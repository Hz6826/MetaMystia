using System;
using Common.UI;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Plugins.DEYU;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D5 RID: 469
	public class WorkSceneBinPannel : UIPanelExtern
	{
		// Token: 0x06003AC0 RID: 15040 RVA: 0x00166CAC File Offset: 0x00164EAC
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneBinPannel()
		{
			Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "WorkSceneBinPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr);
			WorkSceneBinPannel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "m_Scheduler");
			WorkSceneBinPannel.NativeFieldInfoPtr_describerPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "describerPannel");
			WorkSceneBinPannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "describer");
			WorkSceneBinPannel.NativeFieldInfoPtr_onTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "onTrash");
			WorkSceneBinPannel.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "animationController");
			WorkSceneBinPannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "progressIndicator");
			WorkSceneBinPannel.NativeFieldInfoPtr_holdDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "holdDuration");
			WorkSceneBinPannel.NativeFieldInfoPtr_m_CurrentTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "m_CurrentTray");
			WorkSceneBinPannel.NativeFieldInfoPtr_m_IsInputRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "m_IsInputRegistered");
			WorkSceneBinPannel.NativeFieldInfoPtr_willDisposeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "willDisposeData");
			WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674217);
			WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674218);
			WorkSceneBinPannel.NativeMethodInfoPtr_ToggleHoldDispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674219);
			WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674220);
			WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674221);
			WorkSceneBinPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674222);
			WorkSceneBinPannel.NativeMethodInfoPtr_StartHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674223);
			WorkSceneBinPannel.NativeMethodInfoPtr_Store_Private_Void_Sellable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674224);
			WorkSceneBinPannel.NativeMethodInfoPtr_EndHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674225);
			WorkSceneBinPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674226);
			WorkSceneBinPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674227);
			WorkSceneBinPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674228);
			WorkSceneBinPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674229);
			WorkSceneBinPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674230);
			WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674231);
			WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674232);
			WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674233);
			WorkSceneBinPannel.NativeMethodInfoPtr__StartHold_b__16_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, 100674234);
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00166F0C File Offset: 0x0016510C
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x00166F48 File Offset: 0x00165148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133400, XrefRangeEnd = 133403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x00166F84 File Offset: 0x00165184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133421, RefRangeEnd = 133423, XrefRangeStart = 133403, XrefRangeEnd = 133421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleHoldDispose(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_ToggleHoldDispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x00166FC4 File Offset: 0x001651C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133423, XrefRangeEnd = 133455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x00167000 File Offset: 0x00165200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133455, XrefRangeEnd = 133461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x0016703C File Offset: 0x0016523C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133488, RefRangeEnd = 133490, XrefRangeStart = 133461, XrefRangeEnd = 133488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_RefreshPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x00167070 File Offset: 0x00165270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133490, XrefRangeEnd = 133503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_StartHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001670B8 File Offset: 0x001652B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133553, RefRangeEnd = 133555, XrefRangeStart = 133503, XrefRangeEnd = 133553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Store(Sellable sellable, bool dispose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispose;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_Store_Private_Void_Sellable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x00167108 File Offset: 0x00165308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133555, XrefRangeEnd = 133558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_EndHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00167150 File Offset: 0x00165350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133558, XrefRangeEnd = 133560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(float progerss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progerss;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_UpdateVisual_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00167190 File Offset: 0x00165390
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x001671CC File Offset: 0x001653CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133560, XrefRangeEnd = 133569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneBinPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00167208 File Offset: 0x00165408
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneBinPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00167244 File Offset: 0x00165444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00167278 File Offset: 0x00165478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133569, XrefRangeEnd = 133572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x001672AC File Offset: 0x001654AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133572, XrefRangeEnd = 133589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Sellable_PDM_0(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x001672F0 File Offset: 0x001654F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133589, XrefRangeEnd = 133590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Sellable_PDM_1(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD2 RID: 15058 RVA: 0x00167334 File Offset: 0x00165534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133590, XrefRangeEnd = 133591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StartHold_b__16_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.NativeMethodInfoPtr__StartHold_b__16_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00020E87 File Offset: 0x0001F087
		public WorkSceneBinPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06003AD4 RID: 15060 RVA: 0x00167368 File Offset: 0x00165568
		// (set) Token: 0x06003AD5 RID: 15061 RVA: 0x00020E90 File Offset: 0x0001F090
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06003AD6 RID: 15062 RVA: 0x00167398 File Offset: 0x00165598
		// (set) Token: 0x06003AD7 RID: 15063 RVA: 0x00020EAF File Offset: 0x0001F0AF
		public unsafe CanvasGroup describerPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_describerPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_describerPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x001673C8 File Offset: 0x001655C8
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x00020ECE File Offset: 0x0001F0CE
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06003ADA RID: 15066 RVA: 0x001673F8 File Offset: 0x001655F8
		// (set) Token: 0x06003ADB RID: 15067 RVA: 0x00020EED File Offset: 0x0001F0ED
		public unsafe AudioClip onTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_onTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_onTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x00167428 File Offset: 0x00165628
		// (set) Token: 0x06003ADD RID: 15069 RVA: 0x00020F0C File Offset: 0x0001F10C
		public unsafe Animator animationController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_animationController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06003ADE RID: 15070 RVA: 0x00167458 File Offset: 0x00165658
		// (set) Token: 0x06003ADF RID: 15071 RVA: 0x00020F2B File Offset: 0x0001F12B
		public unsafe Image progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x00167488 File Offset: 0x00165688
		// (set) Token: 0x06003AE1 RID: 15073 RVA: 0x00020F4A File Offset: 0x0001F14A
		public unsafe float holdDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_holdDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_holdDuration)) = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x001674B0 File Offset: 0x001656B0
		// (set) Token: 0x06003AE3 RID: 15075 RVA: 0x00020F65 File Offset: 0x0001F165
		public unsafe WorkSceneTrayPannel m_CurrentTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_CurrentTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_CurrentTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x001674E0 File Offset: 0x001656E0
		// (set) Token: 0x06003AE5 RID: 15077 RVA: 0x00020F84 File Offset: 0x0001F184
		public unsafe bool m_IsInputRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_IsInputRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_m_IsInputRegistered)) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06003AE6 RID: 15078 RVA: 0x00167508 File Offset: 0x00165708
		// (set) Token: 0x06003AE7 RID: 15079 RVA: 0x00020F9F File Offset: 0x0001F19F
		public unsafe Sellable willDisposeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_willDisposeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.NativeFieldInfoPtr_willDisposeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400277F RID: 10111
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x04002780 RID: 10112
		private static readonly IntPtr NativeFieldInfoPtr_describerPannel;

		// Token: 0x04002781 RID: 10113
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x04002782 RID: 10114
		private static readonly IntPtr NativeFieldInfoPtr_onTrash;

		// Token: 0x04002783 RID: 10115
		private static readonly IntPtr NativeFieldInfoPtr_animationController;

		// Token: 0x04002784 RID: 10116
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeFieldInfoPtr_holdDuration;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTray;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInputRegistered;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeFieldInfoPtr_willDisposeData;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_ToggleHoldDispose_Private_Void_Boolean_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPannel_Private_Void_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_StartHold_Private_Void_CallbackContext_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_Store_Private_Void_Sellable_Boolean_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_EndHold_Private_Void_CallbackContext_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_Single_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_0;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Sellable_PDM_1;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeMethodInfoPtr__StartHold_b__16_0_Private_Void_0;

		// Token: 0x0200095F RID: 2399
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneBinPannel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BAEC RID: 47852 RVA: 0x002F189C File Offset: 0x002EFA9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr);
				WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_sellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr, "sellable");
				WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorkSceneBinPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674235);
				WorkSceneBinPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr, 100674236);
			}

			// Token: 0x0600BAED RID: 47853 RVA: 0x002F1918 File Offset: 0x002EFB18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneBinPannel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAEE RID: 47854 RVA: 0x002F1954 File Offset: 0x002EFB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133392, XrefRangeEnd = 133394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAEF RID: 47855 RVA: 0x00064D96 File Offset: 0x00062F96
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2C RID: 15660
			// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x002F1988 File Offset: 0x002EFB88
			// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x00064D9F File Offset: 0x00062F9F
			public unsafe Sellable sellable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_sellable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr_sellable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D2D RID: 15661
			// (get) Token: 0x0600BAF2 RID: 47858 RVA: 0x002F19B8 File Offset: 0x002EFBB8
			// (set) Token: 0x0600BAF3 RID: 47859 RVA: 0x00064DBE File Offset: 0x00062FBE
			public unsafe WorkSceneBinPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneBinPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneBinPannel.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078C7 RID: 30919
			private static readonly IntPtr NativeFieldInfoPtr_sellable;

			// Token: 0x040078C8 RID: 30920
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040078C9 RID: 30921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078CA RID: 30922
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_0;
		}

		// Token: 0x02000960 RID: 2400
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneBinPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BAF4 RID: 47860 RVA: 0x002F19E8 File Offset: 0x002EFBE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneBinPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr);
				WorkSceneBinPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr, "<>9");
				WorkSceneBinPannel.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr, "<>9__15_0");
				WorkSceneBinPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr, 100674238);
				WorkSceneBinPannel.__c.NativeMethodInfoPtr__RefreshPannel_b__15_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr, 100674239);
			}

			// Token: 0x0600BAF5 RID: 47861 RVA: 0x002F1A64 File Offset: 0x002EFC64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneBinPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAF6 RID: 47862 RVA: 0x002F1AA0 File Offset: 0x002EFCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133394, XrefRangeEnd = 133400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshPannel_b__15_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneBinPannel.__c.NativeMethodInfoPtr__RefreshPannel_b__15_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BAF7 RID: 47863 RVA: 0x00064DDD File Offset: 0x00062FDD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2E RID: 15662
			// (get) Token: 0x0600BAF8 RID: 47864 RVA: 0x002F1AEC File Offset: 0x002EFCEC
			// (set) Token: 0x0600BAF9 RID: 47865 RVA: 0x00064DE6 File Offset: 0x00062FE6
			public unsafe static WorkSceneBinPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneBinPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneBinPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneBinPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D2F RID: 15663
			// (get) Token: 0x0600BAFA RID: 47866 RVA: 0x002F1B14 File Offset: 0x002EFD14
			// (set) Token: 0x0600BAFB RID: 47867 RVA: 0x00064DF8 File Offset: 0x00062FF8
			public unsafe static Predicate<int> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneBinPannel.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneBinPannel.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078CB RID: 30923
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040078CC RID: 30924
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040078CD RID: 30925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078CE RID: 30926
			private static readonly IntPtr NativeMethodInfoPtr__RefreshPannel_b__15_0_Internal_Boolean_Int32_0;
		}
	}
}
