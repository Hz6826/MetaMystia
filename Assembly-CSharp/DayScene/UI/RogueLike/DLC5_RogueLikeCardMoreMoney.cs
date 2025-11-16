using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E9 RID: 233
	public class DLC5_RogueLikeCardMoreMoney : RogueLikeCard
	{
		// Token: 0x06001AD8 RID: 6872 RVA: 0x000F80C4 File Offset: 0x000F62C4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardMoreMoney()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardMoreMoney");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr);
			DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, "duration");
			DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, 100668125);
			DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, 100668126);
			DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, 100668127);
			DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, 100668128);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x000F816C File Offset: 0x000F636C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71133, XrefRangeEnd = 71140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000F81EC File Offset: 0x000F63EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71140, XrefRangeEnd = 71152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000F8250 File Offset: 0x000F6450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardMoreMoney() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x000F828C File Offset: 0x000F648C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00010854 File Offset: 0x0000EA54
		public DLC5_RogueLikeCardMoreMoney(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000F8304 File Offset: 0x000F6504
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0001085D File Offset: 0x0000EA5D
		public unsafe Il2CppReferenceArray<RarityDataMappingForMultiplier> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForMultiplier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000F8334 File Offset: 0x000F6534
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0001087C File Offset: 0x0000EA7C
		public unsafe int duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x020006AA RID: 1706
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardMoreMoney+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06009832 RID: 38962 RVA: 0x0028B20C File Offset: 0x0028940C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr);
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, 100668129);
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, 100668130);
				DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__1_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr, 100668131);
			}

			// Token: 0x06009833 RID: 38963 RVA: 0x0028B2C4 File Offset: 0x002894C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009834 RID: 38964 RVA: 0x0028B300 File Offset: 0x00289500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71087, XrefRangeEnd = 71098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009835 RID: 38965 RVA: 0x0028B340 File Offset: 0x00289540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71098, XrefRangeEnd = 71110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _UseCard_b__1(int remainingTime, string buffDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref remainingTime;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeMethodInfoPtr__UseCard_b__1_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009836 RID: 38966 RVA: 0x00052582 File Offset: 0x00050782
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003291 RID: 12945
			// (get) Token: 0x06009837 RID: 38967 RVA: 0x0028B398 File Offset: 0x00289598
			// (set) Token: 0x06009838 RID: 38968 RVA: 0x0005258B File Offset: 0x0005078B
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003292 RID: 12946
			// (get) Token: 0x06009839 RID: 38969 RVA: 0x0028B3C8 File Offset: 0x002895C8
			// (set) Token: 0x0600983A RID: 38970 RVA: 0x000525B9 File Offset: 0x000507B9
			public unsafe DLC5_RogueLikeCardMoreMoney __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardMoreMoney>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003293 RID: 12947
			// (get) Token: 0x0600983B RID: 38971 RVA: 0x0028B3F8 File Offset: 0x002895F8
			// (set) Token: 0x0600983C RID: 38972 RVA: 0x000525D8 File Offset: 0x000507D8
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x17003294 RID: 12948
			// (get) Token: 0x0600983D RID: 38973 RVA: 0x0028B420 File Offset: 0x00289620
			// (set) Token: 0x0600983E RID: 38974 RVA: 0x000525F3 File Offset: 0x000507F3
			public unsafe Func<int, string, string> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400629E RID: 25246
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x0400629F RID: 25247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062A0 RID: 25248
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040062A1 RID: 25249
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040062A2 RID: 25250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040062A3 RID: 25251
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__0_Internal_Void_Int32_0;

			// Token: 0x040062A4 RID: 25252
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__1_Internal_String_Int32_String_0;
		}

		// Token: 0x020006AB RID: 1707
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardMoreMoney+<UseCard>d__2")]
		public sealed class _UseCard_d__2 : Object
		{
			// Token: 0x0600983F RID: 38975 RVA: 0x0028B450 File Offset: 0x00289650
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney>.NativeClassPtr, "<UseCard>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668132);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668133);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668134);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668135);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668136);
				DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr, 100668137);
			}

			// Token: 0x06009840 RID: 38976 RVA: 0x0028B580 File Offset: 0x00289780
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardMoreMoney._UseCard_d__2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009841 RID: 38977 RVA: 0x0028B5C8 File Offset: 0x002897C8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009842 RID: 38978 RVA: 0x0028B5FC File Offset: 0x002897FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71110, XrefRangeEnd = 71127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700329C RID: 12956
			// (get) Token: 0x06009843 RID: 38979 RVA: 0x0028B638 File Offset: 0x00289838
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009844 RID: 38980 RVA: 0x0028B678 File Offset: 0x00289878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71127, XrefRangeEnd = 71133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700329D RID: 12957
			// (get) Token: 0x06009845 RID: 38981 RVA: 0x0028B6AC File Offset: 0x002898AC
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009846 RID: 38982 RVA: 0x00052612 File Offset: 0x00050812
			public _UseCard_d__2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003295 RID: 12949
			// (get) Token: 0x06009847 RID: 38983 RVA: 0x0028B6EC File Offset: 0x002898EC
			// (set) Token: 0x06009848 RID: 38984 RVA: 0x0005261B File Offset: 0x0005081B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003296 RID: 12950
			// (get) Token: 0x06009849 RID: 38985 RVA: 0x0028B714 File Offset: 0x00289914
			// (set) Token: 0x0600984A RID: 38986 RVA: 0x00052636 File Offset: 0x00050836
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003297 RID: 12951
			// (get) Token: 0x0600984B RID: 38987 RVA: 0x0028B744 File Offset: 0x00289944
			// (set) Token: 0x0600984C RID: 38988 RVA: 0x00052655 File Offset: 0x00050855
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003298 RID: 12952
			// (get) Token: 0x0600984D RID: 38989 RVA: 0x0028B774 File Offset: 0x00289974
			// (set) Token: 0x0600984E RID: 38990 RVA: 0x00052683 File Offset: 0x00050883
			public unsafe DLC5_RogueLikeCardMoreMoney __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardMoreMoney>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003299 RID: 12953
			// (get) Token: 0x0600984F RID: 38991 RVA: 0x0028B7A4 File Offset: 0x002899A4
			// (set) Token: 0x06009850 RID: 38992 RVA: 0x000526A2 File Offset: 0x000508A2
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700329A RID: 12954
			// (get) Token: 0x06009851 RID: 38993 RVA: 0x0028B7CC File Offset: 0x002899CC
			// (set) Token: 0x06009852 RID: 38994 RVA: 0x000526BD File Offset: 0x000508BD
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700329B RID: 12955
			// (get) Token: 0x06009853 RID: 38995 RVA: 0x0028B7FC File Offset: 0x002899FC
			// (set) Token: 0x06009854 RID: 38996 RVA: 0x000526DC File Offset: 0x000508DC
			public unsafe DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardMoreMoney.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardMoreMoney._UseCard_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040062A5 RID: 25253
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040062A6 RID: 25254
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040062A7 RID: 25255
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x040062A8 RID: 25256
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040062A9 RID: 25257
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x040062AA RID: 25258
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x040062AB RID: 25259
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040062AC RID: 25260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040062AD RID: 25261
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062AE RID: 25262
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040062AF RID: 25263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040062B0 RID: 25264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040062B1 RID: 25265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
