using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace Common.UI.Story
{
	// Token: 0x020003C8 RID: 968
	public class EventToutetsuYuumaTutorialSubPanel : UIPanelParam<ValueTuple<bool, bool>, EventToutetsuYuumaTutorialSubPanel.PannelCloseType>
	{
		// Token: 0x06007353 RID: 29523 RVA: 0x0021F25C File Offset: 0x0021D45C
		// Note: this type is marked as 'beforefieldinit'.
		static EventToutetsuYuumaTutorialSubPanel()
		{
			Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventToutetsuYuumaTutorialSubPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr);
			EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoBackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, "m_GoBackBtn");
			EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, "m_GoNextBtn");
			EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtnText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, "m_GoNextBtnText");
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687016);
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687017);
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687018);
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687019);
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687020);
			EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr, 100687021);
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x0021F340 File Offset: 0x0021D540
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x0021F37C File Offset: 0x0021D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287482, XrefRangeEnd = 287515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<bool, bool> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0021F3D0 File Offset: 0x0021D5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x0021F40C File Offset: 0x0021D60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287515, XrefRangeEnd = 287518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventToutetsuYuumaTutorialSubPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventToutetsuYuumaTutorialSubPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0021F448 File Offset: 0x0021D648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287518, XrefRangeEnd = 287521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x0021F47C File Offset: 0x0021D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287521, XrefRangeEnd = 287524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__5_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialSubPanel.NativeMethodInfoPtr__OnPanelOpen_b__5_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x0003E55B File Offset: 0x0003C75B
		public EventToutetsuYuumaTutorialSubPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600735B RID: 29531 RVA: 0x0021F4B0 File Offset: 0x0021D6B0
		// (set) Token: 0x0600735C RID: 29532 RVA: 0x0003E564 File Offset: 0x0003C764
		public unsafe UIButtonSimple m_GoBackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoBackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoBackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600735D RID: 29533 RVA: 0x0021F4E0 File Offset: 0x0021D6E0
		// (set) Token: 0x0600735E RID: 29534 RVA: 0x0003E583 File Offset: 0x0003C783
		public unsafe UIButtonSimple m_GoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600735F RID: 29535 RVA: 0x0021F510 File Offset: 0x0021D710
		// (set) Token: 0x06007360 RID: 29536 RVA: 0x0003E5A2 File Offset: 0x0003C7A2
		public unsafe TextMeshProUGUI m_GoNextBtnText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtnText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialSubPanel.NativeFieldInfoPtr_m_GoNextBtnText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C75 RID: 19573
		private static readonly IntPtr NativeFieldInfoPtr_m_GoBackBtn;

		// Token: 0x04004C76 RID: 19574
		private static readonly IntPtr NativeFieldInfoPtr_m_GoNextBtn;

		// Token: 0x04004C77 RID: 19575
		private static readonly IntPtr NativeFieldInfoPtr_m_GoNextBtnText;

		// Token: 0x04004C78 RID: 19576
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C79 RID: 19577
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_Boolean_Boolean_0;

		// Token: 0x04004C7A RID: 19578
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C7B RID: 19579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C7C RID: 19580
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0;

		// Token: 0x04004C7D RID: 19581
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_1_Private_Void_0;

		// Token: 0x02000F4C RID: 3916
		public enum PannelCloseType
		{
			// Token: 0x0400AC78 RID: 44152
			Back,
			// Token: 0x0400AC79 RID: 44153
			Next
		}
	}
}
