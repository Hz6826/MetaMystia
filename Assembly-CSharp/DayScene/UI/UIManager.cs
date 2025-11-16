using System;
using Common.UI;
using Common.UI.CreatorsBox;
using Common.UI.InfiniteSelection;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.Managers;
using DEYU.AssetHandleUtility;
using DEYU.GraphicsCollection;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using GamePlatform.Systems;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI
{
	// Token: 0x020000B9 RID: 185
	public class UIManager : MonoSingleton<UIManager>
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x000E1F8C File Offset: 0x000E018C
		// Note: this type is marked as 'beforefieldinit'.
		static UIManager()
		{
			Il2CppClassPointerStore<UIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "UIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager>.NativeClassPtr);
			UIManager.NativeFieldInfoPtr_clockTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "clockTransitionDuration");
			UIManager.NativeFieldInfoPtr_cinematicEffectController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "cinematicEffectController");
			UIManager.NativeFieldInfoPtr_actionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "actionIndicator");
			UIManager.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "currentTime");
			UIManager.NativeFieldInfoPtr_currentDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "currentDate");
			UIManager.NativeFieldInfoPtr_travelTimeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "travelTimeIndicator");
			UIManager.NativeFieldInfoPtr_colorGradingLerpController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "colorGradingLerpController");
			UIManager.NativeFieldInfoPtr_clockCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "clockCanvas");
			UIManager.NativeFieldInfoPtr_effectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "effectRoot");
			UIManager.NativeFieldInfoPtr_buttonEffectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "buttonEffectRoot");
			UIManager.NativeFieldInfoPtr_DaySceneSustainedPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneSustainedPannel");
			UIManager.NativeFieldInfoPtr_DaySceneIzakayaSelectorPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneIzakayaSelectorPannel");
			UIManager.NativeFieldInfoPtr_DayScenePartnerSelectorPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DayScenePartnerSelectorPannel");
			UIManager.NativeFieldInfoPtr_DaySceneShopPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneShopPannel");
			UIManager.NativeFieldInfoPtr_DaySceneKourindoShopPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneKourindoShopPannel");
			UIManager.NativeFieldInfoPtr_DaySceneChatSelectionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneChatSelectionPannel");
			UIManager.NativeFieldInfoPtr_DaySceneChatConfirmationPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneChatConfirmationPannel");
			UIManager.NativeFieldInfoPtr_DaySceneEventSelectionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneEventSelectionPannel");
			UIManager.NativeFieldInfoPtr_DLC3_MusicGameStartPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DLC3_MusicGameStartPannel");
			UIManager.NativeFieldInfoPtr_focusingIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "focusingIndicator");
			UIManager.NativeFieldInfoPtr_focusingIndicatorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "focusingIndicatorOffset");
			UIManager.NativeFieldInfoPtr_currentMapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "currentMapName");
			UIManager.NativeFieldInfoPtr_EventSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "EventSprite");
			UIManager.NativeFieldInfoPtr_MissionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "MissionSprite");
			UIManager.NativeFieldInfoPtr_MerchantSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "MerchantSprite");
			UIManager.NativeFieldInfoPtr_CanDeliverSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "CanDeliverSprite");
			UIManager.NativeFieldInfoPtr_KyoukouTutorialSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "KyoukouTutorialSprite");
			UIManager.NativeFieldInfoPtr_KyoukouNewTutorialSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "KyoukouNewTutorialSprite");
			UIManager.NativeFieldInfoPtr_lastProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "lastProgress");
			UIManager.NativeFieldInfoPtr_onSettingDayLightIlluminationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "onSettingDayLightIlluminationCallback");
			UIManager.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "startTime");
			UIManager.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "endTime");
			UIManager.NativeFieldInfoPtr_totalActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "totalActions");
			UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<SustainedPannel>k__BackingField");
			UIManager.NativeFieldInfoPtr__CurrentActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<CurrentActions>k__BackingField");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeMainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeMainPanel");
			UIManager.NativeFieldInfoPtr_m_Dlc5RoguelikeLoadProgressPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_Dlc5RoguelikeLoadProgressPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSpotSelectionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeSpotSelectionPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeFailedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeFailedPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeRoundPassPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeRoundPassPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeWinPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeWinPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSaveLoadPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeSaveLoadPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeResultPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5RogueLikeResultPanel");
			UIManager.NativeFieldInfoPtr_m_DLC5CreatorsBoxPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_DLC5CreatorsBoxPanel");
			UIManager.NativeFieldInfoPtr_m_InfiniteIngredientsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_InfiniteIngredientsPanel");
			UIManager.NativeFieldInfoPtr_LUCKY_LEAF_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "LUCKY_LEAF_ID");
			UIManager.NativeFieldInfoPtr_COUPONS_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "COUPONS_ID");
			UIManager.NativeMethodInfoPtr_get_SustainedPannel_Public_get_DaySceneSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666779);
			UIManager.NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_DaySceneSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666780);
			UIManager.NativeMethodInfoPtr_get_CurrentActions_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666781);
			UIManager.NativeMethodInfoPtr_set_CurrentActions_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666782);
			UIManager.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666783);
			UIManager.NativeMethodInfoPtr_LoadDependencies_Public_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666784);
			UIManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666785);
			UIManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666786);
			UIManager.NativeMethodInfoPtr_UpdateFocusIndicator_Public_Void_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666787);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666788);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666789);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666790);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666791);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsync_Public_UniTask_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666792);
			UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsync_Public_UniTask_Dictionary_2_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666793);
			UIManager.NativeMethodInfoPtr_OpenEventSelectionModule_Public_Void_Dictionary_2_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666794);
			UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTask_Dictionary_2_String_Action_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666795);
			UIManager.NativeMethodInfoPtr_OpenPartnerSelectionModuleAsync_Public_UniTask_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666796);
			UIManager.NativeMethodInfoPtr_OpenIzakayaSelectionModuleAsync_Public_UniTask_1_Int32_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666797);
			UIManager.NativeMethodInfoPtr_GetTimeCode_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666798);
			UIManager.NativeMethodInfoPtr_UpdateTime_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666799);
			UIManager.NativeMethodInfoPtr_SetTime_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666800);
			UIManager.NativeMethodInfoPtr_UpdateCurrentMapTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666801);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_Action_Action_1_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666802);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_Action_Action_1_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666803);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666804);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666805);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666806);
			UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666807);
			UIManager.NativeMethodInfoPtr_OpenShopPannel_Public_Void_TrackedMerchant_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666808);
			UIManager.NativeMethodInfoPtr_OpenShopPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666809);
			UIManager.NativeMethodInfoPtr_OpenKourindouPannel_Public_Void_TrackedMerchant_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666810);
			UIManager.NativeMethodInfoPtr_OpenKourindouPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666811);
			UIManager.NativeMethodInfoPtr_SetCurrentTime_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666812);
			UIManager.NativeMethodInfoPtr_RoundTime_Private_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666813);
			UIManager.NativeMethodInfoPtr_GetMapTransitionTimePreview_Public_Void_Int32_byref_TimeSpan_byref_TimeSpan_byref_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666814);
			UIManager.NativeMethodInfoPtr_SetCinematicTransitionEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666815);
			UIManager.NativeMethodInfoPtr_GetActionTimeContext_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666816);
			UIManager.NativeMethodInfoPtr_SetCinemativeTransitionContext_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666817);
			UIManager.NativeMethodInfoPtr_AfterRogueLike_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666818);
			UIManager.NativeMethodInfoPtr_OpenCreatorsBoxPanelAsync_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666819);
			UIManager.NativeMethodInfoPtr_OpenInfiniteIngredientsPanelAsync_Public_Static_UniTask_ActiveCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666820);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeMainPanel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666821);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeMainPanelAsync_Private_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666822);
			UIManager.NativeMethodInfoPtr_AfterRogueLikeAsync_Private_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666823);
			UIManager.NativeMethodInfoPtr_ChallengeLoop_Private_Static_UniTask_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666824);
			UIManager.NativeMethodInfoPtr_MoveToRogueLike_Private_Static_Void_String_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666825);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeChallengeSpotSelectionPanel_Private_Static_UniTask_1_RogueMapCloseContext_RogueLikeRunTimeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666826);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeFailedPanelAsync_Private_Static_UniTask_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666827);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeWinPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666828);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeRoundPassPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666829);
			UIManager.NativeMethodInfoPtr_OpenRogueLikeResultPanelAsync_Public_Static_UniTask_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666830);
			UIManager.NativeMethodInfoPtr_FadeInAndLeavePanelForRogueLike_Public_Static_UniTask_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666831);
			UIManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666832);
			UIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666833);
			UIManager.NativeMethodInfoPtr__Initialize_b__41_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100666834);
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000E27C8 File Offset: 0x000E09C8
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x000E2808 File Offset: 0x000E0A08
		public unsafe DaySceneSustainedPannel SustainedPannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_SustainedPannel_Public_get_DaySceneSustainedPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_DaySceneSustainedPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x000E284C File Offset: 0x000E0A4C
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x000E2888 File Offset: 0x000E0A88
		public unsafe int CurrentActions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_CurrentActions_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_CurrentActions_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000E28C8 File Offset: 0x000E0AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57449, RefRangeEnd = 57450, XrefRangeStart = 57374, XrefRangeEnd = 57449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000E28FC File Offset: 0x000E0AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57450, XrefRangeEnd = 57451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask LoadDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_LoadDependencies_Public_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000E2934 File Offset: 0x000E0B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57451, XrefRangeEnd = 57454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000E2970 File Offset: 0x000E0B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57499, RefRangeEnd = 57500, XrefRangeStart = 57454, XrefRangeEnd = 57499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000E29A4 File Offset: 0x000E0BA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57507, RefRangeEnd = 57513, XrefRangeStart = 57500, XrefRangeEnd = 57507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFocusIndicator(Nullable<Vector3> worldCoordinate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(worldCoordinate));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_UpdateFocusIndicator_Public_Void_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000E29EC File Offset: 0x000E0BEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 57520, RefRangeEnd = 57530, XrefRangeStart = 57513, XrefRangeEnd = 57520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenChatConfirmationModule(Action<bool> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000E2A30 File Offset: 0x000E0C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57530, XrefRangeEnd = 57536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenChatConfirmationModuleAsyncInternal(Action<bool> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x000E2A80 File Offset: 0x000E0C80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57543, RefRangeEnd = 57548, XrefRangeStart = 57536, XrefRangeEnd = 57543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenChatConfirmationModule(Action<bool> onFinish, AdpUIPanelManager.PanelVisualMode pannelVisualMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pannelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000E2AD0 File Offset: 0x000E0CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57548, XrefRangeEnd = 57554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenChatConfirmationModuleAsyncInternal(Action<bool> onFinish, AdpUIPanelManager.PanelVisualMode pannelVisualMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pannelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000E2B2C File Offset: 0x000E0D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57563, RefRangeEnd = 57565, XrefRangeStart = 57554, XrefRangeEnd = 57563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<bool> OpenChatConfirmationModuleAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsync_Public_UniTask_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<bool>(pointer);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000E2B64 File Offset: 0x000E0D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57566, RefRangeEnd = 57567, XrefRangeStart = 57565, XrefRangeEnd = 57566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenEventSelectionModuleAsync(Dictionary<string, Action> options, bool useCustomTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCustomTitle;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsync_Public_UniTask_Dictionary_2_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000E2BBC File Offset: 0x000E0DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57569, RefRangeEnd = 57570, XrefRangeStart = 57567, XrefRangeEnd = 57569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEventSelectionModule(Dictionary<string, Action> options, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenEventSelectionModule_Public_Void_Dictionary_2_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000E2C10 File Offset: 0x000E0E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57578, RefRangeEnd = 57580, XrefRangeStart = 57570, XrefRangeEnd = 57578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenEventSelectionModuleAsyncInternal(Dictionary<string, Action> options, bool useCustomTitle, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCustomTitle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTask_Dictionary_2_String_Action_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000E2C78 File Offset: 0x000E0E78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57587, RefRangeEnd = 57591, XrefRangeStart = 57580, XrefRangeEnd = 57587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenPartnerSelectionModuleAsync(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext dataSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataSource));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenPartnerSelectionModuleAsync_Public_UniTask_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000E2CC8 File Offset: 0x000E0EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57591, XrefRangeEnd = 57601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<int> OpenIzakayaSelectionModuleAsync(SchedulerNode.Trigger.IzakayaLockType izakayaLockType, Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> overrideIzakayaData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaLockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideIzakayaData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenIzakayaSelectionModuleAsync_Public_UniTask_1_Int32_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<int>(pointer);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000E2D20 File Offset: 0x000E0F20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57616, RefRangeEnd = 57620, XrefRangeStart = 57601, XrefRangeEnd = 57616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeCode(int remainedActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref remainedActions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_GetTimeCode_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000E2D64 File Offset: 0x000E0F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57620, XrefRangeEnd = 57631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime(int passAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref passAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_UpdateTime_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000E2DA4 File Offset: 0x000E0FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57631, XrefRangeEnd = 57636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(int setAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetTime_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000E2DE4 File Offset: 0x000E0FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57636, XrefRangeEnd = 57639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentMapTitle(string placeKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(placeKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_UpdateCurrentMapTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000E2E28 File Offset: 0x000E1028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57648, RefRangeEnd = 57649, XrefRangeStart = 57639, XrefRangeEnd = 57648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAfterChatMenu(string specialCharacterLabel, Action onExitCallback, Action<Action> onWillExecuteDayEndEventCallback, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(specialCharacterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_Action_Action_1_Action_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x000E2EAC File Offset: 0x000E10AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57649, XrefRangeEnd = 57657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenAfterChatMenuAsyncInternal(string specialCharacterLabel, Action onExitCallback, Action<Action> onWillExecuteDayEndEventCallback, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(specialCharacterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onWillExecuteDayEndEventCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTriggerEvent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_Action_Action_1_Action_Boolean_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000E2F3C File Offset: 0x000E113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57657, XrefRangeEnd = 57667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAfterChatMenu(string normalCharacterLabel, TrackedMerchant trackedMerchant, Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback> configurationCallback, Action onExitCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(normalCharacterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedMerchant);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurationCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x000E2FC4 File Offset: 0x000E11C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57667, XrefRangeEnd = 57676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenAfterChatMenuAsyncInternal(string normalCharacterLabel, TrackedMerchant trackedMerchant, Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback> configurationCallback, Action onExitCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(normalCharacterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedMerchant);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurationCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x000E3058 File Offset: 0x000E1258
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 57686, RefRangeEnd = 57701, XrefRangeStart = 57676, XrefRangeEnd = 57686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAfterChatMenu(Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> configurationCallbacks, string endButtonTitleKey, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction, Action onExitCallback, int indexToSelct = -1, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurationCallbacks);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endButtonTitleKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endButtonAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexToSelct;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000E30F0 File Offset: 0x000E12F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57701, XrefRangeEnd = 57710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenAfterChatMenuAsyncInternal(Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> configurationCallbacks, string endButtonTitleKey, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction, Action onExitCallback, int indexToSelct = -1, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurationCallbacks);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(endButtonTitleKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endButtonAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexToSelct;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000E3190 File Offset: 0x000E1390
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 57718, RefRangeEnd = 57723, XrefRangeStart = 57710, XrefRangeEnd = 57718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenShopPannel(TrackedMerchant merchantData, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenShopPannel_Public_Void_TrackedMerchant_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x000E31E4 File Offset: 0x000E13E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57723, XrefRangeEnd = 57730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenShopPannelAsyncInternal(TrackedMerchant merchantData, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenShopPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000E3244 File Offset: 0x000E1444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57738, RefRangeEnd = 57739, XrefRangeStart = 57730, XrefRangeEnd = 57738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenKourindouPannel(TrackedMerchant merchantData, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenKourindouPannel_Public_Void_TrackedMerchant_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x000E3298 File Offset: 0x000E1498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57739, XrefRangeEnd = 57746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenKourindouPannelAsyncInternal(TrackedMerchant merchantData, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchantData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenKourindouPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x000E32F8 File Offset: 0x000E14F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57763, RefRangeEnd = 57765, XrefRangeStart = 57746, XrefRangeEnd = 57763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentTime(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetCurrentTime_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000E3338 File Offset: 0x000E1538
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 57780, RefRangeEnd = 57787, XrefRangeStart = 57765, XrefRangeEnd = 57780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan RoundTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeSpan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_RoundTime_Private_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000E3384 File Offset: 0x000E1584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57801, RefRangeEnd = 57803, XrefRangeStart = 57787, XrefRangeEnd = 57801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMapTransitionTimePreview(int actionCost, out TimeSpan currentTime, out TimeSpan targetTime, out TimeSpan costTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionCost;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &costTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_GetMapTransitionTimePreview_Public_Void_Int32_byref_TimeSpan_byref_TimeSpan_byref_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000E33F0 File Offset: 0x000E15F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57807, RefRangeEnd = 57809, XrefRangeStart = 57803, XrefRangeEnd = 57807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCinematicTransitionEffect(bool shouldOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetCinematicTransitionEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000E3430 File Offset: 0x000E1630
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 57853, RefRangeEnd = 57859, XrefRangeStart = 57809, XrefRangeEnd = 57853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionTimeContext(int actions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_GetActionTimeContext_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x000E3474 File Offset: 0x000E1674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57869, RefRangeEnd = 57870, XrefRangeStart = 57859, XrefRangeEnd = 57869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCinemativeTransitionContext(string placeKey, bool doCostTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(placeKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doCostTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetCinemativeTransitionContext_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000E34C4 File Offset: 0x000E16C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57870, XrefRangeEnd = 57883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AfterRogueLike()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_AfterRogueLike_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x000E34EC File Offset: 0x000E16EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57888, RefRangeEnd = 57890, XrefRangeStart = 57883, XrefRangeEnd = 57888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenCreatorsBoxPanelAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenCreatorsBoxPanelAsync_Public_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x000E3518 File Offset: 0x000E1718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57895, RefRangeEnd = 57899, XrefRangeStart = 57890, XrefRangeEnd = 57895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenInfiniteIngredientsPanelAsync(DLC5_InfiniteSelectionPanel.ActiveCount activeCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activeCount;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenInfiniteIngredientsPanelAsync_Public_Static_UniTask_ActiveCount_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000E3550 File Offset: 0x000E1750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57912, RefRangeEnd = 57914, XrefRangeStart = 57899, XrefRangeEnd = 57912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenRogueLikeMainPanel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeMainPanel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x000E3578 File Offset: 0x000E1778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57914, XrefRangeEnd = 57920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenRogueLikeMainPanelAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeMainPanelAsync_Private_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000E35A4 File Offset: 0x000E17A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57920, XrefRangeEnd = 57926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask AfterRogueLikeAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_AfterRogueLikeAsync_Private_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000E35D0 File Offset: 0x000E17D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57932, RefRangeEnd = 57935, XrefRangeStart = 57926, XrefRangeEnd = 57932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask ChallengeLoop(Action onStartChallengeCallback = null, bool isStart = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onStartChallengeCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStart;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_ChallengeLoop_Private_Static_UniTask_Action_Boolean_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000E361C File Offset: 0x000E181C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57948, RefRangeEnd = 57949, XrefRangeStart = 57935, XrefRangeEnd = 57948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveToRogueLike(string mapName, UnlockedIzakayaInfo izakayaLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_MoveToRogueLike_Private_Static_Void_String_UnlockedIzakayaInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000E3660 File Offset: 0x000E1860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57958, RefRangeEnd = 57959, XrefRangeStart = 57949, XrefRangeEnd = 57958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext> OpenRogueLikeChallengeSpotSelectionPanel(RogueLikeRunTimeData runTimeData, bool isStart = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStart;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeChallengeSpotSelectionPanel_Private_Static_UniTask_1_RogueMapCloseContext_RogueLikeRunTimeData_Boolean_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>(pointer);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000E36AC File Offset: 0x000E18AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57965, RefRangeEnd = 57966, XrefRangeStart = 57959, XrefRangeEnd = 57965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenRogueLikeFailedPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeFailedPanelAsync_Private_Static_UniTask_RogueLikeRunTimeData_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000E36E8 File Offset: 0x000E18E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57975, RefRangeEnd = 57976, XrefRangeStart = 57966, XrefRangeEnd = 57975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<DLC5_RogueLikeWinPanel.CloseContext> OpenRogueLikeWinPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeInExit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFadeInExit;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeWinPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<DLC5_RogueLikeWinPanel.CloseContext>(pointer);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000E3734 File Offset: 0x000E1934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57985, RefRangeEnd = 57986, XrefRangeStart = 57976, XrefRangeEnd = 57985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<DLC5_RogueLikeWinPanel.CloseContext> OpenRogueLikeRoundPassPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeInExit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFadeInExit;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeRoundPassPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<DLC5_RogueLikeWinPanel.CloseContext>(pointer);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000E3780 File Offset: 0x000E1980
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57992, RefRangeEnd = 57996, XrefRangeStart = 57986, XrefRangeEnd = 57992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenRogueLikeResultPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenRogueLikeResultPanelAsync_Public_Static_UniTask_RogueLikeRunTimeData_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x000E37BC File Offset: 0x000E19BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58002, RefRangeEnd = 58004, XrefRangeStart = 57996, XrefRangeEnd = 58002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask FadeInAndLeavePanelForRogueLike(Action onFadeFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFadeFinish);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_FadeInAndLeavePanelForRogueLike_Public_Static_UniTask_Action_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000E37F8 File Offset: 0x000E19F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58004, XrefRangeEnd = 58042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000E3834 File Offset: 0x000E1A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58042, XrefRangeEnd = 58052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000E3870 File Offset: 0x000E1A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58052, XrefRangeEnd = 58054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__41_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr__Initialize_b__41_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0000C9FD File Offset: 0x0000ABFD
		public UIManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x000E38B0 File Offset: 0x000E1AB0
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000CA06 File Offset: 0x0000AC06
		public unsafe static float clockTransitionDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIManager.NativeFieldInfoPtr_clockTransitionDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIManager.NativeFieldInfoPtr_clockTransitionDuration, (void*)(&value));
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000E38CC File Offset: 0x000E1ACC
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000CA14 File Offset: 0x0000AC14
		public unsafe Animator cinematicEffectController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_cinematicEffectController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_cinematicEffectController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000E38FC File Offset: 0x000E1AFC
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000CA33 File Offset: 0x0000AC33
		public unsafe ClockController actionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_actionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_actionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000E392C File Offset: 0x000E1B2C
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000CA52 File Offset: 0x0000AC52
		public unsafe TextMeshProUGUI currentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000E395C File Offset: 0x000E1B5C
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0000CA71 File Offset: 0x0000AC71
		public unsafe TextMeshProUGUI currentDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x000E398C File Offset: 0x000E1B8C
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x0000CA90 File Offset: 0x0000AC90
		public unsafe TextMeshProUGUI travelTimeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_travelTimeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_travelTimeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x000E39BC File Offset: 0x000E1BBC
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0000CAAF File Offset: 0x0000ACAF
		public unsafe ColorGradingLerpController colorGradingLerpController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_colorGradingLerpController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingLerpController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_colorGradingLerpController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000E39EC File Offset: 0x000E1BEC
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x0000CACE File Offset: 0x0000ACCE
		public unsafe CanvasGroup clockCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_clockCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_clockCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000E3A1C File Offset: 0x000E1C1C
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x0000CAED File Offset: 0x0000ACED
		public unsafe RectTransform effectRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_effectRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_effectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000E3A4C File Offset: 0x000E1C4C
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		public unsafe RectTransform buttonEffectRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_buttonEffectRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_buttonEffectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x000E3A7C File Offset: 0x000E1C7C
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0000CB2B File Offset: 0x0000AD2B
		public unsafe DaySceneSustainedPannel DaySceneSustainedPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneSustainedPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneSustainedPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x000E3AAC File Offset: 0x000E1CAC
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0000CB4A File Offset: 0x0000AD4A
		public unsafe AssetReferenceT<GameObject> DaySceneIzakayaSelectorPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneIzakayaSelectorPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneIzakayaSelectorPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x000E3ADC File Offset: 0x000E1CDC
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000CB69 File Offset: 0x0000AD69
		public unsafe AssetReferenceT<GameObject> DayScenePartnerSelectorPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DayScenePartnerSelectorPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DayScenePartnerSelectorPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x000E3B0C File Offset: 0x000E1D0C
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public unsafe AssetReferenceT<GameObject> DaySceneShopPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneShopPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneShopPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x000E3B3C File Offset: 0x000E1D3C
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0000CBA7 File Offset: 0x0000ADA7
		public unsafe AssetReferenceT<GameObject> DaySceneKourindoShopPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneKourindoShopPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneKourindoShopPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x000E3B6C File Offset: 0x000E1D6C
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0000CBC6 File Offset: 0x0000ADC6
		public unsafe AssetReferenceT<GameObject> DaySceneChatSelectionPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneChatSelectionPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneChatSelectionPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x000E3B9C File Offset: 0x000E1D9C
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0000CBE5 File Offset: 0x0000ADE5
		public unsafe AssetReferenceT<GameObject> DaySceneChatConfirmationPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneChatConfirmationPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneChatConfirmationPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000E3BCC File Offset: 0x000E1DCC
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0000CC04 File Offset: 0x0000AE04
		public unsafe AssetReferenceT<GameObject> DaySceneEventSelectionPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneEventSelectionPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DaySceneEventSelectionPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000E3BFC File Offset: 0x000E1DFC
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0000CC23 File Offset: 0x0000AE23
		public unsafe AssetReferenceT<GameObject> DLC3_MusicGameStartPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DLC3_MusicGameStartPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_DLC3_MusicGameStartPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000E3C2C File Offset: 0x000E1E2C
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0000CC42 File Offset: 0x0000AE42
		public unsafe GameObject focusingIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_focusingIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_focusingIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x000E3C5C File Offset: 0x000E1E5C
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0000CC61 File Offset: 0x0000AE61
		public unsafe Vector3 focusingIndicatorOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_focusingIndicatorOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_focusingIndicatorOffset)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x000E3C84 File Offset: 0x000E1E84
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		public unsafe TextMeshProUGUI currentMapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentMapName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_currentMapName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x000E3CB4 File Offset: 0x000E1EB4
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000CC9B File Offset: 0x0000AE9B
		public unsafe Sprite EventSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_EventSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_EventSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x000E3CE4 File Offset: 0x000E1EE4
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000CCBA File Offset: 0x0000AEBA
		public unsafe Sprite MissionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_MissionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_MissionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x000E3D14 File Offset: 0x000E1F14
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000CCD9 File Offset: 0x0000AED9
		public unsafe Sprite MerchantSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_MerchantSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_MerchantSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x000E3D44 File Offset: 0x000E1F44
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		public unsafe Sprite CanDeliverSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_CanDeliverSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_CanDeliverSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000E3D74 File Offset: 0x000E1F74
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000CD17 File Offset: 0x0000AF17
		public unsafe Sprite KyoukouTutorialSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_KyoukouTutorialSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_KyoukouTutorialSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x000E3DA4 File Offset: 0x000E1FA4
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000CD36 File Offset: 0x0000AF36
		public unsafe Sprite KyoukouNewTutorialSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_KyoukouNewTutorialSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_KyoukouNewTutorialSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000E3DD4 File Offset: 0x000E1FD4
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000CD55 File Offset: 0x0000AF55
		public unsafe float lastProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_lastProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_lastProgress)) = value;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000E3DFC File Offset: 0x000E1FFC
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public unsafe Action<float> onSettingDayLightIlluminationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_onSettingDayLightIlluminationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_onSettingDayLightIlluminationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000E3E2C File Offset: 0x000E202C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000CD8F File Offset: 0x0000AF8F
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x000E3E54 File Offset: 0x000E2054
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000CDAA File Offset: 0x0000AFAA
		public unsafe long endTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_endTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_endTime)) = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x000E3E7C File Offset: 0x000E207C
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000CDC5 File Offset: 0x0000AFC5
		public unsafe int totalActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_totalActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_totalActions)) = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000E3EA4 File Offset: 0x000E20A4
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		public unsafe DaySceneSustainedPannel _SustainedPannel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x000E3ED4 File Offset: 0x000E20D4
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000CDFF File Offset: 0x0000AFFF
		public unsafe int _CurrentActions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__CurrentActions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__CurrentActions_k__BackingField)) = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x000E3EFC File Offset: 0x000E20FC
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000CE1A File Offset: 0x0000B01A
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeMainPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeMainPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeMainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x000E3F2C File Offset: 0x000E212C
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000CE39 File Offset: 0x0000B039
		public unsafe DLC5_RogueLikeLoadProgressPanel m_Dlc5RoguelikeLoadProgressPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_Dlc5RoguelikeLoadProgressPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeLoadProgressPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_Dlc5RoguelikeLoadProgressPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000E3F5C File Offset: 0x000E215C
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000CE58 File Offset: 0x0000B058
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeSpotSelectionPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSpotSelectionPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSpotSelectionPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x000E3F8C File Offset: 0x000E218C
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000CE77 File Offset: 0x0000B077
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeFailedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeFailedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeFailedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x000E3FBC File Offset: 0x000E21BC
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000CE96 File Offset: 0x0000B096
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeRoundPassPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeRoundPassPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeRoundPassPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x000E3FEC File Offset: 0x000E21EC
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeWinPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeWinPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeWinPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000E401C File Offset: 0x000E221C
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000CED4 File Offset: 0x0000B0D4
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeSaveLoadPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSaveLoadPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeSaveLoadPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000E404C File Offset: 0x000E224C
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0000CEF3 File Offset: 0x0000B0F3
		public unsafe AssetReferenceT<GameObject> m_DLC5RogueLikeResultPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeResultPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5RogueLikeResultPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x000E407C File Offset: 0x000E227C
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0000CF12 File Offset: 0x0000B112
		public unsafe AssetReferenceT<GameObject> m_DLC5CreatorsBoxPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5CreatorsBoxPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_DLC5CreatorsBoxPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x000E40AC File Offset: 0x000E22AC
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000CF31 File Offset: 0x0000B131
		public unsafe AssetReferenceT<GameObject> m_InfiniteIngredientsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_InfiniteIngredientsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceT<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_InfiniteIngredientsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000E40DC File Offset: 0x000E22DC
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000CF50 File Offset: 0x0000B150
		public unsafe static int LUCKY_LEAF_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(UIManager.NativeFieldInfoPtr_LUCKY_LEAF_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIManager.NativeFieldInfoPtr_LUCKY_LEAF_ID, (void*)(&value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000E40F8 File Offset: 0x000E22F8
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000CF5E File Offset: 0x0000B15E
		public unsafe static int COUPONS_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(UIManager.NativeFieldInfoPtr_COUPONS_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIManager.NativeFieldInfoPtr_COUPONS_ID, (void*)(&value));
			}
		}

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeFieldInfoPtr_clockTransitionDuration;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeFieldInfoPtr_cinematicEffectController;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeFieldInfoPtr_actionIndicator;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeFieldInfoPtr_currentTime;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeFieldInfoPtr_currentDate;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeFieldInfoPtr_travelTimeIndicator;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeFieldInfoPtr_colorGradingLerpController;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeFieldInfoPtr_clockCanvas;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeFieldInfoPtr_effectRoot;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_buttonEffectRoot;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneSustainedPannel;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneIzakayaSelectorPannel;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr_DayScenePartnerSelectorPannel;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneShopPannel;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneKourindoShopPannel;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneChatSelectionPannel;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneChatConfirmationPannel;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneEventSelectionPannel;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeFieldInfoPtr_DLC3_MusicGameStartPannel;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeFieldInfoPtr_focusingIndicator;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeFieldInfoPtr_focusingIndicatorOffset;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeFieldInfoPtr_currentMapName;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeFieldInfoPtr_EventSprite;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeFieldInfoPtr_MissionSprite;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_MerchantSprite;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeFieldInfoPtr_CanDeliverSprite;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr_KyoukouTutorialSprite;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_KyoukouNewTutorialSprite;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_lastProgress;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeFieldInfoPtr_onSettingDayLightIlluminationCallback;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_endTime;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_totalActions;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr__SustainedPannel_k__BackingField;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActions_k__BackingField;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeMainPanel;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeFieldInfoPtr_m_Dlc5RoguelikeLoadProgressPanel;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeSpotSelectionPanel;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeFailedPanel;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeRoundPassPanel;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeWinPanel;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeSaveLoadPanel;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5RogueLikeResultPanel;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC5CreatorsBoxPanel;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeFieldInfoPtr_m_InfiniteIngredientsPanel;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeFieldInfoPtr_LUCKY_LEAF_ID;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeFieldInfoPtr_COUPONS_ID;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_get_SustainedPannel_Public_get_DaySceneSustainedPannel_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_DaySceneSustainedPannel_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActions_Public_get_Int32_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActions_Private_set_Void_Int32_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_LoadDependencies_Public_UniTask_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFocusIndicator_Public_Void_Nullable_1_Vector3_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_PanelVisualMode_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_PanelVisualMode_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModuleAsync_Public_UniTask_1_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_OpenEventSelectionModuleAsync_Public_UniTask_Dictionary_2_String_Action_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_OpenEventSelectionModule_Public_Void_Dictionary_2_String_Action_Action_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTask_Dictionary_2_String_Action_Boolean_Action_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_OpenPartnerSelectionModuleAsync_Public_UniTask_OpenContext_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_OpenIzakayaSelectionModuleAsync_Public_UniTask_1_Int32_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeCode_Public_String_Int32_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_Int32_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Private_Void_Int32_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentMapTitle_Public_Void_String_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_Action_Action_1_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_Action_Action_1_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_String_TrackedMerchant_Il2CppReferenceArray_1_GetNormalNPCSelectionConfigurationCallback_Action_PanelVisualMode_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenu_Public_Void_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_OpenAfterChatMenuAsyncInternal_Private_UniTaskVoid_Il2CppReferenceArray_1_GetSelectionConfigurationCallback_String_EndButtonCallback_Action_Int32_PanelVisualMode_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_OpenShopPannel_Public_Void_TrackedMerchant_Action_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_OpenShopPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_OpenKourindouPannel_Public_Void_TrackedMerchant_Action_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_OpenKourindouPannelAsyncInternal_Private_UniTaskVoid_TrackedMerchant_Action_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentTime_Private_Void_Single_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_RoundTime_Private_TimeSpan_TimeSpan_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_GetMapTransitionTimePreview_Public_Void_Int32_byref_TimeSpan_byref_TimeSpan_byref_TimeSpan_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_SetCinematicTransitionEffect_Public_Void_Boolean_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_GetActionTimeContext_Public_String_Int32_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_SetCinemativeTransitionContext_Public_Void_String_Boolean_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_AfterRogueLike_Public_Static_Void_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_OpenCreatorsBoxPanelAsync_Public_Static_UniTask_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_OpenInfiniteIngredientsPanelAsync_Public_Static_UniTask_ActiveCount_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeMainPanel_Public_Static_Void_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeMainPanelAsync_Private_Static_UniTask_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_AfterRogueLikeAsync_Private_Static_UniTask_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_ChallengeLoop_Private_Static_UniTask_Action_Boolean_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRogueLike_Private_Static_Void_String_UnlockedIzakayaInfo_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeChallengeSpotSelectionPanel_Private_Static_UniTask_1_RogueMapCloseContext_RogueLikeRunTimeData_Boolean_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeFailedPanelAsync_Private_Static_UniTask_RogueLikeRunTimeData_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeWinPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeRoundPassPanelAsync_Private_Static_UniTask_1_CloseContext_RogueLikeRunTimeData_Boolean_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_OpenRogueLikeResultPanelAsync_Public_Static_UniTask_RogueLikeRunTimeData_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_FadeInAndLeavePanelForRogueLike_Public_Static_UniTask_Action_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__41_0_Private_Void_Single_0;

		// Token: 0x020005E0 RID: 1504
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x06008E47 RID: 36423 RVA: 0x0026E6C0 File Offset: 0x0026C8C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr);
				UIManager.__c__DisplayClass47_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr, "onFinish");
				UIManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr, 100666835);
				UIManager.__c__DisplayClass47_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr, 100666836);
			}

			// Token: 0x06008E48 RID: 36424 RVA: 0x0026E728 File Offset: 0x0026C928
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E49 RID: 36425 RVA: 0x0026E764 File Offset: 0x0026C964
			[CallerCount(0)]
			public unsafe void _OpenChatConfirmationModuleAsyncInternal_b__0(DaySceneChatConfirmationPannel pannelInstance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass47_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E4A RID: 36426 RVA: 0x0004C994 File Offset: 0x0004AB94
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F8E RID: 12174
			// (get) Token: 0x06008E4B RID: 36427 RVA: 0x0026E7A8 File Offset: 0x0026C9A8
			// (set) Token: 0x06008E4C RID: 36428 RVA: 0x0004C99D File Offset: 0x0004AB9D
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass47_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass47_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CE4 RID: 23780
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005CE5 RID: 23781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CE6 RID: 23782
			private static readonly IntPtr NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0;
		}

		// Token: 0x020005E1 RID: 1505
		[ObfuscatedName("DayScene.UI.UIManager+<OpenChatConfirmationModuleAsyncInternal>d__47")]
		public sealed class _OpenChatConfirmationModuleAsyncInternal_d__47 : ValueType
		{
			// Token: 0x06008E4D RID: 36429 RVA: 0x0026E7D8 File Offset: 0x0026C9D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenChatConfirmationModuleAsyncInternal_d__47()
			{
				Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenChatConfirmationModuleAsyncInternal>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>1__state");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>t__builder");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "onFinish");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>4__this");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>8__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>u__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, "<>u__2");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, 100666837);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr, 100666838);
			}

			// Token: 0x06008E4E RID: 36430 RVA: 0x0026E8B8 File Offset: 0x0026CAB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55269, RefRangeEnd = 55271, XrefRangeStart = 55231, XrefRangeEnd = 55269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E4F RID: 36431 RVA: 0x0026E8F0 File Offset: 0x0026CAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E50 RID: 36432 RVA: 0x0004C9BC File Offset: 0x0004ABBC
			public _OpenChatConfirmationModuleAsyncInternal_d__47(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008E51 RID: 36433 RVA: 0x0004C9C5 File Offset: 0x0004ABC5
			public _OpenChatConfirmationModuleAsyncInternal_d__47() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__47>.NativeClassPtr))
			{
			}

			// Token: 0x17002F8F RID: 12175
			// (get) Token: 0x06008E52 RID: 36434 RVA: 0x0026E938 File Offset: 0x0026CB38
			// (set) Token: 0x06008E53 RID: 36435 RVA: 0x0004C9D7 File Offset: 0x0004ABD7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F90 RID: 12176
			// (get) Token: 0x06008E54 RID: 36436 RVA: 0x0026E960 File Offset: 0x0026CB60
			// (set) Token: 0x06008E55 RID: 36437 RVA: 0x0004C9F2 File Offset: 0x0004ABF2
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F91 RID: 12177
			// (get) Token: 0x06008E56 RID: 36438 RVA: 0x0026E990 File Offset: 0x0026CB90
			// (set) Token: 0x06008E57 RID: 36439 RVA: 0x0004CA20 File Offset: 0x0004AC20
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F92 RID: 12178
			// (get) Token: 0x06008E58 RID: 36440 RVA: 0x0026E9C0 File Offset: 0x0026CBC0
			// (set) Token: 0x06008E59 RID: 36441 RVA: 0x0004CA3F File Offset: 0x0004AC3F
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F93 RID: 12179
			// (get) Token: 0x06008E5A RID: 36442 RVA: 0x0026E9F0 File Offset: 0x0026CBF0
			// (set) Token: 0x06008E5B RID: 36443 RVA: 0x0004CA5E File Offset: 0x0004AC5E
			public unsafe UIManager.__c__DisplayClass47_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass47_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F94 RID: 12180
			// (get) Token: 0x06008E5C RID: 36444 RVA: 0x0026EA20 File Offset: 0x0026CC20
			// (set) Token: 0x06008E5D RID: 36445 RVA: 0x0004CA7D File Offset: 0x0004AC7D
			public UniTask<DaySceneChatConfirmationPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatConfirmationPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F95 RID: 12181
			// (get) Token: 0x06008E5E RID: 36446 RVA: 0x0026EA50 File Offset: 0x0026CC50
			// (set) Token: 0x06008E5F RID: 36447 RVA: 0x0004CAAB File Offset: 0x0004ACAB
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__47.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005CE7 RID: 23783
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CE8 RID: 23784
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005CE9 RID: 23785
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005CEA RID: 23786
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CEB RID: 23787
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005CEC RID: 23788
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005CED RID: 23789
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005CEE RID: 23790
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CEF RID: 23791
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E2 RID: 1506
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x06008E60 RID: 36448 RVA: 0x0026EA80 File Offset: 0x0026CC80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr);
				UIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr, "onFinish");
				UIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr, 100666839);
				UIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr, 100666840);
			}

			// Token: 0x06008E61 RID: 36449 RVA: 0x0026EAE8 File Offset: 0x0026CCE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E62 RID: 36450 RVA: 0x0026EB24 File Offset: 0x0026CD24
			[CallerCount(0)]
			public unsafe void _OpenChatConfirmationModuleAsyncInternal_b__0(DaySceneChatConfirmationPannel pannelInstance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass49_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E63 RID: 36451 RVA: 0x0004CAD9 File Offset: 0x0004ACD9
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F96 RID: 12182
			// (get) Token: 0x06008E64 RID: 36452 RVA: 0x0026EB68 File Offset: 0x0026CD68
			// (set) Token: 0x06008E65 RID: 36453 RVA: 0x0004CAE2 File Offset: 0x0004ACE2
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass49_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CF0 RID: 23792
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005CF1 RID: 23793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CF2 RID: 23794
			private static readonly IntPtr NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0;
		}

		// Token: 0x020005E3 RID: 1507
		[ObfuscatedName("DayScene.UI.UIManager+<OpenChatConfirmationModuleAsyncInternal>d__49")]
		public sealed class _OpenChatConfirmationModuleAsyncInternal_d__49 : ValueType
		{
			// Token: 0x06008E66 RID: 36454 RVA: 0x0026EB98 File Offset: 0x0026CD98
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenChatConfirmationModuleAsyncInternal_d__49()
			{
				Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenChatConfirmationModuleAsyncInternal>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>1__state");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>t__builder");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "onFinish");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>4__this");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_pannelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "pannelVisualMode");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>8__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>u__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, "<>u__2");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, 100666841);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr, 100666842);
			}

			// Token: 0x06008E67 RID: 36455 RVA: 0x0026EC8C File Offset: 0x0026CE8C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55309, RefRangeEnd = 55311, XrefRangeStart = 55271, XrefRangeEnd = 55309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E68 RID: 36456 RVA: 0x0026ECC4 File Offset: 0x0026CEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E69 RID: 36457 RVA: 0x0004CB01 File Offset: 0x0004AD01
			public _OpenChatConfirmationModuleAsyncInternal_d__49(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008E6A RID: 36458 RVA: 0x0004CB0A File Offset: 0x0004AD0A
			public _OpenChatConfirmationModuleAsyncInternal_d__49() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__49>.NativeClassPtr))
			{
			}

			// Token: 0x17002F97 RID: 12183
			// (get) Token: 0x06008E6B RID: 36459 RVA: 0x0026ED0C File Offset: 0x0026CF0C
			// (set) Token: 0x06008E6C RID: 36460 RVA: 0x0004CB1C File Offset: 0x0004AD1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F98 RID: 12184
			// (get) Token: 0x06008E6D RID: 36461 RVA: 0x0026ED34 File Offset: 0x0026CF34
			// (set) Token: 0x06008E6E RID: 36462 RVA: 0x0004CB37 File Offset: 0x0004AD37
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F99 RID: 12185
			// (get) Token: 0x06008E6F RID: 36463 RVA: 0x0026ED64 File Offset: 0x0026CF64
			// (set) Token: 0x06008E70 RID: 36464 RVA: 0x0004CB65 File Offset: 0x0004AD65
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F9A RID: 12186
			// (get) Token: 0x06008E71 RID: 36465 RVA: 0x0026ED94 File Offset: 0x0026CF94
			// (set) Token: 0x06008E72 RID: 36466 RVA: 0x0004CB84 File Offset: 0x0004AD84
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F9B RID: 12187
			// (get) Token: 0x06008E73 RID: 36467 RVA: 0x0026EDC4 File Offset: 0x0026CFC4
			// (set) Token: 0x06008E74 RID: 36468 RVA: 0x0004CBA3 File Offset: 0x0004ADA3
			public unsafe AdpUIPanelManager.PanelVisualMode pannelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_pannelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr_pannelVisualMode)) = value;
				}
			}

			// Token: 0x17002F9C RID: 12188
			// (get) Token: 0x06008E75 RID: 36469 RVA: 0x0026EDEC File Offset: 0x0026CFEC
			// (set) Token: 0x06008E76 RID: 36470 RVA: 0x0004CBBE File Offset: 0x0004ADBE
			public unsafe UIManager.__c__DisplayClass49_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass49_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F9D RID: 12189
			// (get) Token: 0x06008E77 RID: 36471 RVA: 0x0026EE1C File Offset: 0x0026D01C
			// (set) Token: 0x06008E78 RID: 36472 RVA: 0x0004CBDD File Offset: 0x0004ADDD
			public UniTask<DaySceneChatConfirmationPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatConfirmationPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F9E RID: 12190
			// (get) Token: 0x06008E79 RID: 36473 RVA: 0x0026EE4C File Offset: 0x0026D04C
			// (set) Token: 0x06008E7A RID: 36474 RVA: 0x0004CC0B File Offset: 0x0004AE0B
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__49.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005CF3 RID: 23795
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005CF4 RID: 23796
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005CF5 RID: 23797
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005CF6 RID: 23798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005CF7 RID: 23799
			private static readonly IntPtr NativeFieldInfoPtr_pannelVisualMode;

			// Token: 0x04005CF8 RID: 23800
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005CF9 RID: 23801
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005CFA RID: 23802
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005CFB RID: 23803
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005CFC RID: 23804
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E4 RID: 1508
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x06008E7B RID: 36475 RVA: 0x0026EE7C File Offset: 0x0026D07C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr);
				UIManager.__c__DisplayClass53_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr, "onFinish");
				UIManager.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr, 100666843);
				UIManager.__c__DisplayClass53_0.NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr, 100666844);
			}

			// Token: 0x06008E7C RID: 36476 RVA: 0x0026EEE4 File Offset: 0x0026D0E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E7D RID: 36477 RVA: 0x0026EF20 File Offset: 0x0026D120
			[CallerCount(0)]
			public unsafe void _OpenEventSelectionModuleAsyncInternal_b__0(DaySceneEventSelectionPannel _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass53_0.NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E7E RID: 36478 RVA: 0x0004CC39 File Offset: 0x0004AE39
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F9F RID: 12191
			// (get) Token: 0x06008E7F RID: 36479 RVA: 0x0026EF64 File Offset: 0x0026D164
			// (set) Token: 0x06008E80 RID: 36480 RVA: 0x0004CC42 File Offset: 0x0004AE42
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass53_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass53_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005CFD RID: 23805
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005CFE RID: 23806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005CFF RID: 23807
			private static readonly IntPtr NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0;
		}

		// Token: 0x020005E5 RID: 1509
		[ObfuscatedName("DayScene.UI.UIManager+<OpenEventSelectionModuleAsyncInternal>d__53")]
		public sealed class _OpenEventSelectionModuleAsyncInternal_d__53 : ValueType
		{
			// Token: 0x06008E81 RID: 36481 RVA: 0x0026EF94 File Offset: 0x0026D194
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenEventSelectionModuleAsyncInternal_d__53()
			{
				Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenEventSelectionModuleAsyncInternal>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr);
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>1__state");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>t__builder");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "onFinish");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>4__this");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "options");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_useCustomTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "useCustomTitle");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>8__1");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>u__1");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, "<>u__2");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, 100666845);
				UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr, 100666846);
			}

			// Token: 0x06008E82 RID: 36482 RVA: 0x0026F09C File Offset: 0x0026D29C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55352, RefRangeEnd = 55354, XrefRangeStart = 55311, XrefRangeEnd = 55352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E83 RID: 36483 RVA: 0x0026F0D4 File Offset: 0x0026D2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E84 RID: 36484 RVA: 0x0004CC61 File Offset: 0x0004AE61
			public _OpenEventSelectionModuleAsyncInternal_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008E85 RID: 36485 RVA: 0x0004CC6A File Offset: 0x0004AE6A
			public _OpenEventSelectionModuleAsyncInternal_d__53() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__53>.NativeClassPtr))
			{
			}

			// Token: 0x17002FA0 RID: 12192
			// (get) Token: 0x06008E86 RID: 36486 RVA: 0x0026F11C File Offset: 0x0026D31C
			// (set) Token: 0x06008E87 RID: 36487 RVA: 0x0004CC7C File Offset: 0x0004AE7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FA1 RID: 12193
			// (get) Token: 0x06008E88 RID: 36488 RVA: 0x0026F144 File Offset: 0x0026D344
			// (set) Token: 0x06008E89 RID: 36489 RVA: 0x0004CC97 File Offset: 0x0004AE97
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FA2 RID: 12194
			// (get) Token: 0x06008E8A RID: 36490 RVA: 0x0026F174 File Offset: 0x0026D374
			// (set) Token: 0x06008E8B RID: 36491 RVA: 0x0004CCC5 File Offset: 0x0004AEC5
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FA3 RID: 12195
			// (get) Token: 0x06008E8C RID: 36492 RVA: 0x0026F1A4 File Offset: 0x0026D3A4
			// (set) Token: 0x06008E8D RID: 36493 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FA4 RID: 12196
			// (get) Token: 0x06008E8E RID: 36494 RVA: 0x0026F1D4 File Offset: 0x0026D3D4
			// (set) Token: 0x06008E8F RID: 36495 RVA: 0x0004CD03 File Offset: 0x0004AF03
			public unsafe Dictionary<string, Action> options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FA5 RID: 12197
			// (get) Token: 0x06008E90 RID: 36496 RVA: 0x0026F204 File Offset: 0x0026D404
			// (set) Token: 0x06008E91 RID: 36497 RVA: 0x0004CD22 File Offset: 0x0004AF22
			public unsafe bool useCustomTitle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_useCustomTitle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr_useCustomTitle)) = value;
				}
			}

			// Token: 0x17002FA6 RID: 12198
			// (get) Token: 0x06008E92 RID: 36498 RVA: 0x0026F22C File Offset: 0x0026D42C
			// (set) Token: 0x06008E93 RID: 36499 RVA: 0x0004CD3D File Offset: 0x0004AF3D
			public unsafe UIManager.__c__DisplayClass53_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass53_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FA7 RID: 12199
			// (get) Token: 0x06008E94 RID: 36500 RVA: 0x0026F25C File Offset: 0x0026D45C
			// (set) Token: 0x06008E95 RID: 36501 RVA: 0x0004CD5C File Offset: 0x0004AF5C
			public UniTask<DaySceneEventSelectionPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneEventSelectionPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneEventSelectionPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneEventSelectionPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FA8 RID: 12200
			// (get) Token: 0x06008E96 RID: 36502 RVA: 0x0026F28C File Offset: 0x0026D48C
			// (set) Token: 0x06008E97 RID: 36503 RVA: 0x0004CD8A File Offset: 0x0004AF8A
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__53.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D00 RID: 23808
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D01 RID: 23809
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D02 RID: 23810
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04005D03 RID: 23811
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D04 RID: 23812
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04005D05 RID: 23813
			private static readonly IntPtr NativeFieldInfoPtr_useCustomTitle;

			// Token: 0x04005D06 RID: 23814
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005D07 RID: 23815
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D08 RID: 23816
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D09 RID: 23817
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D0A RID: 23818
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E6 RID: 1510
		[ObfuscatedName("DayScene.UI.UIManager+<OpenPartnerSelectionModuleAsync>d__54")]
		public sealed class _OpenPartnerSelectionModuleAsync_d__54 : ValueType
		{
			// Token: 0x06008E98 RID: 36504 RVA: 0x0026F2BC File Offset: 0x0026D4BC
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenPartnerSelectionModuleAsync_d__54()
			{
				Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenPartnerSelectionModuleAsync>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr);
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, "<>1__state");
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, "<>t__builder");
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, "<>4__this");
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr_dataSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, "dataSource");
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, "<>u__1");
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, 100666847);
				UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr, 100666848);
			}

			// Token: 0x06008E99 RID: 36505 RVA: 0x0026F374 File Offset: 0x0026D574
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55400, RefRangeEnd = 55402, XrefRangeStart = 55354, XrefRangeEnd = 55400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E9A RID: 36506 RVA: 0x0026F3AC File Offset: 0x0026D5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008E9B RID: 36507 RVA: 0x0004CDB8 File Offset: 0x0004AFB8
			public _OpenPartnerSelectionModuleAsync_d__54(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008E9C RID: 36508 RVA: 0x0004CDC1 File Offset: 0x0004AFC1
			public _OpenPartnerSelectionModuleAsync_d__54() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenPartnerSelectionModuleAsync_d__54>.NativeClassPtr))
			{
			}

			// Token: 0x17002FA9 RID: 12201
			// (get) Token: 0x06008E9D RID: 36509 RVA: 0x0026F3F4 File Offset: 0x0026D5F4
			// (set) Token: 0x06008E9E RID: 36510 RVA: 0x0004CDD3 File Offset: 0x0004AFD3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FAA RID: 12202
			// (get) Token: 0x06008E9F RID: 36511 RVA: 0x0026F41C File Offset: 0x0026D61C
			// (set) Token: 0x06008EA0 RID: 36512 RVA: 0x0004CDEE File Offset: 0x0004AFEE
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FAB RID: 12203
			// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x0026F44C File Offset: 0x0026D64C
			// (set) Token: 0x06008EA2 RID: 36514 RVA: 0x0004CE1C File Offset: 0x0004B01C
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FAC RID: 12204
			// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x0026F47C File Offset: 0x0026D67C
			// (set) Token: 0x06008EA4 RID: 36516 RVA: 0x0004CE3B File Offset: 0x0004B03B
			public DaySceneIzakayaSelectorPartnerSubPannel.OpenContext dataSource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr_dataSource);
					return new DaySceneIzakayaSelectorPartnerSubPannel.OpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr_dataSource), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FAD RID: 12205
			// (get) Token: 0x06008EA5 RID: 36517 RVA: 0x0026F4AC File Offset: 0x0026D6AC
			// (set) Token: 0x06008EA6 RID: 36518 RVA: 0x0004CE69 File Offset: 0x0004B069
			public UniTask<DaySceneIzakayaSelectorPartnerSubPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneIzakayaSelectorPartnerSubPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DaySceneIzakayaSelectorPartnerSubPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenPartnerSelectionModuleAsync_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DaySceneIzakayaSelectorPartnerSubPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D0B RID: 23819
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D0C RID: 23820
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D0D RID: 23821
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D0E RID: 23822
			private static readonly IntPtr NativeFieldInfoPtr_dataSource;

			// Token: 0x04005D0F RID: 23823
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D10 RID: 23824
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D11 RID: 23825
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E7 RID: 1511
		[ObfuscatedName("DayScene.UI.UIManager+<OpenIzakayaSelectionModuleAsync>d__55")]
		public sealed class _OpenIzakayaSelectionModuleAsync_d__55 : ValueType
		{
			// Token: 0x06008EA7 RID: 36519 RVA: 0x0026F4DC File Offset: 0x0026D6DC
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenIzakayaSelectionModuleAsync_d__55()
			{
				Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenIzakayaSelectionModuleAsync>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr);
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "<>1__state");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "<>t__builder");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "<>4__this");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_izakayaLockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "izakayaLockType");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_overrideIzakayaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "overrideIzakayaData");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "<>u__1");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, "<>u__2");
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, 100666849);
				UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr, 100666850);
			}

			// Token: 0x06008EA8 RID: 36520 RVA: 0x0026F5BC File Offset: 0x0026D7BC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 55497, RefRangeEnd = 55500, XrefRangeStart = 55402, XrefRangeEnd = 55497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EA9 RID: 36521 RVA: 0x0026F5F4 File Offset: 0x0026D7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55500, XrefRangeEnd = 55503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EAA RID: 36522 RVA: 0x0004CE97 File Offset: 0x0004B097
			public _OpenIzakayaSelectionModuleAsync_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008EAB RID: 36523 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
			public _OpenIzakayaSelectionModuleAsync_d__55() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenIzakayaSelectionModuleAsync_d__55>.NativeClassPtr))
			{
			}

			// Token: 0x17002FAE RID: 12206
			// (get) Token: 0x06008EAC RID: 36524 RVA: 0x0026F63C File Offset: 0x0026D83C
			// (set) Token: 0x06008EAD RID: 36525 RVA: 0x0004CEB2 File Offset: 0x0004B0B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FAF RID: 12207
			// (get) Token: 0x06008EAE RID: 36526 RVA: 0x0026F664 File Offset: 0x0026D864
			// (set) Token: 0x06008EAF RID: 36527 RVA: 0x0004CECD File Offset: 0x0004B0CD
			public AsyncUniTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FB0 RID: 12208
			// (get) Token: 0x06008EB0 RID: 36528 RVA: 0x0026F694 File Offset: 0x0026D894
			// (set) Token: 0x06008EB1 RID: 36529 RVA: 0x0004CEFB File Offset: 0x0004B0FB
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FB1 RID: 12209
			// (get) Token: 0x06008EB2 RID: 36530 RVA: 0x0026F6C4 File Offset: 0x0026D8C4
			// (set) Token: 0x06008EB3 RID: 36531 RVA: 0x0004CF1A File Offset: 0x0004B11A
			public unsafe SchedulerNode.Trigger.IzakayaLockType izakayaLockType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_izakayaLockType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_izakayaLockType)) = value;
				}
			}

			// Token: 0x17002FB2 RID: 12210
			// (get) Token: 0x06008EB4 RID: 36532 RVA: 0x0026F6EC File Offset: 0x0026D8EC
			// (set) Token: 0x06008EB5 RID: 36533 RVA: 0x0004CF35 File Offset: 0x0004B135
			public unsafe Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> overrideIzakayaData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_overrideIzakayaData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr_overrideIzakayaData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FB3 RID: 12211
			// (get) Token: 0x06008EB6 RID: 36534 RVA: 0x0026F71C File Offset: 0x0026D91C
			// (set) Token: 0x06008EB7 RID: 36535 RVA: 0x0004CF54 File Offset: 0x0004B154
			public UniTask<IzakayaSelectorPanel_New>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__1);
					return new UniTask<IzakayaSelectorPanel_New>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IzakayaSelectorPanel_New>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IzakayaSelectorPanel_New>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FB4 RID: 12212
			// (get) Token: 0x06008EB8 RID: 36536 RVA: 0x0026F74C File Offset: 0x0026D94C
			// (set) Token: 0x06008EB9 RID: 36537 RVA: 0x0004CF82 File Offset: 0x0004B182
			public UniTask<int>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__2);
					return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenIzakayaSelectionModuleAsync_d__55.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D12 RID: 23826
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D13 RID: 23827
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D14 RID: 23828
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D15 RID: 23829
			private static readonly IntPtr NativeFieldInfoPtr_izakayaLockType;

			// Token: 0x04005D16 RID: 23830
			private static readonly IntPtr NativeFieldInfoPtr_overrideIzakayaData;

			// Token: 0x04005D17 RID: 23831
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D18 RID: 23832
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D19 RID: 23833
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D1A RID: 23834
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E8 RID: 1512
		[ObfuscatedName("DayScene.UI.UIManager+<OpenAfterChatMenuAsyncInternal>d__61")]
		public sealed class _OpenAfterChatMenuAsyncInternal_d__61 : ValueType
		{
			// Token: 0x06008EBA RID: 36538 RVA: 0x0026F77C File Offset: 0x0026D97C
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenAfterChatMenuAsyncInternal_d__61()
			{
				Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenAfterChatMenuAsyncInternal>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr);
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "<>1__state");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "<>t__builder");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "<>4__this");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_specialCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "specialCharacterLabel");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_shouldTriggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "shouldTriggerEvent");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "onWillExecuteDayEndEventCallback");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "previousPanelVisualMode");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onExitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "onExitCallback");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, "<>u__1");
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, 100666851);
				UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr, 100666852);
			}

			// Token: 0x06008EBB RID: 36539 RVA: 0x0026F884 File Offset: 0x0026DA84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55554, RefRangeEnd = 55556, XrefRangeStart = 55503, XrefRangeEnd = 55554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EBC RID: 36540 RVA: 0x0026F8BC File Offset: 0x0026DABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EBD RID: 36541 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
			public _OpenAfterChatMenuAsyncInternal_d__61(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008EBE RID: 36542 RVA: 0x0004CFB9 File Offset: 0x0004B1B9
			public _OpenAfterChatMenuAsyncInternal_d__61() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__61>.NativeClassPtr))
			{
			}

			// Token: 0x17002FB5 RID: 12213
			// (get) Token: 0x06008EBF RID: 36543 RVA: 0x0026F904 File Offset: 0x0026DB04
			// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x0004CFCB File Offset: 0x0004B1CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FB6 RID: 12214
			// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x0026F92C File Offset: 0x0026DB2C
			// (set) Token: 0x06008EC2 RID: 36546 RVA: 0x0004CFE6 File Offset: 0x0004B1E6
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FB7 RID: 12215
			// (get) Token: 0x06008EC3 RID: 36547 RVA: 0x0026F95C File Offset: 0x0026DB5C
			// (set) Token: 0x06008EC4 RID: 36548 RVA: 0x0004D014 File Offset: 0x0004B214
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FB8 RID: 12216
			// (get) Token: 0x06008EC5 RID: 36549 RVA: 0x0026F98C File Offset: 0x0026DB8C
			// (set) Token: 0x06008EC6 RID: 36550 RVA: 0x0004D033 File Offset: 0x0004B233
			public unsafe string specialCharacterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_specialCharacterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_specialCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002FB9 RID: 12217
			// (get) Token: 0x06008EC7 RID: 36551 RVA: 0x0026F9B4 File Offset: 0x0026DBB4
			// (set) Token: 0x06008EC8 RID: 36552 RVA: 0x0004D052 File Offset: 0x0004B252
			public unsafe bool shouldTriggerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_shouldTriggerEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_shouldTriggerEvent)) = value;
				}
			}

			// Token: 0x17002FBA RID: 12218
			// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x0026F9DC File Offset: 0x0026DBDC
			// (set) Token: 0x06008ECA RID: 36554 RVA: 0x0004D06D File Offset: 0x0004B26D
			public unsafe Action<Action> onWillExecuteDayEndEventCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onWillExecuteDayEndEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FBB RID: 12219
			// (get) Token: 0x06008ECB RID: 36555 RVA: 0x0026FA0C File Offset: 0x0026DC0C
			// (set) Token: 0x06008ECC RID: 36556 RVA: 0x0004D08C File Offset: 0x0004B28C
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17002FBC RID: 12220
			// (get) Token: 0x06008ECD RID: 36557 RVA: 0x0026FA34 File Offset: 0x0026DC34
			// (set) Token: 0x06008ECE RID: 36558 RVA: 0x0004D0A7 File Offset: 0x0004B2A7
			public unsafe Action onExitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onExitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr_onExitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FBD RID: 12221
			// (get) Token: 0x06008ECF RID: 36559 RVA: 0x0026FA64 File Offset: 0x0026DC64
			// (set) Token: 0x06008ED0 RID: 36560 RVA: 0x0004D0C6 File Offset: 0x0004B2C6
			public UniTask<DaySceneChatSelectionPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatSelectionPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__61.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D1B RID: 23835
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D1C RID: 23836
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D1D RID: 23837
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D1E RID: 23838
			private static readonly IntPtr NativeFieldInfoPtr_specialCharacterLabel;

			// Token: 0x04005D1F RID: 23839
			private static readonly IntPtr NativeFieldInfoPtr_shouldTriggerEvent;

			// Token: 0x04005D20 RID: 23840
			private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteDayEndEventCallback;

			// Token: 0x04005D21 RID: 23841
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x04005D22 RID: 23842
			private static readonly IntPtr NativeFieldInfoPtr_onExitCallback;

			// Token: 0x04005D23 RID: 23843
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D24 RID: 23844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D25 RID: 23845
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005E9 RID: 1513
		[ObfuscatedName("DayScene.UI.UIManager+<OpenAfterChatMenuAsyncInternal>d__63")]
		public sealed class _OpenAfterChatMenuAsyncInternal_d__63 : ValueType
		{
			// Token: 0x06008ED1 RID: 36561 RVA: 0x0026FA94 File Offset: 0x0026DC94
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenAfterChatMenuAsyncInternal_d__63()
			{
				Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenAfterChatMenuAsyncInternal>d__63");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr);
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "<>1__state");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "<>t__builder");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "<>4__this");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_configurationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "configurationCallback");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_normalCharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "normalCharacterLabel");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_trackedMerchant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "trackedMerchant");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "previousPanelVisualMode");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_onExitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "onExitCallback");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, "<>u__1");
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, 100666853);
				UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr, 100666854);
			}

			// Token: 0x06008ED2 RID: 36562 RVA: 0x0026FB9C File Offset: 0x0026DD9C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55608, RefRangeEnd = 55610, XrefRangeStart = 55556, XrefRangeEnd = 55608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ED3 RID: 36563 RVA: 0x0026FBD4 File Offset: 0x0026DDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ED4 RID: 36564 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
			public _OpenAfterChatMenuAsyncInternal_d__63(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008ED5 RID: 36565 RVA: 0x0004D0FD File Offset: 0x0004B2FD
			public _OpenAfterChatMenuAsyncInternal_d__63() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__63>.NativeClassPtr))
			{
			}

			// Token: 0x17002FBE RID: 12222
			// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x0026FC1C File Offset: 0x0026DE1C
			// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x0004D10F File Offset: 0x0004B30F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FBF RID: 12223
			// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x0026FC44 File Offset: 0x0026DE44
			// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x0004D12A File Offset: 0x0004B32A
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FC0 RID: 12224
			// (get) Token: 0x06008EDA RID: 36570 RVA: 0x0026FC74 File Offset: 0x0026DE74
			// (set) Token: 0x06008EDB RID: 36571 RVA: 0x0004D158 File Offset: 0x0004B358
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FC1 RID: 12225
			// (get) Token: 0x06008EDC RID: 36572 RVA: 0x0026FCA4 File Offset: 0x0026DEA4
			// (set) Token: 0x06008EDD RID: 36573 RVA: 0x0004D177 File Offset: 0x0004B377
			public unsafe Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback> configurationCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_configurationCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_configurationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FC2 RID: 12226
			// (get) Token: 0x06008EDE RID: 36574 RVA: 0x0026FCD4 File Offset: 0x0026DED4
			// (set) Token: 0x06008EDF RID: 36575 RVA: 0x0004D196 File Offset: 0x0004B396
			public unsafe string normalCharacterLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_normalCharacterLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_normalCharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002FC3 RID: 12227
			// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x0026FCFC File Offset: 0x0026DEFC
			// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x0004D1B5 File Offset: 0x0004B3B5
			public unsafe TrackedMerchant trackedMerchant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_trackedMerchant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_trackedMerchant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FC4 RID: 12228
			// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x0026FD2C File Offset: 0x0026DF2C
			// (set) Token: 0x06008EE3 RID: 36579 RVA: 0x0004D1D4 File Offset: 0x0004B3D4
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17002FC5 RID: 12229
			// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x0026FD54 File Offset: 0x0026DF54
			// (set) Token: 0x06008EE5 RID: 36581 RVA: 0x0004D1EF File Offset: 0x0004B3EF
			public unsafe Action onExitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_onExitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr_onExitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FC6 RID: 12230
			// (get) Token: 0x06008EE6 RID: 36582 RVA: 0x0026FD84 File Offset: 0x0026DF84
			// (set) Token: 0x06008EE7 RID: 36583 RVA: 0x0004D20E File Offset: 0x0004B40E
			public UniTask<DaySceneChatSelectionPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatSelectionPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__63.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D26 RID: 23846
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D27 RID: 23847
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D28 RID: 23848
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D29 RID: 23849
			private static readonly IntPtr NativeFieldInfoPtr_configurationCallback;

			// Token: 0x04005D2A RID: 23850
			private static readonly IntPtr NativeFieldInfoPtr_normalCharacterLabel;

			// Token: 0x04005D2B RID: 23851
			private static readonly IntPtr NativeFieldInfoPtr_trackedMerchant;

			// Token: 0x04005D2C RID: 23852
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x04005D2D RID: 23853
			private static readonly IntPtr NativeFieldInfoPtr_onExitCallback;

			// Token: 0x04005D2E RID: 23854
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D2F RID: 23855
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D30 RID: 23856
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005EA RID: 1514
		[ObfuscatedName("DayScene.UI.UIManager+<OpenAfterChatMenuAsyncInternal>d__65")]
		public sealed class _OpenAfterChatMenuAsyncInternal_d__65 : ValueType
		{
			// Token: 0x06008EE8 RID: 36584 RVA: 0x0026FDB4 File Offset: 0x0026DFB4
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenAfterChatMenuAsyncInternal_d__65()
			{
				Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenAfterChatMenuAsyncInternal>d__65");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr);
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "<>1__state");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "<>t__builder");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "<>4__this");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_configurationCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "configurationCallbacks");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonTitleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "endButtonTitleKey");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_indexToSelct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "indexToSelct");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "endButtonAction");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "previousPanelVisualMode");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_onExitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "onExitCallback");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, "<>u__1");
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, 100666855);
				UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr, 100666856);
			}

			// Token: 0x06008EE9 RID: 36585 RVA: 0x0026FED0 File Offset: 0x0026E0D0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55662, RefRangeEnd = 55664, XrefRangeStart = 55610, XrefRangeEnd = 55662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EEA RID: 36586 RVA: 0x0026FF08 File Offset: 0x0026E108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008EEB RID: 36587 RVA: 0x0004D23C File Offset: 0x0004B43C
			public _OpenAfterChatMenuAsyncInternal_d__65(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008EEC RID: 36588 RVA: 0x0004D245 File Offset: 0x0004B445
			public _OpenAfterChatMenuAsyncInternal_d__65() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenAfterChatMenuAsyncInternal_d__65>.NativeClassPtr))
			{
			}

			// Token: 0x17002FC7 RID: 12231
			// (get) Token: 0x06008EED RID: 36589 RVA: 0x0026FF50 File Offset: 0x0026E150
			// (set) Token: 0x06008EEE RID: 36590 RVA: 0x0004D257 File Offset: 0x0004B457
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FC8 RID: 12232
			// (get) Token: 0x06008EEF RID: 36591 RVA: 0x0026FF78 File Offset: 0x0026E178
			// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x0004D272 File Offset: 0x0004B472
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FC9 RID: 12233
			// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x0026FFA8 File Offset: 0x0026E1A8
			// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x0004D2A0 File Offset: 0x0004B4A0
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FCA RID: 12234
			// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x0026FFD8 File Offset: 0x0026E1D8
			// (set) Token: 0x06008EF4 RID: 36596 RVA: 0x0004D2BF File Offset: 0x0004B4BF
			public unsafe Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> configurationCallbacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_configurationCallbacks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_configurationCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FCB RID: 12235
			// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x00270008 File Offset: 0x0026E208
			// (set) Token: 0x06008EF6 RID: 36598 RVA: 0x0004D2DE File Offset: 0x0004B4DE
			public unsafe string endButtonTitleKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonTitleKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonTitleKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002FCC RID: 12236
			// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x00270030 File Offset: 0x0026E230
			// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x0004D2FD File Offset: 0x0004B4FD
			public unsafe int indexToSelct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_indexToSelct);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_indexToSelct)) = value;
				}
			}

			// Token: 0x17002FCD RID: 12237
			// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x00270058 File Offset: 0x0026E258
			// (set) Token: 0x06008EFA RID: 36602 RVA: 0x0004D318 File Offset: 0x0004B518
			public unsafe DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_endButtonAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FCE RID: 12238
			// (get) Token: 0x06008EFB RID: 36603 RVA: 0x00270088 File Offset: 0x0026E288
			// (set) Token: 0x06008EFC RID: 36604 RVA: 0x0004D337 File Offset: 0x0004B537
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17002FCF RID: 12239
			// (get) Token: 0x06008EFD RID: 36605 RVA: 0x002700B0 File Offset: 0x0026E2B0
			// (set) Token: 0x06008EFE RID: 36606 RVA: 0x0004D352 File Offset: 0x0004B552
			public unsafe Action onExitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_onExitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr_onExitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FD0 RID: 12240
			// (get) Token: 0x06008EFF RID: 36607 RVA: 0x002700E0 File Offset: 0x0026E2E0
			// (set) Token: 0x06008F00 RID: 36608 RVA: 0x0004D371 File Offset: 0x0004B571
			public UniTask<DaySceneChatSelectionPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatSelectionPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenAfterChatMenuAsyncInternal_d__65.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatSelectionPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D31 RID: 23857
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D32 RID: 23858
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D33 RID: 23859
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D34 RID: 23860
			private static readonly IntPtr NativeFieldInfoPtr_configurationCallbacks;

			// Token: 0x04005D35 RID: 23861
			private static readonly IntPtr NativeFieldInfoPtr_endButtonTitleKey;

			// Token: 0x04005D36 RID: 23862
			private static readonly IntPtr NativeFieldInfoPtr_indexToSelct;

			// Token: 0x04005D37 RID: 23863
			private static readonly IntPtr NativeFieldInfoPtr_endButtonAction;

			// Token: 0x04005D38 RID: 23864
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x04005D39 RID: 23865
			private static readonly IntPtr NativeFieldInfoPtr_onExitCallback;

			// Token: 0x04005D3A RID: 23866
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D3B RID: 23867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D3C RID: 23868
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005EB RID: 1515
		[ObfuscatedName("DayScene.UI.UIManager+<OpenShopPannelAsyncInternal>d__67")]
		public sealed class _OpenShopPannelAsyncInternal_d__67 : ValueType
		{
			// Token: 0x06008F01 RID: 36609 RVA: 0x00270110 File Offset: 0x0026E310
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenShopPannelAsyncInternal_d__67()
			{
				Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenShopPannelAsyncInternal>d__67");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr);
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "<>1__state");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "<>t__builder");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "<>4__this");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_merchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "merchantData");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "onFinishCallback");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, "<>u__1");
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, 100666857);
				UIManager._OpenShopPannelAsyncInternal_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr, 100666858);
			}

			// Token: 0x06008F02 RID: 36610 RVA: 0x002701DC File Offset: 0x0026E3DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55715, RefRangeEnd = 55717, XrefRangeStart = 55664, XrefRangeEnd = 55715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenShopPannelAsyncInternal_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F03 RID: 36611 RVA: 0x00270214 File Offset: 0x0026E414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenShopPannelAsyncInternal_d__67.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F04 RID: 36612 RVA: 0x0004D39F File Offset: 0x0004B59F
			public _OpenShopPannelAsyncInternal_d__67(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F05 RID: 36613 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
			public _OpenShopPannelAsyncInternal_d__67() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenShopPannelAsyncInternal_d__67>.NativeClassPtr))
			{
			}

			// Token: 0x17002FD1 RID: 12241
			// (get) Token: 0x06008F06 RID: 36614 RVA: 0x0027025C File Offset: 0x0026E45C
			// (set) Token: 0x06008F07 RID: 36615 RVA: 0x0004D3BA File Offset: 0x0004B5BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FD2 RID: 12242
			// (get) Token: 0x06008F08 RID: 36616 RVA: 0x00270284 File Offset: 0x0026E484
			// (set) Token: 0x06008F09 RID: 36617 RVA: 0x0004D3D5 File Offset: 0x0004B5D5
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FD3 RID: 12243
			// (get) Token: 0x06008F0A RID: 36618 RVA: 0x002702B4 File Offset: 0x0026E4B4
			// (set) Token: 0x06008F0B RID: 36619 RVA: 0x0004D403 File Offset: 0x0004B603
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FD4 RID: 12244
			// (get) Token: 0x06008F0C RID: 36620 RVA: 0x002702E4 File Offset: 0x0026E4E4
			// (set) Token: 0x06008F0D RID: 36621 RVA: 0x0004D422 File Offset: 0x0004B622
			public unsafe TrackedMerchant merchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_merchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_merchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FD5 RID: 12245
			// (get) Token: 0x06008F0E RID: 36622 RVA: 0x00270314 File Offset: 0x0026E514
			// (set) Token: 0x06008F0F RID: 36623 RVA: 0x0004D441 File Offset: 0x0004B641
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FD6 RID: 12246
			// (get) Token: 0x06008F10 RID: 36624 RVA: 0x00270344 File Offset: 0x0026E544
			// (set) Token: 0x06008F11 RID: 36625 RVA: 0x0004D460 File Offset: 0x0004B660
			public UniTask<DaySceneShopPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneShopPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneShopPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenShopPannelAsyncInternal_d__67.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneShopPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D3D RID: 23869
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D3E RID: 23870
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D3F RID: 23871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D40 RID: 23872
			private static readonly IntPtr NativeFieldInfoPtr_merchantData;

			// Token: 0x04005D41 RID: 23873
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x04005D42 RID: 23874
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D43 RID: 23875
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D44 RID: 23876
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005EC RID: 1516
		[ObfuscatedName("DayScene.UI.UIManager+<OpenKourindouPannelAsyncInternal>d__69")]
		public sealed class _OpenKourindouPannelAsyncInternal_d__69 : ValueType
		{
			// Token: 0x06008F12 RID: 36626 RVA: 0x00270374 File Offset: 0x0026E574
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenKourindouPannelAsyncInternal_d__69()
			{
				Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenKourindouPannelAsyncInternal>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr);
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "<>1__state");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "<>t__builder");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "<>4__this");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_merchantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "merchantData");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "onFinishCallback");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, "<>u__1");
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, 100666859);
				UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr, 100666860);
			}

			// Token: 0x06008F13 RID: 36627 RVA: 0x00270440 File Offset: 0x0026E640
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55768, RefRangeEnd = 55770, XrefRangeStart = 55717, XrefRangeEnd = 55768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F14 RID: 36628 RVA: 0x00270478 File Offset: 0x0026E678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F15 RID: 36629 RVA: 0x0004D48E File Offset: 0x0004B68E
			public _OpenKourindouPannelAsyncInternal_d__69(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F16 RID: 36630 RVA: 0x0004D497 File Offset: 0x0004B697
			public _OpenKourindouPannelAsyncInternal_d__69() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenKourindouPannelAsyncInternal_d__69>.NativeClassPtr))
			{
			}

			// Token: 0x17002FD7 RID: 12247
			// (get) Token: 0x06008F17 RID: 36631 RVA: 0x002704C0 File Offset: 0x0026E6C0
			// (set) Token: 0x06008F18 RID: 36632 RVA: 0x0004D4A9 File Offset: 0x0004B6A9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FD8 RID: 12248
			// (get) Token: 0x06008F19 RID: 36633 RVA: 0x002704E8 File Offset: 0x0026E6E8
			// (set) Token: 0x06008F1A RID: 36634 RVA: 0x0004D4C4 File Offset: 0x0004B6C4
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FD9 RID: 12249
			// (get) Token: 0x06008F1B RID: 36635 RVA: 0x00270518 File Offset: 0x0026E718
			// (set) Token: 0x06008F1C RID: 36636 RVA: 0x0004D4F2 File Offset: 0x0004B6F2
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FDA RID: 12250
			// (get) Token: 0x06008F1D RID: 36637 RVA: 0x00270548 File Offset: 0x0026E748
			// (set) Token: 0x06008F1E RID: 36638 RVA: 0x0004D511 File Offset: 0x0004B711
			public unsafe TrackedMerchant merchantData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_merchantData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_merchantData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FDB RID: 12251
			// (get) Token: 0x06008F1F RID: 36639 RVA: 0x00270578 File Offset: 0x0026E778
			// (set) Token: 0x06008F20 RID: 36640 RVA: 0x0004D530 File Offset: 0x0004B730
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FDC RID: 12252
			// (get) Token: 0x06008F21 RID: 36641 RVA: 0x002705A8 File Offset: 0x0026E7A8
			// (set) Token: 0x06008F22 RID: 36642 RVA: 0x0004D54F File Offset: 0x0004B74F
			public UniTask<DaySceneKourindoShopPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneKourindoShopPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneKourindoShopPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenKourindouPannelAsyncInternal_d__69.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneKourindoShopPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D45 RID: 23877
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D46 RID: 23878
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D47 RID: 23879
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005D48 RID: 23880
			private static readonly IntPtr NativeFieldInfoPtr_merchantData;

			// Token: 0x04005D49 RID: 23881
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x04005D4A RID: 23882
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D4B RID: 23883
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D4C RID: 23884
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005ED RID: 1517
		[ObfuscatedName("DayScene.UI.UIManager+<OpenCreatorsBoxPanelAsync>d__87")]
		public sealed class _OpenCreatorsBoxPanelAsync_d__87 : ValueType
		{
			// Token: 0x06008F23 RID: 36643 RVA: 0x002705D8 File Offset: 0x0026E7D8
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenCreatorsBoxPanelAsync_d__87()
			{
				Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenCreatorsBoxPanelAsync>d__87");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr);
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, "<>1__state");
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, "<>t__builder");
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, "<>u__1");
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, "<>u__2");
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, 100666861);
				UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr, 100666862);
			}

			// Token: 0x06008F24 RID: 36644 RVA: 0x0027067C File Offset: 0x0026E87C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55909, RefRangeEnd = 55911, XrefRangeStart = 55770, XrefRangeEnd = 55909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F25 RID: 36645 RVA: 0x002706B4 File Offset: 0x0026E8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F26 RID: 36646 RVA: 0x0004D57D File Offset: 0x0004B77D
			public _OpenCreatorsBoxPanelAsync_d__87(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F27 RID: 36647 RVA: 0x0004D586 File Offset: 0x0004B786
			public _OpenCreatorsBoxPanelAsync_d__87() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenCreatorsBoxPanelAsync_d__87>.NativeClassPtr))
			{
			}

			// Token: 0x17002FDD RID: 12253
			// (get) Token: 0x06008F28 RID: 36648 RVA: 0x002706FC File Offset: 0x0026E8FC
			// (set) Token: 0x06008F29 RID: 36649 RVA: 0x0004D598 File Offset: 0x0004B798
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FDE RID: 12254
			// (get) Token: 0x06008F2A RID: 36650 RVA: 0x00270724 File Offset: 0x0026E924
			// (set) Token: 0x06008F2B RID: 36651 RVA: 0x0004D5B3 File Offset: 0x0004B7B3
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FDF RID: 12255
			// (get) Token: 0x06008F2C RID: 36652 RVA: 0x00270754 File Offset: 0x0026E954
			// (set) Token: 0x06008F2D RID: 36653 RVA: 0x0004D5E1 File Offset: 0x0004B7E1
			public UniTask<DLC5_CreatorsBoxPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_CreatorsBoxPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_CreatorsBoxPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_CreatorsBoxPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FE0 RID: 12256
			// (get) Token: 0x06008F2E RID: 36654 RVA: 0x00270784 File Offset: 0x0026E984
			// (set) Token: 0x06008F2F RID: 36655 RVA: 0x0004D60F File Offset: 0x0004B80F
			public UniTask<DLC5_CreatorsBoxPanel.OpenContext>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC5_CreatorsBoxPanel.OpenContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_CreatorsBoxPanel.OpenContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenCreatorsBoxPanelAsync_d__87.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_CreatorsBoxPanel.OpenContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D4D RID: 23885
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D4E RID: 23886
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D4F RID: 23887
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D50 RID: 23888
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D51 RID: 23889
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D52 RID: 23890
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005EE RID: 1518
		[ObfuscatedName("DayScene.UI.UIManager+<OpenInfiniteIngredientsPanelAsync>d__88")]
		public sealed class _OpenInfiniteIngredientsPanelAsync_d__88 : ValueType
		{
			// Token: 0x06008F30 RID: 36656 RVA: 0x002707B4 File Offset: 0x0026E9B4
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenInfiniteIngredientsPanelAsync_d__88()
			{
				Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenInfiniteIngredientsPanelAsync>d__88");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr);
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, "<>1__state");
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, "<>t__builder");
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr_activeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, "activeCount");
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, "<>u__1");
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, 100666863);
				UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr, 100666864);
			}

			// Token: 0x06008F31 RID: 36657 RVA: 0x00270858 File Offset: 0x0026EA58
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 55987, RefRangeEnd = 55989, XrefRangeStart = 55911, XrefRangeEnd = 55987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F32 RID: 36658 RVA: 0x00270890 File Offset: 0x0026EA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F33 RID: 36659 RVA: 0x0004D63D File Offset: 0x0004B83D
			public _OpenInfiniteIngredientsPanelAsync_d__88(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F34 RID: 36660 RVA: 0x0004D646 File Offset: 0x0004B846
			public _OpenInfiniteIngredientsPanelAsync_d__88() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenInfiniteIngredientsPanelAsync_d__88>.NativeClassPtr))
			{
			}

			// Token: 0x17002FE1 RID: 12257
			// (get) Token: 0x06008F35 RID: 36661 RVA: 0x002708D8 File Offset: 0x0026EAD8
			// (set) Token: 0x06008F36 RID: 36662 RVA: 0x0004D658 File Offset: 0x0004B858
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FE2 RID: 12258
			// (get) Token: 0x06008F37 RID: 36663 RVA: 0x00270900 File Offset: 0x0026EB00
			// (set) Token: 0x06008F38 RID: 36664 RVA: 0x0004D673 File Offset: 0x0004B873
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FE3 RID: 12259
			// (get) Token: 0x06008F39 RID: 36665 RVA: 0x00270930 File Offset: 0x0026EB30
			// (set) Token: 0x06008F3A RID: 36666 RVA: 0x0004D6A1 File Offset: 0x0004B8A1
			public unsafe DLC5_InfiniteSelectionPanel.ActiveCount activeCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr_activeCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr_activeCount)) = value;
				}
			}

			// Token: 0x17002FE4 RID: 12260
			// (get) Token: 0x06008F3B RID: 36667 RVA: 0x00270958 File Offset: 0x0026EB58
			// (set) Token: 0x06008F3C RID: 36668 RVA: 0x0004D6BC File Offset: 0x0004B8BC
			public UniTask<DLC5_InfiniteSelectionPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_InfiniteSelectionPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_InfiniteSelectionPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenInfiniteIngredientsPanelAsync_d__88.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_InfiniteSelectionPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D53 RID: 23891
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D54 RID: 23892
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D55 RID: 23893
			private static readonly IntPtr NativeFieldInfoPtr_activeCount;

			// Token: 0x04005D56 RID: 23894
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D57 RID: 23895
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D58 RID: 23896
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005EF RID: 1519
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x06008F3D RID: 36669 RVA: 0x00270988 File Offset: 0x0026EB88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr);
				UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_dlc5RogueLikeMainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "dlc5RogueLikeMainPanel");
				UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "profile");
				UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_loadPanelHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "loadPanelHandle");
				UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_rogueLikeAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "rogueLikeAchievement");
				UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_onFadeFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "onFadeFinish");
				UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, 100666865);
				UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, 100666866);
				UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, 100666867);
				UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, 100666868);
				UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, 100666869);
			}

			// Token: 0x06008F3E RID: 36670 RVA: 0x00270A7C File Offset: 0x0026EC7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F3F RID: 36671 RVA: 0x00270AB8 File Offset: 0x0026ECB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56178, XrefRangeEnd = 56184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _OpenRogueLikeMainPanelAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F40 RID: 36672 RVA: 0x00270AF0 File Offset: 0x0026ECF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56184, XrefRangeEnd = 56190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F41 RID: 36673 RVA: 0x00270B28 File Offset: 0x0026ED28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56190, XrefRangeEnd = 56196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F42 RID: 36674 RVA: 0x00270B60 File Offset: 0x0026ED60
			[CallerCount(0)]
			public unsafe void _OpenRogueLikeMainPanelAsync_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F43 RID: 36675 RVA: 0x0004D6EA File Offset: 0x0004B8EA
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002FE5 RID: 12261
			// (get) Token: 0x06008F44 RID: 36676 RVA: 0x00270B94 File Offset: 0x0026ED94
			// (set) Token: 0x06008F45 RID: 36677 RVA: 0x0004D6F3 File Offset: 0x0004B8F3
			public unsafe DLC5_RogueLikeMainPanel dlc5RogueLikeMainPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_dlc5RogueLikeMainPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMainPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_dlc5RogueLikeMainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FE6 RID: 12262
			// (get) Token: 0x06008F46 RID: 36678 RVA: 0x00270BC4 File Offset: 0x0026EDC4
			// (set) Token: 0x06008F47 RID: 36679 RVA: 0x0004D712 File Offset: 0x0004B912
			public IRogueLikeData profile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_profile);
					return new IRogueLikeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_profile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FE7 RID: 12263
			// (get) Token: 0x06008F48 RID: 36680 RVA: 0x00270BF4 File Offset: 0x0026EDF4
			// (set) Token: 0x06008F49 RID: 36681 RVA: 0x0004D740 File Offset: 0x0004B940
			public unsafe IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel> loadPanelHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_loadPanelHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_loadPanelHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FE8 RID: 12264
			// (get) Token: 0x06008F4A RID: 36682 RVA: 0x00270C24 File Offset: 0x0026EE24
			// (set) Token: 0x06008F4B RID: 36683 RVA: 0x0004D75F File Offset: 0x0004B95F
			public Nullable<RogueLikeAchievementSaveData> rogueLikeAchievement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_rogueLikeAchievement);
					return new Nullable<RogueLikeAchievementSaveData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RogueLikeAchievementSaveData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_rogueLikeAchievement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RogueLikeAchievementSaveData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FE9 RID: 12265
			// (get) Token: 0x06008F4C RID: 36684 RVA: 0x00270C54 File Offset: 0x0026EE54
			// (set) Token: 0x06008F4D RID: 36685 RVA: 0x0004D78D File Offset: 0x0004B98D
			public unsafe Action onFadeFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_onFadeFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.NativeFieldInfoPtr_onFadeFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D59 RID: 23897
			private static readonly IntPtr NativeFieldInfoPtr_dlc5RogueLikeMainPanel;

			// Token: 0x04005D5A RID: 23898
			private static readonly IntPtr NativeFieldInfoPtr_profile;

			// Token: 0x04005D5B RID: 23899
			private static readonly IntPtr NativeFieldInfoPtr_loadPanelHandle;

			// Token: 0x04005D5C RID: 23900
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeAchievement;

			// Token: 0x04005D5D RID: 23901
			private static readonly IntPtr NativeFieldInfoPtr_onFadeFinish;

			// Token: 0x04005D5E RID: 23902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005D5F RID: 23903
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__0_Internal_UniTask_0;

			// Token: 0x04005D60 RID: 23904
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0;

			// Token: 0x04005D61 RID: 23905
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_1;

			// Token: 0x04005D62 RID: 23906
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__3_Internal_Void_0;

			// Token: 0x02000FB7 RID: 4023
			[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_0+<<OpenRogueLikeMainPanelAsync>b__0>d")]
			public sealed class __OpenRogueLikeMainPanelAsync_b__0_d : ValueType
			{
				// Token: 0x0601157B RID: 71035 RVA: 0x003FD6B8 File Offset: 0x003FB8B8
				// Note: this type is marked as 'beforefieldinit'.
				static __OpenRogueLikeMainPanelAsync_b__0_d()
				{
					Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "<<OpenRogueLikeMainPanelAsync>b__0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr);
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, "<>1__state");
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, "<>t__builder");
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, "<>4__this");
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, "<>u__1");
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, "<>u__2");
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, 100666870);
					UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr, 100666871);
				}

				// Token: 0x0601157C RID: 71036 RVA: 0x003FD770 File Offset: 0x003FB970
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56029, RefRangeEnd = 56031, XrefRangeStart = 55989, XrefRangeEnd = 56029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601157D RID: 71037 RVA: 0x003FD7A8 File Offset: 0x003FB9A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601157E RID: 71038 RVA: 0x00096D02 File Offset: 0x00094F02
				public __OpenRogueLikeMainPanelAsync_b__0_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0601157F RID: 71039 RVA: 0x00096D0B File Offset: 0x00094F0B
				public __OpenRogueLikeMainPanelAsync_b__0_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A28 RID: 23080
				// (get) Token: 0x06011580 RID: 71040 RVA: 0x003FD7F0 File Offset: 0x003FB9F0
				// (set) Token: 0x06011581 RID: 71041 RVA: 0x00096D1D File Offset: 0x00094F1D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A29 RID: 23081
				// (get) Token: 0x06011582 RID: 71042 RVA: 0x003FD818 File Offset: 0x003FBA18
				// (set) Token: 0x06011583 RID: 71043 RVA: 0x00096D38 File Offset: 0x00094F38
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A2A RID: 23082
				// (get) Token: 0x06011584 RID: 71044 RVA: 0x003FD848 File Offset: 0x003FBA48
				// (set) Token: 0x06011585 RID: 71045 RVA: 0x00096D66 File Offset: 0x00094F66
				public unsafe UIManager.__c__DisplayClass90_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass90_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A2B RID: 23083
				// (get) Token: 0x06011586 RID: 71046 RVA: 0x003FD878 File Offset: 0x003FBA78
				// (set) Token: 0x06011587 RID: 71047 RVA: 0x00096D85 File Offset: 0x00094F85
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A2C RID: 23084
				// (get) Token: 0x06011588 RID: 71048 RVA: 0x003FD8A8 File Offset: 0x003FBAA8
				// (set) Token: 0x06011589 RID: 71049 RVA: 0x00096DB3 File Offset: 0x00094FB3
				public UniTask<DLC5_RogueLikeMainPanel>.Awaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__2);
						return new UniTask<DLC5_RogueLikeMainPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeMainPanel>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.__OpenRogueLikeMainPanelAsync_b__0_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeMainPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF4A RID: 44874
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF4B RID: 44875
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF4C RID: 44876
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF4D RID: 44877
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF4E RID: 44878
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400AF4F RID: 44879
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF50 RID: 44880
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000FB8 RID: 4024
			[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_0+<<OpenRogueLikeMainPanelAsync>g__WaitLoadRogueData|1>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique : ValueType
			{
				// Token: 0x0601158A RID: 71050 RVA: 0x003FD8D8 File Offset: 0x003FBAD8
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique()
				{
					Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "<<OpenRogueLikeMainPanelAsync>g__WaitLoadRogueData|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr);
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, "<>1__state");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, "<>t__builder");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, "<>4__this");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, "<>u__1");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, 100666872);
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr, 100666873);
				}

				// Token: 0x0601158B RID: 71051 RVA: 0x003FD97C File Offset: 0x003FBB7C
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56076, RefRangeEnd = 56078, XrefRangeStart = 56031, XrefRangeEnd = 56076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601158C RID: 71052 RVA: 0x003FD9B4 File Offset: 0x003FBBB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601158D RID: 71053 RVA: 0x00096DE1 File Offset: 0x00094FE1
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0601158E RID: 71054 RVA: 0x00096DEA File Offset: 0x00094FEA
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005A2D RID: 23085
				// (get) Token: 0x0601158F RID: 71055 RVA: 0x003FD9FC File Offset: 0x003FBBFC
				// (set) Token: 0x06011590 RID: 71056 RVA: 0x00096DFC File Offset: 0x00094FFC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A2E RID: 23086
				// (get) Token: 0x06011591 RID: 71057 RVA: 0x003FDA24 File Offset: 0x003FBC24
				// (set) Token: 0x06011592 RID: 71058 RVA: 0x00096E17 File Offset: 0x00095017
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A2F RID: 23087
				// (get) Token: 0x06011593 RID: 71059 RVA: 0x003FDA54 File Offset: 0x003FBC54
				// (set) Token: 0x06011594 RID: 71060 RVA: 0x00096E45 File Offset: 0x00095045
				public unsafe UIManager.__c__DisplayClass90_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass90_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A30 RID: 23088
				// (get) Token: 0x06011595 RID: 71061 RVA: 0x003FDA84 File Offset: 0x003FBC84
				// (set) Token: 0x06011596 RID: 71062 RVA: 0x00096E64 File Offset: 0x00095064
				public UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___u__1);
						return new UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAw1Va2DLDLUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF51 RID: 44881
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF52 RID: 44882
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF53 RID: 44883
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF54 RID: 44884
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF55 RID: 44885
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF56 RID: 44886
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}

			// Token: 0x02000FB9 RID: 4025
			[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_0+<<OpenRogueLikeMainPanelAsync>g__WaitReadSaveData|2>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique : ValueType
			{
				// Token: 0x06011597 RID: 71063 RVA: 0x003FDAB4 File Offset: 0x003FBCB4
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique()
				{
					Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0>.NativeClassPtr, "<<OpenRogueLikeMainPanelAsync>g__WaitReadSaveData|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr);
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>1__state");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>t__builder");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>4__this");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr__fileSystemHandle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<fileSystemHandle>5__2");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>u__1");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>u__2");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, "<>u__3");
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, 100666874);
					UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr, 100666875);
				}

				// Token: 0x06011598 RID: 71064 RVA: 0x003FDB94 File Offset: 0x003FBD94
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56176, RefRangeEnd = 56178, XrefRangeStart = 56078, XrefRangeEnd = 56176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011599 RID: 71065 RVA: 0x003FDBCC File Offset: 0x003FBDCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601159A RID: 71066 RVA: 0x00096E92 File Offset: 0x00095092
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0601159B RID: 71067 RVA: 0x00096E9B File Offset: 0x0009509B
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005A31 RID: 23089
				// (get) Token: 0x0601159C RID: 71068 RVA: 0x003FDC14 File Offset: 0x003FBE14
				// (set) Token: 0x0601159D RID: 71069 RVA: 0x00096EAD File Offset: 0x000950AD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A32 RID: 23090
				// (get) Token: 0x0601159E RID: 71070 RVA: 0x003FDC3C File Offset: 0x003FBE3C
				// (set) Token: 0x0601159F RID: 71071 RVA: 0x00096EC8 File Offset: 0x000950C8
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A33 RID: 23091
				// (get) Token: 0x060115A0 RID: 71072 RVA: 0x003FDC6C File Offset: 0x003FBE6C
				// (set) Token: 0x060115A1 RID: 71073 RVA: 0x00096EF6 File Offset: 0x000950F6
				public unsafe UIManager.__c__DisplayClass90_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass90_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A34 RID: 23092
				// (get) Token: 0x060115A2 RID: 71074 RVA: 0x003FDC9C File Offset: 0x003FBE9C
				// (set) Token: 0x060115A3 RID: 71075 RVA: 0x00096F15 File Offset: 0x00095115
				public FileSystemHandle _fileSystemHandle_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr__fileSystemHandle_5__2);
						return new FileSystemHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr__fileSystemHandle_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A35 RID: 23093
				// (get) Token: 0x060115A4 RID: 71076 RVA: 0x003FDCCC File Offset: 0x003FBECC
				// (set) Token: 0x060115A5 RID: 71077 RVA: 0x00096F43 File Offset: 0x00095143
				public UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__1);
						return new UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A36 RID: 23094
				// (get) Token: 0x060115A6 RID: 71078 RVA: 0x003FDCFC File Offset: 0x003FBEFC
				// (set) Token: 0x060115A7 RID: 71079 RVA: 0x00096F71 File Offset: 0x00095171
				public UniTask<IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel>>.Awaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__2);
						return new UniTask<IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DLC5_RogueLikeSaveLoadPanel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A37 RID: 23095
				// (get) Token: 0x060115A8 RID: 71080 RVA: 0x003FDD2C File Offset: 0x003FBF2C
				// (set) Token: 0x060115A9 RID: 71081 RVA: 0x00096F9F File Offset: 0x0009519F
				public UniTask<Nullable<RogueLikeAchievementSaveData>>.Awaiter __u__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__3);
						return new UniTask<Nullable<RogueLikeAchievementSaveData>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<RogueLikeAchievementSaveData>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsFiAw1IR2LoInIGUnique.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<RogueLikeAchievementSaveData>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF57 RID: 44887
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF58 RID: 44888
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF59 RID: 44889
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF5A RID: 44890
				private static readonly IntPtr NativeFieldInfoPtr__fileSystemHandle_5__2;

				// Token: 0x0400AF5B RID: 44891
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF5C RID: 44892
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400AF5D RID: 44893
				private static readonly IntPtr NativeFieldInfoPtr___u__3;

				// Token: 0x0400AF5E RID: 44894
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF5F RID: 44895
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x020005F0 RID: 1520
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_1")]
		public sealed class __c__DisplayClass90_1 : Il2CppSystem.Object
		{
			// Token: 0x06008F4E RID: 36686 RVA: 0x00270C84 File Offset: 0x0026EE84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_1()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass90_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr);
				UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr_cleanUpFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, "cleanUpFinish");
				UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, "<>9__7");
				UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, 100666876);
				UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, 100666877);
				UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__6_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, 100666878);
				UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__7_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, 100666879);
			}

			// Token: 0x06008F4F RID: 36687 RVA: 0x00270D28 File Offset: 0x0026EF28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F50 RID: 36688 RVA: 0x00270D64 File Offset: 0x0026EF64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenRogueLikeMainPanelAsync_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F51 RID: 36689 RVA: 0x00270D98 File Offset: 0x0026EF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56249, XrefRangeEnd = 56255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _OpenRogueLikeMainPanelAsync_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__6_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F52 RID: 36690 RVA: 0x00270DD0 File Offset: 0x0026EFD0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenRogueLikeMainPanelAsync_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__7_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008F53 RID: 36691 RVA: 0x0004D7AC File Offset: 0x0004B9AC
			public __c__DisplayClass90_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002FEA RID: 12266
			// (get) Token: 0x06008F54 RID: 36692 RVA: 0x00270E0C File Offset: 0x0026F00C
			// (set) Token: 0x06008F55 RID: 36693 RVA: 0x0004D7B5 File Offset: 0x0004B9B5
			public unsafe bool cleanUpFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr_cleanUpFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr_cleanUpFinish)) = value;
				}
			}

			// Token: 0x17002FEB RID: 12267
			// (get) Token: 0x06008F56 RID: 36694 RVA: 0x00270E34 File Offset: 0x0026F034
			// (set) Token: 0x06008F57 RID: 36695 RVA: 0x0004D7D0 File Offset: 0x0004B9D0
			public unsafe Func<bool> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D63 RID: 23907
			private static readonly IntPtr NativeFieldInfoPtr_cleanUpFinish;

			// Token: 0x04005D64 RID: 23908
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04005D65 RID: 23909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005D66 RID: 23910
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__5_Internal_Void_0;

			// Token: 0x04005D67 RID: 23911
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__6_Internal_UniTask_0;

			// Token: 0x04005D68 RID: 23912
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__7_Internal_Boolean_0;

			// Token: 0x02000FBA RID: 4026
			[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass90_1+<<OpenRogueLikeMainPanelAsync>b__6>d")]
			public sealed class __OpenRogueLikeMainPanelAsync_b__6_d : ValueType
			{
				// Token: 0x060115AA RID: 71082 RVA: 0x003FDD5C File Offset: 0x003FBF5C
				// Note: this type is marked as 'beforefieldinit'.
				static __OpenRogueLikeMainPanelAsync_b__6_d()
				{
					Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1>.NativeClassPtr, "<<OpenRogueLikeMainPanelAsync>b__6>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr);
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<>1__state");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<>t__builder");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<>4__this");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr__fileSystemHandle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<fileSystemHandle>5__2");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<>u__1");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, "<>u__2");
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, 100666880);
					UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr, 100666881);
				}

				// Token: 0x060115AB RID: 71083 RVA: 0x003FDE28 File Offset: 0x003FC028
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56247, RefRangeEnd = 56249, XrefRangeStart = 56196, XrefRangeEnd = 56247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115AC RID: 71084 RVA: 0x003FDE60 File Offset: 0x003FC060
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115AD RID: 71085 RVA: 0x00096FCD File Offset: 0x000951CD
				public __OpenRogueLikeMainPanelAsync_b__6_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060115AE RID: 71086 RVA: 0x00096FD6 File Offset: 0x000951D6
				public __OpenRogueLikeMainPanelAsync_b__6_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A38 RID: 23096
				// (get) Token: 0x060115AF RID: 71087 RVA: 0x003FDEA8 File Offset: 0x003FC0A8
				// (set) Token: 0x060115B0 RID: 71088 RVA: 0x00096FE8 File Offset: 0x000951E8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A39 RID: 23097
				// (get) Token: 0x060115B1 RID: 71089 RVA: 0x003FDED0 File Offset: 0x003FC0D0
				// (set) Token: 0x060115B2 RID: 71090 RVA: 0x00097003 File Offset: 0x00095203
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A3A RID: 23098
				// (get) Token: 0x060115B3 RID: 71091 RVA: 0x003FDF00 File Offset: 0x003FC100
				// (set) Token: 0x060115B4 RID: 71092 RVA: 0x00097031 File Offset: 0x00095231
				public unsafe UIManager.__c__DisplayClass90_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass90_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A3B RID: 23099
				// (get) Token: 0x060115B5 RID: 71093 RVA: 0x003FDF30 File Offset: 0x003FC130
				// (set) Token: 0x060115B6 RID: 71094 RVA: 0x00097050 File Offset: 0x00095250
				public FileSystemHandle _fileSystemHandle_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr__fileSystemHandle_5__2);
						return new FileSystemHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr__fileSystemHandle_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A3C RID: 23100
				// (get) Token: 0x060115B7 RID: 71095 RVA: 0x003FDF60 File Offset: 0x003FC160
				// (set) Token: 0x060115B8 RID: 71096 RVA: 0x0009707E File Offset: 0x0009527E
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A3D RID: 23101
				// (get) Token: 0x060115B9 RID: 71097 RVA: 0x003FDF90 File Offset: 0x003FC190
				// (set) Token: 0x060115BA RID: 71098 RVA: 0x000970AC File Offset: 0x000952AC
				public UnityAsyncExtensions.AsyncOperationAwaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__2);
						return new UnityAsyncExtensions.AsyncOperationAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityAsyncExtensions.AsyncOperationAwaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass90_1.__OpenRogueLikeMainPanelAsync_b__6_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityAsyncExtensions.AsyncOperationAwaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF60 RID: 44896
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF61 RID: 44897
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF62 RID: 44898
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF63 RID: 44899
				private static readonly IntPtr NativeFieldInfoPtr__fileSystemHandle_5__2;

				// Token: 0x0400AF64 RID: 44900
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF65 RID: 44901
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400AF66 RID: 44902
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF67 RID: 44903
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x020005F1 RID: 1521
		[ObfuscatedName("DayScene.UI.UIManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008F58 RID: 36696 RVA: 0x00270E64 File Offset: 0x0026F064
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr);
				UIManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, "<>9");
				UIManager.__c.NativeFieldInfoPtr___9__90_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, "<>9__90_4");
				UIManager.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, "<>9__91_0");
				UIManager.__c.NativeFieldInfoPtr___9__94_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, "<>9__94_0");
				UIManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, 100666883);
				UIManager.__c.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__90_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, 100666884);
				UIManager.__c.NativeMethodInfoPtr__AfterRogueLikeAsync_b__91_0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, 100666885);
				UIManager.__c.NativeMethodInfoPtr__OpenRogueLikeChallengeSpotSelectionPanel_b__94_0_Internal_ValueTuple_2_MapSetup_Izakaya_String_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, 100666886);
			}

			// Token: 0x06008F59 RID: 36697 RVA: 0x00270F30 File Offset: 0x0026F130
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F5A RID: 36698 RVA: 0x00270F6C File Offset: 0x0026F16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56287, XrefRangeEnd = 56293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenRogueLikeMainPanelAsync_b__90_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__90_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F5B RID: 36699 RVA: 0x00270FA0 File Offset: 0x0026F1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56293, XrefRangeEnd = 56298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _AfterRogueLikeAsync_b__91_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.NativeMethodInfoPtr__AfterRogueLikeAsync_b__91_0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F5C RID: 36700 RVA: 0x00270FD8 File Offset: 0x0026F1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56298, XrefRangeEnd = 56311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya> _OpenRogueLikeChallengeSpotSelectionPanel_b__94_0(string spotName, UnlockedIzakayaInfo level)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(spotName);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.NativeMethodInfoPtr__OpenRogueLikeChallengeSpotSelectionPanel_b__94_0_Internal_ValueTuple_2_MapSetup_Izakaya_String_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>(pointer);
			}

			// Token: 0x06008F5D RID: 36701 RVA: 0x0004D7EF File Offset: 0x0004B9EF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002FEC RID: 12268
			// (get) Token: 0x06008F5E RID: 36702 RVA: 0x00271030 File Offset: 0x0026F230
			// (set) Token: 0x06008F5F RID: 36703 RVA: 0x0004D7F8 File Offset: 0x0004B9F8
			public unsafe static UIManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FED RID: 12269
			// (get) Token: 0x06008F60 RID: 36704 RVA: 0x00271058 File Offset: 0x0026F258
			// (set) Token: 0x06008F61 RID: 36705 RVA: 0x0004D80A File Offset: 0x0004BA0A
			public unsafe static Action __9__90_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIManager.__c.NativeFieldInfoPtr___9__90_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIManager.__c.NativeFieldInfoPtr___9__90_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FEE RID: 12270
			// (get) Token: 0x06008F62 RID: 36706 RVA: 0x00271080 File Offset: 0x0026F280
			// (set) Token: 0x06008F63 RID: 36707 RVA: 0x0004D81C File Offset: 0x0004BA1C
			public unsafe static Func<UniTask> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIManager.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIManager.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FEF RID: 12271
			// (get) Token: 0x06008F64 RID: 36708 RVA: 0x002710A8 File Offset: 0x0026F2A8
			// (set) Token: 0x06008F65 RID: 36709 RVA: 0x0004D82E File Offset: 0x0004BA2E
			public unsafe static Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>> __9__94_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIManager.__c.NativeFieldInfoPtr___9__94_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIManager.__c.NativeFieldInfoPtr___9__94_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D69 RID: 23913
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005D6A RID: 23914
			private static readonly IntPtr NativeFieldInfoPtr___9__90_4;

			// Token: 0x04005D6B RID: 23915
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04005D6C RID: 23916
			private static readonly IntPtr NativeFieldInfoPtr___9__94_0;

			// Token: 0x04005D6D RID: 23917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005D6E RID: 23918
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeMainPanelAsync_b__90_4_Internal_Void_0;

			// Token: 0x04005D6F RID: 23919
			private static readonly IntPtr NativeMethodInfoPtr__AfterRogueLikeAsync_b__91_0_Internal_UniTask_0;

			// Token: 0x04005D70 RID: 23920
			private static readonly IntPtr NativeMethodInfoPtr__OpenRogueLikeChallengeSpotSelectionPanel_b__94_0_Internal_ValueTuple_2_MapSetup_Izakaya_String_UnlockedIzakayaInfo_0;

			// Token: 0x02000FBB RID: 4027
			[ObfuscatedName("DayScene.UI.UIManager+<>c+<<AfterRogueLikeAsync>b__91_0>d")]
			public sealed class __AfterRogueLikeAsync_b__91_0_d : ValueType
			{
				// Token: 0x060115BB RID: 71099 RVA: 0x003FDFC0 File Offset: 0x003FC1C0
				// Note: this type is marked as 'beforefieldinit'.
				static __AfterRogueLikeAsync_b__91_0_d()
				{
					Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c>.NativeClassPtr, "<<AfterRogueLikeAsync>b__91_0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr);
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, "<>1__state");
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, "<>t__builder");
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr__fileSystemHandle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, "<fileSystemHandle>5__2");
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, "<>u__1");
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, "<>u__2");
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, 100666887);
					UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr, 100666888);
				}

				// Token: 0x060115BC RID: 71100 RVA: 0x003FE078 File Offset: 0x003FC278
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56285, RefRangeEnd = 56287, XrefRangeStart = 56255, XrefRangeEnd = 56285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115BD RID: 71101 RVA: 0x003FE0B0 File Offset: 0x003FC2B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115BE RID: 71102 RVA: 0x000970DA File Offset: 0x000952DA
				public __AfterRogueLikeAsync_b__91_0_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060115BF RID: 71103 RVA: 0x000970E3 File Offset: 0x000952E3
				public __AfterRogueLikeAsync_b__91_0_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c.__AfterRogueLikeAsync_b__91_0_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A3E RID: 23102
				// (get) Token: 0x060115C0 RID: 71104 RVA: 0x003FE0F8 File Offset: 0x003FC2F8
				// (set) Token: 0x060115C1 RID: 71105 RVA: 0x000970F5 File Offset: 0x000952F5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A3F RID: 23103
				// (get) Token: 0x060115C2 RID: 71106 RVA: 0x003FE120 File Offset: 0x003FC320
				// (set) Token: 0x060115C3 RID: 71107 RVA: 0x00097110 File Offset: 0x00095310
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A40 RID: 23104
				// (get) Token: 0x060115C4 RID: 71108 RVA: 0x003FE150 File Offset: 0x003FC350
				// (set) Token: 0x060115C5 RID: 71109 RVA: 0x0009713E File Offset: 0x0009533E
				public FileSystemHandle _fileSystemHandle_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr__fileSystemHandle_5__2);
						return new FileSystemHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr__fileSystemHandle_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A41 RID: 23105
				// (get) Token: 0x060115C6 RID: 71110 RVA: 0x003FE180 File Offset: 0x003FC380
				// (set) Token: 0x060115C7 RID: 71111 RVA: 0x0009716C File Offset: 0x0009536C
				public UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__1);
						return new UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A42 RID: 23106
				// (get) Token: 0x060115C8 RID: 71112 RVA: 0x003FE1B0 File Offset: 0x003FC3B0
				// (set) Token: 0x060115C9 RID: 71113 RVA: 0x0009719A File Offset: 0x0009539A
				public UniTask.Awaiter __u__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__2);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c.__AfterRogueLikeAsync_b__91_0_d.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF68 RID: 44904
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF69 RID: 44905
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF6A RID: 44906
				private static readonly IntPtr NativeFieldInfoPtr__fileSystemHandle_5__2;

				// Token: 0x0400AF6B RID: 44907
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF6C RID: 44908
				private static readonly IntPtr NativeFieldInfoPtr___u__2;

				// Token: 0x0400AF6D RID: 44909
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF6E RID: 44910
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x020005F2 RID: 1522
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeMainPanelAsync>d__90")]
		public sealed class _OpenRogueLikeMainPanelAsync_d__90 : ValueType
		{
			// Token: 0x06008F66 RID: 36710 RVA: 0x002710D0 File Offset: 0x0026F2D0
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeMainPanelAsync_d__90()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeMainPanelAsync>d__90");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr);
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<>8__1");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__difficulty_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<difficulty>5__2");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<>u__2");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerDataCache_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<playerDataCache>5__3");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__runtimeAlbumCache_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<runtimeAlbumCache>5__4");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__rogueLikeSaveData_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<rogueLikeSaveData>5__5");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerSkinDataCache_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, "<playerSkinDataCache>5__6");
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, 100666889);
				UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr, 100666890);
			}

			// Token: 0x06008F67 RID: 36711 RVA: 0x002711EC File Offset: 0x0026F3EC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 56603, RefRangeEnd = 56606, XrefRangeStart = 56311, XrefRangeEnd = 56603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F68 RID: 36712 RVA: 0x00271224 File Offset: 0x0026F424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F69 RID: 36713 RVA: 0x0004D840 File Offset: 0x0004BA40
			public _OpenRogueLikeMainPanelAsync_d__90(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F6A RID: 36714 RVA: 0x0004D849 File Offset: 0x0004BA49
			public _OpenRogueLikeMainPanelAsync_d__90() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeMainPanelAsync_d__90>.NativeClassPtr))
			{
			}

			// Token: 0x17002FF0 RID: 12272
			// (get) Token: 0x06008F6B RID: 36715 RVA: 0x0027126C File Offset: 0x0026F46C
			// (set) Token: 0x06008F6C RID: 36716 RVA: 0x0004D85B File Offset: 0x0004BA5B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FF1 RID: 12273
			// (get) Token: 0x06008F6D RID: 36717 RVA: 0x00271294 File Offset: 0x0026F494
			// (set) Token: 0x06008F6E RID: 36718 RVA: 0x0004D876 File Offset: 0x0004BA76
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FF2 RID: 12274
			// (get) Token: 0x06008F6F RID: 36719 RVA: 0x002712C4 File Offset: 0x0026F4C4
			// (set) Token: 0x06008F70 RID: 36720 RVA: 0x0004D8A4 File Offset: 0x0004BAA4
			public unsafe UIManager.__c__DisplayClass90_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass90_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FF3 RID: 12275
			// (get) Token: 0x06008F71 RID: 36721 RVA: 0x002712F4 File Offset: 0x0026F4F4
			// (set) Token: 0x06008F72 RID: 36722 RVA: 0x0004D8C3 File Offset: 0x0004BAC3
			public unsafe NightSceneDirector.Difficulty _difficulty_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__difficulty_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__difficulty_5__2)) = value;
				}
			}

			// Token: 0x17002FF4 RID: 12276
			// (get) Token: 0x06008F73 RID: 36723 RVA: 0x0027131C File Offset: 0x0026F51C
			// (set) Token: 0x06008F74 RID: 36724 RVA: 0x0004D8DE File Offset: 0x0004BADE
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FF5 RID: 12277
			// (get) Token: 0x06008F75 RID: 36725 RVA: 0x0027134C File Offset: 0x0026F54C
			// (set) Token: 0x06008F76 RID: 36726 RVA: 0x0004D90C File Offset: 0x0004BB0C
			public UniTask<ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__2);
					return new UniTask<ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FF6 RID: 12278
			// (get) Token: 0x06008F77 RID: 36727 RVA: 0x0027137C File Offset: 0x0026F57C
			// (set) Token: 0x06008F78 RID: 36728 RVA: 0x0004D93A File Offset: 0x0004BB3A
			public unsafe RunTimeStorage.RuntimePlayerDataCache _playerDataCache_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerDataCache_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.RuntimePlayerDataCache>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerDataCache_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FF7 RID: 12279
			// (get) Token: 0x06008F79 RID: 36729 RVA: 0x002713AC File Offset: 0x0026F5AC
			// (set) Token: 0x06008F7A RID: 36730 RVA: 0x0004D959 File Offset: 0x0004BB59
			public unsafe RunTimeAlbum.RuntimeAlbumCache _runtimeAlbumCache_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__runtimeAlbumCache_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.RuntimeAlbumCache>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__runtimeAlbumCache_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FF8 RID: 12280
			// (get) Token: 0x06008F7B RID: 36731 RVA: 0x002713DC File Offset: 0x0026F5DC
			// (set) Token: 0x06008F7C RID: 36732 RVA: 0x0004D978 File Offset: 0x0004BB78
			public RogueLikeSaveData _rogueLikeSaveData_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__rogueLikeSaveData_5__5);
					return new RogueLikeSaveData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__rogueLikeSaveData_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FF9 RID: 12281
			// (get) Token: 0x06008F7D RID: 36733 RVA: 0x0027140C File Offset: 0x0026F60C
			// (set) Token: 0x06008F7E RID: 36734 RVA: 0x0004D9A6 File Offset: 0x0004BBA6
			public unsafe RunTimeAlbum.RuntimePlayerSkinDataCache _playerSkinDataCache_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerSkinDataCache_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.RuntimePlayerSkinDataCache>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeMainPanelAsync_d__90.NativeFieldInfoPtr__playerSkinDataCache_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D71 RID: 23921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D72 RID: 23922
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D73 RID: 23923
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005D74 RID: 23924
			private static readonly IntPtr NativeFieldInfoPtr__difficulty_5__2;

			// Token: 0x04005D75 RID: 23925
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D76 RID: 23926
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D77 RID: 23927
			private static readonly IntPtr NativeFieldInfoPtr__playerDataCache_5__3;

			// Token: 0x04005D78 RID: 23928
			private static readonly IntPtr NativeFieldInfoPtr__runtimeAlbumCache_5__4;

			// Token: 0x04005D79 RID: 23929
			private static readonly IntPtr NativeFieldInfoPtr__rogueLikeSaveData_5__5;

			// Token: 0x04005D7A RID: 23930
			private static readonly IntPtr NativeFieldInfoPtr__playerSkinDataCache_5__6;

			// Token: 0x04005D7B RID: 23931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D7C RID: 23932
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005F3 RID: 1523
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass91_0")]
		public sealed class __c__DisplayClass91_0 : Il2CppSystem.Object
		{
			// Token: 0x06008F7F RID: 36735 RVA: 0x0027143C File Offset: 0x0026F63C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass91_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr);
				UIManager.__c__DisplayClass91_0.NativeFieldInfoPtr_fileSystemHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr, "fileSystemHandle");
				UIManager.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr, 100666891);
				UIManager.__c__DisplayClass91_0.NativeMethodInfoPtr__AfterRogueLikeAsync_b__1_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr, 100666892);
			}

			// Token: 0x06008F80 RID: 36736 RVA: 0x002714A4 File Offset: 0x0026F6A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass91_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F81 RID: 36737 RVA: 0x002714E0 File Offset: 0x0026F6E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56606, XrefRangeEnd = 56607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _AfterRogueLikeAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass91_0.NativeMethodInfoPtr__AfterRogueLikeAsync_b__1_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008F82 RID: 36738 RVA: 0x0004D9C5 File Offset: 0x0004BBC5
			public __c__DisplayClass91_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002FFA RID: 12282
			// (get) Token: 0x06008F83 RID: 36739 RVA: 0x00271518 File Offset: 0x0026F718
			// (set) Token: 0x06008F84 RID: 36740 RVA: 0x0004D9CE File Offset: 0x0004BBCE
			public FileSystemHandle fileSystemHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass91_0.NativeFieldInfoPtr_fileSystemHandle);
					return new FileSystemHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass91_0.NativeFieldInfoPtr_fileSystemHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FileSystemHandle>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D7D RID: 23933
			private static readonly IntPtr NativeFieldInfoPtr_fileSystemHandle;

			// Token: 0x04005D7E RID: 23934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005D7F RID: 23935
			private static readonly IntPtr NativeMethodInfoPtr__AfterRogueLikeAsync_b__1_Internal_UniTask_0;
		}

		// Token: 0x020005F4 RID: 1524
		[ObfuscatedName("DayScene.UI.UIManager+<AfterRogueLikeAsync>d__91")]
		public sealed class _AfterRogueLikeAsync_d__91 : ValueType
		{
			// Token: 0x06008F85 RID: 36741 RVA: 0x00271548 File Offset: 0x0026F748
			// Note: this type is marked as 'beforefieldinit'.
			static _AfterRogueLikeAsync_d__91()
			{
				Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<AfterRogueLikeAsync>d__91");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr);
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>1__state");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>t__builder");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>8__1");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeRunTimeData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<rogueLikeRunTimeData>5__2");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeSaveData_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<rogueLikeSaveData>5__3");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>u__1");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>u__2");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>u__3");
				UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, "<>u__4");
				UIManager._AfterRogueLikeAsync_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, 100666893);
				UIManager._AfterRogueLikeAsync_d__91.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr, 100666894);
			}

			// Token: 0x06008F86 RID: 36742 RVA: 0x00271650 File Offset: 0x0026F850
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 56911, RefRangeEnd = 56914, XrefRangeStart = 56607, XrefRangeEnd = 56911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._AfterRogueLikeAsync_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F87 RID: 36743 RVA: 0x00271688 File Offset: 0x0026F888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._AfterRogueLikeAsync_d__91.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F88 RID: 36744 RVA: 0x0004D9FC File Offset: 0x0004BBFC
			public _AfterRogueLikeAsync_d__91(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008F89 RID: 36745 RVA: 0x0004DA05 File Offset: 0x0004BC05
			public _AfterRogueLikeAsync_d__91() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._AfterRogueLikeAsync_d__91>.NativeClassPtr))
			{
			}

			// Token: 0x17002FFB RID: 12283
			// (get) Token: 0x06008F8A RID: 36746 RVA: 0x002716D0 File Offset: 0x0026F8D0
			// (set) Token: 0x06008F8B RID: 36747 RVA: 0x0004DA17 File Offset: 0x0004BC17
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002FFC RID: 12284
			// (get) Token: 0x06008F8C RID: 36748 RVA: 0x002716F8 File Offset: 0x0026F8F8
			// (set) Token: 0x06008F8D RID: 36749 RVA: 0x0004DA32 File Offset: 0x0004BC32
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002FFD RID: 12285
			// (get) Token: 0x06008F8E RID: 36750 RVA: 0x00271728 File Offset: 0x0026F928
			// (set) Token: 0x06008F8F RID: 36751 RVA: 0x0004DA60 File Offset: 0x0004BC60
			public unsafe UIManager.__c__DisplayClass91_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass91_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FFE RID: 12286
			// (get) Token: 0x06008F90 RID: 36752 RVA: 0x00271758 File Offset: 0x0026F958
			// (set) Token: 0x06008F91 RID: 36753 RVA: 0x0004DA7F File Offset: 0x0004BC7F
			public unsafe RogueLikeRunTimeData _rogueLikeRunTimeData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeRunTimeData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeRunTimeData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002FFF RID: 12287
			// (get) Token: 0x06008F92 RID: 36754 RVA: 0x00271788 File Offset: 0x0026F988
			// (set) Token: 0x06008F93 RID: 36755 RVA: 0x0004DA9E File Offset: 0x0004BC9E
			public RogueLikeSaveData _rogueLikeSaveData_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeSaveData_5__3);
					return new RogueLikeSaveData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr__rogueLikeSaveData_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003000 RID: 12288
			// (get) Token: 0x06008F94 RID: 36756 RVA: 0x002717B8 File Offset: 0x0026F9B8
			// (set) Token: 0x06008F95 RID: 36757 RVA: 0x0004DACC File Offset: 0x0004BCCC
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003001 RID: 12289
			// (get) Token: 0x06008F96 RID: 36758 RVA: 0x002717E8 File Offset: 0x0026F9E8
			// (set) Token: 0x06008F97 RID: 36759 RVA: 0x0004DAFA File Offset: 0x0004BCFA
			public UniTask<DLC5_RogueLikeSaveLoadPanel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC5_RogueLikeSaveLoadPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSaveLoadPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSaveLoadPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003002 RID: 12290
			// (get) Token: 0x06008F98 RID: 36760 RVA: 0x00271818 File Offset: 0x0026FA18
			// (set) Token: 0x06008F99 RID: 36761 RVA: 0x0004DB28 File Offset: 0x0004BD28
			public UniTask<Nullable<int>>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__3);
					return new UniTask<Nullable<int>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003003 RID: 12291
			// (get) Token: 0x06008F9A RID: 36762 RVA: 0x00271848 File Offset: 0x0026FA48
			// (set) Token: 0x06008F9B RID: 36763 RVA: 0x0004DB56 File Offset: 0x0004BD56
			public UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__4);
					return new UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._AfterRogueLikeAsync_d__91.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D80 RID: 23936
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D81 RID: 23937
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D82 RID: 23938
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005D83 RID: 23939
			private static readonly IntPtr NativeFieldInfoPtr__rogueLikeRunTimeData_5__2;

			// Token: 0x04005D84 RID: 23940
			private static readonly IntPtr NativeFieldInfoPtr__rogueLikeSaveData_5__3;

			// Token: 0x04005D85 RID: 23941
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D86 RID: 23942
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D87 RID: 23943
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04005D88 RID: 23944
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x04005D89 RID: 23945
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D8A RID: 23946
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005F5 RID: 1525
		[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass92_0")]
		public sealed class __c__DisplayClass92_0 : Il2CppSystem.Object
		{
			// Token: 0x06008F9C RID: 36764 RVA: 0x00271878 File Offset: 0x0026FA78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass92_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass92_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr);
				UIManager.__c__DisplayClass92_0.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr, "rogueLikeRunTimeData");
				UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr, 100666895);
				UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ChallengeLoop_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr, 100666896);
				UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ChallengeLoop_b__1_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr, 100666897);
			}

			// Token: 0x06008F9D RID: 36765 RVA: 0x002718F4 File Offset: 0x0026FAF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass92_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F9E RID: 36766 RVA: 0x00271930 File Offset: 0x0026FB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56925, XrefRangeEnd = 56926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ChallengeLoop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ChallengeLoop_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008F9F RID: 36767 RVA: 0x00271964 File Offset: 0x0026FB64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56926, XrefRangeEnd = 56932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _ChallengeLoop_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass92_0.NativeMethodInfoPtr__ChallengeLoop_b__1_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06008FA0 RID: 36768 RVA: 0x0004DB84 File Offset: 0x0004BD84
			public __c__DisplayClass92_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003004 RID: 12292
			// (get) Token: 0x06008FA1 RID: 36769 RVA: 0x0027199C File Offset: 0x0026FB9C
			// (set) Token: 0x06008FA2 RID: 36770 RVA: 0x0004DB8D File Offset: 0x0004BD8D
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005D8B RID: 23947
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04005D8C RID: 23948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005D8D RID: 23949
			private static readonly IntPtr NativeMethodInfoPtr__ChallengeLoop_b__0_Internal_Void_0;

			// Token: 0x04005D8E RID: 23950
			private static readonly IntPtr NativeMethodInfoPtr__ChallengeLoop_b__1_Internal_UniTask_0;

			// Token: 0x02000FBC RID: 4028
			[ObfuscatedName("DayScene.UI.UIManager+<>c__DisplayClass92_0+<<ChallengeLoop>b__1>d")]
			public sealed class __ChallengeLoop_b__1_d : ValueType
			{
				// Token: 0x060115CA RID: 71114 RVA: 0x003FE1E0 File Offset: 0x003FC3E0
				// Note: this type is marked as 'beforefieldinit'.
				static __ChallengeLoop_b__1_d()
				{
					Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0>.NativeClassPtr, "<<ChallengeLoop>b__1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr);
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, "<>1__state");
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, "<>t__builder");
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, "<>4__this");
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, "<>u__1");
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, 100666898);
					UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr, 100666899);
				}

				// Token: 0x060115CB RID: 71115 RVA: 0x003FE284 File Offset: 0x003FC484
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 56923, RefRangeEnd = 56925, XrefRangeStart = 56914, XrefRangeEnd = 56923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115CC RID: 71116 RVA: 0x003FE2BC File Offset: 0x003FC4BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115CD RID: 71117 RVA: 0x000971C8 File Offset: 0x000953C8
				public __ChallengeLoop_b__1_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060115CE RID: 71118 RVA: 0x000971D1 File Offset: 0x000953D1
				public __ChallengeLoop_b__1_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A43 RID: 23107
				// (get) Token: 0x060115CF RID: 71119 RVA: 0x003FE304 File Offset: 0x003FC504
				// (set) Token: 0x060115D0 RID: 71120 RVA: 0x000971E3 File Offset: 0x000953E3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A44 RID: 23108
				// (get) Token: 0x060115D1 RID: 71121 RVA: 0x003FE32C File Offset: 0x003FC52C
				// (set) Token: 0x060115D2 RID: 71122 RVA: 0x000971FE File Offset: 0x000953FE
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A45 RID: 23109
				// (get) Token: 0x060115D3 RID: 71123 RVA: 0x003FE35C File Offset: 0x003FC55C
				// (set) Token: 0x060115D4 RID: 71124 RVA: 0x0009722C File Offset: 0x0009542C
				public unsafe UIManager.__c__DisplayClass92_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass92_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A46 RID: 23110
				// (get) Token: 0x060115D5 RID: 71125 RVA: 0x003FE38C File Offset: 0x003FC58C
				// (set) Token: 0x060115D6 RID: 71126 RVA: 0x0009724B File Offset: 0x0009544B
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass92_0.__ChallengeLoop_b__1_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400AF6F RID: 44911
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF70 RID: 44912
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400AF71 RID: 44913
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF72 RID: 44914
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400AF73 RID: 44915
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF74 RID: 44916
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x020005F6 RID: 1526
		[ObfuscatedName("DayScene.UI.UIManager+<ChallengeLoop>d__92")]
		public sealed class _ChallengeLoop_d__92 : ValueType
		{
			// Token: 0x06008FA3 RID: 36771 RVA: 0x002719CC File Offset: 0x0026FBCC
			// Note: this type is marked as 'beforefieldinit'.
			static _ChallengeLoop_d__92()
			{
				Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<ChallengeLoop>d__92");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr);
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<>1__state");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<>t__builder");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_onStartChallengeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "onStartChallengeCallback");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_isStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "isStart");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<>8__1");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__mapName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<mapName>5__2");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__izakayaLevel_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<izakayaLevel>5__3");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<>u__1");
				UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, "<>u__2");
				UIManager._ChallengeLoop_d__92.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, 100666900);
				UIManager._ChallengeLoop_d__92.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr, 100666901);
			}

			// Token: 0x06008FA4 RID: 36772 RVA: 0x00271AD4 File Offset: 0x0026FCD4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57052, RefRangeEnd = 57054, XrefRangeStart = 56932, XrefRangeEnd = 57052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ChallengeLoop_d__92.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FA5 RID: 36773 RVA: 0x00271B0C File Offset: 0x0026FD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ChallengeLoop_d__92.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FA6 RID: 36774 RVA: 0x0004DBAC File Offset: 0x0004BDAC
			public _ChallengeLoop_d__92(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008FA7 RID: 36775 RVA: 0x0004DBB5 File Offset: 0x0004BDB5
			public _ChallengeLoop_d__92() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._ChallengeLoop_d__92>.NativeClassPtr))
			{
			}

			// Token: 0x17003005 RID: 12293
			// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x00271B54 File Offset: 0x0026FD54
			// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x0004DBC7 File Offset: 0x0004BDC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003006 RID: 12294
			// (get) Token: 0x06008FAA RID: 36778 RVA: 0x00271B7C File Offset: 0x0026FD7C
			// (set) Token: 0x06008FAB RID: 36779 RVA: 0x0004DBE2 File Offset: 0x0004BDE2
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003007 RID: 12295
			// (get) Token: 0x06008FAC RID: 36780 RVA: 0x00271BAC File Offset: 0x0026FDAC
			// (set) Token: 0x06008FAD RID: 36781 RVA: 0x0004DC10 File Offset: 0x0004BE10
			public unsafe Action onStartChallengeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_onStartChallengeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_onStartChallengeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003008 RID: 12296
			// (get) Token: 0x06008FAE RID: 36782 RVA: 0x00271BDC File Offset: 0x0026FDDC
			// (set) Token: 0x06008FAF RID: 36783 RVA: 0x0004DC2F File Offset: 0x0004BE2F
			public unsafe bool isStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_isStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr_isStart)) = value;
				}
			}

			// Token: 0x17003009 RID: 12297
			// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x00271C04 File Offset: 0x0026FE04
			// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x0004DC4A File Offset: 0x0004BE4A
			public unsafe UIManager.__c__DisplayClass92_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass92_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700300A RID: 12298
			// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x00271C34 File Offset: 0x0026FE34
			// (set) Token: 0x06008FB3 RID: 36787 RVA: 0x0004DC69 File Offset: 0x0004BE69
			public unsafe string _mapName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__mapName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__mapName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700300B RID: 12299
			// (get) Token: 0x06008FB4 RID: 36788 RVA: 0x00271C5C File Offset: 0x0026FE5C
			// (set) Token: 0x06008FB5 RID: 36789 RVA: 0x0004DC88 File Offset: 0x0004BE88
			public unsafe UnlockedIzakayaInfo _izakayaLevel_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__izakayaLevel_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr__izakayaLevel_5__3)) = value;
				}
			}

			// Token: 0x1700300C RID: 12300
			// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x00271C84 File Offset: 0x0026FE84
			// (set) Token: 0x06008FB7 RID: 36791 RVA: 0x0004DCA3 File Offset: 0x0004BEA3
			public UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700300D RID: 12301
			// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x00271CB4 File Offset: 0x0026FEB4
			// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x0004DCD1 File Offset: 0x0004BED1
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ChallengeLoop_d__92.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D8F RID: 23951
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D90 RID: 23952
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D91 RID: 23953
			private static readonly IntPtr NativeFieldInfoPtr_onStartChallengeCallback;

			// Token: 0x04005D92 RID: 23954
			private static readonly IntPtr NativeFieldInfoPtr_isStart;

			// Token: 0x04005D93 RID: 23955
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005D94 RID: 23956
			private static readonly IntPtr NativeFieldInfoPtr__mapName_5__2;

			// Token: 0x04005D95 RID: 23957
			private static readonly IntPtr NativeFieldInfoPtr__izakayaLevel_5__3;

			// Token: 0x04005D96 RID: 23958
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005D97 RID: 23959
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005D98 RID: 23960
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005D99 RID: 23961
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005F7 RID: 1527
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeChallengeSpotSelectionPanel>d__94")]
		public sealed class _OpenRogueLikeChallengeSpotSelectionPanel_d__94 : ValueType
		{
			// Token: 0x06008FBA RID: 36794 RVA: 0x00271CE4 File Offset: 0x0026FEE4
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeChallengeSpotSelectionPanel_d__94()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeChallengeSpotSelectionPanel>d__94");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr);
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "runTimeData");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_isStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "isStart");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockedSpots_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<unlockedSpots>5__2");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__currentSpot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<currentSpot>5__3");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel2Spot_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<unlockAllLevel2Spot>5__4");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel3Spot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<unlockAllLevel3Spot>5__5");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, "<>u__2");
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, 100666902);
				UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr, 100666903);
			}

			// Token: 0x06008FBB RID: 36795 RVA: 0x00271E00 File Offset: 0x00270000
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57116, RefRangeEnd = 57118, XrefRangeStart = 57054, XrefRangeEnd = 57116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FBC RID: 36796 RVA: 0x00271E38 File Offset: 0x00270038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57118, XrefRangeEnd = 57121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FBD RID: 36797 RVA: 0x0004DCFF File Offset: 0x0004BEFF
			public _OpenRogueLikeChallengeSpotSelectionPanel_d__94(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008FBE RID: 36798 RVA: 0x0004DD08 File Offset: 0x0004BF08
			public _OpenRogueLikeChallengeSpotSelectionPanel_d__94() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94>.NativeClassPtr))
			{
			}

			// Token: 0x1700300E RID: 12302
			// (get) Token: 0x06008FBF RID: 36799 RVA: 0x00271E80 File Offset: 0x00270080
			// (set) Token: 0x06008FC0 RID: 36800 RVA: 0x0004DD1A File Offset: 0x0004BF1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700300F RID: 12303
			// (get) Token: 0x06008FC1 RID: 36801 RVA: 0x00271EA8 File Offset: 0x002700A8
			// (set) Token: 0x06008FC2 RID: 36802 RVA: 0x0004DD35 File Offset: 0x0004BF35
			public AsyncUniTaskMethodBuilder<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003010 RID: 12304
			// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x00271ED8 File Offset: 0x002700D8
			// (set) Token: 0x06008FC4 RID: 36804 RVA: 0x0004DD63 File Offset: 0x0004BF63
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003011 RID: 12305
			// (get) Token: 0x06008FC5 RID: 36805 RVA: 0x00271F08 File Offset: 0x00270108
			// (set) Token: 0x06008FC6 RID: 36806 RVA: 0x0004DD82 File Offset: 0x0004BF82
			public unsafe bool isStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_isStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr_isStart)) = value;
				}
			}

			// Token: 0x17003012 RID: 12306
			// (get) Token: 0x06008FC7 RID: 36807 RVA: 0x00271F30 File Offset: 0x00270130
			// (set) Token: 0x06008FC8 RID: 36808 RVA: 0x0004DD9D File Offset: 0x0004BF9D
			public unsafe Dictionary<string, UnlockedIzakayaInfo> _unlockedSpots_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockedSpots_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UnlockedIzakayaInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockedSpots_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003013 RID: 12307
			// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x00271F60 File Offset: 0x00270160
			// (set) Token: 0x06008FCA RID: 36810 RVA: 0x0004DDBC File Offset: 0x0004BFBC
			public unsafe string _currentSpot_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__currentSpot_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__currentSpot_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003014 RID: 12308
			// (get) Token: 0x06008FCB RID: 36811 RVA: 0x00271F88 File Offset: 0x00270188
			// (set) Token: 0x06008FCC RID: 36812 RVA: 0x0004DDDB File Offset: 0x0004BFDB
			public unsafe bool _unlockAllLevel2Spot_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel2Spot_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel2Spot_5__4)) = value;
				}
			}

			// Token: 0x17003015 RID: 12309
			// (get) Token: 0x06008FCD RID: 36813 RVA: 0x00271FB0 File Offset: 0x002701B0
			// (set) Token: 0x06008FCE RID: 36814 RVA: 0x0004DDF6 File Offset: 0x0004BFF6
			public unsafe bool _unlockAllLevel3Spot_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel3Spot_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr__unlockAllLevel3Spot_5__5)) = value;
				}
			}

			// Token: 0x17003016 RID: 12310
			// (get) Token: 0x06008FCF RID: 36815 RVA: 0x00271FD8 File Offset: 0x002701D8
			// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x0004DE11 File Offset: 0x0004C011
			public UniTask<DLC5_RogueLikeSpotSelectionPanel_New>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeSpotSelectionPanel_New>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003017 RID: 12311
			// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x00272008 File Offset: 0x00270208
			// (set) Token: 0x06008FD2 RID: 36818 RVA: 0x0004DE3F File Offset: 0x0004C03F
			public UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeChallengeSpotSelectionPanel_d__94.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005D9A RID: 23962
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005D9B RID: 23963
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005D9C RID: 23964
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x04005D9D RID: 23965
			private static readonly IntPtr NativeFieldInfoPtr_isStart;

			// Token: 0x04005D9E RID: 23966
			private static readonly IntPtr NativeFieldInfoPtr__unlockedSpots_5__2;

			// Token: 0x04005D9F RID: 23967
			private static readonly IntPtr NativeFieldInfoPtr__currentSpot_5__3;

			// Token: 0x04005DA0 RID: 23968
			private static readonly IntPtr NativeFieldInfoPtr__unlockAllLevel2Spot_5__4;

			// Token: 0x04005DA1 RID: 23969
			private static readonly IntPtr NativeFieldInfoPtr__unlockAllLevel3Spot_5__5;

			// Token: 0x04005DA2 RID: 23970
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DA3 RID: 23971
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005DA4 RID: 23972
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DA5 RID: 23973
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005F8 RID: 1528
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeFailedPanelAsync>d__97")]
		public sealed class _OpenRogueLikeFailedPanelAsync_d__97 : ValueType
		{
			// Token: 0x06008FD3 RID: 36819 RVA: 0x00272038 File Offset: 0x00270238
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeFailedPanelAsync_d__97()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeFailedPanelAsync>d__97");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr);
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, "rogueLikeRunTimeData");
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, 100666904);
				UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr, 100666905);
			}

			// Token: 0x06008FD4 RID: 36820 RVA: 0x002720DC File Offset: 0x002702DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57170, RefRangeEnd = 57172, XrefRangeStart = 57121, XrefRangeEnd = 57170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FD5 RID: 36821 RVA: 0x00272114 File Offset: 0x00270314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FD6 RID: 36822 RVA: 0x0004DE6D File Offset: 0x0004C06D
			public _OpenRogueLikeFailedPanelAsync_d__97(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008FD7 RID: 36823 RVA: 0x0004DE76 File Offset: 0x0004C076
			public _OpenRogueLikeFailedPanelAsync_d__97() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeFailedPanelAsync_d__97>.NativeClassPtr))
			{
			}

			// Token: 0x17003018 RID: 12312
			// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x0027215C File Offset: 0x0027035C
			// (set) Token: 0x06008FD9 RID: 36825 RVA: 0x0004DE88 File Offset: 0x0004C088
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003019 RID: 12313
			// (get) Token: 0x06008FDA RID: 36826 RVA: 0x00272184 File Offset: 0x00270384
			// (set) Token: 0x06008FDB RID: 36827 RVA: 0x0004DEA3 File Offset: 0x0004C0A3
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700301A RID: 12314
			// (get) Token: 0x06008FDC RID: 36828 RVA: 0x002721B4 File Offset: 0x002703B4
			// (set) Token: 0x06008FDD RID: 36829 RVA: 0x0004DED1 File Offset: 0x0004C0D1
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700301B RID: 12315
			// (get) Token: 0x06008FDE RID: 36830 RVA: 0x002721E4 File Offset: 0x002703E4
			// (set) Token: 0x06008FDF RID: 36831 RVA: 0x0004DEF0 File Offset: 0x0004C0F0
			public UniTask<DLC5_RogueLikeFailedPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeFailedPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeFailedPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeFailedPanelAsync_d__97.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeFailedPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005DA6 RID: 23974
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DA7 RID: 23975
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005DA8 RID: 23976
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04005DA9 RID: 23977
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DAA RID: 23978
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DAB RID: 23979
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005F9 RID: 1529
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeWinPanelAsync>d__98")]
		public sealed class _OpenRogueLikeWinPanelAsync_d__98 : ValueType
		{
			// Token: 0x06008FE0 RID: 36832 RVA: 0x00272214 File Offset: 0x00270414
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeWinPanelAsync_d__98()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeWinPanelAsync>d__98");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr);
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "rogueLikeRunTimeData");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_needFadeInExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "needFadeInExit");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, "<>u__2");
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, 100666906);
				UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr, 100666907);
			}

			// Token: 0x06008FE1 RID: 36833 RVA: 0x002722E0 File Offset: 0x002704E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57237, RefRangeEnd = 57239, XrefRangeStart = 57172, XrefRangeEnd = 57237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FE2 RID: 36834 RVA: 0x00272318 File Offset: 0x00270518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57239, XrefRangeEnd = 57242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FE3 RID: 36835 RVA: 0x0004DF1E File Offset: 0x0004C11E
			public _OpenRogueLikeWinPanelAsync_d__98(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008FE4 RID: 36836 RVA: 0x0004DF27 File Offset: 0x0004C127
			public _OpenRogueLikeWinPanelAsync_d__98() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeWinPanelAsync_d__98>.NativeClassPtr))
			{
			}

			// Token: 0x1700301C RID: 12316
			// (get) Token: 0x06008FE5 RID: 36837 RVA: 0x00272360 File Offset: 0x00270560
			// (set) Token: 0x06008FE6 RID: 36838 RVA: 0x0004DF39 File Offset: 0x0004C139
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700301D RID: 12317
			// (get) Token: 0x06008FE7 RID: 36839 RVA: 0x00272388 File Offset: 0x00270588
			// (set) Token: 0x06008FE8 RID: 36840 RVA: 0x0004DF54 File Offset: 0x0004C154
			public AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700301E RID: 12318
			// (get) Token: 0x06008FE9 RID: 36841 RVA: 0x002723B8 File Offset: 0x002705B8
			// (set) Token: 0x06008FEA RID: 36842 RVA: 0x0004DF82 File Offset: 0x0004C182
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700301F RID: 12319
			// (get) Token: 0x06008FEB RID: 36843 RVA: 0x002723E8 File Offset: 0x002705E8
			// (set) Token: 0x06008FEC RID: 36844 RVA: 0x0004DFA1 File Offset: 0x0004C1A1
			public unsafe bool needFadeInExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_needFadeInExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr_needFadeInExit)) = value;
				}
			}

			// Token: 0x17003020 RID: 12320
			// (get) Token: 0x06008FED RID: 36845 RVA: 0x00272410 File Offset: 0x00270610
			// (set) Token: 0x06008FEE RID: 36846 RVA: 0x0004DFBC File Offset: 0x0004C1BC
			public UniTask<DLC5_RogueLikeWinPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeWinPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003021 RID: 12321
			// (get) Token: 0x06008FEF RID: 36847 RVA: 0x00272440 File Offset: 0x00270640
			// (set) Token: 0x06008FF0 RID: 36848 RVA: 0x0004DFEA File Offset: 0x0004C1EA
			public UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeWinPanelAsync_d__98.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005DAC RID: 23980
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DAD RID: 23981
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005DAE RID: 23982
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04005DAF RID: 23983
			private static readonly IntPtr NativeFieldInfoPtr_needFadeInExit;

			// Token: 0x04005DB0 RID: 23984
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DB1 RID: 23985
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005DB2 RID: 23986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DB3 RID: 23987
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005FA RID: 1530
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeRoundPassPanelAsync>d__99")]
		public sealed class _OpenRogueLikeRoundPassPanelAsync_d__99 : ValueType
		{
			// Token: 0x06008FF1 RID: 36849 RVA: 0x00272470 File Offset: 0x00270670
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeRoundPassPanelAsync_d__99()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeRoundPassPanelAsync>d__99");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr);
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "rogueLikeRunTimeData");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_needFadeInExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "needFadeInExit");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, "<>u__2");
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, 100666908);
				UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr, 100666909);
			}

			// Token: 0x06008FF2 RID: 36850 RVA: 0x0027253C File Offset: 0x0027073C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57307, RefRangeEnd = 57309, XrefRangeStart = 57242, XrefRangeEnd = 57307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FF3 RID: 36851 RVA: 0x00272574 File Offset: 0x00270774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57309, XrefRangeEnd = 57312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008FF4 RID: 36852 RVA: 0x0004E018 File Offset: 0x0004C218
			public _OpenRogueLikeRoundPassPanelAsync_d__99(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008FF5 RID: 36853 RVA: 0x0004E021 File Offset: 0x0004C221
			public _OpenRogueLikeRoundPassPanelAsync_d__99() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeRoundPassPanelAsync_d__99>.NativeClassPtr))
			{
			}

			// Token: 0x17003022 RID: 12322
			// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x002725BC File Offset: 0x002707BC
			// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x0004E033 File Offset: 0x0004C233
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003023 RID: 12323
			// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x002725E4 File Offset: 0x002707E4
			// (set) Token: 0x06008FF9 RID: 36857 RVA: 0x0004E04E File Offset: 0x0004C24E
			public AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeWinPanel.CloseContext>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003024 RID: 12324
			// (get) Token: 0x06008FFA RID: 36858 RVA: 0x00272614 File Offset: 0x00270814
			// (set) Token: 0x06008FFB RID: 36859 RVA: 0x0004E07C File Offset: 0x0004C27C
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003025 RID: 12325
			// (get) Token: 0x06008FFC RID: 36860 RVA: 0x00272644 File Offset: 0x00270844
			// (set) Token: 0x06008FFD RID: 36861 RVA: 0x0004E09B File Offset: 0x0004C29B
			public unsafe bool needFadeInExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_needFadeInExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr_needFadeInExit)) = value;
				}
			}

			// Token: 0x17003026 RID: 12326
			// (get) Token: 0x06008FFE RID: 36862 RVA: 0x0027266C File Offset: 0x0027086C
			// (set) Token: 0x06008FFF RID: 36863 RVA: 0x0004E0B6 File Offset: 0x0004C2B6
			public UniTask<DLC5_RogueLikeWinPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeWinPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003027 RID: 12327
			// (get) Token: 0x06009000 RID: 36864 RVA: 0x0027269C File Offset: 0x0027089C
			// (set) Token: 0x06009001 RID: 36865 RVA: 0x0004E0E4 File Offset: 0x0004C2E4
			public UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__2);
					return new UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeRoundPassPanelAsync_d__99.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeWinPanel.CloseContext>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005DB4 RID: 23988
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DB5 RID: 23989
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005DB6 RID: 23990
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04005DB7 RID: 23991
			private static readonly IntPtr NativeFieldInfoPtr_needFadeInExit;

			// Token: 0x04005DB8 RID: 23992
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DB9 RID: 23993
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005DBA RID: 23994
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DBB RID: 23995
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005FB RID: 1531
		[ObfuscatedName("DayScene.UI.UIManager+<OpenRogueLikeResultPanelAsync>d__100")]
		public sealed class _OpenRogueLikeResultPanelAsync_d__100 : ValueType
		{
			// Token: 0x06009002 RID: 36866 RVA: 0x002726CC File Offset: 0x002708CC
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenRogueLikeResultPanelAsync_d__100()
			{
				Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenRogueLikeResultPanelAsync>d__100");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr);
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, "<>1__state");
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, "<>t__builder");
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, "rogueLikeRunTimeData");
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, "<>u__1");
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, 100666910);
				UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr, 100666911);
			}

			// Token: 0x06009003 RID: 36867 RVA: 0x00272770 File Offset: 0x00270970
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57361, RefRangeEnd = 57363, XrefRangeStart = 57312, XrefRangeEnd = 57361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009004 RID: 36868 RVA: 0x002727A8 File Offset: 0x002709A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009005 RID: 36869 RVA: 0x0004E112 File Offset: 0x0004C312
			public _OpenRogueLikeResultPanelAsync_d__100(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009006 RID: 36870 RVA: 0x0004E11B File Offset: 0x0004C31B
			public _OpenRogueLikeResultPanelAsync_d__100() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenRogueLikeResultPanelAsync_d__100>.NativeClassPtr))
			{
			}

			// Token: 0x17003028 RID: 12328
			// (get) Token: 0x06009007 RID: 36871 RVA: 0x002727F0 File Offset: 0x002709F0
			// (set) Token: 0x06009008 RID: 36872 RVA: 0x0004E12D File Offset: 0x0004C32D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003029 RID: 12329
			// (get) Token: 0x06009009 RID: 36873 RVA: 0x00272818 File Offset: 0x00270A18
			// (set) Token: 0x0600900A RID: 36874 RVA: 0x0004E148 File Offset: 0x0004C348
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700302A RID: 12330
			// (get) Token: 0x0600900B RID: 36875 RVA: 0x00272848 File Offset: 0x00270A48
			// (set) Token: 0x0600900C RID: 36876 RVA: 0x0004E176 File Offset: 0x0004C376
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302B RID: 12331
			// (get) Token: 0x0600900D RID: 36877 RVA: 0x00272878 File Offset: 0x00270A78
			// (set) Token: 0x0600900E RID: 36878 RVA: 0x0004E195 File Offset: 0x0004C395
			public UniTask<DLC5_RogueLikeResultPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeResultPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeResultPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenRogueLikeResultPanelAsync_d__100.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeResultPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005DBC RID: 23996
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DBD RID: 23997
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005DBE RID: 23998
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04005DBF RID: 23999
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DC0 RID: 24000
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DC1 RID: 24001
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020005FC RID: 1532
		[ObfuscatedName("DayScene.UI.UIManager+<FadeInAndLeavePanelForRogueLike>d__101")]
		public sealed class _FadeInAndLeavePanelForRogueLike_d__101 : ValueType
		{
			// Token: 0x0600900F RID: 36879 RVA: 0x002728A8 File Offset: 0x00270AA8
			// Note: this type is marked as 'beforefieldinit'.
			static _FadeInAndLeavePanelForRogueLike_d__101()
			{
				Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<FadeInAndLeavePanelForRogueLike>d__101");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr);
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, "<>1__state");
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, "<>t__builder");
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr_onFadeFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, "onFadeFinish");
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, "<>u__1");
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, 100666912);
				UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr, 100666913);
			}

			// Token: 0x06009010 RID: 36880 RVA: 0x0027294C File Offset: 0x00270B4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 57372, RefRangeEnd = 57374, XrefRangeStart = 57363, XrefRangeEnd = 57372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009011 RID: 36881 RVA: 0x00272984 File Offset: 0x00270B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009012 RID: 36882 RVA: 0x0004E1C3 File Offset: 0x0004C3C3
			public _FadeInAndLeavePanelForRogueLike_d__101(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009013 RID: 36883 RVA: 0x0004E1CC File Offset: 0x0004C3CC
			public _FadeInAndLeavePanelForRogueLike_d__101() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._FadeInAndLeavePanelForRogueLike_d__101>.NativeClassPtr))
			{
			}

			// Token: 0x1700302C RID: 12332
			// (get) Token: 0x06009014 RID: 36884 RVA: 0x002729CC File Offset: 0x00270BCC
			// (set) Token: 0x06009015 RID: 36885 RVA: 0x0004E1DE File Offset: 0x0004C3DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700302D RID: 12333
			// (get) Token: 0x06009016 RID: 36886 RVA: 0x002729F4 File Offset: 0x00270BF4
			// (set) Token: 0x06009017 RID: 36887 RVA: 0x0004E1F9 File Offset: 0x0004C3F9
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700302E RID: 12334
			// (get) Token: 0x06009018 RID: 36888 RVA: 0x00272A24 File Offset: 0x00270C24
			// (set) Token: 0x06009019 RID: 36889 RVA: 0x0004E227 File Offset: 0x0004C427
			public unsafe Action onFadeFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr_onFadeFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr_onFadeFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700302F RID: 12335
			// (get) Token: 0x0600901A RID: 36890 RVA: 0x00272A54 File Offset: 0x00270C54
			// (set) Token: 0x0600901B RID: 36891 RVA: 0x0004E246 File Offset: 0x0004C446
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._FadeInAndLeavePanelForRogueLike_d__101.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005DC2 RID: 24002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005DC3 RID: 24003
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005DC4 RID: 24004
			private static readonly IntPtr NativeFieldInfoPtr_onFadeFinish;

			// Token: 0x04005DC5 RID: 24005
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005DC6 RID: 24006
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005DC7 RID: 24007
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
