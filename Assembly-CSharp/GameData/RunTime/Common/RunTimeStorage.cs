using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x02000230 RID: 560
	public static class RunTimeStorage : Il2CppSystem.Object
	{
		// Token: 0x0600456F RID: 17775 RVA: 0x0018DBB8 File Offset: 0x0018BDB8
		// Note: this type is marked as 'beforefieldinit'.
		static RunTimeStorage()
		{
			Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "RunTimeStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr);
			RunTimeStorage.NativeFieldInfoPtr_GREEN_TEA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "GREEN_TEA_ID");
			RunTimeStorage.NativeFieldInfoPtr_DARK_MATTER_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "DARK_MATTER_ID");
			RunTimeStorage.NativeFieldInfoPtr_RICE_BALL_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "RICE_BALL_ID");
			RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_CLOTHES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "MYSTIA_NORMAL_CLOTHES");
			RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_WORKING_CLOTHES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "MYSTIA_NORMAL_WORKING_CLOTHES");
			RunTimeStorage.NativeFieldInfoPtr_MAX_OBJECT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "MAX_OBJECT_COUNT");
			RunTimeStorage.NativeFieldInfoPtr_MAX_FUND_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "MAX_FUND_AMOUNT");
			RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<OnAnyObjectInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectOutCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<OnAnyObjectOutCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__ObjectLangageBaseInCounted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<ObjectLangageBaseInCounted>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__BadgeInCounted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<BadgeInCounted>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__RecipeInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<RecipeInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__IzakayaInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<IzakayaInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__DecorationInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<DecorationInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__PartnerInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<PartnerInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__TrophyInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<TrophyInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__CookerInCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<CookerInCallback>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Foods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Foods>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Beverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Beverages>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Ingredients_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Ingredients>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Cookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Cookers>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Items>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Badges_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Badges>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Trophies_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Trophies>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__ItemsDeleteEnterWork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<ItemsDeleteEnterWork>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Recipes>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__Izakayas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<Izakayas>k__BackingField");
			RunTimeStorage.NativeFieldInfoPtr__UnlockedPartner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<UnlockedPartner>k__BackingField");
			RunTimeStorage.NativeMethodInfoPtr_get_OnAnyObjectInCallback_Public_Static_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676934);
			RunTimeStorage.NativeMethodInfoPtr_set_OnAnyObjectInCallback_Public_Static_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676935);
			RunTimeStorage.NativeMethodInfoPtr_get_OnAnyObjectOutCallback_Public_Static_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676936);
			RunTimeStorage.NativeMethodInfoPtr_set_OnAnyObjectOutCallback_Public_Static_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676937);
			RunTimeStorage.NativeMethodInfoPtr_get_ObjectLangageBaseInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676938);
			RunTimeStorage.NativeMethodInfoPtr_set_ObjectLangageBaseInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676939);
			RunTimeStorage.NativeMethodInfoPtr_get_BadgeInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676940);
			RunTimeStorage.NativeMethodInfoPtr_set_BadgeInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676941);
			RunTimeStorage.NativeMethodInfoPtr_get_RecipeInCallback_Public_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676942);
			RunTimeStorage.NativeMethodInfoPtr_set_RecipeInCallback_Public_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676943);
			RunTimeStorage.NativeMethodInfoPtr_get_IzakayaInCallback_Public_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676944);
			RunTimeStorage.NativeMethodInfoPtr_set_IzakayaInCallback_Public_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676945);
			RunTimeStorage.NativeMethodInfoPtr_get_DecorationInCallback_Public_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676946);
			RunTimeStorage.NativeMethodInfoPtr_set_DecorationInCallback_Public_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676947);
			RunTimeStorage.NativeMethodInfoPtr_get_PartnerInCallback_Public_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676948);
			RunTimeStorage.NativeMethodInfoPtr_set_PartnerInCallback_Public_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676949);
			RunTimeStorage.NativeMethodInfoPtr_get_TrophyInCallback_Public_Static_get_Action_1_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676950);
			RunTimeStorage.NativeMethodInfoPtr_set_TrophyInCallback_Public_Static_set_Void_Action_1_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676951);
			RunTimeStorage.NativeMethodInfoPtr_get_CookerInCallback_Public_Static_get_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676952);
			RunTimeStorage.NativeMethodInfoPtr_set_CookerInCallback_Public_Static_set_Void_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676953);
			RunTimeStorage.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676954);
			RunTimeStorage.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676955);
			RunTimeStorage.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676956);
			RunTimeStorage.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676957);
			RunTimeStorage.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676958);
			RunTimeStorage.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676959);
			RunTimeStorage.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676960);
			RunTimeStorage.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676961);
			RunTimeStorage.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676962);
			RunTimeStorage.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676963);
			RunTimeStorage.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676964);
			RunTimeStorage.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676965);
			RunTimeStorage.NativeMethodInfoPtr_get_Trophies_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676966);
			RunTimeStorage.NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676967);
			RunTimeStorage.NativeMethodInfoPtr_get_ItemsDeleteEnterWork_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676968);
			RunTimeStorage.NativeMethodInfoPtr_set_ItemsDeleteEnterWork_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676969);
			RunTimeStorage.NativeMethodInfoPtr_get_Recipes_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676970);
			RunTimeStorage.NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676971);
			RunTimeStorage.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676972);
			RunTimeStorage.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676973);
			RunTimeStorage.NativeMethodInfoPtr_get_UnlockedPartner_Private_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676974);
			RunTimeStorage.NativeMethodInfoPtr_set_UnlockedPartner_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676975);
			RunTimeStorage.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeStorageSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676976);
			RunTimeStorage.NativeMethodInfoPtr_ForceObjectsNum_Private_Static_Void_Dictionary_2_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676977);
			RunTimeStorage.NativeMethodInfoPtr_GetElementCount_Private_Static_Int32_Dictionary_2_Int32_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676978);
			RunTimeStorage.NativeMethodInfoPtr_GetAmountInStorage_Public_Static_Int64_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676979);
			RunTimeStorage.NativeMethodInfoPtr_SendToStorage_Public_Static_Void_Product_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676980);
			RunTimeStorage.NativeMethodInfoPtr_RemoveFromStorage_Public_Static_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676981);
			RunTimeStorage.NativeMethodInfoPtr_ClearForChallenge_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676982);
			RunTimeStorage.NativeMethodInfoPtr_DumpForChallenge_Public_Static_Void_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676983);
			RunTimeStorage.NativeMethodInfoPtr_InitializeForChallenge_Public_Static_Void_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676984);
			RunTimeStorage.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676985);
			RunTimeStorage.NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_T_Action_1_Int32_Boolean_Action_2_T_Int32_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676986);
			RunTimeStorage.NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_ObjectLanguageBase_Action_1_Int32_Boolean_Action_2_ObjectLanguageBase_Int32_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676987);
			RunTimeStorage.NativeMethodInfoPtr_ObjectOut_Private_Static_Void_Dictionary_2_Int32_Int32_Int32_Boolean_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676988);
			RunTimeStorage.NativeMethodInfoPtr_ObjectOutRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Boolean_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676989);
			RunTimeStorage.NativeMethodInfoPtr_GetObject_Private_Static_Il2CppReferenceArray_1_KeyValuePair_2_T_Int32_Dictionary_2_Int32_Int32_Func_2_Int32_T_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676990);
			RunTimeStorage.NativeMethodInfoPtr_TryGetObjectByTag_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Il2CppStructArray_1_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676991);
			RunTimeStorage.NativeMethodInfoPtr_TryGetObjectByLevel_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676992);
			RunTimeStorage.NativeMethodInfoPtr_ObjectInDistinct_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676993);
			RunTimeStorage.NativeMethodInfoPtr_ObjectInRangeDistinct_Private_Static_Void_List_1_Int32_IEnumerable_1_Int32_Action_1_Int32_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676994);
			RunTimeStorage.NativeMethodInfoPtr_CountFood_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676995);
			RunTimeStorage.NativeMethodInfoPtr_GetFoodCountById_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676996);
			RunTimeStorage.NativeMethodInfoPtr_CountFoodLong_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676997);
			RunTimeStorage.NativeMethodInfoPtr_FoodInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676998);
			RunTimeStorage.NativeMethodInfoPtr_FoodOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100676999);
			RunTimeStorage.NativeMethodInfoPtr_FoodOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677000);
			RunTimeStorage.NativeMethodInfoPtr_TryGetFoodById_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677001);
			RunTimeStorage.NativeMethodInfoPtr_TryGetFoodByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677002);
			RunTimeStorage.NativeMethodInfoPtr_TryGetFoodByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677003);
			RunTimeStorage.NativeMethodInfoPtr_GetAllFoods_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677004);
			RunTimeStorage.NativeMethodInfoPtr_GetAllFoodsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677005);
			RunTimeStorage.NativeMethodInfoPtr_InvalifyAllFoods_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677006);
			RunTimeStorage.NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677007);
			RunTimeStorage.NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677008);
			RunTimeStorage.NativeMethodInfoPtr_BeverageInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677009);
			RunTimeStorage.NativeMethodInfoPtr_BeverageOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677010);
			RunTimeStorage.NativeMethodInfoPtr_BeverageOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677011);
			RunTimeStorage.NativeMethodInfoPtr_ClearAllBeverage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677012);
			RunTimeStorage.NativeMethodInfoPtr_GetBeverageCountById_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677013);
			RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageById_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677014);
			RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677015);
			RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677016);
			RunTimeStorage.NativeMethodInfoPtr_GetAllBeverages_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677017);
			RunTimeStorage.NativeMethodInfoPtr_GetAllBeveragesId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677018);
			RunTimeStorage.NativeMethodInfoPtr_TryGetInfiniteIngredientResolver_Private_Static_Predicate_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677019);
			RunTimeStorage.NativeMethodInfoPtr_GetIngredientCountById_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677020);
			RunTimeStorage.NativeMethodInfoPtr_CountIngredient_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677021);
			RunTimeStorage.NativeMethodInfoPtr_IngredientInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677022);
			RunTimeStorage.NativeMethodInfoPtr_IngredientOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677023);
			RunTimeStorage.NativeMethodInfoPtr_IngredientOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677024);
			RunTimeStorage.NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677025);
			RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientById_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677026);
			RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677027);
			RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677028);
			RunTimeStorage.NativeMethodInfoPtr_ContainsAllFollowingIngredients_Public_Static_Boolean_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677029);
			RunTimeStorage.NativeMethodInfoPtr_GetAllIngredients_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677030);
			RunTimeStorage.NativeMethodInfoPtr_CountCooker_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677031);
			RunTimeStorage.NativeMethodInfoPtr_HasCooker_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677032);
			RunTimeStorage.NativeMethodInfoPtr_GetCookerCountById_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677033);
			RunTimeStorage.NativeMethodInfoPtr_CookerInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677034);
			RunTimeStorage.NativeMethodInfoPtr_CookerOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677035);
			RunTimeStorage.NativeMethodInfoPtr_CookerOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677036);
			RunTimeStorage.NativeMethodInfoPtr_GetAllCookers_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677037);
			RunTimeStorage.NativeMethodInfoPtr_SolveGlobalCookCount_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677038);
			RunTimeStorage.NativeMethodInfoPtr_SolveCookCount_Public_Static_Void_IEnumerable_1_Recipe_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677039);
			RunTimeStorage.NativeMethodInfoPtr_CountItem_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677040);
			RunTimeStorage.NativeMethodInfoPtr_CountItem_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677041);
			RunTimeStorage.NativeMethodInfoPtr_GetItemCountById_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677042);
			RunTimeStorage.NativeMethodInfoPtr_ItemInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677043);
			RunTimeStorage.NativeMethodInfoPtr_ItemInRangeWithoutDecorationNotice_Public_Static_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677044);
			RunTimeStorage.NativeMethodInfoPtr_ItemOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677045);
			RunTimeStorage.NativeMethodInfoPtr_GetAllItems_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677046);
			RunTimeStorage.NativeMethodInfoPtr_GetAllItemsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677047);
			RunTimeStorage.NativeMethodInfoPtr_ItemOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677048);
			RunTimeStorage.NativeMethodInfoPtr_HasBadge_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677049);
			RunTimeStorage.NativeMethodInfoPtr_GetAllBadges_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Badge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677050);
			RunTimeStorage.NativeMethodInfoPtr_BadgeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677051);
			RunTimeStorage.NativeMethodInfoPtr_BadgeOut_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677052);
			RunTimeStorage.NativeMethodInfoPtr_BadgeOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677053);
			RunTimeStorage.NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677054);
			RunTimeStorage.NativeMethodInfoPtr_ContainsItem_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677055);
			RunTimeStorage.NativeMethodInfoPtr_GetAllClothes_Public_Static_Il2CppReferenceArray_1_Clothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677056);
			RunTimeStorage.NativeMethodInfoPtr_GetAllDecorations_Public_Static_Il2CppReferenceArray_1_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677057);
			RunTimeStorage.NativeMethodInfoPtr_GetAllRecords_Public_Static_Il2CppReferenceArray_1_Record_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677058);
			RunTimeStorage.NativeMethodInfoPtr_GetAllTrophies_Public_Static_Il2CppReferenceArray_1_Trophy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677059);
			RunTimeStorage.NativeMethodInfoPtr_TrophyInRange_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677060);
			RunTimeStorage.NativeMethodInfoPtr_HasTrophy_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677061);
			RunTimeStorage.NativeMethodInfoPtr_DeleteAllItemsBeforeWork_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677062);
			RunTimeStorage.NativeMethodInfoPtr_HaveRecipe_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677063);
			RunTimeStorage.NativeMethodInfoPtr_CountRecipes_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677064);
			RunTimeStorage.NativeMethodInfoPtr_RecipeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677065);
			RunTimeStorage.NativeMethodInfoPtr_RecipeOut_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677066);
			RunTimeStorage.NativeMethodInfoPtr_RecipeOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677067);
			RunTimeStorage.NativeMethodInfoPtr_GetAllRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677068);
			RunTimeStorage.NativeMethodInfoPtr_GetAllRecipeIndex_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677069);
			RunTimeStorage.NativeMethodInfoPtr_GetRecipesByCookerType_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677070);
			RunTimeStorage.NativeMethodInfoPtr_HasIzakaya_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677071);
			RunTimeStorage.NativeMethodInfoPtr_IzakayaIn_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677072);
			RunTimeStorage.NativeMethodInfoPtr_IzakayaInRange_Public_Static_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677073);
			RunTimeStorage.NativeMethodInfoPtr_GetAllPartners_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677074);
			RunTimeStorage.NativeMethodInfoPtr_CountPartner_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677075);
			RunTimeStorage.NativeMethodInfoPtr_HasPartner_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677076);
			RunTimeStorage.NativeMethodInfoPtr_PartnerIn_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677077);
			RunTimeStorage.NativeMethodInfoPtr_GetAllIzakayas_Public_Static_Il2CppReferenceArray_1_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677078);
			RunTimeStorage.NativeMethodInfoPtr_ClearOutdatedFoods_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677079);
			RunTimeStorage.NativeMethodInfoPtr_ClearAndDumpPlayerRuntimeData_Public_Static_Void_byref_RuntimePlayerDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677080);
			RunTimeStorage.NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Public_Static_RuntimePlayerDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677081);
			RunTimeStorage.NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimePlayerDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, 100677082);
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x0018E9BC File Offset: 0x0018CBBC
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x0018E9F0 File Offset: 0x0018CBF0
		public unsafe static Action OnAnyObjectInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181202, XrefRangeEnd = 181204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_OnAnyObjectInCallback_Public_Static_get_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181204, XrefRangeEnd = 181208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_OnAnyObjectInCallback_Public_Static_set_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x0018EA28 File Offset: 0x0018CC28
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x0018EA5C File Offset: 0x0018CC5C
		public unsafe static Action OnAnyObjectOutCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181208, XrefRangeEnd = 181210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_OnAnyObjectOutCallback_Public_Static_get_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181210, XrefRangeEnd = 181214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_OnAnyObjectOutCallback_Public_Static_set_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x0018EA94 File Offset: 0x0018CC94
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x0018EAC8 File Offset: 0x0018CCC8
		public unsafe static Action<ObjectLanguageBase, int> ObjectLangageBaseInCounted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181214, XrefRangeEnd = 181216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_ObjectLangageBaseInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181216, XrefRangeEnd = 181220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_ObjectLangageBaseInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x0018EB00 File Offset: 0x0018CD00
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x0018EB34 File Offset: 0x0018CD34
		public unsafe static Action<ObjectLanguageBase, int> BadgeInCounted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181220, XrefRangeEnd = 181222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_BadgeInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181222, XrefRangeEnd = 181226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_BadgeInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x0018EB6C File Offset: 0x0018CD6C
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x0018EBA0 File Offset: 0x0018CDA0
		public unsafe static Action<int> RecipeInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181226, XrefRangeEnd = 181228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_RecipeInCallback_Public_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181228, XrefRangeEnd = 181232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_RecipeInCallback_Public_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x0018EBD8 File Offset: 0x0018CDD8
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x0018EC0C File Offset: 0x0018CE0C
		public unsafe static Action<int> IzakayaInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181232, XrefRangeEnd = 181234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_IzakayaInCallback_Public_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181234, XrefRangeEnd = 181238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_IzakayaInCallback_Public_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x0018EC44 File Offset: 0x0018CE44
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x0018EC78 File Offset: 0x0018CE78
		public unsafe static Action<int> DecorationInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181238, XrefRangeEnd = 181240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_DecorationInCallback_Public_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181240, XrefRangeEnd = 181244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_DecorationInCallback_Public_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x0018ECB0 File Offset: 0x0018CEB0
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x0018ECE4 File Offset: 0x0018CEE4
		public unsafe static Action<int> PartnerInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181244, XrefRangeEnd = 181246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_PartnerInCallback_Public_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181246, XrefRangeEnd = 181250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_PartnerInCallback_Public_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x0018ED1C File Offset: 0x0018CF1C
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x0018ED50 File Offset: 0x0018CF50
		public unsafe static Action<ObjectLanguageBase> TrophyInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181250, XrefRangeEnd = 181252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_TrophyInCallback_Public_Static_get_Action_1_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181252, XrefRangeEnd = 181256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_TrophyInCallback_Public_Static_set_Void_Action_1_ObjectLanguageBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x0018ED88 File Offset: 0x0018CF88
		// (set) Token: 0x06004583 RID: 17795 RVA: 0x0018EDBC File Offset: 0x0018CFBC
		public unsafe static Action<ValueTuple<ObjectLanguageBase, Sprite>, int> CookerInCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181256, XrefRangeEnd = 181258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_CookerInCallback_Public_Static_get_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<ObjectLanguageBase, Sprite>, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181258, XrefRangeEnd = 181262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_CookerInCallback_Public_Static_set_Void_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x0018EDF4 File Offset: 0x0018CFF4
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x0018EE28 File Offset: 0x0018D028
		public unsafe static Dictionary<int, int> Foods
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181262, XrefRangeEnd = 181264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181264, XrefRangeEnd = 181268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x0018EE60 File Offset: 0x0018D060
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x0018EE94 File Offset: 0x0018D094
		public unsafe static Dictionary<int, int> Beverages
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181268, XrefRangeEnd = 181270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181270, XrefRangeEnd = 181274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x0018EECC File Offset: 0x0018D0CC
		// (set) Token: 0x06004589 RID: 17801 RVA: 0x0018EF00 File Offset: 0x0018D100
		public unsafe static Dictionary<int, int> Ingredients
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181274, XrefRangeEnd = 181276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181276, XrefRangeEnd = 181280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x0018EF38 File Offset: 0x0018D138
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x0018EF6C File Offset: 0x0018D16C
		public unsafe static Dictionary<int, int> Cookers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181280, XrefRangeEnd = 181282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181282, XrefRangeEnd = 181286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x0018EFA4 File Offset: 0x0018D1A4
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x0018EFD8 File Offset: 0x0018D1D8
		public unsafe static Dictionary<int, int> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181286, XrefRangeEnd = 181288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181288, XrefRangeEnd = 181292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x0018F010 File Offset: 0x0018D210
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x0018F044 File Offset: 0x0018D244
		public unsafe static Dictionary<int, int> Badges
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181292, XrefRangeEnd = 181294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181294, XrefRangeEnd = 181298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x0018F07C File Offset: 0x0018D27C
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x0018F0B0 File Offset: 0x0018D2B0
		public unsafe static List<int> Trophies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181298, XrefRangeEnd = 181300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Trophies_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181300, XrefRangeEnd = 181304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x0018F0E8 File Offset: 0x0018D2E8
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x0018F11C File Offset: 0x0018D31C
		public unsafe static List<int> ItemsDeleteEnterWork
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181304, XrefRangeEnd = 181306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_ItemsDeleteEnterWork_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181306, XrefRangeEnd = 181310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_ItemsDeleteEnterWork_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x0018F154 File Offset: 0x0018D354
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x0018F188 File Offset: 0x0018D388
		public unsafe static List<int> Recipes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181310, XrefRangeEnd = 181312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Recipes_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181312, XrefRangeEnd = 181316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x0018F1C0 File Offset: 0x0018D3C0
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x0018F1F4 File Offset: 0x0018D3F4
		public unsafe static List<int> Izakayas
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181316, XrefRangeEnd = 181318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_Izakayas_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181318, XrefRangeEnd = 181322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x0018F22C File Offset: 0x0018D42C
		// (set) Token: 0x06004599 RID: 17817 RVA: 0x0018F260 File Offset: 0x0018D460
		public unsafe static List<int> UnlockedPartner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181322, XrefRangeEnd = 181324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_get_UnlockedPartner_Private_Static_get_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181324, XrefRangeEnd = 181328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_set_UnlockedPartner_Private_Static_set_Void_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x0018F298 File Offset: 0x0018D498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181692, RefRangeEnd = 181693, XrefRangeStart = 181328, XrefRangeEnd = 181692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(PlayerSaveFile.RunTimeStorageSaveDataPartial saveDataPartial, Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> saveDataDLCPartial)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(saveDataPartial));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(saveDataDLCPartial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeStorageSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x0018F2E8 File Offset: 0x0018D4E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 181717, RefRangeEnd = 181722, XrefRangeStart = 181693, XrefRangeEnd = 181717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceObjectsNum(Dictionary<int, int> targetDictionary, [Optional] Il2CppStructArray<int> ignoreId)
		{
			if (ignoreId == null)
			{
				ignoreId = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetDictionary);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ForceObjectsNum_Private_Static_Void_Dictionary_2_Int32_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x0018F340 File Offset: 0x0018D540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181722, XrefRangeEnd = 181725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetElementCount(this Dictionary<int, int> collection, Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetElementCount_Private_Static_Int32_Dictionary_2_Int32_Int32_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x0018F398 File Offset: 0x0018D598
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 181763, RefRangeEnd = 181771, XrefRangeStart = 181725, XrefRangeEnd = 181763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetAmountInStorage(this Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAmountInStorage_Public_Static_Int64_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x0018F3E0 File Offset: 0x0018D5E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 181910, RefRangeEnd = 181920, XrefRangeStart = 181771, XrefRangeEnd = 181910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendToStorage(this Product product, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_SendToStorage_Public_Static_Void_Product_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0018F42C File Offset: 0x0018D62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181926, RefRangeEnd = 181927, XrefRangeStart = 181920, XrefRangeEnd = 181926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromStorage(this Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_RemoveFromStorage_Public_Static_Void_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0018F468 File Offset: 0x0018D668
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 181946, RefRangeEnd = 181958, XrefRangeStart = 181927, XrefRangeEnd = 181946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearForChallenge()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearForChallenge_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x0018F490 File Offset: 0x0018D690
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 181974, RefRangeEnd = 181983, XrefRangeStart = 181958, XrefRangeEnd = 181974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DumpForChallenge(out IEnumerable<KeyValuePair<int, int>> foods, out IEnumerable<KeyValuePair<int, int>> bevs, out IEnumerable<KeyValuePair<int, int>> ings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_DumpForChallenge_Public_Static_Void_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			foods = ((intPtr6 == 0) ? null : new IEnumerable<KeyValuePair<int, int>>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			bevs = ((intPtr7 == 0) ? null : new IEnumerable<KeyValuePair<int, int>>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			ings = ((intPtr8 == 0) ? null : new IEnumerable<KeyValuePair<int, int>>(intPtr8));
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x0018F51C File Offset: 0x0018D71C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 182002, RefRangeEnd = 182011, XrefRangeStart = 181983, XrefRangeEnd = 182002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeForChallenge(IEnumerable<KeyValuePair<int, int>> foods, IEnumerable<KeyValuePair<int, int>> beverages, IEnumerable<KeyValuePair<int, int>> ingredients)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(foods);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_InitializeForChallenge_Public_Static_Void_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x0018F578 File Offset: 0x0018D778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182034, RefRangeEnd = 182035, XrefRangeStart = 182011, XrefRangeEnd = 182034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerSaveFile.RunTimeStorageSaveDataPartial GenerateSaveData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeStorageSaveDataPartial_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerSaveFile.RunTimeStorageSaveDataPartial(pointer);
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x0018F5A4 File Offset: 0x0018D7A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182093, RefRangeEnd = 182095, XrefRangeStart = 182035, XrefRangeEnd = 182093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectInRange<T>(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, Func<int, T> objectToLanguageHandler, Action<int> tryRecordHandler, bool suppressCallbacks, Action<T, int> altObjectLanguageBaseInCountedCallback, Predicate<int> infiniteResolver = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectToLanguageHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tryRecordHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(altObjectLanguageBaseInCountedCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.MethodInfoStoreGeneric_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_T_Action_1_Int32_Boolean_Action_2_T_Int32_Predicate_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0018F644 File Offset: 0x0018D844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182095, XrefRangeEnd = 182102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectInRange(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, Func<int, ObjectLanguageBase> objectToLanguageHandler, Action<int> tryRecordHandler, bool suppressCallbacks = false, Action<ObjectLanguageBase, int> altObjectLanguageBaseInCountedCallback = null, Predicate<int> infiniteResolver = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectToLanguageHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tryRecordHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(altObjectLanguageBaseInCountedCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_ObjectLanguageBase_Action_1_Int32_Boolean_Action_2_ObjectLanguageBase_Int32_Predicate_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x0018F6E4 File Offset: 0x0018D8E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 182119, RefRangeEnd = 182126, XrefRangeStart = 182102, XrefRangeEnd = 182119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectOut(this Dictionary<int, int> objectPool, int objectId, bool suppressCallbacks = false, Predicate<int> infiniteResolver = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ObjectOut_Private_Static_Void_Dictionary_2_Int32_Int32_Int32_Boolean_Predicate_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x0018F748 File Offset: 0x0018D948
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 182144, RefRangeEnd = 182151, XrefRangeStart = 182126, XrefRangeEnd = 182144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectOutRange(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, bool suppressCallbacks = false, Predicate<int> infiniteResolver = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectIds);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ObjectOutRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Boolean_Predicate_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x0018F7B0 File Offset: 0x0018D9B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182255, RefRangeEnd = 182258, XrefRangeStart = 182151, XrefRangeEnd = 182255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<T, int>> GetObject<T>(this Dictionary<int, int> objectPool, Func<int, T> objectReferenceMethod, Predicate<int> infiniteResolver = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReferenceMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.MethodInfoStoreGeneric_GetObject_Private_Static_Il2CppReferenceArray_1_KeyValuePair_2_T_Int32_Dictionary_2_Int32_Int32_Func_2_Int32_T_Predicate_1_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<T, int>>>(intPtr3) : null;
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x0018F818 File Offset: 0x0018DA18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182307, RefRangeEnd = 182310, XrefRangeStart = 182258, XrefRangeEnd = 182307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetObjectByTag(this Dictionary<int, int> objectPool, Func<int, Il2CppStructArray<int>> objectTagAccessMethod, out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectTagAccessMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetObjectByTag_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Il2CppStructArray_1_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x0018F8AC File Offset: 0x0018DAAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182359, RefRangeEnd = 182362, XrefRangeStart = 182310, XrefRangeEnd = 182359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetObjectByLevel(this Dictionary<int, int> objectPool, Func<int, int> objectTagAccessMethod, out int amount, out IEnumerable<int> ids, int level = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectTagAccessMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetObjectByLevel_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x0018F940 File Offset: 0x0018DB40
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182376, RefRangeEnd = 182381, XrefRangeStart = 182362, XrefRangeEnd = 182376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectInDistinct(this List<int> collection, int item, Action<int> onObjectInNotify, Action<int> onObjectIn = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref item;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onObjectInNotify);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onObjectIn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ObjectInDistinct_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x0018F9A8 File Offset: 0x0018DBA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182399, RefRangeEnd = 182401, XrefRangeStart = 182381, XrefRangeEnd = 182399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ObjectInRangeDistinct(this List<int> collection, IEnumerable<int> items, Action<int> onObjectInNotify, Action<int> onObjectIn = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onObjectInNotify);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onObjectIn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ObjectInRangeDistinct_Private_Static_Void_List_1_Int32_IEnumerable_1_Int32_Action_1_Int32_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x0018FA14 File Offset: 0x0018DC14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182406, RefRangeEnd = 182408, XrefRangeStart = 182401, XrefRangeEnd = 182406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountFood()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountFood_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x0018FA44 File Offset: 0x0018DC44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182413, RefRangeEnd = 182416, XrefRangeStart = 182408, XrefRangeEnd = 182413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFoodCountById(int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetFoodCountById_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x0018FA84 File Offset: 0x0018DC84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182456, RefRangeEnd = 182457, XrefRangeStart = 182416, XrefRangeEnd = 182456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountFoodLong()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountFoodLong_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x0018FAB4 File Offset: 0x0018DCB4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 182476, RefRangeEnd = 182486, XrefRangeStart = 182457, XrefRangeEnd = 182476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FoodInRange(IEnumerable<int> foodIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(foodIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_FoodInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x0018FAF8 File Offset: 0x0018DCF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182489, RefRangeEnd = 182493, XrefRangeStart = 182486, XrefRangeEnd = 182489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FoodOut(int foodId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_FoodOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x0018FB38 File Offset: 0x0018DD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182496, RefRangeEnd = 182497, XrefRangeStart = 182493, XrefRangeEnd = 182496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FoodOutRange(IEnumerable<int> foodIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(foodIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_FoodOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x0018FB7C File Offset: 0x0018DD7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182503, RefRangeEnd = 182505, XrefRangeStart = 182497, XrefRangeEnd = 182503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFoodById(int id, out int amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetFoodById_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x0018FBC8 File Offset: 0x0018DDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182523, RefRangeEnd = 182524, XrefRangeStart = 182505, XrefRangeEnd = 182523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFoodByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetFoodByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x0018FC38 File Offset: 0x0018DE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182542, RefRangeEnd = 182543, XrefRangeStart = 182524, XrefRangeEnd = 182542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetFoodByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetFoodByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x0018FCA8 File Offset: 0x0018DEA8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 182564, RefRangeEnd = 182577, XrefRangeStart = 182543, XrefRangeEnd = 182564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Sellable, int>> GetAllFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllFoods_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Sellable, int>>>(intPtr3) : null;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x0018FCDC File Offset: 0x0018DEDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182598, RefRangeEnd = 182601, XrefRangeStart = 182577, XrefRangeEnd = 182598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<int, int>> GetAllFoodsId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllFoodsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr3) : null;
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x0018FD10 File Offset: 0x0018DF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182607, RefRangeEnd = 182608, XrefRangeStart = 182601, XrefRangeEnd = 182607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvalifyAllFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_InvalifyAllFoods_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x0018FD38 File Offset: 0x0018DF38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182613, RefRangeEnd = 182614, XrefRangeStart = 182608, XrefRangeEnd = 182613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountBeverage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0018FD68 File Offset: 0x0018DF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182614, XrefRangeEnd = 182619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountBeverage(int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0018FDA8 File Offset: 0x0018DFA8
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 182656, RefRangeEnd = 182691, XrefRangeStart = 182619, XrefRangeEnd = 182656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeverageInRange(IEnumerable<int> beverageIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverageIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BeverageInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x0018FDEC File Offset: 0x0018DFEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182694, RefRangeEnd = 182696, XrefRangeStart = 182691, XrefRangeEnd = 182694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeverageOut(int beverageId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref beverageId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BeverageOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x0018FE2C File Offset: 0x0018E02C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182717, RefRangeEnd = 182721, XrefRangeStart = 182696, XrefRangeEnd = 182717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeverageOutRange(IEnumerable<int> beverageIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverageIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BeverageOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x0018FE70 File Offset: 0x0018E070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182727, RefRangeEnd = 182728, XrefRangeStart = 182721, XrefRangeEnd = 182727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllBeverage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearAllBeverage_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x0018FE98 File Offset: 0x0018E098
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 182733, RefRangeEnd = 182741, XrefRangeStart = 182728, XrefRangeEnd = 182733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetBeverageCountById(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetBeverageCountById_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x0018FED8 File Offset: 0x0018E0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182747, RefRangeEnd = 182748, XrefRangeStart = 182741, XrefRangeEnd = 182747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetBeverageById(int id, out int amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageById_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0018FF24 File Offset: 0x0018E124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182748, XrefRangeEnd = 182786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetBeverageByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x0018FF94 File Offset: 0x0018E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182786, XrefRangeEnd = 182824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetBeverageByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetBeverageByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00190004 File Offset: 0x0018E204
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 182845, RefRangeEnd = 182854, XrefRangeStart = 182824, XrefRangeEnd = 182845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Sellable, int>> GetAllBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllBeverages_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Sellable, int>>>(intPtr3) : null;
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00190038 File Offset: 0x0018E238
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182875, RefRangeEnd = 182878, XrefRangeStart = 182854, XrefRangeEnd = 182875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<int, int>> GetAllBeveragesId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllBeveragesId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr3) : null;
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x0019006C File Offset: 0x0018E26C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 182895, RefRangeEnd = 182901, XrefRangeStart = 182878, XrefRangeEnd = 182895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Predicate<int> TryGetInfiniteIngredientResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetInfiniteIngredientResolver_Private_Static_Predicate_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr3) : null;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x001900A0 File Offset: 0x0018E2A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 182907, RefRangeEnd = 182915, XrefRangeStart = 182901, XrefRangeEnd = 182907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIngredientCountById(int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetIngredientCountById_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x001900E0 File Offset: 0x0018E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182915, XrefRangeEnd = 182920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountIngredient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountIngredient_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00190110 File Offset: 0x0018E310
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 182940, RefRangeEnd = 182973, XrefRangeStart = 182920, XrefRangeEnd = 182940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IngredientInRange(IEnumerable<int> ingredientIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredientIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_IngredientInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00190154 File Offset: 0x0018E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182973, XrefRangeEnd = 182977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IngredientOut(int ingredientId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ingredientId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_IngredientOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00190194 File Offset: 0x0018E394
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 182981, RefRangeEnd = 182991, XrefRangeStart = 182977, XrefRangeEnd = 182981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IngredientOutRange(IEnumerable<int> ingredientIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredientIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_IngredientOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x001901D8 File Offset: 0x0018E3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182997, RefRangeEnd = 182998, XrefRangeStart = 182991, XrefRangeEnd = 182997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00190200 File Offset: 0x0018E400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183003, RefRangeEnd = 183004, XrefRangeStart = 182998, XrefRangeEnd = 183003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetIngredientById(int id, out int amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientById_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x0019024C File Offset: 0x0018E44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183004, XrefRangeEnd = 183022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetIngredientByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x001902BC File Offset: 0x0018E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183022, XrefRangeEnd = 183040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetIngredientByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &amount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TryGetIngredientByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ids = ((intPtr4 == 0) ? null : new IEnumerable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x0019032C File Offset: 0x0018E52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183074, RefRangeEnd = 183075, XrefRangeStart = 183040, XrefRangeEnd = 183074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsAllFollowingIngredients(IEnumerable<int> ingredients)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ContainsAllFollowingIngredients_Public_Static_Boolean_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00190370 File Offset: 0x0018E570
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 183097, RefRangeEnd = 183106, XrefRangeStart = 183075, XrefRangeEnd = 183097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Ingredient, int>> GetAllIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllIngredients_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Ingredient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x001903A4 File Offset: 0x0018E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183106, XrefRangeEnd = 183111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountCooker()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountCooker_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x001903D4 File Offset: 0x0018E5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183111, XrefRangeEnd = 183117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasCooker(this int cookerId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HasCooker_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00190414 File Offset: 0x0018E614
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 183123, RefRangeEnd = 183131, XrefRangeStart = 183117, XrefRangeEnd = 183123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCookerCountById(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetCookerCountById_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00190454 File Offset: 0x0018E654
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 183159, RefRangeEnd = 183167, XrefRangeStart = 183131, XrefRangeEnd = 183159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CookerInRange(IEnumerable<int> cookerIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CookerInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00190498 File Offset: 0x0018E698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183170, RefRangeEnd = 183171, XrefRangeStart = 183167, XrefRangeEnd = 183170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CookerOut(int cookerId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CookerOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x001904D8 File Offset: 0x0018E6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183171, XrefRangeEnd = 183174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CookerOutRange(Il2CppStructArray<int> cookerIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CookerOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x0019051C File Offset: 0x0018E71C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 183241, RefRangeEnd = 183253, XrefRangeStart = 183174, XrefRangeEnd = 183241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Cooker, int>> GetAllCookers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllCookers_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Cooker_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Cooker, int>>>(intPtr3) : null;
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00190550 File Offset: 0x0018E750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183263, RefRangeEnd = 183266, XrefRangeStart = 183253, XrefRangeEnd = 183263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SolveGlobalCookCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_SolveGlobalCookCount_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00190578 File Offset: 0x0018E778
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 183355, RefRangeEnd = 183365, XrefRangeStart = 183266, XrefRangeEnd = 183355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SolveCookCount(IEnumerable<Recipe> value, Il2CppStructArray<int> selected)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_SolveCookCount_Public_Static_Void_IEnumerable_1_Recipe_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x001905C0 File Offset: 0x0018E7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183386, RefRangeEnd = 183387, XrefRangeStart = 183365, XrefRangeEnd = 183386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountItem()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountItem_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x001905F0 File Offset: 0x0018E7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183387, XrefRangeEnd = 183420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountItem(int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountItem_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00190630 File Offset: 0x0018E830
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 183426, RefRangeEnd = 183440, XrefRangeStart = 183420, XrefRangeEnd = 183426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetItemCountById(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetItemCountById_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00190670 File Offset: 0x0018E870
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 183512, RefRangeEnd = 183548, XrefRangeStart = 183440, XrefRangeEnd = 183512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ItemInRange(IEnumerable<int> itemIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ItemInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001906B4 File Offset: 0x0018E8B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183596, RefRangeEnd = 183598, XrefRangeStart = 183548, XrefRangeEnd = 183596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ItemInRangeWithoutDecorationNotice(IEnumerable<int> itemIds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ItemInRangeWithoutDecorationNotice_Public_Static_Void_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x001906EC File Offset: 0x0018E8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183601, RefRangeEnd = 183602, XrefRangeStart = 183598, XrefRangeEnd = 183601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ItemOut(int itemId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ItemOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x0019072C File Offset: 0x0018E92C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 183646, RefRangeEnd = 183655, XrefRangeStart = 183602, XrefRangeEnd = 183646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Item, int>> GetAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllItems_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Item_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Item, int>>>(intPtr3) : null;
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00190760 File Offset: 0x0018E960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183696, RefRangeEnd = 183697, XrefRangeStart = 183655, XrefRangeEnd = 183696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<int, int>> GetAllItemsId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllItemsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr3) : null;
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00190794 File Offset: 0x0018E994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183700, RefRangeEnd = 183701, XrefRangeStart = 183697, XrefRangeEnd = 183700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ItemOutRange(IEnumerable<int> itemIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ItemOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x001907D8 File Offset: 0x0018E9D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 183707, RefRangeEnd = 183712, XrefRangeStart = 183701, XrefRangeEnd = 183707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasBadge(this int badgeId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref badgeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HasBadge_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00190818 File Offset: 0x0018EA18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183739, RefRangeEnd = 183741, XrefRangeStart = 183712, XrefRangeEnd = 183739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<Badge, int>> GetAllBadges()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllBadges_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Badge_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Badge, int>>>(intPtr3) : null;
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x0019084C File Offset: 0x0018EA4C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 183782, RefRangeEnd = 183793, XrefRangeStart = 183741, XrefRangeEnd = 183782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BadgeInRange(IEnumerable<int> badgeIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(badgeIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BadgeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00190890 File Offset: 0x0018EA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183793, XrefRangeEnd = 183796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BadgeOut(int badgeId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref badgeId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BadgeOut_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x001908D0 File Offset: 0x0018EAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183796, XrefRangeEnd = 183799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BadgeOutRange(IEnumerable<int> badgeIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(badgeIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_BadgeOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00190914 File Offset: 0x0018EB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183869, RefRangeEnd = 183870, XrefRangeStart = 183799, XrefRangeEnd = 183869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x0019093C File Offset: 0x0018EB3C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 183876, RefRangeEnd = 183911, XrefRangeStart = 183870, XrefRangeEnd = 183876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsItem(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ContainsItem_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0019097C File Offset: 0x0018EB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183947, RefRangeEnd = 183949, XrefRangeStart = 183911, XrefRangeEnd = 183947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ClothesProfile.Clothes> GetAllClothes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllClothes_Public_Static_Il2CppReferenceArray_1_Clothes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothesProfile.Clothes>>(intPtr3) : null;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x001909B0 File Offset: 0x0018EBB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 183985, RefRangeEnd = 183990, XrefRangeStart = 183949, XrefRangeEnd = 183985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Decoration> GetAllDecorations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllDecorations_Public_Static_Il2CppReferenceArray_1_Decoration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Decoration>>(intPtr3) : null;
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x001909E4 File Offset: 0x0018EBE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184028, XrefRangeStart = 183990, XrefRangeEnd = 184026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Record> GetAllRecords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllRecords_Public_Static_Il2CppReferenceArray_1_Record_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Record>>(intPtr3) : null;
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00190A18 File Offset: 0x0018EC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184061, RefRangeEnd = 184063, XrefRangeStart = 184028, XrefRangeEnd = 184061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TrophiesProfile.Trophy> GetAllTrophies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllTrophies_Public_Static_Il2CppReferenceArray_1_Trophy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrophiesProfile.Trophy>>(intPtr3) : null;
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00190A4C File Offset: 0x0018EC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184081, RefRangeEnd = 184082, XrefRangeStart = 184063, XrefRangeEnd = 184081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrophyInRange(int trophy, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trophy;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_TrophyInRange_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00190A8C File Offset: 0x0018EC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184088, RefRangeEnd = 184089, XrefRangeStart = 184082, XrefRangeEnd = 184088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasTrophy(int trophy)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trophy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HasTrophy_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00190ACC File Offset: 0x0018ECCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184152, RefRangeEnd = 184155, XrefRangeStart = 184089, XrefRangeEnd = 184152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteAllItemsBeforeWork()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_DeleteAllItemsBeforeWork_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00190AF4 File Offset: 0x0018ECF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184161, RefRangeEnd = 184163, XrefRangeStart = 184155, XrefRangeEnd = 184161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HaveRecipe(int recipeId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recipeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HaveRecipe_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00190B34 File Offset: 0x0018ED34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184168, RefRangeEnd = 184172, XrefRangeStart = 184163, XrefRangeEnd = 184168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountRecipes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountRecipes_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00190B64 File Offset: 0x0018ED64
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 184204, RefRangeEnd = 184222, XrefRangeStart = 184172, XrefRangeEnd = 184204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecipeInRange(IEnumerable<int> recipeIds, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipeIds);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_RecipeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x00190BA8 File Offset: 0x0018EDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184222, XrefRangeEnd = 184237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecipeOut(int recipeId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recipeId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_RecipeOut_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x00190BDC File Offset: 0x0018EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184237, XrefRangeEnd = 184265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecipeOutRange(Il2CppStructArray<int> recipeIds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipeIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_RecipeOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00190C14 File Offset: 0x0018EE14
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 184289, RefRangeEnd = 184317, XrefRangeStart = 184265, XrefRangeEnd = 184289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Recipe> GetAllRecipes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Recipe>>(intPtr3) : null;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00190C48 File Offset: 0x0018EE48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 184319, RefRangeEnd = 184326, XrefRangeStart = 184317, XrefRangeEnd = 184319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllRecipeIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllRecipeIndex_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00190C7C File Offset: 0x0018EE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184346, RefRangeEnd = 184347, XrefRangeStart = 184326, XrefRangeEnd = 184346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetRecipesByCookerType(IEnumerable<Cooker.CookerType> type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetRecipesByCookerType_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_CookerType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00190CC0 File Offset: 0x0018EEC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 184353, RefRangeEnd = 184358, XrefRangeStart = 184347, XrefRangeEnd = 184353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasIzakaya(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HasIzakaya_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00190D00 File Offset: 0x0018EF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184358, XrefRangeEnd = 184376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IzakayaIn(int izakayaId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_IzakayaIn_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00190D40 File Offset: 0x0018EF40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184394, RefRangeEnd = 184398, XrefRangeStart = 184376, XrefRangeEnd = 184394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IzakayaInRange(IEnumerable<int> izakayaIds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(izakayaIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_IzakayaInRange_Public_Static_Void_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00190D78 File Offset: 0x0018EF78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184414, RefRangeEnd = 184420, XrefRangeStart = 184398, XrefRangeEnd = 184414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllPartners()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllPartners_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00190DAC File Offset: 0x0018EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184420, XrefRangeEnd = 184439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CountPartner()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CountPartner_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00190DDC File Offset: 0x0018EFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184439, XrefRangeEnd = 184445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasPartner(this int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_HasPartner_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00190E1C File Offset: 0x0018F01C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184463, RefRangeEnd = 184466, XrefRangeStart = 184445, XrefRangeEnd = 184463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PartnerIn(int partnerId, bool suppressCallbacks = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_PartnerIn_Public_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00190E5C File Offset: 0x0018F05C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184490, RefRangeEnd = 184494, XrefRangeStart = 184466, XrefRangeEnd = 184490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Izakaya> GetAllIzakayas()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_GetAllIzakayas_Public_Static_Il2CppReferenceArray_1_Izakaya_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya>>(intPtr3) : null;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00190E90 File Offset: 0x0018F090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184546, RefRangeEnd = 184548, XrefRangeStart = 184494, XrefRangeEnd = 184546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearOutdatedFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearOutdatedFoods_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00190EB8 File Offset: 0x0018F0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184605, RefRangeEnd = 184607, XrefRangeStart = 184548, XrefRangeEnd = 184605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAndDumpPlayerRuntimeData(out RunTimeStorage.RuntimePlayerDataCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_ClearAndDumpPlayerRuntimeData_Public_Static_Void_byref_RuntimePlayerDataCache_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new RunTimeStorage.RuntimePlayerDataCache(intPtr4));
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00190F00 File Offset: 0x0018F100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184675, RefRangeEnd = 184677, XrefRangeStart = 184607, XrefRangeEnd = 184675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunTimeStorage.RuntimePlayerDataCache CreatePlayerRuntimeDataCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Public_Static_RuntimePlayerDataCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.RuntimePlayerDataCache>(intPtr3) : null;
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00190F34 File Offset: 0x0018F134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184757, RefRangeEnd = 184759, XrefRangeStart = 184677, XrefRangeEnd = 184757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MountAndOverridePlayerRuntimeData(RunTimeStorage.RuntimePlayerDataCache cache)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimePlayerDataCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0002479D File Offset: 0x0002299D
		public static void ForceObjectsNum(Dictionary<int, int> targetDictionary, params int[] ignoreId)
		{
			RunTimeStorage.ForceObjectsNum(targetDictionary, new Il2CppStructArray<int>(ignoreId));
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x000247AB File Offset: 0x000229AB
		public RunTimeStorage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x00190F6C File Offset: 0x0018F16C
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x000247B4 File Offset: 0x000229B4
		public unsafe static int GREEN_TEA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_GREEN_TEA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_GREEN_TEA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x00190F88 File Offset: 0x0018F188
		// (set) Token: 0x0600460A RID: 17930 RVA: 0x000247C2 File Offset: 0x000229C2
		public unsafe static int DARK_MATTER_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_DARK_MATTER_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_DARK_MATTER_ID, (void*)(&value));
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x0600460B RID: 17931 RVA: 0x00190FA4 File Offset: 0x0018F1A4
		// (set) Token: 0x0600460C RID: 17932 RVA: 0x000247D0 File Offset: 0x000229D0
		public unsafe static int RICE_BALL_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_RICE_BALL_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_RICE_BALL_ID, (void*)(&value));
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x00190FC0 File Offset: 0x0018F1C0
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x000247DE File Offset: 0x000229DE
		public unsafe static int MYSTIA_NORMAL_CLOTHES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_CLOTHES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_CLOTHES, (void*)(&value));
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x00190FDC File Offset: 0x0018F1DC
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x000247EC File Offset: 0x000229EC
		public unsafe static int MYSTIA_NORMAL_WORKING_CLOTHES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_WORKING_CLOTHES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_MYSTIA_NORMAL_WORKING_CLOTHES, (void*)(&value));
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x00190FF8 File Offset: 0x0018F1F8
		// (set) Token: 0x06004612 RID: 17938 RVA: 0x000247FA File Offset: 0x000229FA
		public unsafe static int MAX_OBJECT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_MAX_OBJECT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_MAX_OBJECT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00191014 File Offset: 0x0018F214
		// (set) Token: 0x06004614 RID: 17940 RVA: 0x00024808 File Offset: 0x00022A08
		public unsafe static long MAX_FUND_AMOUNT
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr_MAX_FUND_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr_MAX_FUND_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x00191030 File Offset: 0x0018F230
		// (set) Token: 0x06004616 RID: 17942 RVA: 0x00024816 File Offset: 0x00022A16
		public unsafe static Action _OnAnyObjectInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00191058 File Offset: 0x0018F258
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00024828 File Offset: 0x00022A28
		public unsafe static Action _OnAnyObjectOutCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectOutCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__OnAnyObjectOutCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x00191080 File Offset: 0x0018F280
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x0002483A File Offset: 0x00022A3A
		public unsafe static Action<ObjectLanguageBase, int> _ObjectLangageBaseInCounted_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__ObjectLangageBaseInCounted_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__ObjectLangageBaseInCounted_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x001910A8 File Offset: 0x0018F2A8
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x0002484C File Offset: 0x00022A4C
		public unsafe static Action<ObjectLanguageBase, int> _BadgeInCounted_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__BadgeInCounted_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__BadgeInCounted_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x001910D0 File Offset: 0x0018F2D0
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x0002485E File Offset: 0x00022A5E
		public unsafe static Action<int> _RecipeInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__RecipeInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__RecipeInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x001910F8 File Offset: 0x0018F2F8
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x00024870 File Offset: 0x00022A70
		public unsafe static Action<int> _IzakayaInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__IzakayaInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__IzakayaInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x00191120 File Offset: 0x0018F320
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x00024882 File Offset: 0x00022A82
		public unsafe static Action<int> _DecorationInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__DecorationInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__DecorationInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x00191148 File Offset: 0x0018F348
		// (set) Token: 0x06004624 RID: 17956 RVA: 0x00024894 File Offset: 0x00022A94
		public unsafe static Action<int> _PartnerInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__PartnerInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__PartnerInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x00191170 File Offset: 0x0018F370
		// (set) Token: 0x06004626 RID: 17958 RVA: 0x000248A6 File Offset: 0x00022AA6
		public unsafe static Action<ObjectLanguageBase> _TrophyInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__TrophyInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ObjectLanguageBase>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__TrophyInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x00191198 File Offset: 0x0018F398
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x000248B8 File Offset: 0x00022AB8
		public unsafe static Action<ValueTuple<ObjectLanguageBase, Sprite>, int> _CookerInCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__CookerInCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<ObjectLanguageBase, Sprite>, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__CookerInCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x001911C0 File Offset: 0x0018F3C0
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x000248CA File Offset: 0x00022ACA
		public unsafe static Dictionary<int, int> _Foods_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Foods_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Foods_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x001911E8 File Offset: 0x0018F3E8
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x000248DC File Offset: 0x00022ADC
		public unsafe static Dictionary<int, int> _Beverages_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Beverages_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Beverages_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x00191210 File Offset: 0x0018F410
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x000248EE File Offset: 0x00022AEE
		public unsafe static Dictionary<int, int> _Ingredients_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Ingredients_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Ingredients_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x00191238 File Offset: 0x0018F438
		// (set) Token: 0x06004630 RID: 17968 RVA: 0x00024900 File Offset: 0x00022B00
		public unsafe static Dictionary<int, int> _Cookers_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Cookers_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Cookers_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x00191260 File Offset: 0x0018F460
		// (set) Token: 0x06004632 RID: 17970 RVA: 0x00024912 File Offset: 0x00022B12
		public unsafe static Dictionary<int, int> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Items_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Items_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x00191288 File Offset: 0x0018F488
		// (set) Token: 0x06004634 RID: 17972 RVA: 0x00024924 File Offset: 0x00022B24
		public unsafe static Dictionary<int, int> _Badges_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Badges_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Badges_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x001912B0 File Offset: 0x0018F4B0
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x00024936 File Offset: 0x00022B36
		public unsafe static List<int> _Trophies_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Trophies_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Trophies_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x001912D8 File Offset: 0x0018F4D8
		// (set) Token: 0x06004638 RID: 17976 RVA: 0x00024948 File Offset: 0x00022B48
		public unsafe static List<int> _ItemsDeleteEnterWork_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__ItemsDeleteEnterWork_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__ItemsDeleteEnterWork_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004639 RID: 17977 RVA: 0x00191300 File Offset: 0x0018F500
		// (set) Token: 0x0600463A RID: 17978 RVA: 0x0002495A File Offset: 0x00022B5A
		public unsafe static List<int> _Recipes_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Recipes_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Recipes_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600463B RID: 17979 RVA: 0x00191328 File Offset: 0x0018F528
		// (set) Token: 0x0600463C RID: 17980 RVA: 0x0002496C File Offset: 0x00022B6C
		public unsafe static List<int> _Izakayas_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__Izakayas_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__Izakayas_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x00191350 File Offset: 0x0018F550
		// (set) Token: 0x0600463E RID: 17982 RVA: 0x0002497E File Offset: 0x00022B7E
		public unsafe static List<int> _UnlockedPartner_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.NativeFieldInfoPtr__UnlockedPartner_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.NativeFieldInfoPtr__UnlockedPartner_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeFieldInfoPtr_GREEN_TEA_ID;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeFieldInfoPtr_DARK_MATTER_ID;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeFieldInfoPtr_RICE_BALL_ID;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeFieldInfoPtr_MYSTIA_NORMAL_CLOTHES;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeFieldInfoPtr_MYSTIA_NORMAL_WORKING_CLOTHES;

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeFieldInfoPtr_MAX_OBJECT_COUNT;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeFieldInfoPtr_MAX_FUND_AMOUNT;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeFieldInfoPtr__OnAnyObjectInCallback_k__BackingField;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeFieldInfoPtr__OnAnyObjectOutCallback_k__BackingField;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeFieldInfoPtr__ObjectLangageBaseInCounted_k__BackingField;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeFieldInfoPtr__BadgeInCounted_k__BackingField;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeFieldInfoPtr__RecipeInCallback_k__BackingField;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeFieldInfoPtr__IzakayaInCallback_k__BackingField;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeFieldInfoPtr__DecorationInCallback_k__BackingField;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeFieldInfoPtr__PartnerInCallback_k__BackingField;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeFieldInfoPtr__TrophyInCallback_k__BackingField;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeFieldInfoPtr__CookerInCallback_k__BackingField;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeFieldInfoPtr__Foods_k__BackingField;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr__Beverages_k__BackingField;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeFieldInfoPtr__Ingredients_k__BackingField;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeFieldInfoPtr__Cookers_k__BackingField;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeFieldInfoPtr__Badges_k__BackingField;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeFieldInfoPtr__Trophies_k__BackingField;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeFieldInfoPtr__ItemsDeleteEnterWork_k__BackingField;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeFieldInfoPtr__Izakayas_k__BackingField;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeFieldInfoPtr__UnlockedPartner_k__BackingField;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr_get_OnAnyObjectInCallback_Public_Static_get_Action_0;

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeMethodInfoPtr_set_OnAnyObjectInCallback_Public_Static_set_Void_Action_0;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeMethodInfoPtr_get_OnAnyObjectOutCallback_Public_Static_get_Action_0;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeMethodInfoPtr_set_OnAnyObjectOutCallback_Public_Static_set_Void_Action_0;

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectLangageBaseInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectLangageBaseInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0;

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeMethodInfoPtr_get_BadgeInCounted_Public_Static_get_Action_2_ObjectLanguageBase_Int32_0;

		// Token: 0x04002F66 RID: 12134
		private static readonly IntPtr NativeMethodInfoPtr_set_BadgeInCounted_Public_Static_set_Void_Action_2_ObjectLanguageBase_Int32_0;

		// Token: 0x04002F67 RID: 12135
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeInCallback_Public_Static_get_Action_1_Int32_0;

		// Token: 0x04002F68 RID: 12136
		private static readonly IntPtr NativeMethodInfoPtr_set_RecipeInCallback_Public_Static_set_Void_Action_1_Int32_0;

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaInCallback_Public_Static_get_Action_1_Int32_0;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeMethodInfoPtr_set_IzakayaInCallback_Public_Static_set_Void_Action_1_Int32_0;

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationInCallback_Public_Static_get_Action_1_Int32_0;

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeMethodInfoPtr_set_DecorationInCallback_Public_Static_set_Void_Action_1_Int32_0;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerInCallback_Public_Static_get_Action_1_Int32_0;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeMethodInfoPtr_set_PartnerInCallback_Public_Static_set_Void_Action_1_Int32_0;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeMethodInfoPtr_get_TrophyInCallback_Public_Static_get_Action_1_ObjectLanguageBase_0;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeMethodInfoPtr_set_TrophyInCallback_Public_Static_set_Void_Action_1_ObjectLanguageBase_0;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerInCallback_Public_Static_get_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerInCallback_Public_Static_set_Void_Action_2_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeMethodInfoPtr_get_Foods_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeMethodInfoPtr_set_Foods_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeMethodInfoPtr_get_Beverages_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeMethodInfoPtr_set_Beverages_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeMethodInfoPtr_set_Ingredients_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookers_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeMethodInfoPtr_set_Cookers_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeMethodInfoPtr_get_Badges_Private_Static_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeMethodInfoPtr_set_Badges_Private_Static_set_Void_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeMethodInfoPtr_get_Trophies_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeMethodInfoPtr_set_Trophies_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemsDeleteEnterWork_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemsDeleteEnterWork_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeMethodInfoPtr_get_Izakayas_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeMethodInfoPtr_set_Izakayas_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockedPartner_Private_Static_get_List_1_Int32_0;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeMethodInfoPtr_set_UnlockedPartner_Private_Static_set_Void_List_1_Int32_0;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeStorageSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeMethodInfoPtr_ForceObjectsNum_Private_Static_Void_Dictionary_2_Int32_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeMethodInfoPtr_GetElementCount_Private_Static_Int32_Dictionary_2_Int32_Int32_Product_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountInStorage_Public_Static_Int64_Product_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr_SendToStorage_Public_Static_Void_Product_Boolean_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromStorage_Public_Static_Void_Product_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_ClearForChallenge_Public_Static_Void_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_DumpForChallenge_Public_Static_Void_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_byref_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_InitializeForChallenge_Public_Static_Void_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeStorageSaveDataPartial_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_T_Action_1_Int32_Boolean_Action_2_T_Int32_Predicate_1_Int32_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_ObjectLanguageBase_Action_1_Int32_Boolean_Action_2_ObjectLanguageBase_Int32_Predicate_1_Int32_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_ObjectOut_Private_Static_Void_Dictionary_2_Int32_Int32_Int32_Boolean_Predicate_1_Int32_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_ObjectOutRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Boolean_Predicate_1_Int32_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Private_Static_Il2CppReferenceArray_1_KeyValuePair_2_T_Int32_Dictionary_2_Int32_Int32_Func_2_Int32_T_Predicate_1_Int32_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_TryGetObjectByTag_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Il2CppStructArray_1_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_TryGetObjectByLevel_Private_Static_Boolean_Dictionary_2_Int32_Int32_Func_2_Int32_Int32_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_ObjectInDistinct_Private_Static_Void_List_1_Int32_Int32_Action_1_Int32_Action_1_Int32_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_ObjectInRangeDistinct_Private_Static_Void_List_1_Int32_IEnumerable_1_Int32_Action_1_Int32_Action_1_Int32_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_CountFood_Public_Static_Int32_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodCountById_Public_Static_Int32_Int32_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_CountFoodLong_Public_Static_Int32_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_FoodInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeMethodInfoPtr_FoodOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeMethodInfoPtr_FoodOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFoodById_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFoodByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFoodByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoods_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoodsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeMethodInfoPtr_InvalifyAllFoods_Public_Static_Void_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_0;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeMethodInfoPtr_CountBeverage_Public_Static_Int32_Int32_0;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeMethodInfoPtr_BeverageInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeMethodInfoPtr_BeverageOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeMethodInfoPtr_BeverageOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBeverage_Public_Static_Void_0;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeMethodInfoPtr_GetBeverageCountById_Public_Static_Int32_Int32_0;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBeverageById_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBeverageByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBeverageByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBeverages_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBeveragesId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInfiniteIngredientResolver_Private_Static_Predicate_1_Int32_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientCountById_Public_Static_Int32_Int32_0;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeMethodInfoPtr_CountIngredient_Public_Static_Int32_0;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeMethodInfoPtr_IngredientInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeMethodInfoPtr_IngredientOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_IngredientOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr_TryGetIngredientById_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeMethodInfoPtr_TryGetIngredientByTag_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeMethodInfoPtr_TryGetIngredientByLevel_Public_Static_Boolean_byref_Int32_byref_IEnumerable_1_Int32_Int32_0;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr_ContainsAllFollowingIngredients_Public_Static_Boolean_IEnumerable_1_Int32_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_GetAllIngredients_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_CountCooker_Public_Static_Int32_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_HasCooker_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerCountById_Public_Static_Int32_Int32_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_CookerInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_CookerOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr_CookerOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_Boolean_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCookers_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Cooker_Int32_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_SolveGlobalCookCount_Public_Static_Void_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_SolveCookCount_Public_Static_Void_IEnumerable_1_Recipe_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeMethodInfoPtr_CountItem_Public_Static_Int32_0;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeMethodInfoPtr_CountItem_Public_Static_Int32_Int32_0;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeMethodInfoPtr_GetItemCountById_Public_Static_Int32_Int32_0;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeMethodInfoPtr_ItemInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeMethodInfoPtr_ItemInRangeWithoutDecorationNotice_Public_Static_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeMethodInfoPtr_ItemOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Item_Int32_0;

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItemsId_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeMethodInfoPtr_ItemOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeMethodInfoPtr_HasBadge_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBadges_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_Badge_Int32_0;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeMethodInfoPtr_BadgeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeMethodInfoPtr_BadgeOut_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeMethodInfoPtr_BadgeOutRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeMethodInfoPtr_ContainsItem_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeMethodInfoPtr_GetAllClothes_Public_Static_Il2CppReferenceArray_1_Clothes_0;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDecorations_Public_Static_Il2CppReferenceArray_1_Decoration_0;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecords_Public_Static_Il2CppReferenceArray_1_Record_0;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTrophies_Public_Static_Il2CppReferenceArray_1_Trophy_0;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeMethodInfoPtr_TrophyInRange_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeMethodInfoPtr_HasTrophy_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAllItemsBeforeWork_Public_Static_Void_0;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeMethodInfoPtr_HaveRecipe_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeMethodInfoPtr_CountRecipes_Public_Static_Int32_0;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeMethodInfoPtr_RecipeInRange_Public_Static_Void_IEnumerable_1_Int32_Boolean_0;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeMethodInfoPtr_RecipeOut_Public_Static_Void_Int32_0;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeMethodInfoPtr_RecipeOutRange_Public_Static_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipes_Public_Static_Il2CppReferenceArray_1_Recipe_0;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipeIndex_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr_GetRecipesByCookerType_Public_Static_Il2CppStructArray_1_Int32_IEnumerable_1_CookerType_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_HasIzakaya_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_IzakayaIn_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeMethodInfoPtr_IzakayaInRange_Public_Static_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPartners_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_CountPartner_Public_Static_Int32_0;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeMethodInfoPtr_HasPartner_Public_Static_Boolean_Int32_0;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr_PartnerIn_Public_Static_Void_Int32_Boolean_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_GetAllIzakayas_Public_Static_Il2CppReferenceArray_1_Izakaya_0;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_ClearOutdatedFoods_Public_Static_Void_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_ClearAndDumpPlayerRuntimeData_Public_Static_Void_byref_RuntimePlayerDataCache_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerRuntimeDataCache_Public_Static_RuntimePlayerDataCache_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr_MountAndOverridePlayerRuntimeData_Public_Static_Void_RuntimePlayerDataCache_0;

		// Token: 0x02000A90 RID: 2704
		public class RuntimePlayerDataCache : Il2CppSystem.Object
		{
			// Token: 0x0600CA8F RID: 51855 RVA: 0x00320CCC File Offset: 0x0031EECC
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimePlayerDataCache()
			{
				Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "RuntimePlayerDataCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr);
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Foods");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Beverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Beverages");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Ingredients");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Cookers");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Items");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Badges");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Trophies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Trophies");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_ItemsDeleteEnterWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_ItemsDeleteEnterWork");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Recipes");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Izakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Izakayas");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopLikeFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_PopLikeFoodTags");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopHateFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_PopHateFoodTags");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Level");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Partners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_Partners");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PinnedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_PinnedObjects");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_UserIzakayaPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_UserIzakayaPresets");
				RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_HistoryPartnerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, "m_HistoryPartnerSelection");
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677083);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677084);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677085);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677086);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677087);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedBadges_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677088);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedTrophies_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677089);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedItemsDeleteEnterWork_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677090);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedRecipes_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677091);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedIzakayas_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677092);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPopLikeFoodTags_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677093);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPopHateFoodTags_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677094);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPartners_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677095);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677096);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_PinnedObjects_Public_get_IEnumerable_1_KeyValuePair_2_DefaultProp_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677097);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_UserIzakayaPresets_Public_get_IEnumerable_1_KeyValuePair_2_Int32_List_1_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677098);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_HistoryPartnerSelection_Public_get_IEnumerable_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677099);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677100);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_ = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677101);
				RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimePlayerDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr, 100677102);
			}

			// Token: 0x170041C5 RID: 16837
			// (get) Token: 0x0600CA90 RID: 51856 RVA: 0x00320FDC File Offset: 0x0031F1DC
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedFoods
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041C6 RID: 16838
			// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x0032101C File Offset: 0x0031F21C
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedBeverages
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041C7 RID: 16839
			// (get) Token: 0x0600CA92 RID: 51858 RVA: 0x0032105C File Offset: 0x0031F25C
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedIngredients
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041C8 RID: 16840
			// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x0032109C File Offset: 0x0031F29C
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedCookers
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041C9 RID: 16841
			// (get) Token: 0x0600CA94 RID: 51860 RVA: 0x003210DC File Offset: 0x0031F2DC
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedItems
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CA RID: 16842
			// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x0032111C File Offset: 0x0031F31C
			public unsafe IEnumerable<KeyValuePair<int, int>> CachedBadges
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedBadges_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CB RID: 16843
			// (get) Token: 0x0600CA96 RID: 51862 RVA: 0x0032115C File Offset: 0x0031F35C
			public unsafe IEnumerable<int> CachedTrophies
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedTrophies_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CC RID: 16844
			// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x0032119C File Offset: 0x0031F39C
			public unsafe IEnumerable<int> CachedItemsDeleteEnterWork
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedItemsDeleteEnterWork_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CD RID: 16845
			// (get) Token: 0x0600CA98 RID: 51864 RVA: 0x003211DC File Offset: 0x0031F3DC
			public unsafe IEnumerable<int> CachedRecipes
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedRecipes_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CE RID: 16846
			// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x0032121C File Offset: 0x0031F41C
			public unsafe IEnumerable<int> CachedIzakayas
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedIzakayas_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041CF RID: 16847
			// (get) Token: 0x0600CA9A RID: 51866 RVA: 0x0032125C File Offset: 0x0031F45C
			public unsafe IEnumerable<int> CachedPopLikeFoodTags
			{
				[CallerCount(40)]
				[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPopLikeFoodTags_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041D0 RID: 16848
			// (get) Token: 0x0600CA9B RID: 51867 RVA: 0x0032129C File Offset: 0x0031F49C
			public unsafe IEnumerable<int> CachedPopHateFoodTags
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPopHateFoodTags_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041D1 RID: 16849
			// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x003212DC File Offset: 0x0031F4DC
			public unsafe IEnumerable<int> CachedPartners
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedPartners_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170041D2 RID: 16850
			// (get) Token: 0x0600CA9D RID: 51869 RVA: 0x0032131C File Offset: 0x0031F51C
			public unsafe int CachedLevel
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 20042, RefRangeEnd = 20043, XrefRangeStart = 20042, XrefRangeEnd = 20043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_CachedLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170041D3 RID: 16851
			// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x00321358 File Offset: 0x0031F558
			public unsafe IEnumerable<KeyValuePair<PlayerSaveFile.DefaultProp, List<int>>> PinnedObjects
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_PinnedObjects_Public_get_IEnumerable_1_KeyValuePair_2_DefaultProp_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<PlayerSaveFile.DefaultProp, List<int>>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041D4 RID: 16852
			// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x00321398 File Offset: 0x0031F598
			public unsafe IEnumerable<KeyValuePair<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>>> UserIzakayaPresets
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_UserIzakayaPresets_Public_get_IEnumerable_1_KeyValuePair_2_Int32_List_1_HistoryIzakayaMenuSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>>>>(intPtr3) : null;
				}
			}

			// Token: 0x170041D5 RID: 16853
			// (get) Token: 0x0600CAA0 RID: 51872 RVA: 0x003213D8 File Offset: 0x0031F5D8
			public unsafe IEnumerable<ValueTuple<int, PartnerBase.PartnerType>> HistoryPartnerSelection
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_get_HistoryPartnerSelection_Public_get_IEnumerable_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr3) : null;
				}
			}

			// Token: 0x0600CAA1 RID: 51873 RVA: 0x00321418 File Offset: 0x0031F618
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimePlayerDataCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAA2 RID: 51874 RVA: 0x00321454 File Offset: 0x0031F654
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 180939, RefRangeEnd = 180941, XrefRangeStart = 180913, XrefRangeEnd = 180939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimePlayerDataCache(Il2CppReferenceArray<KeyValuePair<int, int>> foods, Il2CppReferenceArray<KeyValuePair<int, int>> beverages, Il2CppReferenceArray<KeyValuePair<int, int>> ingredients, Il2CppReferenceArray<KeyValuePair<int, int>> cookers, Il2CppReferenceArray<KeyValuePair<int, int>> items, Il2CppReferenceArray<KeyValuePair<int, int>> badges, Il2CppStructArray<int> trophies, Il2CppStructArray<int> itemsDeleteEnterWork, Il2CppStructArray<int> recipes, Il2CppStructArray<int> izakayas, Il2CppStructArray<int> popLikeFoodTags, Il2CppStructArray<int> popHateFoodTags, Il2CppStructArray<int> partners, int level, Dictionary<PlayerSaveFile.DefaultProp, List<int>> pinnedObjects, Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets, Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> historyPartnerSelection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.RuntimePlayerDataCache>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trophies);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemsDeleteEnterWork);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipes);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayas);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popLikeFoodTags);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popHateFoodTags);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partners);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pinnedObjects);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userIzakayaPresets);
				ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(historyPartnerSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAA3 RID: 51875 RVA: 0x003215D4 File Offset: 0x0031F7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180941, XrefRangeEnd = 180985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual RunTimeStorage.RuntimePlayerDataCache Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.RuntimePlayerDataCache.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimePlayerDataCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.RuntimePlayerDataCache>(intPtr3) : null;
			}

			// Token: 0x0600CAA4 RID: 51876 RVA: 0x0006CE70 File Offset: 0x0006B070
			public RuntimePlayerDataCache(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B4 RID: 16820
			// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x00321614 File Offset: 0x0031F814
			// (set) Token: 0x0600CAA6 RID: 51878 RVA: 0x0006CE79 File Offset: 0x0006B079
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B5 RID: 16821
			// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x00321644 File Offset: 0x0031F844
			// (set) Token: 0x0600CAA8 RID: 51880 RVA: 0x0006CE98 File Offset: 0x0006B098
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Beverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Beverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Beverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x00321674 File Offset: 0x0031F874
			// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x0006CEB7 File Offset: 0x0006B0B7
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Ingredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Ingredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B7 RID: 16823
			// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x003216A4 File Offset: 0x0031F8A4
			// (set) Token: 0x0600CAAC RID: 51884 RVA: 0x0006CED6 File Offset: 0x0006B0D6
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Cookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Cookers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B8 RID: 16824
			// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x003216D4 File Offset: 0x0031F8D4
			// (set) Token: 0x0600CAAE RID: 51886 RVA: 0x0006CEF5 File Offset: 0x0006B0F5
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x00321704 File Offset: 0x0031F904
			// (set) Token: 0x0600CAB0 RID: 51888 RVA: 0x0006CF14 File Offset: 0x0006B114
			public unsafe Il2CppReferenceArray<KeyValuePair<int, int>> m_Badges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Badges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Badges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BA RID: 16826
			// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x00321734 File Offset: 0x0031F934
			// (set) Token: 0x0600CAB2 RID: 51890 RVA: 0x0006CF33 File Offset: 0x0006B133
			public unsafe Il2CppStructArray<int> m_Trophies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Trophies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Trophies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BB RID: 16827
			// (get) Token: 0x0600CAB3 RID: 51891 RVA: 0x00321764 File Offset: 0x0031F964
			// (set) Token: 0x0600CAB4 RID: 51892 RVA: 0x0006CF52 File Offset: 0x0006B152
			public unsafe Il2CppStructArray<int> m_ItemsDeleteEnterWork
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_ItemsDeleteEnterWork);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_ItemsDeleteEnterWork), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BC RID: 16828
			// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x00321794 File Offset: 0x0031F994
			// (set) Token: 0x0600CAB6 RID: 51894 RVA: 0x0006CF71 File Offset: 0x0006B171
			public unsafe Il2CppStructArray<int> m_Recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BD RID: 16829
			// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x003217C4 File Offset: 0x0031F9C4
			// (set) Token: 0x0600CAB8 RID: 51896 RVA: 0x0006CF90 File Offset: 0x0006B190
			public unsafe Il2CppStructArray<int> m_Izakayas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Izakayas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Izakayas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BE RID: 16830
			// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x003217F4 File Offset: 0x0031F9F4
			// (set) Token: 0x0600CABA RID: 51898 RVA: 0x0006CFAF File Offset: 0x0006B1AF
			public unsafe Il2CppStructArray<int> m_PopLikeFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopLikeFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopLikeFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BF RID: 16831
			// (get) Token: 0x0600CABB RID: 51899 RVA: 0x00321824 File Offset: 0x0031FA24
			// (set) Token: 0x0600CABC RID: 51900 RVA: 0x0006CFCE File Offset: 0x0006B1CE
			public unsafe Il2CppStructArray<int> m_PopHateFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopHateFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PopHateFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C0 RID: 16832
			// (get) Token: 0x0600CABD RID: 51901 RVA: 0x00321854 File Offset: 0x0031FA54
			// (set) Token: 0x0600CABE RID: 51902 RVA: 0x0006CFED File Offset: 0x0006B1ED
			public unsafe int m_Level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Level)) = value;
				}
			}

			// Token: 0x170041C1 RID: 16833
			// (get) Token: 0x0600CABF RID: 51903 RVA: 0x0032187C File Offset: 0x0031FA7C
			// (set) Token: 0x0600CAC0 RID: 51904 RVA: 0x0006D008 File Offset: 0x0006B208
			public unsafe Il2CppStructArray<int> m_Partners
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Partners);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_Partners), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C2 RID: 16834
			// (get) Token: 0x0600CAC1 RID: 51905 RVA: 0x003218AC File Offset: 0x0031FAAC
			// (set) Token: 0x0600CAC2 RID: 51906 RVA: 0x0006D027 File Offset: 0x0006B227
			public unsafe Dictionary<PlayerSaveFile.DefaultProp, List<int>> m_PinnedObjects
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PinnedObjects);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerSaveFile.DefaultProp, List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_PinnedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C3 RID: 16835
			// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x003218DC File Offset: 0x0031FADC
			// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x0006D046 File Offset: 0x0006B246
			public unsafe Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> m_UserIzakayaPresets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_UserIzakayaPresets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_UserIzakayaPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C4 RID: 16836
			// (get) Token: 0x0600CAC5 RID: 51909 RVA: 0x0032190C File Offset: 0x0031FB0C
			// (set) Token: 0x0600CAC6 RID: 51910 RVA: 0x0006D065 File Offset: 0x0006B265
			public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> m_HistoryPartnerSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_HistoryPartnerSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.RuntimePlayerDataCache.NativeFieldInfoPtr_m_HistoryPartnerSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400821C RID: 33308
			private static readonly IntPtr NativeFieldInfoPtr_m_Foods;

			// Token: 0x0400821D RID: 33309
			private static readonly IntPtr NativeFieldInfoPtr_m_Beverages;

			// Token: 0x0400821E RID: 33310
			private static readonly IntPtr NativeFieldInfoPtr_m_Ingredients;

			// Token: 0x0400821F RID: 33311
			private static readonly IntPtr NativeFieldInfoPtr_m_Cookers;

			// Token: 0x04008220 RID: 33312
			private static readonly IntPtr NativeFieldInfoPtr_m_Items;

			// Token: 0x04008221 RID: 33313
			private static readonly IntPtr NativeFieldInfoPtr_m_Badges;

			// Token: 0x04008222 RID: 33314
			private static readonly IntPtr NativeFieldInfoPtr_m_Trophies;

			// Token: 0x04008223 RID: 33315
			private static readonly IntPtr NativeFieldInfoPtr_m_ItemsDeleteEnterWork;

			// Token: 0x04008224 RID: 33316
			private static readonly IntPtr NativeFieldInfoPtr_m_Recipes;

			// Token: 0x04008225 RID: 33317
			private static readonly IntPtr NativeFieldInfoPtr_m_Izakayas;

			// Token: 0x04008226 RID: 33318
			private static readonly IntPtr NativeFieldInfoPtr_m_PopLikeFoodTags;

			// Token: 0x04008227 RID: 33319
			private static readonly IntPtr NativeFieldInfoPtr_m_PopHateFoodTags;

			// Token: 0x04008228 RID: 33320
			private static readonly IntPtr NativeFieldInfoPtr_m_Level;

			// Token: 0x04008229 RID: 33321
			private static readonly IntPtr NativeFieldInfoPtr_m_Partners;

			// Token: 0x0400822A RID: 33322
			private static readonly IntPtr NativeFieldInfoPtr_m_PinnedObjects;

			// Token: 0x0400822B RID: 33323
			private static readonly IntPtr NativeFieldInfoPtr_m_UserIzakayaPresets;

			// Token: 0x0400822C RID: 33324
			private static readonly IntPtr NativeFieldInfoPtr_m_HistoryPartnerSelection;

			// Token: 0x0400822D RID: 33325
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedFoods_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400822E RID: 33326
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedBeverages_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400822F RID: 33327
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedIngredients_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008230 RID: 33328
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedCookers_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008231 RID: 33329
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedItems_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008232 RID: 33330
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedBadges_Public_get_IEnumerable_1_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008233 RID: 33331
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedTrophies_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008234 RID: 33332
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedItemsDeleteEnterWork_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008235 RID: 33333
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedRecipes_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008236 RID: 33334
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedIzakayas_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008237 RID: 33335
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedPopLikeFoodTags_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008238 RID: 33336
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedPopHateFoodTags_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x04008239 RID: 33337
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedPartners_Public_get_IEnumerable_1_Int32_0;

			// Token: 0x0400823A RID: 33338
			private static readonly IntPtr NativeMethodInfoPtr_get_CachedLevel_Public_get_Int32_0;

			// Token: 0x0400823B RID: 33339
			private static readonly IntPtr NativeMethodInfoPtr_get_PinnedObjects_Public_get_IEnumerable_1_KeyValuePair_2_DefaultProp_List_1_Int32_0;

			// Token: 0x0400823C RID: 33340
			private static readonly IntPtr NativeMethodInfoPtr_get_UserIzakayaPresets_Public_get_IEnumerable_1_KeyValuePair_2_Int32_List_1_HistoryIzakayaMenuSelection_0;

			// Token: 0x0400823D RID: 33341
			private static readonly IntPtr NativeMethodInfoPtr_get_HistoryPartnerSelection_Public_get_IEnumerable_1_ValueTuple_2_Int32_PartnerType_0;

			// Token: 0x0400823E RID: 33342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400823F RID: 33343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppReferenceArray_1_KeyValuePair_2_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_;

			// Token: 0x04008240 RID: 33344
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RuntimePlayerDataCache_0;
		}

		// Token: 0x02000A91 RID: 2705
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CAC7 RID: 51911 RVA: 0x0032193C File Offset: 0x0031FB3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr);
				RunTimeStorage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_3");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_4");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_5");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_6");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_7");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_8");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_9");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_10");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_11");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__91_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__91_12");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__106_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__106_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__106_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__106_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__107_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__107_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__107_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__107_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__112_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__112_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__112_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__112_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__117_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__117_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__118_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__118_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__119_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__120_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__124_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__124_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__126_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__126_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__130_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__130_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__130_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__130_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__131_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__131_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__131_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__131_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__132_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__133_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__133_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__134_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__134_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__134_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__134_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__142_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__142_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__143_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__143_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__144_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__144_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__145_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__145_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__149_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__149_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__152_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__152_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__152_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__152_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__152_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__152_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__152_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__152_3");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__154_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__154_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__154_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__154_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__154_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__154_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__155_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__155_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__156_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__156_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__158_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__158_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__158_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__158_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__158_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__158_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__159_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__159_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__159_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__159_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__161_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__161_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__161_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__161_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__162_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__162_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__162_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__162_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__165_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__165_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__166_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__166_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__169_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__169_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__169_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__169_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__169_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__169_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__171_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__171_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__172_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__172_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__173_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__173_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__174_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__174_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__175_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__175_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__177_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__177_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__177_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__177_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__180_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__180_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__180_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__180_1");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__180_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__180_2");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__183_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__183_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__187_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__187_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__188_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__188_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__192_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__192_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__193_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__193_0");
				RunTimeStorage.__c.NativeFieldInfoPtr___9__194_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, "<>9__194_0");
				RunTimeStorage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677104);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_0_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677105);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_1_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677106);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_2_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677107);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_3_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677108);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_4_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677109);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_5_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677110);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_6_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677111);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677112);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_8_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677113);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_9_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677114);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_10_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677115);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_11_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677116);
				RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_12_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677117);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByTag_b__106_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677118);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByTag_b__106_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677119);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByLevel_b__107_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677120);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByLevel_b__107_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677121);
				RunTimeStorage.__c.NativeMethodInfoPtr__CountFoodLong_b__112_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677122);
				RunTimeStorage.__c.NativeMethodInfoPtr__CountFoodLong_b__112_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677123);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetFoodByTag_b__117_0_Internal_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677124);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetFoodByLevel_b__118_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677125);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllFoods_b__119_0_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677126);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllFoodsId_b__120_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677127);
				RunTimeStorage.__c.NativeMethodInfoPtr__BeverageInRange_b__124_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677128);
				RunTimeStorage.__c.NativeMethodInfoPtr__BeverageOutRange_b__126_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677129);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByTag_b__130_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677130);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByTag_b__130_1_Internal_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677131);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677132);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677133);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBeverages_b__132_0_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677134);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBeveragesId_b__133_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677135);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677136);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677137);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetIngredientByTag_b__142_0_Internal_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677138);
				RunTimeStorage.__c.NativeMethodInfoPtr__TryGetIngredientByLevel_b__143_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677139);
				RunTimeStorage.__c.NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__144_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677140);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllIngredients_b__145_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677141);
				RunTimeStorage.__c.NativeMethodInfoPtr__CookerInRange_b__149_0_Internal_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677142);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677143);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677144);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677145);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_3_Internal_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677146);
				RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677147);
				RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_1_Internal_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677148);
				RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_2_Internal_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677149);
				RunTimeStorage.__c.NativeMethodInfoPtr__CountItem_b__155_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677150);
				RunTimeStorage.__c.NativeMethodInfoPtr__CountItem_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677151);
				RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677152);
				RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677153);
				RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677154);
				RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677155);
				RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677156);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItems_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677157);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItems_b__161_1_Internal_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677158);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItemsId_b__162_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677159);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItemsId_b__162_1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677160);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBadges_b__165_0_Internal_Badge_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677161);
				RunTimeStorage.__c.NativeMethodInfoPtr__BadgeInRange_b__166_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677162);
				RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677163);
				RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677164);
				RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677165);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllClothes_b__171_0_Internal_Clothes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677166);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllDecorations_b__172_0_Internal_Decoration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677167);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllRecords_b__173_0_Internal_Record_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677168);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllTrophies_b__174_0_Internal_Trophy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677169);
				RunTimeStorage.__c.NativeMethodInfoPtr__TrophyInRange_b__175_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677170);
				RunTimeStorage.__c.NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677171);
				RunTimeStorage.__c.NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677172);
				RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677173);
				RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677174);
				RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677175);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllRecipes_b__183_0_Internal_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677176);
				RunTimeStorage.__c.NativeMethodInfoPtr__IzakayaIn_b__187_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677177);
				RunTimeStorage.__c.NativeMethodInfoPtr__IzakayaInRange_b__188_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677178);
				RunTimeStorage.__c.NativeMethodInfoPtr__PartnerIn_b__192_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677179);
				RunTimeStorage.__c.NativeMethodInfoPtr__GetAllIzakayas_b__193_0_Internal_Izakaya_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677180);
				RunTimeStorage.__c.NativeMethodInfoPtr__ClearOutdatedFoods_b__194_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr, 100677181);
			}

			// Token: 0x0600CAC8 RID: 51912 RVA: 0x00322598 File Offset: 0x00320798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAC9 RID: 51913 RVA: 0x003225D4 File Offset: 0x003207D4
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_0(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_0_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CACA RID: 51914 RVA: 0x0032262C File Offset: 0x0032082C
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_1(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_1_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CACB RID: 51915 RVA: 0x00322684 File Offset: 0x00320884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180985, XrefRangeEnd = 180986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__91_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_2_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CACC RID: 51916 RVA: 0x003226D8 File Offset: 0x003208D8
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_3(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_3_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CACD RID: 51917 RVA: 0x00322730 File Offset: 0x00320930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180986, XrefRangeEnd = 180987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__91_4(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_4_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CACE RID: 51918 RVA: 0x00322784 File Offset: 0x00320984
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_5(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_5_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CACF RID: 51919 RVA: 0x003227DC File Offset: 0x003209DC
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_6(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_6_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x00322834 File Offset: 0x00320A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180987, XrefRangeEnd = 180988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__91_7(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAD1 RID: 51921 RVA: 0x00322888 File Offset: 0x00320A88
			[CallerCount(0)]
			public unsafe Dictionary<int, int> _Initialize_b__91_8(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_8_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x003228E0 File Offset: 0x00320AE0
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__91_9(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_9_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD3 RID: 51923 RVA: 0x00322938 File Offset: 0x00320B38
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__91_10(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_10_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD4 RID: 51924 RVA: 0x00322990 File Offset: 0x00320B90
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__91_11(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_11_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD5 RID: 51925 RVA: 0x003229E8 File Offset: 0x00320BE8
			[CallerCount(0)]
			public unsafe IEnumerable<int> _Initialize_b__91_12(PlayerSaveFile.RunTimeStorageSaveDataPartial x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__Initialize_b__91_12_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD6 RID: 51926 RVA: 0x00322A40 File Offset: 0x00320C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180988, XrefRangeEnd = 180993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _TryGetObjectByTag_b__106_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByTag_b__106_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD7 RID: 51927 RVA: 0x00322A98 File Offset: 0x00320C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180993, XrefRangeEnd = 180998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _TryGetObjectByTag_b__106_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByTag_b__106_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD8 RID: 51928 RVA: 0x00322AF0 File Offset: 0x00320CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180998, XrefRangeEnd = 181003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _TryGetObjectByLevel_b__107_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByLevel_b__107_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAD9 RID: 51929 RVA: 0x00322B48 File Offset: 0x00320D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181003, XrefRangeEnd = 181008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _TryGetObjectByLevel_b__107_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetObjectByLevel_b__107_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CADA RID: 51930 RVA: 0x00322BA0 File Offset: 0x00320DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181008, XrefRangeEnd = 181009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CountFoodLong_b__112_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__CountFoodLong_b__112_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CADB RID: 51931 RVA: 0x00322BF4 File Offset: 0x00320DF4
			[CallerCount(0)]
			public unsafe int _CountFoodLong_b__112_1(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__CountFoodLong_b__112_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CADC RID: 51932 RVA: 0x00322C4C File Offset: 0x00320E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181009, XrefRangeEnd = 181011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<int> _TryGetFoodByTag_b__117_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetFoodByTag_b__117_0_Internal_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}

			// Token: 0x0600CADD RID: 51933 RVA: 0x00322C98 File Offset: 0x00320E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181011, XrefRangeEnd = 181012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryGetFoodByLevel_b__118_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetFoodByLevel_b__118_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CADE RID: 51934 RVA: 0x00322CE4 File Offset: 0x00320EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _GetAllFoods_b__119_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllFoods_b__119_0_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600CADF RID: 51935 RVA: 0x00322D30 File Offset: 0x00320F30
			[CallerCount(0)]
			public unsafe int _GetAllFoodsId_b__120_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllFoodsId_b__120_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE0 RID: 51936 RVA: 0x00322D7C File Offset: 0x00320F7C
			[CallerCount(0)]
			public unsafe bool _BeverageInRange_b__124_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__BeverageInRange_b__124_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE1 RID: 51937 RVA: 0x00322DC8 File Offset: 0x00320FC8
			[CallerCount(0)]
			public unsafe bool _BeverageOutRange_b__126_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__BeverageOutRange_b__126_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE2 RID: 51938 RVA: 0x00322E14 File Offset: 0x00321014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181012, XrefRangeEnd = 181013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetBeverageByTag_b__130_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByTag_b__130_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE3 RID: 51939 RVA: 0x00322E68 File Offset: 0x00321068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181013, XrefRangeEnd = 181015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<int> _TryGetBeverageByTag_b__130_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByTag_b__130_1_Internal_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAE4 RID: 51940 RVA: 0x00322EB4 File Offset: 0x003210B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181015, XrefRangeEnd = 181016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetBeverageByLevel_b__131_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE5 RID: 51941 RVA: 0x00322F08 File Offset: 0x00321108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryGetBeverageByLevel_b__131_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE6 RID: 51942 RVA: 0x00322F54 File Offset: 0x00321154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _GetAllBeverages_b__132_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBeverages_b__132_0_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600CAE7 RID: 51943 RVA: 0x00322FA0 File Offset: 0x003211A0
			[CallerCount(0)]
			public unsafe int _GetAllBeveragesId_b__133_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBeveragesId_b__133_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE8 RID: 51944 RVA: 0x00322FEC File Offset: 0x003211EC
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetInfiniteIngredientResolver_b__134_0(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAE9 RID: 51945 RVA: 0x00323038 File Offset: 0x00321238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181016, XrefRangeEnd = 181037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetInfiniteIngredientResolver_b__134_1(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAEA RID: 51946 RVA: 0x00323084 File Offset: 0x00321284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<int> _TryGetIngredientByTag_b__142_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetIngredientByTag_b__142_0_Internal_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}

			// Token: 0x0600CAEB RID: 51947 RVA: 0x003230D0 File Offset: 0x003212D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryGetIngredientByLevel_b__143_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TryGetIngredientByLevel_b__143_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAEC RID: 51948 RVA: 0x0032311C File Offset: 0x0032131C
			[CallerCount(0)]
			public unsafe int _ContainsAllFollowingIngredients_b__144_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__144_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAED RID: 51949 RVA: 0x00323168 File Offset: 0x00321368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _GetAllIngredients_b__145_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllIngredients_b__145_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600CAEE RID: 51950 RVA: 0x003231B4 File Offset: 0x003213B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181037, XrefRangeEnd = 181042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<ObjectLanguageBase, Sprite> _CookerInRange_b__149_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__CookerInRange_b__149_0_Internal_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<ObjectLanguageBase, Sprite>(pointer);
			}

			// Token: 0x0600CAEF RID: 51951 RVA: 0x003231F8 File Offset: 0x003213F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181042, XrefRangeEnd = 181043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllCookers_b__152_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF0 RID: 51952 RVA: 0x0032324C File Offset: 0x0032144C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181043, XrefRangeEnd = 181044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllCookers_b__152_1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF1 RID: 51953 RVA: 0x003232A0 File Offset: 0x003214A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181044, XrefRangeEnd = 181045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllCookers_b__152_2(KeyValuePair<int, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF2 RID: 51954 RVA: 0x003232F4 File Offset: 0x003214F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker _GetAllCookers_b__152_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllCookers_b__152_3_Internal_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}

			// Token: 0x0600CAF3 RID: 51955 RVA: 0x00323340 File Offset: 0x00321540
			[CallerCount(0)]
			public unsafe int _SolveCookCount_b__154_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF4 RID: 51956 RVA: 0x0032338C File Offset: 0x0032158C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181045, XrefRangeEnd = 181049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SolveCookCount_b__154_1(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_1_Internal_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF5 RID: 51957 RVA: 0x003233DC File Offset: 0x003215DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181049, XrefRangeEnd = 181052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SolveCookCount_b__154_2(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__SolveCookCount_b__154_2_Internal_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF6 RID: 51958 RVA: 0x0032342C File Offset: 0x0032162C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181052, XrefRangeEnd = 181053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountItem_b__155_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__CountItem_b__155_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF7 RID: 51959 RVA: 0x00323480 File Offset: 0x00321680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181053, XrefRangeEnd = 181054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CountItem_b__156_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__CountItem_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF8 RID: 51960 RVA: 0x003234D4 File Offset: 0x003216D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181054, XrefRangeEnd = 181057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ItemInRange_b__158_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAF9 RID: 51961 RVA: 0x00323520 File Offset: 0x00321720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181057, XrefRangeEnd = 181069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ItemInRange_b__158_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAFA RID: 51962 RVA: 0x00323560 File Offset: 0x00321760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181069, XrefRangeEnd = 181071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ItemInRange_b__158_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRange_b__158_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAFB RID: 51963 RVA: 0x003235A0 File Offset: 0x003217A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ItemInRangeWithoutDecorationNotice_b__159_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAFC RID: 51964 RVA: 0x003235EC File Offset: 0x003217EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181071, XrefRangeEnd = 181083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ItemInRangeWithoutDecorationNotice_b__159_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CAFD RID: 51965 RVA: 0x0032362C File Offset: 0x0032182C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181083, XrefRangeEnd = 181084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllItems_b__161_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItems_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CAFE RID: 51966 RVA: 0x00323680 File Offset: 0x00321880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item _GetAllItems_b__161_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItems_b__161_1_Internal_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
			}

			// Token: 0x0600CAFF RID: 51967 RVA: 0x003236CC File Offset: 0x003218CC
			[CallerCount(0)]
			public unsafe int _GetAllItemsId_b__162_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItemsId_b__162_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB00 RID: 51968 RVA: 0x00323718 File Offset: 0x00321918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181084, XrefRangeEnd = 181085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllItemsId_b__162_1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllItemsId_b__162_1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB01 RID: 51969 RVA: 0x0032376C File Offset: 0x0032196C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181085, XrefRangeEnd = 181091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Badge _GetAllBadges_b__165_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllBadges_b__165_0_Internal_Badge_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Badge>(intPtr3) : null;
			}

			// Token: 0x0600CB02 RID: 51970 RVA: 0x003237B8 File Offset: 0x003219B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181091, XrefRangeEnd = 181096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BadgeInRange_b__166_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__BadgeInRange_b__166_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB03 RID: 51971 RVA: 0x00323804 File Offset: 0x00321A04
			[CallerCount(0)]
			public unsafe bool _ClearAllItems_b__169_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB04 RID: 51972 RVA: 0x00323850 File Offset: 0x00321A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181096, XrefRangeEnd = 181099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ClearAllItems_b__169_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CB05 RID: 51973 RVA: 0x00323894 File Offset: 0x00321A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181099, XrefRangeEnd = 181105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearAllItems_b__169_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ClearAllItems_b__169_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB06 RID: 51974 RVA: 0x003238D4 File Offset: 0x00321AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181105, XrefRangeEnd = 181111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothesProfile.Clothes _GetAllClothes_b__171_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllClothes_b__171_0_Internal_Clothes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothesProfile.Clothes>(intPtr3) : null;
			}

			// Token: 0x0600CB07 RID: 51975 RVA: 0x00323920 File Offset: 0x00321B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181111, XrefRangeEnd = 181117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoration _GetAllDecorations_b__172_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllDecorations_b__172_0_Internal_Decoration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr3) : null;
			}

			// Token: 0x0600CB08 RID: 51976 RVA: 0x0032396C File Offset: 0x00321B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181117, XrefRangeEnd = 181123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Record _GetAllRecords_b__173_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllRecords_b__173_0_Internal_Record_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Record>(intPtr3) : null;
			}

			// Token: 0x0600CB09 RID: 51977 RVA: 0x003239B8 File Offset: 0x00321BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181123, XrefRangeEnd = 181124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrophiesProfile.Trophy _GetAllTrophies_b__174_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllTrophies_b__174_0_Internal_Trophy_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrophiesProfile.Trophy>(intPtr3) : null;
			}

			// Token: 0x0600CB0A RID: 51978 RVA: 0x00323A04 File Offset: 0x00321C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181124, XrefRangeEnd = 181127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TrophyInRange_b__175_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__TrophyInRange_b__175_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB0B RID: 51979 RVA: 0x00323A44 File Offset: 0x00321C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DeleteAllItemsBeforeWork_b__177_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CB0C RID: 51980 RVA: 0x00323A88 File Offset: 0x00321C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181127, XrefRangeEnd = 181133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DeleteAllItemsBeforeWork_b__177_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB0D RID: 51981 RVA: 0x00323AC8 File Offset: 0x00321CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181133, XrefRangeEnd = 181141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecipeInRange_b__180_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB0E RID: 51982 RVA: 0x00323B08 File Offset: 0x00321D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181141, XrefRangeEnd = 181143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecipeInRange_b__180_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB0F RID: 51983 RVA: 0x00323B48 File Offset: 0x00321D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181143, XrefRangeEnd = 181151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecipeInRange_b__180_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__RecipeInRange_b__180_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB10 RID: 51984 RVA: 0x00323B88 File Offset: 0x00321D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _GetAllRecipes_b__183_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllRecipes_b__183_0_Internal_Recipe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600CB11 RID: 51985 RVA: 0x00323BD4 File Offset: 0x00321DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181151, XrefRangeEnd = 181153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _IzakayaIn_b__187_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__IzakayaIn_b__187_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB12 RID: 51986 RVA: 0x00323C14 File Offset: 0x00321E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _IzakayaInRange_b__188_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__IzakayaInRange_b__188_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB13 RID: 51987 RVA: 0x00323C54 File Offset: 0x00321E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181153, XrefRangeEnd = 181155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PartnerIn_b__192_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__PartnerIn_b__192_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB14 RID: 51988 RVA: 0x00323C94 File Offset: 0x00321E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181155, XrefRangeEnd = 181161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Izakaya _GetAllIzakayas_b__193_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__GetAllIzakayas_b__193_0_Internal_Izakaya_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr3) : null;
			}

			// Token: 0x0600CB15 RID: 51989 RVA: 0x00323CE0 File Offset: 0x00321EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181161, XrefRangeEnd = 181167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _ClearOutdatedFoods_b__194_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c.NativeMethodInfoPtr__ClearOutdatedFoods_b__194_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600CB16 RID: 51990 RVA: 0x0006D084 File Offset: 0x0006B284
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D6 RID: 16854
			// (get) Token: 0x0600CB17 RID: 51991 RVA: 0x00323D38 File Offset: 0x00321F38
			// (set) Token: 0x0600CB18 RID: 51992 RVA: 0x0006D08D File Offset: 0x0006B28D
			public unsafe static RunTimeStorage.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D7 RID: 16855
			// (get) Token: 0x0600CB19 RID: 51993 RVA: 0x00323D60 File Offset: 0x00321F60
			// (set) Token: 0x0600CB1A RID: 51994 RVA: 0x0006D09F File Offset: 0x0006B29F
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D8 RID: 16856
			// (get) Token: 0x0600CB1B RID: 51995 RVA: 0x00323D88 File Offset: 0x00321F88
			// (set) Token: 0x0600CB1C RID: 51996 RVA: 0x0006D0B1 File Offset: 0x0006B2B1
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D9 RID: 16857
			// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x00323DB0 File Offset: 0x00321FB0
			// (set) Token: 0x0600CB1E RID: 51998 RVA: 0x0006D0C3 File Offset: 0x0006B2C3
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__91_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DA RID: 16858
			// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00323DD8 File Offset: 0x00321FD8
			// (set) Token: 0x0600CB20 RID: 52000 RVA: 0x0006D0D5 File Offset: 0x0006B2D5
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DB RID: 16859
			// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x00323E00 File Offset: 0x00322000
			// (set) Token: 0x0600CB22 RID: 52002 RVA: 0x0006D0E7 File Offset: 0x0006B2E7
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__91_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DC RID: 16860
			// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x00323E28 File Offset: 0x00322028
			// (set) Token: 0x0600CB24 RID: 52004 RVA: 0x0006D0F9 File Offset: 0x0006B2F9
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DD RID: 16861
			// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x00323E50 File Offset: 0x00322050
			// (set) Token: 0x0600CB26 RID: 52006 RVA: 0x0006D10B File Offset: 0x0006B30B
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DE RID: 16862
			// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00323E78 File Offset: 0x00322078
			// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x0006D11D File Offset: 0x0006B31D
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__91_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DF RID: 16863
			// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x00323EA0 File Offset: 0x003220A0
			// (set) Token: 0x0600CB2A RID: 52010 RVA: 0x0006D12F File Offset: 0x0006B32F
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>> __9__91_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, Dictionary<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E0 RID: 16864
			// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x00323EC8 File Offset: 0x003220C8
			// (set) Token: 0x0600CB2C RID: 52012 RVA: 0x0006D141 File Offset: 0x0006B341
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>> __9__91_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E1 RID: 16865
			// (get) Token: 0x0600CB2D RID: 52013 RVA: 0x00323EF0 File Offset: 0x003220F0
			// (set) Token: 0x0600CB2E RID: 52014 RVA: 0x0006D153 File Offset: 0x0006B353
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>> __9__91_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E2 RID: 16866
			// (get) Token: 0x0600CB2F RID: 52015 RVA: 0x00323F18 File Offset: 0x00322118
			// (set) Token: 0x0600CB30 RID: 52016 RVA: 0x0006D165 File Offset: 0x0006B365
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>> __9__91_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E3 RID: 16867
			// (get) Token: 0x0600CB31 RID: 52017 RVA: 0x00323F40 File Offset: 0x00322140
			// (set) Token: 0x0600CB32 RID: 52018 RVA: 0x0006D177 File Offset: 0x0006B377
			public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>> __9__91_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__91_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E4 RID: 16868
			// (get) Token: 0x0600CB33 RID: 52019 RVA: 0x00323F68 File Offset: 0x00322168
			// (set) Token: 0x0600CB34 RID: 52020 RVA: 0x0006D189 File Offset: 0x0006B389
			public unsafe static Func<KeyValuePair<int, int>, IEnumerable<int>> __9__106_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__106_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__106_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E5 RID: 16869
			// (get) Token: 0x0600CB35 RID: 52021 RVA: 0x00323F90 File Offset: 0x00322190
			// (set) Token: 0x0600CB36 RID: 52022 RVA: 0x0006D19B File Offset: 0x0006B39B
			public unsafe static Func<KeyValuePair<int, int>, IEnumerable<int>> __9__106_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__106_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__106_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E6 RID: 16870
			// (get) Token: 0x0600CB37 RID: 52023 RVA: 0x00323FB8 File Offset: 0x003221B8
			// (set) Token: 0x0600CB38 RID: 52024 RVA: 0x0006D1AD File Offset: 0x0006B3AD
			public unsafe static Func<KeyValuePair<int, int>, IEnumerable<int>> __9__107_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__107_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__107_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E7 RID: 16871
			// (get) Token: 0x0600CB39 RID: 52025 RVA: 0x00323FE0 File Offset: 0x003221E0
			// (set) Token: 0x0600CB3A RID: 52026 RVA: 0x0006D1BF File Offset: 0x0006B3BF
			public unsafe static Func<KeyValuePair<int, int>, IEnumerable<int>> __9__107_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__107_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__107_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E8 RID: 16872
			// (get) Token: 0x0600CB3B RID: 52027 RVA: 0x00324008 File Offset: 0x00322208
			// (set) Token: 0x0600CB3C RID: 52028 RVA: 0x0006D1D1 File Offset: 0x0006B3D1
			public unsafe static Func<KeyValuePair<int, int>, int> __9__112_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__112_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__112_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E9 RID: 16873
			// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x00324030 File Offset: 0x00322230
			// (set) Token: 0x0600CB3E RID: 52030 RVA: 0x0006D1E3 File Offset: 0x0006B3E3
			public unsafe static Func<int, int, int> __9__112_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__112_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__112_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EA RID: 16874
			// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x00324058 File Offset: 0x00322258
			// (set) Token: 0x0600CB40 RID: 52032 RVA: 0x0006D1F5 File Offset: 0x0006B3F5
			public unsafe static Func<int, Il2CppStructArray<int>> __9__117_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__117_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__117_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EB RID: 16875
			// (get) Token: 0x0600CB41 RID: 52033 RVA: 0x00324080 File Offset: 0x00322280
			// (set) Token: 0x0600CB42 RID: 52034 RVA: 0x0006D207 File Offset: 0x0006B407
			public unsafe static Func<int, int> __9__118_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__118_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__118_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EC RID: 16876
			// (get) Token: 0x0600CB43 RID: 52035 RVA: 0x003240A8 File Offset: 0x003222A8
			// (set) Token: 0x0600CB44 RID: 52036 RVA: 0x0006D219 File Offset: 0x0006B419
			public unsafe static Func<int, Sellable> __9__119_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__119_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__119_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041ED RID: 16877
			// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x003240D0 File Offset: 0x003222D0
			// (set) Token: 0x0600CB46 RID: 52038 RVA: 0x0006D22B File Offset: 0x0006B42B
			public unsafe static Func<int, int> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EE RID: 16878
			// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x003240F8 File Offset: 0x003222F8
			// (set) Token: 0x0600CB48 RID: 52040 RVA: 0x0006D23D File Offset: 0x0006B43D
			public unsafe static Func<int, bool> __9__124_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__124_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__124_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EF RID: 16879
			// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x00324120 File Offset: 0x00322320
			// (set) Token: 0x0600CB4A RID: 52042 RVA: 0x0006D24F File Offset: 0x0006B44F
			public unsafe static Func<int, bool> __9__126_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__126_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__126_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F0 RID: 16880
			// (get) Token: 0x0600CB4B RID: 52043 RVA: 0x00324148 File Offset: 0x00322348
			// (set) Token: 0x0600CB4C RID: 52044 RVA: 0x0006D261 File Offset: 0x0006B461
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__130_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__130_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__130_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F1 RID: 16881
			// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x00324170 File Offset: 0x00322370
			// (set) Token: 0x0600CB4E RID: 52046 RVA: 0x0006D273 File Offset: 0x0006B473
			public unsafe static Func<int, Il2CppStructArray<int>> __9__130_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__130_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__130_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F2 RID: 16882
			// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x00324198 File Offset: 0x00322398
			// (set) Token: 0x0600CB50 RID: 52048 RVA: 0x0006D285 File Offset: 0x0006B485
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__131_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__131_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__131_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F3 RID: 16883
			// (get) Token: 0x0600CB51 RID: 52049 RVA: 0x003241C0 File Offset: 0x003223C0
			// (set) Token: 0x0600CB52 RID: 52050 RVA: 0x0006D297 File Offset: 0x0006B497
			public unsafe static Func<int, int> __9__131_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__131_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__131_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F4 RID: 16884
			// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x003241E8 File Offset: 0x003223E8
			// (set) Token: 0x0600CB54 RID: 52052 RVA: 0x0006D2A9 File Offset: 0x0006B4A9
			public unsafe static Func<int, Sellable> __9__132_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F5 RID: 16885
			// (get) Token: 0x0600CB55 RID: 52053 RVA: 0x00324210 File Offset: 0x00322410
			// (set) Token: 0x0600CB56 RID: 52054 RVA: 0x0006D2BB File Offset: 0x0006B4BB
			public unsafe static Func<int, int> __9__133_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__133_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__133_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F6 RID: 16886
			// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x00324238 File Offset: 0x00322438
			// (set) Token: 0x0600CB58 RID: 52056 RVA: 0x0006D2CD File Offset: 0x0006B4CD
			public unsafe static Predicate<int> __9__134_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__134_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__134_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F7 RID: 16887
			// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00324260 File Offset: 0x00322460
			// (set) Token: 0x0600CB5A RID: 52058 RVA: 0x0006D2DF File Offset: 0x0006B4DF
			public unsafe static Predicate<int> __9__134_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__134_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__134_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F8 RID: 16888
			// (get) Token: 0x0600CB5B RID: 52059 RVA: 0x00324288 File Offset: 0x00322488
			// (set) Token: 0x0600CB5C RID: 52060 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
			public unsafe static Func<int, Il2CppStructArray<int>> __9__142_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__142_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__142_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F9 RID: 16889
			// (get) Token: 0x0600CB5D RID: 52061 RVA: 0x003242B0 File Offset: 0x003224B0
			// (set) Token: 0x0600CB5E RID: 52062 RVA: 0x0006D303 File Offset: 0x0006B503
			public unsafe static Func<int, int> __9__143_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__143_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__143_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FA RID: 16890
			// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x003242D8 File Offset: 0x003224D8
			// (set) Token: 0x0600CB60 RID: 52064 RVA: 0x0006D315 File Offset: 0x0006B515
			public unsafe static Func<int, int> __9__144_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__144_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__144_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FB RID: 16891
			// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00324300 File Offset: 0x00322500
			// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x0006D327 File Offset: 0x0006B527
			public unsafe static Func<int, Ingredient> __9__145_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__145_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__145_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FC RID: 16892
			// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00324328 File Offset: 0x00322528
			// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x0006D339 File Offset: 0x0006B539
			public unsafe static Func<int, ValueTuple<ObjectLanguageBase, Sprite>> __9__149_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__149_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<ObjectLanguageBase, Sprite>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__149_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FD RID: 16893
			// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00324350 File Offset: 0x00322550
			// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x0006D34B File Offset: 0x0006B54B
			public unsafe static Func<KeyValuePair<int, int>, int> __9__152_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FE RID: 16894
			// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00324378 File Offset: 0x00322578
			// (set) Token: 0x0600CB68 RID: 52072 RVA: 0x0006D35D File Offset: 0x0006B55D
			public unsafe static Func<KeyValuePair<int, int>, int> __9__152_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FF RID: 16895
			// (get) Token: 0x0600CB69 RID: 52073 RVA: 0x003243A0 File Offset: 0x003225A0
			// (set) Token: 0x0600CB6A RID: 52074 RVA: 0x0006D36F File Offset: 0x0006B56F
			public unsafe static Func<KeyValuePair<int, int>, int> __9__152_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004200 RID: 16896
			// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x003243C8 File Offset: 0x003225C8
			// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x0006D381 File Offset: 0x0006B581
			public unsafe static Func<int, Cooker> __9__152_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__152_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004201 RID: 16897
			// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x003243F0 File Offset: 0x003225F0
			// (set) Token: 0x0600CB6E RID: 52078 RVA: 0x0006D393 File Offset: 0x0006B593
			public unsafe static Func<int, int> __9__154_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004202 RID: 16898
			// (get) Token: 0x0600CB6F RID: 52079 RVA: 0x00324418 File Offset: 0x00322618
			// (set) Token: 0x0600CB70 RID: 52080 RVA: 0x0006D3A5 File Offset: 0x0006B5A5
			public unsafe static Func<IGrouping<int, int>, int> __9__154_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004203 RID: 16899
			// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x00324440 File Offset: 0x00322640
			// (set) Token: 0x0600CB72 RID: 52082 RVA: 0x0006D3B7 File Offset: 0x0006B5B7
			public unsafe static Func<IGrouping<int, int>, int> __9__154_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__154_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004204 RID: 16900
			// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x00324468 File Offset: 0x00322668
			// (set) Token: 0x0600CB74 RID: 52084 RVA: 0x0006D3C9 File Offset: 0x0006B5C9
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__155_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__155_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__155_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004205 RID: 16901
			// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x00324490 File Offset: 0x00322690
			// (set) Token: 0x0600CB76 RID: 52086 RVA: 0x0006D3DB File Offset: 0x0006B5DB
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__156_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__156_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__156_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004206 RID: 16902
			// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x003244B8 File Offset: 0x003226B8
			// (set) Token: 0x0600CB78 RID: 52088 RVA: 0x0006D3ED File Offset: 0x0006B5ED
			public unsafe static Func<int, bool> __9__158_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004207 RID: 16903
			// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x003244E0 File Offset: 0x003226E0
			// (set) Token: 0x0600CB7A RID: 52090 RVA: 0x0006D3FF File Offset: 0x0006B5FF
			public unsafe static Action<int> __9__158_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004208 RID: 16904
			// (get) Token: 0x0600CB7B RID: 52091 RVA: 0x00324508 File Offset: 0x00322708
			// (set) Token: 0x0600CB7C RID: 52092 RVA: 0x0006D411 File Offset: 0x0006B611
			public unsafe static Action<int> __9__158_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__158_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004209 RID: 16905
			// (get) Token: 0x0600CB7D RID: 52093 RVA: 0x00324530 File Offset: 0x00322730
			// (set) Token: 0x0600CB7E RID: 52094 RVA: 0x0006D423 File Offset: 0x0006B623
			public unsafe static Func<int, bool> __9__159_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__159_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__159_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420A RID: 16906
			// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x00324558 File Offset: 0x00322758
			// (set) Token: 0x0600CB80 RID: 52096 RVA: 0x0006D435 File Offset: 0x0006B635
			public unsafe static Action<int> __9__159_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__159_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__159_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420B RID: 16907
			// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00324580 File Offset: 0x00322780
			// (set) Token: 0x0600CB82 RID: 52098 RVA: 0x0006D447 File Offset: 0x0006B647
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__161_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__161_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__161_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420C RID: 16908
			// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x003245A8 File Offset: 0x003227A8
			// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x0006D459 File Offset: 0x0006B659
			public unsafe static Func<int, Item> __9__161_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__161_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__161_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420D RID: 16909
			// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x003245D0 File Offset: 0x003227D0
			// (set) Token: 0x0600CB86 RID: 52102 RVA: 0x0006D46B File Offset: 0x0006B66B
			public unsafe static Func<int, int> __9__162_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__162_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__162_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420E RID: 16910
			// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x003245F8 File Offset: 0x003227F8
			// (set) Token: 0x0600CB88 RID: 52104 RVA: 0x0006D47D File Offset: 0x0006B67D
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__162_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__162_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__162_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700420F RID: 16911
			// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x00324620 File Offset: 0x00322820
			// (set) Token: 0x0600CB8A RID: 52106 RVA: 0x0006D48F File Offset: 0x0006B68F
			public unsafe static Func<int, Badge> __9__165_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__165_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Badge>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__165_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x00324648 File Offset: 0x00322848
			// (set) Token: 0x0600CB8C RID: 52108 RVA: 0x0006D4A1 File Offset: 0x0006B6A1
			public unsafe static Func<int, bool> __9__166_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__166_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__166_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00324670 File Offset: 0x00322870
			// (set) Token: 0x0600CB8E RID: 52110 RVA: 0x0006D4B3 File Offset: 0x0006B6B3
			public unsafe static Func<int, bool> __9__169_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004212 RID: 16914
			// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x00324698 File Offset: 0x00322898
			// (set) Token: 0x0600CB90 RID: 52112 RVA: 0x0006D4C5 File Offset: 0x0006B6C5
			public unsafe static Func<int, string> __9__169_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004213 RID: 16915
			// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x003246C0 File Offset: 0x003228C0
			// (set) Token: 0x0600CB92 RID: 52114 RVA: 0x0006D4D7 File Offset: 0x0006B6D7
			public unsafe static Action<int> __9__169_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__169_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004214 RID: 16916
			// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x003246E8 File Offset: 0x003228E8
			// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x0006D4E9 File Offset: 0x0006B6E9
			public unsafe static Func<int, ClothesProfile.Clothes> __9__171_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__171_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ClothesProfile.Clothes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__171_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004215 RID: 16917
			// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x00324710 File Offset: 0x00322910
			// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x0006D4FB File Offset: 0x0006B6FB
			public unsafe static Func<int, Decoration> __9__172_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__172_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Decoration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__172_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004216 RID: 16918
			// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x00324738 File Offset: 0x00322938
			// (set) Token: 0x0600CB98 RID: 52120 RVA: 0x0006D50D File Offset: 0x0006B70D
			public unsafe static Func<int, Record> __9__173_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__173_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Record>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__173_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004217 RID: 16919
			// (get) Token: 0x0600CB99 RID: 52121 RVA: 0x00324760 File Offset: 0x00322960
			// (set) Token: 0x0600CB9A RID: 52122 RVA: 0x0006D51F File Offset: 0x0006B71F
			public unsafe static Func<int, TrophiesProfile.Trophy> __9__174_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__174_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, TrophiesProfile.Trophy>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__174_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004218 RID: 16920
			// (get) Token: 0x0600CB9B RID: 52123 RVA: 0x00324788 File Offset: 0x00322988
			// (set) Token: 0x0600CB9C RID: 52124 RVA: 0x0006D531 File Offset: 0x0006B731
			public unsafe static Action<int> __9__175_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__175_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__175_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004219 RID: 16921
			// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x003247B0 File Offset: 0x003229B0
			// (set) Token: 0x0600CB9E RID: 52126 RVA: 0x0006D543 File Offset: 0x0006B743
			public unsafe static Func<int, string> __9__177_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__177_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__177_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421A RID: 16922
			// (get) Token: 0x0600CB9F RID: 52127 RVA: 0x003247D8 File Offset: 0x003229D8
			// (set) Token: 0x0600CBA0 RID: 52128 RVA: 0x0006D555 File Offset: 0x0006B755
			public unsafe static Action<int> __9__177_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__177_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__177_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421B RID: 16923
			// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x00324800 File Offset: 0x00322A00
			// (set) Token: 0x0600CBA2 RID: 52130 RVA: 0x0006D567 File Offset: 0x0006B767
			public unsafe static Action<int> __9__180_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421C RID: 16924
			// (get) Token: 0x0600CBA3 RID: 52131 RVA: 0x00324828 File Offset: 0x00322A28
			// (set) Token: 0x0600CBA4 RID: 52132 RVA: 0x0006D579 File Offset: 0x0006B779
			public unsafe static Action<int> __9__180_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421D RID: 16925
			// (get) Token: 0x0600CBA5 RID: 52133 RVA: 0x00324850 File Offset: 0x00322A50
			// (set) Token: 0x0600CBA6 RID: 52134 RVA: 0x0006D58B File Offset: 0x0006B78B
			public unsafe static Action<int> __9__180_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__180_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421E RID: 16926
			// (get) Token: 0x0600CBA7 RID: 52135 RVA: 0x00324878 File Offset: 0x00322A78
			// (set) Token: 0x0600CBA8 RID: 52136 RVA: 0x0006D59D File Offset: 0x0006B79D
			public unsafe static Func<int, Recipe> __9__183_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__183_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__183_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421F RID: 16927
			// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x003248A0 File Offset: 0x00322AA0
			// (set) Token: 0x0600CBAA RID: 52138 RVA: 0x0006D5AF File Offset: 0x0006B7AF
			public unsafe static Action<int> __9__187_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__187_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__187_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004220 RID: 16928
			// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x003248C8 File Offset: 0x00322AC8
			// (set) Token: 0x0600CBAC RID: 52140 RVA: 0x0006D5C1 File Offset: 0x0006B7C1
			public unsafe static Action<int> __9__188_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__188_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__188_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004221 RID: 16929
			// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x003248F0 File Offset: 0x00322AF0
			// (set) Token: 0x0600CBAE RID: 52142 RVA: 0x0006D5D3 File Offset: 0x0006B7D3
			public unsafe static Action<int> __9__192_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__192_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__192_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004222 RID: 16930
			// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x00324918 File Offset: 0x00322B18
			// (set) Token: 0x0600CBB0 RID: 52144 RVA: 0x0006D5E5 File Offset: 0x0006B7E5
			public unsafe static Func<int, Izakaya> __9__193_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__193_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Izakaya>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__193_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004223 RID: 16931
			// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x00324940 File Offset: 0x00322B40
			// (set) Token: 0x0600CBB2 RID: 52146 RVA: 0x0006D5F7 File Offset: 0x0006B7F7
			public unsafe static Func<KeyValuePair<Sellable, int>, IEnumerable<int>> __9__194_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__194_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c.NativeFieldInfoPtr___9__194_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008241 RID: 33345
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008242 RID: 33346
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04008243 RID: 33347
			private static readonly IntPtr NativeFieldInfoPtr___9__91_1;

			// Token: 0x04008244 RID: 33348
			private static readonly IntPtr NativeFieldInfoPtr___9__91_2;

			// Token: 0x04008245 RID: 33349
			private static readonly IntPtr NativeFieldInfoPtr___9__91_3;

			// Token: 0x04008246 RID: 33350
			private static readonly IntPtr NativeFieldInfoPtr___9__91_4;

			// Token: 0x04008247 RID: 33351
			private static readonly IntPtr NativeFieldInfoPtr___9__91_5;

			// Token: 0x04008248 RID: 33352
			private static readonly IntPtr NativeFieldInfoPtr___9__91_6;

			// Token: 0x04008249 RID: 33353
			private static readonly IntPtr NativeFieldInfoPtr___9__91_7;

			// Token: 0x0400824A RID: 33354
			private static readonly IntPtr NativeFieldInfoPtr___9__91_8;

			// Token: 0x0400824B RID: 33355
			private static readonly IntPtr NativeFieldInfoPtr___9__91_9;

			// Token: 0x0400824C RID: 33356
			private static readonly IntPtr NativeFieldInfoPtr___9__91_10;

			// Token: 0x0400824D RID: 33357
			private static readonly IntPtr NativeFieldInfoPtr___9__91_11;

			// Token: 0x0400824E RID: 33358
			private static readonly IntPtr NativeFieldInfoPtr___9__91_12;

			// Token: 0x0400824F RID: 33359
			private static readonly IntPtr NativeFieldInfoPtr___9__106_0;

			// Token: 0x04008250 RID: 33360
			private static readonly IntPtr NativeFieldInfoPtr___9__106_2;

			// Token: 0x04008251 RID: 33361
			private static readonly IntPtr NativeFieldInfoPtr___9__107_0;

			// Token: 0x04008252 RID: 33362
			private static readonly IntPtr NativeFieldInfoPtr___9__107_2;

			// Token: 0x04008253 RID: 33363
			private static readonly IntPtr NativeFieldInfoPtr___9__112_0;

			// Token: 0x04008254 RID: 33364
			private static readonly IntPtr NativeFieldInfoPtr___9__112_1;

			// Token: 0x04008255 RID: 33365
			private static readonly IntPtr NativeFieldInfoPtr___9__117_0;

			// Token: 0x04008256 RID: 33366
			private static readonly IntPtr NativeFieldInfoPtr___9__118_0;

			// Token: 0x04008257 RID: 33367
			private static readonly IntPtr NativeFieldInfoPtr___9__119_0;

			// Token: 0x04008258 RID: 33368
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x04008259 RID: 33369
			private static readonly IntPtr NativeFieldInfoPtr___9__124_0;

			// Token: 0x0400825A RID: 33370
			private static readonly IntPtr NativeFieldInfoPtr___9__126_0;

			// Token: 0x0400825B RID: 33371
			private static readonly IntPtr NativeFieldInfoPtr___9__130_0;

			// Token: 0x0400825C RID: 33372
			private static readonly IntPtr NativeFieldInfoPtr___9__130_1;

			// Token: 0x0400825D RID: 33373
			private static readonly IntPtr NativeFieldInfoPtr___9__131_0;

			// Token: 0x0400825E RID: 33374
			private static readonly IntPtr NativeFieldInfoPtr___9__131_1;

			// Token: 0x0400825F RID: 33375
			private static readonly IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x04008260 RID: 33376
			private static readonly IntPtr NativeFieldInfoPtr___9__133_0;

			// Token: 0x04008261 RID: 33377
			private static readonly IntPtr NativeFieldInfoPtr___9__134_0;

			// Token: 0x04008262 RID: 33378
			private static readonly IntPtr NativeFieldInfoPtr___9__134_1;

			// Token: 0x04008263 RID: 33379
			private static readonly IntPtr NativeFieldInfoPtr___9__142_0;

			// Token: 0x04008264 RID: 33380
			private static readonly IntPtr NativeFieldInfoPtr___9__143_0;

			// Token: 0x04008265 RID: 33381
			private static readonly IntPtr NativeFieldInfoPtr___9__144_0;

			// Token: 0x04008266 RID: 33382
			private static readonly IntPtr NativeFieldInfoPtr___9__145_0;

			// Token: 0x04008267 RID: 33383
			private static readonly IntPtr NativeFieldInfoPtr___9__149_0;

			// Token: 0x04008268 RID: 33384
			private static readonly IntPtr NativeFieldInfoPtr___9__152_0;

			// Token: 0x04008269 RID: 33385
			private static readonly IntPtr NativeFieldInfoPtr___9__152_1;

			// Token: 0x0400826A RID: 33386
			private static readonly IntPtr NativeFieldInfoPtr___9__152_2;

			// Token: 0x0400826B RID: 33387
			private static readonly IntPtr NativeFieldInfoPtr___9__152_3;

			// Token: 0x0400826C RID: 33388
			private static readonly IntPtr NativeFieldInfoPtr___9__154_0;

			// Token: 0x0400826D RID: 33389
			private static readonly IntPtr NativeFieldInfoPtr___9__154_1;

			// Token: 0x0400826E RID: 33390
			private static readonly IntPtr NativeFieldInfoPtr___9__154_2;

			// Token: 0x0400826F RID: 33391
			private static readonly IntPtr NativeFieldInfoPtr___9__155_0;

			// Token: 0x04008270 RID: 33392
			private static readonly IntPtr NativeFieldInfoPtr___9__156_0;

			// Token: 0x04008271 RID: 33393
			private static readonly IntPtr NativeFieldInfoPtr___9__158_0;

			// Token: 0x04008272 RID: 33394
			private static readonly IntPtr NativeFieldInfoPtr___9__158_1;

			// Token: 0x04008273 RID: 33395
			private static readonly IntPtr NativeFieldInfoPtr___9__158_2;

			// Token: 0x04008274 RID: 33396
			private static readonly IntPtr NativeFieldInfoPtr___9__159_0;

			// Token: 0x04008275 RID: 33397
			private static readonly IntPtr NativeFieldInfoPtr___9__159_1;

			// Token: 0x04008276 RID: 33398
			private static readonly IntPtr NativeFieldInfoPtr___9__161_0;

			// Token: 0x04008277 RID: 33399
			private static readonly IntPtr NativeFieldInfoPtr___9__161_1;

			// Token: 0x04008278 RID: 33400
			private static readonly IntPtr NativeFieldInfoPtr___9__162_0;

			// Token: 0x04008279 RID: 33401
			private static readonly IntPtr NativeFieldInfoPtr___9__162_1;

			// Token: 0x0400827A RID: 33402
			private static readonly IntPtr NativeFieldInfoPtr___9__165_0;

			// Token: 0x0400827B RID: 33403
			private static readonly IntPtr NativeFieldInfoPtr___9__166_0;

			// Token: 0x0400827C RID: 33404
			private static readonly IntPtr NativeFieldInfoPtr___9__169_0;

			// Token: 0x0400827D RID: 33405
			private static readonly IntPtr NativeFieldInfoPtr___9__169_1;

			// Token: 0x0400827E RID: 33406
			private static readonly IntPtr NativeFieldInfoPtr___9__169_2;

			// Token: 0x0400827F RID: 33407
			private static readonly IntPtr NativeFieldInfoPtr___9__171_0;

			// Token: 0x04008280 RID: 33408
			private static readonly IntPtr NativeFieldInfoPtr___9__172_0;

			// Token: 0x04008281 RID: 33409
			private static readonly IntPtr NativeFieldInfoPtr___9__173_0;

			// Token: 0x04008282 RID: 33410
			private static readonly IntPtr NativeFieldInfoPtr___9__174_0;

			// Token: 0x04008283 RID: 33411
			private static readonly IntPtr NativeFieldInfoPtr___9__175_0;

			// Token: 0x04008284 RID: 33412
			private static readonly IntPtr NativeFieldInfoPtr___9__177_0;

			// Token: 0x04008285 RID: 33413
			private static readonly IntPtr NativeFieldInfoPtr___9__177_1;

			// Token: 0x04008286 RID: 33414
			private static readonly IntPtr NativeFieldInfoPtr___9__180_0;

			// Token: 0x04008287 RID: 33415
			private static readonly IntPtr NativeFieldInfoPtr___9__180_1;

			// Token: 0x04008288 RID: 33416
			private static readonly IntPtr NativeFieldInfoPtr___9__180_2;

			// Token: 0x04008289 RID: 33417
			private static readonly IntPtr NativeFieldInfoPtr___9__183_0;

			// Token: 0x0400828A RID: 33418
			private static readonly IntPtr NativeFieldInfoPtr___9__187_0;

			// Token: 0x0400828B RID: 33419
			private static readonly IntPtr NativeFieldInfoPtr___9__188_0;

			// Token: 0x0400828C RID: 33420
			private static readonly IntPtr NativeFieldInfoPtr___9__192_0;

			// Token: 0x0400828D RID: 33421
			private static readonly IntPtr NativeFieldInfoPtr___9__193_0;

			// Token: 0x0400828E RID: 33422
			private static readonly IntPtr NativeFieldInfoPtr___9__194_0;

			// Token: 0x0400828F RID: 33423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008290 RID: 33424
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_0_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008291 RID: 33425
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_1_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008292 RID: 33426
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_2_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008293 RID: 33427
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_3_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008294 RID: 33428
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_4_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008295 RID: 33429
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_5_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008296 RID: 33430
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_6_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008297 RID: 33431
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04008298 RID: 33432
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_8_Internal_Dictionary_2_Int32_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04008299 RID: 33433
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_9_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x0400829A RID: 33434
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_10_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x0400829B RID: 33435
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_11_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x0400829C RID: 33436
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__91_12_Internal_IEnumerable_1_Int32_RunTimeStorageSaveDataPartial_0;

			// Token: 0x0400829D RID: 33437
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByTag_b__106_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400829E RID: 33438
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByTag_b__106_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400829F RID: 33439
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByLevel_b__107_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082A0 RID: 33440
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByLevel_b__107_2_Internal_IEnumerable_1_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082A1 RID: 33441
			private static readonly IntPtr NativeMethodInfoPtr__CountFoodLong_b__112_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082A2 RID: 33442
			private static readonly IntPtr NativeMethodInfoPtr__CountFoodLong_b__112_1_Internal_Int32_Int32_Int32_0;

			// Token: 0x040082A3 RID: 33443
			private static readonly IntPtr NativeMethodInfoPtr__TryGetFoodByTag_b__117_0_Internal_Il2CppStructArray_1_Int32_Int32_0;

			// Token: 0x040082A4 RID: 33444
			private static readonly IntPtr NativeMethodInfoPtr__TryGetFoodByLevel_b__118_0_Internal_Int32_Int32_0;

			// Token: 0x040082A5 RID: 33445
			private static readonly IntPtr NativeMethodInfoPtr__GetAllFoods_b__119_0_Internal_Sellable_Int32_0;

			// Token: 0x040082A6 RID: 33446
			private static readonly IntPtr NativeMethodInfoPtr__GetAllFoodsId_b__120_0_Internal_Int32_Int32_0;

			// Token: 0x040082A7 RID: 33447
			private static readonly IntPtr NativeMethodInfoPtr__BeverageInRange_b__124_0_Internal_Boolean_Int32_0;

			// Token: 0x040082A8 RID: 33448
			private static readonly IntPtr NativeMethodInfoPtr__BeverageOutRange_b__126_0_Internal_Boolean_Int32_0;

			// Token: 0x040082A9 RID: 33449
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBeverageByTag_b__130_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082AA RID: 33450
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBeverageByTag_b__130_1_Internal_Il2CppStructArray_1_Int32_Int32_0;

			// Token: 0x040082AB RID: 33451
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082AC RID: 33452
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBeverageByLevel_b__131_1_Internal_Int32_Int32_0;

			// Token: 0x040082AD RID: 33453
			private static readonly IntPtr NativeMethodInfoPtr__GetAllBeverages_b__132_0_Internal_Sellable_Int32_0;

			// Token: 0x040082AE RID: 33454
			private static readonly IntPtr NativeMethodInfoPtr__GetAllBeveragesId_b__133_0_Internal_Int32_Int32_0;

			// Token: 0x040082AF RID: 33455
			private static readonly IntPtr NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_0_Internal_Boolean_Int32_0;

			// Token: 0x040082B0 RID: 33456
			private static readonly IntPtr NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__134_1_Internal_Boolean_Int32_0;

			// Token: 0x040082B1 RID: 33457
			private static readonly IntPtr NativeMethodInfoPtr__TryGetIngredientByTag_b__142_0_Internal_Il2CppStructArray_1_Int32_Int32_0;

			// Token: 0x040082B2 RID: 33458
			private static readonly IntPtr NativeMethodInfoPtr__TryGetIngredientByLevel_b__143_0_Internal_Int32_Int32_0;

			// Token: 0x040082B3 RID: 33459
			private static readonly IntPtr NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__144_0_Internal_Int32_Int32_0;

			// Token: 0x040082B4 RID: 33460
			private static readonly IntPtr NativeMethodInfoPtr__GetAllIngredients_b__145_0_Internal_Ingredient_Int32_0;

			// Token: 0x040082B5 RID: 33461
			private static readonly IntPtr NativeMethodInfoPtr__CookerInRange_b__149_0_Internal_ValueTuple_2_ObjectLanguageBase_Sprite_Int32_0;

			// Token: 0x040082B6 RID: 33462
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookers_b__152_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082B7 RID: 33463
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookers_b__152_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082B8 RID: 33464
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookers_b__152_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082B9 RID: 33465
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookers_b__152_3_Internal_Cooker_Int32_0;

			// Token: 0x040082BA RID: 33466
			private static readonly IntPtr NativeMethodInfoPtr__SolveCookCount_b__154_0_Internal_Int32_Int32_0;

			// Token: 0x040082BB RID: 33467
			private static readonly IntPtr NativeMethodInfoPtr__SolveCookCount_b__154_1_Internal_Int32_IGrouping_2_Int32_Int32_0;

			// Token: 0x040082BC RID: 33468
			private static readonly IntPtr NativeMethodInfoPtr__SolveCookCount_b__154_2_Internal_Int32_IGrouping_2_Int32_Int32_0;

			// Token: 0x040082BD RID: 33469
			private static readonly IntPtr NativeMethodInfoPtr__CountItem_b__155_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082BE RID: 33470
			private static readonly IntPtr NativeMethodInfoPtr__CountItem_b__156_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082BF RID: 33471
			private static readonly IntPtr NativeMethodInfoPtr__ItemInRange_b__158_0_Internal_Boolean_Int32_0;

			// Token: 0x040082C0 RID: 33472
			private static readonly IntPtr NativeMethodInfoPtr__ItemInRange_b__158_1_Internal_Void_Int32_0;

			// Token: 0x040082C1 RID: 33473
			private static readonly IntPtr NativeMethodInfoPtr__ItemInRange_b__158_2_Internal_Void_Int32_0;

			// Token: 0x040082C2 RID: 33474
			private static readonly IntPtr NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_0_Internal_Boolean_Int32_0;

			// Token: 0x040082C3 RID: 33475
			private static readonly IntPtr NativeMethodInfoPtr__ItemInRangeWithoutDecorationNotice_b__159_1_Internal_Void_Int32_0;

			// Token: 0x040082C4 RID: 33476
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItems_b__161_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082C5 RID: 33477
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItems_b__161_1_Internal_Item_Int32_0;

			// Token: 0x040082C6 RID: 33478
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItemsId_b__162_0_Internal_Int32_Int32_0;

			// Token: 0x040082C7 RID: 33479
			private static readonly IntPtr NativeMethodInfoPtr__GetAllItemsId_b__162_1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x040082C8 RID: 33480
			private static readonly IntPtr NativeMethodInfoPtr__GetAllBadges_b__165_0_Internal_Badge_Int32_0;

			// Token: 0x040082C9 RID: 33481
			private static readonly IntPtr NativeMethodInfoPtr__BadgeInRange_b__166_0_Internal_Boolean_Int32_0;

			// Token: 0x040082CA RID: 33482
			private static readonly IntPtr NativeMethodInfoPtr__ClearAllItems_b__169_0_Internal_Boolean_Int32_0;

			// Token: 0x040082CB RID: 33483
			private static readonly IntPtr NativeMethodInfoPtr__ClearAllItems_b__169_1_Internal_String_Int32_0;

			// Token: 0x040082CC RID: 33484
			private static readonly IntPtr NativeMethodInfoPtr__ClearAllItems_b__169_2_Internal_Void_Int32_0;

			// Token: 0x040082CD RID: 33485
			private static readonly IntPtr NativeMethodInfoPtr__GetAllClothes_b__171_0_Internal_Clothes_Int32_0;

			// Token: 0x040082CE RID: 33486
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDecorations_b__172_0_Internal_Decoration_Int32_0;

			// Token: 0x040082CF RID: 33487
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecords_b__173_0_Internal_Record_Int32_0;

			// Token: 0x040082D0 RID: 33488
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrophies_b__174_0_Internal_Trophy_Int32_0;

			// Token: 0x040082D1 RID: 33489
			private static readonly IntPtr NativeMethodInfoPtr__TrophyInRange_b__175_0_Internal_Void_Int32_0;

			// Token: 0x040082D2 RID: 33490
			private static readonly IntPtr NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_0_Internal_String_Int32_0;

			// Token: 0x040082D3 RID: 33491
			private static readonly IntPtr NativeMethodInfoPtr__DeleteAllItemsBeforeWork_b__177_1_Internal_Void_Int32_0;

			// Token: 0x040082D4 RID: 33492
			private static readonly IntPtr NativeMethodInfoPtr__RecipeInRange_b__180_0_Internal_Void_Int32_0;

			// Token: 0x040082D5 RID: 33493
			private static readonly IntPtr NativeMethodInfoPtr__RecipeInRange_b__180_1_Internal_Void_Int32_0;

			// Token: 0x040082D6 RID: 33494
			private static readonly IntPtr NativeMethodInfoPtr__RecipeInRange_b__180_2_Internal_Void_Int32_0;

			// Token: 0x040082D7 RID: 33495
			private static readonly IntPtr NativeMethodInfoPtr__GetAllRecipes_b__183_0_Internal_Recipe_Int32_0;

			// Token: 0x040082D8 RID: 33496
			private static readonly IntPtr NativeMethodInfoPtr__IzakayaIn_b__187_0_Internal_Void_Int32_0;

			// Token: 0x040082D9 RID: 33497
			private static readonly IntPtr NativeMethodInfoPtr__IzakayaInRange_b__188_0_Internal_Void_Int32_0;

			// Token: 0x040082DA RID: 33498
			private static readonly IntPtr NativeMethodInfoPtr__PartnerIn_b__192_0_Internal_Void_Int32_0;

			// Token: 0x040082DB RID: 33499
			private static readonly IntPtr NativeMethodInfoPtr__GetAllIzakayas_b__193_0_Internal_Izakaya_Int32_0;

			// Token: 0x040082DC RID: 33500
			private static readonly IntPtr NativeMethodInfoPtr__ClearOutdatedFoods_b__194_0_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0;
		}

		// Token: 0x02000A92 RID: 2706
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass92_0")]
		public sealed class __c__DisplayClass92_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBB3 RID: 52147 RVA: 0x00324968 File Offset: 0x00322B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass92_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass92_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass92_0.NativeFieldInfoPtr_ignoreId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr, "ignoreId");
				RunTimeStorage.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr, 100677182);
				RunTimeStorage.__c__DisplayClass92_0.NativeMethodInfoPtr__ForceObjectsNum_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr, 100677183);
			}

			// Token: 0x0600CBB4 RID: 52148 RVA: 0x003249D0 File Offset: 0x00322BD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass92_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass92_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBB5 RID: 52149 RVA: 0x00324A0C File Offset: 0x00322C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181167, XrefRangeEnd = 181171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ForceObjectsNum_b__0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass92_0.NativeMethodInfoPtr__ForceObjectsNum_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBB6 RID: 52150 RVA: 0x0006D609 File Offset: 0x0006B809
			public __c__DisplayClass92_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004224 RID: 16932
			// (get) Token: 0x0600CBB7 RID: 52151 RVA: 0x00324A60 File Offset: 0x00322C60
			// (set) Token: 0x0600CBB8 RID: 52152 RVA: 0x0006D612 File Offset: 0x0006B812
			public unsafe Il2CppStructArray<int> ignoreId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass92_0.NativeFieldInfoPtr_ignoreId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass92_0.NativeFieldInfoPtr_ignoreId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082DD RID: 33501
			private static readonly IntPtr NativeFieldInfoPtr_ignoreId;

			// Token: 0x040082DE RID: 33502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082DF RID: 33503
			private static readonly IntPtr NativeMethodInfoPtr__ForceObjectsNum_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000A93 RID: 2707
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__101`1")]
		[Serializable]
		public sealed class __c__101<T> : Il2CppSystem.Object
		{
			// Token: 0x0600CBB9 RID: 52153 RVA: 0x00324A90 File Offset: 0x00322C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__101()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__101`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr);
				RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr, "<>9");
				RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr, "<>9__101_0");
				RunTimeStorage.__c__101<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr, 100677185);
				RunTimeStorage.__c__101<T>.NativeMethodInfoPtr__ObjectInRange_b__101_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr, 100677186);
			}

			// Token: 0x0600CBBA RID: 52154 RVA: 0x00324B48 File Offset: 0x00322D48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__101() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__101<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__101<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBBB RID: 52155 RVA: 0x00324B84 File Offset: 0x00322D84
			[CallerCount(0)]
			public unsafe int _ObjectInRange_b__101_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__101<T>.NativeMethodInfoPtr__ObjectInRange_b__101_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBBC RID: 52156 RVA: 0x0006D631 File Offset: 0x0006B831
			public __c__101(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004225 RID: 16933
			// (get) Token: 0x0600CBBD RID: 52157 RVA: 0x00324BD0 File Offset: 0x00322DD0
			// (set) Token: 0x0600CBBE RID: 52158 RVA: 0x0006D63A File Offset: 0x0006B83A
			public unsafe static RunTimeStorage.__c__101<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.__c__101<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004226 RID: 16934
			// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x00324BF8 File Offset: 0x00322DF8
			// (set) Token: 0x0600CBC0 RID: 52160 RVA: 0x0006D64C File Offset: 0x0006B84C
			public unsafe static Func<int, int> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c__101<T>.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082E0 RID: 33504
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040082E1 RID: 33505
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x040082E2 RID: 33506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082E3 RID: 33507
			private static readonly IntPtr NativeMethodInfoPtr__ObjectInRange_b__101_0_Internal_Int32_Int32_0;
		}

		// Token: 0x02000A94 RID: 2708
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass105_0`1")]
		public sealed class __c__DisplayClass105_0<T> : Il2CppSystem.Object
		{
			// Token: 0x0600CBC1 RID: 52161 RVA: 0x00324C20 File Offset: 0x00322E20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass105_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass105_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_infiniteResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr, "infiniteResolver");
				RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_objectReferenceMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr, "objectReferenceMethod");
				RunTimeStorage.__c__DisplayClass105_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr, 100677187);
				RunTimeStorage.__c__DisplayClass105_0<T>.NativeMethodInfoPtr__GetObject_b__1_Internal_KeyValuePair_2_T_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr, 100677188);
			}

			// Token: 0x0600CBC2 RID: 52162 RVA: 0x00324CD8 File Offset: 0x00322ED8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass105_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass105_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass105_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBC3 RID: 52163 RVA: 0x00324D14 File Offset: 0x00322F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181171, XrefRangeEnd = 181174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<T, int> _GetObject_b__1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass105_0<T>.NativeMethodInfoPtr__GetObject_b__1_Internal_KeyValuePair_2_T_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<T, int>(pointer);
			}

			// Token: 0x0600CBC4 RID: 52164 RVA: 0x0006D65E File Offset: 0x0006B85E
			public __c__DisplayClass105_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004227 RID: 16935
			// (get) Token: 0x0600CBC5 RID: 52165 RVA: 0x00324D64 File Offset: 0x00322F64
			// (set) Token: 0x0600CBC6 RID: 52166 RVA: 0x0006D667 File Offset: 0x0006B867
			public unsafe Predicate<int> infiniteResolver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_infiniteResolver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_infiniteResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004228 RID: 16936
			// (get) Token: 0x0600CBC7 RID: 52167 RVA: 0x00324D94 File Offset: 0x00322F94
			// (set) Token: 0x0600CBC8 RID: 52168 RVA: 0x0006D686 File Offset: 0x0006B886
			public unsafe Func<int, T> objectReferenceMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_objectReferenceMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass105_0<T>.NativeFieldInfoPtr_objectReferenceMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082E4 RID: 33508
			private static readonly IntPtr NativeFieldInfoPtr_infiniteResolver;

			// Token: 0x040082E5 RID: 33509
			private static readonly IntPtr NativeFieldInfoPtr_objectReferenceMethod;

			// Token: 0x040082E6 RID: 33510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082E7 RID: 33511
			private static readonly IntPtr NativeMethodInfoPtr__GetObject_b__1_Internal_KeyValuePair_2_T_Int32_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000A95 RID: 2709
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__105`1")]
		[Serializable]
		public sealed class __c__105<T> : Il2CppSystem.Object
		{
			// Token: 0x0600CBC9 RID: 52169 RVA: 0x00324DC4 File Offset: 0x00322FC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__105()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__105`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr);
				RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr, "<>9");
				RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9__105_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr, "<>9__105_0");
				RunTimeStorage.__c__105<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr, 100677190);
				RunTimeStorage.__c__105<T>.NativeMethodInfoPtr__GetObject_b__105_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr, 100677191);
			}

			// Token: 0x0600CBCA RID: 52170 RVA: 0x00324E7C File Offset: 0x0032307C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__105() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__105<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__105<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBCB RID: 52171 RVA: 0x00324EB8 File Offset: 0x003230B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181174, XrefRangeEnd = 181175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetObject_b__105_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__105<T>.NativeMethodInfoPtr__GetObject_b__105_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBCC RID: 52172 RVA: 0x0006D6A5 File Offset: 0x0006B8A5
			public __c__105(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004229 RID: 16937
			// (get) Token: 0x0600CBCD RID: 52173 RVA: 0x00324F0C File Offset: 0x0032310C
			// (set) Token: 0x0600CBCE RID: 52174 RVA: 0x0006D6AE File Offset: 0x0006B8AE
			public unsafe static RunTimeStorage.__c__105<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.__c__105<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0600CBCF RID: 52175 RVA: 0x00324F34 File Offset: 0x00323134
			// (set) Token: 0x0600CBD0 RID: 52176 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
			public unsafe static Func<KeyValuePair<int, int>, int> __9__105_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9__105_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeStorage.__c__105<T>.NativeFieldInfoPtr___9__105_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082E8 RID: 33512
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040082E9 RID: 33513
			private static readonly IntPtr NativeFieldInfoPtr___9__105_0;

			// Token: 0x040082EA RID: 33514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082EB RID: 33515
			private static readonly IntPtr NativeMethodInfoPtr__GetObject_b__105_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000A96 RID: 2710
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass106_0")]
		public sealed class __c__DisplayClass106_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBD1 RID: 52177 RVA: 0x00324F5C File Offset: 0x0032315C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass106_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass106_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_objectTagAccessMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr, "objectTagAccessMethod");
				RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr, "tag");
				RunTimeStorage.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr, 100677192);
				RunTimeStorage.__c__DisplayClass106_0.NativeMethodInfoPtr__TryGetObjectByTag_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr, 100677193);
			}

			// Token: 0x0600CBD2 RID: 52178 RVA: 0x00324FD8 File Offset: 0x003231D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass106_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass106_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass106_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBD3 RID: 52179 RVA: 0x00325014 File Offset: 0x00323214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181175, XrefRangeEnd = 181180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetObjectByTag_b__1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass106_0.NativeMethodInfoPtr__TryGetObjectByTag_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBD4 RID: 52180 RVA: 0x0006D6D2 File Offset: 0x0006B8D2
			public __c__DisplayClass106_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0600CBD5 RID: 52181 RVA: 0x00325068 File Offset: 0x00323268
			// (set) Token: 0x0600CBD6 RID: 52182 RVA: 0x0006D6DB File Offset: 0x0006B8DB
			public unsafe Func<int, Il2CppStructArray<int>> objectTagAccessMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_objectTagAccessMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_objectTagAccessMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422C RID: 16940
			// (get) Token: 0x0600CBD7 RID: 52183 RVA: 0x00325098 File Offset: 0x00323298
			// (set) Token: 0x0600CBD8 RID: 52184 RVA: 0x0006D6FA File Offset: 0x0006B8FA
			public unsafe int tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_tag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass106_0.NativeFieldInfoPtr_tag)) = value;
				}
			}

			// Token: 0x040082EC RID: 33516
			private static readonly IntPtr NativeFieldInfoPtr_objectTagAccessMethod;

			// Token: 0x040082ED RID: 33517
			private static readonly IntPtr NativeFieldInfoPtr_tag;

			// Token: 0x040082EE RID: 33518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082EF RID: 33519
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByTag_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000A97 RID: 2711
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass107_0")]
		public sealed class __c__DisplayClass107_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBD9 RID: 52185 RVA: 0x003250C0 File Offset: 0x003232C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass107_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass107_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_objectTagAccessMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr, "objectTagAccessMethod");
				RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr, "level");
				RunTimeStorage.__c__DisplayClass107_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr, 100677194);
				RunTimeStorage.__c__DisplayClass107_0.NativeMethodInfoPtr__TryGetObjectByLevel_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr, 100677195);
			}

			// Token: 0x0600CBDA RID: 52186 RVA: 0x0032513C File Offset: 0x0032333C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass107_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass107_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass107_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBDB RID: 52187 RVA: 0x00325178 File Offset: 0x00323378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181180, XrefRangeEnd = 181181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetObjectByLevel_b__1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass107_0.NativeMethodInfoPtr__TryGetObjectByLevel_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBDC RID: 52188 RVA: 0x0006D715 File Offset: 0x0006B915
			public __c__DisplayClass107_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422D RID: 16941
			// (get) Token: 0x0600CBDD RID: 52189 RVA: 0x003251CC File Offset: 0x003233CC
			// (set) Token: 0x0600CBDE RID: 52190 RVA: 0x0006D71E File Offset: 0x0006B91E
			public unsafe Func<int, int> objectTagAccessMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_objectTagAccessMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_objectTagAccessMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422E RID: 16942
			// (get) Token: 0x0600CBDF RID: 52191 RVA: 0x003251FC File Offset: 0x003233FC
			// (set) Token: 0x0600CBE0 RID: 52192 RVA: 0x0006D73D File Offset: 0x0006B93D
			public unsafe int level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass107_0.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x040082F0 RID: 33520
			private static readonly IntPtr NativeFieldInfoPtr_objectTagAccessMethod;

			// Token: 0x040082F1 RID: 33521
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x040082F2 RID: 33522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082F3 RID: 33523
			private static readonly IntPtr NativeMethodInfoPtr__TryGetObjectByLevel_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000A98 RID: 2712
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass134_0")]
		public sealed class __c__DisplayClass134_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBE1 RID: 52193 RVA: 0x00325224 File Offset: 0x00323424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass134_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass134_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass134_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr, "id");
				RunTimeStorage.__c__DisplayClass134_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr, 100677196);
				RunTimeStorage.__c__DisplayClass134_0.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__2_Internal_Boolean_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr, 100677197);
			}

			// Token: 0x0600CBE2 RID: 52194 RVA: 0x0032528C File Offset: 0x0032348C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass134_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass134_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass134_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBE3 RID: 52195 RVA: 0x003252C8 File Offset: 0x003234C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181181, XrefRangeEnd = 181183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetInfiniteIngredientResolver_b__2(Nullable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass134_0.NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__2_Internal_Boolean_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBE4 RID: 52196 RVA: 0x0006D758 File Offset: 0x0006B958
			public __c__DisplayClass134_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422F RID: 16943
			// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x0032531C File Offset: 0x0032351C
			// (set) Token: 0x0600CBE6 RID: 52198 RVA: 0x0006D761 File Offset: 0x0006B961
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass134_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass134_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x040082F4 RID: 33524
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040082F5 RID: 33525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082F6 RID: 33526
			private static readonly IntPtr NativeMethodInfoPtr__TryGetInfiniteIngredientResolver_b__2_Internal_Boolean_Nullable_1_Int32_0;
		}

		// Token: 0x02000A99 RID: 2713
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass144_0")]
		public sealed class __c__DisplayClass144_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBE7 RID: 52199 RVA: 0x00325344 File Offset: 0x00323544
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass144_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass144_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass144_0.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr, "collection");
				RunTimeStorage.__c__DisplayClass144_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr, 100677198);
				RunTimeStorage.__c__DisplayClass144_0.NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__1_Internal_Boolean_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr, 100677199);
			}

			// Token: 0x0600CBE8 RID: 52200 RVA: 0x003253AC File Offset: 0x003235AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass144_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass144_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass144_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBE9 RID: 52201 RVA: 0x003253E8 File Offset: 0x003235E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181183, XrefRangeEnd = 181194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ContainsAllFollowingIngredients_b__1(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass144_0.NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__1_Internal_Boolean_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBEA RID: 52202 RVA: 0x0006D77C File Offset: 0x0006B97C
			public __c__DisplayClass144_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004230 RID: 16944
			// (get) Token: 0x0600CBEB RID: 52203 RVA: 0x00325438 File Offset: 0x00323638
			// (set) Token: 0x0600CBEC RID: 52204 RVA: 0x0006D785 File Offset: 0x0006B985
			public unsafe Predicate<int> collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass144_0.NativeFieldInfoPtr_collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass144_0.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082F7 RID: 33527
			private static readonly IntPtr NativeFieldInfoPtr_collection;

			// Token: 0x040082F8 RID: 33528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082F9 RID: 33529
			private static readonly IntPtr NativeMethodInfoPtr__ContainsAllFollowingIngredients_b__1_Internal_Boolean_IGrouping_2_Int32_Int32_0;
		}

		// Token: 0x02000A9A RID: 2714
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass156_0")]
		public sealed class __c__DisplayClass156_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBED RID: 52205 RVA: 0x00325468 File Offset: 0x00323668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass156_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass156_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass156_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr, "key");
				RunTimeStorage.__c__DisplayClass156_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr, 100677200);
				RunTimeStorage.__c__DisplayClass156_0.NativeMethodInfoPtr__CountItem_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr, 100677201);
			}

			// Token: 0x0600CBEE RID: 52206 RVA: 0x003254D0 File Offset: 0x003236D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass156_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass156_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass156_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBEF RID: 52207 RVA: 0x0032550C File Offset: 0x0032370C
			[CallerCount(0)]
			public unsafe bool _CountItem_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass156_0.NativeMethodInfoPtr__CountItem_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBF0 RID: 52208 RVA: 0x0006D7A4 File Offset: 0x0006B9A4
			public __c__DisplayClass156_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004231 RID: 16945
			// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x00325558 File Offset: 0x00323758
			// (set) Token: 0x0600CBF2 RID: 52210 RVA: 0x0006D7AD File Offset: 0x0006B9AD
			public unsafe int key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass156_0.NativeFieldInfoPtr_key);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass156_0.NativeFieldInfoPtr_key)) = value;
				}
			}

			// Token: 0x040082FA RID: 33530
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040082FB RID: 33531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082FC RID: 33532
			private static readonly IntPtr NativeMethodInfoPtr__CountItem_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A9B RID: 2715
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBF3 RID: 52211 RVA: 0x00325580 File Offset: 0x00323780
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass182_0.NativeFieldInfoPtr_recipeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr, "recipeIds");
				RunTimeStorage.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr, 100677202);
				RunTimeStorage.__c__DisplayClass182_0.NativeMethodInfoPtr__RecipeOutRange_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr, 100677203);
			}

			// Token: 0x0600CBF4 RID: 52212 RVA: 0x003255E8 File Offset: 0x003237E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass182_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBF5 RID: 52213 RVA: 0x00325624 File Offset: 0x00323824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181194, XrefRangeEnd = 181197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RecipeOutRange_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass182_0.NativeMethodInfoPtr__RecipeOutRange_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBF6 RID: 52214 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
			public __c__DisplayClass182_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004232 RID: 16946
			// (get) Token: 0x0600CBF7 RID: 52215 RVA: 0x00325670 File Offset: 0x00323870
			// (set) Token: 0x0600CBF8 RID: 52216 RVA: 0x0006D7D1 File Offset: 0x0006B9D1
			public unsafe Il2CppStructArray<int> recipeIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass182_0.NativeFieldInfoPtr_recipeIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass182_0.NativeFieldInfoPtr_recipeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082FD RID: 33533
			private static readonly IntPtr NativeFieldInfoPtr_recipeIds;

			// Token: 0x040082FE RID: 33534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040082FF RID: 33535
			private static readonly IntPtr NativeMethodInfoPtr__RecipeOutRange_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A9C RID: 2716
		[ObfuscatedName("GameData.RunTime.Common.RunTimeStorage+<>c__DisplayClass185_0")]
		public sealed class __c__DisplayClass185_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBF9 RID: 52217 RVA: 0x003256A0 File Offset: 0x003238A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass185_0()
			{
				Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr, "<>c__DisplayClass185_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr);
				RunTimeStorage.__c__DisplayClass185_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr, "type");
				RunTimeStorage.__c__DisplayClass185_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr, 100677204);
				RunTimeStorage.__c__DisplayClass185_0.NativeMethodInfoPtr__GetRecipesByCookerType_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr, 100677205);
			}

			// Token: 0x0600CBFA RID: 52218 RVA: 0x00325708 File Offset: 0x00323908
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass185_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeStorage.__c__DisplayClass185_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass185_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBFB RID: 52219 RVA: 0x00325744 File Offset: 0x00323944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181197, XrefRangeEnd = 181202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRecipesByCookerType_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeStorage.__c__DisplayClass185_0.NativeMethodInfoPtr__GetRecipesByCookerType_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBFC RID: 52220 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
			public __c__DisplayClass185_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004233 RID: 16947
			// (get) Token: 0x0600CBFD RID: 52221 RVA: 0x00325790 File Offset: 0x00323990
			// (set) Token: 0x0600CBFE RID: 52222 RVA: 0x0006D7F9 File Offset: 0x0006B9F9
			public unsafe IEnumerable<Cooker.CookerType> type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass185_0.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeStorage.__c__DisplayClass185_0.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008300 RID: 33536
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008301 RID: 33537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008302 RID: 33538
			private static readonly IntPtr NativeMethodInfoPtr__GetRecipesByCookerType_b__0_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000A9D RID: 2717
		private sealed class MethodInfoStoreGeneric_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_T_Action_1_Int32_Boolean_Action_2_T_Int32_Predicate_1_Int32_0<T>
		{
			// Token: 0x04008303 RID: 33539
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RunTimeStorage.NativeMethodInfoPtr_ObjectInRange_Private_Static_Void_Dictionary_2_Int32_Int32_IEnumerable_1_Int32_Func_2_Int32_T_Action_1_Int32_Boolean_Action_2_T_Int32_Predicate_1_Int32_0, Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A9E RID: 2718
		private sealed class MethodInfoStoreGeneric_GetObject_Private_Static_Il2CppReferenceArray_1_KeyValuePair_2_T_Int32_Dictionary_2_Int32_Int32_Func_2_Int32_T_Predicate_1_Int32_0<T>
		{
			// Token: 0x04008304 RID: 33540
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RunTimeStorage.NativeMethodInfoPtr_GetObject_Private_Static_Il2CppReferenceArray_1_KeyValuePair_2_T_Int32_Dictionary_2_Int32_Int32_Func_2_Int32_T_Predicate_1_Int32_0, Il2CppClassPointerStore<RunTimeStorage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
