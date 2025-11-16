using System;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x0200021C RID: 540
	public static class DataBaseLanguage : Il2CppSystem.Object
	{
		// Token: 0x06003F5D RID: 16221 RVA: 0x001766F4 File Offset: 0x001748F4
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseLanguage()
		{
			Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.CoreLanguage.Collections", "DataBaseLanguage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr);
			DataBaseLanguage.NativeFieldInfoPtr__BeverageTags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<BeverageTags>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__FoodTags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<FoodTags>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__FoodTagsDLCMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<FoodTagsDLCMapping>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__FoodPrefixs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<FoodPrefixs>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Ingredients_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Ingredients>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Items>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Badges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Badges>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Beverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Beverages>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Foods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Foods>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__StandardCookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<StandardCookers>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Missions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Missions>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__News_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<News>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Cookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Cookers>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__Izakayas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<Izakayas>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__NormalGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<NormalGuest>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__SpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<SpecialGuest>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestFoodRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<SpecialGuestFoodRequest>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestBevRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<SpecialGuestBevRequest>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__BuffDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<BuffDescription>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__MissionFinishCondition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<MissionFinishCondition>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__RewardCondition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<RewardCondition>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__PartnerJob_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<PartnerJob>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__CGData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<CGData>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__MusicNameData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<MusicNameData>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__SpellLang_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<SpellLang>k__BackingField");
			DataBaseLanguage.NativeFieldInfoPtr__CookerBGMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<CookerBGMapping>k__BackingField");
			DataBaseLanguage.NativeMethodInfoPtr_get_BeverageTags_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675203);
			DataBaseLanguage.NativeMethodInfoPtr_set_BeverageTags_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675204);
			DataBaseLanguage.NativeMethodInfoPtr_get_FoodTags_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675205);
			DataBaseLanguage.NativeMethodInfoPtr_set_FoodTags_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675206);
			DataBaseLanguage.NativeMethodInfoPtr_get_FoodTagsDLCMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675207);
			DataBaseLanguage.NativeMethodInfoPtr_set_FoodTagsDLCMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675208);
			DataBaseLanguage.NativeMethodInfoPtr_get_FoodPrefixs_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675209);
			DataBaseLanguage.NativeMethodInfoPtr_set_FoodPrefixs_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675210);
			DataBaseLanguage.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675211);
			DataBaseLanguage.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675212);
			DataBaseLanguage.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675213);
			DataBaseLanguage.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675214);
			DataBaseLanguage.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675215);
			DataBaseLanguage.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675216);
			DataBaseLanguage.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675217);
			DataBaseLanguage.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675218);
			DataBaseLanguage.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675219);
			DataBaseLanguage.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675220);
			DataBaseLanguage.NativeMethodInfoPtr_get_StandardCookers_Private_Static_get_Dictionary_2_CookerType_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675221);
			DataBaseLanguage.NativeMethodInfoPtr_set_StandardCookers_Private_Static_set_Void_Dictionary_2_CookerType_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675222);
			DataBaseLanguage.NativeMethodInfoPtr_get_Missions_Private_Static_get_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675223);
			DataBaseLanguage.NativeMethodInfoPtr_set_Missions_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675224);
			DataBaseLanguage.NativeMethodInfoPtr_get_News_Private_Static_get_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675225);
			DataBaseLanguage.NativeMethodInfoPtr_set_News_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675226);
			DataBaseLanguage.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675227);
			DataBaseLanguage.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675228);
			DataBaseLanguage.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675229);
			DataBaseLanguage.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675230);
			DataBaseLanguage.NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675231);
			DataBaseLanguage.NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675232);
			DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675233);
			DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675234);
			DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuestFoodRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675235);
			DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuestFoodRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675236);
			DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuestBevRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675237);
			DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuestBevRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675238);
			DataBaseLanguage.NativeMethodInfoPtr_get_BuffDescription_Private_Static_get_Dictionary_2_BuffType_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675239);
			DataBaseLanguage.NativeMethodInfoPtr_set_BuffDescription_Private_Static_set_Void_Dictionary_2_BuffType_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675240);
			DataBaseLanguage.NativeMethodInfoPtr_get_MissionFinishCondition_Private_Static_get_Dictionary_2_ConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675241);
			DataBaseLanguage.NativeMethodInfoPtr_set_MissionFinishCondition_Private_Static_set_Void_Dictionary_2_ConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675242);
			DataBaseLanguage.NativeMethodInfoPtr_get_RewardCondition_Private_Static_get_Dictionary_2_ProductType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675243);
			DataBaseLanguage.NativeMethodInfoPtr_set_RewardCondition_Private_Static_set_Void_Dictionary_2_ProductType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675244);
			DataBaseLanguage.NativeMethodInfoPtr_get_PartnerJob_Private_Static_get_Dictionary_2_PartnerType_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675245);
			DataBaseLanguage.NativeMethodInfoPtr_set_PartnerJob_Private_Static_set_Void_Dictionary_2_PartnerType_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675246);
			DataBaseLanguage.NativeMethodInfoPtr_get_CGData_Private_Static_get_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675247);
			DataBaseLanguage.NativeMethodInfoPtr_set_CGData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675248);
			DataBaseLanguage.NativeMethodInfoPtr_get_MusicNameData_Private_Static_get_Dictionary_2_String_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675249);
			DataBaseLanguage.NativeMethodInfoPtr_set_MusicNameData_Private_Static_set_Void_Dictionary_2_String_ValueTuple_3_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675250);
			DataBaseLanguage.NativeMethodInfoPtr_get_SpellLang_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675251);
			DataBaseLanguage.NativeMethodInfoPtr_set_SpellLang_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675252);
			DataBaseLanguage.NativeMethodInfoPtr_get_CookerBGMapping_Private_Static_get_Dictionary_2_CookerSeries_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675253);
			DataBaseLanguage.NativeMethodInfoPtr_set_CookerBGMapping_Private_Static_set_Void_Dictionary_2_CookerSeries_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675254);
			DataBaseLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_CookerType_ObjectLa = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675255);
			DataBaseLanguage.NativeMethodInfoPtr_RefSpellLang_Public_Static_Il2CppReferenceArray_1_LanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675256);
			DataBaseLanguage.NativeMethodInfoPtr_GetBeverageTag_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675257);
			DataBaseLanguage.NativeMethodInfoPtr_GetFoodTag_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675258);
			DataBaseLanguage.NativeMethodInfoPtr_GetAllFoodTags_Public_Static_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675259);
			DataBaseLanguage.NativeMethodInfoPtr_GetAllFoodTagsId_Public_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675260);
			DataBaseLanguage.NativeMethodInfoPtr_GetFoodTagMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675261);
			DataBaseLanguage.NativeMethodInfoPtr_GetAllBeverageTags_Public_Static_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675262);
			DataBaseLanguage.NativeMethodInfoPtr_FoodPrefix_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675263);
			DataBaseLanguage.NativeMethodInfoPtr_GetItemLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675264);
			DataBaseLanguage.NativeMethodInfoPtr_GetBadgeLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675265);
			DataBaseLanguage.NativeMethodInfoPtr_GetIngredientLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675266);
			DataBaseLanguage.NativeMethodInfoPtr_GetBeverageLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675267);
			DataBaseLanguage.NativeMethodInfoPtr_GetFoodLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675268);
			DataBaseLanguage.NativeMethodInfoPtr_GetFoodToRecipeLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675269);
			DataBaseLanguage.NativeMethodInfoPtr_GetCookerLang_Public_Static_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675270);
			DataBaseLanguage.NativeMethodInfoPtr_GetIzakayaLang_Public_Static_LanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675271);
			DataBaseLanguage.NativeMethodInfoPtr_GetNormalGuestLang_Public_Static_LanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675272);
			DataBaseLanguage.NativeMethodInfoPtr_GetSpecialGuestLang_Public_Static_LanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675273);
			DataBaseLanguage.NativeMethodInfoPtr_GetSpecialFoodTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675274);
			DataBaseLanguage.NativeMethodInfoPtr_GetSpecialBevTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675275);
			DataBaseLanguage.NativeMethodInfoPtr_GetAllSpecialGuestsNames_Public_Static_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675276);
			DataBaseLanguage.NativeMethodInfoPtr_GetStdCooker_Public_Static_ObjectLanguageBase_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675277);
			DataBaseLanguage.NativeMethodInfoPtr_GetMissionLanguage_Public_Static_LanguageBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675278);
			DataBaseLanguage.NativeMethodInfoPtr_GetNewsLanguage_Public_Static_LanguageBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675279);
			DataBaseLanguage.NativeMethodInfoPtr_GetMissionConditionLang_Public_Static_String_ConditionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675280);
			DataBaseLanguage.NativeMethodInfoPtr_GetRewardConditionLang_Public_Static_String_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675281);
			DataBaseLanguage.NativeMethodInfoPtr_GetPartnerJobLang_Public_Static_LanguageBase_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675282);
			DataBaseLanguage.NativeMethodInfoPtr_GetCGLabelLang_Public_Static_LanguageBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675283);
			DataBaseLanguage.NativeMethodInfoPtr_GetMusicKeyLang_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675284);
			DataBaseLanguage.NativeMethodInfoPtr_RefBuffLang_Public_Static_ObjectLanguageBase_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675285);
			DataBaseLanguage.NativeMethodInfoPtr_GetMusicGameChapterLang_Public_Static_ValueTuple_3_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675286);
			DataBaseLanguage.NativeMethodInfoPtr_GetPrefix_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675287);
			DataBaseLanguage.NativeMethodInfoPtr_GetPrefix_Public_Static_String_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675288);
			DataBaseLanguage.NativeMethodInfoPtr_GetCookerBG_Public_Static_Sprite_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675289);
			DataBaseLanguage.NativeMethodInfoPtr_GetEvalText_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675290);
			DataBaseLanguage.NativeMethodInfoPtr_GetEvalText_Public_Static_String_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675291);
			DataBaseLanguage.NativeMethodInfoPtr_Method_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, 100675292);
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x00177034 File Offset: 0x00175234
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x00177068 File Offset: 0x00175268
		public unsafe static Dictionary<int, string> BeverageTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156061, XrefRangeEnd = 156063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_BeverageTags_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156063, XrefRangeEnd = 156067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_BeverageTags_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x001770A0 File Offset: 0x001752A0
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x001770D4 File Offset: 0x001752D4
		public unsafe static Dictionary<int, string> FoodTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156067, XrefRangeEnd = 156069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_FoodTags_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156069, XrefRangeEnd = 156073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_FoodTags_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x0017710C File Offset: 0x0017530C
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x00177140 File Offset: 0x00175340
		public unsafe static Dictionary<int, string> FoodTagsDLCMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156073, XrefRangeEnd = 156075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_FoodTagsDLCMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156075, XrefRangeEnd = 156079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_FoodTagsDLCMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x00177178 File Offset: 0x00175378
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x001771AC File Offset: 0x001753AC
		public unsafe static Dictionary<int, string> FoodPrefixs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156079, XrefRangeEnd = 156081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_FoodPrefixs_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156081, XrefRangeEnd = 156085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_FoodPrefixs_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x001771E4 File Offset: 0x001753E4
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x00177218 File Offset: 0x00175418
		public unsafe static Dictionary<int, ObjectLanguageBase> Ingredients
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156085, XrefRangeEnd = 156087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156087, XrefRangeEnd = 156091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00177250 File Offset: 0x00175450
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x00177284 File Offset: 0x00175484
		public unsafe static Dictionary<int, ObjectLanguageBase> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156091, XrefRangeEnd = 156093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156093, XrefRangeEnd = 156097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x001772BC File Offset: 0x001754BC
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x001772F0 File Offset: 0x001754F0
		public unsafe static Dictionary<int, ObjectLanguageBase> Badges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156097, XrefRangeEnd = 156099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156099, XrefRangeEnd = 156103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x00177328 File Offset: 0x00175528
		// (set) Token: 0x06003F6D RID: 16237 RVA: 0x0017735C File Offset: 0x0017555C
		public unsafe static Dictionary<int, ObjectLanguageBase> Beverages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156103, XrefRangeEnd = 156105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156105, XrefRangeEnd = 156109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06003F6E RID: 16238 RVA: 0x00177394 File Offset: 0x00175594
		// (set) Token: 0x06003F6F RID: 16239 RVA: 0x001773C8 File Offset: 0x001755C8
		public unsafe static Dictionary<int, ObjectLanguageBase> Foods
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156109, XrefRangeEnd = 156111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156111, XrefRangeEnd = 156115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06003F70 RID: 16240 RVA: 0x00177400 File Offset: 0x00175600
		// (set) Token: 0x06003F71 RID: 16241 RVA: 0x00177434 File Offset: 0x00175634
		public unsafe static Dictionary<Cooker.CookerType, ObjectLanguageBase> StandardCookers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156115, XrefRangeEnd = 156117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_StandardCookers_Private_Static_get_Dictionary_2_CookerType_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerType, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156117, XrefRangeEnd = 156121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_StandardCookers_Private_Static_set_Void_Dictionary_2_CookerType_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06003F72 RID: 16242 RVA: 0x0017746C File Offset: 0x0017566C
		// (set) Token: 0x06003F73 RID: 16243 RVA: 0x001774A0 File Offset: 0x001756A0
		public unsafe static Dictionary<string, LanguageBase> Missions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156121, XrefRangeEnd = 156123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Missions_Private_Static_get_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156123, XrefRangeEnd = 156127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Missions_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x001774D8 File Offset: 0x001756D8
		// (set) Token: 0x06003F75 RID: 16245 RVA: 0x0017750C File Offset: 0x0017570C
		public unsafe static Dictionary<string, LanguageBase> News
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156127, XrefRangeEnd = 156129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_News_Private_Static_get_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156129, XrefRangeEnd = 156133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_News_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06003F76 RID: 16246 RVA: 0x00177544 File Offset: 0x00175744
		// (set) Token: 0x06003F77 RID: 16247 RVA: 0x00177578 File Offset: 0x00175778
		public unsafe static Dictionary<int, ObjectLanguageBase> Cookers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156133, XrefRangeEnd = 156135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156135, XrefRangeEnd = 156139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x001775B0 File Offset: 0x001757B0
		// (set) Token: 0x06003F79 RID: 16249 RVA: 0x001775E4 File Offset: 0x001757E4
		public unsafe static Dictionary<int, LanguageBase> Izakayas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156139, XrefRangeEnd = 156141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156141, XrefRangeEnd = 156145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06003F7A RID: 16250 RVA: 0x0017761C File Offset: 0x0017581C
		// (set) Token: 0x06003F7B RID: 16251 RVA: 0x00177650 File Offset: 0x00175850
		public unsafe static Dictionary<int, LanguageBase> NormalGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156145, XrefRangeEnd = 156147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156147, XrefRangeEnd = 156151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06003F7C RID: 16252 RVA: 0x00177688 File Offset: 0x00175888
		// (set) Token: 0x06003F7D RID: 16253 RVA: 0x001776BC File Offset: 0x001758BC
		public unsafe static Dictionary<int, ValueTuple<string, string, string, string>> SpecialGuest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156151, XrefRangeEnd = 156153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<string, string, string, string>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156153, XrefRangeEnd = 156157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x001776F4 File Offset: 0x001758F4
		// (set) Token: 0x06003F7F RID: 16255 RVA: 0x00177728 File Offset: 0x00175928
		public unsafe static Dictionary<int, Dictionary<int, string>> SpecialGuestFoodRequest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156157, XrefRangeEnd = 156159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuestFoodRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, string>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156159, XrefRangeEnd = 156163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuestFoodRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x00177760 File Offset: 0x00175960
		// (set) Token: 0x06003F81 RID: 16257 RVA: 0x00177794 File Offset: 0x00175994
		public unsafe static Dictionary<int, Dictionary<int, string>> SpecialGuestBevRequest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156163, XrefRangeEnd = 156165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_SpecialGuestBevRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, string>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156165, XrefRangeEnd = 156169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_SpecialGuestBevRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x001777CC File Offset: 0x001759CC
		// (set) Token: 0x06003F83 RID: 16259 RVA: 0x00177800 File Offset: 0x00175A00
		public unsafe static Dictionary<EventManager.BuffType, ObjectLanguageBase> BuffDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156169, XrefRangeEnd = 156171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_BuffDescription_Private_Static_get_Dictionary_2_BuffType_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EventManager.BuffType, ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156171, XrefRangeEnd = 156175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_BuffDescription_Private_Static_set_Void_Dictionary_2_BuffType_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x00177838 File Offset: 0x00175A38
		// (set) Token: 0x06003F85 RID: 16261 RVA: 0x0017786C File Offset: 0x00175A6C
		public unsafe static Dictionary<MissionNode.FinishCondition.ConditionType, string> MissionFinishCondition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156175, XrefRangeEnd = 156177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_MissionFinishCondition_Private_Static_get_Dictionary_2_ConditionType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<MissionNode.FinishCondition.ConditionType, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156177, XrefRangeEnd = 156181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_MissionFinishCondition_Private_Static_set_Void_Dictionary_2_ConditionType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x001778A4 File Offset: 0x00175AA4
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x001778D8 File Offset: 0x00175AD8
		public unsafe static Dictionary<Product.ProductType, string> RewardCondition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156181, XrefRangeEnd = 156183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_RewardCondition_Private_Static_get_Dictionary_2_ProductType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Product.ProductType, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156183, XrefRangeEnd = 156187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_RewardCondition_Private_Static_set_Void_Dictionary_2_ProductType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x00177910 File Offset: 0x00175B10
		// (set) Token: 0x06003F89 RID: 16265 RVA: 0x00177944 File Offset: 0x00175B44
		public unsafe static Dictionary<PartnerBase.PartnerType, LanguageBase> PartnerJob
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156187, XrefRangeEnd = 156189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_PartnerJob_Private_Static_get_Dictionary_2_PartnerType_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerBase.PartnerType, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156189, XrefRangeEnd = 156193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_PartnerJob_Private_Static_set_Void_Dictionary_2_PartnerType_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06003F8A RID: 16266 RVA: 0x0017797C File Offset: 0x00175B7C
		// (set) Token: 0x06003F8B RID: 16267 RVA: 0x001779B0 File Offset: 0x00175BB0
		public unsafe static Dictionary<string, LanguageBase> CGData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156193, XrefRangeEnd = 156195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_CGData_Private_Static_get_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156195, XrefRangeEnd = 156199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_CGData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x001779E8 File Offset: 0x00175BE8
		// (set) Token: 0x06003F8D RID: 16269 RVA: 0x00177A1C File Offset: 0x00175C1C
		public unsafe static Dictionary<string, ValueTuple<string, string, string>> MusicNameData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156199, XrefRangeEnd = 156201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_MusicNameData_Private_Static_get_Dictionary_2_String_ValueTuple_3_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<string, string, string>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156201, XrefRangeEnd = 156205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_MusicNameData_Private_Static_set_Void_Dictionary_2_String_ValueTuple_3_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06003F8E RID: 16270 RVA: 0x00177A54 File Offset: 0x00175C54
		// (set) Token: 0x06003F8F RID: 16271 RVA: 0x00177A88 File Offset: 0x00175C88
		public unsafe static Dictionary<int, Il2CppReferenceArray<LanguageBase>> SpellLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156205, XrefRangeEnd = 156207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_SpellLang_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<LanguageBase>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156207, XrefRangeEnd = 156211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_SpellLang_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06003F90 RID: 16272 RVA: 0x00177AC0 File Offset: 0x00175CC0
		// (set) Token: 0x06003F91 RID: 16273 RVA: 0x00177AF4 File Offset: 0x00175CF4
		public unsafe static Dictionary<Cooker.CookerSeries, Sprite> CookerBGMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156211, XrefRangeEnd = 156213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_get_CookerBGMapping_Private_Static_get_Dictionary_2_CookerSeries_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerSeries, Sprite>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156213, XrefRangeEnd = 156217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_set_CookerBGMapping_Private_Static_set_Void_Dictionary_2_CookerSeries_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x00177B2C File Offset: 0x00175D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156549, RefRangeEnd = 156550, XrefRangeStart = 156217, XrefRangeEnd = 156549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<int, string> beverageTags, Dictionary<int, string> foodTags, Dictionary<int, string> foodTagsDLCMapping, Dictionary<int, string> foodPrefixs, Dictionary<int, ObjectLanguageBase> ingredietns, Dictionary<int, ObjectLanguageBase> items, Dictionary<int, ObjectLanguageBase> badges, Dictionary<int, ObjectLanguageBase> beverages, Dictionary<int, ObjectLanguageBase> foods, Dictionary<int, ObjectLanguageBase> cookers, Dictionary<int, LanguageBase> izakayas, Dictionary<string, LanguageBase> missions, Dictionary<string, LanguageBase> news, Dictionary<Cooker.CookerType, ObjectLanguageBase> standardCookers, Dictionary<int, LanguageBase> normalGuests, Dictionary<int, ValueTuple<string, string, string, string>> specialGuests, Dictionary<int, Il2CppStringArray> specialFood, Dictionary<int, Il2CppStringArray> specialBev, Dictionary<EventManager.BuffType, ObjectLanguageBase> buffLang, Dictionary<MissionNode.FinishCondition.ConditionType, string> missionFinishCondition, Dictionary<Product.ProductType, string> rewardCondition, Dictionary<PartnerBase.PartnerType, LanguageBase> partnerJob, Dictionary<string, LanguageBase> cgData, Dictionary<string, ValueTuple<string, string, string>> musicNameData, Dictionary<int, Il2CppReferenceArray<LanguageBase>> spellName, Dictionary<Cooker.CookerSeries, Sprite> cookerBGMapping)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverageTags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foodTags);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foodTagsDLCMapping);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foodPrefixs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredietns);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foods);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayas);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(missions);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(news);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(standardCookers);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuests);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuests);
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialFood);
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialBev);
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffLang);
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(missionFinishCondition);
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rewardCondition);
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerJob);
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cgData);
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicNameData);
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spellName);
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerBGMapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_CookerType_ObjectLa, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00177D4C File Offset: 0x00175F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156556, RefRangeEnd = 156557, XrefRangeStart = 156550, XrefRangeEnd = 156556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<LanguageBase> RefSpellLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_RefSpellLang_Public_Static_Il2CppReferenceArray_1_LanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr3) : null;
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x00177D8C File Offset: 0x00175F8C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 156562, RefRangeEnd = 156594, XrefRangeStart = 156557, XrefRangeEnd = 156562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetBeverageTag(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetBeverageTag_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00177DC4 File Offset: 0x00175FC4
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 156599, RefRangeEnd = 156668, XrefRangeStart = 156594, XrefRangeEnd = 156599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFoodTag(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetFoodTag_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00177DFC File Offset: 0x00175FFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156670, RefRangeEnd = 156673, XrefRangeStart = 156668, XrefRangeEnd = 156670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> GetAllFoodTags()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetAllFoodTags_Public_Static_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00177E30 File Offset: 0x00176030
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 156682, RefRangeEnd = 156689, XrefRangeStart = 156673, XrefRangeEnd = 156682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetAllFoodTagsId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetAllFoodTagsId_Public_Static_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00177E64 File Offset: 0x00176064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156694, RefRangeEnd = 156696, XrefRangeStart = 156689, XrefRangeEnd = 156694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFoodTagMapping(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetFoodTagMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00177E9C File Offset: 0x0017609C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 156698, RefRangeEnd = 156704, XrefRangeStart = 156696, XrefRangeEnd = 156698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> GetAllBeverageTags()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetAllBeverageTags_Public_Static_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00177ED0 File Offset: 0x001760D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156704, XrefRangeEnd = 156709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FoodPrefix(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_FoodPrefix_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00177F08 File Offset: 0x00176108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156714, RefRangeEnd = 156717, XrefRangeStart = 156709, XrefRangeEnd = 156714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetItemLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetItemLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00177F48 File Offset: 0x00176148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156722, RefRangeEnd = 156723, XrefRangeStart = 156717, XrefRangeEnd = 156722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetBadgeLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetBadgeLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00177F88 File Offset: 0x00176188
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 156728, RefRangeEnd = 156742, XrefRangeStart = 156723, XrefRangeEnd = 156728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetIngredientLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetIngredientLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00177FC8 File Offset: 0x001761C8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 156747, RefRangeEnd = 156757, XrefRangeStart = 156742, XrefRangeEnd = 156747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetBeverageLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetBeverageLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00178008 File Offset: 0x00176208
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 156762, RefRangeEnd = 156777, XrefRangeStart = 156757, XrefRangeEnd = 156762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetFoodLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetFoodLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00178048 File Offset: 0x00176248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156794, RefRangeEnd = 156795, XrefRangeStart = 156777, XrefRangeEnd = 156794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetFoodToRecipeLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetFoodToRecipeLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00178088 File Offset: 0x00176288
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156800, RefRangeEnd = 156804, XrefRangeStart = 156795, XrefRangeEnd = 156800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetCookerLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetCookerLang_Public_Static_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x001780C8 File Offset: 0x001762C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156809, RefRangeEnd = 156812, XrefRangeStart = 156804, XrefRangeEnd = 156809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetIzakayaLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetIzakayaLang_Public_Static_LanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00178108 File Offset: 0x00176308
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156817, RefRangeEnd = 156820, XrefRangeStart = 156812, XrefRangeEnd = 156817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetNormalGuestLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetNormalGuestLang_Public_Static_LanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00178148 File Offset: 0x00176348
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 156842, RefRangeEnd = 156868, XrefRangeStart = 156820, XrefRangeEnd = 156842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetSpecialGuestLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetSpecialGuestLang_Public_Static_LanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00178188 File Offset: 0x00176388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156880, RefRangeEnd = 156881, XrefRangeStart = 156868, XrefRangeEnd = 156880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> GetSpecialFoodTagLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetSpecialFoodTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x001781C8 File Offset: 0x001763C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156893, RefRangeEnd = 156894, XrefRangeStart = 156881, XrefRangeEnd = 156893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> GetSpecialBevTagLang(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetSpecialBevTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00178208 File Offset: 0x00176408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156894, XrefRangeEnd = 156929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, string> GetAllSpecialGuestsNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetAllSpecialGuestsNames_Public_Static_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0017823C File Offset: 0x0017643C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 156934, RefRangeEnd = 156947, XrefRangeStart = 156929, XrefRangeEnd = 156934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase GetStdCooker(this Cooker.CookerType id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetStdCooker_Public_Static_ObjectLanguageBase_CookerType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0017827C File Offset: 0x0017647C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 156963, RefRangeEnd = 156971, XrefRangeStart = 156947, XrefRangeEnd = 156963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetMissionLanguage(this string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetMissionLanguage_Public_Static_LanguageBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x001782C0 File Offset: 0x001764C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156987, RefRangeEnd = 156988, XrefRangeStart = 156971, XrefRangeEnd = 156987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetNewsLanguage(this string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetNewsLanguage_Public_Static_LanguageBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00178304 File Offset: 0x00176504
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 156993, RefRangeEnd = 157013, XrefRangeStart = 156988, XrefRangeEnd = 156993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMissionConditionLang(this MissionNode.FinishCondition.ConditionType finishCondition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref finishCondition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetMissionConditionLang_Public_Static_String_ConditionType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0017833C File Offset: 0x0017653C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157018, RefRangeEnd = 157020, XrefRangeStart = 157013, XrefRangeEnd = 157018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRewardConditionLang(this Product.ProductType targetReward)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetReward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetRewardConditionLang_Public_Static_String_ProductType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00178374 File Offset: 0x00176574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157053, RefRangeEnd = 157057, XrefRangeStart = 157020, XrefRangeEnd = 157053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetPartnerJobLang(this PartnerBase.PartnerType partnerType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetPartnerJobLang_Public_Static_LanguageBase_PartnerType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x001783B4 File Offset: 0x001765B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157062, RefRangeEnd = 157064, XrefRangeStart = 157057, XrefRangeEnd = 157062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LanguageBase GetCGLabelLang(this string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetCGLabelLang_Public_Static_LanguageBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x001783F8 File Offset: 0x001765F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157079, RefRangeEnd = 157082, XrefRangeStart = 157064, XrefRangeEnd = 157079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMusicKeyLang(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetMusicKeyLang_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x00178434 File Offset: 0x00176634
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 157088, RefRangeEnd = 157094, XrefRangeStart = 157082, XrefRangeEnd = 157088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectLanguageBase RefBuffLang(this EventManager.BuffType buffType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_RefBuffLang_Public_Static_ObjectLanguageBase_BuffType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00178474 File Offset: 0x00176674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157109, RefRangeEnd = 157111, XrefRangeStart = 157094, XrefRangeEnd = 157109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<string, string, string> GetMusicGameChapterLang(this string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetMusicGameChapterLang_Public_Static_ValueTuple_3_String_String_String_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<string, string, string>(pointer);
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x001784B0 File Offset: 0x001766B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157111, XrefRangeEnd = 157180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPrefix(Il2CppStructArray<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetPrefix_Public_Static_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001784EC File Offset: 0x001766EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157191, RefRangeEnd = 157192, XrefRangeStart = 157180, XrefRangeEnd = 157191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPrefix(Ingredient value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetPrefix_Public_Static_String_Ingredient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00178528 File Offset: 0x00176728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157197, RefRangeEnd = 157198, XrefRangeStart = 157192, XrefRangeEnd = 157197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite GetCookerBG(this Cooker.CookerSeries cookerSeries)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerSeries;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetCookerBG_Public_Static_Sprite_CookerSeries_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00178568 File Offset: 0x00176768
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 157205, RefRangeEnd = 157227, XrefRangeStart = 157198, XrefRangeEnd = 157205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEvalText(this int evalLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evalLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetEvalText_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x001785A0 File Offset: 0x001767A0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 157205, RefRangeEnd = 157227, XrefRangeStart = 157205, XrefRangeEnd = 157227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEvalText(this GuestGroupController.EvaluationResult evalLevel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evalLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_GetEvalText_Public_Static_String_EvaluationResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001785D8 File Offset: 0x001767D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_String_0(string x)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.NativeMethodInfoPtr_Method_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00022EAE File Offset: 0x000210AE
		public DataBaseLanguage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x00178614 File Offset: 0x00176814
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x00022EB7 File Offset: 0x000210B7
		public unsafe static Dictionary<int, string> _BeverageTags_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__BeverageTags_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__BeverageTags_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x0017863C File Offset: 0x0017683C
		// (set) Token: 0x06003FBC RID: 16316 RVA: 0x00022EC9 File Offset: 0x000210C9
		public unsafe static Dictionary<int, string> _FoodTags_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__FoodTags_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__FoodTags_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06003FBD RID: 16317 RVA: 0x00178664 File Offset: 0x00176864
		// (set) Token: 0x06003FBE RID: 16318 RVA: 0x00022EDB File Offset: 0x000210DB
		public unsafe static Dictionary<int, string> _FoodTagsDLCMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__FoodTagsDLCMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__FoodTagsDLCMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x0017868C File Offset: 0x0017688C
		// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x00022EED File Offset: 0x000210ED
		public unsafe static Dictionary<int, string> _FoodPrefixs_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__FoodPrefixs_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__FoodPrefixs_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x001786B4 File Offset: 0x001768B4
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x00022EFF File Offset: 0x000210FF
		public unsafe static Dictionary<int, ObjectLanguageBase> _Ingredients_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Ingredients_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Ingredients_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x001786DC File Offset: 0x001768DC
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x00022F11 File Offset: 0x00021111
		public unsafe static Dictionary<int, ObjectLanguageBase> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Items_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Items_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x00178704 File Offset: 0x00176904
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x00022F23 File Offset: 0x00021123
		public unsafe static Dictionary<int, ObjectLanguageBase> _Badges_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Badges_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Badges_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06003FC7 RID: 16327 RVA: 0x0017872C File Offset: 0x0017692C
		// (set) Token: 0x06003FC8 RID: 16328 RVA: 0x00022F35 File Offset: 0x00021135
		public unsafe static Dictionary<int, ObjectLanguageBase> _Beverages_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Beverages_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Beverages_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x00178754 File Offset: 0x00176954
		// (set) Token: 0x06003FCA RID: 16330 RVA: 0x00022F47 File Offset: 0x00021147
		public unsafe static Dictionary<int, ObjectLanguageBase> _Foods_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Foods_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Foods_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x0017877C File Offset: 0x0017697C
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x00022F59 File Offset: 0x00021159
		public unsafe static Dictionary<Cooker.CookerType, ObjectLanguageBase> _StandardCookers_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__StandardCookers_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerType, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__StandardCookers_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x001787A4 File Offset: 0x001769A4
		// (set) Token: 0x06003FCE RID: 16334 RVA: 0x00022F6B File Offset: 0x0002116B
		public unsafe static Dictionary<string, LanguageBase> _Missions_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Missions_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Missions_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x001787CC File Offset: 0x001769CC
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x00022F7D File Offset: 0x0002117D
		public unsafe static Dictionary<string, LanguageBase> _News_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__News_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__News_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x001787F4 File Offset: 0x001769F4
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x00022F8F File Offset: 0x0002118F
		public unsafe static Dictionary<int, ObjectLanguageBase> _Cookers_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Cookers_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Cookers_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x0017881C File Offset: 0x00176A1C
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x00022FA1 File Offset: 0x000211A1
		public unsafe static Dictionary<int, LanguageBase> _Izakayas_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__Izakayas_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__Izakayas_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x00178844 File Offset: 0x00176A44
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x00022FB3 File Offset: 0x000211B3
		public unsafe static Dictionary<int, LanguageBase> _NormalGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__NormalGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__NormalGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x0017886C File Offset: 0x00176A6C
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x00022FC5 File Offset: 0x000211C5
		public unsafe static Dictionary<int, ValueTuple<string, string, string, string>> _SpecialGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<string, string, string, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x00178894 File Offset: 0x00176A94
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x00022FD7 File Offset: 0x000211D7
		public unsafe static Dictionary<int, Dictionary<int, string>> _SpecialGuestFoodRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestFoodRequest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestFoodRequest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x001788BC File Offset: 0x00176ABC
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x00022FE9 File Offset: 0x000211E9
		public unsafe static Dictionary<int, Dictionary<int, string>> _SpecialGuestBevRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestBevRequest_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<int, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__SpecialGuestBevRequest_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x001788E4 File Offset: 0x00176AE4
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x00022FFB File Offset: 0x000211FB
		public unsafe static Dictionary<EventManager.BuffType, ObjectLanguageBase> _BuffDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__BuffDescription_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EventManager.BuffType, ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__BuffDescription_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x0017890C File Offset: 0x00176B0C
		// (set) Token: 0x06003FE0 RID: 16352 RVA: 0x0002300D File Offset: 0x0002120D
		public unsafe static Dictionary<MissionNode.FinishCondition.ConditionType, string> _MissionFinishCondition_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__MissionFinishCondition_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MissionNode.FinishCondition.ConditionType, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__MissionFinishCondition_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06003FE1 RID: 16353 RVA: 0x00178934 File Offset: 0x00176B34
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x0002301F File Offset: 0x0002121F
		public unsafe static Dictionary<Product.ProductType, string> _RewardCondition_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__RewardCondition_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Product.ProductType, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__RewardCondition_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x0017895C File Offset: 0x00176B5C
		// (set) Token: 0x06003FE4 RID: 16356 RVA: 0x00023031 File Offset: 0x00021231
		public unsafe static Dictionary<PartnerBase.PartnerType, LanguageBase> _PartnerJob_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__PartnerJob_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerBase.PartnerType, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__PartnerJob_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x00178984 File Offset: 0x00176B84
		// (set) Token: 0x06003FE6 RID: 16358 RVA: 0x00023043 File Offset: 0x00021243
		public unsafe static Dictionary<string, LanguageBase> _CGData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__CGData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__CGData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x001789AC File Offset: 0x00176BAC
		// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x00023055 File Offset: 0x00021255
		public unsafe static Dictionary<string, ValueTuple<string, string, string>> _MusicNameData_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__MusicNameData_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<string, string, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__MusicNameData_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x001789D4 File Offset: 0x00176BD4
		// (set) Token: 0x06003FEA RID: 16362 RVA: 0x00023067 File Offset: 0x00021267
		public unsafe static Dictionary<int, Il2CppReferenceArray<LanguageBase>> _SpellLang_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__SpellLang_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<LanguageBase>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__SpellLang_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06003FEB RID: 16363 RVA: 0x001789FC File Offset: 0x00176BFC
		// (set) Token: 0x06003FEC RID: 16364 RVA: 0x00023079 File Offset: 0x00021279
		public unsafe static Dictionary<Cooker.CookerSeries, Sprite> _CookerBGMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.NativeFieldInfoPtr__CookerBGMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerSeries, Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.NativeFieldInfoPtr__CookerBGMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeFieldInfoPtr__BeverageTags_k__BackingField;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeFieldInfoPtr__FoodTags_k__BackingField;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeFieldInfoPtr__FoodTagsDLCMapping_k__BackingField;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeFieldInfoPtr__FoodPrefixs_k__BackingField;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeFieldInfoPtr__Ingredients_k__BackingField;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeFieldInfoPtr__Badges_k__BackingField;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeFieldInfoPtr__Beverages_k__BackingField;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeFieldInfoPtr__Foods_k__BackingField;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeFieldInfoPtr__StandardCookers_k__BackingField;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeFieldInfoPtr__Missions_k__BackingField;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeFieldInfoPtr__News_k__BackingField;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeFieldInfoPtr__Cookers_k__BackingField;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeFieldInfoPtr__Izakayas_k__BackingField;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuest_k__BackingField;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuest_k__BackingField;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestFoodRequest_k__BackingField;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestBevRequest_k__BackingField;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeFieldInfoPtr__BuffDescription_k__BackingField;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeFieldInfoPtr__MissionFinishCondition_k__BackingField;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeFieldInfoPtr__RewardCondition_k__BackingField;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeFieldInfoPtr__PartnerJob_k__BackingField;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeFieldInfoPtr__CGData_k__BackingField;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeFieldInfoPtr__MusicNameData_k__BackingField;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeFieldInfoPtr__SpellLang_k__BackingField;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeFieldInfoPtr__CookerBGMapping_k__BackingField;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeMethodInfoPtr_get_BeverageTags_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeMethodInfoPtr_set_BeverageTags_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodTags_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodTags_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodTagsDLCMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodTagsDLCMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodPrefixs_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodPrefixs_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_get_StandardCookers_Private_Static_get_Dictionary_2_CookerType_ObjectLanguageBase_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_set_StandardCookers_Private_Static_set_Void_Dictionary_2_CookerType_ObjectLanguageBase_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_get_Missions_Private_Static_get_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_set_Missions_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_get_News_Private_Static_get_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_set_News_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_ObjectLanguageBase_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_get_Izakayas_Private_Static_get_Dictionary_2_Int32_LanguageBase_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuest_Private_Static_get_Dictionary_2_Int32_LanguageBase_0;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuest_Private_Static_set_Void_Dictionary_2_Int32_LanguageBase_0;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuest_Private_Static_get_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuest_Private_Static_set_Void_Dictionary_2_Int32_ValueTuple_4_String_String_String_String_0;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestFoodRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestFoodRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestBevRequest_Private_Static_get_Dictionary_2_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestBevRequest_Private_Static_set_Void_Dictionary_2_Int32_Dictionary_2_Int32_String_0;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeMethodInfoPtr_get_BuffDescription_Private_Static_get_Dictionary_2_BuffType_ObjectLanguageBase_0;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeMethodInfoPtr_set_BuffDescription_Private_Static_set_Void_Dictionary_2_BuffType_ObjectLanguageBase_0;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeMethodInfoPtr_get_MissionFinishCondition_Private_Static_get_Dictionary_2_ConditionType_String_0;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeMethodInfoPtr_set_MissionFinishCondition_Private_Static_set_Void_Dictionary_2_ConditionType_String_0;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr_get_RewardCondition_Private_Static_get_Dictionary_2_ProductType_String_0;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeMethodInfoPtr_set_RewardCondition_Private_Static_set_Void_Dictionary_2_ProductType_String_0;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerJob_Private_Static_get_Dictionary_2_PartnerType_LanguageBase_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeMethodInfoPtr_set_PartnerJob_Private_Static_set_Void_Dictionary_2_PartnerType_LanguageBase_0;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeMethodInfoPtr_get_CGData_Private_Static_get_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeMethodInfoPtr_set_CGData_Private_Static_set_Void_Dictionary_2_String_LanguageBase_0;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicNameData_Private_Static_get_Dictionary_2_String_ValueTuple_3_String_String_String_0;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicNameData_Private_Static_set_Void_Dictionary_2_String_ValueTuple_3_String_String_String_0;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeMethodInfoPtr_get_SpellLang_Private_Static_get_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_set_SpellLang_Private_Static_set_Void_Dictionary_2_Int32_Il2CppReferenceArray_1_LanguageBase_0;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerBGMapping_Private_Static_get_Dictionary_2_CookerSeries_Sprite_0;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerBGMapping_Private_Static_set_Void_Dictionary_2_CookerSeries_Sprite_0;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_String_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_ObjectLanguageBase_Dictionary_2_Int32_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_String_LanguageBase_Dictionary_2_CookerType_ObjectLa;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeMethodInfoPtr_RefSpellLang_Public_Static_Il2CppReferenceArray_1_LanguageBase_Int32_0;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeMethodInfoPtr_GetBeverageTag_Public_Static_String_Int32_0;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodTag_Public_Static_String_Int32_0;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoodTags_Public_Static_Dictionary_2_Int32_String_0;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoodTagsId_Public_Static_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodTagMapping_Public_Static_String_Int32_0;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBeverageTags_Public_Static_Dictionary_2_Int32_String_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_FoodPrefix_Public_Static_String_Int32_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr_GetItemLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeMethodInfoPtr_GetBadgeLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeMethodInfoPtr_GetBeverageLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodToRecipeLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerLang_Public_Static_ObjectLanguageBase_Int32_0;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaLang_Public_Static_LanguageBase_Int32_0;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalGuestLang_Public_Static_LanguageBase_Int32_0;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestLang_Public_Static_LanguageBase_Int32_0;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialFoodTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialBevTagLang_Public_Static_Dictionary_2_Int32_String_Int32_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSpecialGuestsNames_Public_Static_Dictionary_2_Int32_String_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr_GetStdCooker_Public_Static_ObjectLanguageBase_CookerType_0;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeMethodInfoPtr_GetMissionLanguage_Public_Static_LanguageBase_String_0;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeMethodInfoPtr_GetNewsLanguage_Public_Static_LanguageBase_String_0;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeMethodInfoPtr_GetMissionConditionLang_Public_Static_String_ConditionType_0;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeMethodInfoPtr_GetRewardConditionLang_Public_Static_String_ProductType_0;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerJobLang_Public_Static_LanguageBase_PartnerType_0;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeMethodInfoPtr_GetCGLabelLang_Public_Static_LanguageBase_String_0;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeMethodInfoPtr_GetMusicKeyLang_Public_Static_String_String_0;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_RefBuffLang_Public_Static_ObjectLanguageBase_BuffType_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_GetMusicGameChapterLang_Public_Static_ValueTuple_3_String_String_String_String_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefix_Public_Static_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefix_Public_Static_String_Ingredient_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerBG_Public_Static_Sprite_CookerSeries_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_GetEvalText_Public_Static_String_Int32_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_GetEvalText_Public_Static_String_EvaluationResult_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_0;

		// Token: 0x020009DB RID: 2523
		[ObfuscatedName("GameData.CoreLanguage.Collections.DataBaseLanguage+<>c__DisplayClass104_0")]
		public sealed class __c__DisplayClass104_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C17A RID: 49530 RVA: 0x0030454C File Offset: 0x0030274C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass104_0()
			{
				Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<>c__DisplayClass104_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr);
				DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr, "specialFood");
				DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr, "specialBev");
				DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr, 100675293);
				DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr, 100675294);
				DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__Initialize_b__9_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr, 100675295);
			}

			// Token: 0x0600C17B RID: 49531 RVA: 0x003045DC File Offset: 0x003027DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass104_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseLanguage.__c__DisplayClass104_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C17C RID: 49532 RVA: 0x00304618 File Offset: 0x00302818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155906, XrefRangeEnd = 155911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__2(KeyValuePair<int, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C17D RID: 49533 RVA: 0x0030466C File Offset: 0x0030286C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155911, XrefRangeEnd = 155916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__9(KeyValuePair<int, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c__DisplayClass104_0.NativeMethodInfoPtr__Initialize_b__9_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C17E RID: 49534 RVA: 0x00068744 File Offset: 0x00066944
			public __c__DisplayClass104_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F06 RID: 16134
			// (get) Token: 0x0600C17F RID: 49535 RVA: 0x003046C0 File Offset: 0x003028C0
			// (set) Token: 0x0600C180 RID: 49536 RVA: 0x0006874D File Offset: 0x0006694D
			public unsafe Dictionary<int, Il2CppStringArray> specialFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F07 RID: 16135
			// (get) Token: 0x0600C181 RID: 49537 RVA: 0x003046F0 File Offset: 0x003028F0
			// (set) Token: 0x0600C182 RID: 49538 RVA: 0x0006876C File Offset: 0x0006696C
			public unsafe Dictionary<int, Il2CppStringArray> specialBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseLanguage.__c__DisplayClass104_0.NativeFieldInfoPtr_specialBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007C98 RID: 31896
			private static readonly IntPtr NativeFieldInfoPtr_specialFood;

			// Token: 0x04007C99 RID: 31897
			private static readonly IntPtr NativeFieldInfoPtr_specialBev;

			// Token: 0x04007C9A RID: 31898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007C9B RID: 31899
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__2_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04007C9C RID: 31900
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__9_Internal_Boolean_KeyValuePair_2_Int32_IEnumerable_1_Int32_0;
		}

		// Token: 0x020009DC RID: 2524
		[ObfuscatedName("GameData.CoreLanguage.Collections.DataBaseLanguage+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C183 RID: 49539 RVA: 0x00304720 File Offset: 0x00302920
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseLanguage>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr);
				DataBaseLanguage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_0");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_14");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_1");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_3");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_4");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_5");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_15");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_16");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_6");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_7");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_17");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_8");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_10");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_11");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_12");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_18");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_19");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__104_13");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__125_0");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__125_1");
				DataBaseLanguage.__c.NativeFieldInfoPtr___9__136_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, "<>9__136_0");
				DataBaseLanguage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675297);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_0_Internal_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675298);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_1_Internal_IEnumerable_1_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675299);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_14_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675300);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_3_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675301);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_4_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675302);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_5_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675303);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_6_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675304);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_15_Internal_Int32_Tuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675305);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_16_Internal_String_Tuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675306);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_7_Internal_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675307);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_8_Internal_IEnumerable_1_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675308);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_17_Internal_Int32_WeightedTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675309);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_10_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675310);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_11_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675311);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_12_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675312);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_13_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675313);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_18_Internal_Int32_Tuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675314);
				DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_19_Internal_String_Tuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675315);
				DataBaseLanguage.__c.NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675316);
				DataBaseLanguage.__c.NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_1_Internal_String_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675317);
				DataBaseLanguage.__c.NativeMethodInfoPtr__GetPrefix_b__136_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr, 100675318);
			}

			// Token: 0x0600C184 RID: 49540 RVA: 0x00304ABC File Offset: 0x00302CBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseLanguage.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C185 RID: 49541 RVA: 0x00304AF8 File Offset: 0x00302CF8
			[CallerCount(0)]
			public unsafe int _Initialize_b__104_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_0_Internal_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C186 RID: 49542 RVA: 0x00304B48 File Offset: 0x00302D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155916, XrefRangeEnd = 155935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _Initialize_b__104_1(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_1_Internal_IEnumerable_1_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C187 RID: 49543 RVA: 0x00304B98 File Offset: 0x00302D98
			[CallerCount(0)]
			public unsafe int _Initialize_b__104_14(SpecialGuest.WeightedTag y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_14_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C188 RID: 49544 RVA: 0x00304BE8 File Offset: 0x00302DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155935, XrefRangeEnd = 155936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_3(KeyValuePair<int, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_3_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C189 RID: 49545 RVA: 0x00304C3C File Offset: 0x00302E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155936, XrefRangeEnd = 155937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_4(KeyValuePair<int, Il2CppStringArray> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_4_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C18A RID: 49546 RVA: 0x00304C90 File Offset: 0x00302E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155937, XrefRangeEnd = 155939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_5(Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_5_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C18B RID: 49547 RVA: 0x00304CE0 File Offset: 0x00302EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155939, XrefRangeEnd = 155985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<int, string> _Initialize_b__104_6(Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_6_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}

			// Token: 0x0600C18C RID: 49548 RVA: 0x00304D30 File Offset: 0x00302F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155985, XrefRangeEnd = 155986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_15(Tuple<int, string> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_15_Internal_Int32_Tuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C18D RID: 49549 RVA: 0x00304D80 File Offset: 0x00302F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155986, XrefRangeEnd = 155987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__104_16(Tuple<int, string> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_16_Internal_String_Tuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C18E RID: 49550 RVA: 0x00304DC8 File Offset: 0x00302FC8
			[CallerCount(0)]
			public unsafe int _Initialize_b__104_7(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_7_Internal_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C18F RID: 49551 RVA: 0x00304E18 File Offset: 0x00303018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155987, XrefRangeEnd = 156006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _Initialize_b__104_8(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_8_Internal_IEnumerable_1_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C190 RID: 49552 RVA: 0x00304E68 File Offset: 0x00303068
			[CallerCount(0)]
			public unsafe int _Initialize_b__104_17(SpecialGuest.WeightedTag y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_17_Internal_Int32_WeightedTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C191 RID: 49553 RVA: 0x00304EB8 File Offset: 0x003030B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156006, XrefRangeEnd = 156007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_10(KeyValuePair<int, IEnumerable<int>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_10_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C192 RID: 49554 RVA: 0x00304F0C File Offset: 0x0030310C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156007, XrefRangeEnd = 156008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_11(KeyValuePair<int, Il2CppStringArray> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_11_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C193 RID: 49555 RVA: 0x00304F60 File Offset: 0x00303160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156008, XrefRangeEnd = 156010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_12(Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_12_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C194 RID: 49556 RVA: 0x00304FB0 File Offset: 0x003031B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156010, XrefRangeEnd = 156056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<int, string> _Initialize_b__104_13(Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_13_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}

			// Token: 0x0600C195 RID: 49557 RVA: 0x00305000 File Offset: 0x00303200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156056, XrefRangeEnd = 156057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Initialize_b__104_18(Tuple<int, string> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_18_Internal_Int32_Tuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C196 RID: 49558 RVA: 0x00305050 File Offset: 0x00303250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156057, XrefRangeEnd = 156058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__104_19(Tuple<int, string> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__Initialize_b__104_19_Internal_String_Tuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C197 RID: 49559 RVA: 0x00305098 File Offset: 0x00303298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156058, XrefRangeEnd = 156059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllSpecialGuestsNames_b__125_0(KeyValuePair<int, ValueTuple<string, string, string, string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C198 RID: 49560 RVA: 0x003050EC File Offset: 0x003032EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156059, XrefRangeEnd = 156061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllSpecialGuestsNames_b__125_1(KeyValuePair<int, ValueTuple<string, string, string, string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_1_Internal_String_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C199 RID: 49561 RVA: 0x0030513C File Offset: 0x0030333C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _GetPrefix_b__136_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseLanguage.__c.NativeMethodInfoPtr__GetPrefix_b__136_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600C19A RID: 49562 RVA: 0x0006878B File Offset: 0x0006698B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F08 RID: 16136
			// (get) Token: 0x0600C19B RID: 49563 RVA: 0x00305188 File Offset: 0x00303388
			// (set) Token: 0x0600C19C RID: 49564 RVA: 0x00068794 File Offset: 0x00066994
			public unsafe static DataBaseLanguage.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseLanguage.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F09 RID: 16137
			// (get) Token: 0x0600C19D RID: 49565 RVA: 0x003051B0 File Offset: 0x003033B0
			// (set) Token: 0x0600C19E RID: 49566 RVA: 0x000687A6 File Offset: 0x000669A6
			public unsafe static Func<SpecialGuest, int> __9__104_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0A RID: 16138
			// (get) Token: 0x0600C19F RID: 49567 RVA: 0x003051D8 File Offset: 0x003033D8
			// (set) Token: 0x0600C1A0 RID: 49568 RVA: 0x000687B8 File Offset: 0x000669B8
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__104_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0B RID: 16139
			// (get) Token: 0x0600C1A1 RID: 49569 RVA: 0x00305200 File Offset: 0x00303400
			// (set) Token: 0x0600C1A2 RID: 49570 RVA: 0x000687CA File Offset: 0x000669CA
			public unsafe static Func<SpecialGuest, IEnumerable<int>> __9__104_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0C RID: 16140
			// (get) Token: 0x0600C1A3 RID: 49571 RVA: 0x00305228 File Offset: 0x00303428
			// (set) Token: 0x0600C1A4 RID: 49572 RVA: 0x000687DC File Offset: 0x000669DC
			public unsafe static Func<KeyValuePair<int, IEnumerable<int>>, int> __9__104_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, IEnumerable<int>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0D RID: 16141
			// (get) Token: 0x0600C1A5 RID: 49573 RVA: 0x00305250 File Offset: 0x00303450
			// (set) Token: 0x0600C1A6 RID: 49574 RVA: 0x000687EE File Offset: 0x000669EE
			public unsafe static Func<KeyValuePair<int, Il2CppStringArray>, int> __9__104_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppStringArray>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0E RID: 16142
			// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x00305278 File Offset: 0x00303478
			// (set) Token: 0x0600C1A8 RID: 49576 RVA: 0x00068800 File Offset: 0x00066A00
			public unsafe static Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, int> __9__104_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0F RID: 16143
			// (get) Token: 0x0600C1A9 RID: 49577 RVA: 0x003052A0 File Offset: 0x003034A0
			// (set) Token: 0x0600C1AA RID: 49578 RVA: 0x00068812 File Offset: 0x00066A12
			public unsafe static Func<Tuple<int, string>, int> __9__104_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<int, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F10 RID: 16144
			// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x003052C8 File Offset: 0x003034C8
			// (set) Token: 0x0600C1AC RID: 49580 RVA: 0x00068824 File Offset: 0x00066A24
			public unsafe static Func<Tuple<int, string>, string> __9__104_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<int, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F11 RID: 16145
			// (get) Token: 0x0600C1AD RID: 49581 RVA: 0x003052F0 File Offset: 0x003034F0
			// (set) Token: 0x0600C1AE RID: 49582 RVA: 0x00068836 File Offset: 0x00066A36
			public unsafe static Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, Dictionary<int, string>> __9__104_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F12 RID: 16146
			// (get) Token: 0x0600C1AF RID: 49583 RVA: 0x00305318 File Offset: 0x00303518
			// (set) Token: 0x0600C1B0 RID: 49584 RVA: 0x00068848 File Offset: 0x00066A48
			public unsafe static Func<SpecialGuest, int> __9__104_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F13 RID: 16147
			// (get) Token: 0x0600C1B1 RID: 49585 RVA: 0x00305340 File Offset: 0x00303540
			// (set) Token: 0x0600C1B2 RID: 49586 RVA: 0x0006885A File Offset: 0x00066A5A
			public unsafe static Func<SpecialGuest.WeightedTag, int> __9__104_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest.WeightedTag, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F14 RID: 16148
			// (get) Token: 0x0600C1B3 RID: 49587 RVA: 0x00305368 File Offset: 0x00303568
			// (set) Token: 0x0600C1B4 RID: 49588 RVA: 0x0006886C File Offset: 0x00066A6C
			public unsafe static Func<SpecialGuest, IEnumerable<int>> __9__104_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F15 RID: 16149
			// (get) Token: 0x0600C1B5 RID: 49589 RVA: 0x00305390 File Offset: 0x00303590
			// (set) Token: 0x0600C1B6 RID: 49590 RVA: 0x0006887E File Offset: 0x00066A7E
			public unsafe static Func<KeyValuePair<int, IEnumerable<int>>, int> __9__104_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, IEnumerable<int>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F16 RID: 16150
			// (get) Token: 0x0600C1B7 RID: 49591 RVA: 0x003053B8 File Offset: 0x003035B8
			// (set) Token: 0x0600C1B8 RID: 49592 RVA: 0x00068890 File Offset: 0x00066A90
			public unsafe static Func<KeyValuePair<int, Il2CppStringArray>, int> __9__104_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Il2CppStringArray>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F17 RID: 16151
			// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x003053E0 File Offset: 0x003035E0
			// (set) Token: 0x0600C1BA RID: 49594 RVA: 0x000688A2 File Offset: 0x00066AA2
			public unsafe static Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, int> __9__104_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F18 RID: 16152
			// (get) Token: 0x0600C1BB RID: 49595 RVA: 0x00305408 File Offset: 0x00303608
			// (set) Token: 0x0600C1BC RID: 49596 RVA: 0x000688B4 File Offset: 0x00066AB4
			public unsafe static Func<Tuple<int, string>, int> __9__104_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<int, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F19 RID: 16153
			// (get) Token: 0x0600C1BD RID: 49597 RVA: 0x00305430 File Offset: 0x00303630
			// (set) Token: 0x0600C1BE RID: 49598 RVA: 0x000688C6 File Offset: 0x00066AC6
			public unsafe static Func<Tuple<int, string>, string> __9__104_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<int, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1A RID: 16154
			// (get) Token: 0x0600C1BF RID: 49599 RVA: 0x00305458 File Offset: 0x00303658
			// (set) Token: 0x0600C1C0 RID: 49600 RVA: 0x000688D8 File Offset: 0x00066AD8
			public unsafe static Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, Dictionary<int, string>> __9__104_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<KeyValuePair<int, IEnumerable<int>>, KeyValuePair<int, Il2CppStringArray>>, Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__104_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1B RID: 16155
			// (get) Token: 0x0600C1C1 RID: 49601 RVA: 0x00305480 File Offset: 0x00303680
			// (set) Token: 0x0600C1C2 RID: 49602 RVA: 0x000688EA File Offset: 0x00066AEA
			public unsafe static Func<KeyValuePair<int, ValueTuple<string, string, string, string>>, int> __9__125_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<string, string, string, string>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1C RID: 16156
			// (get) Token: 0x0600C1C3 RID: 49603 RVA: 0x003054A8 File Offset: 0x003036A8
			// (set) Token: 0x0600C1C4 RID: 49604 RVA: 0x000688FC File Offset: 0x00066AFC
			public unsafe static Func<KeyValuePair<int, ValueTuple<string, string, string, string>>, string> __9__125_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<string, string, string, string>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__125_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1D RID: 16157
			// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x003054D0 File Offset: 0x003036D0
			// (set) Token: 0x0600C1C6 RID: 49606 RVA: 0x0006890E File Offset: 0x00066B0E
			public unsafe static Func<int, Ingredient> __9__136_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__136_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseLanguage.__c.NativeFieldInfoPtr___9__136_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007C9D RID: 31901
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007C9E RID: 31902
			private static readonly IntPtr NativeFieldInfoPtr___9__104_0;

			// Token: 0x04007C9F RID: 31903
			private static readonly IntPtr NativeFieldInfoPtr___9__104_14;

			// Token: 0x04007CA0 RID: 31904
			private static readonly IntPtr NativeFieldInfoPtr___9__104_1;

			// Token: 0x04007CA1 RID: 31905
			private static readonly IntPtr NativeFieldInfoPtr___9__104_3;

			// Token: 0x04007CA2 RID: 31906
			private static readonly IntPtr NativeFieldInfoPtr___9__104_4;

			// Token: 0x04007CA3 RID: 31907
			private static readonly IntPtr NativeFieldInfoPtr___9__104_5;

			// Token: 0x04007CA4 RID: 31908
			private static readonly IntPtr NativeFieldInfoPtr___9__104_15;

			// Token: 0x04007CA5 RID: 31909
			private static readonly IntPtr NativeFieldInfoPtr___9__104_16;

			// Token: 0x04007CA6 RID: 31910
			private static readonly IntPtr NativeFieldInfoPtr___9__104_6;

			// Token: 0x04007CA7 RID: 31911
			private static readonly IntPtr NativeFieldInfoPtr___9__104_7;

			// Token: 0x04007CA8 RID: 31912
			private static readonly IntPtr NativeFieldInfoPtr___9__104_17;

			// Token: 0x04007CA9 RID: 31913
			private static readonly IntPtr NativeFieldInfoPtr___9__104_8;

			// Token: 0x04007CAA RID: 31914
			private static readonly IntPtr NativeFieldInfoPtr___9__104_10;

			// Token: 0x04007CAB RID: 31915
			private static readonly IntPtr NativeFieldInfoPtr___9__104_11;

			// Token: 0x04007CAC RID: 31916
			private static readonly IntPtr NativeFieldInfoPtr___9__104_12;

			// Token: 0x04007CAD RID: 31917
			private static readonly IntPtr NativeFieldInfoPtr___9__104_18;

			// Token: 0x04007CAE RID: 31918
			private static readonly IntPtr NativeFieldInfoPtr___9__104_19;

			// Token: 0x04007CAF RID: 31919
			private static readonly IntPtr NativeFieldInfoPtr___9__104_13;

			// Token: 0x04007CB0 RID: 31920
			private static readonly IntPtr NativeFieldInfoPtr___9__125_0;

			// Token: 0x04007CB1 RID: 31921
			private static readonly IntPtr NativeFieldInfoPtr___9__125_1;

			// Token: 0x04007CB2 RID: 31922
			private static readonly IntPtr NativeFieldInfoPtr___9__136_0;

			// Token: 0x04007CB3 RID: 31923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007CB4 RID: 31924
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_0_Internal_Int32_SpecialGuest_0;

			// Token: 0x04007CB5 RID: 31925
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_1_Internal_IEnumerable_1_Int32_SpecialGuest_0;

			// Token: 0x04007CB6 RID: 31926
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_14_Internal_Int32_WeightedTag_0;

			// Token: 0x04007CB7 RID: 31927
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_3_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04007CB8 RID: 31928
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_4_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CB9 RID: 31929
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_5_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CBA RID: 31930
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_6_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CBB RID: 31931
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_15_Internal_Int32_Tuple_2_Int32_String_0;

			// Token: 0x04007CBC RID: 31932
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_16_Internal_String_Tuple_2_Int32_String_0;

			// Token: 0x04007CBD RID: 31933
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_7_Internal_Int32_SpecialGuest_0;

			// Token: 0x04007CBE RID: 31934
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_8_Internal_IEnumerable_1_Int32_SpecialGuest_0;

			// Token: 0x04007CBF RID: 31935
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_17_Internal_Int32_WeightedTag_0;

			// Token: 0x04007CC0 RID: 31936
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_10_Internal_Int32_KeyValuePair_2_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04007CC1 RID: 31937
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_11_Internal_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CC2 RID: 31938
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_12_Internal_Int32_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CC3 RID: 31939
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_13_Internal_Dictionary_2_Int32_String_Tuple_2_KeyValuePair_2_Int32_IEnumerable_1_Int32_KeyValuePair_2_Int32_Il2CppStringArray_0;

			// Token: 0x04007CC4 RID: 31940
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_18_Internal_Int32_Tuple_2_Int32_String_0;

			// Token: 0x04007CC5 RID: 31941
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__104_19_Internal_String_Tuple_2_Int32_String_0;

			// Token: 0x04007CC6 RID: 31942
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_0_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0;

			// Token: 0x04007CC7 RID: 31943
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialGuestsNames_b__125_1_Internal_String_KeyValuePair_2_Int32_ValueTuple_4_String_String_String_String_0;

			// Token: 0x04007CC8 RID: 31944
			private static readonly IntPtr NativeMethodInfoPtr__GetPrefix_b__136_0_Internal_Ingredient_Int32_0;
		}
	}
}
