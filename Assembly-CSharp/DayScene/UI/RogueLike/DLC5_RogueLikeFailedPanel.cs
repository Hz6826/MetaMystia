using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000110 RID: 272
	public class DLC5_RogueLikeFailedPanel : UIPanelParamOpen<RogueLikeRunTimeData>
	{
		// Token: 0x06001DC7 RID: 7623 RVA: 0x0010237C File Offset: 0x0010057C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeFailedPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeFailedPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr);
			DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_ResultBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, "m_ResultBtn");
			DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_BreakBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, "m_BreakBtn");
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668617);
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668618);
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668619);
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668620);
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668621);
			DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr, 100668622);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0010244C File Offset: 0x0010064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74490, XrefRangeEnd = 74508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00102488 File Offset: 0x00100688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74508, XrefRangeEnd = 74509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x001024D8 File Offset: 0x001006D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74509, XrefRangeEnd = 74512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00102514 File Offset: 0x00100714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74512, XrefRangeEnd = 74515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeFailedPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeFailedPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00102550 File Offset: 0x00100750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74515, XrefRangeEnd = 74518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__2_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00102584 File Offset: 0x00100784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74518, XrefRangeEnd = 74526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__2_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeFailedPanel.NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00011FA1 File Offset: 0x000101A1
		public DLC5_RogueLikeFailedPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x001025B8 File Offset: 0x001007B8
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00011FAA File Offset: 0x000101AA
		public unsafe UIButtonSimple m_ResultBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_ResultBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_ResultBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x001025E8 File Offset: 0x001007E8
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00011FC9 File Offset: 0x000101C9
		public unsafe UIButtonSimple m_BreakBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_BreakBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeFailedPanel.NativeFieldInfoPtr_m_BreakBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_m_ResultBtn;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_m_BreakBtn;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueLikeRunTimeData_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_0_Private_Void_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_1_Private_Void_0;
	}
}
