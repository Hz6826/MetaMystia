using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x0200036D RID: 877
	public class DaySceneCGDisplayerSubPannel : UISubPanel<DaySceneCGDisplayerPannel>
	{
		// Token: 0x06006835 RID: 26677 RVA: 0x001FA4A4 File Offset: 0x001F86A4
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneCGDisplayerSubPannel()
		{
			Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DaySceneCGDisplayerSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr);
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LEGACY_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "LEGACY_TITLE");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_UNUSED_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "UNUSED_TITLE");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "Visual");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoPreviousBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "GotoPreviousBtn");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "GotoNextBtn");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Tips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "Tips");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LegacyIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "LegacyIndicator");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_IndicatorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "IndicatorText");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_hideWhenOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "hideWhenOnly");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_CurrentPicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "m_CurrentPicture");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_DoHideUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "m_DoHideUI");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__PanelOpenMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "<PanelOpenMode>k__BackingField");
			DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__Picture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "<Picture>k__BackingField");
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_get_PanelOpenMode_Private_get_OpenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685017);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_set_PanelOpenMode_Public_set_Void_OpenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685018);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_get_Picture_Private_get_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685019);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_set_Picture_Public_set_Void_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685020);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685021);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdateInputHelper_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685022);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnHide_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685023);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdateTips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685024);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685025);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685026);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdatePic_Private_Void_ValueTuple_3_Sprite_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685027);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685028);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685029);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685030);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685031);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685032);
			DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, 100685033);
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06006836 RID: 26678 RVA: 0x001FA72C File Offset: 0x001F892C
		// (set) Token: 0x06006837 RID: 26679 RVA: 0x001FA768 File Offset: 0x001F8968
		public unsafe DaySceneCGDisplayerPannel.OpenMode PanelOpenMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_get_PanelOpenMode_Private_get_OpenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_set_PanelOpenMode_Public_set_Void_OpenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06006838 RID: 26680 RVA: 0x001FA7A8 File Offset: 0x001F89A8
		// (set) Token: 0x06006839 RID: 26681 RVA: 0x001FA7E8 File Offset: 0x001F89E8
		public unsafe Il2CppReferenceArray<ValueTuple<Sprite, bool, bool>> Picture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_get_Picture_Private_get_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<Sprite, bool, bool>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_set_Picture_Public_set_Void_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x001FA82C File Offset: 0x001F8A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267444, XrefRangeEnd = 267491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x001FA868 File Offset: 0x001F8A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267521, RefRangeEnd = 267522, XrefRangeStart = 267491, XrefRangeEnd = 267521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputHelper(bool showLegacyIndicator, bool showUnusedIndicator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showLegacyIndicator;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showUnusedIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdateInputHelper_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x001FA8B4 File Offset: 0x001F8AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267522, XrefRangeEnd = 267526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHide(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnHide_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x001FA8FC File Offset: 0x001F8AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267526, XrefRangeEnd = 267530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdateTips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600683E RID: 26686 RVA: 0x001FA930 File Offset: 0x001F8B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267530, XrefRangeEnd = 267532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x001FA964 File Offset: 0x001F8B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267532, XrefRangeEnd = 267534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x001FA998 File Offset: 0x001F8B98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 267538, RefRangeEnd = 267542, XrefRangeStart = 267534, XrefRangeEnd = 267538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePic(ValueTuple<Sprite, bool, bool> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_UpdatePic_Private_Void_ValueTuple_3_Sprite_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x001FA9E0 File Offset: 0x001F8BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267542, XrefRangeEnd = 267546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x001FAA28 File Offset: 0x001F8C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267546, XrefRangeEnd = 267550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitchScroll(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x001FAA70 File Offset: 0x001F8C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267552, RefRangeEnd = 267554, XrefRangeStart = 267550, XrefRangeEnd = 267552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSwitch(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x001FAAB0 File Offset: 0x001F8CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267554, XrefRangeEnd = 267556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x001FAAEC File Offset: 0x001F8CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267556, XrefRangeEnd = 267565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x001FAB28 File Offset: 0x001F8D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267565, XrefRangeEnd = 267568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneCGDisplayerSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x0003857C File Offset: 0x0003677C
		public DaySceneCGDisplayerSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x06006848 RID: 26696 RVA: 0x001FAB64 File Offset: 0x001F8D64
		// (set) Token: 0x06006849 RID: 26697 RVA: 0x00038585 File Offset: 0x00036785
		public unsafe static string LEGACY_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LEGACY_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LEGACY_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600684A RID: 26698 RVA: 0x001FAB84 File Offset: 0x001F8D84
		// (set) Token: 0x0600684B RID: 26699 RVA: 0x00038597 File Offset: 0x00036797
		public unsafe static string UNUSED_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_UNUSED_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_UNUSED_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x0600684C RID: 26700 RVA: 0x001FABA4 File Offset: 0x001F8DA4
		// (set) Token: 0x0600684D RID: 26701 RVA: 0x000385A9 File Offset: 0x000367A9
		public unsafe Image Visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x0600684E RID: 26702 RVA: 0x001FABD4 File Offset: 0x001F8DD4
		// (set) Token: 0x0600684F RID: 26703 RVA: 0x000385C8 File Offset: 0x000367C8
		public unsafe UIButtonSimple GotoPreviousBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoPreviousBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoPreviousBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06006850 RID: 26704 RVA: 0x001FAC04 File Offset: 0x001F8E04
		// (set) Token: 0x06006851 RID: 26705 RVA: 0x000385E7 File Offset: 0x000367E7
		public unsafe UIButtonSimple GotoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_GotoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x06006852 RID: 26706 RVA: 0x001FAC34 File Offset: 0x001F8E34
		// (set) Token: 0x06006853 RID: 26707 RVA: 0x00038606 File Offset: 0x00036806
		public unsafe CanvasGroup Tips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Tips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_Tips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x001FAC64 File Offset: 0x001F8E64
		// (set) Token: 0x06006855 RID: 26709 RVA: 0x00038625 File Offset: 0x00036825
		public unsafe CanvasGroup LegacyIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LegacyIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_LegacyIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x001FAC94 File Offset: 0x001F8E94
		// (set) Token: 0x06006857 RID: 26711 RVA: 0x00038644 File Offset: 0x00036844
		public unsafe TextMeshProUGUI IndicatorText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_IndicatorText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_IndicatorText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x001FACC4 File Offset: 0x001F8EC4
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x00038663 File Offset: 0x00036863
		public unsafe Il2CppReferenceArray<GameObject> hideWhenOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_hideWhenOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_hideWhenOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x001FACF4 File Offset: 0x001F8EF4
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00038682 File Offset: 0x00036882
		public unsafe int m_CurrentPicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_CurrentPicture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_CurrentPicture)) = value;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x001FAD1C File Offset: 0x001F8F1C
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x0003869D File Offset: 0x0003689D
		public unsafe bool m_DoHideUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_DoHideUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr_m_DoHideUI)) = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x001FAD44 File Offset: 0x001F8F44
		// (set) Token: 0x0600685F RID: 26719 RVA: 0x000386B8 File Offset: 0x000368B8
		public unsafe DaySceneCGDisplayerPannel.OpenMode _PanelOpenMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__PanelOpenMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__PanelOpenMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x001FAD6C File Offset: 0x001F8F6C
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x000386D3 File Offset: 0x000368D3
		public unsafe Il2CppReferenceArray<ValueTuple<Sprite, bool, bool>> _Picture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__Picture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<Sprite, bool, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.NativeFieldInfoPtr__Picture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004519 RID: 17689
		private static readonly IntPtr NativeFieldInfoPtr_LEGACY_TITLE;

		// Token: 0x0400451A RID: 17690
		private static readonly IntPtr NativeFieldInfoPtr_UNUSED_TITLE;

		// Token: 0x0400451B RID: 17691
		private static readonly IntPtr NativeFieldInfoPtr_Visual;

		// Token: 0x0400451C RID: 17692
		private static readonly IntPtr NativeFieldInfoPtr_GotoPreviousBtn;

		// Token: 0x0400451D RID: 17693
		private static readonly IntPtr NativeFieldInfoPtr_GotoNextBtn;

		// Token: 0x0400451E RID: 17694
		private static readonly IntPtr NativeFieldInfoPtr_Tips;

		// Token: 0x0400451F RID: 17695
		private static readonly IntPtr NativeFieldInfoPtr_LegacyIndicator;

		// Token: 0x04004520 RID: 17696
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorText;

		// Token: 0x04004521 RID: 17697
		private static readonly IntPtr NativeFieldInfoPtr_hideWhenOnly;

		// Token: 0x04004522 RID: 17698
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPicture;

		// Token: 0x04004523 RID: 17699
		private static readonly IntPtr NativeFieldInfoPtr_m_DoHideUI;

		// Token: 0x04004524 RID: 17700
		private static readonly IntPtr NativeFieldInfoPtr__PanelOpenMode_k__BackingField;

		// Token: 0x04004525 RID: 17701
		private static readonly IntPtr NativeFieldInfoPtr__Picture_k__BackingField;

		// Token: 0x04004526 RID: 17702
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelOpenMode_Private_get_OpenMode_0;

		// Token: 0x04004527 RID: 17703
		private static readonly IntPtr NativeMethodInfoPtr_set_PanelOpenMode_Public_set_Void_OpenMode_0;

		// Token: 0x04004528 RID: 17704
		private static readonly IntPtr NativeMethodInfoPtr_get_Picture_Private_get_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0;

		// Token: 0x04004529 RID: 17705
		private static readonly IntPtr NativeMethodInfoPtr_set_Picture_Public_set_Void_Il2CppReferenceArray_1_ValueTuple_3_Sprite_Boolean_Boolean_0;

		// Token: 0x0400452A RID: 17706
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400452B RID: 17707
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputHelper_Private_Void_Boolean_Boolean_0;

		// Token: 0x0400452C RID: 17708
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Private_Void_CallbackContext_0;

		// Token: 0x0400452D RID: 17709
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTips_Private_Void_0;

		// Token: 0x0400452E RID: 17710
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x0400452F RID: 17711
		private static readonly IntPtr NativeMethodInfoPtr_GoToPrevious_Private_Void_0;

		// Token: 0x04004530 RID: 17712
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePic_Private_Void_ValueTuple_3_Sprite_Boolean_Boolean_0;

		// Token: 0x04004531 RID: 17713
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitchMove_Private_Void_CallbackContext_0;

		// Token: 0x04004532 RID: 17714
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitchScroll_Private_Void_CallbackContext_0;

		// Token: 0x04004533 RID: 17715
		private static readonly IntPtr NativeMethodInfoPtr_OnSwitch_Private_Void_Single_0;

		// Token: 0x04004534 RID: 17716
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004535 RID: 17717
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004536 RID: 17718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E78 RID: 3704
		[ObfuscatedName("Common.UI.DaySceneCGDisplayerSubPannel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0601075E RID: 67422 RVA: 0x003D1F1C File Offset: 0x003D011C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr);
				DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr, "count");
				DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr, 100685034);
				DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__UpdateInputHelper_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr, 100685035);
			}

			// Token: 0x0601075F RID: 67423 RVA: 0x003D1F84 File Offset: 0x003D0184
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010760 RID: 67424 RVA: 0x003D1FC0 File Offset: 0x003D01C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267442, XrefRangeEnd = 267444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateInputHelper_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeMethodInfoPtr__UpdateInputHelper_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010761 RID: 67425 RVA: 0x0008FA10 File Offset: 0x0008DC10
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F7 RID: 22007
			// (get) Token: 0x06010762 RID: 67426 RVA: 0x003D2004 File Offset: 0x003D0204
			// (set) Token: 0x06010763 RID: 67427 RVA: 0x0008FA19 File Offset: 0x0008DC19
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCGDisplayerSubPannel.__c__DisplayClass20_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x0400A6B3 RID: 42675
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x0400A6B4 RID: 42676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6B5 RID: 42677
			private static readonly IntPtr NativeMethodInfoPtr__UpdateInputHelper_b__0_Internal_Void_GameObject_0;
		}
	}
}
