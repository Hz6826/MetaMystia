using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000299 RID: 665
	[Serializable]
	public sealed class Collectable : ValueType
	{
		// Token: 0x060054DE RID: 21726 RVA: 0x001BCDDC File Offset: 0x001BAFDC
		// Note: this type is marked as 'beforefieldinit'.
		static Collectable()
		{
			Il2CppClassPointerStore<Collectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "Collectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collectable>.NativeClassPtr);
			Collectable.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "key");
			Collectable.NativeFieldInfoPtr_offByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "offByDefault");
			Collectable.NativeFieldInfoPtr_showTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "showTime");
			Collectable.NativeFieldInfoPtr_primaryProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "primaryProduct");
			Collectable.NativeFieldInfoPtr_secondaryProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "secondaryProduct");
			Collectable.NativeFieldInfoPtr_regenerateHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "regenerateHours");
			Collectable.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Vector2Int_Int32_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_ProbabilityDrivenProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collectable>.NativeClassPtr, 100680663);
			Collectable.NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collectable>.NativeClassPtr, 100680664);
			Collectable.NativeMethodInfoPtr_GetRegenerateActions_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collectable>.NativeClassPtr, 100680665);
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x001BCEC0 File Offset: 0x001BB0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212574, XrefRangeEnd = 212577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collectable(string key, bool offByDefault, Vector2Int showTime, int regenerateHours, Il2CppReferenceArray<Product> primaryProduct, Il2CppReferenceArray<Collectable.ProbabilityDrivenProduct> secondaryProduct) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collectable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offByDefault;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref regenerateHours;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryProduct);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collectable.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Vector2Int_Int32_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_ProbabilityDrivenProduct_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x001BCF60 File Offset: 0x001BB160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212577, RefRangeEnd = 212580, XrefRangeStart = 212577, XrefRangeEnd = 212577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetTrueShowAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collectable.NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x001BCFA4 File Offset: 0x001BB1A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212580, RefRangeEnd = 212581, XrefRangeStart = 212580, XrefRangeEnd = 212580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRegenerateActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collectable.NativeMethodInfoPtr_GetRegenerateActions_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x0002DA33 File Offset: 0x0002BC33
		public Collectable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x0002DA3C File Offset: 0x0002BC3C
		public Collectable() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collectable>.NativeClassPtr))
		{
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x060054E4 RID: 21732 RVA: 0x001BCFE8 File Offset: 0x001BB1E8
		// (set) Token: 0x060054E5 RID: 21733 RVA: 0x0002DA4E File Offset: 0x0002BC4E
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x001BD010 File Offset: 0x001BB210
		// (set) Token: 0x060054E7 RID: 21735 RVA: 0x0002DA6D File Offset: 0x0002BC6D
		public unsafe bool offByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_offByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_offByDefault)) = value;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x001BD038 File Offset: 0x001BB238
		// (set) Token: 0x060054E9 RID: 21737 RVA: 0x0002DA88 File Offset: 0x0002BC88
		public unsafe Vector2Int showTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_showTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_showTime)) = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x001BD060 File Offset: 0x001BB260
		// (set) Token: 0x060054EB RID: 21739 RVA: 0x0002DAA3 File Offset: 0x0002BCA3
		public unsafe Il2CppReferenceArray<Product> primaryProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_primaryProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_primaryProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060054EC RID: 21740 RVA: 0x001BD090 File Offset: 0x001BB290
		// (set) Token: 0x060054ED RID: 21741 RVA: 0x0002DAC2 File Offset: 0x0002BCC2
		public unsafe Il2CppReferenceArray<Collectable.ProbabilityDrivenProduct> secondaryProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_secondaryProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collectable.ProbabilityDrivenProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_secondaryProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060054EE RID: 21742 RVA: 0x001BD0C0 File Offset: 0x001BB2C0
		// (set) Token: 0x060054EF RID: 21743 RVA: 0x0002DAE1 File Offset: 0x0002BCE1
		public unsafe int regenerateHours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_regenerateHours);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.NativeFieldInfoPtr_regenerateHours)) = value;
			}
		}

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeFieldInfoPtr_offByDefault;

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeFieldInfoPtr_showTime;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeFieldInfoPtr_primaryProduct;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeFieldInfoPtr_secondaryProduct;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeFieldInfoPtr_regenerateHours;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Vector2Int_Int32_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_ProbabilityDrivenProduct_0;

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeMethodInfoPtr_GetTrueShowAction_Public_Vector2Int_0;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeMethodInfoPtr_GetRegenerateActions_Public_Int32_0;

		// Token: 0x02000C44 RID: 3140
		[Serializable]
		public sealed class ProbabilityDrivenProduct : ValueType
		{
			// Token: 0x0600E361 RID: 58209 RVA: 0x0036BFB8 File Offset: 0x0036A1B8
			// Note: this type is marked as 'beforefieldinit'.
			static ProbabilityDrivenProduct()
			{
				Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Collectable>.NativeClassPtr, "ProbabilityDrivenProduct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr);
				Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr, "product");
				Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr, "probability");
				Collectable.ProbabilityDrivenProduct.NativeMethodInfoPtr__ctor_Public_Void_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr, 100680666);
			}

			// Token: 0x0600E362 RID: 58210 RVA: 0x0036C020 File Offset: 0x0036A220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212573, XrefRangeEnd = 212574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProbabilityDrivenProduct(Product product, int probability) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probability;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collectable.ProbabilityDrivenProduct.NativeMethodInfoPtr__ctor_Public_Void_Product_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E363 RID: 58211 RVA: 0x00079446 File Offset: 0x00077646
			public ProbabilityDrivenProduct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E364 RID: 58212 RVA: 0x0007944F File Offset: 0x0007764F
			public ProbabilityDrivenProduct() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collectable.ProbabilityDrivenProduct>.NativeClassPtr))
			{
			}

			// Token: 0x170049D5 RID: 18901
			// (get) Token: 0x0600E365 RID: 58213 RVA: 0x0036C084 File Offset: 0x0036A284
			// (set) Token: 0x0600E366 RID: 58214 RVA: 0x00079461 File Offset: 0x00077661
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049D6 RID: 18902
			// (get) Token: 0x0600E367 RID: 58215 RVA: 0x0036C0B4 File Offset: 0x0036A2B4
			// (set) Token: 0x0600E368 RID: 58216 RVA: 0x0007948F File Offset: 0x0007768F
			public unsafe int probability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_probability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collectable.ProbabilityDrivenProduct.NativeFieldInfoPtr_probability)) = value;
				}
			}

			// Token: 0x04009159 RID: 37209
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400915A RID: 37210
			private static readonly IntPtr NativeFieldInfoPtr_probability;

			// Token: 0x0400915B RID: 37211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Product_Int32_0;
		}
	}
}
