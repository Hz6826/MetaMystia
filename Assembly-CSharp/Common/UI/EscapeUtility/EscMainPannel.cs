using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.InputSystem;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003C2 RID: 962
	public class EscMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, EscMainPannel, EscMainPannel.GoToSpecificType>
	{
		// Token: 0x060072CA RID: 29386 RVA: 0x0021D4C4 File Offset: 0x0021B6C4
		// Note: this type is marked as 'beforefieldinit'.
		static EscMainPannel()
		{
			Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscMainPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr);
			EscMainPannel.NativeFieldInfoPtr_LoadPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "LoadPannel");
			EscMainPannel.NativeFieldInfoPtr_ConfigPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "ConfigPannel");
			EscMainPannel.NativeFieldInfoPtr_BindingPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "BindingPannel");
			EscMainPannel.NativeFieldInfoPtr_EscPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "EscPannel");
			EscMainPannel.NativeFieldInfoPtr_LoadBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "LoadBtn");
			EscMainPannel.NativeFieldInfoPtr_ConfigBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "ConfigBtn");
			EscMainPannel.NativeFieldInfoPtr_BindingBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "BindingBtn");
			EscMainPannel.NativeFieldInfoPtr_ExitGameBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "ExitGameBtn");
			EscMainPannel.NativeFieldInfoPtr__ShouldInstantClose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "<ShouldInstantClose>k__BackingField");
			EscMainPannel.NativeFieldInfoPtr__AfterEscPanelCloseByLoadOrExitCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "<AfterEscPanelCloseByLoadOrExitCallback>k__BackingField");
			EscMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686931);
			EscMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686932);
			EscMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686933);
			EscMainPannel.NativeMethodInfoPtr_get_ShouldInstantClose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686934);
			EscMainPannel.NativeMethodInfoPtr_set_ShouldInstantClose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686935);
			EscMainPannel.NativeMethodInfoPtr_get_AfterEscPanelCloseByLoadOrExitCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686936);
			EscMainPannel.NativeMethodInfoPtr_set_AfterEscPanelCloseByLoadOrExitCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686937);
			EscMainPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686938);
			EscMainPannel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686939);
			EscMainPannel.NativeMethodInfoPtr_OpenEsc_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686940);
			EscMainPannel.NativeMethodInfoPtr_OpenEsc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686941);
			EscMainPannel.NativeMethodInfoPtr_OnEscClosed_Private_Void_EscEscPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686942);
			EscMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686943);
			EscMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686944);
			EscMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686945);
			EscMainPannel.NativeMethodInfoPtr__OnEscClosed_b__27_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, 100686946);
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x0021D6FC File Offset: 0x0021B8FC
		public unsafe override IEnumerable<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287042, XrefRangeEnd = 287048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x0021D748 File Offset: 0x0021B948
		public unsafe override EscMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x060072CD RID: 29389 RVA: 0x0021D790 File Offset: 0x0021B990
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x060072CE RID: 29390 RVA: 0x0021D7D4 File Offset: 0x0021B9D4
		// (set) Token: 0x060072CF RID: 29391 RVA: 0x0021D810 File Offset: 0x0021BA10
		public unsafe bool ShouldInstantClose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_get_ShouldInstantClose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_set_ShouldInstantClose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x060072D0 RID: 29392 RVA: 0x0021D850 File Offset: 0x0021BA50
		// (set) Token: 0x060072D1 RID: 29393 RVA: 0x0021D890 File Offset: 0x0021BA90
		public unsafe Action AfterEscPanelCloseByLoadOrExitCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_get_AfterEscPanelCloseByLoadOrExitCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_set_AfterEscPanelCloseByLoadOrExitCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x0021D8D4 File Offset: 0x0021BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287048, XrefRangeEnd = 287049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x0021D91C File Offset: 0x0021BB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287049, XrefRangeEnd = 287070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPostPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x0021D958 File Offset: 0x0021BB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287070, XrefRangeEnd = 287092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEsc(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_OpenEsc_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x0021D9A0 File Offset: 0x0021BBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenEsc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_OpenEsc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x0021D9D4 File Offset: 0x0021BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287092, XrefRangeEnd = 287105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEscClosed(EscEscPannel pannelInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_OnEscClosed_Private_Void_EscEscPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x0021DA18 File Offset: 0x0021BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287105, XrefRangeEnd = 287117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x0021DA54 File Offset: 0x0021BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287117, XrefRangeEnd = 287120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscMainPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x0021DA90 File Offset: 0x0021BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287120, XrefRangeEnd = 287123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x0021DAC4 File Offset: 0x0021BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287123, XrefRangeEnd = 287135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEscClosed_b__27_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.NativeMethodInfoPtr__OnEscClosed_b__27_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x0003E15D File Offset: 0x0003C35D
		public EscMainPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x0021DAF8 File Offset: 0x0021BCF8
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x0003E166 File Offset: 0x0003C366
		public unsafe EscLoadPannel LoadPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_LoadPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscLoadPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_LoadPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x0021DB28 File Offset: 0x0021BD28
		// (set) Token: 0x060072DF RID: 29407 RVA: 0x0003E185 File Offset: 0x0003C385
		public unsafe EscConfigPannel ConfigPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ConfigPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscConfigPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ConfigPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x0021DB58 File Offset: 0x0021BD58
		// (set) Token: 0x060072E1 RID: 29409 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
		public unsafe EscBindingPannel BindingPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_BindingPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_BindingPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x0021DB88 File Offset: 0x0021BD88
		// (set) Token: 0x060072E3 RID: 29411 RVA: 0x0003E1C3 File Offset: 0x0003C3C3
		public unsafe EscEscPannel EscPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_EscPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscEscPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_EscPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x0021DBB8 File Offset: 0x0021BDB8
		// (set) Token: 0x060072E5 RID: 29413 RVA: 0x0003E1E2 File Offset: 0x0003C3E2
		public unsafe UIButtonToggle LoadBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_LoadBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_LoadBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x060072E6 RID: 29414 RVA: 0x0021DBE8 File Offset: 0x0021BDE8
		// (set) Token: 0x060072E7 RID: 29415 RVA: 0x0003E201 File Offset: 0x0003C401
		public unsafe UIButtonToggle ConfigBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ConfigBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ConfigBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x0021DC18 File Offset: 0x0021BE18
		// (set) Token: 0x060072E9 RID: 29417 RVA: 0x0003E220 File Offset: 0x0003C420
		public unsafe UIButtonToggle BindingBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_BindingBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_BindingBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x0021DC48 File Offset: 0x0021BE48
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x0003E23F File Offset: 0x0003C43F
		public unsafe UIButtonSimple ExitGameBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ExitGameBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr_ExitGameBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x0021DC78 File Offset: 0x0021BE78
		// (set) Token: 0x060072ED RID: 29421 RVA: 0x0003E25E File Offset: 0x0003C45E
		public unsafe bool _ShouldInstantClose_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr__ShouldInstantClose_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr__ShouldInstantClose_k__BackingField)) = value;
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x0021DCA0 File Offset: 0x0021BEA0
		// (set) Token: 0x060072EF RID: 29423 RVA: 0x0003E279 File Offset: 0x0003C479
		public unsafe Action _AfterEscPanelCloseByLoadOrExitCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr__AfterEscPanelCloseByLoadOrExitCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel.NativeFieldInfoPtr__AfterEscPanelCloseByLoadOrExitCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C17 RID: 19479
		private static readonly IntPtr NativeFieldInfoPtr_LoadPannel;

		// Token: 0x04004C18 RID: 19480
		private static readonly IntPtr NativeFieldInfoPtr_ConfigPannel;

		// Token: 0x04004C19 RID: 19481
		private static readonly IntPtr NativeFieldInfoPtr_BindingPannel;

		// Token: 0x04004C1A RID: 19482
		private static readonly IntPtr NativeFieldInfoPtr_EscPannel;

		// Token: 0x04004C1B RID: 19483
		private static readonly IntPtr NativeFieldInfoPtr_LoadBtn;

		// Token: 0x04004C1C RID: 19484
		private static readonly IntPtr NativeFieldInfoPtr_ConfigBtn;

		// Token: 0x04004C1D RID: 19485
		private static readonly IntPtr NativeFieldInfoPtr_BindingBtn;

		// Token: 0x04004C1E RID: 19486
		private static readonly IntPtr NativeFieldInfoPtr_ExitGameBtn;

		// Token: 0x04004C1F RID: 19487
		private static readonly IntPtr NativeFieldInfoPtr__ShouldInstantClose_k__BackingField;

		// Token: 0x04004C20 RID: 19488
		private static readonly IntPtr NativeFieldInfoPtr__AfterEscPanelCloseByLoadOrExitCallback_k__BackingField;

		// Token: 0x04004C21 RID: 19489
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0;

		// Token: 0x04004C22 RID: 19490
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0;

		// Token: 0x04004C23 RID: 19491
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x04004C24 RID: 19492
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldInstantClose_Public_get_Boolean_0;

		// Token: 0x04004C25 RID: 19493
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldInstantClose_Public_set_Void_Boolean_0;

		// Token: 0x04004C26 RID: 19494
		private static readonly IntPtr NativeMethodInfoPtr_get_AfterEscPanelCloseByLoadOrExitCallback_Public_get_Action_0;

		// Token: 0x04004C27 RID: 19495
		private static readonly IntPtr NativeMethodInfoPtr_set_AfterEscPanelCloseByLoadOrExitCallback_Public_set_Void_Action_0;

		// Token: 0x04004C28 RID: 19496
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004C29 RID: 19497
		private static readonly IntPtr NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C2A RID: 19498
		private static readonly IntPtr NativeMethodInfoPtr_OpenEsc_Private_Void_CallbackContext_0;

		// Token: 0x04004C2B RID: 19499
		private static readonly IntPtr NativeMethodInfoPtr_OpenEsc_Private_Void_0;

		// Token: 0x04004C2C RID: 19500
		private static readonly IntPtr NativeMethodInfoPtr_OnEscClosed_Private_Void_EscEscPannel_0;

		// Token: 0x04004C2D RID: 19501
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C2E RID: 19502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C2F RID: 19503
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004C30 RID: 19504
		private static readonly IntPtr NativeMethodInfoPtr__OnEscClosed_b__27_0_Private_Void_0;

		// Token: 0x02000F43 RID: 3907
		public enum GoToSpecificType
		{
			// Token: 0x0400AC4A RID: 44106
			Load,
			// Token: 0x0400AC4B RID: 44107
			Config,
			// Token: 0x0400AC4C RID: 44108
			Binding
		}

		// Token: 0x02000F44 RID: 3908
		[ObfuscatedName("Common.UI.EscapeUtility.EscMainPannel+<get_GetData>d__10")]
		public sealed class _get_GetData_d__10 : Object
		{
			// Token: 0x06011086 RID: 69766 RVA: 0x003EEED0 File Offset: 0x003ED0D0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__10()
			{
				Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "<get_GetData>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr);
				EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, "<>1__state");
				EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, "<>2__current");
				EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, "<>l__initialThreadId");
				EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, "<>4__this");
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686947);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686948);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686949);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686950);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686951);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686952);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686953);
				EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr, 100686954);
			}

			// Token: 0x06011087 RID: 69767 RVA: 0x003EEFEC File Offset: 0x003ED1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscMainPannel._get_GetData_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011088 RID: 69768 RVA: 0x003EF034 File Offset: 0x003ED234
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011089 RID: 69769 RVA: 0x003EF068 File Offset: 0x003ED268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287022, XrefRangeEnd = 287023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700589E RID: 22686
			// (get) Token: 0x0601108A RID: 69770 RVA: 0x003EF0A4 File Offset: 0x003ED2A4
			public unsafe ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>> prop_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>(pointer);
				}
			}

			// Token: 0x0601108B RID: 69771 RVA: 0x003EF0DC File Offset: 0x003ED2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287023, XrefRangeEnd = 287029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700589F RID: 22687
			// (get) Token: 0x0601108C RID: 69772 RVA: 0x003EF110 File Offset: 0x003ED310
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287029, XrefRangeEnd = 287032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601108D RID: 69773 RVA: 0x003EF150 File Offset: 0x003ED350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287032, XrefRangeEnd = 287034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>>>(intPtr3) : null;
			}

			// Token: 0x0601108E RID: 69774 RVA: 0x003EF190 File Offset: 0x003ED390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel._get_GetData_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0601108F RID: 69775 RVA: 0x0009423C File Offset: 0x0009243C
			public _get_GetData_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700589A RID: 22682
			// (get) Token: 0x06011090 RID: 69776 RVA: 0x003EF1D0 File Offset: 0x003ED3D0
			// (set) Token: 0x06011091 RID: 69777 RVA: 0x00094245 File Offset: 0x00092445
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700589B RID: 22683
			// (get) Token: 0x06011092 RID: 69778 RVA: 0x003EF1F8 File Offset: 0x003ED3F8
			// (set) Token: 0x06011093 RID: 69779 RVA: 0x00094260 File Offset: 0x00092460
			public ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current);
					return new ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700589C RID: 22684
			// (get) Token: 0x06011094 RID: 69780 RVA: 0x003EF228 File Offset: 0x003ED428
			// (set) Token: 0x06011095 RID: 69781 RVA: 0x0009428E File Offset: 0x0009248E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700589D RID: 22685
			// (get) Token: 0x06011096 RID: 69782 RVA: 0x003EF250 File Offset: 0x003ED450
			// (set) Token: 0x06011097 RID: 69783 RVA: 0x000942A9 File Offset: 0x000924A9
			public unsafe EscMainPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscMainPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscMainPannel._get_GetData_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC4D RID: 44109
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC4E RID: 44110
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AC4F RID: 44111
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400AC50 RID: 44112
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC51 RID: 44113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AC52 RID: 44114
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC53 RID: 44115
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AC54 RID: 44116
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0;

			// Token: 0x0400AC55 RID: 44117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC56 RID: 44118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AC57 RID: 44119
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_EscMainPannel_0;

			// Token: 0x0400AC58 RID: 44120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000F45 RID: 3909
		[ObfuscatedName("Common.UI.EscapeUtility.EscMainPannel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06011098 RID: 69784 RVA: 0x003EF280 File Offset: 0x003ED480
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscMainPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr);
				EscMainPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr, "<>9");
				EscMainPannel.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr, "<>9__27_1");
				EscMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr, 100686956);
				EscMainPannel.__c.NativeMethodInfoPtr__OnEscClosed_b__27_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr, 100686957);
			}

			// Token: 0x06011099 RID: 69785 RVA: 0x003EF2FC File Offset: 0x003ED4FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscMainPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601109A RID: 69786 RVA: 0x003EF338 File Offset: 0x003ED538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287034, XrefRangeEnd = 287042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEscClosed_b__27_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscMainPannel.__c.NativeMethodInfoPtr__OnEscClosed_b__27_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601109B RID: 69787 RVA: 0x000942C8 File Offset: 0x000924C8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058A0 RID: 22688
			// (get) Token: 0x0601109C RID: 69788 RVA: 0x003EF36C File Offset: 0x003ED56C
			// (set) Token: 0x0601109D RID: 69789 RVA: 0x000942D1 File Offset: 0x000924D1
			public unsafe static EscMainPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscMainPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscMainPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscMainPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058A1 RID: 22689
			// (get) Token: 0x0601109E RID: 69790 RVA: 0x003EF394 File Offset: 0x003ED594
			// (set) Token: 0x0601109F RID: 69791 RVA: 0x000942E3 File Offset: 0x000924E3
			public unsafe static Action __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscMainPannel.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscMainPannel.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC59 RID: 44121
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AC5A RID: 44122
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x0400AC5B RID: 44123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC5C RID: 44124
			private static readonly IntPtr NativeMethodInfoPtr__OnEscClosed_b__27_1_Internal_Void_0;
		}
	}
}
