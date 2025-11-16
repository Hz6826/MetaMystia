using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x02000223 RID: 547
	[Serializable]
	public class TrackedCollectable : Object
	{
		// Token: 0x0600414E RID: 16718 RVA: 0x0017E0BC File Offset: 0x0017C2BC
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedCollectable()
		{
			Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.DaySceneUtility.Collection", "TrackedCollectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr);
			TrackedCollectable.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "key");
			TrackedCollectable.NativeFieldInfoPtr_currentCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "currentCoolDown");
			TrackedCollectable.NativeFieldInfoPtr_openStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "openStatus");
			TrackedCollectable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675628);
			TrackedCollectable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675629);
			TrackedCollectable.NativeMethodInfoPtr__ctor_Public_Void_Collectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675630);
			TrackedCollectable.NativeMethodInfoPtr_get_Availabile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675631);
			TrackedCollectable.NativeMethodInfoPtr_Collect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675632);
			TrackedCollectable.NativeMethodInfoPtr_TryUpdateCoolDown_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675633);
			TrackedCollectable.NativeMethodInfoPtr_RefreshCoolDownImmediately_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, 100675634);
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x0017E1B4 File Offset: 0x0017C3B4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedCollectable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x0017E1F0 File Offset: 0x0017C3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160960, XrefRangeEnd = 160974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrackedCollectable Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedCollectable>(intPtr3) : null;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x0017E230 File Offset: 0x0017C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160974, XrefRangeEnd = 160976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedCollectable(Collectable collectable) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(collectable));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr__ctor_Public_Void_Collectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x0017E280 File Offset: 0x0017C480
		public unsafe bool Availabile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr_get_Availabile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x0017E2BC File Offset: 0x0017C4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161110, RefRangeEnd = 161111, XrefRangeStart = 160976, XrefRangeEnd = 161110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Collect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr_Collect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x0017E2F0 File Offset: 0x0017C4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161111, XrefRangeEnd = 161115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateCoolDown(int actionPassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionPassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr_TryUpdateCoolDown_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x0017E330 File Offset: 0x0017C530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161115, RefRangeEnd = 161119, XrefRangeStart = 161115, XrefRangeEnd = 161115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCoolDownImmediately()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.NativeMethodInfoPtr_RefreshCoolDownImmediately_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00023658 File Offset: 0x00021858
		public TrackedCollectable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x0017E364 File Offset: 0x0017C564
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x00023661 File Offset: 0x00021861
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x0017E38C File Offset: 0x0017C58C
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x00023680 File Offset: 0x00021880
		public unsafe int currentCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_currentCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_currentCoolDown)) = value;
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x0017E3B4 File Offset: 0x0017C5B4
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x0002369B File Offset: 0x0002189B
		public unsafe bool openStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_openStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.NativeFieldInfoPtr_openStatus)) = value;
			}
		}

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeFieldInfoPtr_currentCoolDown;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeFieldInfoPtr_openStatus;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedCollectable_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Collectable_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_get_Availabile_Public_get_Boolean_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_Collect_Public_Void_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateCoolDown_Public_Void_Int32_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCoolDownImmediately_Public_Void_0;

		// Token: 0x020009F2 RID: 2546
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600C2F8 RID: 49912 RVA: 0x00308F48 File Offset: 0x00307148
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr);
				TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_productList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, "productList");
				TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, "value");
				TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_luckyLeafBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, "luckyLeafBuff");
				TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, 100675635);
				TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, 100675636);
				TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr__Collect_b__2_Internal_Product_IGrouping_2___f__AnonymousType0_3_ProductType_Int32_String_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr, 100675637);
			}

			// Token: 0x0600C2F9 RID: 49913 RVA: 0x00308FEC File Offset: 0x003071EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2FA RID: 49914 RVA: 0x00309028 File Offset: 0x00307228
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 160868, RefRangeEnd = 160870, XrefRangeStart = 160860, XrefRangeEnd = 160868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2FB RID: 49915 RVA: 0x0030905C File Offset: 0x0030725C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160870, XrefRangeEnd = 160916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _Collect_b__2(IGrouping<__f__AnonymousType0<Product.ProductType, int, string>, Product> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_0.NativeMethodInfoPtr__Collect_b__2_Internal_Product_IGrouping_2___f__AnonymousType0_3_ProductType_Int32_String_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x0600C2FC RID: 49916 RVA: 0x00069154 File Offset: 0x00067354
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F73 RID: 16243
			// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x003090A4 File Offset: 0x003072A4
			// (set) Token: 0x0600C2FE RID: 49918 RVA: 0x0006915D File Offset: 0x0006735D
			public unsafe List<Product> productList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_productList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_productList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F74 RID: 16244
			// (get) Token: 0x0600C2FF RID: 49919 RVA: 0x003090D4 File Offset: 0x003072D4
			// (set) Token: 0x0600C300 RID: 49920 RVA: 0x0006917C File Offset: 0x0006737C
			public Collectable value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_value);
					return new Collectable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Collectable>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Collectable>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003F75 RID: 16245
			// (get) Token: 0x0600C301 RID: 49921 RVA: 0x00309104 File Offset: 0x00307304
			// (set) Token: 0x0600C302 RID: 49922 RVA: 0x000691AA File Offset: 0x000673AA
			public unsafe int luckyLeafBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_luckyLeafBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_0.NativeFieldInfoPtr_luckyLeafBuff)) = value;
				}
			}

			// Token: 0x04007D7A RID: 32122
			private static readonly IntPtr NativeFieldInfoPtr_productList;

			// Token: 0x04007D7B RID: 32123
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04007D7C RID: 32124
			private static readonly IntPtr NativeFieldInfoPtr_luckyLeafBuff;

			// Token: 0x04007D7D RID: 32125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D7E RID: 32126
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04007D7F RID: 32127
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__2_Internal_Product_IGrouping_2___f__AnonymousType0_3_ProductType_Int32_String_Product_0;
		}

		// Token: 0x020009F3 RID: 2547
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Object
		{
			// Token: 0x0600C303 RID: 49923 RVA: 0x0030912C File Offset: 0x0030732C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr);
				TrackedCollectable.__c__DisplayClass8_1.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr, "product");
				TrackedCollectable.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr, 100675638);
				TrackedCollectable.__c__DisplayClass8_1.NativeMethodInfoPtr__Collect_b__7_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr, 100675639);
			}

			// Token: 0x0600C304 RID: 49924 RVA: 0x00309194 File Offset: 0x00307394
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C305 RID: 49925 RVA: 0x003091D0 File Offset: 0x003073D0
			[CallerCount(0)]
			public unsafe int _Collect_b__7(int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_1.NativeMethodInfoPtr__Collect_b__7_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C306 RID: 49926 RVA: 0x000691C5 File Offset: 0x000673C5
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F76 RID: 16246
			// (get) Token: 0x0600C307 RID: 49927 RVA: 0x0030921C File Offset: 0x0030741C
			// (set) Token: 0x0600C308 RID: 49928 RVA: 0x000691CE File Offset: 0x000673CE
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_1.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_1.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007D80 RID: 32128
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04007D81 RID: 32129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D82 RID: 32130
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__7_Internal_Int32_Int32_0;
		}

		// Token: 0x020009F4 RID: 2548
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable+<>c__DisplayClass8_2")]
		public sealed class __c__DisplayClass8_2 : Object
		{
			// Token: 0x0600C309 RID: 49929 RVA: 0x0030924C File Offset: 0x0030744C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_2()
			{
				Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "<>c__DisplayClass8_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr);
				TrackedCollectable.__c__DisplayClass8_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr, "x");
				TrackedCollectable.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr, 100675640);
				TrackedCollectable.__c__DisplayClass8_2.NativeMethodInfoPtr__Collect_b__8_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr, 100675641);
			}

			// Token: 0x0600C30A RID: 49930 RVA: 0x003092B4 File Offset: 0x003074B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable.__c__DisplayClass8_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30B RID: 49931 RVA: 0x003092F0 File Offset: 0x003074F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160916, XrefRangeEnd = 160929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Collect_b__8(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c__DisplayClass8_2.NativeMethodInfoPtr__Collect_b__8_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30C RID: 49932 RVA: 0x000691FC File Offset: 0x000673FC
			public __c__DisplayClass8_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F77 RID: 16247
			// (get) Token: 0x0600C30D RID: 49933 RVA: 0x00309334 File Offset: 0x00307534
			// (set) Token: 0x0600C30E RID: 49934 RVA: 0x00069205 File Offset: 0x00067405
			public Product x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_2.NativeFieldInfoPtr_x);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedCollectable.__c__DisplayClass8_2.NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007D83 RID: 32131
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04007D84 RID: 32132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D85 RID: 32133
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_Internal_Void_AchievementNotifyResult_0;
		}

		// Token: 0x020009F5 RID: 2549
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedCollectable+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C30F RID: 49935 RVA: 0x00309364 File Offset: 0x00307564
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedCollectable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr);
				TrackedCollectable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9");
				TrackedCollectable.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9__8_1");
				TrackedCollectable.__c.NativeFieldInfoPtr___9__8_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9__8_5");
				TrackedCollectable.__c.NativeFieldInfoPtr___9__8_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9__8_6");
				TrackedCollectable.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9__8_3");
				TrackedCollectable.__c.NativeFieldInfoPtr___9__8_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, "<>9__8_4");
				TrackedCollectable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675643);
				TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_1_Internal___f__AnonymousType0_3_ProductType_Int32_String_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675644);
				TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_5_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675645);
				TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_6_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675646);
				TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_3_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675647);
				TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_4_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr, 100675648);
			}

			// Token: 0x0600C310 RID: 49936 RVA: 0x00309480 File Offset: 0x00307680
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedCollectable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C311 RID: 49937 RVA: 0x003094BC File Offset: 0x003076BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160929, XrefRangeEnd = 160935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Product.ProductType, int, string> _Collect_b__8_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_1_Internal___f__AnonymousType0_3_ProductType_Int32_String_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Product.ProductType, int, string>>(intPtr3) : null;
			}

			// Token: 0x0600C312 RID: 49938 RVA: 0x00309514 File Offset: 0x00307714
			[CallerCount(0)]
			public unsafe int _Collect_b__8_5(Product y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_5_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C313 RID: 49939 RVA: 0x00309568 File Offset: 0x00307768
			[CallerCount(0)]
			public unsafe int _Collect_b__8_6(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_6_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C314 RID: 49940 RVA: 0x003095C0 File Offset: 0x003077C0
			[CallerCount(0)]
			public unsafe bool _Collect_b__8_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_3_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C315 RID: 49941 RVA: 0x00309614 File Offset: 0x00307814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160935, XrefRangeEnd = 160960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Collect_b__8_4(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedCollectable.__c.NativeMethodInfoPtr__Collect_b__8_4_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C316 RID: 49942 RVA: 0x00069233 File Offset: 0x00067433
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F78 RID: 16248
			// (get) Token: 0x0600C317 RID: 49943 RVA: 0x0030965C File Offset: 0x0030785C
			// (set) Token: 0x0600C318 RID: 49944 RVA: 0x0006923C File Offset: 0x0006743C
			public unsafe static TrackedCollectable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedCollectable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F79 RID: 16249
			// (get) Token: 0x0600C319 RID: 49945 RVA: 0x00309684 File Offset: 0x00307884
			// (set) Token: 0x0600C31A RID: 49946 RVA: 0x0006924E File Offset: 0x0006744E
			public unsafe static Func<Product, __f__AnonymousType0<Product.ProductType, int, string>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, __f__AnonymousType0<Product.ProductType, int, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7A RID: 16250
			// (get) Token: 0x0600C31B RID: 49947 RVA: 0x003096AC File Offset: 0x003078AC
			// (set) Token: 0x0600C31C RID: 49948 RVA: 0x00069260 File Offset: 0x00067460
			public unsafe static Func<Product, int> __9__8_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7B RID: 16251
			// (get) Token: 0x0600C31D RID: 49949 RVA: 0x003096D4 File Offset: 0x003078D4
			// (set) Token: 0x0600C31E RID: 49950 RVA: 0x00069272 File Offset: 0x00067472
			public unsafe static Func<int, int, int> __9__8_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7C RID: 16252
			// (get) Token: 0x0600C31F RID: 49951 RVA: 0x003096FC File Offset: 0x003078FC
			// (set) Token: 0x0600C320 RID: 49952 RVA: 0x00069284 File Offset: 0x00067484
			public unsafe static Func<Product, bool> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F7D RID: 16253
			// (get) Token: 0x0600C321 RID: 49953 RVA: 0x00309724 File Offset: 0x00307924
			// (set) Token: 0x0600C322 RID: 49954 RVA: 0x00069296 File Offset: 0x00067496
			public unsafe static Action<Product> __9__8_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrackedCollectable.__c.NativeFieldInfoPtr___9__8_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D86 RID: 32134
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D87 RID: 32135
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04007D88 RID: 32136
			private static readonly IntPtr NativeFieldInfoPtr___9__8_5;

			// Token: 0x04007D89 RID: 32137
			private static readonly IntPtr NativeFieldInfoPtr___9__8_6;

			// Token: 0x04007D8A RID: 32138
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x04007D8B RID: 32139
			private static readonly IntPtr NativeFieldInfoPtr___9__8_4;

			// Token: 0x04007D8C RID: 32140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D8D RID: 32141
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_1_Internal___f__AnonymousType0_3_ProductType_Int32_String_Product_0;

			// Token: 0x04007D8E RID: 32142
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_5_Internal_Int32_Product_0;

			// Token: 0x04007D8F RID: 32143
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_6_Internal_Int32_Int32_Int32_0;

			// Token: 0x04007D90 RID: 32144
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_3_Internal_Boolean_Product_0;

			// Token: 0x04007D91 RID: 32145
			private static readonly IntPtr NativeMethodInfoPtr__Collect_b__8_4_Internal_Void_Product_0;
		}
	}
}
