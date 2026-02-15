using MemoryPack;
using UnityEngine;

namespace MetaMystia.Network;

public enum ChangeType
{
    GRANT,
    REVOKE
}

[MemoryPackable]
public partial class ChangeHostRoleAction : Action
{
    public override ActionType Type => ActionType.CHANGE_HOST_ROLE;

    public ChangeType ChangeType;

    public override void OnReceivedDerived()
    {
        MpManager.IsHost = ChangeType switch
        {
            ChangeType.GRANT => true,
            ChangeType.REVOKE => false,
            _ => MpManager.IsHost
        };
    }

    public static void Send(ChangeType changeType)  // 暂时不想让游戏本身发送该包，如果有需求可以补全
    {
        var action = new ChangeHostRoleAction { ChangeType = changeType };
        action.SendToHostOrBroadcast();
    }
}
