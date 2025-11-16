using System;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000365 RID: 869
	public class ReceivedObjectDisplayerController : MonoSingleton<ReceivedObjectDisplayerController>
	{
		// Token: 0x06006661 RID: 26209 RVA: 0x001F45F8 File Offset: 0x001F27F8
		// Note: this type is marked as 'beforefieldinit'.
		static ReceivedObjectDisplayerController()
		{
			Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ReceivedObjectDisplayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr);
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_IZAKAYA_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_IZAKAYA_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_PARTNER_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_PARTNER_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_RECIPE_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_RECIPE_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_ADD_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_FUND_ADD_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_LOST_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_FUND_LOST_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_DECORATION_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_DECORATION_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_MAP_UNLOCK_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_MAP_UNLOCK_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_TROPHY_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_TROPHY_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_COOKER_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "RECIEVE_COOKER_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_FOODTAG_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_UPDATE_FOODTAG_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_HATEFOODTAG_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_UPDATE_HATEFOODTAG_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_BEVTAG_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_UPDATE_BEVTAG_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_IZAKAYA_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_UPDATE_IZAKAYA_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_WRITE_MORE_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_WRITE_MORE_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPGRATE_KIZUNA_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "ALBUM_UPGRATE_KIZUNA_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "LEVEL_UP_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_PROPERTIES_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "LEVEL_UP_PROPERTIES_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_START_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "MISSION_START_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_FINISH_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "MISSION_FINISH_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_SPELL_DECALARATION_KWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "SPELL_DECALARATION_KWD");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "spriteMessageParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "badgeMessageParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeWithoutCountMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "badgeWithoutCountMessageParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "textMessageParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageCountParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "spriteMessageCountParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageCountParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "textMessageCountParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "recievedMessagePositionIndicatorParent");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "recievedObjectField");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "recievedObjectLayoutField");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_flexibleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "flexibleRect");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_onNotify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "onNotify");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageStayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "messageStayDuration");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "messageInsertionAdjustmentDuration");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_burstMessageFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "burstMessageFrameOffset");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_maxMessageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "maxMessageCount");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_currentVelocityBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "currentVelocityBuffer");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "executionQueue");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_CustomSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "m_CustomSpacing");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_WorldPositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "m_WorldPositionBuffer");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_registeredObjectCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "registeredObjectCollection");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_releaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "releaseHandle");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "executionCoroutine");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_RefreshRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "m_RefreshRequested");
			ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_UnBindCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "m_UnBindCallback");
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_set_FlexibleSpaceHeight_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684728);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684729);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684730);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684731);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryRegisterCustomSpacing_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684732);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryRemoveCustomSpacing_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684733);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryUpdateMetrics_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684734);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_UpdateMetrics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684735);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_UpdateMetricsImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684736);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTextMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684737);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyCommonPhraseUpdate_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684738);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestSpawnInNight_Public_Void_String_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684739);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyObjectLanguageBase_Public_Void_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684740);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySellableLanguageBase_Public_Void_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684741);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeLanguageBase_Public_Void_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684742);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684743);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684744);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684745);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpell_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684746);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTrophy_Private_Void_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684747);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyIzakaya_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684748);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyPartner_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684749);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyCooker_Private_Void_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684750);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyRecipe_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684751);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTagUpdate_Private_Void_ValueTuple_4_Int32_SellableType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684752);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyIzakayaUpdate_Private_Void_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684753);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestNewInfo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684754);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestUpgrateKizunaLevel_Private_Void_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684755);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyFund_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684756);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyDecoration_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684757);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpriteMessage_Private_Void_Sprite_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684758);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyLevelMessage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684759);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMissionStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684760);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMissionFinish_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684761);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpriteCountMessage_Private_Void_Sprite_String_Int32_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684762);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeCountMessage_Private_Void_Sprite_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684763);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountMessage_Private_Void_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684764);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTextCountMessage_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684765);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_BindDayScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684766);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_BindWorkScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684767);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684768);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684769);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684770);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetCount_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684771);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetSpriteMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684772);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetBadgeMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684773);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetBadgeWithoutCountMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684774);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTextMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684775);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetSpriteMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684776);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTextMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684777);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684778);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684779);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684780);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684781);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684782);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684783);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684784);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_byref___c__DisplayClass78_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684785);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr__BindDayScene_b__85_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684786);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr__BindWorkScene_b__86_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684787);
			ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, 100684788);
		}

		// Token: 0x1700234E RID: 9038
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x001F4E84 File Offset: 0x001F3084
		public unsafe float FlexibleSpaceHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263814, XrefRangeEnd = 263817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_set_FlexibleSpaceHeight_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x001F4EC4 File Offset: 0x001F30C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263817, XrefRangeEnd = 263845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x001F4EF8 File Offset: 0x001F30F8
		[CallerCount(0)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x001F4F2C File Offset: 0x001F312C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263850, RefRangeEnd = 263852, XrefRangeStart = 263845, XrefRangeEnd = 263850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x001F4F60 File Offset: 0x001F3160
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 263868, RefRangeEnd = 263874, XrefRangeStart = 263852, XrefRangeEnd = 263868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRegisterCustomSpacing<T>(RectTransform rect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.MethodInfoStoreGeneric_TryRegisterCustomSpacing_Public_Static_Void_RectTransform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x001F4F98 File Offset: 0x001F3198
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 263890, RefRangeEnd = 263897, XrefRangeStart = 263874, XrefRangeEnd = 263890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRemoveCustomSpacing<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.MethodInfoStoreGeneric_TryRemoveCustomSpacing_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x001F4FC0 File Offset: 0x001F31C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263903, RefRangeEnd = 263904, XrefRangeStart = 263897, XrefRangeEnd = 263903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryUpdateMetrics()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryUpdateMetrics_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x001F4FE8 File Offset: 0x001F31E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263904, RefRangeEnd = 263906, XrefRangeStart = 263904, XrefRangeEnd = 263904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_UpdateMetrics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x001F501C File Offset: 0x001F321C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263934, RefRangeEnd = 263936, XrefRangeStart = 263906, XrefRangeEnd = 263934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMetricsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_UpdateMetricsImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x001F5050 File Offset: 0x001F3250
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 263953, RefRangeEnd = 263988, XrefRangeStart = 263936, XrefRangeEnd = 263953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTextMessage(string content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTextMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x001F5094 File Offset: 0x001F3294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263990, RefRangeEnd = 263992, XrefRangeStart = 263988, XrefRangeEnd = 263990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyCommonPhraseUpdate(string titleKeyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(titleKeyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyCommonPhraseUpdate_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x001F50D8 File Offset: 0x001F32D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264092, RefRangeEnd = 264096, XrefRangeStart = 263992, XrefRangeEnd = 264092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpecialGuestSpawnInNight(string characterLabel, bool targetIzakaya = false, Il2CppStructArray<int> spawnIzakaya = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetIzakaya;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnIzakaya);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestSpawnInNight_Public_Void_String_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x001F513C File Offset: 0x001F333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264096, XrefRangeEnd = 264098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyObjectLanguageBase(ObjectLanguageBase objectLanguageBase, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectLanguageBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyObjectLanguageBase_Public_Void_ObjectLanguageBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x001F518C File Offset: 0x001F338C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264104, RefRangeEnd = 264105, XrefRangeStart = 264098, XrefRangeEnd = 264104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySellableLanguageBase(Sellable sellable, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySellableLanguageBase_Public_Void_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x001F51DC File Offset: 0x001F33DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264105, XrefRangeEnd = 264126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBadgeLanguageBase(ObjectLanguageBase objectLanguageBase, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectLanguageBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeLanguageBase_Public_Void_ObjectLanguageBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x001F522C File Offset: 0x001F342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264126, XrefRangeEnd = 264129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBadgeWithoutCountLanguageBase(ObjectLanguageBase objectLanguageBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectLanguageBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x001F5270 File Offset: 0x001F3470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264130, RefRangeEnd = 264131, XrefRangeStart = 264129, XrefRangeEnd = 264130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBadgeWithoutCountLanguageBase(Sprite badgeSprite, string textName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(badgeSprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x001F52C4 File Offset: 0x001F34C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264141, RefRangeEnd = 264142, XrefRangeStart = 264131, XrefRangeEnd = 264141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMap(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x001F5308 File Offset: 0x001F3508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264146, RefRangeEnd = 264147, XrefRangeStart = 264142, XrefRangeEnd = 264146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpell(string characterName, string spellName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spellName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpell_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x001F535C File Offset: 0x001F355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264147, XrefRangeEnd = 264155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTrophy(ObjectLanguageBase objectLanguageBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectLanguageBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTrophy_Private_Void_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x001F53A0 File Offset: 0x001F35A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264155, XrefRangeEnd = 264165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyIzakaya(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyIzakaya_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x001F53E0 File Offset: 0x001F35E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264165, XrefRangeEnd = 264175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPartner(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyPartner_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x001F5420 File Offset: 0x001F3620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264175, XrefRangeEnd = 264183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyCooker(ValueTuple<ObjectLanguageBase, Sprite> objectLanguageBase, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(objectLanguageBase));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyCooker_Private_Void_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x001F5478 File Offset: 0x001F3678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264183, XrefRangeEnd = 264194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyRecipe(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyRecipe_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x001F54B8 File Offset: 0x001F36B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264194, XrefRangeEnd = 264212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTagUpdate(ValueTuple<int, Sellable.SellableType, bool, int> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTagUpdate_Private_Void_ValueTuple_4_Int32_SellableType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x001F5500 File Offset: 0x001F3700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264212, XrefRangeEnd = 264222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyIzakayaUpdate(ValueTuple<int, int> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyIzakayaUpdate_Private_Void_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x001F5548 File Offset: 0x001F3748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264222, XrefRangeEnd = 264232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpecialGuestNewInfo(int characterId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestNewInfo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x001F5588 File Offset: 0x001F3788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264232, XrefRangeEnd = 264239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpecialGuestUpgrateKizunaLevel(ValueTuple<int, int> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpecialGuestUpgrateKizunaLevel_Private_Void_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x001F55D0 File Offset: 0x001F37D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264239, XrefRangeEnd = 264245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyFund(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyFund_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x001F5610 File Offset: 0x001F3810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264245, XrefRangeEnd = 264256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDecoration(int itemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyDecoration_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x001F5650 File Offset: 0x001F3850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264275, RefRangeEnd = 264277, XrefRangeStart = 264256, XrefRangeEnd = 264275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpriteMessage(Sprite sprite, string name, Sprite bg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpriteMessage_Private_Void_Sprite_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x001F56B8 File Offset: 0x001F38B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264277, XrefRangeEnd = 264595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyLevelMessage(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyLevelMessage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x001F56F8 File Offset: 0x001F38F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264595, XrefRangeEnd = 264603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMissionStart(string missionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(missionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMissionStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x001F573C File Offset: 0x001F393C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264603, XrefRangeEnd = 264611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyMissionFinish(string missionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(missionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyMissionFinish_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x001F5780 File Offset: 0x001F3980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264632, RefRangeEnd = 264635, XrefRangeStart = 264611, XrefRangeEnd = 264632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySpriteCountMessage(Sprite sprite, string name, int count, Sprite bg, bool addModify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bg);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addModify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifySpriteCountMessage_Private_Void_Sprite_String_Int32_Sprite_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x001F5804 File Offset: 0x001F3A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264635, XrefRangeEnd = 264655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBadgeCountMessage(Sprite sprite, string name, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeCountMessage_Private_Void_Sprite_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x001F5868 File Offset: 0x001F3A68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264673, RefRangeEnd = 264675, XrefRangeStart = 264655, XrefRangeEnd = 264673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBadgeWithoutCountMessage(Sprite sprite, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyBadgeWithoutCountMessage_Private_Void_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x001F58BC File Offset: 0x001F3ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264694, RefRangeEnd = 264695, XrefRangeStart = 264675, XrefRangeEnd = 264694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTextCountMessage(string content, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyTextCountMessage_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x001F590C File Offset: 0x001F3B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264865, RefRangeEnd = 264866, XrefRangeStart = 264695, XrefRangeEnd = 264865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindDayScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_BindDayScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x001F5940 File Offset: 0x001F3B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265009, RefRangeEnd = 265010, XrefRangeStart = 264866, XrefRangeEnd = 265009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindWorkScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_BindWorkScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x001F5974 File Offset: 0x001F3B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitleKWD(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001F59BC File Offset: 0x001F3BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265010, XrefRangeEnd = 265015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitleKWD(string key, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x001F5A18 File Offset: 0x001F3C18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265023, RefRangeEnd = 265029, XrefRangeStart = 265015, XrefRangeEnd = 265023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTitleKWD(string key, string data1, string data2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x001F5A84 File Offset: 0x001F3C84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265040, RefRangeEnd = 265044, XrefRangeStart = 265029, XrefRangeEnd = 265040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetCount_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x001F5AC8 File Offset: 0x001F3CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265044, XrefRangeEnd = 265045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetSpriteMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetSpriteMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x001F5B00 File Offset: 0x001F3D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265045, XrefRangeEnd = 265046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetBadgeMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetBadgeMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x001F5B38 File Offset: 0x001F3D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265046, XrefRangeEnd = 265047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetBadgeWithoutCountMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetBadgeWithoutCountMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x001F5B70 File Offset: 0x001F3D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265047, XrefRangeEnd = 265048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetTextMessageInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTextMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x001F5BA8 File Offset: 0x001F3DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265048, XrefRangeEnd = 265049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetSpriteMessageCountInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetSpriteMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x001F5BE0 File Offset: 0x001F3DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265049, XrefRangeEnd = 265050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetTextMessageCountInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetTextMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x001F5C18 File Offset: 0x001F3E18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265064, RefRangeEnd = 265070, XrefRangeStart = 265050, XrefRangeEnd = 265064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UIElementCluster, GameObject> GetInstanceInternal(GameObject parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UIElementCluster, GameObject>(pointer);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x001F5C60 File Offset: 0x001F3E60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 265077, RefRangeEnd = 265084, XrefRangeStart = 265070, XrefRangeEnd = 265077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryExecuteNotify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x001F5C94 File Offset: 0x001F3E94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265115, RefRangeEnd = 265121, XrefRangeStart = 265084, XrefRangeEnd = 265115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDataInternal(Func<ValueTuple<UIElementCluster, GameObject>> objectGenerator, Action<UIElementCluster> dataProcessor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGenerator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataProcessor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x001F5CE8 File Offset: 0x001F3EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265121, XrefRangeEnd = 265162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceivedObjectDisplayerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x001F5D24 File Offset: 0x001F3F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265162, XrefRangeEnd = 265167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Single_PDM_0(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x001F5D5C File Offset: 0x001F3F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265167, XrefRangeEnd = 265172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Single_PDM_1(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x001F5D94 File Offset: 0x001F3F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265172, XrefRangeEnd = 265176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Single_PDM_2(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_2, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x001F5DCC File Offset: 0x001F3FCC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 265183, RefRangeEnd = 265199, XrefRangeStart = 265176, XrefRangeEnd = 265183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_byref___c__DisplayClass78_0_0(Func<DataBaseCore.LevelProperties, float> getValueCallback, string property, Func<float, string> overrideToStringCallback, ref ReceivedObjectDisplayerController.__c__DisplayClass78_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getValueCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideToStringCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_byref___c__DisplayClass78_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x001F5E48 File Offset: 0x001F4048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265199, XrefRangeEnd = 265281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BindDayScene_b__85_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr__BindDayScene_b__85_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x001F5E7C File Offset: 0x001F407C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265281, XrefRangeEnd = 265349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BindWorkScene_b__86_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr__BindWorkScene_b__86_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x001F5EB0 File Offset: 0x001F40B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265349, XrefRangeEnd = 265354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x000374F0 File Offset: 0x000356F0
		public ReceivedObjectDisplayerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x001F5EF0 File Offset: 0x001F40F0
		// (set) Token: 0x060066A1 RID: 26273 RVA: 0x000374F9 File Offset: 0x000356F9
		public unsafe static string RECIEVE_IZAKAYA_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_IZAKAYA_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_IZAKAYA_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x001F5F10 File Offset: 0x001F4110
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x0003750B File Offset: 0x0003570B
		public unsafe static string RECIEVE_PARTNER_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_PARTNER_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_PARTNER_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x001F5F30 File Offset: 0x001F4130
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x0003751D File Offset: 0x0003571D
		public unsafe static string RECIEVE_RECIPE_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_RECIPE_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_RECIPE_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x001F5F50 File Offset: 0x001F4150
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x0003752F File Offset: 0x0003572F
		public unsafe static string RECIEVE_FUND_ADD_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_ADD_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_ADD_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x001F5F70 File Offset: 0x001F4170
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00037541 File Offset: 0x00035741
		public unsafe static string RECIEVE_FUND_LOST_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_LOST_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_FUND_LOST_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x001F5F90 File Offset: 0x001F4190
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x00037553 File Offset: 0x00035753
		public unsafe static string RECIEVE_DECORATION_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_DECORATION_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_DECORATION_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x001F5FB0 File Offset: 0x001F41B0
		// (set) Token: 0x060066AD RID: 26285 RVA: 0x00037565 File Offset: 0x00035765
		public unsafe static string RECIEVE_MAP_UNLOCK_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_MAP_UNLOCK_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_MAP_UNLOCK_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060066AE RID: 26286 RVA: 0x001F5FD0 File Offset: 0x001F41D0
		// (set) Token: 0x060066AF RID: 26287 RVA: 0x00037577 File Offset: 0x00035777
		public unsafe static string RECIEVE_TROPHY_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_TROPHY_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_TROPHY_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x001F5FF0 File Offset: 0x001F41F0
		// (set) Token: 0x060066B1 RID: 26289 RVA: 0x00037589 File Offset: 0x00035789
		public unsafe static string RECIEVE_COOKER_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_COOKER_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_RECIEVE_COOKER_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x060066B2 RID: 26290 RVA: 0x001F6010 File Offset: 0x001F4210
		// (set) Token: 0x060066B3 RID: 26291 RVA: 0x0003759B File Offset: 0x0003579B
		public unsafe static string ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x001F6030 File Offset: 0x001F4230
		// (set) Token: 0x060066B5 RID: 26293 RVA: 0x000375AD File Offset: 0x000357AD
		public unsafe static string ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x060066B6 RID: 26294 RVA: 0x001F6050 File Offset: 0x001F4250
		// (set) Token: 0x060066B7 RID: 26295 RVA: 0x000375BF File Offset: 0x000357BF
		public unsafe static string ALBUM_UPDATE_FOODTAG_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_FOODTAG_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_FOODTAG_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x060066B8 RID: 26296 RVA: 0x001F6070 File Offset: 0x001F4270
		// (set) Token: 0x060066B9 RID: 26297 RVA: 0x000375D1 File Offset: 0x000357D1
		public unsafe static string ALBUM_UPDATE_HATEFOODTAG_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_HATEFOODTAG_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_HATEFOODTAG_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x060066BA RID: 26298 RVA: 0x001F6090 File Offset: 0x001F4290
		// (set) Token: 0x060066BB RID: 26299 RVA: 0x000375E3 File Offset: 0x000357E3
		public unsafe static string ALBUM_UPDATE_BEVTAG_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_BEVTAG_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_BEVTAG_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x060066BC RID: 26300 RVA: 0x001F60B0 File Offset: 0x001F42B0
		// (set) Token: 0x060066BD RID: 26301 RVA: 0x000375F5 File Offset: 0x000357F5
		public unsafe static string ALBUM_UPDATE_IZAKAYA_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_IZAKAYA_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPDATE_IZAKAYA_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x001F60D0 File Offset: 0x001F42D0
		// (set) Token: 0x060066BF RID: 26303 RVA: 0x00037607 File Offset: 0x00035807
		public unsafe static string ALBUM_WRITE_MORE_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_WRITE_MORE_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_WRITE_MORE_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x001F60F0 File Offset: 0x001F42F0
		// (set) Token: 0x060066C1 RID: 26305 RVA: 0x00037619 File Offset: 0x00035819
		public unsafe static string ALBUM_UPGRATE_KIZUNA_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPGRATE_KIZUNA_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_ALBUM_UPGRATE_KIZUNA_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x060066C2 RID: 26306 RVA: 0x001F6110 File Offset: 0x001F4310
		// (set) Token: 0x060066C3 RID: 26307 RVA: 0x0003762B File Offset: 0x0003582B
		public unsafe static string LEVEL_UP_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x060066C4 RID: 26308 RVA: 0x001F6130 File Offset: 0x001F4330
		// (set) Token: 0x060066C5 RID: 26309 RVA: 0x0003763D File Offset: 0x0003583D
		public unsafe static string LEVEL_UP_PROPERTIES_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_PROPERTIES_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_LEVEL_UP_PROPERTIES_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x060066C6 RID: 26310 RVA: 0x001F6150 File Offset: 0x001F4350
		// (set) Token: 0x060066C7 RID: 26311 RVA: 0x0003764F File Offset: 0x0003584F
		public unsafe static string MISSION_START_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_START_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_START_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x001F6170 File Offset: 0x001F4370
		// (set) Token: 0x060066C9 RID: 26313 RVA: 0x00037661 File Offset: 0x00035861
		public unsafe static string MISSION_FINISH_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_FINISH_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_MISSION_FINISH_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x060066CA RID: 26314 RVA: 0x001F6190 File Offset: 0x001F4390
		// (set) Token: 0x060066CB RID: 26315 RVA: 0x00037673 File Offset: 0x00035873
		public unsafe static string SPELL_DECALARATION_KWD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_SPELL_DECALARATION_KWD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.NativeFieldInfoPtr_SPELL_DECALARATION_KWD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x060066CC RID: 26316 RVA: 0x001F61B0 File Offset: 0x001F43B0
		// (set) Token: 0x060066CD RID: 26317 RVA: 0x00037685 File Offset: 0x00035885
		public unsafe GameObject spriteMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x060066CE RID: 26318 RVA: 0x001F61E0 File Offset: 0x001F43E0
		// (set) Token: 0x060066CF RID: 26319 RVA: 0x000376A4 File Offset: 0x000358A4
		public unsafe GameObject badgeMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x060066D0 RID: 26320 RVA: 0x001F6210 File Offset: 0x001F4410
		// (set) Token: 0x060066D1 RID: 26321 RVA: 0x000376C3 File Offset: 0x000358C3
		public unsafe GameObject badgeWithoutCountMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeWithoutCountMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_badgeWithoutCountMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x060066D2 RID: 26322 RVA: 0x001F6240 File Offset: 0x001F4440
		// (set) Token: 0x060066D3 RID: 26323 RVA: 0x000376E2 File Offset: 0x000358E2
		public unsafe GameObject textMessageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x060066D4 RID: 26324 RVA: 0x001F6270 File Offset: 0x001F4470
		// (set) Token: 0x060066D5 RID: 26325 RVA: 0x00037701 File Offset: 0x00035901
		public unsafe GameObject spriteMessageCountParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageCountParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_spriteMessageCountParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x001F62A0 File Offset: 0x001F44A0
		// (set) Token: 0x060066D7 RID: 26327 RVA: 0x00037720 File Offset: 0x00035920
		public unsafe GameObject textMessageCountParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageCountParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_textMessageCountParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x060066D8 RID: 26328 RVA: 0x001F62D0 File Offset: 0x001F44D0
		// (set) Token: 0x060066D9 RID: 26329 RVA: 0x0003773F File Offset: 0x0003593F
		public unsafe GameObject recievedMessagePositionIndicatorParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedMessagePositionIndicatorParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x060066DA RID: 26330 RVA: 0x001F6300 File Offset: 0x001F4500
		// (set) Token: 0x060066DB RID: 26331 RVA: 0x0003775E File Offset: 0x0003595E
		public unsafe RectTransform recievedObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x001F6330 File Offset: 0x001F4530
		// (set) Token: 0x060066DD RID: 26333 RVA: 0x0003777D File Offset: 0x0003597D
		public unsafe RectTransform recievedObjectLayoutField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_recievedObjectLayoutField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x001F6360 File Offset: 0x001F4560
		// (set) Token: 0x060066DF RID: 26335 RVA: 0x0003779C File Offset: 0x0003599C
		public unsafe RectTransform flexibleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_flexibleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_flexibleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x060066E0 RID: 26336 RVA: 0x001F6390 File Offset: 0x001F4590
		// (set) Token: 0x060066E1 RID: 26337 RVA: 0x000377BB File Offset: 0x000359BB
		public unsafe AudioClip onNotify
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_onNotify);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_onNotify), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x060066E2 RID: 26338 RVA: 0x001F63C0 File Offset: 0x001F45C0
		// (set) Token: 0x060066E3 RID: 26339 RVA: 0x000377DA File Offset: 0x000359DA
		public unsafe float messageStayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageStayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageStayDuration)) = value;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x001F63E8 File Offset: 0x001F45E8
		// (set) Token: 0x060066E5 RID: 26341 RVA: 0x000377F5 File Offset: 0x000359F5
		public unsafe float messageInsertionAdjustmentDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_messageInsertionAdjustmentDuration)) = value;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x001F6410 File Offset: 0x001F4610
		// (set) Token: 0x060066E7 RID: 26343 RVA: 0x00037810 File Offset: 0x00035A10
		public unsafe int burstMessageFrameOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_burstMessageFrameOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_burstMessageFrameOffset)) = value;
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x001F6438 File Offset: 0x001F4638
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x0003782B File Offset: 0x00035A2B
		public unsafe int maxMessageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_maxMessageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_maxMessageCount)) = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x001F6460 File Offset: 0x001F4660
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x00037846 File Offset: 0x00035A46
		public unsafe Dictionary<UIElementCluster, Vector3> currentVelocityBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_currentVelocityBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UIElementCluster, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_currentVelocityBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x001F6490 File Offset: 0x001F4690
		// (set) Token: 0x060066ED RID: 26349 RVA: 0x00037865 File Offset: 0x00035A65
		public unsafe Queue<Action> executionQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x001F64C0 File Offset: 0x001F46C0
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x00037884 File Offset: 0x00035A84
		public unsafe Dictionary<Type, RectTransform> m_CustomSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_CustomSpacing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_CustomSpacing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x001F64F0 File Offset: 0x001F46F0
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x000378A3 File Offset: 0x00035AA3
		public unsafe Il2CppStructArray<Vector3> m_WorldPositionBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_WorldPositionBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_WorldPositionBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x060066F2 RID: 26354 RVA: 0x001F6520 File Offset: 0x001F4720
		// (set) Token: 0x060066F3 RID: 26355 RVA: 0x000378C2 File Offset: 0x00035AC2
		public unsafe HashSet<ValueTuple<UIElementCluster, GameObject>> registeredObjectCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_registeredObjectCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ValueTuple<UIElementCluster, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_registeredObjectCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x060066F4 RID: 26356 RVA: 0x001F6550 File Offset: 0x001F4750
		// (set) Token: 0x060066F5 RID: 26357 RVA: 0x000378E1 File Offset: 0x00035AE1
		public unsafe Queue<Action> releaseHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_releaseHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_releaseHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x060066F6 RID: 26358 RVA: 0x001F6580 File Offset: 0x001F4780
		// (set) Token: 0x060066F7 RID: 26359 RVA: 0x00037900 File Offset: 0x00035B00
		public unsafe Coroutine executionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_executionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x060066F8 RID: 26360 RVA: 0x001F65B0 File Offset: 0x001F47B0
		// (set) Token: 0x060066F9 RID: 26361 RVA: 0x0003791F File Offset: 0x00035B1F
		public unsafe bool m_RefreshRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_RefreshRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_RefreshRequested)) = value;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x060066FA RID: 26362 RVA: 0x001F65D8 File Offset: 0x001F47D8
		// (set) Token: 0x060066FB RID: 26363 RVA: 0x0003793A File Offset: 0x00035B3A
		public unsafe Action m_UnBindCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_UnBindCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.NativeFieldInfoPtr_m_UnBindCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043E6 RID: 17382
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_IZAKAYA_KWD;

		// Token: 0x040043E7 RID: 17383
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_PARTNER_KWD;

		// Token: 0x040043E8 RID: 17384
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_RECIPE_KWD;

		// Token: 0x040043E9 RID: 17385
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_FUND_ADD_KWD;

		// Token: 0x040043EA RID: 17386
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_FUND_LOST_KWD;

		// Token: 0x040043EB RID: 17387
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_DECORATION_KWD;

		// Token: 0x040043EC RID: 17388
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_MAP_UNLOCK_KWD;

		// Token: 0x040043ED RID: 17389
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_TROPHY_KWD;

		// Token: 0x040043EE RID: 17390
		private static readonly IntPtr NativeFieldInfoPtr_RECIEVE_COOKER_KWD;

		// Token: 0x040043EF RID: 17391
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD;

		// Token: 0x040043F0 RID: 17392
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD;

		// Token: 0x040043F1 RID: 17393
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_UPDATE_FOODTAG_KWD;

		// Token: 0x040043F2 RID: 17394
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_UPDATE_HATEFOODTAG_KWD;

		// Token: 0x040043F3 RID: 17395
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_UPDATE_BEVTAG_KWD;

		// Token: 0x040043F4 RID: 17396
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_UPDATE_IZAKAYA_KWD;

		// Token: 0x040043F5 RID: 17397
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_WRITE_MORE_KWD;

		// Token: 0x040043F6 RID: 17398
		private static readonly IntPtr NativeFieldInfoPtr_ALBUM_UPGRATE_KIZUNA_KWD;

		// Token: 0x040043F7 RID: 17399
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_UP_KWD;

		// Token: 0x040043F8 RID: 17400
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_UP_PROPERTIES_KWD;

		// Token: 0x040043F9 RID: 17401
		private static readonly IntPtr NativeFieldInfoPtr_MISSION_START_KWD;

		// Token: 0x040043FA RID: 17402
		private static readonly IntPtr NativeFieldInfoPtr_MISSION_FINISH_KWD;

		// Token: 0x040043FB RID: 17403
		private static readonly IntPtr NativeFieldInfoPtr_SPELL_DECALARATION_KWD;

		// Token: 0x040043FC RID: 17404
		private static readonly IntPtr NativeFieldInfoPtr_spriteMessageParent;

		// Token: 0x040043FD RID: 17405
		private static readonly IntPtr NativeFieldInfoPtr_badgeMessageParent;

		// Token: 0x040043FE RID: 17406
		private static readonly IntPtr NativeFieldInfoPtr_badgeWithoutCountMessageParent;

		// Token: 0x040043FF RID: 17407
		private static readonly IntPtr NativeFieldInfoPtr_textMessageParent;

		// Token: 0x04004400 RID: 17408
		private static readonly IntPtr NativeFieldInfoPtr_spriteMessageCountParent;

		// Token: 0x04004401 RID: 17409
		private static readonly IntPtr NativeFieldInfoPtr_textMessageCountParent;

		// Token: 0x04004402 RID: 17410
		private static readonly IntPtr NativeFieldInfoPtr_recievedMessagePositionIndicatorParent;

		// Token: 0x04004403 RID: 17411
		private static readonly IntPtr NativeFieldInfoPtr_recievedObjectField;

		// Token: 0x04004404 RID: 17412
		private static readonly IntPtr NativeFieldInfoPtr_recievedObjectLayoutField;

		// Token: 0x04004405 RID: 17413
		private static readonly IntPtr NativeFieldInfoPtr_flexibleRect;

		// Token: 0x04004406 RID: 17414
		private static readonly IntPtr NativeFieldInfoPtr_onNotify;

		// Token: 0x04004407 RID: 17415
		private static readonly IntPtr NativeFieldInfoPtr_messageStayDuration;

		// Token: 0x04004408 RID: 17416
		private static readonly IntPtr NativeFieldInfoPtr_messageInsertionAdjustmentDuration;

		// Token: 0x04004409 RID: 17417
		private static readonly IntPtr NativeFieldInfoPtr_burstMessageFrameOffset;

		// Token: 0x0400440A RID: 17418
		private static readonly IntPtr NativeFieldInfoPtr_maxMessageCount;

		// Token: 0x0400440B RID: 17419
		private static readonly IntPtr NativeFieldInfoPtr_currentVelocityBuffer;

		// Token: 0x0400440C RID: 17420
		private static readonly IntPtr NativeFieldInfoPtr_executionQueue;

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomSpacing;

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldPositionBuffer;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeFieldInfoPtr_registeredObjectCollection;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeFieldInfoPtr_releaseHandle;

		// Token: 0x04004411 RID: 17425
		private static readonly IntPtr NativeFieldInfoPtr_executionCoroutine;

		// Token: 0x04004412 RID: 17426
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshRequested;

		// Token: 0x04004413 RID: 17427
		private static readonly IntPtr NativeFieldInfoPtr_m_UnBindCallback;

		// Token: 0x04004414 RID: 17428
		private static readonly IntPtr NativeMethodInfoPtr_set_FlexibleSpaceHeight_Private_set_Void_Single_0;

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCustomSpacing_Public_Static_Void_RectTransform_0;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveCustomSpacing_Public_Static_Void_0;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateMetrics_Public_Static_Void_0;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMetrics_Private_Void_0;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMetricsImpl_Private_Void_0;

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTextMessage_Public_Void_String_0;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCommonPhraseUpdate_Public_Void_String_0;

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpecialGuestSpawnInNight_Public_Void_String_Boolean_Il2CppStructArray_1_Int32_0;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeMethodInfoPtr_NotifyObjectLanguageBase_Public_Void_ObjectLanguageBase_Int32_0;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeMethodInfoPtr_NotifySellableLanguageBase_Public_Void_Sellable_Int32_0;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBadgeLanguageBase_Public_Void_ObjectLanguageBase_Int32_0;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_ObjectLanguageBase_0;

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBadgeWithoutCountLanguageBase_Public_Void_Sprite_String_0;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMap_Public_Void_String_0;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpell_Public_Void_String_String_0;

		// Token: 0x04004427 RID: 17447
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTrophy_Private_Void_ObjectLanguageBase_0;

		// Token: 0x04004428 RID: 17448
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIzakaya_Private_Void_Int32_0;

		// Token: 0x04004429 RID: 17449
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPartner_Private_Void_Int32_0;

		// Token: 0x0400442A RID: 17450
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCooker_Private_Void_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0;

		// Token: 0x0400442B RID: 17451
		private static readonly IntPtr NativeMethodInfoPtr_NotifyRecipe_Private_Void_Int32_0;

		// Token: 0x0400442C RID: 17452
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTagUpdate_Private_Void_ValueTuple_4_Int32_SellableType_Boolean_Int32_0;

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIzakayaUpdate_Private_Void_ValueTuple_2_Int32_Int32_0;

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpecialGuestNewInfo_Private_Void_Int32_0;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpecialGuestUpgrateKizunaLevel_Private_Void_ValueTuple_2_Int32_Int32_0;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeMethodInfoPtr_NotifyFund_Private_Void_Int32_0;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDecoration_Private_Void_Int32_0;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpriteMessage_Private_Void_Sprite_String_Sprite_0;

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeMethodInfoPtr_NotifyLevelMessage_Private_Void_Int32_0;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMissionStart_Private_Void_String_0;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeMethodInfoPtr_NotifyMissionFinish_Private_Void_String_0;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeMethodInfoPtr_NotifySpriteCountMessage_Private_Void_Sprite_String_Int32_Sprite_Boolean_0;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBadgeCountMessage_Private_Void_Sprite_String_Int32_0;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBadgeWithoutCountMessage_Private_Void_Sprite_String_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTextCountMessage_Private_Void_String_Int32_0;

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeMethodInfoPtr_BindDayScene_Public_Void_0;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeMethodInfoPtr_BindWorkScene_Public_Void_0;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeMethodInfoPtr_GetTitleKWD_Private_String_String_0;

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_0;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeMethodInfoPtr_GetTitleKWD_Private_String_String_String_String_0;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Private_String_Int32_0;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeMethodInfoPtr_GetBadgeMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004442 RID: 17474
		private static readonly IntPtr NativeMethodInfoPtr_GetBadgeWithoutCountMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeMethodInfoPtr_GetTextMessageInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeMethodInfoPtr_GetTextMessageCountInstance_Private_ValueTuple_2_UIElementCluster_GameObject_0;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceInternal_Private_ValueTuple_2_UIElementCluster_GameObject_GameObject_0;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteNotify_Private_Void_0;

		// Token: 0x04004448 RID: 17480
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDataInternal_Private_Void_Func_1_ValueTuple_2_UIElementCluster_GameObject_Action_1_UIElementCluster_0;

		// Token: 0x04004449 RID: 17481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400444A RID: 17482
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_0;

		// Token: 0x0400444B RID: 17483
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_1;

		// Token: 0x0400444C RID: 17484
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Single_PDM_2;

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Func_2_LevelProperties_Single_String_Func_2_Single_String_byref___c__DisplayClass78_0_0;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeMethodInfoPtr__BindDayScene_b__85_0_Private_Void_0;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeMethodInfoPtr__BindWorkScene_b__86_0_Private_Void_0;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000E50 RID: 3664
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x060105B8 RID: 67000 RVA: 0x003CD3C8 File Offset: 0x003CB5C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, "content");
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, 100684789);
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__NotifyTextMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, 100684790);
				ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__NotifyTextMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr, 100684791);
			}

			// Token: 0x060105B9 RID: 67001 RVA: 0x003CD46C File Offset: 0x003CB66C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105BA RID: 67002 RVA: 0x003CD4A8 File Offset: 0x003CB6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263524, XrefRangeEnd = 263539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTextMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__NotifyTextMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105BB RID: 67003 RVA: 0x003CD4DC File Offset: 0x003CB6DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263539, XrefRangeEnd = 263545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTextMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeMethodInfoPtr__NotifyTextMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105BC RID: 67004 RVA: 0x0008EBB5 File Offset: 0x0008CDB5
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700557F RID: 21887
			// (get) Token: 0x060105BD RID: 67005 RVA: 0x003CD520 File Offset: 0x003CB720
			// (set) Token: 0x060105BE RID: 67006 RVA: 0x0008EBBE File Offset: 0x0008CDBE
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005580 RID: 21888
			// (get) Token: 0x060105BF RID: 67007 RVA: 0x003CD550 File Offset: 0x003CB750
			// (set) Token: 0x060105C0 RID: 67008 RVA: 0x0008EBDD File Offset: 0x0008CDDD
			public unsafe string content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr_content);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005581 RID: 21889
			// (get) Token: 0x060105C1 RID: 67009 RVA: 0x003CD578 File Offset: 0x003CB778
			// (set) Token: 0x060105C2 RID: 67010 RVA: 0x0008EBFC File Offset: 0x0008CDFC
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass56_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5C3 RID: 42435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5C4 RID: 42436
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x0400A5C5 RID: 42437
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A5C6 RID: 42438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5C7 RID: 42439
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTextMessage_b__0_Internal_Void_0;

			// Token: 0x0400A5C8 RID: 42440
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTextMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E51 RID: 3665
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x060105C3 RID: 67011 RVA: 0x003CD5A8 File Offset: 0x003CB7A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeFieldInfoPtr_specialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr, "specialGuest");
				ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr, 100684792);
				ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr, 100684793);
			}

			// Token: 0x060105C4 RID: 67012 RVA: 0x003CD610 File Offset: 0x003CB810
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105C5 RID: 67013 RVA: 0x003CD64C File Offset: 0x003CB84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263545, XrefRangeEnd = 263561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifySpecialGuestSpawnInNight_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105C6 RID: 67014 RVA: 0x0008EC1B File Offset: 0x0008CE1B
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005582 RID: 21890
			// (get) Token: 0x060105C7 RID: 67015 RVA: 0x003CD698 File Offset: 0x003CB898
			// (set) Token: 0x060105C8 RID: 67016 RVA: 0x0008EC24 File Offset: 0x0008CE24
			public unsafe SpecialGuest specialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeFieldInfoPtr_specialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_0.NativeFieldInfoPtr_specialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5C9 RID: 42441
			private static readonly IntPtr NativeFieldInfoPtr_specialGuest;

			// Token: 0x0400A5CA RID: 42442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5CB RID: 42443
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000E52 RID: 3666
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass58_1")]
		public sealed class __c__DisplayClass58_1 : Il2CppSystem.Object
		{
			// Token: 0x060105C9 RID: 67017 RVA: 0x003CD6C8 File Offset: 0x003CB8C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_1()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass58_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr, "x");
				ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr, "CS$<>8__locals1");
				ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr, 100684794);
				ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__3_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr, 100684795);
			}

			// Token: 0x060105CA RID: 67018 RVA: 0x003CD744 File Offset: 0x003CB944
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass58_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105CB RID: 67019 RVA: 0x003CD780 File Offset: 0x003CB980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263561, XrefRangeEnd = 263562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifySpecialGuestSpawnInNight_b__3(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__3_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105CC RID: 67020 RVA: 0x0008EC43 File Offset: 0x0008CE43
			public __c__DisplayClass58_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005583 RID: 21891
			// (get) Token: 0x060105CD RID: 67021 RVA: 0x003CD7D0 File Offset: 0x003CB9D0
			// (set) Token: 0x060105CE RID: 67022 RVA: 0x0008EC4C File Offset: 0x0008CE4C
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17005584 RID: 21892
			// (get) Token: 0x060105CF RID: 67023 RVA: 0x003CD7F8 File Offset: 0x003CB9F8
			// (set) Token: 0x060105D0 RID: 67024 RVA: 0x0008EC67 File Offset: 0x0008CE67
			public unsafe ReceivedObjectDisplayerController.__c__DisplayClass58_0 field_Public___c__DisplayClass58_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController.__c__DisplayClass58_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5CC RID: 42444
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A5CD RID: 42445
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0;

			// Token: 0x0400A5CE RID: 42446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5CF RID: 42447
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__3_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000E53 RID: 3667
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060105D1 RID: 67025 RVA: 0x003CD828 File Offset: 0x003CBA28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__58_1");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__58_2");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__58_4");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_4");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_5");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_6");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_7");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_8");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_9");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_10");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_11");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_12");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_13");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_14");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_15");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_16");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_17");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_18");
				ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, "<>9__78_19");
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684797);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684798);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_2_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684799);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_4_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684800);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_4_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684801);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_5_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684802);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_6_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684803);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_7_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684804);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_8_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684805);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_9_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684806);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_10_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684807);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_11_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684808);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_12_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684809);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_13_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684810);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_14_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684811);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_15_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684812);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_16_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684813);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_17_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684814);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_18_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684815);
				ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_19_Internal_Single_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr, 100684816);
			}

			// Token: 0x060105D2 RID: 67026 RVA: 0x003CDB74 File Offset: 0x003CBD74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060105D3 RID: 67027 RVA: 0x003CDBB0 File Offset: 0x003CBDB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263562, XrefRangeEnd = 263563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _NotifySpecialGuestSpawnInNight_b__58_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060105D4 RID: 67028 RVA: 0x003CDBF4 File Offset: 0x003CBDF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263563, XrefRangeEnd = 263564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _NotifySpecialGuestSpawnInNight_b__58_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_2_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105D5 RID: 67029 RVA: 0x003CDC44 File Offset: 0x003CBE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _NotifySpecialGuestSpawnInNight_b__58_4(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_4_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060105D6 RID: 67030 RVA: 0x003CDC8C File Offset: 0x003CBE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263564, XrefRangeEnd = 263565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_4(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_4_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105D7 RID: 67031 RVA: 0x003CDCE0 File Offset: 0x003CBEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263565, XrefRangeEnd = 263566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_5(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_5_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105D8 RID: 67032 RVA: 0x003CDD34 File Offset: 0x003CBF34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263566, XrefRangeEnd = 263567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_6(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_6_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105D9 RID: 67033 RVA: 0x003CDD88 File Offset: 0x003CBF88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263567, XrefRangeEnd = 263568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_7(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_7_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DA RID: 67034 RVA: 0x003CDDDC File Offset: 0x003CBFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263568, XrefRangeEnd = 263569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_8(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_8_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DB RID: 67035 RVA: 0x003CDE30 File Offset: 0x003CC030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263569, XrefRangeEnd = 263570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_9(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_9_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DC RID: 67036 RVA: 0x003CDE84 File Offset: 0x003CC084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263570, XrefRangeEnd = 263571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_10(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_10_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DD RID: 67037 RVA: 0x003CDED8 File Offset: 0x003CC0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263571, XrefRangeEnd = 263572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_11(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_11_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DE RID: 67038 RVA: 0x003CDF2C File Offset: 0x003CC12C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263572, XrefRangeEnd = 263573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_12(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_12_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105DF RID: 67039 RVA: 0x003CDF80 File Offset: 0x003CC180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263573, XrefRangeEnd = 263574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_13(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_13_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E0 RID: 67040 RVA: 0x003CDFD4 File Offset: 0x003CC1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263574, XrefRangeEnd = 263575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_14(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_14_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E1 RID: 67041 RVA: 0x003CE028 File Offset: 0x003CC228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263575, XrefRangeEnd = 263576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_15(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_15_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E2 RID: 67042 RVA: 0x003CE07C File Offset: 0x003CC27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263576, XrefRangeEnd = 263577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_16(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_16_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E3 RID: 67043 RVA: 0x003CE0D0 File Offset: 0x003CC2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263577, XrefRangeEnd = 263578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_17(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_17_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E4 RID: 67044 RVA: 0x003CE124 File Offset: 0x003CC324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263578, XrefRangeEnd = 263579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_18(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_18_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E5 RID: 67045 RVA: 0x003CE178 File Offset: 0x003CC378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263579, XrefRangeEnd = 263580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _NotifyLevelMessage_b__78_19(DataBaseCore.LevelProperties x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c.NativeMethodInfoPtr__NotifyLevelMessage_b__78_19_Internal_Single_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060105E6 RID: 67046 RVA: 0x0008EC86 File Offset: 0x0008CE86
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005585 RID: 21893
			// (get) Token: 0x060105E7 RID: 67047 RVA: 0x003CE1CC File Offset: 0x003CC3CC
			// (set) Token: 0x060105E8 RID: 67048 RVA: 0x0008EC8F File Offset: 0x0008CE8F
			public unsafe static ReceivedObjectDisplayerController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005586 RID: 21894
			// (get) Token: 0x060105E9 RID: 67049 RVA: 0x003CE1F4 File Offset: 0x003CC3F4
			// (set) Token: 0x060105EA RID: 67050 RVA: 0x0008ECA1 File Offset: 0x0008CEA1
			public unsafe static Func<int, string> __9__58_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005587 RID: 21895
			// (get) Token: 0x060105EB RID: 67051 RVA: 0x003CE21C File Offset: 0x003CC41C
			// (set) Token: 0x060105EC RID: 67052 RVA: 0x0008ECB3 File Offset: 0x0008CEB3
			public unsafe static Func<string, bool> __9__58_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005588 RID: 21896
			// (get) Token: 0x060105ED RID: 67053 RVA: 0x003CE244 File Offset: 0x003CC444
			// (set) Token: 0x060105EE RID: 67054 RVA: 0x0008ECC5 File Offset: 0x0008CEC5
			public unsafe static Func<string, string> __9__58_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__58_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005589 RID: 21897
			// (get) Token: 0x060105EF RID: 67055 RVA: 0x003CE26C File Offset: 0x003CC46C
			// (set) Token: 0x060105F0 RID: 67056 RVA: 0x0008ECD7 File Offset: 0x0008CED7
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558A RID: 21898
			// (get) Token: 0x060105F1 RID: 67057 RVA: 0x003CE294 File Offset: 0x003CC494
			// (set) Token: 0x060105F2 RID: 67058 RVA: 0x0008ECE9 File Offset: 0x0008CEE9
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558B RID: 21899
			// (get) Token: 0x060105F3 RID: 67059 RVA: 0x003CE2BC File Offset: 0x003CC4BC
			// (set) Token: 0x060105F4 RID: 67060 RVA: 0x0008ECFB File Offset: 0x0008CEFB
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558C RID: 21900
			// (get) Token: 0x060105F5 RID: 67061 RVA: 0x003CE2E4 File Offset: 0x003CC4E4
			// (set) Token: 0x060105F6 RID: 67062 RVA: 0x0008ED0D File Offset: 0x0008CF0D
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558D RID: 21901
			// (get) Token: 0x060105F7 RID: 67063 RVA: 0x003CE30C File Offset: 0x003CC50C
			// (set) Token: 0x060105F8 RID: 67064 RVA: 0x0008ED1F File Offset: 0x0008CF1F
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558E RID: 21902
			// (get) Token: 0x060105F9 RID: 67065 RVA: 0x003CE334 File Offset: 0x003CC534
			// (set) Token: 0x060105FA RID: 67066 RVA: 0x0008ED31 File Offset: 0x0008CF31
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700558F RID: 21903
			// (get) Token: 0x060105FB RID: 67067 RVA: 0x003CE35C File Offset: 0x003CC55C
			// (set) Token: 0x060105FC RID: 67068 RVA: 0x0008ED43 File Offset: 0x0008CF43
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005590 RID: 21904
			// (get) Token: 0x060105FD RID: 67069 RVA: 0x003CE384 File Offset: 0x003CC584
			// (set) Token: 0x060105FE RID: 67070 RVA: 0x0008ED55 File Offset: 0x0008CF55
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005591 RID: 21905
			// (get) Token: 0x060105FF RID: 67071 RVA: 0x003CE3AC File Offset: 0x003CC5AC
			// (set) Token: 0x06010600 RID: 67072 RVA: 0x0008ED67 File Offset: 0x0008CF67
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005592 RID: 21906
			// (get) Token: 0x06010601 RID: 67073 RVA: 0x003CE3D4 File Offset: 0x003CC5D4
			// (set) Token: 0x06010602 RID: 67074 RVA: 0x0008ED79 File Offset: 0x0008CF79
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005593 RID: 21907
			// (get) Token: 0x06010603 RID: 67075 RVA: 0x003CE3FC File Offset: 0x003CC5FC
			// (set) Token: 0x06010604 RID: 67076 RVA: 0x0008ED8B File Offset: 0x0008CF8B
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005594 RID: 21908
			// (get) Token: 0x06010605 RID: 67077 RVA: 0x003CE424 File Offset: 0x003CC624
			// (set) Token: 0x06010606 RID: 67078 RVA: 0x0008ED9D File Offset: 0x0008CF9D
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005595 RID: 21909
			// (get) Token: 0x06010607 RID: 67079 RVA: 0x003CE44C File Offset: 0x003CC64C
			// (set) Token: 0x06010608 RID: 67080 RVA: 0x0008EDAF File Offset: 0x0008CFAF
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005596 RID: 21910
			// (get) Token: 0x06010609 RID: 67081 RVA: 0x003CE474 File Offset: 0x003CC674
			// (set) Token: 0x0601060A RID: 67082 RVA: 0x0008EDC1 File Offset: 0x0008CFC1
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005597 RID: 21911
			// (get) Token: 0x0601060B RID: 67083 RVA: 0x003CE49C File Offset: 0x003CC69C
			// (set) Token: 0x0601060C RID: 67084 RVA: 0x0008EDD3 File Offset: 0x0008CFD3
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005598 RID: 21912
			// (get) Token: 0x0601060D RID: 67085 RVA: 0x003CE4C4 File Offset: 0x003CC6C4
			// (set) Token: 0x0601060E RID: 67086 RVA: 0x0008EDE5 File Offset: 0x0008CFE5
			public unsafe static Func<DataBaseCore.LevelProperties, float> __9__78_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReceivedObjectDisplayerController.__c.NativeFieldInfoPtr___9__78_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5D0 RID: 42448
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A5D1 RID: 42449
			private static readonly IntPtr NativeFieldInfoPtr___9__58_1;

			// Token: 0x0400A5D2 RID: 42450
			private static readonly IntPtr NativeFieldInfoPtr___9__58_2;

			// Token: 0x0400A5D3 RID: 42451
			private static readonly IntPtr NativeFieldInfoPtr___9__58_4;

			// Token: 0x0400A5D4 RID: 42452
			private static readonly IntPtr NativeFieldInfoPtr___9__78_4;

			// Token: 0x0400A5D5 RID: 42453
			private static readonly IntPtr NativeFieldInfoPtr___9__78_5;

			// Token: 0x0400A5D6 RID: 42454
			private static readonly IntPtr NativeFieldInfoPtr___9__78_6;

			// Token: 0x0400A5D7 RID: 42455
			private static readonly IntPtr NativeFieldInfoPtr___9__78_7;

			// Token: 0x0400A5D8 RID: 42456
			private static readonly IntPtr NativeFieldInfoPtr___9__78_8;

			// Token: 0x0400A5D9 RID: 42457
			private static readonly IntPtr NativeFieldInfoPtr___9__78_9;

			// Token: 0x0400A5DA RID: 42458
			private static readonly IntPtr NativeFieldInfoPtr___9__78_10;

			// Token: 0x0400A5DB RID: 42459
			private static readonly IntPtr NativeFieldInfoPtr___9__78_11;

			// Token: 0x0400A5DC RID: 42460
			private static readonly IntPtr NativeFieldInfoPtr___9__78_12;

			// Token: 0x0400A5DD RID: 42461
			private static readonly IntPtr NativeFieldInfoPtr___9__78_13;

			// Token: 0x0400A5DE RID: 42462
			private static readonly IntPtr NativeFieldInfoPtr___9__78_14;

			// Token: 0x0400A5DF RID: 42463
			private static readonly IntPtr NativeFieldInfoPtr___9__78_15;

			// Token: 0x0400A5E0 RID: 42464
			private static readonly IntPtr NativeFieldInfoPtr___9__78_16;

			// Token: 0x0400A5E1 RID: 42465
			private static readonly IntPtr NativeFieldInfoPtr___9__78_17;

			// Token: 0x0400A5E2 RID: 42466
			private static readonly IntPtr NativeFieldInfoPtr___9__78_18;

			// Token: 0x0400A5E3 RID: 42467
			private static readonly IntPtr NativeFieldInfoPtr___9__78_19;

			// Token: 0x0400A5E4 RID: 42468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5E5 RID: 42469
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_1_Internal_String_Int32_0;

			// Token: 0x0400A5E6 RID: 42470
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_2_Internal_Boolean_String_0;

			// Token: 0x0400A5E7 RID: 42471
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpecialGuestSpawnInNight_b__58_4_Internal_String_String_0;

			// Token: 0x0400A5E8 RID: 42472
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_4_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5E9 RID: 42473
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_5_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5EA RID: 42474
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_6_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5EB RID: 42475
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_7_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5EC RID: 42476
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_8_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5ED RID: 42477
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_9_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5EE RID: 42478
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_10_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5EF RID: 42479
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_11_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F0 RID: 42480
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_12_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F1 RID: 42481
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_13_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F2 RID: 42482
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_14_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F3 RID: 42483
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_15_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F4 RID: 42484
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_16_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F5 RID: 42485
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_17_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F6 RID: 42486
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_18_Internal_Single_LevelProperties_0;

			// Token: 0x0400A5F7 RID: 42487
			private static readonly IntPtr NativeMethodInfoPtr__NotifyLevelMessage_b__78_19_Internal_Single_LevelProperties_0;
		}

		// Token: 0x02000E54 RID: 3668
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Il2CppSystem.Object
		{
			// Token: 0x0601060F RID: 67087 RVA: 0x003CE4EC File Offset: 0x003CC6EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, "name");
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, "sprite");
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, "bg");
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, 100684817);
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__NotifySpriteMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, 100684818);
				ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__NotifySpriteMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr, 100684819);
			}

			// Token: 0x06010610 RID: 67088 RVA: 0x003CE5B8 File Offset: 0x003CC7B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010611 RID: 67089 RVA: 0x003CE5F4 File Offset: 0x003CC7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263580, XrefRangeEnd = 263595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySpriteMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__NotifySpriteMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010612 RID: 67090 RVA: 0x003CE628 File Offset: 0x003CC828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263595, XrefRangeEnd = 263605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySpriteMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeMethodInfoPtr__NotifySpriteMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010613 RID: 67091 RVA: 0x0008EDF7 File Offset: 0x0008CFF7
			public __c__DisplayClass77_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005599 RID: 21913
			// (get) Token: 0x06010614 RID: 67092 RVA: 0x003CE66C File Offset: 0x003CC86C
			// (set) Token: 0x06010615 RID: 67093 RVA: 0x0008EE00 File Offset: 0x0008D000
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700559A RID: 21914
			// (get) Token: 0x06010616 RID: 67094 RVA: 0x003CE69C File Offset: 0x003CC89C
			// (set) Token: 0x06010617 RID: 67095 RVA: 0x0008EE1F File Offset: 0x0008D01F
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700559B RID: 21915
			// (get) Token: 0x06010618 RID: 67096 RVA: 0x003CE6C4 File Offset: 0x003CC8C4
			// (set) Token: 0x06010619 RID: 67097 RVA: 0x0008EE3E File Offset: 0x0008D03E
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700559C RID: 21916
			// (get) Token: 0x0601061A RID: 67098 RVA: 0x003CE6F4 File Offset: 0x003CC8F4
			// (set) Token: 0x0601061B RID: 67099 RVA: 0x0008EE5D File Offset: 0x0008D05D
			public unsafe Sprite bg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_bg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700559D RID: 21917
			// (get) Token: 0x0601061C RID: 67100 RVA: 0x003CE724 File Offset: 0x003CC924
			// (set) Token: 0x0601061D RID: 67101 RVA: 0x0008EE7C File Offset: 0x0008D07C
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass77_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5F8 RID: 42488
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5F9 RID: 42489
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400A5FA RID: 42490
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400A5FB RID: 42491
			private static readonly IntPtr NativeFieldInfoPtr_bg;

			// Token: 0x0400A5FC RID: 42492
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A5FD RID: 42493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5FE RID: 42494
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpriteMessage_b__0_Internal_Void_0;

			// Token: 0x0400A5FF RID: 42495
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpriteMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E55 RID: 3669
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : ValueType
		{
			// Token: 0x0601061E RID: 67102 RVA: 0x003CE754 File Offset: 0x003CC954
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass78_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_levelProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass78_0>.NativeClassPtr, "levelProfile");
				ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_lastProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass78_0>.NativeClassPtr, "lastProfile");
			}

			// Token: 0x0601061F RID: 67103 RVA: 0x0008EE9B File Offset: 0x0008D09B
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010620 RID: 67104 RVA: 0x0008EEA4 File Offset: 0x0008D0A4
			public __c__DisplayClass78_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass78_0>.NativeClassPtr))
			{
			}

			// Token: 0x1700559E RID: 21918
			// (get) Token: 0x06010621 RID: 67105 RVA: 0x003CE7A8 File Offset: 0x003CC9A8
			// (set) Token: 0x06010622 RID: 67106 RVA: 0x0008EEB6 File Offset: 0x0008D0B6
			public DataBaseCore.LevelProperties levelProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_levelProfile);
					return new DataBaseCore.LevelProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_levelProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700559F RID: 21919
			// (get) Token: 0x06010623 RID: 67107 RVA: 0x003CE7D8 File Offset: 0x003CC9D8
			// (set) Token: 0x06010624 RID: 67108 RVA: 0x0008EEE4 File Offset: 0x0008D0E4
			public DataBaseCore.LevelProperties lastProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_lastProfile);
					return new DataBaseCore.LevelProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass78_0.NativeFieldInfoPtr_lastProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A600 RID: 42496
			private static readonly IntPtr NativeFieldInfoPtr_levelProfile;

			// Token: 0x0400A601 RID: 42497
			private static readonly IntPtr NativeFieldInfoPtr_lastProfile;
		}

		// Token: 0x02000E56 RID: 3670
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : Il2CppSystem.Object
		{
			// Token: 0x06010625 RID: 67109 RVA: 0x003CE808 File Offset: 0x003CCA08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "name");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "sprite");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_countString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "countString");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_addModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "addModify");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "bg");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, 100684820);
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__NotifySpriteCountMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, 100684821);
				ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__NotifySpriteCountMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr, 100684822);
			}

			// Token: 0x06010626 RID: 67110 RVA: 0x003CE8FC File Offset: 0x003CCAFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010627 RID: 67111 RVA: 0x003CE938 File Offset: 0x003CCB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263605, XrefRangeEnd = 263620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySpriteCountMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__NotifySpriteCountMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010628 RID: 67112 RVA: 0x003CE96C File Offset: 0x003CCB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263620, XrefRangeEnd = 263637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySpriteCountMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeMethodInfoPtr__NotifySpriteCountMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010629 RID: 67113 RVA: 0x0008EF12 File Offset: 0x0008D112
			public __c__DisplayClass81_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055A0 RID: 21920
			// (get) Token: 0x0601062A RID: 67114 RVA: 0x003CE9B0 File Offset: 0x003CCBB0
			// (set) Token: 0x0601062B RID: 67115 RVA: 0x0008EF1B File Offset: 0x0008D11B
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055A1 RID: 21921
			// (get) Token: 0x0601062C RID: 67116 RVA: 0x003CE9E0 File Offset: 0x003CCBE0
			// (set) Token: 0x0601062D RID: 67117 RVA: 0x0008EF3A File Offset: 0x0008D13A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055A2 RID: 21922
			// (get) Token: 0x0601062E RID: 67118 RVA: 0x003CEA08 File Offset: 0x003CCC08
			// (set) Token: 0x0601062F RID: 67119 RVA: 0x0008EF59 File Offset: 0x0008D159
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055A3 RID: 21923
			// (get) Token: 0x06010630 RID: 67120 RVA: 0x003CEA38 File Offset: 0x003CCC38
			// (set) Token: 0x06010631 RID: 67121 RVA: 0x0008EF78 File Offset: 0x0008D178
			public unsafe string countString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_countString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_countString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055A4 RID: 21924
			// (get) Token: 0x06010632 RID: 67122 RVA: 0x003CEA60 File Offset: 0x003CCC60
			// (set) Token: 0x06010633 RID: 67123 RVA: 0x0008EF97 File Offset: 0x0008D197
			public unsafe bool addModify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_addModify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_addModify)) = value;
				}
			}

			// Token: 0x170055A5 RID: 21925
			// (get) Token: 0x06010634 RID: 67124 RVA: 0x003CEA88 File Offset: 0x003CCC88
			// (set) Token: 0x06010635 RID: 67125 RVA: 0x0008EFB2 File Offset: 0x0008D1B2
			public unsafe Sprite bg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_bg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055A6 RID: 21926
			// (get) Token: 0x06010636 RID: 67126 RVA: 0x003CEAB8 File Offset: 0x003CCCB8
			// (set) Token: 0x06010637 RID: 67127 RVA: 0x0008EFD1 File Offset: 0x0008D1D1
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass81_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A602 RID: 42498
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A603 RID: 42499
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400A604 RID: 42500
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400A605 RID: 42501
			private static readonly IntPtr NativeFieldInfoPtr_countString;

			// Token: 0x0400A606 RID: 42502
			private static readonly IntPtr NativeFieldInfoPtr_addModify;

			// Token: 0x0400A607 RID: 42503
			private static readonly IntPtr NativeFieldInfoPtr_bg;

			// Token: 0x0400A608 RID: 42504
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A609 RID: 42505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A60A RID: 42506
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpriteCountMessage_b__0_Internal_Void_0;

			// Token: 0x0400A60B RID: 42507
			private static readonly IntPtr NativeMethodInfoPtr__NotifySpriteCountMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E57 RID: 3671
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x06010638 RID: 67128 RVA: 0x003CEAE8 File Offset: 0x003CCCE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, "name");
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, "sprite");
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_countString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, "countString");
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, 100684823);
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__NotifyBadgeCountMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, 100684824);
				ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__NotifyBadgeCountMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr, 100684825);
			}

			// Token: 0x06010639 RID: 67129 RVA: 0x003CEBB4 File Offset: 0x003CCDB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601063A RID: 67130 RVA: 0x003CEBF0 File Offset: 0x003CCDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263637, XrefRangeEnd = 263652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyBadgeCountMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__NotifyBadgeCountMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601063B RID: 67131 RVA: 0x003CEC24 File Offset: 0x003CCE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263652, XrefRangeEnd = 263667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyBadgeCountMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeMethodInfoPtr__NotifyBadgeCountMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601063C RID: 67132 RVA: 0x0008EFF0 File Offset: 0x0008D1F0
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055A7 RID: 21927
			// (get) Token: 0x0601063D RID: 67133 RVA: 0x003CEC68 File Offset: 0x003CCE68
			// (set) Token: 0x0601063E RID: 67134 RVA: 0x0008EFF9 File Offset: 0x0008D1F9
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055A8 RID: 21928
			// (get) Token: 0x0601063F RID: 67135 RVA: 0x003CEC98 File Offset: 0x003CCE98
			// (set) Token: 0x06010640 RID: 67136 RVA: 0x0008F018 File Offset: 0x0008D218
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055A9 RID: 21929
			// (get) Token: 0x06010641 RID: 67137 RVA: 0x003CECC0 File Offset: 0x003CCEC0
			// (set) Token: 0x06010642 RID: 67138 RVA: 0x0008F037 File Offset: 0x0008D237
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055AA RID: 21930
			// (get) Token: 0x06010643 RID: 67139 RVA: 0x003CECF0 File Offset: 0x003CCEF0
			// (set) Token: 0x06010644 RID: 67140 RVA: 0x0008F056 File Offset: 0x0008D256
			public unsafe string countString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_countString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr_countString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055AB RID: 21931
			// (get) Token: 0x06010645 RID: 67141 RVA: 0x003CED18 File Offset: 0x003CCF18
			// (set) Token: 0x06010646 RID: 67142 RVA: 0x0008F075 File Offset: 0x0008D275
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A60C RID: 42508
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A60D RID: 42509
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400A60E RID: 42510
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400A60F RID: 42511
			private static readonly IntPtr NativeFieldInfoPtr_countString;

			// Token: 0x0400A610 RID: 42512
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A611 RID: 42513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A612 RID: 42514
			private static readonly IntPtr NativeMethodInfoPtr__NotifyBadgeCountMessage_b__0_Internal_Void_0;

			// Token: 0x0400A613 RID: 42515
			private static readonly IntPtr NativeMethodInfoPtr__NotifyBadgeCountMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E58 RID: 3672
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x06010647 RID: 67143 RVA: 0x003CED48 File Offset: 0x003CCF48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, "name");
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, "sprite");
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, 100684826);
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, 100684827);
				ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr, 100684828);
			}

			// Token: 0x06010648 RID: 67144 RVA: 0x003CEE00 File Offset: 0x003CD000
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010649 RID: 67145 RVA: 0x003CEE3C File Offset: 0x003CD03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263667, XrefRangeEnd = 263682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyBadgeWithoutCountMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601064A RID: 67146 RVA: 0x003CEE70 File Offset: 0x003CD070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263682, XrefRangeEnd = 263691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyBadgeWithoutCountMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601064B RID: 67147 RVA: 0x0008F094 File Offset: 0x0008D294
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055AC RID: 21932
			// (get) Token: 0x0601064C RID: 67148 RVA: 0x003CEEB4 File Offset: 0x003CD0B4
			// (set) Token: 0x0601064D RID: 67149 RVA: 0x0008F09D File Offset: 0x0008D29D
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055AD RID: 21933
			// (get) Token: 0x0601064E RID: 67150 RVA: 0x003CEEE4 File Offset: 0x003CD0E4
			// (set) Token: 0x0601064F RID: 67151 RVA: 0x0008F0BC File Offset: 0x0008D2BC
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055AE RID: 21934
			// (get) Token: 0x06010650 RID: 67152 RVA: 0x003CEF0C File Offset: 0x003CD10C
			// (set) Token: 0x06010651 RID: 67153 RVA: 0x0008F0DB File Offset: 0x0008D2DB
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055AF RID: 21935
			// (get) Token: 0x06010652 RID: 67154 RVA: 0x003CEF3C File Offset: 0x003CD13C
			// (set) Token: 0x06010653 RID: 67155 RVA: 0x0008F0FA File Offset: 0x0008D2FA
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass83_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A614 RID: 42516
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A615 RID: 42517
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400A616 RID: 42518
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400A617 RID: 42519
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A618 RID: 42520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A619 RID: 42521
			private static readonly IntPtr NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__0_Internal_Void_0;

			// Token: 0x0400A61A RID: 42522
			private static readonly IntPtr NativeMethodInfoPtr__NotifyBadgeWithoutCountMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E59 RID: 3673
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
		{
			// Token: 0x06010654 RID: 67156 RVA: 0x003CEF6C File Offset: 0x003CD16C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, "content");
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_countString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, "countString");
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, "<>9__1");
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, 100684829);
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__NotifyTextCountMessage_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, 100684830);
				ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__NotifyTextCountMessage_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr, 100684831);
			}

			// Token: 0x06010655 RID: 67157 RVA: 0x003CF024 File Offset: 0x003CD224
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010656 RID: 67158 RVA: 0x003CF060 File Offset: 0x003CD260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263691, XrefRangeEnd = 263706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTextCountMessage_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__NotifyTextCountMessage_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010657 RID: 67159 RVA: 0x003CF094 File Offset: 0x003CD294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263706, XrefRangeEnd = 263718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyTextCountMessage_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeMethodInfoPtr__NotifyTextCountMessage_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010658 RID: 67160 RVA: 0x0008F119 File Offset: 0x0008D319
			public __c__DisplayClass84_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055B0 RID: 21936
			// (get) Token: 0x06010659 RID: 67161 RVA: 0x003CF0D8 File Offset: 0x003CD2D8
			// (set) Token: 0x0601065A RID: 67162 RVA: 0x0008F122 File Offset: 0x0008D322
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055B1 RID: 21937
			// (get) Token: 0x0601065B RID: 67163 RVA: 0x003CF108 File Offset: 0x003CD308
			// (set) Token: 0x0601065C RID: 67164 RVA: 0x0008F141 File Offset: 0x0008D341
			public unsafe string content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_content);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_content), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055B2 RID: 21938
			// (get) Token: 0x0601065D RID: 67165 RVA: 0x003CF130 File Offset: 0x003CD330
			// (set) Token: 0x0601065E RID: 67166 RVA: 0x0008F160 File Offset: 0x0008D360
			public unsafe string countString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_countString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr_countString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170055B3 RID: 21939
			// (get) Token: 0x0601065F RID: 67167 RVA: 0x003CF158 File Offset: 0x003CD358
			// (set) Token: 0x06010660 RID: 67168 RVA: 0x0008F17F File Offset: 0x0008D37F
			public unsafe Action<UIElementCluster> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass84_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A61B RID: 42523
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A61C RID: 42524
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x0400A61D RID: 42525
			private static readonly IntPtr NativeFieldInfoPtr_countString;

			// Token: 0x0400A61E RID: 42526
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A61F RID: 42527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A620 RID: 42528
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTextCountMessage_b__0_Internal_Void_0;

			// Token: 0x0400A621 RID: 42529
			private static readonly IntPtr NativeMethodInfoPtr__NotifyTextCountMessage_b__1_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000E5A RID: 3674
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass99_0")]
		public sealed class __c__DisplayClass99_0 : Il2CppSystem.Object
		{
			// Token: 0x06010661 RID: 67169 RVA: 0x003CF188 File Offset: 0x003CD388
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass99_0()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass99_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, "coroutine");
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_objectInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, "objectInstance");
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, 100684832);
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, 100684833);
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_UIElementCluster_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, 100684834);
				ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, 100684835);
			}

			// Token: 0x06010662 RID: 67170 RVA: 0x003CF240 File Offset: 0x003CD440
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass99_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010663 RID: 67171 RVA: 0x003CF27C File Offset: 0x003CD47C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263750, XrefRangeEnd = 263756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010664 RID: 67172 RVA: 0x003CF2B0 File Offset: 0x003CD4B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263781, RefRangeEnd = 263783, XrefRangeStart = 263756, XrefRangeEnd = 263781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ValueTuple_2_UIElementCluster_GameObject_0(ValueTuple<UIElementCluster, GameObject> current)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_UIElementCluster_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010665 RID: 67173 RVA: 0x003CF2F8 File Offset: 0x003CD4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263783, XrefRangeEnd = 263788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010666 RID: 67174 RVA: 0x0008F19E File Offset: 0x0008D39E
			public __c__DisplayClass99_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055B4 RID: 21940
			// (get) Token: 0x06010667 RID: 67175 RVA: 0x003CF338 File Offset: 0x003CD538
			// (set) Token: 0x06010668 RID: 67176 RVA: 0x0008F1A7 File Offset: 0x0008D3A7
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055B5 RID: 21941
			// (get) Token: 0x06010669 RID: 67177 RVA: 0x003CF368 File Offset: 0x003CD568
			// (set) Token: 0x0601066A RID: 67178 RVA: 0x0008F1C6 File Offset: 0x0008D3C6
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055B6 RID: 21942
			// (get) Token: 0x0601066B RID: 67179 RVA: 0x003CF398 File Offset: 0x003CD598
			// (set) Token: 0x0601066C RID: 67180 RVA: 0x0008F1E5 File Offset: 0x0008D3E5
			public ValueTuple<UIElementCluster, GameObject> objectInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_objectInstance);
					return new ValueTuple<UIElementCluster, GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.NativeFieldInfoPtr_objectInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A622 RID: 42530
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x0400A623 RID: 42531
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A624 RID: 42532
			private static readonly IntPtr NativeFieldInfoPtr_objectInstance;

			// Token: 0x0400A625 RID: 42533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A626 RID: 42534
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A627 RID: 42535
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_UIElementCluster_GameObject_0;

			// Token: 0x0400A628 RID: 42536
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x020010B4 RID: 4276
			[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass99_0+<<NotifyDataInternal>g__OnRegisteredMessageTiming|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060122DF RID: 74463 RVA: 0x00425544 File Offset: 0x00423744
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique()
				{
					Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0>.NativeClassPtr, "<<NotifyDataInternal>g__OnRegisteredMessageTiming|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<>1__state");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<>2__current");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<>4__this");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<thisObjectInstance>5__2");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__seconds_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<seconds>5__3");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, "<waitForSeconds>5__4");
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684836);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684837);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684838);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684839);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684840);
					ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr, 100684841);
				}

				// Token: 0x060122E0 RID: 74464 RVA: 0x00425660 File Offset: 0x00423860
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122E1 RID: 74465 RVA: 0x004256A8 File Offset: 0x004238A8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122E2 RID: 74466 RVA: 0x004256DC File Offset: 0x004238DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263718, XrefRangeEnd = 263744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F1A RID: 24346
				// (get) Token: 0x060122E3 RID: 74467 RVA: 0x00425718 File Offset: 0x00423918
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122E4 RID: 74468 RVA: 0x00425758 File Offset: 0x00423958
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263744, XrefRangeEnd = 263750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F1B RID: 24347
				// (get) Token: 0x060122E5 RID: 74469 RVA: 0x0042578C File Offset: 0x0042398C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122E6 RID: 74470 RVA: 0x0009DD8B File Offset: 0x0009BF8B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F14 RID: 24340
				// (get) Token: 0x060122E7 RID: 74471 RVA: 0x004257CC File Offset: 0x004239CC
				// (set) Token: 0x060122E8 RID: 74472 RVA: 0x0009DD94 File Offset: 0x0009BF94
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F15 RID: 24341
				// (get) Token: 0x060122E9 RID: 74473 RVA: 0x004257F4 File Offset: 0x004239F4
				// (set) Token: 0x060122EA RID: 74474 RVA: 0x0009DDAF File Offset: 0x0009BFAF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F16 RID: 24342
				// (get) Token: 0x060122EB RID: 74475 RVA: 0x00425824 File Offset: 0x00423A24
				// (set) Token: 0x060122EC RID: 74476 RVA: 0x0009DDCE File Offset: 0x0009BFCE
				public unsafe ReceivedObjectDisplayerController.__c__DisplayClass99_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController.__c__DisplayClass99_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F17 RID: 24343
				// (get) Token: 0x060122ED RID: 74477 RVA: 0x00425854 File Offset: 0x00423A54
				// (set) Token: 0x060122EE RID: 74478 RVA: 0x0009DDED File Offset: 0x0009BFED
				public ValueTuple<UIElementCluster, GameObject> _thisObjectInstance_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2);
						return new ValueTuple<UIElementCluster, GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__thisObjectInstance_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<UIElementCluster, GameObject>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005F18 RID: 24344
				// (get) Token: 0x060122EF RID: 74479 RVA: 0x00425884 File Offset: 0x00423A84
				// (set) Token: 0x060122F0 RID: 74480 RVA: 0x0009DE1B File Offset: 0x0009C01B
				public unsafe float _seconds_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__seconds_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__seconds_5__3)) = value;
					}
				}

				// Token: 0x17005F19 RID: 24345
				// (get) Token: 0x060122F1 RID: 74481 RVA: 0x004258AC File Offset: 0x00423AAC
				// (set) Token: 0x060122F2 RID: 74482 RVA: 0x0009DE36 File Offset: 0x0009C036
				public unsafe WaitForSecondsRealtime _waitForSeconds_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSecondsRealtime>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVa2UIGaSiWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B847 RID: 47175
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B848 RID: 47176
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B849 RID: 47177
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B84A RID: 47178
				private static readonly IntPtr NativeFieldInfoPtr__thisObjectInstance_5__2;

				// Token: 0x0400B84B RID: 47179
				private static readonly IntPtr NativeFieldInfoPtr__seconds_5__3;

				// Token: 0x0400B84C RID: 47180
				private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__4;

				// Token: 0x0400B84D RID: 47181
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B84E RID: 47182
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B84F RID: 47183
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B850 RID: 47184
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B851 RID: 47185
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B852 RID: 47186
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000E5B RID: 3675
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<>c__DisplayClass99_1")]
		public sealed class __c__DisplayClass99_1 : Il2CppSystem.Object
		{
			// Token: 0x0601066D RID: 67181 RVA: 0x003CF3C8 File Offset: 0x003CD5C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass99_1()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<>c__DisplayClass99_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr);
				ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr, "objectData");
				ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectLayoutData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr, "objectLayoutData");
				ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr, 100684842);
				ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeMethodInfoPtr__NotifyDataInternal_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr, 100684843);
			}

			// Token: 0x0601066E RID: 67182 RVA: 0x003CF444 File Offset: 0x003CD644
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass99_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.__c__DisplayClass99_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601066F RID: 67183 RVA: 0x003CF480 File Offset: 0x003CD680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263788, XrefRangeEnd = 263796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifyDataInternal_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeMethodInfoPtr__NotifyDataInternal_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010670 RID: 67184 RVA: 0x0008F213 File Offset: 0x0008D413
			public __c__DisplayClass99_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055B7 RID: 21943
			// (get) Token: 0x06010671 RID: 67185 RVA: 0x003CF4B4 File Offset: 0x003CD6B4
			// (set) Token: 0x06010672 RID: 67186 RVA: 0x0008F21C File Offset: 0x0008D41C
			public unsafe UIElementCluster objectData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055B8 RID: 21944
			// (get) Token: 0x06010673 RID: 67187 RVA: 0x003CF4E4 File Offset: 0x003CD6E4
			// (set) Token: 0x06010674 RID: 67188 RVA: 0x0008F23B File Offset: 0x0008D43B
			public unsafe GameObject objectLayoutData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectLayoutData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.__c__DisplayClass99_1.NativeFieldInfoPtr_objectLayoutData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A629 RID: 42537
			private static readonly IntPtr NativeFieldInfoPtr_objectData;

			// Token: 0x0400A62A RID: 42538
			private static readonly IntPtr NativeFieldInfoPtr_objectLayoutData;

			// Token: 0x0400A62B RID: 42539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A62C RID: 42540
			private static readonly IntPtr NativeMethodInfoPtr__NotifyDataInternal_b__3_Internal_Void_0;
		}

		// Token: 0x02000E5C RID: 3676
		[ObfuscatedName("Common.UI.ReceivedObjectDisplayerController+<<TryExecuteNotify>g__Execute|98_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x06010675 RID: 67189 RVA: 0x003CF514 File Offset: 0x003CD714
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique()
			{
				Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr, "<<TryExecuteNotify>g__Execute|98_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, "<>1__state");
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, "<>2__current");
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, "<>4__this");
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, "<i>5__2");
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684844);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684845);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684846);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684847);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684848);
				ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr, 100684849);
			}

			// Token: 0x06010676 RID: 67190 RVA: 0x003CF608 File Offset: 0x003CD808
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010677 RID: 67191 RVA: 0x003CF650 File Offset: 0x003CD850
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010678 RID: 67192 RVA: 0x003CF684 File Offset: 0x003CD884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263796, XrefRangeEnd = 263808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170055BD RID: 21949
			// (get) Token: 0x06010679 RID: 67193 RVA: 0x003CF6C0 File Offset: 0x003CD8C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601067A RID: 67194 RVA: 0x003CF700 File Offset: 0x003CD900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263808, XrefRangeEnd = 263814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170055BE RID: 21950
			// (get) Token: 0x0601067B RID: 67195 RVA: 0x003CF734 File Offset: 0x003CD934
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601067C RID: 67196 RVA: 0x0008F25A File Offset: 0x0008D45A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055B9 RID: 21945
			// (get) Token: 0x0601067D RID: 67197 RVA: 0x003CF774 File Offset: 0x003CD974
			// (set) Token: 0x0601067E RID: 67198 RVA: 0x0008F263 File Offset: 0x0008D463
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170055BA RID: 21946
			// (get) Token: 0x0601067F RID: 67199 RVA: 0x003CF79C File Offset: 0x003CD99C
			// (set) Token: 0x06010680 RID: 67200 RVA: 0x0008F27E File Offset: 0x0008D47E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055BB RID: 21947
			// (get) Token: 0x06010681 RID: 67201 RVA: 0x003CF7CC File Offset: 0x003CD9CC
			// (set) Token: 0x06010682 RID: 67202 RVA: 0x0008F29D File Offset: 0x0008D49D
			public unsafe ReceivedObjectDisplayerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedObjectDisplayerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055BC RID: 21948
			// (get) Token: 0x06010683 RID: 67203 RVA: 0x003CF7FC File Offset: 0x003CD9FC
			// (set) Token: 0x06010684 RID: 67204 RVA: 0x0008F2BC File Offset: 0x0008D4BC
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedObjectDisplayerController.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReInObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400A62D RID: 42541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A62E RID: 42542
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A62F RID: 42543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A630 RID: 42544
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400A631 RID: 42545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A632 RID: 42546
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A633 RID: 42547
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A634 RID: 42548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A635 RID: 42549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A636 RID: 42550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E5D RID: 3677
		private sealed class MethodInfoStoreGeneric_TryRegisterCustomSpacing_Public_Static_Void_RectTransform_0<T>
		{
			// Token: 0x0400A637 RID: 42551
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryRegisterCustomSpacing_Public_Static_Void_RectTransform_0, Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E5E RID: 3678
		private sealed class MethodInfoStoreGeneric_TryRemoveCustomSpacing_Public_Static_Void_0<T>
		{
			// Token: 0x0400A638 RID: 42552
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReceivedObjectDisplayerController.NativeMethodInfoPtr_TryRemoveCustomSpacing_Public_Static_Void_0, Il2CppClassPointerStore<ReceivedObjectDisplayerController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
