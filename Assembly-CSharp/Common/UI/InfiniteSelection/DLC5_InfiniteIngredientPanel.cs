using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x020003C9 RID: 969
	public class DLC5_InfiniteIngredientPanel : UIPanelParam<DLC5_InfiniteIngredientPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x06007361 RID: 29537 RVA: 0x0021F540 File Offset: 0x0021D740
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_InfiniteIngredientPanel()
		{
			Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.InfiniteSelection", "DLC5_InfiniteIngredientPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr);
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_ItemPrefab");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_ItemField");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ProgressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_ProgressIndicator");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_NullElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_NullElement");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_Describer");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_Grid");
			DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Backing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "m_Backing");
			DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, 100687022);
			DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, 100687023);
			DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, 100687024);
			DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, 100687025);
			DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, 100687026);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x0021F660 File Offset: 0x0021D860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287583, XrefRangeEnd = 287639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x0021F69C File Offset: 0x0021D89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287639, XrefRangeEnd = 287668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_InfiniteIngredientPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x0021F6F0 File Offset: 0x0021D8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287668, XrefRangeEnd = 287672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose(Nullable<int> closeParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(closeParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x0021F744 File Offset: 0x0021D944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287672, XrefRangeEnd = 287682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x0021F780 File Offset: 0x0021D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287682, XrefRangeEnd = 287693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_InfiniteIngredientPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x0003E5C1 File Offset: 0x0003C7C1
		public DLC5_InfiniteIngredientPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06007368 RID: 29544 RVA: 0x0021F7BC File Offset: 0x0021D9BC
		// (set) Token: 0x06007369 RID: 29545 RVA: 0x0003E5CA File Offset: 0x0003C7CA
		public unsafe GameObject m_ItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600736A RID: 29546 RVA: 0x0021F7EC File Offset: 0x0021D9EC
		// (set) Token: 0x0600736B RID: 29547 RVA: 0x0003E5E9 File Offset: 0x0003C7E9
		public unsafe GridLayoutGroup m_ItemField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ItemField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x0021F81C File Offset: 0x0021DA1C
		// (set) Token: 0x0600736D RID: 29549 RVA: 0x0003E608 File Offset: 0x0003C808
		public unsafe AdpProgressIndicatorComponent m_ProgressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ProgressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_ProgressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600736E RID: 29550 RVA: 0x0021F84C File Offset: 0x0021DA4C
		// (set) Token: 0x0600736F RID: 29551 RVA: 0x0003E627 File Offset: 0x0003C827
		public unsafe Sprite m_NullElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_NullElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_NullElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x0021F87C File Offset: 0x0021DA7C
		// (set) Token: 0x06007371 RID: 29553 RVA: 0x0003E646 File Offset: 0x0003C846
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06007372 RID: 29554 RVA: 0x0021F8AC File Offset: 0x0021DAAC
		// (set) Token: 0x06007373 RID: 29555 RVA: 0x0003E665 File Offset: 0x0003C865
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Nullable<int>, UIElementCluster, UIButtonSimple> m_Grid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Grid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Nullable<int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Grid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06007374 RID: 29556 RVA: 0x0021F8DC File Offset: 0x0021DADC
		// (set) Token: 0x06007375 RID: 29557 RVA: 0x0003E684 File Offset: 0x0003C884
		public unsafe List<Nullable<int>> m_Backing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Backing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.NativeFieldInfoPtr_m_Backing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C7E RID: 19582
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemPrefab;

		// Token: 0x04004C7F RID: 19583
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemField;

		// Token: 0x04004C80 RID: 19584
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressIndicator;

		// Token: 0x04004C81 RID: 19585
		private static readonly IntPtr NativeFieldInfoPtr_m_NullElement;

		// Token: 0x04004C82 RID: 19586
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x04004C83 RID: 19587
		private static readonly IntPtr NativeFieldInfoPtr_m_Grid;

		// Token: 0x04004C84 RID: 19588
		private static readonly IntPtr NativeFieldInfoPtr_m_Backing;

		// Token: 0x04004C85 RID: 19589
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C86 RID: 19590
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004C87 RID: 19591
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_Nullable_1_Int32_0;

		// Token: 0x04004C88 RID: 19592
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C89 RID: 19593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F4D RID: 3917
		public sealed class OpenContext : ValueType
		{
			// Token: 0x060110BC RID: 69820 RVA: 0x003EF8E4 File Offset: 0x003EDAE4
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr);
				DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_CurrentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr, "CurrentSelection");
				DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_Selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr, "Selections");
				DLC5_InfiniteIngredientPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr, 100687027);
			}

			// Token: 0x060110BD RID: 69821 RVA: 0x003EF94C File Offset: 0x003EDB4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287525, RefRangeEnd = 287527, XrefRangeStart = 287524, XrefRangeEnd = 287525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Nullable<int> currentSelection, IEnumerable<int> selections) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentSelection));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110BE RID: 69822 RVA: 0x000943AC File Offset: 0x000925AC
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060110BF RID: 69823 RVA: 0x000943B5 File Offset: 0x000925B5
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170058AA RID: 22698
			// (get) Token: 0x060110C0 RID: 69824 RVA: 0x003EF9B4 File Offset: 0x003EDBB4
			// (set) Token: 0x060110C1 RID: 69825 RVA: 0x000943C7 File Offset: 0x000925C7
			public Nullable<int> CurrentSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_CurrentSelection);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_CurrentSelection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058AB RID: 22699
			// (get) Token: 0x060110C2 RID: 69826 RVA: 0x003EF9E4 File Offset: 0x003EDBE4
			// (set) Token: 0x060110C3 RID: 69827 RVA: 0x000943F5 File Offset: 0x000925F5
			public unsafe IEnumerable<int> Selections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_Selections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.OpenContext.NativeFieldInfoPtr_Selections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC7A RID: 44154
			private static readonly IntPtr NativeFieldInfoPtr_CurrentSelection;

			// Token: 0x0400AC7B RID: 44155
			private static readonly IntPtr NativeFieldInfoPtr_Selections;

			// Token: 0x0400AC7C RID: 44156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_IEnumerable_1_Int32_0;
		}

		// Token: 0x02000F4E RID: 3918
		[ObfuscatedName("Common.UI.InfiniteSelection.DLC5_InfiniteIngredientPanel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x060110C4 RID: 69828 RVA: 0x003EFA14 File Offset: 0x003EDC14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, "isValid");
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_tempLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, "tempLang");
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, 100687028);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, 100687029);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, 100687030);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr, 100687031);
			}

			// Token: 0x060110C5 RID: 69829 RVA: 0x003EFACC File Offset: 0x003EDCCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110C6 RID: 69830 RVA: 0x003EFB08 File Offset: 0x003EDD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287527, XrefRangeEnd = 287550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__0(Nullable<int> value, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110C7 RID: 69831 RVA: 0x003EFB74 File Offset: 0x003EDD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287550, XrefRangeEnd = 287571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1(Nullable<int> value, UIElementCluster _, UIButtonSimple btn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110C8 RID: 69832 RVA: 0x003EFBE0 File Offset: 0x003EDDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287571, XrefRangeEnd = 287576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110C9 RID: 69833 RVA: 0x00094414 File Offset: 0x00092614
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058AC RID: 22700
			// (get) Token: 0x060110CA RID: 69834 RVA: 0x003EFC28 File Offset: 0x003EDE28
			// (set) Token: 0x060110CB RID: 69835 RVA: 0x0009441D File Offset: 0x0009261D
			public unsafe DLC5_InfiniteIngredientPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteIngredientPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058AD RID: 22701
			// (get) Token: 0x060110CC RID: 69836 RVA: 0x003EFC58 File Offset: 0x003EDE58
			// (set) Token: 0x060110CD RID: 69837 RVA: 0x0009443C File Offset: 0x0009263C
			public Nullable<bool> isValid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_isValid);
					return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_isValid), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058AE RID: 22702
			// (get) Token: 0x060110CE RID: 69838 RVA: 0x003EFC88 File Offset: 0x003EDE88
			// (set) Token: 0x060110CF RID: 69839 RVA: 0x0009446A File Offset: 0x0009266A
			public unsafe ObjectLanguageBase tempLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_tempLang);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_tempLang), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC7D RID: 44157
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AC7E RID: 44158
			private static readonly IntPtr NativeFieldInfoPtr_isValid;

			// Token: 0x0400AC7F RID: 44159
			private static readonly IntPtr NativeFieldInfoPtr_tempLang;

			// Token: 0x0400AC80 RID: 44160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC81 RID: 44161
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400AC82 RID: 44162
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_Nullable_1_Int32_UIElementCluster_UIButtonSimple_0;

			// Token: 0x0400AC83 RID: 44163
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0;
		}

		// Token: 0x02000F4F RID: 3919
		[ObfuscatedName("Common.UI.InfiniteSelection.DLC5_InfiniteIngredientPanel+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Il2CppSystem.Object
		{
			// Token: 0x060110D0 RID: 69840 RVA: 0x003EFCB8 File Offset: 0x003EDEB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr, "value");
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr, 100687032);
				DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr, 100687033);
			}

			// Token: 0x060110D1 RID: 69841 RVA: 0x003EFD34 File Offset: 0x003EDF34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110D2 RID: 69842 RVA: 0x003EFD70 File Offset: 0x003EDF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287576, XrefRangeEnd = 287580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110D3 RID: 69843 RVA: 0x00094489 File Offset: 0x00092689
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058AF RID: 22703
			// (get) Token: 0x060110D4 RID: 69844 RVA: 0x003EFDA4 File Offset: 0x003EDFA4
			// (set) Token: 0x060110D5 RID: 69845 RVA: 0x00094492 File Offset: 0x00092692
			public Nullable<int> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_value);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058B0 RID: 22704
			// (get) Token: 0x060110D6 RID: 69846 RVA: 0x003EFDD4 File Offset: 0x003EDFD4
			// (set) Token: 0x060110D7 RID: 69847 RVA: 0x000944C0 File Offset: 0x000926C0
			public unsafe DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0 field_Public___c__DisplayClass8_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteIngredientPanel.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteIngredientPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC84 RID: 44164
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400AC85 RID: 44165
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass8_0_0;

			// Token: 0x0400AC86 RID: 44166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC87 RID: 44167
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0;
		}

		// Token: 0x02000F50 RID: 3920
		[ObfuscatedName("Common.UI.InfiniteSelection.DLC5_InfiniteIngredientPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060110D8 RID: 69848 RVA: 0x003EFE04 File Offset: 0x003EE004
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr);
				DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr, "<>9");
				DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr, "<>9__9_0");
				DLC5_InfiniteIngredientPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr, 100687035);
				DLC5_InfiniteIngredientPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__9_0_Internal_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr, 100687036);
			}

			// Token: 0x060110D9 RID: 69849 RVA: 0x003EFE80 File Offset: 0x003EE080
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteIngredientPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110DA RID: 69850 RVA: 0x003EFEBC File Offset: 0x003EE0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287580, XrefRangeEnd = 287583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _OnPanelOpen_b__9_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteIngredientPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__9_0_Internal_Nullable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}

			// Token: 0x060110DB RID: 69851 RVA: 0x000944DF File Offset: 0x000926DF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058B1 RID: 22705
			// (get) Token: 0x060110DC RID: 69852 RVA: 0x003EFF00 File Offset: 0x003EE100
			// (set) Token: 0x060110DD RID: 69853 RVA: 0x000944E8 File Offset: 0x000926E8
			public unsafe static DLC5_InfiniteIngredientPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteIngredientPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058B2 RID: 22706
			// (get) Token: 0x060110DE RID: 69854 RVA: 0x003EFF28 File Offset: 0x003EE128
			// (set) Token: 0x060110DF RID: 69855 RVA: 0x000944FA File Offset: 0x000926FA
			public unsafe static Func<int, Nullable<int>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_InfiniteIngredientPanel.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC88 RID: 44168
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AC89 RID: 44169
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400AC8A RID: 44170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC8B RID: 44171
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_0_Internal_Nullable_1_Int32_Int32_0;
		}
	}
}
