using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200011C RID: 284
	public class ProductReference : Object
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x00108E00 File Offset: 0x00107000
		// Note: this type is marked as 'beforefieldinit'.
		static ProductReference()
		{
			Il2CppClassPointerStore<ProductReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "ProductReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductReference>.NativeClassPtr);
			ProductReference.NativeFieldInfoPtr__Product_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductReference>.NativeClassPtr, "<Product>k__BackingField");
			ProductReference.NativeMethodInfoPtr_get_Product_Public_get_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductReference>.NativeClassPtr, 100668922);
			ProductReference.NativeMethodInfoPtr_set_Product_Public_set_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductReference>.NativeClassPtr, 100668923);
			ProductReference.NativeMethodInfoPtr__ctor_Public_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductReference>.NativeClassPtr, 100668924);
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00108E80 File Offset: 0x00107080
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00108EB8 File Offset: 0x001070B8
		public unsafe Product Product
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ProductReference.NativeMethodInfoPtr_get_Product_Public_get_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78309, XrefRangeEnd = 78310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductReference.NativeMethodInfoPtr_set_Product_Public_set_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00108F00 File Offset: 0x00107100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78312, RefRangeEnd = 78313, XrefRangeStart = 78310, XrefRangeEnd = 78312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductReference(Product product) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductReference>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductReference.NativeMethodInfoPtr__ctor_Public_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00013776 File Offset: 0x00011976
		public ProductReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x00108F50 File Offset: 0x00107150
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0001377F File Offset: 0x0001197F
		public Product _Product_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductReference.NativeFieldInfoPtr__Product_k__BackingField);
				return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductReference.NativeFieldInfoPtr__Product_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeFieldInfoPtr__Product_k__BackingField;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_get_Product_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_set_Product_Public_set_Void_Product_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Product_0;
	}
}
