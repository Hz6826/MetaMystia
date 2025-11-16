using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x020003CB RID: 971
	public class DLC5_InfiniteSelectionPanel : UIPanelParamOpen<DLC5_InfiniteSelectionPanel.OpenContext>
	{
		// Token: 0x0600738B RID: 29579 RVA: 0x0021FD28 File Offset: 0x0021DF28
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_InfiniteSelectionPanel()
		{
			Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.InfiniteSelection", "DLC5_InfiniteSelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr);
			DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "m_Drawer1");
			DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "m_Drawer2");
			DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "m_Drawer3");
			DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_SelectionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "m_SelectionPanel");
			DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_IgnoreCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "m_IgnoreCollection");
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687044);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_EditIngredient_Private_UniTaskVoid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687045);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687046);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687047);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687048);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687049);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687050);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687051);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687052);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Method_Internal_Static_IEnumerable_1_Int32_IEnumerable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687053);
			DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_DLC5_InfiniteSelectionDrawer_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, 100687054);
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x0021FE98 File Offset: 0x0021E098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287790, XrefRangeEnd = 287814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x0021FED4 File Offset: 0x0021E0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287814, XrefRangeEnd = 287819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid EditIngredient(int editIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref editIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_EditIngredient_Private_UniTaskVoid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x0021FF20 File Offset: 0x0021E120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287819, XrefRangeEnd = 287832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_InfiniteSelectionPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x0021FF70 File Offset: 0x0021E170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287837, RefRangeEnd = 287839, XrefRangeStart = 287832, XrefRangeEnd = 287837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(bool noAnimation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref noAnimation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0021FFB0 File Offset: 0x0021E1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0021FFEC File Offset: 0x0021E1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287839, XrefRangeEnd = 287849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_InfiniteSelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x00220028 File Offset: 0x0021E228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287849, XrefRangeEnd = 287855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x0022005C File Offset: 0x0021E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287855, XrefRangeEnd = 287861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x00220090 File Offset: 0x0021E290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287861, XrefRangeEnd = 287867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__7_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x002200C4 File Offset: 0x0021E2C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287870, RefRangeEnd = 287873, XrefRangeStart = 287867, XrefRangeEnd = 287870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> Method_Internal_Static_IEnumerable_1_Int32_IEnumerable_1_Int32_Nullable_1_Int32_0(IEnumerable<int> collection, Nullable<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Method_Internal_Static_IEnumerable_1_Int32_IEnumerable_1_Int32_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x00220120 File Offset: 0x0021E320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287873, XrefRangeEnd = 287878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_DLC5_InfiniteSelectionDrawer_Boolean_PDM_0(DLC5_InfiniteSelectionDrawer drawer, bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drawer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_DLC5_InfiniteSelectionDrawer_Boolean_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x0003E766 File Offset: 0x0003C966
		public DLC5_InfiniteSelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x00220164 File Offset: 0x0021E364
		// (set) Token: 0x06007399 RID: 29593 RVA: 0x0003E76F File Offset: 0x0003C96F
		public unsafe DLC5_InfiniteSelectionDrawer m_Drawer1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteSelectionDrawer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600739A RID: 29594 RVA: 0x00220194 File Offset: 0x0021E394
		// (set) Token: 0x0600739B RID: 29595 RVA: 0x0003E78E File Offset: 0x0003C98E
		public unsafe DLC5_InfiniteSelectionDrawer m_Drawer2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteSelectionDrawer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x002201C4 File Offset: 0x0021E3C4
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x0003E7AD File Offset: 0x0003C9AD
		public unsafe DLC5_InfiniteSelectionDrawer m_Drawer3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteSelectionDrawer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_Drawer3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600739E RID: 29598 RVA: 0x002201F4 File Offset: 0x0021E3F4
		// (set) Token: 0x0600739F RID: 29599 RVA: 0x0003E7CC File Offset: 0x0003C9CC
		public unsafe DLC5_InfiniteIngredientPanel m_SelectionPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_SelectionPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteIngredientPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_SelectionPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x060073A0 RID: 29600 RVA: 0x00220224 File Offset: 0x0021E424
		// (set) Token: 0x060073A1 RID: 29601 RVA: 0x0003E7EB File Offset: 0x0003C9EB
		public unsafe Il2CppStructArray<int> m_IgnoreCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_IgnoreCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.NativeFieldInfoPtr_m_IgnoreCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C97 RID: 19607
		private static readonly IntPtr NativeFieldInfoPtr_m_Drawer1;

		// Token: 0x04004C98 RID: 19608
		private static readonly IntPtr NativeFieldInfoPtr_m_Drawer2;

		// Token: 0x04004C99 RID: 19609
		private static readonly IntPtr NativeFieldInfoPtr_m_Drawer3;

		// Token: 0x04004C9A RID: 19610
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionPanel;

		// Token: 0x04004C9B RID: 19611
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreCollection;

		// Token: 0x04004C9C RID: 19612
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C9D RID: 19613
		private static readonly IntPtr NativeMethodInfoPtr_EditIngredient_Private_UniTaskVoid_Int32_0;

		// Token: 0x04004C9E RID: 19614
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04004C9F RID: 19615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_Boolean_0;

		// Token: 0x04004CA0 RID: 19616
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004CA1 RID: 19617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004CA2 RID: 19618
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_0_Private_Void_0;

		// Token: 0x04004CA3 RID: 19619
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_1_Private_Void_0;

		// Token: 0x04004CA4 RID: 19620
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_2_Private_Void_0;

		// Token: 0x04004CA5 RID: 19621
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerable_1_Int32_IEnumerable_1_Int32_Nullable_1_Int32_0;

		// Token: 0x04004CA6 RID: 19622
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_DLC5_InfiniteSelectionDrawer_Boolean_PDM_0;

		// Token: 0x02000F51 RID: 3921
		public enum ActiveCount
		{
			// Token: 0x0400AC8D RID: 44173
			I = 1,
			// Token: 0x0400AC8E RID: 44174
			II,
			// Token: 0x0400AC8F RID: 44175
			III
		}

		// Token: 0x02000F52 RID: 3922
		public class OpenContext : Object
		{
			// Token: 0x060110E0 RID: 69856 RVA: 0x003EFF50 File Offset: 0x003EE150
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, "<Ingredient1>k__BackingField");
				DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, "<Ingredient2>k__BackingField");
				DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient3_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, "<Ingredient3>k__BackingField");
				DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__ActiveCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, "<ActiveCount>k__BackingField");
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient1_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687055);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient1_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687056);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient2_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687057);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient2_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687058);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient3_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687059);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient3_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687060);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_ActiveCount_Public_get_ActiveCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687061);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_ActiveCount_Public_set_Void_ActiveCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687062);
				DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_ActiveCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr, 100687063);
			}

			// Token: 0x170058B7 RID: 22711
			// (get) Token: 0x060110E1 RID: 69857 RVA: 0x003F0080 File Offset: 0x003EE280
			// (set) Token: 0x060110E2 RID: 69858 RVA: 0x003F00B8 File Offset: 0x003EE2B8
			public unsafe Nullable<int> Ingredient1
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient1_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Nullable<int>(pointer);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient1_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170058B8 RID: 22712
			// (get) Token: 0x060110E3 RID: 69859 RVA: 0x003F0100 File Offset: 0x003EE300
			// (set) Token: 0x060110E4 RID: 69860 RVA: 0x003F0138 File Offset: 0x003EE338
			public unsafe Nullable<int> Ingredient2
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient2_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Nullable<int>(pointer);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient2_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170058B9 RID: 22713
			// (get) Token: 0x060110E5 RID: 69861 RVA: 0x003F0180 File Offset: 0x003EE380
			// (set) Token: 0x060110E6 RID: 69862 RVA: 0x003F01B8 File Offset: 0x003EE3B8
			public unsafe Nullable<int> Ingredient3
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_Ingredient3_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Nullable<int>(pointer);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 287704, RefRangeEnd = 287705, XrefRangeStart = 287704, XrefRangeEnd = 287704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_Ingredient3_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170058BA RID: 22714
			// (get) Token: 0x060110E7 RID: 69863 RVA: 0x003F0200 File Offset: 0x003EE400
			// (set) Token: 0x060110E8 RID: 69864 RVA: 0x003F023C File Offset: 0x003EE43C
			public unsafe DLC5_InfiniteSelectionPanel.ActiveCount ActiveCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_get_ActiveCount_Public_get_ActiveCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr_set_ActiveCount_Public_set_Void_ActiveCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060110E9 RID: 69865 RVA: 0x003F027C File Offset: 0x003EE47C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 287706, RefRangeEnd = 287707, XrefRangeStart = 287705, XrefRangeEnd = 287706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Nullable<int> ingredient1, Nullable<int> ingredient2, Nullable<int> ingredient3, DLC5_InfiniteSelectionPanel.ActiveCount activeCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ingredient1));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ingredient2));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ingredient3));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_ActiveCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110EA RID: 69866 RVA: 0x0009450C File Offset: 0x0009270C
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058B3 RID: 22707
			// (get) Token: 0x060110EB RID: 69867 RVA: 0x003F0308 File Offset: 0x003EE508
			// (set) Token: 0x060110EC RID: 69868 RVA: 0x00094515 File Offset: 0x00092715
			public Nullable<int> _Ingredient1_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient1_k__BackingField);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient1_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058B4 RID: 22708
			// (get) Token: 0x060110ED RID: 69869 RVA: 0x003F0338 File Offset: 0x003EE538
			// (set) Token: 0x060110EE RID: 69870 RVA: 0x00094543 File Offset: 0x00092743
			public Nullable<int> _Ingredient2_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient2_k__BackingField);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient2_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058B5 RID: 22709
			// (get) Token: 0x060110EF RID: 69871 RVA: 0x003F0368 File Offset: 0x003EE568
			// (set) Token: 0x060110F0 RID: 69872 RVA: 0x00094571 File Offset: 0x00092771
			public Nullable<int> _Ingredient3_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient3_k__BackingField);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__Ingredient3_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058B6 RID: 22710
			// (get) Token: 0x060110F1 RID: 69873 RVA: 0x003F0398 File Offset: 0x003EE598
			// (set) Token: 0x060110F2 RID: 69874 RVA: 0x0009459F File Offset: 0x0009279F
			public unsafe DLC5_InfiniteSelectionPanel.ActiveCount _ActiveCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__ActiveCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel.OpenContext.NativeFieldInfoPtr__ActiveCount_k__BackingField)) = value;
				}
			}

			// Token: 0x0400AC90 RID: 44176
			private static readonly IntPtr NativeFieldInfoPtr__Ingredient1_k__BackingField;

			// Token: 0x0400AC91 RID: 44177
			private static readonly IntPtr NativeFieldInfoPtr__Ingredient2_k__BackingField;

			// Token: 0x0400AC92 RID: 44178
			private static readonly IntPtr NativeFieldInfoPtr__Ingredient3_k__BackingField;

			// Token: 0x0400AC93 RID: 44179
			private static readonly IntPtr NativeFieldInfoPtr__ActiveCount_k__BackingField;

			// Token: 0x0400AC94 RID: 44180
			private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient1_Public_get_Nullable_1_Int32_0;

			// Token: 0x0400AC95 RID: 44181
			private static readonly IntPtr NativeMethodInfoPtr_set_Ingredient1_Public_set_Void_Nullable_1_Int32_0;

			// Token: 0x0400AC96 RID: 44182
			private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient2_Public_get_Nullable_1_Int32_0;

			// Token: 0x0400AC97 RID: 44183
			private static readonly IntPtr NativeMethodInfoPtr_set_Ingredient2_Public_set_Void_Nullable_1_Int32_0;

			// Token: 0x0400AC98 RID: 44184
			private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient3_Public_get_Nullable_1_Int32_0;

			// Token: 0x0400AC99 RID: 44185
			private static readonly IntPtr NativeMethodInfoPtr_set_Ingredient3_Public_set_Void_Nullable_1_Int32_0;

			// Token: 0x0400AC9A RID: 44186
			private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCount_Public_get_ActiveCount_0;

			// Token: 0x0400AC9B RID: 44187
			private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCount_Public_set_Void_ActiveCount_0;

			// Token: 0x0400AC9C RID: 44188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_ActiveCount_0;
		}

		// Token: 0x02000F53 RID: 3923
		[ObfuscatedName("Common.UI.InfiniteSelection.DLC5_InfiniteSelectionPanel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060110F3 RID: 69875 RVA: 0x003F03C0 File Offset: 0x003EE5C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr);
				DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr, "<>9");
				DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr, "<>9__8_0");
				DLC5_InfiniteSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr, 100687065);
				DLC5_InfiniteSelectionPanel.__c.NativeMethodInfoPtr__EditIngredient_b__8_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr, 100687066);
			}

			// Token: 0x060110F4 RID: 69876 RVA: 0x003F043C File Offset: 0x003EE63C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110F5 RID: 69877 RVA: 0x003F0478 File Offset: 0x003EE678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287707, XrefRangeEnd = 287708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _EditIngredient_b__8_0(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel.__c.NativeMethodInfoPtr__EditIngredient_b__8_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060110F6 RID: 69878 RVA: 0x000945BA File Offset: 0x000927BA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058BB RID: 22715
			// (get) Token: 0x060110F7 RID: 69879 RVA: 0x003F04CC File Offset: 0x003EE6CC
			// (set) Token: 0x060110F8 RID: 69880 RVA: 0x000945C3 File Offset: 0x000927C3
			public unsafe static DLC5_InfiniteSelectionPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteSelectionPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058BC RID: 22716
			// (get) Token: 0x060110F9 RID: 69881 RVA: 0x003F04F4 File Offset: 0x003EE6F4
			// (set) Token: 0x060110FA RID: 69882 RVA: 0x000945D5 File Offset: 0x000927D5
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_InfiniteSelectionPanel.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC9D RID: 44189
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AC9E RID: 44190
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400AC9F RID: 44191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ACA0 RID: 44192
			private static readonly IntPtr NativeMethodInfoPtr__EditIngredient_b__8_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;
		}

		// Token: 0x02000F54 RID: 3924
		[ObfuscatedName("Common.UI.InfiniteSelection.DLC5_InfiniteSelectionPanel+<EditIngredient>d__8")]
		public sealed class _EditIngredient_d__8 : ValueType
		{
			// Token: 0x060110FB RID: 69883 RVA: 0x003F051C File Offset: 0x003EE71C
			// Note: this type is marked as 'beforefieldinit'.
			static _EditIngredient_d__8()
			{
				Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel>.NativeClassPtr, "<EditIngredient>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr);
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "<>1__state");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "<>t__builder");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr_editIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "editIndex");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "<>4__this");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr__currentValue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "<currentValue>5__2");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, "<>u__1");
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, 100687067);
				DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr, 100687068);
			}

			// Token: 0x060110FC RID: 69884 RVA: 0x003F05E8 File Offset: 0x003EE7E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287788, RefRangeEnd = 287790, XrefRangeStart = 287708, XrefRangeEnd = 287788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110FD RID: 69885 RVA: 0x003F0620 File Offset: 0x003EE820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110FE RID: 69886 RVA: 0x000945E7 File Offset: 0x000927E7
			public _EditIngredient_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060110FF RID: 69887 RVA: 0x000945F0 File Offset: 0x000927F0
			public _EditIngredient_d__8() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_InfiniteSelectionPanel._EditIngredient_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170058BD RID: 22717
			// (get) Token: 0x06011100 RID: 69888 RVA: 0x003F0668 File Offset: 0x003EE868
			// (set) Token: 0x06011101 RID: 69889 RVA: 0x00094602 File Offset: 0x00092802
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170058BE RID: 22718
			// (get) Token: 0x06011102 RID: 69890 RVA: 0x003F0690 File Offset: 0x003EE890
			// (set) Token: 0x06011103 RID: 69891 RVA: 0x0009461D File Offset: 0x0009281D
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058BF RID: 22719
			// (get) Token: 0x06011104 RID: 69892 RVA: 0x003F06C0 File Offset: 0x003EE8C0
			// (set) Token: 0x06011105 RID: 69893 RVA: 0x0009464B File Offset: 0x0009284B
			public unsafe int editIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr_editIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr_editIndex)) = value;
				}
			}

			// Token: 0x170058C0 RID: 22720
			// (get) Token: 0x06011106 RID: 69894 RVA: 0x003F06E8 File Offset: 0x003EE8E8
			// (set) Token: 0x06011107 RID: 69895 RVA: 0x00094666 File Offset: 0x00092866
			public unsafe DLC5_InfiniteSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_InfiniteSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058C1 RID: 22721
			// (get) Token: 0x06011108 RID: 69896 RVA: 0x003F0718 File Offset: 0x003EE918
			// (set) Token: 0x06011109 RID: 69897 RVA: 0x00094685 File Offset: 0x00092885
			public Nullable<int> _currentValue_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr__currentValue_5__2);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr__currentValue_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170058C2 RID: 22722
			// (get) Token: 0x0601110A RID: 69898 RVA: 0x003F0748 File Offset: 0x003EE948
			// (set) Token: 0x0601110B RID: 69899 RVA: 0x000946B3 File Offset: 0x000928B3
			public UniTask<Nullable<int>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___u__1);
					return new UniTask<Nullable<int>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_InfiniteSelectionPanel._EditIngredient_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Nullable<int>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400ACA1 RID: 44193
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400ACA2 RID: 44194
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400ACA3 RID: 44195
			private static readonly IntPtr NativeFieldInfoPtr_editIndex;

			// Token: 0x0400ACA4 RID: 44196
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ACA5 RID: 44197
			private static readonly IntPtr NativeFieldInfoPtr__currentValue_5__2;

			// Token: 0x0400ACA6 RID: 44198
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400ACA7 RID: 44199
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400ACA8 RID: 44200
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
