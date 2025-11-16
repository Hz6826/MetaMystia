using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common.UI.Story
{
	// Token: 0x020003C6 RID: 966
	public class EventQTETutorialSubPannel : UIPanelParamClose<EventQTETutorialSubPannel.PannelCloseType>
	{
		// Token: 0x0600732C RID: 29484 RVA: 0x0021E94C File Offset: 0x0021CB4C
		// Note: this type is marked as 'beforefieldinit'.
		static EventQTETutorialSubPannel()
		{
			Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventQTETutorialSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr);
			EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoBackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, "m_GoBackBtn");
			EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, "m_GoNextBtn");
			EventQTETutorialSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100686995);
			EventQTETutorialSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100686996);
			EventQTETutorialSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100686997);
			EventQTETutorialSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100686998);
			EventQTETutorialSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100686999);
			EventQTETutorialSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr, 100687000);
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x0021EA1C File Offset: 0x0021CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287341, XrefRangeEnd = 287356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x0021EA58 File Offset: 0x0021CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x0021EA94 File Offset: 0x0021CC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x0021EAD0 File Offset: 0x0021CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQTETutorialSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQTETutorialSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x0021EB0C File Offset: 0x0021CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287356, XrefRangeEnd = 287359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x0021EB40 File Offset: 0x0021CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287359, XrefRangeEnd = 287362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__3_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialSubPannel.NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x0003E474 File Offset: 0x0003C674
		public EventQTETutorialSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x06007334 RID: 29492 RVA: 0x0021EB74 File Offset: 0x0021CD74
		// (set) Token: 0x06007335 RID: 29493 RVA: 0x0003E47D File Offset: 0x0003C67D
		public unsafe UIButtonSimple m_GoBackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoBackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoBackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x06007336 RID: 29494 RVA: 0x0021EBA4 File Offset: 0x0021CDA4
		// (set) Token: 0x06007337 RID: 29495 RVA: 0x0003E49C File Offset: 0x0003C69C
		public unsafe UIButtonSimple m_GoNextBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoNextBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialSubPannel.NativeFieldInfoPtr_m_GoNextBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C59 RID: 19545
		private static readonly IntPtr NativeFieldInfoPtr_m_GoBackBtn;

		// Token: 0x04004C5A RID: 19546
		private static readonly IntPtr NativeFieldInfoPtr_m_GoNextBtn;

		// Token: 0x04004C5B RID: 19547
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C5C RID: 19548
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004C5D RID: 19549
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C5E RID: 19550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C5F RID: 19551
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_0_Private_Void_0;

		// Token: 0x04004C60 RID: 19552
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_1_Private_Void_0;

		// Token: 0x02000F4A RID: 3914
		public enum PannelCloseType
		{
			// Token: 0x0400AC71 RID: 44145
			Back,
			// Token: 0x0400AC72 RID: 44146
			Next
		}
	}
}
