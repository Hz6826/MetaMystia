using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI
{
	// Token: 0x02000383 RID: 899
	public class UISelectionPanel : UIPanelParamClose<bool>
	{
		// Token: 0x06006AB6 RID: 27318 RVA: 0x002025E4 File Offset: 0x002007E4
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectionPanel()
		{
			Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "UISelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr);
			UISelectionPanel.NativeFieldInfoPtr_m_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, "m_ConfirmButton");
			UISelectionPanel.NativeFieldInfoPtr_m_RefuseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, "m_RefuseButton");
			UISelectionPanel.NativeFieldInfoPtr_defaultSelectConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, "defaultSelectConfirm");
			UISelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685365);
			UISelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685366);
			UISelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685367);
			UISelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685368);
			UISelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685369);
			UISelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr, 100685370);
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x002026C8 File Offset: 0x002008C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271160, XrefRangeEnd = 271175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00202704 File Offset: 0x00200904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271175, XrefRangeEnd = 271177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x00202740 File Offset: 0x00200940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x0020277C File Offset: 0x0020097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271177, XrefRangeEnd = 271180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x002027B8 File Offset: 0x002009B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271180, XrefRangeEnd = 271183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x002027EC File Offset: 0x002009EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271183, XrefRangeEnd = 271186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__3_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x00039C32 File Offset: 0x00037E32
		public UISelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x00202820 File Offset: 0x00200A20
		// (set) Token: 0x06006ABF RID: 27327 RVA: 0x00039C3B File Offset: 0x00037E3B
		public unsafe UIButtonSimple m_ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_m_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_m_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x00202850 File Offset: 0x00200A50
		// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x00039C5A File Offset: 0x00037E5A
		public unsafe UIButtonSimple m_RefuseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_m_RefuseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_m_RefuseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x00202880 File Offset: 0x00200A80
		// (set) Token: 0x06006AC3 RID: 27331 RVA: 0x00039C79 File Offset: 0x00037E79
		public unsafe bool defaultSelectConfirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_defaultSelectConfirm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectionPanel.NativeFieldInfoPtr_defaultSelectConfirm)) = value;
			}
		}

		// Token: 0x040046BA RID: 18106
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmButton;

		// Token: 0x040046BB RID: 18107
		private static readonly IntPtr NativeFieldInfoPtr_m_RefuseButton;

		// Token: 0x040046BC RID: 18108
		private static readonly IntPtr NativeFieldInfoPtr_defaultSelectConfirm;

		// Token: 0x040046BD RID: 18109
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040046BE RID: 18110
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040046BF RID: 18111
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040046C0 RID: 18112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046C1 RID: 18113
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0;

		// Token: 0x040046C2 RID: 18114
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0;
	}
}
