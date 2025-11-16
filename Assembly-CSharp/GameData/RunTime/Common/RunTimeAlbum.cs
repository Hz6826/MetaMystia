using System;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace GameData.RunTime.Common
{
	// Token: 0x0200022D RID: 557
	public static class RunTimeAlbum : Object
	{
		// Token: 0x060042B7 RID: 17079 RVA: 0x00183348 File Offset: 0x00181548
		// Note: this type is marked as 'beforefieldinit'.
		static RunTimeAlbum()
		{
			Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "RunTimeAlbum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr);
			RunTimeAlbum.NativeFieldInfoPtr_DEFAULT_IZAKAYA_SKIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "DEFAULT_IZAKAYA_SKIN");
			RunTimeAlbum.NativeFieldInfoPtr_nightBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "nightBGM");
			RunTimeAlbum.NativeFieldInfoPtr_nightBGMIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "nightBGMIndex");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewNormalGuestAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewNormalGuestAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewSpecialGuestAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewSpecialGuestAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestTagUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestTagUpdated");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestIzakayaUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestIzakayaUpdated");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestInfoUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestInfoUpdated");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestKizunaFull");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestKizunaUpgrade");
			RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnSpecialGuestKizunaChanged");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewFoodAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewFoodAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewBeverageAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewBeverageAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewIngredientAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewIngredientAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewCookerAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewCookerAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewItemAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewItemAdd");
			RunTimeAlbum.NativeFieldInfoPtr_OnNewBadgeAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "OnNewBadgeAdd");
			RunTimeAlbum.NativeFieldInfoPtr__NormalGuests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<NormalGuests>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Foods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Foods>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Beverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Beverages>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Ingredients_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Ingredients>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Cookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Cookers>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Items>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__Badges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<Badges>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__HistoryCollectables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<HistoryCollectables>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__UsedDecorations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<UsedDecorations>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__UseCurrentSkinAtNight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<UseCurrentSkinAtNight>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__UseSpecialShopSkinAtNight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<UseSpecialShopSkinAtNight>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__IngCollectCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<IngCollectCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__UnsatisfiedTagCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<UnsatisfiedTagCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__EvictGuestsCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<EvictGuestsCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__CookingCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<CookingCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__StrongBuyAndSellCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<StrongBuyAndSellCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__RewardSpellTriggerCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<RewardSpellTriggerCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__PunishmentSpellTriggerCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<PunishmentSpellTriggerCount>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__CurrentPlayerSkin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<CurrentPlayerSkin>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr__EffectiveSGuestMappingRules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<EffectiveSGuestMappingRules>k__BackingField");
			RunTimeAlbum.NativeFieldInfoPtr_RecordedSpecialNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "RecordedSpecialNPCs");
			RunTimeAlbum.NativeFieldInfoPtr_s_ExceptItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "s_ExceptItems");
			RunTimeAlbum.NativeMethodInfoPtr_get_NormalGuests_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100675999);
			RunTimeAlbum.NativeMethodInfoPtr_set_NormalGuests_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676000);
			RunTimeAlbum.NativeMethodInfoPtr_get_Foods_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676001);
			RunTimeAlbum.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676002);
			RunTimeAlbum.NativeMethodInfoPtr_get_Beverages_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676003);
			RunTimeAlbum.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676004);
			RunTimeAlbum.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676005);
			RunTimeAlbum.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676006);
			RunTimeAlbum.NativeMethodInfoPtr_get_Cookers_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676007);
			RunTimeAlbum.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676008);
			RunTimeAlbum.NativeMethodInfoPtr_get_Items_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676009);
			RunTimeAlbum.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676010);
			RunTimeAlbum.NativeMethodInfoPtr_get_Badges_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676011);
			RunTimeAlbum.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676012);
			RunTimeAlbum.NativeMethodInfoPtr_get_HistoryCollectables_Private_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676013);
			RunTimeAlbum.NativeMethodInfoPtr_set_HistoryCollectables_Private_Static_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676014);
			RunTimeAlbum.NativeMethodInfoPtr_get_UsedDecorations_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676015);
			RunTimeAlbum.NativeMethodInfoPtr_set_UsedDecorations_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676016);
			RunTimeAlbum.NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676017);
			RunTimeAlbum.NativeMethodInfoPtr_set_UseCurrentSkinAtNight_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676018);
			RunTimeAlbum.NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676019);
			RunTimeAlbum.NativeMethodInfoPtr_set_UseSpecialShopSkinAtNight_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676020);
			RunTimeAlbum.NativeMethodInfoPtr_get_IngCollectCount_Public_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676021);
			RunTimeAlbum.NativeMethodInfoPtr_set_IngCollectCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676022);
			RunTimeAlbum.NativeMethodInfoPtr_get_UnsatisfiedTagCount_Public_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676023);
			RunTimeAlbum.NativeMethodInfoPtr_set_UnsatisfiedTagCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676024);
			RunTimeAlbum.NativeMethodInfoPtr_get_EvictGuestsCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676025);
			RunTimeAlbum.NativeMethodInfoPtr_set_EvictGuestsCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676026);
			RunTimeAlbum.NativeMethodInfoPtr_get_CookingCount_Public_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676027);
			RunTimeAlbum.NativeMethodInfoPtr_set_CookingCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676028);
			RunTimeAlbum.NativeMethodInfoPtr_get_StrongBuyAndSellCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676029);
			RunTimeAlbum.NativeMethodInfoPtr_set_StrongBuyAndSellCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676030);
			RunTimeAlbum.NativeMethodInfoPtr_get_RewardSpellTriggerCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676031);
			RunTimeAlbum.NativeMethodInfoPtr_set_RewardSpellTriggerCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676032);
			RunTimeAlbum.NativeMethodInfoPtr_get_PunishmentSpellTriggerCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676033);
			RunTimeAlbum.NativeMethodInfoPtr_set_PunishmentSpellTriggerCount_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676034);
			RunTimeAlbum.NativeMethodInfoPtr_get_CurrentPlayerSkin_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676035);
			RunTimeAlbum.NativeMethodInfoPtr_set_CurrentPlayerSkin_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676036);
			RunTimeAlbum.NativeMethodInfoPtr_get_EffectiveSGuestMappingRules_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676037);
			RunTimeAlbum.NativeMethodInfoPtr_set_EffectiveSGuestMappingRules_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676038);
			RunTimeAlbum.NativeMethodInfoPtr_ClassifyIngredientByType_Public_Static_Void_DataSource_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676039);
			RunTimeAlbum.NativeMethodInfoPtr_ClassifyIngredientByTypeCore_Private_Static_Void_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676040);
			RunTimeAlbum.NativeMethodInfoPtr_GetIngredientWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676041);
			RunTimeAlbum.NativeMethodInfoPtr_GetFoodWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676042);
			RunTimeAlbum.NativeMethodInfoPtr_GetBeverageWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676043);
			RunTimeAlbum.NativeMethodInfoPtr_GetCookerWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676044);
			RunTimeAlbum.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeAlbumSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676045);
			RunTimeAlbum.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeAlbumSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676046);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecord_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676047);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordNormalGuests_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676048);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordSpecialGuests_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676049);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordFoods_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676050);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordBeverages_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676051);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordIngredients_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676052);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordCookers_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676053);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordItems_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676054);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordBadges_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676055);
			RunTimeAlbum.NativeMethodInfoPtr_TrySetSpecialGuestSkin_Public_Static_Void_Int32_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676056);
			RunTimeAlbum.NativeMethodInfoPtr_HasSpecialNPCRecorded_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676057);
			RunTimeAlbum.NativeMethodInfoPtr_GetRecordHistoryCollectables_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676058);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordHistoryCollectables_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676059);
			RunTimeAlbum.NativeMethodInfoPtr_TryRecordUsedDecoration_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676060);
			RunTimeAlbum.NativeMethodInfoPtr_TryRemoveUsedDecoration_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676061);
			RunTimeAlbum.NativeMethodInfoPtr_ChangePlayerSkin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676062);
			RunTimeAlbum.NativeMethodInfoPtr_SetPlayerSkinDebugConsole_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676063);
			RunTimeAlbum.NativeMethodInfoPtr_GetRevealedData_Public_Static_Void_SpecialGuest_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676064);
			RunTimeAlbum.NativeMethodInfoPtr_RemoveRevealedData_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676065);
			RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676066);
			RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestHateFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676067);
			RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestBevTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676068);
			RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestIzakaya_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676069);
			RunTimeAlbum.NativeMethodInfoPtr_CheckAllRevealedDataIsUnlocked_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676070);
			RunTimeAlbum.NativeMethodInfoPtr_SetPositiveSpellCardNum_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676071);
			RunTimeAlbum.NativeMethodInfoPtr_SetNegativeSpellCardNum_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676072);
			RunTimeAlbum.NativeMethodInfoPtr_GetPositiveSpellCardNum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676073);
			RunTimeAlbum.NativeMethodInfoPtr_GetNegativeSpellCardNum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676074);
			RunTimeAlbum.NativeMethodInfoPtr_RecordPositiveSpellCardNum_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676075);
			RunTimeAlbum.NativeMethodInfoPtr_RecordNegativeSpellCardNum_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676076);
			RunTimeAlbum.NativeMethodInfoPtr_UpdateNegativeSpellCardTotalNum_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676077);
			RunTimeAlbum.NativeMethodInfoPtr_UpdatePositiveSpellCardTotalNum_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676078);
			RunTimeAlbum.NativeMethodInfoPtr_ClearSGuestAlbum_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676079);
			RunTimeAlbum.NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676080);
			RunTimeAlbum.NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676081);
			RunTimeAlbum.NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676082);
			RunTimeAlbum.NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676083);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedNormalGuests_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676084);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedSpecialGuests_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676085);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedFoodIds_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676086);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBeverageIds_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676087);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedIngredientIds_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676088);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedCookerIds_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676089);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedItemIds_Public_Static_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676090);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedFoods_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676091);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBeverages_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676092);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedIngredients_Public_Static_IEnumerable_1_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676093);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedCookers_Public_Static_IEnumerable_1_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676094);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedItems_Public_Static_IEnumerable_1_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676095);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBadges_Public_Static_IEnumerable_1_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676096);
			RunTimeAlbum.NativeMethodInfoPtr_GetAllUsingDecorations_Public_Static_IEnumerable_1_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676097);
			RunTimeAlbum.NativeMethodInfoPtr_CountNormalGuests_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676098);
			RunTimeAlbum.NativeMethodInfoPtr_CountSpecialGuests_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676099);
			RunTimeAlbum.NativeMethodInfoPtr_CountFoods_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676100);
			RunTimeAlbum.NativeMethodInfoPtr_CountBeverages_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676101);
			RunTimeAlbum.NativeMethodInfoPtr_CountIngredients_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676102);
			RunTimeAlbum.NativeMethodInfoPtr_CountCookers_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676103);
			RunTimeAlbum.NativeMethodInfoPtr_CountItems_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676104);
			RunTimeAlbum.NativeMethodInfoPtr_CountBadges_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676105);
			RunTimeAlbum.NativeMethodInfoPtr_GetPlayerClothes_Public_Static_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676106);
			RunTimeAlbum.NativeMethodInfoPtr_GetNightBGMId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676107);
			RunTimeAlbum.NativeMethodInfoPtr_SetNightBGMId_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676108);
			RunTimeAlbum.NativeMethodInfoPtr_GetNightBGMIndex_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676109);
			RunTimeAlbum.NativeMethodInfoPtr_SetNightBGMIndex_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676110);
			RunTimeAlbum.NativeMethodInfoPtr_PlayerSkinSet_Public_Static_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676111);
			RunTimeAlbum.NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676112);
			RunTimeAlbum.NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676113);
			RunTimeAlbum.NativeMethodInfoPtr_RefNormalPixel_Public_Static_CharacterSpriteSetCompact_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676114);
			RunTimeAlbum.NativeMethodInfoPtr_RefNormalPortrayal_Public_Static_CharacterPortrayal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676115);
			RunTimeAlbum.NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676116);
			RunTimeAlbum.NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676117);
			RunTimeAlbum.NativeMethodInfoPtr_RefSpecialNPCId_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676118);
			RunTimeAlbum.NativeMethodInfoPtr_GetLevelUpExpAmount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676119);
			RunTimeAlbum.NativeMethodInfoPtr_HasSpecialNPCKizunaExpFull_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676120);
			RunTimeAlbum.NativeMethodInfoPtr_HasDecorationUsing_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676121);
			RunTimeAlbum.NativeMethodInfoPtr_GetLevel5KizunaNPCData_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676122);
			RunTimeAlbum.NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676123);
			RunTimeAlbum.NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676124);
			RunTimeAlbum.NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676125);
			RunTimeAlbum.NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676126);
			RunTimeAlbum.NativeMethodInfoPtr_UpgradeOrGenerateSpecialNPCKizuna_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676127);
			RunTimeAlbum.NativeMethodInfoPtr_RefreshAllKizunaLevelUpdateData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676128);
			RunTimeAlbum.NativeMethodInfoPtr_UpdateAllStatusForSpecialNPC_Public_Static_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676129);
			RunTimeAlbum.NativeMethodInfoPtr_RefSpecialPixel_Public_Static_CharacterSpriteSetCompact_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676130);
			RunTimeAlbum.NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForKyouko_Private_Static_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676131);
			RunTimeAlbum.NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForSelf_Private_Static_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676132);
			RunTimeAlbum.NativeMethodInfoPtr_RefSpecialPortrayal_Public_Static_CharacterPortrayal_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676133);
			RunTimeAlbum.NativeMethodInfoPtr_RefSelfPixel_Public_Static_CharacterSpriteSetFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676134);
			RunTimeAlbum.NativeMethodInfoPtr_RefSelfPortrayal_Public_Static_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676135);
			RunTimeAlbum.NativeMethodInfoPtr_GetAlbumIngredientsOrderByDatabase_Public_Static_IEnumerable_1_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676136);
			RunTimeAlbum.NativeMethodInfoPtr_GetAlbumFoodsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676137);
			RunTimeAlbum.NativeMethodInfoPtr_GetAlbumBevsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676138);
			RunTimeAlbum.NativeMethodInfoPtr_IsBadgeRecoreded_Public_Static_Boolean_Badge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676139);
			RunTimeAlbum.NativeMethodInfoPtr_CheckSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676140);
			RunTimeAlbum.NativeMethodInfoPtr_CheckMappingSGuestOrigin_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676141);
			RunTimeAlbum.NativeMethodInfoPtr_AddSGuestMapping_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676142);
			RunTimeAlbum.NativeMethodInfoPtr_RemoveSGuestMapping_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676143);
			RunTimeAlbum.NativeMethodInfoPtr_ClearAndDumpPlayerSkinDataAsync_Public_Static_UniTask_byref_RuntimePlayerSkinDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676144);
			RunTimeAlbum.NativeMethodInfoPtr_CreatePlayerRuntimeSkinDataCache_Public_Static_RuntimePlayerSkinDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676145);
			RunTimeAlbum.NativeMethodInfoPtr_MountAndOverridePlayerSkinRuntimeData_Public_Static_UniTask_RuntimePlayerSkinDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676146);
			RunTimeAlbum.NativeMethodInfoPtr_ClearAndDumpRunTimeAlbumData_Public_Static_Void_byref_RuntimeAlbumCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676147);
			RunTimeAlbum.NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Private_Static_RuntimeAlbumCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676148);
			RunTimeAlbum.NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimeAlbumCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, 100676149);
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x00184250 File Offset: 0x00182450
		// (set) Token: 0x060042B9 RID: 17081 RVA: 0x00184284 File Offset: 0x00182484
		public unsafe static List<int> NormalGuests
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167690, XrefRangeEnd = 167694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_NormalGuests_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167694, XrefRangeEnd = 167700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_NormalGuests_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x001842BC File Offset: 0x001824BC
		// (set) Token: 0x060042BB RID: 17083 RVA: 0x001842F0 File Offset: 0x001824F0
		public unsafe static List<int> Foods
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167700, XrefRangeEnd = 167704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Foods_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167704, XrefRangeEnd = 167710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x00184328 File Offset: 0x00182528
		// (set) Token: 0x060042BD RID: 17085 RVA: 0x0018435C File Offset: 0x0018255C
		public unsafe static List<int> Beverages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167710, XrefRangeEnd = 167714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Beverages_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167714, XrefRangeEnd = 167720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x00184394 File Offset: 0x00182594
		// (set) Token: 0x060042BF RID: 17087 RVA: 0x001843C8 File Offset: 0x001825C8
		public unsafe static List<int> Ingredients
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167720, XrefRangeEnd = 167724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167724, XrefRangeEnd = 167730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x00184400 File Offset: 0x00182600
		// (set) Token: 0x060042C1 RID: 17089 RVA: 0x00184434 File Offset: 0x00182634
		public unsafe static List<int> Cookers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167730, XrefRangeEnd = 167734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Cookers_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167734, XrefRangeEnd = 167740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x0018446C File Offset: 0x0018266C
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x001844A0 File Offset: 0x001826A0
		public unsafe static List<int> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167740, XrefRangeEnd = 167744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Items_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167744, XrefRangeEnd = 167750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x001844D8 File Offset: 0x001826D8
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x0018450C File Offset: 0x0018270C
		public unsafe static List<int> Badges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167750, XrefRangeEnd = 167754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_Badges_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167754, XrefRangeEnd = 167760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x00184544 File Offset: 0x00182744
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x00184578 File Offset: 0x00182778
		public unsafe static List<string> HistoryCollectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167760, XrefRangeEnd = 167764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_HistoryCollectables_Private_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167764, XrefRangeEnd = 167770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_HistoryCollectables_Private_Static_set_Void_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x001845B0 File Offset: 0x001827B0
		// (set) Token: 0x060042C9 RID: 17097 RVA: 0x001845E4 File Offset: 0x001827E4
		public unsafe static List<int> UsedDecorations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167770, XrefRangeEnd = 167774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_UsedDecorations_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167774, XrefRangeEnd = 167780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_UsedDecorations_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x0018461C File Offset: 0x0018281C
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x0018464C File Offset: 0x0018284C
		public unsafe static bool UseCurrentSkinAtNight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167780, XrefRangeEnd = 167784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167784, XrefRangeEnd = 167788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_UseCurrentSkinAtNight_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x00184680 File Offset: 0x00182880
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x001846B0 File Offset: 0x001828B0
		public unsafe static bool UseSpecialShopSkinAtNight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167788, XrefRangeEnd = 167792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167792, XrefRangeEnd = 167796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_UseSpecialShopSkinAtNight_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x060042CE RID: 17102 RVA: 0x001846E4 File Offset: 0x001828E4
		// (set) Token: 0x060042CF RID: 17103 RVA: 0x00184718 File Offset: 0x00182918
		public unsafe static Dictionary<int, int> IngCollectCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167796, XrefRangeEnd = 167800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_IngCollectCount_Public_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167800, XrefRangeEnd = 167806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_IngCollectCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x00184750 File Offset: 0x00182950
		// (set) Token: 0x060042D1 RID: 17105 RVA: 0x00184784 File Offset: 0x00182984
		public unsafe static Dictionary<int, int> UnsatisfiedTagCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167806, XrefRangeEnd = 167810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_UnsatisfiedTagCount_Public_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167810, XrefRangeEnd = 167816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_UnsatisfiedTagCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x001847BC File Offset: 0x001829BC
		// (set) Token: 0x060042D3 RID: 17107 RVA: 0x001847EC File Offset: 0x001829EC
		public unsafe static int EvictGuestsCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167816, XrefRangeEnd = 167820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_EvictGuestsCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167820, XrefRangeEnd = 167824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_EvictGuestsCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x00184820 File Offset: 0x00182A20
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x00184854 File Offset: 0x00182A54
		public unsafe static Dictionary<int, int> CookingCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167824, XrefRangeEnd = 167828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_CookingCount_Public_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167828, XrefRangeEnd = 167834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_CookingCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0018488C File Offset: 0x00182A8C
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x001848BC File Offset: 0x00182ABC
		public unsafe static int StrongBuyAndSellCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167834, XrefRangeEnd = 167838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_StrongBuyAndSellCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167838, XrefRangeEnd = 167842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_StrongBuyAndSellCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x001848F0 File Offset: 0x00182AF0
		// (set) Token: 0x060042D9 RID: 17113 RVA: 0x00184920 File Offset: 0x00182B20
		public unsafe static int RewardSpellTriggerCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167842, XrefRangeEnd = 167846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_RewardSpellTriggerCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167846, XrefRangeEnd = 167850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_RewardSpellTriggerCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x00184954 File Offset: 0x00182B54
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x00184984 File Offset: 0x00182B84
		public unsafe static int PunishmentSpellTriggerCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167850, XrefRangeEnd = 167854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_PunishmentSpellTriggerCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167854, XrefRangeEnd = 167858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_PunishmentSpellTriggerCount_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x001849B8 File Offset: 0x00182BB8
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x001849E8 File Offset: 0x00182BE8
		public unsafe static int CurrentPlayerSkin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167858, XrefRangeEnd = 167862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_CurrentPlayerSkin_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167862, XrefRangeEnd = 167866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_CurrentPlayerSkin_Private_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x00184A1C File Offset: 0x00182C1C
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x00184A50 File Offset: 0x00182C50
		public unsafe static List<int> EffectiveSGuestMappingRules
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167866, XrefRangeEnd = 167870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_get_EffectiveSGuestMappingRules_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167870, XrefRangeEnd = 167876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_set_EffectiveSGuestMappingRules_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00184A88 File Offset: 0x00182C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 167912, RefRangeEnd = 167915, XrefRangeStart = 167876, XrefRangeEnd = 167912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClassifyIngredientByType(RunTimeAlbum.DataSource dataSource, List<KeyValuePair<Ingredient, int>> seaFood, List<KeyValuePair<Ingredient, int>> meat, List<KeyValuePair<Ingredient, int>> veggies, List<KeyValuePair<Ingredient, int>> other, Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>> filterFunc = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dataSource;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seaFood);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veggies);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ClassifyIngredientByType_Public_Static_Void_DataSource_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x00184B18 File Offset: 0x00182D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168114, RefRangeEnd = 168115, XrefRangeStart = 167915, XrefRangeEnd = 168114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClassifyIngredientByTypeCore(IEnumerable<KeyValuePair<Ingredient, int>> collection, List<KeyValuePair<Ingredient, int>> seaFood, List<KeyValuePair<Ingredient, int>> meat, List<KeyValuePair<Ingredient, int>> veggies, List<KeyValuePair<Ingredient, int>> other, Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>> filterFunc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seaFood);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meat);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veggies);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ClassifyIngredientByTypeCore_Private_Static_Void_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00184BAC File Offset: 0x00182DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168115, XrefRangeEnd = 168120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<Ingredient, int>> GetIngredientWithRecord()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetIngredientWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00184BE0 File Offset: 0x00182DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168120, XrefRangeEnd = 168125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<Sellable, int>> GetFoodWithRecord()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetFoodWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00184C14 File Offset: 0x00182E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168130, RefRangeEnd = 168131, XrefRangeStart = 168125, XrefRangeEnd = 168130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<Sellable, int>> GetBeverageWithRecord()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetBeverageWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00184C48 File Offset: 0x00182E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168131, XrefRangeEnd = 168136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<KeyValuePair<Cooker, int>> GetCookerWithRecord()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetCookerWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Cooker_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Cooker, int>>>(intPtr3) : null;
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x00184C7C File Offset: 0x00182E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168522, RefRangeEnd = 168523, XrefRangeStart = 168136, XrefRangeEnd = 168522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(PlayerSaveFile.RunTimeAlbumSaveDataPartial saveDataPartial, Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> saveDataDLCPartial)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(saveDataPartial));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(saveDataDLCPartial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeAlbumSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00184CCC File Offset: 0x00182ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168609, RefRangeEnd = 168610, XrefRangeStart = 168523, XrefRangeEnd = 168609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerSaveFile.RunTimeAlbumSaveDataPartial GenerateSaveData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeAlbumSaveDataPartial_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerSaveFile.RunTimeAlbumSaveDataPartial(pointer);
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00184CF8 File Offset: 0x00182EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168616, RefRangeEnd = 168617, XrefRangeStart = 168610, XrefRangeEnd = 168616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecord(this List<int> list, int value, Action<int> onRecordAction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRecordAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecord_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x00184D50 File Offset: 0x00182F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168631, RefRangeEnd = 168633, XrefRangeStart = 168617, XrefRangeEnd = 168631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordNormalGuests(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordNormalGuests_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00184D84 File Offset: 0x00182F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168637, RefRangeEnd = 168639, XrefRangeStart = 168633, XrefRangeEnd = 168637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordSpecialGuests(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordSpecialGuests_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x00184DB8 File Offset: 0x00182FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168653, RefRangeEnd = 168654, XrefRangeStart = 168639, XrefRangeEnd = 168653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordFoods(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordFoods_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x00184DEC File Offset: 0x00182FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168654, XrefRangeEnd = 168668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordBeverages(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordBeverages_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x00184E20 File Offset: 0x00183020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168668, XrefRangeEnd = 168677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordIngredients(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordIngredients_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x00184E54 File Offset: 0x00183054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168677, XrefRangeEnd = 168691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordCookers(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordCookers_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00184E88 File Offset: 0x00183088
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 168705, RefRangeEnd = 168713, XrefRangeStart = 168691, XrefRangeEnd = 168705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordItems(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordItems_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00184EBC File Offset: 0x001830BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168713, XrefRangeEnd = 168727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordBadges(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordBadges_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00184EF0 File Offset: 0x001830F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168750, RefRangeEnd = 168752, XrefRangeStart = 168727, XrefRangeEnd = 168750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrySetSpecialGuestSkin(int id, CharacterSkinSets.SkinSelectionInfo skinSelectionInfo)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skinSelectionInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TrySetSpecialGuestSkin_Public_Static_Void_Int32_SkinSelectionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00184F30 File Offset: 0x00183130
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 168760, RefRangeEnd = 168772, XrefRangeStart = 168752, XrefRangeEnd = 168760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpecialNPCRecorded(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_HasSpecialNPCRecorded_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00184F70 File Offset: 0x00183170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168783, RefRangeEnd = 168785, XrefRangeStart = 168772, XrefRangeEnd = 168783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetRecordHistoryCollectables()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetRecordHistoryCollectables_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00184FA4 File Offset: 0x001831A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168839, RefRangeEnd = 168840, XrefRangeStart = 168785, XrefRangeEnd = 168839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordHistoryCollectables(string collectableData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(collectableData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordHistoryCollectables_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00184FDC File Offset: 0x001831DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168871, RefRangeEnd = 168872, XrefRangeStart = 168840, XrefRangeEnd = 168871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRecordUsedDecoration(int decorationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref decorationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRecordUsedDecoration_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00185010 File Offset: 0x00183210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168883, RefRangeEnd = 168884, XrefRangeStart = 168872, XrefRangeEnd = 168883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRemoveUsedDecoration(int decorationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref decorationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_TryRemoveUsedDecoration_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00185044 File Offset: 0x00183244
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 168929, RefRangeEnd = 168934, XrefRangeStart = 168884, XrefRangeEnd = 168929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangePlayerSkin(int skinSelectionInfo)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skinSelectionInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ChangePlayerSkin_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00185078 File Offset: 0x00183278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168942, RefRangeEnd = 168944, XrefRangeStart = 168934, XrefRangeEnd = 168942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerSkinDebugConsole(int skinSelectionInfo)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skinSelectionInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetPlayerSkinDebugConsole_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x001850AC File Offset: 0x001832AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 168978, RefRangeEnd = 168982, XrefRangeStart = 168944, XrefRangeEnd = 168978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRevealedData(this SpecialGuest specialGuestData, out IEnumerable<int> revealedFoodTags, out IEnumerable<int> revealedHateFoodTags, out IEnumerable<int> revealedBevTags, out IEnumerable<int> revealedIzakaya)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuestData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetRevealedData_Public_Static_Void_SpecialGuest_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			revealedFoodTags = ((intPtr7 == 0) ? null : new IEnumerable<int>(intPtr7));
			IntPtr intPtr8 = intPtr2;
			revealedHateFoodTags = ((intPtr8 == 0) ? null : new IEnumerable<int>(intPtr8));
			IntPtr intPtr9 = intPtr3;
			revealedBevTags = ((intPtr9 == 0) ? null : new IEnumerable<int>(intPtr9));
			IntPtr intPtr10 = intPtr4;
			revealedIzakaya = ((intPtr10 == 0) ? null : new IEnumerable<int>(intPtr10));
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00185170 File Offset: 0x00183370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169057, RefRangeEnd = 169058, XrefRangeStart = 168982, XrefRangeEnd = 169057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveRevealedData(this int specialGuestId, int amount = 1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RemoveRevealedData_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x001851B0 File Offset: 0x001833B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 169121, RefRangeEnd = 169127, XrefRangeStart = 169058, XrefRangeEnd = 169121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSpecialGuestFoodTag(int specialGusetId, [Optional] Il2CppStructArray<int> foodTags)
		{
			if (foodTags == null)
			{
				foodTags = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foodTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00185204 File Offset: 0x00183404
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 169190, RefRangeEnd = 169194, XrefRangeStart = 169127, XrefRangeEnd = 169190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSpecialGuestHateFoodTag(int specialGusetId, [Optional] Il2CppStructArray<int> foodTags)
		{
			if (foodTags == null)
			{
				foodTags = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foodTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestHateFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00185258 File Offset: 0x00183458
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 169258, RefRangeEnd = 169263, XrefRangeStart = 169194, XrefRangeEnd = 169258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSpecialGuestBevTag(int specialGusetId, [Optional] Il2CppStructArray<int> bevTags)
		{
			if (bevTags == null)
			{
				bevTags = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bevTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestBevTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x001852AC File Offset: 0x001834AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169305, RefRangeEnd = 169306, XrefRangeStart = 169263, XrefRangeEnd = 169305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSpecialGuestIzakaya(int specialGusetId, int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordSpecialGuestIzakaya_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x001852EC File Offset: 0x001834EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 169365, RefRangeEnd = 169372, XrefRangeStart = 169306, XrefRangeEnd = 169365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckAllRevealedDataIsUnlocked(int specialGuestId, int checkType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CheckAllRevealedDataIsUnlocked_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00185338 File Offset: 0x00183538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169382, RefRangeEnd = 169385, XrefRangeStart = 169372, XrefRangeEnd = 169382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPositiveSpellCardNum(int specialGuestId, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetPositiveSpellCardNum_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00185378 File Offset: 0x00183578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169395, RefRangeEnd = 169396, XrefRangeStart = 169385, XrefRangeEnd = 169395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNegativeSpellCardNum(int specialGuestId, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetNegativeSpellCardNum_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x001853B8 File Offset: 0x001835B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169401, RefRangeEnd = 169403, XrefRangeStart = 169396, XrefRangeEnd = 169401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPositiveSpellCardNum(int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetPositiveSpellCardNum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x001853F8 File Offset: 0x001835F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169408, RefRangeEnd = 169410, XrefRangeStart = 169403, XrefRangeEnd = 169408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNegativeSpellCardNum(int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetNegativeSpellCardNum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00185438 File Offset: 0x00183638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169449, RefRangeEnd = 169450, XrefRangeStart = 169410, XrefRangeEnd = 169449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordPositiveSpellCardNum(int specialGusetId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordPositiveSpellCardNum_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0018546C File Offset: 0x0018366C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169489, RefRangeEnd = 169490, XrefRangeStart = 169450, XrefRangeEnd = 169489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordNegativeSpellCardNum(int specialGusetId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGusetId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RecordNegativeSpellCardNum_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x001854A0 File Offset: 0x001836A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169490, XrefRangeEnd = 169521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateNegativeSpellCardTotalNum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_UpdateNegativeSpellCardTotalNum_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x001854C8 File Offset: 0x001836C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169521, XrefRangeEnd = 169552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdatePositiveSpellCardTotalNum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_UpdatePositiveSpellCardTotalNum_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x001854F0 File Offset: 0x001836F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169560, RefRangeEnd = 169561, XrefRangeStart = 169552, XrefRangeEnd = 169560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSGuestAlbum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ClearSGuestAlbum_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00185518 File Offset: 0x00183718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169574, RefRangeEnd = 169575, XrefRangeStart = 169561, XrefRangeEnd = 169574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IfGuestHaveSpawnHere(int specialGuestId, int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00185564 File Offset: 0x00183764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169592, RefRangeEnd = 169593, XrefRangeStart = 169575, XrefRangeEnd = 169592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IfGuestHaveSpawnHere(string specialGuestLabel, int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(specialGuestLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x001855B4 File Offset: 0x001837B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 169610, RefRangeEnd = 169614, XrefRangeStart = 169593, XrefRangeEnd = 169610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGuestSpawnIzakayaId(int specialGuestId, int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x001855F4 File Offset: 0x001837F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169635, RefRangeEnd = 169636, XrefRangeStart = 169614, XrefRangeEnd = 169635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGuestSpawnIzakayaId(string specialGuestLabel, int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(specialGuestLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00185638 File Offset: 0x00183838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169644, RefRangeEnd = 169645, XrefRangeStart = 169636, XrefRangeEnd = 169644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecordedNormalGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedNormalGuests_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x0018566C File Offset: 0x0018386C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 169653, RefRangeEnd = 169672, XrefRangeStart = 169645, XrefRangeEnd = 169653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecordedSpecialGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedSpecialGuests_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x001856A0 File Offset: 0x001838A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169680, RefRangeEnd = 169681, XrefRangeStart = 169672, XrefRangeEnd = 169680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllRecordedFoodIds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedFoodIds_Public_Static_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x001856D4 File Offset: 0x001838D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169689, RefRangeEnd = 169690, XrefRangeStart = 169681, XrefRangeEnd = 169689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllRecordedBeverageIds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBeverageIds_Public_Static_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00185708 File Offset: 0x00183908
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169698, RefRangeEnd = 169701, XrefRangeStart = 169690, XrefRangeEnd = 169698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllRecordedIngredientIds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedIngredientIds_Public_Static_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x0018573C File Offset: 0x0018393C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169709, RefRangeEnd = 169710, XrefRangeStart = 169701, XrefRangeEnd = 169709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllRecordedCookerIds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedCookerIds_Public_Static_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00185770 File Offset: 0x00183970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169710, XrefRangeEnd = 169718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllRecordedItemIds()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedItemIds_Public_Static_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x001857A4 File Offset: 0x001839A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169744, RefRangeEnd = 169745, XrefRangeStart = 169718, XrefRangeEnd = 169744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetAllRecordedFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedFoods_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x001857D8 File Offset: 0x001839D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 169771, RefRangeEnd = 169776, XrefRangeStart = 169745, XrefRangeEnd = 169771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetAllRecordedBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBeverages_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x0018580C File Offset: 0x00183A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169802, RefRangeEnd = 169803, XrefRangeStart = 169776, XrefRangeEnd = 169802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Ingredient> GetAllRecordedIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedIngredients_Public_Static_IEnumerable_1_Ingredient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Ingredient>>(intPtr3) : null;
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00185840 File Offset: 0x00183A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169829, RefRangeEnd = 169830, XrefRangeStart = 169803, XrefRangeEnd = 169829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Cooker> GetAllRecordedCookers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedCookers_Public_Static_IEnumerable_1_Cooker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker>>(intPtr3) : null;
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00185874 File Offset: 0x00183A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169856, RefRangeEnd = 169857, XrefRangeStart = 169830, XrefRangeEnd = 169856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<NonTradableObjectBase> GetAllRecordedItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedItems_Public_Static_IEnumerable_1_NonTradableObjectBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NonTradableObjectBase>>(intPtr3) : null;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x001858A8 File Offset: 0x00183AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169857, XrefRangeEnd = 169883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Badge> GetAllRecordedBadges()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllRecordedBadges_Public_Static_IEnumerable_1_Badge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Badge>>(intPtr3) : null;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x001858DC File Offset: 0x00183ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169909, RefRangeEnd = 169911, XrefRangeStart = 169883, XrefRangeEnd = 169909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Decoration> GetAllUsingDecorations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAllUsingDecorations_Public_Static_IEnumerable_1_Decoration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Decoration>>(intPtr3) : null;
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00185910 File Offset: 0x00183B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169911, XrefRangeEnd = 169919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountNormalGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountNormalGuests_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00185940 File Offset: 0x00183B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169919, XrefRangeEnd = 169927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountSpecialGuests()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountSpecialGuests_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00185970 File Offset: 0x00183B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169935, RefRangeEnd = 169936, XrefRangeStart = 169927, XrefRangeEnd = 169935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountFoods_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x001859A0 File Offset: 0x00183BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169944, RefRangeEnd = 169945, XrefRangeStart = 169936, XrefRangeEnd = 169944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountBeverages_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x001859D0 File Offset: 0x00183BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169953, RefRangeEnd = 169954, XrefRangeStart = 169945, XrefRangeEnd = 169953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountIngredients_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00185A00 File Offset: 0x00183C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169962, RefRangeEnd = 169963, XrefRangeStart = 169954, XrefRangeEnd = 169962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountCookers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountCookers_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00185A30 File Offset: 0x00183C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169963, XrefRangeEnd = 169971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountItems_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00185A60 File Offset: 0x00183C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169971, XrefRangeEnd = 169979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountBadges()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CountBadges_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00185A90 File Offset: 0x00183C90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 169998, RefRangeEnd = 170004, XrefRangeStart = 169979, XrefRangeEnd = 169998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothesProfile.Clothes GetPlayerClothes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetPlayerClothes_Public_Static_Clothes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr3) : null;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00185AC4 File Offset: 0x00183CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170004, XrefRangeEnd = 170008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNightBGMId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetNightBGMId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00185AF4 File Offset: 0x00183CF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170019, RefRangeEnd = 170022, XrefRangeStart = 170008, XrefRangeEnd = 170019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNightBGMId(int musicPackageIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref musicPackageIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetNightBGMId_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00185B28 File Offset: 0x00183D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170022, XrefRangeEnd = 170026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNightBGMIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetNightBGMIndex_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00185B58 File Offset: 0x00183D58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170030, RefRangeEnd = 170033, XrefRangeStart = 170026, XrefRangeEnd = 170030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNightBGMIndex(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_SetNightBGMIndex_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00185B8C File Offset: 0x00183D8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170055, RefRangeEnd = 170058, XrefRangeStart = 170033, XrefRangeEnd = 170055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSkinSets.SkinSelectionInfo PlayerSkinSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_PlayerSkinSet_Public_Static_SkinSelectionInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00185BBC File Offset: 0x00183DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170082, RefRangeEnd = 170085, XrefRangeStart = 170058, XrefRangeEnd = 170082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCharacterKizuna(int characterId, out int maxExp, out int level)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxExp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00185C18 File Offset: 0x00183E18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170103, RefRangeEnd = 170107, XrefRangeStart = 170085, XrefRangeEnd = 170103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCharacterKizuna(string characterLabel, out int maxExp, out int level)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxExp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x00185C78 File Offset: 0x00183E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170114, RefRangeEnd = 170117, XrefRangeStart = 170107, XrefRangeEnd = 170114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSpriteSetCompact RefNormalPixel(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefNormalPixel_Public_Static_CharacterSpriteSetCompact_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00185CB8 File Offset: 0x00183EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170117, XrefRangeEnd = 170124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterPortrayal RefNormalPortrayal(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefNormalPortrayal_Public_Static_CharacterPortrayal_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00185CF8 File Offset: 0x00183EF8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 170157, RefRangeEnd = 170190, XrefRangeStart = 170124, XrefRangeEnd = 170157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunTimeAlbum.SpecialGuestRunTimeData RefOrGenerateSpecialRunTimeData(this int guestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.SpecialGuestRunTimeData>(intPtr3) : null;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x00185D38 File Offset: 0x00183F38
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 170195, RefRangeEnd = 170204, XrefRangeStart = 170190, XrefRangeEnd = 170195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunTimeAlbum.SpecialGuestRunTimeData RefOrGenerateSpecialRunTimeData(this string npcLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.SpecialGuestRunTimeData>(intPtr3) : null;
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x00185D7C File Offset: 0x00183F7C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 170205, RefRangeEnd = 170237, XrefRangeStart = 170204, XrefRangeEnd = 170205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RefSpecialNPCId(this string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefSpecialNPCId_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00185DC0 File Offset: 0x00183FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170237, RefRangeEnd = 170238, XrefRangeStart = 170237, XrefRangeEnd = 170237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLevelUpExpAmount(int currentLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetLevelUpExpAmount_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x00185E00 File Offset: 0x00184000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170250, RefRangeEnd = 170251, XrefRangeStart = 170238, XrefRangeEnd = 170250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSpecialNPCKizunaExpFull(int characterId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_HasSpecialNPCKizunaExpFull_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x00185E40 File Offset: 0x00184040
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170262, RefRangeEnd = 170266, XrefRangeStart = 170251, XrefRangeEnd = 170262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasDecorationUsing(int decorationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref decorationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_HasDecorationUsing_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x00185E80 File Offset: 0x00184080
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 170306, RefRangeEnd = 170311, XrefRangeStart = 170266, XrefRangeEnd = 170306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetLevel5KizunaNPCData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetLevel5KizunaNPCData_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x00185EB4 File Offset: 0x001840B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170319, RefRangeEnd = 170321, XrefRangeStart = 170311, XrefRangeEnd = 170319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOrGenerateSpecialNPCKizunaLevel(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00185EF8 File Offset: 0x001840F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170325, RefRangeEnd = 170327, XrefRangeStart = 170321, XrefRangeEnd = 170325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOrGenerateSpecialNPCKizunaLevel(int characterId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00185F38 File Offset: 0x00184138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170332, RefRangeEnd = 170335, XrefRangeStart = 170327, XrefRangeEnd = 170332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AlterOrGenerateSpecialNPCKizuna(string characterLabel, int kizunaAmount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kizunaAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00185F7C File Offset: 0x0018417C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 170444, RefRangeEnd = 170449, XrefRangeStart = 170335, XrefRangeEnd = 170444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AlterOrGenerateSpecialNPCKizuna(int characterId, int kizunaAmount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kizunaAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00185FBC File Offset: 0x001841BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170499, RefRangeEnd = 170502, XrefRangeStart = 170449, XrefRangeEnd = 170499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpgradeOrGenerateSpecialNPCKizuna(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_UpgradeOrGenerateSpecialNPCKizuna_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00185FF4 File Offset: 0x001841F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170570, RefRangeEnd = 170572, XrefRangeStart = 170502, XrefRangeEnd = 170570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshAllKizunaLevelUpdateData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefreshAllKizunaLevelUpdateData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0018601C File Offset: 0x0018421C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170584, RefRangeEnd = 170586, XrefRangeStart = 170572, XrefRangeEnd = 170584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAllStatusForSpecialNPC(SpecialGuest specialGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_UpdateAllStatusForSpecialNPC_Public_Static_Void_SpecialGuest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00186054 File Offset: 0x00184254
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 170610, RefRangeEnd = 170629, XrefRangeStart = 170586, XrefRangeEnd = 170610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSpriteSetCompact RefSpecialPixel(this int id, bool useDefaultSkin = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultSkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefSpecialPixel_Public_Static_CharacterSpriteSetCompact_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x001860A4 File Offset: 0x001842A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170636, RefRangeEnd = 170638, XrefRangeStart = 170629, XrefRangeEnd = 170636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> CalculateIfShouldLoadSpecialSkinForKyouko(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForKyouko_Private_Static_Nullable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<int>(pointer);
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001860DC File Offset: 0x001842DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170652, RefRangeEnd = 170655, XrefRangeStart = 170638, XrefRangeEnd = 170652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> CalculateIfShouldLoadSpecialSkinForSelf()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForSelf_Private_Static_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<int>(pointer);
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00186108 File Offset: 0x00184308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170679, RefRangeEnd = 170683, XrefRangeStart = 170655, XrefRangeEnd = 170679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterPortrayal RefSpecialPortrayal(this int id, bool useDefaultSkin = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultSkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefSpecialPortrayal_Public_Static_CharacterPortrayal_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00186158 File Offset: 0x00184358
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 170698, RefRangeEnd = 170705, XrefRangeStart = 170683, XrefRangeEnd = 170698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterSpriteSetFull RefSelfPixel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefSelfPixel_Public_Static_CharacterSpriteSetFull_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr3) : null;
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x0018618C File Offset: 0x0018438C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170718, RefRangeEnd = 170719, XrefRangeStart = 170705, XrefRangeEnd = 170718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterPortrayal RefSelfPortrayal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RefSelfPortrayal_Public_Static_CharacterPortrayal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x001861C0 File Offset: 0x001843C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170739, RefRangeEnd = 170741, XrefRangeStart = 170719, XrefRangeEnd = 170739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Ingredient> GetAlbumIngredientsOrderByDatabase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAlbumIngredientsOrderByDatabase_Public_Static_IEnumerable_1_Ingredient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Ingredient>>(intPtr3) : null;
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x001861F4 File Offset: 0x001843F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170761, RefRangeEnd = 170764, XrefRangeStart = 170741, XrefRangeEnd = 170761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetAlbumFoodsOrderByDatabase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAlbumFoodsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00186228 File Offset: 0x00184428
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170784, RefRangeEnd = 170787, XrefRangeStart = 170764, XrefRangeEnd = 170784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Sellable> GetAlbumBevsOrderByDatabase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_GetAlbumBevsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0018625C File Offset: 0x0018445C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170798, RefRangeEnd = 170799, XrefRangeStart = 170787, XrefRangeEnd = 170798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBadgeRecoreded(Badge badge)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(badge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_IsBadgeRecoreded_Public_Static_Boolean_Badge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x001862A0 File Offset: 0x001844A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170814, RefRangeEnd = 170816, XrefRangeStart = 170799, XrefRangeEnd = 170814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckSGuestMapping(int originGuest, out int mappingSGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originGuest;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mappingSGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CheckSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x001862EC File Offset: 0x001844EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170816, XrefRangeEnd = 170837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckMappingSGuestOrigin(int mappingSGuest, out int originalGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mappingSGuest;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &originalGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CheckMappingSGuestOrigin_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00186338 File Offset: 0x00184538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170867, RefRangeEnd = 170868, XrefRangeStart = 170837, XrefRangeEnd = 170867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSGuestMapping(int originGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_AddSGuestMapping_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0018636C File Offset: 0x0018456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170868, XrefRangeEnd = 170879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveSGuestMapping(int originGuest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originGuest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_RemoveSGuestMapping_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x001863A0 File Offset: 0x001845A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170916, RefRangeEnd = 170918, XrefRangeStart = 170879, XrefRangeEnd = 170916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask ClearAndDumpPlayerSkinDataAsync(out RunTimeAlbum.RuntimePlayerSkinDataCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr2;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ClearAndDumpPlayerSkinDataAsync_Public_Static_UniTask_byref_RuntimePlayerSkinDataCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			cache = ((intPtr3 == 0) ? null : new RunTimeAlbum.RuntimePlayerSkinDataCache(intPtr3));
			return new UniTask(pointer);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x001863F0 File Offset: 0x001845F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170918, XrefRangeEnd = 170937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunTimeAlbum.RuntimePlayerSkinDataCache CreatePlayerRuntimeSkinDataCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CreatePlayerRuntimeSkinDataCache_Public_Static_RuntimePlayerSkinDataCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.RuntimePlayerSkinDataCache>(intPtr3) : null;
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00186424 File Offset: 0x00184624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170937, XrefRangeEnd = 170954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask MountAndOverridePlayerSkinRuntimeData(RunTimeAlbum.RuntimePlayerSkinDataCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_MountAndOverridePlayerSkinRuntimeData_Public_Static_UniTask_RuntimePlayerSkinDataCache_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x00186460 File Offset: 0x00184660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171124, RefRangeEnd = 171126, XrefRangeStart = 170954, XrefRangeEnd = 171124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAndDumpRunTimeAlbumData(out RunTimeAlbum.RuntimeAlbumCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_ClearAndDumpRunTimeAlbumData_Public_Static_Void_byref_RuntimeAlbumCache_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new RunTimeAlbum.RuntimeAlbumCache(intPtr4));
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x001864A8 File Offset: 0x001846A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171183, RefRangeEnd = 171184, XrefRangeStart = 171126, XrefRangeEnd = 171183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunTimeAlbum.RuntimeAlbumCache CreatePlayerRuntimeDataCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Private_Static_RuntimeAlbumCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.RuntimeAlbumCache>(intPtr3) : null;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x001864DC File Offset: 0x001846DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171229, RefRangeEnd = 171230, XrefRangeStart = 171184, XrefRangeEnd = 171229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MountAndOverridePlayerRuntimeData(RunTimeAlbum.RuntimeAlbumCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimeAlbumCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x00023FB2 File Offset: 0x000221B2
		public static void RecordSpecialGuestFoodTag(int specialGusetId, params int[] foodTags)
		{
			RunTimeAlbum.RecordSpecialGuestFoodTag(specialGusetId, new Il2CppStructArray<int>(foodTags));
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x00023FC0 File Offset: 0x000221C0
		public static void RecordSpecialGuestHateFoodTag(int specialGusetId, params int[] foodTags)
		{
			RunTimeAlbum.RecordSpecialGuestHateFoodTag(specialGusetId, new Il2CppStructArray<int>(foodTags));
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x00023FCE File Offset: 0x000221CE
		public static void RecordSpecialGuestBevTag(int specialGusetId, params int[] bevTags)
		{
			RunTimeAlbum.RecordSpecialGuestBevTag(specialGusetId, new Il2CppStructArray<int>(bevTags));
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x00023FDC File Offset: 0x000221DC
		public RunTimeAlbum(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x00186514 File Offset: 0x00184714
		// (set) Token: 0x06004354 RID: 17236 RVA: 0x00023FE5 File Offset: 0x000221E5
		public unsafe static int DEFAULT_IZAKAYA_SKIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_DEFAULT_IZAKAYA_SKIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_DEFAULT_IZAKAYA_SKIN, (void*)(&value));
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x00186530 File Offset: 0x00184730
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x00023FF3 File Offset: 0x000221F3
		public unsafe static int nightBGM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_nightBGM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_nightBGM, (void*)(&value));
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x0018654C File Offset: 0x0018474C
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x00024001 File Offset: 0x00022201
		public unsafe static int nightBGMIndex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_nightBGMIndex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_nightBGMIndex, (void*)(&value));
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x00186568 File Offset: 0x00184768
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x0002400F File Offset: 0x0002220F
		public unsafe static Action<int> OnNewNormalGuestAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewNormalGuestAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewNormalGuestAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x00186590 File Offset: 0x00184790
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x00024021 File Offset: 0x00022221
		public unsafe static Action<int> OnNewSpecialGuestAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewSpecialGuestAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewSpecialGuestAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x001865B8 File Offset: 0x001847B8
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x00024033 File Offset: 0x00022233
		public unsafe static Action<ValueTuple<int, Sellable.SellableType, bool, int>> OnSpecialGuestTagUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestTagUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<int, Sellable.SellableType, bool, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestTagUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x001865E0 File Offset: 0x001847E0
		// (set) Token: 0x06004360 RID: 17248 RVA: 0x00024045 File Offset: 0x00022245
		public unsafe static Action<ValueTuple<int, int>> OnSpecialGuestIzakayaUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestIzakayaUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<int, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestIzakayaUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x00186608 File Offset: 0x00184808
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x00024057 File Offset: 0x00022257
		public unsafe static Action<int> OnSpecialGuestInfoUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestInfoUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestInfoUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00186630 File Offset: 0x00184830
		// (set) Token: 0x06004364 RID: 17252 RVA: 0x00024069 File Offset: 0x00022269
		public unsafe static Action OnSpecialGuestKizunaFull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaFull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaFull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x00186658 File Offset: 0x00184858
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x0002407B File Offset: 0x0002227B
		public unsafe static Action<ValueTuple<int, int>> OnSpecialGuestKizunaUpgrade
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaUpgrade, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<int, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaUpgrade, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x00186680 File Offset: 0x00184880
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x0002408D File Offset: 0x0002228D
		public unsafe static Action<string, bool> OnSpecialGuestKizunaChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnSpecialGuestKizunaChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x001866A8 File Offset: 0x001848A8
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x0002409F File Offset: 0x0002229F
		public unsafe static Action<int> OnNewFoodAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewFoodAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewFoodAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x001866D0 File Offset: 0x001848D0
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x000240B1 File Offset: 0x000222B1
		public unsafe static Action<int> OnNewBeverageAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewBeverageAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewBeverageAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x0600436D RID: 17261 RVA: 0x001866F8 File Offset: 0x001848F8
		// (set) Token: 0x0600436E RID: 17262 RVA: 0x000240C3 File Offset: 0x000222C3
		public unsafe static Action<int> OnNewIngredientAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewIngredientAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewIngredientAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600436F RID: 17263 RVA: 0x00186720 File Offset: 0x00184920
		// (set) Token: 0x06004370 RID: 17264 RVA: 0x000240D5 File Offset: 0x000222D5
		public unsafe static Action<int> OnNewCookerAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewCookerAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewCookerAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004371 RID: 17265 RVA: 0x00186748 File Offset: 0x00184948
		// (set) Token: 0x06004372 RID: 17266 RVA: 0x000240E7 File Offset: 0x000222E7
		public unsafe static Action<int> OnNewItemAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewItemAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewItemAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x00186770 File Offset: 0x00184970
		// (set) Token: 0x06004374 RID: 17268 RVA: 0x000240F9 File Offset: 0x000222F9
		public unsafe static Action<int> OnNewBadgeAdd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewBadgeAdd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_OnNewBadgeAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x00186798 File Offset: 0x00184998
		// (set) Token: 0x06004376 RID: 17270 RVA: 0x0002410B File Offset: 0x0002230B
		public unsafe static List<int> _NormalGuests_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__NormalGuests_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__NormalGuests_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x001867C0 File Offset: 0x001849C0
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x0002411D File Offset: 0x0002231D
		public unsafe static List<int> _Foods_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Foods_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Foods_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x001867E8 File Offset: 0x001849E8
		// (set) Token: 0x0600437A RID: 17274 RVA: 0x0002412F File Offset: 0x0002232F
		public unsafe static List<int> _Beverages_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Beverages_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Beverages_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x00186810 File Offset: 0x00184A10
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x00024141 File Offset: 0x00022341
		public unsafe static List<int> _Ingredients_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Ingredients_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Ingredients_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x00186838 File Offset: 0x00184A38
		// (set) Token: 0x0600437E RID: 17278 RVA: 0x00024153 File Offset: 0x00022353
		public unsafe static List<int> _Cookers_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Cookers_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Cookers_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x00186860 File Offset: 0x00184A60
		// (set) Token: 0x06004380 RID: 17280 RVA: 0x00024165 File Offset: 0x00022365
		public unsafe static List<int> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Items_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Items_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x00186888 File Offset: 0x00184A88
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x00024177 File Offset: 0x00022377
		public unsafe static List<int> _Badges_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__Badges_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__Badges_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x001868B0 File Offset: 0x00184AB0
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x00024189 File Offset: 0x00022389
		public unsafe static List<string> _HistoryCollectables_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__HistoryCollectables_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__HistoryCollectables_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x001868D8 File Offset: 0x00184AD8
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x0002419B File Offset: 0x0002239B
		public unsafe static List<int> _UsedDecorations_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__UsedDecorations_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__UsedDecorations_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x00186900 File Offset: 0x00184B00
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x000241AD File Offset: 0x000223AD
		public unsafe static bool _UseCurrentSkinAtNight_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__UseCurrentSkinAtNight_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__UseCurrentSkinAtNight_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004389 RID: 17289 RVA: 0x0018691C File Offset: 0x00184B1C
		// (set) Token: 0x0600438A RID: 17290 RVA: 0x000241BB File Offset: 0x000223BB
		public unsafe static bool _UseSpecialShopSkinAtNight_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__UseSpecialShopSkinAtNight_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__UseSpecialShopSkinAtNight_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x00186938 File Offset: 0x00184B38
		// (set) Token: 0x0600438C RID: 17292 RVA: 0x000241C9 File Offset: 0x000223C9
		public unsafe static Dictionary<int, int> _IngCollectCount_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__IngCollectCount_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__IngCollectCount_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x00186960 File Offset: 0x00184B60
		// (set) Token: 0x0600438E RID: 17294 RVA: 0x000241DB File Offset: 0x000223DB
		public unsafe static Dictionary<int, int> _UnsatisfiedTagCount_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__UnsatisfiedTagCount_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__UnsatisfiedTagCount_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x00186988 File Offset: 0x00184B88
		// (set) Token: 0x06004390 RID: 17296 RVA: 0x000241ED File Offset: 0x000223ED
		public unsafe static int _EvictGuestsCount_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__EvictGuestsCount_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__EvictGuestsCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004391 RID: 17297 RVA: 0x001869A4 File Offset: 0x00184BA4
		// (set) Token: 0x06004392 RID: 17298 RVA: 0x000241FB File Offset: 0x000223FB
		public unsafe static Dictionary<int, int> _CookingCount_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__CookingCount_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__CookingCount_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004393 RID: 17299 RVA: 0x001869CC File Offset: 0x00184BCC
		// (set) Token: 0x06004394 RID: 17300 RVA: 0x0002420D File Offset: 0x0002240D
		public unsafe static int _StrongBuyAndSellCount_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__StrongBuyAndSellCount_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__StrongBuyAndSellCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x001869E8 File Offset: 0x00184BE8
		// (set) Token: 0x06004396 RID: 17302 RVA: 0x0002421B File Offset: 0x0002241B
		public unsafe static int _RewardSpellTriggerCount_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__RewardSpellTriggerCount_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__RewardSpellTriggerCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x00186A04 File Offset: 0x00184C04
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x00024229 File Offset: 0x00022429
		public unsafe static int _PunishmentSpellTriggerCount_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__PunishmentSpellTriggerCount_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__PunishmentSpellTriggerCount_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x00186A20 File Offset: 0x00184C20
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x00024237 File Offset: 0x00022437
		public unsafe static int _CurrentPlayerSkin_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__CurrentPlayerSkin_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__CurrentPlayerSkin_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x00186A3C File Offset: 0x00184C3C
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x00024245 File Offset: 0x00022445
		public unsafe static List<int> _EffectiveSGuestMappingRules_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr__EffectiveSGuestMappingRules_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr__EffectiveSGuestMappingRules_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x00186A64 File Offset: 0x00184C64
		// (set) Token: 0x0600439E RID: 17310 RVA: 0x00024257 File Offset: 0x00022457
		public unsafe static Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> RecordedSpecialNPCs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_RecordedSpecialNPCs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_RecordedSpecialNPCs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x0600439F RID: 17311 RVA: 0x00186A8C File Offset: 0x00184C8C
		// (set) Token: 0x060043A0 RID: 17312 RVA: 0x00024269 File Offset: 0x00022469
		public unsafe static Il2CppStructArray<int> s_ExceptItems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.NativeFieldInfoPtr_s_ExceptItems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.NativeFieldInfoPtr_s_ExceptItems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_IZAKAYA_SKIN;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeFieldInfoPtr_nightBGM;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeFieldInfoPtr_nightBGMIndex;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeFieldInfoPtr_OnNewNormalGuestAdd;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeFieldInfoPtr_OnNewSpecialGuestAdd;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestTagUpdated;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestIzakayaUpdated;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestInfoUpdated;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestKizunaFull;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestKizunaUpgrade;

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeFieldInfoPtr_OnSpecialGuestKizunaChanged;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeFieldInfoPtr_OnNewFoodAdd;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeFieldInfoPtr_OnNewBeverageAdd;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeFieldInfoPtr_OnNewIngredientAdd;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeFieldInfoPtr_OnNewCookerAdd;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeFieldInfoPtr_OnNewItemAdd;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeFieldInfoPtr_OnNewBadgeAdd;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuests_k__BackingField;

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeFieldInfoPtr__Foods_k__BackingField;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeFieldInfoPtr__Beverages_k__BackingField;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeFieldInfoPtr__Ingredients_k__BackingField;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeFieldInfoPtr__Cookers_k__BackingField;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeFieldInfoPtr__Badges_k__BackingField;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeFieldInfoPtr__HistoryCollectables_k__BackingField;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeFieldInfoPtr__UsedDecorations_k__BackingField;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeFieldInfoPtr__UseCurrentSkinAtNight_k__BackingField;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeFieldInfoPtr__UseSpecialShopSkinAtNight_k__BackingField;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeFieldInfoPtr__IngCollectCount_k__BackingField;

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeFieldInfoPtr__UnsatisfiedTagCount_k__BackingField;

		// Token: 0x04002D27 RID: 11559
		private static readonly IntPtr NativeFieldInfoPtr__EvictGuestsCount_k__BackingField;

		// Token: 0x04002D28 RID: 11560
		private static readonly IntPtr NativeFieldInfoPtr__CookingCount_k__BackingField;

		// Token: 0x04002D29 RID: 11561
		private static readonly IntPtr NativeFieldInfoPtr__StrongBuyAndSellCount_k__BackingField;

		// Token: 0x04002D2A RID: 11562
		private static readonly IntPtr NativeFieldInfoPtr__RewardSpellTriggerCount_k__BackingField;

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeFieldInfoPtr__PunishmentSpellTriggerCount_k__BackingField;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerSkin_k__BackingField;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeFieldInfoPtr__EffectiveSGuestMappingRules_k__BackingField;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeFieldInfoPtr_RecordedSpecialNPCs;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeFieldInfoPtr_s_ExceptItems;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuests_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuests_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeMethodInfoPtr_get_Foods_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeMethodInfoPtr_get_Beverages_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookers_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D3B RID: 11579
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D3C RID: 11580
		private static readonly IntPtr NativeMethodInfoPtr_get_Badges_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D3D RID: 11581
		private static readonly IntPtr NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D3E RID: 11582
		private static readonly IntPtr NativeMethodInfoPtr_get_HistoryCollectables_Private_Static_get_List_1_String_0;

		// Token: 0x04002D3F RID: 11583
		private static readonly IntPtr NativeMethodInfoPtr_set_HistoryCollectables_Private_Static_set_Void_List_1_String_0;

		// Token: 0x04002D40 RID: 11584
		private static readonly IntPtr NativeMethodInfoPtr_get_UsedDecorations_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D41 RID: 11585
		private static readonly IntPtr NativeMethodInfoPtr_set_UsedDecorations_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D42 RID: 11586
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_Static_get_Boolean_0;

		// Token: 0x04002D43 RID: 11587
		private static readonly IntPtr NativeMethodInfoPtr_set_UseCurrentSkinAtNight_Public_Static_set_Void_Boolean_0;

		// Token: 0x04002D44 RID: 11588
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_Static_get_Boolean_0;

		// Token: 0x04002D45 RID: 11589
		private static readonly IntPtr NativeMethodInfoPtr_set_UseSpecialShopSkinAtNight_Public_Static_set_Void_Boolean_0;

		// Token: 0x04002D46 RID: 11590
		private static readonly IntPtr NativeMethodInfoPtr_get_IngCollectCount_Public_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D47 RID: 11591
		private static readonly IntPtr NativeMethodInfoPtr_set_IngCollectCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D48 RID: 11592
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsatisfiedTagCount_Public_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D49 RID: 11593
		private static readonly IntPtr NativeMethodInfoPtr_set_UnsatisfiedTagCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D4A RID: 11594
		private static readonly IntPtr NativeMethodInfoPtr_get_EvictGuestsCount_Public_Static_get_Int32_0;

		// Token: 0x04002D4B RID: 11595
		private static readonly IntPtr NativeMethodInfoPtr_set_EvictGuestsCount_Public_Static_set_Void_Int32_0;

		// Token: 0x04002D4C RID: 11596
		private static readonly IntPtr NativeMethodInfoPtr_get_CookingCount_Public_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D4D RID: 11597
		private static readonly IntPtr NativeMethodInfoPtr_set_CookingCount_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002D4E RID: 11598
		private static readonly IntPtr NativeMethodInfoPtr_get_StrongBuyAndSellCount_Public_Static_get_Int32_0;

		// Token: 0x04002D4F RID: 11599
		private static readonly IntPtr NativeMethodInfoPtr_set_StrongBuyAndSellCount_Public_Static_set_Void_Int32_0;

		// Token: 0x04002D50 RID: 11600
		private static readonly IntPtr NativeMethodInfoPtr_get_RewardSpellTriggerCount_Public_Static_get_Int32_0;

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr_set_RewardSpellTriggerCount_Public_Static_set_Void_Int32_0;

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr_get_PunishmentSpellTriggerCount_Public_Static_get_Int32_0;

		// Token: 0x04002D53 RID: 11603
		private static readonly IntPtr NativeMethodInfoPtr_set_PunishmentSpellTriggerCount_Public_Static_set_Void_Int32_0;

		// Token: 0x04002D54 RID: 11604
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerSkin_Public_Static_get_Int32_0;

		// Token: 0x04002D55 RID: 11605
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerSkin_Private_Static_set_Void_Int32_0;

		// Token: 0x04002D56 RID: 11606
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveSGuestMappingRules_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002D57 RID: 11607
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectiveSGuestMappingRules_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr_ClassifyIngredientByType_Public_Static_Void_DataSource_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr_ClassifyIngredientByTypeCore_Private_Static_Void_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_Func_2_List_1_KeyValuePair_2_Ingredient_Int32_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x04002D5A RID: 11610
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04002D5C RID: 11612
		private static readonly IntPtr NativeMethodInfoPtr_GetBeverageWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerWithRecord_Public_Static_IEnumerable_1_KeyValuePair_2_Cooker_Int32_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeAlbumSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeAlbumSaveDataPartial_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly IntPtr NativeMethodInfoPtr_TryRecord_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordNormalGuests_Public_Static_Void_Int32_0;

		// Token: 0x04002D62 RID: 11618
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordSpecialGuests_Public_Static_Void_Int32_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordFoods_Public_Static_Void_Int32_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordBeverages_Public_Static_Void_Int32_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordIngredients_Public_Static_Void_Int32_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordCookers_Public_Static_Void_Int32_0;

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordItems_Public_Static_Void_Int32_0;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordBadges_Public_Static_Void_Int32_0;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeMethodInfoPtr_TrySetSpecialGuestSkin_Public_Static_Void_Int32_SkinSelectionInfo_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeMethodInfoPtr_HasSpecialNPCRecorded_Public_Static_Boolean_Int32_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeMethodInfoPtr_GetRecordHistoryCollectables_Public_Static_Il2CppStringArray_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordHistoryCollectables_Public_Static_Void_String_0;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordUsedDecoration_Public_Static_Void_Int32_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveUsedDecoration_Public_Static_Void_Int32_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeMethodInfoPtr_ChangePlayerSkin_Public_Static_Void_Int32_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerSkinDebugConsole_Public_Static_Void_Int32_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealedData_Public_Static_Void_SpecialGuest_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_byref_IEnumerable_1_Int32_0;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRevealedData_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeMethodInfoPtr_RecordSpecialGuestFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeMethodInfoPtr_RecordSpecialGuestHateFoodTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeMethodInfoPtr_RecordSpecialGuestBevTag_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeMethodInfoPtr_RecordSpecialGuestIzakaya_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeMethodInfoPtr_CheckAllRevealedDataIsUnlocked_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeMethodInfoPtr_SetPositiveSpellCardNum_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeMethodInfoPtr_SetNegativeSpellCardNum_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeMethodInfoPtr_GetPositiveSpellCardNum_Public_Static_Int32_Int32_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_GetNegativeSpellCardNum_Public_Static_Int32_Int32_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_RecordPositiveSpellCardNum_Public_Static_Void_Int32_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr_RecordNegativeSpellCardNum_Public_Static_Void_Int32_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNegativeSpellCardTotalNum_Public_Static_Void_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePositiveSpellCardTotalNum_Public_Static_Void_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_ClearSGuestAlbum_Public_Static_Void_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeMethodInfoPtr_IfGuestHaveSpawnHere_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestSpawnIzakayaId_Public_Static_Void_String_Int32_0;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedNormalGuests_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedSpecialGuests_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04002D87 RID: 11655
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedFoodIds_Public_Static_List_1_Int32_0;

		// Token: 0x04002D88 RID: 11656
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedBeverageIds_Public_Static_List_1_Int32_0;

		// Token: 0x04002D89 RID: 11657
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedIngredientIds_Public_Static_List_1_Int32_0;

		// Token: 0x04002D8A RID: 11658
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedCookerIds_Public_Static_List_1_Int32_0;

		// Token: 0x04002D8B RID: 11659
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedItemIds_Public_Static_List_1_Int32_0;

		// Token: 0x04002D8C RID: 11660
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedFoods_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x04002D8D RID: 11661
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedBeverages_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x04002D8E RID: 11662
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedIngredients_Public_Static_IEnumerable_1_Ingredient_0;

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedCookers_Public_Static_IEnumerable_1_Cooker_0;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedItems_Public_Static_IEnumerable_1_NonTradableObjectBase_0;

		// Token: 0x04002D91 RID: 11665
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecordedBadges_Public_Static_IEnumerable_1_Badge_0;

		// Token: 0x04002D92 RID: 11666
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUsingDecorations_Public_Static_IEnumerable_1_Decoration_0;

		// Token: 0x04002D93 RID: 11667
		private static readonly IntPtr NativeMethodInfoPtr_CountNormalGuests_Public_Static_Int32_0;

		// Token: 0x04002D94 RID: 11668
		private static readonly IntPtr NativeMethodInfoPtr_CountSpecialGuests_Public_Static_Int32_0;

		// Token: 0x04002D95 RID: 11669
		private static readonly IntPtr NativeMethodInfoPtr_CountFoods_Public_Static_Int32_0;

		// Token: 0x04002D96 RID: 11670
		private static readonly IntPtr NativeMethodInfoPtr_CountBeverages_Public_Static_Int32_0;

		// Token: 0x04002D97 RID: 11671
		private static readonly IntPtr NativeMethodInfoPtr_CountIngredients_Public_Static_Int32_0;

		// Token: 0x04002D98 RID: 11672
		private static readonly IntPtr NativeMethodInfoPtr_CountCookers_Public_Static_Int32_0;

		// Token: 0x04002D99 RID: 11673
		private static readonly IntPtr NativeMethodInfoPtr_CountItems_Public_Static_Int32_0;

		// Token: 0x04002D9A RID: 11674
		private static readonly IntPtr NativeMethodInfoPtr_CountBadges_Public_Static_Int32_0;

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerClothes_Public_Static_Clothes_0;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeMethodInfoPtr_GetNightBGMId_Public_Static_Int32_0;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeMethodInfoPtr_SetNightBGMId_Public_Static_Void_Int32_0;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeMethodInfoPtr_GetNightBGMIndex_Public_Static_Int32_0;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeMethodInfoPtr_SetNightBGMIndex_Public_Static_Void_Int32_0;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSkinSet_Public_Static_SkinSelectionInfo_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterKizuna_Public_Static_Int32_String_byref_Int32_byref_Int32_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeMethodInfoPtr_RefNormalPixel_Public_Static_CharacterSpriteSetCompact_Int32_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeMethodInfoPtr_RefNormalPortrayal_Public_Static_CharacterPortrayal_Int32_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_Int32_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeMethodInfoPtr_RefOrGenerateSpecialRunTimeData_Public_Static_SpecialGuestRunTimeData_String_0;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeMethodInfoPtr_RefSpecialNPCId_Public_Static_Int32_String_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeMethodInfoPtr_GetLevelUpExpAmount_Public_Static_Int32_Int32_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeMethodInfoPtr_HasSpecialNPCKizunaExpFull_Public_Static_Boolean_Int32_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_HasDecorationUsing_Public_Static_Boolean_Int32_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel5KizunaNPCData_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_String_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_GetOrGenerateSpecialNPCKizunaLevel_Public_Static_Int32_Int32_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_String_Int32_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_AlterOrGenerateSpecialNPCKizuna_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeOrGenerateSpecialNPCKizuna_Public_Static_Void_String_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAllKizunaLevelUpdateData_Public_Static_Void_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllStatusForSpecialNPC_Public_Static_Void_SpecialGuest_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeMethodInfoPtr_RefSpecialPixel_Public_Static_CharacterSpriteSetCompact_Int32_Boolean_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForKyouko_Private_Static_Nullable_1_Int32_Int32_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIfShouldLoadSpecialSkinForSelf_Private_Static_Nullable_1_Int32_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeMethodInfoPtr_RefSpecialPortrayal_Public_Static_CharacterPortrayal_Int32_Boolean_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeMethodInfoPtr_RefSelfPixel_Public_Static_CharacterSpriteSetFull_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeMethodInfoPtr_RefSelfPortrayal_Public_Static_CharacterPortrayal_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeMethodInfoPtr_GetAlbumIngredientsOrderByDatabase_Public_Static_IEnumerable_1_Ingredient_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeMethodInfoPtr_GetAlbumFoodsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr_GetAlbumBevsOrderByDatabase_Public_Static_IEnumerable_1_Sellable_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_IsBadgeRecoreded_Public_Static_Boolean_Badge_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeMethodInfoPtr_CheckSGuestMapping_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeMethodInfoPtr_CheckMappingSGuestOrigin_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeMethodInfoPtr_AddSGuestMapping_Public_Static_Void_Int32_0;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSGuestMapping_Public_Static_Void_Int32_0;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeMethodInfoPtr_ClearAndDumpPlayerSkinDataAsync_Public_Static_UniTask_byref_RuntimePlayerSkinDataCache_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerRuntimeSkinDataCache_Public_Static_RuntimePlayerSkinDataCache_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeMethodInfoPtr_MountAndOverridePlayerSkinRuntimeData_Public_Static_UniTask_RuntimePlayerSkinDataCache_0;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeMethodInfoPtr_ClearAndDumpRunTimeAlbumData_Public_Static_Void_byref_RuntimeAlbumCache_0;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Private_Static_RuntimeAlbumCache_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimeAlbumCache_0;

		// Token: 0x02000A28 RID: 2600
		public enum DataSource
		{
			// Token: 0x04007EC8 RID: 32456
			Album,
			// Token: 0x04007EC9 RID: 32457
			InStorageOnly
		}

		// Token: 0x02000A29 RID: 2601
		public class SpecialGuestRunTimeData : Object
		{
			// Token: 0x0600C542 RID: 50498 RVA: 0x00310264 File Offset: 0x0030E464
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialGuestRunTimeData()
			{
				Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "SpecialGuestRunTimeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_izakayaWhereCanSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "izakayaWhereCanSpawn");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedBevTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "revealedBevTags");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "revealedFoodTags");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedHateFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "revealedHateFoodTags");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedIzakaya = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "revealedIzakaya");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__UnlockedExplicits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<UnlockedExplicits>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentSkinSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<CurrentSkinSelection>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondExp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<CurrentBondExp>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<CurrentBondLevel>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__DoNotShowInNight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<DoNotShowInNight>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__PositiveSCNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<PositiveSCNum>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__NegativeSCNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, "<NegativeSCNum>k__BackingField");
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676151);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_List_1_Int32_SkinSelectionInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676152);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676153);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_UnlockedExplicits_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676154);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_UnlockedExplicits_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676155);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentSkinSelection_Public_get_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676156);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentSkinSelection_Public_set_Void_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676157);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentBondExp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676158);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentBondExp_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676159);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentBondLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676160);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentBondLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676161);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_DoNotShowInNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676162);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_DoNotShowInNight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676163);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_IzakayaWhereCanSpawn_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676164);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedFoodTags_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676165);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedHateFoodTags_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676166);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedBevTags_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676167);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedIzakaya_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676168);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_PositiveSCNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676169);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_PositiveSCNum_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676170);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_NegativeSCNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676171);
				RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_NegativeSCNum_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr, 100676172);
			}

			// Token: 0x0600C543 RID: 50499 RVA: 0x00310538 File Offset: 0x0030E738
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuestRunTimeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C544 RID: 50500 RVA: 0x00310574 File Offset: 0x0030E774
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 167059, RefRangeEnd = 167071, XrefRangeStart = 167035, XrefRangeEnd = 167059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuestRunTimeData(int currentBondExp, int currentBondLevel, List<int> unlockedExplicits, CharacterSkinSets.SkinSelectionInfo currentSkinSelection, bool doNotShowInNight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.SpecialGuestRunTimeData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref currentBondExp;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentBondLevel;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedExplicits);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentSkinSelection;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotShowInNight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_List_1_Int32_SkinSelectionInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C545 RID: 50501 RVA: 0x003105F8 File Offset: 0x0030E7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167071, XrefRangeEnd = 167109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual RunTimeAlbum.SpecialGuestRunTimeData Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.SpecialGuestRunTimeData>(intPtr3) : null;
			}

			// Token: 0x1700403E RID: 16446
			// (get) Token: 0x0600C546 RID: 50502 RVA: 0x00310638 File Offset: 0x0030E838
			// (set) Token: 0x0600C547 RID: 50503 RVA: 0x00310678 File Offset: 0x0030E878
			public unsafe List<int> UnlockedExplicits
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_UnlockedExplicits_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_UnlockedExplicits_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700403F RID: 16447
			// (get) Token: 0x0600C548 RID: 50504 RVA: 0x003106BC File Offset: 0x0030E8BC
			// (set) Token: 0x0600C549 RID: 50505 RVA: 0x003106F8 File Offset: 0x0030E8F8
			public unsafe CharacterSkinSets.SkinSelectionInfo CurrentSkinSelection
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentSkinSelection_Public_get_SkinSelectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentSkinSelection_Public_set_Void_SkinSelectionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004040 RID: 16448
			// (get) Token: 0x0600C54A RID: 50506 RVA: 0x00310738 File Offset: 0x0030E938
			// (set) Token: 0x0600C54B RID: 50507 RVA: 0x00310774 File Offset: 0x0030E974
			public unsafe int CurrentBondExp
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 105723, RefRangeEnd = 105726, XrefRangeStart = 105723, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentBondExp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentBondExp_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004041 RID: 16449
			// (get) Token: 0x0600C54C RID: 50508 RVA: 0x003107B4 File Offset: 0x0030E9B4
			// (set) Token: 0x0600C54D RID: 50509 RVA: 0x003107F0 File Offset: 0x0030E9F0
			public unsafe int CurrentBondLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_CurrentBondLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_CurrentBondLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004042 RID: 16450
			// (get) Token: 0x0600C54E RID: 50510 RVA: 0x00310830 File Offset: 0x0030EA30
			// (set) Token: 0x0600C54F RID: 50511 RVA: 0x0031086C File Offset: 0x0030EA6C
			public unsafe bool DoNotShowInNight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_DoNotShowInNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_DoNotShowInNight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004043 RID: 16451
			// (get) Token: 0x0600C550 RID: 50512 RVA: 0x003108AC File Offset: 0x0030EAAC
			public unsafe List<int> IzakayaWhereCanSpawn
			{
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 167116, RefRangeEnd = 167132, XrefRangeStart = 167109, XrefRangeEnd = 167116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_IzakayaWhereCanSpawn_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004044 RID: 16452
			// (get) Token: 0x0600C551 RID: 50513 RVA: 0x003108EC File Offset: 0x0030EAEC
			public unsafe List<int> RevealedFoodTags
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 167139, RefRangeEnd = 167147, XrefRangeStart = 167132, XrefRangeEnd = 167139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedFoodTags_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004045 RID: 16453
			// (get) Token: 0x0600C552 RID: 50514 RVA: 0x0031092C File Offset: 0x0030EB2C
			public unsafe List<int> RevealedHateFoodTags
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 167154, RefRangeEnd = 167162, XrefRangeStart = 167147, XrefRangeEnd = 167154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedHateFoodTags_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004046 RID: 16454
			// (get) Token: 0x0600C553 RID: 50515 RVA: 0x0031096C File Offset: 0x0030EB6C
			public unsafe List<int> RevealedBevTags
			{
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 167169, RefRangeEnd = 167177, XrefRangeStart = 167162, XrefRangeEnd = 167169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedBevTags_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004047 RID: 16455
			// (get) Token: 0x0600C554 RID: 50516 RVA: 0x003109AC File Offset: 0x0030EBAC
			public unsafe List<int> RevealedIzakaya
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 167184, RefRangeEnd = 167188, XrefRangeStart = 167177, XrefRangeEnd = 167184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_RevealedIzakaya_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004048 RID: 16456
			// (get) Token: 0x0600C555 RID: 50517 RVA: 0x003109EC File Offset: 0x0030EBEC
			// (set) Token: 0x0600C556 RID: 50518 RVA: 0x00310A28 File Offset: 0x0030EC28
			public unsafe int PositiveSCNum
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 103797, RefRangeEnd = 103804, XrefRangeStart = 103797, XrefRangeEnd = 103804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_PositiveSCNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_PositiveSCNum_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004049 RID: 16457
			// (get) Token: 0x0600C557 RID: 50519 RVA: 0x00310A68 File Offset: 0x0030EC68
			// (set) Token: 0x0600C558 RID: 50520 RVA: 0x00310AA4 File Offset: 0x0030ECA4
			public unsafe int NegativeSCNum
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 86389, RefRangeEnd = 86391, XrefRangeStart = 86389, XrefRangeEnd = 86391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_get_NegativeSCNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 105753, RefRangeEnd = 105754, XrefRangeStart = 105753, XrefRangeEnd = 105754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.SpecialGuestRunTimeData.NativeMethodInfoPtr_set_NegativeSCNum_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600C559 RID: 50521 RVA: 0x0006A757 File Offset: 0x00068957
			public SpecialGuestRunTimeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004032 RID: 16434
			// (get) Token: 0x0600C55A RID: 50522 RVA: 0x00310AE4 File Offset: 0x0030ECE4
			// (set) Token: 0x0600C55B RID: 50523 RVA: 0x0006A760 File Offset: 0x00068960
			public unsafe List<int> izakayaWhereCanSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_izakayaWhereCanSpawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_izakayaWhereCanSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004033 RID: 16435
			// (get) Token: 0x0600C55C RID: 50524 RVA: 0x00310B14 File Offset: 0x0030ED14
			// (set) Token: 0x0600C55D RID: 50525 RVA: 0x0006A77F File Offset: 0x0006897F
			public unsafe List<int> revealedBevTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedBevTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedBevTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004034 RID: 16436
			// (get) Token: 0x0600C55E RID: 50526 RVA: 0x00310B44 File Offset: 0x0030ED44
			// (set) Token: 0x0600C55F RID: 50527 RVA: 0x0006A79E File Offset: 0x0006899E
			public unsafe List<int> revealedFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004035 RID: 16437
			// (get) Token: 0x0600C560 RID: 50528 RVA: 0x00310B74 File Offset: 0x0030ED74
			// (set) Token: 0x0600C561 RID: 50529 RVA: 0x0006A7BD File Offset: 0x000689BD
			public unsafe List<int> revealedHateFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedHateFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedHateFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004036 RID: 16438
			// (get) Token: 0x0600C562 RID: 50530 RVA: 0x00310BA4 File Offset: 0x0030EDA4
			// (set) Token: 0x0600C563 RID: 50531 RVA: 0x0006A7DC File Offset: 0x000689DC
			public unsafe List<int> revealedIzakaya
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedIzakaya);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr_revealedIzakaya), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004037 RID: 16439
			// (get) Token: 0x0600C564 RID: 50532 RVA: 0x00310BD4 File Offset: 0x0030EDD4
			// (set) Token: 0x0600C565 RID: 50533 RVA: 0x0006A7FB File Offset: 0x000689FB
			public unsafe List<int> _UnlockedExplicits_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__UnlockedExplicits_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__UnlockedExplicits_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004038 RID: 16440
			// (get) Token: 0x0600C566 RID: 50534 RVA: 0x00310C04 File Offset: 0x0030EE04
			// (set) Token: 0x0600C567 RID: 50535 RVA: 0x0006A81A File Offset: 0x00068A1A
			public unsafe CharacterSkinSets.SkinSelectionInfo _CurrentSkinSelection_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentSkinSelection_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentSkinSelection_k__BackingField)) = value;
				}
			}

			// Token: 0x17004039 RID: 16441
			// (get) Token: 0x0600C568 RID: 50536 RVA: 0x00310C2C File Offset: 0x0030EE2C
			// (set) Token: 0x0600C569 RID: 50537 RVA: 0x0006A835 File Offset: 0x00068A35
			public unsafe int _CurrentBondExp_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondExp_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondExp_k__BackingField)) = value;
				}
			}

			// Token: 0x1700403A RID: 16442
			// (get) Token: 0x0600C56A RID: 50538 RVA: 0x00310C54 File Offset: 0x0030EE54
			// (set) Token: 0x0600C56B RID: 50539 RVA: 0x0006A850 File Offset: 0x00068A50
			public unsafe int _CurrentBondLevel_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondLevel_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__CurrentBondLevel_k__BackingField)) = value;
				}
			}

			// Token: 0x1700403B RID: 16443
			// (get) Token: 0x0600C56C RID: 50540 RVA: 0x00310C7C File Offset: 0x0030EE7C
			// (set) Token: 0x0600C56D RID: 50541 RVA: 0x0006A86B File Offset: 0x00068A6B
			public unsafe bool _DoNotShowInNight_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__DoNotShowInNight_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__DoNotShowInNight_k__BackingField)) = value;
				}
			}

			// Token: 0x1700403C RID: 16444
			// (get) Token: 0x0600C56E RID: 50542 RVA: 0x00310CA4 File Offset: 0x0030EEA4
			// (set) Token: 0x0600C56F RID: 50543 RVA: 0x0006A886 File Offset: 0x00068A86
			public unsafe int _PositiveSCNum_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__PositiveSCNum_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__PositiveSCNum_k__BackingField)) = value;
				}
			}

			// Token: 0x1700403D RID: 16445
			// (get) Token: 0x0600C570 RID: 50544 RVA: 0x00310CCC File Offset: 0x0030EECC
			// (set) Token: 0x0600C571 RID: 50545 RVA: 0x0006A8A1 File Offset: 0x00068AA1
			public unsafe int _NegativeSCNum_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__NegativeSCNum_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.SpecialGuestRunTimeData.NativeFieldInfoPtr__NegativeSCNum_k__BackingField)) = value;
				}
			}

			// Token: 0x04007ECA RID: 32458
			private static readonly IntPtr NativeFieldInfoPtr_izakayaWhereCanSpawn;

			// Token: 0x04007ECB RID: 32459
			private static readonly IntPtr NativeFieldInfoPtr_revealedBevTags;

			// Token: 0x04007ECC RID: 32460
			private static readonly IntPtr NativeFieldInfoPtr_revealedFoodTags;

			// Token: 0x04007ECD RID: 32461
			private static readonly IntPtr NativeFieldInfoPtr_revealedHateFoodTags;

			// Token: 0x04007ECE RID: 32462
			private static readonly IntPtr NativeFieldInfoPtr_revealedIzakaya;

			// Token: 0x04007ECF RID: 32463
			private static readonly IntPtr NativeFieldInfoPtr__UnlockedExplicits_k__BackingField;

			// Token: 0x04007ED0 RID: 32464
			private static readonly IntPtr NativeFieldInfoPtr__CurrentSkinSelection_k__BackingField;

			// Token: 0x04007ED1 RID: 32465
			private static readonly IntPtr NativeFieldInfoPtr__CurrentBondExp_k__BackingField;

			// Token: 0x04007ED2 RID: 32466
			private static readonly IntPtr NativeFieldInfoPtr__CurrentBondLevel_k__BackingField;

			// Token: 0x04007ED3 RID: 32467
			private static readonly IntPtr NativeFieldInfoPtr__DoNotShowInNight_k__BackingField;

			// Token: 0x04007ED4 RID: 32468
			private static readonly IntPtr NativeFieldInfoPtr__PositiveSCNum_k__BackingField;

			// Token: 0x04007ED5 RID: 32469
			private static readonly IntPtr NativeFieldInfoPtr__NegativeSCNum_k__BackingField;

			// Token: 0x04007ED6 RID: 32470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007ED7 RID: 32471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_List_1_Int32_SkinSelectionInfo_Boolean_0;

			// Token: 0x04007ED8 RID: 32472
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_SpecialGuestRunTimeData_0;

			// Token: 0x04007ED9 RID: 32473
			private static readonly IntPtr NativeMethodInfoPtr_get_UnlockedExplicits_Public_get_List_1_Int32_0;

			// Token: 0x04007EDA RID: 32474
			private static readonly IntPtr NativeMethodInfoPtr_set_UnlockedExplicits_Public_set_Void_List_1_Int32_0;

			// Token: 0x04007EDB RID: 32475
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSkinSelection_Public_get_SkinSelectionInfo_0;

			// Token: 0x04007EDC RID: 32476
			private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSkinSelection_Public_set_Void_SkinSelectionInfo_0;

			// Token: 0x04007EDD RID: 32477
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBondExp_Public_get_Int32_0;

			// Token: 0x04007EDE RID: 32478
			private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBondExp_Public_set_Void_Int32_0;

			// Token: 0x04007EDF RID: 32479
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBondLevel_Public_get_Int32_0;

			// Token: 0x04007EE0 RID: 32480
			private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBondLevel_Public_set_Void_Int32_0;

			// Token: 0x04007EE1 RID: 32481
			private static readonly IntPtr NativeMethodInfoPtr_get_DoNotShowInNight_Public_get_Boolean_0;

			// Token: 0x04007EE2 RID: 32482
			private static readonly IntPtr NativeMethodInfoPtr_set_DoNotShowInNight_Public_set_Void_Boolean_0;

			// Token: 0x04007EE3 RID: 32483
			private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaWhereCanSpawn_Public_get_List_1_Int32_0;

			// Token: 0x04007EE4 RID: 32484
			private static readonly IntPtr NativeMethodInfoPtr_get_RevealedFoodTags_Public_get_List_1_Int32_0;

			// Token: 0x04007EE5 RID: 32485
			private static readonly IntPtr NativeMethodInfoPtr_get_RevealedHateFoodTags_Public_get_List_1_Int32_0;

			// Token: 0x04007EE6 RID: 32486
			private static readonly IntPtr NativeMethodInfoPtr_get_RevealedBevTags_Public_get_List_1_Int32_0;

			// Token: 0x04007EE7 RID: 32487
			private static readonly IntPtr NativeMethodInfoPtr_get_RevealedIzakaya_Public_get_List_1_Int32_0;

			// Token: 0x04007EE8 RID: 32488
			private static readonly IntPtr NativeMethodInfoPtr_get_PositiveSCNum_Public_get_Int32_0;

			// Token: 0x04007EE9 RID: 32489
			private static readonly IntPtr NativeMethodInfoPtr_set_PositiveSCNum_Public_set_Void_Int32_0;

			// Token: 0x04007EEA RID: 32490
			private static readonly IntPtr NativeMethodInfoPtr_get_NegativeSCNum_Public_get_Int32_0;

			// Token: 0x04007EEB RID: 32491
			private static readonly IntPtr NativeMethodInfoPtr_set_NegativeSCNum_Public_set_Void_Int32_0;
		}

		// Token: 0x02000A2A RID: 2602
		public class RuntimePlayerSkinDataCache : Object
		{
			// Token: 0x0600C572 RID: 50546 RVA: 0x00310CF4 File Offset: 0x0030EEF4
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimePlayerSkinDataCache()
			{
				Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "RuntimePlayerSkinDataCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr);
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_ClothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, "m_ClothesId");
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseCurrentSkinAtNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, "m_UseCurrentSkinAtNight");
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseSpecialShopSkinAtNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, "m_UseSpecialShopSkinAtNight");
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_ClothesId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, 100676173);
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, 100676174);
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, 100676175);
				RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr, 100676176);
			}

			// Token: 0x1700404D RID: 16461
			// (get) Token: 0x0600C573 RID: 50547 RVA: 0x00310DAC File Offset: 0x0030EFAC
			public unsafe int ClothesId
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_ClothesId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700404E RID: 16462
			// (get) Token: 0x0600C574 RID: 50548 RVA: 0x00310DE8 File Offset: 0x0030EFE8
			public unsafe bool UseCurrentSkinAtNight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700404F RID: 16463
			// (get) Token: 0x0600C575 RID: 50549 RVA: 0x00310E24 File Offset: 0x0030F024
			public unsafe bool UseSpecialShopSkinAtNight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600C576 RID: 50550 RVA: 0x00310E60 File Offset: 0x0030F060
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 167189, RefRangeEnd = 167192, XrefRangeStart = 167188, XrefRangeEnd = 167189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimePlayerSkinDataCache(int clothesId, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.RuntimePlayerSkinDataCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref clothesId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCurrentSkinAtNight;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpecialShopSkinAtNight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C577 RID: 50551 RVA: 0x0006A8BC File Offset: 0x00068ABC
			public RuntimePlayerSkinDataCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404A RID: 16458
			// (get) Token: 0x0600C578 RID: 50552 RVA: 0x00310EC4 File Offset: 0x0030F0C4
			// (set) Token: 0x0600C579 RID: 50553 RVA: 0x0006A8C5 File Offset: 0x00068AC5
			public unsafe int m_ClothesId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_ClothesId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_ClothesId)) = value;
				}
			}

			// Token: 0x1700404B RID: 16459
			// (get) Token: 0x0600C57A RID: 50554 RVA: 0x00310EEC File Offset: 0x0030F0EC
			// (set) Token: 0x0600C57B RID: 50555 RVA: 0x0006A8E0 File Offset: 0x00068AE0
			public unsafe bool m_UseCurrentSkinAtNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseCurrentSkinAtNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseCurrentSkinAtNight)) = value;
				}
			}

			// Token: 0x1700404C RID: 16460
			// (get) Token: 0x0600C57C RID: 50556 RVA: 0x00310F14 File Offset: 0x0030F114
			// (set) Token: 0x0600C57D RID: 50557 RVA: 0x0006A8FB File Offset: 0x00068AFB
			public unsafe bool m_UseSpecialShopSkinAtNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseSpecialShopSkinAtNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimePlayerSkinDataCache.NativeFieldInfoPtr_m_UseSpecialShopSkinAtNight)) = value;
				}
			}

			// Token: 0x04007EEC RID: 32492
			private static readonly IntPtr NativeFieldInfoPtr_m_ClothesId;

			// Token: 0x04007EED RID: 32493
			private static readonly IntPtr NativeFieldInfoPtr_m_UseCurrentSkinAtNight;

			// Token: 0x04007EEE RID: 32494
			private static readonly IntPtr NativeFieldInfoPtr_m_UseSpecialShopSkinAtNight;

			// Token: 0x04007EEF RID: 32495
			private static readonly IntPtr NativeMethodInfoPtr_get_ClothesId_Public_get_Int32_0;

			// Token: 0x04007EF0 RID: 32496
			private static readonly IntPtr NativeMethodInfoPtr_get_UseCurrentSkinAtNight_Public_get_Boolean_0;

			// Token: 0x04007EF1 RID: 32497
			private static readonly IntPtr NativeMethodInfoPtr_get_UseSpecialShopSkinAtNight_Public_get_Boolean_0;

			// Token: 0x04007EF2 RID: 32498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_0;
		}

		// Token: 0x02000A2B RID: 2603
		public class RuntimeAlbumCache : Object
		{
			// Token: 0x0600C57E RID: 50558 RVA: 0x00310F3C File Offset: 0x0030F13C
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimeAlbumCache()
			{
				Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "RuntimeAlbumCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr);
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_Foods");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Beverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_Beverages");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_Ingredients");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_Cookers");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_Items");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_UsedDecorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_UsedDecorations");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_NormalGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_NormalGuests");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_EffectiveSGuestMappingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_EffectiveSGuestMappingRules");
				RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_RecordedSpecialNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, "m_RecordedSpecialNPCs");
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676177);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676178);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676179);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676180);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676181);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedUsedDecorations_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676182);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedNormalGuests_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676183);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedEffectiveSGuestMappingRules_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676184);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedRecordedSpecialNPCs_Public_get_Dictionary_2_Int32_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676185);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676186);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676187);
				RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimeAlbumCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr, 100676188);
			}

			// Token: 0x17004059 RID: 16473
			// (get) Token: 0x0600C57F RID: 50559 RVA: 0x0031110C File Offset: 0x0030F30C
			public unsafe IEnumerable<int> CachedFoods
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405A RID: 16474
			// (get) Token: 0x0600C580 RID: 50560 RVA: 0x0031114C File Offset: 0x0030F34C
			public unsafe IEnumerable<int> CachedBeverages
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405B RID: 16475
			// (get) Token: 0x0600C581 RID: 50561 RVA: 0x0031118C File Offset: 0x0030F38C
			public unsafe IEnumerable<int> CachedIngredients
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405C RID: 16476
			// (get) Token: 0x0600C582 RID: 50562 RVA: 0x003111CC File Offset: 0x0030F3CC
			public unsafe IEnumerable<int> CachedCookers
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405D RID: 16477
			// (get) Token: 0x0600C583 RID: 50563 RVA: 0x0031120C File Offset: 0x0030F40C
			public unsafe IEnumerable<int> CachedItems
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405E RID: 16478
			// (get) Token: 0x0600C584 RID: 50564 RVA: 0x0031124C File Offset: 0x0030F44C
			public unsafe IEnumerable<int> CachedUsedDecorations
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedUsedDecorations_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700405F RID: 16479
			// (get) Token: 0x0600C585 RID: 50565 RVA: 0x0031128C File Offset: 0x0030F48C
			public unsafe IEnumerable<int> CachedNormalGuests
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedNormalGuests_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004060 RID: 16480
			// (get) Token: 0x0600C586 RID: 50566 RVA: 0x003112CC File Offset: 0x0030F4CC
			public unsafe IEnumerable<int> CachedEffectiveSGuestMappingRules
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedEffectiveSGuestMappingRules_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17004061 RID: 16481
			// (get) Token: 0x0600C587 RID: 50567 RVA: 0x0031130C File Offset: 0x0030F50C
			public unsafe Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> CachedRecordedSpecialNPCs
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167192, XrefRangeEnd = 167194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_get_CachedRecordedSpecialNPCs_Public_get_Dictionary_2_Int32_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr3) : null;
				}
			}

			// Token: 0x0600C588 RID: 50568 RVA: 0x0031134C File Offset: 0x0030F54C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimeAlbumCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C589 RID: 50569 RVA: 0x00311388 File Offset: 0x0030F588
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 167214, RefRangeEnd = 167216, XrefRangeStart = 167194, XrefRangeEnd = 167214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimeAlbumCache(Il2CppStructArray<int> foods, Il2CppStructArray<int> beverages, Il2CppStructArray<int> ingredients, Il2CppStructArray<int> cookers, Il2CppStructArray<int> items, Il2CppStructArray<int> usedDecorations, Il2CppStructArray<int> normalGuests, Il2CppStructArray<int> effectiveSGuestMappingRules, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> recordedSpecialNPCs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.RuntimeAlbumCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedDecorations);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuests);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectiveSGuestMappingRules);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recordedSpecialNPCs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C58A RID: 50570 RVA: 0x0031146C File Offset: 0x0030F66C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167216, XrefRangeEnd = 167241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual RunTimeAlbum.RuntimeAlbumCache Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.RuntimeAlbumCache.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimeAlbumCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.RuntimeAlbumCache>(intPtr3) : null;
			}

			// Token: 0x0600C58B RID: 50571 RVA: 0x0006A916 File Offset: 0x00068B16
			public RuntimeAlbumCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004050 RID: 16464
			// (get) Token: 0x0600C58C RID: 50572 RVA: 0x003114AC File Offset: 0x0030F6AC
			// (set) Token: 0x0600C58D RID: 50573 RVA: 0x0006A91F File Offset: 0x00068B1F
			public unsafe Il2CppStructArray<int> m_Foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004051 RID: 16465
			// (get) Token: 0x0600C58E RID: 50574 RVA: 0x003114DC File Offset: 0x0030F6DC
			// (set) Token: 0x0600C58F RID: 50575 RVA: 0x0006A93E File Offset: 0x00068B3E
			public unsafe Il2CppStructArray<int> m_Beverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Beverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Beverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0600C590 RID: 50576 RVA: 0x0031150C File Offset: 0x0030F70C
			// (set) Token: 0x0600C591 RID: 50577 RVA: 0x0006A95D File Offset: 0x00068B5D
			public unsafe Il2CppStructArray<int> m_Ingredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Ingredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0600C592 RID: 50578 RVA: 0x0031153C File Offset: 0x0030F73C
			// (set) Token: 0x0600C593 RID: 50579 RVA: 0x0006A97C File Offset: 0x00068B7C
			public unsafe Il2CppStructArray<int> m_Cookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Cookers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0600C594 RID: 50580 RVA: 0x0031156C File Offset: 0x0030F76C
			// (set) Token: 0x0600C595 RID: 50581 RVA: 0x0006A99B File Offset: 0x00068B9B
			public unsafe Il2CppStructArray<int> m_Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004055 RID: 16469
			// (get) Token: 0x0600C596 RID: 50582 RVA: 0x0031159C File Offset: 0x0030F79C
			// (set) Token: 0x0600C597 RID: 50583 RVA: 0x0006A9BA File Offset: 0x00068BBA
			public unsafe Il2CppStructArray<int> m_UsedDecorations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_UsedDecorations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_UsedDecorations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004056 RID: 16470
			// (get) Token: 0x0600C598 RID: 50584 RVA: 0x003115CC File Offset: 0x0030F7CC
			// (set) Token: 0x0600C599 RID: 50585 RVA: 0x0006A9D9 File Offset: 0x00068BD9
			public unsafe Il2CppStructArray<int> m_NormalGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_NormalGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_NormalGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004057 RID: 16471
			// (get) Token: 0x0600C59A RID: 50586 RVA: 0x003115FC File Offset: 0x0030F7FC
			// (set) Token: 0x0600C59B RID: 50587 RVA: 0x0006A9F8 File Offset: 0x00068BF8
			public unsafe Il2CppStructArray<int> m_EffectiveSGuestMappingRules
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_EffectiveSGuestMappingRules);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_EffectiveSGuestMappingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004058 RID: 16472
			// (get) Token: 0x0600C59C RID: 50588 RVA: 0x0031162C File Offset: 0x0030F82C
			// (set) Token: 0x0600C59D RID: 50589 RVA: 0x0006AA17 File Offset: 0x00068C17
			public unsafe static Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> m_RecordedSpecialNPCs
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_RecordedSpecialNPCs, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.RuntimeAlbumCache.NativeFieldInfoPtr_m_RecordedSpecialNPCs, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007EF3 RID: 32499
			private static readonly IntPtr NativeFieldInfoPtr_m_Foods;

			// Token: 0x04007EF4 RID: 32500
			private static readonly IntPtr NativeFieldInfoPtr_m_Beverages;

			// Token: 0x04007EF5 RID: 32501
			private static readonly IntPtr NativeFieldInfoPtr_m_Ingredients;

			// Token: 0x04007EF6 RID: 32502
			private static readonly IntPtr NativeFieldInfoPtr_m_Cookers;

			// Token: 0x04007EF7 RID: 32503
			private static readonly IntPtr NativeFieldInfoPtr_m_Items;

			// Token: 0x04007EF8 RID: 32504
			private static readonly IntPtr NativeFieldInfoPtr_m_UsedDecorations;

			// Token: 0x04007EF9 RID: 32505
			private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuests;

			// Token: 0x04007EFA RID: 32506
			private static readonly IntPtr NativeFieldInfoPtr_m_EffectiveSGuestMappingRules;

			// Token: 0x04007EFB RID: 32507
			private static readonly IntPtr NativeFieldInfoPtr_m_RecordedSpecialNPCs;

			// Token: 0x04007EFC RID: 32508
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007EFD RID: 32509
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007EFE RID: 32510
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007EFF RID: 32511
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007F00 RID: 32512
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007F01 RID: 32513
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedUsedDecorations_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007F02 RID: 32514
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedNormalGuests_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007F03 RID: 32515
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedEffectiveSGuestMappingRules_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04007F04 RID: 32516
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedRecordedSpecialNPCs_Public_get_Dictionary_2_Int32_SpecialGuestRunTimeData_0;

			// Token: 0x04007F05 RID: 32517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F06 RID: 32518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_0;

			// Token: 0x04007F07 RID: 32519
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimeAlbumCache_0;
		}

		// Token: 0x02000A2C RID: 2604
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C59E RID: 50590 RVA: 0x00311654 File Offset: 0x0030F854
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr);
				RunTimeAlbum.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__99_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__99_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_2");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_3");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_4");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_5");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_6");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__100_7");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_2");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_3");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_4");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_5");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_6");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_7");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_8");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_9");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__105_10");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__130_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__130_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__137_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__137_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__138_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__138_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__151_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__151_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__152_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__152_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__153_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__153_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__154_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__154_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__155_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__155_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__156_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__156_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__157_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__157_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__182_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__182_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__188_1");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__188_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__196_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__196_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__197_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__197_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__198_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__198_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__211_0");
				RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, "<>9__211_1");
				RunTimeAlbum.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676190);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByType_b__99_0_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676191);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByType_b__99_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676192);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676193);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_1_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676194);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676195);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_3_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676196);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676197);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_5_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676198);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676199);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_7_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676200);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_0_Internal_Int32_KeyValuePair_2_String_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676201);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676202);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_2_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676203);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_3_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676204);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_4_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676205);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_5_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676206);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_6_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676207);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_7_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676208);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_8_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676209);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_9_Internal_Dictionary_2_Int32_SpecialGuestRunTimeData_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676210);
				RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_10_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676211);
				RunTimeAlbum.__c.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__130_1_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676212);
				RunTimeAlbum.__c.NativeMethodInfoPtr__UpdateNegativeSpellCardTotalNum_b__137_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676213);
				RunTimeAlbum.__c.NativeMethodInfoPtr__UpdatePositiveSpellCardTotalNum_b__138_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676214);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedFoods_b__151_0_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676215);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedBeverages_b__152_0_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676216);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedIngredients_b__153_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676217);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedCookers_b__154_0_Internal_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676218);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedItems_b__155_0_Internal_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676219);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedBadges_b__156_0_Internal_Badge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676220);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllUsingDecorations_b__157_0_Internal_Decoration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676221);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_0_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676222);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_1_Internal_Int32_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676223);
				RunTimeAlbum.__c.NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676224);
				RunTimeAlbum.__c.NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_0_Internal_Void_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676225);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumIngredientsOrderByDatabase_b__196_0_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676226);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumFoodsOrderByDatabase_b__197_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676227);
				RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumBevsOrderByDatabase_b__198_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676228);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676229);
				RunTimeAlbum.__c.NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_1_Internal_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr, 100676230);
			}

			// Token: 0x0600C59F RID: 50591 RVA: 0x00311CE8 File Offset: 0x0030FEE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5A0 RID: 50592 RVA: 0x00311D24 File Offset: 0x0030FF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167241, XrefRangeEnd = 167260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<Ingredient, int>> _ClassifyIngredientByType_b__99_0(List<KeyValuePair<Ingredient, int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByType_b__99_0_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C5A1 RID: 50593 RVA: 0x00311D74 File Offset: 0x0030FF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167260, XrefRangeEnd = 167261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ClassifyIngredientByType_b__99_1(KeyValuePair<Ingredient, int> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByType_b__99_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A2 RID: 50594 RVA: 0x00311DC8 File Offset: 0x0030FFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167261, XrefRangeEnd = 167264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_0(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A3 RID: 50595 RVA: 0x00311E1C File Offset: 0x0031001C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167264, XrefRangeEnd = 167270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_1(KeyValuePair<Ingredient, int> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_1_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A4 RID: 50596 RVA: 0x00311E70 File Offset: 0x00310070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167270, XrefRangeEnd = 167273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_2(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A5 RID: 50597 RVA: 0x00311EC4 File Offset: 0x003100C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167273, XrefRangeEnd = 167279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_3(KeyValuePair<Ingredient, int> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_3_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A6 RID: 50598 RVA: 0x00311F18 File Offset: 0x00310118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167279, XrefRangeEnd = 167282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_4(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A7 RID: 50599 RVA: 0x00311F6C File Offset: 0x0031016C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167282, XrefRangeEnd = 167288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_5(KeyValuePair<Ingredient, int> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_5_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A8 RID: 50600 RVA: 0x00311FC0 File Offset: 0x003101C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167288, XrefRangeEnd = 167291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_6(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5A9 RID: 50601 RVA: 0x00312014 File Offset: 0x00310214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167291, XrefRangeEnd = 167297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClassifyIngredientByTypeCore_b__100_7(KeyValuePair<Ingredient, int> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_7_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5AA RID: 50602 RVA: 0x00312068 File Offset: 0x00310268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167297, XrefRangeEnd = 167298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__105_0(KeyValuePair<string, PlayerSaveFile.DLCAlbumSaveData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_0_Internal_Int32_KeyValuePair_2_String_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5AB RID: 50603 RVA: 0x003120BC File Offset: 0x003102BC
			[CallerCount(0)]
			public unsafe bool _Initialize_b__105_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5AC RID: 50604 RVA: 0x00312108 File Offset: 0x00310308
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_2(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_2_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5AD RID: 50605 RVA: 0x00312160 File Offset: 0x00310360
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_3(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_3_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5AE RID: 50606 RVA: 0x003121B8 File Offset: 0x003103B8
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_4(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_4_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5AF RID: 50607 RVA: 0x00312210 File Offset: 0x00310410
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_5(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_5_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5B0 RID: 50608 RVA: 0x00312268 File Offset: 0x00310468
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_6(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_6_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5B1 RID: 50609 RVA: 0x003122C0 File Offset: 0x003104C0
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_7(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_7_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5B2 RID: 50610 RVA: 0x00312318 File Offset: 0x00310518
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__105_8(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_8_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5B3 RID: 50611 RVA: 0x00312370 File Offset: 0x00310570
			[CallerCount(0)]
			public unsafe Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> _Initialize_b__105_9(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_9_Internal_Dictionary_2_Int32_SpecialGuestRunTimeData_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr3) : null;
			}

			// Token: 0x0600C5B4 RID: 50612 RVA: 0x003123C8 File Offset: 0x003105C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167298, XrefRangeEnd = 167301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _Initialize_b__105_10(PlayerSaveFile.DLCAlbumSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__Initialize_b__105_10_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C5B5 RID: 50613 RVA: 0x00312420 File Offset: 0x00310620
			[CallerCount(0)]
			public unsafe int _CheckAllRevealedDataIsUnlocked_b__130_1(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__130_1_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5B6 RID: 50614 RVA: 0x00312470 File Offset: 0x00310670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167301, XrefRangeEnd = 167308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateNegativeSpellCardTotalNum_b__137_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__UpdateNegativeSpellCardTotalNum_b__137_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5B7 RID: 50615 RVA: 0x003124B4 File Offset: 0x003106B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167308, XrefRangeEnd = 167315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePositiveSpellCardTotalNum_b__138_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__UpdatePositiveSpellCardTotalNum_b__138_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5B8 RID: 50616 RVA: 0x003124F8 File Offset: 0x003106F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167315, XrefRangeEnd = 167316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _GetAllRecordedFoods_b__151_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedFoods_b__151_0_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600C5B9 RID: 50617 RVA: 0x00312544 File Offset: 0x00310744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167316, XrefRangeEnd = 167317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _GetAllRecordedBeverages_b__152_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedBeverages_b__152_0_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600C5BA RID: 50618 RVA: 0x00312590 File Offset: 0x00310790
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _GetAllRecordedIngredients_b__153_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedIngredients_b__153_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600C5BB RID: 50619 RVA: 0x003125DC File Offset: 0x003107DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker _GetAllRecordedCookers_b__154_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedCookers_b__154_0_Internal_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}

			// Token: 0x0600C5BC RID: 50620 RVA: 0x00312628 File Offset: 0x00310828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167317, XrefRangeEnd = 167318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item _GetAllRecordedItems_b__155_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedItems_b__155_0_Internal_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
			}

			// Token: 0x0600C5BD RID: 50621 RVA: 0x00312674 File Offset: 0x00310874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167318, XrefRangeEnd = 167319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Badge _GetAllRecordedBadges_b__156_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllRecordedBadges_b__156_0_Internal_Badge_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Badge>(intPtr3) : null;
			}

			// Token: 0x0600C5BE RID: 50622 RVA: 0x003126C0 File Offset: 0x003108C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167319, XrefRangeEnd = 167320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoration _GetAllUsingDecorations_b__157_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAllUsingDecorations_b__157_0_Internal_Decoration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr3) : null;
			}

			// Token: 0x0600C5BF RID: 50623 RVA: 0x0031270C File Offset: 0x0031090C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167320, XrefRangeEnd = 167321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLevel5KizunaNPCData_b__182_0(KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_0_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C0 RID: 50624 RVA: 0x00312760 File Offset: 0x00310960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167321, XrefRangeEnd = 167322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetLevel5KizunaNPCData_b__182_1(KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_1_Internal_Int32_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C1 RID: 50625 RVA: 0x003127B4 File Offset: 0x003109B4
			[CallerCount(0)]
			public unsafe int _RefreshAllKizunaLevelUpdateData_b__188_1(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C2 RID: 50626 RVA: 0x00312800 File Offset: 0x00310A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167322, XrefRangeEnd = 167328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshAllKizunaLevelUpdateData_b__188_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_0_Internal_Void_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5C3 RID: 50627 RVA: 0x00312848 File Offset: 0x00310A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167328, XrefRangeEnd = 167339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAlbumIngredientsOrderByDatabase_b__196_0(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumIngredientsOrderByDatabase_b__196_0_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C4 RID: 50628 RVA: 0x00312898 File Offset: 0x00310A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167339, XrefRangeEnd = 167350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAlbumFoodsOrderByDatabase_b__197_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumFoodsOrderByDatabase_b__197_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C5 RID: 50629 RVA: 0x003128E8 File Offset: 0x00310AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167350, XrefRangeEnd = 167361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAlbumBevsOrderByDatabase_b__198_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__GetAlbumBevsOrderByDatabase_b__198_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C6 RID: 50630 RVA: 0x00312938 File Offset: 0x00310B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167361, XrefRangeEnd = 167368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearAndDumpRunTimeAlbumData_b__211_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C7 RID: 50631 RVA: 0x00312984 File Offset: 0x00310B84
			[CallerCount(0)]
			public unsafe int _ClearAndDumpRunTimeAlbumData_b__211_1(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c.NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_1_Internal_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C5C8 RID: 50632 RVA: 0x0006AA29 File Offset: 0x00068C29
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004062 RID: 16482
			// (get) Token: 0x0600C5C9 RID: 50633 RVA: 0x003129D4 File Offset: 0x00310BD4
			// (set) Token: 0x0600C5CA RID: 50634 RVA: 0x0006AA32 File Offset: 0x00068C32
			public unsafe static RunTimeAlbum.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004063 RID: 16483
			// (get) Token: 0x0600C5CB RID: 50635 RVA: 0x003129FC File Offset: 0x00310BFC
			// (set) Token: 0x0600C5CC RID: 50636 RVA: 0x0006AA44 File Offset: 0x00068C44
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__99_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004064 RID: 16484
			// (get) Token: 0x0600C5CD RID: 50637 RVA: 0x00312A24 File Offset: 0x00310C24
			// (set) Token: 0x0600C5CE RID: 50638 RVA: 0x0006AA56 File Offset: 0x00068C56
			public unsafe static Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>> __9__99_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004065 RID: 16485
			// (get) Token: 0x0600C5CF RID: 50639 RVA: 0x00312A4C File Offset: 0x00310C4C
			// (set) Token: 0x0600C5D0 RID: 50640 RVA: 0x0006AA68 File Offset: 0x00068C68
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004066 RID: 16486
			// (get) Token: 0x0600C5D1 RID: 50641 RVA: 0x00312A74 File Offset: 0x00310C74
			// (set) Token: 0x0600C5D2 RID: 50642 RVA: 0x0006AA7A File Offset: 0x00068C7A
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004067 RID: 16487
			// (get) Token: 0x0600C5D3 RID: 50643 RVA: 0x00312A9C File Offset: 0x00310C9C
			// (set) Token: 0x0600C5D4 RID: 50644 RVA: 0x0006AA8C File Offset: 0x00068C8C
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004068 RID: 16488
			// (get) Token: 0x0600C5D5 RID: 50645 RVA: 0x00312AC4 File Offset: 0x00310CC4
			// (set) Token: 0x0600C5D6 RID: 50646 RVA: 0x0006AA9E File Offset: 0x00068C9E
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004069 RID: 16489
			// (get) Token: 0x0600C5D7 RID: 50647 RVA: 0x00312AEC File Offset: 0x00310CEC
			// (set) Token: 0x0600C5D8 RID: 50648 RVA: 0x0006AAB0 File Offset: 0x00068CB0
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406A RID: 16490
			// (get) Token: 0x0600C5D9 RID: 50649 RVA: 0x00312B14 File Offset: 0x00310D14
			// (set) Token: 0x0600C5DA RID: 50650 RVA: 0x0006AAC2 File Offset: 0x00068CC2
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406B RID: 16491
			// (get) Token: 0x0600C5DB RID: 50651 RVA: 0x00312B3C File Offset: 0x00310D3C
			// (set) Token: 0x0600C5DC RID: 50652 RVA: 0x0006AAD4 File Offset: 0x00068CD4
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406C RID: 16492
			// (get) Token: 0x0600C5DD RID: 50653 RVA: 0x00312B64 File Offset: 0x00310D64
			// (set) Token: 0x0600C5DE RID: 50654 RVA: 0x0006AAE6 File Offset: 0x00068CE6
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__100_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__100_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406D RID: 16493
			// (get) Token: 0x0600C5DF RID: 50655 RVA: 0x00312B8C File Offset: 0x00310D8C
			// (set) Token: 0x0600C5E0 RID: 50656 RVA: 0x0006AAF8 File Offset: 0x00068CF8
			public unsafe static Func<KeyValuePair<string, PlayerSaveFile.DLCAlbumSaveData>, int> __9__105_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, PlayerSaveFile.DLCAlbumSaveData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406E RID: 16494
			// (get) Token: 0x0600C5E1 RID: 50657 RVA: 0x00312BB4 File Offset: 0x00310DB4
			// (set) Token: 0x0600C5E2 RID: 50658 RVA: 0x0006AB0A File Offset: 0x00068D0A
			public unsafe static Func<int, bool> __9__105_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406F RID: 16495
			// (get) Token: 0x0600C5E3 RID: 50659 RVA: 0x00312BDC File Offset: 0x00310DDC
			// (set) Token: 0x0600C5E4 RID: 50660 RVA: 0x0006AB1C File Offset: 0x00068D1C
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004070 RID: 16496
			// (get) Token: 0x0600C5E5 RID: 50661 RVA: 0x00312C04 File Offset: 0x00310E04
			// (set) Token: 0x0600C5E6 RID: 50662 RVA: 0x0006AB2E File Offset: 0x00068D2E
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004071 RID: 16497
			// (get) Token: 0x0600C5E7 RID: 50663 RVA: 0x00312C2C File Offset: 0x00310E2C
			// (set) Token: 0x0600C5E8 RID: 50664 RVA: 0x0006AB40 File Offset: 0x00068D40
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004072 RID: 16498
			// (get) Token: 0x0600C5E9 RID: 50665 RVA: 0x00312C54 File Offset: 0x00310E54
			// (set) Token: 0x0600C5EA RID: 50666 RVA: 0x0006AB52 File Offset: 0x00068D52
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004073 RID: 16499
			// (get) Token: 0x0600C5EB RID: 50667 RVA: 0x00312C7C File Offset: 0x00310E7C
			// (set) Token: 0x0600C5EC RID: 50668 RVA: 0x0006AB64 File Offset: 0x00068D64
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004074 RID: 16500
			// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x00312CA4 File Offset: 0x00310EA4
			// (set) Token: 0x0600C5EE RID: 50670 RVA: 0x0006AB76 File Offset: 0x00068D76
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004075 RID: 16501
			// (get) Token: 0x0600C5EF RID: 50671 RVA: 0x00312CCC File Offset: 0x00310ECC
			// (set) Token: 0x0600C5F0 RID: 50672 RVA: 0x0006AB88 File Offset: 0x00068D88
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004076 RID: 16502
			// (get) Token: 0x0600C5F1 RID: 50673 RVA: 0x00312CF4 File Offset: 0x00310EF4
			// (set) Token: 0x0600C5F2 RID: 50674 RVA: 0x0006AB9A File Offset: 0x00068D9A
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>> __9__105_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004077 RID: 16503
			// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00312D1C File Offset: 0x00310F1C
			// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x0006ABAC File Offset: 0x00068DAC
			public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>> __9__105_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__105_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004078 RID: 16504
			// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x00312D44 File Offset: 0x00310F44
			// (set) Token: 0x0600C5F6 RID: 50678 RVA: 0x0006ABBE File Offset: 0x00068DBE
			public unsafe static Func<Izakaya, int> __9__130_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__130_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__130_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004079 RID: 16505
			// (get) Token: 0x0600C5F7 RID: 50679 RVA: 0x00312D6C File Offset: 0x00310F6C
			// (set) Token: 0x0600C5F8 RID: 50680 RVA: 0x0006ABD0 File Offset: 0x00068DD0
			public unsafe static Action<AchievementNotifyResult> __9__137_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__137_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__137_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407A RID: 16506
			// (get) Token: 0x0600C5F9 RID: 50681 RVA: 0x00312D94 File Offset: 0x00310F94
			// (set) Token: 0x0600C5FA RID: 50682 RVA: 0x0006ABE2 File Offset: 0x00068DE2
			public unsafe static Action<AchievementNotifyResult> __9__138_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__138_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__138_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407B RID: 16507
			// (get) Token: 0x0600C5FB RID: 50683 RVA: 0x00312DBC File Offset: 0x00310FBC
			// (set) Token: 0x0600C5FC RID: 50684 RVA: 0x0006ABF4 File Offset: 0x00068DF4
			public unsafe static Func<int, Sellable> __9__151_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__151_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__151_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407C RID: 16508
			// (get) Token: 0x0600C5FD RID: 50685 RVA: 0x00312DE4 File Offset: 0x00310FE4
			// (set) Token: 0x0600C5FE RID: 50686 RVA: 0x0006AC06 File Offset: 0x00068E06
			public unsafe static Func<int, Sellable> __9__152_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__152_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__152_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407D RID: 16509
			// (get) Token: 0x0600C5FF RID: 50687 RVA: 0x00312E0C File Offset: 0x0031100C
			// (set) Token: 0x0600C600 RID: 50688 RVA: 0x0006AC18 File Offset: 0x00068E18
			public unsafe static Func<int, Ingredient> __9__153_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__153_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__153_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407E RID: 16510
			// (get) Token: 0x0600C601 RID: 50689 RVA: 0x00312E34 File Offset: 0x00311034
			// (set) Token: 0x0600C602 RID: 50690 RVA: 0x0006AC2A File Offset: 0x00068E2A
			public unsafe static Func<int, Cooker> __9__154_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__154_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__154_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407F RID: 16511
			// (get) Token: 0x0600C603 RID: 50691 RVA: 0x00312E5C File Offset: 0x0031105C
			// (set) Token: 0x0600C604 RID: 50692 RVA: 0x0006AC3C File Offset: 0x00068E3C
			public unsafe static Func<int, Item> __9__155_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__155_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__155_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004080 RID: 16512
			// (get) Token: 0x0600C605 RID: 50693 RVA: 0x00312E84 File Offset: 0x00311084
			// (set) Token: 0x0600C606 RID: 50694 RVA: 0x0006AC4E File Offset: 0x00068E4E
			public unsafe static Func<int, Badge> __9__156_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__156_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Badge>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__156_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004081 RID: 16513
			// (get) Token: 0x0600C607 RID: 50695 RVA: 0x00312EAC File Offset: 0x003110AC
			// (set) Token: 0x0600C608 RID: 50696 RVA: 0x0006AC60 File Offset: 0x00068E60
			public unsafe static Func<int, Decoration> __9__157_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__157_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Decoration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__157_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004082 RID: 16514
			// (get) Token: 0x0600C609 RID: 50697 RVA: 0x00312ED4 File Offset: 0x003110D4
			// (set) Token: 0x0600C60A RID: 50698 RVA: 0x0006AC72 File Offset: 0x00068E72
			public unsafe static Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, bool> __9__182_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004083 RID: 16515
			// (get) Token: 0x0600C60B RID: 50699 RVA: 0x00312EFC File Offset: 0x003110FC
			// (set) Token: 0x0600C60C RID: 50700 RVA: 0x0006AC84 File Offset: 0x00068E84
			public unsafe static Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, int> __9__182_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__182_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004084 RID: 16516
			// (get) Token: 0x0600C60D RID: 50701 RVA: 0x00312F24 File Offset: 0x00311124
			// (set) Token: 0x0600C60E RID: 50702 RVA: 0x0006AC96 File Offset: 0x00068E96
			public unsafe static Func<int, int> __9__188_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004085 RID: 16517
			// (get) Token: 0x0600C60F RID: 50703 RVA: 0x00312F4C File Offset: 0x0031114C
			// (set) Token: 0x0600C610 RID: 50704 RVA: 0x0006ACA8 File Offset: 0x00068EA8
			public unsafe static Action<KeyValuePair<int, int>> __9__188_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__188_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004086 RID: 16518
			// (get) Token: 0x0600C611 RID: 50705 RVA: 0x00312F74 File Offset: 0x00311174
			// (set) Token: 0x0600C612 RID: 50706 RVA: 0x0006ACBA File Offset: 0x00068EBA
			public unsafe static Func<Ingredient, bool> __9__196_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__196_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__196_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004087 RID: 16519
			// (get) Token: 0x0600C613 RID: 50707 RVA: 0x00312F9C File Offset: 0x0031119C
			// (set) Token: 0x0600C614 RID: 50708 RVA: 0x0006ACCC File Offset: 0x00068ECC
			public unsafe static Func<Sellable, bool> __9__197_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__197_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__197_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004088 RID: 16520
			// (get) Token: 0x0600C615 RID: 50709 RVA: 0x00312FC4 File Offset: 0x003111C4
			// (set) Token: 0x0600C616 RID: 50710 RVA: 0x0006ACDE File Offset: 0x00068EDE
			public unsafe static Func<Sellable, bool> __9__198_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__198_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__198_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004089 RID: 16521
			// (get) Token: 0x0600C617 RID: 50711 RVA: 0x00312FEC File Offset: 0x003111EC
			// (set) Token: 0x0600C618 RID: 50712 RVA: 0x0006ACF0 File Offset: 0x00068EF0
			public unsafe static Func<int, bool> __9__211_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700408A RID: 16522
			// (get) Token: 0x0600C619 RID: 50713 RVA: 0x00313014 File Offset: 0x00311214
			// (set) Token: 0x0600C61A RID: 50714 RVA: 0x0006AD02 File Offset: 0x00068F02
			public unsafe static Func<NormalGuest, int> __9__211_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeAlbum.__c.NativeFieldInfoPtr___9__211_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F08 RID: 32520
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007F09 RID: 32521
			private static readonly IntPtr NativeFieldInfoPtr___9__99_1;

			// Token: 0x04007F0A RID: 32522
			private static readonly IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x04007F0B RID: 32523
			private static readonly IntPtr NativeFieldInfoPtr___9__100_0;

			// Token: 0x04007F0C RID: 32524
			private static readonly IntPtr NativeFieldInfoPtr___9__100_1;

			// Token: 0x04007F0D RID: 32525
			private static readonly IntPtr NativeFieldInfoPtr___9__100_2;

			// Token: 0x04007F0E RID: 32526
			private static readonly IntPtr NativeFieldInfoPtr___9__100_3;

			// Token: 0x04007F0F RID: 32527
			private static readonly IntPtr NativeFieldInfoPtr___9__100_4;

			// Token: 0x04007F10 RID: 32528
			private static readonly IntPtr NativeFieldInfoPtr___9__100_5;

			// Token: 0x04007F11 RID: 32529
			private static readonly IntPtr NativeFieldInfoPtr___9__100_6;

			// Token: 0x04007F12 RID: 32530
			private static readonly IntPtr NativeFieldInfoPtr___9__100_7;

			// Token: 0x04007F13 RID: 32531
			private static readonly IntPtr NativeFieldInfoPtr___9__105_0;

			// Token: 0x04007F14 RID: 32532
			private static readonly IntPtr NativeFieldInfoPtr___9__105_1;

			// Token: 0x04007F15 RID: 32533
			private static readonly IntPtr NativeFieldInfoPtr___9__105_2;

			// Token: 0x04007F16 RID: 32534
			private static readonly IntPtr NativeFieldInfoPtr___9__105_3;

			// Token: 0x04007F17 RID: 32535
			private static readonly IntPtr NativeFieldInfoPtr___9__105_4;

			// Token: 0x04007F18 RID: 32536
			private static readonly IntPtr NativeFieldInfoPtr___9__105_5;

			// Token: 0x04007F19 RID: 32537
			private static readonly IntPtr NativeFieldInfoPtr___9__105_6;

			// Token: 0x04007F1A RID: 32538
			private static readonly IntPtr NativeFieldInfoPtr___9__105_7;

			// Token: 0x04007F1B RID: 32539
			private static readonly IntPtr NativeFieldInfoPtr___9__105_8;

			// Token: 0x04007F1C RID: 32540
			private static readonly IntPtr NativeFieldInfoPtr___9__105_9;

			// Token: 0x04007F1D RID: 32541
			private static readonly IntPtr NativeFieldInfoPtr___9__105_10;

			// Token: 0x04007F1E RID: 32542
			private static readonly IntPtr NativeFieldInfoPtr___9__130_1;

			// Token: 0x04007F1F RID: 32543
			private static readonly IntPtr NativeFieldInfoPtr___9__137_0;

			// Token: 0x04007F20 RID: 32544
			private static readonly IntPtr NativeFieldInfoPtr___9__138_0;

			// Token: 0x04007F21 RID: 32545
			private static readonly IntPtr NativeFieldInfoPtr___9__151_0;

			// Token: 0x04007F22 RID: 32546
			private static readonly IntPtr NativeFieldInfoPtr___9__152_0;

			// Token: 0x04007F23 RID: 32547
			private static readonly IntPtr NativeFieldInfoPtr___9__153_0;

			// Token: 0x04007F24 RID: 32548
			private static readonly IntPtr NativeFieldInfoPtr___9__154_0;

			// Token: 0x04007F25 RID: 32549
			private static readonly IntPtr NativeFieldInfoPtr___9__155_0;

			// Token: 0x04007F26 RID: 32550
			private static readonly IntPtr NativeFieldInfoPtr___9__156_0;

			// Token: 0x04007F27 RID: 32551
			private static readonly IntPtr NativeFieldInfoPtr___9__157_0;

			// Token: 0x04007F28 RID: 32552
			private static readonly IntPtr NativeFieldInfoPtr___9__182_0;

			// Token: 0x04007F29 RID: 32553
			private static readonly IntPtr NativeFieldInfoPtr___9__182_1;

			// Token: 0x04007F2A RID: 32554
			private static readonly IntPtr NativeFieldInfoPtr___9__188_1;

			// Token: 0x04007F2B RID: 32555
			private static readonly IntPtr NativeFieldInfoPtr___9__188_0;

			// Token: 0x04007F2C RID: 32556
			private static readonly IntPtr NativeFieldInfoPtr___9__196_0;

			// Token: 0x04007F2D RID: 32557
			private static readonly IntPtr NativeFieldInfoPtr___9__197_0;

			// Token: 0x04007F2E RID: 32558
			private static readonly IntPtr NativeFieldInfoPtr___9__198_0;

			// Token: 0x04007F2F RID: 32559
			private static readonly IntPtr NativeFieldInfoPtr___9__211_0;

			// Token: 0x04007F30 RID: 32560
			private static readonly IntPtr NativeFieldInfoPtr___9__211_1;

			// Token: 0x04007F31 RID: 32561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F32 RID: 32562
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByType_b__99_0_Internal_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F33 RID: 32563
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByType_b__99_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F34 RID: 32564
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F35 RID: 32565
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_1_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F36 RID: 32566
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F37 RID: 32567
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_3_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F38 RID: 32568
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F39 RID: 32569
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_5_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F3A RID: 32570
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F3B RID: 32571
			private static readonly IntPtr NativeMethodInfoPtr__ClassifyIngredientByTypeCore_b__100_7_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F3C RID: 32572
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_0_Internal_Int32_KeyValuePair_2_String_DLCAlbumSaveData_0;

			// Token: 0x04007F3D RID: 32573
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_1_Internal_Boolean_Int32_0;

			// Token: 0x04007F3E RID: 32574
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_2_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F3F RID: 32575
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_3_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F40 RID: 32576
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_4_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F41 RID: 32577
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_5_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F42 RID: 32578
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_6_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F43 RID: 32579
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_7_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F44 RID: 32580
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_8_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F45 RID: 32581
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_9_Internal_Dictionary_2_Int32_SpecialGuestRunTimeData_DLCAlbumSaveData_0;

			// Token: 0x04007F46 RID: 32582
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__105_10_Internal_IEnumerable_1_Int32_DLCAlbumSaveData_0;

			// Token: 0x04007F47 RID: 32583
			private static readonly IntPtr NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__130_1_Internal_Int32_Izakaya_0;

			// Token: 0x04007F48 RID: 32584
			private static readonly IntPtr NativeMethodInfoPtr__UpdateNegativeSpellCardTotalNum_b__137_0_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x04007F49 RID: 32585
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePositiveSpellCardTotalNum_b__138_0_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x04007F4A RID: 32586
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedFoods_b__151_0_Internal_Sellable_Int32_0;

			// Token: 0x04007F4B RID: 32587
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedBeverages_b__152_0_Internal_Sellable_Int32_0;

			// Token: 0x04007F4C RID: 32588
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedIngredients_b__153_0_Internal_Ingredient_Int32_0;

			// Token: 0x04007F4D RID: 32589
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedCookers_b__154_0_Internal_Cooker_Int32_0;

			// Token: 0x04007F4E RID: 32590
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedItems_b__155_0_Internal_Item_Int32_0;

			// Token: 0x04007F4F RID: 32591
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecordedBadges_b__156_0_Internal_Badge_Int32_0;

			// Token: 0x04007F50 RID: 32592
			private static readonly IntPtr NativeMethodInfoPtr__GetAllUsingDecorations_b__157_0_Internal_Decoration_Int32_0;

			// Token: 0x04007F51 RID: 32593
			private static readonly IntPtr NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_0_Internal_Boolean_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0;

			// Token: 0x04007F52 RID: 32594
			private static readonly IntPtr NativeMethodInfoPtr__GetLevel5KizunaNPCData_b__182_1_Internal_Int32_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0;

			// Token: 0x04007F53 RID: 32595
			private static readonly IntPtr NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_1_Internal_Int32_Int32_0;

			// Token: 0x04007F54 RID: 32596
			private static readonly IntPtr NativeMethodInfoPtr__RefreshAllKizunaLevelUpdateData_b__188_0_Internal_Void_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04007F55 RID: 32597
			private static readonly IntPtr NativeMethodInfoPtr__GetAlbumIngredientsOrderByDatabase_b__196_0_Internal_Boolean_Ingredient_0;

			// Token: 0x04007F56 RID: 32598
			private static readonly IntPtr NativeMethodInfoPtr__GetAlbumFoodsOrderByDatabase_b__197_0_Internal_Boolean_Sellable_0;

			// Token: 0x04007F57 RID: 32599
			private static readonly IntPtr NativeMethodInfoPtr__GetAlbumBevsOrderByDatabase_b__198_0_Internal_Boolean_Sellable_0;

			// Token: 0x04007F58 RID: 32600
			private static readonly IntPtr NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_0_Internal_Boolean_Int32_0;

			// Token: 0x04007F59 RID: 32601
			private static readonly IntPtr NativeMethodInfoPtr__ClearAndDumpRunTimeAlbumData_b__211_1_Internal_Int32_NormalGuest_0;
		}

		// Token: 0x02000A2D RID: 2605
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<GetIngredientWithRecord>d__101")]
		public sealed class _GetIngredientWithRecord_d__101 : Object
		{
			// Token: 0x0600C61B RID: 50715 RVA: 0x0031303C File Offset: 0x0031123C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetIngredientWithRecord_d__101()
			{
				Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<GetIngredientWithRecord>d__101");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, "<>1__state");
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, "<>2__current");
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, "<>l__initialThreadId");
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, "<>7__wrap1");
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676231);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676232);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676233);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676234);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676235);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676236);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676237);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676238);
				RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr, 100676239);
			}

			// Token: 0x0600C61C RID: 50716 RVA: 0x0031316C File Offset: 0x0031136C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetIngredientWithRecord_d__101(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum._GetIngredientWithRecord_d__101>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C61D RID: 50717 RVA: 0x003131B4 File Offset: 0x003113B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167368, XrefRangeEnd = 167373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C61E RID: 50718 RVA: 0x003131E8 File Offset: 0x003113E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167373, XrefRangeEnd = 167425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C61F RID: 50719 RVA: 0x00313224 File Offset: 0x00311424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167425, XrefRangeEnd = 167428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700408F RID: 16527
			// (get) Token: 0x0600C620 RID: 50720 RVA: 0x00313258 File Offset: 0x00311458
			public unsafe KeyValuePair<Ingredient, int> prop_KeyValuePair_2_Ingredient_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<Ingredient, int>(pointer);
				}
			}

			// Token: 0x0600C621 RID: 50721 RVA: 0x00313290 File Offset: 0x00311490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167428, XrefRangeEnd = 167434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004090 RID: 16528
			// (get) Token: 0x0600C622 RID: 50722 RVA: 0x003132C4 File Offset: 0x003114C4
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167434, XrefRangeEnd = 167437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C623 RID: 50723 RVA: 0x00313304 File Offset: 0x00311504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167437, XrefRangeEnd = 167439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<Ingredient, int>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Ingredient_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C624 RID: 50724 RVA: 0x00313344 File Offset: 0x00311544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C625 RID: 50725 RVA: 0x0006AD14 File Offset: 0x00068F14
			public _GetIngredientWithRecord_d__101(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408B RID: 16523
			// (get) Token: 0x0600C626 RID: 50726 RVA: 0x00313384 File Offset: 0x00311584
			// (set) Token: 0x0600C627 RID: 50727 RVA: 0x0006AD1D File Offset: 0x00068F1D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700408C RID: 16524
			// (get) Token: 0x0600C628 RID: 50728 RVA: 0x003133AC File Offset: 0x003115AC
			// (set) Token: 0x0600C629 RID: 50729 RVA: 0x0006AD38 File Offset: 0x00068F38
			public KeyValuePair<Ingredient, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<Ingredient, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Ingredient, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Ingredient, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700408D RID: 16525
			// (get) Token: 0x0600C62A RID: 50730 RVA: 0x003133DC File Offset: 0x003115DC
			// (set) Token: 0x0600C62B RID: 50731 RVA: 0x0006AD66 File Offset: 0x00068F66
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700408E RID: 16526
			// (get) Token: 0x0600C62C RID: 50732 RVA: 0x00313404 File Offset: 0x00311604
			// (set) Token: 0x0600C62D RID: 50733 RVA: 0x0006AD81 File Offset: 0x00068F81
			public unsafe IEnumerator<Ingredient> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Ingredient>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetIngredientWithRecord_d__101.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F5A RID: 32602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F5B RID: 32603
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F5C RID: 32604
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F5D RID: 32605
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04007F5E RID: 32606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F5F RID: 32607
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F60 RID: 32608
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F61 RID: 32609
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007F62 RID: 32610
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F63 RID: 32611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F64 RID: 32612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F65 RID: 32613
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04007F66 RID: 32614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A2E RID: 2606
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<GetFoodWithRecord>d__102")]
		public sealed class _GetFoodWithRecord_d__102 : Object
		{
			// Token: 0x0600C62E RID: 50734 RVA: 0x00313434 File Offset: 0x00311634
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFoodWithRecord_d__102()
			{
				Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<GetFoodWithRecord>d__102");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, "<>1__state");
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, "<>2__current");
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, "<>l__initialThreadId");
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, "<>7__wrap1");
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676240);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676241);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676242);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676243);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676244);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676245);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676246);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676247);
				RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr, 100676248);
			}

			// Token: 0x0600C62F RID: 50735 RVA: 0x00313564 File Offset: 0x00311764
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFoodWithRecord_d__102(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum._GetFoodWithRecord_d__102>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C630 RID: 50736 RVA: 0x003135AC File Offset: 0x003117AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167439, XrefRangeEnd = 167444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C631 RID: 50737 RVA: 0x003135E0 File Offset: 0x003117E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167444, XrefRangeEnd = 167495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C632 RID: 50738 RVA: 0x0031361C File Offset: 0x0031181C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167495, XrefRangeEnd = 167498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004095 RID: 16533
			// (get) Token: 0x0600C633 RID: 50739 RVA: 0x00313650 File Offset: 0x00311850
			public unsafe KeyValuePair<Sellable, int> prop_KeyValuePair_2_Sellable_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<Sellable, int>(pointer);
				}
			}

			// Token: 0x0600C634 RID: 50740 RVA: 0x00313688 File Offset: 0x00311888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167498, XrefRangeEnd = 167504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004096 RID: 16534
			// (get) Token: 0x0600C635 RID: 50741 RVA: 0x003136BC File Offset: 0x003118BC
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167504, XrefRangeEnd = 167507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C636 RID: 50742 RVA: 0x003136FC File Offset: 0x003118FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167507, XrefRangeEnd = 167509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<Sellable, int>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C637 RID: 50743 RVA: 0x0031373C File Offset: 0x0031193C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetFoodWithRecord_d__102.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C638 RID: 50744 RVA: 0x0006ADA0 File Offset: 0x00068FA0
			public _GetFoodWithRecord_d__102(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004091 RID: 16529
			// (get) Token: 0x0600C639 RID: 50745 RVA: 0x0031377C File Offset: 0x0031197C
			// (set) Token: 0x0600C63A RID: 50746 RVA: 0x0006ADA9 File Offset: 0x00068FA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004092 RID: 16530
			// (get) Token: 0x0600C63B RID: 50747 RVA: 0x003137A4 File Offset: 0x003119A4
			// (set) Token: 0x0600C63C RID: 50748 RVA: 0x0006ADC4 File Offset: 0x00068FC4
			public KeyValuePair<Sellable, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<Sellable, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004093 RID: 16531
			// (get) Token: 0x0600C63D RID: 50749 RVA: 0x003137D4 File Offset: 0x003119D4
			// (set) Token: 0x0600C63E RID: 50750 RVA: 0x0006ADF2 File Offset: 0x00068FF2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004094 RID: 16532
			// (get) Token: 0x0600C63F RID: 50751 RVA: 0x003137FC File Offset: 0x003119FC
			// (set) Token: 0x0600C640 RID: 50752 RVA: 0x0006AE0D File Offset: 0x0006900D
			public unsafe IEnumerator<Sellable> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetFoodWithRecord_d__102.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F67 RID: 32615
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F68 RID: 32616
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F69 RID: 32617
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F6A RID: 32618
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04007F6B RID: 32619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F6C RID: 32620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F6D RID: 32621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F6E RID: 32622
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007F6F RID: 32623
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04007F70 RID: 32624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F71 RID: 32625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F72 RID: 32626
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04007F73 RID: 32627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A2F RID: 2607
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<GetBeverageWithRecord>d__103")]
		public sealed class _GetBeverageWithRecord_d__103 : Object
		{
			// Token: 0x0600C641 RID: 50753 RVA: 0x0031382C File Offset: 0x00311A2C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetBeverageWithRecord_d__103()
			{
				Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<GetBeverageWithRecord>d__103");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, "<>1__state");
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, "<>2__current");
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, "<>l__initialThreadId");
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, "<>7__wrap1");
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676249);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676250);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676251);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676252);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676253);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676254);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676255);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676256);
				RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr, 100676257);
			}

			// Token: 0x0600C642 RID: 50754 RVA: 0x0031395C File Offset: 0x00311B5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetBeverageWithRecord_d__103(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum._GetBeverageWithRecord_d__103>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C643 RID: 50755 RVA: 0x003139A4 File Offset: 0x00311BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167509, XrefRangeEnd = 167514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C644 RID: 50756 RVA: 0x003139D8 File Offset: 0x00311BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167514, XrefRangeEnd = 167565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C645 RID: 50757 RVA: 0x00313A14 File Offset: 0x00311C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167565, XrefRangeEnd = 167568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700409B RID: 16539
			// (get) Token: 0x0600C646 RID: 50758 RVA: 0x00313A48 File Offset: 0x00311C48
			public unsafe KeyValuePair<Sellable, int> prop_KeyValuePair_2_Sellable_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<Sellable, int>(pointer);
				}
			}

			// Token: 0x0600C647 RID: 50759 RVA: 0x00313A80 File Offset: 0x00311C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167568, XrefRangeEnd = 167574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700409C RID: 16540
			// (get) Token: 0x0600C648 RID: 50760 RVA: 0x00313AB4 File Offset: 0x00311CB4
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167574, XrefRangeEnd = 167577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C649 RID: 50761 RVA: 0x00313AF4 File Offset: 0x00311CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167577, XrefRangeEnd = 167579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<Sellable, int>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C64A RID: 50762 RVA: 0x00313B34 File Offset: 0x00311D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C64B RID: 50763 RVA: 0x0006AE2C File Offset: 0x0006902C
			public _GetBeverageWithRecord_d__103(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004097 RID: 16535
			// (get) Token: 0x0600C64C RID: 50764 RVA: 0x00313B74 File Offset: 0x00311D74
			// (set) Token: 0x0600C64D RID: 50765 RVA: 0x0006AE35 File Offset: 0x00069035
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004098 RID: 16536
			// (get) Token: 0x0600C64E RID: 50766 RVA: 0x00313B9C File Offset: 0x00311D9C
			// (set) Token: 0x0600C64F RID: 50767 RVA: 0x0006AE50 File Offset: 0x00069050
			public KeyValuePair<Sellable, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<Sellable, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004099 RID: 16537
			// (get) Token: 0x0600C650 RID: 50768 RVA: 0x00313BCC File Offset: 0x00311DCC
			// (set) Token: 0x0600C651 RID: 50769 RVA: 0x0006AE7E File Offset: 0x0006907E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0600C652 RID: 50770 RVA: 0x00313BF4 File Offset: 0x00311DF4
			// (set) Token: 0x0600C653 RID: 50771 RVA: 0x0006AE99 File Offset: 0x00069099
			public unsafe IEnumerator<Sellable> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetBeverageWithRecord_d__103.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F74 RID: 32628
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F75 RID: 32629
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F76 RID: 32630
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F77 RID: 32631
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04007F78 RID: 32632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F79 RID: 32633
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F7A RID: 32634
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F7B RID: 32635
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007F7C RID: 32636
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04007F7D RID: 32637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F7E RID: 32638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F7F RID: 32639
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04007F80 RID: 32640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A30 RID: 2608
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<GetCookerWithRecord>d__104")]
		public sealed class _GetCookerWithRecord_d__104 : Object
		{
			// Token: 0x0600C654 RID: 50772 RVA: 0x00313C24 File Offset: 0x00311E24
			// Note: this type is marked as 'beforefieldinit'.
			static _GetCookerWithRecord_d__104()
			{
				Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<GetCookerWithRecord>d__104");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, "<>1__state");
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, "<>2__current");
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, "<>l__initialThreadId");
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, "<>7__wrap1");
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676258);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676259);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676260);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676261);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676262);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676263);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676264);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676265);
				RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr, 100676266);
			}

			// Token: 0x0600C655 RID: 50773 RVA: 0x00313D54 File Offset: 0x00311F54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetCookerWithRecord_d__104(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum._GetCookerWithRecord_d__104>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C656 RID: 50774 RVA: 0x00313D9C File Offset: 0x00311F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167579, XrefRangeEnd = 167584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C657 RID: 50775 RVA: 0x00313DD0 File Offset: 0x00311FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167584, XrefRangeEnd = 167636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C658 RID: 50776 RVA: 0x00313E0C File Offset: 0x0031200C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167636, XrefRangeEnd = 167639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040A1 RID: 16545
			// (get) Token: 0x0600C659 RID: 50777 RVA: 0x00313E40 File Offset: 0x00312040
			public unsafe KeyValuePair<Cooker, int> prop_KeyValuePair_2_Cooker_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<Cooker, int>(pointer);
				}
			}

			// Token: 0x0600C65A RID: 50778 RVA: 0x00313E78 File Offset: 0x00312078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167639, XrefRangeEnd = 167645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040A2 RID: 16546
			// (get) Token: 0x0600C65B RID: 50779 RVA: 0x00313EAC File Offset: 0x003120AC
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167645, XrefRangeEnd = 167648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C65C RID: 50780 RVA: 0x00313EEC File Offset: 0x003120EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167648, XrefRangeEnd = 167650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<Cooker, int>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Cooker_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<Cooker, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C65D RID: 50781 RVA: 0x00313F2C File Offset: 0x0031212C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum._GetCookerWithRecord_d__104.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C65E RID: 50782 RVA: 0x0006AEB8 File Offset: 0x000690B8
			public _GetCookerWithRecord_d__104(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409D RID: 16541
			// (get) Token: 0x0600C65F RID: 50783 RVA: 0x00313F6C File Offset: 0x0031216C
			// (set) Token: 0x0600C660 RID: 50784 RVA: 0x0006AEC1 File Offset: 0x000690C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700409E RID: 16542
			// (get) Token: 0x0600C661 RID: 50785 RVA: 0x00313F94 File Offset: 0x00312194
			// (set) Token: 0x0600C662 RID: 50786 RVA: 0x0006AEDC File Offset: 0x000690DC
			public KeyValuePair<Cooker, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<Cooker, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Cooker, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Cooker, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0600C663 RID: 50787 RVA: 0x00313FC4 File Offset: 0x003121C4
			// (set) Token: 0x0600C664 RID: 50788 RVA: 0x0006AF0A File Offset: 0x0006910A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0600C665 RID: 50789 RVA: 0x00313FEC File Offset: 0x003121EC
			// (set) Token: 0x0600C666 RID: 50790 RVA: 0x0006AF25 File Offset: 0x00069125
			public unsafe IEnumerator<Cooker> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Cooker>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum._GetCookerWithRecord_d__104.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F81 RID: 32641
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007F82 RID: 32642
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007F83 RID: 32643
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007F84 RID: 32644
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04007F85 RID: 32645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007F86 RID: 32646
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F87 RID: 32647
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007F88 RID: 32648
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007F89 RID: 32649
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x04007F8A RID: 32650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007F8B RID: 32651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007F8C RID: 32652
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x04007F8D RID: 32653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000A31 RID: 2609
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Object
		{
			// Token: 0x0600C667 RID: 50791 RVA: 0x0031401C File Offset: 0x0031221C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr);
				RunTimeAlbum.__c__DisplayClass126_0.NativeFieldInfoPtr_specialGusetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr, "specialGusetId");
				RunTimeAlbum.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr, 100676267);
				RunTimeAlbum.__c__DisplayClass126_0.NativeMethodInfoPtr__RecordSpecialGuestFoodTag_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr, 100676268);
			}

			// Token: 0x0600C668 RID: 50792 RVA: 0x00314084 File Offset: 0x00312284
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass126_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C669 RID: 50793 RVA: 0x003140C0 File Offset: 0x003122C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167650, XrefRangeEnd = 167658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RecordSpecialGuestFoodTag_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass126_0.NativeMethodInfoPtr__RecordSpecialGuestFoodTag_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C66A RID: 50794 RVA: 0x0006AF44 File Offset: 0x00069144
			public __c__DisplayClass126_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A3 RID: 16547
			// (get) Token: 0x0600C66B RID: 50795 RVA: 0x0031410C File Offset: 0x0031230C
			// (set) Token: 0x0600C66C RID: 50796 RVA: 0x0006AF4D File Offset: 0x0006914D
			public unsafe int specialGusetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass126_0.NativeFieldInfoPtr_specialGusetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass126_0.NativeFieldInfoPtr_specialGusetId)) = value;
				}
			}

			// Token: 0x04007F8E RID: 32654
			private static readonly IntPtr NativeFieldInfoPtr_specialGusetId;

			// Token: 0x04007F8F RID: 32655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F90 RID: 32656
			private static readonly IntPtr NativeMethodInfoPtr__RecordSpecialGuestFoodTag_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A32 RID: 2610
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c__DisplayClass127_0")]
		public sealed class __c__DisplayClass127_0 : Object
		{
			// Token: 0x0600C66D RID: 50797 RVA: 0x00314134 File Offset: 0x00312334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass127_0()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c__DisplayClass127_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr);
				RunTimeAlbum.__c__DisplayClass127_0.NativeFieldInfoPtr_specialGusetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr, "specialGusetId");
				RunTimeAlbum.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr, 100676269);
				RunTimeAlbum.__c__DisplayClass127_0.NativeMethodInfoPtr__RecordSpecialGuestHateFoodTag_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr, 100676270);
			}

			// Token: 0x0600C66E RID: 50798 RVA: 0x0031419C File Offset: 0x0031239C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass127_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass127_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C66F RID: 50799 RVA: 0x003141D8 File Offset: 0x003123D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167658, XrefRangeEnd = 167667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RecordSpecialGuestHateFoodTag_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass127_0.NativeMethodInfoPtr__RecordSpecialGuestHateFoodTag_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C670 RID: 50800 RVA: 0x0006AF68 File Offset: 0x00069168
			public __c__DisplayClass127_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A4 RID: 16548
			// (get) Token: 0x0600C671 RID: 50801 RVA: 0x00314224 File Offset: 0x00312424
			// (set) Token: 0x0600C672 RID: 50802 RVA: 0x0006AF71 File Offset: 0x00069171
			public unsafe int specialGusetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass127_0.NativeFieldInfoPtr_specialGusetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass127_0.NativeFieldInfoPtr_specialGusetId)) = value;
				}
			}

			// Token: 0x04007F91 RID: 32657
			private static readonly IntPtr NativeFieldInfoPtr_specialGusetId;

			// Token: 0x04007F92 RID: 32658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F93 RID: 32659
			private static readonly IntPtr NativeMethodInfoPtr__RecordSpecialGuestHateFoodTag_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A33 RID: 2611
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c__DisplayClass128_0")]
		public sealed class __c__DisplayClass128_0 : Object
		{
			// Token: 0x0600C673 RID: 50803 RVA: 0x0031424C File Offset: 0x0031244C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_0()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c__DisplayClass128_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr);
				RunTimeAlbum.__c__DisplayClass128_0.NativeFieldInfoPtr_specialGusetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr, "specialGusetId");
				RunTimeAlbum.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr, 100676271);
				RunTimeAlbum.__c__DisplayClass128_0.NativeMethodInfoPtr__RecordSpecialGuestBevTag_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr, 100676272);
			}

			// Token: 0x0600C674 RID: 50804 RVA: 0x003142B4 File Offset: 0x003124B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass128_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C675 RID: 50805 RVA: 0x003142F0 File Offset: 0x003124F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167667, XrefRangeEnd = 167676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RecordSpecialGuestBevTag_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass128_0.NativeMethodInfoPtr__RecordSpecialGuestBevTag_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C676 RID: 50806 RVA: 0x0006AF8C File Offset: 0x0006918C
			public __c__DisplayClass128_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A5 RID: 16549
			// (get) Token: 0x0600C677 RID: 50807 RVA: 0x0031433C File Offset: 0x0031253C
			// (set) Token: 0x0600C678 RID: 50808 RVA: 0x0006AF95 File Offset: 0x00069195
			public unsafe int specialGusetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass128_0.NativeFieldInfoPtr_specialGusetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass128_0.NativeFieldInfoPtr_specialGusetId)) = value;
				}
			}

			// Token: 0x04007F94 RID: 32660
			private static readonly IntPtr NativeFieldInfoPtr_specialGusetId;

			// Token: 0x04007F95 RID: 32661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F96 RID: 32662
			private static readonly IntPtr NativeMethodInfoPtr__RecordSpecialGuestBevTag_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A34 RID: 2612
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c__DisplayClass129_0")]
		public sealed class __c__DisplayClass129_0 : Object
		{
			// Token: 0x0600C679 RID: 50809 RVA: 0x00314364 File Offset: 0x00312564
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass129_0()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c__DisplayClass129_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr);
				RunTimeAlbum.__c__DisplayClass129_0.NativeFieldInfoPtr_izakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr, "izakayaId");
				RunTimeAlbum.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr, 100676273);
				RunTimeAlbum.__c__DisplayClass129_0.NativeMethodInfoPtr__RecordSpecialGuestIzakaya_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr, 100676274);
			}

			// Token: 0x0600C67A RID: 50810 RVA: 0x003143CC File Offset: 0x003125CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass129_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass129_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C67B RID: 50811 RVA: 0x00314408 File Offset: 0x00312608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167676, XrefRangeEnd = 167679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RecordSpecialGuestIzakaya_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass129_0.NativeMethodInfoPtr__RecordSpecialGuestIzakaya_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C67C RID: 50812 RVA: 0x0006AFB0 File Offset: 0x000691B0
			public __c__DisplayClass129_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A6 RID: 16550
			// (get) Token: 0x0600C67D RID: 50813 RVA: 0x00314454 File Offset: 0x00312654
			// (set) Token: 0x0600C67E RID: 50814 RVA: 0x0006AFB9 File Offset: 0x000691B9
			public unsafe int izakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass129_0.NativeFieldInfoPtr_izakayaId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass129_0.NativeFieldInfoPtr_izakayaId)) = value;
				}
			}

			// Token: 0x04007F97 RID: 32663
			private static readonly IntPtr NativeFieldInfoPtr_izakayaId;

			// Token: 0x04007F98 RID: 32664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F99 RID: 32665
			private static readonly IntPtr NativeMethodInfoPtr__RecordSpecialGuestIzakaya_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A35 RID: 2613
		[ObfuscatedName("GameData.RunTime.Common.RunTimeAlbum+<>c__DisplayClass130_0")]
		public sealed class __c__DisplayClass130_0 : Object
		{
			// Token: 0x0600C67F RID: 50815 RVA: 0x0031447C File Offset: 0x0031267C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass130_0()
			{
				Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeAlbum>.NativeClassPtr, "<>c__DisplayClass130_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr);
				RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr_specialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr, "specialGuest");
				RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr, "<>9__2");
				RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr, 100676275);
				RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__0_Internal_Boolean_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr, 100676276);
				RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__2_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr, 100676277);
			}

			// Token: 0x0600C680 RID: 50816 RVA: 0x0031450C File Offset: 0x0031270C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass130_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeAlbum.__c__DisplayClass130_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C681 RID: 50817 RVA: 0x00314548 File Offset: 0x00312748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167679, XrefRangeEnd = 167690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckAllRevealedDataIsUnlocked_b__0(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__0_Internal_Boolean_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C682 RID: 50818 RVA: 0x00314598 File Offset: 0x00312798
			[CallerCount(0)]
			public unsafe bool _CheckAllRevealedDataIsUnlocked_b__2(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeAlbum.__c__DisplayClass130_0.NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__2_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C683 RID: 50819 RVA: 0x0006AFD4 File Offset: 0x000691D4
			public __c__DisplayClass130_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A7 RID: 16551
			// (get) Token: 0x0600C684 RID: 50820 RVA: 0x003145E8 File Offset: 0x003127E8
			// (set) Token: 0x0600C685 RID: 50821 RVA: 0x0006AFDD File Offset: 0x000691DD
			public unsafe SpecialGuest specialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr_specialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr_specialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A8 RID: 16552
			// (get) Token: 0x0600C686 RID: 50822 RVA: 0x00314618 File Offset: 0x00312818
			// (set) Token: 0x0600C687 RID: 50823 RVA: 0x0006AFFC File Offset: 0x000691FC
			public unsafe Func<Izakaya.SpecialGuestGroup, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeAlbum.__c__DisplayClass130_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007F9A RID: 32666
			private static readonly IntPtr NativeFieldInfoPtr_specialGuest;

			// Token: 0x04007F9B RID: 32667
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04007F9C RID: 32668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007F9D RID: 32669
			private static readonly IntPtr NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__0_Internal_Boolean_Izakaya_0;

			// Token: 0x04007F9E RID: 32670
			private static readonly IntPtr NativeMethodInfoPtr__CheckAllRevealedDataIsUnlocked_b__2_Internal_Boolean_SpecialGuestGroup_0;
		}
	}
}
