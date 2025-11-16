using System;
using Common.Effects;
using Common.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI;
using DEYU.AdpUISystem.Managers;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Night.UI.HUD.Ordering;
using NightScene.EventUtility;
using NightScene.UI.EventUtility;
using NightScene.UI.HUDUtility;
using PrepNightScene.UI;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace NightScene.UI
{
	// Token: 0x020001B5 RID: 437
	public class UIManager : MonoSingleton<UIManager>
	{
		// Token: 0x0600355A RID: 13658 RVA: 0x001560C4 File Offset: 0x001542C4
		// Note: this type is marked as 'beforefieldinit'.
		static UIManager()
		{
			Il2CppClassPointerStore<UIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI", "UIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager>.NativeClassPtr);
			UIManager.NativeFieldInfoPtr_izakayaTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "izakayaTitle");
			UIManager.NativeFieldInfoPtr_izakayaDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "izakayaDescription");
			UIManager.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "onOpen");
			UIManager.NativeFieldInfoPtr_spellStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "spellStart");
			UIManager.NativeFieldInfoPtr_buffModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "buffModule");
			UIManager.NativeFieldInfoPtr_guestBuffMarkModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "guestBuffMarkModule");
			UIManager.NativeFieldInfoPtr_characterField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "characterField");
			UIManager.NativeFieldInfoPtr_throwDeliverParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "throwDeliverParent");
			UIManager.NativeFieldInfoPtr_sceneEffectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "sceneEffectField");
			UIManager.NativeFieldInfoPtr_UIPannelRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "UIPannelRoot");
			UIManager.NativeFieldInfoPtr_deskCodeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "deskCodeField");
			UIManager.NativeFieldInfoPtr_m_UiAnimationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_UiAnimationBack");
			UIManager.NativeFieldInfoPtr_m_UiAnimationMiddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_UiAnimationMiddle");
			UIManager.NativeFieldInfoPtr_m_UiAnimationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_UiAnimationFront");
			UIManager.NativeFieldInfoPtr_m_UiAnimationTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_UiAnimationTop");
			UIManager.NativeFieldInfoPtr_m_IncomeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_IncomeUI");
			UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyVisualElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_PlayerInputOnlyVisualElements");
			UIManager.NativeFieldInfoPtr_m_TraySpecialEffectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_TraySpecialEffectTransform");
			UIManager.NativeFieldInfoPtr_WorkSceneSustainedPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "WorkSceneSustainedPannel");
			UIManager.NativeFieldInfoPtr_DaySceneChatConfirmationPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneChatConfirmationPannel");
			UIManager.NativeFieldInfoPtr_DaySceneEventSelectionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "DaySceneEventSelectionPannel");
			UIManager.NativeFieldInfoPtr_cookerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "cookerParent");
			UIManager.NativeFieldInfoPtr_guestTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "guestTable");
			UIManager.NativeFieldInfoPtr_incomeBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "incomeBox");
			UIManager.NativeFieldInfoPtr_dialogField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "dialogField");
			UIManager.NativeFieldInfoPtr_spellDeclareTextParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "spellDeclareTextParent");
			UIManager.NativeFieldInfoPtr_spellDclareDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "spellDclareDuration");
			UIManager.NativeFieldInfoPtr_tipFinishSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "tipFinishSFX");
			UIManager.NativeFieldInfoPtr_clockController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "clockController");
			UIManager.NativeFieldInfoPtr_passionController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "passionController");
			UIManager.NativeFieldInfoPtr_comboController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "comboController");
			UIManager.NativeFieldInfoPtr_defaultIncomeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "defaultIncomeController");
			UIManager.NativeFieldInfoPtr_m_OrderController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_OrderController");
			UIManager.NativeFieldInfoPtr_partnerStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "partnerStateController");
			UIManager.NativeFieldInfoPtr_tipAndMoneyDisplayerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "tipAndMoneyDisplayerController");
			UIManager.NativeFieldInfoPtr_characterPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "characterPortrayal");
			UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "m_PlayerInputOnlyElementsTweenKey");
			UIManager.NativeFieldInfoPtr_defaultAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "defaultAnchoredPosition");
			UIManager.NativeFieldInfoPtr_kickIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "kickIndex");
			UIManager.NativeFieldInfoPtr_portrayalCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "portrayalCoroutine");
			UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<SustainedPannel>k__BackingField");
			UIManager.NativeFieldInfoPtr__OnSwitchingInputToPlayerCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OnSwitchingInputToPlayerCallback>k__BackingField");
			UIManager.NativeFieldInfoPtr__IncomeController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<IncomeController>k__BackingField");
			UIManager.NativeFieldInfoPtr__IncomeBoxPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<IncomeBoxPosition>k__BackingField");
			UIManager.NativeMethodInfoPtr_get_SustainedPannel_Public_get_WorkSceneSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673475);
			UIManager.NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_WorkSceneSustainedPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673476);
			UIManager.NativeMethodInfoPtr_get_OnSwitchingInputToPlayerCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673477);
			UIManager.NativeMethodInfoPtr_set_OnSwitchingInputToPlayerCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673478);
			UIManager.NativeMethodInfoPtr_get_UiAnimationBack_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673479);
			UIManager.NativeMethodInfoPtr_get_UiAnimationMiddle_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673480);
			UIManager.NativeMethodInfoPtr_get_UiAnimationFront_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673481);
			UIManager.NativeMethodInfoPtr_get_UiAnimationTop_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673482);
			UIManager.NativeMethodInfoPtr_get_IncomeUI_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673483);
			UIManager.NativeMethodInfoPtr_get_IncomeController_Public_get_IncomeControllerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673484);
			UIManager.NativeMethodInfoPtr_set_IncomeController_Public_set_Void_IncomeControllerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673485);
			UIManager.NativeMethodInfoPtr_get_TraySpecialEffectTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673486);
			UIManager.NativeMethodInfoPtr_get_IncomeBoxPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673487);
			UIManager.NativeMethodInfoPtr_set_IncomeBoxPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673488);
			UIManager.NativeMethodInfoPtr_Initialize_Public_Action_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673489);
			UIManager.NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673490);
			UIManager.NativeMethodInfoPtr_UniversalGameManager_OnPlayerInputAvailabilityUpdate_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673491);
			UIManager.NativeMethodInfoPtr_UpdateCurrentStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673492);
			UIManager.NativeMethodInfoPtr_InitializePlayerPortrayal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673493);
			UIManager.NativeMethodInfoPtr_SetPortrayal_Public_Void_Sprite_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673494);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673495);
			UIManager.NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673496);
			UIManager.NativeMethodInfoPtr_OpenEventSelectionModule_Public_Void_Dictionary_2_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673497);
			UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTaskVoid_Dictionary_2_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673498);
			UIManager.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673499);
			UIManager.NativeMethodInfoPtr_SetKickButton_Public_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673500);
			UIManager.NativeMethodInfoPtr_OnConfirmKick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673501);
			UIManager.NativeMethodInfoPtr_PlayOnOpenAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673502);
			UIManager.NativeMethodInfoPtr_SetPortrayalActive_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673503);
			UIManager.NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673504);
			UIManager.NativeMethodInfoPtr_ToggleIzakayaConfigureModule_Public_Void_Action_IPostExtraChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673505);
			UIManager.NativeMethodInfoPtr_RegisterConsistentBuffRecord_Public_Void_BuffType_Guid_Func_2_String_String_byref_Action_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673506);
			UIManager.NativeMethodInfoPtr_RegisterTimedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Single_byref_Action_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673507);
			UIManager.NativeMethodInfoPtr_RegisterCountedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Int32_byref_Action_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673508);
			UIManager.NativeMethodInfoPtr_SetExp_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673509);
			UIManager.NativeMethodInfoPtr_AddIncomeControllerUI_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673510);
			UIManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673511);
			UIManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673512);
			UIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673513);
			UIManager.NativeMethodInfoPtr__SetPortrayalActive_b__82_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager>.NativeClassPtr, 100673514);
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x00156784 File Offset: 0x00154984
		// (set) Token: 0x0600355C RID: 13660 RVA: 0x001567C4 File Offset: 0x001549C4
		public unsafe WorkSceneSustainedPannel SustainedPannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_SustainedPannel_Public_get_WorkSceneSustainedPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_WorkSceneSustainedPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x00156808 File Offset: 0x00154A08
		// (set) Token: 0x0600355E RID: 13662 RVA: 0x00156848 File Offset: 0x00154A48
		public unsafe Action OnSwitchingInputToPlayerCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_OnSwitchingInputToPlayerCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_OnSwitchingInputToPlayerCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x0015688C File Offset: 0x00154A8C
		public unsafe Transform UiAnimationBack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_UiAnimationBack_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x001568CC File Offset: 0x00154ACC
		public unsafe Transform UiAnimationMiddle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_UiAnimationMiddle_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06003561 RID: 13665 RVA: 0x0015690C File Offset: 0x00154B0C
		public unsafe Transform UiAnimationFront
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_UiAnimationFront_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x0015694C File Offset: 0x00154B4C
		public unsafe Transform UiAnimationTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_UiAnimationTop_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06003563 RID: 13667 RVA: 0x0015698C File Offset: 0x00154B8C
		public unsafe Transform IncomeUI
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_IncomeUI_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x001569CC File Offset: 0x00154BCC
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x00156A0C File Offset: 0x00154C0C
		public unsafe IncomeControllerBase IncomeController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_IncomeController_Public_get_IncomeControllerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IncomeControllerBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_IncomeController_Public_set_Void_IncomeControllerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x00156A50 File Offset: 0x00154C50
		public unsafe Transform TraySpecialEffectTransform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_TraySpecialEffectTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06003567 RID: 13671 RVA: 0x00156A90 File Offset: 0x00154C90
		// (set) Token: 0x06003568 RID: 13672 RVA: 0x00156ACC File Offset: 0x00154CCC
		public unsafe Vector2 IncomeBoxPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_get_IncomeBoxPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_set_IncomeBoxPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00156B0C File Offset: 0x00154D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126372, RefRangeEnd = 126373, XrefRangeStart = 126218, XrefRangeEnd = 126372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action Initialize(NightSceneDirector.ChallengeType challengeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref challengeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_Initialize_Public_Action_ChallengeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00156B58 File Offset: 0x00154D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126373, XrefRangeEnd = 126374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdpUIPanelManager_OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00156B98 File Offset: 0x00154D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UniversalGameManager_OnPlayerInputAvailabilityUpdate(bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_UniversalGameManager_OnPlayerInputAvailabilityUpdate_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00156BD8 File Offset: 0x00154DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126391, RefRangeEnd = 126394, XrefRangeStart = 126374, XrefRangeEnd = 126391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_UpdateCurrentStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00156C0C File Offset: 0x00154E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126410, RefRangeEnd = 126411, XrefRangeStart = 126394, XrefRangeEnd = 126410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePlayerPortrayal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_InitializePlayerPortrayal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00156C40 File Offset: 0x00154E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126416, RefRangeEnd = 126417, XrefRangeStart = 126411, XrefRangeEnd = 126416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPortrayal(Sprite image, Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetPortrayal_Public_Void_Sprite_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00156C90 File Offset: 0x00154E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126424, RefRangeEnd = 126425, XrefRangeStart = 126417, XrefRangeEnd = 126424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenChatConfirmationModule(Action<bool> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00156CD4 File Offset: 0x00154ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126425, XrefRangeEnd = 126431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003571 RID: 13681 RVA: 0x00156D24 File Offset: 0x00154F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126439, RefRangeEnd = 126440, XrefRangeStart = 126431, XrefRangeEnd = 126439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06003572 RID: 13682 RVA: 0x00156D78 File Offset: 0x00154F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126440, XrefRangeEnd = 126447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenEventSelectionModuleAsyncInternal(Dictionary<string, Action> options, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTaskVoid_Dictionary_2_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x00156DD8 File Offset: 0x00154FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126447, XrefRangeEnd = 126505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00156E0C File Offset: 0x0015500C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126516, RefRangeEnd = 126519, XrefRangeStart = 126505, XrefRangeEnd = 126516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKickButton(Nullable<int> kickIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kickIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetKickButton_Public_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00156E54 File Offset: 0x00155054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126519, XrefRangeEnd = 126541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConfirmKick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_OnConfirmKick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00156E88 File Offset: 0x00155088
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126546, RefRangeEnd = 126550, XrefRangeStart = 126541, XrefRangeEnd = 126546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOnOpenAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_PlayOnOpenAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00156EBC File Offset: 0x001550BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126557, RefRangeEnd = 126558, XrefRangeStart = 126550, XrefRangeEnd = 126557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPortrayalActive(bool active, bool doNotFade = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotFade;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetPortrayalActive_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00156F08 File Offset: 0x00155108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126563, RefRangeEnd = 126566, XrefRangeStart = 126558, XrefRangeEnd = 126563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteThrowDeliver(Sprite sprite, Vector3 target, Vector3 start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x00156F74 File Offset: 0x00155174
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 126570, RefRangeEnd = 126579, XrefRangeStart = 126566, XrefRangeEnd = 126570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleIzakayaConfigureModule(Action onConfigFinishCallback, IPostExtraChecker iPostExtraChecker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConfigFinishCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iPostExtraChecker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_ToggleIzakayaConfigureModule_Public_Void_Action_IPostExtraChecker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00156FC8 File Offset: 0x001551C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126583, RefRangeEnd = 126584, XrefRangeStart = 126579, XrefRangeEnd = 126583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterConsistentBuffRecord(EventManager.BuffType buffType, Guid guid, Func<string, string> getBuffDescriptionCallback, out Action onBuffFinish, Func<string, string> titleOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getBuffDescriptionCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(titleOverride);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_RegisterConsistentBuffRecord_Public_Void_BuffType_Guid_Func_2_String_String_byref_Action_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			onBuffFinish = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x0015705C File Offset: 0x0015525C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126587, RefRangeEnd = 126589, XrefRangeStart = 126584, XrefRangeEnd = 126587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTimedBuffRecord(EventManager.BuffType buffType, Guid guid, out Action<string, float> onBuffUpdate, out Action onBuffFinish, Func<string, string> titleOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(titleOverride);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_RegisterTimedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Single_byref_Action_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			onBuffUpdate = ((intPtr5 == 0) ? null : new Action<string, float>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			onBuffFinish = ((intPtr6 == 0) ? null : new Action(intPtr6));
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00157100 File Offset: 0x00155300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126592, RefRangeEnd = 126593, XrefRangeStart = 126589, XrefRangeEnd = 126592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCountedBuffRecord(EventManager.BuffType buffType, Guid guid, out Action<string, int> onBuffUpdate, out Action onBuffFinish, Func<string, string> titleOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(titleOverride);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_RegisterCountedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Int32_byref_Action_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			onBuffUpdate = ((intPtr5 == 0) ? null : new Action<string, int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			onBuffFinish = ((intPtr6 == 0) ? null : new Action(intPtr6));
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x001571A4 File Offset: 0x001553A4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExp(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_SetExp_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x001571E4 File Offset: 0x001553E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126623, RefRangeEnd = 126625, XrefRangeStart = 126593, XrefRangeEnd = 126623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIncomeControllerUI(GameObject incomeControllerUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(incomeControllerUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr_AddIncomeControllerUI_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00157228 File Offset: 0x00155428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126625, XrefRangeEnd = 126628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00157264 File Offset: 0x00155464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126628, XrefRangeEnd = 126667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x001572A0 File Offset: 0x001554A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126667, XrefRangeEnd = 126676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x001572DC File Offset: 0x001554DC
		[CallerCount(0)]
		public unsafe void _SetPortrayalActive_b__82_0(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.NativeMethodInfoPtr__SetPortrayalActive_b__82_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0001D928 File Offset: 0x0001BB28
		public UIManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003584 RID: 13700 RVA: 0x0015731C File Offset: 0x0015551C
		// (set) Token: 0x06003585 RID: 13701 RVA: 0x0001D931 File Offset: 0x0001BB31
		public unsafe TextMeshProUGUI izakayaTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_izakayaTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_izakayaTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06003586 RID: 13702 RVA: 0x0015734C File Offset: 0x0015554C
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x0001D950 File Offset: 0x0001BB50
		public unsafe TextMeshProUGUI izakayaDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_izakayaDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_izakayaDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06003588 RID: 13704 RVA: 0x0015737C File Offset: 0x0015557C
		// (set) Token: 0x06003589 RID: 13705 RVA: 0x0001D96F File Offset: 0x0001BB6F
		public unsafe AudioClip onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x001573AC File Offset: 0x001555AC
		// (set) Token: 0x0600358B RID: 13707 RVA: 0x0001D98E File Offset: 0x0001BB8E
		public unsafe AudioClip spellStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x001573DC File Offset: 0x001555DC
		// (set) Token: 0x0600358D RID: 13709 RVA: 0x0001D9AD File Offset: 0x0001BBAD
		public unsafe BuffModule buffModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_buffModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_buffModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x0015740C File Offset: 0x0015560C
		// (set) Token: 0x0600358F RID: 13711 RVA: 0x0001D9CC File Offset: 0x0001BBCC
		public unsafe GuestBuffMarkModule guestBuffMarkModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_guestBuffMarkModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestBuffMarkModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_guestBuffMarkModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003590 RID: 13712 RVA: 0x0015743C File Offset: 0x0015563C
		// (set) Token: 0x06003591 RID: 13713 RVA: 0x0001D9EB File Offset: 0x0001BBEB
		public unsafe Transform characterField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_characterField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_characterField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x0015746C File Offset: 0x0015566C
		// (set) Token: 0x06003593 RID: 13715 RVA: 0x0001DA0A File Offset: 0x0001BC0A
		public unsafe GameObject throwDeliverParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_throwDeliverParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_throwDeliverParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003594 RID: 13716 RVA: 0x0015749C File Offset: 0x0015569C
		// (set) Token: 0x06003595 RID: 13717 RVA: 0x0001DA29 File Offset: 0x0001BC29
		public unsafe Transform sceneEffectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_sceneEffectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_sceneEffectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x001574CC File Offset: 0x001556CC
		// (set) Token: 0x06003597 RID: 13719 RVA: 0x0001DA48 File Offset: 0x0001BC48
		public unsafe RectTransform UIPannelRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_UIPannelRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_UIPannelRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x001574FC File Offset: 0x001556FC
		// (set) Token: 0x06003599 RID: 13721 RVA: 0x0001DA67 File Offset: 0x0001BC67
		public unsafe Transform deskCodeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_deskCodeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_deskCodeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600359A RID: 13722 RVA: 0x0015752C File Offset: 0x0015572C
		// (set) Token: 0x0600359B RID: 13723 RVA: 0x0001DA86 File Offset: 0x0001BC86
		public unsafe Transform m_UiAnimationBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x0015755C File Offset: 0x0015575C
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x0001DAA5 File Offset: 0x0001BCA5
		public unsafe Transform m_UiAnimationMiddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationMiddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationMiddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0015758C File Offset: 0x0015578C
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
		public unsafe Transform m_UiAnimationFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x001575BC File Offset: 0x001557BC
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x0001DAE3 File Offset: 0x0001BCE3
		public unsafe Transform m_UiAnimationTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_UiAnimationTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x001575EC File Offset: 0x001557EC
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x0001DB02 File Offset: 0x0001BD02
		public unsafe Transform m_IncomeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_IncomeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_IncomeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x0015761C File Offset: 0x0015581C
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x0001DB21 File Offset: 0x0001BD21
		public unsafe Il2CppReferenceArray<CanvasGroup> m_PlayerInputOnlyVisualElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyVisualElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyVisualElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x0015764C File Offset: 0x0015584C
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x0001DB40 File Offset: 0x0001BD40
		public unsafe Transform m_TraySpecialEffectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_TraySpecialEffectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_TraySpecialEffectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x0015767C File Offset: 0x0015587C
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x0001DB5F File Offset: 0x0001BD5F
		public unsafe WorkSceneSustainedPannel WorkSceneSustainedPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_WorkSceneSustainedPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_WorkSceneSustainedPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x001576AC File Offset: 0x001558AC
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x0001DB7E File Offset: 0x0001BD7E
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

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x001576DC File Offset: 0x001558DC
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x0001DB9D File Offset: 0x0001BD9D
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

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x0015770C File Offset: 0x0015590C
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		public unsafe GameObject cookerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_cookerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_cookerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x0015773C File Offset: 0x0015593C
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x0001DBDB File Offset: 0x0001BDDB
		public unsafe GameObject guestTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_guestTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_guestTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0015776C File Offset: 0x0015596C
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x0001DBFA File Offset: 0x0001BDFA
		public unsafe RectTransform incomeBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_incomeBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_incomeBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x0015779C File Offset: 0x0015599C
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x0001DC19 File Offset: 0x0001BE19
		public unsafe Transform dialogField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_dialogField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_dialogField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x001577CC File Offset: 0x001559CC
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x0001DC38 File Offset: 0x0001BE38
		public unsafe GameObject spellDeclareTextParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellDeclareTextParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellDeclareTextParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x001577FC File Offset: 0x001559FC
		// (set) Token: 0x060035B9 RID: 13753 RVA: 0x0001DC57 File Offset: 0x0001BE57
		public unsafe float spellDclareDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellDclareDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_spellDclareDuration)) = value;
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x00157824 File Offset: 0x00155A24
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x0001DC72 File Offset: 0x0001BE72
		public unsafe Il2CppReferenceArray<AudioClip> tipFinishSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_tipFinishSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_tipFinishSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x00157854 File Offset: 0x00155A54
		// (set) Token: 0x060035BD RID: 13757 RVA: 0x0001DC91 File Offset: 0x0001BE91
		public unsafe ClockController clockController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_clockController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_clockController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00157884 File Offset: 0x00155A84
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		public unsafe PassionController passionController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_passionController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PassionController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_passionController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x001578B4 File Offset: 0x00155AB4
		// (set) Token: 0x060035C1 RID: 13761 RVA: 0x0001DCCF File Offset: 0x0001BECF
		public unsafe ComboController comboController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_comboController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComboController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_comboController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x001578E4 File Offset: 0x00155AE4
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x0001DCEE File Offset: 0x0001BEEE
		public unsafe GameObject defaultIncomeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_defaultIncomeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_defaultIncomeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x00157914 File Offset: 0x00155B14
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x0001DD0D File Offset: 0x0001BF0D
		public unsafe OrderController m_OrderController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_OrderController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_OrderController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x00157944 File Offset: 0x00155B44
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x0001DD2C File Offset: 0x0001BF2C
		public unsafe PartnerStateModuleUI partnerStateController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_partnerStateController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerStateModuleUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_partnerStateController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x00157974 File Offset: 0x00155B74
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x0001DD4B File Offset: 0x0001BF4B
		public unsafe TipAndMoneyDisplayerController tipAndMoneyDisplayerController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_tipAndMoneyDisplayerController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TipAndMoneyDisplayerController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_tipAndMoneyDisplayerController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x001579A4 File Offset: 0x00155BA4
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x0001DD6A File Offset: 0x0001BF6A
		public unsafe Image characterPortrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_characterPortrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_characterPortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x001579D4 File Offset: 0x00155BD4
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x0001DD89 File Offset: 0x0001BF89
		public unsafe UnityEngine.Object m_PlayerInputOnlyElementsTweenKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x00157A04 File Offset: 0x00155C04
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		public unsafe Vector2 defaultAnchoredPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_defaultAnchoredPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_defaultAnchoredPosition)) = value;
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x00157A2C File Offset: 0x00155C2C
		// (set) Token: 0x060035D1 RID: 13777 RVA: 0x0001DDC3 File Offset: 0x0001BFC3
		public Nullable<int> kickIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_kickIndex);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_kickIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x00157A5C File Offset: 0x00155C5C
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x0001DDF1 File Offset: 0x0001BFF1
		public unsafe Coroutine portrayalCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_portrayalCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr_portrayalCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x00157A8C File Offset: 0x00155C8C
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0001DE10 File Offset: 0x0001C010
		public unsafe WorkSceneSustainedPannel _SustainedPannel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__SustainedPannel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x00157ABC File Offset: 0x00155CBC
		// (set) Token: 0x060035D7 RID: 13783 RVA: 0x0001DE2F File Offset: 0x0001C02F
		public unsafe Action _OnSwitchingInputToPlayerCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__OnSwitchingInputToPlayerCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__OnSwitchingInputToPlayerCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x00157AEC File Offset: 0x00155CEC
		// (set) Token: 0x060035D9 RID: 13785 RVA: 0x0001DE4E File Offset: 0x0001C04E
		public unsafe IncomeControllerBase _IncomeController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__IncomeController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__IncomeController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x00157B1C File Offset: 0x00155D1C
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x0001DE6D File Offset: 0x0001C06D
		public unsafe Vector2 _IncomeBoxPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__IncomeBoxPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.NativeFieldInfoPtr__IncomeBoxPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeFieldInfoPtr_izakayaTitle;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeFieldInfoPtr_izakayaDescription;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeFieldInfoPtr_spellStart;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeFieldInfoPtr_buffModule;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeFieldInfoPtr_guestBuffMarkModule;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeFieldInfoPtr_characterField;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeFieldInfoPtr_throwDeliverParent;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeFieldInfoPtr_sceneEffectField;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeFieldInfoPtr_UIPannelRoot;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeFieldInfoPtr_deskCodeField;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeFieldInfoPtr_m_UiAnimationBack;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeFieldInfoPtr_m_UiAnimationMiddle;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeFieldInfoPtr_m_UiAnimationFront;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeFieldInfoPtr_m_UiAnimationTop;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeFieldInfoPtr_m_IncomeUI;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerInputOnlyVisualElements;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeFieldInfoPtr_m_TraySpecialEffectTransform;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneSustainedPannel;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneChatConfirmationPannel;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeFieldInfoPtr_DaySceneEventSelectionPannel;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeFieldInfoPtr_cookerParent;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeFieldInfoPtr_guestTable;

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_incomeBox;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeFieldInfoPtr_dialogField;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeFieldInfoPtr_spellDeclareTextParent;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeFieldInfoPtr_spellDclareDuration;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeFieldInfoPtr_tipFinishSFX;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeFieldInfoPtr_clockController;

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeFieldInfoPtr_passionController;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeFieldInfoPtr_comboController;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeFieldInfoPtr_defaultIncomeController;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeFieldInfoPtr_m_OrderController;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeFieldInfoPtr_partnerStateController;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeFieldInfoPtr_tipAndMoneyDisplayerController;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeFieldInfoPtr_characterPortrayal;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeFieldInfoPtr_defaultAnchoredPosition;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeFieldInfoPtr_kickIndex;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeFieldInfoPtr_portrayalCoroutine;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeFieldInfoPtr__SustainedPannel_k__BackingField;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeFieldInfoPtr__OnSwitchingInputToPlayerCallback_k__BackingField;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeFieldInfoPtr__IncomeController_k__BackingField;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeFieldInfoPtr__IncomeBoxPosition_k__BackingField;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_get_SustainedPannel_Public_get_WorkSceneSustainedPannel_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_set_SustainedPannel_Private_set_Void_WorkSceneSustainedPannel_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSwitchingInputToPlayerCallback_Public_get_Action_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSwitchingInputToPlayerCallback_Public_set_Void_Action_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationBack_Public_get_Transform_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationMiddle_Public_get_Transform_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationFront_Public_get_Transform_0;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr_get_UiAnimationTop_Public_get_Transform_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_get_IncomeUI_Public_get_Transform_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_get_IncomeController_Public_get_IncomeControllerBase_0;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeMethodInfoPtr_set_IncomeController_Public_set_Void_IncomeControllerBase_0;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeMethodInfoPtr_get_TraySpecialEffectTransform_Public_get_Transform_0;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeMethodInfoPtr_get_IncomeBoxPosition_Public_get_Vector2_0;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeMethodInfoPtr_set_IncomeBoxPosition_Private_set_Void_Vector2_0;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Action_ChallengeType_0;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeMethodInfoPtr_UniversalGameManager_OnPlayerInputAvailabilityUpdate_Private_Void_Boolean_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentStatus_Private_Void_0;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_InitializePlayerPortrayal_Public_Void_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_SetPortrayal_Public_Void_Sprite_Vector2_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModule_Public_Void_Action_1_Boolean_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeMethodInfoPtr_OpenChatConfirmationModuleAsyncInternal_Private_UniTaskVoid_Action_1_Boolean_0;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_OpenEventSelectionModule_Public_Void_Dictionary_2_String_Action_Action_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_OpenEventSelectionModuleAsyncInternal_Private_UniTaskVoid_Dictionary_2_String_Action_Action_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_SetKickButton_Public_Void_Nullable_1_Int32_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_OnConfirmKick_Private_Void_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_PlayOnOpenAudio_Public_Void_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_SetPortrayalActive_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_Vector3_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_ToggleIzakayaConfigureModule_Public_Void_Action_IPostExtraChecker_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConsistentBuffRecord_Public_Void_BuffType_Guid_Func_2_String_String_byref_Action_Func_2_String_String_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTimedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Single_byref_Action_Func_2_String_String_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCountedBuffRecord_Public_Void_BuffType_Guid_byref_Action_2_String_Int32_byref_Action_Func_2_String_String_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_SetExp_Private_Void_Int32_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_AddIncomeControllerUI_Public_Void_GameObject_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr__SetPortrayalActive_b__82_0_Private_Void_Single_0;

		// Token: 0x0200090D RID: 2317
		[ObfuscatedName("NightScene.UI.UIManager+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B705 RID: 46853 RVA: 0x002E686C File Offset: 0x002E4A6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr);
				UIManager.__c__DisplayClass75_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr, "onFinish");
				UIManager.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr, 100673515);
				UIManager.__c__DisplayClass75_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr, 100673516);
			}

			// Token: 0x0600B706 RID: 46854 RVA: 0x002E68D4 File Offset: 0x002E4AD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B707 RID: 46855 RVA: 0x002E6910 File Offset: 0x002E4B10
			[CallerCount(0)]
			public unsafe void _OpenChatConfirmationModuleAsyncInternal_b__0(DaySceneChatConfirmationPannel pannelInstance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass75_0.NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B708 RID: 46856 RVA: 0x00062A38 File Offset: 0x00060C38
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BFF RID: 15359
			// (get) Token: 0x0600B709 RID: 46857 RVA: 0x002E6954 File Offset: 0x002E4B54
			// (set) Token: 0x0600B70A RID: 46858 RVA: 0x00062A41 File Offset: 0x00060C41
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass75_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass75_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007683 RID: 30339
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04007684 RID: 30340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007685 RID: 30341
			private static readonly IntPtr NativeMethodInfoPtr__OpenChatConfirmationModuleAsyncInternal_b__0_Internal_Void_DaySceneChatConfirmationPannel_0;
		}

		// Token: 0x0200090E RID: 2318
		[ObfuscatedName("NightScene.UI.UIManager+<OpenChatConfirmationModuleAsyncInternal>d__75")]
		public sealed class _OpenChatConfirmationModuleAsyncInternal_d__75 : ValueType
		{
			// Token: 0x0600B70B RID: 46859 RVA: 0x002E6984 File Offset: 0x002E4B84
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenChatConfirmationModuleAsyncInternal_d__75()
			{
				Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenChatConfirmationModuleAsyncInternal>d__75");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>1__state");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>t__builder");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "onFinish");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>4__this");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>8__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>u__1");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, "<>u__2");
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, 100673517);
				UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr, 100673518);
			}

			// Token: 0x0600B70C RID: 46860 RVA: 0x002E6A64 File Offset: 0x002E4C64
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126158, RefRangeEnd = 126160, XrefRangeStart = 126129, XrefRangeEnd = 126158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B70D RID: 46861 RVA: 0x002E6A9C File Offset: 0x002E4C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B70E RID: 46862 RVA: 0x00062A60 File Offset: 0x00060C60
			public _OpenChatConfirmationModuleAsyncInternal_d__75(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B70F RID: 46863 RVA: 0x00062A69 File Offset: 0x00060C69
			public _OpenChatConfirmationModuleAsyncInternal_d__75() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenChatConfirmationModuleAsyncInternal_d__75>.NativeClassPtr))
			{
			}

			// Token: 0x17003C00 RID: 15360
			// (get) Token: 0x0600B710 RID: 46864 RVA: 0x002E6AE4 File Offset: 0x002E4CE4
			// (set) Token: 0x0600B711 RID: 46865 RVA: 0x00062A7B File Offset: 0x00060C7B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C01 RID: 15361
			// (get) Token: 0x0600B712 RID: 46866 RVA: 0x002E6B0C File Offset: 0x002E4D0C
			// (set) Token: 0x0600B713 RID: 46867 RVA: 0x00062A96 File Offset: 0x00060C96
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C02 RID: 15362
			// (get) Token: 0x0600B714 RID: 46868 RVA: 0x002E6B3C File Offset: 0x002E4D3C
			// (set) Token: 0x0600B715 RID: 46869 RVA: 0x00062AC4 File Offset: 0x00060CC4
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C03 RID: 15363
			// (get) Token: 0x0600B716 RID: 46870 RVA: 0x002E6B6C File Offset: 0x002E4D6C
			// (set) Token: 0x0600B717 RID: 46871 RVA: 0x00062AE3 File Offset: 0x00060CE3
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C04 RID: 15364
			// (get) Token: 0x0600B718 RID: 46872 RVA: 0x002E6B9C File Offset: 0x002E4D9C
			// (set) Token: 0x0600B719 RID: 46873 RVA: 0x00062B02 File Offset: 0x00060D02
			public unsafe UIManager.__c__DisplayClass75_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass75_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C05 RID: 15365
			// (get) Token: 0x0600B71A RID: 46874 RVA: 0x002E6BCC File Offset: 0x002E4DCC
			// (set) Token: 0x0600B71B RID: 46875 RVA: 0x00062B21 File Offset: 0x00060D21
			public UniTask<DaySceneChatConfirmationPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneChatConfirmationPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneChatConfirmationPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C06 RID: 15366
			// (get) Token: 0x0600B71C RID: 46876 RVA: 0x002E6BFC File Offset: 0x002E4DFC
			// (set) Token: 0x0600B71D RID: 46877 RVA: 0x00062B4F File Offset: 0x00060D4F
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenChatConfirmationModuleAsyncInternal_d__75.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007686 RID: 30342
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007687 RID: 30343
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04007688 RID: 30344
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04007689 RID: 30345
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400768A RID: 30346
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400768B RID: 30347
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400768C RID: 30348
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400768D RID: 30349
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400768E RID: 30350
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200090F RID: 2319
		[ObfuscatedName("NightScene.UI.UIManager+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B71E RID: 46878 RVA: 0x002E6C2C File Offset: 0x002E4E2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr);
				UIManager.__c__DisplayClass77_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr, "onFinish");
				UIManager.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr, 100673519);
				UIManager.__c__DisplayClass77_0.NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr, 100673520);
			}

			// Token: 0x0600B71F RID: 46879 RVA: 0x002E6C94 File Offset: 0x002E4E94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B720 RID: 46880 RVA: 0x002E6CD0 File Offset: 0x002E4ED0
			[CallerCount(0)]
			public unsafe void _OpenEventSelectionModuleAsyncInternal_b__0(DaySceneEventSelectionPannel _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager.__c__DisplayClass77_0.NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B721 RID: 46881 RVA: 0x00062B7D File Offset: 0x00060D7D
			public __c__DisplayClass77_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C07 RID: 15367
			// (get) Token: 0x0600B722 RID: 46882 RVA: 0x002E6D14 File Offset: 0x002E4F14
			// (set) Token: 0x0600B723 RID: 46883 RVA: 0x00062B86 File Offset: 0x00060D86
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass77_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager.__c__DisplayClass77_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400768F RID: 30351
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04007690 RID: 30352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007691 RID: 30353
			private static readonly IntPtr NativeMethodInfoPtr__OpenEventSelectionModuleAsyncInternal_b__0_Internal_Void_DaySceneEventSelectionPannel_0;
		}

		// Token: 0x02000910 RID: 2320
		[ObfuscatedName("NightScene.UI.UIManager+<OpenEventSelectionModuleAsyncInternal>d__77")]
		public sealed class _OpenEventSelectionModuleAsyncInternal_d__77 : ValueType
		{
			// Token: 0x0600B724 RID: 46884 RVA: 0x002E6D44 File Offset: 0x002E4F44
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenEventSelectionModuleAsyncInternal_d__77()
			{
				Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<OpenEventSelectionModuleAsyncInternal>d__77");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr);
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>1__state");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>t__builder");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "onFinish");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>4__this");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "options");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>8__1");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>u__1");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, "<>u__2");
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, 100673521);
				UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr, 100673522);
			}

			// Token: 0x0600B725 RID: 46885 RVA: 0x002E6E38 File Offset: 0x002E5038
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126199, RefRangeEnd = 126201, XrefRangeStart = 126160, XrefRangeEnd = 126199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B726 RID: 46886 RVA: 0x002E6E70 File Offset: 0x002E5070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B727 RID: 46887 RVA: 0x00062BA5 File Offset: 0x00060DA5
			public _OpenEventSelectionModuleAsyncInternal_d__77(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B728 RID: 46888 RVA: 0x00062BAE File Offset: 0x00060DAE
			public _OpenEventSelectionModuleAsyncInternal_d__77() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._OpenEventSelectionModuleAsyncInternal_d__77>.NativeClassPtr))
			{
			}

			// Token: 0x17003C08 RID: 15368
			// (get) Token: 0x0600B729 RID: 46889 RVA: 0x002E6EB8 File Offset: 0x002E50B8
			// (set) Token: 0x0600B72A RID: 46890 RVA: 0x00062BC0 File Offset: 0x00060DC0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C09 RID: 15369
			// (get) Token: 0x0600B72B RID: 46891 RVA: 0x002E6EE0 File Offset: 0x002E50E0
			// (set) Token: 0x0600B72C RID: 46892 RVA: 0x00062BDB File Offset: 0x00060DDB
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C0A RID: 15370
			// (get) Token: 0x0600B72D RID: 46893 RVA: 0x002E6F10 File Offset: 0x002E5110
			// (set) Token: 0x0600B72E RID: 46894 RVA: 0x00062C09 File Offset: 0x00060E09
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0B RID: 15371
			// (get) Token: 0x0600B72F RID: 46895 RVA: 0x002E6F40 File Offset: 0x002E5140
			// (set) Token: 0x0600B730 RID: 46896 RVA: 0x00062C28 File Offset: 0x00060E28
			public unsafe UIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0C RID: 15372
			// (get) Token: 0x0600B731 RID: 46897 RVA: 0x002E6F70 File Offset: 0x002E5170
			// (set) Token: 0x0600B732 RID: 46898 RVA: 0x00062C47 File Offset: 0x00060E47
			public unsafe Dictionary<string, Action> options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0D RID: 15373
			// (get) Token: 0x0600B733 RID: 46899 RVA: 0x002E6FA0 File Offset: 0x002E51A0
			// (set) Token: 0x0600B734 RID: 46900 RVA: 0x00062C66 File Offset: 0x00060E66
			public unsafe UIManager.__c__DisplayClass77_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager.__c__DisplayClass77_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C0E RID: 15374
			// (get) Token: 0x0600B735 RID: 46901 RVA: 0x002E6FD0 File Offset: 0x002E51D0
			// (set) Token: 0x0600B736 RID: 46902 RVA: 0x00062C85 File Offset: 0x00060E85
			public UniTask<DaySceneEventSelectionPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneEventSelectionPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneEventSelectionPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DayScene.UI.DaySceneEventSelectionPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C0F RID: 15375
			// (get) Token: 0x0600B737 RID: 46903 RVA: 0x002E7000 File Offset: 0x002E5200
			// (set) Token: 0x0600B738 RID: 46904 RVA: 0x00062CB3 File Offset: 0x00060EB3
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._OpenEventSelectionModuleAsyncInternal_d__77.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007692 RID: 30354
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007693 RID: 30355
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04007694 RID: 30356
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04007695 RID: 30357
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007696 RID: 30358
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x04007697 RID: 30359
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007698 RID: 30360
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04007699 RID: 30361
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400769A RID: 30362
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400769B RID: 30363
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000911 RID: 2321
		[ObfuscatedName("NightScene.UI.UIManager+<ExecuteThrowDeliver>d__83")]
		public sealed class _ExecuteThrowDeliver_d__83 : Il2CppSystem.Object
		{
			// Token: 0x0600B739 RID: 46905 RVA: 0x002E7030 File Offset: 0x002E5230
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteThrowDeliver_d__83()
			{
				Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIManager>.NativeClassPtr, "<ExecuteThrowDeliver>d__83");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr);
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "<>1__state");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "<>2__current");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "start");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "target");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "sprite");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__controllableLaunch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "<controllableLaunch>5__2");
				UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__pushCallback_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, "<pushCallback>5__3");
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673523);
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673524);
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673525);
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673526);
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673527);
				UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr, 100673528);
			}

			// Token: 0x0600B73A RID: 46906 RVA: 0x002E7160 File Offset: 0x002E5360
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteThrowDeliver_d__83(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIManager._ExecuteThrowDeliver_d__83>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B73B RID: 46907 RVA: 0x002E71A8 File Offset: 0x002E53A8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B73C RID: 46908 RVA: 0x002E71DC File Offset: 0x002E53DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126201, XrefRangeEnd = 126212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003C17 RID: 15383
			// (get) Token: 0x0600B73D RID: 46909 RVA: 0x002E7218 File Offset: 0x002E5418
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B73E RID: 46910 RVA: 0x002E7258 File Offset: 0x002E5458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126212, XrefRangeEnd = 126218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003C18 RID: 15384
			// (get) Token: 0x0600B73F RID: 46911 RVA: 0x002E728C File Offset: 0x002E548C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIManager._ExecuteThrowDeliver_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B740 RID: 46912 RVA: 0x00062CE1 File Offset: 0x00060EE1
			public _ExecuteThrowDeliver_d__83(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C10 RID: 15376
			// (get) Token: 0x0600B741 RID: 46913 RVA: 0x002E72CC File Offset: 0x002E54CC
			// (set) Token: 0x0600B742 RID: 46914 RVA: 0x00062CEA File Offset: 0x00060EEA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C11 RID: 15377
			// (get) Token: 0x0600B743 RID: 46915 RVA: 0x002E72F4 File Offset: 0x002E54F4
			// (set) Token: 0x0600B744 RID: 46916 RVA: 0x00062D05 File Offset: 0x00060F05
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C12 RID: 15378
			// (get) Token: 0x0600B745 RID: 46917 RVA: 0x002E7324 File Offset: 0x002E5524
			// (set) Token: 0x0600B746 RID: 46918 RVA: 0x00062D24 File Offset: 0x00060F24
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17003C13 RID: 15379
			// (get) Token: 0x0600B747 RID: 46919 RVA: 0x002E734C File Offset: 0x002E554C
			// (set) Token: 0x0600B748 RID: 46920 RVA: 0x00062D3F File Offset: 0x00060F3F
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x17003C14 RID: 15380
			// (get) Token: 0x0600B749 RID: 46921 RVA: 0x002E7374 File Offset: 0x002E5574
			// (set) Token: 0x0600B74A RID: 46922 RVA: 0x00062D5A File Offset: 0x00060F5A
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C15 RID: 15381
			// (get) Token: 0x0600B74B RID: 46923 RVA: 0x002E73A4 File Offset: 0x002E55A4
			// (set) Token: 0x0600B74C RID: 46924 RVA: 0x00062D79 File Offset: 0x00060F79
			public unsafe ControllableLaunchAnimation _controllableLaunch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__controllableLaunch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllableLaunchAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__controllableLaunch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C16 RID: 15382
			// (get) Token: 0x0600B74D RID: 46925 RVA: 0x002E73D4 File Offset: 0x002E55D4
			// (set) Token: 0x0600B74E RID: 46926 RVA: 0x00062D98 File Offset: 0x00060F98
			public unsafe Action<ControllableLaunchAnimation> _pushCallback_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__pushCallback_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ControllableLaunchAnimation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIManager._ExecuteThrowDeliver_d__83.NativeFieldInfoPtr__pushCallback_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400769C RID: 30364
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400769D RID: 30365
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400769E RID: 30366
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x0400769F RID: 30367
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x040076A0 RID: 30368
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x040076A1 RID: 30369
			private static readonly IntPtr NativeFieldInfoPtr__controllableLaunch_5__2;

			// Token: 0x040076A2 RID: 30370
			private static readonly IntPtr NativeFieldInfoPtr__pushCallback_5__3;

			// Token: 0x040076A3 RID: 30371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040076A4 RID: 30372
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076A5 RID: 30373
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040076A6 RID: 30374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040076A7 RID: 30375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076A8 RID: 30376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
