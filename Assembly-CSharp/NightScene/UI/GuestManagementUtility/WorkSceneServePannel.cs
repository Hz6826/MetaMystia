using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020001BF RID: 447
	public class WorkSceneServePannel : UIPanelExtern
	{
		// Token: 0x06003782 RID: 14210 RVA: 0x0015CE8C File Offset: 0x0015B08C
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneServePannel()
		{
			Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.GuestManagementUtility", "WorkSceneServePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr);
			WorkSceneServePannel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "m_Scheduler");
			WorkSceneServePannel.NativeFieldInfoPtr_describerPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "describerPannel");
			WorkSceneServePannel.NativeFieldInfoPtr_describerSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "describerSubPannel");
			WorkSceneServePannel.NativeFieldInfoPtr_normalRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "normalRequest");
			WorkSceneServePannel.NativeFieldInfoPtr_specialRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "specialRequest");
			WorkSceneServePannel.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "onClose");
			WorkSceneServePannel.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "onOpen");
			WorkSceneServePannel.NativeFieldInfoPtr_servBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "servBev");
			WorkSceneServePannel.NativeFieldInfoPtr_servBevOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "servBevOutline");
			WorkSceneServePannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "describer");
			WorkSceneServePannel.NativeFieldInfoPtr_servFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "servFood");
			WorkSceneServePannel.NativeFieldInfoPtr_servFoodOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "servFoodOutline");
			WorkSceneServePannel.NativeFieldInfoPtr_guestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "guestName");
			WorkSceneServePannel.NativeFieldInfoPtr_onServedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "onServedColor");
			WorkSceneServePannel.NativeFieldInfoPtr_deskCodeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "deskCodeText");
			WorkSceneServePannel.NativeFieldInfoPtr_m_CurrentTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "m_CurrentTray");
			WorkSceneServePannel.NativeFieldInfoPtr_m_DescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "m_DescriberCanvasGroup");
			WorkSceneServePannel.NativeFieldInfoPtr_willServeBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "willServeBeverage");
			WorkSceneServePannel.NativeFieldInfoPtr_willServeFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "willServeFood");
			WorkSceneServePannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			WorkSceneServePannel.NativeMethodInfoPtr_get_isThrowDeliverMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673765);
			WorkSceneServePannel.NativeMethodInfoPtr_get_operatingOrder_Private_get_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673766);
			WorkSceneServePannel.NativeMethodInfoPtr_get_onOrderEvaluate_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673767);
			WorkSceneServePannel.NativeMethodInfoPtr_get_onRecoverPatient_Private_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673768);
			WorkSceneServePannel.NativeMethodInfoPtr_get_onFoodDelieverStatusUpdated_Private_get_Action_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673769);
			WorkSceneServePannel.NativeMethodInfoPtr_get_onBevDelieverStatusUpdated_Private_get_Action_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673770);
			WorkSceneServePannel.NativeMethodInfoPtr_get_isGuestManualControlled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673771);
			WorkSceneServePannel.NativeMethodInfoPtr_get_currentGuestController_Private_get_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673772);
			WorkSceneServePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673773);
			WorkSceneServePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673774);
			WorkSceneServePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673775);
			WorkSceneServePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673776);
			WorkSceneServePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673777);
			WorkSceneServePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673778);
			WorkSceneServePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673779);
			WorkSceneServePannel.NativeMethodInfoPtr_OnThrowDelivering_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673780);
			WorkSceneServePannel.NativeMethodInfoPtr_InvokeOrderUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673781);
			WorkSceneServePannel.NativeMethodInfoPtr_FinishOrderStatus_Private_Void_Boolean_OrderBase_Sellable_Sellable_Action_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673782);
			WorkSceneServePannel.NativeMethodInfoPtr_SetServedVisualOnUI_Private_Void_UIButtonSimple_Image_Sellable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673783);
			WorkSceneServePannel.NativeMethodInfoPtr_ResetServedVisualOnUI_Private_Void_UIButtonSimple_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673784);
			WorkSceneServePannel.NativeMethodInfoPtr_Send_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673785);
			WorkSceneServePannel.NativeMethodInfoPtr_Cancel_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673786);
			WorkSceneServePannel.NativeMethodInfoPtr_UpdateFoodVisualOnDesk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673787);
			WorkSceneServePannel.NativeMethodInfoPtr_UpdateBevVisualOnDesk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673788);
			WorkSceneServePannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673789);
			WorkSceneServePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673790);
			WorkSceneServePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673791);
			WorkSceneServePannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673792);
			WorkSceneServePannel.NativeMethodInfoPtr_Method_Private_Void_byref_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, 100673793);
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x0015D290 File Offset: 0x0015B490
		public unsafe bool isThrowDeliverMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129355, RefRangeEnd = 129357, XrefRangeStart = 129352, XrefRangeEnd = 129355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_isThrowDeliverMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x0015D2CC File Offset: 0x0015B4CC
		public unsafe GuestsManager.OrderBase operatingOrder
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 129360, RefRangeEnd = 129386, XrefRangeStart = 129357, XrefRangeEnd = 129360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_operatingOrder_Private_get_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0015D30C File Offset: 0x0015B50C
		public unsafe Action onOrderEvaluate
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129389, RefRangeEnd = 129391, XrefRangeStart = 129386, XrefRangeEnd = 129389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_onOrderEvaluate_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x0015D34C File Offset: 0x0015B54C
		public unsafe Action<int> onRecoverPatient
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129394, RefRangeEnd = 129396, XrefRangeStart = 129391, XrefRangeEnd = 129394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_onRecoverPatient_Private_get_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0015D38C File Offset: 0x0015B58C
		public unsafe Action<Sprite> onFoodDelieverStatusUpdated
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 129399, RefRangeEnd = 129403, XrefRangeStart = 129396, XrefRangeEnd = 129399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_onFoodDelieverStatusUpdated_Private_get_Action_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x0015D3CC File Offset: 0x0015B5CC
		public unsafe Action<Sprite> onBevDelieverStatusUpdated
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129406, RefRangeEnd = 129408, XrefRangeStart = 129403, XrefRangeEnd = 129406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_onBevDelieverStatusUpdated_Private_get_Action_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0015D40C File Offset: 0x0015B60C
		public unsafe bool isGuestManualControlled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129411, RefRangeEnd = 129413, XrefRangeStart = 129408, XrefRangeEnd = 129411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_isGuestManualControlled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x0015D448 File Offset: 0x0015B648
		public unsafe GuestGroupController currentGuestController
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129416, RefRangeEnd = 129418, XrefRangeStart = 129413, XrefRangeEnd = 129416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_currentGuestController_Private_get_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr3) : null;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x0015D488 File Offset: 0x0015B688
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x0015D4C0 File Offset: 0x0015B6C0
		public unsafe Nullable<WorkSceneServePannel.PannelOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<WorkSceneServePannel.PannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129418, XrefRangeEnd = 129419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0015D508 File Offset: 0x0015B708
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0015D544 File Offset: 0x0015B744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129419, XrefRangeEnd = 129426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0015D580 File Offset: 0x0015B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129426, XrefRangeEnd = 129657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x0015D5BC File Offset: 0x0015B7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129657, XrefRangeEnd = 129660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x0015D5F8 File Offset: 0x0015B7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129660, XrefRangeEnd = 129688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x0015D634 File Offset: 0x0015B834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129688, XrefRangeEnd = 129693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnThrowDelivering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_OnThrowDelivering_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0015D674 File Offset: 0x0015B874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129735, RefRangeEnd = 129736, XrefRangeStart = 129693, XrefRangeEnd = 129735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOrderUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_InvokeOrderUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0015D6A8 File Offset: 0x0015B8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129736, XrefRangeEnd = 129739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishOrderStatus(bool isGuestManualControlled, GuestsManager.OrderBase operatingOrder, Sellable willServeFood, Sellable willServeBev, Action onOrderEvaluate, Action<int> onRecoverPatient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isGuestManualControlled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operatingOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willServeFood);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(willServeBev);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOrderEvaluate);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRecoverPatient);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_FinishOrderStatus_Private_Void_Boolean_OrderBase_Sellable_Sellable_Action_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0015D744 File Offset: 0x0015B944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129771, RefRangeEnd = 129774, XrefRangeStart = 129739, XrefRangeEnd = 129771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetServedVisualOnUI(UIButtonSimple served, Image servedOutline, Sellable toServe, bool canCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(served);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(servedOutline);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toServe);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_SetServedVisualOnUI_Private_Void_UIButtonSimple_Image_Sellable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0015D7B8 File Offset: 0x0015B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129774, XrefRangeEnd = 129780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetServedVisualOnUI(UIButtonSimple served, Image servedOutline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(served);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(servedOutline);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_ResetServedVisualOnUI_Private_Void_UIButtonSimple_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x0015D80C File Offset: 0x0015BA0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129834, RefRangeEnd = 129835, XrefRangeStart = 129780, XrefRangeEnd = 129834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send(Sellable toSend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toSend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_Send_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x0015D850 File Offset: 0x0015BA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129902, RefRangeEnd = 129903, XrefRangeStart = 129835, XrefRangeEnd = 129902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(Sellable toCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toCancel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_Cancel_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0015D894 File Offset: 0x0015BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129903, XrefRangeEnd = 129904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFoodVisualOnDesk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_UpdateFoodVisualOnDesk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0015D8C8 File Offset: 0x0015BAC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129905, RefRangeEnd = 129906, XrefRangeStart = 129904, XrefRangeEnd = 129905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBevVisualOnDesk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_UpdateBevVisualOnDesk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0015D8FC File Offset: 0x0015BAFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129918, RefRangeEnd = 129921, XrefRangeStart = 129906, XrefRangeEnd = 129918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0015D930 File Offset: 0x0015BB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129921, XrefRangeEnd = 129940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneServePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0015D96C File Offset: 0x0015BB6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneServePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x0015D9A8 File Offset: 0x0015BBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129940, XrefRangeEnd = 129941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0015D9DC File Offset: 0x0015BBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129946, RefRangeEnd = 129948, XrefRangeStart = 129941, XrefRangeEnd = 129946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_byref_Sellable_0(ref Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.NativeMethodInfoPtr_Method_Private_Void_byref_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sellable = ((intPtr4 == 0) ? null : new Sellable(intPtr4));
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0001EEEF File Offset: 0x0001D0EF
		public WorkSceneServePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x0015DA34 File Offset: 0x0015BC34
		// (set) Token: 0x060037A2 RID: 14242 RVA: 0x0001EEF8 File Offset: 0x0001D0F8
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x060037A3 RID: 14243 RVA: 0x0015DA64 File Offset: 0x0015BC64
		// (set) Token: 0x060037A4 RID: 14244 RVA: 0x0001EF17 File Offset: 0x0001D117
		public unsafe CanvasGroup describerPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describerPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describerPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x060037A5 RID: 14245 RVA: 0x0015DA94 File Offset: 0x0015BC94
		// (set) Token: 0x060037A6 RID: 14246 RVA: 0x0001EF36 File Offset: 0x0001D136
		public unsafe CanvasGroup describerSubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describerSubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describerSubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x0015DAC4 File Offset: 0x0015BCC4
		// (set) Token: 0x060037A8 RID: 14248 RVA: 0x0001EF55 File Offset: 0x0001D155
		public unsafe GameObject normalRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_normalRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_normalRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x0015DAF4 File Offset: 0x0015BCF4
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x0001EF74 File Offset: 0x0001D174
		public unsafe GameObject specialRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_specialRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_specialRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0015DB24 File Offset: 0x0015BD24
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x0001EF93 File Offset: 0x0001D193
		public unsafe AudioClip onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x0015DB54 File Offset: 0x0015BD54
		// (set) Token: 0x060037AE RID: 14254 RVA: 0x0001EFB2 File Offset: 0x0001D1B2
		public unsafe AudioClip onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x0015DB84 File Offset: 0x0015BD84
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0001EFD1 File Offset: 0x0001D1D1
		public unsafe UIButtonSimple servBev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servBev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servBev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x0015DBB4 File Offset: 0x0015BDB4
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		public unsafe Image servBevOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servBevOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servBevOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x0015DBE4 File Offset: 0x0015BDE4
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x0001F00F File Offset: 0x0001D20F
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x0015DC14 File Offset: 0x0015BE14
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x0001F02E File Offset: 0x0001D22E
		public unsafe UIButtonSimple servFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x0015DC44 File Offset: 0x0015BE44
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x0001F04D File Offset: 0x0001D24D
		public unsafe Image servFoodOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servFoodOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_servFoodOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x0015DC74 File Offset: 0x0015BE74
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x0001F06C File Offset: 0x0001D26C
		public unsafe TextMeshProUGUI guestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_guestName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_guestName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x0015DCA4 File Offset: 0x0015BEA4
		// (set) Token: 0x060037BC RID: 14268 RVA: 0x0001F08B File Offset: 0x0001D28B
		public unsafe Color onServedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onServedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_onServedColor)) = value;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x0015DCCC File Offset: 0x0015BECC
		// (set) Token: 0x060037BE RID: 14270 RVA: 0x0001F0A6 File Offset: 0x0001D2A6
		public unsafe TextMeshProUGUI deskCodeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_deskCodeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_deskCodeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0015DCFC File Offset: 0x0015BEFC
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x0001F0C5 File Offset: 0x0001D2C5
		public unsafe WorkSceneTrayPannel m_CurrentTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_CurrentTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_CurrentTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0015DD2C File Offset: 0x0015BF2C
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0001F0E4 File Offset: 0x0001D2E4
		public unsafe CanvasGroup m_DescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_DescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_m_DescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x0015DD5C File Offset: 0x0015BF5C
		// (set) Token: 0x060037C4 RID: 14276 RVA: 0x0001F103 File Offset: 0x0001D303
		public unsafe Sellable willServeBeverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_willServeBeverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_willServeBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x0015DD8C File Offset: 0x0015BF8C
		// (set) Token: 0x060037C6 RID: 14278 RVA: 0x0001F122 File Offset: 0x0001D322
		public unsafe Sellable willServeFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_willServeFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr_willServeFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x060037C7 RID: 14279 RVA: 0x0015DDBC File Offset: 0x0015BFBC
		// (set) Token: 0x060037C8 RID: 14280 RVA: 0x0001F141 File Offset: 0x0001D341
		public Nullable<WorkSceneServePannel.PannelOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<WorkSceneServePannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WorkSceneServePannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WorkSceneServePannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeFieldInfoPtr_describerPannel;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeFieldInfoPtr_describerSubPannel;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeFieldInfoPtr_normalRequest;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeFieldInfoPtr_specialRequest;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeFieldInfoPtr_servBev;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeFieldInfoPtr_servBevOutline;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeFieldInfoPtr_servFood;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeFieldInfoPtr_servFoodOutline;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeFieldInfoPtr_guestName;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeFieldInfoPtr_onServedColor;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeFieldInfoPtr_deskCodeText;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTray;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberCanvasGroup;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeFieldInfoPtr_willServeBeverage;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeFieldInfoPtr_willServeFood;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_get_isThrowDeliverMode_Private_get_Boolean_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingOrder_Private_get_OrderBase_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_get_onOrderEvaluate_Private_get_Action_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_get_onRecoverPatient_Private_get_Action_1_Int32_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_get_onFoodDelieverStatusUpdated_Private_get_Action_1_Sprite_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_get_onBevDelieverStatusUpdated_Private_get_Action_1_Sprite_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_get_isGuestManualControlled_Private_get_Boolean_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_get_currentGuestController_Private_get_GuestGroupController_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_OnThrowDelivering_Private_IEnumerator_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOrderUpdate_Private_Void_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_FinishOrderStatus_Private_Void_Boolean_OrderBase_Sellable_Sellable_Action_Action_1_Int32_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_SetServedVisualOnUI_Private_Void_UIButtonSimple_Image_Sellable_Boolean_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_ResetServedVisualOnUI_Private_Void_UIButtonSimple_Image_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_Send_Private_Void_Sellable_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Private_Void_Sellable_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFoodVisualOnDesk_Private_Void_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBevVisualOnDesk_Private_Void_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPannel_Private_Void_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_byref_Sellable_0;

		// Token: 0x02000931 RID: 2353
		public sealed class PannelOpenContext : ValueType
		{
			// Token: 0x0600B8BF RID: 47295 RVA: 0x002EB1C0 File Offset: 0x002E93C0
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr);
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isThrowDeliverMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "isThrowDeliverMode");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_operatingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "operatingOrder");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onOrderEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "onOrderEvaluate");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onRecoverPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "onRecoverPatient");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isGuestManualControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "isGuestManualControlled");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onFoodDelieverStatusUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "onFoodDelieverStatusUpdated");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onBevDelieverStatusUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "onBevDelieverStatusUpdated");
				WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_currentGuestController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, "currentGuestController");
				WorkSceneServePannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr, 100673794);
			}

			// Token: 0x0600B8C0 RID: 47296 RVA: 0x002EB2A0 File Offset: 0x002E94A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129045, XrefRangeEnd = 129051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(bool isThrowDeliverMode, GuestsManager.OrderBase operatingOrder, Action onOrderEvaluate, Action<int> onRecoverPatient, bool isGuestManualControlled, Action<Sprite> onFoodDelieverStatusUpdated, Action<Sprite> onBevDelieverStatusUpdated, GuestGroupController currentGuestController) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isThrowDeliverMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operatingOrder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOrderEvaluate);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRecoverPatient);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isGuestManualControlled;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFoodDelieverStatusUpdated);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBevDelieverStatusUpdated);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentGuestController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8C1 RID: 47297 RVA: 0x00063B68 File Offset: 0x00061D68
			public PannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B8C2 RID: 47298 RVA: 0x00063B71 File Offset: 0x00061D71
			public PannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.PannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003C86 RID: 15494
			// (get) Token: 0x0600B8C3 RID: 47299 RVA: 0x002EB36C File Offset: 0x002E956C
			// (set) Token: 0x0600B8C4 RID: 47300 RVA: 0x00063B83 File Offset: 0x00061D83
			public unsafe bool isThrowDeliverMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isThrowDeliverMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isThrowDeliverMode)) = value;
				}
			}

			// Token: 0x17003C87 RID: 15495
			// (get) Token: 0x0600B8C5 RID: 47301 RVA: 0x002EB394 File Offset: 0x002E9594
			// (set) Token: 0x0600B8C6 RID: 47302 RVA: 0x00063B9E File Offset: 0x00061D9E
			public unsafe GuestsManager.OrderBase operatingOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_operatingOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_operatingOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C88 RID: 15496
			// (get) Token: 0x0600B8C7 RID: 47303 RVA: 0x002EB3C4 File Offset: 0x002E95C4
			// (set) Token: 0x0600B8C8 RID: 47304 RVA: 0x00063BBD File Offset: 0x00061DBD
			public unsafe Action onOrderEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onOrderEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onOrderEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C89 RID: 15497
			// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x002EB3F4 File Offset: 0x002E95F4
			// (set) Token: 0x0600B8CA RID: 47306 RVA: 0x00063BDC File Offset: 0x00061DDC
			public unsafe Action<int> onRecoverPatient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onRecoverPatient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onRecoverPatient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C8A RID: 15498
			// (get) Token: 0x0600B8CB RID: 47307 RVA: 0x002EB424 File Offset: 0x002E9624
			// (set) Token: 0x0600B8CC RID: 47308 RVA: 0x00063BFB File Offset: 0x00061DFB
			public unsafe bool isGuestManualControlled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isGuestManualControlled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_isGuestManualControlled)) = value;
				}
			}

			// Token: 0x17003C8B RID: 15499
			// (get) Token: 0x0600B8CD RID: 47309 RVA: 0x002EB44C File Offset: 0x002E964C
			// (set) Token: 0x0600B8CE RID: 47310 RVA: 0x00063C16 File Offset: 0x00061E16
			public unsafe Action<Sprite> onFoodDelieverStatusUpdated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onFoodDelieverStatusUpdated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onFoodDelieverStatusUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C8C RID: 15500
			// (get) Token: 0x0600B8CF RID: 47311 RVA: 0x002EB47C File Offset: 0x002E967C
			// (set) Token: 0x0600B8D0 RID: 47312 RVA: 0x00063C35 File Offset: 0x00061E35
			public unsafe Action<Sprite> onBevDelieverStatusUpdated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onBevDelieverStatusUpdated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_onBevDelieverStatusUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C8D RID: 15501
			// (get) Token: 0x0600B8D1 RID: 47313 RVA: 0x002EB4AC File Offset: 0x002E96AC
			// (set) Token: 0x0600B8D2 RID: 47314 RVA: 0x00063C54 File Offset: 0x00061E54
			public unsafe GuestGroupController currentGuestController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_currentGuestController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.PannelOpenContext.NativeFieldInfoPtr_currentGuestController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400776D RID: 30573
			private static readonly IntPtr NativeFieldInfoPtr_isThrowDeliverMode;

			// Token: 0x0400776E RID: 30574
			private static readonly IntPtr NativeFieldInfoPtr_operatingOrder;

			// Token: 0x0400776F RID: 30575
			private static readonly IntPtr NativeFieldInfoPtr_onOrderEvaluate;

			// Token: 0x04007770 RID: 30576
			private static readonly IntPtr NativeFieldInfoPtr_onRecoverPatient;

			// Token: 0x04007771 RID: 30577
			private static readonly IntPtr NativeFieldInfoPtr_isGuestManualControlled;

			// Token: 0x04007772 RID: 30578
			private static readonly IntPtr NativeFieldInfoPtr_onFoodDelieverStatusUpdated;

			// Token: 0x04007773 RID: 30579
			private static readonly IntPtr NativeFieldInfoPtr_onBevDelieverStatusUpdated;

			// Token: 0x04007774 RID: 30580
			private static readonly IntPtr NativeFieldInfoPtr_currentGuestController;

			// Token: 0x04007775 RID: 30581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_OrderBase_Action_Action_1_Int32_Boolean_Action_1_Sprite_Action_1_Sprite_GuestGroupController_0;
		}

		// Token: 0x02000932 RID: 2354
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B8D3 RID: 47315 RVA: 0x002EB4DC File Offset: 0x002E96DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestFoodButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "requestFoodButton");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_isNotOverridePic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "isNotOverridePic");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestBevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "requestBevButton");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_izakayaTrayInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "izakayaTrayInstance");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "<>9__19");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, "<>9__22");
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673795);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673796);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673797);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673798);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673799);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673800);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673801);
				WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr, 100673802);
			}

			// Token: 0x0600B8D4 RID: 47316 RVA: 0x002EB634 File Offset: 0x002E9834
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8D5 RID: 47317 RVA: 0x002EB670 File Offset: 0x002E9870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129051, XrefRangeEnd = 129067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Sellable_PDM_0(Sellable sellable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8D6 RID: 47318 RVA: 0x002EB6B4 File Offset: 0x002E98B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129067, XrefRangeEnd = 129069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8D7 RID: 47319 RVA: 0x002EB6E8 File Offset: 0x002E98E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129069, XrefRangeEnd = 129071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Sellable_PDM_1(Sellable sellable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8D8 RID: 47320 RVA: 0x002EB72C File Offset: 0x002E992C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129071, XrefRangeEnd = 129073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__19()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8D9 RID: 47321 RVA: 0x002EB760 File Offset: 0x002E9960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8DA RID: 47322 RVA: 0x002EB794 File Offset: 0x002E9994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129073, XrefRangeEnd = 129076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B8DB RID: 47323 RVA: 0x002EB7E0 File Offset: 0x002E99E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129076, XrefRangeEnd = 129079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B8DC RID: 47324 RVA: 0x00063C73 File Offset: 0x00061E73
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C8E RID: 15502
			// (get) Token: 0x0600B8DD RID: 47325 RVA: 0x002EB82C File Offset: 0x002E9A2C
			// (set) Token: 0x0600B8DE RID: 47326 RVA: 0x00063C7C File Offset: 0x00061E7C
			public unsafe WorkSceneServePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C8F RID: 15503
			// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x002EB85C File Offset: 0x002E9A5C
			// (set) Token: 0x0600B8E0 RID: 47328 RVA: 0x00063C9B File Offset: 0x00061E9B
			public unsafe UIButtonSimple requestFoodButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestFoodButton);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestFoodButton), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C90 RID: 15504
			// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x002EB88C File Offset: 0x002E9A8C
			// (set) Token: 0x0600B8E2 RID: 47330 RVA: 0x00063CBA File Offset: 0x00061EBA
			public unsafe bool isNotOverridePic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_isNotOverridePic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_isNotOverridePic)) = value;
				}
			}

			// Token: 0x17003C91 RID: 15505
			// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x002EB8B4 File Offset: 0x002E9AB4
			// (set) Token: 0x0600B8E4 RID: 47332 RVA: 0x00063CD5 File Offset: 0x00061ED5
			public unsafe UIButtonSimple requestBevButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestBevButton);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_requestBevButton), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C92 RID: 15506
			// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x002EB8E4 File Offset: 0x002E9AE4
			// (set) Token: 0x0600B8E6 RID: 47334 RVA: 0x00063CF4 File Offset: 0x00061EF4
			public unsafe IzakayaTray izakayaTrayInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_izakayaTrayInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_izakayaTrayInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C93 RID: 15507
			// (get) Token: 0x0600B8E7 RID: 47335 RVA: 0x002EB914 File Offset: 0x002E9B14
			// (set) Token: 0x0600B8E8 RID: 47336 RVA: 0x00063D13 File Offset: 0x00061F13
			public unsafe Action __9__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__19);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__19), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C94 RID: 15508
			// (get) Token: 0x0600B8E9 RID: 47337 RVA: 0x002EB944 File Offset: 0x002E9B44
			// (set) Token: 0x0600B8EA RID: 47338 RVA: 0x00063D32 File Offset: 0x00061F32
			public unsafe Action __9__22
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__22);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_0.NativeFieldInfoPtr___9__22), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007776 RID: 30582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007777 RID: 30583
			private static readonly IntPtr NativeFieldInfoPtr_requestFoodButton;

			// Token: 0x04007778 RID: 30584
			private static readonly IntPtr NativeFieldInfoPtr_isNotOverridePic;

			// Token: 0x04007779 RID: 30585
			private static readonly IntPtr NativeFieldInfoPtr_requestBevButton;

			// Token: 0x0400777A RID: 30586
			private static readonly IntPtr NativeFieldInfoPtr_izakayaTrayInstance;

			// Token: 0x0400777B RID: 30587
			private static readonly IntPtr NativeFieldInfoPtr___9__19;

			// Token: 0x0400777C RID: 30588
			private static readonly IntPtr NativeFieldInfoPtr___9__22;

			// Token: 0x0400777D RID: 30589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400777E RID: 30590
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0;

			// Token: 0x0400777F RID: 30591
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04007780 RID: 30592
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_1;

			// Token: 0x04007781 RID: 30593
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0;

			// Token: 0x04007782 RID: 30594
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0;

			// Token: 0x04007783 RID: 30595
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_Int32_0;

			// Token: 0x04007784 RID: 30596
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000933 RID: 2355
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass41_1")]
		public sealed class __c__DisplayClass41_1 : Il2CppSystem.Object
		{
			// Token: 0x0600B8EB RID: 47339 RVA: 0x002EB974 File Offset: 0x002E9B74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_1()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass41_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_sellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr, "sellable");
				WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr, "CS$<>8__locals1");
				WorkSceneServePannel.__c__DisplayClass41_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr, 100673803);
				WorkSceneServePannel.__c__DisplayClass41_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr, 100673804);
			}

			// Token: 0x0600B8EC RID: 47340 RVA: 0x002EB9F0 File Offset: 0x002E9BF0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8ED RID: 47341 RVA: 0x002EBA2C File Offset: 0x002E9C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129079, XrefRangeEnd = 129081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8EE RID: 47342 RVA: 0x00063D51 File Offset: 0x00061F51
			public __c__DisplayClass41_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C95 RID: 15509
			// (get) Token: 0x0600B8EF RID: 47343 RVA: 0x002EBA60 File Offset: 0x002E9C60
			// (set) Token: 0x0600B8F0 RID: 47344 RVA: 0x00063D5A File Offset: 0x00061F5A
			public unsafe Sellable sellable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_sellable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_sellable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C96 RID: 15510
			// (get) Token: 0x0600B8F1 RID: 47345 RVA: 0x002EBA90 File Offset: 0x002E9C90
			// (set) Token: 0x0600B8F2 RID: 47346 RVA: 0x00063D79 File Offset: 0x00061F79
			public unsafe WorkSceneServePannel.__c__DisplayClass41_0 field_Public___c__DisplayClass41_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_1.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007785 RID: 30597
			private static readonly IntPtr NativeFieldInfoPtr_sellable;

			// Token: 0x04007786 RID: 30598
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0;

			// Token: 0x04007787 RID: 30599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007788 RID: 30600
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_0;
		}

		// Token: 0x02000934 RID: 2356
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass41_2")]
		public sealed class __c__DisplayClass41_2 : Il2CppSystem.Object
		{
			// Token: 0x0600B8F3 RID: 47347 RVA: 0x002EBAC0 File Offset: 0x002E9CC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_2()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass41_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_normalOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "normalOrder");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "requestFood");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "requestBev");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "pixel");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "colorScheme");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "CS$<>8__locals2");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "<>9__21");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "<>9__20");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "<>9__24");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, "<>9__23");
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673805);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673806);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__20_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673807);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__21_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673808);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673809);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673810);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__23_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673811);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__24_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673812);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673813);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673814);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673815);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673816);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673817);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673818);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673819);
				WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr, 100673820);
			}

			// Token: 0x0600B8F4 RID: 47348 RVA: 0x002EBCF4 File Offset: 0x002E9EF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass41_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8F5 RID: 47349 RVA: 0x002EBD30 File Offset: 0x002E9F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129081, XrefRangeEnd = 129105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8F6 RID: 47350 RVA: 0x002EBD74 File Offset: 0x002E9F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129105, XrefRangeEnd = 129116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__20_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8F7 RID: 47351 RVA: 0x002EBDA8 File Offset: 0x002E9FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129116, XrefRangeEnd = 129119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__21_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8F8 RID: 47352 RVA: 0x002EBDDC File Offset: 0x002E9FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129119, XrefRangeEnd = 129125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8F9 RID: 47353 RVA: 0x002EBE20 File Offset: 0x002EA020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129125, XrefRangeEnd = 129149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FA RID: 47354 RVA: 0x002EBE64 File Offset: 0x002EA064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129149, XrefRangeEnd = 129160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__23()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__23_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FB RID: 47355 RVA: 0x002EBE98 File Offset: 0x002EA098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129160, XrefRangeEnd = 129163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__24_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FC RID: 47356 RVA: 0x002EBECC File Offset: 0x002EA0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129163, XrefRangeEnd = 129169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FD RID: 47357 RVA: 0x002EBF10 File Offset: 0x002EA110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__12(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FE RID: 47358 RVA: 0x002EBF54 File Offset: 0x002EA154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__13(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B8FF RID: 47359 RVA: 0x002EBF98 File Offset: 0x002EA198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129169, XrefRangeEnd = 129172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__14(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B900 RID: 47360 RVA: 0x002EBFDC File Offset: 0x002EA1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129172, XrefRangeEnd = 129175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__15(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B901 RID: 47361 RVA: 0x002EC020 File Offset: 0x002EA220
			[CallerCount(0)]
			public unsafe void _OnPanelOpen_b__16(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B902 RID: 47362 RVA: 0x002EC064 File Offset: 0x002EA264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129175, XrefRangeEnd = 129176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__17(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B903 RID: 47363 RVA: 0x002EC0A8 File Offset: 0x002EA2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129176, XrefRangeEnd = 129177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__18(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass41_2.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B904 RID: 47364 RVA: 0x00063D98 File Offset: 0x00061F98
			public __c__DisplayClass41_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C97 RID: 15511
			// (get) Token: 0x0600B905 RID: 47365 RVA: 0x002EC0EC File Offset: 0x002EA2EC
			// (set) Token: 0x0600B906 RID: 47366 RVA: 0x00063DA1 File Offset: 0x00061FA1
			public unsafe GuestsManager.NormalOrder normalOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_normalOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.NormalOrder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_normalOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C98 RID: 15512
			// (get) Token: 0x0600B907 RID: 47367 RVA: 0x002EC11C File Offset: 0x002EA31C
			// (set) Token: 0x0600B908 RID: 47368 RVA: 0x00063DC0 File Offset: 0x00061FC0
			public unsafe string requestFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestFood);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestFood), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C99 RID: 15513
			// (get) Token: 0x0600B909 RID: 47369 RVA: 0x002EC144 File Offset: 0x002EA344
			// (set) Token: 0x0600B90A RID: 47370 RVA: 0x00063DDF File Offset: 0x00061FDF
			public unsafe string requestBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestBev);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_requestBev), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C9A RID: 15514
			// (get) Token: 0x0600B90B RID: 47371 RVA: 0x002EC16C File Offset: 0x002EA36C
			// (set) Token: 0x0600B90C RID: 47372 RVA: 0x00063DFE File Offset: 0x00061FFE
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C9B RID: 15515
			// (get) Token: 0x0600B90D RID: 47373 RVA: 0x002EC19C File Offset: 0x002EA39C
			// (set) Token: 0x0600B90E RID: 47374 RVA: 0x00063E1D File Offset: 0x0006201D
			public unsafe Color colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_colorScheme);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_colorScheme)) = value;
				}
			}

			// Token: 0x17003C9C RID: 15516
			// (get) Token: 0x0600B90F RID: 47375 RVA: 0x002EC1C4 File Offset: 0x002EA3C4
			// (set) Token: 0x0600B910 RID: 47376 RVA: 0x00063E38 File Offset: 0x00062038
			public unsafe WorkSceneServePannel.__c__DisplayClass41_0 field_Public___c__DisplayClass41_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C9D RID: 15517
			// (get) Token: 0x0600B911 RID: 47377 RVA: 0x002EC1F4 File Offset: 0x002EA3F4
			// (set) Token: 0x0600B912 RID: 47378 RVA: 0x00063E57 File Offset: 0x00062057
			public unsafe Action __9__21
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__21);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__21), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C9E RID: 15518
			// (get) Token: 0x0600B913 RID: 47379 RVA: 0x002EC224 File Offset: 0x002EA424
			// (set) Token: 0x0600B914 RID: 47380 RVA: 0x00063E76 File Offset: 0x00062076
			public unsafe Action __9__20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__20);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__20), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C9F RID: 15519
			// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002EC254 File Offset: 0x002EA454
			// (set) Token: 0x0600B916 RID: 47382 RVA: 0x00063E95 File Offset: 0x00062095
			public unsafe Action __9__24
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__24);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__24), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA0 RID: 15520
			// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002EC284 File Offset: 0x002EA484
			// (set) Token: 0x0600B918 RID: 47384 RVA: 0x00063EB4 File Offset: 0x000620B4
			public unsafe Action __9__23
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__23);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass41_2.NativeFieldInfoPtr___9__23), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007789 RID: 30601
			private static readonly IntPtr NativeFieldInfoPtr_normalOrder;

			// Token: 0x0400778A RID: 30602
			private static readonly IntPtr NativeFieldInfoPtr_requestFood;

			// Token: 0x0400778B RID: 30603
			private static readonly IntPtr NativeFieldInfoPtr_requestBev;

			// Token: 0x0400778C RID: 30604
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x0400778D RID: 30605
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x0400778E RID: 30606
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass41_0_0;

			// Token: 0x0400778F RID: 30607
			private static readonly IntPtr NativeFieldInfoPtr___9__21;

			// Token: 0x04007790 RID: 30608
			private static readonly IntPtr NativeFieldInfoPtr___9__20;

			// Token: 0x04007791 RID: 30609
			private static readonly IntPtr NativeFieldInfoPtr___9__24;

			// Token: 0x04007792 RID: 30610
			private static readonly IntPtr NativeFieldInfoPtr___9__23;

			// Token: 0x04007793 RID: 30611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007794 RID: 30612
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Void_Image_0;

			// Token: 0x04007795 RID: 30613
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__20_Internal_Void_0;

			// Token: 0x04007796 RID: 30614
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__21_Internal_Void_0;

			// Token: 0x04007797 RID: 30615
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_Image_0;

			// Token: 0x04007798 RID: 30616
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Image_0;

			// Token: 0x04007799 RID: 30617
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__23_Internal_Void_0;

			// Token: 0x0400779A RID: 30618
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__24_Internal_Void_0;

			// Token: 0x0400779B RID: 30619
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Image_0;

			// Token: 0x0400779C RID: 30620
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400779D RID: 30621
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400779E RID: 30622
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__14_Internal_Void_Image_0;

			// Token: 0x0400779F RID: 30623
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_Image_0;

			// Token: 0x040077A0 RID: 30624
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Void_Image_0;

			// Token: 0x040077A1 RID: 30625
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_Image_0;

			// Token: 0x040077A2 RID: 30626
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_Image_0;
		}

		// Token: 0x02000935 RID: 2357
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B919 RID: 47385 RVA: 0x002EC2B4 File Offset: 0x002EA4B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr);
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__41_3");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__41_5");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__49_0");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__49_1");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__49_2");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__49_3");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__50_0");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__50_2");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__50_3");
				WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, "<>9__50_5");
				WorkSceneServePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673822);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_3_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673823);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_5_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673824);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673825);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673826);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_2_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673827);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673828);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673829);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673830);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_3_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673831);
				WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr, 100673832);
			}

			// Token: 0x0600B91A RID: 47386 RVA: 0x002EC498 File Offset: 0x002EA698
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B91B RID: 47387 RVA: 0x002EC4D4 File Offset: 0x002EA6D4
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__41_3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_3_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B91C RID: 47388 RVA: 0x002EC524 File Offset: 0x002EA724
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__41_5(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_5_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B91D RID: 47389 RVA: 0x002EC574 File Offset: 0x002EA774
			[CallerCount(0)]
			public unsafe bool _Send_b__49_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B91E RID: 47390 RVA: 0x002EC5C4 File Offset: 0x002EA7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129177, XrefRangeEnd = 129183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Send_b__49_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B91F RID: 47391 RVA: 0x002EC610 File Offset: 0x002EA810
			[CallerCount(0)]
			public unsafe bool _Send_b__49_2(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_2_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B920 RID: 47392 RVA: 0x002EC660 File Offset: 0x002EA860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129183, XrefRangeEnd = 129189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Send_b__49_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Send_b__49_3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B921 RID: 47393 RVA: 0x002EC6AC File Offset: 0x002EA8AC
			[CallerCount(0)]
			public unsafe bool _Cancel_b__50_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B922 RID: 47394 RVA: 0x002EC6FC File Offset: 0x002EA8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129189, XrefRangeEnd = 129195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cancel_b__50_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B923 RID: 47395 RVA: 0x002EC748 File Offset: 0x002EA948
			[CallerCount(0)]
			public unsafe bool _Cancel_b__50_3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_3_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B924 RID: 47396 RVA: 0x002EC798 File Offset: 0x002EA998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129195, XrefRangeEnd = 129201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cancel_b__50_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c.NativeMethodInfoPtr__Cancel_b__50_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B925 RID: 47397 RVA: 0x00063ED3 File Offset: 0x000620D3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CA1 RID: 15521
			// (get) Token: 0x0600B926 RID: 47398 RVA: 0x002EC7E4 File Offset: 0x002EA9E4
			// (set) Token: 0x0600B927 RID: 47399 RVA: 0x00063EDC File Offset: 0x000620DC
			public unsafe static WorkSceneServePannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA2 RID: 15522
			// (get) Token: 0x0600B928 RID: 47400 RVA: 0x002EC80C File Offset: 0x002EAA0C
			// (set) Token: 0x0600B929 RID: 47401 RVA: 0x00063EEE File Offset: 0x000620EE
			public unsafe static Func<Sellable, bool> __9__41_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA3 RID: 15523
			// (get) Token: 0x0600B92A RID: 47402 RVA: 0x002EC834 File Offset: 0x002EAA34
			// (set) Token: 0x0600B92B RID: 47403 RVA: 0x00063F00 File Offset: 0x00062100
			public unsafe static Func<Sellable, bool> __9__41_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__41_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA4 RID: 15524
			// (get) Token: 0x0600B92C RID: 47404 RVA: 0x002EC85C File Offset: 0x002EAA5C
			// (set) Token: 0x0600B92D RID: 47405 RVA: 0x00063F12 File Offset: 0x00062112
			public unsafe static Func<Sellable, bool> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA5 RID: 15525
			// (get) Token: 0x0600B92E RID: 47406 RVA: 0x002EC884 File Offset: 0x002EAA84
			// (set) Token: 0x0600B92F RID: 47407 RVA: 0x00063F24 File Offset: 0x00062124
			public unsafe static Predicate<int> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA6 RID: 15526
			// (get) Token: 0x0600B930 RID: 47408 RVA: 0x002EC8AC File Offset: 0x002EAAAC
			// (set) Token: 0x0600B931 RID: 47409 RVA: 0x00063F36 File Offset: 0x00062136
			public unsafe static Func<Sellable, bool> __9__49_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA7 RID: 15527
			// (get) Token: 0x0600B932 RID: 47410 RVA: 0x002EC8D4 File Offset: 0x002EAAD4
			// (set) Token: 0x0600B933 RID: 47411 RVA: 0x00063F48 File Offset: 0x00062148
			public unsafe static Predicate<int> __9__49_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__49_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA8 RID: 15528
			// (get) Token: 0x0600B934 RID: 47412 RVA: 0x002EC8FC File Offset: 0x002EAAFC
			// (set) Token: 0x0600B935 RID: 47413 RVA: 0x00063F5A File Offset: 0x0006215A
			public unsafe static Func<Sellable, bool> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CA9 RID: 15529
			// (get) Token: 0x0600B936 RID: 47414 RVA: 0x002EC924 File Offset: 0x002EAB24
			// (set) Token: 0x0600B937 RID: 47415 RVA: 0x00063F6C File Offset: 0x0006216C
			public unsafe static Predicate<int> __9__50_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CAA RID: 15530
			// (get) Token: 0x0600B938 RID: 47416 RVA: 0x002EC94C File Offset: 0x002EAB4C
			// (set) Token: 0x0600B939 RID: 47417 RVA: 0x00063F7E File Offset: 0x0006217E
			public unsafe static Func<Sellable, bool> __9__50_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CAB RID: 15531
			// (get) Token: 0x0600B93A RID: 47418 RVA: 0x002EC974 File Offset: 0x002EAB74
			// (set) Token: 0x0600B93B RID: 47419 RVA: 0x00063F90 File Offset: 0x00062190
			public unsafe static Predicate<int> __9__50_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneServePannel.__c.NativeFieldInfoPtr___9__50_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077A3 RID: 30627
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040077A4 RID: 30628
			private static readonly IntPtr NativeFieldInfoPtr___9__41_3;

			// Token: 0x040077A5 RID: 30629
			private static readonly IntPtr NativeFieldInfoPtr___9__41_5;

			// Token: 0x040077A6 RID: 30630
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x040077A7 RID: 30631
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x040077A8 RID: 30632
			private static readonly IntPtr NativeFieldInfoPtr___9__49_2;

			// Token: 0x040077A9 RID: 30633
			private static readonly IntPtr NativeFieldInfoPtr___9__49_3;

			// Token: 0x040077AA RID: 30634
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x040077AB RID: 30635
			private static readonly IntPtr NativeFieldInfoPtr___9__50_2;

			// Token: 0x040077AC RID: 30636
			private static readonly IntPtr NativeFieldInfoPtr___9__50_3;

			// Token: 0x040077AD RID: 30637
			private static readonly IntPtr NativeFieldInfoPtr___9__50_5;

			// Token: 0x040077AE RID: 30638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077AF RID: 30639
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__41_3_Internal_Boolean_Sellable_0;

			// Token: 0x040077B0 RID: 30640
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__41_5_Internal_Boolean_Sellable_0;

			// Token: 0x040077B1 RID: 30641
			private static readonly IntPtr NativeMethodInfoPtr__Send_b__49_0_Internal_Boolean_Sellable_0;

			// Token: 0x040077B2 RID: 30642
			private static readonly IntPtr NativeMethodInfoPtr__Send_b__49_1_Internal_Boolean_Int32_0;

			// Token: 0x040077B3 RID: 30643
			private static readonly IntPtr NativeMethodInfoPtr__Send_b__49_2_Internal_Boolean_Sellable_0;

			// Token: 0x040077B4 RID: 30644
			private static readonly IntPtr NativeMethodInfoPtr__Send_b__49_3_Internal_Boolean_Int32_0;

			// Token: 0x040077B5 RID: 30645
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__50_0_Internal_Boolean_Sellable_0;

			// Token: 0x040077B6 RID: 30646
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__50_2_Internal_Boolean_Int32_0;

			// Token: 0x040077B7 RID: 30647
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__50_3_Internal_Boolean_Sellable_0;

			// Token: 0x040077B8 RID: 30648
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__50_5_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000936 RID: 2358
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B93C RID: 47420 RVA: 0x002EC99C File Offset: 0x002EAB9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "currentController");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_isGuestMannual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "isGuestMannual");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_workingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "workingOrder");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "finishLaunchedFood");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "finishLaunchedBev");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentOnEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "currentOnEvaluate");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_onCurrentRecoverPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "onCurrentRecoverPatient");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentFoodStatusUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "currentFoodStatusUpdated");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentBevStatusUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "currentBevStatusUpdated");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "thisWillServeFood");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_launchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "launchTarget");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "thisWillServeBeverage");
				WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, 100673833);
				WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, 100673834);
				WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, 100673835);
				WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, 100673836);
			}

			// Token: 0x0600B93D RID: 47421 RVA: 0x002ECB1C File Offset: 0x002EAD1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B93E RID: 47422 RVA: 0x002ECB58 File Offset: 0x002EAD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129229, XrefRangeEnd = 129230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B93F RID: 47423 RVA: 0x002ECB8C File Offset: 0x002EAD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129230, XrefRangeEnd = 129235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B940 RID: 47424 RVA: 0x002ECBCC File Offset: 0x002EADCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129235, XrefRangeEnd = 129240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B941 RID: 47425 RVA: 0x00063FA2 File Offset: 0x000621A2
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CAC RID: 15532
			// (get) Token: 0x0600B942 RID: 47426 RVA: 0x002ECC0C File Offset: 0x002EAE0C
			// (set) Token: 0x0600B943 RID: 47427 RVA: 0x00063FAB File Offset: 0x000621AB
			public unsafe GuestGroupController currentController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CAD RID: 15533
			// (get) Token: 0x0600B944 RID: 47428 RVA: 0x002ECC3C File Offset: 0x002EAE3C
			// (set) Token: 0x0600B945 RID: 47429 RVA: 0x00063FCA File Offset: 0x000621CA
			public unsafe WorkSceneServePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CAE RID: 15534
			// (get) Token: 0x0600B946 RID: 47430 RVA: 0x002ECC6C File Offset: 0x002EAE6C
			// (set) Token: 0x0600B947 RID: 47431 RVA: 0x00063FE9 File Offset: 0x000621E9
			public unsafe bool isGuestMannual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_isGuestMannual);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_isGuestMannual)) = value;
				}
			}

			// Token: 0x17003CAF RID: 15535
			// (get) Token: 0x0600B948 RID: 47432 RVA: 0x002ECC94 File Offset: 0x002EAE94
			// (set) Token: 0x0600B949 RID: 47433 RVA: 0x00064004 File Offset: 0x00062204
			public unsafe GuestsManager.OrderBase workingOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_workingOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_workingOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB0 RID: 15536
			// (get) Token: 0x0600B94A RID: 47434 RVA: 0x002ECCC4 File Offset: 0x002EAEC4
			// (set) Token: 0x0600B94B RID: 47435 RVA: 0x00064023 File Offset: 0x00062223
			public unsafe Sellable finishLaunchedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB1 RID: 15537
			// (get) Token: 0x0600B94C RID: 47436 RVA: 0x002ECCF4 File Offset: 0x002EAEF4
			// (set) Token: 0x0600B94D RID: 47437 RVA: 0x00064042 File Offset: 0x00062242
			public unsafe Sellable finishLaunchedBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_finishLaunchedBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB2 RID: 15538
			// (get) Token: 0x0600B94E RID: 47438 RVA: 0x002ECD24 File Offset: 0x002EAF24
			// (set) Token: 0x0600B94F RID: 47439 RVA: 0x00064061 File Offset: 0x00062261
			public unsafe Action currentOnEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentOnEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentOnEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB3 RID: 15539
			// (get) Token: 0x0600B950 RID: 47440 RVA: 0x002ECD54 File Offset: 0x002EAF54
			// (set) Token: 0x0600B951 RID: 47441 RVA: 0x00064080 File Offset: 0x00062280
			public unsafe Action<int> onCurrentRecoverPatient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_onCurrentRecoverPatient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_onCurrentRecoverPatient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB4 RID: 15540
			// (get) Token: 0x0600B952 RID: 47442 RVA: 0x002ECD84 File Offset: 0x002EAF84
			// (set) Token: 0x0600B953 RID: 47443 RVA: 0x0006409F File Offset: 0x0006229F
			public unsafe Action<Sprite> currentFoodStatusUpdated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentFoodStatusUpdated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentFoodStatusUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB5 RID: 15541
			// (get) Token: 0x0600B954 RID: 47444 RVA: 0x002ECDB4 File Offset: 0x002EAFB4
			// (set) Token: 0x0600B955 RID: 47445 RVA: 0x000640BE File Offset: 0x000622BE
			public unsafe Action<Sprite> currentBevStatusUpdated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentBevStatusUpdated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_currentBevStatusUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB6 RID: 15542
			// (get) Token: 0x0600B956 RID: 47446 RVA: 0x002ECDE4 File Offset: 0x002EAFE4
			// (set) Token: 0x0600B957 RID: 47447 RVA: 0x000640DD File Offset: 0x000622DD
			public unsafe Sellable thisWillServeFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CB7 RID: 15543
			// (get) Token: 0x0600B958 RID: 47448 RVA: 0x002ECE14 File Offset: 0x002EB014
			// (set) Token: 0x0600B959 RID: 47449 RVA: 0x000640FC File Offset: 0x000622FC
			public unsafe Vector3 launchTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_launchTarget);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_launchTarget)) = value;
				}
			}

			// Token: 0x17003CB8 RID: 15544
			// (get) Token: 0x0600B95A RID: 47450 RVA: 0x002ECE3C File Offset: 0x002EB03C
			// (set) Token: 0x0600B95B RID: 47451 RVA: 0x00064117 File Offset: 0x00062317
			public unsafe Sellable thisWillServeBeverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeBeverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.NativeFieldInfoPtr_thisWillServeBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077B9 RID: 30649
			private static readonly IntPtr NativeFieldInfoPtr_currentController;

			// Token: 0x040077BA RID: 30650
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077BB RID: 30651
			private static readonly IntPtr NativeFieldInfoPtr_isGuestMannual;

			// Token: 0x040077BC RID: 30652
			private static readonly IntPtr NativeFieldInfoPtr_workingOrder;

			// Token: 0x040077BD RID: 30653
			private static readonly IntPtr NativeFieldInfoPtr_finishLaunchedFood;

			// Token: 0x040077BE RID: 30654
			private static readonly IntPtr NativeFieldInfoPtr_finishLaunchedBev;

			// Token: 0x040077BF RID: 30655
			private static readonly IntPtr NativeFieldInfoPtr_currentOnEvaluate;

			// Token: 0x040077C0 RID: 30656
			private static readonly IntPtr NativeFieldInfoPtr_onCurrentRecoverPatient;

			// Token: 0x040077C1 RID: 30657
			private static readonly IntPtr NativeFieldInfoPtr_currentFoodStatusUpdated;

			// Token: 0x040077C2 RID: 30658
			private static readonly IntPtr NativeFieldInfoPtr_currentBevStatusUpdated;

			// Token: 0x040077C3 RID: 30659
			private static readonly IntPtr NativeFieldInfoPtr_thisWillServeFood;

			// Token: 0x040077C4 RID: 30660
			private static readonly IntPtr NativeFieldInfoPtr_launchTarget;

			// Token: 0x040077C5 RID: 30661
			private static readonly IntPtr NativeFieldInfoPtr_thisWillServeBeverage;

			// Token: 0x040077C6 RID: 30662
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077C7 RID: 30663
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040077C8 RID: 30664
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040077C9 RID: 30665
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000FF9 RID: 4089
			[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass44_0+<<OnThrowDelivering>g__LaunchFood|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0 : Il2CppSystem.Object
			{
				// Token: 0x06011857 RID: 71767 RVA: 0x00405CC0 File Offset: 0x00403EC0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0()
				{
					Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "<<OnThrowDelivering>g__LaunchFood|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr__targetVisual_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, "<targetVisual>5__2");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673837);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673838);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673839);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673840);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673841);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr, 100673842);
				}

				// Token: 0x06011858 RID: 71768 RVA: 0x00405DB4 File Offset: 0x00403FB4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011859 RID: 71769 RVA: 0x00405DFC File Offset: 0x00403FFC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601185A RID: 71770 RVA: 0x00405E30 File Offset: 0x00404030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129201, XrefRangeEnd = 129209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005B23 RID: 23331
				// (get) Token: 0x0601185B RID: 71771 RVA: 0x00405E6C File Offset: 0x0040406C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601185C RID: 71772 RVA: 0x00405EAC File Offset: 0x004040AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129209, XrefRangeEnd = 129215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005B24 RID: 23332
				// (get) Token: 0x0601185D RID: 71773 RVA: 0x00405EE0 File Offset: 0x004040E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601185E RID: 71774 RVA: 0x00098685 File Offset: 0x00096885
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B1F RID: 23327
				// (get) Token: 0x0601185F RID: 71775 RVA: 0x00405F20 File Offset: 0x00404120
				// (set) Token: 0x06011860 RID: 71776 RVA: 0x0009868E File Offset: 0x0009688E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005B20 RID: 23328
				// (get) Token: 0x06011861 RID: 71777 RVA: 0x00405F48 File Offset: 0x00404148
				// (set) Token: 0x06011862 RID: 71778 RVA: 0x000986A9 File Offset: 0x000968A9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B21 RID: 23329
				// (get) Token: 0x06011863 RID: 71779 RVA: 0x00405F78 File Offset: 0x00404178
				// (set) Token: 0x06011864 RID: 71780 RVA: 0x000986C8 File Offset: 0x000968C8
				public unsafe WorkSceneServePannel.__c__DisplayClass44_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel.__c__DisplayClass44_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B22 RID: 23330
				// (get) Token: 0x06011865 RID: 71781 RVA: 0x00405FA8 File Offset: 0x004041A8
				// (set) Token: 0x06011866 RID: 71782 RVA: 0x000986E7 File Offset: 0x000968E7
				public unsafe Sprite _targetVisual_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr__targetVisual_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb0.NativeFieldInfoPtr__targetVisual_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B11F RID: 45343
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B120 RID: 45344
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B121 RID: 45345
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B122 RID: 45346
				private static readonly IntPtr NativeFieldInfoPtr__targetVisual_5__2;

				// Token: 0x0400B123 RID: 45347
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B124 RID: 45348
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B125 RID: 45349
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B126 RID: 45350
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B127 RID: 45351
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B128 RID: 45352
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000FFA RID: 4090
			[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass44_0+<<OnThrowDelivering>g__LaunchBev|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1 : Il2CppSystem.Object
			{
				// Token: 0x06011867 RID: 71783 RVA: 0x00405FD8 File Offset: 0x004041D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1()
				{
					Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0>.NativeClassPtr, "<<OnThrowDelivering>g__LaunchBev|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr__targetVisual_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, "<targetVisual>5__2");
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673843);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673844);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673845);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673846);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673847);
					WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr, 100673848);
				}

				// Token: 0x06011868 RID: 71784 RVA: 0x004060CC File Offset: 0x004042CC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011869 RID: 71785 RVA: 0x00406114 File Offset: 0x00404314
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601186A RID: 71786 RVA: 0x00406148 File Offset: 0x00404348
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129215, XrefRangeEnd = 129223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005B29 RID: 23337
				// (get) Token: 0x0601186B RID: 71787 RVA: 0x00406184 File Offset: 0x00404384
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601186C RID: 71788 RVA: 0x004061C4 File Offset: 0x004043C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129223, XrefRangeEnd = 129229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005B2A RID: 23338
				// (get) Token: 0x0601186D RID: 71789 RVA: 0x004061F8 File Offset: 0x004043F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601186E RID: 71790 RVA: 0x00098706 File Offset: 0x00096906
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B25 RID: 23333
				// (get) Token: 0x0601186F RID: 71791 RVA: 0x00406238 File Offset: 0x00404438
				// (set) Token: 0x06011870 RID: 71792 RVA: 0x0009870F File Offset: 0x0009690F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005B26 RID: 23334
				// (get) Token: 0x06011871 RID: 71793 RVA: 0x00406260 File Offset: 0x00404460
				// (set) Token: 0x06011872 RID: 71794 RVA: 0x0009872A File Offset: 0x0009692A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B27 RID: 23335
				// (get) Token: 0x06011873 RID: 71795 RVA: 0x00406290 File Offset: 0x00404490
				// (set) Token: 0x06011874 RID: 71796 RVA: 0x00098749 File Offset: 0x00096949
				public unsafe WorkSceneServePannel.__c__DisplayClass44_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel.__c__DisplayClass44_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B28 RID: 23336
				// (get) Token: 0x06011875 RID: 71797 RVA: 0x004062C0 File Offset: 0x004044C0
				// (set) Token: 0x06011876 RID: 71798 RVA: 0x00098768 File Offset: 0x00096968
				public unsafe Sprite _targetVisual_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr__targetVisual_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpVoObMoInVoBoOb1.NativeFieldInfoPtr__targetVisual_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B129 RID: 45353
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B12A RID: 45354
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B12B RID: 45355
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B12C RID: 45356
				private static readonly IntPtr NativeFieldInfoPtr__targetVisual_5__2;

				// Token: 0x0400B12D RID: 45357
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B12E RID: 45358
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B12F RID: 45359
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B130 RID: 45360
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B131 RID: 45361
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B132 RID: 45362
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000937 RID: 2359
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<OnThrowDelivering>d__44")]
		public sealed class _OnThrowDelivering_d__44 : Il2CppSystem.Object
		{
			// Token: 0x0600B95C RID: 47452 RVA: 0x002ECE6C File Offset: 0x002EB06C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnThrowDelivering_d__44()
			{
				Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<OnThrowDelivering>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, "<>1__state");
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, "<>2__current");
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, "<>4__this");
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr__operationQueue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, "<operationQueue>5__2");
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673849);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673850);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673851);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673852);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673853);
				WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr, 100673854);
			}

			// Token: 0x0600B95D RID: 47453 RVA: 0x002ECF60 File Offset: 0x002EB160
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnThrowDelivering_d__44(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel._OnThrowDelivering_d__44>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B95E RID: 47454 RVA: 0x002ECFA8 File Offset: 0x002EB1A8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B95F RID: 47455 RVA: 0x002ECFDC File Offset: 0x002EB1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129240, XrefRangeEnd = 129325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CBD RID: 15549
			// (get) Token: 0x0600B960 RID: 47456 RVA: 0x002ED018 File Offset: 0x002EB218
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B961 RID: 47457 RVA: 0x002ED058 File Offset: 0x002EB258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129325, XrefRangeEnd = 129331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CBE RID: 15550
			// (get) Token: 0x0600B962 RID: 47458 RVA: 0x002ED08C File Offset: 0x002EB28C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel._OnThrowDelivering_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B963 RID: 47459 RVA: 0x00064136 File Offset: 0x00062336
			public _OnThrowDelivering_d__44(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CB9 RID: 15545
			// (get) Token: 0x0600B964 RID: 47460 RVA: 0x002ED0CC File Offset: 0x002EB2CC
			// (set) Token: 0x0600B965 RID: 47461 RVA: 0x0006413F File Offset: 0x0006233F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CBA RID: 15546
			// (get) Token: 0x0600B966 RID: 47462 RVA: 0x002ED0F4 File Offset: 0x002EB2F4
			// (set) Token: 0x0600B967 RID: 47463 RVA: 0x0006415A File Offset: 0x0006235A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CBB RID: 15547
			// (get) Token: 0x0600B968 RID: 47464 RVA: 0x002ED124 File Offset: 0x002EB324
			// (set) Token: 0x0600B969 RID: 47465 RVA: 0x00064179 File Offset: 0x00062379
			public unsafe WorkSceneServePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CBC RID: 15548
			// (get) Token: 0x0600B96A RID: 47466 RVA: 0x002ED154 File Offset: 0x002EB354
			// (set) Token: 0x0600B96B RID: 47467 RVA: 0x00064198 File Offset: 0x00062398
			public unsafe Queue<Func<IEnumerator>> _operationQueue_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr__operationQueue_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Func<IEnumerator>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel._OnThrowDelivering_d__44.NativeFieldInfoPtr__operationQueue_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077CA RID: 30666
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040077CB RID: 30667
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040077CC RID: 30668
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077CD RID: 30669
			private static readonly IntPtr NativeFieldInfoPtr__operationQueue_5__2;

			// Token: 0x040077CE RID: 30670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040077CF RID: 30671
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077D0 RID: 30672
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040077D1 RID: 30673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040077D2 RID: 30674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040077D3 RID: 30675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000938 RID: 2360
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B96C RID: 47468 RVA: 0x002ED184 File Offset: 0x002EB384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
				WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_toServe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, "toServe");
				WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, "<>9__2");
				WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, 100673855);
				WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, 100673856);
				WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, 100673857);
				WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr, 100673858);
			}

			// Token: 0x0600B96D RID: 47469 RVA: 0x002ED23C File Offset: 0x002EB43C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B96E RID: 47470 RVA: 0x002ED278 File Offset: 0x002EB478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129331, XrefRangeEnd = 129342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetServedVisualOnUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B96F RID: 47471 RVA: 0x002ED2AC File Offset: 0x002EB4AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129342, XrefRangeEnd = 129344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetServedVisualOnUI_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B970 RID: 47472 RVA: 0x002ED2E0 File Offset: 0x002EB4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129344, XrefRangeEnd = 129346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetServedVisualOnUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__SetServedVisualOnUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B971 RID: 47473 RVA: 0x000641B7 File Offset: 0x000623B7
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CBF RID: 15551
			// (get) Token: 0x0600B972 RID: 47474 RVA: 0x002ED314 File Offset: 0x002EB514
			// (set) Token: 0x0600B973 RID: 47475 RVA: 0x000641C0 File Offset: 0x000623C0
			public unsafe WorkSceneServePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneServePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CC0 RID: 15552
			// (get) Token: 0x0600B974 RID: 47476 RVA: 0x002ED344 File Offset: 0x002EB544
			// (set) Token: 0x0600B975 RID: 47477 RVA: 0x000641DF File Offset: 0x000623DF
			public unsafe Sellable toServe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_toServe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_toServe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CC1 RID: 15553
			// (get) Token: 0x0600B976 RID: 47478 RVA: 0x002ED374 File Offset: 0x002EB574
			// (set) Token: 0x0600B977 RID: 47479 RVA: 0x000641FE File Offset: 0x000623FE
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077D4 RID: 30676
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077D5 RID: 30677
			private static readonly IntPtr NativeFieldInfoPtr_toServe;

			// Token: 0x040077D6 RID: 30678
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040077D7 RID: 30679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077D8 RID: 30680
			private static readonly IntPtr NativeMethodInfoPtr__SetServedVisualOnUI_b__0_Internal_Void_0;

			// Token: 0x040077D9 RID: 30681
			private static readonly IntPtr NativeMethodInfoPtr__SetServedVisualOnUI_b__2_Internal_Void_0;

			// Token: 0x040077DA RID: 30682
			private static readonly IntPtr NativeMethodInfoPtr__SetServedVisualOnUI_b__1_Internal_Void_0;
		}

		// Token: 0x02000939 RID: 2361
		[ObfuscatedName("NightScene.UI.GuestManagementUtility.WorkSceneServePannel+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B978 RID: 47480 RVA: 0x002ED3A4 File Offset: 0x002EB5A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneServePannel>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr);
				WorkSceneServePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_izakayaTrayInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr, "izakayaTrayInstance");
				WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr, 100673859);
				WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__Cancel_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr, 100673860);
				WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__Cancel_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr, 100673861);
			}

			// Token: 0x0600B979 RID: 47481 RVA: 0x002ED420 File Offset: 0x002EB620
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneServePannel.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B97A RID: 47482 RVA: 0x002ED45C File Offset: 0x002EB65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129346, XrefRangeEnd = 129349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cancel_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__Cancel_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B97B RID: 47483 RVA: 0x002ED4A8 File Offset: 0x002EB6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129349, XrefRangeEnd = 129352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cancel_b__4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneServePannel.__c__DisplayClass50_0.NativeMethodInfoPtr__Cancel_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B97C RID: 47484 RVA: 0x0006421D File Offset: 0x0006241D
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CC2 RID: 15554
			// (get) Token: 0x0600B97D RID: 47485 RVA: 0x002ED4F4 File Offset: 0x002EB6F4
			// (set) Token: 0x0600B97E RID: 47486 RVA: 0x00064226 File Offset: 0x00062426
			public unsafe IzakayaTray izakayaTrayInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_izakayaTrayInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneServePannel.__c__DisplayClass50_0.NativeFieldInfoPtr_izakayaTrayInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077DB RID: 30683
			private static readonly IntPtr NativeFieldInfoPtr_izakayaTrayInstance;

			// Token: 0x040077DC RID: 30684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077DD RID: 30685
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__1_Internal_Boolean_Int32_0;

			// Token: 0x040077DE RID: 30686
			private static readonly IntPtr NativeMethodInfoPtr__Cancel_b__4_Internal_Boolean_Int32_0;
		}
	}
}
