using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x0200036E RID: 878
	public class DaySceneDecorationPannel : UIPanel
	{
		// Token: 0x06006862 RID: 26722 RVA: 0x001FAD9C File Offset: 0x001F8F9C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneDecorationPannel()
		{
			Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DaySceneDecorationPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr);
			DaySceneDecorationPannel.NativeFieldInfoPtr_itemElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "itemElement");
			DaySceneDecorationPannel.NativeFieldInfoPtr_itemDescrierCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "itemDescrierCluster");
			DaySceneDecorationPannel.NativeFieldInfoPtr_itemPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "itemPannel");
			DaySceneDecorationPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "scroller");
			DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "m_DecorationList");
			DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "m_DecorationGroup");
			DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685036);
			DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685037);
			DaySceneDecorationPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685038);
			DaySceneDecorationPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685039);
			DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685040);
			DaySceneDecorationPannel.NativeMethodInfoPtr_DescribeDecorations_Private_Void_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685041);
			DaySceneDecorationPannel.NativeMethodInfoPtr_DescribeNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685042);
			DaySceneDecorationPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685043);
			DaySceneDecorationPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, 100685044);
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x001FAEF8 File Offset: 0x001F90F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x001FAF34 File Offset: 0x001F9134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267666, XrefRangeEnd = 267725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x001FAF70 File Offset: 0x001F9170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267725, XrefRangeEnd = 267748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(Decoration decorationInfo, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(decorationInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x001FAFD8 File Offset: 0x001F91D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267748, XrefRangeEnd = 267763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(Decoration decorationInfo, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(decorationInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x001FB040 File Offset: 0x001F9240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267763, XrefRangeEnd = 267778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDecorationPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x001FB07C File Offset: 0x001F927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267778, XrefRangeEnd = 267779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeDecorations(Decoration decoration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(decoration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.NativeMethodInfoPtr_DescribeDecorations_Private_Void_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x001FB0C0 File Offset: 0x001F92C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267779, XrefRangeEnd = 267780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.NativeMethodInfoPtr_DescribeNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001FB0F4 File Offset: 0x001F92F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267780, XrefRangeEnd = 267789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneDecorationPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001FB130 File Offset: 0x001F9330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267789, XrefRangeEnd = 267798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneDecorationPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x000386F2 File Offset: 0x000368F2
		public DaySceneDecorationPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x001FB16C File Offset: 0x001F936C
		// (set) Token: 0x0600686E RID: 26734 RVA: 0x000386FB File Offset: 0x000368FB
		public unsafe GameObject itemElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x001FB19C File Offset: 0x001F939C
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x0003871A File Offset: 0x0003691A
		public unsafe UIElementCluster itemDescrierCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemDescrierCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemDescrierCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x001FB1CC File Offset: 0x001F93CC
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x00038739 File Offset: 0x00036939
		public unsafe GridLayoutGroup itemPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_itemPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x001FB1FC File Offset: 0x001F93FC
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x00038758 File Offset: 0x00036958
		public unsafe AdpProgressIndicatorComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x001FB22C File Offset: 0x001F942C
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x00038777 File Offset: 0x00036977
		public unsafe List<Decoration> m_DecorationList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Decoration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06006877 RID: 26743 RVA: 0x001FB25C File Offset: 0x001F945C
		// (set) Token: 0x06006878 RID: 26744 RVA: 0x00038796 File Offset: 0x00036996
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Decoration, UIElementCluster, UIButtonSimple> m_DecorationGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Decoration, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.NativeFieldInfoPtr_m_DecorationGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004537 RID: 17719
		private static readonly IntPtr NativeFieldInfoPtr_itemElement;

		// Token: 0x04004538 RID: 17720
		private static readonly IntPtr NativeFieldInfoPtr_itemDescrierCluster;

		// Token: 0x04004539 RID: 17721
		private static readonly IntPtr NativeFieldInfoPtr_itemPannel;

		// Token: 0x0400453A RID: 17722
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x0400453B RID: 17723
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationList;

		// Token: 0x0400453C RID: 17724
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationGroup;

		// Token: 0x0400453D RID: 17725
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400453E RID: 17726
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400453F RID: 17727
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004540 RID: 17728
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_Decoration_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004541 RID: 17729
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004542 RID: 17730
		private static readonly IntPtr NativeMethodInfoPtr_DescribeDecorations_Private_Void_Decoration_0;

		// Token: 0x04004543 RID: 17731
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Private_Void_0;

		// Token: 0x04004544 RID: 17732
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004545 RID: 17733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E79 RID: 3705
		[ObfuscatedName("Common.UI.DaySceneDecorationPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010764 RID: 67428 RVA: 0x003D202C File Offset: 0x003D022C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr);
				DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr, "<>9");
				DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr, "<>9__7_0");
				DaySceneDecorationPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr, 100685046);
				DaySceneDecorationPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__7_0_Internal_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr, 100685047);
			}

			// Token: 0x06010765 RID: 67429 RVA: 0x003D20A8 File Offset: 0x003D02A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDecorationPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010766 RID: 67430 RVA: 0x003D20E4 File Offset: 0x003D02E4
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__7_0(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__7_0_Internal_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010767 RID: 67431 RVA: 0x0008FA34 File Offset: 0x0008DC34
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055F8 RID: 22008
			// (get) Token: 0x06010768 RID: 67432 RVA: 0x003D2134 File Offset: 0x003D0334
			// (set) Token: 0x06010769 RID: 67433 RVA: 0x0008FA3D File Offset: 0x0008DC3D
			public unsafe static DaySceneDecorationPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDecorationPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055F9 RID: 22009
			// (get) Token: 0x0601076A RID: 67434 RVA: 0x003D215C File Offset: 0x003D035C
			// (set) Token: 0x0601076B RID: 67435 RVA: 0x0008FA4F File Offset: 0x0008DC4F
			public unsafe static Func<Decoration, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDecorationPannel.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6B6 RID: 42678
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A6B7 RID: 42679
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400A6B8 RID: 42680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6B9 RID: 42681
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_0_Internal_Int32_Decoration_0;
		}

		// Token: 0x02000E7A RID: 3706
		[ObfuscatedName("Common.UI.DaySceneDecorationPannel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0601076C RID: 67436 RVA: 0x003D2184 File Offset: 0x003D0384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr);
				DaySceneDecorationPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_decorationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr, "decorationInfo");
				DaySceneDecorationPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr, 100685048);
				DaySceneDecorationPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr, 100685049);
			}

			// Token: 0x0601076D RID: 67437 RVA: 0x003D21EC File Offset: 0x003D03EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601076E RID: 67438 RVA: 0x003D2228 File Offset: 0x003D0428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601076F RID: 67439 RVA: 0x0008FA61 File Offset: 0x0008DC61
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055FA RID: 22010
			// (get) Token: 0x06010770 RID: 67440 RVA: 0x003D226C File Offset: 0x003D046C
			// (set) Token: 0x06010771 RID: 67441 RVA: 0x0008FA6A File Offset: 0x0008DC6A
			public unsafe Decoration decorationInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_decorationInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass8_0.NativeFieldInfoPtr_decorationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6BA RID: 42682
			private static readonly IntPtr NativeFieldInfoPtr_decorationInfo;

			// Token: 0x0400A6BB RID: 42683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6BC RID: 42684
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;
		}

		// Token: 0x02000E7B RID: 3707
		[ObfuscatedName("Common.UI.DaySceneDecorationPannel+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x06010772 RID: 67442 RVA: 0x003D229C File Offset: 0x003D049C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDecorationPannel>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr);
				DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr_decorationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr, "decorationInfo");
				DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DaySceneDecorationPannel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr, 100685050);
				DaySceneDecorationPannel.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr, 100685051);
			}

			// Token: 0x06010773 RID: 67443 RVA: 0x003D2318 File Offset: 0x003D0518
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDecorationPannel.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010774 RID: 67444 RVA: 0x003D2354 File Offset: 0x003D0554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267568, XrefRangeEnd = 267666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010775 RID: 67445 RVA: 0x0008FA89 File Offset: 0x0008DC89
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170055FB RID: 22011
			// (get) Token: 0x06010776 RID: 67446 RVA: 0x003D2388 File Offset: 0x003D0588
			// (set) Token: 0x06010777 RID: 67447 RVA: 0x0008FA92 File Offset: 0x0008DC92
			public unsafe Decoration decorationInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr_decorationInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr_decorationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170055FC RID: 22012
			// (get) Token: 0x06010778 RID: 67448 RVA: 0x003D23B8 File Offset: 0x003D05B8
			// (set) Token: 0x06010779 RID: 67449 RVA: 0x0008FAB1 File Offset: 0x0008DCB1
			public unsafe DaySceneDecorationPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDecorationPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDecorationPannel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6BD RID: 42685
			private static readonly IntPtr NativeFieldInfoPtr_decorationInfo;

			// Token: 0x0400A6BE RID: 42686
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6BF RID: 42687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6C0 RID: 42688
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
