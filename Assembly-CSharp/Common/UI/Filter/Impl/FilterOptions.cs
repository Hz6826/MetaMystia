using System;
using GameData.Core;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter.Impl
{
	// Token: 0x020003BB RID: 955
	public static class FilterOptions : Object
	{
		// Token: 0x060071A5 RID: 29093 RVA: 0x00219700 File Offset: 0x00217900
		// Note: this type is marked as 'beforefieldinit'.
		static FilterOptions()
		{
			Il2CppClassPointerStore<FilterOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter.Impl", "FilterOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr);
			FilterOptions.NativeFieldInfoPtr__RecipeFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<RecipeFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__FoodFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<FoodFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__DailyFoodFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<DailyFoodFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__BeverageFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<BeverageFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__DailyBeverageFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<DailyBeverageFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__IngredientFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<IngredientFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__CookerFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<CookerFilterConfigFactories>k__BackingField");
			FilterOptions.NativeFieldInfoPtr__ItemFilterConfigFactories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "<ItemFilterConfigFactories>k__BackingField");
			FilterOptions.NativeMethodInfoPtr_get_RecipeFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686491);
			FilterOptions.NativeMethodInfoPtr_get_FoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686492);
			FilterOptions.NativeMethodInfoPtr_get_DailyFoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686493);
			FilterOptions.NativeMethodInfoPtr_get_BeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686494);
			FilterOptions.NativeMethodInfoPtr_get_DailyBeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686495);
			FilterOptions.NativeMethodInfoPtr_get_IngredientFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686496);
			FilterOptions.NativeMethodInfoPtr_get_CookerFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686497);
			FilterOptions.NativeMethodInfoPtr_get_ItemFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, 100686498);
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x00219870 File Offset: 0x00217A70
		public unsafe static IReadOnlyList<FilterConfigFactory<Recipe>> RecipeFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283838, XrefRangeEnd = 283842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_RecipeFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Recipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Recipe>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x002198A4 File Offset: 0x00217AA4
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> FoodFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283842, XrefRangeEnd = 283846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_FoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x002198D8 File Offset: 0x00217AD8
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> DailyFoodFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283846, XrefRangeEnd = 283850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_DailyFoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x0021990C File Offset: 0x00217B0C
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> BeverageFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283850, XrefRangeEnd = 283854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_BeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x060071AA RID: 29098 RVA: 0x00219940 File Offset: 0x00217B40
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> DailyBeverageFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283854, XrefRangeEnd = 283858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_DailyBeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x00219974 File Offset: 0x00217B74
		public unsafe static IReadOnlyList<FilterConfigFactory<Ingredient>> IngredientFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283858, XrefRangeEnd = 283862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_IngredientFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Ingredient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Ingredient>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x002199A8 File Offset: 0x00217BA8
		public unsafe static IReadOnlyList<FilterConfigFactory<Cooker>> CookerFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283862, XrefRangeEnd = 283866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_CookerFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Cooker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Cooker>>>(intPtr3) : null;
			}
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x002199DC File Offset: 0x00217BDC
		public unsafe static IReadOnlyList<FilterConfigFactory<Item>> ItemFilterConfigFactories
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283866, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NativeMethodInfoPtr_get_ItemFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Item_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Item>>>(intPtr3) : null;
			}
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x0003D933 File Offset: 0x0003BB33
		public FilterOptions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00219A10 File Offset: 0x00217C10
		// (set) Token: 0x060071B0 RID: 29104 RVA: 0x0003D93C File Offset: 0x0003BB3C
		public unsafe static IReadOnlyList<FilterConfigFactory<Recipe>> _RecipeFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__RecipeFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Recipe>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__RecipeFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x060071B1 RID: 29105 RVA: 0x00219A38 File Offset: 0x00217C38
		// (set) Token: 0x060071B2 RID: 29106 RVA: 0x0003D94E File Offset: 0x0003BB4E
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> _FoodFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__FoodFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__FoodFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x060071B3 RID: 29107 RVA: 0x00219A60 File Offset: 0x00217C60
		// (set) Token: 0x060071B4 RID: 29108 RVA: 0x0003D960 File Offset: 0x0003BB60
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> _DailyFoodFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__DailyFoodFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__DailyFoodFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x00219A88 File Offset: 0x00217C88
		// (set) Token: 0x060071B6 RID: 29110 RVA: 0x0003D972 File Offset: 0x0003BB72
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> _BeverageFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__BeverageFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__BeverageFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x00219AB0 File Offset: 0x00217CB0
		// (set) Token: 0x060071B8 RID: 29112 RVA: 0x0003D984 File Offset: 0x0003BB84
		public unsafe static IReadOnlyList<FilterConfigFactory<Sellable>> _DailyBeverageFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__DailyBeverageFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Sellable>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__DailyBeverageFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x060071B9 RID: 29113 RVA: 0x00219AD8 File Offset: 0x00217CD8
		// (set) Token: 0x060071BA RID: 29114 RVA: 0x0003D996 File Offset: 0x0003BB96
		public unsafe static IReadOnlyList<FilterConfigFactory<Ingredient>> _IngredientFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__IngredientFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Ingredient>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__IngredientFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x00219B00 File Offset: 0x00217D00
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x0003D9A8 File Offset: 0x0003BBA8
		public unsafe static IReadOnlyList<FilterConfigFactory<Cooker>> _CookerFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__CookerFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Cooker>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__CookerFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x00219B28 File Offset: 0x00217D28
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x0003D9BA File Offset: 0x0003BBBA
		public unsafe static IReadOnlyList<FilterConfigFactory<Item>> _ItemFilterConfigFactories_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterOptions.NativeFieldInfoPtr__ItemFilterConfigFactories_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<Item>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterOptions.NativeFieldInfoPtr__ItemFilterConfigFactories_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B48 RID: 19272
		private static readonly IntPtr NativeFieldInfoPtr__RecipeFilterConfigFactories_k__BackingField;

		// Token: 0x04004B49 RID: 19273
		private static readonly IntPtr NativeFieldInfoPtr__FoodFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4A RID: 19274
		private static readonly IntPtr NativeFieldInfoPtr__DailyFoodFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4B RID: 19275
		private static readonly IntPtr NativeFieldInfoPtr__BeverageFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4C RID: 19276
		private static readonly IntPtr NativeFieldInfoPtr__DailyBeverageFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4D RID: 19277
		private static readonly IntPtr NativeFieldInfoPtr__IngredientFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4E RID: 19278
		private static readonly IntPtr NativeFieldInfoPtr__CookerFilterConfigFactories_k__BackingField;

		// Token: 0x04004B4F RID: 19279
		private static readonly IntPtr NativeFieldInfoPtr__ItemFilterConfigFactories_k__BackingField;

		// Token: 0x04004B50 RID: 19280
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Recipe_0;

		// Token: 0x04004B51 RID: 19281
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0;

		// Token: 0x04004B52 RID: 19282
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyFoodFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0;

		// Token: 0x04004B53 RID: 19283
		private static readonly IntPtr NativeMethodInfoPtr_get_BeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0;

		// Token: 0x04004B54 RID: 19284
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyBeverageFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Sellable_0;

		// Token: 0x04004B55 RID: 19285
		private static readonly IntPtr NativeMethodInfoPtr_get_IngredientFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Ingredient_0;

		// Token: 0x04004B56 RID: 19286
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Cooker_0;

		// Token: 0x04004B57 RID: 19287
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemFilterConfigFactories_Public_Static_get_IReadOnlyList_1_FilterConfigFactory_1_Item_0;

		// Token: 0x02000F0D RID: 3853
		public class CookerByAcquireOrderFactory : FilterOptions.NonTradableByAcquireOrderFactory<Cooker>
		{
			// Token: 0x06010E61 RID: 69217 RVA: 0x003E7B44 File Offset: 0x003E5D44
			// Note: this type is marked as 'beforefieldinit'.
			static CookerByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "CookerByAcquireOrderFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr);
				FilterOptions.CookerByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr, "m_AcquireOrderCache");
				FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr, 100686500);
				FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr, 100686501);
				FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr, 100686502);
				FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr, 100686503);
			}

			// Token: 0x170057F8 RID: 22520
			// (get) Token: 0x06010E62 RID: 69218 RVA: 0x003E7BD4 File Offset: 0x003E5DD4
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282932, XrefRangeEnd = 282936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E63 RID: 69219 RVA: 0x003E7C18 File Offset: 0x003E5E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282936, XrefRangeEnd = 282947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E64 RID: 69220 RVA: 0x003E7C54 File Offset: 0x003E5E54
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override List<int> GetAcquireOrderList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}

			// Token: 0x06010E65 RID: 69221 RVA: 0x003E7CA0 File Offset: 0x003E5EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282947, XrefRangeEnd = 282950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookerByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.CookerByAcquireOrderFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E66 RID: 69222 RVA: 0x00093298 File Offset: 0x00091498
			public CookerByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057F7 RID: 22519
			// (get) Token: 0x06010E67 RID: 69223 RVA: 0x003E7CE8 File Offset: 0x003E5EE8
			// (set) Token: 0x06010E68 RID: 69224 RVA: 0x000932A1 File Offset: 0x000914A1
			public unsafe List<int> m_AcquireOrderCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.CookerByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.CookerByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAF9 RID: 43769
			private static readonly IntPtr NativeFieldInfoPtr_m_AcquireOrderCache;

			// Token: 0x0400AAFA RID: 43770
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AAFB RID: 43771
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AAFC RID: 43772
			private static readonly IntPtr NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0;

			// Token: 0x0400AAFD RID: 43773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F0E RID: 3854
		public class CookerByCookerTypeFactory : ByValueContainsConfigFactory<Cooker.CookerType, Cooker>
		{
			// Token: 0x06010E69 RID: 69225 RVA: 0x003E7D18 File Offset: 0x003E5F18
			// Note: this type is marked as 'beforefieldinit'.
			static CookerByCookerTypeFactory()
			{
				Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "CookerByCookerTypeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr);
				FilterOptions.CookerByCookerTypeFactory.NativeFieldInfoPtr_m_CookerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, "m_CookerTypes");
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686504);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686505);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686506);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686507);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686508);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686509);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686510);
				FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr, 100686511);
			}

			// Token: 0x170057FA RID: 22522
			// (get) Token: 0x06010E6A RID: 69226 RVA: 0x003E7DF8 File Offset: 0x003E5FF8
			public unsafe override Rule ContainsRule
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170057FB RID: 22523
			// (get) Token: 0x06010E6B RID: 69227 RVA: 0x003E7E40 File Offset: 0x003E6040
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170057FC RID: 22524
			// (get) Token: 0x06010E6C RID: 69228 RVA: 0x003E7E7C File Offset: 0x003E607C
			public unsafe override uint ColumnCount
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010E6D RID: 69229 RVA: 0x003E7EB8 File Offset: 0x003E60B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282950, XrefRangeEnd = 282954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010E6E RID: 69230 RVA: 0x003E7F08 File Offset: 0x003E6108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282954, XrefRangeEnd = 282958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerType> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}

			// Token: 0x06010E6F RID: 69231 RVA: 0x003E7F54 File Offset: 0x003E6154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(Cooker.CookerType value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010E70 RID: 69232 RVA: 0x003E7FA4 File Offset: 0x003E61A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282958, XrefRangeEnd = 282960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerType> GetFocusing(Cooker ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Cooker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}

			// Token: 0x06010E71 RID: 69233 RVA: 0x003E8000 File Offset: 0x003E6200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282960, XrefRangeEnd = 282963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookerByCookerTypeFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.CookerByCookerTypeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerByCookerTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E72 RID: 69234 RVA: 0x000932C0 File Offset: 0x000914C0
			public CookerByCookerTypeFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057F9 RID: 22521
			// (get) Token: 0x06010E73 RID: 69235 RVA: 0x003E8048 File Offset: 0x003E6248
			// (set) Token: 0x06010E74 RID: 69236 RVA: 0x000932C9 File Offset: 0x000914C9
			public unsafe static IReadOnlyCollection<Cooker.CookerType> m_CookerTypes
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterOptions.CookerByCookerTypeFactory.NativeFieldInfoPtr_m_CookerTypes, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterOptions.CookerByCookerTypeFactory.NativeFieldInfoPtr_m_CookerTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAFE RID: 43774
			private static readonly IntPtr NativeFieldInfoPtr_m_CookerTypes;

			// Token: 0x0400AAFF RID: 43775
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0;

			// Token: 0x0400AB00 RID: 43776
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

			// Token: 0x0400AB01 RID: 43777
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB02 RID: 43778
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0;

			// Token: 0x0400AB03 RID: 43779
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0;

			// Token: 0x0400AB04 RID: 43780
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0;

			// Token: 0x0400AB05 RID: 43781
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Cooker_0;

			// Token: 0x0400AB06 RID: 43782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F0F RID: 3855
		public class CookerBySeriesTypeFactory : ByValueContainsConfigFactory<Cooker.CookerSeries, Cooker>
		{
			// Token: 0x06010E75 RID: 69237 RVA: 0x003E8070 File Offset: 0x003E6270
			// Note: this type is marked as 'beforefieldinit'.
			static CookerBySeriesTypeFactory()
			{
				Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "CookerBySeriesTypeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686513);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686514);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686515);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686516);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686517);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686518);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerSeries_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686519);
				FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, 100686520);
			}

			// Token: 0x170057FD RID: 22525
			// (get) Token: 0x06010E76 RID: 69238 RVA: 0x003E813C File Offset: 0x003E633C
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170057FE RID: 22526
			// (get) Token: 0x06010E77 RID: 69239 RVA: 0x003E8184 File Offset: 0x003E6384
			public unsafe override uint ColumnCount
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170057FF RID: 22527
			// (get) Token: 0x06010E78 RID: 69240 RVA: 0x003E81C0 File Offset: 0x003E63C0
			public unsafe override Rule ContainsRule
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010E79 RID: 69241 RVA: 0x003E8208 File Offset: 0x003E6408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282964, XrefRangeEnd = 282978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010E7A RID: 69242 RVA: 0x003E8258 File Offset: 0x003E6458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282978, XrefRangeEnd = 283001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerSeries> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerSeries>>(intPtr3) : null;
			}

			// Token: 0x06010E7B RID: 69243 RVA: 0x003E82A4 File Offset: 0x003E64A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283001, XrefRangeEnd = 283002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(Cooker.CookerSeries value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerSeries_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010E7C RID: 69244 RVA: 0x003E82F4 File Offset: 0x003E64F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283002, XrefRangeEnd = 283006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerSeries> GetFocusing(Cooker ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerSeries_Cooker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerSeries>>(intPtr3) : null;
			}

			// Token: 0x06010E7D RID: 69245 RVA: 0x003E8350 File Offset: 0x003E6550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283006, XrefRangeEnd = 283009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookerBySeriesTypeFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerBySeriesTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E7E RID: 69246 RVA: 0x000932DB File Offset: 0x000914DB
			public CookerBySeriesTypeFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB07 RID: 43783
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0;

			// Token: 0x0400AB08 RID: 43784
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB09 RID: 43785
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0;

			// Token: 0x0400AB0A RID: 43786
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0;

			// Token: 0x0400AB0B RID: 43787
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerSeries_0;

			// Token: 0x0400AB0C RID: 43788
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerSeries_0;

			// Token: 0x0400AB0D RID: 43789
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerSeries_Cooker_0;

			// Token: 0x0400AB0E RID: 43790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

			// Token: 0x020010C4 RID: 4292
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+CookerBySeriesTypeFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0601235C RID: 74588 RVA: 0x00426D18 File Offset: 0x00424F18
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr);
					FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr, "<>9__7_0");
					FilterOptions.CookerBySeriesTypeFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr, 100686522);
					FilterOptions.CookerBySeriesTypeFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__7_0_Internal_CookerSeries_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr, 100686523);
				}

				// Token: 0x0601235D RID: 74589 RVA: 0x00426D94 File Offset: 0x00424F94
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.CookerBySeriesTypeFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerBySeriesTypeFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601235E RID: 74590 RVA: 0x00426DD0 File Offset: 0x00424FD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282963, XrefRangeEnd = 282964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Cooker.CookerSeries _GetSelectionsTyped_b__7_0(KeyValuePair<Cooker, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.CookerBySeriesTypeFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__7_0_Internal_CookerSeries_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601235F RID: 74591 RVA: 0x0009E132 File Offset: 0x0009C332
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F3A RID: 24378
				// (get) Token: 0x06012360 RID: 74592 RVA: 0x00426E24 File Offset: 0x00425024
				// (set) Token: 0x06012361 RID: 74593 RVA: 0x0009E13B File Offset: 0x0009C33B
				public unsafe static FilterOptions.CookerBySeriesTypeFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.CookerBySeriesTypeFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F3B RID: 24379
				// (get) Token: 0x06012362 RID: 74594 RVA: 0x00426E4C File Offset: 0x0042504C
				// (set) Token: 0x06012363 RID: 74595 RVA: 0x0009E14D File Offset: 0x0009C34D
				public unsafe static Func<KeyValuePair<Cooker, int>, Cooker.CookerSeries> __9__7_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, Cooker.CookerSeries>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.CookerBySeriesTypeFactory.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B892 RID: 47250
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B893 RID: 47251
				private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

				// Token: 0x0400B894 RID: 47252
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B895 RID: 47253
				private static readonly IntPtr NativeMethodInfoPtr__GetSelectionsTyped_b__7_0_Internal_CookerSeries_KeyValuePair_2_Cooker_Int32_0;
			}
		}

		// Token: 0x02000F10 RID: 3856
		public class IngredientByTagFactory : FilterOptions.TradableByTagFactory<Ingredient>
		{
			// Token: 0x06010E7F RID: 69247 RVA: 0x003E8398 File Offset: 0x003E6598
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientByTagFactory()
			{
				Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "IngredientByTagFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr);
				FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr, 100686524);
				FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr, 100686525);
				FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr, 100686526);
				FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr, 100686527);
			}

			// Token: 0x06010E80 RID: 69248 RVA: 0x003E8414 File Offset: 0x003E6614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283009, XrefRangeEnd = 283012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref contains;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005800 RID: 22528
			// (get) Token: 0x06010E81 RID: 69249 RVA: 0x003E8478 File Offset: 0x003E6678
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283012, XrefRangeEnd = 283015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E82 RID: 69250 RVA: 0x003E84BC File Offset: 0x003E66BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283015, XrefRangeEnd = 283048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<int> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06010E83 RID: 69251 RVA: 0x003E8508 File Offset: 0x003E6708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010E84 RID: 69252 RVA: 0x000932E4 File Offset: 0x000914E4
			public IngredientByTagFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB0F RID: 43791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0;

			// Token: 0x0400AB10 RID: 43792
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB11 RID: 43793
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0;

			// Token: 0x0400AB12 RID: 43794
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0;

			// Token: 0x020010C5 RID: 4293
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+IngredientByTagFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06012364 RID: 74596 RVA: 0x00426E74 File Offset: 0x00425074
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr);
					FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr, "<>9__3_0");
					FilterOptions.IngredientByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr, 100686529);
					FilterOptions.IngredientByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__3_0_Internal_IEnumerable_1_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr, 100686530);
				}

				// Token: 0x06012365 RID: 74597 RVA: 0x00426EF0 File Offset: 0x004250F0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByTagFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012366 RID: 74598 RVA: 0x00426F2C File Offset: 0x0042512C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _GetSelectionsTyped_b__3_0(Ingredient x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__3_0_Internal_IEnumerable_1_Int32_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x06012367 RID: 74599 RVA: 0x0009E15F File Offset: 0x0009C35F
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F3C RID: 24380
				// (get) Token: 0x06012368 RID: 74600 RVA: 0x00426F7C File Offset: 0x0042517C
				// (set) Token: 0x06012369 RID: 74601 RVA: 0x0009E168 File Offset: 0x0009C368
				public unsafe static FilterOptions.IngredientByTagFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.IngredientByTagFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F3D RID: 24381
				// (get) Token: 0x0601236A RID: 74602 RVA: 0x00426FA4 File Offset: 0x004251A4
				// (set) Token: 0x0601236B RID: 74603 RVA: 0x0009E17A File Offset: 0x0009C37A
				public unsafe static Func<Ingredient, IEnumerable<int>> __9__3_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.IngredientByTagFactory.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B896 RID: 47254
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B897 RID: 47255
				private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

				// Token: 0x0400B898 RID: 47256
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B899 RID: 47257
				private static readonly IntPtr NativeMethodInfoPtr__GetSelectionsTyped_b__3_0_Internal_IEnumerable_1_Int32_Ingredient_0;
			}
		}

		// Token: 0x02000F11 RID: 3857
		public class IngredientByPriceFactory : FilterOptions.TradableByPriceFactory<Ingredient>
		{
			// Token: 0x06010E85 RID: 69253 RVA: 0x003E8558 File Offset: 0x003E6758
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientByPriceFactory()
			{
				Il2CppClassPointerStore<FilterOptions.IngredientByPriceFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "IngredientByPriceFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByPriceFactory>.NativeClassPtr);
				FilterOptions.IngredientByPriceFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByPriceFactory>.NativeClassPtr, 100686531);
				FilterOptions.IngredientByPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByPriceFactory>.NativeClassPtr, 100686532);
			}

			// Token: 0x17005801 RID: 22529
			// (get) Token: 0x06010E86 RID: 69254 RVA: 0x003E85AC File Offset: 0x003E67AC
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByPriceFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E87 RID: 69255 RVA: 0x003E85F0 File Offset: 0x003E67F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283048, XrefRangeEnd = 283051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientByPriceFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByPriceFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E88 RID: 69256 RVA: 0x000932ED File Offset: 0x000914ED
			public IngredientByPriceFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB13 RID: 43795
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB14 RID: 43796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F12 RID: 3858
		public class IngredientByLevelFactory : FilterOptions.TradableByLevelFactory<Ingredient>
		{
			// Token: 0x06010E89 RID: 69257 RVA: 0x003E8638 File Offset: 0x003E6838
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientByLevelFactory()
			{
				Il2CppClassPointerStore<FilterOptions.IngredientByLevelFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "IngredientByLevelFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByLevelFactory>.NativeClassPtr);
				FilterOptions.IngredientByLevelFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByLevelFactory>.NativeClassPtr, 100686533);
				FilterOptions.IngredientByLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByLevelFactory>.NativeClassPtr, 100686534);
			}

			// Token: 0x17005802 RID: 22530
			// (get) Token: 0x06010E8A RID: 69258 RVA: 0x003E868C File Offset: 0x003E688C
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByLevelFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E8B RID: 69259 RVA: 0x003E86D0 File Offset: 0x003E68D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283051, XrefRangeEnd = 283054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientByLevelFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByLevelFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E8C RID: 69260 RVA: 0x000932F6 File Offset: 0x000914F6
			public IngredientByLevelFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB15 RID: 43797
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB16 RID: 43798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F13 RID: 3859
		public class IngredientByCountFactory : FilterOptions.TradableByCountFactory<Ingredient>
		{
			// Token: 0x06010E8D RID: 69261 RVA: 0x003E8718 File Offset: 0x003E6918
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientByCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "IngredientByCountFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr);
				FilterOptions.IngredientByCountFactory.NativeFieldInfoPtr_m_CountCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, "m_CountCache");
				FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, 100686535);
				FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, 100686536);
				FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, 100686537);
				FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, 100686538);
			}

			// Token: 0x17005804 RID: 22532
			// (get) Token: 0x06010E8E RID: 69262 RVA: 0x003E87A8 File Offset: 0x003E69A8
			public unsafe override string GetObjectName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E8F RID: 69263 RVA: 0x003E87EC File Offset: 0x003E69EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283056, XrefRangeEnd = 283093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E90 RID: 69264 RVA: 0x003E8828 File Offset: 0x003E6A28
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Dictionary<int, int> GetCountList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x06010E91 RID: 69265 RVA: 0x003E8874 File Offset: 0x003E6A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283093, XrefRangeEnd = 283096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientByCountFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E92 RID: 69266 RVA: 0x000932FF File Offset: 0x000914FF
			public IngredientByCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005803 RID: 22531
			// (get) Token: 0x06010E93 RID: 69267 RVA: 0x003E88BC File Offset: 0x003E6ABC
			// (set) Token: 0x06010E94 RID: 69268 RVA: 0x00093308 File Offset: 0x00091508
			public unsafe Dictionary<int, int> m_CountCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByCountFactory.NativeFieldInfoPtr_m_CountCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByCountFactory.NativeFieldInfoPtr_m_CountCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB17 RID: 43799
			private static readonly IntPtr NativeFieldInfoPtr_m_CountCache;

			// Token: 0x0400AB18 RID: 43800
			private static readonly IntPtr NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB19 RID: 43801
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB1A RID: 43802
			private static readonly IntPtr NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0;

			// Token: 0x0400AB1B RID: 43803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

			// Token: 0x020010C6 RID: 4294
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+IngredientByCountFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x0601236C RID: 74604 RVA: 0x00426FCC File Offset: 0x004251CC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr);
					FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, "<>9__3_0");
					FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, "<>9__3_1");
					FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, 100686540);
					FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, 100686541);
					FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr, 100686542);
				}

				// Token: 0x0601236D RID: 74605 RVA: 0x00427070 File Offset: 0x00425270
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByCountFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601236E RID: 74606 RVA: 0x004270AC File Offset: 0x004252AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283054, XrefRangeEnd = 283055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__3_0(KeyValuePair<Ingredient, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601236F RID: 74607 RVA: 0x00427100 File Offset: 0x00425300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283055, XrefRangeEnd = 283056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__3_1(KeyValuePair<Ingredient, int> y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012370 RID: 74608 RVA: 0x0009E18C File Offset: 0x0009C38C
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F3E RID: 24382
				// (get) Token: 0x06012371 RID: 74609 RVA: 0x00427154 File Offset: 0x00425354
				// (set) Token: 0x06012372 RID: 74610 RVA: 0x0009E195 File Offset: 0x0009C395
				public unsafe static FilterOptions.IngredientByCountFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.IngredientByCountFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F3F RID: 24383
				// (get) Token: 0x06012373 RID: 74611 RVA: 0x0042717C File Offset: 0x0042537C
				// (set) Token: 0x06012374 RID: 74612 RVA: 0x0009E1A7 File Offset: 0x0009C3A7
				public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__3_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F40 RID: 24384
				// (get) Token: 0x06012375 RID: 74613 RVA: 0x004271A4 File Offset: 0x004253A4
				// (set) Token: 0x06012376 RID: 74614 RVA: 0x0009E1B9 File Offset: 0x0009C3B9
				public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__3_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.IngredientByCountFactory.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B89A RID: 47258
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B89B RID: 47259
				private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

				// Token: 0x0400B89C RID: 47260
				private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

				// Token: 0x0400B89D RID: 47261
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B89E RID: 47262
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

				// Token: 0x0400B89F RID: 47263
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;
			}
		}

		// Token: 0x02000F14 RID: 3860
		public class IngredientByAcquireOrderFactory : FilterOptions.TradableByAcquireOrderFactory<Ingredient>
		{
			// Token: 0x06010E95 RID: 69269 RVA: 0x003E88EC File Offset: 0x003E6AEC
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "IngredientByAcquireOrderFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr);
				FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, "m_AcquireOrderCache");
				FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, 100686543);
				FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, 100686544);
				FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, 100686545);
				FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr, 100686546);
			}

			// Token: 0x17005807 RID: 22535
			// (get) Token: 0x06010E96 RID: 69270 RVA: 0x003E8990 File Offset: 0x003E6B90
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010E97 RID: 69271 RVA: 0x003E89D4 File Offset: 0x003E6BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283096, XrefRangeEnd = 283107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E98 RID: 69272 RVA: 0x003E8A10 File Offset: 0x003E6C10
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override List<int> GetAcquireOrderList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}

			// Token: 0x06010E99 RID: 69273 RVA: 0x003E8A5C File Offset: 0x003E6C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283107, XrefRangeEnd = 283110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.IngredientByAcquireOrderFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.IngredientByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E9A RID: 69274 RVA: 0x00093327 File Offset: 0x00091527
			public IngredientByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005805 RID: 22533
			// (get) Token: 0x06010E9B RID: 69275 RVA: 0x003E8AA4 File Offset: 0x003E6CA4
			// (set) Token: 0x06010E9C RID: 69276 RVA: 0x00093330 File Offset: 0x00091530
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x17005806 RID: 22534
			// (get) Token: 0x06010E9D RID: 69277 RVA: 0x003E8ACC File Offset: 0x003E6CCC
			// (set) Token: 0x06010E9E RID: 69278 RVA: 0x0009334B File Offset: 0x0009154B
			public unsafe List<int> m_AcquireOrderCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.IngredientByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB1C RID: 43804
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB1D RID: 43805
			private static readonly IntPtr NativeFieldInfoPtr_m_AcquireOrderCache;

			// Token: 0x0400AB1E RID: 43806
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB1F RID: 43807
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB20 RID: 43808
			private static readonly IntPtr NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0;

			// Token: 0x0400AB21 RID: 43809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F15 RID: 3861
		public class ItemByCountFactory : FilterOptions.NonTradableByCountFactory<Item>
		{
			// Token: 0x06010E9F RID: 69279 RVA: 0x003E8AFC File Offset: 0x003E6CFC
			// Note: this type is marked as 'beforefieldinit'.
			static ItemByCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "ItemByCountFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr);
				FilterOptions.ItemByCountFactory.NativeFieldInfoPtr_m_CountCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, "m_CountCache");
				FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, 100686547);
				FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, 100686548);
				FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, 100686549);
				FilterOptions.ItemByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, 100686550);
			}

			// Token: 0x17005809 RID: 22537
			// (get) Token: 0x06010EA0 RID: 69280 RVA: 0x003E8B8C File Offset: 0x003E6D8C
			public unsafe override string GetObjectName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283112, XrefRangeEnd = 283115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010EA1 RID: 69281 RVA: 0x003E8BD0 File Offset: 0x003E6DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283115, XrefRangeEnd = 283152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EA2 RID: 69282 RVA: 0x003E8C0C File Offset: 0x003E6E0C
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Dictionary<int, int> GetCountList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x06010EA3 RID: 69283 RVA: 0x003E8C58 File Offset: 0x003E6E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283152, XrefRangeEnd = 283155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemByCountFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EA4 RID: 69284 RVA: 0x0009336A File Offset: 0x0009156A
			public ItemByCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005808 RID: 22536
			// (get) Token: 0x06010EA5 RID: 69285 RVA: 0x003E8CA0 File Offset: 0x003E6EA0
			// (set) Token: 0x06010EA6 RID: 69286 RVA: 0x00093373 File Offset: 0x00091573
			public unsafe Dictionary<int, int> m_CountCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByCountFactory.NativeFieldInfoPtr_m_CountCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByCountFactory.NativeFieldInfoPtr_m_CountCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB22 RID: 43810
			private static readonly IntPtr NativeFieldInfoPtr_m_CountCache;

			// Token: 0x0400AB23 RID: 43811
			private static readonly IntPtr NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB24 RID: 43812
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB25 RID: 43813
			private static readonly IntPtr NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0;

			// Token: 0x0400AB26 RID: 43814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

			// Token: 0x020010C7 RID: 4295
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+ItemByCountFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06012377 RID: 74615 RVA: 0x004271CC File Offset: 0x004253CC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr);
					FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, "<>9__3_0");
					FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, "<>9__3_1");
					FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, 100686552);
					FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, 100686553);
					FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr, 100686554);
				}

				// Token: 0x06012378 RID: 74616 RVA: 0x00427270 File Offset: 0x00425470
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.ItemByCountFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012379 RID: 74617 RVA: 0x004272AC File Offset: 0x004254AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283110, XrefRangeEnd = 283111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__3_0(KeyValuePair<Item, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601237A RID: 74618 RVA: 0x00427300 File Offset: 0x00425500
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283111, XrefRangeEnd = 283112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__3_1(KeyValuePair<Item, int> y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601237B RID: 74619 RVA: 0x0009E1CB File Offset: 0x0009C3CB
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F41 RID: 24385
				// (get) Token: 0x0601237C RID: 74620 RVA: 0x00427354 File Offset: 0x00425554
				// (set) Token: 0x0601237D RID: 74621 RVA: 0x0009E1D4 File Offset: 0x0009C3D4
				public unsafe static FilterOptions.ItemByCountFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.ItemByCountFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F42 RID: 24386
				// (get) Token: 0x0601237E RID: 74622 RVA: 0x0042737C File Offset: 0x0042557C
				// (set) Token: 0x0601237F RID: 74623 RVA: 0x0009E1E6 File Offset: 0x0009C3E6
				public unsafe static Func<KeyValuePair<Item, int>, int> __9__3_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F43 RID: 24387
				// (get) Token: 0x06012380 RID: 74624 RVA: 0x004273A4 File Offset: 0x004255A4
				// (set) Token: 0x06012381 RID: 74625 RVA: 0x0009E1F8 File Offset: 0x0009C3F8
				public unsafe static Func<KeyValuePair<Item, int>, int> __9__3_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.ItemByCountFactory.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B8A0 RID: 47264
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B8A1 RID: 47265
				private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

				// Token: 0x0400B8A2 RID: 47266
				private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

				// Token: 0x0400B8A3 RID: 47267
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B8A4 RID: 47268
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__3_0_Internal_Int32_KeyValuePair_2_Item_Int32_0;

				// Token: 0x0400B8A5 RID: 47269
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__3_1_Internal_Int32_KeyValuePair_2_Item_Int32_0;
			}
		}

		// Token: 0x02000F16 RID: 3862
		public class ItemByAcquireOrderFactory : FilterOptions.NonTradableByAcquireOrderFactory<Item>
		{
			// Token: 0x06010EA7 RID: 69287 RVA: 0x003E8CD0 File Offset: 0x003E6ED0
			// Note: this type is marked as 'beforefieldinit'.
			static ItemByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "ItemByAcquireOrderFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr);
				FilterOptions.ItemByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr, "m_AcquireOrderCache");
				FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr, 100686555);
				FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr, 100686556);
				FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr, 100686557);
				FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr, 100686558);
			}

			// Token: 0x1700580B RID: 22539
			// (get) Token: 0x06010EA8 RID: 69288 RVA: 0x003E8D60 File Offset: 0x003E6F60
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283155, XrefRangeEnd = 283159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010EA9 RID: 69289 RVA: 0x003E8DA4 File Offset: 0x003E6FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283159, XrefRangeEnd = 283170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EAA RID: 69290 RVA: 0x003E8DE0 File Offset: 0x003E6FE0
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override List<int> GetAcquireOrderList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}

			// Token: 0x06010EAB RID: 69291 RVA: 0x003E8E2C File Offset: 0x003E702C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283170, XrefRangeEnd = 283173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.ItemByAcquireOrderFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EAC RID: 69292 RVA: 0x00093392 File Offset: 0x00091592
			public ItemByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700580A RID: 22538
			// (get) Token: 0x06010EAD RID: 69293 RVA: 0x003E8E74 File Offset: 0x003E7074
			// (set) Token: 0x06010EAE RID: 69294 RVA: 0x0009339B File Offset: 0x0009159B
			public unsafe List<int> m_AcquireOrderCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB27 RID: 43815
			private static readonly IntPtr NativeFieldInfoPtr_m_AcquireOrderCache;

			// Token: 0x0400AB28 RID: 43816
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB29 RID: 43817
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB2A RID: 43818
			private static readonly IntPtr NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0;

			// Token: 0x0400AB2B RID: 43819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F17 RID: 3863
		public class ItemByTypeFactory : ByValueContainsConfigFactory<FilterOptions.ItemByTypeFactory.ItemType, Item>
		{
			// Token: 0x06010EAF RID: 69295 RVA: 0x003E8EA4 File Offset: 0x003E70A4
			// Note: this type is marked as 'beforefieldinit'.
			static ItemByTypeFactory()
			{
				Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "ItemByTypeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr);
				FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, "m_ItemTypes");
				FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypeTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, "m_ItemTypeTexts");
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686559);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686560);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686561);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686562);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686563);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686564);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_ItemType_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686565);
				FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr, 100686566);
			}

			// Token: 0x1700580E RID: 22542
			// (get) Token: 0x06010EB0 RID: 69296 RVA: 0x003E8F98 File Offset: 0x003E7198
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700580F RID: 22543
			// (get) Token: 0x06010EB1 RID: 69297 RVA: 0x003E8FE0 File Offset: 0x003E71E0
			public unsafe override uint ColumnCount
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005810 RID: 22544
			// (get) Token: 0x06010EB2 RID: 69298 RVA: 0x003E901C File Offset: 0x003E721C
			public unsafe override Rule ContainsRule
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010EB3 RID: 69299 RVA: 0x003E9064 File Offset: 0x003E7264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283173, XrefRangeEnd = 283177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EB4 RID: 69300 RVA: 0x003E90B4 File Offset: 0x003E72B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283177, XrefRangeEnd = 283181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<FilterOptions.ItemByTypeFactory.ItemType> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_ItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FilterOptions.ItemByTypeFactory.ItemType>>(intPtr3) : null;
			}

			// Token: 0x06010EB5 RID: 69301 RVA: 0x003E9100 File Offset: 0x003E7300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283181, XrefRangeEnd = 283205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(FilterOptions.ItemByTypeFactory.ItemType value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_ItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EB6 RID: 69302 RVA: 0x003E9150 File Offset: 0x003E7350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283205, XrefRangeEnd = 283219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<FilterOptions.ItemByTypeFactory.ItemType> GetFocusing(Item ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_ItemType_Item_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FilterOptions.ItemByTypeFactory.ItemType>>(intPtr3) : null;
			}

			// Token: 0x06010EB7 RID: 69303 RVA: 0x003E91AC File Offset: 0x003E73AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283219, XrefRangeEnd = 283222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemByTypeFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.ItemByTypeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.ItemByTypeFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EB8 RID: 69304 RVA: 0x000933BA File Offset: 0x000915BA
			public ItemByTypeFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700580C RID: 22540
			// (get) Token: 0x06010EB9 RID: 69305 RVA: 0x003E91F4 File Offset: 0x003E73F4
			// (set) Token: 0x06010EBA RID: 69306 RVA: 0x000933C3 File Offset: 0x000915C3
			public unsafe static IReadOnlyCollection<FilterOptions.ItemByTypeFactory.ItemType> m_ItemTypes
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypes, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<FilterOptions.ItemByTypeFactory.ItemType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700580D RID: 22541
			// (get) Token: 0x06010EBB RID: 69307 RVA: 0x003E921C File Offset: 0x003E741C
			// (set) Token: 0x06010EBC RID: 69308 RVA: 0x000933D5 File Offset: 0x000915D5
			public unsafe Dictionary<FilterOptions.ItemByTypeFactory.ItemType, string> m_ItemTypeTexts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypeTexts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FilterOptions.ItemByTypeFactory.ItemType, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.ItemByTypeFactory.NativeFieldInfoPtr_m_ItemTypeTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB2C RID: 43820
			private static readonly IntPtr NativeFieldInfoPtr_m_ItemTypes;

			// Token: 0x0400AB2D RID: 43821
			private static readonly IntPtr NativeFieldInfoPtr_m_ItemTypeTexts;

			// Token: 0x0400AB2E RID: 43822
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_get_FilterType_0;

			// Token: 0x0400AB2F RID: 43823
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB30 RID: 43824
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0;

			// Token: 0x0400AB31 RID: 43825
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0;

			// Token: 0x0400AB32 RID: 43826
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_ItemType_0;

			// Token: 0x0400AB33 RID: 43827
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_ItemType_0;

			// Token: 0x0400AB34 RID: 43828
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_ItemType_Item_0;

			// Token: 0x0400AB35 RID: 43829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

			// Token: 0x020010C8 RID: 4296
			public enum ItemType
			{
				// Token: 0x0400B8A7 RID: 47271
				Clothes,
				// Token: 0x0400B8A8 RID: 47272
				Decoration,
				// Token: 0x0400B8A9 RID: 47273
				Record,
				// Token: 0x0400B8AA RID: 47274
				TimeLimitedItem,
				// Token: 0x0400B8AB RID: 47275
				Other
			}
		}

		// Token: 0x02000F18 RID: 3864
		public static class LanguageList : Object
		{
			// Token: 0x06010EBD RID: 69309 RVA: 0x000933F4 File Offset: 0x000915F4
			// Note: this type is marked as 'beforefieldinit'.
			static LanguageList()
			{
				Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "LanguageList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr);
			}

			// Token: 0x06010EBE RID: 69310 RVA: 0x00093414 File Offset: 0x00091614
			public LanguageList(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x020010C9 RID: 4297
			public static class StringProvider : Object
			{
				// Token: 0x06012382 RID: 74626 RVA: 0x004273CC File Offset: 0x004255CC
				// Note: this type is marked as 'beforefieldinit'.
				static StringProvider()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "StringProvider");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsAnd_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686568);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsOr_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686569);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsNot_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686570);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Amount_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686571);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Tag_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686572);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Price_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686573);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Level_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686574);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Type_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686575);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Serie_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686576);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_AcquireOrder_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686577);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_FirstDigit_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686578);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_IsDailyMenu_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686579);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Ascending_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686580);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Descending_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686581);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Recipe_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686582);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Item_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686583);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Ingredient_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686584);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Cooker_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686585);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Food_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686586);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Beverage_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686587);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Base_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686588);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Super_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686589);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Extreme_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686590);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Sparrow_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686591);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Nuclear_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686592);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Suspicious_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686593);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Tsukimi_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686594);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_SamadhiFire_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686595);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_PeerlessWindGod_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686596);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_StarMagicPot_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686597);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_PureHellFryer_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686598);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_ByakurenCuttingBoard_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686599);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Trinity_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686600);
					FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Cook_Count_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.StringProvider>.NativeClassPtr, 100686601);
				}

				// Token: 0x17005F44 RID: 24388
				// (get) Token: 0x06012383 RID: 74627 RVA: 0x004276A0 File Offset: 0x004258A0
				public unsafe static string Rule_ContainsAnd
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283222, XrefRangeEnd = 283225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsAnd_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F45 RID: 24389
				// (get) Token: 0x06012384 RID: 74628 RVA: 0x004276CC File Offset: 0x004258CC
				public unsafe static string Rule_ContainsOr
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283225, XrefRangeEnd = 283228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsOr_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F46 RID: 24390
				// (get) Token: 0x06012385 RID: 74629 RVA: 0x004276F8 File Offset: 0x004258F8
				public unsafe static string Rule_ContainsNot
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283228, XrefRangeEnd = 283231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Rule_ContainsNot_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F47 RID: 24391
				// (get) Token: 0x06012386 RID: 74630 RVA: 0x00427724 File Offset: 0x00425924
				public unsafe static string General_Amount
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283231, XrefRangeEnd = 283234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Amount_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F48 RID: 24392
				// (get) Token: 0x06012387 RID: 74631 RVA: 0x00427750 File Offset: 0x00425950
				public unsafe static string General_Tag
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283234, XrefRangeEnd = 283237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Tag_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F49 RID: 24393
				// (get) Token: 0x06012388 RID: 74632 RVA: 0x0042777C File Offset: 0x0042597C
				public unsafe static string General_Price
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283237, XrefRangeEnd = 283240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Price_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4A RID: 24394
				// (get) Token: 0x06012389 RID: 74633 RVA: 0x004277A8 File Offset: 0x004259A8
				public unsafe static string General_Level
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283240, XrefRangeEnd = 283243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Level_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4B RID: 24395
				// (get) Token: 0x0601238A RID: 74634 RVA: 0x004277D4 File Offset: 0x004259D4
				public unsafe static string General_Type
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283243, XrefRangeEnd = 283246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Type_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4C RID: 24396
				// (get) Token: 0x0601238B RID: 74635 RVA: 0x00427800 File Offset: 0x00425A00
				public unsafe static string General_Serie
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283246, XrefRangeEnd = 283249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Serie_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4D RID: 24397
				// (get) Token: 0x0601238C RID: 74636 RVA: 0x0042782C File Offset: 0x00425A2C
				public unsafe static string General_AcquireOrder
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283249, XrefRangeEnd = 283252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_AcquireOrder_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4E RID: 24398
				// (get) Token: 0x0601238D RID: 74637 RVA: 0x00427858 File Offset: 0x00425A58
				public unsafe static string General_FirstDigit
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 283255, RefRangeEnd = 283256, XrefRangeStart = 283252, XrefRangeEnd = 283255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_FirstDigit_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F4F RID: 24399
				// (get) Token: 0x0601238E RID: 74638 RVA: 0x00427884 File Offset: 0x00425A84
				public unsafe static string General_IsDailyMenu
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283256, XrefRangeEnd = 283259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_IsDailyMenu_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F50 RID: 24400
				// (get) Token: 0x0601238F RID: 74639 RVA: 0x004278B0 File Offset: 0x00425AB0
				public unsafe static string General_Ascending
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283259, XrefRangeEnd = 283262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Ascending_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F51 RID: 24401
				// (get) Token: 0x06012390 RID: 74640 RVA: 0x004278DC File Offset: 0x00425ADC
				public unsafe static string General_Descending
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283262, XrefRangeEnd = 283265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_General_Descending_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F52 RID: 24402
				// (get) Token: 0x06012391 RID: 74641 RVA: 0x00427908 File Offset: 0x00425B08
				public unsafe static string Recipe_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283265, XrefRangeEnd = 283268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Recipe_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F53 RID: 24403
				// (get) Token: 0x06012392 RID: 74642 RVA: 0x00427934 File Offset: 0x00425B34
				public unsafe static string Item_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Item_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F54 RID: 24404
				// (get) Token: 0x06012393 RID: 74643 RVA: 0x00427960 File Offset: 0x00425B60
				public unsafe static string Ingredient_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Ingredient_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F55 RID: 24405
				// (get) Token: 0x06012394 RID: 74644 RVA: 0x0042798C File Offset: 0x00425B8C
				public unsafe static string Cooker_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283268, XrefRangeEnd = 283271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Cooker_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F56 RID: 24406
				// (get) Token: 0x06012395 RID: 74645 RVA: 0x004279B8 File Offset: 0x00425BB8
				public unsafe static string Food_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283271, XrefRangeEnd = 283274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Food_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F57 RID: 24407
				// (get) Token: 0x06012396 RID: 74646 RVA: 0x004279E4 File Offset: 0x00425BE4
				public unsafe static string Beverage_Name
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283274, XrefRangeEnd = 283277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Beverage_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F58 RID: 24408
				// (get) Token: 0x06012397 RID: 74647 RVA: 0x00427A10 File Offset: 0x00425C10
				public unsafe static string CookerSeries_Base
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283277, XrefRangeEnd = 283280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Base_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F59 RID: 24409
				// (get) Token: 0x06012398 RID: 74648 RVA: 0x00427A3C File Offset: 0x00425C3C
				public unsafe static string CookerSeries_Super
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283280, XrefRangeEnd = 283283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Super_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5A RID: 24410
				// (get) Token: 0x06012399 RID: 74649 RVA: 0x00427A68 File Offset: 0x00425C68
				public unsafe static string CookerSeries_Extreme
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283283, XrefRangeEnd = 283286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Extreme_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5B RID: 24411
				// (get) Token: 0x0601239A RID: 74650 RVA: 0x00427A94 File Offset: 0x00425C94
				public unsafe static string CookerSeries_Sparrow
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283286, XrefRangeEnd = 283289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Sparrow_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5C RID: 24412
				// (get) Token: 0x0601239B RID: 74651 RVA: 0x00427AC0 File Offset: 0x00425CC0
				public unsafe static string CookerSeries_Nuclear
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283289, XrefRangeEnd = 283292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Nuclear_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5D RID: 24413
				// (get) Token: 0x0601239C RID: 74652 RVA: 0x00427AEC File Offset: 0x00425CEC
				public unsafe static string CookerSeries_Suspicious
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283292, XrefRangeEnd = 283295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Suspicious_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5E RID: 24414
				// (get) Token: 0x0601239D RID: 74653 RVA: 0x00427B18 File Offset: 0x00425D18
				public unsafe static string CookerSeries_Tsukimi
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283295, XrefRangeEnd = 283298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Tsukimi_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F5F RID: 24415
				// (get) Token: 0x0601239E RID: 74654 RVA: 0x00427B44 File Offset: 0x00425D44
				public unsafe static string CookerSeries_SamadhiFire
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283298, XrefRangeEnd = 283301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_SamadhiFire_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F60 RID: 24416
				// (get) Token: 0x0601239F RID: 74655 RVA: 0x00427B70 File Offset: 0x00425D70
				public unsafe static string CookerSeries_PeerlessWindGod
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283301, XrefRangeEnd = 283304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_PeerlessWindGod_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F61 RID: 24417
				// (get) Token: 0x060123A0 RID: 74656 RVA: 0x00427B9C File Offset: 0x00425D9C
				public unsafe static string CookerSeries_StarMagicPot
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283304, XrefRangeEnd = 283307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_StarMagicPot_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F62 RID: 24418
				// (get) Token: 0x060123A1 RID: 74657 RVA: 0x00427BC8 File Offset: 0x00425DC8
				public unsafe static string CookerSeries_PureHellFryer
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283307, XrefRangeEnd = 283310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_PureHellFryer_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F63 RID: 24419
				// (get) Token: 0x060123A2 RID: 74658 RVA: 0x00427BF4 File Offset: 0x00425DF4
				public unsafe static string CookerSeries_ByakurenCuttingBoard
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283310, XrefRangeEnd = 283313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_ByakurenCuttingBoard_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F64 RID: 24420
				// (get) Token: 0x060123A3 RID: 74659 RVA: 0x00427C20 File Offset: 0x00425E20
				public unsafe static string CookerSeries_Trinity
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283313, XrefRangeEnd = 283316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_CookerSeries_Trinity_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x17005F65 RID: 24421
				// (get) Token: 0x060123A4 RID: 74660 RVA: 0x00427C4C File Offset: 0x00425E4C
				public unsafe static string Cook_Count
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283316, XrefRangeEnd = 283319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.StringProvider.NativeMethodInfoPtr_get_Cook_Count_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060123A5 RID: 74661 RVA: 0x0009E20A File Offset: 0x0009C40A
				public StringProvider(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8AC RID: 47276
				private static readonly IntPtr NativeMethodInfoPtr_get_Rule_ContainsAnd_Public_Static_get_String_0;

				// Token: 0x0400B8AD RID: 47277
				private static readonly IntPtr NativeMethodInfoPtr_get_Rule_ContainsOr_Public_Static_get_String_0;

				// Token: 0x0400B8AE RID: 47278
				private static readonly IntPtr NativeMethodInfoPtr_get_Rule_ContainsNot_Public_Static_get_String_0;

				// Token: 0x0400B8AF RID: 47279
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Amount_Public_Static_get_String_0;

				// Token: 0x0400B8B0 RID: 47280
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Tag_Public_Static_get_String_0;

				// Token: 0x0400B8B1 RID: 47281
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Price_Public_Static_get_String_0;

				// Token: 0x0400B8B2 RID: 47282
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Level_Public_Static_get_String_0;

				// Token: 0x0400B8B3 RID: 47283
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Type_Public_Static_get_String_0;

				// Token: 0x0400B8B4 RID: 47284
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Serie_Public_Static_get_String_0;

				// Token: 0x0400B8B5 RID: 47285
				private static readonly IntPtr NativeMethodInfoPtr_get_General_AcquireOrder_Public_Static_get_String_0;

				// Token: 0x0400B8B6 RID: 47286
				private static readonly IntPtr NativeMethodInfoPtr_get_General_FirstDigit_Public_Static_get_String_0;

				// Token: 0x0400B8B7 RID: 47287
				private static readonly IntPtr NativeMethodInfoPtr_get_General_IsDailyMenu_Public_Static_get_String_0;

				// Token: 0x0400B8B8 RID: 47288
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Ascending_Public_Static_get_String_0;

				// Token: 0x0400B8B9 RID: 47289
				private static readonly IntPtr NativeMethodInfoPtr_get_General_Descending_Public_Static_get_String_0;

				// Token: 0x0400B8BA RID: 47290
				private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Name_Public_Static_get_String_0;

				// Token: 0x0400B8BB RID: 47291
				private static readonly IntPtr NativeMethodInfoPtr_get_Item_Name_Public_Static_get_String_0;

				// Token: 0x0400B8BC RID: 47292
				private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient_Name_Public_Static_get_String_0;

				// Token: 0x0400B8BD RID: 47293
				private static readonly IntPtr NativeMethodInfoPtr_get_Cooker_Name_Public_Static_get_String_0;

				// Token: 0x0400B8BE RID: 47294
				private static readonly IntPtr NativeMethodInfoPtr_get_Food_Name_Public_Static_get_String_0;

				// Token: 0x0400B8BF RID: 47295
				private static readonly IntPtr NativeMethodInfoPtr_get_Beverage_Name_Public_Static_get_String_0;

				// Token: 0x0400B8C0 RID: 47296
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Base_Public_Static_get_String_0;

				// Token: 0x0400B8C1 RID: 47297
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Super_Public_Static_get_String_0;

				// Token: 0x0400B8C2 RID: 47298
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Extreme_Public_Static_get_String_0;

				// Token: 0x0400B8C3 RID: 47299
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Sparrow_Public_Static_get_String_0;

				// Token: 0x0400B8C4 RID: 47300
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Nuclear_Public_Static_get_String_0;

				// Token: 0x0400B8C5 RID: 47301
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Suspicious_Public_Static_get_String_0;

				// Token: 0x0400B8C6 RID: 47302
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Tsukimi_Public_Static_get_String_0;

				// Token: 0x0400B8C7 RID: 47303
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_SamadhiFire_Public_Static_get_String_0;

				// Token: 0x0400B8C8 RID: 47304
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_PeerlessWindGod_Public_Static_get_String_0;

				// Token: 0x0400B8C9 RID: 47305
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_StarMagicPot_Public_Static_get_String_0;

				// Token: 0x0400B8CA RID: 47306
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_PureHellFryer_Public_Static_get_String_0;

				// Token: 0x0400B8CB RID: 47307
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_ByakurenCuttingBoard_Public_Static_get_String_0;

				// Token: 0x0400B8CC RID: 47308
				private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Trinity_Public_Static_get_String_0;

				// Token: 0x0400B8CD RID: 47309
				private static readonly IntPtr NativeMethodInfoPtr_get_Cook_Count_Public_Static_get_String_0;
			}

			// Token: 0x020010CA RID: 4298
			public static class ByValueContains : Object
			{
				// Token: 0x060123A6 RID: 74662 RVA: 0x0009E213 File Offset: 0x0009C413
				// Note: this type is marked as 'beforefieldinit'.
				static ByValueContains()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.ByValueContains>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "ByValueContains");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.ByValueContains>.NativeClassPtr);
					FilterOptions.LanguageList.ByValueContains.NativeMethodInfoPtr_GetRuleText_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.ByValueContains>.NativeClassPtr, 100686602);
				}

				// Token: 0x060123A7 RID: 74663 RVA: 0x00427C78 File Offset: 0x00425E78
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 283322, RefRangeEnd = 283329, XrefRangeStart = 283319, XrefRangeEnd = 283322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRuleText(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.ByValueContains.NativeMethodInfoPtr_GetRuleText_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123A8 RID: 74664 RVA: 0x0009E247 File Offset: 0x0009C447
				public ByValueContains(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8CE RID: 47310
				private static readonly IntPtr NativeMethodInfoPtr_GetRuleText_Public_Static_String_Rule_0;
			}

			// Token: 0x020010CB RID: 4299
			public static class GeneralFilter : Object
			{
				// Token: 0x060123A9 RID: 74665 RVA: 0x00427CB0 File Offset: 0x00425EB0
				// Note: this type is marked as 'beforefieldinit'.
				static GeneralFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "GeneralFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByTagFactoryText_Public_Static_String_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686603);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByPriceFactoryText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686604);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByLevelFactoryText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686605);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByAcquireOrderFactoryText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686606);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByAmountFactoryText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686607);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByTypeFactoryText_Public_Static_String_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686608);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetBySeriesFactoryText_Public_Static_String_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686609);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetOrderText_Public_Static_String_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686610);
					FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByCapicalLetterFactoryText_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.GeneralFilter>.NativeClassPtr, 100686611);
				}

				// Token: 0x060123AA RID: 74666 RVA: 0x00427D90 File Offset: 0x00425F90
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283340, RefRangeEnd = 283341, XrefRangeStart = 283329, XrefRangeEnd = 283340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByTagFactoryText(string objectName, Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByTagFactoryText_Public_Static_String_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123AB RID: 74667 RVA: 0x00427DDC File Offset: 0x00425FDC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283348, RefRangeEnd = 283349, XrefRangeStart = 283341, XrefRangeEnd = 283348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByPriceFactoryText(string objectName)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByPriceFactoryText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123AC RID: 74668 RVA: 0x00427E18 File Offset: 0x00426018
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283356, RefRangeEnd = 283357, XrefRangeStart = 283349, XrefRangeEnd = 283356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByLevelFactoryText(string objectName)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByLevelFactoryText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123AD RID: 74669 RVA: 0x00427E54 File Offset: 0x00426054
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 283364, RefRangeEnd = 283371, XrefRangeStart = 283357, XrefRangeEnd = 283364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByAcquireOrderFactoryText(string objectName)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByAcquireOrderFactoryText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123AE RID: 74670 RVA: 0x00427E90 File Offset: 0x00426090
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283378, RefRangeEnd = 283379, XrefRangeStart = 283371, XrefRangeEnd = 283378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByAmountFactoryText(string objectName)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByAmountFactoryText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123AF RID: 74671 RVA: 0x00427ECC File Offset: 0x004260CC
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 283390, RefRangeEnd = 283396, XrefRangeStart = 283379, XrefRangeEnd = 283390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByTypeFactoryText(string objectName, Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByTypeFactoryText_Public_Static_String_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B0 RID: 74672 RVA: 0x00427F18 File Offset: 0x00426118
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283396, XrefRangeEnd = 283407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetBySeriesFactoryText(string objectName, Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetBySeriesFactoryText_Public_Static_String_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B1 RID: 74673 RVA: 0x00427F64 File Offset: 0x00426164
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283413, RefRangeEnd = 283414, XrefRangeStart = 283407, XrefRangeEnd = 283413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetOrderText(Order order)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref order;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetOrderText_Public_Static_String_Order_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B2 RID: 74674 RVA: 0x00427F9C File Offset: 0x0042619C
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 283255, RefRangeEnd = 283256, XrefRangeStart = 283255, XrefRangeEnd = 283256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetByCapicalLetterFactoryText()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.GeneralFilter.NativeMethodInfoPtr_GetByCapicalLetterFactoryText_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B3 RID: 74675 RVA: 0x0009E250 File Offset: 0x0009C450
				public GeneralFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8CF RID: 47311
				private static readonly IntPtr NativeMethodInfoPtr_GetByTagFactoryText_Public_Static_String_String_Rule_0;

				// Token: 0x0400B8D0 RID: 47312
				private static readonly IntPtr NativeMethodInfoPtr_GetByPriceFactoryText_Public_Static_String_String_0;

				// Token: 0x0400B8D1 RID: 47313
				private static readonly IntPtr NativeMethodInfoPtr_GetByLevelFactoryText_Public_Static_String_String_0;

				// Token: 0x0400B8D2 RID: 47314
				private static readonly IntPtr NativeMethodInfoPtr_GetByAcquireOrderFactoryText_Public_Static_String_String_0;

				// Token: 0x0400B8D3 RID: 47315
				private static readonly IntPtr NativeMethodInfoPtr_GetByAmountFactoryText_Public_Static_String_String_0;

				// Token: 0x0400B8D4 RID: 47316
				private static readonly IntPtr NativeMethodInfoPtr_GetByTypeFactoryText_Public_Static_String_String_Rule_0;

				// Token: 0x0400B8D5 RID: 47317
				private static readonly IntPtr NativeMethodInfoPtr_GetBySeriesFactoryText_Public_Static_String_String_Rule_0;

				// Token: 0x0400B8D6 RID: 47318
				private static readonly IntPtr NativeMethodInfoPtr_GetOrderText_Public_Static_String_Order_0;

				// Token: 0x0400B8D7 RID: 47319
				private static readonly IntPtr NativeMethodInfoPtr_GetByCapicalLetterFactoryText_Public_Static_String_0;
			}

			// Token: 0x020010CC RID: 4300
			public static class CookerFilter : Object
			{
				// Token: 0x060123B4 RID: 74676 RVA: 0x00427FC8 File Offset: 0x004261C8
				// Note: this type is marked as 'beforefieldinit'.
				static CookerFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "CookerFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr);
					FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerByAcquireOrderFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr, 100686612);
					FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerByCookerTypeFactoryName_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr, 100686613);
					FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerBySeriesTypeFactoryName_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr, 100686614);
					FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetSeriesSelectionText_Public_Static_String_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.CookerFilter>.NativeClassPtr, 100686615);
				}

				// Token: 0x060123B5 RID: 74677 RVA: 0x00428044 File Offset: 0x00426244
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetCookerByAcquireOrderFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerByAcquireOrderFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B6 RID: 74678 RVA: 0x00428070 File Offset: 0x00426270
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283414, XrefRangeEnd = 283418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetCookerByCookerTypeFactoryName(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerByCookerTypeFactoryName_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B7 RID: 74679 RVA: 0x004280A8 File Offset: 0x004262A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283418, XrefRangeEnd = 283432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetCookerBySeriesTypeFactoryName(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetCookerBySeriesTypeFactoryName_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B8 RID: 74680 RVA: 0x004280E0 File Offset: 0x004262E0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 283435, RefRangeEnd = 283437, XrefRangeStart = 283432, XrefRangeEnd = 283435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetSeriesSelectionText(Cooker.CookerSeries series)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref series;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.CookerFilter.NativeMethodInfoPtr_GetSeriesSelectionText_Public_Static_String_CookerSeries_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123B9 RID: 74681 RVA: 0x0009E259 File Offset: 0x0009C459
				public CookerFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8D8 RID: 47320
				private static readonly IntPtr NativeMethodInfoPtr_GetCookerByAcquireOrderFactoryName_Public_Static_String_0;

				// Token: 0x0400B8D9 RID: 47321
				private static readonly IntPtr NativeMethodInfoPtr_GetCookerByCookerTypeFactoryName_Public_Static_String_Rule_0;

				// Token: 0x0400B8DA RID: 47322
				private static readonly IntPtr NativeMethodInfoPtr_GetCookerBySeriesTypeFactoryName_Public_Static_String_Rule_0;

				// Token: 0x0400B8DB RID: 47323
				private static readonly IntPtr NativeMethodInfoPtr_GetSeriesSelectionText_Public_Static_String_CookerSeries_0;
			}

			// Token: 0x020010CD RID: 4301
			public static class IngredientFilter : Object
			{
				// Token: 0x060123BA RID: 74682 RVA: 0x0009E262 File Offset: 0x0009C462
				// Note: this type is marked as 'beforefieldinit'.
				static IngredientFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.IngredientFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "IngredientFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.IngredientFilter>.NativeClassPtr);
					FilterOptions.LanguageList.IngredientFilter.NativeMethodInfoPtr_GetIngredientTypeName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.IngredientFilter>.NativeClassPtr, 100686616);
				}

				// Token: 0x060123BB RID: 74683 RVA: 0x00428118 File Offset: 0x00426318
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetIngredientTypeName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.IngredientFilter.NativeMethodInfoPtr_GetIngredientTypeName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123BC RID: 74684 RVA: 0x0009E296 File Offset: 0x0009C496
				public IngredientFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8DC RID: 47324
				private static readonly IntPtr NativeMethodInfoPtr_GetIngredientTypeName_Public_Static_String_0;
			}

			// Token: 0x020010CE RID: 4302
			public static class ItemFilter : Object
			{
				// Token: 0x060123BD RID: 74685 RVA: 0x00428144 File Offset: 0x00426344
				// Note: this type is marked as 'beforefieldinit'.
				static ItemFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "ItemFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.ItemFilter>.NativeClassPtr);
					FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemTypeName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.ItemFilter>.NativeClassPtr, 100686617);
					FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemByAcquireOrderFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.ItemFilter>.NativeClassPtr, 100686618);
					FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemByTypeOrderFactoryName_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.ItemFilter>.NativeClassPtr, 100686619);
				}

				// Token: 0x060123BE RID: 74686 RVA: 0x004281AC File Offset: 0x004263AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetItemTypeName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemTypeName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123BF RID: 74687 RVA: 0x004281D8 File Offset: 0x004263D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetItemByAcquireOrderFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemByAcquireOrderFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C0 RID: 74688 RVA: 0x00428204 File Offset: 0x00426404
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283437, XrefRangeEnd = 283441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetItemByTypeOrderFactoryName(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.ItemFilter.NativeMethodInfoPtr_GetItemByTypeOrderFactoryName_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C1 RID: 74689 RVA: 0x0009E29F File Offset: 0x0009C49F
				public ItemFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8DD RID: 47325
				private static readonly IntPtr NativeMethodInfoPtr_GetItemTypeName_Public_Static_String_0;

				// Token: 0x0400B8DE RID: 47326
				private static readonly IntPtr NativeMethodInfoPtr_GetItemByAcquireOrderFactoryName_Public_Static_String_0;

				// Token: 0x0400B8DF RID: 47327
				private static readonly IntPtr NativeMethodInfoPtr_GetItemByTypeOrderFactoryName_Public_Static_String_Rule_0;
			}

			// Token: 0x020010CF RID: 4303
			public static class RecipeFilter : Object
			{
				// Token: 0x060123C2 RID: 74690 RVA: 0x0042823C File Offset: 0x0042643C
				// Note: this type is marked as 'beforefieldinit'.
				static RecipeFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "RecipeFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByCookerFactoryName_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686620);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByTagFactoryName_Public_Static_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686621);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByFoodPriceFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686622);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByFoodLevelFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686623);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByCookCountFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686624);
					FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByAcquireOrderFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.RecipeFilter>.NativeClassPtr, 100686625);
				}

				// Token: 0x060123C3 RID: 74691 RVA: 0x004282E0 File Offset: 0x004264E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283441, XrefRangeEnd = 283445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByCookerFactoryName(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByCookerFactoryName_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C4 RID: 74692 RVA: 0x00428318 File Offset: 0x00426518
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283445, XrefRangeEnd = 283459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByTagFactoryName(Rule rule)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref rule;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByTagFactoryName_Public_Static_String_Rule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C5 RID: 74693 RVA: 0x00428350 File Offset: 0x00426550
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283459, XrefRangeEnd = 283469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByFoodPriceFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByFoodPriceFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C6 RID: 74694 RVA: 0x0042837C File Offset: 0x0042657C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283469, XrefRangeEnd = 283479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByFoodLevelFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByFoodLevelFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C7 RID: 74695 RVA: 0x004283A8 File Offset: 0x004265A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByCookCountFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByCookCountFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C8 RID: 74696 RVA: 0x004283D4 File Offset: 0x004265D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283479, XrefRangeEnd = 283483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetRecipeByAcquireOrderFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.RecipeFilter.NativeMethodInfoPtr_GetRecipeByAcquireOrderFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123C9 RID: 74697 RVA: 0x0009E2A8 File Offset: 0x0009C4A8
				public RecipeFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8E0 RID: 47328
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByCookerFactoryName_Public_Static_String_Rule_0;

				// Token: 0x0400B8E1 RID: 47329
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByTagFactoryName_Public_Static_String_Rule_0;

				// Token: 0x0400B8E2 RID: 47330
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByFoodPriceFactoryName_Public_Static_String_0;

				// Token: 0x0400B8E3 RID: 47331
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByFoodLevelFactoryName_Public_Static_String_0;

				// Token: 0x0400B8E4 RID: 47332
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByCookCountFactoryName_Public_Static_String_0;

				// Token: 0x0400B8E5 RID: 47333
				private static readonly IntPtr NativeMethodInfoPtr_GetRecipeByAcquireOrderFactoryName_Public_Static_String_0;
			}

			// Token: 0x020010D0 RID: 4304
			public static class SellableFilter : Object
			{
				// Token: 0x060123CA RID: 74698 RVA: 0x00428400 File Offset: 0x00426600
				// Note: this type is marked as 'beforefieldinit'.
				static SellableFilter()
				{
					Il2CppClassPointerStore<FilterOptions.LanguageList.SellableFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.LanguageList>.NativeClassPtr, "SellableFilter");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.LanguageList.SellableFilter>.NativeClassPtr);
					FilterOptions.LanguageList.SellableFilter.NativeMethodInfoPtr_GetSellableName_Public_Static_String_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.SellableFilter>.NativeClassPtr, 100686626);
					FilterOptions.LanguageList.SellableFilter.NativeMethodInfoPtr_GetIsDailySellableFactoryName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.LanguageList.SellableFilter>.NativeClassPtr, 100686627);
				}

				// Token: 0x060123CB RID: 74699 RVA: 0x00428454 File Offset: 0x00426654
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283483, XrefRangeEnd = 283489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetSellableName(Sellable.SellableType sellableType)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref sellableType;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.SellableFilter.NativeMethodInfoPtr_GetSellableName_Public_Static_String_SellableType_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123CC RID: 74700 RVA: 0x0042848C File Offset: 0x0042668C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static string GetIsDailySellableFactoryName()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.LanguageList.SellableFilter.NativeMethodInfoPtr_GetIsDailySellableFactoryName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060123CD RID: 74701 RVA: 0x0009E2B1 File Offset: 0x0009C4B1
				public SellableFilter(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0400B8E6 RID: 47334
				private static readonly IntPtr NativeMethodInfoPtr_GetSellableName_Public_Static_String_SellableType_0;

				// Token: 0x0400B8E7 RID: 47335
				private static readonly IntPtr NativeMethodInfoPtr_GetIsDailySellableFactoryName_Public_Static_String_0;
			}
		}

		// Token: 0x02000F19 RID: 3865
		public class NonTradableByCountFactory<TNonTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TNonTradableObjectBase> where TNonTradableObjectBase : NonTradableObjectBase
		{
			// Token: 0x06010EBF RID: 69311 RVA: 0x003E924C File Offset: 0x003E744C
			// Note: this type is marked as 'beforefieldinit'.
			static NonTradableByCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "NonTradableByCountFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNonTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr);
				FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_get_GetObjectName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686628);
				FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686629);
				FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetCountList_Protected_Abstract_Virtual_New_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686630);
				FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686631);
				FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686632);
			}

			// Token: 0x17005811 RID: 22545
			// (get) Token: 0x06010EC0 RID: 69312 RVA: 0x003E9318 File Offset: 0x003E7518
			public unsafe virtual string GetObjectName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_get_GetObjectName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17005812 RID: 22546
			// (get) Token: 0x06010EC1 RID: 69313 RVA: 0x003E935C File Offset: 0x003E755C
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283489, XrefRangeEnd = 283490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010EC2 RID: 69314 RVA: 0x003E9394 File Offset: 0x003E7594
			[CallerCount(0)]
			public unsafe virtual Dictionary<int, int> GetCountList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetCountList_Protected_Abstract_Virtual_New_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x06010EC3 RID: 69315 RVA: 0x003E93E0 File Offset: 0x003E75E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283490, XrefRangeEnd = 283493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetFocusing(TNonTradableObjectBase ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TNonTradableObjectBase).IsValueType)
				{
					TNonTradableObjectBase tnonTradableObjectBase = ordering;
					intPtr = ((tnonTradableObjectBase is string) ? IL2CPP.ManagedStringToIl2Cpp(tnonTradableObjectBase as string) : IL2CPP.Il2CppObjectBaseToPtr(tnonTradableObjectBase as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010EC4 RID: 69316 RVA: 0x003E9464 File Offset: 0x003E7664
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282067, RefRangeEnd = 282069, XrefRangeStart = 282067, XrefRangeEnd = 282069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NonTradableByCountFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NonTradableByCountFactory<TNonTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EC5 RID: 69317 RVA: 0x0009341D File Offset: 0x0009161D
			public NonTradableByCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB36 RID: 43830
			private static readonly IntPtr NativeMethodInfoPtr_get_GetObjectName_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400AB37 RID: 43831
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0;

			// Token: 0x0400AB38 RID: 43832
			private static readonly IntPtr NativeMethodInfoPtr_GetCountList_Protected_Abstract_Virtual_New_Dictionary_2_Int32_Int32_0;

			// Token: 0x0400AB39 RID: 43833
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0;

			// Token: 0x0400AB3A RID: 43834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F1A RID: 3866
		public class NonTradableByAcquireOrderFactory<TNonTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TNonTradableObjectBase> where TNonTradableObjectBase : NonTradableObjectBase
		{
			// Token: 0x06010EC6 RID: 69318 RVA: 0x003E94AC File Offset: 0x003E76AC
			// Note: this type is marked as 'beforefieldinit'.
			static NonTradableByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "NonTradableByAcquireOrderFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNonTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr);
				FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Abstract_Virtual_New_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686633);
				FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686634);
				FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr, 100686635);
			}

			// Token: 0x06010EC7 RID: 69319 RVA: 0x003E9550 File Offset: 0x003E7750
			[CallerCount(0)]
			public unsafe virtual List<int> GetAcquireOrderList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Abstract_Virtual_New_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}

			// Token: 0x06010EC8 RID: 69320 RVA: 0x003E959C File Offset: 0x003E779C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283493, XrefRangeEnd = 283497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetFocusing(TNonTradableObjectBase ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TNonTradableObjectBase).IsValueType)
				{
					TNonTradableObjectBase tnonTradableObjectBase = ordering;
					intPtr = ((tnonTradableObjectBase is string) ? IL2CPP.ManagedStringToIl2Cpp(tnonTradableObjectBase as string) : IL2CPP.Il2CppObjectBaseToPtr(tnonTradableObjectBase as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010EC9 RID: 69321 RVA: 0x003E9620 File Offset: 0x003E7820
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NonTradableByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.NonTradableByAcquireOrderFactory<TNonTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010ECA RID: 69322 RVA: 0x00093426 File Offset: 0x00091626
			public NonTradableByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB3B RID: 43835
			private static readonly IntPtr NativeMethodInfoPtr_GetAcquireOrderList_Protected_Abstract_Virtual_New_List_1_Int32_0;

			// Token: 0x0400AB3C RID: 43836
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TNonTradableObjectBase_0;

			// Token: 0x0400AB3D RID: 43837
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F1B RID: 3867
		public class TmiByValueOrderConfigFactory<TFocusing, TOrdering> : ByValueOrderConfigFactory<TFocusing, TOrdering>
		{
			// Token: 0x06010ECB RID: 69323 RVA: 0x003E9668 File Offset: 0x003E7868
			// Note: this type is marked as 'beforefieldinit'.
			static TmiByValueOrderConfigFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TmiByValueOrderConfigFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr);
				FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_Final_String_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686636);
				FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686637);
			}

			// Token: 0x06010ECC RID: 69324 RVA: 0x003E9708 File Offset: 0x003E7908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283497, XrefRangeEnd = 283498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(Order value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_Final_String_Order_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010ECD RID: 69325 RVA: 0x003E974C File Offset: 0x003E794C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 283500, RefRangeEnd = 283542, XrefRangeStart = 283498, XrefRangeEnd = 283500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TmiByValueOrderConfigFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TmiByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010ECE RID: 69326 RVA: 0x0009342F File Offset: 0x0009162F
			public TmiByValueOrderConfigFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB3E RID: 43838
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_Final_String_Order_0;

			// Token: 0x0400AB3F RID: 43839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F1C RID: 3868
		public class TmiByFirstLetterFactory<TOrdering> : FilterOptions.TmiByValueOrderConfigFactory<ushort, TOrdering> where TOrdering : NonTradableObjectBase
		{
			// Token: 0x06010ECF RID: 69327 RVA: 0x003E9794 File Offset: 0x003E7994
			// Note: this type is marked as 'beforefieldinit'.
			static TmiByFirstLetterFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TmiByFirstLetterFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr);
				FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr, 100686638);
				FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr, 100686639);
				FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_ShouldEnable_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr, 100686640);
				FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_UInt16_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr, 100686641);
				FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr, 100686642);
			}

			// Token: 0x17005813 RID: 22547
			// (get) Token: 0x06010ED0 RID: 69328 RVA: 0x003E9860 File Offset: 0x003E7A60
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283542, XrefRangeEnd = 283543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17005814 RID: 22548
			// (get) Token: 0x06010ED1 RID: 69329 RVA: 0x003E98A4 File Offset: 0x003E7AA4
			public unsafe override bool InvertSelection
			{
				[CallerCount(19)]
				[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010ED2 RID: 69330 RVA: 0x003E98EC File Offset: 0x003E7AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283543, XrefRangeEnd = 283544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ShouldEnable()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_ShouldEnable_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010ED3 RID: 69331 RVA: 0x003E9934 File Offset: 0x003E7B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283544, XrefRangeEnd = 283548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ushort GetFocusing(TOrdering ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TOrdering).IsValueType)
				{
					TOrdering tordering = ordering;
					intPtr = ((tordering is string) ? IL2CPP.ManagedStringToIl2Cpp(tordering as string) : IL2CPP.Il2CppObjectBaseToPtr(tordering as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_UInt16_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010ED4 RID: 69332 RVA: 0x003E99C4 File Offset: 0x003E7BC4
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 283548, RefRangeEnd = 283556, XrefRangeStart = 283548, XrefRangeEnd = 283548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TmiByFirstLetterFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TmiByFirstLetterFactory<TOrdering>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TmiByFirstLetterFactory<TOrdering>.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010ED5 RID: 69333 RVA: 0x00093438 File Offset: 0x00091638
			public TmiByFirstLetterFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB40 RID: 43840
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB41 RID: 43841
			private static readonly IntPtr NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_get_Boolean_0;

			// Token: 0x0400AB42 RID: 43842
			private static readonly IntPtr NativeMethodInfoPtr_ShouldEnable_Public_Virtual_Boolean_0;

			// Token: 0x0400AB43 RID: 43843
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_UInt16_TOrdering_0;

			// Token: 0x0400AB44 RID: 43844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F1D RID: 3869
		public class RecipeByFoodFactory<TOrderValue> : FilterOptions.TmiByValueOrderConfigFactory<TOrderValue, Recipe>
		{
			// Token: 0x06010ED6 RID: 69334 RVA: 0x003E9A0C File Offset: 0x003E7C0C
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByFoodFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByFoodFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr);
				FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TOrderValue_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr, 100686643);
				FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_TOrderValue_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr, 100686644);
				FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr, 100686645);
			}

			// Token: 0x06010ED7 RID: 69335 RVA: 0x003E9AB0 File Offset: 0x003E7CB0
			[CallerCount(0)]
			public unsafe virtual TOrderValue GetValue(Sellable food)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TOrderValue_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOrderValue>(intPtr, false, true);
			}

			// Token: 0x06010ED8 RID: 69336 RVA: 0x003E9B08 File Offset: 0x003E7D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283556, XrefRangeEnd = 283558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TOrderValue GetFocusing(Recipe ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_TOrderValue_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOrderValue>(intPtr, false, true);
			}

			// Token: 0x06010ED9 RID: 69337 RVA: 0x003E9B54 File Offset: 0x003E7D54
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 281971, RefRangeEnd = 281982, XrefRangeStart = 281971, XrefRangeEnd = 281982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByFoodFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByFoodFactory<TOrderValue>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByFoodFactory<TOrderValue>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EDA RID: 69338 RVA: 0x00093441 File Offset: 0x00091641
			public RecipeByFoodFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB45 RID: 43845
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Protected_Abstract_Virtual_New_TOrderValue_Sellable_0;

			// Token: 0x0400AB46 RID: 43846
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_TOrderValue_Recipe_0;

			// Token: 0x0400AB47 RID: 43847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F1E RID: 3870
		public class RecipeByCookerFactory : ByValueContainsConfigFactory<Cooker.CookerType, Recipe>
		{
			// Token: 0x06010EDB RID: 69339 RVA: 0x003E9B9C File Offset: 0x003E7D9C
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByCookerFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByCookerFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr);
				FilterOptions.RecipeByCookerFactory.NativeFieldInfoPtr_m_CookerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, "m_CookerTypes");
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686646);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686647);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686648);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686649);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686650);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686651);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686652);
				FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr, 100686653);
			}

			// Token: 0x17005816 RID: 22550
			// (get) Token: 0x06010EDC RID: 69340 RVA: 0x003E9C7C File Offset: 0x003E7E7C
			public unsafe override Rule ContainsRule
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005817 RID: 22551
			// (get) Token: 0x06010EDD RID: 69341 RVA: 0x003E9CC4 File Offset: 0x003E7EC4
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005818 RID: 22552
			// (get) Token: 0x06010EDE RID: 69342 RVA: 0x003E9D00 File Offset: 0x003E7F00
			public unsafe override uint ColumnCount
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010EDF RID: 69343 RVA: 0x003E9D3C File Offset: 0x003E7F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283558, XrefRangeEnd = 283562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EE0 RID: 69344 RVA: 0x003E9D8C File Offset: 0x003E7F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283562, XrefRangeEnd = 283566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerType> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}

			// Token: 0x06010EE1 RID: 69345 RVA: 0x003E9DD8 File Offset: 0x003E7FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(Cooker.CookerType value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EE2 RID: 69346 RVA: 0x003E9E28 File Offset: 0x003E8028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283566, XrefRangeEnd = 283570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Cooker.CookerType> GetFocusing(Recipe ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Recipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr3) : null;
			}

			// Token: 0x06010EE3 RID: 69347 RVA: 0x003E9E84 File Offset: 0x003E8084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283570, XrefRangeEnd = 283573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByCookerFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByCookerFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByCookerFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EE4 RID: 69348 RVA: 0x0009344A File Offset: 0x0009164A
			public RecipeByCookerFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005815 RID: 22549
			// (get) Token: 0x06010EE5 RID: 69349 RVA: 0x003E9ECC File Offset: 0x003E80CC
			// (set) Token: 0x06010EE6 RID: 69350 RVA: 0x00093453 File Offset: 0x00091653
			public unsafe static IReadOnlyCollection<Cooker.CookerType> m_CookerTypes
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterOptions.RecipeByCookerFactory.NativeFieldInfoPtr_m_CookerTypes, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterOptions.RecipeByCookerFactory.NativeFieldInfoPtr_m_CookerTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB48 RID: 43848
			private static readonly IntPtr NativeFieldInfoPtr_m_CookerTypes;

			// Token: 0x0400AB49 RID: 43849
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0;

			// Token: 0x0400AB4A RID: 43850
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

			// Token: 0x0400AB4B RID: 43851
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB4C RID: 43852
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0;

			// Token: 0x0400AB4D RID: 43853
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_CookerType_0;

			// Token: 0x0400AB4E RID: 43854
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_CookerType_0;

			// Token: 0x0400AB4F RID: 43855
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_CookerType_Recipe_0;

			// Token: 0x0400AB50 RID: 43856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F1F RID: 3871
		public class RecipeByTagFactory : ByValueContainsConfigFactory<int, Recipe>
		{
			// Token: 0x06010EE7 RID: 69351 RVA: 0x003E9EF4 File Offset: 0x003E80F4
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByTagFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByTagFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr);
				FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ContainsRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, "<ContainsRule>k__BackingField");
				FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ColumnCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, "<ColumnCount>k__BackingField");
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686655);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686656);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686657);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686658);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686659);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686660);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686661);
				FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, 100686662);
			}

			// Token: 0x06010EE8 RID: 69352 RVA: 0x003E9FE8 File Offset: 0x003E81E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283573, XrefRangeEnd = 283576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref contains;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700581B RID: 22555
			// (get) Token: 0x06010EE9 RID: 69353 RVA: 0x003EA04C File Offset: 0x003E824C
			public unsafe override Rule ContainsRule
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700581C RID: 22556
			// (get) Token: 0x06010EEA RID: 69354 RVA: 0x003EA094 File Offset: 0x003E8294
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700581D RID: 22557
			// (get) Token: 0x06010EEB RID: 69355 RVA: 0x003EA0D0 File Offset: 0x003E82D0
			public unsafe override uint ColumnCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010EEC RID: 69356 RVA: 0x003EA10C File Offset: 0x003E830C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283576, XrefRangeEnd = 283590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EED RID: 69357 RVA: 0x003EA15C File Offset: 0x003E835C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283590, XrefRangeEnd = 283620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<int> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06010EEE RID: 69358 RVA: 0x003EA1A8 File Offset: 0x003E83A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010EEF RID: 69359 RVA: 0x003EA1F8 File Offset: 0x003E83F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<int> GetFocusing(Recipe ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByTagFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_Int32_Recipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06010EF0 RID: 69360 RVA: 0x00093465 File Offset: 0x00091665
			public RecipeByTagFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005819 RID: 22553
			// (get) Token: 0x06010EF1 RID: 69361 RVA: 0x003EA254 File Offset: 0x003E8454
			// (set) Token: 0x06010EF2 RID: 69362 RVA: 0x0009346E File Offset: 0x0009166E
			public unsafe Rule _ContainsRule_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ContainsRule_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ContainsRule_k__BackingField)) = value;
				}
			}

			// Token: 0x1700581A RID: 22554
			// (get) Token: 0x06010EF3 RID: 69363 RVA: 0x003EA27C File Offset: 0x003E847C
			// (set) Token: 0x06010EF4 RID: 69364 RVA: 0x00093489 File Offset: 0x00091689
			public unsafe uint _ColumnCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ColumnCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByTagFactory.NativeFieldInfoPtr__ColumnCount_k__BackingField)) = value;
				}
			}

			// Token: 0x0400AB51 RID: 43857
			private static readonly IntPtr NativeFieldInfoPtr__ContainsRule_k__BackingField;

			// Token: 0x0400AB52 RID: 43858
			private static readonly IntPtr NativeFieldInfoPtr__ColumnCount_k__BackingField;

			// Token: 0x0400AB53 RID: 43859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_UInt32_UInt32_0;

			// Token: 0x0400AB54 RID: 43860
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_get_Rule_0;

			// Token: 0x0400AB55 RID: 43861
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

			// Token: 0x0400AB56 RID: 43862
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB57 RID: 43863
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_String_Rule_0;

			// Token: 0x0400AB58 RID: 43864
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0;

			// Token: 0x0400AB59 RID: 43865
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0;

			// Token: 0x0400AB5A RID: 43866
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_IEnumerable_1_Int32_Recipe_0;

			// Token: 0x020010D1 RID: 4305
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+RecipeByTagFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060123CE RID: 74702 RVA: 0x004284B8 File Offset: 0x004266B8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr);
					FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr, "<>9__10_0");
					FilterOptions.RecipeByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr, 100686664);
					FilterOptions.RecipeByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__10_0_Internal_IEnumerable_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr, 100686665);
				}

				// Token: 0x060123CF RID: 74703 RVA: 0x00428534 File Offset: 0x00426734
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByTagFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060123D0 RID: 74704 RVA: 0x00428570 File Offset: 0x00426770
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _GetSelectionsTyped_b__10_0(Recipe x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__10_0_Internal_IEnumerable_1_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x060123D1 RID: 74705 RVA: 0x0009E2BA File Offset: 0x0009C4BA
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F66 RID: 24422
				// (get) Token: 0x060123D2 RID: 74706 RVA: 0x004285C0 File Offset: 0x004267C0
				// (set) Token: 0x060123D3 RID: 74707 RVA: 0x0009E2C3 File Offset: 0x0009C4C3
				public unsafe static FilterOptions.RecipeByTagFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.RecipeByTagFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F67 RID: 24423
				// (get) Token: 0x060123D4 RID: 74708 RVA: 0x004285E8 File Offset: 0x004267E8
				// (set) Token: 0x060123D5 RID: 74709 RVA: 0x0009E2D5 File Offset: 0x0009C4D5
				public unsafe static Func<Recipe, IEnumerable<int>> __9__10_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.RecipeByTagFactory.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B8E8 RID: 47336
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B8E9 RID: 47337
				private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

				// Token: 0x0400B8EA RID: 47338
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B8EB RID: 47339
				private static readonly IntPtr NativeMethodInfoPtr__GetSelectionsTyped_b__10_0_Internal_IEnumerable_1_Int32_Recipe_0;
			}
		}

		// Token: 0x02000F20 RID: 3872
		public class RecipeByFoodPriceFactory : FilterOptions.RecipeByFoodFactory<int>
		{
			// Token: 0x06010EF5 RID: 69365 RVA: 0x003EA2A4 File Offset: 0x003E84A4
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByFoodPriceFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByFoodPriceFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr);
				FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr, 100686666);
				FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr, 100686667);
				FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr, 100686668);
			}

			// Token: 0x1700581E RID: 22558
			// (get) Token: 0x06010EF6 RID: 69366 RVA: 0x003EA30C File Offset: 0x003E850C
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010EF7 RID: 69367 RVA: 0x003EA350 File Offset: 0x003E8550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetValue(Sellable food)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010EF8 RID: 69368 RVA: 0x003EA3A8 File Offset: 0x003E85A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283620, XrefRangeEnd = 283623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByFoodPriceFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByFoodPriceFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByFoodPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EF9 RID: 69369 RVA: 0x000934A4 File Offset: 0x000916A4
			public RecipeByFoodPriceFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB5B RID: 43867
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB5C RID: 43868
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0;

			// Token: 0x0400AB5D RID: 43869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F21 RID: 3873
		public class RecipeByFoodLevelFactory : FilterOptions.RecipeByFoodFactory<int>
		{
			// Token: 0x06010EFA RID: 69370 RVA: 0x003EA3F0 File Offset: 0x003E85F0
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByFoodLevelFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByFoodLevelFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr);
				FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr, 100686669);
				FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr, 100686670);
				FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr, 100686671);
			}

			// Token: 0x1700581F RID: 22559
			// (get) Token: 0x06010EFB RID: 69371 RVA: 0x003EA458 File Offset: 0x003E8658
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010EFC RID: 69372 RVA: 0x003EA49C File Offset: 0x003E869C
			[CallerCount(0)]
			public unsafe override int GetValue(Sellable food)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010EFD RID: 69373 RVA: 0x003EA4F4 File Offset: 0x003E86F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283623, XrefRangeEnd = 283626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByFoodLevelFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByFoodLevelFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByFoodLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010EFE RID: 69374 RVA: 0x000934AD File Offset: 0x000916AD
			public RecipeByFoodLevelFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB5E RID: 43870
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB5F RID: 43871
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Protected_Virtual_Int32_Sellable_0;

			// Token: 0x0400AB60 RID: 43872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F22 RID: 3874
		public class RecipeByCookCountFactory : FilterOptions.TmiByValueOrderConfigFactory<int, Recipe>
		{
			// Token: 0x06010EFF RID: 69375 RVA: 0x003EA53C File Offset: 0x003E873C
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByCookCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByCookCountFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr);
				FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr, 100686672);
				FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr, 100686673);
				FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr, 100686674);
				FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr, 100686675);
			}

			// Token: 0x17005820 RID: 22560
			// (get) Token: 0x06010F00 RID: 69376 RVA: 0x003EA5B8 File Offset: 0x003E87B8
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F01 RID: 69377 RVA: 0x003EA5FC File Offset: 0x003E87FC
			[CallerCount(0)]
			public unsafe override int GetFocusing(Recipe ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010F02 RID: 69378 RVA: 0x003EA654 File Offset: 0x003E8854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283626, XrefRangeEnd = 283631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F03 RID: 69379 RVA: 0x003EA688 File Offset: 0x003E8888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283631, XrefRangeEnd = 283634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByCookCountFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByCookCountFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByCookCountFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F04 RID: 69380 RVA: 0x000934B6 File Offset: 0x000916B6
			public RecipeByCookCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB61 RID: 43873
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB62 RID: 43874
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0;

			// Token: 0x0400AB63 RID: 43875
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Final_Void_0;

			// Token: 0x0400AB64 RID: 43876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F23 RID: 3875
		public class RecipeByAcquireOrderFactory : FilterOptions.TmiByValueOrderConfigFactory<int, Recipe>
		{
			// Token: 0x06010F05 RID: 69381 RVA: 0x003EA6D0 File Offset: 0x003E88D0
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "RecipeByAcquireOrderFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr);
				FilterOptions.RecipeByAcquireOrderFactory.NativeFieldInfoPtr_m_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr, "m_Recipes");
				FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr, 100686676);
				FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr, 100686677);
				FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr, 100686678);
				FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr, 100686679);
			}

			// Token: 0x17005822 RID: 22562
			// (get) Token: 0x06010F06 RID: 69382 RVA: 0x003EA760 File Offset: 0x003E8960
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F07 RID: 69383 RVA: 0x003EA7A4 File Offset: 0x003E89A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283634, XrefRangeEnd = 283639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F08 RID: 69384 RVA: 0x003EA7E0 File Offset: 0x003E89E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283639, XrefRangeEnd = 283642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetFocusing(Recipe ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010F09 RID: 69385 RVA: 0x003EA838 File Offset: 0x003E8A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283642, XrefRangeEnd = 283645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.RecipeByAcquireOrderFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.RecipeByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F0A RID: 69386 RVA: 0x000934BF File Offset: 0x000916BF
			public RecipeByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005821 RID: 22561
			// (get) Token: 0x06010F0B RID: 69387 RVA: 0x003EA880 File Offset: 0x003E8A80
			// (set) Token: 0x06010F0C RID: 69388 RVA: 0x000934C8 File Offset: 0x000916C8
			public unsafe Il2CppReferenceArray<Recipe> m_Recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByAcquireOrderFactory.NativeFieldInfoPtr_m_Recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.RecipeByAcquireOrderFactory.NativeFieldInfoPtr_m_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB65 RID: 43877
			private static readonly IntPtr NativeFieldInfoPtr_m_Recipes;

			// Token: 0x0400AB66 RID: 43878
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB67 RID: 43879
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB68 RID: 43880
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Int32_Recipe_0;

			// Token: 0x0400AB69 RID: 43881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
		}

		// Token: 0x02000F24 RID: 3876
		public class SellableByTagFactory : FilterOptions.TradableByTagFactory<Sellable>
		{
			// Token: 0x06010F0D RID: 69389 RVA: 0x003EA8B0 File Offset: 0x003E8AB0
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByTagFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByTagFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr);
				FilterOptions.SellableByTagFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.SellableByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, 100686680);
				FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, 100686681);
				FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, 100686682);
				FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, 100686683);
			}

			// Token: 0x06010F0E RID: 69390 RVA: 0x003EA940 File Offset: 0x003E8B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283645, XrefRangeEnd = 283648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByTagFactory(Sellable.SellableType sellableType, bool contains, uint columnCount, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sellableType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contains;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByTagFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_Boolean_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005824 RID: 22564
			// (get) Token: 0x06010F0F RID: 69391 RVA: 0x003EA9B4 File Offset: 0x003E8BB4
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283648, XrefRangeEnd = 283654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F10 RID: 69392 RVA: 0x003EA9F8 File Offset: 0x003E8BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283654, XrefRangeEnd = 283707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<int> GetSelectionsTyped()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06010F11 RID: 69393 RVA: 0x003EAA44 File Offset: 0x003E8C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283707, XrefRangeEnd = 283708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetSelectionTextTyped(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByTagFactory.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010F12 RID: 69394 RVA: 0x000934E7 File Offset: 0x000916E7
			public SellableByTagFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005823 RID: 22563
			// (get) Token: 0x06010F13 RID: 69395 RVA: 0x003EAA94 File Offset: 0x003E8C94
			// (set) Token: 0x06010F14 RID: 69396 RVA: 0x000934F0 File Offset: 0x000916F0
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByTagFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByTagFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x0400AB6A RID: 43882
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB6B RID: 43883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SellableType_Boolean_UInt32_UInt32_0;

			// Token: 0x0400AB6C RID: 43884
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB6D RID: 43885
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_IEnumerable_1_Int32_0;

			// Token: 0x0400AB6E RID: 43886
			private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Virtual_String_Int32_0;

			// Token: 0x020010D2 RID: 4306
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+SellableByTagFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060123D6 RID: 74710 RVA: 0x00428610 File Offset: 0x00426810
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr);
					FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, "<>9__4_0");
					FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, "<>9__4_1");
					FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, 100686685);
					FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__4_0_Internal_IEnumerable_1_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, 100686686);
					FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__4_1_Internal_IEnumerable_1_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr, 100686687);
				}

				// Token: 0x060123D7 RID: 74711 RVA: 0x004286B4 File Offset: 0x004268B4
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByTagFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060123D8 RID: 74712 RVA: 0x004286F0 File Offset: 0x004268F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _GetSelectionsTyped_b__4_0(Sellable x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__4_0_Internal_IEnumerable_1_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x060123D9 RID: 74713 RVA: 0x00428740 File Offset: 0x00426940
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _GetSelectionsTyped_b__4_1(Sellable x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByTagFactory.__c.NativeMethodInfoPtr__GetSelectionsTyped_b__4_1_Internal_IEnumerable_1_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x060123DA RID: 74714 RVA: 0x0009E2E7 File Offset: 0x0009C4E7
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F68 RID: 24424
				// (get) Token: 0x060123DB RID: 74715 RVA: 0x00428790 File Offset: 0x00426990
				// (set) Token: 0x060123DC RID: 74716 RVA: 0x0009E2F0 File Offset: 0x0009C4F0
				public unsafe static FilterOptions.SellableByTagFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.SellableByTagFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F69 RID: 24425
				// (get) Token: 0x060123DD RID: 74717 RVA: 0x004287B8 File Offset: 0x004269B8
				// (set) Token: 0x060123DE RID: 74718 RVA: 0x0009E302 File Offset: 0x0009C502
				public unsafe static Func<Sellable, IEnumerable<int>> __9__4_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F6A RID: 24426
				// (get) Token: 0x060123DF RID: 74719 RVA: 0x004287E0 File Offset: 0x004269E0
				// (set) Token: 0x060123E0 RID: 74720 RVA: 0x0009E314 File Offset: 0x0009C514
				public unsafe static Func<Sellable, IEnumerable<int>> __9__4_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByTagFactory.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B8EC RID: 47340
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B8ED RID: 47341
				private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

				// Token: 0x0400B8EE RID: 47342
				private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

				// Token: 0x0400B8EF RID: 47343
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B8F0 RID: 47344
				private static readonly IntPtr NativeMethodInfoPtr__GetSelectionsTyped_b__4_0_Internal_IEnumerable_1_Int32_Sellable_0;

				// Token: 0x0400B8F1 RID: 47345
				private static readonly IntPtr NativeMethodInfoPtr__GetSelectionsTyped_b__4_1_Internal_IEnumerable_1_Int32_Sellable_0;
			}
		}

		// Token: 0x02000F25 RID: 3877
		public class SellableByPriceFactory : FilterOptions.TradableByPriceFactory<Sellable>
		{
			// Token: 0x06010F15 RID: 69397 RVA: 0x003EAABC File Offset: 0x003E8CBC
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByPriceFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByPriceFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr);
				FilterOptions.SellableByPriceFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.SellableByPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr, 100686688);
				FilterOptions.SellableByPriceFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr, 100686689);
			}

			// Token: 0x06010F16 RID: 69398 RVA: 0x003EAB24 File Offset: 0x003E8D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283708, XrefRangeEnd = 283711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByPriceFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByPriceFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sellableType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByPriceFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005826 RID: 22566
			// (get) Token: 0x06010F17 RID: 69399 RVA: 0x003EAB7C File Offset: 0x003E8D7C
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283711, XrefRangeEnd = 283717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByPriceFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F18 RID: 69400 RVA: 0x0009350B File Offset: 0x0009170B
			public SellableByPriceFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005825 RID: 22565
			// (get) Token: 0x06010F19 RID: 69401 RVA: 0x003EABC0 File Offset: 0x003E8DC0
			// (set) Token: 0x06010F1A RID: 69402 RVA: 0x00093514 File Offset: 0x00091714
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByPriceFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByPriceFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x0400AB6F RID: 43887
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB70 RID: 43888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0;

			// Token: 0x0400AB71 RID: 43889
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;
		}

		// Token: 0x02000F26 RID: 3878
		public class SellableByLevelFactory : FilterOptions.TradableByLevelFactory<Sellable>
		{
			// Token: 0x06010F1B RID: 69403 RVA: 0x003EABE8 File Offset: 0x003E8DE8
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByLevelFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByLevelFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr);
				FilterOptions.SellableByLevelFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.SellableByLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr, 100686690);
				FilterOptions.SellableByLevelFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr, 100686691);
			}

			// Token: 0x06010F1C RID: 69404 RVA: 0x003EAC50 File Offset: 0x003E8E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283717, XrefRangeEnd = 283720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByLevelFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByLevelFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sellableType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByLevelFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005828 RID: 22568
			// (get) Token: 0x06010F1D RID: 69405 RVA: 0x003EACA8 File Offset: 0x003E8EA8
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByLevelFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F1E RID: 69406 RVA: 0x0009352F File Offset: 0x0009172F
			public SellableByLevelFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005827 RID: 22567
			// (get) Token: 0x06010F1F RID: 69407 RVA: 0x003EACEC File Offset: 0x003E8EEC
			// (set) Token: 0x06010F20 RID: 69408 RVA: 0x00093538 File Offset: 0x00091738
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByLevelFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByLevelFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x0400AB72 RID: 43890
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB73 RID: 43891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0;

			// Token: 0x0400AB74 RID: 43892
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;
		}

		// Token: 0x02000F27 RID: 3879
		public class SellableByInDailyMenuFactory : FilterOptions.TmiByValueOrderConfigFactory<bool, Sellable>
		{
			// Token: 0x06010F21 RID: 69409 RVA: 0x003EAD14 File Offset: 0x003E8F14
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByInDailyMenuFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByInDailyMenuFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr);
				FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr, 100686692);
				FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr, 100686693);
				FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr, 100686694);
			}

			// Token: 0x06010F22 RID: 69410 RVA: 0x003EAD7C File Offset: 0x003E8F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283721, XrefRangeEnd = 283724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByInDailyMenuFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005829 RID: 22569
			// (get) Token: 0x06010F23 RID: 69411 RVA: 0x003EADC4 File Offset: 0x003E8FC4
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F24 RID: 69412 RVA: 0x003EAE08 File Offset: 0x003E9008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283724, XrefRangeEnd = 283761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool GetFocusing(Sellable ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ordering);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByInDailyMenuFactory.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Boolean_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010F25 RID: 69413 RVA: 0x00093553 File Offset: 0x00091753
			public SellableByInDailyMenuFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB75 RID: 43893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

			// Token: 0x0400AB76 RID: 43894
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_get_String_0;

			// Token: 0x0400AB77 RID: 43895
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Boolean_Sellable_0;

			// Token: 0x020010D3 RID: 4307
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+SellableByInDailyMenuFactory+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Object
			{
				// Token: 0x060123E1 RID: 74721 RVA: 0x00428808 File Offset: 0x00426A08
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr);
					FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr, "ordering");
					FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr, 100686695);
					FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetFocusing_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr, 100686696);
					FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetFocusing_b__1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr, 100686697);
				}

				// Token: 0x060123E2 RID: 74722 RVA: 0x00428884 File Offset: 0x00426A84
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060123E3 RID: 74723 RVA: 0x004288C0 File Offset: 0x00426AC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283720, XrefRangeEnd = 283721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _GetFocusing_b__0(Recipe x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetFocusing_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060123E4 RID: 74724 RVA: 0x00428910 File Offset: 0x00426B10
				[CallerCount(0)]
				public unsafe bool _GetFocusing_b__1(Sellable x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__GetFocusing_b__1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060123E5 RID: 74725 RVA: 0x0009E326 File Offset: 0x0009C526
				public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F6B RID: 24427
				// (get) Token: 0x060123E6 RID: 74726 RVA: 0x00428960 File Offset: 0x00426B60
				// (set) Token: 0x060123E7 RID: 74727 RVA: 0x0009E32F File Offset: 0x0009C52F
				public unsafe Sellable ordering
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_ordering);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByInDailyMenuFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_ordering), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B8F2 RID: 47346
				private static readonly IntPtr NativeFieldInfoPtr_ordering;

				// Token: 0x0400B8F3 RID: 47347
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B8F4 RID: 47348
				private static readonly IntPtr NativeMethodInfoPtr__GetFocusing_b__0_Internal_Boolean_Recipe_0;

				// Token: 0x0400B8F5 RID: 47349
				private static readonly IntPtr NativeMethodInfoPtr__GetFocusing_b__1_Internal_Boolean_Sellable_0;
			}
		}

		// Token: 0x02000F28 RID: 3880
		public class SellableByCountFactory : FilterOptions.TradableByCountFactory<Sellable>
		{
			// Token: 0x06010F26 RID: 69414 RVA: 0x003EAE60 File Offset: 0x003E9060
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByCountFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr);
				FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_CountCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, "m_CountCache");
				FilterOptions.SellableByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, 100686698);
				FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, 100686699);
				FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, 100686700);
				FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, 100686701);
			}

			// Token: 0x06010F27 RID: 69415 RVA: 0x003EAF04 File Offset: 0x003E9104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283763, XrefRangeEnd = 283766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByCountFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sellableType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByCountFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700582C RID: 22572
			// (get) Token: 0x06010F28 RID: 69416 RVA: 0x003EAF5C File Offset: 0x003E915C
			public unsafe override string GetObjectName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F29 RID: 69417 RVA: 0x003EAFA0 File Offset: 0x003E91A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283766, XrefRangeEnd = 283805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F2A RID: 69418 RVA: 0x003EAFDC File Offset: 0x003E91DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Dictionary<int, int> GetCountList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByCountFactory.NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x06010F2B RID: 69419 RVA: 0x0009355C File Offset: 0x0009175C
			public SellableByCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700582A RID: 22570
			// (get) Token: 0x06010F2C RID: 69420 RVA: 0x003EB028 File Offset: 0x003E9228
			// (set) Token: 0x06010F2D RID: 69421 RVA: 0x00093565 File Offset: 0x00091765
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x1700582B RID: 22571
			// (get) Token: 0x06010F2E RID: 69422 RVA: 0x003EB050 File Offset: 0x003E9250
			// (set) Token: 0x06010F2F RID: 69423 RVA: 0x00093580 File Offset: 0x00091780
			public unsafe Dictionary<int, int> m_CountCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_CountCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByCountFactory.NativeFieldInfoPtr_m_CountCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB78 RID: 43896
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB79 RID: 43897
			private static readonly IntPtr NativeFieldInfoPtr_m_CountCache;

			// Token: 0x0400AB7A RID: 43898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0;

			// Token: 0x0400AB7B RID: 43899
			private static readonly IntPtr NativeMethodInfoPtr_get_GetObjectName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB7C RID: 43900
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB7D RID: 43901
			private static readonly IntPtr NativeMethodInfoPtr_GetCountList_Protected_Virtual_Dictionary_2_Int32_Int32_0;

			// Token: 0x020010D4 RID: 4308
			[ObfuscatedName("Common.UI.Filter.Impl.FilterOptions+SellableByCountFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060123E8 RID: 74728 RVA: 0x00428990 File Offset: 0x00426B90
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr);
					FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, "<>9");
					FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, "<>9__5_0");
					FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, "<>9__5_1");
					FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, 100686703);
					FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__5_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, 100686704);
					FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__5_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr, 100686705);
				}

				// Token: 0x060123E9 RID: 74729 RVA: 0x00428A34 File Offset: 0x00426C34
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByCountFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060123EA RID: 74730 RVA: 0x00428A70 File Offset: 0x00426C70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283761, XrefRangeEnd = 283762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__5_0(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__5_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060123EB RID: 74731 RVA: 0x00428AC4 File Offset: 0x00426CC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283762, XrefRangeEnd = 283763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _OnWillFilter_b__5_1(KeyValuePair<int, int> y)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByCountFactory.__c.NativeMethodInfoPtr__OnWillFilter_b__5_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060123EC RID: 74732 RVA: 0x0009E34E File Offset: 0x0009C54E
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F6C RID: 24428
				// (get) Token: 0x060123ED RID: 74733 RVA: 0x00428B18 File Offset: 0x00426D18
				// (set) Token: 0x060123EE RID: 74734 RVA: 0x0009E357 File Offset: 0x0009C557
				public unsafe static FilterOptions.SellableByCountFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterOptions.SellableByCountFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F6D RID: 24429
				// (get) Token: 0x060123EF RID: 74735 RVA: 0x00428B40 File Offset: 0x00426D40
				// (set) Token: 0x060123F0 RID: 74736 RVA: 0x0009E369 File Offset: 0x0009C569
				public unsafe static Func<KeyValuePair<int, int>, int> __9__5_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F6E RID: 24430
				// (get) Token: 0x060123F1 RID: 74737 RVA: 0x00428B68 File Offset: 0x00426D68
				// (set) Token: 0x060123F2 RID: 74738 RVA: 0x0009E37B File Offset: 0x0009C57B
				public unsafe static Func<KeyValuePair<int, int>, int> __9__5_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FilterOptions.SellableByCountFactory.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B8F6 RID: 47350
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B8F7 RID: 47351
				private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

				// Token: 0x0400B8F8 RID: 47352
				private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

				// Token: 0x0400B8F9 RID: 47353
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B8FA RID: 47354
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__5_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B8FB RID: 47355
				private static readonly IntPtr NativeMethodInfoPtr__OnWillFilter_b__5_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0;
			}
		}

		// Token: 0x02000F29 RID: 3881
		public class SellableByAcquireOrderFactory : FilterOptions.TradableByAcquireOrderFactory<Sellable>
		{
			// Token: 0x06010F30 RID: 69424 RVA: 0x003EB080 File Offset: 0x003E9280
			// Note: this type is marked as 'beforefieldinit'.
			static SellableByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "SellableByAcquireOrderFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr);
				FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, "m_SellableType");
				FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, "m_AcquireOrderCache");
				FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, 100686706);
				FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, 100686707);
				FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, 100686708);
				FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr, 100686709);
			}

			// Token: 0x06010F31 RID: 69425 RVA: 0x003EB124 File Offset: 0x003E9324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283805, XrefRangeEnd = 283808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableByAcquireOrderFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.SellableByAcquireOrderFactory>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sellableType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700582F RID: 22575
			// (get) Token: 0x06010F32 RID: 69426 RVA: 0x003EB17C File Offset: 0x003E937C
			public unsafe override string GetTradableName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F33 RID: 69427 RVA: 0x003EB1C0 File Offset: 0x003E93C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283808, XrefRangeEnd = 283822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnWillFilter()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F34 RID: 69428 RVA: 0x003EB1FC File Offset: 0x003E93FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override List<int> GetAcquireOrderList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.SellableByAcquireOrderFactory.NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}

			// Token: 0x06010F35 RID: 69429 RVA: 0x0009359F File Offset: 0x0009179F
			public SellableByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700582D RID: 22573
			// (get) Token: 0x06010F36 RID: 69430 RVA: 0x003EB248 File Offset: 0x003E9448
			// (set) Token: 0x06010F37 RID: 69431 RVA: 0x000935A8 File Offset: 0x000917A8
			public unsafe Sellable.SellableType m_SellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_SellableType)) = value;
				}
			}

			// Token: 0x1700582E RID: 22574
			// (get) Token: 0x06010F38 RID: 69432 RVA: 0x003EB270 File Offset: 0x003E9470
			// (set) Token: 0x06010F39 RID: 69433 RVA: 0x000935C3 File Offset: 0x000917C3
			public unsafe List<int> m_AcquireOrderCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.SellableByAcquireOrderFactory.NativeFieldInfoPtr_m_AcquireOrderCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB7E RID: 43902
			private static readonly IntPtr NativeFieldInfoPtr_m_SellableType;

			// Token: 0x0400AB7F RID: 43903
			private static readonly IntPtr NativeFieldInfoPtr_m_AcquireOrderCache;

			// Token: 0x0400AB80 RID: 43904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SellableType_UInt32_0;

			// Token: 0x0400AB81 RID: 43905
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Virtual_get_String_0;

			// Token: 0x0400AB82 RID: 43906
			private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_Void_0;

			// Token: 0x0400AB83 RID: 43907
			private static readonly IntPtr NativeMethodInfoPtr_GetAcquireOrderList_Protected_Virtual_List_1_Int32_0;
		}

		// Token: 0x02000F2A RID: 3882
		public class TradableByTagFactory<TTradableObjectBase> : ByValueContainsConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06010F3A RID: 69434 RVA: 0x003EB2A0 File Offset: 0x003E94A0
			// Note: this type is marked as 'beforefieldinit'.
			static TradableByTagFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TradableByTagFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ColumnCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, "<ColumnCount>k__BackingField");
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ContainsRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, "<ContainsRule>k__BackingField");
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686710);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686711);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686712);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686713);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_Final_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686714);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_Final_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686715);
				FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_IEnumerable_1_Int32_TTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr, 100686716);
			}

			// Token: 0x06010F3B RID: 69435 RVA: 0x003EB3BC File Offset: 0x003E95BC
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 283822, RefRangeEnd = 283834, XrefRangeStart = 283822, XrefRangeEnd = 283822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TradableByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TradableByTagFactory<TTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref contains;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnCount;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005832 RID: 22578
			// (get) Token: 0x06010F3C RID: 69436 RVA: 0x003EB420 File Offset: 0x003E9620
			public unsafe override FilterType FilterType
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005833 RID: 22579
			// (get) Token: 0x06010F3D RID: 69437 RVA: 0x003EB45C File Offset: 0x003E965C
			public unsafe override uint ColumnCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005834 RID: 22580
			// (get) Token: 0x06010F3E RID: 69438 RVA: 0x003EB498 File Offset: 0x003E9698
			public unsafe virtual string GetTradableName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17005835 RID: 22581
			// (get) Token: 0x06010F3F RID: 69439 RVA: 0x003EB4DC File Offset: 0x003E96DC
			public unsafe override Rule ContainsRule
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_Final_get_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010F40 RID: 69440 RVA: 0x003EB518 File Offset: 0x003E9718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283834, XrefRangeEnd = 283835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string GetByTypeText(Rule rule)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_Final_String_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010F41 RID: 69441 RVA: 0x003EB55C File Offset: 0x003E975C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<int> GetFocusing(TTradableObjectBase ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTradableObjectBase).IsValueType)
				{
					TTradableObjectBase ttradableObjectBase = ordering;
					intPtr = ((ttradableObjectBase is string) ? IL2CPP.ManagedStringToIl2Cpp(ttradableObjectBase as string) : IL2CPP.Il2CppObjectBaseToPtr(ttradableObjectBase as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_IEnumerable_1_Int32_TTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr4) : null;
			}

			// Token: 0x06010F42 RID: 69442 RVA: 0x000935E2 File Offset: 0x000917E2
			public TradableByTagFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005830 RID: 22576
			// (get) Token: 0x06010F43 RID: 69443 RVA: 0x003EB5E4 File Offset: 0x003E97E4
			// (set) Token: 0x06010F44 RID: 69444 RVA: 0x000935EB File Offset: 0x000917EB
			public unsafe uint _ColumnCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ColumnCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ColumnCount_k__BackingField)) = value;
				}
			}

			// Token: 0x17005831 RID: 22577
			// (get) Token: 0x06010F45 RID: 69445 RVA: 0x003EB60C File Offset: 0x003E980C
			// (set) Token: 0x06010F46 RID: 69446 RVA: 0x00093606 File Offset: 0x00091806
			public unsafe Rule _ContainsRule_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ContainsRule_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterOptions.TradableByTagFactory<TTradableObjectBase>.NativeFieldInfoPtr__ContainsRule_k__BackingField)) = value;
				}
			}

			// Token: 0x0400AB84 RID: 43908
			private static readonly IntPtr NativeFieldInfoPtr__ColumnCount_k__BackingField;

			// Token: 0x0400AB85 RID: 43909
			private static readonly IntPtr NativeFieldInfoPtr__ContainsRule_k__BackingField;

			// Token: 0x0400AB86 RID: 43910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_UInt32_UInt32_0;

			// Token: 0x0400AB87 RID: 43911
			private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

			// Token: 0x0400AB88 RID: 43912
			private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

			// Token: 0x0400AB89 RID: 43913
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400AB8A RID: 43914
			private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Virtual_Final_get_Rule_0;

			// Token: 0x0400AB8B RID: 43915
			private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Virtual_Final_String_Rule_0;

			// Token: 0x0400AB8C RID: 43916
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_IEnumerable_1_Int32_TTradableObjectBase_0;
		}

		// Token: 0x02000F2B RID: 3883
		public class TradableByPriceFactory<TTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06010F47 RID: 69447 RVA: 0x003EB634 File Offset: 0x003E9834
			// Note: this type is marked as 'beforefieldinit'.
			static TradableByPriceFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TradableByPriceFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr);
				FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr, 100686717);
				FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr, 100686718);
				FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr, 100686719);
				FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr, 100686720);
			}

			// Token: 0x17005836 RID: 22582
			// (get) Token: 0x06010F48 RID: 69448 RVA: 0x003EB6EC File Offset: 0x003E98EC
			public unsafe virtual string GetTradableName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17005837 RID: 22583
			// (get) Token: 0x06010F49 RID: 69449 RVA: 0x003EB730 File Offset: 0x003E9930
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283835, XrefRangeEnd = 283836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F4A RID: 69450 RVA: 0x003EB768 File Offset: 0x003E9968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetFocusing(TTradableObjectBase ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTradableObjectBase).IsValueType)
				{
					TTradableObjectBase ttradableObjectBase = ordering;
					intPtr = ((ttradableObjectBase is string) ? IL2CPP.ManagedStringToIl2Cpp(ttradableObjectBase as string) : IL2CPP.Il2CppObjectBaseToPtr(ttradableObjectBase as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010F4B RID: 69451 RVA: 0x003EB7EC File Offset: 0x003E99EC
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TradableByPriceFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TradableByPriceFactory<TTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByPriceFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F4C RID: 69452 RVA: 0x00093621 File Offset: 0x00091821
			public TradableByPriceFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB8D RID: 43917
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400AB8E RID: 43918
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0;

			// Token: 0x0400AB8F RID: 43919
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0;

			// Token: 0x0400AB90 RID: 43920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F2C RID: 3884
		public class TradableByLevelFactory<TTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06010F4D RID: 69453 RVA: 0x003EB834 File Offset: 0x003E9A34
			// Note: this type is marked as 'beforefieldinit'.
			static TradableByLevelFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TradableByLevelFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr);
				FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr, 100686721);
				FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr, 100686722);
				FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr, 100686723);
				FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr, 100686724);
			}

			// Token: 0x17005838 RID: 22584
			// (get) Token: 0x06010F4E RID: 69454 RVA: 0x003EB8EC File Offset: 0x003E9AEC
			public unsafe virtual string GetTradableName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17005839 RID: 22585
			// (get) Token: 0x06010F4F RID: 69455 RVA: 0x003EB930 File Offset: 0x003E9B30
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283836, XrefRangeEnd = 283837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F50 RID: 69456 RVA: 0x003EB968 File Offset: 0x003E9B68
			[CallerCount(0)]
			public unsafe override int GetFocusing(TTradableObjectBase ordering)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TTradableObjectBase).IsValueType)
				{
					TTradableObjectBase ttradableObjectBase = ordering;
					intPtr = ((ttradableObjectBase is string) ? IL2CPP.ManagedStringToIl2Cpp(ttradableObjectBase as string) : IL2CPP.Il2CppObjectBaseToPtr(ttradableObjectBase as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref ordering;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010F51 RID: 69457 RVA: 0x003EB9EC File Offset: 0x003E9BEC
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TradableByLevelFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TradableByLevelFactory<TTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByLevelFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F52 RID: 69458 RVA: 0x0009362A File Offset: 0x0009182A
			public TradableByLevelFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB91 RID: 43921
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400AB92 RID: 43922
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0;

			// Token: 0x0400AB93 RID: 43923
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Virtual_Final_Int32_TTradableObjectBase_0;

			// Token: 0x0400AB94 RID: 43924
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F2D RID: 3885
		public class TradableByCountFactory<TTradableObjectBase> : FilterOptions.NonTradableByCountFactory<TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06010F53 RID: 69459 RVA: 0x003EBA34 File Offset: 0x003E9C34
			// Note: this type is marked as 'beforefieldinit'.
			static TradableByCountFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TradableByCountFactory<TTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TradableByCountFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TradableByCountFactory<TTradableObjectBase>>.NativeClassPtr);
				FilterOptions.TradableByCountFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByCountFactory<TTradableObjectBase>>.NativeClassPtr, 100686725);
			}

			// Token: 0x06010F54 RID: 69460 RVA: 0x003EBAB0 File Offset: 0x003E9CB0
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 283500, RefRangeEnd = 283542, XrefRangeStart = 283500, XrefRangeEnd = 283542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TradableByCountFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TradableByCountFactory<TTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByCountFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F55 RID: 69461 RVA: 0x00093633 File Offset: 0x00091833
			public TradableByCountFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB95 RID: 43925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}

		// Token: 0x02000F2E RID: 3886
		public class TradableByAcquireOrderFactory<TTradableObjectBase> : FilterOptions.NonTradableByAcquireOrderFactory<TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06010F56 RID: 69462 RVA: 0x003EBAF8 File Offset: 0x003E9CF8
			// Note: this type is marked as 'beforefieldinit'.
			static TradableByAcquireOrderFactory()
			{
				Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterOptions>.NativeClassPtr, "TradableByAcquireOrderFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTradableObjectBase>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr);
				FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr, 100686726);
				FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr, 100686727);
				FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr, 100686728);
			}

			// Token: 0x1700583A RID: 22586
			// (get) Token: 0x06010F57 RID: 69463 RVA: 0x003EBB9C File Offset: 0x003E9D9C
			public unsafe virtual string GetTradableName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700583B RID: 22587
			// (get) Token: 0x06010F58 RID: 69464 RVA: 0x003EBBE0 File Offset: 0x003E9DE0
			public unsafe override string FactoryName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283837, XrefRangeEnd = 283838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06010F59 RID: 69465 RVA: 0x003EBC18 File Offset: 0x003E9E18
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 281971, RefRangeEnd = 281982, XrefRangeStart = 281971, XrefRangeEnd = 281982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TradableByAcquireOrderFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionPriorityWeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOptions.TradableByAcquireOrderFactory<TTradableObjectBase>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F5A RID: 69466 RVA: 0x0009363C File Offset: 0x0009183C
			public TradableByAcquireOrderFactory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AB96 RID: 43926
			private static readonly IntPtr NativeMethodInfoPtr_get_GetTradableName_Protected_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400AB97 RID: 43927
			private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0;

			// Token: 0x0400AB98 RID: 43928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
		}
	}
}
