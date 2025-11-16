using System;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E7 RID: 231
	public class DLC5_RogueLikeCardGiveItemAfterSettle : RogueLikeCard
	{
		// Token: 0x06001ACA RID: 6858 RVA: 0x000F7CE4 File Offset: 0x000F5EE4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardGiveItemAfterSettle()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardGiveItemAfterSettle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_get_TypeIndex_Protected_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668111);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_Void_Rarity_RogueLikeManager_byref_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668112);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_ModifyStorageAfterSettle_Protected_Void_Rarity_byref_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668113);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668114);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668115);
			DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_0_Private_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, 100668116);
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x000F7DA0 File Offset: 0x000F5FA0
		public unsafe virtual int TypeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_get_TypeIndex_Protected_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000F7DE8 File Offset: 0x000F5FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71005, XrefRangeEnd = 71007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager, out List<Product> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_Void_Rarity_RogueLikeManager_byref_List_1_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			products = ((intPtr4 == 0) ? null : new List<Product>(intPtr4));
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x000F7E64 File Offset: 0x000F6064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71074, RefRangeEnd = 71075, XrefRangeStart = 71007, XrefRangeEnd = 71074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, out List<Product> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_ModifyStorageAfterSettle_Protected_Void_Rarity_byref_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			products = ((intPtr4 == 0) ? null : new List<Product>(intPtr4));
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000F7EC4 File Offset: 0x000F60C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71075, XrefRangeEnd = 71083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000F7F28 File Offset: 0x000F6128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardGiveItemAfterSettle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000F7F64 File Offset: 0x000F6164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71083, XrefRangeEnd = 71087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ModifyStorageAfterSettle_b__4_0(KeyValuePair<Ingredient, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_0_Private_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00010823 File Offset: 0x0000EA23
		public DLC5_RogueLikeCardGiveItemAfterSettle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x000F7FB8 File Offset: 0x000F61B8
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0001082C File Offset: 0x0000EA2C
		public unsafe Il2CppReferenceArray<RarityDataMappingForDuration> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItemAfterSettle.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForDuration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItemAfterSettle.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIndex_Protected_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_ModifyStorageAfterSettle_Public_Virtual_Void_Rarity_RogueLikeManager_byref_List_1_Product_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_ModifyStorageAfterSettle_Protected_Void_Rarity_byref_List_1_Product_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_0_Private_Boolean_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x020006A8 RID: 1704
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardGiveItemAfterSettle+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06009823 RID: 38947 RVA: 0x0028AF4C File Offset: 0x0028914C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr);
				DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr, "num");
				DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr, 100668117);
				DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__2_Internal_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr, 100668118);
				DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr, 100668119);
			}

			// Token: 0x06009824 RID: 38948 RVA: 0x0028AFC8 File Offset: 0x002891C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009825 RID: 38949 RVA: 0x0028B004 File Offset: 0x00289204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70999, XrefRangeEnd = 71000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _ModifyStorageAfterSettle_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__2_Internal_Product_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x06009826 RID: 38950 RVA: 0x0028B048 File Offset: 0x00289248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71000, XrefRangeEnd = 71004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ModifyStorageAfterSettle_b__3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009827 RID: 38951 RVA: 0x00052531 File Offset: 0x00050731
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700328E RID: 12942
			// (get) Token: 0x06009828 RID: 38952 RVA: 0x0028B088 File Offset: 0x00289288
			// (set) Token: 0x06009829 RID: 38953 RVA: 0x0005253A File Offset: 0x0005073A
			public unsafe int num
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeFieldInfoPtr_num);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardGiveItemAfterSettle.__c__DisplayClass4_0.NativeFieldInfoPtr_num)) = value;
				}
			}

			// Token: 0x04006296 RID: 25238
			private static readonly IntPtr NativeFieldInfoPtr_num;

			// Token: 0x04006297 RID: 25239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006298 RID: 25240
			private static readonly IntPtr NativeMethodInfoPtr__ModifyStorageAfterSettle_b__2_Internal_Product_Int32_0;

			// Token: 0x04006299 RID: 25241
			private static readonly IntPtr NativeMethodInfoPtr__ModifyStorageAfterSettle_b__3_Internal_Void_Int32_0;
		}

		// Token: 0x020006A9 RID: 1705
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardGiveItemAfterSettle+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600982A RID: 38954 RVA: 0x0028B0B0 File Offset: 0x002892B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr);
				DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr, "<>9__4_1");
				DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr, 100668121);
				DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr, 100668122);
			}

			// Token: 0x0600982B RID: 38955 RVA: 0x0028B12C File Offset: 0x0028932C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardGiveItemAfterSettle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600982C RID: 38956 RVA: 0x0028B168 File Offset: 0x00289368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71004, XrefRangeEnd = 71005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ModifyStorageAfterSettle_b__4_1(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600982D RID: 38957 RVA: 0x00052555 File Offset: 0x00050755
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700328F RID: 12943
			// (get) Token: 0x0600982E RID: 38958 RVA: 0x0028B1BC File Offset: 0x002893BC
			// (set) Token: 0x0600982F RID: 38959 RVA: 0x0005255E File Offset: 0x0005075E
			public unsafe static DLC5_RogueLikeCardGiveItemAfterSettle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardGiveItemAfterSettle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003290 RID: 12944
			// (get) Token: 0x06009830 RID: 38960 RVA: 0x0028B1E4 File Offset: 0x002893E4
			// (set) Token: 0x06009831 RID: 38961 RVA: 0x00052570 File Offset: 0x00050770
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardGiveItemAfterSettle.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400629A RID: 25242
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400629B RID: 25243
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400629C RID: 25244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400629D RID: 25245
			private static readonly IntPtr NativeMethodInfoPtr__ModifyStorageAfterSettle_b__4_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;
		}
	}
}
