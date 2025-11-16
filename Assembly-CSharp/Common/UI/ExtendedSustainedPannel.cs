using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000379 RID: 889
	public class ExtendedSustainedPannel : GeneralSustainedPannel
	{
		// Token: 0x06006978 RID: 27000 RVA: 0x001FE7A8 File Offset: 0x001FC9A8
		// Note: this type is marked as 'beforefieldinit'.
		static ExtendedSustainedPannel()
		{
			Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ExtendedSustainedPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr);
			ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtnGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "FastForwardBtnGroup");
			ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "FastForwardBtn");
			ExtendedSustainedPannel.NativeFieldInfoPtr_PlayerInputOnlyElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "PlayerInputOnlyElements");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnGroupArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_FastForwardBtnGroupArray");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardGroupTweenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_FastForwardGroupTweenKey");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_PlayerInputOnlyElementsTweenKey");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnEnableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_FastForwardBtnEnableState");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnInteractableAreaInteractableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_FastForwardBtnInteractableAreaInteractableState");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnPlayerInputModeInteractableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_FastForwardBtnPlayerInputModeInteractableState");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_OverrideFastForwardBtnEnableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_OverrideFastForwardBtnEnableState");
			ExtendedSustainedPannel.NativeFieldInfoPtr_m_SpecialEventsFastForwardBtnEnableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, "m_SpecialEventsFastForwardBtnEnableState");
			ExtendedSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685188);
			ExtendedSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685189);
			ExtendedSustainedPannel.NativeMethodInfoPtr_SetFastForwardButtonAvailability_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685190);
			ExtendedSustainedPannel.NativeMethodInfoPtr_SetOverrideFastForwardButtonAvailability_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685191);
			ExtendedSustainedPannel.NativeMethodInfoPtr_SetSpecialEventsFastForawrdBtnEnableState_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685192);
			ExtendedSustainedPannel.NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685193);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685194);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685195);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnTriggerEnterStateChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685196);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685197);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685198);
			ExtendedSustainedPannel.NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685199);
			ExtendedSustainedPannel.NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685200);
			ExtendedSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685201);
			ExtendedSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685202);
			ExtendedSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr, 100685203);
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x06006979 RID: 27001 RVA: 0x001FE9F4 File Offset: 0x001FCBF4
		public unsafe virtual string HoldActionMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_get_HoldActionMap_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x001FEA38 File Offset: 0x001FCC38
		public unsafe virtual string HoldActionName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_get_HoldActionName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x001FEA7C File Offset: 0x001FCC7C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 269167, RefRangeEnd = 269181, XrefRangeStart = 269165, XrefRangeEnd = 269167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFastForwardButtonAvailability(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_SetFastForwardButtonAvailability_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x001FEABC File Offset: 0x001FCCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269181, XrefRangeEnd = 269183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideFastForwardButtonAvailability(bool disable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_SetOverrideFastForwardButtonAvailability_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x001FEAFC File Offset: 0x001FCCFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269184, RefRangeEnd = 269186, XrefRangeStart = 269183, XrefRangeEnd = 269184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialEventsFastForawrdBtnEnableState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_SetSpecialEventsFastForawrdBtnEnableState_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x001FEB3C File Offset: 0x001FCD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269186, XrefRangeEnd = 269188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFastForwardBtn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x001FEB70 File Offset: 0x001FCD70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269254, RefRangeEnd = 269256, XrefRangeStart = 269188, XrefRangeEnd = 269254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x001FEBAC File Offset: 0x001FCDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269256, XrefRangeEnd = 269261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x001FEBEC File Offset: 0x001FCDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269261, XrefRangeEnd = 269264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnterStateChanged(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_OnTriggerEnterStateChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x001FEC2C File Offset: 0x001FCE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269264, XrefRangeEnd = 269265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_OnSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x001FEC60 File Offset: 0x001FCE60
		[CallerCount(0)]
		public unsafe virtual void OnFastForwardSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_OnFastForwardSubmit_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x001FEC9C File Offset: 0x001FCE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269265, XrefRangeEnd = 269269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryExecuteHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x001FECE4 File Offset: 0x001FCEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269269, XrefRangeEnd = 269271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseHold(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x001FED2C File Offset: 0x001FCF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269311, RefRangeEnd = 269312, XrefRangeStart = 269271, XrefRangeEnd = 269311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPrePanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x001FED68 File Offset: 0x001FCF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269327, RefRangeEnd = 269329, XrefRangeStart = 269312, XrefRangeEnd = 269327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExtendedSustainedPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x001FEDA4 File Offset: 0x001FCFA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269344, RefRangeEnd = 269346, XrefRangeStart = 269329, XrefRangeEnd = 269344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtendedSustainedPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtendedSustainedPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtendedSustainedPannel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x000390C0 File Offset: 0x000372C0
		public ExtendedSustainedPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600698A RID: 27018 RVA: 0x001FEDE0 File Offset: 0x001FCFE0
		// (set) Token: 0x0600698B RID: 27019 RVA: 0x000390C9 File Offset: 0x000372C9
		public unsafe CanvasGroup FastForwardBtnGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtnGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtnGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600698C RID: 27020 RVA: 0x001FEE10 File Offset: 0x001FD010
		// (set) Token: 0x0600698D RID: 27021 RVA: 0x000390E8 File Offset: 0x000372E8
		public unsafe UIButtonHold FastForwardBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_FastForwardBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600698E RID: 27022 RVA: 0x001FEE40 File Offset: 0x001FD040
		// (set) Token: 0x0600698F RID: 27023 RVA: 0x00039107 File Offset: 0x00037307
		public unsafe Il2CppReferenceArray<CanvasGroup> PlayerInputOnlyElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_PlayerInputOnlyElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_PlayerInputOnlyElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x06006990 RID: 27024 RVA: 0x001FEE70 File Offset: 0x001FD070
		// (set) Token: 0x06006991 RID: 27025 RVA: 0x00039126 File Offset: 0x00037326
		public unsafe Il2CppReferenceArray<CanvasGroup> m_FastForwardBtnGroupArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnGroupArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnGroupArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06006992 RID: 27026 RVA: 0x001FEEA0 File Offset: 0x001FD0A0
		// (set) Token: 0x06006993 RID: 27027 RVA: 0x00039145 File Offset: 0x00037345
		public unsafe Object m_FastForwardGroupTweenKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardGroupTweenKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardGroupTweenKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x06006994 RID: 27028 RVA: 0x001FEED0 File Offset: 0x001FD0D0
		// (set) Token: 0x06006995 RID: 27029 RVA: 0x00039164 File Offset: 0x00037364
		public unsafe Object m_PlayerInputOnlyElementsTweenKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x001FEF00 File Offset: 0x001FD100
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x00039183 File Offset: 0x00037383
		public unsafe bool m_FastForwardBtnEnableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnEnableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnEnableState)) = value;
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x001FEF28 File Offset: 0x001FD128
		// (set) Token: 0x06006999 RID: 27033 RVA: 0x0003919E File Offset: 0x0003739E
		public unsafe bool m_FastForwardBtnInteractableAreaInteractableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnInteractableAreaInteractableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnInteractableAreaInteractableState)) = value;
			}
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x001FEF50 File Offset: 0x001FD150
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x000391B9 File Offset: 0x000373B9
		public unsafe bool m_FastForwardBtnPlayerInputModeInteractableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnPlayerInputModeInteractableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_FastForwardBtnPlayerInputModeInteractableState)) = value;
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600699C RID: 27036 RVA: 0x001FEF78 File Offset: 0x001FD178
		// (set) Token: 0x0600699D RID: 27037 RVA: 0x000391D4 File Offset: 0x000373D4
		public unsafe bool m_OverrideFastForwardBtnEnableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_OverrideFastForwardBtnEnableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_OverrideFastForwardBtnEnableState)) = value;
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x001FEFA0 File Offset: 0x001FD1A0
		// (set) Token: 0x0600699F RID: 27039 RVA: 0x000391EF File Offset: 0x000373EF
		public unsafe bool m_SpecialEventsFastForwardBtnEnableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_SpecialEventsFastForwardBtnEnableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExtendedSustainedPannel.NativeFieldInfoPtr_m_SpecialEventsFastForwardBtnEnableState)) = value;
			}
		}

		// Token: 0x040045EF RID: 17903
		private static readonly IntPtr NativeFieldInfoPtr_FastForwardBtnGroup;

		// Token: 0x040045F0 RID: 17904
		private static readonly IntPtr NativeFieldInfoPtr_FastForwardBtn;

		// Token: 0x040045F1 RID: 17905
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInputOnlyElements;

		// Token: 0x040045F2 RID: 17906
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardBtnGroupArray;

		// Token: 0x040045F3 RID: 17907
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardGroupTweenKey;

		// Token: 0x040045F4 RID: 17908
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerInputOnlyElementsTweenKey;

		// Token: 0x040045F5 RID: 17909
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardBtnEnableState;

		// Token: 0x040045F6 RID: 17910
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardBtnInteractableAreaInteractableState;

		// Token: 0x040045F7 RID: 17911
		private static readonly IntPtr NativeFieldInfoPtr_m_FastForwardBtnPlayerInputModeInteractableState;

		// Token: 0x040045F8 RID: 17912
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideFastForwardBtnEnableState;

		// Token: 0x040045F9 RID: 17913
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialEventsFastForwardBtnEnableState;

		// Token: 0x040045FA RID: 17914
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionMap_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040045FB RID: 17915
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldActionName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040045FC RID: 17916
		private static readonly IntPtr NativeMethodInfoPtr_SetFastForwardButtonAvailability_Public_Void_Boolean_0;

		// Token: 0x040045FD RID: 17917
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideFastForwardButtonAvailability_Private_Void_Boolean_0;

		// Token: 0x040045FE RID: 17918
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialEventsFastForawrdBtnEnableState_Protected_Void_Boolean_0;

		// Token: 0x040045FF RID: 17919
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFastForwardBtn_Private_Void_0;

		// Token: 0x04004600 RID: 17920
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004601 RID: 17921
		private static readonly IntPtr NativeMethodInfoPtr_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0;

		// Token: 0x04004602 RID: 17922
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnterStateChanged_Private_Void_Boolean_0;

		// Token: 0x04004603 RID: 17923
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_0;

		// Token: 0x04004604 RID: 17924
		private static readonly IntPtr NativeMethodInfoPtr_OnFastForwardSubmit_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04004605 RID: 17925
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteHold_Private_Void_CallbackContext_0;

		// Token: 0x04004606 RID: 17926
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseHold_Private_Void_CallbackContext_0;

		// Token: 0x04004607 RID: 17927
		private static readonly IntPtr NativeMethodInfoPtr_OnPrePanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004608 RID: 17928
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004609 RID: 17929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
