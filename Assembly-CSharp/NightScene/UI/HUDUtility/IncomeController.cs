using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C1 RID: 449
	public class IncomeController : IncomeControllerBase
	{
		// Token: 0x060037F5 RID: 14325 RVA: 0x0015E528 File Offset: 0x0015C728
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeController()
		{
			Il2CppClassPointerStore<IncomeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeController>.NativeClassPtr);
			IncomeController.NativeFieldInfoPtr_ChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, "ChangeDuration");
			IncomeController.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, "m_Text");
			IncomeController.NativeFieldInfoPtr_m_CurrentFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, "m_CurrentFund");
			IncomeController.NativeFieldInfoPtr_TargetFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, "TargetFund");
			IncomeController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673876);
			IncomeController.NativeMethodInfoPtr_SetFund_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673877);
			IncomeController.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673878);
			IncomeController.NativeMethodInfoPtr_UpdateFundVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673879);
			IncomeController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673880);
			IncomeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673881);
			IncomeController.NativeMethodInfoPtr__UpdateFundVisual_b__7_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeController>.NativeClassPtr, 100673882);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x0015E634 File Offset: 0x0015C834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130038, RefRangeEnd = 130039, XrefRangeStart = 129997, XrefRangeEnd = 130038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeController.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x0015E670 File Offset: 0x0015C870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130046, RefRangeEnd = 130048, XrefRangeStart = 130039, XrefRangeEnd = 130046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFund(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeController.NativeMethodInfoPtr_SetFund_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x0015E6B0 File Offset: 0x0015C8B0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFundUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeController.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x0015E6EC File Offset: 0x0015C8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130048, XrefRangeEnd = 130055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFundVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeController.NativeMethodInfoPtr_UpdateFundVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x0015E720 File Offset: 0x0015C920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x0015E75C File Offset: 0x0015C95C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x0015E798 File Offset: 0x0015C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130055, XrefRangeEnd = 130062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateFundVisual_b__7_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeController.NativeMethodInfoPtr__UpdateFundVisual_b__7_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x0001F37B File Offset: 0x0001D57B
		public IncomeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x0015E7D8 File Offset: 0x0015C9D8
		// (set) Token: 0x060037FF RID: 14335 RVA: 0x0001F384 File Offset: 0x0001D584
		public unsafe static float ChangeDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IncomeController.NativeFieldInfoPtr_ChangeDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IncomeController.NativeFieldInfoPtr_ChangeDuration, (void*)(&value));
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x0015E7F4 File Offset: 0x0015C9F4
		// (set) Token: 0x06003801 RID: 14337 RVA: 0x0001F392 File Offset: 0x0001D592
		public unsafe TextMeshProUGUI m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_m_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x0015E824 File Offset: 0x0015CA24
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x0001F3B1 File Offset: 0x0001D5B1
		public unsafe int m_CurrentFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_m_CurrentFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_m_CurrentFund)) = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0015E84C File Offset: 0x0015CA4C
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		public unsafe int TargetFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_TargetFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeController.NativeFieldInfoPtr_TargetFund)) = value;
			}
		}

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeFieldInfoPtr_ChangeDuration;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFund;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr_TargetFund;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeMethodInfoPtr_SetFund_Public_Void_Int32_0;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFundVisual_Private_Void_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr__UpdateFundVisual_b__7_0_Private_Void_Single_0;
	}
}
