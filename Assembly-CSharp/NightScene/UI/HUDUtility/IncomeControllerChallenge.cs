using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020001C3 RID: 451
	public class IncomeControllerChallenge : IncomeController
	{
		// Token: 0x06003812 RID: 14354 RVA: 0x0015EBD4 File Offset: 0x0015CDD4
		// Note: this type is marked as 'beforefieldinit'.
		static IncomeControllerChallenge()
		{
			Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.HUDUtility", "IncomeControllerChallenge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr);
			IncomeControllerChallenge.NativeFieldInfoPtr_cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "cross");
			IncomeControllerChallenge.NativeFieldInfoPtr_check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "check");
			IncomeControllerChallenge.NativeFieldInfoPtr_crossSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "crossSpellCard");
			IncomeControllerChallenge.NativeFieldInfoPtr_checkSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "checkSpellCard");
			IncomeControllerChallenge.NativeFieldInfoPtr_targetAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "targetAmountText");
			IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "spellCardCollectionParent");
			IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionAmountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "spellCardCollectionAmountText");
			IncomeControllerChallenge.NativeFieldInfoPtr_targetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, "targetAmount");
			IncomeControllerChallenge.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673893);
			IncomeControllerChallenge.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673894);
			IncomeControllerChallenge.NativeMethodInfoPtr_SetSpellMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673895);
			IncomeControllerChallenge.NativeMethodInfoPtr_UpdateSpellCount_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673896);
			IncomeControllerChallenge.NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673897);
			IncomeControllerChallenge.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673898);
			IncomeControllerChallenge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr, 100673899);
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x0015ED30 File Offset: 0x0015CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130094, XrefRangeEnd = 130135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerChallenge.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x0015ED6C File Offset: 0x0015CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130135, XrefRangeEnd = 130138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFundUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerChallenge.NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x0015EDA8 File Offset: 0x0015CFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130142, RefRangeEnd = 130143, XrefRangeStart = 130138, XrefRangeEnd = 130142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpellMode(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerChallenge.NativeMethodInfoPtr_SetSpellMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0015EDE8 File Offset: 0x0015CFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130156, RefRangeEnd = 130158, XrefRangeStart = 130143, XrefRangeEnd = 130156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpellCount(int current, int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerChallenge.NativeMethodInfoPtr_UpdateSpellCount_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0015EE34 File Offset: 0x0015D034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130159, RefRangeEnd = 130160, XrefRangeStart = 130158, XrefRangeEnd = 130159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetFund(int targetAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerChallenge.NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0015EE74 File Offset: 0x0015D074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130160, XrefRangeEnd = 130168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IncomeControllerChallenge.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0015EEB0 File Offset: 0x0015D0B0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IncomeControllerChallenge() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IncomeControllerChallenge>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IncomeControllerChallenge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		public IncomeControllerChallenge(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x0015EEEC File Offset: 0x0015D0EC
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x0001F3F9 File Offset: 0x0001D5F9
		public unsafe Image cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x0015EF1C File Offset: 0x0015D11C
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x0001F418 File Offset: 0x0001D618
		public unsafe Image check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x0015EF4C File Offset: 0x0015D14C
		// (set) Token: 0x06003820 RID: 14368 RVA: 0x0001F437 File Offset: 0x0001D637
		public unsafe Image crossSpellCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_crossSpellCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_crossSpellCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x0015EF7C File Offset: 0x0015D17C
		// (set) Token: 0x06003822 RID: 14370 RVA: 0x0001F456 File Offset: 0x0001D656
		public unsafe Image checkSpellCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_checkSpellCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_checkSpellCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x0015EFAC File Offset: 0x0015D1AC
		// (set) Token: 0x06003824 RID: 14372 RVA: 0x0001F475 File Offset: 0x0001D675
		public unsafe TextMeshProUGUI targetAmountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_targetAmountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_targetAmountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x0015EFDC File Offset: 0x0015D1DC
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x0001F494 File Offset: 0x0001D694
		public unsafe RectTransform spellCardCollectionParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x0015F00C File Offset: 0x0015D20C
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x0001F4B3 File Offset: 0x0001D6B3
		public unsafe TextMeshProUGUI spellCardCollectionAmountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionAmountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_spellCardCollectionAmountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x0015F03C File Offset: 0x0015D23C
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x0001F4D2 File Offset: 0x0001D6D2
		public unsafe int targetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_targetAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IncomeControllerChallenge.NativeFieldInfoPtr_targetAmount)) = value;
			}
		}

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeFieldInfoPtr_cross;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeFieldInfoPtr_check;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeFieldInfoPtr_crossSpellCard;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeFieldInfoPtr_checkSpellCard;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeFieldInfoPtr_targetAmountText;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeFieldInfoPtr_spellCardCollectionParent;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeFieldInfoPtr_spellCardCollectionAmountText;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeFieldInfoPtr_targetAmount;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_OnFundUpdate_Protected_Virtual_Void_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_SetSpellMode_Public_Void_Boolean_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpellCount_Public_Void_Int32_Int32_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetFund_Public_Void_Int32_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
