using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.CookingUtility;
using Plugins.DEYU;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D7 RID: 471
	public class WorkSceneEmptyDeskPannel : UIPanelExtern
	{
		// Token: 0x06003B72 RID: 15218 RVA: 0x00168F1C File Offset: 0x0016711C
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneEmptyDeskPannel()
		{
			Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "WorkSceneEmptyDeskPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr);
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_Scheduler");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_OnDeskButton");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_OnDeskVisual");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisualOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_OnDeskVisualOutline");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_DescriberPannel");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_DescriberSubPannel");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_Describer");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_CurrentTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "m_CurrentTray");
			WorkSceneEmptyDeskPannel.NativeFieldInfoPtr__ControllerParent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "<ControllerParent>k__BackingField");
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_get_ControllerParent_Private_get_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674330);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_set_ControllerParent_Public_set_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674331);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674332);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674333);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674334);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674335);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674336);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_UpdatePannelElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674337);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_RefreshTrayContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674338);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_ResetOnDesk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674339);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_SetOnDesk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674340);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Grab_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674341);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Store_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674342);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674343);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674344);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674345);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674346);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674347);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674348);
			WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, 100674349);
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00169190 File Offset: 0x00167390
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x001691D0 File Offset: 0x001673D0
		public unsafe CookController ControllerParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_get_ControllerParent_Private_get_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_set_ControllerParent_Public_set_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00169214 File Offset: 0x00167414
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00169250 File Offset: 0x00167450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135063, XrefRangeEnd = 135083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x0016928C File Offset: 0x0016748C
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x001692C8 File Offset: 0x001674C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135083, XrefRangeEnd = 135118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00169304 File Offset: 0x00167504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135118, XrefRangeEnd = 135124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00169340 File Offset: 0x00167540
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135142, RefRangeEnd = 135146, XrefRangeStart = 135124, XrefRangeEnd = 135142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePannelElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_UpdatePannelElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x00169374 File Offset: 0x00167574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135146, XrefRangeEnd = 135148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTrayContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_RefreshTrayContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x001693A8 File Offset: 0x001675A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135154, RefRangeEnd = 135155, XrefRangeStart = 135148, XrefRangeEnd = 135154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOnDesk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_ResetOnDesk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x001693DC File Offset: 0x001675DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135211, RefRangeEnd = 135212, XrefRangeStart = 135155, XrefRangeEnd = 135211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOnDesk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_SetOnDesk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00169410 File Offset: 0x00167610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135212, XrefRangeEnd = 135241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Grab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Grab_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00169444 File Offset: 0x00167644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135241, XrefRangeEnd = 135267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Store(Sellable toDeliver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toDeliver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Store_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x00169488 File Offset: 0x00167688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x001694C4 File Offset: 0x001676C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneEmptyDeskPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x00169500 File Offset: 0x00167700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00169534 File Offset: 0x00167734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135267, XrefRangeEnd = 135270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__13_0(MoveDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00169574 File Offset: 0x00167774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135270, XrefRangeEnd = 135286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Sellable_PDM_0(Sellable data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x001695B8 File Offset: 0x001677B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135286, XrefRangeEnd = 135288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x001695EC File Offset: 0x001677EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135288, XrefRangeEnd = 135313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Sellable_PDM_1(Sellable data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x000215B8 File Offset: 0x0001F7B8
		public WorkSceneEmptyDeskPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00169630 File Offset: 0x00167830
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x000215C1 File Offset: 0x0001F7C1
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x00169660 File Offset: 0x00167860
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x000215E0 File Offset: 0x0001F7E0
		public unsafe UIButtonSimple m_OnDeskButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x00169690 File Offset: 0x00167890
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x000215FF File Offset: 0x0001F7FF
		public unsafe Image m_OnDeskVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x001696C0 File Offset: 0x001678C0
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x0002161E File Offset: 0x0001F81E
		public unsafe Image m_OnDeskVisualOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisualOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_OnDeskVisualOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x001696F0 File Offset: 0x001678F0
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x0002163D File Offset: 0x0001F83D
		public unsafe CanvasGroup m_DescriberPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x00169720 File Offset: 0x00167920
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x0002165C File Offset: 0x0001F85C
		public unsafe CanvasGroup m_DescriberSubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberSubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_DescriberSubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x00169750 File Offset: 0x00167950
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x0002167B File Offset: 0x0001F87B
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x00169780 File Offset: 0x00167980
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x0002169A File Offset: 0x0001F89A
		public unsafe WorkSceneTrayPannel m_CurrentTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_CurrentTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr_m_CurrentTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x001697B0 File Offset: 0x001679B0
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x000216B9 File Offset: 0x0001F8B9
		public unsafe CookController _ControllerParent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr__ControllerParent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.NativeFieldInfoPtr__ControllerParent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeskButton;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeskVisual;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDeskVisualOutline;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberPannel;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberSubPannel;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTray;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeFieldInfoPtr__ControllerParent_k__BackingField;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeMethodInfoPtr_get_ControllerParent_Private_get_CookController_0;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeMethodInfoPtr_set_ControllerParent_Public_set_Void_CookController_0;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePannelElement_Private_Void_0;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTrayContent_Private_Void_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_ResetOnDesk_Private_Void_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_SetOnDesk_Private_Void_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_Grab_Private_Void_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_Store_Private_Void_Sellable_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_0_Private_Void_MoveDirection_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1;

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneEmptyDeskPannel+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BBA4 RID: 48036 RVA: 0x002F3ADC File Offset: 0x002F1CDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr);
				WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr, "data");
				WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr, 100674350);
				WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr, 100674351);
			}

			// Token: 0x0600BBA5 RID: 48037 RVA: 0x002F3B58 File Offset: 0x002F1D58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBA6 RID: 48038 RVA: 0x002F3B94 File Offset: 0x002F1D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135048, XrefRangeEnd = 135050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBA7 RID: 48039 RVA: 0x00065322 File Offset: 0x00063522
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D5F RID: 15711
			// (get) Token: 0x0600BBA8 RID: 48040 RVA: 0x002F3BC8 File Offset: 0x002F1DC8
			// (set) Token: 0x0600BBA9 RID: 48041 RVA: 0x0006532B File Offset: 0x0006352B
			public unsafe Sellable data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D60 RID: 15712
			// (get) Token: 0x0600BBAA RID: 48042 RVA: 0x002F3BF8 File Offset: 0x002F1DF8
			// (set) Token: 0x0600BBAB RID: 48043 RVA: 0x0006534A File Offset: 0x0006354A
			public unsafe WorkSceneEmptyDeskPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneEmptyDeskPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007934 RID: 31028
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04007935 RID: 31029
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007936 RID: 31030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007937 RID: 31031
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0;
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneEmptyDeskPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BBAC RID: 48044 RVA: 0x002F3C28 File Offset: 0x002F1E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr);
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_toSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, "toSet");
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, "<>9__1");
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, "<>9__2");
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, 100674352);
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, 100674353);
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, 100674354);
				WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__2_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr, 100674355);
			}

			// Token: 0x0600BBAD RID: 48045 RVA: 0x002F3CF4 File Offset: 0x002F1EF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBAE RID: 48046 RVA: 0x002F3D30 File Offset: 0x002F1F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135050, XrefRangeEnd = 135061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOnDesk_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBAF RID: 48047 RVA: 0x002F3D64 File Offset: 0x002F1F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135061, XrefRangeEnd = 135063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOnDesk_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBB0 RID: 48048 RVA: 0x002F3D98 File Offset: 0x002F1F98
			[CallerCount(0)]
			public unsafe void _SetOnDesk_b__2(MoveDirection dir)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__SetOnDesk_b__2_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBB1 RID: 48049 RVA: 0x00065369 File Offset: 0x00063569
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D61 RID: 15713
			// (get) Token: 0x0600BBB2 RID: 48050 RVA: 0x002F3DD8 File Offset: 0x002F1FD8
			// (set) Token: 0x0600BBB3 RID: 48051 RVA: 0x00065372 File Offset: 0x00063572
			public unsafe WorkSceneEmptyDeskPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneEmptyDeskPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D62 RID: 15714
			// (get) Token: 0x0600BBB4 RID: 48052 RVA: 0x002F3E08 File Offset: 0x002F2008
			// (set) Token: 0x0600BBB5 RID: 48053 RVA: 0x00065391 File Offset: 0x00063591
			public unsafe Sellable toSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_toSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_toSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D63 RID: 15715
			// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x002F3E38 File Offset: 0x002F2038
			// (set) Token: 0x0600BBB7 RID: 48055 RVA: 0x000653B0 File Offset: 0x000635B0
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D64 RID: 15716
			// (get) Token: 0x0600BBB8 RID: 48056 RVA: 0x002F3E68 File Offset: 0x002F2068
			// (set) Token: 0x0600BBB9 RID: 48057 RVA: 0x000653CF File Offset: 0x000635CF
			public unsafe Action<MoveDirection> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoveDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass20_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007938 RID: 31032
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007939 RID: 31033
			private static readonly IntPtr NativeFieldInfoPtr_toSet;

			// Token: 0x0400793A RID: 31034
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400793B RID: 31035
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400793C RID: 31036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400793D RID: 31037
			private static readonly IntPtr NativeMethodInfoPtr__SetOnDesk_b__0_Internal_Void_0;

			// Token: 0x0400793E RID: 31038
			private static readonly IntPtr NativeMethodInfoPtr__SetOnDesk_b__1_Internal_Void_0;

			// Token: 0x0400793F RID: 31039
			private static readonly IntPtr NativeMethodInfoPtr__SetOnDesk_b__2_Internal_Void_MoveDirection_0;
		}

		// Token: 0x02000970 RID: 2416
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneEmptyDeskPannel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BBBA RID: 48058 RVA: 0x002F3E98 File Offset: 0x002F2098
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr);
				WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_grabed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr, "grabed");
				WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr, "index");
				WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr, 100674356);
				WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Grab_b__0_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr, 100674357);
				WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Grab_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr, 100674358);
			}

			// Token: 0x0600BBBB RID: 48059 RVA: 0x002F3F28 File Offset: 0x002F2128
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBBC RID: 48060 RVA: 0x002F3F64 File Offset: 0x002F2164
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Grab_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Grab_b__0_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBBD RID: 48061 RVA: 0x002F3FA8 File Offset: 0x002F21A8
			[CallerCount(0)]
			public unsafe bool _Grab_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeMethodInfoPtr__Grab_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BBBE RID: 48062 RVA: 0x000653EE File Offset: 0x000635EE
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D65 RID: 15717
			// (get) Token: 0x0600BBBF RID: 48063 RVA: 0x002F3FF4 File Offset: 0x002F21F4
			// (set) Token: 0x0600BBC0 RID: 48064 RVA: 0x000653F7 File Offset: 0x000635F7
			public unsafe Sellable grabed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_grabed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_grabed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D66 RID: 15718
			// (get) Token: 0x0600BBC1 RID: 48065 RVA: 0x002F4024 File Offset: 0x002F2224
			// (set) Token: 0x0600BBC2 RID: 48066 RVA: 0x00065416 File Offset: 0x00063616
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass21_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04007940 RID: 31040
			private static readonly IntPtr NativeFieldInfoPtr_grabed;

			// Token: 0x04007941 RID: 31041
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04007942 RID: 31042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007943 RID: 31043
			private static readonly IntPtr NativeMethodInfoPtr__Grab_b__0_Internal_Void_Sellable_0;

			// Token: 0x04007944 RID: 31044
			private static readonly IntPtr NativeMethodInfoPtr__Grab_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000971 RID: 2417
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneEmptyDeskPannel+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BBC3 RID: 48067 RVA: 0x002F404C File Offset: 0x002F224C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr);
				WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_parentStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr, "parentStored");
				WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr, 100674359);
				WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__Store_b__0_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr, 100674360);
			}

			// Token: 0x0600BBC4 RID: 48068 RVA: 0x002F40B4 File Offset: 0x002F22B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneEmptyDeskPannel.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBC5 RID: 48069 RVA: 0x002F40F0 File Offset: 0x002F22F0
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Store_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeMethodInfoPtr__Store_b__0_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BBC6 RID: 48070 RVA: 0x00065431 File Offset: 0x00063631
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D67 RID: 15719
			// (get) Token: 0x0600BBC7 RID: 48071 RVA: 0x002F4134 File Offset: 0x002F2334
			// (set) Token: 0x0600BBC8 RID: 48072 RVA: 0x0006543A File Offset: 0x0006363A
			public unsafe Sellable parentStored
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_parentStored);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneEmptyDeskPannel.__c__DisplayClass22_0.NativeFieldInfoPtr_parentStored), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007945 RID: 31045
			private static readonly IntPtr NativeFieldInfoPtr_parentStored;

			// Token: 0x04007946 RID: 31046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007947 RID: 31047
			private static readonly IntPtr NativeMethodInfoPtr__Store_b__0_Internal_Void_Sellable_0;
		}
	}
}
