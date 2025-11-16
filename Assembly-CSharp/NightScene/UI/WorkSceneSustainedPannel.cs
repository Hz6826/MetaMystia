using System;
using Common.UI;
using Common.UI.QTEUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.MusicUtility;
using NightScene.UI.CookingUtility;
using NightScene.UI.GuestManagementUtility;
using NightScene.UI.HUDUtility;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI
{
	// Token: 0x020001B8 RID: 440
	public class WorkSceneSustainedPannel : ExtendedSustainedPannel
	{
		// Token: 0x0600361C RID: 13852 RVA: 0x001587E8 File Offset: 0x001569E8
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneSustainedPannel()
		{
			Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI", "WorkSceneSustainedPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr);
			WorkSceneSustainedPannel.NativeFieldInfoPtr_DailyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "DailyBtn");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "KickBtn");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "KickBtnGroup");
			WorkSceneSustainedPannel.NativeFieldInfoPtr__KickBtnHold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<KickBtnHold>k__BackingField");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneTrayPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneTrayPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneDailyDisplayerPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneDailyDisplayerPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneCookingSelectionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneCookingSelectionPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneEmptyDeskPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneEmptyDeskPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneBinPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneBinPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneServePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneServePannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneQTEPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneLegacyQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneLegacyQTEPannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneStoragePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneStoragePannel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneThrowDeliverPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "WorkSceneThrowDeliverPanel");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_GotoDailyDisplayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_GotoDailyDisplayerBlocker");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_BufferRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_BufferRectTransform");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_KickBtnTweenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_KickBtnTweenKey");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroupArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "KickBtnGroupArray");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_IfKickBtnActived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_IfKickBtnActived");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_WorkSceneTrayPannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_WorkSceneTrayPannelInstance");
			WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldStartHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<OnSecondarySwitchHoldStartHandle>k__BackingField");
			WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldEndHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<OnSecondarySwitchHoldEndHandle>k__BackingField");
			WorkSceneSustainedPannel.NativeFieldInfoPtr__OnTertiarySwitchHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<OnTertiarySwitchHandle>k__BackingField");
			WorkSceneSustainedPannel.NativeFieldInfoPtr__ShouldReopenThrowDeliverPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<ShouldReopenThrowDeliverPanel>k__BackingField");
			WorkSceneSustainedPannel.NativeFieldInfoPtr_m_LastCloseTrayStackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "m_LastCloseTrayStackTrace");
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_KickBtnHold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673576);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_set_KickBtnHold_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673577);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_BufferRectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673578);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673579);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673580);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673581);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnSecondarySwitchHoldStartHandle_Private_get_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673582);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnSecondarySwitchHoldStartHandle_Public_set_Void_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673583);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnSecondarySwitchHoldEndHandle_Private_get_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673584);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnSecondarySwitchHoldEndHandle_Public_set_Void_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673585);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnTertiarySwitchHandle_Private_get_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673586);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnTertiarySwitchHandle_Public_set_Void_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673587);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_IsTrayOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673588);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_get_ShouldReopenThrowDeliverPanel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673589);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_set_ShouldReopenThrowDeliverPanel_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673590);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673591);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673592);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_SetKickButtonAvailability_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673593);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenThrowDeliverPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673594);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673595);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenDailyPanelParameterless_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673596);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenDailyPannel_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673597);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenCookingSelectionPannel_Public_Void_CookController_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673598);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelManual_Public_Void_Single_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673599);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenEmptyDeskPannel_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673600);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenStoragePannel_Public_Void_SellableType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673601);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenBinPannel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673602);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenServePanel_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673603);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenTrayPanel_Public_WorkSceneTrayPannel_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673604);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_CloseTrayPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673605);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673606);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673607);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673608);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_TryExecuteHoldKickButton_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673609);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_TryReleaseHoldKickButton_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673610);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673611);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673612);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelForCook_Private_UniTaskVoid_Single_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673613);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelInternalAsync_Private_UniTask_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673614);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenTrayPanelVisualOnly_Public_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673615);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673616);
			WorkSceneSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673617);
			WorkSceneSustainedPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673618);
			WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673619);
			WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673620);
			WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_2_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, 100673621);
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x00158DA4 File Offset: 0x00156FA4
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x00158DE0 File Offset: 0x00156FE0
		public unsafe bool KickBtnHold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_KickBtnHold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_set_KickBtnHold_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x00158E20 File Offset: 0x00157020
		public unsafe RectTransform BufferRectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_BufferRectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x00158E60 File Offset: 0x00157060
		public unsafe override string HoldActionMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127293, XrefRangeEnd = 127295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x00158EA4 File Offset: 0x001570A4
		public unsafe override string HoldActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127295, XrefRangeEnd = 127296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x00158EE8 File Offset: 0x001570E8
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x00158F30 File Offset: 0x00157130
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x00158F70 File Offset: 0x00157170
		public unsafe Action<InputAction.CallbackContext> OnSecondarySwitchHoldStartHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnSecondarySwitchHoldStartHandle_Private_get_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnSecondarySwitchHoldStartHandle_Public_set_Void_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x00158FB4 File Offset: 0x001571B4
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x00158FF4 File Offset: 0x001571F4
		public unsafe Action<InputAction.CallbackContext> OnSecondarySwitchHoldEndHandle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 87732, RefRangeEnd = 87742, XrefRangeStart = 87732, XrefRangeEnd = 87742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnSecondarySwitchHoldEndHandle_Private_get_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127296, XrefRangeEnd = 127297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnSecondarySwitchHoldEndHandle_Public_set_Void_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x00159038 File Offset: 0x00157238
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x00159078 File Offset: 0x00157278
		public unsafe Action<InputAction.CallbackContext> OnTertiarySwitchHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_OnTertiarySwitchHandle_Private_get_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127297, XrefRangeEnd = 127298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_set_OnTertiarySwitchHandle_Public_set_Void_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x001590BC File Offset: 0x001572BC
		public unsafe bool IsTrayOpened
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127298, XrefRangeEnd = 127302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_IsTrayOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x001590F8 File Offset: 0x001572F8
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x00159134 File Offset: 0x00157334
		public unsafe bool ShouldReopenThrowDeliverPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_get_ShouldReopenThrowDeliverPanel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_set_ShouldReopenThrowDeliverPanel_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00159174 File Offset: 0x00157374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127302, XrefRangeEnd = 127401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x001591B0 File Offset: 0x001573B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127401, XrefRangeEnd = 127404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x001591EC File Offset: 0x001573EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127419, RefRangeEnd = 127420, XrefRangeStart = 127404, XrefRangeEnd = 127419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKickButtonAvailability(Action onSubmitCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onSubmitCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_SetKickButtonAvailability_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00159230 File Offset: 0x00157430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127420, XrefRangeEnd = 127442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenThrowDeliverPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenThrowDeliverPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00159264 File Offset: 0x00157464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127442, XrefRangeEnd = 127456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFastForwardSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x001592A0 File Offset: 0x001574A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127458, RefRangeEnd = 127459, XrefRangeStart = 127456, XrefRangeEnd = 127458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDailyPanelParameterless()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenDailyPanelParameterless_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x001592D4 File Offset: 0x001574D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127459, XrefRangeEnd = 127468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDailyPannel(Action onPannelCloseCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenDailyPannel_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00159318 File Offset: 0x00157518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127499, RefRangeEnd = 127500, XrefRangeStart = 127468, XrefRangeEnd = 127499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCookingSelectionPannel(CookController cookController, float setIngredientFieldAlpha, float setRecipeFieldAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setIngredientFieldAlpha;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setRecipeFieldAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenCookingSelectionPannel_Public_Void_CookController_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00159378 File Offset: 0x00157578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127505, RefRangeEnd = 127506, XrefRangeStart = 127500, XrefRangeEnd = 127505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenQTEPanelManual(float qteMultiplier, Action<float> onPanelClose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qteMultiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPanelClose);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelManual_Public_Void_Single_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x001593C8 File Offset: 0x001575C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127506, XrefRangeEnd = 127533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEmptyDeskPannel(CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenEmptyDeskPannel_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0015940C File Offset: 0x0015760C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127563, RefRangeEnd = 127564, XrefRangeStart = 127533, XrefRangeEnd = 127563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStoragePannel(Sellable.SellableType sellableType, float setFoodAlpha, float setBevAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sellableType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setFoodAlpha;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setBevAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenStoragePannel_Public_Void_SellableType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00159468 File Offset: 0x00157668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127590, RefRangeEnd = 127591, XrefRangeStart = 127564, XrefRangeEnd = 127590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenBinPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenBinPannel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0015949C File Offset: 0x0015769C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127627, RefRangeEnd = 127629, XrefRangeStart = 127591, XrefRangeEnd = 127627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenServePanel(bool isThrowDeliverMode, GuestsManager.OrderBase order, Action onOrderEvaluate, Action<int> onRecoverPatient, bool isGuestManualControlled, Action<Sprite> onFoodDelieverStatusUpdated, Action<Sprite> onBevDelieverStatusUpdated, GuestGroupController currentGuestController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isThrowDeliverMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(order);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOrderEvaluate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRecoverPatient);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isGuestManualControlled;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFoodDelieverStatusUpdated);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBevDelieverStatusUpdated);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentGuestController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenServePanel_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00159558 File Offset: 0x00157758
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 127648, RefRangeEnd = 127653, XrefRangeStart = 127629, XrefRangeEnd = 127648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneTrayPannel OpenTrayPanel(WorkSceneTrayPannel.PannelOpenContext OpenContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(OpenContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenTrayPanel_Public_WorkSceneTrayPannel_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr3) : null;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x001595B0 File Offset: 0x001577B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 127674, RefRangeEnd = 127686, XrefRangeStart = 127653, XrefRangeEnd = 127674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTrayPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_CloseTrayPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x001595E4 File Offset: 0x001577E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127686, XrefRangeEnd = 127690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCurrentPanelLayerChanged(IEnumerable<UIPanelBaseImpl> currentLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentLayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00159634 File Offset: 0x00157834
		[CallerCount(0)]
		public new unsafe void TryExecuteHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0015967C File Offset: 0x0015787C
		[CallerCount(0)]
		public new unsafe void TryReleaseHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x001596C4 File Offset: 0x001578C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127690, XrefRangeEnd = 127692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryExecuteHoldKickButton(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_TryExecuteHoldKickButton_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0015970C File Offset: 0x0015790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127692, XrefRangeEnd = 127693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseHoldKickButton(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_TryReleaseHoldKickButton_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00159754 File Offset: 0x00157954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127693, XrefRangeEnd = 127699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelWillOpen<T>(T panelParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_Void_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x001597D8 File Offset: 0x001579D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127699, XrefRangeEnd = 127702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00159814 File Offset: 0x00157A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127702, XrefRangeEnd = 127708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OpenQTEPanelForCook(float qteMultiplier, CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qteMultiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelForCook_Private_UniTaskVoid_Single_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00159870 File Offset: 0x00157A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127717, RefRangeEnd = 127719, XrefRangeStart = 127708, XrefRangeEnd = 127717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<float> OpenQTEPanelInternalAsync(float qteMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref qteMultiplier;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenQTEPanelInternalAsync_Private_UniTask_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<float>(pointer);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x001598B4 File Offset: 0x00157AB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 127731, RefRangeEnd = 127738, XrefRangeStart = 127719, XrefRangeEnd = 127731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTrayPanelVisualOnly(AdpUIPanelManager.RequestedInputMode requestedInputMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedInputMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr_OpenTrayPanelVisualOnly_Public_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x001598F4 File Offset: 0x00157AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127738, XrefRangeEnd = 127740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00159930 File Offset: 0x00157B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127740, XrefRangeEnd = 127762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0015996C File Offset: 0x00157B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127762, XrefRangeEnd = 127773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneSustainedPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x001599A8 File Offset: 0x00157BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127773, XrefRangeEnd = 127782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__49_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x001599DC File Offset: 0x00157BDC
		[CallerCount(0)]
		public unsafe void _OnPannelPostInitialize_b__49_1(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00159A24 File Offset: 0x00157C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127782, XrefRangeEnd = 127784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__49_2(bool isopen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isopen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__49_2_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0001E0DF File Offset: 0x0001C2DF
		public WorkSceneSustainedPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x00159A64 File Offset: 0x00157C64
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
		public unsafe UIButtonSimple DailyBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_DailyBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_DailyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x00159A94 File Offset: 0x00157C94
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x0001E107 File Offset: 0x0001C307
		public unsafe UIButtonHold KickBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06003650 RID: 13904 RVA: 0x00159AC4 File Offset: 0x00157CC4
		// (set) Token: 0x06003651 RID: 13905 RVA: 0x0001E126 File Offset: 0x0001C326
		public unsafe CanvasGroup KickBtnGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x00159AF4 File Offset: 0x00157CF4
		// (set) Token: 0x06003653 RID: 13907 RVA: 0x0001E145 File Offset: 0x0001C345
		public unsafe bool _KickBtnHold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__KickBtnHold_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__KickBtnHold_k__BackingField)) = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x00159B1C File Offset: 0x00157D1C
		// (set) Token: 0x06003655 RID: 13909 RVA: 0x0001E160 File Offset: 0x0001C360
		public unsafe WorkSceneTrayPannel WorkSceneTrayPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneTrayPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneTrayPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x00159B4C File Offset: 0x00157D4C
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x0001E17F File Offset: 0x0001C37F
		public unsafe WorkSceneDailyDisplayerPannel WorkSceneDailyDisplayerPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneDailyDisplayerPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneDailyDisplayerPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneDailyDisplayerPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x00159B7C File Offset: 0x00157D7C
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x0001E19E File Offset: 0x0001C39E
		public unsafe WorkSceneCookingSelectionPannel WorkSceneCookingSelectionPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneCookingSelectionPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneCookingSelectionPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x00159BAC File Offset: 0x00157DAC
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x0001E1BD File Offset: 0x0001C3BD
		public unsafe WorkSceneEmptyDeskPannel WorkSceneEmptyDeskPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneEmptyDeskPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneEmptyDeskPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneEmptyDeskPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x00159BDC File Offset: 0x00157DDC
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x0001E1DC File Offset: 0x0001C3DC
		public unsafe WorkSceneBinPannel WorkSceneBinPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneBinPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneBinPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneBinPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x00159C0C File Offset: 0x00157E0C
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x0001E1FB File Offset: 0x0001C3FB
		public unsafe WorkSceneServePannel WorkSceneServePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneServePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneServePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x00159C3C File Offset: 0x00157E3C
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x0001E21A File Offset: 0x0001C41A
		public unsafe QTEPannel WorkSceneQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x00159C6C File Offset: 0x00157E6C
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x0001E239 File Offset: 0x0001C439
		public unsafe WorkSceneLegacyQTEPannel WorkSceneLegacyQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneLegacyQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneLegacyQTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneLegacyQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x00159C9C File Offset: 0x00157E9C
		// (set) Token: 0x06003665 RID: 13925 RVA: 0x0001E258 File Offset: 0x0001C458
		public unsafe WorkSceneStoragePannel WorkSceneStoragePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneStoragePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneStoragePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x00159CCC File Offset: 0x00157ECC
		// (set) Token: 0x06003667 RID: 13927 RVA: 0x0001E277 File Offset: 0x0001C477
		public unsafe WorkSceneThrowDeliverPanel WorkSceneThrowDeliverPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneThrowDeliverPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneThrowDeliverPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_WorkSceneThrowDeliverPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x00159CFC File Offset: 0x00157EFC
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x0001E296 File Offset: 0x0001C496
		public unsafe Image m_GotoDailyDisplayerBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_GotoDailyDisplayerBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_GotoDailyDisplayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x00159D2C File Offset: 0x00157F2C
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x0001E2B5 File Offset: 0x0001C4B5
		public unsafe RectTransform m_BufferRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_BufferRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_BufferRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x00159D5C File Offset: 0x00157F5C
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x0001E2D4 File Offset: 0x0001C4D4
		public unsafe UnityEngine.Object m_KickBtnTweenKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_KickBtnTweenKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_KickBtnTweenKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x00159D8C File Offset: 0x00157F8C
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x0001E2F3 File Offset: 0x0001C4F3
		public unsafe Il2CppReferenceArray<CanvasGroup> KickBtnGroupArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroupArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_KickBtnGroupArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x00159DBC File Offset: 0x00157FBC
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x0001E312 File Offset: 0x0001C512
		public unsafe bool m_IfKickBtnActived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_IfKickBtnActived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_IfKickBtnActived)) = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x00159DE4 File Offset: 0x00157FE4
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x0001E32D File Offset: 0x0001C52D
		public unsafe WorkSceneTrayPannel m_WorkSceneTrayPannelInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_WorkSceneTrayPannelInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_WorkSceneTrayPannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x00159E14 File Offset: 0x00158014
		// (set) Token: 0x06003675 RID: 13941 RVA: 0x0001E34C File Offset: 0x0001C54C
		public unsafe Action<InputAction.CallbackContext> _OnSecondarySwitchHoldStartHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldStartHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldStartHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x00159E44 File Offset: 0x00158044
		// (set) Token: 0x06003677 RID: 13943 RVA: 0x0001E36B File Offset: 0x0001C56B
		public unsafe Action<InputAction.CallbackContext> _OnSecondarySwitchHoldEndHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldEndHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnSecondarySwitchHoldEndHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x00159E74 File Offset: 0x00158074
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x0001E38A File Offset: 0x0001C58A
		public unsafe Action<InputAction.CallbackContext> _OnTertiarySwitchHandle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnTertiarySwitchHandle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__OnTertiarySwitchHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x00159EA4 File Offset: 0x001580A4
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x0001E3A9 File Offset: 0x0001C5A9
		public unsafe bool _ShouldReopenThrowDeliverPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__ShouldReopenThrowDeliverPanel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr__ShouldReopenThrowDeliverPanel_k__BackingField)) = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x00159ECC File Offset: 0x001580CC
		// (set) Token: 0x0600367D RID: 13949 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public unsafe string m_LastCloseTrayStackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_LastCloseTrayStackTrace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.NativeFieldInfoPtr_m_LastCloseTrayStackTrace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeFieldInfoPtr_DailyBtn;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeFieldInfoPtr_KickBtn;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeFieldInfoPtr_KickBtnGroup;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeFieldInfoPtr__KickBtnHold_k__BackingField;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneTrayPannel;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneDailyDisplayerPannel;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneCookingSelectionPannel;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneEmptyDeskPannel;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneBinPannel;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneServePannel;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneQTEPannel;

		// Token: 0x0400249A RID: 9370
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneLegacyQTEPannel;

		// Token: 0x0400249B RID: 9371
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneStoragePannel;

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeFieldInfoPtr_WorkSceneThrowDeliverPanel;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoDailyDisplayerBlocker;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferRectTransform;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeFieldInfoPtr_m_KickBtnTweenKey;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeFieldInfoPtr_KickBtnGroupArray;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeFieldInfoPtr_m_IfKickBtnActived;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkSceneTrayPannelInstance;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeFieldInfoPtr__OnSecondarySwitchHoldStartHandle_k__BackingField;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeFieldInfoPtr__OnSecondarySwitchHoldEndHandle_k__BackingField;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeFieldInfoPtr__OnTertiarySwitchHandle_k__BackingField;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeFieldInfoPtr__ShouldReopenThrowDeliverPanel_k__BackingField;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeFieldInfoPtr_m_LastCloseTrayStackTrace;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr_get_KickBtnHold_Public_get_Boolean_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_set_KickBtnHold_Private_set_Void_Boolean_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferRectTransform_Public_get_RectTransform_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionMap_Public_Virtual_get_String_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionName_Public_Virtual_get_String_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSecondarySwitchHoldStartHandle_Private_get_Action_1_CallbackContext_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSecondarySwitchHoldStartHandle_Public_set_Void_Action_1_CallbackContext_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSecondarySwitchHoldEndHandle_Private_get_Action_1_CallbackContext_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSecondarySwitchHoldEndHandle_Public_set_Void_Action_1_CallbackContext_0;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeMethodInfoPtr_get_OnTertiarySwitchHandle_Private_get_Action_1_CallbackContext_0;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeMethodInfoPtr_set_OnTertiarySwitchHandle_Public_set_Void_Action_1_CallbackContext_0;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTrayOpened_Public_get_Boolean_0;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldReopenThrowDeliverPanel_Public_get_Boolean_0;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldReopenThrowDeliverPanel_Public_set_Void_Boolean_0;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeMethodInfoPtr_SetKickButtonAvailability_Public_Void_Action_0;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeMethodInfoPtr_OpenThrowDeliverPanel_Public_Void_0;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeMethodInfoPtr_OnFastForwardSubmit_Public_Virtual_Void_0;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeMethodInfoPtr_OpenDailyPanelParameterless_Public_Void_0;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeMethodInfoPtr_OpenDailyPannel_Public_Void_Action_0;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_OpenCookingSelectionPannel_Public_Void_CookController_Single_Single_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_OpenQTEPanelManual_Public_Void_Single_Action_1_Single_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_OpenEmptyDeskPannel_Public_Void_CookController_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePannel_Public_Void_SellableType_Single_Single_0;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr_OpenBinPannel_Public_Void_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_OpenServePanel_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_OpenTrayPanel_Public_WorkSceneTrayPannel_PannelOpenContext_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_CloseTrayPanel_Public_Void_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentPanelLayerChanged_Protected_Virtual_Void_IEnumerable_1_UIPanelBaseImpl_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteHoldKickButton_Private_Void_CallbackContext_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseHoldKickButton_Private_Void_CallbackContext_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClosed_Protected_Virtual_Void_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_OpenQTEPanelForCook_Private_UniTaskVoid_Single_CookController_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_OpenQTEPanelInternalAsync_Private_UniTask_1_Single_Single_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_OpenTrayPanelVisualOnly_Public_Void_RequestedInputMode_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__49_0_Private_Void_0;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__49_1_Private_Void_CallbackContext_0;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__49_2_Private_Void_Boolean_0;

		// Token: 0x02000918 RID: 2328
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B797 RID: 46999 RVA: 0x002E800C File Offset: 0x002E620C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_onSubmitCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr, "onSubmitCallback");
				WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr, 100673622);
				WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr, 100673623);
			}

			// Token: 0x0600B798 RID: 47000 RVA: 0x002E8088 File Offset: 0x002E6288
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B799 RID: 47001 RVA: 0x002E80C4 File Offset: 0x002E62C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127145, XrefRangeEnd = 127160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B79A RID: 47002 RVA: 0x00063048 File Offset: 0x00061248
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C2E RID: 15406
			// (get) Token: 0x0600B79B RID: 47003 RVA: 0x002E80F8 File Offset: 0x002E62F8
			// (set) Token: 0x0600B79C RID: 47004 RVA: 0x00063051 File Offset: 0x00061251
			public unsafe Action onSubmitCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_onSubmitCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_onSubmitCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C2F RID: 15407
			// (get) Token: 0x0600B79D RID: 47005 RVA: 0x002E8128 File Offset: 0x002E6328
			// (set) Token: 0x0600B79E RID: 47006 RVA: 0x00063070 File Offset: 0x00061270
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076D0 RID: 30416
			private static readonly IntPtr NativeFieldInfoPtr_onSubmitCallback;

			// Token: 0x040076D1 RID: 30417
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076D2 RID: 30418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076D3 RID: 30419
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000919 RID: 2329
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B79F RID: 47007 RVA: 0x002E8158 File Offset: 0x002E6358
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_onPanelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr, "onPanelCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr, 100673624);
				WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__OpenThrowDeliverPanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr, 100673625);
			}

			// Token: 0x0600B7A0 RID: 47008 RVA: 0x002E81D4 File Offset: 0x002E63D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7A1 RID: 47009 RVA: 0x002E8210 File Offset: 0x002E6410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127160, XrefRangeEnd = 127162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenThrowDeliverPanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__OpenThrowDeliverPanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7A2 RID: 47010 RVA: 0x0006308F File Offset: 0x0006128F
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C30 RID: 15408
			// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002E8244 File Offset: 0x002E6444
			// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x00063098 File Offset: 0x00061298
			public unsafe Action onPanelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_onPanelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_onPanelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C31 RID: 15409
			// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x002E8274 File Offset: 0x002E6474
			// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x000630B7 File Offset: 0x000612B7
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076D4 RID: 30420
			private static readonly IntPtr NativeFieldInfoPtr_onPanelCloseCallback;

			// Token: 0x040076D5 RID: 30421
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076D6 RID: 30422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076D7 RID: 30423
			private static readonly IntPtr NativeMethodInfoPtr__OpenThrowDeliverPanel_b__0_Internal_Void_0;
		}

		// Token: 0x0200091A RID: 2330
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7A7 RID: 47015 RVA: 0x002E82A4 File Offset: 0x002E64A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr, "onCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_cookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr, "cookController");
				WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr, 100673626);
				WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__OpenCookingSelectionPannel_b__0_Internal_Void_WorkSceneCookingSelectionPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr, 100673627);
			}

			// Token: 0x0600B7A8 RID: 47016 RVA: 0x002E8334 File Offset: 0x002E6534
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7A9 RID: 47017 RVA: 0x002E8370 File Offset: 0x002E6570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127162, XrefRangeEnd = 127166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenCookingSelectionPannel_b__0(WorkSceneCookingSelectionPannel instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeMethodInfoPtr__OpenCookingSelectionPannel_b__0_Internal_Void_WorkSceneCookingSelectionPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7AA RID: 47018 RVA: 0x000630D6 File Offset: 0x000612D6
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C32 RID: 15410
			// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x002E83B4 File Offset: 0x002E65B4
			// (set) Token: 0x0600B7AC RID: 47020 RVA: 0x000630DF File Offset: 0x000612DF
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C33 RID: 15411
			// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x002E83E4 File Offset: 0x002E65E4
			// (set) Token: 0x0600B7AE RID: 47022 RVA: 0x000630FE File Offset: 0x000612FE
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C34 RID: 15412
			// (get) Token: 0x0600B7AF RID: 47023 RVA: 0x002E8414 File Offset: 0x002E6614
			// (set) Token: 0x0600B7B0 RID: 47024 RVA: 0x0006311D File Offset: 0x0006131D
			public unsafe CookController cookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_cookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass56_0.NativeFieldInfoPtr_cookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076D8 RID: 30424
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;

			// Token: 0x040076D9 RID: 30425
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076DA RID: 30426
			private static readonly IntPtr NativeFieldInfoPtr_cookController;

			// Token: 0x040076DB RID: 30427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076DC RID: 30428
			private static readonly IntPtr NativeMethodInfoPtr__OpenCookingSelectionPannel_b__0_Internal_Void_WorkSceneCookingSelectionPannel_0;
		}

		// Token: 0x0200091B RID: 2331
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7B1 RID: 47025 RVA: 0x002E8444 File Offset: 0x002E6644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr, "onCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr, 100673628);
				WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OpenEmptyDeskPannel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr, 100673629);
			}

			// Token: 0x0600B7B2 RID: 47026 RVA: 0x002E84C0 File Offset: 0x002E66C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7B3 RID: 47027 RVA: 0x002E84FC File Offset: 0x002E66FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127166, XrefRangeEnd = 127167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenEmptyDeskPannel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OpenEmptyDeskPannel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7B4 RID: 47028 RVA: 0x0006313C File Offset: 0x0006133C
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C35 RID: 15413
			// (get) Token: 0x0600B7B5 RID: 47029 RVA: 0x002E8530 File Offset: 0x002E6730
			// (set) Token: 0x0600B7B6 RID: 47030 RVA: 0x00063145 File Offset: 0x00061345
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C36 RID: 15414
			// (get) Token: 0x0600B7B7 RID: 47031 RVA: 0x002E8560 File Offset: 0x002E6760
			// (set) Token: 0x0600B7B8 RID: 47032 RVA: 0x00063164 File Offset: 0x00061364
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076DD RID: 30429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076DE RID: 30430
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;

			// Token: 0x040076DF RID: 30431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076E0 RID: 30432
			private static readonly IntPtr NativeMethodInfoPtr__OpenEmptyDeskPannel_b__0_Internal_Void_0;
		}

		// Token: 0x0200091C RID: 2332
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7B9 RID: 47033 RVA: 0x002E8590 File Offset: 0x002E6790
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr, "onCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr, 100673630);
				WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeMethodInfoPtr__OpenStoragePannel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr, 100673631);
			}

			// Token: 0x0600B7BA RID: 47034 RVA: 0x002E860C File Offset: 0x002E680C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7BB RID: 47035 RVA: 0x002E8648 File Offset: 0x002E6848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenStoragePannel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeMethodInfoPtr__OpenStoragePannel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7BC RID: 47036 RVA: 0x00063183 File Offset: 0x00061383
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C37 RID: 15415
			// (get) Token: 0x0600B7BD RID: 47037 RVA: 0x002E867C File Offset: 0x002E687C
			// (set) Token: 0x0600B7BE RID: 47038 RVA: 0x0006318C File Offset: 0x0006138C
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C38 RID: 15416
			// (get) Token: 0x0600B7BF RID: 47039 RVA: 0x002E86AC File Offset: 0x002E68AC
			// (set) Token: 0x0600B7C0 RID: 47040 RVA: 0x000631AB File Offset: 0x000613AB
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass59_0.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076E1 RID: 30433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076E2 RID: 30434
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;

			// Token: 0x040076E3 RID: 30435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076E4 RID: 30436
			private static readonly IntPtr NativeMethodInfoPtr__OpenStoragePannel_b__0_Internal_Void_0;
		}

		// Token: 0x0200091D RID: 2333
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7C1 RID: 47041 RVA: 0x002E86DC File Offset: 0x002E68DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr, "onCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr, 100673632);
				WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeMethodInfoPtr__OpenBinPannel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr, 100673633);
			}

			// Token: 0x0600B7C2 RID: 47042 RVA: 0x002E8758 File Offset: 0x002E6958
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7C3 RID: 47043 RVA: 0x002E8794 File Offset: 0x002E6994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenBinPannel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeMethodInfoPtr__OpenBinPannel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7C4 RID: 47044 RVA: 0x000631CA File Offset: 0x000613CA
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C39 RID: 15417
			// (get) Token: 0x0600B7C5 RID: 47045 RVA: 0x002E87C8 File Offset: 0x002E69C8
			// (set) Token: 0x0600B7C6 RID: 47046 RVA: 0x000631D3 File Offset: 0x000613D3
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C3A RID: 15418
			// (get) Token: 0x0600B7C7 RID: 47047 RVA: 0x002E87F8 File Offset: 0x002E69F8
			// (set) Token: 0x0600B7C8 RID: 47048 RVA: 0x000631F2 File Offset: 0x000613F2
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass60_0.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076E5 RID: 30437
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076E6 RID: 30438
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;

			// Token: 0x040076E7 RID: 30439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076E8 RID: 30440
			private static readonly IntPtr NativeMethodInfoPtr__OpenBinPannel_b__0_Internal_Void_0;
		}

		// Token: 0x0200091E RID: 2334
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7C9 RID: 47049 RVA: 0x002E8828 File Offset: 0x002E6A28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_onCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr, "onCloseCallback");
				WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr, 100673634);
				WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__OpenServePanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr, 100673635);
			}

			// Token: 0x0600B7CA RID: 47050 RVA: 0x002E88A4 File Offset: 0x002E6AA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7CB RID: 47051 RVA: 0x002E88E0 File Offset: 0x002E6AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127167, XrefRangeEnd = 127200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenServePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__OpenServePanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7CC RID: 47052 RVA: 0x00063211 File Offset: 0x00061411
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C3B RID: 15419
			// (get) Token: 0x0600B7CD RID: 47053 RVA: 0x002E8914 File Offset: 0x002E6B14
			// (set) Token: 0x0600B7CE RID: 47054 RVA: 0x0006321A File Offset: 0x0006141A
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C3C RID: 15420
			// (get) Token: 0x0600B7CF RID: 47055 RVA: 0x002E8944 File Offset: 0x002E6B44
			// (set) Token: 0x0600B7D0 RID: 47056 RVA: 0x00063239 File Offset: 0x00061439
			public unsafe Action onCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_onCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_onCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076E9 RID: 30441
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076EA RID: 30442
			private static readonly IntPtr NativeFieldInfoPtr_onCloseCallback;

			// Token: 0x040076EB RID: 30443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076EC RID: 30444
			private static readonly IntPtr NativeMethodInfoPtr__OpenServePanel_b__0_Internal_Void_0;
		}

		// Token: 0x0200091F RID: 2335
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<OpenQTEPanelForCook>d__72")]
		public sealed class _OpenQTEPanelForCook_d__72 : ValueType
		{
			// Token: 0x0600B7D1 RID: 47057 RVA: 0x002E8974 File Offset: 0x002E6B74
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenQTEPanelForCook_d__72()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<OpenQTEPanelForCook>d__72");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr);
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "<>1__state");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "<>t__builder");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_qteMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "qteMultiplier");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_cookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "cookController");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, "<>u__1");
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, 100673636);
				WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr, 100673637);
			}

			// Token: 0x0600B7D2 RID: 47058 RVA: 0x002E8A40 File Offset: 0x002E6C40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 127262, RefRangeEnd = 127264, XrefRangeStart = 127200, XrefRangeEnd = 127262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7D3 RID: 47059 RVA: 0x002E8A78 File Offset: 0x002E6C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7D4 RID: 47060 RVA: 0x00063258 File Offset: 0x00061458
			public _OpenQTEPanelForCook_d__72(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B7D5 RID: 47061 RVA: 0x00063261 File Offset: 0x00061461
			public _OpenQTEPanelForCook_d__72() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72>.NativeClassPtr))
			{
			}

			// Token: 0x17003C3D RID: 15421
			// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x002E8AC0 File Offset: 0x002E6CC0
			// (set) Token: 0x0600B7D7 RID: 47063 RVA: 0x00063273 File Offset: 0x00061473
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C3E RID: 15422
			// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x002E8AE8 File Offset: 0x002E6CE8
			// (set) Token: 0x0600B7D9 RID: 47065 RVA: 0x0006328E File Offset: 0x0006148E
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C3F RID: 15423
			// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x002E8B18 File Offset: 0x002E6D18
			// (set) Token: 0x0600B7DB RID: 47067 RVA: 0x000632BC File Offset: 0x000614BC
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C40 RID: 15424
			// (get) Token: 0x0600B7DC RID: 47068 RVA: 0x002E8B48 File Offset: 0x002E6D48
			// (set) Token: 0x0600B7DD RID: 47069 RVA: 0x000632DB File Offset: 0x000614DB
			public unsafe float qteMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_qteMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_qteMultiplier)) = value;
				}
			}

			// Token: 0x17003C41 RID: 15425
			// (get) Token: 0x0600B7DE RID: 47070 RVA: 0x002E8B70 File Offset: 0x002E6D70
			// (set) Token: 0x0600B7DF RID: 47071 RVA: 0x000632F6 File Offset: 0x000614F6
			public unsafe CookController cookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_cookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr_cookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C42 RID: 15426
			// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x002E8BA0 File Offset: 0x002E6DA0
			// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x00063315 File Offset: 0x00061515
			public UniTask<float>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___u__1);
					return new UniTask<float>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<float>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelForCook_d__72.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<float>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040076ED RID: 30445
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040076EE RID: 30446
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040076EF RID: 30447
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076F0 RID: 30448
			private static readonly IntPtr NativeFieldInfoPtr_qteMultiplier;

			// Token: 0x040076F1 RID: 30449
			private static readonly IntPtr NativeFieldInfoPtr_cookController;

			// Token: 0x040076F2 RID: 30450
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040076F3 RID: 30451
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076F4 RID: 30452
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000920 RID: 2336
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B7E2 RID: 47074 RVA: 0x002E8BD0 File Offset: 0x002E6DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr);
				WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_musicManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr, "musicManager");
				WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr, 100673638);
				WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__OpenQTEPanelInternalAsync_b__0_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr, 100673639);
			}

			// Token: 0x0600B7E3 RID: 47075 RVA: 0x002E8C38 File Offset: 0x002E6E38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7E4 RID: 47076 RVA: 0x002E8C74 File Offset: 0x002E6E74
			[CallerCount(0)]
			public unsafe long _OpenQTEPanelInternalAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__OpenQTEPanelInternalAsync_b__0_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B7E5 RID: 47077 RVA: 0x00063343 File Offset: 0x00061543
			public __c__DisplayClass73_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C43 RID: 15427
			// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x002E8CB0 File Offset: 0x002E6EB0
			// (set) Token: 0x0600B7E7 RID: 47079 RVA: 0x0006334C File Offset: 0x0006154C
			public unsafe MusicManager musicManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_musicManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_musicManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040076F5 RID: 30453
			private static readonly IntPtr NativeFieldInfoPtr_musicManager;

			// Token: 0x040076F6 RID: 30454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040076F7 RID: 30455
			private static readonly IntPtr NativeMethodInfoPtr__OpenQTEPanelInternalAsync_b__0_Internal_Int64_0;
		}

		// Token: 0x02000921 RID: 2337
		[ObfuscatedName("NightScene.UI.WorkSceneSustainedPannel+<OpenQTEPanelInternalAsync>d__73")]
		public sealed class _OpenQTEPanelInternalAsync_d__73 : ValueType
		{
			// Token: 0x0600B7E8 RID: 47080 RVA: 0x002E8CE0 File Offset: 0x002E6EE0
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenQTEPanelInternalAsync_d__73()
			{
				Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr, "<OpenQTEPanelInternalAsync>d__73");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr);
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "<>1__state");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "<>t__builder");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "<>4__this");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr_qteMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "qteMultiplier");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr__panel_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "<panel>5__2");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, "<>u__1");
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, 100673640);
				WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr, 100673641);
			}

			// Token: 0x0600B7E9 RID: 47081 RVA: 0x002E8DAC File Offset: 0x002E6FAC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 127288, RefRangeEnd = 127290, XrefRangeStart = 127264, XrefRangeEnd = 127288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7EA RID: 47082 RVA: 0x002E8DE4 File Offset: 0x002E6FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127290, XrefRangeEnd = 127293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B7EB RID: 47083 RVA: 0x0006336B File Offset: 0x0006156B
			public _OpenQTEPanelInternalAsync_d__73(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B7EC RID: 47084 RVA: 0x00063374 File Offset: 0x00061574
			public _OpenQTEPanelInternalAsync_d__73() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73>.NativeClassPtr))
			{
			}

			// Token: 0x17003C44 RID: 15428
			// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002E8E2C File Offset: 0x002E702C
			// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x00063386 File Offset: 0x00061586
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003C45 RID: 15429
			// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002E8E54 File Offset: 0x002E7054
			// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x000633A1 File Offset: 0x000615A1
			public AsyncUniTaskMethodBuilder<float> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<float>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<float>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003C46 RID: 15430
			// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002E8E84 File Offset: 0x002E7084
			// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x000633CF File Offset: 0x000615CF
			public unsafe WorkSceneSustainedPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C47 RID: 15431
			// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x002E8EB4 File Offset: 0x002E70B4
			// (set) Token: 0x0600B7F4 RID: 47092 RVA: 0x000633EE File Offset: 0x000615EE
			public unsafe float qteMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr_qteMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr_qteMultiplier)) = value;
				}
			}

			// Token: 0x17003C48 RID: 15432
			// (get) Token: 0x0600B7F5 RID: 47093 RVA: 0x002E8EDC File Offset: 0x002E70DC
			// (set) Token: 0x0600B7F6 RID: 47094 RVA: 0x00063409 File Offset: 0x00061609
			public unsafe QTEPannelBase _panel_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr__panel_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannelBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr__panel_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C49 RID: 15433
			// (get) Token: 0x0600B7F7 RID: 47095 RVA: 0x002E8F0C File Offset: 0x002E710C
			// (set) Token: 0x0600B7F8 RID: 47096 RVA: 0x00063428 File Offset: 0x00061628
			public UniTask<QTEPannelBase>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___u__1);
					return new UniTask<QTEPannelBase>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<QTEPannelBase>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneSustainedPannel._OpenQTEPanelInternalAsync_d__73.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<QTEPannelBase>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040076F8 RID: 30456
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040076F9 RID: 30457
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040076FA RID: 30458
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040076FB RID: 30459
			private static readonly IntPtr NativeFieldInfoPtr_qteMultiplier;

			// Token: 0x040076FC RID: 30460
			private static readonly IntPtr NativeFieldInfoPtr__panel_5__2;

			// Token: 0x040076FD RID: 30461
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040076FE RID: 30462
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040076FF RID: 30463
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000922 RID: 2338
		private sealed class MethodInfoStoreGeneric_OnPanelWillOpen_Protected_Virtual_Void_T_0<T>
		{
			// Token: 0x04007700 RID: 30464
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WorkSceneSustainedPannel.NativeMethodInfoPtr_OnPanelWillOpen_Protected_Virtual_Void_T_0, Il2CppClassPointerStore<WorkSceneSustainedPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
