using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.UI.Story
{
	// Token: 0x020003C5 RID: 965
	public class EventQTETutorialPannel : UIPanel
	{
		// Token: 0x06007319 RID: 29465 RVA: 0x0021E4AC File Offset: 0x0021C6AC
		// Note: this type is marked as 'beforefieldinit'.
		static EventQTETutorialPannel()
		{
			Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventQTETutorialPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr);
			EventQTETutorialPannel.NativeFieldInfoPtr_pageA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, "pageA");
			EventQTETutorialPannel.NativeFieldInfoPtr_pageB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, "pageB");
			EventQTETutorialPannel.NativeFieldInfoPtr_pageC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, "pageC");
			EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686984);
			EventQTETutorialPannel.NativeMethodInfoPtr_OpenPannel_Private_Void_EventQTETutorialSubPannel_Action_1_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686985);
			EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686986);
			EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686987);
			EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686988);
			EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686989);
			EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686990);
			EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686991);
			EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686992);
			EventQTETutorialPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686993);
			EventQTETutorialPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr, 100686994);
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x0021E5F4 File Offset: 0x0021C7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287276, XrefRangeEnd = 287284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x0021E630 File Offset: 0x0021C830
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287293, RefRangeEnd = 287297, XrefRangeStart = 287284, XrefRangeEnd = 287293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPannel(EventQTETutorialSubPannel pannelPrefab, Action<EventQTETutorialSubPannel.PannelCloseType> onPannelClose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelPrefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelClose);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OpenPannel_Private_Void_EventQTETutorialSubPannel_Action_1_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x0021E684 File Offset: 0x0021C884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x0021E6B8 File Offset: 0x0021C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287297, XrefRangeEnd = 287305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x0021E6EC File Offset: 0x0021C8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287305, XrefRangeEnd = 287313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OpenPanelC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x0021E720 File Offset: 0x0021C920
		[CallerCount(0)]
		public unsafe void OnPanelClose(EventQTETutorialSubPannel.PannelCloseType closeInfo, Action prev, Action next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prev);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x0021E784 File Offset: 0x0021C984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287313, XrefRangeEnd = 287319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelAClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x0021E7C4 File Offset: 0x0021C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287319, XrefRangeEnd = 287330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelBClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0021E804 File Offset: 0x0021CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287330, XrefRangeEnd = 287341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelCClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x0021E844 File Offset: 0x0021CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x0021E880 File Offset: 0x0021CA80
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQTETutorialPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQTETutorialPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x0003E40E File Offset: 0x0003C60E
		public EventQTETutorialPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x0021E8BC File Offset: 0x0021CABC
		// (set) Token: 0x06007327 RID: 29479 RVA: 0x0003E417 File Offset: 0x0003C617
		public unsafe EventQTETutorialSubPannel pageA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventQTETutorialSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x06007328 RID: 29480 RVA: 0x0021E8EC File Offset: 0x0021CAEC
		// (set) Token: 0x06007329 RID: 29481 RVA: 0x0003E436 File Offset: 0x0003C636
		public unsafe EventQTETutorialSubPannel pageB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventQTETutorialSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x0021E91C File Offset: 0x0021CB1C
		// (set) Token: 0x0600732B RID: 29483 RVA: 0x0003E455 File Offset: 0x0003C655
		public unsafe EventQTETutorialSubPannel pageC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventQTETutorialSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialPannel.NativeFieldInfoPtr_pageC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C4B RID: 19531
		private static readonly IntPtr NativeFieldInfoPtr_pageA;

		// Token: 0x04004C4C RID: 19532
		private static readonly IntPtr NativeFieldInfoPtr_pageB;

		// Token: 0x04004C4D RID: 19533
		private static readonly IntPtr NativeFieldInfoPtr_pageC;

		// Token: 0x04004C4E RID: 19534
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004C4F RID: 19535
		private static readonly IntPtr NativeMethodInfoPtr_OpenPannel_Private_Void_EventQTETutorialSubPannel_Action_1_PannelCloseType_0;

		// Token: 0x04004C50 RID: 19536
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelA_Private_Void_0;

		// Token: 0x04004C51 RID: 19537
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelB_Private_Void_0;

		// Token: 0x04004C52 RID: 19538
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelC_Private_Void_0;

		// Token: 0x04004C53 RID: 19539
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0;

		// Token: 0x04004C54 RID: 19540
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C55 RID: 19541
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C56 RID: 19542
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C57 RID: 19543
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C58 RID: 19544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
