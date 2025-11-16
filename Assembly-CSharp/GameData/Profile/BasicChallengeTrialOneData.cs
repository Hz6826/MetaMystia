using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace GameData.Profile
{
	// Token: 0x020002F4 RID: 756
	public class BasicChallengeTrialOneData : GeneralTrialChallengeBossData
	{
		// Token: 0x06005A6C RID: 23148 RVA: 0x001CD4A8 File Offset: 0x001CB6A8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicChallengeTrialOneData()
		{
			Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "BasicChallengeTrialOneData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr);
			BasicChallengeTrialOneData.NativeFieldInfoPtr_easyChallengeIngredientCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr, "easyChallengeIngredientCount");
			BasicChallengeTrialOneData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr, 100681434);
			BasicChallengeTrialOneData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr, 100681435);
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x001CD514 File Offset: 0x001CB714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219900, XrefRangeEnd = 220002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreloadGeneralChallenge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicChallengeTrialOneData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x001CD550 File Offset: 0x001CB750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicChallengeTrialOneData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		public BasicChallengeTrialOneData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x001CD58C File Offset: 0x001CB78C
		// (set) Token: 0x06005A71 RID: 23153 RVA: 0x00030E01 File Offset: 0x0002F001
		public unsafe int easyChallengeIngredientCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.NativeFieldInfoPtr_easyChallengeIngredientCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.NativeFieldInfoPtr_easyChallengeIngredientCount)) = value;
			}
		}

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeFieldInfoPtr_easyChallengeIngredientCount;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeMethodInfoPtr_OnPreloadGeneralChallenge_Protected_Virtual_Void_0;

		// Token: 0x04003C2F RID: 15407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB9 RID: 3257
		[ObfuscatedName("GameData.Profile.BasicChallengeTrialOneData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E92A RID: 59690 RVA: 0x0037C144 File Offset: 0x0037A344
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr);
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, "foods");
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, "bevs");
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, "ings");
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, 100681436);
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, 100681437);
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, 100681438);
				BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__5_Internal_KeyValuePair_2_Int32_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr, 100681439);
			}

			// Token: 0x0600E92B RID: 59691 RVA: 0x0037C210 File Offset: 0x0037A410
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E92C RID: 59692 RVA: 0x0037C24C File Offset: 0x0037A44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPreloadGeneralChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E92D RID: 59693 RVA: 0x0037C280 File Offset: 0x0037A480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219884, XrefRangeEnd = 219888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Il2CppStructArray<int>> _OnPreloadGeneralChallenge_b__1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr3) : null;
			}

			// Token: 0x0600E92E RID: 59694 RVA: 0x0037C2D0 File Offset: 0x0037A4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219888, XrefRangeEnd = 219891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, int> _OnPreloadGeneralChallenge_b__5(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__5_Internal_KeyValuePair_2_Int32_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, int>(pointer);
			}

			// Token: 0x0600E92F RID: 59695 RVA: 0x0007CBDC File Offset: 0x0007ADDC
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BCE RID: 19406
			// (get) Token: 0x0600E930 RID: 59696 RVA: 0x0037C318 File Offset: 0x0037A518
			// (set) Token: 0x0600E931 RID: 59697 RVA: 0x0007CBE5 File Offset: 0x0007ADE5
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BCF RID: 19407
			// (get) Token: 0x0600E932 RID: 59698 RVA: 0x0037C348 File Offset: 0x0037A548
			// (set) Token: 0x0600E933 RID: 59699 RVA: 0x0007CC04 File Offset: 0x0007AE04
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD0 RID: 19408
			// (get) Token: 0x0600E934 RID: 59700 RVA: 0x0037C378 File Offset: 0x0037A578
			// (set) Token: 0x0600E935 RID: 59701 RVA: 0x0007CC23 File Offset: 0x0007AE23
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD1 RID: 19409
			// (get) Token: 0x0600E936 RID: 59702 RVA: 0x0037C3A8 File Offset: 0x0037A5A8
			// (set) Token: 0x0600E937 RID: 59703 RVA: 0x0007CC42 File Offset: 0x0007AE42
			public unsafe BasicChallengeTrialOneData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicChallengeTrialOneData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicChallengeTrialOneData.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094BD RID: 38077
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x040094BE RID: 38078
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x040094BF RID: 38079
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x040094C0 RID: 38080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094C1 RID: 38081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094C2 RID: 38082
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0;

			// Token: 0x040094C3 RID: 38083
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Recipe_0;

			// Token: 0x040094C4 RID: 38084
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__5_Internal_KeyValuePair_2_Int32_Int32_Sellable_0;
		}

		// Token: 0x02000CBA RID: 3258
		[ObfuscatedName("GameData.Profile.BasicChallengeTrialOneData+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600E938 RID: 59704 RVA: 0x0037C3D8 File Offset: 0x0037A5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasicChallengeTrialOneData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr);
				BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, "<>9");
				BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, "<>9__1_2");
				BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, "<>9__1_3");
				BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, "<>9__1_4");
				BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, 100681441);
				BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, 100681442);
				BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_3_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, 100681443);
				BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_4_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr, 100681444);
			}

			// Token: 0x0600E939 RID: 59705 RVA: 0x0037C4A4 File Offset: 0x0037A6A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicChallengeTrialOneData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E93A RID: 59706 RVA: 0x0037C4E0 File Offset: 0x0037A6E0
			[CallerCount(0)]
			public unsafe IEnumerable<int> _OnPreloadGeneralChallenge_b__1_2(Il2CppStructArray<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600E93B RID: 59707 RVA: 0x0037C530 File Offset: 0x0037A730
			[CallerCount(0)]
			public unsafe int _OnPreloadGeneralChallenge_b__1_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_3_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E93C RID: 59708 RVA: 0x0037C57C File Offset: 0x0037A77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219891, XrefRangeEnd = 219900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, int> _OnPreloadGeneralChallenge_b__1_4(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BasicChallengeTrialOneData.__c.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_4_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, int>(pointer);
			}

			// Token: 0x0600E93D RID: 59709 RVA: 0x0007CC61 File Offset: 0x0007AE61
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BD2 RID: 19410
			// (get) Token: 0x0600E93E RID: 59710 RVA: 0x0037C5C4 File Offset: 0x0037A7C4
			// (set) Token: 0x0600E93F RID: 59711 RVA: 0x0007CC6A File Offset: 0x0007AE6A
			public unsafe static BasicChallengeTrialOneData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicChallengeTrialOneData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD3 RID: 19411
			// (get) Token: 0x0600E940 RID: 59712 RVA: 0x0037C5EC File Offset: 0x0037A7EC
			// (set) Token: 0x0600E941 RID: 59713 RVA: 0x0007CC7C File Offset: 0x0007AE7C
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__1_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD4 RID: 19412
			// (get) Token: 0x0600E942 RID: 59714 RVA: 0x0037C614 File Offset: 0x0037A814
			// (set) Token: 0x0600E943 RID: 59715 RVA: 0x0007CC8E File Offset: 0x0007AE8E
			public unsafe static Func<int, int> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD5 RID: 19413
			// (get) Token: 0x0600E944 RID: 59716 RVA: 0x0037C63C File Offset: 0x0037A83C
			// (set) Token: 0x0600E945 RID: 59717 RVA: 0x0007CCA0 File Offset: 0x0007AEA0
			public unsafe static Func<IGrouping<int, int>, KeyValuePair<int, int>> __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BasicChallengeTrialOneData.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094C5 RID: 38085
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040094C6 RID: 38086
			private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

			// Token: 0x040094C7 RID: 38087
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x040094C8 RID: 38088
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x040094C9 RID: 38089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094CA RID: 38090
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x040094CB RID: 38091
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_3_Internal_Int32_Int32_0;

			// Token: 0x040094CC RID: 38092
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__1_4_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0;
		}
	}
}
