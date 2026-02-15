using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetaMystia.Network;
using SgrYuki;

namespace MetaMystia;

[AutoLog]
public static partial class MpManager
{
    public enum ROLE
    {
        Host,
        Client
    }

    #region Const Values
    private const int TCP_PORT = 40815;
    public const long SERVER_ID = 0;
    public const long NOT_CONNECTED_CLIENT_ID = -1;
    private const string SyncActionCommandID = "SyncAction";
    #endregion

    private static INetworkProvider _network;

    #region Multiplayer Related Values
    public static string PlayerId { get; set { field = value; Log.Info($"Player ID set to: {value}"); } } = Environment.MachineName;
    public static string PeerAddress => _network?.PeerAddress ?? "<Unknown>";
    public static string PeerId { get; set; }
    public static long Latency { get; private set; } = 0;

    public static int ConnectedPlayersCount => IsConnected ? 1 : 0;
    public static int AllPlayersCount => ConnectedPlayersCount + 1;  // TODO
    #endregion

    #region Networking
    public static bool IsRunning { get; private set; }
    public static bool IsNetworkServer => _network?.IsServer ?? false;
    public static bool IsNetworkClient => !IsNetworkServer;

    private static bool IsConnecting = false;
    public static bool IsConnected => _network?.IsConnected ?? false;
    public static bool IsConnectedNetworkClient => IsConnected && IsNetworkClient;
    public static bool IsConnectedNetworkServer => IsConnected && IsNetworkServer;
    public static string RoleTag => IsNetworkServer ? "[S]" : "[C]";
    public static string RoleName => IsNetworkServer ? "Host" : "Client";
    #endregion

    #region Game Logic
    public static bool IsHost { get; set; }  // 游戏的逻辑主机标识，如数据生成依照该标识
    public static bool IsConnectedHost => IsConnected && IsHost;
    public static bool IsConnectedClient => IsConnected && !IsHost;
    #endregion

    private static ConcurrentDictionary<int, long> pingSendTimes = new();
    private static int pingSendTimeMaxLength = 100;  // 以防peer始终不回应导致内存泄漏
    public static long TimestampNow => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    public static long TimeOffset = 0L;
    public static long GetSynchronizedTimestampNow => TimestampNow - TimeOffset;
    private static volatile int _pingId = 0;  // pingSendTimes都用Concurrent了，这个也要

    #region SinglePlay GamePlay Getters
    public static Common.UI.Scene LocalScene { get; private set; } = Common.UI.Scene.EmptyScene;
    public static Common.UI.Scene PeerScene = Common.UI.Scene.EmptyScene;
    public static List<string> ActiveDLCLabel => DLCManager.ActiveDLCLabel;
    public static bool InStory => Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Playing || Common.SceneDirector.Instance.playableDirector.state == UnityEngine.Playables.PlayState.Delayed;
    public static bool ShouldSkipAction => !IsConnected || InStory;
    public static bool InputAvailable => Common.UI.UniversalGameManager.IsInputEnabled;

    public static string GameVersion => Common.LoadingSceneManager.VersionData;
    public static string ModVersion => MyPluginInfo.PLUGIN_VERSION;
    public static Language Language => Common.UI.EscapeUtility.EscConfigPannel.CurrentSettings.CurrentLanguage.GetLanguage();

    public const string PeerGetCharacterUnitNotNullCommand = "PeerGetCharacterUnitNotNullCommand";

    #endregion
    #region Multiplayer GamePlay Getters

    public static float MultiplayerTipModifier => AllPlayersCount switch
    {
        1 => 1.0f,  // 4 min = 4 + time pause
        2 => 0.8f,  // 9 min = 7.2
        3 => 0.75f, // 11 min = 8.25
        4 => 0.68f, // 13 min = 8.84
        _ => 0.6f
    };
    public static float MultiplayerFundModifier => AllPlayersCount switch
    {
        1 => 1.0f,  // 4 min = 4 + time pause
        2 => 0.9f,  // 9 min = 8.1
        3 => 0.85f, // 11 min = 9.35
        4 => 0.8f,  // 13 min = 10.4
        _ => 0.7f
    };
    public static int WorkTimeModifier => AllPlayersCount switch
    {
        1 => 4 * 60,
        2 => 9 * 60,
        3 => 11 * 60,
        4 => 13 * 60,
        _ => 15
    };

    #endregion

    public static void Initialize(INetworkProvider networkProvider)
    {
        if (_network != null)
        {
            _network.Connected -= OnNetworkConnected;
            _network.Disconnected -= OnNetworkDisconnected;
            _network.PacketReceived -= OnNetworkPacketReceived;
        }
        _network = networkProvider;
        _network.Connected += OnNetworkConnected;
        _network.Disconnected += OnNetworkDisconnected;
        _network.PacketReceived += OnNetworkPacketReceived;
    }

    public static void SwitchRole(bool stop_existed_server = true)
    {
        if (!IsRunning)
        {
            Log.LogWarning("MpManager is not running.");
            return;
        }
        if (_network == null)
        {
            Log.LogError("Network provider not set.");
            return;
        }

        Log.Message($"Switching role to {(IsNetworkServer ? "Client" : "Host")}");
        if (IsNetworkServer)
        {
            if (IsConnected && !stop_existed_server) return; // 已连接且未要求stop_existed_server
            _network.Stop();
            Log.Message("Switched to client mode. Use ConnectToPeerAsync to connect.");
        }
        else
        {
            // 当前是客户端 -> 切换为主机
            _network.Stop(); // 确保客户端停止
            _network.StartHost(TCP_PORT);
            Log.Message("Switched to host mode. Server started.");
        }
    }

    public static bool Start(ROLE r = ROLE.Host)
    {
        if (!Plugin.AllPatched)
        {
            PluginManager.Console.LogToConsole($"Cannot start multiplayer, patch failure!\n{DumpDebugText()}");
            Log.Fatal($"Cannot start multiplayer, patch failure!\n{DumpDebugText()}");
            return false;
        }

        if (IsRunning)
        {
            Log.LogWarning("MpManager is already running");
            return true;
        }

        if (_network == null)
        {
            Log.LogError("Network provider not set. Call SetNetworkProvider first.");
            return false;
        }

        IsRunning = true;
        PeerId = "<Unknown>";
        Log.Info(DumpDebugText());
        if (r == ROLE.Host)
        {
            _network.StartHost(TCP_PORT);
            Log.LogInfo("Starting MpManager as host");  // 客户端模式由ConnectToPeerAsync负责
        }

        return true;
    }

    public static void Stop()
    {
        if (!IsRunning)
            return;

        Log.LogInfo("Stopping MpManager");
        IsRunning = false;

        try
        {
            _network.Stop();
        }
        catch (Exception e)
        {
            Log.LogError($"Error stopping: {e.Message}");
        }
        Log.LogInfo("MpManager has stopped");
    }

    public static void Initialize()
    {
        Log.LogInfo($"MpManager initialized");
        MystiaManager.Initialize();
        PeerManager.Initialize();
    }

    public static bool Restart()
    {
        Stop();
        return Start(IsNetworkServer? ROLE.Host : ROLE.Client);
    }

    public static async Task<bool> ConnectToPeerAsync(string peerIp, int port = TCP_PORT, bool stop_existed_server = true)
    {
        if (!IsRunning && !Start(ROLE.Client))
        {
            return false;
        }

        if (IsConnected)
        {
            Log.LogWarning("[C] Already connected to a peer. Please disconnect first.");
            return false;
        }

        if (IsConnecting)
        {
            Log.LogWarning("[C] Now try connecting to a peer, please wait..");
            return false;
        }

        try
        {
            IsConnecting = true;
            if (IsNetworkServer)
            {
                SwitchRole(stop_existed_server);
            }
            PluginManager.Console.LogToConsole(TextId.MpConnecting.Get(peerIp, port));
            Log.LogInfo($"[C] Connecting to {peerIp}:{port}...");
            await _network.ConnectAsClientAsync(peerIp, port);  // OnConnect会有事件触发
            if (!_network.IsConnected) throw new Exception("Could not connect to peer");
            Log.LogMessage($"[C] Successfully connected to peer {peerIp}:{port}");

            return true;
        }
        catch (Exception e)
        {
            Log.LogError($"[C] Error connecting to peer: {e.Message}");
            return false;
        }
        finally
        {
            IsConnecting = false;
        }
    }

    private static void OnNetworkConnected(string address)
    {
        // 可以直接访问PeerAddress，留着返回address只是为了兼容性
        OnConnected();
    }

    private static void OnConnected()
    {
        // PeerAddress = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        HelloAction.Send();
        SceneTransitAction.Send(LocalScene);
        IsHost = IsNetworkServer;  // 初始化时与NetworkServer一致
        CommandScheduler.EnqueueInterval(SyncActionCommandID, 0.5f, SyncAction.Send);
        CommandScheduler.EnqueueKey(
            key: PeerGetCharacterUnitNotNullCommand,
            executeWhen: () => PeerManager.GetCharacterUnit() != null,
            execute: () =>
            {
                if (!InStory)
                {
                    PeerManager.EnableCollision(true);
                }
                PeerManager.GetCharacterComponent()?.UpdateIcon(false);
            },
            timeoutSeconds: 120
        );
        CommandScheduler.EnqueueInterval("MpPing", 3f, SendPing);  // 将心跳定时器移到了这里
        Notify.ShowOnMainThread($"联机系统：已连接！");
    }

    private static void OnNetworkDisconnected()
    {
        OnDisconnected();
    }


    private static void OnDisconnected()
    {
        PeerId = "<Unknown>";
        DLCManager.ClearPeer();
        IsHost = false;
        CommandScheduler.EnqueueWithNoCondition(() =>
        {
            if (PeerManager.GetCharacterUnit() != null)
            {
                PeerManager.EnableCollision(false);
                PeerManager.GetCharacterComponent()?.UpdateIcon(true);
            }
        });
        CommandScheduler.RemoveKeyFromKeyQueue(PeerGetCharacterUnitNotNullCommand);
        CommandScheduler.CancelInterval(SyncActionCommandID);
        CommandScheduler.CancelInterval("MpPing");
        Notify.ShowOnMainThread($"联机系统：连接已断开！");
    }

    private static void OnNetworkPacketReceived(NetPacket packet)
    {
        foreach (var action in packet.Actions)
        {
            action?.OnReceived();
        }
    }

    public static void SendToHostOrBroadcast(NetPacket packet)
    {
        _network?.Send(packet);
    }

    public static void SendToPeer(NetPacket packet)
    {
        _network?.Send(packet);
    }

    public static void DisconnectPeer()
    {
        if (!IsConnected) return;
        _network?.Disconnect();
        Log.LogMessage("Peer connection disconnected");
    }

    /// <summary>
    /// Peer A -> Ping -> Peer B
    /// Peer A <- Pong <- Peer B
    /// Peer A calculates latency
    /// </summary>
    public static void SendPing()
    {
        if (!IsConnected) return;
        if (pingSendTimes.Count >= pingSendTimeMaxLength)
        {
            // 移除最旧的 Ping 记录（键最小，即最早发送的 Ping）
            var oldestKey = pingSendTimes.Keys.Min();
            pingSendTimes.TryRemove(oldestKey, out _);
        }
        var t = TimestampNow;
        int id = Interlocked.Increment(ref _pingId);
        pingSendTimes[id] = t;
        PingAction.SendToPeer(0, id);
    }

    public static void UpdateLatency(int id)
    {
        if (!pingSendTimes.TryRemove(id, out long t)) return;
        Latency = (TimestampNow - t) / 2;
    }

    public static string GetStatus()
    {
        StringBuilder status = new();
        status.AppendLine($"Mystia ID: {PlayerId}");
        status.AppendLine($"Local Port: {TCP_PORT}");
        status.AppendLine($"Running: {(IsRunning ? "Yes" : "No")}");
        status.AppendLine($"Connected: {(IsConnected ? "Yes" : "No")}");
        if (!IsConnected) return status.ToString();
        status.AppendLine($"Kyouko ID: {PeerId}");
        status.AppendLine($"Kyouko Address: {PeerAddress ?? "<Unknown>"}");
        status.AppendLine($"Latency: {Latency} ms");
        status.AppendLine("");
        status.AppendLine($"Is Logic Host: {(IsHost ? "Yes" : "No")}");

        return status.ToString();
    }

    public static string GetBriefStatus()
    {
        if (!Plugin.AllPatched)
        {
            return "Patch failure!!! The game will not function normally! Please remove the mod or contact mod developer!";
        }
        if (!IsRunning)
        {
            return "Multiplayer: Off";
        }
        if (IsConnected)
        {
            return $"Multiplayer: {RoleTag} Connected to {PeerId} ({PeerAddress}), ping: {Latency} ms {(IsHost?"[Logic Host]":"")}";
        }
        else
        {
            return $"Multiplayer: On (Not connected) as {RoleName}";
        }
    }

    public static string DumpDebugText()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{DateTimeOffset.Now}, {System.Runtime.InteropServices.RuntimeInformation.OSDescription}, {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}");
        sb.AppendLine($"{GameVersion}, {PluginManager.Label}");
        sb.AppendLine(GetBriefStatus());
        sb.AppendLine($"DLC: {string.Join(", ", ActiveDLCLabel)}");
        return sb.ToString();
    }

    public static void OnSceneTransit(Common.UI.Scene newScene)
    {
        Log.Message($"LocalScene transit from {LocalScene} -> {newScene}");
        SceneTransitAction.Send(newScene);
        LocalScene = newScene;
        if (newScene == Common.UI.Scene.MainScene && IsConnected)
        {
            Log.Message($"Transit to {newScene}, disconnecting peer");
            DisconnectPeer();
        }
    }

    public static void DayOver(long clientId)
    {
        if (!IsConnectedHost) return;
        Log.Message($"{PeerId} dayover");
        if (PeerManager.IsDayOver && MystiaManager.IsDayOver)
        {
            if (IsConnectedNetworkServer)
            {
                ReadyAction.Broadcast(ReadyType.DayOver);
            }
            else
            {
                ReadyAction.Send(ReadyType.DayOver);  // 仅为逻辑主机时服务器接管all ready状态
            }


            // For host who will not receive DayOver allready
            CommandScheduler.EnqueueWithNoCondition(() => Dialog.ShowReadyDialog(true, DaySceneManagerPatch.OnDayOver));
        }
    }

    public static void PrepOver(long clientId)
    {
        if (!IsConnectedHost) return;
        Log.Message($"{PeerId} prep over");

        if (PeerManager.IsPrepOver && MystiaManager.IsPrepOver)
        {
            if (IsConnectedNetworkServer)
            {
                ReadyAction.Broadcast(ReadyType.PrepOver);
            }
            else
            {
                ReadyAction.Send(ReadyType.PrepOver);  // 仅为逻辑主机时服务器接管all ready状态
            }

            // For host who will not receive PrepOver allready
            CommandScheduler.EnqueueWithNoCondition(IzakayaConfigPannelPatch.PrepOver);
        }
    }
}
