using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x0200029A RID: 666
	[Serializable]
	public sealed class Merchant : ValueType
	{
		// Token: 0x060054F0 RID: 21744 RVA: 0x001BD0E8 File Offset: 0x001BB2E8
		// Note: this type is marked as 'beforefieldinit'.
		static Merchant()
		{
			Il2CppClassPointerStore<Merchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "Merchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merchant>.NativeClassPtr);
			Merchant.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "key");
			Merchant.NativeFieldInfoPtr_welcomeDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "welcomeDialogPackage");
			Merchant.NativeFieldInfoPtr_nullDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "nullDialogPackage");
			Merchant.NativeFieldInfoPtr_priceMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "priceMultiplierRange");
			Merchant.NativeFieldInfoPtr_merchandiseCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "merchandiseCollection");
			Merchant.NativeFieldInfoPtr_leastSellNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "leastSellNum");
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		public Merchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x0002DB05 File Offset: 0x0002BD05
		public Merchant() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant>.NativeClassPtr))
		{
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x001BD190 File Offset: 0x001BB390
		// (set) Token: 0x060054F4 RID: 21748 RVA: 0x0002DB17 File Offset: 0x0002BD17
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x001BD1B8 File Offset: 0x001BB3B8
		// (set) Token: 0x060054F6 RID: 21750 RVA: 0x0002DB36 File Offset: 0x0002BD36
		public unsafe Il2CppReferenceArray<DialogPackage> welcomeDialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_welcomeDialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_welcomeDialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x001BD1E8 File Offset: 0x001BB3E8
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x0002DB55 File Offset: 0x0002BD55
		public unsafe Il2CppReferenceArray<DialogPackage> nullDialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_nullDialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_nullDialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x001BD218 File Offset: 0x001BB418
		// (set) Token: 0x060054FA RID: 21754 RVA: 0x0002DB74 File Offset: 0x0002BD74
		public unsafe Vector2 priceMultiplierRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_priceMultiplierRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_priceMultiplierRange)) = value;
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x001BD240 File Offset: 0x001BB440
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x0002DB8F File Offset: 0x0002BD8F
		public unsafe Il2CppReferenceArray<Merchant.Merchandise> merchandiseCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_merchandiseCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Merchant.Merchandise>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_merchandiseCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x001BD270 File Offset: 0x001BB470
		// (set) Token: 0x060054FE RID: 21758 RVA: 0x0002DBAE File Offset: 0x0002BDAE
		public unsafe int leastSellNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_leastSellNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_leastSellNum)) = value;
			}
		}

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeFieldInfoPtr_welcomeDialogPackage;

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeFieldInfoPtr_nullDialogPackage;

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeFieldInfoPtr_priceMultiplierRange;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeFieldInfoPtr_merchandiseCollection;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeFieldInfoPtr_leastSellNum;

		// Token: 0x02000C45 RID: 3141
		[Serializable]
		public sealed class Merchandise : ValueType
		{
			// Token: 0x0600E369 RID: 58217 RVA: 0x0036C0DC File Offset: 0x0036A2DC
			// Note: this type is marked as 'beforefieldinit'.
			static Merchandise()
			{
				Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "Merchandise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr);
				Merchant.Merchandise.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr, "item");
				Merchant.Merchandise.NativeFieldInfoPtr_sellProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr, "sellProbability");
				Merchant.Merchandise.NativeFieldInfoPtr_itemAmountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr, "itemAmountRange");
				Merchant.Merchandise.NativeMethodInfoPtr__ctor_Public_Void_Product_Single_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr, 100680667);
			}

			// Token: 0x0600E36A RID: 58218 RVA: 0x0036C158 File Offset: 0x0036A358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212581, XrefRangeEnd = 212582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Merchandise(Product item, float sellProbability, Vector2Int itemAmountRange) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellProbability;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemAmountRange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.Merchandise.NativeMethodInfoPtr__ctor_Public_Void_Product_Single_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E36B RID: 58219 RVA: 0x000794AA File Offset: 0x000776AA
			public Merchandise(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E36C RID: 58220 RVA: 0x000794B3 File Offset: 0x000776B3
			public Merchandise() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant.Merchandise>.NativeClassPtr))
			{
			}

			// Token: 0x170049D7 RID: 18903
			// (get) Token: 0x0600E36D RID: 58221 RVA: 0x0036C1CC File Offset: 0x0036A3CC
			// (set) Token: 0x0600E36E RID: 58222 RVA: 0x000794C5 File Offset: 0x000776C5
			public Product item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_item);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_item), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049D8 RID: 18904
			// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0036C1FC File Offset: 0x0036A3FC
			// (set) Token: 0x0600E370 RID: 58224 RVA: 0x000794F3 File Offset: 0x000776F3
			public unsafe float sellProbability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_sellProbability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_sellProbability)) = value;
				}
			}

			// Token: 0x170049D9 RID: 18905
			// (get) Token: 0x0600E371 RID: 58225 RVA: 0x0036C224 File Offset: 0x0036A424
			// (set) Token: 0x0600E372 RID: 58226 RVA: 0x0007950E File Offset: 0x0007770E
			public unsafe Vector2Int itemAmountRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_itemAmountRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.Merchandise.NativeFieldInfoPtr_itemAmountRange)) = value;
				}
			}

			// Token: 0x0400915C RID: 37212
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400915D RID: 37213
			private static readonly IntPtr NativeFieldInfoPtr_sellProbability;

			// Token: 0x0400915E RID: 37214
			private static readonly IntPtr NativeFieldInfoPtr_itemAmountRange;

			// Token: 0x0400915F RID: 37215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Product_Single_Vector2Int_0;
		}
	}
}
