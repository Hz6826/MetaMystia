
using HarmonyLib;

using DayScene.UI;
using GameData.Core.Collections.DaySceneUtility;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility;

namespace MetaMystia.Patch;

[HarmonyPatch(typeof(DayScene.UI.DaySceneChatSelectionPannel.__c__DisplayClass17_0))]
[AutoLog]
public partial class DaySceneChatSelectionPannel__c__DisplayClass17_0Patch
{
    [HarmonyPatch(nameof(DaySceneChatSelectionPannel.__c__DisplayClass17_0.Method_Internal_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_PDM_0))]
    [HarmonyPostfix]
    public static void AddFreeChatSelection_Postfix(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, ref bool availability)
    {
        var stringId = specialNPCInteractData.characterLabel;
        if (!availability && stringId.IsResourceExSpecialMerchant() && RunTimeDayScene.HasChatData(stringId))
        {
            // availability == false 且 目标角色为 Ex Special Merchant 时
            // 根据需要判定是否应当移除 MerchantData 对 FreeChat 的屏蔽，即为 Ex Special Merchant 追加 FreeChat
            int npcId = RunTimeAlbum.RefSpecialNPCId(stringId);
            availability = DataBaseDay.DaySceneCheckSpecialGuestNotSkipGreeting(npcId);
        }
    }
}