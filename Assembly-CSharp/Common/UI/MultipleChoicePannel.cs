using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x0200037D RID: 893
	public class MultipleChoicePannel : UIPanel
	{
		// Token: 0x060069DE RID: 27102 RVA: 0x001FFED0 File Offset: 0x001FE0D0
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleChoicePannel()
		{
			Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "MultipleChoicePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr);
			MultipleChoicePannel.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "Parent");
			MultipleChoicePannel.NativeFieldInfoPtr_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "Field");
			MultipleChoicePannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "Scroller");
			MultipleChoicePannel.NativeFieldInfoPtr_PannelTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "PannelTitle");
			MultipleChoicePannel.NativeFieldInfoPtr_SubmitBtnTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "SubmitBtnTitle");
			MultipleChoicePannel.NativeFieldInfoPtr_DenyBtnTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "DenyBtnTitle");
			MultipleChoicePannel.NativeFieldInfoPtr_ConfirmBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "ConfirmBtn");
			MultipleChoicePannel.NativeFieldInfoPtr_DenyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "DenyBtn");
			MultipleChoicePannel.NativeFieldInfoPtr_m_AllExtraSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "m_AllExtraSelections");
			MultipleChoicePannel.NativeFieldInfoPtr_m_AllValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "m_AllValue");
			MultipleChoicePannel.NativeFieldInfoPtr_SelectedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "SelectedID");
			MultipleChoicePannel.NativeFieldInfoPtr_m_GridControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "m_GridControl");
			MultipleChoicePannel.NativeFieldInfoPtr_m_SelectAllSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "m_SelectAllSelection");
			MultipleChoicePannel.NativeFieldInfoPtr__FinalSelectedID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "<FinalSelectedID>k__BackingField");
			MultipleChoicePannel.NativeFieldInfoPtr__IsConfirm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "<IsConfirm>k__BackingField");
			MultipleChoicePannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			MultipleChoicePannel.NativeFieldInfoPtr__OpenContextString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "<OpenContextString>k__BackingField");
			MultipleChoicePannel.NativeMethodInfoPtr_get_FinalSelectedID_Public_get_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685244);
			MultipleChoicePannel.NativeMethodInfoPtr_set_FinalSelectedID_Private_set_Void_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685245);
			MultipleChoicePannel.NativeMethodInfoPtr_get_IsConfirm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685246);
			MultipleChoicePannel.NativeMethodInfoPtr_set_IsConfirm_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685247);
			MultipleChoicePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_MultipleChoicePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685248);
			MultipleChoicePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MultipleChoicePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685249);
			MultipleChoicePannel.NativeMethodInfoPtr_get_OpenContextString_Private_get_MultipleChoicePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685250);
			MultipleChoicePannel.NativeMethodInfoPtr_set_OpenContextString_Public_set_Void_MultipleChoicePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685251);
			MultipleChoicePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685252);
			MultipleChoicePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685253);
			MultipleChoicePannel.NativeMethodInfoPtr_OnConfirm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685254);
			MultipleChoicePannel.NativeMethodInfoPtr_OnDeny_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685255);
			MultipleChoicePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685256);
			MultipleChoicePannel.NativeMethodInfoPtr_UpdateSubmitBtn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685257);
			MultipleChoicePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685258);
			MultipleChoicePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685259);
			MultipleChoicePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685260);
			MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685261);
			MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_1_Private_Void_Object_UIElementCluster_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685262);
			MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_4_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, 100685263);
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x002001E4 File Offset: 0x001FE3E4
		// (set) Token: 0x060069E0 RID: 27104 RVA: 0x00200224 File Offset: 0x001FE424
		public unsafe List<Il2CppSystem.Object> FinalSelectedID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_get_FinalSelectedID_Public_get_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_set_FinalSelectedID_Private_set_Void_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x00200268 File Offset: 0x001FE468
		// (set) Token: 0x060069E2 RID: 27106 RVA: 0x002002A4 File Offset: 0x001FE4A4
		public unsafe bool IsConfirm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_get_IsConfirm_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_set_IsConfirm_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x002002E4 File Offset: 0x001FE4E4
		// (set) Token: 0x060069E4 RID: 27108 RVA: 0x0020031C File Offset: 0x001FE51C
		public unsafe MultipleChoicePannel.MultipleChoicePannelOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_get_OpenContext_Private_get_MultipleChoicePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MultipleChoicePannel.MultipleChoicePannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269870, XrefRangeEnd = 269871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MultipleChoicePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x00200364 File Offset: 0x001FE564
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x0020039C File Offset: 0x001FE59C
		public unsafe MultipleChoicePannel.MultipleChoicePannelOpenContext OpenContextString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_get_OpenContextString_Private_get_MultipleChoicePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MultipleChoicePannel.MultipleChoicePannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269871, XrefRangeEnd = 269872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_set_OpenContextString_Public_set_Void_MultipleChoicePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x002003E4 File Offset: 0x001FE5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleChoicePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x00200420 File Offset: 0x001FE620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269872, XrefRangeEnd = 269916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x00200454 File Offset: 0x001FE654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269916, XrefRangeEnd = 269918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConfirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_OnConfirm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00200488 File Offset: 0x001FE688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269918, XrefRangeEnd = 269919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeny()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_OnDeny_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x002004BC File Offset: 0x001FE6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269919, XrefRangeEnd = 269966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x002004F0 File Offset: 0x001FE6F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269972, RefRangeEnd = 269975, XrefRangeStart = 269966, XrefRangeEnd = 269972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubmitBtn(bool requestedAvailibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedAvailibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_UpdateSubmitBtn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x00200530 File Offset: 0x001FE730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269975, XrefRangeEnd = 269982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x00200564 File Offset: 0x001FE764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269982, XrefRangeEnd = 270001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleChoicePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x002005A0 File Offset: 0x001FE7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270001, XrefRangeEnd = 270022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleChoicePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x002005DC File Offset: 0x001FE7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270022, XrefRangeEnd = 270036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__30_0(Il2CppSystem.Object value, UIElementCluster ui, UIButtonToggle btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00200644 File Offset: 0x001FE844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270036, XrefRangeEnd = 270068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__30_1(Il2CppSystem.Object value, UIElementCluster ui, UIButtonToggle btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_1_Private_Void_Object_UIElementCluster_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x002006AC File Offset: 0x001FE8AC
		[CallerCount(0)]
		public unsafe void _OnPanelInitialize_b__30_4(MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.NativeMethodInfoPtr__OnPanelInitialize_b__30_4_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x00039369 File Offset: 0x00037569
		public MultipleChoicePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060069F4 RID: 27124 RVA: 0x002006EC File Offset: 0x001FE8EC
		// (set) Token: 0x060069F5 RID: 27125 RVA: 0x00039372 File Offset: 0x00037572
		public unsafe GameObject Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x060069F6 RID: 27126 RVA: 0x0020071C File Offset: 0x001FE91C
		// (set) Token: 0x060069F7 RID: 27127 RVA: 0x00039391 File Offset: 0x00037591
		public unsafe GridLayoutGroup Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060069F8 RID: 27128 RVA: 0x0020074C File Offset: 0x001FE94C
		// (set) Token: 0x060069F9 RID: 27129 RVA: 0x000393B0 File Offset: 0x000375B0
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060069FA RID: 27130 RVA: 0x0020077C File Offset: 0x001FE97C
		// (set) Token: 0x060069FB RID: 27131 RVA: 0x000393CF File Offset: 0x000375CF
		public unsafe TextMeshProUGUI PannelTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_PannelTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_PannelTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060069FC RID: 27132 RVA: 0x002007AC File Offset: 0x001FE9AC
		// (set) Token: 0x060069FD RID: 27133 RVA: 0x000393EE File Offset: 0x000375EE
		public unsafe TextMeshProUGUI SubmitBtnTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_SubmitBtnTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_SubmitBtnTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060069FE RID: 27134 RVA: 0x002007DC File Offset: 0x001FE9DC
		// (set) Token: 0x060069FF RID: 27135 RVA: 0x0003940D File Offset: 0x0003760D
		public unsafe TextMeshProUGUI DenyBtnTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_DenyBtnTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_DenyBtnTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x0020080C File Offset: 0x001FEA0C
		// (set) Token: 0x06006A01 RID: 27137 RVA: 0x0003942C File Offset: 0x0003762C
		public unsafe UIButtonSimple ConfirmBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_ConfirmBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_ConfirmBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x0020083C File Offset: 0x001FEA3C
		// (set) Token: 0x06006A03 RID: 27139 RVA: 0x0003944B File Offset: 0x0003764B
		public unsafe UIButtonSimple DenyBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_DenyBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_DenyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x06006A04 RID: 27140 RVA: 0x0020086C File Offset: 0x001FEA6C
		// (set) Token: 0x06006A05 RID: 27141 RVA: 0x0003946A File Offset: 0x0003766A
		public unsafe Dictionary<Il2CppSystem.Object, ValueTuple<string, string>> m_AllExtraSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_AllExtraSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Object, ValueTuple<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_AllExtraSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x0020089C File Offset: 0x001FEA9C
		// (set) Token: 0x06006A07 RID: 27143 RVA: 0x00039489 File Offset: 0x00037689
		public unsafe List<Il2CppSystem.Object> m_AllValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_AllValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_AllValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x06006A08 RID: 27144 RVA: 0x002008CC File Offset: 0x001FEACC
		// (set) Token: 0x06006A09 RID: 27145 RVA: 0x000394A8 File Offset: 0x000376A8
		public unsafe List<Il2CppSystem.Object> SelectedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_SelectedID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_SelectedID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x002008FC File Offset: 0x001FEAFC
		// (set) Token: 0x06006A0B RID: 27147 RVA: 0x000394C7 File Offset: 0x000376C7
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Il2CppSystem.Object, UIElementCluster, UIButtonToggle> m_GridControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_GridControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Il2CppSystem.Object, UIElementCluster, UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_GridControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x06006A0C RID: 27148 RVA: 0x0020092C File Offset: 0x001FEB2C
		// (set) Token: 0x06006A0D RID: 27149 RVA: 0x000394E6 File Offset: 0x000376E6
		public ValueTuple<Il2CppSystem.Object, string, string> m_SelectAllSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_SelectAllSelection);
				return new ValueTuple<Il2CppSystem.Object, string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr_m_SelectAllSelection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x0020095C File Offset: 0x001FEB5C
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x00039514 File Offset: 0x00037714
		public unsafe List<Il2CppSystem.Object> _FinalSelectedID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__FinalSelectedID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__FinalSelectedID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06006A10 RID: 27152 RVA: 0x0020098C File Offset: 0x001FEB8C
		// (set) Token: 0x06006A11 RID: 27153 RVA: 0x00039533 File Offset: 0x00037733
		public unsafe bool _IsConfirm_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__IsConfirm_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__IsConfirm_k__BackingField)) = value;
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06006A12 RID: 27154 RVA: 0x002009B4 File Offset: 0x001FEBB4
		// (set) Token: 0x06006A13 RID: 27155 RVA: 0x0003954E File Offset: 0x0003774E
		public MultipleChoicePannel.MultipleChoicePannelOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06006A14 RID: 27156 RVA: 0x002009E4 File Offset: 0x001FEBE4
		// (set) Token: 0x06006A15 RID: 27157 RVA: 0x0003957C File Offset: 0x0003777C
		public MultipleChoicePannel.MultipleChoicePannelOpenContext _OpenContextString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__OpenContextString_k__BackingField);
				return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.NativeFieldInfoPtr__OpenContextString_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04004637 RID: 17975
		private static readonly IntPtr NativeFieldInfoPtr_Parent;

		// Token: 0x04004638 RID: 17976
		private static readonly IntPtr NativeFieldInfoPtr_Field;

		// Token: 0x04004639 RID: 17977
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x0400463A RID: 17978
		private static readonly IntPtr NativeFieldInfoPtr_PannelTitle;

		// Token: 0x0400463B RID: 17979
		private static readonly IntPtr NativeFieldInfoPtr_SubmitBtnTitle;

		// Token: 0x0400463C RID: 17980
		private static readonly IntPtr NativeFieldInfoPtr_DenyBtnTitle;

		// Token: 0x0400463D RID: 17981
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmBtn;

		// Token: 0x0400463E RID: 17982
		private static readonly IntPtr NativeFieldInfoPtr_DenyBtn;

		// Token: 0x0400463F RID: 17983
		private static readonly IntPtr NativeFieldInfoPtr_m_AllExtraSelections;

		// Token: 0x04004640 RID: 17984
		private static readonly IntPtr NativeFieldInfoPtr_m_AllValue;

		// Token: 0x04004641 RID: 17985
		private static readonly IntPtr NativeFieldInfoPtr_SelectedID;

		// Token: 0x04004642 RID: 17986
		private static readonly IntPtr NativeFieldInfoPtr_m_GridControl;

		// Token: 0x04004643 RID: 17987
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectAllSelection;

		// Token: 0x04004644 RID: 17988
		private static readonly IntPtr NativeFieldInfoPtr__FinalSelectedID_k__BackingField;

		// Token: 0x04004645 RID: 17989
		private static readonly IntPtr NativeFieldInfoPtr__IsConfirm_k__BackingField;

		// Token: 0x04004646 RID: 17990
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04004647 RID: 17991
		private static readonly IntPtr NativeFieldInfoPtr__OpenContextString_k__BackingField;

		// Token: 0x04004648 RID: 17992
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalSelectedID_Public_get_List_1_Object_0;

		// Token: 0x04004649 RID: 17993
		private static readonly IntPtr NativeMethodInfoPtr_set_FinalSelectedID_Private_set_Void_List_1_Object_0;

		// Token: 0x0400464A RID: 17994
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConfirm_Public_get_Boolean_0;

		// Token: 0x0400464B RID: 17995
		private static readonly IntPtr NativeMethodInfoPtr_set_IsConfirm_Private_set_Void_Boolean_0;

		// Token: 0x0400464C RID: 17996
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_MultipleChoicePannelOpenContext_0;

		// Token: 0x0400464D RID: 17997
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_MultipleChoicePannelOpenContext_0;

		// Token: 0x0400464E RID: 17998
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContextString_Private_get_MultipleChoicePannelOpenContext_0;

		// Token: 0x0400464F RID: 17999
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContextString_Public_set_Void_MultipleChoicePannelOpenContext_0;

		// Token: 0x04004650 RID: 18000
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004651 RID: 18001
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0;

		// Token: 0x04004652 RID: 18002
		private static readonly IntPtr NativeMethodInfoPtr_OnConfirm_Private_Void_0;

		// Token: 0x04004653 RID: 18003
		private static readonly IntPtr NativeMethodInfoPtr_OnDeny_Private_Void_0;

		// Token: 0x04004654 RID: 18004
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_0;

		// Token: 0x04004655 RID: 18005
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubmitBtn_Private_Void_Boolean_0;

		// Token: 0x04004656 RID: 18006
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_0;

		// Token: 0x04004657 RID: 18007
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004658 RID: 18008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004659 RID: 18009
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0;

		// Token: 0x0400465A RID: 18010
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_1_Private_Void_Object_UIElementCluster_UIButtonToggle_0;

		// Token: 0x0400465B RID: 18011
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_4_Private_Void_MoveDirection_0;

		// Token: 0x02000E8B RID: 3723
		public sealed class MultipleChoicePannelOpenContext : ValueType
		{
			// Token: 0x0601082A RID: 67626 RVA: 0x003D4184 File Offset: 0x003D2384
			// Note: this type is marked as 'beforefieldinit'.
			static MultipleChoicePannelOpenContext()
			{
				Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "MultipleChoicePannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr);
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_AllData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "AllData");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_ExtraSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "ExtraSelections");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SelectAllSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "SelectAllSelection");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_IdToSelectionTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "IdToSelectionTextCallback");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_PannelTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "PannelTitle");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitButtonAvailabilityCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "GetSubmitButtonAvailabilityCallback");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SubmitBtnTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "SubmitBtnTitle");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_DenyBtnTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "DenyBtnTitle");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitBtnTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "GetSubmitBtnTextCallback");
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, 100685264);
				MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_Func_2_IEnumerable_1_Object_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, 100685265);
			}

			// Token: 0x0601082B RID: 67627 RVA: 0x003D428C File Offset: 0x003D248C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 269786, RefRangeEnd = 269791, XrefRangeStart = 269740, XrefRangeEnd = 269786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MultipleChoicePannelOpenContext(Il2CppReferenceArray<Il2CppSystem.Object> allData, IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>> extraSelections, ValueTuple<Il2CppSystem.Object, string, string> selectAllSelection, Func<Il2CppSystem.Object, string> idToSelectionTextCallback, string pannelTitle, string submitBtnTitle, string debyBtnTitle, Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> getSubmitButtonAvailabilityCallback = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraSelections);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selectAllSelection));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToSelectionTextCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pannelTitle);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(submitBtnTitle);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debyBtnTitle);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSubmitButtonAvailabilityCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601082C RID: 67628 RVA: 0x003D4364 File Offset: 0x003D2564
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 269837, RefRangeEnd = 269841, XrefRangeStart = 269791, XrefRangeEnd = 269837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MultipleChoicePannelOpenContext(Il2CppReferenceArray<Il2CppSystem.Object> allData, IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>> extraSelections, ValueTuple<Il2CppSystem.Object, string, string> selectAllSelection, Func<Il2CppSystem.Object, string> idToSelectionTextCallback, string pannelTitle, Func<IEnumerable<Il2CppSystem.Object>, string> getSubmitBtnTitleCallback, string denyBtnTitle, Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> getSubmitButtonAvailabilityCallback = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraSelections);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selectAllSelection));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToSelectionTextCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pannelTitle);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSubmitBtnTitleCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(denyBtnTitle);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getSubmitButtonAvailabilityCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_Func_2_IEnumerable_1_Object_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601082D RID: 67629 RVA: 0x0009026E File Offset: 0x0008E46E
			public MultipleChoicePannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601082E RID: 67630 RVA: 0x00090277 File Offset: 0x0008E477
			public MultipleChoicePannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17005631 RID: 22065
			// (get) Token: 0x0601082F RID: 67631 RVA: 0x003D443C File Offset: 0x003D263C
			// (set) Token: 0x06010830 RID: 67632 RVA: 0x00090289 File Offset: 0x0008E489
			public unsafe Il2CppReferenceArray<Il2CppSystem.Object> AllData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_AllData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_AllData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005632 RID: 22066
			// (get) Token: 0x06010831 RID: 67633 RVA: 0x003D446C File Offset: 0x003D266C
			// (set) Token: 0x06010832 RID: 67634 RVA: 0x000902A8 File Offset: 0x0008E4A8
			public unsafe IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>> ExtraSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_ExtraSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<Il2CppSystem.Object, string, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_ExtraSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005633 RID: 22067
			// (get) Token: 0x06010833 RID: 67635 RVA: 0x003D449C File Offset: 0x003D269C
			// (set) Token: 0x06010834 RID: 67636 RVA: 0x000902C7 File Offset: 0x0008E4C7
			public ValueTuple<Il2CppSystem.Object, string, string> SelectAllSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SelectAllSelection);
					return new ValueTuple<Il2CppSystem.Object, string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SelectAllSelection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Il2CppSystem.Object, string, string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005634 RID: 22068
			// (get) Token: 0x06010835 RID: 67637 RVA: 0x003D44CC File Offset: 0x003D26CC
			// (set) Token: 0x06010836 RID: 67638 RVA: 0x000902F5 File Offset: 0x0008E4F5
			public unsafe Func<Il2CppSystem.Object, string> IdToSelectionTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_IdToSelectionTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_IdToSelectionTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005635 RID: 22069
			// (get) Token: 0x06010837 RID: 67639 RVA: 0x003D44FC File Offset: 0x003D26FC
			// (set) Token: 0x06010838 RID: 67640 RVA: 0x00090314 File Offset: 0x0008E514
			public unsafe string PannelTitle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_PannelTitle);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_PannelTitle), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005636 RID: 22070
			// (get) Token: 0x06010839 RID: 67641 RVA: 0x003D4524 File Offset: 0x003D2724
			// (set) Token: 0x0601083A RID: 67642 RVA: 0x00090333 File Offset: 0x0008E533
			public unsafe Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> GetSubmitButtonAvailabilityCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitButtonAvailabilityCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitButtonAvailabilityCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005637 RID: 22071
			// (get) Token: 0x0601083B RID: 67643 RVA: 0x003D4554 File Offset: 0x003D2754
			// (set) Token: 0x0601083C RID: 67644 RVA: 0x00090352 File Offset: 0x0008E552
			public unsafe string SubmitBtnTitle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SubmitBtnTitle);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_SubmitBtnTitle), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005638 RID: 22072
			// (get) Token: 0x0601083D RID: 67645 RVA: 0x003D457C File Offset: 0x003D277C
			// (set) Token: 0x0601083E RID: 67646 RVA: 0x00090371 File Offset: 0x0008E571
			public unsafe string DenyBtnTitle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_DenyBtnTitle);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_DenyBtnTitle), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005639 RID: 22073
			// (get) Token: 0x0601083F RID: 67647 RVA: 0x003D45A4 File Offset: 0x003D27A4
			// (set) Token: 0x06010840 RID: 67648 RVA: 0x00090390 File Offset: 0x0008E590
			public unsafe Func<IEnumerable<Il2CppSystem.Object>, string> GetSubmitBtnTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitBtnTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Il2CppSystem.Object>, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.MultipleChoicePannelOpenContext.NativeFieldInfoPtr_GetSubmitBtnTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A71D RID: 42781
			private static readonly IntPtr NativeFieldInfoPtr_AllData;

			// Token: 0x0400A71E RID: 42782
			private static readonly IntPtr NativeFieldInfoPtr_ExtraSelections;

			// Token: 0x0400A71F RID: 42783
			private static readonly IntPtr NativeFieldInfoPtr_SelectAllSelection;

			// Token: 0x0400A720 RID: 42784
			private static readonly IntPtr NativeFieldInfoPtr_IdToSelectionTextCallback;

			// Token: 0x0400A721 RID: 42785
			private static readonly IntPtr NativeFieldInfoPtr_PannelTitle;

			// Token: 0x0400A722 RID: 42786
			private static readonly IntPtr NativeFieldInfoPtr_GetSubmitButtonAvailabilityCallback;

			// Token: 0x0400A723 RID: 42787
			private static readonly IntPtr NativeFieldInfoPtr_SubmitBtnTitle;

			// Token: 0x0400A724 RID: 42788
			private static readonly IntPtr NativeFieldInfoPtr_DenyBtnTitle;

			// Token: 0x0400A725 RID: 42789
			private static readonly IntPtr NativeFieldInfoPtr_GetSubmitBtnTextCallback;

			// Token: 0x0400A726 RID: 42790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0;

			// Token: 0x0400A727 RID: 42791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_IEnumerable_1_ValueTuple_3_Object_String_String_ValueTuple_3_Object_String_String_Func_2_Object_String_String_Func_2_IEnumerable_1_Object_String_String_Func_2_ValueTuple_2_IEnumerable_1_Object_Boolean_Boolean_0;

			// Token: 0x020010B8 RID: 4280
			[ObfuscatedName("Common.UI.MultipleChoicePannel+MultipleChoicePannelOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601231F RID: 74527 RVA: 0x00426090 File Offset: 0x00424290
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr);
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, "<>9");
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, "<>9__9_0");
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, "<>9__10_0");
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, 100685267);
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, 100685268);
					MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr, 100685269);
				}

				// Token: 0x06012320 RID: 74528 RVA: 0x00426134 File Offset: 0x00424334
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012321 RID: 74529 RVA: 0x00426170 File Offset: 0x00424370
				[CallerCount(0)]
				public unsafe bool __ctor_b__9_0(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012322 RID: 74530 RVA: 0x004261C4 File Offset: 0x004243C4
				[CallerCount(0)]
				public unsafe bool __ctor_b__10_0(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012323 RID: 74531 RVA: 0x0009DFBB File Offset: 0x0009C1BB
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F2B RID: 24363
				// (get) Token: 0x06012324 RID: 74532 RVA: 0x00426218 File Offset: 0x00424418
				// (set) Token: 0x06012325 RID: 74533 RVA: 0x0009DFC4 File Offset: 0x0009C1C4
				public unsafe static MultipleChoicePannel.MultipleChoicePannelOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel.MultipleChoicePannelOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F2C RID: 24364
				// (get) Token: 0x06012326 RID: 74534 RVA: 0x00426240 File Offset: 0x00424440
				// (set) Token: 0x06012327 RID: 74535 RVA: 0x0009DFD6 File Offset: 0x0009C1D6
				public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__9_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F2D RID: 24365
				// (get) Token: 0x06012328 RID: 74536 RVA: 0x00426268 File Offset: 0x00424468
				// (set) Token: 0x06012329 RID: 74537 RVA: 0x0009DFE8 File Offset: 0x0009C1E8
				public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__10_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MultipleChoicePannel.MultipleChoicePannelOpenContext.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B86C RID: 47212
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B86D RID: 47213
				private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

				// Token: 0x0400B86E RID: 47214
				private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

				// Token: 0x0400B86F RID: 47215
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B870 RID: 47216
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;

				// Token: 0x0400B871 RID: 47217
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;
			}
		}

		// Token: 0x02000E8C RID: 3724
		[ObfuscatedName("Common.UI.MultipleChoicePannel+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x06010841 RID: 67649 RVA: 0x003D45D4 File Offset: 0x003D27D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipleChoicePannel>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr);
				MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr, "value");
				MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr, 100685270);
				MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr, 100685271);
				MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr, 100685272);
			}

			// Token: 0x06010842 RID: 67650 RVA: 0x003D4664 File Offset: 0x003D2864
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleChoicePannel.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010843 RID: 67651 RVA: 0x003D46A0 File Offset: 0x003D28A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269841, XrefRangeEnd = 269858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010844 RID: 67652 RVA: 0x003D46D4 File Offset: 0x003D28D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269858, XrefRangeEnd = 269870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleChoicePannel.__c__DisplayClass30_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010845 RID: 67653 RVA: 0x000903AF File Offset: 0x0008E5AF
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700563A RID: 22074
			// (get) Token: 0x06010846 RID: 67654 RVA: 0x003D4708 File Offset: 0x003D2908
			// (set) Token: 0x06010847 RID: 67655 RVA: 0x000903B8 File Offset: 0x0008E5B8
			public unsafe Il2CppSystem.Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700563B RID: 22075
			// (get) Token: 0x06010848 RID: 67656 RVA: 0x003D4738 File Offset: 0x003D2938
			// (set) Token: 0x06010849 RID: 67657 RVA: 0x000903D7 File Offset: 0x0008E5D7
			public unsafe MultipleChoicePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipleChoicePannel.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A728 RID: 42792
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A729 RID: 42793
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A72A RID: 42794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A72B RID: 42795
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0;

			// Token: 0x0400A72C RID: 42796
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0;
		}
	}
}
