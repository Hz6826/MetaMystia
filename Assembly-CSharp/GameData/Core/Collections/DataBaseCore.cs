using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x0200023A RID: 570
	public static class DataBaseCore : Il2CppSystem.Object
	{
		// Token: 0x060046BA RID: 18106 RVA: 0x001930C0 File Offset: 0x001912C0
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseCore()
		{
			Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "DataBaseCore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr);
			DataBaseCore.NativeFieldInfoPtr__DLCMarker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<DLCMarker>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Ingredients_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Ingredients>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Beverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Beverages>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Foods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Foods>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Recipes>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Cookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Cookers>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Izakayas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Izakayas>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Items>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Badges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Badges>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Clothes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Clothes>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Decorations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Decorations>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__RecordId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<RecordId>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__Trophies_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<Trophies>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__TagRules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<TagRules>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__CharacterLevelProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<CharacterLevelProfile>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__CollabPackages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<CollabPackages>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__IngredientsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<IngredientsMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__BeveragesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<BeveragesMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__FoodsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<FoodsMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__RecipesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<RecipesMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__CookersMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<CookersMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__IzakayasMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<IzakayasMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__ItemsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<ItemsMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__BadgesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<BadgesMapping>k__BackingField");
			DataBaseCore.NativeFieldInfoPtr__TrophyMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<TrophyMapping>k__BackingField");
			DataBaseCore.NativeMethodInfoPtr_get_DLCMarker_Private_Static_get_Dictionary_2_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677330);
			DataBaseCore.NativeMethodInfoPtr_set_DLCMarker_Private_Static_set_Void_Dictionary_2_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677331);
			DataBaseCore.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677332);
			DataBaseCore.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677333);
			DataBaseCore.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677334);
			DataBaseCore.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677335);
			DataBaseCore.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677336);
			DataBaseCore.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677337);
			DataBaseCore.NativeMethodInfoPtr_get_Recipes_Private_Static_get_Dictionary_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677338);
			DataBaseCore.NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_Dictionary_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677339);
			DataBaseCore.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677340);
			DataBaseCore.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677341);
			DataBaseCore.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677342);
			DataBaseCore.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677343);
			DataBaseCore.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677344);
			DataBaseCore.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677345);
			DataBaseCore.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677346);
			DataBaseCore.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677347);
			DataBaseCore.NativeMethodInfoPtr_get_Clothes_Private_Static_get_Dictionary_2_Int32_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677348);
			DataBaseCore.NativeMethodInfoPtr_set_Clothes_Private_Static_set_Void_Dictionary_2_Int32_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677349);
			DataBaseCore.NativeMethodInfoPtr_get_Decorations_Private_Static_get_Dictionary_2_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677350);
			DataBaseCore.NativeMethodInfoPtr_set_Decorations_Private_Static_set_Void_Dictionary_2_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677351);
			DataBaseCore.NativeMethodInfoPtr_get_RecordId_Private_Static_get_Dictionary_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677352);
			DataBaseCore.NativeMethodInfoPtr_set_RecordId_Private_Static_set_Void_Dictionary_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677353);
			DataBaseCore.NativeMethodInfoPtr_get_Trophies_Private_Static_get_Dictionary_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677354);
			DataBaseCore.NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_Dictionary_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677355);
			DataBaseCore.NativeMethodInfoPtr_get_TagRules_Private_Static_get_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677356);
			DataBaseCore.NativeMethodInfoPtr_set_TagRules_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677357);
			DataBaseCore.NativeMethodInfoPtr_get_CharacterLevelProfile_Private_Static_get_Dictionary_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677358);
			DataBaseCore.NativeMethodInfoPtr_set_CharacterLevelProfile_Private_Static_set_Void_Dictionary_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677359);
			DataBaseCore.NativeMethodInfoPtr_get_CollabPackages_Private_Static_get_Dictionary_2_String_CollabPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677360);
			DataBaseCore.NativeMethodInfoPtr_set_CollabPackages_Private_Static_set_Void_Dictionary_2_String_CollabPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677361);
			DataBaseCore.NativeMethodInfoPtr_get_IngredientsMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677362);
			DataBaseCore.NativeMethodInfoPtr_set_IngredientsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677363);
			DataBaseCore.NativeMethodInfoPtr_get_BeveragesMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677364);
			DataBaseCore.NativeMethodInfoPtr_set_BeveragesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677365);
			DataBaseCore.NativeMethodInfoPtr_get_FoodsMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677366);
			DataBaseCore.NativeMethodInfoPtr_set_FoodsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677367);
			DataBaseCore.NativeMethodInfoPtr_get_RecipesMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677368);
			DataBaseCore.NativeMethodInfoPtr_set_RecipesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677369);
			DataBaseCore.NativeMethodInfoPtr_get_CookersMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677370);
			DataBaseCore.NativeMethodInfoPtr_set_CookersMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677371);
			DataBaseCore.NativeMethodInfoPtr_get_IzakayasMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677372);
			DataBaseCore.NativeMethodInfoPtr_set_IzakayasMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677373);
			DataBaseCore.NativeMethodInfoPtr_get_ItemsMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677374);
			DataBaseCore.NativeMethodInfoPtr_set_ItemsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677375);
			DataBaseCore.NativeMethodInfoPtr_get_BadgesMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677376);
			DataBaseCore.NativeMethodInfoPtr_set_BadgesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677377);
			DataBaseCore.NativeMethodInfoPtr_get_TrophyMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677378);
			DataBaseCore.NativeMethodInfoPtr_set_TrophyMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677379);
			DataBaseCore.NativeMethodInfoPtr_GetIngredientsDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677380);
			DataBaseCore.NativeMethodInfoPtr_GetBeveragesDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677381);
			DataBaseCore.NativeMethodInfoPtr_GetFoodsDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677382);
			DataBaseCore.NativeMethodInfoPtr_GetRecipesDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677383);
			DataBaseCore.NativeMethodInfoPtr_GetCookersDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677384);
			DataBaseCore.NativeMethodInfoPtr_GetIzakayasDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677385);
			DataBaseCore.NativeMethodInfoPtr_GetItemsDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677386);
			DataBaseCore.NativeMethodInfoPtr_GetBadgesDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677387);
			DataBaseCore.NativeMethodInfoPtr_GetTrophyDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677388);
			DataBaseCore.NativeMethodInfoPtr_InitializeDLCMarker_Public_Static_Void_Dictionary_2_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677389);
			DataBaseCore.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseCoreData_Dictionary_2_Int32_LevelProperties_Dictionary_2_String_CollabPackage_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677390);
			DataBaseCore.NativeMethodInfoPtr_GetAllIngredients_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677391);
			DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveIngredients_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677392);
			DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveAndNotIgnoredIngredients_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677393);
			DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveAndNotMissionIngredients_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677394);
			DataBaseCore.NativeMethodInfoPtr_GetAllFoods_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677395);
			DataBaseCore.NativeMethodInfoPtr_GetAllBeverages_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677396);
			DataBaseCore.NativeMethodInfoPtr_GetAllRecipes_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677397);
			DataBaseCore.NativeMethodInfoPtr_GetAllRecipeValues_Public_Static_IEnumerable_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677398);
			DataBaseCore.NativeMethodInfoPtr_GetAllRecipesExceptDLCs_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677399);
			DataBaseCore.NativeMethodInfoPtr_GetAllCookers_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677400);
			DataBaseCore.NativeMethodInfoPtr_GetAllItems_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677401);
			DataBaseCore.NativeMethodInfoPtr_GetAllItemsExceptDefaultClothes_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677402);
			DataBaseCore.NativeMethodInfoPtr_GetAllBadges_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677403);
			DataBaseCore.NativeMethodInfoPtr_GetAllIzakayas_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677404);
			DataBaseCore.NativeMethodInfoPtr_GetAllClothes_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677405);
			DataBaseCore.NativeMethodInfoPtr_GetAllDecorations_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677406);
			DataBaseCore.NativeMethodInfoPtr_GetAllRecords_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677407);
			DataBaseCore.NativeMethodInfoPtr_GetAllTrophies_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677408);
			DataBaseCore.NativeMethodInfoPtr_GetAllDLCMarker_Public_Static_IEnumerable_1_KeyValuePair_2_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677409);
			DataBaseCore.NativeMethodInfoPtr_RefDLCMarker_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677410);
			DataBaseCore.NativeMethodInfoPtr_GetIzakayasMusicPackageRecordCount_Public_Static_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677411);
			DataBaseCore.NativeMethodInfoPtr_AsNewIngredient_Public_Static_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677412);
			DataBaseCore.NativeMethodInfoPtr_AsNewFood_Public_Static_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677413);
			DataBaseCore.NativeMethodInfoPtr_AsNewBeverage_Public_Static_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677414);
			DataBaseCore.NativeMethodInfoPtr_RefIngredient_Public_Static_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677415);
			DataBaseCore.NativeMethodInfoPtr_RefFood_Public_Static_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677416);
			DataBaseCore.NativeMethodInfoPtr_RefBeverage_Public_Static_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677417);
			DataBaseCore.NativeMethodInfoPtr_RefRecipe_Public_Static_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677418);
			DataBaseCore.NativeMethodInfoPtr_MatchRecipe_Public_Static_IEnumerable_1_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677419);
			DataBaseCore.NativeMethodInfoPtr_MatchFirstRecipe_Public_Static_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677420);
			DataBaseCore.NativeMethodInfoPtr_RefCooker_Public_Static_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677421);
			DataBaseCore.NativeMethodInfoPtr_RefIzakaya_Public_Static_Izakaya_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677422);
			DataBaseCore.NativeMethodInfoPtr_RefItem_Public_Static_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677423);
			DataBaseCore.NativeMethodInfoPtr_RefBadge_Public_Static_Badge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677424);
			DataBaseCore.NativeMethodInfoPtr_RefCollab_Public_Static_CollabPackage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677425);
			DataBaseCore.NativeMethodInfoPtr_GetAllCollabs_Public_Static_IEnumerable_1_CollabPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677426);
			DataBaseCore.NativeMethodInfoPtr_RefClothes_Public_Static_Clothes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677427);
			DataBaseCore.NativeMethodInfoPtr_RefDecorations_Public_Static_Decoration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677428);
			DataBaseCore.NativeMethodInfoPtr_RefRecords_Public_Static_Record_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677429);
			DataBaseCore.NativeMethodInfoPtr_RefTrophies_Public_Static_Trophy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677430);
			DataBaseCore.NativeMethodInfoPtr_IsClothes_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677431);
			DataBaseCore.NativeMethodInfoPtr_IsDecoration_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677432);
			DataBaseCore.NativeMethodInfoPtr_IsRecord_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677433);
			DataBaseCore.NativeMethodInfoPtr_IsTrophy_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677434);
			DataBaseCore.NativeMethodInfoPtr_TryMatchRecipe_Public_Static_Boolean_Sellable_byref_IEnumerable_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677435);
			DataBaseCore.NativeMethodInfoPtr_GetIngredients_Public_Static_IEnumerable_1_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677436);
			DataBaseCore.NativeMethodInfoPtr_GetFoods_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677437);
			DataBaseCore.NativeMethodInfoPtr_GetBevs_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677438);
			DataBaseCore.NativeMethodInfoPtr_FindUnObtainedRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_Il2CppReferenceArray_1_Recipe_IEnumerable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677439);
			DataBaseCore.NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Dictionary_2_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677440);
			DataBaseCore.NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677441);
			DataBaseCore.NativeMethodInfoPtr_GetLevelProfile_Public_Static_LevelProperties_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677442);
			DataBaseCore.NativeMethodInfoPtr_CheckHasNextLevel_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677443);
			DataBaseCore.NativeMethodInfoPtr_IngredientsExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677444);
			DataBaseCore.NativeMethodInfoPtr_BeveragesExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677445);
			DataBaseCore.NativeMethodInfoPtr_FoodsExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677446);
			DataBaseCore.NativeMethodInfoPtr_RecipesExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677447);
			DataBaseCore.NativeMethodInfoPtr_CookersExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677448);
			DataBaseCore.NativeMethodInfoPtr_IzakayasExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677449);
			DataBaseCore.NativeMethodInfoPtr_ItemsExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677450);
			DataBaseCore.NativeMethodInfoPtr_BadgesExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677451);
			DataBaseCore.NativeMethodInfoPtr_ClothesExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677452);
			DataBaseCore.NativeMethodInfoPtr_DecorationsExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677453);
			DataBaseCore.NativeMethodInfoPtr_RecordIdExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677454);
			DataBaseCore.NativeMethodInfoPtr_TrophyIdExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677455);
			DataBaseCore.NativeMethodInfoPtr_TagRulesExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, 100677456);
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x00193CD0 File Offset: 0x00191ED0
		// (set) Token: 0x060046BC RID: 18108 RVA: 0x00193D04 File Offset: 0x00191F04
		public unsafe static Dictionary<string, GameObject> DLCMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186783, XrefRangeEnd = 186785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_DLCMarker_Private_Static_get_Dictionary_2_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186785, XrefRangeEnd = 186789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_DLCMarker_Private_Static_set_Void_Dictionary_2_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x00193D3C File Offset: 0x00191F3C
		// (set) Token: 0x060046BE RID: 18110 RVA: 0x00193D70 File Offset: 0x00191F70
		public unsafe static Dictionary<int, Ingredient> Ingredients
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186789, XrefRangeEnd = 186791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Ingredient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186791, XrefRangeEnd = 186795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Ingredient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x00193DA8 File Offset: 0x00191FA8
		// (set) Token: 0x060046C0 RID: 18112 RVA: 0x00193DDC File Offset: 0x00191FDC
		public unsafe static Dictionary<int, Sellable> Beverages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186795, XrefRangeEnd = 186797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186797, XrefRangeEnd = 186801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x00193E14 File Offset: 0x00192014
		// (set) Token: 0x060046C2 RID: 18114 RVA: 0x00193E48 File Offset: 0x00192048
		public unsafe static Dictionary<int, Sellable> Foods
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186801, XrefRangeEnd = 186803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186803, XrefRangeEnd = 186807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00193E80 File Offset: 0x00192080
		// (set) Token: 0x060046C4 RID: 18116 RVA: 0x00193EB4 File Offset: 0x001920B4
		public unsafe static Dictionary<int, Recipe> Recipes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186807, XrefRangeEnd = 186809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Recipes_Private_Static_get_Dictionary_2_Int32_Recipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186809, XrefRangeEnd = 186813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_Dictionary_2_Int32_Recipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x060046C5 RID: 18117 RVA: 0x00193EEC File Offset: 0x001920EC
		// (set) Token: 0x060046C6 RID: 18118 RVA: 0x00193F20 File Offset: 0x00192120
		public unsafe static Dictionary<int, Cooker> Cookers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186813, XrefRangeEnd = 186815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Cooker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186815, XrefRangeEnd = 186819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Cooker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x00193F58 File Offset: 0x00192158
		// (set) Token: 0x060046C8 RID: 18120 RVA: 0x00193F8C File Offset: 0x0019218C
		public unsafe static Dictionary<int, Izakaya> Izakayas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186819, XrefRangeEnd = 186821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_Izakaya_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186821, XrefRangeEnd = 186825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_Izakaya_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x00193FC4 File Offset: 0x001921C4
		// (set) Token: 0x060046CA RID: 18122 RVA: 0x00193FF8 File Offset: 0x001921F8
		public unsafe static Dictionary<int, Item> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186825, XrefRangeEnd = 186827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Item_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186827, XrefRangeEnd = 186831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Item_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x00194030 File Offset: 0x00192230
		// (set) Token: 0x060046CC RID: 18124 RVA: 0x00194064 File Offset: 0x00192264
		public unsafe static Dictionary<int, Badge> Badges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186831, XrefRangeEnd = 186833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Badge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186833, XrefRangeEnd = 186837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Badge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x0019409C File Offset: 0x0019229C
		// (set) Token: 0x060046CE RID: 18126 RVA: 0x001940D0 File Offset: 0x001922D0
		public unsafe static Dictionary<int, ClothesProfile.Clothes> Clothes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186837, XrefRangeEnd = 186839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Clothes_Private_Static_get_Dictionary_2_Int32_Clothes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ClothesProfile.Clothes>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186839, XrefRangeEnd = 186843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Clothes_Private_Static_set_Void_Dictionary_2_Int32_Clothes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x00194108 File Offset: 0x00192308
		// (set) Token: 0x060046D0 RID: 18128 RVA: 0x0019413C File Offset: 0x0019233C
		public unsafe static Dictionary<int, Decoration> Decorations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186843, XrefRangeEnd = 186845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Decorations_Private_Static_get_Dictionary_2_Int32_Decoration_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Decoration>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186845, XrefRangeEnd = 186849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Decorations_Private_Static_set_Void_Dictionary_2_Int32_Decoration_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x00194174 File Offset: 0x00192374
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x001941A8 File Offset: 0x001923A8
		public unsafe static Dictionary<int, Record> RecordId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186849, XrefRangeEnd = 186851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_RecordId_Private_Static_get_Dictionary_2_Int32_Record_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Record>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186851, XrefRangeEnd = 186855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_RecordId_Private_Static_set_Void_Dictionary_2_Int32_Record_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x001941E0 File Offset: 0x001923E0
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00194214 File Offset: 0x00192414
		public unsafe static Dictionary<int, TrophiesProfile.Trophy> Trophies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186855, XrefRangeEnd = 186857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_Trophies_Private_Static_get_Dictionary_2_Int32_Trophy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186857, XrefRangeEnd = 186861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_Dictionary_2_Int32_Trophy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0019424C File Offset: 0x0019244C
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x00194280 File Offset: 0x00192480
		public unsafe static Dictionary<int, Il2CppStructArray<int>> TagRules
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186861, XrefRangeEnd = 186863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_TagRules_Private_Static_get_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<int>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186863, XrefRangeEnd = 186867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_TagRules_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x001942B8 File Offset: 0x001924B8
		// (set) Token: 0x060046D8 RID: 18136 RVA: 0x001942EC File Offset: 0x001924EC
		public unsafe static Dictionary<int, DataBaseCore.LevelProperties> CharacterLevelProfile
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186867, XrefRangeEnd = 186869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_CharacterLevelProfile_Private_Static_get_Dictionary_2_Int32_LevelProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DataBaseCore.LevelProperties>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186869, XrefRangeEnd = 186873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_CharacterLevelProfile_Private_Static_set_Void_Dictionary_2_Int32_LevelProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x00194324 File Offset: 0x00192524
		// (set) Token: 0x060046DA RID: 18138 RVA: 0x00194358 File Offset: 0x00192558
		public unsafe static Dictionary<string, CollabPackage> CollabPackages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186873, XrefRangeEnd = 186875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_CollabPackages_Private_Static_get_Dictionary_2_String_CollabPackage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CollabPackage>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186875, XrefRangeEnd = 186879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_CollabPackages_Private_Static_set_Void_Dictionary_2_String_CollabPackage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x00194390 File Offset: 0x00192590
		// (set) Token: 0x060046DC RID: 18140 RVA: 0x001943C4 File Offset: 0x001925C4
		public unsafe static Dictionary<int, string> IngredientsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186879, XrefRangeEnd = 186881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_IngredientsMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186881, XrefRangeEnd = 186885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_IngredientsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x001943FC File Offset: 0x001925FC
		// (set) Token: 0x060046DE RID: 18142 RVA: 0x00194430 File Offset: 0x00192630
		public unsafe static Dictionary<int, string> BeveragesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186885, XrefRangeEnd = 186887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_BeveragesMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186887, XrefRangeEnd = 186891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_BeveragesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x060046DF RID: 18143 RVA: 0x00194468 File Offset: 0x00192668
		// (set) Token: 0x060046E0 RID: 18144 RVA: 0x0019449C File Offset: 0x0019269C
		public unsafe static Dictionary<int, string> FoodsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186891, XrefRangeEnd = 186893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_FoodsMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186893, XrefRangeEnd = 186897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_FoodsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x060046E1 RID: 18145 RVA: 0x001944D4 File Offset: 0x001926D4
		// (set) Token: 0x060046E2 RID: 18146 RVA: 0x00194508 File Offset: 0x00192708
		public unsafe static Dictionary<int, string> RecipesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186897, XrefRangeEnd = 186899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_RecipesMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186899, XrefRangeEnd = 186903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_RecipesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x060046E3 RID: 18147 RVA: 0x00194540 File Offset: 0x00192740
		// (set) Token: 0x060046E4 RID: 18148 RVA: 0x00194574 File Offset: 0x00192774
		public unsafe static Dictionary<int, string> CookersMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186903, XrefRangeEnd = 186905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_CookersMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186905, XrefRangeEnd = 186909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_CookersMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x001945AC File Offset: 0x001927AC
		// (set) Token: 0x060046E6 RID: 18150 RVA: 0x001945E0 File Offset: 0x001927E0
		public unsafe static Dictionary<int, string> IzakayasMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186909, XrefRangeEnd = 186911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_IzakayasMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186911, XrefRangeEnd = 186915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_IzakayasMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x060046E7 RID: 18151 RVA: 0x00194618 File Offset: 0x00192818
		// (set) Token: 0x060046E8 RID: 18152 RVA: 0x0019464C File Offset: 0x0019284C
		public unsafe static Dictionary<int, string> ItemsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186915, XrefRangeEnd = 186917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_ItemsMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186917, XrefRangeEnd = 186921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_ItemsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x00194684 File Offset: 0x00192884
		// (set) Token: 0x060046EA RID: 18154 RVA: 0x001946B8 File Offset: 0x001928B8
		public unsafe static Dictionary<int, string> BadgesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186921, XrefRangeEnd = 186923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_BadgesMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186923, XrefRangeEnd = 186927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_BadgesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x001946F0 File Offset: 0x001928F0
		// (set) Token: 0x060046EC RID: 18156 RVA: 0x00194724 File Offset: 0x00192924
		public unsafe static Dictionary<int, string> TrophyMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186927, XrefRangeEnd = 186929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_get_TrophyMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186929, XrefRangeEnd = 186933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_set_TrophyMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x0019475C File Offset: 0x0019295C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186940, RefRangeEnd = 186943, XrefRangeStart = 186933, XrefRangeEnd = 186940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetIngredientsDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetIngredientsDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00194794 File Offset: 0x00192994
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 186950, RefRangeEnd = 186957, XrefRangeStart = 186943, XrefRangeEnd = 186950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetBeveragesDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetBeveragesDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x001947CC File Offset: 0x001929CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 186964, RefRangeEnd = 186970, XrefRangeStart = 186957, XrefRangeEnd = 186964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFoodsDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetFoodsDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00194804 File Offset: 0x00192A04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 186977, RefRangeEnd = 186982, XrefRangeStart = 186970, XrefRangeEnd = 186977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRecipesDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetRecipesDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x0019483C File Offset: 0x00192A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186989, RefRangeEnd = 186992, XrefRangeStart = 186982, XrefRangeEnd = 186989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCookersDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetCookersDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x00194874 File Offset: 0x00192A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186999, RefRangeEnd = 187000, XrefRangeStart = 186992, XrefRangeEnd = 186999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetIzakayasDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetIzakayasDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x001948AC File Offset: 0x00192AAC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 187007, RefRangeEnd = 187014, XrefRangeStart = 187000, XrefRangeEnd = 187007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetItemsDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetItemsDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x001948E4 File Offset: 0x00192AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187021, RefRangeEnd = 187023, XrefRangeStart = 187014, XrefRangeEnd = 187021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetBadgesDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetBadgesDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0019491C File Offset: 0x00192B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187030, RefRangeEnd = 187031, XrefRangeStart = 187023, XrefRangeEnd = 187030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTrophyDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetTrophyDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00194954 File Offset: 0x00192B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187035, RefRangeEnd = 187036, XrefRangeStart = 187031, XrefRangeEnd = 187035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeDLCMarker(Dictionary<string, GameObject> dlcMarker)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dlcMarker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_InitializeDLCMarker_Public_Static_Void_Dictionary_2_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x0019498C File Offset: 0x00192B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187526, RefRangeEnd = 187527, XrefRangeStart = 187036, XrefRangeEnd = 187526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<string, DataBaseCore.DataBaseCoreData> coreData, Dictionary<int, DataBaseCore.LevelProperties> levelProfileData, Dictionary<string, CollabPackage> collabPackages, Dictionary<int, ClothesProfile.Clothes> clothes, Dictionary<int, Decoration> decorations, Dictionary<int, Record> records)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coreData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(levelProfileData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collabPackages);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decorations);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(records);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseCoreData_Dictionary_2_Int32_LevelProperties_Dictionary_2_String_CollabPackage_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x00194A20 File Offset: 0x00192C20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187533, RefRangeEnd = 187536, XrefRangeStart = 187527, XrefRangeEnd = 187533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllIngredients_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00194A54 File Offset: 0x00192C54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187560, RefRangeEnd = 187563, XrefRangeStart = 187536, XrefRangeEnd = 187560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllEffectiveIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveIngredients_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x00194A88 File Offset: 0x00192C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187587, RefRangeEnd = 187590, XrefRangeStart = 187563, XrefRangeEnd = 187587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllEffectiveAndNotIgnoredIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveAndNotIgnoredIngredients_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x00194ABC File Offset: 0x00192CBC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 187614, RefRangeEnd = 187624, XrefRangeStart = 187590, XrefRangeEnd = 187614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllEffectiveAndNotMissionIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllEffectiveAndNotMissionIngredients_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00194AF0 File Offset: 0x00192CF0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 187630, RefRangeEnd = 187639, XrefRangeStart = 187624, XrefRangeEnd = 187630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllFoods_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00194B24 File Offset: 0x00192D24
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 187645, RefRangeEnd = 187669, XrefRangeStart = 187639, XrefRangeEnd = 187645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllBeverages_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x00194B58 File Offset: 0x00192D58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 187675, RefRangeEnd = 187682, XrefRangeStart = 187669, XrefRangeEnd = 187675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecipes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllRecipes_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x00194B8C File Offset: 0x00192D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187682, XrefRangeEnd = 187688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Recipe> GetAllRecipeValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllRecipeValues_Public_Static_IEnumerable_1_Recipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Recipe>>(intPtr3) : null;
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x00194BC0 File Offset: 0x00192DC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187712, RefRangeEnd = 187714, XrefRangeStart = 187688, XrefRangeEnd = 187712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecipesExceptDLCs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllRecipesExceptDLCs_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00194BF4 File Offset: 0x00192DF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187723, RefRangeEnd = 187728, XrefRangeStart = 187714, XrefRangeEnd = 187723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllCookers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllCookers_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00194C28 File Offset: 0x00192E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187734, RefRangeEnd = 187735, XrefRangeStart = 187728, XrefRangeEnd = 187734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllItems_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x00194C5C File Offset: 0x00192E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187759, RefRangeEnd = 187760, XrefRangeStart = 187735, XrefRangeEnd = 187759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllItemsExceptDefaultClothes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllItemsExceptDefaultClothes_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00194C90 File Offset: 0x00192E90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 187766, RefRangeEnd = 187770, XrefRangeStart = 187760, XrefRangeEnd = 187766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllBadges()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllBadges_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00194CC4 File Offset: 0x00192EC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 187776, RefRangeEnd = 187780, XrefRangeStart = 187770, XrefRangeEnd = 187776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllIzakayas()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllIzakayas_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00194CF8 File Offset: 0x00192EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187794, RefRangeEnd = 187795, XrefRangeStart = 187780, XrefRangeEnd = 187794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllClothes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllClothes_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00194D2C File Offset: 0x00192F2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187809, RefRangeEnd = 187814, XrefRangeStart = 187795, XrefRangeEnd = 187809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllDecorations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllDecorations_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00194D60 File Offset: 0x00192F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187828, RefRangeEnd = 187830, XrefRangeStart = 187814, XrefRangeEnd = 187828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllRecords_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00194D94 File Offset: 0x00192F94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187868, RefRangeEnd = 187870, XrefRangeStart = 187830, XrefRangeEnd = 187868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllTrophies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllTrophies_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00194DC8 File Offset: 0x00192FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187872, RefRangeEnd = 187873, XrefRangeStart = 187870, XrefRangeEnd = 187872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<string, GameObject>> GetAllDLCMarker()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllDLCMarker_Public_Static_IEnumerable_1_KeyValuePair_2_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, GameObject>>>(intPtr3) : null;
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00194DFC File Offset: 0x00192FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187878, RefRangeEnd = 187879, XrefRangeStart = 187873, XrefRangeEnd = 187878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RefDLCMarker(this string dlcLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dlcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefDLCMarker_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00194E40 File Offset: 0x00193040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187879, XrefRangeEnd = 187933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, int> GetIzakayasMusicPackageRecordCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetIzakayasMusicPackageRecordCount_Public_Static_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00194E74 File Offset: 0x00193074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187933, XrefRangeEnd = 187940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ingredient AsNewIngredient(this int ingredientID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ingredientID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_AsNewIngredient_Public_Static_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00194EB4 File Offset: 0x001930B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187947, RefRangeEnd = 187952, XrefRangeStart = 187940, XrefRangeEnd = 187947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sellable AsNewFood(this int foodId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_AsNewFood_Public_Static_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00194EF4 File Offset: 0x001930F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187952, XrefRangeEnd = 187959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sellable AsNewBeverage(this int beverageId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref beverageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_AsNewBeverage_Public_Static_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00194F34 File Offset: 0x00193134
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 187965, RefRangeEnd = 188028, XrefRangeStart = 187959, XrefRangeEnd = 187965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Ingredient RefIngredient(this int ingredientID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ingredientID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefIngredient_Public_Static_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00194F74 File Offset: 0x00193174
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 188034, RefRangeEnd = 188073, XrefRangeStart = 188028, XrefRangeEnd = 188034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sellable RefFood(this int foodId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefFood_Public_Static_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00194FB4 File Offset: 0x001931B4
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 188079, RefRangeEnd = 188144, XrefRangeStart = 188073, XrefRangeEnd = 188079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sellable RefBeverage(this int beverageId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref beverageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefBeverage_Public_Static_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00194FF4 File Offset: 0x001931F4
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 188150, RefRangeEnd = 188186, XrefRangeStart = 188144, XrefRangeEnd = 188150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Recipe RefRecipe(this int recipeId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recipeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefRecipe_Public_Static_Recipe_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00195034 File Offset: 0x00193234
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 188220, RefRangeEnd = 188231, XrefRangeStart = 188186, XrefRangeEnd = 188220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Recipe> MatchRecipe(this int foodId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_MatchRecipe_Public_Static_IEnumerable_1_Recipe_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Recipe>>(intPtr3) : null;
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00195074 File Offset: 0x00193274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 188268, RefRangeEnd = 188271, XrefRangeStart = 188231, XrefRangeEnd = 188268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Recipe MatchFirstRecipe(this int foodId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_MatchFirstRecipe_Public_Static_Recipe_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x001950B4 File Offset: 0x001932B4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 188277, RefRangeEnd = 188304, XrefRangeStart = 188271, XrefRangeEnd = 188277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Cooker RefCooker(this int cookerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefCooker_Public_Static_Cooker_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x001950F4 File Offset: 0x001932F4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 188310, RefRangeEnd = 188327, XrefRangeStart = 188304, XrefRangeEnd = 188310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Izakaya RefIzakaya(this int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefIzakaya_Public_Static_Izakaya_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr3) : null;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00195134 File Offset: 0x00193334
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 188333, RefRangeEnd = 188354, XrefRangeStart = 188327, XrefRangeEnd = 188333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Item RefItem(this int itemId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefItem_Public_Static_Item_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00195174 File Offset: 0x00193374
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 188360, RefRangeEnd = 188368, XrefRangeStart = 188354, XrefRangeEnd = 188360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Badge RefBadge(this int badgeId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref badgeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefBadge_Public_Static_Badge_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Badge>(intPtr3) : null;
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x001951B4 File Offset: 0x001933B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188374, RefRangeEnd = 188375, XrefRangeStart = 188368, XrefRangeEnd = 188374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CollabPackage RefCollab(this string collabLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(collabLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefCollab_Public_Static_CollabPackage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CollabPackage>(intPtr3) : null;
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x001951F8 File Offset: 0x001933F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188381, RefRangeEnd = 188383, XrefRangeStart = 188375, XrefRangeEnd = 188381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<CollabPackage> GetAllCollabs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetAllCollabs_Public_Static_IEnumerable_1_CollabPackage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CollabPackage>>(intPtr3) : null;
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0019522C File Offset: 0x0019342C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 188389, RefRangeEnd = 188402, XrefRangeStart = 188383, XrefRangeEnd = 188389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothesProfile.Clothes RefClothes(this int clothesId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clothesId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefClothes_Public_Static_Clothes_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr3) : null;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0019526C File Offset: 0x0019346C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 188408, RefRangeEnd = 188413, XrefRangeStart = 188402, XrefRangeEnd = 188408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decoration RefDecorations(this int decorationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref decorationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefDecorations_Public_Static_Decoration_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr3) : null;
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x001952AC File Offset: 0x001934AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188419, RefRangeEnd = 188420, XrefRangeStart = 188413, XrefRangeEnd = 188419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Record RefRecords(this int recordId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recordId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefRecords_Public_Static_Record_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Record>(intPtr3) : null;
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x001952EC File Offset: 0x001934EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 188426, RefRangeEnd = 188430, XrefRangeStart = 188420, XrefRangeEnd = 188426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrophiesProfile.Trophy RefTrophies(this int trophyId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trophyId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RefTrophies_Public_Static_Trophy_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrophiesProfile.Trophy>(intPtr3) : null;
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x0019532C File Offset: 0x0019352C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 188436, RefRangeEnd = 188441, XrefRangeStart = 188430, XrefRangeEnd = 188436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClothes(this int clothesId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clothesId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IsClothes_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x0019536C File Offset: 0x0019356C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 188447, RefRangeEnd = 188452, XrefRangeStart = 188441, XrefRangeEnd = 188447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDecoration(this int decorationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref decorationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IsDecoration_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x001953AC File Offset: 0x001935AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 188458, RefRangeEnd = 188463, XrefRangeStart = 188452, XrefRangeEnd = 188458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRecord(this int recordId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recordId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IsRecord_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x001953EC File Offset: 0x001935EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188463, XrefRangeEnd = 188469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTrophy(this int trophyId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trophyId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IsTrophy_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x0019542C File Offset: 0x0019362C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188492, RefRangeEnd = 188493, XrefRangeStart = 188469, XrefRangeEnd = 188492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryMatchRecipe(Sellable foodData, out IEnumerable<Recipe> matchedRecipes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(foodData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_TryMatchRecipe_Public_Static_Boolean_Sellable_byref_IEnumerable_1_Recipe_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			matchedRecipes = ((intPtr4 == 0) ? null : new IEnumerable<Recipe>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x00195490 File Offset: 0x00193690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188520, RefRangeEnd = 188522, XrefRangeStart = 188493, XrefRangeEnd = 188520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Ingredient> GetIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetIngredients_Public_Static_IEnumerable_1_Ingredient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Ingredient>>(intPtr3) : null;
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x001954C4 File Offset: 0x001936C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188528, RefRangeEnd = 188530, XrefRangeStart = 188522, XrefRangeEnd = 188528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetFoods_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x001954F8 File Offset: 0x001936F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188536, RefRangeEnd = 188538, XrefRangeStart = 188530, XrefRangeEnd = 188536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetBevs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetBevs_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0019552C File Offset: 0x0019372C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188562, RefRangeEnd = 188563, XrefRangeStart = 188538, XrefRangeEnd = 188562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Recipe> FindUnObtainedRecipes(Il2CppReferenceArray<Recipe> obtained, IEnumerable<Cooker.CookerType> cookerType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obtained);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_FindUnObtainedRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_Il2CppReferenceArray_1_Recipe_IEnumerable_1_CookerType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr3) : null;
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x00195584 File Offset: 0x00193784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188720, RefRangeEnd = 188721, XrefRangeStart = 188563, XrefRangeEnd = 188720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> SolveTagPriority(IEnumerable<int> rawTags, Dictionary<int, Il2CppStructArray<int>> tagRules, out Il2CppStructArray<int> weakTags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tagRules);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Dictionary_2_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			weakTags = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr5) : null;
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x00195600 File Offset: 0x00193800
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 188724, RefRangeEnd = 188730, XrefRangeStart = 188721, XrefRangeEnd = 188724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> SolveTagPriority(IEnumerable<int> rawTags, out Il2CppStructArray<int> weakTags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawTags);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_byref_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			weakTags = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr5) : null;
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x00195668 File Offset: 0x00193868
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 188735, RefRangeEnd = 188746, XrefRangeStart = 188730, XrefRangeEnd = 188735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DataBaseCore.LevelProperties GetLevelProfile(int level)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_GetLevelProfile_Public_Static_LevelProperties_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DataBaseCore.LevelProperties(pointer);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x001956A0 File Offset: 0x001938A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188752, RefRangeEnd = 188754, XrefRangeStart = 188746, XrefRangeEnd = 188752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckHasNextLevel(int level)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_CheckHasNextLevel_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x001956E0 File Offset: 0x001938E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188754, XrefRangeEnd = 188760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IngredientsExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IngredientsExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x00195720 File Offset: 0x00193920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188760, XrefRangeEnd = 188766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BeveragesExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_BeveragesExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x00195760 File Offset: 0x00193960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188766, XrefRangeEnd = 188772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FoodsExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_FoodsExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x001957A0 File Offset: 0x001939A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188772, XrefRangeEnd = 188778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RecipesExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RecipesExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x001957E0 File Offset: 0x001939E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188778, XrefRangeEnd = 188784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CookersExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_CookersExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x00195820 File Offset: 0x00193A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188790, RefRangeEnd = 188791, XrefRangeStart = 188784, XrefRangeEnd = 188790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IzakayasExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_IzakayasExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x00195860 File Offset: 0x00193A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188797, RefRangeEnd = 188798, XrefRangeStart = 188791, XrefRangeEnd = 188797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ItemsExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_ItemsExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x001958A0 File Offset: 0x00193AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188798, XrefRangeEnd = 188804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BadgesExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_BadgesExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x001958E0 File Offset: 0x00193AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188804, XrefRangeEnd = 188810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClothesExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_ClothesExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x00195920 File Offset: 0x00193B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188810, XrefRangeEnd = 188816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DecorationsExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_DecorationsExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x00195960 File Offset: 0x00193B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188816, XrefRangeEnd = 188822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RecordIdExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_RecordIdExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x001959A0 File Offset: 0x00193BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188822, XrefRangeEnd = 188828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrophyIdExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_TrophyIdExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x001959E0 File Offset: 0x00193BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188828, XrefRangeEnd = 188834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TagRulesExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.NativeMethodInfoPtr_TagRulesExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x00024BB8 File Offset: 0x00022DB8
		public DataBaseCore(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600473B RID: 18235 RVA: 0x00195A20 File Offset: 0x00193C20
		// (set) Token: 0x0600473C RID: 18236 RVA: 0x00024BC1 File Offset: 0x00022DC1
		public unsafe static Dictionary<string, GameObject> _DLCMarker_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__DLCMarker_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__DLCMarker_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600473D RID: 18237 RVA: 0x00195A48 File Offset: 0x00193C48
		// (set) Token: 0x0600473E RID: 18238 RVA: 0x00024BD3 File Offset: 0x00022DD3
		public unsafe static Dictionary<int, Ingredient> _Ingredients_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Ingredients_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Ingredients_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600473F RID: 18239 RVA: 0x00195A70 File Offset: 0x00193C70
		// (set) Token: 0x06004740 RID: 18240 RVA: 0x00024BE5 File Offset: 0x00022DE5
		public unsafe static Dictionary<int, Sellable> _Beverages_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Beverages_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Beverages_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x00195A98 File Offset: 0x00193C98
		// (set) Token: 0x06004742 RID: 18242 RVA: 0x00024BF7 File Offset: 0x00022DF7
		public unsafe static Dictionary<int, Sellable> _Foods_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Foods_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Foods_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x00195AC0 File Offset: 0x00193CC0
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x00024C09 File Offset: 0x00022E09
		public unsafe static Dictionary<int, Recipe> _Recipes_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Recipes_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Recipes_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x00195AE8 File Offset: 0x00193CE8
		// (set) Token: 0x06004746 RID: 18246 RVA: 0x00024C1B File Offset: 0x00022E1B
		public unsafe static Dictionary<int, Cooker> _Cookers_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Cookers_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Cookers_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x00195B10 File Offset: 0x00193D10
		// (set) Token: 0x06004748 RID: 18248 RVA: 0x00024C2D File Offset: 0x00022E2D
		public unsafe static Dictionary<int, Izakaya> _Izakayas_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Izakayas_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Izakayas_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x00195B38 File Offset: 0x00193D38
		// (set) Token: 0x0600474A RID: 18250 RVA: 0x00024C3F File Offset: 0x00022E3F
		public unsafe static Dictionary<int, Item> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Items_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Items_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x0600474B RID: 18251 RVA: 0x00195B60 File Offset: 0x00193D60
		// (set) Token: 0x0600474C RID: 18252 RVA: 0x00024C51 File Offset: 0x00022E51
		public unsafe static Dictionary<int, Badge> _Badges_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Badges_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Badges_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x00195B88 File Offset: 0x00193D88
		// (set) Token: 0x0600474E RID: 18254 RVA: 0x00024C63 File Offset: 0x00022E63
		public unsafe static Dictionary<int, ClothesProfile.Clothes> _Clothes_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Clothes_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ClothesProfile.Clothes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Clothes_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x00195BB0 File Offset: 0x00193DB0
		// (set) Token: 0x06004750 RID: 18256 RVA: 0x00024C75 File Offset: 0x00022E75
		public unsafe static Dictionary<int, Decoration> _Decorations_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Decorations_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Decoration>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Decorations_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x00195BD8 File Offset: 0x00193DD8
		// (set) Token: 0x06004752 RID: 18258 RVA: 0x00024C87 File Offset: 0x00022E87
		public unsafe static Dictionary<int, Record> _RecordId_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__RecordId_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Record>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__RecordId_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x00195C00 File Offset: 0x00193E00
		// (set) Token: 0x06004754 RID: 18260 RVA: 0x00024C99 File Offset: 0x00022E99
		public unsafe static Dictionary<int, TrophiesProfile.Trophy> _Trophies_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__Trophies_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__Trophies_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x00195C28 File Offset: 0x00193E28
		// (set) Token: 0x06004756 RID: 18262 RVA: 0x00024CAB File Offset: 0x00022EAB
		public unsafe static Dictionary<int, Il2CppStructArray<int>> _TagRules_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__TagRules_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__TagRules_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x00195C50 File Offset: 0x00193E50
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x00024CBD File Offset: 0x00022EBD
		public unsafe static Dictionary<int, DataBaseCore.LevelProperties> _CharacterLevelProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__CharacterLevelProfile_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DataBaseCore.LevelProperties>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__CharacterLevelProfile_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x00195C78 File Offset: 0x00193E78
		// (set) Token: 0x0600475A RID: 18266 RVA: 0x00024CCF File Offset: 0x00022ECF
		public unsafe static Dictionary<string, CollabPackage> _CollabPackages_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__CollabPackages_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CollabPackage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__CollabPackages_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x00195CA0 File Offset: 0x00193EA0
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x00024CE1 File Offset: 0x00022EE1
		public unsafe static Dictionary<int, string> _IngredientsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__IngredientsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__IngredientsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x00195CC8 File Offset: 0x00193EC8
		// (set) Token: 0x0600475E RID: 18270 RVA: 0x00024CF3 File Offset: 0x00022EF3
		public unsafe static Dictionary<int, string> _BeveragesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__BeveragesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__BeveragesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x00195CF0 File Offset: 0x00193EF0
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x00024D05 File Offset: 0x00022F05
		public unsafe static Dictionary<int, string> _FoodsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__FoodsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__FoodsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x00195D18 File Offset: 0x00193F18
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x00024D17 File Offset: 0x00022F17
		public unsafe static Dictionary<int, string> _RecipesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__RecipesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__RecipesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x00195D40 File Offset: 0x00193F40
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x00024D29 File Offset: 0x00022F29
		public unsafe static Dictionary<int, string> _CookersMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__CookersMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__CookersMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x00195D68 File Offset: 0x00193F68
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x00024D3B File Offset: 0x00022F3B
		public unsafe static Dictionary<int, string> _IzakayasMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__IzakayasMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__IzakayasMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x00195D90 File Offset: 0x00193F90
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x00024D4D File Offset: 0x00022F4D
		public unsafe static Dictionary<int, string> _ItemsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__ItemsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__ItemsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x00195DB8 File Offset: 0x00193FB8
		// (set) Token: 0x0600476A RID: 18282 RVA: 0x00024D5F File Offset: 0x00022F5F
		public unsafe static Dictionary<int, string> _BadgesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__BadgesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__BadgesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x00195DE0 File Offset: 0x00193FE0
		// (set) Token: 0x0600476C RID: 18284 RVA: 0x00024D71 File Offset: 0x00022F71
		public unsafe static Dictionary<int, string> _TrophyMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseCore.NativeFieldInfoPtr__TrophyMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseCore.NativeFieldInfoPtr__TrophyMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeFieldInfoPtr__DLCMarker_k__BackingField;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeFieldInfoPtr__Ingredients_k__BackingField;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeFieldInfoPtr__Beverages_k__BackingField;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeFieldInfoPtr__Foods_k__BackingField;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeFieldInfoPtr__Cookers_k__BackingField;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeFieldInfoPtr__Izakayas_k__BackingField;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeFieldInfoPtr__Badges_k__BackingField;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeFieldInfoPtr__Clothes_k__BackingField;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeFieldInfoPtr__Decorations_k__BackingField;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeFieldInfoPtr__RecordId_k__BackingField;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeFieldInfoPtr__Trophies_k__BackingField;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr__TagRules_k__BackingField;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeFieldInfoPtr__CharacterLevelProfile_k__BackingField;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeFieldInfoPtr__CollabPackages_k__BackingField;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeFieldInfoPtr__IngredientsMapping_k__BackingField;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeFieldInfoPtr__BeveragesMapping_k__BackingField;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeFieldInfoPtr__FoodsMapping_k__BackingField;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeFieldInfoPtr__RecipesMapping_k__BackingField;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeFieldInfoPtr__CookersMapping_k__BackingField;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr__IzakayasMapping_k__BackingField;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeFieldInfoPtr__ItemsMapping_k__BackingField;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeFieldInfoPtr__BadgesMapping_k__BackingField;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeFieldInfoPtr__TrophyMapping_k__BackingField;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_get_DLCMarker_Private_Static_get_Dictionary_2_String_GameObject_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_set_DLCMarker_Private_Static_set_Void_Dictionary_2_String_GameObject_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Ingredient_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Ingredient_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Sellable_0;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Sellable_0;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Sellable_0;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Private_Static_get_Dictionary_2_Int32_Recipe_0;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_Dictionary_2_Int32_Recipe_0;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Cooker_0;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Cooker_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_Izakaya_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_Izakaya_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Item_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Item_0;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Badge_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Badge_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_get_Clothes_Private_Static_get_Dictionary_2_Int32_Clothes_0;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeMethodInfoPtr_set_Clothes_Private_Static_set_Void_Dictionary_2_Int32_Clothes_0;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeMethodInfoPtr_get_Decorations_Private_Static_get_Dictionary_2_Int32_Decoration_0;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr_set_Decorations_Private_Static_set_Void_Dictionary_2_Int32_Decoration_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordId_Private_Static_get_Dictionary_2_Int32_Record_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr_set_RecordId_Private_Static_set_Void_Dictionary_2_Int32_Record_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_get_Trophies_Private_Static_get_Dictionary_2_Int32_Trophy_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_Dictionary_2_Int32_Trophy_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_get_TagRules_Private_Static_get_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_set_TagRules_Private_Static_set_Void_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterLevelProfile_Private_Static_get_Dictionary_2_Int32_LevelProperties_0;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterLevelProfile_Private_Static_set_Void_Dictionary_2_Int32_LevelProperties_0;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeMethodInfoPtr_get_CollabPackages_Private_Static_get_Dictionary_2_String_CollabPackage_0;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr_set_CollabPackages_Private_Static_set_Void_Dictionary_2_String_CollabPackage_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr_get_IngredientsMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr_set_IngredientsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_get_BeveragesMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_set_BeveragesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodsMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipesMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeMethodInfoPtr_set_RecipesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeMethodInfoPtr_get_CookersMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr_set_CookersMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayasMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_set_IzakayasMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemsMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemsMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr_get_BadgesMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_set_BadgesMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_get_TrophyMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_set_TrophyMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientsDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_GetBeveragesDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodsDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr_GetRecipesDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr_GetCookersDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayasDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr_GetBadgesDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeMethodInfoPtr_GetTrophyDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDLCMarker_Public_Static_Void_Dictionary_2_String_GameObject_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseCoreData_Dictionary_2_Int32_LevelProperties_Dictionary_2_String_CollabPackage_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_GetAllIngredients_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeMethodInfoPtr_GetAllEffectiveIngredients_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr_GetAllEffectiveAndNotIgnoredIngredients_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_GetAllEffectiveAndNotMissionIngredients_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoods_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBeverages_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipes_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipeValues_Public_Static_IEnumerable_1_Recipe_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipesExceptDLCs_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCookers_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemsExceptDefaultClothes_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBadges_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr_GetAllIzakayas_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeMethodInfoPtr_GetAllClothes_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDecorations_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecords_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTrophies_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDLCMarker_Public_Static_IEnumerable_1_KeyValuePair_2_String_GameObject_0;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeMethodInfoPtr_RefDLCMarker_Public_Static_GameObject_String_0;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayasMusicPackageRecordCount_Public_Static_Dictionary_2_Int32_Int32_0;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr_AsNewIngredient_Public_Static_Ingredient_Int32_0;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeMethodInfoPtr_AsNewFood_Public_Static_Sellable_Int32_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr_AsNewBeverage_Public_Static_Sellable_Int32_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr_RefIngredient_Public_Static_Ingredient_Int32_0;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeMethodInfoPtr_RefFood_Public_Static_Sellable_Int32_0;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr_RefBeverage_Public_Static_Sellable_Int32_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr_RefRecipe_Public_Static_Recipe_Int32_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr_MatchRecipe_Public_Static_IEnumerable_1_Recipe_Int32_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr_MatchFirstRecipe_Public_Static_Recipe_Int32_0;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeMethodInfoPtr_RefCooker_Public_Static_Cooker_Int32_0;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeMethodInfoPtr_RefIzakaya_Public_Static_Izakaya_Int32_0;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeMethodInfoPtr_RefItem_Public_Static_Item_Int32_0;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeMethodInfoPtr_RefBadge_Public_Static_Badge_Int32_0;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeMethodInfoPtr_RefCollab_Public_Static_CollabPackage_String_0;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCollabs_Public_Static_IEnumerable_1_CollabPackage_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_RefClothes_Public_Static_Clothes_Int32_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr_RefDecorations_Public_Static_Decoration_Int32_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_RefRecords_Public_Static_Record_Int32_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr_RefTrophies_Public_Static_Trophy_Int32_0;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr_IsClothes_Public_Static_Boolean_Int32_0;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeMethodInfoPtr_IsDecoration_Public_Static_Boolean_Int32_0;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_IsRecord_Public_Static_Boolean_Int32_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr_IsTrophy_Public_Static_Boolean_Int32_0;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr_TryMatchRecipe_Public_Static_Boolean_Sellable_byref_IEnumerable_1_Recipe_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredients_Public_Static_IEnumerable_1_Ingredient_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_GetFoods_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr_GetBevs_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr_FindUnObtainedRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_Il2CppReferenceArray_1_Recipe_IEnumerable_1_CookerType_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_Dictionary_2_Int32_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeMethodInfoPtr_SolveTagPriority_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_Int32_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr_GetLevelProfile_Public_Static_LevelProperties_Int32_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr_CheckHasNextLevel_Public_Static_Boolean_Int32_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr_IngredientsExists_Public_Static_Boolean_Int32_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr_BeveragesExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr_FoodsExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr_RecipesExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr_CookersExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr_IzakayasExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr_ItemsExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr_BadgesExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_ClothesExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_DecorationsExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr_RecordIdExists_Public_Static_Boolean_Int32_0;

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeMethodInfoPtr_TrophyIdExists_Public_Static_Boolean_Int32_0;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr_TagRulesExists_Public_Static_Boolean_Int32_0;

		// Token: 0x02000AA9 RID: 2729
		public class DataBaseCoreData : Il2CppSystem.Object
		{
			// Token: 0x0600CC67 RID: 52327 RVA: 0x00326EBC File Offset: 0x003250BC
			// Note: this type is marked as 'beforefieldinit'.
			static DataBaseCoreData()
			{
				Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "DataBaseCoreData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr);
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Ingredients_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Ingredients>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Beverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Beverages>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Foods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Foods>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Recipes>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Cookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Cookers>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Izakayas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Izakayas>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Items>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Badges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Badges>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Trophies_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Trophies>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Clothes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<Clothes>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__DecorationId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<DecorationId>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__RecordId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<RecordId>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__TagRules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, "<TagRules>k__BackingField");
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Ingredient_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Recipe_Dictionary_2_Int32_Cooker_Dictionary_2_Int32_Izakaya_Dictionary_2_Int32_Item_Dictionary_2_Int32_Badge_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_Dictionary_2_Int32_Trophy_List_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677457);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Ingredients_Internal_get_Dictionary_2_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677458);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Ingredients_Internal_set_Void_Dictionary_2_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677459);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Beverages_Internal_get_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677460);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Beverages_Internal_set_Void_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677461);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Foods_Internal_get_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677462);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Foods_Internal_set_Void_Dictionary_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677463);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Recipes_Internal_get_Dictionary_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677464);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Recipes_Internal_set_Void_Dictionary_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677465);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Cookers_Internal_get_Dictionary_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677466);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Cookers_Internal_set_Void_Dictionary_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677467);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Izakayas_Internal_get_Dictionary_2_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677468);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Izakayas_Internal_set_Void_Dictionary_2_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677469);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Items_Internal_get_Dictionary_2_Int32_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677470);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Items_Internal_set_Void_Dictionary_2_Int32_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677471);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Badges_Internal_get_Dictionary_2_Int32_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677472);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Badges_Internal_set_Void_Dictionary_2_Int32_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677473);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Trophies_Internal_get_Dictionary_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677474);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Trophies_Internal_set_Void_Dictionary_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677475);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Clothes_Internal_get_Dictionary_2_Int32_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677476);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Clothes_Internal_set_Void_Dictionary_2_Int32_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677477);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_DecorationId_Internal_get_Dictionary_2_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677478);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_DecorationId_Internal_set_Void_Dictionary_2_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677479);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_RecordId_Internal_get_Dictionary_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677480);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_RecordId_Internal_set_Void_Dictionary_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677481);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_TagRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677482);
				DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_TagRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr, 100677483);
			}

			// Token: 0x0600CC68 RID: 52328 RVA: 0x00327208 File Offset: 0x00325408
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186325, RefRangeEnd = 186326, XrefRangeStart = 186311, XrefRangeEnd = 186325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataBaseCoreData(Dictionary<int, Ingredient> ingredients, Dictionary<int, Sellable> beverages, Dictionary<int, Sellable> foods, Dictionary<int, Recipe> recipes, Dictionary<int, Cooker> cookers, Dictionary<int, Izakaya> izakayas, Dictionary<int, Item> items, Dictionary<int, Badge> badges, Dictionary<int, ClothesProfile.Clothes> clothes, Dictionary<int, Decoration> decorationId, Dictionary<int, Record> recordId, Dictionary<int, TrophiesProfile.Trophy> trophyId, List<Il2CppStructArray<int>> tagRules) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.DataBaseCoreData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayas);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothes);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decorationId);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recordId);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trophyId);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tagRules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Ingredient_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Recipe_Dictionary_2_Int32_Cooker_Dictionary_2_Int32_Izakaya_Dictionary_2_Int32_Item_Dictionary_2_Int32_Badge_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_Dictionary_2_Int32_Trophy_List_1_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700425F RID: 16991
			// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x0032733C File Offset: 0x0032553C
			// (set) Token: 0x0600CC6A RID: 52330 RVA: 0x0032737C File Offset: 0x0032557C
			public unsafe Dictionary<int, Ingredient> Ingredients
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Ingredients_Internal_get_Dictionary_2_Int32_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Ingredients_Internal_set_Void_Dictionary_2_Int32_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004260 RID: 16992
			// (get) Token: 0x0600CC6B RID: 52331 RVA: 0x003273C0 File Offset: 0x003255C0
			// (set) Token: 0x0600CC6C RID: 52332 RVA: 0x00327400 File Offset: 0x00325600
			public unsafe Dictionary<int, Sellable> Beverages
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Beverages_Internal_get_Dictionary_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Beverages_Internal_set_Void_Dictionary_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004261 RID: 16993
			// (get) Token: 0x0600CC6D RID: 52333 RVA: 0x00327444 File Offset: 0x00325644
			// (set) Token: 0x0600CC6E RID: 52334 RVA: 0x00327484 File Offset: 0x00325684
			public unsafe Dictionary<int, Sellable> Foods
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Foods_Internal_get_Dictionary_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Foods_Internal_set_Void_Dictionary_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004262 RID: 16994
			// (get) Token: 0x0600CC6F RID: 52335 RVA: 0x003274C8 File Offset: 0x003256C8
			// (set) Token: 0x0600CC70 RID: 52336 RVA: 0x00327508 File Offset: 0x00325708
			public unsafe Dictionary<int, Recipe> Recipes
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Recipes_Internal_get_Dictionary_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Recipes_Internal_set_Void_Dictionary_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004263 RID: 16995
			// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x0032754C File Offset: 0x0032574C
			// (set) Token: 0x0600CC72 RID: 52338 RVA: 0x0032758C File Offset: 0x0032578C
			public unsafe Dictionary<int, Cooker> Cookers
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Cookers_Internal_get_Dictionary_2_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Cookers_Internal_set_Void_Dictionary_2_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004264 RID: 16996
			// (get) Token: 0x0600CC73 RID: 52339 RVA: 0x003275D0 File Offset: 0x003257D0
			// (set) Token: 0x0600CC74 RID: 52340 RVA: 0x00327610 File Offset: 0x00325810
			public unsafe Dictionary<int, Izakaya> Izakayas
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Izakayas_Internal_get_Dictionary_2_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Izakayas_Internal_set_Void_Dictionary_2_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004265 RID: 16997
			// (get) Token: 0x0600CC75 RID: 52341 RVA: 0x00327654 File Offset: 0x00325854
			// (set) Token: 0x0600CC76 RID: 52342 RVA: 0x00327694 File Offset: 0x00325894
			public unsafe Dictionary<int, Item> Items
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Items_Internal_get_Dictionary_2_Int32_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Items_Internal_set_Void_Dictionary_2_Int32_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004266 RID: 16998
			// (get) Token: 0x0600CC77 RID: 52343 RVA: 0x003276D8 File Offset: 0x003258D8
			// (set) Token: 0x0600CC78 RID: 52344 RVA: 0x00327718 File Offset: 0x00325918
			public unsafe Dictionary<int, Badge> Badges
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Badges_Internal_get_Dictionary_2_Int32_Badge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 157648, RefRangeEnd = 157649, XrefRangeStart = 157648, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Badges_Internal_set_Void_Dictionary_2_Int32_Badge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004267 RID: 16999
			// (get) Token: 0x0600CC79 RID: 52345 RVA: 0x0032775C File Offset: 0x0032595C
			// (set) Token: 0x0600CC7A RID: 52346 RVA: 0x0032779C File Offset: 0x0032599C
			public unsafe Dictionary<int, TrophiesProfile.Trophy> Trophies
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Trophies_Internal_get_Dictionary_2_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Trophies_Internal_set_Void_Dictionary_2_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004268 RID: 17000
			// (get) Token: 0x0600CC7B RID: 52347 RVA: 0x003277E0 File Offset: 0x003259E0
			// (set) Token: 0x0600CC7C RID: 52348 RVA: 0x00327820 File Offset: 0x00325A20
			public unsafe Dictionary<int, ClothesProfile.Clothes> Clothes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_Clothes_Internal_get_Dictionary_2_Int32_Clothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ClothesProfile.Clothes>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_Clothes_Internal_set_Void_Dictionary_2_Int32_Clothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004269 RID: 17001
			// (get) Token: 0x0600CC7D RID: 52349 RVA: 0x00327864 File Offset: 0x00325A64
			// (set) Token: 0x0600CC7E RID: 52350 RVA: 0x003278A4 File Offset: 0x00325AA4
			public unsafe Dictionary<int, Decoration> DecorationId
			{
				[CallerCount(40)]
				[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_DecorationId_Internal_get_Dictionary_2_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Decoration>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_DecorationId_Internal_set_Void_Dictionary_2_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700426A RID: 17002
			// (get) Token: 0x0600CC7F RID: 52351 RVA: 0x003278E8 File Offset: 0x00325AE8
			// (set) Token: 0x0600CC80 RID: 52352 RVA: 0x00327928 File Offset: 0x00325B28
			public unsafe Dictionary<int, Record> RecordId
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_RecordId_Internal_get_Dictionary_2_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Record>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_RecordId_Internal_set_Void_Dictionary_2_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700426B RID: 17003
			// (get) Token: 0x0600CC81 RID: 52353 RVA: 0x0032796C File Offset: 0x00325B6C
			// (set) Token: 0x0600CC82 RID: 52354 RVA: 0x003279AC File Offset: 0x00325BAC
			public unsafe List<Il2CppStructArray<int>> TagRules
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_get_TagRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.DataBaseCoreData.NativeMethodInfoPtr_set_TagRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CC83 RID: 52355 RVA: 0x0006DA80 File Offset: 0x0006BC80
			public DataBaseCoreData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004252 RID: 16978
			// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x003279F0 File Offset: 0x00325BF0
			// (set) Token: 0x0600CC85 RID: 52357 RVA: 0x0006DA89 File Offset: 0x0006BC89
			public unsafe Dictionary<int, Ingredient> _Ingredients_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Ingredients_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Ingredients_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004253 RID: 16979
			// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x00327A20 File Offset: 0x00325C20
			// (set) Token: 0x0600CC87 RID: 52359 RVA: 0x0006DAA8 File Offset: 0x0006BCA8
			public unsafe Dictionary<int, Sellable> _Beverages_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Beverages_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Beverages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004254 RID: 16980
			// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x00327A50 File Offset: 0x00325C50
			// (set) Token: 0x0600CC89 RID: 52361 RVA: 0x0006DAC7 File Offset: 0x0006BCC7
			public unsafe Dictionary<int, Sellable> _Foods_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Foods_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Foods_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004255 RID: 16981
			// (get) Token: 0x0600CC8A RID: 52362 RVA: 0x00327A80 File Offset: 0x00325C80
			// (set) Token: 0x0600CC8B RID: 52363 RVA: 0x0006DAE6 File Offset: 0x0006BCE6
			public unsafe Dictionary<int, Recipe> _Recipes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Recipes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Recipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004256 RID: 16982
			// (get) Token: 0x0600CC8C RID: 52364 RVA: 0x00327AB0 File Offset: 0x00325CB0
			// (set) Token: 0x0600CC8D RID: 52365 RVA: 0x0006DB05 File Offset: 0x0006BD05
			public unsafe Dictionary<int, Cooker> _Cookers_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Cookers_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Cookers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0600CC8E RID: 52366 RVA: 0x00327AE0 File Offset: 0x00325CE0
			// (set) Token: 0x0600CC8F RID: 52367 RVA: 0x0006DB24 File Offset: 0x0006BD24
			public unsafe Dictionary<int, Izakaya> _Izakayas_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Izakayas_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Izakayas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004258 RID: 16984
			// (get) Token: 0x0600CC90 RID: 52368 RVA: 0x00327B10 File Offset: 0x00325D10
			// (set) Token: 0x0600CC91 RID: 52369 RVA: 0x0006DB43 File Offset: 0x0006BD43
			public unsafe Dictionary<int, Item> _Items_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Items_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004259 RID: 16985
			// (get) Token: 0x0600CC92 RID: 52370 RVA: 0x00327B40 File Offset: 0x00325D40
			// (set) Token: 0x0600CC93 RID: 52371 RVA: 0x0006DB62 File Offset: 0x0006BD62
			public unsafe Dictionary<int, Badge> _Badges_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Badges_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Badges_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425A RID: 16986
			// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x00327B70 File Offset: 0x00325D70
			// (set) Token: 0x0600CC95 RID: 52373 RVA: 0x0006DB81 File Offset: 0x0006BD81
			public unsafe Dictionary<int, TrophiesProfile.Trophy> _Trophies_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Trophies_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Trophies_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425B RID: 16987
			// (get) Token: 0x0600CC96 RID: 52374 RVA: 0x00327BA0 File Offset: 0x00325DA0
			// (set) Token: 0x0600CC97 RID: 52375 RVA: 0x0006DBA0 File Offset: 0x0006BDA0
			public unsafe Dictionary<int, ClothesProfile.Clothes> _Clothes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Clothes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ClothesProfile.Clothes>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__Clothes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425C RID: 16988
			// (get) Token: 0x0600CC98 RID: 52376 RVA: 0x00327BD0 File Offset: 0x00325DD0
			// (set) Token: 0x0600CC99 RID: 52377 RVA: 0x0006DBBF File Offset: 0x0006BDBF
			public unsafe Dictionary<int, Decoration> _DecorationId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__DecorationId_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Decoration>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__DecorationId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425D RID: 16989
			// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x00327C00 File Offset: 0x00325E00
			// (set) Token: 0x0600CC9B RID: 52379 RVA: 0x0006DBDE File Offset: 0x0006BDDE
			public unsafe Dictionary<int, Record> _RecordId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__RecordId_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Record>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__RecordId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425E RID: 16990
			// (get) Token: 0x0600CC9C RID: 52380 RVA: 0x00327C30 File Offset: 0x00325E30
			// (set) Token: 0x0600CC9D RID: 52381 RVA: 0x0006DBFD File Offset: 0x0006BDFD
			public unsafe List<Il2CppStructArray<int>> _TagRules_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__TagRules_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.DataBaseCoreData.NativeFieldInfoPtr__TagRules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008354 RID: 33620
			private static readonly IntPtr NativeFieldInfoPtr__Ingredients_k__BackingField;

			// Token: 0x04008355 RID: 33621
			private static readonly IntPtr NativeFieldInfoPtr__Beverages_k__BackingField;

			// Token: 0x04008356 RID: 33622
			private static readonly IntPtr NativeFieldInfoPtr__Foods_k__BackingField;

			// Token: 0x04008357 RID: 33623
			private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

			// Token: 0x04008358 RID: 33624
			private static readonly IntPtr NativeFieldInfoPtr__Cookers_k__BackingField;

			// Token: 0x04008359 RID: 33625
			private static readonly IntPtr NativeFieldInfoPtr__Izakayas_k__BackingField;

			// Token: 0x0400835A RID: 33626
			private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

			// Token: 0x0400835B RID: 33627
			private static readonly IntPtr NativeFieldInfoPtr__Badges_k__BackingField;

			// Token: 0x0400835C RID: 33628
			private static readonly IntPtr NativeFieldInfoPtr__Trophies_k__BackingField;

			// Token: 0x0400835D RID: 33629
			private static readonly IntPtr NativeFieldInfoPtr__Clothes_k__BackingField;

			// Token: 0x0400835E RID: 33630
			private static readonly IntPtr NativeFieldInfoPtr__DecorationId_k__BackingField;

			// Token: 0x0400835F RID: 33631
			private static readonly IntPtr NativeFieldInfoPtr__RecordId_k__BackingField;

			// Token: 0x04008360 RID: 33632
			private static readonly IntPtr NativeFieldInfoPtr__TagRules_k__BackingField;

			// Token: 0x04008361 RID: 33633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Ingredient_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Sellable_Dictionary_2_Int32_Recipe_Dictionary_2_Int32_Cooker_Dictionary_2_Int32_Izakaya_Dictionary_2_Int32_Item_Dictionary_2_Int32_Badge_Dictionary_2_Int32_Clothes_Dictionary_2_Int32_Decoration_Dictionary_2_Int32_Record_Dictionary_2_Int32_Trophy_List_1_Il2CppStructArray_1_Int32_0;

			// Token: 0x04008362 RID: 33634
			private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Internal_get_Dictionary_2_Int32_Ingredient_0;

			// Token: 0x04008363 RID: 33635
			private static readonly IntPtr NativeMethodInfoPtr_set_Ingredients_Internal_set_Void_Dictionary_2_Int32_Ingredient_0;

			// Token: 0x04008364 RID: 33636
			private static readonly IntPtr NativeMethodInfoPtr_get_Beverages_Internal_get_Dictionary_2_Int32_Sellable_0;

			// Token: 0x04008365 RID: 33637
			private static readonly IntPtr NativeMethodInfoPtr_set_Beverages_Internal_set_Void_Dictionary_2_Int32_Sellable_0;

			// Token: 0x04008366 RID: 33638
			private static readonly IntPtr NativeMethodInfoPtr_get_Foods_Internal_get_Dictionary_2_Int32_Sellable_0;

			// Token: 0x04008367 RID: 33639
			private static readonly IntPtr NativeMethodInfoPtr_set_Foods_Internal_set_Void_Dictionary_2_Int32_Sellable_0;

			// Token: 0x04008368 RID: 33640
			private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Internal_get_Dictionary_2_Int32_Recipe_0;

			// Token: 0x04008369 RID: 33641
			private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Internal_set_Void_Dictionary_2_Int32_Recipe_0;

			// Token: 0x0400836A RID: 33642
			private static readonly IntPtr NativeMethodInfoPtr_get_Cookers_Internal_get_Dictionary_2_Int32_Cooker_0;

			// Token: 0x0400836B RID: 33643
			private static readonly IntPtr NativeMethodInfoPtr_set_Cookers_Internal_set_Void_Dictionary_2_Int32_Cooker_0;

			// Token: 0x0400836C RID: 33644
			private static readonly IntPtr NativeMethodInfoPtr_get_Izakayas_Internal_get_Dictionary_2_Int32_Izakaya_0;

			// Token: 0x0400836D RID: 33645
			private static readonly IntPtr NativeMethodInfoPtr_set_Izakayas_Internal_set_Void_Dictionary_2_Int32_Izakaya_0;

			// Token: 0x0400836E RID: 33646
			private static readonly IntPtr NativeMethodInfoPtr_get_Items_Internal_get_Dictionary_2_Int32_Item_0;

			// Token: 0x0400836F RID: 33647
			private static readonly IntPtr NativeMethodInfoPtr_set_Items_Internal_set_Void_Dictionary_2_Int32_Item_0;

			// Token: 0x04008370 RID: 33648
			private static readonly IntPtr NativeMethodInfoPtr_get_Badges_Internal_get_Dictionary_2_Int32_Badge_0;

			// Token: 0x04008371 RID: 33649
			private static readonly IntPtr NativeMethodInfoPtr_set_Badges_Internal_set_Void_Dictionary_2_Int32_Badge_0;

			// Token: 0x04008372 RID: 33650
			private static readonly IntPtr NativeMethodInfoPtr_get_Trophies_Internal_get_Dictionary_2_Int32_Trophy_0;

			// Token: 0x04008373 RID: 33651
			private static readonly IntPtr NativeMethodInfoPtr_set_Trophies_Internal_set_Void_Dictionary_2_Int32_Trophy_0;

			// Token: 0x04008374 RID: 33652
			private static readonly IntPtr NativeMethodInfoPtr_get_Clothes_Internal_get_Dictionary_2_Int32_Clothes_0;

			// Token: 0x04008375 RID: 33653
			private static readonly IntPtr NativeMethodInfoPtr_set_Clothes_Internal_set_Void_Dictionary_2_Int32_Clothes_0;

			// Token: 0x04008376 RID: 33654
			private static readonly IntPtr NativeMethodInfoPtr_get_DecorationId_Internal_get_Dictionary_2_Int32_Decoration_0;

			// Token: 0x04008377 RID: 33655
			private static readonly IntPtr NativeMethodInfoPtr_set_DecorationId_Internal_set_Void_Dictionary_2_Int32_Decoration_0;

			// Token: 0x04008378 RID: 33656
			private static readonly IntPtr NativeMethodInfoPtr_get_RecordId_Internal_get_Dictionary_2_Int32_Record_0;

			// Token: 0x04008379 RID: 33657
			private static readonly IntPtr NativeMethodInfoPtr_set_RecordId_Internal_set_Void_Dictionary_2_Int32_Record_0;

			// Token: 0x0400837A RID: 33658
			private static readonly IntPtr NativeMethodInfoPtr_get_TagRules_Internal_get_List_1_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400837B RID: 33659
			private static readonly IntPtr NativeMethodInfoPtr_set_TagRules_Internal_set_Void_List_1_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000AAA RID: 2730
		[Serializable]
		public sealed class LevelProperties : ValueType
		{
			// Token: 0x0600CC9E RID: 52382 RVA: 0x00327C60 File Offset: 0x00325E60
			// Note: this type is marked as 'beforefieldinit'.
			static LevelProperties()
			{
				Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "LevelProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr);
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_levelUpExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "levelUpExp");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_startPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "startPassion");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_startTipRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "startTipRate");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "maxRecipes");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "maxBeverages");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_dayCookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "dayCookCount");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_cookSpdMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "cookSpdMultiplier");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_moveSpdMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "moveSpdMultiplier");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffTriggerProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "qteBuffTriggerProb");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffLengthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "qteBuffLengthMultiplier");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_doubleCollectionProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "doubleCollectionProb");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_shopPriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "shopPriceMultiplier");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "maxTray");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "additiveGuestPatient");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "additiveGuestSpawnRate");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestBaseMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "additiveGuestBaseMood");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_additivePositiveBuffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "additivePositiveBuffTime");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr_unlockedRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "unlockedRecipes");
				DataBaseCore.LevelProperties.NativeFieldInfoPtr__PropertyLinkedList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "<PropertyLinkedList>k__BackingField");
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_LevelUpExp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677484);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_BasePassion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677485);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_TipRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677486);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxDailyRecipe_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677487);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxDailyBev_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677488);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DailyCookCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677489);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_CookSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677490);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677491);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffProb_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677492);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffDurationMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677493);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DoubleCollectProb_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677494);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MerchantPriceMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677495);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677496);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestBaseMood_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677497);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestPatient_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677498);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestSpawnRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677499);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraPositiveBuffTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677500);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_UnlockedRecipes_Public_get_Il2CppReferenceArray_1_levelUnlockRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677501);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_StartPassion_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677502);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_StartTipRate_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677503);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxRecipes_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677504);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxBeverages_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677505);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DayCookCount_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677506);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_CookSpdMultiplier_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677507);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677508);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffTriggerProb_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677509);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffLengthMultiplier_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677510);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DoubleCollectionProb_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677511);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ShopPriceMultiplier_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677512);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxTray_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677513);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestPatient_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677514);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestSpawnRate_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677515);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestBaseMood_Public_get_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677516);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditivePositiveBuffTime_Public_get_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677517);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_PropertyLinkedList_Public_get_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677518);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_set_PropertyLinkedList_Public_set_Void_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677519);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_GetValueInt_Private_Int32_Func_2_LevelProperties_DiffPropertyInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677520);
				DataBaseCore.LevelProperties.NativeMethodInfoPtr_GetValueFloat_Private_Single_Func_2_LevelProperties_DiffPropertyFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, 100677521);
			}

			// Token: 0x1700427F RID: 17023
			// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x00328100 File Offset: 0x00326300
			public unsafe int LevelUpExp
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_LevelUpExp_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004280 RID: 17024
			// (get) Token: 0x0600CCA0 RID: 52384 RVA: 0x00328144 File Offset: 0x00326344
			public unsafe int BasePassion
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186353, RefRangeEnd = 186357, XrefRangeStart = 186336, XrefRangeEnd = 186353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_BasePassion_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004281 RID: 17025
			// (get) Token: 0x0600CCA1 RID: 52385 RVA: 0x00328188 File Offset: 0x00326388
			public unsafe float TipRate
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 186374, RefRangeEnd = 186380, XrefRangeStart = 186357, XrefRangeEnd = 186374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_TipRate_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004282 RID: 17026
			// (get) Token: 0x0600CCA2 RID: 52386 RVA: 0x003281CC File Offset: 0x003263CC
			public unsafe int MaxDailyRecipe
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 186397, RefRangeEnd = 186402, XrefRangeStart = 186380, XrefRangeEnd = 186397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxDailyRecipe_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004283 RID: 17027
			// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x00328210 File Offset: 0x00326410
			public unsafe int MaxDailyBev
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 186419, RefRangeEnd = 186424, XrefRangeStart = 186402, XrefRangeEnd = 186419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxDailyBev_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004284 RID: 17028
			// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x00328254 File Offset: 0x00326454
			public unsafe int DailyCookCount
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186441, RefRangeEnd = 186445, XrefRangeStart = 186424, XrefRangeEnd = 186441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DailyCookCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004285 RID: 17029
			// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x00328298 File Offset: 0x00326498
			public unsafe float CookSpeedMultiplier
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 186462, RefRangeEnd = 186468, XrefRangeStart = 186445, XrefRangeEnd = 186462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_CookSpeedMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004286 RID: 17030
			// (get) Token: 0x0600CCA6 RID: 52390 RVA: 0x003282DC File Offset: 0x003264DC
			public unsafe float MoveSpeedMultiplier
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 186485, RefRangeEnd = 186492, XrefRangeStart = 186468, XrefRangeEnd = 186485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004287 RID: 17031
			// (get) Token: 0x0600CCA7 RID: 52391 RVA: 0x00328320 File Offset: 0x00326520
			public unsafe float QteBuffProb
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186509, RefRangeEnd = 186513, XrefRangeStart = 186492, XrefRangeEnd = 186509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffProb_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004288 RID: 17032
			// (get) Token: 0x0600CCA8 RID: 52392 RVA: 0x00328364 File Offset: 0x00326564
			public unsafe float QteBuffDurationMultiplier
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186530, RefRangeEnd = 186534, XrefRangeStart = 186513, XrefRangeEnd = 186530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffDurationMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004289 RID: 17033
			// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x003283A8 File Offset: 0x003265A8
			public unsafe float DoubleCollectProb
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 186551, RefRangeEnd = 186556, XrefRangeStart = 186534, XrefRangeEnd = 186551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DoubleCollectProb_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428A RID: 17034
			// (get) Token: 0x0600CCAA RID: 52394 RVA: 0x003283EC File Offset: 0x003265EC
			public unsafe float MerchantPriceMultiplier
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 186573, RefRangeEnd = 186579, XrefRangeStart = 186556, XrefRangeEnd = 186573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MerchantPriceMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428B RID: 17035
			// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x00328430 File Offset: 0x00326630
			public unsafe int TrayMaxNum
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 186596, RefRangeEnd = 186601, XrefRangeStart = 186579, XrefRangeEnd = 186596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428C RID: 17036
			// (get) Token: 0x0600CCAC RID: 52396 RVA: 0x00328474 File Offset: 0x00326674
			public unsafe int ExtraGuestBaseMood
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186618, RefRangeEnd = 186622, XrefRangeStart = 186601, XrefRangeEnd = 186618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestBaseMood_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428D RID: 17037
			// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x003284B8 File Offset: 0x003266B8
			public unsafe float ExtraGuestPatient
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186639, RefRangeEnd = 186643, XrefRangeStart = 186622, XrefRangeEnd = 186639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestPatient_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428E RID: 17038
			// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x003284FC File Offset: 0x003266FC
			public unsafe float ExtraGuestSpawnRate
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 186660, RefRangeEnd = 186664, XrefRangeStart = 186643, XrefRangeEnd = 186660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraGuestSpawnRate_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700428F RID: 17039
			// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x00328540 File Offset: 0x00326740
			public unsafe float ExtraPositiveBuffTime
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 186681, RefRangeEnd = 186688, XrefRangeStart = 186664, XrefRangeEnd = 186681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ExtraPositiveBuffTime_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004290 RID: 17040
			// (get) Token: 0x0600CCB0 RID: 52400 RVA: 0x00328584 File Offset: 0x00326784
			public unsafe Il2CppReferenceArray<DataBaseCore.LevelProperties.levelUnlockRecipe> UnlockedRecipes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_UnlockedRecipes_Public_get_Il2CppReferenceArray_1_levelUnlockRecipe_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataBaseCore.LevelProperties.levelUnlockRecipe>>(intPtr3) : null;
				}
			}

			// Token: 0x17004291 RID: 17041
			// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x003285C8 File Offset: 0x003267C8
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt StartPassion
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_StartPassion_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x17004292 RID: 17042
			// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x0032860C File Offset: 0x0032680C
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat StartTipRate
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_StartTipRate_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x17004293 RID: 17043
			// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x00328650 File Offset: 0x00326850
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt MaxRecipes
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxRecipes_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x17004294 RID: 17044
			// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x00328694 File Offset: 0x00326894
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt MaxBeverages
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxBeverages_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x17004295 RID: 17045
			// (get) Token: 0x0600CCB5 RID: 52405 RVA: 0x003286D8 File Offset: 0x003268D8
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt DayCookCount
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DayCookCount_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x17004296 RID: 17046
			// (get) Token: 0x0600CCB6 RID: 52406 RVA: 0x0032871C File Offset: 0x0032691C
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat CookSpdMultiplier
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_CookSpdMultiplier_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x17004297 RID: 17047
			// (get) Token: 0x0600CCB7 RID: 52407 RVA: 0x00328760 File Offset: 0x00326960
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat MoveSpdMultiplier
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x17004298 RID: 17048
			// (get) Token: 0x0600CCB8 RID: 52408 RVA: 0x003287A4 File Offset: 0x003269A4
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat QteBuffTriggerProb
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffTriggerProb_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x17004299 RID: 17049
			// (get) Token: 0x0600CCB9 RID: 52409 RVA: 0x003287E8 File Offset: 0x003269E8
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat QteBuffLengthMultiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_QteBuffLengthMultiplier_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x1700429A RID: 17050
			// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x0032882C File Offset: 0x00326A2C
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat DoubleCollectionProb
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_DoubleCollectionProb_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x1700429B RID: 17051
			// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x00328870 File Offset: 0x00326A70
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat ShopPriceMultiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_ShopPriceMultiplier_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x1700429C RID: 17052
			// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x003288B4 File Offset: 0x00326AB4
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt MaxTray
			{
				[CallerCount(40)]
				[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_MaxTray_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x1700429D RID: 17053
			// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x003288F8 File Offset: 0x00326AF8
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat AdditiveGuestPatient
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestPatient_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x1700429E RID: 17054
			// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x0032893C File Offset: 0x00326B3C
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat AdditiveGuestSpawnRate
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestSpawnRate_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x1700429F RID: 17055
			// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x00328980 File Offset: 0x00326B80
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt AdditiveGuestBaseMood
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditiveGuestBaseMood_Public_get_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}
			}

			// Token: 0x170042A0 RID: 17056
			// (get) Token: 0x0600CCC0 RID: 52416 RVA: 0x003289C4 File Offset: 0x00326BC4
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat AdditivePositiveBuffTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_AdditivePositiveBuffTime_Public_get_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}
			}

			// Token: 0x170042A1 RID: 17057
			// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x00328A08 File Offset: 0x00326C08
			// (set) Token: 0x0600CCC2 RID: 52418 RVA: 0x00328A4C File Offset: 0x00326C4C
			public unsafe LinkedListNode<ValueTuple<int, DataBaseCore.LevelProperties>> PropertyLinkedList
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_get_PropertyLinkedList_Public_get_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<ValueTuple<int, DataBaseCore.LevelProperties>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_set_PropertyLinkedList_Public_set_Void_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600CCC3 RID: 52419 RVA: 0x00328A94 File Offset: 0x00326C94
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 186702, RefRangeEnd = 186708, XrefRangeStart = 186688, XrefRangeEnd = 186702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetValueInt(Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> getValueCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getValueCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_GetValueInt_Private_Int32_Func_2_LevelProperties_DiffPropertyInt_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCC4 RID: 52420 RVA: 0x00328AE8 File Offset: 0x00326CE8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 186722, RefRangeEnd = 186732, XrefRangeStart = 186708, XrefRangeEnd = 186722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetValueFloat(Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> getValueCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getValueCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.NativeMethodInfoPtr_GetValueFloat_Private_Single_Func_2_LevelProperties_DiffPropertyFloat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCC5 RID: 52421 RVA: 0x0006DC1C File Offset: 0x0006BE1C
			public LevelProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CCC6 RID: 52422 RVA: 0x0006DC25 File Offset: 0x0006BE25
			public LevelProperties() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr))
			{
			}

			// Token: 0x1700426C RID: 17004
			// (get) Token: 0x0600CCC7 RID: 52423 RVA: 0x00328B3C File Offset: 0x00326D3C
			// (set) Token: 0x0600CCC8 RID: 52424 RVA: 0x0006DC37 File Offset: 0x0006BE37
			public unsafe int levelUpExp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_levelUpExp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_levelUpExp)) = value;
				}
			}

			// Token: 0x1700426D RID: 17005
			// (get) Token: 0x0600CCC9 RID: 52425 RVA: 0x00328B64 File Offset: 0x00326D64
			// (set) Token: 0x0600CCCA RID: 52426 RVA: 0x0006DC52 File Offset: 0x0006BE52
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt startPassion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_startPassion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_startPassion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426E RID: 17006
			// (get) Token: 0x0600CCCB RID: 52427 RVA: 0x00328B94 File Offset: 0x00326D94
			// (set) Token: 0x0600CCCC RID: 52428 RVA: 0x0006DC71 File Offset: 0x0006BE71
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat startTipRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_startTipRate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_startTipRate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426F RID: 17007
			// (get) Token: 0x0600CCCD RID: 52429 RVA: 0x00328BC4 File Offset: 0x00326DC4
			// (set) Token: 0x0600CCCE RID: 52430 RVA: 0x0006DC90 File Offset: 0x0006BE90
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt maxRecipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxRecipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004270 RID: 17008
			// (get) Token: 0x0600CCCF RID: 52431 RVA: 0x00328BF4 File Offset: 0x00326DF4
			// (set) Token: 0x0600CCD0 RID: 52432 RVA: 0x0006DCAF File Offset: 0x0006BEAF
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt maxBeverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxBeverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004271 RID: 17009
			// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00328C24 File Offset: 0x00326E24
			// (set) Token: 0x0600CCD2 RID: 52434 RVA: 0x0006DCCE File Offset: 0x0006BECE
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt dayCookCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_dayCookCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_dayCookCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004272 RID: 17010
			// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00328C54 File Offset: 0x00326E54
			// (set) Token: 0x0600CCD4 RID: 52436 RVA: 0x0006DCED File Offset: 0x0006BEED
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat cookSpdMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_cookSpdMultiplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_cookSpdMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004273 RID: 17011
			// (get) Token: 0x0600CCD5 RID: 52437 RVA: 0x00328C84 File Offset: 0x00326E84
			// (set) Token: 0x0600CCD6 RID: 52438 RVA: 0x0006DD0C File Offset: 0x0006BF0C
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat moveSpdMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_moveSpdMultiplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_moveSpdMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004274 RID: 17012
			// (get) Token: 0x0600CCD7 RID: 52439 RVA: 0x00328CB4 File Offset: 0x00326EB4
			// (set) Token: 0x0600CCD8 RID: 52440 RVA: 0x0006DD2B File Offset: 0x0006BF2B
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat qteBuffTriggerProb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffTriggerProb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffTriggerProb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004275 RID: 17013
			// (get) Token: 0x0600CCD9 RID: 52441 RVA: 0x00328CE4 File Offset: 0x00326EE4
			// (set) Token: 0x0600CCDA RID: 52442 RVA: 0x0006DD4A File Offset: 0x0006BF4A
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat qteBuffLengthMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffLengthMultiplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_qteBuffLengthMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004276 RID: 17014
			// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x00328D14 File Offset: 0x00326F14
			// (set) Token: 0x0600CCDC RID: 52444 RVA: 0x0006DD69 File Offset: 0x0006BF69
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat doubleCollectionProb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_doubleCollectionProb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_doubleCollectionProb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004277 RID: 17015
			// (get) Token: 0x0600CCDD RID: 52445 RVA: 0x00328D44 File Offset: 0x00326F44
			// (set) Token: 0x0600CCDE RID: 52446 RVA: 0x0006DD88 File Offset: 0x0006BF88
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat shopPriceMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_shopPriceMultiplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_shopPriceMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004278 RID: 17016
			// (get) Token: 0x0600CCDF RID: 52447 RVA: 0x00328D74 File Offset: 0x00326F74
			// (set) Token: 0x0600CCE0 RID: 52448 RVA: 0x0006DDA7 File Offset: 0x0006BFA7
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt maxTray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxTray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_maxTray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004279 RID: 17017
			// (get) Token: 0x0600CCE1 RID: 52449 RVA: 0x00328DA4 File Offset: 0x00326FA4
			// (set) Token: 0x0600CCE2 RID: 52450 RVA: 0x0006DDC6 File Offset: 0x0006BFC6
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat additiveGuestPatient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestPatient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestPatient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427A RID: 17018
			// (get) Token: 0x0600CCE3 RID: 52451 RVA: 0x00328DD4 File Offset: 0x00326FD4
			// (set) Token: 0x0600CCE4 RID: 52452 RVA: 0x0006DDE5 File Offset: 0x0006BFE5
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat additiveGuestSpawnRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestSpawnRate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestSpawnRate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427B RID: 17019
			// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x00328E04 File Offset: 0x00327004
			// (set) Token: 0x0600CCE6 RID: 52454 RVA: 0x0006DE04 File Offset: 0x0006C004
			public unsafe DataBaseCore.LevelProperties.DiffPropertyInt additiveGuestBaseMood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestBaseMood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additiveGuestBaseMood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427C RID: 17020
			// (get) Token: 0x0600CCE7 RID: 52455 RVA: 0x00328E34 File Offset: 0x00327034
			// (set) Token: 0x0600CCE8 RID: 52456 RVA: 0x0006DE23 File Offset: 0x0006C023
			public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat additivePositiveBuffTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additivePositiveBuffTime);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_additivePositiveBuffTime), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427D RID: 17021
			// (get) Token: 0x0600CCE9 RID: 52457 RVA: 0x00328E64 File Offset: 0x00327064
			// (set) Token: 0x0600CCEA RID: 52458 RVA: 0x0006DE42 File Offset: 0x0006C042
			public unsafe Il2CppReferenceArray<DataBaseCore.LevelProperties.levelUnlockRecipe> unlockedRecipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_unlockedRecipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataBaseCore.LevelProperties.levelUnlockRecipe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr_unlockedRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700427E RID: 17022
			// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x00328E94 File Offset: 0x00327094
			// (set) Token: 0x0600CCEC RID: 52460 RVA: 0x0006DE61 File Offset: 0x0006C061
			public unsafe LinkedListNode<ValueTuple<int, DataBaseCore.LevelProperties>> _PropertyLinkedList_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr__PropertyLinkedList_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<ValueTuple<int, DataBaseCore.LevelProperties>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.NativeFieldInfoPtr__PropertyLinkedList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400837C RID: 33660
			private static readonly IntPtr NativeFieldInfoPtr_levelUpExp;

			// Token: 0x0400837D RID: 33661
			private static readonly IntPtr NativeFieldInfoPtr_startPassion;

			// Token: 0x0400837E RID: 33662
			private static readonly IntPtr NativeFieldInfoPtr_startTipRate;

			// Token: 0x0400837F RID: 33663
			private static readonly IntPtr NativeFieldInfoPtr_maxRecipes;

			// Token: 0x04008380 RID: 33664
			private static readonly IntPtr NativeFieldInfoPtr_maxBeverages;

			// Token: 0x04008381 RID: 33665
			private static readonly IntPtr NativeFieldInfoPtr_dayCookCount;

			// Token: 0x04008382 RID: 33666
			private static readonly IntPtr NativeFieldInfoPtr_cookSpdMultiplier;

			// Token: 0x04008383 RID: 33667
			private static readonly IntPtr NativeFieldInfoPtr_moveSpdMultiplier;

			// Token: 0x04008384 RID: 33668
			private static readonly IntPtr NativeFieldInfoPtr_qteBuffTriggerProb;

			// Token: 0x04008385 RID: 33669
			private static readonly IntPtr NativeFieldInfoPtr_qteBuffLengthMultiplier;

			// Token: 0x04008386 RID: 33670
			private static readonly IntPtr NativeFieldInfoPtr_doubleCollectionProb;

			// Token: 0x04008387 RID: 33671
			private static readonly IntPtr NativeFieldInfoPtr_shopPriceMultiplier;

			// Token: 0x04008388 RID: 33672
			private static readonly IntPtr NativeFieldInfoPtr_maxTray;

			// Token: 0x04008389 RID: 33673
			private static readonly IntPtr NativeFieldInfoPtr_additiveGuestPatient;

			// Token: 0x0400838A RID: 33674
			private static readonly IntPtr NativeFieldInfoPtr_additiveGuestSpawnRate;

			// Token: 0x0400838B RID: 33675
			private static readonly IntPtr NativeFieldInfoPtr_additiveGuestBaseMood;

			// Token: 0x0400838C RID: 33676
			private static readonly IntPtr NativeFieldInfoPtr_additivePositiveBuffTime;

			// Token: 0x0400838D RID: 33677
			private static readonly IntPtr NativeFieldInfoPtr_unlockedRecipes;

			// Token: 0x0400838E RID: 33678
			private static readonly IntPtr NativeFieldInfoPtr__PropertyLinkedList_k__BackingField;

			// Token: 0x0400838F RID: 33679
			private static readonly IntPtr NativeMethodInfoPtr_get_LevelUpExp_Public_get_Int32_0;

			// Token: 0x04008390 RID: 33680
			private static readonly IntPtr NativeMethodInfoPtr_get_BasePassion_Public_get_Int32_0;

			// Token: 0x04008391 RID: 33681
			private static readonly IntPtr NativeMethodInfoPtr_get_TipRate_Public_get_Single_0;

			// Token: 0x04008392 RID: 33682
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxDailyRecipe_Public_get_Int32_0;

			// Token: 0x04008393 RID: 33683
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxDailyBev_Public_get_Int32_0;

			// Token: 0x04008394 RID: 33684
			private static readonly IntPtr NativeMethodInfoPtr_get_DailyCookCount_Public_get_Int32_0;

			// Token: 0x04008395 RID: 33685
			private static readonly IntPtr NativeMethodInfoPtr_get_CookSpeedMultiplier_Public_get_Single_0;

			// Token: 0x04008396 RID: 33686
			private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0;

			// Token: 0x04008397 RID: 33687
			private static readonly IntPtr NativeMethodInfoPtr_get_QteBuffProb_Public_get_Single_0;

			// Token: 0x04008398 RID: 33688
			private static readonly IntPtr NativeMethodInfoPtr_get_QteBuffDurationMultiplier_Public_get_Single_0;

			// Token: 0x04008399 RID: 33689
			private static readonly IntPtr NativeMethodInfoPtr_get_DoubleCollectProb_Public_get_Single_0;

			// Token: 0x0400839A RID: 33690
			private static readonly IntPtr NativeMethodInfoPtr_get_MerchantPriceMultiplier_Public_get_Single_0;

			// Token: 0x0400839B RID: 33691
			private static readonly IntPtr NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0;

			// Token: 0x0400839C RID: 33692
			private static readonly IntPtr NativeMethodInfoPtr_get_ExtraGuestBaseMood_Public_get_Int32_0;

			// Token: 0x0400839D RID: 33693
			private static readonly IntPtr NativeMethodInfoPtr_get_ExtraGuestPatient_Public_get_Single_0;

			// Token: 0x0400839E RID: 33694
			private static readonly IntPtr NativeMethodInfoPtr_get_ExtraGuestSpawnRate_Public_get_Single_0;

			// Token: 0x0400839F RID: 33695
			private static readonly IntPtr NativeMethodInfoPtr_get_ExtraPositiveBuffTime_Public_get_Single_0;

			// Token: 0x040083A0 RID: 33696
			private static readonly IntPtr NativeMethodInfoPtr_get_UnlockedRecipes_Public_get_Il2CppReferenceArray_1_levelUnlockRecipe_0;

			// Token: 0x040083A1 RID: 33697
			private static readonly IntPtr NativeMethodInfoPtr_get_StartPassion_Public_get_DiffPropertyInt_0;

			// Token: 0x040083A2 RID: 33698
			private static readonly IntPtr NativeMethodInfoPtr_get_StartTipRate_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083A3 RID: 33699
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxRecipes_Public_get_DiffPropertyInt_0;

			// Token: 0x040083A4 RID: 33700
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxBeverages_Public_get_DiffPropertyInt_0;

			// Token: 0x040083A5 RID: 33701
			private static readonly IntPtr NativeMethodInfoPtr_get_DayCookCount_Public_get_DiffPropertyInt_0;

			// Token: 0x040083A6 RID: 33702
			private static readonly IntPtr NativeMethodInfoPtr_get_CookSpdMultiplier_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083A7 RID: 33703
			private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpdMultiplier_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083A8 RID: 33704
			private static readonly IntPtr NativeMethodInfoPtr_get_QteBuffTriggerProb_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083A9 RID: 33705
			private static readonly IntPtr NativeMethodInfoPtr_get_QteBuffLengthMultiplier_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083AA RID: 33706
			private static readonly IntPtr NativeMethodInfoPtr_get_DoubleCollectionProb_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083AB RID: 33707
			private static readonly IntPtr NativeMethodInfoPtr_get_ShopPriceMultiplier_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083AC RID: 33708
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxTray_Public_get_DiffPropertyInt_0;

			// Token: 0x040083AD RID: 33709
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveGuestPatient_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083AE RID: 33710
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveGuestSpawnRate_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083AF RID: 33711
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveGuestBaseMood_Public_get_DiffPropertyInt_0;

			// Token: 0x040083B0 RID: 33712
			private static readonly IntPtr NativeMethodInfoPtr_get_AdditivePositiveBuffTime_Public_get_DiffPropertyFloat_0;

			// Token: 0x040083B1 RID: 33713
			private static readonly IntPtr NativeMethodInfoPtr_get_PropertyLinkedList_Public_get_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0;

			// Token: 0x040083B2 RID: 33714
			private static readonly IntPtr NativeMethodInfoPtr_set_PropertyLinkedList_Public_set_Void_LinkedListNode_1_ValueTuple_2_Int32_LevelProperties_0;

			// Token: 0x040083B3 RID: 33715
			private static readonly IntPtr NativeMethodInfoPtr_GetValueInt_Private_Int32_Func_2_LevelProperties_DiffPropertyInt_0;

			// Token: 0x040083B4 RID: 33716
			private static readonly IntPtr NativeMethodInfoPtr_GetValueFloat_Private_Single_Func_2_LevelProperties_DiffPropertyFloat_0;

			// Token: 0x02001011 RID: 4113
			[Serializable]
			public class DiffPropertyInt : Il2CppSystem.Object
			{
				// Token: 0x060119BF RID: 72127 RVA: 0x00409DE0 File Offset: 0x00407FE0
				// Note: this type is marked as 'beforefieldinit'.
				static DiffPropertyInt()
				{
					Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "DiffPropertyInt");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr);
					DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr, "value");
					DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_hasDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr, "hasDiff");
					DataBaseCore.LevelProperties.DiffPropertyInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr, 100677522);
					DataBaseCore.LevelProperties.DiffPropertyInt.NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr, 100677523);
				}

				// Token: 0x060119C0 RID: 72128 RVA: 0x00409E5C File Offset: 0x0040805C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186326, XrefRangeEnd = 186327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DiffPropertyInt(int value, bool hasDiff) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyInt>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDiff;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.DiffPropertyInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060119C1 RID: 72129 RVA: 0x00409EB4 File Offset: 0x004080B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186327, XrefRangeEnd = 186331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public new unsafe static implicit operator DataBaseCore.LevelProperties.DiffPropertyInt(int left)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref left;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.DiffPropertyInt.NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyInt_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119C2 RID: 72130 RVA: 0x00099209 File Offset: 0x00097409
				public DiffPropertyInt(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B95 RID: 23445
				// (get) Token: 0x060119C3 RID: 72131 RVA: 0x00409EF4 File Offset: 0x004080F4
				// (set) Token: 0x060119C4 RID: 72132 RVA: 0x00099212 File Offset: 0x00097412
				public unsafe int value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_value);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_value)) = value;
					}
				}

				// Token: 0x17005B96 RID: 23446
				// (get) Token: 0x060119C5 RID: 72133 RVA: 0x00409F1C File Offset: 0x0040811C
				// (set) Token: 0x060119C6 RID: 72134 RVA: 0x0009922D File Offset: 0x0009742D
				public unsafe bool hasDiff
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_hasDiff);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyInt.NativeFieldInfoPtr_hasDiff)) = value;
					}
				}

				// Token: 0x0400B205 RID: 45573
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x0400B206 RID: 45574
				private static readonly IntPtr NativeFieldInfoPtr_hasDiff;

				// Token: 0x0400B207 RID: 45575
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

				// Token: 0x0400B208 RID: 45576
				private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyInt_Int32_0;
			}

			// Token: 0x02001012 RID: 4114
			[Serializable]
			public class DiffPropertyFloat : Il2CppSystem.Object
			{
				// Token: 0x060119C7 RID: 72135 RVA: 0x00409F44 File Offset: 0x00408144
				// Note: this type is marked as 'beforefieldinit'.
				static DiffPropertyFloat()
				{
					Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "DiffPropertyFloat");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr);
					DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr, "value");
					DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_hasDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr, "hasDiff");
					DataBaseCore.LevelProperties.DiffPropertyFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr, 100677524);
					DataBaseCore.LevelProperties.DiffPropertyFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr, 100677525);
				}

				// Token: 0x060119C8 RID: 72136 RVA: 0x00409FC0 File Offset: 0x004081C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186331, XrefRangeEnd = 186332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DiffPropertyFloat(float value, bool hasDiff) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.LevelProperties.DiffPropertyFloat>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasDiff;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060119C9 RID: 72137 RVA: 0x0040A018 File Offset: 0x00408218
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186332, XrefRangeEnd = 186336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public new unsafe static implicit operator DataBaseCore.LevelProperties.DiffPropertyFloat(float left)
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref left;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyFloat_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119CA RID: 72138 RVA: 0x00099248 File Offset: 0x00097448
				public DiffPropertyFloat(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B97 RID: 23447
				// (get) Token: 0x060119CB RID: 72139 RVA: 0x0040A058 File Offset: 0x00408258
				// (set) Token: 0x060119CC RID: 72140 RVA: 0x00099251 File Offset: 0x00097451
				public unsafe float value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_value);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_value)) = value;
					}
				}

				// Token: 0x17005B98 RID: 23448
				// (get) Token: 0x060119CD RID: 72141 RVA: 0x0040A080 File Offset: 0x00408280
				// (set) Token: 0x060119CE RID: 72142 RVA: 0x0009926C File Offset: 0x0009746C
				public unsafe bool hasDiff
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_hasDiff);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.DiffPropertyFloat.NativeFieldInfoPtr_hasDiff)) = value;
					}
				}

				// Token: 0x0400B209 RID: 45577
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x0400B20A RID: 45578
				private static readonly IntPtr NativeFieldInfoPtr_hasDiff;

				// Token: 0x0400B20B RID: 45579
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

				// Token: 0x0400B20C RID: 45580
				private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DiffPropertyFloat_Single_0;
			}

			// Token: 0x02001013 RID: 4115
			[Serializable]
			public sealed class levelUnlockRecipe : ValueType
			{
				// Token: 0x060119CF RID: 72143 RVA: 0x0040A0A8 File Offset: 0x004082A8
				// Note: this type is marked as 'beforefieldinit'.
				static levelUnlockRecipe()
				{
					Il2CppClassPointerStore<DataBaseCore.LevelProperties.levelUnlockRecipe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "levelUnlockRecipe");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.LevelProperties.levelUnlockRecipe>.NativeClassPtr);
					DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.levelUnlockRecipe>.NativeClassPtr, "recipe");
					DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_frontMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.levelUnlockRecipe>.NativeClassPtr, "frontMap");
				}

				// Token: 0x060119D0 RID: 72144 RVA: 0x00099287 File Offset: 0x00097487
				public levelUnlockRecipe(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060119D1 RID: 72145 RVA: 0x00099290 File Offset: 0x00097490
				public levelUnlockRecipe() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.LevelProperties.levelUnlockRecipe>.NativeClassPtr))
				{
				}

				// Token: 0x17005B99 RID: 23449
				// (get) Token: 0x060119D2 RID: 72146 RVA: 0x0040A0FC File Offset: 0x004082FC
				// (set) Token: 0x060119D3 RID: 72147 RVA: 0x000992A2 File Offset: 0x000974A2
				public unsafe int recipe
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_recipe);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_recipe)) = value;
					}
				}

				// Token: 0x17005B9A RID: 23450
				// (get) Token: 0x060119D4 RID: 72148 RVA: 0x0040A124 File Offset: 0x00408324
				// (set) Token: 0x060119D5 RID: 72149 RVA: 0x000992BD File Offset: 0x000974BD
				public unsafe string frontMap
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_frontMap);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.LevelProperties.levelUnlockRecipe.NativeFieldInfoPtr_frontMap), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400B20D RID: 45581
				private static readonly IntPtr NativeFieldInfoPtr_recipe;

				// Token: 0x0400B20E RID: 45582
				private static readonly IntPtr NativeFieldInfoPtr_frontMap;
			}

			// Token: 0x02001014 RID: 4116
			[ObfuscatedName("GameData.Core.Collections.DataBaseCore+LevelProperties+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060119D6 RID: 72150 RVA: 0x0040A14C File Offset: 0x0040834C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr);
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__21_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__23_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__25_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__27_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__29_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__31_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__33_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__35_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__37_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__39_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__41_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__43_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__45_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__47_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__49_0");
					DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, "<>9__51_0");
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677527);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_BasePassion_b__21_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677528);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_TipRate_b__23_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677529);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MaxDailyRecipe_b__25_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677530);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MaxDailyBev_b__27_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677531);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_DailyCookCount_b__29_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677532);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_CookSpeedMultiplier_b__31_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677533);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MoveSpeedMultiplier_b__33_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677534);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_QteBuffProb_b__35_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677535);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_QteBuffDurationMultiplier_b__37_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677536);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_DoubleCollectProb_b__39_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677537);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MerchantPriceMultiplier_b__41_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677538);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_TrayMaxNum_b__43_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677539);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestBaseMood_b__45_0_Internal_DiffPropertyInt_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677540);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestPatient_b__47_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677541);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestSpawnRate_b__49_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677542);
					DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraPositiveBuffTime_b__51_0_Internal_DiffPropertyFloat_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr, 100677543);
				}

				// Token: 0x060119D7 RID: 72151 RVA: 0x0040A420 File Offset: 0x00408620
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.LevelProperties.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060119D8 RID: 72152 RVA: 0x0040A45C File Offset: 0x0040865C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_BasePassion_b__21_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_BasePassion_b__21_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119D9 RID: 72153 RVA: 0x0040A4B4 File Offset: 0x004086B4
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_TipRate_b__23_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_TipRate_b__23_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119DA RID: 72154 RVA: 0x0040A50C File Offset: 0x0040870C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_MaxDailyRecipe_b__25_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MaxDailyRecipe_b__25_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119DB RID: 72155 RVA: 0x0040A564 File Offset: 0x00408764
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_MaxDailyBev_b__27_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MaxDailyBev_b__27_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119DC RID: 72156 RVA: 0x0040A5BC File Offset: 0x004087BC
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_DailyCookCount_b__29_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_DailyCookCount_b__29_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119DD RID: 72157 RVA: 0x0040A614 File Offset: 0x00408814
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_CookSpeedMultiplier_b__31_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_CookSpeedMultiplier_b__31_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119DE RID: 72158 RVA: 0x0040A66C File Offset: 0x0040886C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_MoveSpeedMultiplier_b__33_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MoveSpeedMultiplier_b__33_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119DF RID: 72159 RVA: 0x0040A6C4 File Offset: 0x004088C4
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_QteBuffProb_b__35_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_QteBuffProb_b__35_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E0 RID: 72160 RVA: 0x0040A71C File Offset: 0x0040891C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_QteBuffDurationMultiplier_b__37_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_QteBuffDurationMultiplier_b__37_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E1 RID: 72161 RVA: 0x0040A774 File Offset: 0x00408974
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_DoubleCollectProb_b__39_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_DoubleCollectProb_b__39_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E2 RID: 72162 RVA: 0x0040A7CC File Offset: 0x004089CC
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_MerchantPriceMultiplier_b__41_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_MerchantPriceMultiplier_b__41_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E3 RID: 72163 RVA: 0x0040A824 File Offset: 0x00408A24
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_TrayMaxNum_b__43_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_TrayMaxNum_b__43_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119E4 RID: 72164 RVA: 0x0040A87C File Offset: 0x00408A7C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyInt _get_ExtraGuestBaseMood_b__45_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestBaseMood_b__45_0_Internal_DiffPropertyInt_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyInt>(intPtr3) : null;
				}

				// Token: 0x060119E5 RID: 72165 RVA: 0x0040A8D4 File Offset: 0x00408AD4
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_ExtraGuestPatient_b__47_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestPatient_b__47_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E6 RID: 72166 RVA: 0x0040A92C File Offset: 0x00408B2C
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_ExtraGuestSpawnRate_b__49_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraGuestSpawnRate_b__49_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E7 RID: 72167 RVA: 0x0040A984 File Offset: 0x00408B84
				[CallerCount(0)]
				public unsafe DataBaseCore.LevelProperties.DiffPropertyFloat _get_ExtraPositiveBuffTime_b__51_0(DataBaseCore.LevelProperties x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.LevelProperties.__c.NativeMethodInfoPtr__get_ExtraPositiveBuffTime_b__51_0_Internal_DiffPropertyFloat_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.DiffPropertyFloat>(intPtr3) : null;
				}

				// Token: 0x060119E8 RID: 72168 RVA: 0x000992DC File Offset: 0x000974DC
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B9B RID: 23451
				// (get) Token: 0x060119E9 RID: 72169 RVA: 0x0040A9DC File Offset: 0x00408BDC
				// (set) Token: 0x060119EA RID: 72170 RVA: 0x000992E5 File Offset: 0x000974E5
				public unsafe static DataBaseCore.LevelProperties.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.LevelProperties.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B9C RID: 23452
				// (get) Token: 0x060119EB RID: 72171 RVA: 0x0040AA04 File Offset: 0x00408C04
				// (set) Token: 0x060119EC RID: 72172 RVA: 0x000992F7 File Offset: 0x000974F7
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__21_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B9D RID: 23453
				// (get) Token: 0x060119ED RID: 72173 RVA: 0x0040AA2C File Offset: 0x00408C2C
				// (set) Token: 0x060119EE RID: 72174 RVA: 0x00099309 File Offset: 0x00097509
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__23_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B9E RID: 23454
				// (get) Token: 0x060119EF RID: 72175 RVA: 0x0040AA54 File Offset: 0x00408C54
				// (set) Token: 0x060119F0 RID: 72176 RVA: 0x0009931B File Offset: 0x0009751B
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__25_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B9F RID: 23455
				// (get) Token: 0x060119F1 RID: 72177 RVA: 0x0040AA7C File Offset: 0x00408C7C
				// (set) Token: 0x060119F2 RID: 72178 RVA: 0x0009932D File Offset: 0x0009752D
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__27_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA0 RID: 23456
				// (get) Token: 0x060119F3 RID: 72179 RVA: 0x0040AAA4 File Offset: 0x00408CA4
				// (set) Token: 0x060119F4 RID: 72180 RVA: 0x0009933F File Offset: 0x0009753F
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__29_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA1 RID: 23457
				// (get) Token: 0x060119F5 RID: 72181 RVA: 0x0040AACC File Offset: 0x00408CCC
				// (set) Token: 0x060119F6 RID: 72182 RVA: 0x00099351 File Offset: 0x00097551
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__31_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA2 RID: 23458
				// (get) Token: 0x060119F7 RID: 72183 RVA: 0x0040AAF4 File Offset: 0x00408CF4
				// (set) Token: 0x060119F8 RID: 72184 RVA: 0x00099363 File Offset: 0x00097563
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__33_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA3 RID: 23459
				// (get) Token: 0x060119F9 RID: 72185 RVA: 0x0040AB1C File Offset: 0x00408D1C
				// (set) Token: 0x060119FA RID: 72186 RVA: 0x00099375 File Offset: 0x00097575
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__35_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA4 RID: 23460
				// (get) Token: 0x060119FB RID: 72187 RVA: 0x0040AB44 File Offset: 0x00408D44
				// (set) Token: 0x060119FC RID: 72188 RVA: 0x00099387 File Offset: 0x00097587
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__37_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA5 RID: 23461
				// (get) Token: 0x060119FD RID: 72189 RVA: 0x0040AB6C File Offset: 0x00408D6C
				// (set) Token: 0x060119FE RID: 72190 RVA: 0x00099399 File Offset: 0x00097599
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__39_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA6 RID: 23462
				// (get) Token: 0x060119FF RID: 72191 RVA: 0x0040AB94 File Offset: 0x00408D94
				// (set) Token: 0x06011A00 RID: 72192 RVA: 0x000993AB File Offset: 0x000975AB
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__41_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA7 RID: 23463
				// (get) Token: 0x06011A01 RID: 72193 RVA: 0x0040ABBC File Offset: 0x00408DBC
				// (set) Token: 0x06011A02 RID: 72194 RVA: 0x000993BD File Offset: 0x000975BD
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__43_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA8 RID: 23464
				// (get) Token: 0x06011A03 RID: 72195 RVA: 0x0040ABE4 File Offset: 0x00408DE4
				// (set) Token: 0x06011A04 RID: 72196 RVA: 0x000993CF File Offset: 0x000975CF
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> __9__45_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BA9 RID: 23465
				// (get) Token: 0x06011A05 RID: 72197 RVA: 0x0040AC0C File Offset: 0x00408E0C
				// (set) Token: 0x06011A06 RID: 72198 RVA: 0x000993E1 File Offset: 0x000975E1
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__47_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BAA RID: 23466
				// (get) Token: 0x06011A07 RID: 72199 RVA: 0x0040AC34 File Offset: 0x00408E34
				// (set) Token: 0x06011A08 RID: 72200 RVA: 0x000993F3 File Offset: 0x000975F3
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__49_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BAB RID: 23467
				// (get) Token: 0x06011A09 RID: 72201 RVA: 0x0040AC5C File Offset: 0x00408E5C
				// (set) Token: 0x06011A0A RID: 72202 RVA: 0x00099405 File Offset: 0x00097605
				public unsafe static Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> __9__51_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DataBaseCore.LevelProperties.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B20F RID: 45583
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B210 RID: 45584
				private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

				// Token: 0x0400B211 RID: 45585
				private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

				// Token: 0x0400B212 RID: 45586
				private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

				// Token: 0x0400B213 RID: 45587
				private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

				// Token: 0x0400B214 RID: 45588
				private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

				// Token: 0x0400B215 RID: 45589
				private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

				// Token: 0x0400B216 RID: 45590
				private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

				// Token: 0x0400B217 RID: 45591
				private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

				// Token: 0x0400B218 RID: 45592
				private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

				// Token: 0x0400B219 RID: 45593
				private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

				// Token: 0x0400B21A RID: 45594
				private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

				// Token: 0x0400B21B RID: 45595
				private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

				// Token: 0x0400B21C RID: 45596
				private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

				// Token: 0x0400B21D RID: 45597
				private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

				// Token: 0x0400B21E RID: 45598
				private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

				// Token: 0x0400B21F RID: 45599
				private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

				// Token: 0x0400B220 RID: 45600
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B221 RID: 45601
				private static readonly IntPtr NativeMethodInfoPtr__get_BasePassion_b__21_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B222 RID: 45602
				private static readonly IntPtr NativeMethodInfoPtr__get_TipRate_b__23_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B223 RID: 45603
				private static readonly IntPtr NativeMethodInfoPtr__get_MaxDailyRecipe_b__25_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B224 RID: 45604
				private static readonly IntPtr NativeMethodInfoPtr__get_MaxDailyBev_b__27_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B225 RID: 45605
				private static readonly IntPtr NativeMethodInfoPtr__get_DailyCookCount_b__29_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B226 RID: 45606
				private static readonly IntPtr NativeMethodInfoPtr__get_CookSpeedMultiplier_b__31_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B227 RID: 45607
				private static readonly IntPtr NativeMethodInfoPtr__get_MoveSpeedMultiplier_b__33_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B228 RID: 45608
				private static readonly IntPtr NativeMethodInfoPtr__get_QteBuffProb_b__35_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B229 RID: 45609
				private static readonly IntPtr NativeMethodInfoPtr__get_QteBuffDurationMultiplier_b__37_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B22A RID: 45610
				private static readonly IntPtr NativeMethodInfoPtr__get_DoubleCollectProb_b__39_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B22B RID: 45611
				private static readonly IntPtr NativeMethodInfoPtr__get_MerchantPriceMultiplier_b__41_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B22C RID: 45612
				private static readonly IntPtr NativeMethodInfoPtr__get_TrayMaxNum_b__43_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B22D RID: 45613
				private static readonly IntPtr NativeMethodInfoPtr__get_ExtraGuestBaseMood_b__45_0_Internal_DiffPropertyInt_LevelProperties_0;

				// Token: 0x0400B22E RID: 45614
				private static readonly IntPtr NativeMethodInfoPtr__get_ExtraGuestPatient_b__47_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B22F RID: 45615
				private static readonly IntPtr NativeMethodInfoPtr__get_ExtraGuestSpawnRate_b__49_0_Internal_DiffPropertyFloat_LevelProperties_0;

				// Token: 0x0400B230 RID: 45616
				private static readonly IntPtr NativeMethodInfoPtr__get_ExtraPositiveBuffTime_b__51_0_Internal_DiffPropertyFloat_LevelProperties_0;
			}
		}

		// Token: 0x02000AAB RID: 2731
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CCED RID: 52461 RVA: 0x00328EC4 File Offset: 0x003270C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr);
				DataBaseCore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_1");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_2");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_3");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_4");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_5");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_6");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_7");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_8");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_9");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_10");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_11");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_12");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_13");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_14");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_15");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_16");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_17");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_18");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_19");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_20");
				DataBaseCore.__c.NativeFieldInfoPtr___9__110_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__110_21");
				DataBaseCore.__c.NativeFieldInfoPtr___9__112_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__112_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__113_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__114_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__119_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__122_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__122_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__128_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__128_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__128_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__128_1");
				DataBaseCore.__c.NativeFieldInfoPtr___9__131_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__131_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__131_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__131_1");
				DataBaseCore.__c.NativeFieldInfoPtr___9__131_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__131_2");
				DataBaseCore.__c.NativeFieldInfoPtr___9__139_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__139_1");
				DataBaseCore.__c.NativeFieldInfoPtr___9__140_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__140_1");
				DataBaseCore.__c.NativeFieldInfoPtr___9__156_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__156_0");
				DataBaseCore.__c.NativeFieldInfoPtr___9__160_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, "<>9__160_0");
				DataBaseCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677545);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_0_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677546);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_1_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677547);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_2_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677548);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_3_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677549);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_4_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677550);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_5_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677551);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_6_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677552);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_7_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677553);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_8_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677554);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_9_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677555);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_10_Internal_ValueTuple_2_Int32_LevelProperties_KeyValuePair_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677556);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_11_Internal_Int32_ValueTuple_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677557);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_12_Internal_LevelProperties_ValueTuple_2_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677558);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_13_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677559);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_14_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677560);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_15_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677561);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_16_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677562);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_17_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677563);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_18_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677564);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_19_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677565);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_20_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677566);
				DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_21_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677567);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveIngredients_b__112_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677568);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveAndNotIgnoredIngredients_b__113_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677569);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveAndNotMissionIngredients_b__114_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677570);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllRecipesExceptDLCs_b__119_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677571);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllItemsExceptDefaultClothes_b__122_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677572);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllTrophies_b__128_0_Internal_Boolean_KeyValuePair_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677573);
				DataBaseCore.__c.NativeMethodInfoPtr__GetAllTrophies_b__128_1_Internal_Int32_KeyValuePair_2_Int32_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677574);
				DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_0_Internal_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677575);
				DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_1_Internal_Int32_IGrouping_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677576);
				DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_2_Internal_Int32_IGrouping_2_Int32_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677577);
				DataBaseCore.__c.NativeMethodInfoPtr__MatchRecipe_b__139_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677578);
				DataBaseCore.__c.NativeMethodInfoPtr__MatchFirstRecipe_b__140_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677579);
				DataBaseCore.__c.NativeMethodInfoPtr__GetIngredients_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677580);
				DataBaseCore.__c.NativeMethodInfoPtr__SolveTagPriority_b__160_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr, 100677581);
			}

			// Token: 0x0600CCEE RID: 52462 RVA: 0x003294B8 File Offset: 0x003276B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCEF RID: 52463 RVA: 0x003294F4 File Offset: 0x003276F4
			[CallerCount(0)]
			public unsafe Dictionary<int, Ingredient> _Initialize_b__110_0(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_0_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr3) : null;
			}

			// Token: 0x0600CCF0 RID: 52464 RVA: 0x00329544 File Offset: 0x00327744
			[CallerCount(0)]
			public unsafe Dictionary<int, Item> _Initialize_b__110_1(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_1_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr3) : null;
			}

			// Token: 0x0600CCF1 RID: 52465 RVA: 0x00329594 File Offset: 0x00327794
			[CallerCount(0)]
			public unsafe Dictionary<int, Badge> _Initialize_b__110_2(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_2_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr3) : null;
			}

			// Token: 0x0600CCF2 RID: 52466 RVA: 0x003295E4 File Offset: 0x003277E4
			[CallerCount(0)]
			public unsafe Dictionary<int, TrophiesProfile.Trophy> _Initialize_b__110_3(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_3_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr3) : null;
			}

			// Token: 0x0600CCF3 RID: 52467 RVA: 0x00329634 File Offset: 0x00327834
			[CallerCount(0)]
			public unsafe Dictionary<int, Sellable> _Initialize_b__110_4(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_4_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}

			// Token: 0x0600CCF4 RID: 52468 RVA: 0x00329684 File Offset: 0x00327884
			[CallerCount(0)]
			public unsafe Dictionary<int, Sellable> _Initialize_b__110_5(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_5_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}

			// Token: 0x0600CCF5 RID: 52469 RVA: 0x003296D4 File Offset: 0x003278D4
			[CallerCount(0)]
			public unsafe Dictionary<int, Recipe> _Initialize_b__110_6(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_6_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr3) : null;
			}

			// Token: 0x0600CCF6 RID: 52470 RVA: 0x00329724 File Offset: 0x00327924
			[CallerCount(0)]
			public unsafe IEnumerable<Il2CppStructArray<int>> _Initialize_b__110_7(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_7_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr3) : null;
			}

			// Token: 0x0600CCF7 RID: 52471 RVA: 0x00329774 File Offset: 0x00327974
			[CallerCount(0)]
			public unsafe Dictionary<int, Cooker> _Initialize_b__110_8(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_8_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr3) : null;
			}

			// Token: 0x0600CCF8 RID: 52472 RVA: 0x003297C4 File Offset: 0x003279C4
			[CallerCount(0)]
			public unsafe Dictionary<int, Izakaya> _Initialize_b__110_9(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_9_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr3) : null;
			}

			// Token: 0x0600CCF9 RID: 52473 RVA: 0x00329814 File Offset: 0x00327A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186732, XrefRangeEnd = 186738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, DataBaseCore.LevelProperties> _Initialize_b__110_10(KeyValuePair<int, DataBaseCore.LevelProperties> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_10_Internal_ValueTuple_2_Int32_LevelProperties_KeyValuePair_2_Int32_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, DataBaseCore.LevelProperties>(pointer);
			}

			// Token: 0x0600CCFA RID: 52474 RVA: 0x00329864 File Offset: 0x00327A64
			[CallerCount(0)]
			public unsafe int _Initialize_b__110_11(ValueTuple<int, DataBaseCore.LevelProperties> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_11_Internal_Int32_ValueTuple_2_Int32_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCFB RID: 52475 RVA: 0x003298B8 File Offset: 0x00327AB8
			[CallerCount(0)]
			public unsafe DataBaseCore.LevelProperties _Initialize_b__110_12(ValueTuple<int, DataBaseCore.LevelProperties> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_12_Internal_LevelProperties_ValueTuple_2_Int32_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DataBaseCore.LevelProperties(pointer);
			}

			// Token: 0x0600CCFC RID: 52476 RVA: 0x00329908 File Offset: 0x00327B08
			[CallerCount(0)]
			public unsafe Dictionary<int, Ingredient> _Initialize_b__110_13(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_13_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Ingredient>>(intPtr3) : null;
			}

			// Token: 0x0600CCFD RID: 52477 RVA: 0x00329958 File Offset: 0x00327B58
			[CallerCount(0)]
			public unsafe Dictionary<int, Sellable> _Initialize_b__110_14(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_14_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}

			// Token: 0x0600CCFE RID: 52478 RVA: 0x003299A8 File Offset: 0x00327BA8
			[CallerCount(0)]
			public unsafe Dictionary<int, Sellable> _Initialize_b__110_15(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_15_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Sellable>>(intPtr3) : null;
			}

			// Token: 0x0600CCFF RID: 52479 RVA: 0x003299F8 File Offset: 0x00327BF8
			[CallerCount(0)]
			public unsafe Dictionary<int, Recipe> _Initialize_b__110_16(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_16_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Recipe>>(intPtr3) : null;
			}

			// Token: 0x0600CD00 RID: 52480 RVA: 0x00329A48 File Offset: 0x00327C48
			[CallerCount(0)]
			public unsafe Dictionary<int, Cooker> _Initialize_b__110_17(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_17_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker>>(intPtr3) : null;
			}

			// Token: 0x0600CD01 RID: 52481 RVA: 0x00329A98 File Offset: 0x00327C98
			[CallerCount(0)]
			public unsafe Dictionary<int, Izakaya> _Initialize_b__110_18(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_18_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Izakaya>>(intPtr3) : null;
			}

			// Token: 0x0600CD02 RID: 52482 RVA: 0x00329AE8 File Offset: 0x00327CE8
			[CallerCount(0)]
			public unsafe Dictionary<int, Item> _Initialize_b__110_19(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_19_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Item>>(intPtr3) : null;
			}

			// Token: 0x0600CD03 RID: 52483 RVA: 0x00329B38 File Offset: 0x00327D38
			[CallerCount(0)]
			public unsafe Dictionary<int, Badge> _Initialize_b__110_20(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_20_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Badge>>(intPtr3) : null;
			}

			// Token: 0x0600CD04 RID: 52484 RVA: 0x00329B88 File Offset: 0x00327D88
			[CallerCount(0)]
			public unsafe Dictionary<int, TrophiesProfile.Trophy> _Initialize_b__110_21(DataBaseCore.DataBaseCoreData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__Initialize_b__110_21_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TrophiesProfile.Trophy>>(intPtr3) : null;
			}

			// Token: 0x0600CD05 RID: 52485 RVA: 0x00329BD8 File Offset: 0x00327DD8
			[CallerCount(0)]
			public unsafe bool _GetAllEffectiveIngredients_b__112_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveIngredients_b__112_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD06 RID: 52486 RVA: 0x00329C24 File Offset: 0x00327E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186738, XrefRangeEnd = 186740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllEffectiveAndNotIgnoredIngredients_b__113_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveAndNotIgnoredIngredients_b__113_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD07 RID: 52487 RVA: 0x00329C70 File Offset: 0x00327E70
			[CallerCount(0)]
			public unsafe bool _GetAllEffectiveAndNotMissionIngredients_b__114_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllEffectiveAndNotMissionIngredients_b__114_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD08 RID: 52488 RVA: 0x00329CBC File Offset: 0x00327EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186740, XrefRangeEnd = 186749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllRecipesExceptDLCs_b__119_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllRecipesExceptDLCs_b__119_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD09 RID: 52489 RVA: 0x00329D08 File Offset: 0x00327F08
			[CallerCount(0)]
			public unsafe bool _GetAllItemsExceptDefaultClothes_b__122_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllItemsExceptDefaultClothes_b__122_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0A RID: 52490 RVA: 0x00329D54 File Offset: 0x00327F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186749, XrefRangeEnd = 186762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTrophies_b__128_0(KeyValuePair<int, TrophiesProfile.Trophy> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllTrophies_b__128_0_Internal_Boolean_KeyValuePair_2_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0B RID: 52491 RVA: 0x00329DA8 File Offset: 0x00327FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186762, XrefRangeEnd = 186763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllTrophies_b__128_1(KeyValuePair<int, TrophiesProfile.Trophy> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetAllTrophies_b__128_1_Internal_Int32_KeyValuePair_2_Int32_Trophy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0C RID: 52492 RVA: 0x00329DFC File Offset: 0x00327FFC
			[CallerCount(0)]
			public unsafe int _GetIzakayasMusicPackageRecordCount_b__131_0(Record x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_0_Internal_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0D RID: 52493 RVA: 0x00329E4C File Offset: 0x0032804C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186763, XrefRangeEnd = 186767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetIzakayasMusicPackageRecordCount_b__131_1(IGrouping<int, Record> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_1_Internal_Int32_IGrouping_2_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0E RID: 52494 RVA: 0x00329E9C File Offset: 0x0032809C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186767, XrefRangeEnd = 186770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetIzakayasMusicPackageRecordCount_b__131_2(IGrouping<int, Record> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_2_Internal_Int32_IGrouping_2_Int32_Record_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0F RID: 52495 RVA: 0x00329EEC File Offset: 0x003280EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186770, XrefRangeEnd = 186771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _MatchRecipe_b__139_1(KeyValuePair<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__MatchRecipe_b__139_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600CD10 RID: 52496 RVA: 0x00329F44 File Offset: 0x00328144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186771, XrefRangeEnd = 186772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _MatchFirstRecipe_b__140_1(KeyValuePair<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__MatchFirstRecipe_b__140_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600CD11 RID: 52497 RVA: 0x00329F9C File Offset: 0x0032819C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186772, XrefRangeEnd = 186773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIngredients_b__156_0(KeyValuePair<int, Ingredient> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__GetIngredients_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD12 RID: 52498 RVA: 0x00329FF0 File Offset: 0x003281F0
			[CallerCount(0)]
			public unsafe int _SolveTagPriority_b__160_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c.NativeMethodInfoPtr__SolveTagPriority_b__160_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD13 RID: 52499 RVA: 0x0006DE80 File Offset: 0x0006C080
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A2 RID: 17058
			// (get) Token: 0x0600CD14 RID: 52500 RVA: 0x0032A03C File Offset: 0x0032823C
			// (set) Token: 0x0600CD15 RID: 52501 RVA: 0x0006DE89 File Offset: 0x0006C089
			public unsafe static DataBaseCore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseCore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A3 RID: 17059
			// (get) Token: 0x0600CD16 RID: 52502 RVA: 0x0032A064 File Offset: 0x00328264
			// (set) Token: 0x0600CD17 RID: 52503 RVA: 0x0006DE9B File Offset: 0x0006C09B
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Ingredient>> __9__110_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Ingredient>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A4 RID: 17060
			// (get) Token: 0x0600CD18 RID: 52504 RVA: 0x0032A08C File Offset: 0x0032828C
			// (set) Token: 0x0600CD19 RID: 52505 RVA: 0x0006DEAD File Offset: 0x0006C0AD
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Item>> __9__110_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Item>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0600CD1A RID: 52506 RVA: 0x0032A0B4 File Offset: 0x003282B4
			// (set) Token: 0x0600CD1B RID: 52507 RVA: 0x0006DEBF File Offset: 0x0006C0BF
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Badge>> __9__110_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Badge>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A6 RID: 17062
			// (get) Token: 0x0600CD1C RID: 52508 RVA: 0x0032A0DC File Offset: 0x003282DC
			// (set) Token: 0x0600CD1D RID: 52509 RVA: 0x0006DED1 File Offset: 0x0006C0D1
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, TrophiesProfile.Trophy>> __9__110_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, TrophiesProfile.Trophy>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A7 RID: 17063
			// (get) Token: 0x0600CD1E RID: 52510 RVA: 0x0032A104 File Offset: 0x00328304
			// (set) Token: 0x0600CD1F RID: 52511 RVA: 0x0006DEE3 File Offset: 0x0006C0E3
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>> __9__110_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A8 RID: 17064
			// (get) Token: 0x0600CD20 RID: 52512 RVA: 0x0032A12C File Offset: 0x0032832C
			// (set) Token: 0x0600CD21 RID: 52513 RVA: 0x0006DEF5 File Offset: 0x0006C0F5
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>> __9__110_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0600CD22 RID: 52514 RVA: 0x0032A154 File Offset: 0x00328354
			// (set) Token: 0x0600CD23 RID: 52515 RVA: 0x0006DF07 File Offset: 0x0006C107
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Recipe>> __9__110_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Recipe>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AA RID: 17066
			// (get) Token: 0x0600CD24 RID: 52516 RVA: 0x0032A17C File Offset: 0x0032837C
			// (set) Token: 0x0600CD25 RID: 52517 RVA: 0x0006DF19 File Offset: 0x0006C119
			public unsafe static Func<DataBaseCore.DataBaseCoreData, IEnumerable<Il2CppStructArray<int>>> __9__110_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, IEnumerable<Il2CppStructArray<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AB RID: 17067
			// (get) Token: 0x0600CD26 RID: 52518 RVA: 0x0032A1A4 File Offset: 0x003283A4
			// (set) Token: 0x0600CD27 RID: 52519 RVA: 0x0006DF2B File Offset: 0x0006C12B
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Cooker>> __9__110_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Cooker>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AC RID: 17068
			// (get) Token: 0x0600CD28 RID: 52520 RVA: 0x0032A1CC File Offset: 0x003283CC
			// (set) Token: 0x0600CD29 RID: 52521 RVA: 0x0006DF3D File Offset: 0x0006C13D
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Izakaya>> __9__110_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Izakaya>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AD RID: 17069
			// (get) Token: 0x0600CD2A RID: 52522 RVA: 0x0032A1F4 File Offset: 0x003283F4
			// (set) Token: 0x0600CD2B RID: 52523 RVA: 0x0006DF4F File Offset: 0x0006C14F
			public unsafe static Func<KeyValuePair<int, DataBaseCore.LevelProperties>, ValueTuple<int, DataBaseCore.LevelProperties>> __9__110_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, DataBaseCore.LevelProperties>, ValueTuple<int, DataBaseCore.LevelProperties>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AE RID: 17070
			// (get) Token: 0x0600CD2C RID: 52524 RVA: 0x0032A21C File Offset: 0x0032841C
			// (set) Token: 0x0600CD2D RID: 52525 RVA: 0x0006DF61 File Offset: 0x0006C161
			public unsafe static Func<ValueTuple<int, DataBaseCore.LevelProperties>, int> __9__110_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, DataBaseCore.LevelProperties>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AF RID: 17071
			// (get) Token: 0x0600CD2E RID: 52526 RVA: 0x0032A244 File Offset: 0x00328444
			// (set) Token: 0x0600CD2F RID: 52527 RVA: 0x0006DF73 File Offset: 0x0006C173
			public unsafe static Func<ValueTuple<int, DataBaseCore.LevelProperties>, DataBaseCore.LevelProperties> __9__110_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, DataBaseCore.LevelProperties>, DataBaseCore.LevelProperties>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B0 RID: 17072
			// (get) Token: 0x0600CD30 RID: 52528 RVA: 0x0032A26C File Offset: 0x0032846C
			// (set) Token: 0x0600CD31 RID: 52529 RVA: 0x0006DF85 File Offset: 0x0006C185
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Ingredient>> __9__110_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Ingredient>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B1 RID: 17073
			// (get) Token: 0x0600CD32 RID: 52530 RVA: 0x0032A294 File Offset: 0x00328494
			// (set) Token: 0x0600CD33 RID: 52531 RVA: 0x0006DF97 File Offset: 0x0006C197
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>> __9__110_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B2 RID: 17074
			// (get) Token: 0x0600CD34 RID: 52532 RVA: 0x0032A2BC File Offset: 0x003284BC
			// (set) Token: 0x0600CD35 RID: 52533 RVA: 0x0006DFA9 File Offset: 0x0006C1A9
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>> __9__110_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Sellable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B3 RID: 17075
			// (get) Token: 0x0600CD36 RID: 52534 RVA: 0x0032A2E4 File Offset: 0x003284E4
			// (set) Token: 0x0600CD37 RID: 52535 RVA: 0x0006DFBB File Offset: 0x0006C1BB
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Recipe>> __9__110_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Recipe>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B4 RID: 17076
			// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x0032A30C File Offset: 0x0032850C
			// (set) Token: 0x0600CD39 RID: 52537 RVA: 0x0006DFCD File Offset: 0x0006C1CD
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Cooker>> __9__110_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Cooker>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x0032A334 File Offset: 0x00328534
			// (set) Token: 0x0600CD3B RID: 52539 RVA: 0x0006DFDF File Offset: 0x0006C1DF
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Izakaya>> __9__110_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Izakaya>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x0032A35C File Offset: 0x0032855C
			// (set) Token: 0x0600CD3D RID: 52541 RVA: 0x0006DFF1 File Offset: 0x0006C1F1
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Item>> __9__110_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Item>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B7 RID: 17079
			// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x0032A384 File Offset: 0x00328584
			// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x0006E003 File Offset: 0x0006C203
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Badge>> __9__110_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, Badge>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B8 RID: 17080
			// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x0032A3AC File Offset: 0x003285AC
			// (set) Token: 0x0600CD41 RID: 52545 RVA: 0x0006E015 File Offset: 0x0006C215
			public unsafe static Func<DataBaseCore.DataBaseCoreData, Dictionary<int, TrophiesProfile.Trophy>> __9__110_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.DataBaseCoreData, Dictionary<int, TrophiesProfile.Trophy>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__110_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B9 RID: 17081
			// (get) Token: 0x0600CD42 RID: 52546 RVA: 0x0032A3D4 File Offset: 0x003285D4
			// (set) Token: 0x0600CD43 RID: 52547 RVA: 0x0006E027 File Offset: 0x0006C227
			public unsafe static Func<int, bool> __9__112_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__112_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__112_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BA RID: 17082
			// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x0032A3FC File Offset: 0x003285FC
			// (set) Token: 0x0600CD45 RID: 52549 RVA: 0x0006E039 File Offset: 0x0006C239
			public unsafe static Func<int, bool> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BB RID: 17083
			// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x0032A424 File Offset: 0x00328624
			// (set) Token: 0x0600CD47 RID: 52551 RVA: 0x0006E04B File Offset: 0x0006C24B
			public unsafe static Func<int, bool> __9__114_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__114_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__114_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BC RID: 17084
			// (get) Token: 0x0600CD48 RID: 52552 RVA: 0x0032A44C File Offset: 0x0032864C
			// (set) Token: 0x0600CD49 RID: 52553 RVA: 0x0006E05D File Offset: 0x0006C25D
			public unsafe static Func<int, bool> __9__119_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__119_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__119_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BD RID: 17085
			// (get) Token: 0x0600CD4A RID: 52554 RVA: 0x0032A474 File Offset: 0x00328674
			// (set) Token: 0x0600CD4B RID: 52555 RVA: 0x0006E06F File Offset: 0x0006C26F
			public unsafe static Func<int, bool> __9__122_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__122_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__122_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BE RID: 17086
			// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x0032A49C File Offset: 0x0032869C
			// (set) Token: 0x0600CD4D RID: 52557 RVA: 0x0006E081 File Offset: 0x0006C281
			public unsafe static Func<KeyValuePair<int, TrophiesProfile.Trophy>, bool> __9__128_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__128_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TrophiesProfile.Trophy>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__128_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BF RID: 17087
			// (get) Token: 0x0600CD4E RID: 52558 RVA: 0x0032A4C4 File Offset: 0x003286C4
			// (set) Token: 0x0600CD4F RID: 52559 RVA: 0x0006E093 File Offset: 0x0006C293
			public unsafe static Func<KeyValuePair<int, TrophiesProfile.Trophy>, int> __9__128_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__128_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TrophiesProfile.Trophy>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__128_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C0 RID: 17088
			// (get) Token: 0x0600CD50 RID: 52560 RVA: 0x0032A4EC File Offset: 0x003286EC
			// (set) Token: 0x0600CD51 RID: 52561 RVA: 0x0006E0A5 File Offset: 0x0006C2A5
			public unsafe static Func<Record, int> __9__131_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Record, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C1 RID: 17089
			// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x0032A514 File Offset: 0x00328714
			// (set) Token: 0x0600CD53 RID: 52563 RVA: 0x0006E0B7 File Offset: 0x0006C2B7
			public unsafe static Func<IGrouping<int, Record>, int> __9__131_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Record>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C2 RID: 17090
			// (get) Token: 0x0600CD54 RID: 52564 RVA: 0x0032A53C File Offset: 0x0032873C
			// (set) Token: 0x0600CD55 RID: 52565 RVA: 0x0006E0C9 File Offset: 0x0006C2C9
			public unsafe static Func<IGrouping<int, Record>, int> __9__131_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Record>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__131_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C3 RID: 17091
			// (get) Token: 0x0600CD56 RID: 52566 RVA: 0x0032A564 File Offset: 0x00328764
			// (set) Token: 0x0600CD57 RID: 52567 RVA: 0x0006E0DB File Offset: 0x0006C2DB
			public unsafe static Func<KeyValuePair<int, Recipe>, Recipe> __9__139_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__139_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Recipe>, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__139_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C4 RID: 17092
			// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x0032A58C File Offset: 0x0032878C
			// (set) Token: 0x0600CD59 RID: 52569 RVA: 0x0006E0ED File Offset: 0x0006C2ED
			public unsafe static Func<KeyValuePair<int, Recipe>, Recipe> __9__140_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__140_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Recipe>, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__140_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C5 RID: 17093
			// (get) Token: 0x0600CD5A RID: 52570 RVA: 0x0032A5B4 File Offset: 0x003287B4
			// (set) Token: 0x0600CD5B RID: 52571 RVA: 0x0006E0FF File Offset: 0x0006C2FF
			public unsafe static Func<KeyValuePair<int, Ingredient>, bool> __9__156_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__156_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Ingredient>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__156_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C6 RID: 17094
			// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x0032A5DC File Offset: 0x003287DC
			// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x0006E111 File Offset: 0x0006C311
			public unsafe static Func<int, int> __9__160_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseCore.__c.NativeFieldInfoPtr___9__160_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseCore.__c.NativeFieldInfoPtr___9__160_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040083B5 RID: 33717
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040083B6 RID: 33718
			private static readonly IntPtr NativeFieldInfoPtr___9__110_0;

			// Token: 0x040083B7 RID: 33719
			private static readonly IntPtr NativeFieldInfoPtr___9__110_1;

			// Token: 0x040083B8 RID: 33720
			private static readonly IntPtr NativeFieldInfoPtr___9__110_2;

			// Token: 0x040083B9 RID: 33721
			private static readonly IntPtr NativeFieldInfoPtr___9__110_3;

			// Token: 0x040083BA RID: 33722
			private static readonly IntPtr NativeFieldInfoPtr___9__110_4;

			// Token: 0x040083BB RID: 33723
			private static readonly IntPtr NativeFieldInfoPtr___9__110_5;

			// Token: 0x040083BC RID: 33724
			private static readonly IntPtr NativeFieldInfoPtr___9__110_6;

			// Token: 0x040083BD RID: 33725
			private static readonly IntPtr NativeFieldInfoPtr___9__110_7;

			// Token: 0x040083BE RID: 33726
			private static readonly IntPtr NativeFieldInfoPtr___9__110_8;

			// Token: 0x040083BF RID: 33727
			private static readonly IntPtr NativeFieldInfoPtr___9__110_9;

			// Token: 0x040083C0 RID: 33728
			private static readonly IntPtr NativeFieldInfoPtr___9__110_10;

			// Token: 0x040083C1 RID: 33729
			private static readonly IntPtr NativeFieldInfoPtr___9__110_11;

			// Token: 0x040083C2 RID: 33730
			private static readonly IntPtr NativeFieldInfoPtr___9__110_12;

			// Token: 0x040083C3 RID: 33731
			private static readonly IntPtr NativeFieldInfoPtr___9__110_13;

			// Token: 0x040083C4 RID: 33732
			private static readonly IntPtr NativeFieldInfoPtr___9__110_14;

			// Token: 0x040083C5 RID: 33733
			private static readonly IntPtr NativeFieldInfoPtr___9__110_15;

			// Token: 0x040083C6 RID: 33734
			private static readonly IntPtr NativeFieldInfoPtr___9__110_16;

			// Token: 0x040083C7 RID: 33735
			private static readonly IntPtr NativeFieldInfoPtr___9__110_17;

			// Token: 0x040083C8 RID: 33736
			private static readonly IntPtr NativeFieldInfoPtr___9__110_18;

			// Token: 0x040083C9 RID: 33737
			private static readonly IntPtr NativeFieldInfoPtr___9__110_19;

			// Token: 0x040083CA RID: 33738
			private static readonly IntPtr NativeFieldInfoPtr___9__110_20;

			// Token: 0x040083CB RID: 33739
			private static readonly IntPtr NativeFieldInfoPtr___9__110_21;

			// Token: 0x040083CC RID: 33740
			private static readonly IntPtr NativeFieldInfoPtr___9__112_0;

			// Token: 0x040083CD RID: 33741
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x040083CE RID: 33742
			private static readonly IntPtr NativeFieldInfoPtr___9__114_0;

			// Token: 0x040083CF RID: 33743
			private static readonly IntPtr NativeFieldInfoPtr___9__119_0;

			// Token: 0x040083D0 RID: 33744
			private static readonly IntPtr NativeFieldInfoPtr___9__122_0;

			// Token: 0x040083D1 RID: 33745
			private static readonly IntPtr NativeFieldInfoPtr___9__128_0;

			// Token: 0x040083D2 RID: 33746
			private static readonly IntPtr NativeFieldInfoPtr___9__128_1;

			// Token: 0x040083D3 RID: 33747
			private static readonly IntPtr NativeFieldInfoPtr___9__131_0;

			// Token: 0x040083D4 RID: 33748
			private static readonly IntPtr NativeFieldInfoPtr___9__131_1;

			// Token: 0x040083D5 RID: 33749
			private static readonly IntPtr NativeFieldInfoPtr___9__131_2;

			// Token: 0x040083D6 RID: 33750
			private static readonly IntPtr NativeFieldInfoPtr___9__139_1;

			// Token: 0x040083D7 RID: 33751
			private static readonly IntPtr NativeFieldInfoPtr___9__140_1;

			// Token: 0x040083D8 RID: 33752
			private static readonly IntPtr NativeFieldInfoPtr___9__156_0;

			// Token: 0x040083D9 RID: 33753
			private static readonly IntPtr NativeFieldInfoPtr___9__160_0;

			// Token: 0x040083DA RID: 33754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040083DB RID: 33755
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_0_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0;

			// Token: 0x040083DC RID: 33756
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_1_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0;

			// Token: 0x040083DD RID: 33757
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_2_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0;

			// Token: 0x040083DE RID: 33758
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_3_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0;

			// Token: 0x040083DF RID: 33759
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_4_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0;

			// Token: 0x040083E0 RID: 33760
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_5_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0;

			// Token: 0x040083E1 RID: 33761
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_6_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0;

			// Token: 0x040083E2 RID: 33762
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_7_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_DataBaseCoreData_0;

			// Token: 0x040083E3 RID: 33763
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_8_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0;

			// Token: 0x040083E4 RID: 33764
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_9_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0;

			// Token: 0x040083E5 RID: 33765
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_10_Internal_ValueTuple_2_Int32_LevelProperties_KeyValuePair_2_Int32_LevelProperties_0;

			// Token: 0x040083E6 RID: 33766
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_11_Internal_Int32_ValueTuple_2_Int32_LevelProperties_0;

			// Token: 0x040083E7 RID: 33767
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_12_Internal_LevelProperties_ValueTuple_2_Int32_LevelProperties_0;

			// Token: 0x040083E8 RID: 33768
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_13_Internal_Dictionary_2_Int32_Ingredient_DataBaseCoreData_0;

			// Token: 0x040083E9 RID: 33769
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_14_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0;

			// Token: 0x040083EA RID: 33770
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_15_Internal_Dictionary_2_Int32_Sellable_DataBaseCoreData_0;

			// Token: 0x040083EB RID: 33771
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_16_Internal_Dictionary_2_Int32_Recipe_DataBaseCoreData_0;

			// Token: 0x040083EC RID: 33772
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_17_Internal_Dictionary_2_Int32_Cooker_DataBaseCoreData_0;

			// Token: 0x040083ED RID: 33773
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_18_Internal_Dictionary_2_Int32_Izakaya_DataBaseCoreData_0;

			// Token: 0x040083EE RID: 33774
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_19_Internal_Dictionary_2_Int32_Item_DataBaseCoreData_0;

			// Token: 0x040083EF RID: 33775
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_20_Internal_Dictionary_2_Int32_Badge_DataBaseCoreData_0;

			// Token: 0x040083F0 RID: 33776
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__110_21_Internal_Dictionary_2_Int32_Trophy_DataBaseCoreData_0;

			// Token: 0x040083F1 RID: 33777
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEffectiveIngredients_b__112_0_Internal_Boolean_Int32_0;

			// Token: 0x040083F2 RID: 33778
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEffectiveAndNotIgnoredIngredients_b__113_0_Internal_Boolean_Int32_0;

			// Token: 0x040083F3 RID: 33779
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEffectiveAndNotMissionIngredients_b__114_0_Internal_Boolean_Int32_0;

			// Token: 0x040083F4 RID: 33780
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecipesExceptDLCs_b__119_0_Internal_Boolean_Int32_0;

			// Token: 0x040083F5 RID: 33781
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItemsExceptDefaultClothes_b__122_0_Internal_Boolean_Int32_0;

			// Token: 0x040083F6 RID: 33782
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrophies_b__128_0_Internal_Boolean_KeyValuePair_2_Int32_Trophy_0;

			// Token: 0x040083F7 RID: 33783
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrophies_b__128_1_Internal_Int32_KeyValuePair_2_Int32_Trophy_0;

			// Token: 0x040083F8 RID: 33784
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_0_Internal_Int32_Record_0;

			// Token: 0x040083F9 RID: 33785
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_1_Internal_Int32_IGrouping_2_Int32_Record_0;

			// Token: 0x040083FA RID: 33786
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayasMusicPackageRecordCount_b__131_2_Internal_Int32_IGrouping_2_Int32_Record_0;

			// Token: 0x040083FB RID: 33787
			private static readonly IntPtr NativeMethodInfoPtr__MatchRecipe_b__139_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0;

			// Token: 0x040083FC RID: 33788
			private static readonly IntPtr NativeMethodInfoPtr__MatchFirstRecipe_b__140_1_Internal_Recipe_KeyValuePair_2_Int32_Recipe_0;

			// Token: 0x040083FD RID: 33789
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredients_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Ingredient_0;

			// Token: 0x040083FE RID: 33790
			private static readonly IntPtr NativeMethodInfoPtr__SolveTagPriority_b__160_0_Internal_Int32_Int32_0;
		}

		// Token: 0x02000AAC RID: 2732
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD5E RID: 52574 RVA: 0x0032A604 File Offset: 0x00328804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr);
				DataBaseCore.__c__DisplayClass139_0.NativeFieldInfoPtr_foodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr, "foodId");
				DataBaseCore.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr, 100677582);
				DataBaseCore.__c__DisplayClass139_0.NativeMethodInfoPtr__MatchRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr, 100677583);
			}

			// Token: 0x0600CD5F RID: 52575 RVA: 0x0032A66C File Offset: 0x0032886C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD60 RID: 52576 RVA: 0x0032A6A8 File Offset: 0x003288A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186773, XrefRangeEnd = 186774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchRecipe_b__0(KeyValuePair<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass139_0.NativeMethodInfoPtr__MatchRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD61 RID: 52577 RVA: 0x0006E123 File Offset: 0x0006C323
			public __c__DisplayClass139_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C7 RID: 17095
			// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x0032A6FC File Offset: 0x003288FC
			// (set) Token: 0x0600CD63 RID: 52579 RVA: 0x0006E12C File Offset: 0x0006C32C
			public unsafe int foodId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass139_0.NativeFieldInfoPtr_foodId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass139_0.NativeFieldInfoPtr_foodId)) = value;
				}
			}

			// Token: 0x040083FF RID: 33791
			private static readonly IntPtr NativeFieldInfoPtr_foodId;

			// Token: 0x04008400 RID: 33792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008401 RID: 33793
			private static readonly IntPtr NativeMethodInfoPtr__MatchRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0;
		}

		// Token: 0x02000AAD RID: 2733
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c__DisplayClass140_0")]
		public sealed class __c__DisplayClass140_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD64 RID: 52580 RVA: 0x0032A724 File Offset: 0x00328924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass140_0()
			{
				Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c__DisplayClass140_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr);
				DataBaseCore.__c__DisplayClass140_0.NativeFieldInfoPtr_foodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr, "foodId");
				DataBaseCore.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr, 100677584);
				DataBaseCore.__c__DisplayClass140_0.NativeMethodInfoPtr__MatchFirstRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr, 100677585);
			}

			// Token: 0x0600CD65 RID: 52581 RVA: 0x0032A78C File Offset: 0x0032898C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass140_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass140_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD66 RID: 52582 RVA: 0x0032A7C8 File Offset: 0x003289C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186774, XrefRangeEnd = 186775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchFirstRecipe_b__0(KeyValuePair<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass140_0.NativeMethodInfoPtr__MatchFirstRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD67 RID: 52583 RVA: 0x0006E147 File Offset: 0x0006C347
			public __c__DisplayClass140_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C8 RID: 17096
			// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x0032A81C File Offset: 0x00328A1C
			// (set) Token: 0x0600CD69 RID: 52585 RVA: 0x0006E150 File Offset: 0x0006C350
			public unsafe int foodId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass140_0.NativeFieldInfoPtr_foodId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass140_0.NativeFieldInfoPtr_foodId)) = value;
				}
			}

			// Token: 0x04008402 RID: 33794
			private static readonly IntPtr NativeFieldInfoPtr_foodId;

			// Token: 0x04008403 RID: 33795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008404 RID: 33796
			private static readonly IntPtr NativeMethodInfoPtr__MatchFirstRecipe_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0;
		}

		// Token: 0x02000AAE RID: 2734
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c__DisplayClass155_0")]
		public sealed class __c__DisplayClass155_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD6A RID: 52586 RVA: 0x0032A844 File Offset: 0x00328A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass155_0()
			{
				Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c__DisplayClass155_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr);
				DataBaseCore.__c__DisplayClass155_0.NativeFieldInfoPtr_foodData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr, "foodData");
				DataBaseCore.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr, 100677586);
				DataBaseCore.__c__DisplayClass155_0.NativeMethodInfoPtr__TryMatchRecipe_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr, 100677587);
			}

			// Token: 0x0600CD6B RID: 52587 RVA: 0x0032A8AC File Offset: 0x00328AAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass155_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass155_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD6C RID: 52588 RVA: 0x0032A8E8 File Offset: 0x00328AE8
			[CallerCount(0)]
			public unsafe bool _TryMatchRecipe_b__0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass155_0.NativeMethodInfoPtr__TryMatchRecipe_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD6D RID: 52589 RVA: 0x0006E16B File Offset: 0x0006C36B
			public __c__DisplayClass155_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C9 RID: 17097
			// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x0032A938 File Offset: 0x00328B38
			// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x0006E174 File Offset: 0x0006C374
			public unsafe Sellable foodData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass155_0.NativeFieldInfoPtr_foodData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass155_0.NativeFieldInfoPtr_foodData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008405 RID: 33797
			private static readonly IntPtr NativeFieldInfoPtr_foodData;

			// Token: 0x04008406 RID: 33798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008407 RID: 33799
			private static readonly IntPtr NativeMethodInfoPtr__TryMatchRecipe_b__0_Internal_Boolean_Recipe_0;
		}

		// Token: 0x02000AAF RID: 2735
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c__DisplayClass159_0")]
		public sealed class __c__DisplayClass159_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD70 RID: 52592 RVA: 0x0032A968 File Offset: 0x00328B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass159_0()
			{
				Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c__DisplayClass159_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr);
				DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_cookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr, "cookerType");
				DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_obtained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr, "obtained");
				DataBaseCore.__c__DisplayClass159_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr, 100677588);
				DataBaseCore.__c__DisplayClass159_0.NativeMethodInfoPtr__FindUnObtainedRecipes_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr, 100677589);
			}

			// Token: 0x0600CD71 RID: 52593 RVA: 0x0032A9E4 File Offset: 0x00328BE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass159_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass159_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass159_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD72 RID: 52594 RVA: 0x0032AA20 File Offset: 0x00328C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186775, XrefRangeEnd = 186779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindUnObtainedRecipes_b__0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass159_0.NativeMethodInfoPtr__FindUnObtainedRecipes_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD73 RID: 52595 RVA: 0x0006E193 File Offset: 0x0006C393
			public __c__DisplayClass159_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CA RID: 17098
			// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x0032AA70 File Offset: 0x00328C70
			// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x0006E19C File Offset: 0x0006C39C
			public unsafe IEnumerable<Cooker.CookerType> cookerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_cookerType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_cookerType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CB RID: 17099
			// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x0032AAA0 File Offset: 0x00328CA0
			// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x0006E1BB File Offset: 0x0006C3BB
			public unsafe Il2CppReferenceArray<Recipe> obtained
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_obtained);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass159_0.NativeFieldInfoPtr_obtained), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008408 RID: 33800
			private static readonly IntPtr NativeFieldInfoPtr_cookerType;

			// Token: 0x04008409 RID: 33801
			private static readonly IntPtr NativeFieldInfoPtr_obtained;

			// Token: 0x0400840A RID: 33802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400840B RID: 33803
			private static readonly IntPtr NativeMethodInfoPtr__FindUnObtainedRecipes_b__0_Internal_Boolean_Recipe_0;
		}

		// Token: 0x02000AB0 RID: 2736
		[ObfuscatedName("GameData.Core.Collections.DataBaseCore+<>c__DisplayClass160_0")]
		public sealed class __c__DisplayClass160_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD78 RID: 52600 RVA: 0x0032AAD0 File Offset: 0x00328CD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass160_0()
			{
				Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseCore>.NativeClassPtr, "<>c__DisplayClass160_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr);
				DataBaseCore.__c__DisplayClass160_0.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr, "tag");
				DataBaseCore.__c__DisplayClass160_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr, 100677590);
				DataBaseCore.__c__DisplayClass160_0.NativeMethodInfoPtr__SolveTagPriority_b__1_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr, 100677591);
			}

			// Token: 0x0600CD79 RID: 52601 RVA: 0x0032AB38 File Offset: 0x00328D38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass160_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseCore.__c__DisplayClass160_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass160_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD7A RID: 52602 RVA: 0x0032AB74 File Offset: 0x00328D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186779, XrefRangeEnd = 186783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SolveTagPriority_b__1(KeyValuePair<int, Il2CppStructArray<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseCore.__c__DisplayClass160_0.NativeMethodInfoPtr__SolveTagPriority_b__1_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD7B RID: 52603 RVA: 0x0006E1DA File Offset: 0x0006C3DA
			public __c__DisplayClass160_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CC RID: 17100
			// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x0032ABC8 File Offset: 0x00328DC8
			// (set) Token: 0x0600CD7D RID: 52605 RVA: 0x0006E1E3 File Offset: 0x0006C3E3
			public unsafe int tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass160_0.NativeFieldInfoPtr_tag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseCore.__c__DisplayClass160_0.NativeFieldInfoPtr_tag)) = value;
				}
			}

			// Token: 0x0400840C RID: 33804
			private static readonly IntPtr NativeFieldInfoPtr_tag;

			// Token: 0x0400840D RID: 33805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400840E RID: 33806
			private static readonly IntPtr NativeMethodInfoPtr__SolveTagPriority_b__1_Internal_Boolean_KeyValuePair_2_Int32_Il2CppStructArray_1_Int32_0;
		}
	}
}
