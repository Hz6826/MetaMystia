using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002DB RID: 731
	public class KourindoStaticMerchandiseProfile : ScriptableObject
	{
		// Token: 0x060059AD RID: 22957 RVA: 0x001CB66C File Offset: 0x001C986C
		// Note: this type is marked as 'beforefieldinit'.
		static KourindoStaticMerchandiseProfile()
		{
			Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "KourindoStaticMerchandiseProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr);
			KourindoStaticMerchandiseProfile.NativeFieldInfoPtr_merchandiseCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr, "merchandiseCollection");
			KourindoStaticMerchandiseProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr, 100681354);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x001CB6C4 File Offset: 0x001C98C4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KourindoStaticMerchandiseProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KourindoStaticMerchandiseProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x000306BF File Offset: 0x0002E8BF
		public KourindoStaticMerchandiseProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x001CB700 File Offset: 0x001C9900
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x000306C8 File Offset: 0x0002E8C8
		public unsafe Il2CppReferenceArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> merchandiseCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.NativeFieldInfoPtr_merchandiseCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.NativeFieldInfoPtr_merchandiseCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BD4 RID: 15316
		private static readonly IntPtr NativeFieldInfoPtr_merchandiseCollection;

		// Token: 0x04003BD5 RID: 15317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CA8 RID: 3240
		[Serializable]
		public sealed class KourindoStaticMerchandise : ValueType
		{
			// Token: 0x0600E851 RID: 59473 RVA: 0x00379F40 File Offset: 0x00378140
			// Note: this type is marked as 'beforefieldinit'.
			static KourindoStaticMerchandise()
			{
				Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile>.NativeClassPtr, "KourindoStaticMerchandise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr);
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, "label");
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_currencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, "currencies");
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_onlyAddOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, "onlyAddOnce");
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, "product");
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Currency_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, 100681355);
				KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, 100681356);
			}

			// Token: 0x0600E852 RID: 59474 RVA: 0x00379FE4 File Offset: 0x003781E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 219570, RefRangeEnd = 219572, XrefRangeStart = 219567, XrefRangeEnd = 219570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KourindoStaticMerchandise(string label, Il2CppStructArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency> currencies, bool onlyAddOnce, Product product) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currencies);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyAddOnce;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Currency_Boolean_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E853 RID: 59475 RVA: 0x0037A06C File Offset: 0x0037826C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219572, XrefRangeEnd = 219573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNewProduct(Product newProduct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newProduct));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E854 RID: 59476 RVA: 0x0007C288 File Offset: 0x0007A488
			public KourindoStaticMerchandise(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E855 RID: 59477 RVA: 0x0007C291 File Offset: 0x0007A491
			public KourindoStaticMerchandise() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr))
			{
			}

			// Token: 0x17004B7A RID: 19322
			// (get) Token: 0x0600E856 RID: 59478 RVA: 0x0037A0B8 File Offset: 0x003782B8
			// (set) Token: 0x0600E857 RID: 59479 RVA: 0x0007C2A3 File Offset: 0x0007A4A3
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B7B RID: 19323
			// (get) Token: 0x0600E858 RID: 59480 RVA: 0x0037A0E0 File Offset: 0x003782E0
			// (set) Token: 0x0600E859 RID: 59481 RVA: 0x0007C2C2 File Offset: 0x0007A4C2
			public unsafe Il2CppStructArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency> currencies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_currencies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_currencies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B7C RID: 19324
			// (get) Token: 0x0600E85A RID: 59482 RVA: 0x0037A110 File Offset: 0x00378310
			// (set) Token: 0x0600E85B RID: 59483 RVA: 0x0007C2E1 File Offset: 0x0007A4E1
			public unsafe bool onlyAddOnce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_onlyAddOnce);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_onlyAddOnce)) = value;
				}
			}

			// Token: 0x17004B7D RID: 19325
			// (get) Token: 0x0600E85C RID: 59484 RVA: 0x0037A138 File Offset: 0x00378338
			// (set) Token: 0x0600E85D RID: 59485 RVA: 0x0007C2FC File Offset: 0x0007A4FC
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009438 RID: 37944
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009439 RID: 37945
			private static readonly IntPtr NativeFieldInfoPtr_currencies;

			// Token: 0x0400943A RID: 37946
			private static readonly IntPtr NativeFieldInfoPtr_onlyAddOnce;

			// Token: 0x0400943B RID: 37947
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400943C RID: 37948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Currency_Boolean_Product_0;

			// Token: 0x0400943D RID: 37949
			private static readonly IntPtr NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0;

			// Token: 0x0200105F RID: 4191
			[Serializable]
			[StructLayout(2)]
			public struct Currency
			{
				// Token: 0x06011E6B RID: 73323 RVA: 0x00417F68 File Offset: 0x00416168
				// Note: this type is marked as 'beforefieldinit'.
				static Currency()
				{
					Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, "Currency");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr);
					KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr, "price");
					KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr, "Id");
					KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.NativeFieldInfoPtr_currencyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr, "currencyType");
					KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.NativeMethodInfoPtr__ctor_Public_Void_CurrencyType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr, 100681357);
				}

				// Token: 0x06011E6C RID: 73324 RVA: 0x00417FE4 File Offset: 0x004161E4
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 219566, RefRangeEnd = 219567, XrefRangeStart = 219566, XrefRangeEnd = 219566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Currency(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType currencyType, int price, int id)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref currencyType;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.NativeMethodInfoPtr__ctor_Public_Void_CurrencyType_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E6D RID: 73325 RVA: 0x0009B8AA File Offset: 0x00099AAA
				public Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>.NativeClassPtr, ref this));
				}

				// Token: 0x0400B4F8 RID: 46328
				private static readonly IntPtr NativeFieldInfoPtr_price;

				// Token: 0x0400B4F9 RID: 46329
				private static readonly IntPtr NativeFieldInfoPtr_Id;

				// Token: 0x0400B4FA RID: 46330
				private static readonly IntPtr NativeFieldInfoPtr_currencyType;

				// Token: 0x0400B4FB RID: 46331
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CurrencyType_Int32_Int32_0;

				// Token: 0x0400B4FC RID: 46332
				[FieldOffset(0)]
				public int price;

				// Token: 0x0400B4FD RID: 46333
				[FieldOffset(4)]
				public int Id;

				// Token: 0x0400B4FE RID: 46334
				[FieldOffset(8)]
				public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType currencyType;

				// Token: 0x020010E2 RID: 4322
				public enum CurrencyType
				{
					// Token: 0x0400B935 RID: 47413
					Fund,
					// Token: 0x0400B936 RID: 47414
					Item,
					// Token: 0x0400B937 RID: 47415
					Cooker
				}
			}
		}
	}
}
