using MemoryPack;

using MetaMystia.Patch;
using SgrYuki;

namespace MetaMystia.Network;

/// <summary>主机 → 全体玩家：确认备菜阶段全员就绪，客机收到后推进场景。</summary>
[MemoryPackable]
[AutoLog]
public partial class PrepAllReadyAction : Action
{
    [CheckScene(Common.UI.Scene.IzakayaPrepScene)]
    public override void OnReceivedDerived()
    {
        if (SenderUid != MpConstants.HostUid)
        {
            Log.LogWarning($"PrepAllReady from non-host uid={SenderUid}, ignoring");
            return;
        }

        IzakayaConfigPannelPatch.PrepOver();
    }

    public static void Broadcast()
    {
        if (!MpManager.IsRoomHost) return;
        new PrepAllReadyAction().Send();
    }
}
