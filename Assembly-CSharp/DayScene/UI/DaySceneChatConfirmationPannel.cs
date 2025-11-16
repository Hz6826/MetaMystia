using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace DayScene.UI
{
	// Token: 0x020000BA RID: 186
	public class DaySceneChatConfirmationPannel : UIPanel
	{
		// Token: 0x060014B5 RID: 5301 RVA: 0x000E4114 File Offset: 0x000E2314
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneChatConfirmationPannel()
		{
			Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneChatConfirmationPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr);
			DaySceneChatConfirmationPannel.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, "Yes");
			DaySceneChatConfirmationPannel.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, "No");
			DaySceneChatConfirmationPannel.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, "<Result>k__BackingField");
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666914);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666915);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666916);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666917);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_ExitWithResult_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666918);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666919);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666920);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666921);
			DaySceneChatConfirmationPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr, 100666922);
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x000E4234 File Offset: 0x000E2434
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x000E4270 File Offset: 0x000E2470
		public unsafe bool Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000E42B0 File Offset: 0x000E24B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58054, XrefRangeEnd = 58077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatConfirmationPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000E42EC File Offset: 0x000E24EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58077, XrefRangeEnd = 58078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatConfirmationPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000E4328 File Offset: 0x000E2528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58078, XrefRangeEnd = 58079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitWithResult(bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr_ExitWithResult_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000E4368 File Offset: 0x000E2568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneChatConfirmationPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000E43A4 File Offset: 0x000E25A4
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneChatConfirmationPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneChatConfirmationPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000E43E0 File Offset: 0x000E25E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58079, XrefRangeEnd = 58080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000E4414 File Offset: 0x000E2614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58080, XrefRangeEnd = 58081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneChatConfirmationPannel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0000CF6C File Offset: 0x0000B16C
		public DaySceneChatConfirmationPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000E4448 File Offset: 0x000E2648
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000CF75 File Offset: 0x0000B175
		public unsafe UIButtonSimple Yes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr_Yes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr_Yes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000E4478 File Offset: 0x000E2678
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0000CF94 File Offset: 0x0000B194
		public unsafe UIButtonSimple No
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr_No);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr_No), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000E44A8 File Offset: 0x000E26A8
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000CFB3 File Offset: 0x0000B1B3
		public unsafe bool _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneChatConfirmationPannel.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Boolean_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_ExitWithResult_Private_Void_Boolean_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0;
	}
}
