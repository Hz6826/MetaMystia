using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace MusicGame.UI
{
	// Token: 0x02000022 RID: 34
	public class MusicGamePausePannel : UIPanel
	{
		// Token: 0x06000308 RID: 776 RVA: 0x000A8704 File Offset: 0x000A6904
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGamePausePannel()
		{
			Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGamePausePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr);
			MusicGamePausePannel.NativeFieldInfoPtr_ContinueBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, "ContinueBtn");
			MusicGamePausePannel.NativeFieldInfoPtr_BackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, "BackBtn");
			MusicGamePausePannel.NativeFieldInfoPtr_RestartBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, "RestartBtn");
			MusicGamePausePannel.NativeFieldInfoPtr__AbortMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, "<AbortMode>k__BackingField");
			MusicGamePausePannel.NativeFieldInfoPtr__EnableRestartAndExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, "<EnableRestartAndExit>k__BackingField");
			MusicGamePausePannel.NativeMethodInfoPtr_get_AbortMode_Public_get_MusicAbortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663749);
			MusicGamePausePannel.NativeMethodInfoPtr_set_AbortMode_Private_set_Void_MusicAbortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663750);
			MusicGamePausePannel.NativeMethodInfoPtr_get_EnableRestartAndExit_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663751);
			MusicGamePausePannel.NativeMethodInfoPtr_set_EnableRestartAndExit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663752);
			MusicGamePausePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663753);
			MusicGamePausePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663754);
			MusicGamePausePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663755);
			MusicGamePausePannel.NativeMethodInfoPtr_OnPanelOpenCloseFadeFinish_Protected_Virtual_Void_FadeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663756);
			MusicGamePausePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663757);
			MusicGamePausePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663758);
			MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663759);
			MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663760);
			MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663761);
			MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663762);
			MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr, 100663763);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000A88C4 File Offset: 0x000A6AC4
		// (set) Token: 0x0600030A RID: 778 RVA: 0x000A8900 File Offset: 0x000A6B00
		public unsafe MusicGamePausePannel.MusicAbortMode AbortMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr_get_AbortMode_Public_get_MusicAbortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr_set_AbortMode_Private_set_Void_MusicAbortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000A8940 File Offset: 0x000A6B40
		// (set) Token: 0x0600030C RID: 780 RVA: 0x000A897C File Offset: 0x000A6B7C
		public unsafe bool EnableRestartAndExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr_get_EnableRestartAndExit_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr_set_EnableRestartAndExit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000A89BC File Offset: 0x000A6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21344, XrefRangeEnd = 21368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGamePausePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000A89F8 File Offset: 0x000A6BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21368, XrefRangeEnd = 21373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGamePausePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000A8A34 File Offset: 0x000A6C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21373, XrefRangeEnd = 21374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGamePausePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000A8A70 File Offset: 0x000A6C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21374, XrefRangeEnd = 21378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpenCloseFadeFinish(FadeType fadeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGamePausePannel.NativeMethodInfoPtr_OnPanelOpenCloseFadeFinish_Protected_Virtual_Void_FadeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000A8ABC File Offset: 0x000A6CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGamePausePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000A8AF8 File Offset: 0x000A6CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21378, XrefRangeEnd = 21379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGamePausePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGamePausePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000A8B34 File Offset: 0x000A6D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21379, XrefRangeEnd = 21384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000A8B68 File Offset: 0x000A6D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21384, XrefRangeEnd = 21399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000A8B9C File Offset: 0x000A6D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21399, XrefRangeEnd = 21405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000A8BD0 File Offset: 0x000A6DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21405, XrefRangeEnd = 21420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000A8C04 File Offset: 0x000A6E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21420, XrefRangeEnd = 21426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__12_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGamePausePannel.NativeMethodInfoPtr__OnPanelInitialize_b__12_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public MusicGamePausePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000A8C38 File Offset: 0x000A6E38
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003AFD File Offset: 0x00001CFD
		public unsafe UIButtonSimple ContinueBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_ContinueBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_ContinueBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000A8C68 File Offset: 0x000A6E68
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003B1C File Offset: 0x00001D1C
		public unsafe UIButtonSimple BackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_BackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_BackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000A8C98 File Offset: 0x000A6E98
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003B3B File Offset: 0x00001D3B
		public unsafe UIButtonSimple RestartBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_RestartBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr_RestartBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000A8CC8 File Offset: 0x000A6EC8
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003B5A File Offset: 0x00001D5A
		public unsafe MusicGamePausePannel.MusicAbortMode _AbortMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr__AbortMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr__AbortMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000A8CF0 File Offset: 0x000A6EF0
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003B75 File Offset: 0x00001D75
		public unsafe bool _EnableRestartAndExit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr__EnableRestartAndExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGamePausePannel.NativeFieldInfoPtr__EnableRestartAndExit_k__BackingField)) = value;
			}
		}

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_ContinueBtn;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_BackBtn;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_RestartBtn;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr__AbortMode_k__BackingField;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr__EnableRestartAndExit_k__BackingField;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_get_AbortMode_Public_get_MusicAbortMode_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_set_AbortMode_Private_set_Void_MusicAbortMode_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableRestartAndExit_Private_get_Boolean_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableRestartAndExit_Public_set_Void_Boolean_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenCloseFadeFinish_Protected_Virtual_Void_FadeType_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_0_Private_Void_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_1_Private_Void_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_3_Private_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_2_Private_Void_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_4_Private_Void_0;

		// Token: 0x02000495 RID: 1173
		public enum MusicAbortMode
		{
			// Token: 0x040052D7 RID: 21207
			Continue,
			// Token: 0x040052D8 RID: 21208
			Back,
			// Token: 0x040052D9 RID: 21209
			Restart
		}
	}
}
