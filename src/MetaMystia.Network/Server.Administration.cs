using System.Threading.Channels;

namespace MetaMystia.Network;

public enum ServerCommand { Kick, Leave, MaxPlayers }
public sealed record ServerPlayer(int Uid, string Name, ushort Room);
public sealed record ServerStatus(int MaxPlayers, ServerPlayer[] Players, RoomSummary[] Rooms);

public sealed partial class Server
{
    public async Task<ServerStatus> GetStatusAsync()
    {
        if (Volatile.Read(ref stopping) != 0 || Volatile.Read(ref started) == 0) throw new InvalidOperationException("Not running");
        var result = new TaskCompletionSource<ServerStatus>(TaskCreationOptions.RunContinuationsAsynchronously);
        await events.Writer.WriteAsync(() => result.TrySetResult(new(maxPlayers,
            peers.Where(p => p.Player != null).Select(p => new ServerPlayer(p.Player!.Uid, p.Player.Name, p.Room)).ToArray(),
            Capture(null).Rooms))).ConfigureAwait(false);
        return await result.Task.ConfigureAwait(false);
    }

    /// <summary>独立服务端的本地管理入口，与网络消息在同一队列执行。</summary>
    public async Task<NetworkErrorCode> ManageAsync(ServerCommand command, int value)
    {
        if (options.LanKey != null) throw new InvalidOperationException("Standalone server only");
        if (Volatile.Read(ref stopping) != 0 || Volatile.Read(ref started) == 0) return NetworkErrorCode.ServerStopped;
        var result = new TaskCompletionSource<NetworkErrorCode>(TaskCreationOptions.RunContinuationsAsynchronously);
        try
        {
            await events.Writer.WriteAsync(() =>
            {
                var error = Volatile.Read(ref stopping) != 0 ? NetworkErrorCode.ServerStopped : Manage(command, value);
                Log(ServerLogLevel.Info, $"管理员操作 command={command} value={value}，结果={error}");
                result.TrySetResult(error);
            }).ConfigureAwait(false);
        }
        catch (ChannelClosedException) { return NetworkErrorCode.ServerStopped; }
        return await result.Task.ConfigureAwait(false);
    }

    private NetworkErrorCode Manage(ServerCommand command, int value)
    {
        if (command == ServerCommand.MaxPlayers)
        {
            if (value < 1 || value > 256) return NetworkErrorCode.InvalidLimit;
            maxPlayers = value;
            Publish();
            return NetworkErrorCode.None;
        }
        if (command is not (ServerCommand.Kick or ServerCommand.Leave)) return NetworkErrorCode.InvalidMessage;
        var peer = peers.FirstOrDefault(p => p.Player?.Uid == value && !p.Rejected);
        if (peer == null) return NetworkErrorCode.PlayerMissing;
        if (command == ServerCommand.Leave)
        {
            if (peer.Room == 0) return NetworkErrorCode.NotInRoom;
            Leave(peer);
            Publish();
        }
        else
        {
            Reject(peer, NetworkErrorCode.KickedByServer);
            Remove(peer, NetworkErrorCode.KickedByServer);
        }
        return NetworkErrorCode.None;
    }

    private void Log(ServerLogLevel level, string message)
    {
        try { Logged?.Invoke(new(level, message)); }
        catch (Exception e) { try { CallbackError?.Invoke(e); } catch { } }
    }
}
