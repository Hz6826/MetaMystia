using System;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using NightScene.EventUtility;
using Story;
using UnityEngine;

namespace GameData.RunTime.NightSceneUtility
{
	// Token: 0x0200021F RID: 543
	public class IzakayaConfigure : Singleton<IzakayaConfigure>
	{
		// Token: 0x06004015 RID: 16405 RVA: 0x00179314 File Offset: 0x00177514
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaConfigure()
		{
			Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.NightSceneUtility", "IzakayaConfigure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr);
			IzakayaConfigure.NativeFieldInfoPtr_DefaultRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "DefaultRecipe");
			IzakayaConfigure.NativeFieldInfoPtr_DefaultBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "DefaultBev");
			IzakayaConfigure.NativeFieldInfoPtr_specialGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "specialGuestPool");
			IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestPoolIdentityData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<SpecialGuestPoolIdentityData>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__IzakayaData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<IzakayaData>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__CookerConfigure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<CookerConfigure>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__DailyRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<DailyRecipes>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__DailyBeverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<DailyBeverages>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__PopNotHateRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<PopNotHateRecipes>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__PopNotHateBeverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<PopNotHateBeverages>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__CheapestRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<CheapestRecipes>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__CheapestBeverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<CheapestBeverages>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveRecipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<TheMostExpensiveRecipes>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveBeverages_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<TheMostExpensiveBeverages>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__StoredFoods_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<StoredFoods>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__NormalGuestPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<NormalGuestPool>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__NormalGuestInterval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<NormalGuestInterval>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__SpawnPasserbyGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<SpawnPasserbyGuest>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__PasserbyGuestSpanInterval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<PasserbyGuestSpanInterval>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__BaseRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<BaseRange>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__Map_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<Map>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestGachaInterval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<SpecialGuestGachaInterval>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr_m_HasSpawnedSpecialGuestTonight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "m_HasSpawnedSpecialGuestTonight");
			IzakayaConfigure.NativeFieldInfoPtr__ExtraStoreFoodCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<ExtraStoreFoodCallback>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__ExtraAbandonFoodCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<ExtraAbandonFoodCallback>k__BackingField");
			IzakayaConfigure.NativeFieldInfoPtr__ExtraRemoveStoredFoodCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<ExtraRemoveStoredFoodCallback>k__BackingField");
			IzakayaConfigure.NativeMethodInfoPtr_get_SpecialGuestPoolIdentityData_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675347);
			IzakayaConfigure.NativeMethodInfoPtr_set_SpecialGuestPoolIdentityData_Private_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675348);
			IzakayaConfigure.NativeMethodInfoPtr_get_IzakayaData_Public_get_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675349);
			IzakayaConfigure.NativeMethodInfoPtr_set_IzakayaData_Private_set_Void_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675350);
			IzakayaConfigure.NativeMethodInfoPtr_get_CookerConfigure_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675351);
			IzakayaConfigure.NativeMethodInfoPtr_set_CookerConfigure_Private_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675352);
			IzakayaConfigure.NativeMethodInfoPtr_get_EmptyRecipeSlotCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675353);
			IzakayaConfigure.NativeMethodInfoPtr_get_EmptyBeverageSlotCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675354);
			IzakayaConfigure.NativeMethodInfoPtr_get_DailyRecipes_Public_get_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675355);
			IzakayaConfigure.NativeMethodInfoPtr_set_DailyRecipes_Private_set_Void_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675356);
			IzakayaConfigure.NativeMethodInfoPtr_get_DailyBeverages_Public_get_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675357);
			IzakayaConfigure.NativeMethodInfoPtr_set_DailyBeverages_Private_set_Void_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675358);
			IzakayaConfigure.NativeMethodInfoPtr_get_PopNotHateRecipes_Public_get_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675359);
			IzakayaConfigure.NativeMethodInfoPtr_set_PopNotHateRecipes_Private_set_Void_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675360);
			IzakayaConfigure.NativeMethodInfoPtr_get_PopNotHateBeverages_Public_get_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675361);
			IzakayaConfigure.NativeMethodInfoPtr_set_PopNotHateBeverages_Private_set_Void_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675362);
			IzakayaConfigure.NativeMethodInfoPtr_get_CheapestRecipes_Public_get_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675363);
			IzakayaConfigure.NativeMethodInfoPtr_set_CheapestRecipes_Private_set_Void_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675364);
			IzakayaConfigure.NativeMethodInfoPtr_get_CheapestBeverages_Public_get_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675365);
			IzakayaConfigure.NativeMethodInfoPtr_set_CheapestBeverages_Private_set_Void_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675366);
			IzakayaConfigure.NativeMethodInfoPtr_get_TheMostExpensiveRecipes_Public_get_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675367);
			IzakayaConfigure.NativeMethodInfoPtr_set_TheMostExpensiveRecipes_Private_set_Void_List_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675368);
			IzakayaConfigure.NativeMethodInfoPtr_get_TheMostExpensiveBeverages_Public_get_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675369);
			IzakayaConfigure.NativeMethodInfoPtr_set_TheMostExpensiveBeverages_Private_set_Void_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675370);
			IzakayaConfigure.NativeMethodInfoPtr_get_StoredFoods_Private_get_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675371);
			IzakayaConfigure.NativeMethodInfoPtr_set_StoredFoods_Private_set_Void_List_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675372);
			IzakayaConfigure.NativeMethodInfoPtr_get_BatchedStoredFoods_Public_get_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675373);
			IzakayaConfigure.NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675374);
			IzakayaConfigure.NativeMethodInfoPtr_set_NormalGuestPool_Private_set_Void_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675375);
			IzakayaConfigure.NativeMethodInfoPtr_get_NormalGuestInterval_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675376);
			IzakayaConfigure.NativeMethodInfoPtr_set_NormalGuestInterval_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675377);
			IzakayaConfigure.NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675378);
			IzakayaConfigure.NativeMethodInfoPtr_set_SpawnPasserbyGuest_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675379);
			IzakayaConfigure.NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675380);
			IzakayaConfigure.NativeMethodInfoPtr_set_PasserbyGuestSpanInterval_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675381);
			IzakayaConfigure.NativeMethodInfoPtr_get_BaseRange_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675382);
			IzakayaConfigure.NativeMethodInfoPtr_set_BaseRange_Private_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675383);
			IzakayaConfigure.NativeMethodInfoPtr_get_Map_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675384);
			IzakayaConfigure.NativeMethodInfoPtr_set_Map_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675385);
			IzakayaConfigure.NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675386);
			IzakayaConfigure.NativeMethodInfoPtr_set_SpecialGuestGachaInterval_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675387);
			IzakayaConfigure.NativeMethodInfoPtr_get_CanGacha_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675388);
			IzakayaConfigure.NativeMethodInfoPtr_get_RemainingGuestPool_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675389);
			IzakayaConfigure.NativeMethodInfoPtr_UpdateValue_Public_Void_Vector2Int_Vector2_IEnumerable_1_NormalGuestGroup_Single_IEnumerable_1_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675390);
			IzakayaConfigure.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675391);
			IzakayaConfigure.NativeMethodInfoPtr_Initialize_Public_Void_Izakaya_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675392);
			IzakayaConfigure.NativeMethodInfoPtr_LoadLockedMissionRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675393);
			IzakayaConfigure.NativeMethodInfoPtr_CalculateSpecialGuestPool_Private_Void_String_IEnumerable_1_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675394);
			IzakayaConfigure.NativeMethodInfoPtr_GetStoredFoods_Public_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675395);
			IzakayaConfigure.NativeMethodInfoPtr_get_ExtraStoreFoodCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675396);
			IzakayaConfigure.NativeMethodInfoPtr_set_ExtraStoreFoodCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675397);
			IzakayaConfigure.NativeMethodInfoPtr_get_ExtraAbandonFoodCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675398);
			IzakayaConfigure.NativeMethodInfoPtr_set_ExtraAbandonFoodCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675399);
			IzakayaConfigure.NativeMethodInfoPtr_get_ExtraRemoveStoredFoodCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675400);
			IzakayaConfigure.NativeMethodInfoPtr_set_ExtraRemoveStoredFoodCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675401);
			IzakayaConfigure.NativeMethodInfoPtr_StoreFood_Public_Void_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675402);
			IzakayaConfigure.NativeMethodInfoPtr_RemoveStoredFood_Public_Void_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675403);
			IzakayaConfigure.NativeMethodInfoPtr_PreCalculateRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675404);
			IzakayaConfigure.NativeMethodInfoPtr_OverrideCookers_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675405);
			IzakayaConfigure.NativeMethodInfoPtr_OverrideRecipes_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675406);
			IzakayaConfigure.NativeMethodInfoPtr_RecordIzakayaMenuSelection_Public_Void_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675407);
			IzakayaConfigure.NativeMethodInfoPtr_RegisterToDailyRecipes_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675408);
			IzakayaConfigure.NativeMethodInfoPtr_LogoffFromDailyRecipes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675409);
			IzakayaConfigure.NativeMethodInfoPtr_IsDailyRecipeFood_Public_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675410);
			IzakayaConfigure.NativeMethodInfoPtr_RegisterToDailyBeverages_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675411);
			IzakayaConfigure.NativeMethodInfoPtr_LogoffFromDailyBeverages_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675412);
			IzakayaConfigure.NativeMethodInfoPtr_RegisterToCookers_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675413);
			IzakayaConfigure.NativeMethodInfoPtr_LogOffFromCookers_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675414);
			IzakayaConfigure.NativeMethodInfoPtr_Gacha_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675415);
			IzakayaConfigure.NativeMethodInfoPtr_SetThisGuestHasSpawned_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675416);
			IzakayaConfigure.NativeMethodInfoPtr_CheckThisGuestHasSpawnedTonight_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675417);
			IzakayaConfigure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675418);
			IzakayaConfigure.NativeMethodInfoPtr__LoadLockedMissionRecipes_b__93_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, 100675419);
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x00179B00 File Offset: 0x00177D00
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x00179B40 File Offset: 0x00177D40
		public unsafe Il2CppStructArray<int> SpecialGuestPoolIdentityData
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_SpecialGuestPoolIdentityData_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157624, XrefRangeEnd = 157625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_SpecialGuestPoolIdentityData_Private_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x00179B84 File Offset: 0x00177D84
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x00179BC4 File Offset: 0x00177DC4
		public unsafe Izakaya IzakayaData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_IzakayaData_Public_get_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_IzakayaData_Private_set_Void_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x00179C08 File Offset: 0x00177E08
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x00179C48 File Offset: 0x00177E48
		public unsafe Il2CppStructArray<int> CookerConfigure
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_CookerConfigure_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_CookerConfigure_Private_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x00179C8C File Offset: 0x00177E8C
		public unsafe int EmptyRecipeSlotCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 157635, RefRangeEnd = 157638, XrefRangeStart = 157629, XrefRangeEnd = 157635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_EmptyRecipeSlotCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x00179CC8 File Offset: 0x00177EC8
		public unsafe int EmptyBeverageSlotCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 157644, RefRangeEnd = 157647, XrefRangeStart = 157638, XrefRangeEnd = 157644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_EmptyBeverageSlotCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x00179D04 File Offset: 0x00177F04
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x00179D44 File Offset: 0x00177F44
		public unsafe List<Recipe> DailyRecipes
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_DailyRecipes_Public_get_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_DailyRecipes_Private_set_Void_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x00179D88 File Offset: 0x00177F88
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x00179DC8 File Offset: 0x00177FC8
		public unsafe List<Sellable> DailyBeverages
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_DailyBeverages_Public_get_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_DailyBeverages_Private_set_Void_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x00179E0C File Offset: 0x0017800C
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x00179E4C File Offset: 0x0017804C
		public unsafe List<Recipe> PopNotHateRecipes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_PopNotHateRecipes_Public_get_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_PopNotHateRecipes_Private_set_Void_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x00179E90 File Offset: 0x00178090
		// (set) Token: 0x06004025 RID: 16421 RVA: 0x00179ED0 File Offset: 0x001780D0
		public unsafe List<Sellable> PopNotHateBeverages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_PopNotHateBeverages_Public_get_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157648, RefRangeEnd = 157649, XrefRangeStart = 157647, XrefRangeEnd = 157648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_PopNotHateBeverages_Private_set_Void_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x00179F14 File Offset: 0x00178114
		// (set) Token: 0x06004027 RID: 16423 RVA: 0x00179F54 File Offset: 0x00178154
		public unsafe List<Recipe> CheapestRecipes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_CheapestRecipes_Public_get_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_CheapestRecipes_Private_set_Void_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06004028 RID: 16424 RVA: 0x00179F98 File Offset: 0x00178198
		// (set) Token: 0x06004029 RID: 16425 RVA: 0x00179FD8 File Offset: 0x001781D8
		public unsafe List<Sellable> CheapestBeverages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_CheapestBeverages_Public_get_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_CheapestBeverages_Private_set_Void_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x0017A01C File Offset: 0x0017821C
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x0017A05C File Offset: 0x0017825C
		public unsafe List<Recipe> TheMostExpensiveRecipes
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_TheMostExpensiveRecipes_Public_get_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_TheMostExpensiveRecipes_Private_set_Void_List_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600402C RID: 16428 RVA: 0x0017A0A0 File Offset: 0x001782A0
		// (set) Token: 0x0600402D RID: 16429 RVA: 0x0017A0E0 File Offset: 0x001782E0
		public unsafe List<Sellable> TheMostExpensiveBeverages
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_TheMostExpensiveBeverages_Public_get_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_TheMostExpensiveBeverages_Private_set_Void_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600402E RID: 16430 RVA: 0x0017A124 File Offset: 0x00178324
		// (set) Token: 0x0600402F RID: 16431 RVA: 0x0017A164 File Offset: 0x00178364
		public unsafe List<Sellable> StoredFoods
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_StoredFoods_Private_get_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_StoredFoods_Private_set_Void_List_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x0017A1A8 File Offset: 0x001783A8
		public unsafe IEnumerable<KeyValuePair<Sellable, int>> BatchedStoredFoods
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 157689, RefRangeEnd = 157691, XrefRangeStart = 157649, XrefRangeEnd = 157689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_BatchedStoredFoods_Public_get_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Sellable, int>>>(intPtr3) : null;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x0017A1E8 File Offset: 0x001783E8
		// (set) Token: 0x06004032 RID: 16434 RVA: 0x0017A228 File Offset: 0x00178428
		public unsafe Il2CppReferenceArray<IEnumerable<NormalGuest>> NormalGuestPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEnumerable<NormalGuest>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_NormalGuestPool_Private_set_Void_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x0017A26C File Offset: 0x0017846C
		// (set) Token: 0x06004034 RID: 16436 RVA: 0x0017A2A8 File Offset: 0x001784A8
		public unsafe Vector2 NormalGuestInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_NormalGuestInterval_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_NormalGuestInterval_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x0017A2E8 File Offset: 0x001784E8
		// (set) Token: 0x06004036 RID: 16438 RVA: 0x0017A324 File Offset: 0x00178524
		public unsafe bool SpawnPasserbyGuest
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157691, RefRangeEnd = 157692, XrefRangeStart = 157691, XrefRangeEnd = 157691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_SpawnPasserbyGuest_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x0017A364 File Offset: 0x00178564
		// (set) Token: 0x06004038 RID: 16440 RVA: 0x0017A3A0 File Offset: 0x001785A0
		public unsafe Vector2 PasserbyGuestSpanInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_PasserbyGuestSpanInterval_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x0017A3E0 File Offset: 0x001785E0
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x0017A41C File Offset: 0x0017861C
		public unsafe Vector2Int BaseRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_BaseRange_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_BaseRange_Private_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600403B RID: 16443 RVA: 0x0017A45C File Offset: 0x0017865C
		// (set) Token: 0x0600403C RID: 16444 RVA: 0x0017A49C File Offset: 0x0017869C
		public unsafe GameObject Map
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_Map_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_Map_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x0017A4E0 File Offset: 0x001786E0
		// (set) Token: 0x0600403E RID: 16446 RVA: 0x0017A51C File Offset: 0x0017871C
		public unsafe float SpecialGuestGachaInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_SpecialGuestGachaInterval_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600403F RID: 16447 RVA: 0x0017A55C File Offset: 0x0017875C
		public unsafe bool CanGacha
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157696, RefRangeEnd = 157697, XrefRangeStart = 157692, XrefRangeEnd = 157696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_CanGacha_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06004040 RID: 16448 RVA: 0x0017A598 File Offset: 0x00178798
		public unsafe IEnumerable<int> RemainingGuestPool
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157697, XrefRangeEnd = 157701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_RemainingGuestPool_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0017A5D8 File Offset: 0x001787D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157725, RefRangeEnd = 157728, XrefRangeStart = 157701, XrefRangeEnd = 157725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(Vector2Int baseFundRange, Vector2 normalGuestInterval, IEnumerable<Izakaya.NormalGuestGroup> normalGuestsPool, float specialGuestGachaInterval, IEnumerable<Izakaya.SpecialGuestGroup> thisSpecialGuestPool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref baseFundRange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestInterval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuestsPool);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestGachaInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisSpecialGuestPool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_UpdateValue_Public_Void_Vector2Int_Vector2_IEnumerable_1_NormalGuestGroup_Single_IEnumerable_1_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x0017A658 File Offset: 0x00178858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157728, XrefRangeEnd = 157738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigure.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0017A694 File Offset: 0x00178894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157849, RefRangeEnd = 157850, XrefRangeStart = 157738, XrefRangeEnd = 157849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Izakaya info, GameObject map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_Initialize_Public_Void_Izakaya_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0017A6E8 File Offset: 0x001788E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157868, RefRangeEnd = 157869, XrefRangeStart = 157850, XrefRangeEnd = 157868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLockedMissionRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_LoadLockedMissionRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0017A71C File Offset: 0x0017891C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158022, RefRangeEnd = 158024, XrefRangeStart = 157869, XrefRangeEnd = 158022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateSpecialGuestPool(string daySceneMapLabel, IEnumerable<Izakaya.SpecialGuestGroup> specialGuestGroups)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(daySceneMapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestGroups);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_CalculateSpecialGuestPool_Private_Void_String_IEnumerable_1_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0017A770 File Offset: 0x00178970
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Sellable> GetStoredFoods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_GetStoredFoods_Public_IEnumerable_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x0017A7B0 File Offset: 0x001789B0
		// (set) Token: 0x06004048 RID: 16456 RVA: 0x0017A7F0 File Offset: 0x001789F0
		public unsafe Action ExtraStoreFoodCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_ExtraStoreFoodCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_ExtraStoreFoodCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06004049 RID: 16457 RVA: 0x0017A834 File Offset: 0x00178A34
		// (set) Token: 0x0600404A RID: 16458 RVA: 0x0017A874 File Offset: 0x00178A74
		public unsafe Action ExtraAbandonFoodCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_ExtraAbandonFoodCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_ExtraAbandonFoodCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x0017A8B8 File Offset: 0x00178AB8
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x0017A8F8 File Offset: 0x00178AF8
		public unsafe Action ExtraRemoveStoredFoodCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_get_ExtraRemoveStoredFoodCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_set_ExtraRemoveStoredFoodCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0017A93C File Offset: 0x00178B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158035, RefRangeEnd = 158038, XrefRangeStart = 158024, XrefRangeEnd = 158035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreFood(Sellable sellable, int messageSender = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageSender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_StoreFood_Public_Void_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0017A98C File Offset: 0x00178B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158045, RefRangeEnd = 158047, XrefRangeStart = 158038, XrefRangeEnd = 158045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStoredFood(Sellable sellable, int messageSender = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageSender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_RemoveStoredFood_Public_Void_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x0017A9DC File Offset: 0x00178BDC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 158231, RefRangeEnd = 158246, XrefRangeStart = 158047, XrefRangeEnd = 158231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreCalculateRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_PreCalculateRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0017AA10 File Offset: 0x00178C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158254, RefRangeEnd = 158255, XrefRangeStart = 158246, XrefRangeEnd = 158254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideCookers(Il2CppStructArray<int> newCookers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCookers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_OverrideCookers_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0017AA54 File Offset: 0x00178C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158284, RefRangeEnd = 158285, XrefRangeStart = 158255, XrefRangeEnd = 158284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideRecipes(Il2CppStructArray<int> newRecipes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newRecipes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_OverrideRecipes_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x0017AA98 File Offset: 0x00178C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158285, XrefRangeEnd = 158332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordIzakayaMenuSelection(PlayerSaveFile.HistoryIzakayaMenuSelection historyMenuSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(historyMenuSelection));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_RecordIzakayaMenuSelection_Public_Void_HistoryIzakayaMenuSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0017AAE0 File Offset: 0x00178CE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 158352, RefRangeEnd = 158358, XrefRangeStart = 158332, XrefRangeEnd = 158352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToDailyRecipes(int id, bool checkPlayerStorage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayerStorage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_RegisterToDailyRecipes_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0017AB2C File Offset: 0x00178D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158384, RefRangeEnd = 158385, XrefRangeStart = 158358, XrefRangeEnd = 158384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogoffFromDailyRecipes(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_LogoffFromDailyRecipes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0017AB6C File Offset: 0x00178D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158399, RefRangeEnd = 158401, XrefRangeStart = 158385, XrefRangeEnd = 158399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDailyRecipeFood(Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_IsDailyRecipeFood_Public_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x0017ABBC File Offset: 0x00178DBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 158421, RefRangeEnd = 158427, XrefRangeStart = 158401, XrefRangeEnd = 158421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToDailyBeverages(int id, bool checkPlayerStorage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayerStorage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_RegisterToDailyBeverages_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x0017AC08 File Offset: 0x00178E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158448, RefRangeEnd = 158449, XrefRangeStart = 158427, XrefRangeEnd = 158448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogoffFromDailyBeverages(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_LogoffFromDailyBeverages_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0017AC48 File Offset: 0x00178E48
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 158450, RefRangeEnd = 158459, XrefRangeStart = 158449, XrefRangeEnd = 158450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToCookers(int id, int index, bool checkPlayerHaveCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayerHaveCooker;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_RegisterToCookers_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0017ACA4 File Offset: 0x00178EA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158460, RefRangeEnd = 158462, XrefRangeStart = 158459, XrefRangeEnd = 158460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogOffFromCookers(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_LogOffFromCookers_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0017ACE4 File Offset: 0x00178EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158462, XrefRangeEnd = 158505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Gacha()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_Gacha_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0017AD20 File Offset: 0x00178F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158505, XrefRangeEnd = 158512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetThisGuestHasSpawned(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_SetThisGuestHasSpawned_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0017AD60 File Offset: 0x00178F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158512, XrefRangeEnd = 158516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckThisGuestHasSpawnedTonight(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr_CheckThisGuestHasSpawnedTonight_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0017ADAC File Offset: 0x00178FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158516, XrefRangeEnd = 158527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaConfigure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0017ADE8 File Offset: 0x00178FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158527, XrefRangeEnd = 158547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadLockedMissionRecipes_b__93_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.NativeMethodInfoPtr__LoadLockedMissionRecipes_b__93_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0002311B File Offset: 0x0002131B
		public IzakayaConfigure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x0017AE28 File Offset: 0x00179028
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x00023124 File Offset: 0x00021324
		public unsafe static int DefaultRecipe
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.NativeFieldInfoPtr_DefaultRecipe, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.NativeFieldInfoPtr_DefaultRecipe, (void*)(&value));
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x0017AE44 File Offset: 0x00179044
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x00023132 File Offset: 0x00021332
		public unsafe static int DefaultBev
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.NativeFieldInfoPtr_DefaultBev, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.NativeFieldInfoPtr_DefaultBev, (void*)(&value));
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x0017AE60 File Offset: 0x00179060
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x00023140 File Offset: 0x00021340
		public unsafe Dictionary<int, Vector2> specialGuestPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr_specialGuestPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr_specialGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x0017AE90 File Offset: 0x00179090
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x0002315F File Offset: 0x0002135F
		public unsafe Il2CppStructArray<int> _SpecialGuestPoolIdentityData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestPoolIdentityData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestPoolIdentityData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x0017AEC0 File Offset: 0x001790C0
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x0002317E File Offset: 0x0002137E
		public unsafe Izakaya _IzakayaData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__IzakayaData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__IzakayaData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x0017AEF0 File Offset: 0x001790F0
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x0002319D File Offset: 0x0002139D
		public unsafe Il2CppStructArray<int> _CookerConfigure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CookerConfigure_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CookerConfigure_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x0017AF20 File Offset: 0x00179120
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x000231BC File Offset: 0x000213BC
		public unsafe List<Recipe> _DailyRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__DailyRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__DailyRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x0017AF50 File Offset: 0x00179150
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x000231DB File Offset: 0x000213DB
		public unsafe List<Sellable> _DailyBeverages_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__DailyBeverages_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__DailyBeverages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x0017AF80 File Offset: 0x00179180
		// (set) Token: 0x06004071 RID: 16497 RVA: 0x000231FA File Offset: 0x000213FA
		public unsafe List<Recipe> _PopNotHateRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PopNotHateRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PopNotHateRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x0017AFB0 File Offset: 0x001791B0
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x00023219 File Offset: 0x00021419
		public unsafe List<Sellable> _PopNotHateBeverages_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PopNotHateBeverages_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PopNotHateBeverages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x0017AFE0 File Offset: 0x001791E0
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x00023238 File Offset: 0x00021438
		public unsafe List<Recipe> _CheapestRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CheapestRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CheapestRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x0017B010 File Offset: 0x00179210
		// (set) Token: 0x06004077 RID: 16503 RVA: 0x00023257 File Offset: 0x00021457
		public unsafe List<Sellable> _CheapestBeverages_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CheapestBeverages_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__CheapestBeverages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x0017B040 File Offset: 0x00179240
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x00023276 File Offset: 0x00021476
		public unsafe List<Recipe> _TheMostExpensiveRecipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveRecipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveRecipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x0017B070 File Offset: 0x00179270
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x00023295 File Offset: 0x00021495
		public unsafe List<Sellable> _TheMostExpensiveBeverages_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveBeverages_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__TheMostExpensiveBeverages_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x0017B0A0 File Offset: 0x001792A0
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x000232B4 File Offset: 0x000214B4
		public unsafe List<Sellable> _StoredFoods_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__StoredFoods_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__StoredFoods_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x0017B0D0 File Offset: 0x001792D0
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x000232D3 File Offset: 0x000214D3
		public unsafe Il2CppReferenceArray<IEnumerable<NormalGuest>> _NormalGuestPool_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__NormalGuestPool_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEnumerable<NormalGuest>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__NormalGuestPool_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x0017B100 File Offset: 0x00179300
		// (set) Token: 0x06004081 RID: 16513 RVA: 0x000232F2 File Offset: 0x000214F2
		public unsafe Vector2 _NormalGuestInterval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__NormalGuestInterval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__NormalGuestInterval_k__BackingField)) = value;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x0017B128 File Offset: 0x00179328
		// (set) Token: 0x06004083 RID: 16515 RVA: 0x0002330D File Offset: 0x0002150D
		public unsafe bool _SpawnPasserbyGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpawnPasserbyGuest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpawnPasserbyGuest_k__BackingField)) = value;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x0017B150 File Offset: 0x00179350
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x00023328 File Offset: 0x00021528
		public unsafe Vector2 _PasserbyGuestSpanInterval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PasserbyGuestSpanInterval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__PasserbyGuestSpanInterval_k__BackingField)) = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x0017B178 File Offset: 0x00179378
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x00023343 File Offset: 0x00021543
		public unsafe Vector2Int _BaseRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__BaseRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__BaseRange_k__BackingField)) = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x0017B1A0 File Offset: 0x001793A0
		// (set) Token: 0x06004089 RID: 16521 RVA: 0x0002335E File Offset: 0x0002155E
		public unsafe GameObject _Map_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__Map_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__Map_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x0017B1D0 File Offset: 0x001793D0
		// (set) Token: 0x0600408B RID: 16523 RVA: 0x0002337D File Offset: 0x0002157D
		public unsafe float _SpecialGuestGachaInterval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestGachaInterval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__SpecialGuestGachaInterval_k__BackingField)) = value;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x0017B1F8 File Offset: 0x001793F8
		// (set) Token: 0x0600408D RID: 16525 RVA: 0x00023398 File Offset: 0x00021598
		public unsafe HashSet<int> m_HasSpawnedSpecialGuestTonight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr_m_HasSpawnedSpecialGuestTonight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr_m_HasSpawnedSpecialGuestTonight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x0017B228 File Offset: 0x00179428
		// (set) Token: 0x0600408F RID: 16527 RVA: 0x000233B7 File Offset: 0x000215B7
		public unsafe Action _ExtraStoreFoodCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraStoreFoodCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraStoreFoodCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x0017B258 File Offset: 0x00179458
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x000233D6 File Offset: 0x000215D6
		public unsafe Action _ExtraAbandonFoodCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraAbandonFoodCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraAbandonFoodCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004092 RID: 16530 RVA: 0x0017B288 File Offset: 0x00179488
		// (set) Token: 0x06004093 RID: 16531 RVA: 0x000233F5 File Offset: 0x000215F5
		public unsafe Action _ExtraRemoveStoredFoodCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraRemoveStoredFoodCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.NativeFieldInfoPtr__ExtraRemoveStoredFoodCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRecipe;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeFieldInfoPtr_DefaultBev;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestPool;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestPoolIdentityData_k__BackingField;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeFieldInfoPtr__IzakayaData_k__BackingField;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeFieldInfoPtr__CookerConfigure_k__BackingField;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeFieldInfoPtr__DailyRecipes_k__BackingField;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeFieldInfoPtr__DailyBeverages_k__BackingField;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeFieldInfoPtr__PopNotHateRecipes_k__BackingField;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeFieldInfoPtr__PopNotHateBeverages_k__BackingField;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeFieldInfoPtr__CheapestRecipes_k__BackingField;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeFieldInfoPtr__CheapestBeverages_k__BackingField;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeFieldInfoPtr__TheMostExpensiveRecipes_k__BackingField;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeFieldInfoPtr__TheMostExpensiveBeverages_k__BackingField;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeFieldInfoPtr__StoredFoods_k__BackingField;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestPool_k__BackingField;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeFieldInfoPtr__NormalGuestInterval_k__BackingField;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeFieldInfoPtr__SpawnPasserbyGuest_k__BackingField;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeFieldInfoPtr__PasserbyGuestSpanInterval_k__BackingField;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeFieldInfoPtr__BaseRange_k__BackingField;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeFieldInfoPtr__Map_k__BackingField;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestGachaInterval_k__BackingField;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeFieldInfoPtr_m_HasSpawnedSpecialGuestTonight;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeFieldInfoPtr__ExtraStoreFoodCallback_k__BackingField;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeFieldInfoPtr__ExtraAbandonFoodCallback_k__BackingField;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeFieldInfoPtr__ExtraRemoveStoredFoodCallback_k__BackingField;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPoolIdentityData_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestPoolIdentityData_Private_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaData_Public_get_Izakaya_0;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeMethodInfoPtr_set_IzakayaData_Private_set_Void_Izakaya_0;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerConfigure_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerConfigure_Private_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_get_EmptyRecipeSlotCount_Public_get_Int32_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_get_EmptyBeverageSlotCount_Public_get_Int32_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyRecipes_Public_get_List_1_Recipe_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_set_DailyRecipes_Private_set_Void_List_1_Recipe_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyBeverages_Public_get_List_1_Sellable_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_set_DailyBeverages_Private_set_Void_List_1_Sellable_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr_get_PopNotHateRecipes_Public_get_List_1_Recipe_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr_set_PopNotHateRecipes_Private_set_Void_List_1_Recipe_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_get_PopNotHateBeverages_Public_get_List_1_Sellable_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_set_PopNotHateBeverages_Private_set_Void_List_1_Sellable_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_get_CheapestRecipes_Public_get_List_1_Recipe_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_set_CheapestRecipes_Private_set_Void_List_1_Recipe_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_get_CheapestBeverages_Public_get_List_1_Sellable_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_set_CheapestBeverages_Private_set_Void_List_1_Sellable_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_get_TheMostExpensiveRecipes_Public_get_List_1_Recipe_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_set_TheMostExpensiveRecipes_Private_set_Void_List_1_Recipe_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_get_TheMostExpensiveBeverages_Public_get_List_1_Sellable_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr_set_TheMostExpensiveBeverages_Private_set_Void_List_1_Sellable_0;

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredFoods_Private_get_List_1_Sellable_0;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeMethodInfoPtr_set_StoredFoods_Private_set_Void_List_1_Sellable_0;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeMethodInfoPtr_get_BatchedStoredFoods_Public_get_IEnumerable_1_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestPool_Private_set_Void_Il2CppReferenceArray_1_IEnumerable_1_NormalGuest_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestInterval_Public_get_Vector2_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestInterval_Private_set_Void_Vector2_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_set_SpawnPasserbyGuest_Private_set_Void_Boolean_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_set_PasserbyGuestSpanInterval_Private_set_Void_Vector2_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseRange_Public_get_Vector2Int_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseRange_Private_set_Void_Vector2Int_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr_get_Map_Public_get_GameObject_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr_set_Map_Private_set_Void_GameObject_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestGachaInterval_Private_set_Void_Single_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_get_CanGacha_Public_get_Boolean_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingGuestPool_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Void_Vector2Int_Vector2_IEnumerable_1_NormalGuestGroup_Single_IEnumerable_1_SpecialGuestGroup_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Izakaya_GameObject_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_LoadLockedMissionRecipes_Public_Void_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSpecialGuestPool_Private_Void_String_IEnumerable_1_SpecialGuestGroup_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredFoods_Public_IEnumerable_1_Sellable_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraStoreFoodCallback_Public_get_Action_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtraStoreFoodCallback_Public_set_Void_Action_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraAbandonFoodCallback_Public_get_Action_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtraAbandonFoodCallback_Public_set_Void_Action_0;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraRemoveStoredFoodCallback_Public_get_Action_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtraRemoveStoredFoodCallback_Public_set_Void_Action_0;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeMethodInfoPtr_StoreFood_Public_Void_Sellable_Int32_0;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStoredFood_Public_Void_Sellable_Int32_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeMethodInfoPtr_PreCalculateRecipes_Public_Void_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr_OverrideCookers_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_OverrideRecipes_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_RecordIzakayaMenuSelection_Public_Void_HistoryIzakayaMenuSelection_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToDailyRecipes_Public_Void_Int32_Boolean_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_LogoffFromDailyRecipes_Public_Void_Int32_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_IsDailyRecipeFood_Public_Boolean_Sellable_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToDailyBeverages_Public_Void_Int32_Boolean_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_LogoffFromDailyBeverages_Public_Void_Int32_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToCookers_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr_LogOffFromCookers_Public_Void_Int32_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeMethodInfoPtr_Gacha_Public_Int32_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_SetThisGuestHasSpawned_Public_Void_Int32_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_CheckThisGuestHasSpawnedTonight_Public_Boolean_Int32_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr__LoadLockedMissionRecipes_b__93_0_Private_Void_Int32_0;

		// Token: 0x020009DF RID: 2527
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C1E3 RID: 49635 RVA: 0x003059C4 File Offset: 0x00303BC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr);
				IzakayaConfigure.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__56_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__56_1");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__90_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__90_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__92_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__92_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_8");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_1");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_3");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_5");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_6");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__94_7");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_6");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_7");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_1");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_2");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_3");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_4");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__110_5");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__112_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__112_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__113_0");
				IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, "<>9__113_1");
				IzakayaConfigure.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675421);
				IzakayaConfigure.__c.NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_0_Internal_Sellable_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675422);
				IzakayaConfigure.__c.NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_1_Internal_KeyValuePair_2_Sellable_Int32_IGrouping_2_Sellable_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675423);
				IzakayaConfigure.__c.NativeMethodInfoPtr__UpdateValue_b__90_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675424);
				IzakayaConfigure.__c.NativeMethodInfoPtr__Initialize_b__92_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675425);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_8_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675426);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_1_Internal_Boolean_ValueTuple_3_Boolean_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675427);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_3_Internal_Int32_ValueTuple_2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675428);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_5_Internal_Int32_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675429);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_6_Internal_String_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675430);
				IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_7_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675431);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675432);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675433);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675434);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675435);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_2_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675436);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_3_Internal_Int32_IGrouping_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675437);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_4_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675438);
				IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_5_Internal_Int32_IGrouping_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675439);
				IzakayaConfigure.__c.NativeMethodInfoPtr__OverrideRecipes_b__112_0_Internal_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675440);
				IzakayaConfigure.__c.NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_0_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675441);
				IzakayaConfigure.__c.NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_1_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr, 100675442);
			}

			// Token: 0x0600C1E4 RID: 49636 RVA: 0x00305D60 File Offset: 0x00303F60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C1E5 RID: 49637 RVA: 0x00305D9C File Offset: 0x00303F9C
			[CallerCount(0)]
			public unsafe Sellable _get_BatchedStoredFoods_b__56_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_0_Internal_Sellable_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600C1E6 RID: 49638 RVA: 0x00305DEC File Offset: 0x00303FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157482, XrefRangeEnd = 157491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Sellable, int> _get_BatchedStoredFoods_b__56_1(IGrouping<Sellable, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_1_Internal_KeyValuePair_2_Sellable_Int32_IGrouping_2_Sellable_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Sellable, int>(pointer);
			}

			// Token: 0x0600C1E7 RID: 49639 RVA: 0x00305E34 File Offset: 0x00304034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IEnumerable<NormalGuest>> _UpdateValue_b__90_0(Izakaya.NormalGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__UpdateValue_b__90_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
			}

			// Token: 0x0600C1E8 RID: 49640 RVA: 0x00305E84 File Offset: 0x00304084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IEnumerable<NormalGuest>> _Initialize_b__92_0(Izakaya.NormalGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__Initialize_b__92_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
			}

			// Token: 0x0600C1E9 RID: 49641 RVA: 0x00305ED4 File Offset: 0x003040D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157491, XrefRangeEnd = 157497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _CalculateSpecialGuestPool_b__94_8(ValueTuple<int, PartnerBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_8_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600C1EA RID: 49642 RVA: 0x00305F2C File Offset: 0x0030412C
			[CallerCount(0)]
			public unsafe bool _CalculateSpecialGuestPool_b__94_1(ValueTuple<bool, float, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_1_Internal_Boolean_ValueTuple_3_Boolean_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1EB RID: 49643 RVA: 0x00305F80 File Offset: 0x00304180
			[CallerCount(0)]
			public unsafe int _CalculateSpecialGuestPool_b__94_3(ValueTuple<float, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_3_Internal_Int32_ValueTuple_2_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1EC RID: 49644 RVA: 0x00305FD4 File Offset: 0x003041D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157497, XrefRangeEnd = 157498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CalculateSpecialGuestPool_b__94_5(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_5_Internal_Int32_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1ED RID: 49645 RVA: 0x00306028 File Offset: 0x00304228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157498, XrefRangeEnd = 157506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CalculateSpecialGuestPool_b__94_6(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_6_Internal_String_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C1EE RID: 49646 RVA: 0x00306078 File Offset: 0x00304278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157506, XrefRangeEnd = 157509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CalculateSpecialGuestPool_b__94_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_7_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C1EF RID: 49647 RVA: 0x003060BC File Offset: 0x003042BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157509, XrefRangeEnd = 157528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PreCalculateRecipes_b__110_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F0 RID: 49648 RVA: 0x0030610C File Offset: 0x0030430C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157528, XrefRangeEnd = 157535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PreCalculateRecipes_b__110_6(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F1 RID: 49649 RVA: 0x00306158 File Offset: 0x00304358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157535, XrefRangeEnd = 157553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PreCalculateRecipes_b__110_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F2 RID: 49650 RVA: 0x003061A8 File Offset: 0x003043A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157553, XrefRangeEnd = 157560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PreCalculateRecipes_b__110_7(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F3 RID: 49651 RVA: 0x003061F4 File Offset: 0x003043F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157560, XrefRangeEnd = 157563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PreCalculateRecipes_b__110_2(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_2_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F4 RID: 49652 RVA: 0x00306244 File Offset: 0x00304444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157563, XrefRangeEnd = 157567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PreCalculateRecipes_b__110_3(IGrouping<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_3_Internal_Int32_IGrouping_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F5 RID: 49653 RVA: 0x00306294 File Offset: 0x00304494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157567, XrefRangeEnd = 157569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PreCalculateRecipes_b__110_4(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_4_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F6 RID: 49654 RVA: 0x003062E4 File Offset: 0x003044E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157569, XrefRangeEnd = 157573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PreCalculateRecipes_b__110_5(IGrouping<int, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__PreCalculateRecipes_b__110_5_Internal_Int32_IGrouping_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F7 RID: 49655 RVA: 0x00306334 File Offset: 0x00304534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe _OverrideRecipes_b__112_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__OverrideRecipes_b__112_0_Internal_Recipe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600C1F8 RID: 49656 RVA: 0x00306380 File Offset: 0x00304580
			[CallerCount(0)]
			public unsafe int _RecordIzakayaMenuSelection_b__113_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_0_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1F9 RID: 49657 RVA: 0x003063D0 File Offset: 0x003045D0
			[CallerCount(0)]
			public unsafe int _RecordIzakayaMenuSelection_b__113_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c.NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_1_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C1FA RID: 49658 RVA: 0x00068A41 File Offset: 0x00066C41
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F27 RID: 16167
			// (get) Token: 0x0600C1FB RID: 49659 RVA: 0x00306420 File Offset: 0x00304620
			// (set) Token: 0x0600C1FC RID: 49660 RVA: 0x00068A4A File Offset: 0x00066C4A
			public unsafe static IzakayaConfigure.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F28 RID: 16168
			// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x00306448 File Offset: 0x00304648
			// (set) Token: 0x0600C1FE RID: 49662 RVA: 0x00068A5C File Offset: 0x00066C5C
			public unsafe static Func<Sellable, Sellable> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x00306470 File Offset: 0x00304670
			// (set) Token: 0x0600C200 RID: 49664 RVA: 0x00068A6E File Offset: 0x00066C6E
			public unsafe static Func<IGrouping<Sellable, Sellable>, KeyValuePair<Sellable, int>> __9__56_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Sellable, Sellable>, KeyValuePair<Sellable, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__56_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2A RID: 16170
			// (get) Token: 0x0600C201 RID: 49665 RVA: 0x00306498 File Offset: 0x00304698
			// (set) Token: 0x0600C202 RID: 49666 RVA: 0x00068A80 File Offset: 0x00066C80
			public unsafe static Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>> __9__90_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__90_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__90_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2B RID: 16171
			// (get) Token: 0x0600C203 RID: 49667 RVA: 0x003064C0 File Offset: 0x003046C0
			// (set) Token: 0x0600C204 RID: 49668 RVA: 0x00068A92 File Offset: 0x00066C92
			public unsafe static Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>> __9__92_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__92_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__92_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2C RID: 16172
			// (get) Token: 0x0600C205 RID: 49669 RVA: 0x003064E8 File Offset: 0x003046E8
			// (set) Token: 0x0600C206 RID: 49670 RVA: 0x00068AA4 File Offset: 0x00066CA4
			public unsafe static Func<ValueTuple<int, PartnerBase>, IEnumerable<int>> __9__94_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2D RID: 16173
			// (get) Token: 0x0600C207 RID: 49671 RVA: 0x00306510 File Offset: 0x00304710
			// (set) Token: 0x0600C208 RID: 49672 RVA: 0x00068AB6 File Offset: 0x00066CB6
			public unsafe static Func<ValueTuple<bool, float, int>, bool> __9__94_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<bool, float, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2E RID: 16174
			// (get) Token: 0x0600C209 RID: 49673 RVA: 0x00306538 File Offset: 0x00304738
			// (set) Token: 0x0600C20A RID: 49674 RVA: 0x00068AC8 File Offset: 0x00066CC8
			public unsafe static Func<ValueTuple<float, int>, int> __9__94_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<float, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2F RID: 16175
			// (get) Token: 0x0600C20B RID: 49675 RVA: 0x00306560 File Offset: 0x00304760
			// (set) Token: 0x0600C20C RID: 49676 RVA: 0x00068ADA File Offset: 0x00066CDA
			public unsafe static Func<KeyValuePair<int, Vector2>, int> __9__94_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Vector2>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F30 RID: 16176
			// (get) Token: 0x0600C20D RID: 49677 RVA: 0x00306588 File Offset: 0x00304788
			// (set) Token: 0x0600C20E RID: 49678 RVA: 0x00068AEC File Offset: 0x00066CEC
			public unsafe static Func<KeyValuePair<int, Vector2>, string> __9__94_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Vector2>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F31 RID: 16177
			// (get) Token: 0x0600C20F RID: 49679 RVA: 0x003065B0 File Offset: 0x003047B0
			// (set) Token: 0x0600C210 RID: 49680 RVA: 0x00068AFE File Offset: 0x00066CFE
			public unsafe static Func<int, string> __9__94_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__94_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F32 RID: 16178
			// (get) Token: 0x0600C211 RID: 49681 RVA: 0x003065D8 File Offset: 0x003047D8
			// (set) Token: 0x0600C212 RID: 49682 RVA: 0x00068B10 File Offset: 0x00066D10
			public unsafe static Func<int, bool> __9__110_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F33 RID: 16179
			// (get) Token: 0x0600C213 RID: 49683 RVA: 0x00306600 File Offset: 0x00304800
			// (set) Token: 0x0600C214 RID: 49684 RVA: 0x00068B22 File Offset: 0x00066D22
			public unsafe static Func<Recipe, bool> __9__110_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F34 RID: 16180
			// (get) Token: 0x0600C215 RID: 49685 RVA: 0x00306628 File Offset: 0x00304828
			// (set) Token: 0x0600C216 RID: 49686 RVA: 0x00068B34 File Offset: 0x00066D34
			public unsafe static Func<int, bool> __9__110_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F35 RID: 16181
			// (get) Token: 0x0600C217 RID: 49687 RVA: 0x00306650 File Offset: 0x00304850
			// (set) Token: 0x0600C218 RID: 49688 RVA: 0x00068B46 File Offset: 0x00066D46
			public unsafe static Func<Sellable, bool> __9__110_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F36 RID: 16182
			// (get) Token: 0x0600C219 RID: 49689 RVA: 0x00306678 File Offset: 0x00304878
			// (set) Token: 0x0600C21A RID: 49690 RVA: 0x00068B58 File Offset: 0x00066D58
			public unsafe static Func<Recipe, int> __9__110_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F37 RID: 16183
			// (get) Token: 0x0600C21B RID: 49691 RVA: 0x003066A0 File Offset: 0x003048A0
			// (set) Token: 0x0600C21C RID: 49692 RVA: 0x00068B6A File Offset: 0x00066D6A
			public unsafe static Func<IGrouping<int, Recipe>, int> __9__110_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Recipe>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F38 RID: 16184
			// (get) Token: 0x0600C21D RID: 49693 RVA: 0x003066C8 File Offset: 0x003048C8
			// (set) Token: 0x0600C21E RID: 49694 RVA: 0x00068B7C File Offset: 0x00066D7C
			public unsafe static Func<Sellable, int> __9__110_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F39 RID: 16185
			// (get) Token: 0x0600C21F RID: 49695 RVA: 0x003066F0 File Offset: 0x003048F0
			// (set) Token: 0x0600C220 RID: 49696 RVA: 0x00068B8E File Offset: 0x00066D8E
			public unsafe static Func<IGrouping<int, Sellable>, int> __9__110_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Sellable>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__110_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3A RID: 16186
			// (get) Token: 0x0600C221 RID: 49697 RVA: 0x00306718 File Offset: 0x00304918
			// (set) Token: 0x0600C222 RID: 49698 RVA: 0x00068BA0 File Offset: 0x00066DA0
			public unsafe static Func<int, Recipe> __9__112_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__112_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__112_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3B RID: 16187
			// (get) Token: 0x0600C223 RID: 49699 RVA: 0x00306740 File Offset: 0x00304940
			// (set) Token: 0x0600C224 RID: 49700 RVA: 0x00068BB2 File Offset: 0x00066DB2
			public unsafe static Func<Recipe, int> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3C RID: 16188
			// (get) Token: 0x0600C225 RID: 49701 RVA: 0x00306768 File Offset: 0x00304968
			// (set) Token: 0x0600C226 RID: 49702 RVA: 0x00068BC4 File Offset: 0x00066DC4
			public unsafe static Func<Sellable, int> __9__113_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigure.__c.NativeFieldInfoPtr___9__113_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007CD7 RID: 31959
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007CD8 RID: 31960
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x04007CD9 RID: 31961
			private static readonly IntPtr NativeFieldInfoPtr___9__56_1;

			// Token: 0x04007CDA RID: 31962
			private static readonly IntPtr NativeFieldInfoPtr___9__90_0;

			// Token: 0x04007CDB RID: 31963
			private static readonly IntPtr NativeFieldInfoPtr___9__92_0;

			// Token: 0x04007CDC RID: 31964
			private static readonly IntPtr NativeFieldInfoPtr___9__94_8;

			// Token: 0x04007CDD RID: 31965
			private static readonly IntPtr NativeFieldInfoPtr___9__94_1;

			// Token: 0x04007CDE RID: 31966
			private static readonly IntPtr NativeFieldInfoPtr___9__94_3;

			// Token: 0x04007CDF RID: 31967
			private static readonly IntPtr NativeFieldInfoPtr___9__94_5;

			// Token: 0x04007CE0 RID: 31968
			private static readonly IntPtr NativeFieldInfoPtr___9__94_6;

			// Token: 0x04007CE1 RID: 31969
			private static readonly IntPtr NativeFieldInfoPtr___9__94_7;

			// Token: 0x04007CE2 RID: 31970
			private static readonly IntPtr NativeFieldInfoPtr___9__110_6;

			// Token: 0x04007CE3 RID: 31971
			private static readonly IntPtr NativeFieldInfoPtr___9__110_0;

			// Token: 0x04007CE4 RID: 31972
			private static readonly IntPtr NativeFieldInfoPtr___9__110_7;

			// Token: 0x04007CE5 RID: 31973
			private static readonly IntPtr NativeFieldInfoPtr___9__110_1;

			// Token: 0x04007CE6 RID: 31974
			private static readonly IntPtr NativeFieldInfoPtr___9__110_2;

			// Token: 0x04007CE7 RID: 31975
			private static readonly IntPtr NativeFieldInfoPtr___9__110_3;

			// Token: 0x04007CE8 RID: 31976
			private static readonly IntPtr NativeFieldInfoPtr___9__110_4;

			// Token: 0x04007CE9 RID: 31977
			private static readonly IntPtr NativeFieldInfoPtr___9__110_5;

			// Token: 0x04007CEA RID: 31978
			private static readonly IntPtr NativeFieldInfoPtr___9__112_0;

			// Token: 0x04007CEB RID: 31979
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x04007CEC RID: 31980
			private static readonly IntPtr NativeFieldInfoPtr___9__113_1;

			// Token: 0x04007CED RID: 31981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007CEE RID: 31982
			private static readonly IntPtr NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_0_Internal_Sellable_Sellable_0;

			// Token: 0x04007CEF RID: 31983
			private static readonly IntPtr NativeMethodInfoPtr__get_BatchedStoredFoods_b__56_1_Internal_KeyValuePair_2_Sellable_Int32_IGrouping_2_Sellable_Sellable_0;

			// Token: 0x04007CF0 RID: 31984
			private static readonly IntPtr NativeMethodInfoPtr__UpdateValue_b__90_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0;

			// Token: 0x04007CF1 RID: 31985
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__92_0_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0;

			// Token: 0x04007CF2 RID: 31986
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_8_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0;

			// Token: 0x04007CF3 RID: 31987
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_1_Internal_Boolean_ValueTuple_3_Boolean_Single_Int32_0;

			// Token: 0x04007CF4 RID: 31988
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_3_Internal_Int32_ValueTuple_2_Single_Int32_0;

			// Token: 0x04007CF5 RID: 31989
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_5_Internal_Int32_KeyValuePair_2_Int32_Vector2_0;

			// Token: 0x04007CF6 RID: 31990
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_6_Internal_String_KeyValuePair_2_Int32_Vector2_0;

			// Token: 0x04007CF7 RID: 31991
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__94_7_Internal_String_Int32_0;

			// Token: 0x04007CF8 RID: 31992
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_0_Internal_Boolean_Recipe_0;

			// Token: 0x04007CF9 RID: 31993
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_6_Internal_Boolean_Int32_0;

			// Token: 0x04007CFA RID: 31994
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_1_Internal_Boolean_Sellable_0;

			// Token: 0x04007CFB RID: 31995
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_7_Internal_Boolean_Int32_0;

			// Token: 0x04007CFC RID: 31996
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_2_Internal_Int32_Recipe_0;

			// Token: 0x04007CFD RID: 31997
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_3_Internal_Int32_IGrouping_2_Int32_Recipe_0;

			// Token: 0x04007CFE RID: 31998
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_4_Internal_Int32_Sellable_0;

			// Token: 0x04007CFF RID: 31999
			private static readonly IntPtr NativeMethodInfoPtr__PreCalculateRecipes_b__110_5_Internal_Int32_IGrouping_2_Int32_Sellable_0;

			// Token: 0x04007D00 RID: 32000
			private static readonly IntPtr NativeMethodInfoPtr__OverrideRecipes_b__112_0_Internal_Recipe_Int32_0;

			// Token: 0x04007D01 RID: 32001
			private static readonly IntPtr NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_0_Internal_Int32_Recipe_0;

			// Token: 0x04007D02 RID: 32002
			private static readonly IntPtr NativeMethodInfoPtr__RecordIzakayaMenuSelection_b__113_1_Internal_Int32_Sellable_0;
		}

		// Token: 0x020009E0 RID: 2528
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass92_0")]
		public sealed class __c__DisplayClass92_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C227 RID: 49703 RVA: 0x00306790 File Offset: 0x00304990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass92_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass92_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_specialGuestControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr, "specialGuestControlled");
				IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr, "eventManager");
				IzakayaConfigure.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr, 100675443);
				IzakayaConfigure.__c__DisplayClass92_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr, 100675444);
			}

			// Token: 0x0600C228 RID: 49704 RVA: 0x0030680C File Offset: 0x00304A0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass92_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass92_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C229 RID: 49705 RVA: 0x00306848 File Offset: 0x00304A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157573, XrefRangeEnd = 157575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__1(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass92_0.NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C22A RID: 49706 RVA: 0x00068BD6 File Offset: 0x00066DD6
			public __c__DisplayClass92_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F3D RID: 16189
			// (get) Token: 0x0600C22B RID: 49707 RVA: 0x00306898 File Offset: 0x00304A98
			// (set) Token: 0x0600C22C RID: 49708 RVA: 0x00068BDF File Offset: 0x00066DDF
			public unsafe SpecialGuestControlled specialGuestControlled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_specialGuestControlled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestControlled>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_specialGuestControlled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F3E RID: 16190
			// (get) Token: 0x0600C22D RID: 49709 RVA: 0x003068C8 File Offset: 0x00304AC8
			// (set) Token: 0x0600C22E RID: 49710 RVA: 0x00068BFE File Offset: 0x00066DFE
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass92_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D03 RID: 32003
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestControlled;

			// Token: 0x04007D04 RID: 32004
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04007D05 RID: 32005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D06 RID: 32006
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x020009E1 RID: 2529
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C22F RID: 49711 RVA: 0x003068F8 File Offset: 0x00304AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_daySceneMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "daySceneMapLabel");
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_specialGuestGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "specialGuestGroups");
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_isChallengeSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "isChallengeSession");
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_lastProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "lastProbability");
				IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_maxAccuProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, "maxAccuProbability");
				IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, 100675445);
				IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__0_Internal_ValueTuple_3_Boolean_Single_Int32_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, 100675446);
				IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__2_Internal_ValueTuple_2_Single_Int32_ValueTuple_3_Boolean_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, 100675447);
				IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__4_Internal_Vector2_ValueTuple_2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr, 100675448);
			}

			// Token: 0x0600C230 RID: 49712 RVA: 0x003069EC File Offset: 0x00304BEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C231 RID: 49713 RVA: 0x00306A28 File Offset: 0x00304C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157575, XrefRangeEnd = 157618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<bool, float, int> _CalculateSpecialGuestPool_b__0(SpecialGuest guestData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestData);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__0_Internal_ValueTuple_3_Boolean_Single_Int32_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<bool, float, int>(pointer);
			}

			// Token: 0x0600C232 RID: 49714 RVA: 0x00306A70 File Offset: 0x00304C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157618, XrefRangeEnd = 157621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<float, int> _CalculateSpecialGuestPool_b__2(ValueTuple<bool, float, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__2_Internal_ValueTuple_2_Single_Int32_ValueTuple_3_Boolean_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<float, int>(pointer);
			}

			// Token: 0x0600C233 RID: 49715 RVA: 0x00306AC0 File Offset: 0x00304CC0
			[CallerCount(0)]
			public unsafe Vector2 _CalculateSpecialGuestPool_b__4(ValueTuple<float, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_0.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__4_Internal_Vector2_ValueTuple_2_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C234 RID: 49716 RVA: 0x00068C1D File Offset: 0x00066E1D
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F3F RID: 16191
			// (get) Token: 0x0600C235 RID: 49717 RVA: 0x00306B14 File Offset: 0x00304D14
			// (set) Token: 0x0600C236 RID: 49718 RVA: 0x00068C26 File Offset: 0x00066E26
			public unsafe IzakayaConfigure __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F40 RID: 16192
			// (get) Token: 0x0600C237 RID: 49719 RVA: 0x00306B44 File Offset: 0x00304D44
			// (set) Token: 0x0600C238 RID: 49720 RVA: 0x00068C45 File Offset: 0x00066E45
			public unsafe string daySceneMapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_daySceneMapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_daySceneMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F41 RID: 16193
			// (get) Token: 0x0600C239 RID: 49721 RVA: 0x00306B6C File Offset: 0x00304D6C
			// (set) Token: 0x0600C23A RID: 49722 RVA: 0x00068C64 File Offset: 0x00066E64
			public unsafe IEnumerable<Izakaya.SpecialGuestGroup> specialGuestGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_specialGuestGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.SpecialGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_specialGuestGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F42 RID: 16194
			// (get) Token: 0x0600C23B RID: 49723 RVA: 0x00306B9C File Offset: 0x00304D9C
			// (set) Token: 0x0600C23C RID: 49724 RVA: 0x00068C83 File Offset: 0x00066E83
			public unsafe bool isChallengeSession
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_isChallengeSession);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_isChallengeSession)) = value;
				}
			}

			// Token: 0x17003F43 RID: 16195
			// (get) Token: 0x0600C23D RID: 49725 RVA: 0x00306BC4 File Offset: 0x00304DC4
			// (set) Token: 0x0600C23E RID: 49726 RVA: 0x00068C9E File Offset: 0x00066E9E
			public unsafe float lastProbability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_lastProbability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_lastProbability)) = value;
				}
			}

			// Token: 0x17003F44 RID: 16196
			// (get) Token: 0x0600C23F RID: 49727 RVA: 0x00306BEC File Offset: 0x00304DEC
			// (set) Token: 0x0600C240 RID: 49728 RVA: 0x00068CB9 File Offset: 0x00066EB9
			public unsafe float maxAccuProbability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_maxAccuProbability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_0.NativeFieldInfoPtr_maxAccuProbability)) = value;
				}
			}

			// Token: 0x04007D07 RID: 32007
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D08 RID: 32008
			private static readonly IntPtr NativeFieldInfoPtr_daySceneMapLabel;

			// Token: 0x04007D09 RID: 32009
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestGroups;

			// Token: 0x04007D0A RID: 32010
			private static readonly IntPtr NativeFieldInfoPtr_isChallengeSession;

			// Token: 0x04007D0B RID: 32011
			private static readonly IntPtr NativeFieldInfoPtr_lastProbability;

			// Token: 0x04007D0C RID: 32012
			private static readonly IntPtr NativeFieldInfoPtr_maxAccuProbability;

			// Token: 0x04007D0D RID: 32013
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D0E RID: 32014
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__0_Internal_ValueTuple_3_Boolean_Single_Int32_SpecialGuest_0;

			// Token: 0x04007D0F RID: 32015
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__2_Internal_ValueTuple_2_Single_Int32_ValueTuple_3_Boolean_Single_Int32_0;

			// Token: 0x04007D10 RID: 32016
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__4_Internal_Vector2_ValueTuple_2_Single_Int32_0;
		}

		// Token: 0x020009E2 RID: 2530
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass94_1")]
		public sealed class __c__DisplayClass94_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C241 RID: 49729 RVA: 0x00306C14 File Offset: 0x00304E14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_1()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass94_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass94_1.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr, "guestData");
				IzakayaConfigure.__c__DisplayClass94_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr, 100675449);
				IzakayaConfigure.__c__DisplayClass94_1.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr, 100675450);
			}

			// Token: 0x0600C242 RID: 49730 RVA: 0x00306C7C File Offset: 0x00304E7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass94_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C243 RID: 49731 RVA: 0x00306CB8 File Offset: 0x00304EB8
			[CallerCount(0)]
			public unsafe bool _CalculateSpecialGuestPool_b__9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass94_1.NativeMethodInfoPtr__CalculateSpecialGuestPool_b__9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C244 RID: 49732 RVA: 0x00068CD4 File Offset: 0x00066ED4
			public __c__DisplayClass94_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F45 RID: 16197
			// (get) Token: 0x0600C245 RID: 49733 RVA: 0x00306D04 File Offset: 0x00304F04
			// (set) Token: 0x0600C246 RID: 49734 RVA: 0x00068CDD File Offset: 0x00066EDD
			public unsafe SpecialGuest guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_1.NativeFieldInfoPtr_guestData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass94_1.NativeFieldInfoPtr_guestData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D11 RID: 32017
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x04007D12 RID: 32018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D13 RID: 32019
			private static readonly IntPtr NativeMethodInfoPtr__CalculateSpecialGuestPool_b__9_Internal_Boolean_Int32_0;
		}

		// Token: 0x020009E3 RID: 2531
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass114_0")]
		public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C247 RID: 49735 RVA: 0x00306D34 File Offset: 0x00304F34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass114_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass114_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass114_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr, "id");
				IzakayaConfigure.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr, 100675451);
				IzakayaConfigure.__c__DisplayClass114_0.NativeMethodInfoPtr__RegisterToDailyRecipes_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr, 100675452);
			}

			// Token: 0x0600C248 RID: 49736 RVA: 0x00306D9C File Offset: 0x00304F9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass114_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass114_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C249 RID: 49737 RVA: 0x00306DD8 File Offset: 0x00304FD8
			[CallerCount(0)]
			public unsafe bool _RegisterToDailyRecipes_b__0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass114_0.NativeMethodInfoPtr__RegisterToDailyRecipes_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C24A RID: 49738 RVA: 0x00068CFC File Offset: 0x00066EFC
			public __c__DisplayClass114_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F46 RID: 16198
			// (get) Token: 0x0600C24B RID: 49739 RVA: 0x00306E28 File Offset: 0x00305028
			// (set) Token: 0x0600C24C RID: 49740 RVA: 0x00068D05 File Offset: 0x00066F05
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass114_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass114_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04007D14 RID: 32020
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04007D15 RID: 32021
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D16 RID: 32022
			private static readonly IntPtr NativeMethodInfoPtr__RegisterToDailyRecipes_b__0_Internal_Boolean_Recipe_0;
		}

		// Token: 0x020009E4 RID: 2532
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass115_0")]
		public sealed class __c__DisplayClass115_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C24D RID: 49741 RVA: 0x00306E50 File Offset: 0x00305050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass115_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass115_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass115_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr, "id");
				IzakayaConfigure.__c__DisplayClass115_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr, 100675453);
				IzakayaConfigure.__c__DisplayClass115_0.NativeMethodInfoPtr__LogoffFromDailyRecipes_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr, 100675454);
			}

			// Token: 0x0600C24E RID: 49742 RVA: 0x00306EB8 File Offset: 0x003050B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass115_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass115_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass115_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C24F RID: 49743 RVA: 0x00306EF4 File Offset: 0x003050F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157621, XrefRangeEnd = 157622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LogoffFromDailyRecipes_b__0(KeyValuePair<int, Recipe> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass115_0.NativeMethodInfoPtr__LogoffFromDailyRecipes_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C250 RID: 49744 RVA: 0x00068D20 File Offset: 0x00066F20
			public __c__DisplayClass115_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F47 RID: 16199
			// (get) Token: 0x0600C251 RID: 49745 RVA: 0x00306F48 File Offset: 0x00305148
			// (set) Token: 0x0600C252 RID: 49746 RVA: 0x00068D29 File Offset: 0x00066F29
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass115_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass115_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04007D17 RID: 32023
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04007D18 RID: 32024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D19 RID: 32025
			private static readonly IntPtr NativeMethodInfoPtr__LogoffFromDailyRecipes_b__0_Internal_Boolean_KeyValuePair_2_Int32_Recipe_0;
		}

		// Token: 0x020009E5 RID: 2533
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass116_0")]
		public sealed class __c__DisplayClass116_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C253 RID: 49747 RVA: 0x00306F70 File Offset: 0x00305170
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass116_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass116_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass116_0.NativeFieldInfoPtr_food = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr, "food");
				IzakayaConfigure.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr, 100675455);
				IzakayaConfigure.__c__DisplayClass116_0.NativeMethodInfoPtr__IsDailyRecipeFood_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr, 100675456);
			}

			// Token: 0x0600C254 RID: 49748 RVA: 0x00306FD8 File Offset: 0x003051D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass116_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass116_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C255 RID: 49749 RVA: 0x00307014 File Offset: 0x00305214
			[CallerCount(0)]
			public unsafe bool _IsDailyRecipeFood_b__0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass116_0.NativeMethodInfoPtr__IsDailyRecipeFood_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C256 RID: 49750 RVA: 0x00068D44 File Offset: 0x00066F44
			public __c__DisplayClass116_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F48 RID: 16200
			// (get) Token: 0x0600C257 RID: 49751 RVA: 0x00307064 File Offset: 0x00305264
			// (set) Token: 0x0600C258 RID: 49752 RVA: 0x00068D4D File Offset: 0x00066F4D
			public unsafe Sellable food
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass116_0.NativeFieldInfoPtr_food);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass116_0.NativeFieldInfoPtr_food), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D1A RID: 32026
			private static readonly IntPtr NativeFieldInfoPtr_food;

			// Token: 0x04007D1B RID: 32027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D1C RID: 32028
			private static readonly IntPtr NativeMethodInfoPtr__IsDailyRecipeFood_b__0_Internal_Boolean_Recipe_0;
		}

		// Token: 0x020009E6 RID: 2534
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass117_0")]
		public sealed class __c__DisplayClass117_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C259 RID: 49753 RVA: 0x00307094 File Offset: 0x00305294
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass117_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass117_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass117_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr, "id");
				IzakayaConfigure.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr, 100675457);
				IzakayaConfigure.__c__DisplayClass117_0.NativeMethodInfoPtr__RegisterToDailyBeverages_b__0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr, 100675458);
			}

			// Token: 0x0600C25A RID: 49754 RVA: 0x003070FC File Offset: 0x003052FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass117_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass117_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C25B RID: 49755 RVA: 0x00307138 File Offset: 0x00305338
			[CallerCount(0)]
			public unsafe bool _RegisterToDailyBeverages_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass117_0.NativeMethodInfoPtr__RegisterToDailyBeverages_b__0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C25C RID: 49756 RVA: 0x00068D6C File Offset: 0x00066F6C
			public __c__DisplayClass117_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F49 RID: 16201
			// (get) Token: 0x0600C25D RID: 49757 RVA: 0x00307188 File Offset: 0x00305388
			// (set) Token: 0x0600C25E RID: 49758 RVA: 0x00068D75 File Offset: 0x00066F75
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass117_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass117_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04007D1D RID: 32029
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04007D1E RID: 32030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D1F RID: 32031
			private static readonly IntPtr NativeMethodInfoPtr__RegisterToDailyBeverages_b__0_Internal_Boolean_Sellable_0;
		}

		// Token: 0x020009E7 RID: 2535
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass118_0")]
		public sealed class __c__DisplayClass118_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C25F RID: 49759 RVA: 0x003071B0 File Offset: 0x003053B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass118_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass118_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass118_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr, "id");
				IzakayaConfigure.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr, 100675459);
				IzakayaConfigure.__c__DisplayClass118_0.NativeMethodInfoPtr__LogoffFromDailyBeverages_b__0_Internal_Boolean_KeyValuePair_2_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr, 100675460);
			}

			// Token: 0x0600C260 RID: 49760 RVA: 0x00307218 File Offset: 0x00305418
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass118_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass118_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C261 RID: 49761 RVA: 0x00307254 File Offset: 0x00305454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157622, XrefRangeEnd = 157623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LogoffFromDailyBeverages_b__0(KeyValuePair<int, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass118_0.NativeMethodInfoPtr__LogoffFromDailyBeverages_b__0_Internal_Boolean_KeyValuePair_2_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C262 RID: 49762 RVA: 0x00068D90 File Offset: 0x00066F90
			public __c__DisplayClass118_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4A RID: 16202
			// (get) Token: 0x0600C263 RID: 49763 RVA: 0x003072A8 File Offset: 0x003054A8
			// (set) Token: 0x0600C264 RID: 49764 RVA: 0x00068D99 File Offset: 0x00066F99
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass118_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass118_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04007D20 RID: 32032
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04007D21 RID: 32033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D22 RID: 32034
			private static readonly IntPtr NativeMethodInfoPtr__LogoffFromDailyBeverages_b__0_Internal_Boolean_KeyValuePair_2_Int32_Sellable_0;
		}

		// Token: 0x020009E8 RID: 2536
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaConfigure+<>c__DisplayClass121_0")]
		public sealed class __c__DisplayClass121_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C265 RID: 49765 RVA: 0x003072D0 File Offset: 0x003054D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass121_0()
			{
				Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigure>.NativeClassPtr, "<>c__DisplayClass121_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr);
				IzakayaConfigure.__c__DisplayClass121_0.NativeFieldInfoPtr_randVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr, "randVal");
				IzakayaConfigure.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr, 100675461);
				IzakayaConfigure.__c__DisplayClass121_0.NativeMethodInfoPtr__Gacha_b__0_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr, 100675462);
			}

			// Token: 0x0600C266 RID: 49766 RVA: 0x00307338 File Offset: 0x00305538
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass121_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigure.__c__DisplayClass121_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C267 RID: 49767 RVA: 0x00307374 File Offset: 0x00305574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157623, XrefRangeEnd = 157624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Gacha_b__0(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigure.__c__DisplayClass121_0.NativeMethodInfoPtr__Gacha_b__0_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C268 RID: 49768 RVA: 0x00068DB4 File Offset: 0x00066FB4
			public __c__DisplayClass121_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4B RID: 16203
			// (get) Token: 0x0600C269 RID: 49769 RVA: 0x003073C8 File Offset: 0x003055C8
			// (set) Token: 0x0600C26A RID: 49770 RVA: 0x00068DBD File Offset: 0x00066FBD
			public unsafe float randVal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass121_0.NativeFieldInfoPtr_randVal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigure.__c__DisplayClass121_0.NativeFieldInfoPtr_randVal)) = value;
				}
			}

			// Token: 0x04007D23 RID: 32035
			private static readonly IntPtr NativeFieldInfoPtr_randVal;

			// Token: 0x04007D24 RID: 32036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D25 RID: 32037
			private static readonly IntPtr NativeMethodInfoPtr__Gacha_b__0_Internal_Boolean_KeyValuePair_2_Int32_Vector2_0;
		}
	}
}
