using System;
using System.Runtime.InteropServices;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x0200029C RID: 668
	[Serializable]
	public sealed class Product : ValueType
	{
		// Token: 0x06005517 RID: 21783 RVA: 0x001BD6FC File Offset: 0x001BB8FC
		// Note: this type is marked as 'beforefieldinit'.
		static Product()
		{
			Il2CppClassPointerStore<Product>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "Product");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product>.NativeClassPtr);
			Product.NativeFieldInfoPtr_productType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "productType");
			Product.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "productId");
			Product.NativeFieldInfoPtr_productLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "productLabel");
			Product.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "productAmount");
			Product.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680680);
			Product.NativeMethodInfoPtr_SetProductAmount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680681);
			Product.NativeMethodInfoPtr_UnfoldProductIds_Public_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680682);
			Product.NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680683);
			Product.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680684);
			Product.NativeMethodInfoPtr_GetPerPrice_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680685);
			Product.NativeMethodInfoPtr_GetPrice_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680686);
			Product.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680687);
			Product.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680688);
			Product.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680689);
			Product.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680690);
			Product.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680691);
			Product.NativeMethodInfoPtr_MergeAndDistinctEqualedProduct_Public_Static_List_1_Product_IEnumerable_1_Product_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680692);
			Product.NativeMethodInfoPtr_InsertEqualedProduct_Public_Static_Void_List_1_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100680693);
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x001BD894 File Offset: 0x001BBA94
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 212650, RefRangeEnd = 212682, XrefRangeStart = 212649, XrefRangeEnd = 212650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product(Product.ProductType productType, int productId, int productAmount, string productLabel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref productType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x001BD910 File Offset: 0x001BBB10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138385, RefRangeEnd = 138389, XrefRangeStart = 138385, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProductAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_SetProductAmount_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x001BD954 File Offset: 0x001BBB54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212685, RefRangeEnd = 212692, XrefRangeStart = 212682, XrefRangeEnd = 212685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<int> UnfoldProductIds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_UnfoldProductIds_Public_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x001BD998 File Offset: 0x001BBB98
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 212705, RefRangeEnd = 212717, XrefRangeStart = 212692, XrefRangeEnd = 212705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectLanguageBase GetText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x001BD9DC File Offset: 0x001BBBDC
		[CallerCount(0)]
		public unsafe static bool Equals(Product left, Product right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_Equals_Public_Static_Boolean_Product_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x001BDA3C File Offset: 0x001BBC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212723, RefRangeEnd = 212724, XrefRangeStart = 212717, XrefRangeEnd = 212723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPerPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_GetPerPrice_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x001BDA80 File Offset: 0x001BBC80
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212726, RefRangeEnd = 212732, XrefRangeStart = 212724, XrefRangeEnd = 212726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_GetPrice_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x001BDAC4 File Offset: 0x001BBCC4
		[CallerCount(0)]
		public unsafe static bool operator ==(Product left, Product right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Product_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x001BDB24 File Offset: 0x001BBD24
		[CallerCount(0)]
		public unsafe static bool operator !=(Product left, Product right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Product_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x001BDB84 File Offset: 0x001BBD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212732, XrefRangeEnd = 212736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x001BDBD8 File Offset: 0x001BBDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212736, XrefRangeEnd = 212740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x001BDC1C File Offset: 0x001BBE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212740, XrefRangeEnd = 212744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x001BDC58 File Offset: 0x001BBE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212811, RefRangeEnd = 212813, XrefRangeStart = 212744, XrefRangeEnd = 212811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Product> MergeAndDistinctEqualedProduct(IEnumerable<Product> products, bool needOrderByType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needOrderByType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_MergeAndDistinctEqualedProduct_Public_Static_List_1_Product_IEnumerable_1_Product_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr3) : null;
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x001BDCAC File Offset: 0x001BBEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212813, XrefRangeEnd = 212834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertEqualedProduct(List<Product> productList, Product element)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(element));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_InsertEqualedProduct_Public_Static_Void_List_1_Product_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0002DCA5 File Offset: 0x0002BEA5
		public Product(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0002DCAE File Offset: 0x0002BEAE
		public Product() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product>.NativeClassPtr))
		{
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x001BDCFC File Offset: 0x001BBEFC
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		public unsafe Product.ProductType productType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productType)) = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x001BDD24 File Offset: 0x001BBF24
		// (set) Token: 0x0600552B RID: 21803 RVA: 0x0002DCDB File Offset: 0x0002BEDB
		public unsafe int productId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productId)) = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x001BDD4C File Offset: 0x001BBF4C
		// (set) Token: 0x0600552D RID: 21805 RVA: 0x0002DCF6 File Offset: 0x0002BEF6
		public unsafe string productLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x0600552E RID: 21806 RVA: 0x001BDD74 File Offset: 0x001BBF74
		// (set) Token: 0x0600552F RID: 21807 RVA: 0x0002DD15 File Offset: 0x0002BF15
		public unsafe int productAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr_productAmount)) = value;
			}
		}

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeFieldInfoPtr_productType;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeFieldInfoPtr_productId;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeFieldInfoPtr_productLabel;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeFieldInfoPtr_productAmount;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_Int32_String_0;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeMethodInfoPtr_SetProductAmount_Public_Void_Int32_0;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeMethodInfoPtr_UnfoldProductIds_Public_IEnumerable_1_Int32_0;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_0;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_Product_Product_0;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeMethodInfoPtr_GetPerPrice_Public_Int32_0;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeMethodInfoPtr_GetPrice_Public_Int32_0;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Product_Product_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Product_Product_0;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeMethodInfoPtr_MergeAndDistinctEqualedProduct_Public_Static_List_1_Product_IEnumerable_1_Product_Boolean_0;

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeMethodInfoPtr_InsertEqualedProduct_Public_Static_Void_List_1_Product_Product_0;

		// Token: 0x02000C47 RID: 3143
		public enum ProductType
		{
			// Token: 0x04009169 RID: 37225
			Food,
			// Token: 0x0400916A RID: 37226
			Ingredient,
			// Token: 0x0400916B RID: 37227
			Beverage,
			// Token: 0x0400916C RID: 37228
			Money,
			// Token: 0x0400916D RID: 37229
			Mission,
			// Token: 0x0400916E RID: 37230
			Item,
			// Token: 0x0400916F RID: 37231
			Recipe,
			// Token: 0x04009170 RID: 37232
			Izakaya,
			// Token: 0x04009171 RID: 37233
			Cooker,
			// Token: 0x04009172 RID: 37234
			Partner,
			// Token: 0x04009173 RID: 37235
			Badge,
			// Token: 0x04009174 RID: 37236
			Trophy
		}

		// Token: 0x02000C48 RID: 3144
		[StructLayout(2)]
		public struct ProductKey
		{
			// Token: 0x0600E382 RID: 58242 RVA: 0x0036C4C4 File Offset: 0x0036A6C4
			// Note: this type is marked as 'beforefieldinit'.
			static ProductKey()
			{
				Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product>.NativeClassPtr, "ProductKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr);
				Product.ProductKey.NativeFieldInfoPtr_ProductType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr, "ProductType");
				Product.ProductKey.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr, "Id");
				Product.ProductKey.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr, 100680694);
			}

			// Token: 0x0600E383 RID: 58243 RVA: 0x0036C52C File Offset: 0x0036A72C
			[CallerCount(104)]
			[CachedScanResults(RefRangeStart = 395, RefRangeEnd = 499, XrefRangeStart = 395, XrefRangeEnd = 499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductKey(Product.ProductType productType, int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref productType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.ProductKey.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E384 RID: 58244 RVA: 0x000795B8 File Offset: 0x000777B8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product.ProductKey>.NativeClassPtr, ref this));
			}

			// Token: 0x04009175 RID: 37237
			private static readonly IntPtr NativeFieldInfoPtr_ProductType;

			// Token: 0x04009176 RID: 37238
			private static readonly IntPtr NativeFieldInfoPtr_Id;

			// Token: 0x04009177 RID: 37239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_0;

			// Token: 0x04009178 RID: 37240
			[FieldOffset(0)]
			public Product.ProductType ProductType;

			// Token: 0x04009179 RID: 37241
			[FieldOffset(4)]
			public int Id;
		}

		// Token: 0x02000C49 RID: 3145
		public class ProductKeyEqualityComparer : Object
		{
			// Token: 0x0600E385 RID: 58245 RVA: 0x0036C56C File Offset: 0x0036A76C
			// Note: this type is marked as 'beforefieldinit'.
			static ProductKeyEqualityComparer()
			{
				Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product>.NativeClassPtr, "ProductKeyEqualityComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr);
				Product.ProductKeyEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProductKey_ProductKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr, 100680695);
				Product.ProductKeyEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ProductKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr, 100680696);
				Product.ProductKeyEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr, 100680697);
			}

			// Token: 0x0600E386 RID: 58246 RVA: 0x0036C5D4 File Offset: 0x0036A7D4
			[CallerCount(0)]
			public unsafe virtual bool Equals(Product.ProductKey x, Product.ProductKey y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.ProductKeyEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProductKey_ProductKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E387 RID: 58247 RVA: 0x0036C62C File Offset: 0x0036A82C
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(Product.ProductKey obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.ProductKeyEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ProductKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E388 RID: 58248 RVA: 0x0036C678 File Offset: 0x0036A878
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductKeyEqualityComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product.ProductKeyEqualityComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.ProductKeyEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E389 RID: 58249 RVA: 0x000795CA File Offset: 0x000777CA
			public ProductKeyEqualityComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400917A RID: 37242
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ProductKey_ProductKey_0;

			// Token: 0x0400917B RID: 37243
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ProductKey_0;

			// Token: 0x0400917C RID: 37244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C4A RID: 3146
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.Product+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E38A RID: 58250 RVA: 0x0036C6B4 File Offset: 0x0036A8B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Product.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product.__c>.NativeClassPtr);
				Product.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product.__c>.NativeClassPtr, "<>9");
				Product.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product.__c>.NativeClassPtr, "<>9__19_0");
				Product.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.__c>.NativeClassPtr, 100680699);
				Product.__c.NativeMethodInfoPtr__MergeAndDistinctEqualedProduct_b__19_0_Internal_ProductType_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product.__c>.NativeClassPtr, 100680700);
			}

			// Token: 0x0600E38B RID: 58251 RVA: 0x0036C730 File Offset: 0x0036A930
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E38C RID: 58252 RVA: 0x0036C76C File Offset: 0x0036A96C
			[CallerCount(0)]
			public unsafe Product.ProductType _MergeAndDistinctEqualedProduct_b__19_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.__c.NativeMethodInfoPtr__MergeAndDistinctEqualedProduct_b__19_0_Internal_ProductType_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E38D RID: 58253 RVA: 0x000795D3 File Offset: 0x000777D3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049DF RID: 18911
			// (get) Token: 0x0600E38E RID: 58254 RVA: 0x0036C7C0 File Offset: 0x0036A9C0
			// (set) Token: 0x0600E38F RID: 58255 RVA: 0x000795DC File Offset: 0x000777DC
			public unsafe static Product.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E0 RID: 18912
			// (get) Token: 0x0600E390 RID: 58256 RVA: 0x0036C7E8 File Offset: 0x0036A9E8
			// (set) Token: 0x0600E391 RID: 58257 RVA: 0x000795EE File Offset: 0x000777EE
			public unsafe static Func<Product, Product.ProductType> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, Product.ProductType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400917D RID: 37245
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400917E RID: 37246
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400917F RID: 37247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009180 RID: 37248
			private static readonly IntPtr NativeMethodInfoPtr__MergeAndDistinctEqualedProduct_b__19_0_Internal_ProductType_Product_0;
		}
	}
}
