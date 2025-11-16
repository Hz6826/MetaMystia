using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x02000225 RID: 549
	[Serializable]
	public class TrackedMerchant : Object
	{
		// Token: 0x06004168 RID: 16744 RVA: 0x0017E5C4 File Offset: 0x0017C7C4
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedMerchant()
		{
			Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.DaySceneUtility.Collection", "TrackedMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr);
			TrackedMerchant.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, "key");
			TrackedMerchant.NativeFieldInfoPtr_currentPriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, "currentPriceMultiplier");
			TrackedMerchant.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, "products");
			TrackedMerchant.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, 100675652);
			TrackedMerchant.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, 100675653);
			TrackedMerchant.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, 100675654);
			TrackedMerchant.NativeMethodInfoPtr_GenerateProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, 100675655);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x0017E680 File Offset: 0x0017C880
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedMerchant(string key) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x0017E6CC File Offset: 0x0017C8CC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x0017E708 File Offset: 0x0017C908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161135, XrefRangeEnd = 161150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrackedMerchant Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr3) : null;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x0017E748 File Offset: 0x0017C948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161208, RefRangeEnd = 161211, XrefRangeStart = 161150, XrefRangeEnd = 161208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.NativeMethodInfoPtr_GenerateProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x00023714 File Offset: 0x00021914
		public TrackedMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x0017E77C File Offset: 0x0017C97C
		// (set) Token: 0x0600416F RID: 16751 RVA: 0x0002371D File Offset: 0x0002191D
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x0017E7A4 File Offset: 0x0017C9A4
		// (set) Token: 0x06004171 RID: 16753 RVA: 0x0002373C File Offset: 0x0002193C
		public unsafe float currentPriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_currentPriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_currentPriceMultiplier)) = value;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x0017E7CC File Offset: 0x0017C9CC
		// (set) Token: 0x06004173 RID: 16755 RVA: 0x00023757 File Offset: 0x00021957
		public unsafe Il2CppReferenceArray<Product> products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeFieldInfoPtr_currentPriceMultiplier;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeFieldInfoPtr_products;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedMerchant_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_GenerateProduct_Public_Void_0;

		// Token: 0x020009F6 RID: 2550
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.Collection.TrackedMerchant+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600C323 RID: 49955 RVA: 0x0030974C File Offset: 0x0030794C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedMerchant>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr);
				TrackedMerchant.__c__DisplayClass6_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr, "item");
				TrackedMerchant.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr, 100675656);
				TrackedMerchant.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateProduct_b__0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr, 100675657);
			}

			// Token: 0x0600C324 RID: 49956 RVA: 0x003097B4 File Offset: 0x003079B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedMerchant.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C325 RID: 49957 RVA: 0x003097F0 File Offset: 0x003079F0
			[CallerCount(0)]
			public unsafe bool _GenerateProduct_b__0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedMerchant.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateProduct_b__0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C326 RID: 49958 RVA: 0x000692A8 File Offset: 0x000674A8
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F7E RID: 16254
			// (get) Token: 0x0600C327 RID: 49959 RVA: 0x00309844 File Offset: 0x00307A44
			// (set) Token: 0x0600C328 RID: 49960 RVA: 0x000692B1 File Offset: 0x000674B1
			public Product item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.__c__DisplayClass6_0.NativeFieldInfoPtr_item);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedMerchant.__c__DisplayClass6_0.NativeFieldInfoPtr_item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007D92 RID: 32146
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04007D93 RID: 32147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D94 RID: 32148
			private static readonly IntPtr NativeMethodInfoPtr__GenerateProduct_b__0_Internal_Boolean_Product_0;
		}
	}
}
