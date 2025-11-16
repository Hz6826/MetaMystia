using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003C1 RID: 961
	public class EscLoadPannelSubSubPannel : UISubPanel<EscLoadPannelSubPannel>
	{
		// Token: 0x060072B5 RID: 29365 RVA: 0x0021D070 File Offset: 0x0021B270
		// Note: this type is marked as 'beforefieldinit'.
		static EscLoadPannelSubSubPannel()
		{
			Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscLoadPannelSubSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr);
			EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, "Text");
			EscLoadPannelSubSubPannel.NativeFieldInfoPtr_ConfirmBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, "ConfirmBtn");
			EscLoadPannelSubSubPannel.NativeFieldInfoPtr_DenyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, "DenyBtn");
			EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, "Result");
			EscLoadPannelSubSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, "m_ShouldInstantClose");
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686922);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_set_DisplayedContent_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686923);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686924);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686925);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_Yes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686926);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_No_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686927);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686928);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686929);
			EscLoadPannelSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr, 100686930);
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x0021D1B8 File Offset: 0x0021B3B8
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubSubPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700274C RID: 10060
		// (set) Token: 0x060072B7 RID: 29367 RVA: 0x0021D200 File Offset: 0x0021B400
		public unsafe string DisplayedContent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 286991, RefRangeEnd = 286993, XrefRangeStart = 286990, XrefRangeEnd = 286991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubSubPannel.NativeMethodInfoPtr_set_DisplayedContent_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x0021D244 File Offset: 0x0021B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286993, XrefRangeEnd = 286994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubSubPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x0021D28C File Offset: 0x0021B48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286994, XrefRangeEnd = 287012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x0021D2C8 File Offset: 0x0021B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287012, XrefRangeEnd = 287015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Yes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubSubPannel.NativeMethodInfoPtr_Yes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x0021D2FC File Offset: 0x0021B4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287015, XrefRangeEnd = 287018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void No()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubSubPannel.NativeMethodInfoPtr_No_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x0021D330 File Offset: 0x0021B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287018, XrefRangeEnd = 287019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x0021D36C File Offset: 0x0021B56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscLoadPannelSubSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x0021D3A8 File Offset: 0x0021B5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287019, XrefRangeEnd = 287022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscLoadPannelSubSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscLoadPannelSubSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscLoadPannelSubSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x0003E0C1 File Offset: 0x0003C2C1
		public EscLoadPannelSubSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x060072C0 RID: 29376 RVA: 0x0021D3E4 File Offset: 0x0021B5E4
		// (set) Token: 0x060072C1 RID: 29377 RVA: 0x0003E0CA File Offset: 0x0003C2CA
		public unsafe TextMeshProUGUI Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x060072C2 RID: 29378 RVA: 0x0021D414 File Offset: 0x0021B614
		// (set) Token: 0x060072C3 RID: 29379 RVA: 0x0003E0E9 File Offset: 0x0003C2E9
		public unsafe UIButtonSimple ConfirmBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_ConfirmBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_ConfirmBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x060072C4 RID: 29380 RVA: 0x0021D444 File Offset: 0x0021B644
		// (set) Token: 0x060072C5 RID: 29381 RVA: 0x0003E108 File Offset: 0x0003C308
		public unsafe UIButtonSimple DenyBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_DenyBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_DenyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x060072C6 RID: 29382 RVA: 0x0021D474 File Offset: 0x0021B674
		// (set) Token: 0x060072C7 RID: 29383 RVA: 0x0003E127 File Offset: 0x0003C327
		public unsafe EscLoadPannelSubSubPannel.PannelResult Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x060072C8 RID: 29384 RVA: 0x0021D49C File Offset: 0x0021B69C
		// (set) Token: 0x060072C9 RID: 29385 RVA: 0x0003E142 File Offset: 0x0003C342
		public unsafe bool m_ShouldInstantClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscLoadPannelSubSubPannel.NativeFieldInfoPtr_m_ShouldInstantClose)) = value;
			}
		}

		// Token: 0x04004C09 RID: 19465
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04004C0A RID: 19466
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmBtn;

		// Token: 0x04004C0B RID: 19467
		private static readonly IntPtr NativeFieldInfoPtr_DenyBtn;

		// Token: 0x04004C0C RID: 19468
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04004C0D RID: 19469
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInstantClose;

		// Token: 0x04004C0E RID: 19470
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004C0F RID: 19471
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayedContent_Public_set_Void_String_0;

		// Token: 0x04004C10 RID: 19472
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004C11 RID: 19473
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C12 RID: 19474
		private static readonly IntPtr NativeMethodInfoPtr_Yes_Private_Void_0;

		// Token: 0x04004C13 RID: 19475
		private static readonly IntPtr NativeMethodInfoPtr_No_Private_Void_0;

		// Token: 0x04004C14 RID: 19476
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004C15 RID: 19477
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C16 RID: 19478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F42 RID: 3906
		public enum PannelResult
		{
			// Token: 0x0400AC47 RID: 44103
			Yes,
			// Token: 0x0400AC48 RID: 44104
			No
		}
	}
}
