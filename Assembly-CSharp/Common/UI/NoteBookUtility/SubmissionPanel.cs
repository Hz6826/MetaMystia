using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x020003A3 RID: 931
	public class SubmissionPanel : UIPanelParamOpen<SubmissionPanel.OpenContext>
	{
		// Token: 0x060070C1 RID: 28865 RVA: 0x00215AD4 File Offset: 0x00213CD4
		// Note: this type is marked as 'beforefieldinit'.
		static SubmissionPanel()
		{
			Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "SubmissionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr);
			SubmissionPanel.NativeFieldInfoPtr_SellableDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "SellableDescriber");
			SubmissionPanel.NativeFieldInfoPtr_Detail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "Detail");
			SubmissionPanel.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "Null");
			SubmissionPanel.NativeFieldInfoPtr_SubmitAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "SubmitAmount");
			SubmissionPanel.NativeFieldInfoPtr_ObjectStackedParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "ObjectStackedParent");
			SubmissionPanel.NativeFieldInfoPtr_InventoryTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "InventoryTransform");
			SubmissionPanel.NativeFieldInfoPtr_SelectedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "SelectedTransform");
			SubmissionPanel.NativeFieldInfoPtr_allInventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "allInventoryInstances");
			SubmissionPanel.NativeFieldInfoPtr_allSelectedInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "allSelectedInstances");
			SubmissionPanel.NativeFieldInfoPtr_m_InventoryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "m_InventoryGroup");
			SubmissionPanel.NativeFieldInfoPtr_m_SelectAllAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "m_SelectAllAction");
			SubmissionPanel.NativeFieldInfoPtr_m_SelectedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "m_SelectedGroup");
			SubmissionPanel.NativeMethodInfoPtr_get_Max_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686293);
			SubmissionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686294);
			SubmissionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686295);
			SubmissionPanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686296);
			SubmissionPanel.NativeMethodInfoPtr_OnInventoryElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686297);
			SubmissionPanel.NativeMethodInfoPtr_OnSelectedElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686298);
			SubmissionPanel.NativeMethodInfoPtr_CheckEnterGroupSilent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686299);
			SubmissionPanel.NativeMethodInfoPtr_TryEnterInventoryGroup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686300);
			SubmissionPanel.NativeMethodInfoPtr_TryEnterSelectedGroup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686301);
			SubmissionPanel.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686302);
			SubmissionPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686303);
			SubmissionPanel.NativeMethodInfoPtr_OnSelectAll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686304);
			SubmissionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686305);
			SubmissionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686306);
			SubmissionPanel.NativeMethodInfoPtr__UpdateElements_b__23_1_Private_KeyValuePair_2_NonTradableObjectBase_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, 100686307);
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x060070C2 RID: 28866 RVA: 0x00215D20 File Offset: 0x00213F20
		public unsafe int Max
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281546, XrefRangeEnd = 281547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_get_Max_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x00215D5C File Offset: 0x00213F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281547, XrefRangeEnd = 281610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmissionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00215D98 File Offset: 0x00213F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281610, XrefRangeEnd = 281617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(SubmissionPanel.OpenContext param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(param));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmissionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x00215DEC File Offset: 0x00213FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281617, XrefRangeEnd = 281648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00215E58 File Offset: 0x00214058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281648, XrefRangeEnd = 281676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInventoryElementSelected(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_OnInventoryElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x00215EC4 File Offset: 0x002140C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281676, XrefRangeEnd = 281698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectedElementSelected(KeyValuePair<NonTradableObjectBase, int> product, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_OnSelectedElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x00215F30 File Offset: 0x00214130
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 281704, RefRangeEnd = 281709, XrefRangeStart = 281698, XrefRangeEnd = 281704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnterGroupSilent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_CheckEnterGroupSilent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x00215F64 File Offset: 0x00214164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281715, RefRangeEnd = 281716, XrefRangeStart = 281709, XrefRangeEnd = 281715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEnterInventoryGroup(bool shouldEnterFirst = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldEnterFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_TryEnterInventoryGroup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x00215FA4 File Offset: 0x002141A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281722, RefRangeEnd = 281723, XrefRangeStart = 281716, XrefRangeEnd = 281722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEnterSelectedGroup(bool shouldEnterFirst = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldEnterFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_TryEnterSelectedGroup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x00215FE4 File Offset: 0x002141E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 281773, RefRangeEnd = 281778, XrefRangeStart = 281723, XrefRangeEnd = 281773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x00216018 File Offset: 0x00214218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281778, XrefRangeEnd = 281785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmissionPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x00216054 File Offset: 0x00214254
		[CallerCount(0)]
		public unsafe void OnSelectAll(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr_OnSelectAll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x0021609C File Offset: 0x0021429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281785, XrefRangeEnd = 281801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubmissionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x002160D8 File Offset: 0x002142D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281801, XrefRangeEnd = 281817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmissionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x00216114 File Offset: 0x00214314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281817, XrefRangeEnd = 281827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<NonTradableObjectBase, int> _UpdateElements_b__23_1(IGrouping<int, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.NativeMethodInfoPtr__UpdateElements_b__23_1_Private_KeyValuePair_2_NonTradableObjectBase_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new KeyValuePair<NonTradableObjectBase, int>(pointer);
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x0003D432 File Offset: 0x0003B632
		public SubmissionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x060070D2 RID: 28882 RVA: 0x0021615C File Offset: 0x0021435C
		// (set) Token: 0x060070D3 RID: 28883 RVA: 0x0003D43B File Offset: 0x0003B63B
		public unsafe SellableDescriber SellableDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SellableDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SellableDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x060070D4 RID: 28884 RVA: 0x0021618C File Offset: 0x0021438C
		// (set) Token: 0x060070D5 RID: 28885 RVA: 0x0003D45A File Offset: 0x0003B65A
		public unsafe GameObject Detail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_Detail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_Detail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x060070D6 RID: 28886 RVA: 0x002161BC File Offset: 0x002143BC
		// (set) Token: 0x060070D7 RID: 28887 RVA: 0x0003D479 File Offset: 0x0003B679
		public unsafe GameObject Null
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_Null);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_Null), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x060070D8 RID: 28888 RVA: 0x002161EC File Offset: 0x002143EC
		// (set) Token: 0x060070D9 RID: 28889 RVA: 0x0003D498 File Offset: 0x0003B698
		public unsafe TextMeshProUGUI SubmitAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SubmitAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SubmitAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x060070DA RID: 28890 RVA: 0x0021621C File Offset: 0x0021441C
		// (set) Token: 0x060070DB RID: 28891 RVA: 0x0003D4B7 File Offset: 0x0003B6B7
		public unsafe GameObject ObjectStackedParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_ObjectStackedParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_ObjectStackedParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x060070DC RID: 28892 RVA: 0x0021624C File Offset: 0x0021444C
		// (set) Token: 0x060070DD RID: 28893 RVA: 0x0003D4D6 File Offset: 0x0003B6D6
		public unsafe GridLayoutGroup InventoryTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_InventoryTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_InventoryTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x060070DE RID: 28894 RVA: 0x0021627C File Offset: 0x0021447C
		// (set) Token: 0x060070DF RID: 28895 RVA: 0x0003D4F5 File Offset: 0x0003B6F5
		public unsafe GridLayoutGroup SelectedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SelectedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_SelectedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x060070E0 RID: 28896 RVA: 0x002162AC File Offset: 0x002144AC
		// (set) Token: 0x060070E1 RID: 28897 RVA: 0x0003D514 File Offset: 0x0003B714
		public unsafe List<KeyValuePair<NonTradableObjectBase, int>> allInventoryInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_allInventoryInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<NonTradableObjectBase, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_allInventoryInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x060070E2 RID: 28898 RVA: 0x002162DC File Offset: 0x002144DC
		// (set) Token: 0x060070E3 RID: 28899 RVA: 0x0003D533 File Offset: 0x0003B733
		public unsafe List<KeyValuePair<NonTradableObjectBase, int>> allSelectedInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_allSelectedInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<NonTradableObjectBase, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_allSelectedInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x060070E4 RID: 28900 RVA: 0x0021630C File Offset: 0x0021450C
		// (set) Token: 0x060070E5 RID: 28901 RVA: 0x0003D552 File Offset: 0x0003B752
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple> m_InventoryGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_InventoryGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_InventoryGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x0021633C File Offset: 0x0021453C
		// (set) Token: 0x060070E7 RID: 28903 RVA: 0x0003D571 File Offset: 0x0003B771
		public unsafe Action m_SelectAllAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_SelectAllAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_SelectAllAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x0021636C File Offset: 0x0021456C
		// (set) Token: 0x060070E9 RID: 28905 RVA: 0x0003D590 File Offset: 0x0003B790
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple> m_SelectedGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_SelectedGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<NonTradableObjectBase, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.NativeFieldInfoPtr_m_SelectedGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AAA RID: 19114
		private static readonly IntPtr NativeFieldInfoPtr_SellableDescriber;

		// Token: 0x04004AAB RID: 19115
		private static readonly IntPtr NativeFieldInfoPtr_Detail;

		// Token: 0x04004AAC RID: 19116
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04004AAD RID: 19117
		private static readonly IntPtr NativeFieldInfoPtr_SubmitAmount;

		// Token: 0x04004AAE RID: 19118
		private static readonly IntPtr NativeFieldInfoPtr_ObjectStackedParent;

		// Token: 0x04004AAF RID: 19119
		private static readonly IntPtr NativeFieldInfoPtr_InventoryTransform;

		// Token: 0x04004AB0 RID: 19120
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTransform;

		// Token: 0x04004AB1 RID: 19121
		private static readonly IntPtr NativeFieldInfoPtr_allInventoryInstances;

		// Token: 0x04004AB2 RID: 19122
		private static readonly IntPtr NativeFieldInfoPtr_allSelectedInstances;

		// Token: 0x04004AB3 RID: 19123
		private static readonly IntPtr NativeFieldInfoPtr_m_InventoryGroup;

		// Token: 0x04004AB4 RID: 19124
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectAllAction;

		// Token: 0x04004AB5 RID: 19125
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedGroup;

		// Token: 0x04004AB6 RID: 19126
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Private_get_Int32_0;

		// Token: 0x04004AB7 RID: 19127
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004AB8 RID: 19128
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004AB9 RID: 19129
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004ABA RID: 19130
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004ABB RID: 19131
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectedElementSelected_Private_Void_KeyValuePair_2_NonTradableObjectBase_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004ABC RID: 19132
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnterGroupSilent_Private_Void_0;

		// Token: 0x04004ABD RID: 19133
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterInventoryGroup_Private_Void_Boolean_0;

		// Token: 0x04004ABE RID: 19134
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterSelectedGroup_Private_Void_Boolean_0;

		// Token: 0x04004ABF RID: 19135
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04004AC0 RID: 19136
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004AC1 RID: 19137
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAll_Private_Void_CallbackContext_0;

		// Token: 0x04004AC2 RID: 19138
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004AC3 RID: 19139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004AC4 RID: 19140
		private static readonly IntPtr NativeMethodInfoPtr__UpdateElements_b__23_1_Private_KeyValuePair_2_NonTradableObjectBase_Int32_IGrouping_2_Int32_Int32_0;

		// Token: 0x02000EF9 RID: 3833
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06010D9D RID: 69021 RVA: 0x003E51D8 File Offset: 0x003E33D8
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr);
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_OnDescribeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "OnDescribeObjectCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetElementCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "GetElementCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageInCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "StorageInCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageOutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "StorageOutCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_IdToObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "IdToObjectCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetObjectAmountCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "GetObjectAmountCallback");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_SelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "SelectedObjects");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_UpdateExternalVisualHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "UpdateExternalVisualHandle");
				SubmissionPanel.OpenContext.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, "Max");
				SubmissionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Action_2_SellableDescriber_NonTradableObjectBase_Func_1_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_NonTradableObjectBase_Func_2_Int32_Int32_IList_1_Int32_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr, 100686308);
			}

			// Token: 0x06010D9E RID: 69022 RVA: 0x003E52CC File Offset: 0x003E34CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 281480, RefRangeEnd = 281482, XrefRangeStart = 281472, XrefRangeEnd = 281480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Action<SellableDescriber, NonTradableObjectBase> onDescribeObjectCallback, Func<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>> getElementCallback, Action<IEnumerable<int>, bool> storageInCallback, Action<int, bool> storageOutCallback, Func<int, NonTradableObjectBase> idToObjectCallback, Func<int, int> getObjectAmountCallback, IList<int> selectedObjects, Action updateExternalVisualHandle, int max) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDescribeObjectCallback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getElementCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageInCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageOutCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(idToObjectCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getObjectAmountCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedObjects);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateExternalVisualHandle);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Action_2_SellableDescriber_NonTradableObjectBase_Func_1_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_NonTradableObjectBase_Func_2_Int32_Int32_IList_1_Int32_Action_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D9F RID: 69023 RVA: 0x00092CA1 File Offset: 0x00090EA1
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010DA0 RID: 69024 RVA: 0x00092CAA File Offset: 0x00090EAA
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170057BE RID: 22462
			// (get) Token: 0x06010DA1 RID: 69025 RVA: 0x003E53B0 File Offset: 0x003E35B0
			// (set) Token: 0x06010DA2 RID: 69026 RVA: 0x00092CBC File Offset: 0x00090EBC
			public unsafe Action<SellableDescriber, NonTradableObjectBase> OnDescribeObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_OnDescribeObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SellableDescriber, NonTradableObjectBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_OnDescribeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057BF RID: 22463
			// (get) Token: 0x06010DA3 RID: 69027 RVA: 0x003E53E0 File Offset: 0x003E35E0
			// (set) Token: 0x06010DA4 RID: 69028 RVA: 0x00092CDB File Offset: 0x00090EDB
			public unsafe Func<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>> GetElementCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetElementCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<KeyValuePair<NonTradableObjectBase, int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetElementCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C0 RID: 22464
			// (get) Token: 0x06010DA5 RID: 69029 RVA: 0x003E5410 File Offset: 0x003E3610
			// (set) Token: 0x06010DA6 RID: 69030 RVA: 0x00092CFA File Offset: 0x00090EFA
			public unsafe Action<IEnumerable<int>, bool> StorageInCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageInCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageInCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C1 RID: 22465
			// (get) Token: 0x06010DA7 RID: 69031 RVA: 0x003E5440 File Offset: 0x003E3640
			// (set) Token: 0x06010DA8 RID: 69032 RVA: 0x00092D19 File Offset: 0x00090F19
			public unsafe Action<int, bool> StorageOutCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageOutCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_StorageOutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C2 RID: 22466
			// (get) Token: 0x06010DA9 RID: 69033 RVA: 0x003E5470 File Offset: 0x003E3670
			// (set) Token: 0x06010DAA RID: 69034 RVA: 0x00092D38 File Offset: 0x00090F38
			public unsafe Func<int, NonTradableObjectBase> IdToObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_IdToObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, NonTradableObjectBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_IdToObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C3 RID: 22467
			// (get) Token: 0x06010DAB RID: 69035 RVA: 0x003E54A0 File Offset: 0x003E36A0
			// (set) Token: 0x06010DAC RID: 69036 RVA: 0x00092D57 File Offset: 0x00090F57
			public unsafe Func<int, int> GetObjectAmountCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetObjectAmountCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_GetObjectAmountCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C4 RID: 22468
			// (get) Token: 0x06010DAD RID: 69037 RVA: 0x003E54D0 File Offset: 0x003E36D0
			// (set) Token: 0x06010DAE RID: 69038 RVA: 0x00092D76 File Offset: 0x00090F76
			public unsafe IList<int> SelectedObjects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_SelectedObjects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_SelectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C5 RID: 22469
			// (get) Token: 0x06010DAF RID: 69039 RVA: 0x003E5500 File Offset: 0x003E3700
			// (set) Token: 0x06010DB0 RID: 69040 RVA: 0x00092D95 File Offset: 0x00090F95
			public unsafe Action UpdateExternalVisualHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_UpdateExternalVisualHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_UpdateExternalVisualHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057C6 RID: 22470
			// (get) Token: 0x06010DB1 RID: 69041 RVA: 0x003E5530 File Offset: 0x003E3730
			// (set) Token: 0x06010DB2 RID: 69042 RVA: 0x00092DB4 File Offset: 0x00090FB4
			public unsafe int Max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_Max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.OpenContext.NativeFieldInfoPtr_Max)) = value;
				}
			}

			// Token: 0x0400AA84 RID: 43652
			private static readonly IntPtr NativeFieldInfoPtr_OnDescribeObjectCallback;

			// Token: 0x0400AA85 RID: 43653
			private static readonly IntPtr NativeFieldInfoPtr_GetElementCallback;

			// Token: 0x0400AA86 RID: 43654
			private static readonly IntPtr NativeFieldInfoPtr_StorageInCallback;

			// Token: 0x0400AA87 RID: 43655
			private static readonly IntPtr NativeFieldInfoPtr_StorageOutCallback;

			// Token: 0x0400AA88 RID: 43656
			private static readonly IntPtr NativeFieldInfoPtr_IdToObjectCallback;

			// Token: 0x0400AA89 RID: 43657
			private static readonly IntPtr NativeFieldInfoPtr_GetObjectAmountCallback;

			// Token: 0x0400AA8A RID: 43658
			private static readonly IntPtr NativeFieldInfoPtr_SelectedObjects;

			// Token: 0x0400AA8B RID: 43659
			private static readonly IntPtr NativeFieldInfoPtr_UpdateExternalVisualHandle;

			// Token: 0x0400AA8C RID: 43660
			private static readonly IntPtr NativeFieldInfoPtr_Max;

			// Token: 0x0400AA8D RID: 43661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_2_SellableDescriber_NonTradableObjectBase_Func_1_IEnumerable_1_KeyValuePair_2_NonTradableObjectBase_Int32_Action_2_IEnumerable_1_Int32_Boolean_Action_2_Int32_Boolean_Func_2_Int32_NonTradableObjectBase_Func_2_Int32_Int32_IList_1_Int32_Action_Int32_0;
		}

		// Token: 0x02000EFA RID: 3834
		[ObfuscatedName("Common.UI.NoteBookUtility.SubmissionPanel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x06010DB3 RID: 69043 RVA: 0x003E5558 File Offset: 0x003E3758
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr);
				SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, "product");
				SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_productAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, "productAmountText");
				SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, 100686309);
				SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, 100686310);
				SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, 100686311);
				SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr, 100686312);
			}

			// Token: 0x06010DB4 RID: 69044 RVA: 0x003E55FC File Offset: 0x003E37FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DB5 RID: 69045 RVA: 0x003E5638 File Offset: 0x003E3838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281482, XrefRangeEnd = 281486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DB6 RID: 69046 RVA: 0x003E567C File Offset: 0x003E387C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DB7 RID: 69047 RVA: 0x003E56C0 File Offset: 0x003E38C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DB8 RID: 69048 RVA: 0x00092DCF File Offset: 0x00090FCF
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057C7 RID: 22471
			// (get) Token: 0x06010DB9 RID: 69049 RVA: 0x003E5704 File Offset: 0x003E3904
			// (set) Token: 0x06010DBA RID: 69050 RVA: 0x00092DD8 File Offset: 0x00090FD8
			public KeyValuePair<NonTradableObjectBase, int> product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_product);
					return new KeyValuePair<NonTradableObjectBase, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170057C8 RID: 22472
			// (get) Token: 0x06010DBB RID: 69051 RVA: 0x003E5734 File Offset: 0x003E3934
			// (set) Token: 0x06010DBC RID: 69052 RVA: 0x00092E06 File Offset: 0x00091006
			public unsafe string productAmountText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_productAmountText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass17_0.NativeFieldInfoPtr_productAmountText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400AA8E RID: 43662
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400AA8F RID: 43663
			private static readonly IntPtr NativeFieldInfoPtr_productAmountText;

			// Token: 0x0400AA90 RID: 43664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA91 RID: 43665
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;

			// Token: 0x0400AA92 RID: 43666
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA93 RID: 43667
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EFB RID: 3835
		[ObfuscatedName("Common.UI.NoteBookUtility.SubmissionPanel+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x06010DBD RID: 69053 RVA: 0x003E575C File Offset: 0x003E395C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr);
				SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_thisProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr, "thisProduct");
				SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr, 100686313);
				SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__OnInventoryElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr, 100686314);
				SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__OnInventoryElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr, 100686315);
			}

			// Token: 0x06010DBE RID: 69054 RVA: 0x003E57EC File Offset: 0x003E39EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DBF RID: 69055 RVA: 0x003E5828 File Offset: 0x003E3A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281486, XrefRangeEnd = 281502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInventoryElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__OnInventoryElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DC0 RID: 69056 RVA: 0x003E585C File Offset: 0x003E3A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281502, XrefRangeEnd = 281509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInventoryElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__OnInventoryElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DC1 RID: 69057 RVA: 0x00092E25 File Offset: 0x00091025
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057C9 RID: 22473
			// (get) Token: 0x06010DC2 RID: 69058 RVA: 0x003E5890 File Offset: 0x003E3A90
			// (set) Token: 0x06010DC3 RID: 69059 RVA: 0x00092E2E File Offset: 0x0009102E
			public unsafe SubmissionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057CA RID: 22474
			// (get) Token: 0x06010DC4 RID: 69060 RVA: 0x003E58C0 File Offset: 0x003E3AC0
			// (set) Token: 0x06010DC5 RID: 69061 RVA: 0x00092E4D File Offset: 0x0009104D
			public KeyValuePair<NonTradableObjectBase, int> thisProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_thisProduct);
					return new KeyValuePair<NonTradableObjectBase, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_thisProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AA94 RID: 43668
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA95 RID: 43669
			private static readonly IntPtr NativeFieldInfoPtr_thisProduct;

			// Token: 0x0400AA96 RID: 43670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA97 RID: 43671
			private static readonly IntPtr NativeMethodInfoPtr__OnInventoryElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400AA98 RID: 43672
			private static readonly IntPtr NativeMethodInfoPtr__OnInventoryElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x02000EFC RID: 3836
		[ObfuscatedName("Common.UI.NoteBookUtility.SubmissionPanel+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x06010DC6 RID: 69062 RVA: 0x003E58F0 File Offset: 0x003E3AF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr);
				SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_thisProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr, "thisProduct");
				SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr, 100686316);
				SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnSelectedElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr, 100686317);
				SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnSelectedElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr, 100686318);
			}

			// Token: 0x06010DC7 RID: 69063 RVA: 0x003E5980 File Offset: 0x003E3B80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DC8 RID: 69064 RVA: 0x003E59BC File Offset: 0x003E3BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281509, XrefRangeEnd = 281535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSelectedElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnSelectedElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DC9 RID: 69065 RVA: 0x003E59F0 File Offset: 0x003E3BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281535, XrefRangeEnd = 281546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSelectedElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__OnSelectedElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DCA RID: 69066 RVA: 0x00092E7B File Offset: 0x0009107B
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057CB RID: 22475
			// (get) Token: 0x06010DCB RID: 69067 RVA: 0x003E5A24 File Offset: 0x003E3C24
			// (set) Token: 0x06010DCC RID: 69068 RVA: 0x00092E84 File Offset: 0x00091084
			public KeyValuePair<NonTradableObjectBase, int> thisProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_thisProduct);
					return new KeyValuePair<NonTradableObjectBase, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_thisProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<NonTradableObjectBase, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170057CC RID: 22476
			// (get) Token: 0x06010DCD RID: 69069 RVA: 0x003E5A54 File Offset: 0x003E3C54
			// (set) Token: 0x06010DCE RID: 69070 RVA: 0x00092EB2 File Offset: 0x000910B2
			public unsafe SubmissionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubmissionPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA99 RID: 43673
			private static readonly IntPtr NativeFieldInfoPtr_thisProduct;

			// Token: 0x0400AA9A RID: 43674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA9B RID: 43675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA9C RID: 43676
			private static readonly IntPtr NativeMethodInfoPtr__OnSelectedElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400AA9D RID: 43677
			private static readonly IntPtr NativeMethodInfoPtr__OnSelectedElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x02000EFD RID: 3837
		[ObfuscatedName("Common.UI.NoteBookUtility.SubmissionPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010DCF RID: 69071 RVA: 0x003E5A84 File Offset: 0x003E3C84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmissionPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr);
				SubmissionPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr, "<>9");
				SubmissionPanel.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr, "<>9__23_0");
				SubmissionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr, 100686320);
				SubmissionPanel.__c.NativeMethodInfoPtr__UpdateElements_b__23_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr, 100686321);
			}

			// Token: 0x06010DD0 RID: 69072 RVA: 0x003E5B00 File Offset: 0x003E3D00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmissionPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DD1 RID: 69073 RVA: 0x003E5B3C File Offset: 0x003E3D3C
			[CallerCount(0)]
			public unsafe int _UpdateElements_b__23_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmissionPanel.__c.NativeMethodInfoPtr__UpdateElements_b__23_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010DD2 RID: 69074 RVA: 0x00092ED1 File Offset: 0x000910D1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057CD RID: 22477
			// (get) Token: 0x06010DD3 RID: 69075 RVA: 0x003E5B88 File Offset: 0x003E3D88
			// (set) Token: 0x06010DD4 RID: 69076 RVA: 0x00092EDA File Offset: 0x000910DA
			public unsafe static SubmissionPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubmissionPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubmissionPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubmissionPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057CE RID: 22478
			// (get) Token: 0x06010DD5 RID: 69077 RVA: 0x003E5BB0 File Offset: 0x003E3DB0
			// (set) Token: 0x06010DD6 RID: 69078 RVA: 0x00092EEC File Offset: 0x000910EC
			public unsafe static Func<int, int> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubmissionPanel.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubmissionPanel.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA9E RID: 43678
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA9F RID: 43679
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x0400AAA0 RID: 43680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAA1 RID: 43681
			private static readonly IntPtr NativeMethodInfoPtr__UpdateElements_b__23_0_Internal_Int32_Int32_0;
		}
	}
}
