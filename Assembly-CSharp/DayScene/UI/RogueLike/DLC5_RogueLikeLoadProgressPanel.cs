using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000111 RID: 273
	public class DLC5_RogueLikeLoadProgressPanel : UIPanelExtern
	{
		// Token: 0x06001DD3 RID: 7635 RVA: 0x00102618 File Offset: 0x00100818
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeLoadProgressPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeLoadProgressPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr);
			DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr, "m_Animator");
			DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_Variant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr, "Variant");
			DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr, 100668623);
			DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr, 100668624);
			DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr, 100668625);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x001026AC File Offset: 0x001008AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74526, XrefRangeEnd = 74528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x001026E8 File Offset: 0x001008E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74528, XrefRangeEnd = 74540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00102724 File Offset: 0x00100924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19396, RefRangeEnd = 19400, XrefRangeStart = 19396, XrefRangeEnd = 19400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeLoadProgressPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeLoadProgressPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeLoadProgressPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00011FE8 File Offset: 0x000101E8
		public DLC5_RogueLikeLoadProgressPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00102760 File Offset: 0x00100960
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00011FF1 File Offset: 0x000101F1
		public unsafe Animator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00102790 File Offset: 0x00100990
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00012010 File Offset: 0x00010210
		public unsafe static int Variant
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_Variant, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeLoadProgressPanel.NativeFieldInfoPtr_Variant, (void*)(&value));
			}
		}

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeFieldInfoPtr_Variant;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
