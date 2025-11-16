using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.UI.Story
{
	// Token: 0x020003C7 RID: 967
	public class EventToutetsuYuumaTutorialPanel : UIPanelParamOpen<EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase>
	{
		// Token: 0x06007338 RID: 29496 RVA: 0x0021EBD4 File Offset: 0x0021CDD4
		// Note: this type is marked as 'beforefieldinit'.
		static EventToutetsuYuumaTutorialPanel()
		{
			Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventToutetsuYuumaTutorialPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr);
			EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, "pageA");
			EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, "pageB");
			EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, "pageC");
			EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, "pageD");
			EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr__CurrentYuumaTutorialPhase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, "<CurrentYuumaTutorialPhase>k__BackingField");
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_get_CurrentYuumaTutorialPhase_Private_get_YuumaTutorialPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687001);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_set_CurrentYuumaTutorialPhase_Private_set_Void_YuumaTutorialPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687002);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_YuumaTutorialPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687003);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanel_Private_Void_ValueTuple_2_Boolean_Boolean_EventToutetsuYuumaTutorialSubPanel_Action_1_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687004);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelA_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687005);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelB_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687006);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687007);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687008);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687009);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687010);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687011);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687012);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelDClose_Private_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687013);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687014);
			EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr, 100687015);
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x0021ED94 File Offset: 0x0021CF94
		// (set) Token: 0x0600733A RID: 29498 RVA: 0x0021EDD0 File Offset: 0x0021CFD0
		public unsafe EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase CurrentYuumaTutorialPhase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_get_CurrentYuumaTutorialPhase_Private_get_YuumaTutorialPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_set_CurrentYuumaTutorialPhase_Private_set_Void_YuumaTutorialPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x0021EE10 File Offset: 0x0021D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287362, XrefRangeEnd = 287381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase yuumaTutorialPhase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref yuumaTutorialPhase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_YuumaTutorialPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0021EE5C File Offset: 0x0021D05C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 287390, RefRangeEnd = 287395, XrefRangeStart = 287381, XrefRangeEnd = 287390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanel(ValueTuple<bool, bool> isLastPage, EventToutetsuYuumaTutorialSubPanel pannelPrefab, Action<EventToutetsuYuumaTutorialSubPanel.PannelCloseType> onPannelClose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(isLastPage));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pannelPrefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelClose);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanel_Private_Void_ValueTuple_2_Boolean_Boolean_EventToutetsuYuumaTutorialSubPanel_Action_1_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0021EEC8 File Offset: 0x0021D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287395, XrefRangeEnd = 287405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelA()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelA_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x0021EEFC File Offset: 0x0021D0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287405, XrefRangeEnd = 287415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelB_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0021EF30 File Offset: 0x0021D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287415, XrefRangeEnd = 287425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x0021EF64 File Offset: 0x0021D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287425, XrefRangeEnd = 287435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPanelD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OpenPanelD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x0021EF98 File Offset: 0x0021D198
		[CallerCount(0)]
		public unsafe void OnPanelClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo, Action prev, Action next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prev);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x0021EFFC File Offset: 0x0021D1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287435, XrefRangeEnd = 287441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelAClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x0021F03C File Offset: 0x0021D23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287441, XrefRangeEnd = 287452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelBClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x0021F07C File Offset: 0x0021D27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287452, XrefRangeEnd = 287467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelCClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x0021F0BC File Offset: 0x0021D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287467, XrefRangeEnd = 287479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_OnPanelDClose_Private_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x0021F0FC File Offset: 0x0021D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x0021F138 File Offset: 0x0021D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287479, XrefRangeEnd = 287482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventToutetsuYuumaTutorialPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventToutetsuYuumaTutorialPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventToutetsuYuumaTutorialPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x0003E4BB File Offset: 0x0003C6BB
		public EventToutetsuYuumaTutorialPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x0021F174 File Offset: 0x0021D374
		// (set) Token: 0x0600734A RID: 29514 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		public unsafe EventToutetsuYuumaTutorialSubPanel pageA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventToutetsuYuumaTutorialSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x0021F1A4 File Offset: 0x0021D3A4
		// (set) Token: 0x0600734C RID: 29516 RVA: 0x0003E4E3 File Offset: 0x0003C6E3
		public unsafe EventToutetsuYuumaTutorialSubPanel pageB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventToutetsuYuumaTutorialSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x0021F1D4 File Offset: 0x0021D3D4
		// (set) Token: 0x0600734E RID: 29518 RVA: 0x0003E502 File Offset: 0x0003C702
		public unsafe EventToutetsuYuumaTutorialSubPanel pageC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventToutetsuYuumaTutorialSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600734F RID: 29519 RVA: 0x0021F204 File Offset: 0x0021D404
		// (set) Token: 0x06007350 RID: 29520 RVA: 0x0003E521 File Offset: 0x0003C721
		public unsafe EventToutetsuYuumaTutorialSubPanel pageD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventToutetsuYuumaTutorialSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr_pageD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x06007351 RID: 29521 RVA: 0x0021F234 File Offset: 0x0021D434
		// (set) Token: 0x06007352 RID: 29522 RVA: 0x0003E540 File Offset: 0x0003C740
		public unsafe EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase _CurrentYuumaTutorialPhase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr__CurrentYuumaTutorialPhase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventToutetsuYuumaTutorialPanel.NativeFieldInfoPtr__CurrentYuumaTutorialPhase_k__BackingField)) = value;
			}
		}

		// Token: 0x04004C61 RID: 19553
		private static readonly IntPtr NativeFieldInfoPtr_pageA;

		// Token: 0x04004C62 RID: 19554
		private static readonly IntPtr NativeFieldInfoPtr_pageB;

		// Token: 0x04004C63 RID: 19555
		private static readonly IntPtr NativeFieldInfoPtr_pageC;

		// Token: 0x04004C64 RID: 19556
		private static readonly IntPtr NativeFieldInfoPtr_pageD;

		// Token: 0x04004C65 RID: 19557
		private static readonly IntPtr NativeFieldInfoPtr__CurrentYuumaTutorialPhase_k__BackingField;

		// Token: 0x04004C66 RID: 19558
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentYuumaTutorialPhase_Private_get_YuumaTutorialPhase_0;

		// Token: 0x04004C67 RID: 19559
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentYuumaTutorialPhase_Private_set_Void_YuumaTutorialPhase_0;

		// Token: 0x04004C68 RID: 19560
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_YuumaTutorialPhase_0;

		// Token: 0x04004C69 RID: 19561
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanel_Private_Void_ValueTuple_2_Boolean_Boolean_EventToutetsuYuumaTutorialSubPanel_Action_1_PannelCloseType_0;

		// Token: 0x04004C6A RID: 19562
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelA_Private_Void_0;

		// Token: 0x04004C6B RID: 19563
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelB_Private_Void_0;

		// Token: 0x04004C6C RID: 19564
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelC_Private_Void_0;

		// Token: 0x04004C6D RID: 19565
		private static readonly IntPtr NativeMethodInfoPtr_OpenPanelD_Private_Void_0;

		// Token: 0x04004C6E RID: 19566
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Private_Void_PannelCloseType_Action_Action_0;

		// Token: 0x04004C6F RID: 19567
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelAClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C70 RID: 19568
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelBClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C71 RID: 19569
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelCClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C72 RID: 19570
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDClose_Private_Void_PannelCloseType_0;

		// Token: 0x04004C73 RID: 19571
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C74 RID: 19572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F4B RID: 3915
		public enum YuumaTutorialPhase
		{
			// Token: 0x0400AC74 RID: 44148
			First,
			// Token: 0x0400AC75 RID: 44149
			Second,
			// Token: 0x0400AC76 RID: 44150
			ReMemory
		}
	}
}
