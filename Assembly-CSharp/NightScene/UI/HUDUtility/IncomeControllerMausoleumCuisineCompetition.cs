using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C8 RID: 456
	public class IncomeControllerMausoleumCuisineCompetition : IncomeController
	{
		// Token: 0x06003901 RID: 14593 RVA: 0x00161698 File Offset: 0x0015F898
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerMausoleumCuisineCompetition()
		{
			Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerMausoleumCuisineCompetition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr);
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "cross");
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "check");
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "targetAmountText");
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "targetAmountText2");
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_currentAmountText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "currentAmountText2");
			IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, "targetAmount");
			IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, 100673993);
			IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, 100673994);
			IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, 100673995);
			IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, 100673996);
			IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr, 100673997);
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x001617A4 File Offset: 0x0015F9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131017, XrefRangeEnd = 131072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x001617E0 File Offset: 0x0015F9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131072, XrefRangeEnd = 131076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFundUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0016181C File Offset: 0x0015FA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131083, RefRangeEnd = 131085, XrefRangeStart = 131076, XrefRangeEnd = 131083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetFund(int targetAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0016185C File Offset: 0x0015FA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131085, XrefRangeEnd = 131091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00161898 File Offset: 0x0015FA98
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerMausoleumCuisineCompetition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerMausoleumCuisineCompetition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerMausoleumCuisineCompetition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x0001FD9F File Offset: 0x0001DF9F
		public IncomeControllerMausoleumCuisineCompetition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x001618D4 File Offset: 0x0015FAD4
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public unsafe Image cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x00161904 File Offset: 0x0015FB04
		// (set) Token: 0x0600390B RID: 14603 RVA: 0x0001FDC7 File Offset: 0x0001DFC7
		public unsafe Image check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00161934 File Offset: 0x0015FB34
		// (set) Token: 0x0600390D RID: 14605 RVA: 0x0001FDE6 File Offset: 0x0001DFE6
		public unsafe TextMeshProUGUI targetAmountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x00161964 File Offset: 0x0015FB64
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x0001FE05 File Offset: 0x0001E005
		public unsafe TextMeshProUGUI targetAmountText2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmountText2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x00161994 File Offset: 0x0015FB94
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x0001FE24 File Offset: 0x0001E024
		public unsafe TextMeshProUGUI currentAmountText2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_currentAmountText2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_currentAmountText2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x001619C4 File Offset: 0x0015FBC4
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x0001FE43 File Offset: 0x0001E043
		public unsafe int targetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerMausoleumCuisineCompetition.NativeFieldInfoPtr_targetAmount)) = value;
			}
		}

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeFieldInfoPtr_cross;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeFieldInfoPtr_check;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeFieldInfoPtr_targetAmountText;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeFieldInfoPtr_targetAmountText2;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeFieldInfoPtr_currentAmountText2;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeFieldInfoPtr_targetAmount;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
