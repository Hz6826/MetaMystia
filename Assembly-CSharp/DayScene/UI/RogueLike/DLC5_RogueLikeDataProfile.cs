using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FE RID: 254
	public class DLC5_RogueLikeDataProfile : ScriptableObject
	{
		// Token: 0x06001C18 RID: 7192 RVA: 0x000FC930 File Offset: 0x000FAB30
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeDataProfile()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeDataProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr);
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_InitialProducts");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialRecipePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_InitialRecipePool");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialBevPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_InitialBevPool");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_BevLevelLinkToNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_RoundDuration");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GlobalProductMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GlobalProductMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_RoundSetups");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_MapSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_MapSetups");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level1RecipePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_Level1RecipePriceMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level2RecipePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_Level2RecipePriceMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level3RecipePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_Level3RecipePriceMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level4RecipePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_Level4RecipePriceMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level5RecipePriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_Level5RecipePriceMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PartnerBasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_PartnerBasePrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_SpecialGuestPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EliteSpecialGuestPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_EliteSpecialGuestPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_ClothesPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_DecorationPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_CookerPriceSetups");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedComboNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaNeedComboNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedSpellNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaNeedSpellNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaMaxCardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaMaxCardNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BeginToSpawnDangerousCardRoundIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_BeginToSpawnDangerousCardRoundIndex");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel2SpotRoundIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_UnlockAllLevel2SpotRoundIndex");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel3SpotRoundIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_UnlockAllLevel3SpotRoundIndex");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaTriggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaTriggerData");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaRewardPairData");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_LuckyLeafExtraMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_LuckyLeafExtraMultiplier");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AyaNewsBeginRoundIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_AyaNewsBeginRoundIndex");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PriceToRefreshAyaNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_PriceToRefreshAyaNews");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AkyuuWashiPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_AkyuuWashiPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EllenCandyPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_EllenCandyPrice");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_KourindouDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_KourindouDiscount");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerCollectWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_CookerCollectWeight");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationCollectWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_DecorationCollectWeight");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesCollectWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_ClothesCollectWeight");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EachMapMaxCollectRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_EachMapMaxCollectRate");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRecipeInitialNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaRecipeInitialNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaBevInitialNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_GachaBevInitialNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SelectRecipeInitialNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_SelectRecipeInitialNum");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseGachaNumWhenSettle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_BaseGachaNumWhenSettle");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseMoveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_BaseMoveAction");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseIngredientNumWhenGetRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_BaseIngredientNumWhenGetRecipe");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_SpecialGuestVisitEverywhere");
			DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_StartFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "m_StartFund");
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668385);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668386);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668387);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668388);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668389);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_SetRoundSetups_Public_Void_List_1_RogueLikeRoundSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668390);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668391);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668392);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668393);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668394);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668395);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668396);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668397);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668398);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668399);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668400);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668401);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668402);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668403);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668404);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668405);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668406);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668407);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668408);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668409);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668410);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668411);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668412);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668413);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668414);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668415);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668416);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668417);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668418);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_CookerCollectWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668419);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_DecorationCollectWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668420);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_ClothesCollectWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668421);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EachMapMaxCollectRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668422);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668423);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668424);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668425);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668426);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668427);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668428);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668429);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668430);
			DLC5_RogueLikeDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, 100668431);
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x000FD090 File Offset: 0x000FB290
		public unsafe virtual IReadOnlyList<Product> InitialProducts
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x000FD0D0 File Offset: 0x000FB2D0
		public unsafe virtual IReadOnlyList<int> InitialRecipePool
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x000FD110 File Offset: 0x000FB310
		public unsafe virtual IReadOnlyList<int> InitialBevPool
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x000FD150 File Offset: 0x000FB350
		public unsafe virtual IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000FD190 File Offset: 0x000FB390
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000FD1D0 File Offset: 0x000FB3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73516, XrefRangeEnd = 73521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoundSetups(List<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> newRoundSetup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newRoundSetup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_SetRoundSetups_Public_Void_List_1_RogueLikeRoundSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x000FD214 File Offset: 0x000FB414
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000FD254 File Offset: 0x000FB454
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000FD294 File Offset: 0x000FB494
		public unsafe virtual IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TriggerCardData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x000FD2D4 File Offset: 0x000FB4D4
		public unsafe virtual IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RogueLikeCardRewardPair>>(intPtr3) : null;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000FD314 File Offset: 0x000FB514
		public unsafe virtual int RoundDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000FD350 File Offset: 0x000FB550
		public unsafe virtual float GlobalProductMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x000FD38C File Offset: 0x000FB58C
		public unsafe virtual float Level1RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000FD3C8 File Offset: 0x000FB5C8
		public unsafe virtual float Level2RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000FD404 File Offset: 0x000FB604
		public unsafe virtual float Level3RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000FD440 File Offset: 0x000FB640
		public unsafe virtual float Level4RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000FD47C File Offset: 0x000FB67C
		public unsafe virtual float Level5RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000FD4B8 File Offset: 0x000FB6B8
		public unsafe virtual int PartnerBasePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x000FD4F4 File Offset: 0x000FB6F4
		public unsafe virtual int SpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000FD530 File Offset: 0x000FB730
		public unsafe virtual int EliteSpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000FD56C File Offset: 0x000FB76C
		public unsafe virtual int ClothesPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20042, RefRangeEnd = 20043, XrefRangeStart = 20042, XrefRangeEnd = 20043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000FD5A8 File Offset: 0x000FB7A8
		public unsafe virtual int DecorationPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73521, RefRangeEnd = 73522, XrefRangeStart = 73521, XrefRangeEnd = 73521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x000FD5E4 File Offset: 0x000FB7E4
		public unsafe virtual int GachaNeedComboNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000FD620 File Offset: 0x000FB820
		public unsafe virtual int GachaNeedSpellNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x000FD65C File Offset: 0x000FB85C
		public unsafe virtual int GachaMaxCardNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x000FD698 File Offset: 0x000FB898
		public unsafe virtual int BeginToSpawnDangerousCardRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000FD6D4 File Offset: 0x000FB8D4
		public unsafe virtual int UnlockAllLevel2SpotRoundIndex
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 49194, RefRangeEnd = 49208, XrefRangeStart = 49194, XrefRangeEnd = 49208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x000FD710 File Offset: 0x000FB910
		public unsafe virtual int UnlockAllLevel3SpotRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x000FD74C File Offset: 0x000FB94C
		public unsafe virtual float LuckyLeafExtraMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000FD788 File Offset: 0x000FB988
		public unsafe virtual int AyaNewsBeginRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000FD7C4 File Offset: 0x000FB9C4
		public unsafe virtual int PriceToRefreshAyaNews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000FD800 File Offset: 0x000FBA00
		public unsafe virtual int AkyuuWashiPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000FD83C File Offset: 0x000FBA3C
		public unsafe virtual int EllenCandyPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x000FD878 File Offset: 0x000FBA78
		public unsafe virtual float KourindouDiscount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000FD8B4 File Offset: 0x000FBAB4
		public unsafe float CookerCollectWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_CookerCollectWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		public unsafe float DecorationCollectWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_DecorationCollectWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x000FD92C File Offset: 0x000FBB2C
		public unsafe float ClothesCollectWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_ClothesCollectWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x000FD968 File Offset: 0x000FBB68
		public unsafe float EachMapMaxCollectRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_EachMapMaxCollectRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000FD9A4 File Offset: 0x000FBBA4
		public unsafe virtual int GachaRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000FD9E0 File Offset: 0x000FBBE0
		public unsafe virtual int GachaBevInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x000FDA1C File Offset: 0x000FBC1C
		public unsafe virtual int SelectRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000FDA58 File Offset: 0x000FBC58
		public unsafe virtual int BaseGachaNumWhenSettle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000FDA94 File Offset: 0x000FBC94
		public unsafe virtual int BaseMoveAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x000FDAD0 File Offset: 0x000FBCD0
		public unsafe virtual int BaseIngredientNumWhenGetRecipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000FDB0C File Offset: 0x000FBD0C
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr3) : null;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x000FDB4C File Offset: 0x000FBD4C
		public unsafe virtual int StartFund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000FDB88 File Offset: 0x000FBD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73522, XrefRangeEnd = 73523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeDataProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00011221 File Offset: 0x0000F421
		public DLC5_RogueLikeDataProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000FDBC4 File Offset: 0x000FBDC4
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0001122A File Offset: 0x0000F42A
		public unsafe Il2CppReferenceArray<Product> m_InitialProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000FDBF4 File Offset: 0x000FBDF4
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00011249 File Offset: 0x0000F449
		public unsafe Il2CppStructArray<int> m_InitialRecipePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialRecipePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialRecipePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000FDC24 File Offset: 0x000FBE24
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x00011268 File Offset: 0x0000F468
		public unsafe Il2CppStructArray<int> m_InitialBevPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialBevPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_InitialBevPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x000FDC54 File Offset: 0x000FBE54
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x00011287 File Offset: 0x0000F487
		public unsafe Il2CppStructArray<Vector2Int> m_BevLevelLinkToNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000FDC84 File Offset: 0x000FBE84
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x000112A6 File Offset: 0x0000F4A6
		public unsafe int m_RoundDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundDuration)) = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x000FDCAC File Offset: 0x000FBEAC
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x000112C1 File Offset: 0x0000F4C1
		public unsafe float m_GlobalProductMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GlobalProductMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GlobalProductMultiplier)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x000FDCD4 File Offset: 0x000FBED4
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x000112DC File Offset: 0x0000F4DC
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> m_RoundSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_RoundSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x000FDD04 File Offset: 0x000FBF04
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x000112FB File Offset: 0x0000F4FB
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup> m_MapSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_MapSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_MapSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x000FDD34 File Offset: 0x000FBF34
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0001131A File Offset: 0x0000F51A
		public unsafe float m_Level1RecipePriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level1RecipePriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level1RecipePriceMultiplier)) = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x000FDD5C File Offset: 0x000FBF5C
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x00011335 File Offset: 0x0000F535
		public unsafe float m_Level2RecipePriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level2RecipePriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level2RecipePriceMultiplier)) = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x000FDD84 File Offset: 0x000FBF84
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x00011350 File Offset: 0x0000F550
		public unsafe float m_Level3RecipePriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level3RecipePriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level3RecipePriceMultiplier)) = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x000FDDAC File Offset: 0x000FBFAC
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0001136B File Offset: 0x0000F56B
		public unsafe float m_Level4RecipePriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level4RecipePriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level4RecipePriceMultiplier)) = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x000FDDD4 File Offset: 0x000FBFD4
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00011386 File Offset: 0x0000F586
		public unsafe float m_Level5RecipePriceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level5RecipePriceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_Level5RecipePriceMultiplier)) = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x000FDDFC File Offset: 0x000FBFFC
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x000113A1 File Offset: 0x0000F5A1
		public unsafe int m_PartnerBasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PartnerBasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PartnerBasePrice)) = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000FDE24 File Offset: 0x000FC024
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x000113BC File Offset: 0x0000F5BC
		public unsafe int m_SpecialGuestPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestPrice)) = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x000FDE4C File Offset: 0x000FC04C
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x000113D7 File Offset: 0x0000F5D7
		public unsafe int m_EliteSpecialGuestPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EliteSpecialGuestPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EliteSpecialGuestPrice)) = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000FDE74 File Offset: 0x000FC074
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x000113F2 File Offset: 0x0000F5F2
		public unsafe int m_ClothesPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesPrice)) = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000FDE9C File Offset: 0x000FC09C
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0001140D File Offset: 0x0000F60D
		public unsafe int m_DecorationPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationPrice)) = value;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000FDEC4 File Offset: 0x000FC0C4
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x00011428 File Offset: 0x0000F628
		public unsafe Il2CppStructArray<DLC5_RogueLikeDataProfile.CookerPriceSetup> m_CookerPriceSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000FDEF4 File Offset: 0x000FC0F4
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x00011447 File Offset: 0x0000F647
		public unsafe int m_GachaNeedComboNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedComboNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedComboNum)) = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x000FDF1C File Offset: 0x000FC11C
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00011462 File Offset: 0x0000F662
		public unsafe int m_GachaNeedSpellNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedSpellNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaNeedSpellNum)) = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x000FDF44 File Offset: 0x000FC144
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x0001147D File Offset: 0x0000F67D
		public unsafe int m_GachaMaxCardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaMaxCardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaMaxCardNum)) = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000FDF6C File Offset: 0x000FC16C
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x00011498 File Offset: 0x0000F698
		public unsafe int m_BeginToSpawnDangerousCardRoundIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BeginToSpawnDangerousCardRoundIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BeginToSpawnDangerousCardRoundIndex)) = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x000FDF94 File Offset: 0x000FC194
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x000114B3 File Offset: 0x0000F6B3
		public unsafe int m_UnlockAllLevel2SpotRoundIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel2SpotRoundIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel2SpotRoundIndex)) = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x000FDFBC File Offset: 0x000FC1BC
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x000114CE File Offset: 0x0000F6CE
		public unsafe int m_UnlockAllLevel3SpotRoundIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel3SpotRoundIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_UnlockAllLevel3SpotRoundIndex)) = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x000FDFE4 File Offset: 0x000FC1E4
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x000114E9 File Offset: 0x0000F6E9
		public unsafe Il2CppStructArray<TriggerCardData> m_GachaTriggerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaTriggerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TriggerCardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaTriggerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x000FE014 File Offset: 0x000FC214
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x00011508 File Offset: 0x0000F708
		public unsafe Il2CppReferenceArray<RogueLikeCardRewardPair> m_GachaRewardPairData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCardRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x000FE044 File Offset: 0x000FC244
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x00011527 File Offset: 0x0000F727
		public unsafe float m_LuckyLeafExtraMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_LuckyLeafExtraMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_LuckyLeafExtraMultiplier)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000FE06C File Offset: 0x000FC26C
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x00011542 File Offset: 0x0000F742
		public unsafe int m_AyaNewsBeginRoundIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AyaNewsBeginRoundIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AyaNewsBeginRoundIndex)) = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x000FE094 File Offset: 0x000FC294
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0001155D File Offset: 0x0000F75D
		public unsafe int m_PriceToRefreshAyaNews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PriceToRefreshAyaNews);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_PriceToRefreshAyaNews)) = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x000FE0BC File Offset: 0x000FC2BC
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x00011578 File Offset: 0x0000F778
		public unsafe int m_AkyuuWashiPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AkyuuWashiPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_AkyuuWashiPrice)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x000FE0E4 File Offset: 0x000FC2E4
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00011593 File Offset: 0x0000F793
		public unsafe int m_EllenCandyPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EllenCandyPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EllenCandyPrice)) = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x000FE10C File Offset: 0x000FC30C
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x000115AE File Offset: 0x0000F7AE
		public unsafe float m_KourindouDiscount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_KourindouDiscount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_KourindouDiscount)) = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000FE134 File Offset: 0x000FC334
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x000115C9 File Offset: 0x0000F7C9
		public unsafe float m_CookerCollectWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerCollectWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_CookerCollectWeight)) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000FE15C File Offset: 0x000FC35C
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x000115E4 File Offset: 0x0000F7E4
		public unsafe float m_DecorationCollectWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationCollectWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_DecorationCollectWeight)) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x000FE184 File Offset: 0x000FC384
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x000115FF File Offset: 0x0000F7FF
		public unsafe float m_ClothesCollectWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesCollectWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_ClothesCollectWeight)) = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000FE1AC File Offset: 0x000FC3AC
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0001161A File Offset: 0x0000F81A
		public unsafe float m_EachMapMaxCollectRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EachMapMaxCollectRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_EachMapMaxCollectRate)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000FE1D4 File Offset: 0x000FC3D4
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00011635 File Offset: 0x0000F835
		public unsafe int m_GachaRecipeInitialNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRecipeInitialNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaRecipeInitialNum)) = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000FE1FC File Offset: 0x000FC3FC
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x00011650 File Offset: 0x0000F850
		public unsafe int m_GachaBevInitialNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaBevInitialNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_GachaBevInitialNum)) = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x000FE224 File Offset: 0x000FC424
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0001166B File Offset: 0x0000F86B
		public unsafe int m_SelectRecipeInitialNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SelectRecipeInitialNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SelectRecipeInitialNum)) = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000FE24C File Offset: 0x000FC44C
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00011686 File Offset: 0x0000F886
		public unsafe int m_BaseGachaNumWhenSettle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseGachaNumWhenSettle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseGachaNumWhenSettle)) = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000FE274 File Offset: 0x000FC474
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x000116A1 File Offset: 0x0000F8A1
		public unsafe int m_BaseMoveAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseMoveAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseMoveAction)) = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000FE29C File Offset: 0x000FC49C
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x000116BC File Offset: 0x0000F8BC
		public unsafe int m_BaseIngredientNumWhenGetRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseIngredientNumWhenGetRecipe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_BaseIngredientNumWhenGetRecipe)) = value;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x000116D7 File Offset: 0x0000F8D7
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> m_SpecialGuestVisitEverywhere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x000FE2F4 File Offset: 0x000FC4F4
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x000116F6 File Offset: 0x0000F8F6
		public unsafe int m_StartFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_StartFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.NativeFieldInfoPtr_m_StartFund)) = value;
			}
		}

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialProducts;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialRecipePool;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialBevPool;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_m_BevLevelLinkToNum;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_m_RoundDuration;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalProductMultiplier;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_m_RoundSetups;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_m_MapSetups;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1RecipePriceMultiplier;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2RecipePriceMultiplier;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_m_Level3RecipePriceMultiplier;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_m_Level4RecipePriceMultiplier;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_m_Level5RecipePriceMultiplier;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerBasePrice;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestPrice;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteSpecialGuestPrice;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesPrice;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationPrice;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerPriceSetups;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaNeedComboNum;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaNeedSpellNum;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaMaxCardNum;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_m_BeginToSpawnDangerousCardRoundIndex;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeFieldInfoPtr_m_UnlockAllLevel2SpotRoundIndex;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeFieldInfoPtr_m_UnlockAllLevel3SpotRoundIndex;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaTriggerData;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRewardPairData;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeFieldInfoPtr_m_LuckyLeafExtraMultiplier;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeFieldInfoPtr_m_AyaNewsBeginRoundIndex;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeFieldInfoPtr_m_PriceToRefreshAyaNews;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_m_AkyuuWashiPrice;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_m_EllenCandyPrice;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeFieldInfoPtr_m_KourindouDiscount;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerCollectWeight;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationCollectWeight;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesCollectWeight;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_m_EachMapMaxCollectRate;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRecipeInitialNum;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaBevInitialNum;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectRecipeInitialNum;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseGachaNumWhenSettle;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseMoveAction;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIngredientNumWhenGetRecipe;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_m_StartFund;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_SetRoundSetups_Public_Void_List_1_RogueLikeRoundSetup_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerCollectWeight_Public_get_Single_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationCollectWeight_Public_get_Single_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_get_ClothesCollectWeight_Public_get_Single_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_get_EachMapMaxCollectRate_Public_get_Single_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006CF RID: 1743
		[Serializable]
		public class RogueLikeRoundSetup : Il2CppSystem.Object
		{
			// Token: 0x060099EF RID: 39407 RVA: 0x00290250 File Offset: 0x0028E450
			// Note: this type is marked as 'beforefieldinit'.
			static RogueLikeRoundSetup()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "RogueLikeRoundSetup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_IncomeRequirement");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_IncomeRequirementN");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_IncomeRequirementH");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_IncomeRequirementL");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestSpawnRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_GuestSpawnRateMultiplier");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestFundMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_GuestFundMultiplier");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_RecipeAddToPoolAfterWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_RecipeAddToPoolAfterWave");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_BevAddToPoolAfterWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, "m_BevAddToPoolAfterWave");
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668432);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirement_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668433);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementN_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668434);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementH_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668435);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementL_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668436);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_GuestSpawnRateMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668437);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_GuestFundMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668438);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_RecipeAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668439);
				DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_BevAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr, 100668440);
			}

			// Token: 0x060099F0 RID: 39408 RVA: 0x002903D0 File Offset: 0x0028E5D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73512, XrefRangeEnd = 73515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeRoundSetup(int incomeRequirement, float guestSpawnRateMultiplier, float guestFundMultiplier, Il2CppStructArray<int> recipeAddToPoolAfterWave, Il2CppStructArray<int> bevAddToPoolAfterWave) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref incomeRequirement;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestSpawnRateMultiplier;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestFundMultiplier;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipeAddToPoolAfterWave);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bevAddToPoolAfterWave);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700331C RID: 13084
			// (get) Token: 0x060099F1 RID: 39409 RVA: 0x0029045C File Offset: 0x0028E65C
			public unsafe int IncomeRequirement
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirement_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700331D RID: 13085
			// (get) Token: 0x060099F2 RID: 39410 RVA: 0x00290498 File Offset: 0x0028E698
			public unsafe int IncomeRequirementN
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementN_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700331E RID: 13086
			// (get) Token: 0x060099F3 RID: 39411 RVA: 0x002904D4 File Offset: 0x0028E6D4
			public unsafe int IncomeRequirementH
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementH_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700331F RID: 13087
			// (get) Token: 0x060099F4 RID: 39412 RVA: 0x00290510 File Offset: 0x0028E710
			public unsafe int IncomeRequirementL
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_IncomeRequirementL_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003320 RID: 13088
			// (get) Token: 0x060099F5 RID: 39413 RVA: 0x0029054C File Offset: 0x0028E74C
			public unsafe float GuestSpawnRateMultiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_GuestSpawnRateMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003321 RID: 13089
			// (get) Token: 0x060099F6 RID: 39414 RVA: 0x00290588 File Offset: 0x0028E788
			public unsafe float GuestFundMultiplier
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_GuestFundMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003322 RID: 13090
			// (get) Token: 0x060099F7 RID: 39415 RVA: 0x002905C4 File Offset: 0x0028E7C4
			public unsafe Il2CppStructArray<int> RecipeAddToPoolAfterWave
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_RecipeAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003323 RID: 13091
			// (get) Token: 0x060099F8 RID: 39416 RVA: 0x00290604 File Offset: 0x0028E804
			public unsafe Il2CppStructArray<int> BevAddToPoolAfterWave
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeMethodInfoPtr_get_BevAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x060099F9 RID: 39417 RVA: 0x00053491 File Offset: 0x00051691
			public RogueLikeRoundSetup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003314 RID: 13076
			// (get) Token: 0x060099FA RID: 39418 RVA: 0x00290644 File Offset: 0x0028E844
			// (set) Token: 0x060099FB RID: 39419 RVA: 0x0005349A File Offset: 0x0005169A
			public unsafe int m_IncomeRequirement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirement)) = value;
				}
			}

			// Token: 0x17003315 RID: 13077
			// (get) Token: 0x060099FC RID: 39420 RVA: 0x0029066C File Offset: 0x0028E86C
			// (set) Token: 0x060099FD RID: 39421 RVA: 0x000534B5 File Offset: 0x000516B5
			public unsafe int m_IncomeRequirementN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementN);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementN)) = value;
				}
			}

			// Token: 0x17003316 RID: 13078
			// (get) Token: 0x060099FE RID: 39422 RVA: 0x00290694 File Offset: 0x0028E894
			// (set) Token: 0x060099FF RID: 39423 RVA: 0x000534D0 File Offset: 0x000516D0
			public unsafe int m_IncomeRequirementH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementH);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementH)) = value;
				}
			}

			// Token: 0x17003317 RID: 13079
			// (get) Token: 0x06009A00 RID: 39424 RVA: 0x002906BC File Offset: 0x0028E8BC
			// (set) Token: 0x06009A01 RID: 39425 RVA: 0x000534EB File Offset: 0x000516EB
			public unsafe int m_IncomeRequirementL
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementL);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_IncomeRequirementL)) = value;
				}
			}

			// Token: 0x17003318 RID: 13080
			// (get) Token: 0x06009A02 RID: 39426 RVA: 0x002906E4 File Offset: 0x0028E8E4
			// (set) Token: 0x06009A03 RID: 39427 RVA: 0x00053506 File Offset: 0x00051706
			public unsafe float m_GuestSpawnRateMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestSpawnRateMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestSpawnRateMultiplier)) = value;
				}
			}

			// Token: 0x17003319 RID: 13081
			// (get) Token: 0x06009A04 RID: 39428 RVA: 0x0029070C File Offset: 0x0028E90C
			// (set) Token: 0x06009A05 RID: 39429 RVA: 0x00053521 File Offset: 0x00051721
			public unsafe float m_GuestFundMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestFundMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_GuestFundMultiplier)) = value;
				}
			}

			// Token: 0x1700331A RID: 13082
			// (get) Token: 0x06009A06 RID: 39430 RVA: 0x00290734 File Offset: 0x0028E934
			// (set) Token: 0x06009A07 RID: 39431 RVA: 0x0005353C File Offset: 0x0005173C
			public unsafe Il2CppStructArray<int> m_RecipeAddToPoolAfterWave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_RecipeAddToPoolAfterWave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_RecipeAddToPoolAfterWave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700331B RID: 13083
			// (get) Token: 0x06009A08 RID: 39432 RVA: 0x00290764 File Offset: 0x0028E964
			// (set) Token: 0x06009A09 RID: 39433 RVA: 0x0005355B File Offset: 0x0005175B
			public unsafe Il2CppStructArray<int> m_BevAddToPoolAfterWave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_BevAddToPoolAfterWave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeRoundSetup.NativeFieldInfoPtr_m_BevAddToPoolAfterWave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006396 RID: 25494
			private static readonly IntPtr NativeFieldInfoPtr_m_IncomeRequirement;

			// Token: 0x04006397 RID: 25495
			private static readonly IntPtr NativeFieldInfoPtr_m_IncomeRequirementN;

			// Token: 0x04006398 RID: 25496
			private static readonly IntPtr NativeFieldInfoPtr_m_IncomeRequirementH;

			// Token: 0x04006399 RID: 25497
			private static readonly IntPtr NativeFieldInfoPtr_m_IncomeRequirementL;

			// Token: 0x0400639A RID: 25498
			private static readonly IntPtr NativeFieldInfoPtr_m_GuestSpawnRateMultiplier;

			// Token: 0x0400639B RID: 25499
			private static readonly IntPtr NativeFieldInfoPtr_m_GuestFundMultiplier;

			// Token: 0x0400639C RID: 25500
			private static readonly IntPtr NativeFieldInfoPtr_m_RecipeAddToPoolAfterWave;

			// Token: 0x0400639D RID: 25501
			private static readonly IntPtr NativeFieldInfoPtr_m_BevAddToPoolAfterWave;

			// Token: 0x0400639E RID: 25502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400639F RID: 25503
			private static readonly IntPtr NativeMethodInfoPtr_get_IncomeRequirement_Public_get_Int32_0;

			// Token: 0x040063A0 RID: 25504
			private static readonly IntPtr NativeMethodInfoPtr_get_IncomeRequirementN_Public_get_Int32_0;

			// Token: 0x040063A1 RID: 25505
			private static readonly IntPtr NativeMethodInfoPtr_get_IncomeRequirementH_Public_get_Int32_0;

			// Token: 0x040063A2 RID: 25506
			private static readonly IntPtr NativeMethodInfoPtr_get_IncomeRequirementL_Public_get_Int32_0;

			// Token: 0x040063A3 RID: 25507
			private static readonly IntPtr NativeMethodInfoPtr_get_GuestSpawnRateMultiplier_Public_get_Single_0;

			// Token: 0x040063A4 RID: 25508
			private static readonly IntPtr NativeMethodInfoPtr_get_GuestFundMultiplier_Public_get_Single_0;

			// Token: 0x040063A5 RID: 25509
			private static readonly IntPtr NativeMethodInfoPtr_get_RecipeAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x040063A6 RID: 25510
			private static readonly IntPtr NativeMethodInfoPtr_get_BevAddToPoolAfterWave_Public_get_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x020006D0 RID: 1744
		[Serializable]
		public sealed class MapSetup : ValueType
		{
			// Token: 0x06009A0A RID: 39434 RVA: 0x00290794 File Offset: 0x0028E994
			// Note: this type is marked as 'beforefieldinit'.
			static MapSetup()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "MapSetup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr);
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_MapName");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_Ingredients");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_PartnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_PartnerId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpawnedSpecialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_SpawnedSpecialGuestId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpecialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_SpecialGuestId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_ClothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_ClothesId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_DecorationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_DecorationId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_CookerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_CookerId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_RecipeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_RecipeId");
				DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MerchantIngredientDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "m_MerchantIngredientDiscount");
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_MapName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668441);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_Ingredients_Public_get_IReadOnlyList_1_IngredientRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668442);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_PartnerId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668443);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_SpawnedSpecialGuestId_Public_get_IReadOnlyList_1_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668444);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_SpecialGuestId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668445);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_ClothesId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668446);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_DecorationId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668447);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_CookerId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668448);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_RecipeId_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668449);
				DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_MerchantIngredientDiscount_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, 100668450);
			}

			// Token: 0x1700332E RID: 13102
			// (get) Token: 0x06009A0B RID: 39435 RVA: 0x00290950 File Offset: 0x0028EB50
			public unsafe string MapName
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_MapName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700332F RID: 13103
			// (get) Token: 0x06009A0C RID: 39436 RVA: 0x0029098C File Offset: 0x0028EB8C
			public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange> Ingredients
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_Ingredients_Public_get_IReadOnlyList_1_IngredientRange_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>>(intPtr3) : null;
				}
			}

			// Token: 0x17003330 RID: 13104
			// (get) Token: 0x06009A0D RID: 39437 RVA: 0x002909D0 File Offset: 0x0028EBD0
			public unsafe IReadOnlyList<int> PartnerId
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_PartnerId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003331 RID: 13105
			// (get) Token: 0x06009A0E RID: 39438 RVA: 0x00290A14 File Offset: 0x0028EC14
			public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpawnedSpecialGuestId
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_SpawnedSpecialGuestId_Public_get_IReadOnlyList_1_ConditionalSpecialGuest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr3) : null;
				}
			}

			// Token: 0x17003332 RID: 13106
			// (get) Token: 0x06009A0F RID: 39439 RVA: 0x00290A58 File Offset: 0x0028EC58
			public unsafe IReadOnlyList<int> SpecialGuestId
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_SpecialGuestId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003333 RID: 13107
			// (get) Token: 0x06009A10 RID: 39440 RVA: 0x00290A9C File Offset: 0x0028EC9C
			public unsafe IReadOnlyList<int> ClothesId
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_ClothesId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003334 RID: 13108
			// (get) Token: 0x06009A11 RID: 39441 RVA: 0x00290AE0 File Offset: 0x0028ECE0
			public unsafe IReadOnlyList<int> DecorationId
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_DecorationId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003335 RID: 13109
			// (get) Token: 0x06009A12 RID: 39442 RVA: 0x00290B24 File Offset: 0x0028ED24
			public unsafe IReadOnlyList<int> CookerId
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_CookerId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003336 RID: 13110
			// (get) Token: 0x06009A13 RID: 39443 RVA: 0x00290B68 File Offset: 0x0028ED68
			public unsafe IReadOnlyList<int> RecipeId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_RecipeId_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003337 RID: 13111
			// (get) Token: 0x06009A14 RID: 39444 RVA: 0x00290BAC File Offset: 0x0028EDAC
			public unsafe Vector2 MerchantIngredientDiscount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.NativeMethodInfoPtr_get_MerchantIngredientDiscount_Public_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009A15 RID: 39445 RVA: 0x0005357A File Offset: 0x0005177A
			public MapSetup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009A16 RID: 39446 RVA: 0x00053583 File Offset: 0x00051783
			public MapSetup() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr))
			{
			}

			// Token: 0x17003324 RID: 13092
			// (get) Token: 0x06009A17 RID: 39447 RVA: 0x00290BF0 File Offset: 0x0028EDF0
			// (set) Token: 0x06009A18 RID: 39448 RVA: 0x00053595 File Offset: 0x00051795
			public unsafe string m_MapName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MapName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003325 RID: 13093
			// (get) Token: 0x06009A19 RID: 39449 RVA: 0x00290C18 File Offset: 0x0028EE18
			// (set) Token: 0x06009A1A RID: 39450 RVA: 0x000535B4 File Offset: 0x000517B4
			public unsafe Il2CppStructArray<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange> m_Ingredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_Ingredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003326 RID: 13094
			// (get) Token: 0x06009A1B RID: 39451 RVA: 0x00290C48 File Offset: 0x0028EE48
			// (set) Token: 0x06009A1C RID: 39452 RVA: 0x000535D3 File Offset: 0x000517D3
			public unsafe Il2CppStructArray<int> m_PartnerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_PartnerId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_PartnerId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003327 RID: 13095
			// (get) Token: 0x06009A1D RID: 39453 RVA: 0x00290C78 File Offset: 0x0028EE78
			// (set) Token: 0x06009A1E RID: 39454 RVA: 0x000535F2 File Offset: 0x000517F2
			public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> m_SpawnedSpecialGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpawnedSpecialGuestId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpawnedSpecialGuestId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003328 RID: 13096
			// (get) Token: 0x06009A1F RID: 39455 RVA: 0x00290CA8 File Offset: 0x0028EEA8
			// (set) Token: 0x06009A20 RID: 39456 RVA: 0x00053611 File Offset: 0x00051811
			public unsafe Il2CppStructArray<int> m_SpecialGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpecialGuestId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_SpecialGuestId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003329 RID: 13097
			// (get) Token: 0x06009A21 RID: 39457 RVA: 0x00290CD8 File Offset: 0x0028EED8
			// (set) Token: 0x06009A22 RID: 39458 RVA: 0x00053630 File Offset: 0x00051830
			public unsafe Il2CppStructArray<int> m_ClothesId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_ClothesId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_ClothesId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332A RID: 13098
			// (get) Token: 0x06009A23 RID: 39459 RVA: 0x00290D08 File Offset: 0x0028EF08
			// (set) Token: 0x06009A24 RID: 39460 RVA: 0x0005364F File Offset: 0x0005184F
			public unsafe Il2CppStructArray<int> m_DecorationId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_DecorationId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_DecorationId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332B RID: 13099
			// (get) Token: 0x06009A25 RID: 39461 RVA: 0x00290D38 File Offset: 0x0028EF38
			// (set) Token: 0x06009A26 RID: 39462 RVA: 0x0005366E File Offset: 0x0005186E
			public unsafe Il2CppStructArray<int> m_CookerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_CookerId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_CookerId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332C RID: 13100
			// (get) Token: 0x06009A27 RID: 39463 RVA: 0x00290D68 File Offset: 0x0028EF68
			// (set) Token: 0x06009A28 RID: 39464 RVA: 0x0005368D File Offset: 0x0005188D
			public unsafe Il2CppStructArray<int> m_RecipeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_RecipeId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_RecipeId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700332D RID: 13101
			// (get) Token: 0x06009A29 RID: 39465 RVA: 0x00290D98 File Offset: 0x0028EF98
			// (set) Token: 0x06009A2A RID: 39466 RVA: 0x000536AC File Offset: 0x000518AC
			public unsafe Vector2 m_MerchantIngredientDiscount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MerchantIngredientDiscount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.NativeFieldInfoPtr_m_MerchantIngredientDiscount)) = value;
				}
			}

			// Token: 0x040063A7 RID: 25511
			private static readonly IntPtr NativeFieldInfoPtr_m_MapName;

			// Token: 0x040063A8 RID: 25512
			private static readonly IntPtr NativeFieldInfoPtr_m_Ingredients;

			// Token: 0x040063A9 RID: 25513
			private static readonly IntPtr NativeFieldInfoPtr_m_PartnerId;

			// Token: 0x040063AA RID: 25514
			private static readonly IntPtr NativeFieldInfoPtr_m_SpawnedSpecialGuestId;

			// Token: 0x040063AB RID: 25515
			private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestId;

			// Token: 0x040063AC RID: 25516
			private static readonly IntPtr NativeFieldInfoPtr_m_ClothesId;

			// Token: 0x040063AD RID: 25517
			private static readonly IntPtr NativeFieldInfoPtr_m_DecorationId;

			// Token: 0x040063AE RID: 25518
			private static readonly IntPtr NativeFieldInfoPtr_m_CookerId;

			// Token: 0x040063AF RID: 25519
			private static readonly IntPtr NativeFieldInfoPtr_m_RecipeId;

			// Token: 0x040063B0 RID: 25520
			private static readonly IntPtr NativeFieldInfoPtr_m_MerchantIngredientDiscount;

			// Token: 0x040063B1 RID: 25521
			private static readonly IntPtr NativeMethodInfoPtr_get_MapName_Public_get_String_0;

			// Token: 0x040063B2 RID: 25522
			private static readonly IntPtr NativeMethodInfoPtr_get_Ingredients_Public_get_IReadOnlyList_1_IngredientRange_0;

			// Token: 0x040063B3 RID: 25523
			private static readonly IntPtr NativeMethodInfoPtr_get_PartnerId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063B4 RID: 25524
			private static readonly IntPtr NativeMethodInfoPtr_get_SpawnedSpecialGuestId_Public_get_IReadOnlyList_1_ConditionalSpecialGuest_0;

			// Token: 0x040063B5 RID: 25525
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063B6 RID: 25526
			private static readonly IntPtr NativeMethodInfoPtr_get_ClothesId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063B7 RID: 25527
			private static readonly IntPtr NativeMethodInfoPtr_get_DecorationId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063B8 RID: 25528
			private static readonly IntPtr NativeMethodInfoPtr_get_CookerId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063B9 RID: 25529
			private static readonly IntPtr NativeMethodInfoPtr_get_RecipeId_Public_get_IReadOnlyList_1_Int32_0;

			// Token: 0x040063BA RID: 25530
			private static readonly IntPtr NativeMethodInfoPtr_get_MerchantIngredientDiscount_Public_get_Vector2_0;

			// Token: 0x02000FC9 RID: 4041
			[Serializable]
			[StructLayout(2)]
			public struct IngredientRange
			{
				// Token: 0x06011624 RID: 71204 RVA: 0x003FF2D0 File Offset: 0x003FD4D0
				// Note: this type is marked as 'beforefieldinit'.
				static IngredientRange()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "IngredientRange");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr);
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeFieldInfoPtr_m_IngredientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, "m_IngredientId");
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, "m_Range");
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeFieldInfoPtr_m_IsBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, "m_IsBeverage");
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_IngredientId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, 100668451);
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_Range_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, 100668452);
					DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_IsBeverage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, 100668453);
				}

				// Token: 0x17005A5A RID: 23130
				// (get) Token: 0x06011625 RID: 71205 RVA: 0x003FF374 File Offset: 0x003FD574
				public unsafe int IngredientId
				{
					[CallerCount(140)]
					[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_IngredientId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17005A5B RID: 23131
				// (get) Token: 0x06011626 RID: 71206 RVA: 0x003FF3A4 File Offset: 0x003FD5A4
				public unsafe Vector2Int Range
				{
					[CallerCount(0)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_Range_Public_get_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17005A5C RID: 23132
				// (get) Token: 0x06011627 RID: 71207 RVA: 0x003FF3D4 File Offset: 0x003FD5D4
				public unsafe bool IsBeverage
				{
					[CallerCount(0)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange.NativeMethodInfoPtr_get_IsBeverage_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06011628 RID: 71208 RVA: 0x00097441 File Offset: 0x00095641
				public Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange>.NativeClassPtr, ref this));
				}

				// Token: 0x0400AFA9 RID: 44969
				private static readonly IntPtr NativeFieldInfoPtr_m_IngredientId;

				// Token: 0x0400AFAA RID: 44970
				private static readonly IntPtr NativeFieldInfoPtr_m_Range;

				// Token: 0x0400AFAB RID: 44971
				private static readonly IntPtr NativeFieldInfoPtr_m_IsBeverage;

				// Token: 0x0400AFAC RID: 44972
				private static readonly IntPtr NativeMethodInfoPtr_get_IngredientId_Public_get_Int32_0;

				// Token: 0x0400AFAD RID: 44973
				private static readonly IntPtr NativeMethodInfoPtr_get_Range_Public_get_Vector2Int_0;

				// Token: 0x0400AFAE RID: 44974
				private static readonly IntPtr NativeMethodInfoPtr_get_IsBeverage_Public_get_Boolean_0;

				// Token: 0x0400AFAF RID: 44975
				[FieldOffset(0)]
				public int m_IngredientId;

				// Token: 0x0400AFB0 RID: 44976
				[FieldOffset(4)]
				public Vector2Int m_Range;

				// Token: 0x0400AFB1 RID: 44977
				[FieldOffset(12)]
				[MarshalAs(4)]
				public bool m_IsBeverage;
			}

			// Token: 0x02000FCA RID: 4042
			[Serializable]
			public sealed class ConditionalSpecialGuest : ValueType
			{
				// Token: 0x06011629 RID: 71209 RVA: 0x003FF404 File Offset: 0x003FD604
				// Note: this type is marked as 'beforefieldinit'.
				static ConditionalSpecialGuest()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, "ConditionalSpecialGuest");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr);
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_SpecialGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, "m_SpecialGuestId");
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_DependentAreaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, "m_DependentAreaName");
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowAreaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, "m_ShowAreaName");
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowOnlyAfterPlayerUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, "m_ShowOnlyAfterPlayerUnlock");
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, "m_ShowWeight");
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_SpecialGuestId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, 100668454);
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_DependentAreaName_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, 100668455);
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowAreaName_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, 100668456);
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowOnlyAfterPlayerUnlock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, 100668457);
					DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr, 100668458);
				}

				// Token: 0x17005A62 RID: 23138
				// (get) Token: 0x0601162A RID: 71210 RVA: 0x003FF4F8 File Offset: 0x003FD6F8
				public unsafe int SpecialGuestId
				{
					[CallerCount(140)]
					[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_SpecialGuestId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17005A63 RID: 23139
				// (get) Token: 0x0601162B RID: 71211 RVA: 0x003FF53C File Offset: 0x003FD73C
				public unsafe IReadOnlyList<string> DependentAreaName
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_DependentAreaName_Public_get_IReadOnlyList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
					}
				}

				// Token: 0x17005A64 RID: 23140
				// (get) Token: 0x0601162C RID: 71212 RVA: 0x003FF580 File Offset: 0x003FD780
				public unsafe IReadOnlyList<string> ShowAreaName
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowAreaName_Public_get_IReadOnlyList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
					}
				}

				// Token: 0x17005A65 RID: 23141
				// (get) Token: 0x0601162D RID: 71213 RVA: 0x003FF5C4 File Offset: 0x003FD7C4
				public unsafe bool ShowOnlyAfterPlayerUnlock
				{
					[CallerCount(1)]
					[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowOnlyAfterPlayerUnlock_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x17005A66 RID: 23142
				// (get) Token: 0x0601162E RID: 71214 RVA: 0x003FF608 File Offset: 0x003FD808
				public unsafe float ShowWeight
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeMethodInfoPtr_get_ShowWeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0601162F RID: 71215 RVA: 0x00097453 File Offset: 0x00095653
				public ConditionalSpecialGuest(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06011630 RID: 71216 RVA: 0x0009745C File Offset: 0x0009565C
				public ConditionalSpecialGuest() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>.NativeClassPtr))
				{
				}

				// Token: 0x17005A5D RID: 23133
				// (get) Token: 0x06011631 RID: 71217 RVA: 0x003FF64C File Offset: 0x003FD84C
				// (set) Token: 0x06011632 RID: 71218 RVA: 0x0009746E File Offset: 0x0009566E
				public unsafe int m_SpecialGuestId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_SpecialGuestId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_SpecialGuestId)) = value;
					}
				}

				// Token: 0x17005A5E RID: 23134
				// (get) Token: 0x06011633 RID: 71219 RVA: 0x003FF674 File Offset: 0x003FD874
				// (set) Token: 0x06011634 RID: 71220 RVA: 0x00097489 File Offset: 0x00095689
				public unsafe Il2CppStringArray m_DependentAreaName
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_DependentAreaName);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_DependentAreaName), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A5F RID: 23135
				// (get) Token: 0x06011635 RID: 71221 RVA: 0x003FF6A4 File Offset: 0x003FD8A4
				// (set) Token: 0x06011636 RID: 71222 RVA: 0x000974A8 File Offset: 0x000956A8
				public unsafe Il2CppStringArray m_ShowAreaName
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowAreaName);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowAreaName), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A60 RID: 23136
				// (get) Token: 0x06011637 RID: 71223 RVA: 0x003FF6D4 File Offset: 0x003FD8D4
				// (set) Token: 0x06011638 RID: 71224 RVA: 0x000974C7 File Offset: 0x000956C7
				public unsafe bool m_ShowOnlyAfterPlayerUnlock
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowOnlyAfterPlayerUnlock);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowOnlyAfterPlayerUnlock)) = value;
					}
				}

				// Token: 0x17005A61 RID: 23137
				// (get) Token: 0x06011639 RID: 71225 RVA: 0x003FF6FC File Offset: 0x003FD8FC
				// (set) Token: 0x0601163A RID: 71226 RVA: 0x000974E2 File Offset: 0x000956E2
				public unsafe float m_ShowWeight
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowWeight);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest.NativeFieldInfoPtr_m_ShowWeight)) = value;
					}
				}

				// Token: 0x0400AFB2 RID: 44978
				private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestId;

				// Token: 0x0400AFB3 RID: 44979
				private static readonly IntPtr NativeFieldInfoPtr_m_DependentAreaName;

				// Token: 0x0400AFB4 RID: 44980
				private static readonly IntPtr NativeFieldInfoPtr_m_ShowAreaName;

				// Token: 0x0400AFB5 RID: 44981
				private static readonly IntPtr NativeFieldInfoPtr_m_ShowOnlyAfterPlayerUnlock;

				// Token: 0x0400AFB6 RID: 44982
				private static readonly IntPtr NativeFieldInfoPtr_m_ShowWeight;

				// Token: 0x0400AFB7 RID: 44983
				private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestId_Public_get_Int32_0;

				// Token: 0x0400AFB8 RID: 44984
				private static readonly IntPtr NativeMethodInfoPtr_get_DependentAreaName_Public_get_IReadOnlyList_1_String_0;

				// Token: 0x0400AFB9 RID: 44985
				private static readonly IntPtr NativeMethodInfoPtr_get_ShowAreaName_Public_get_IReadOnlyList_1_String_0;

				// Token: 0x0400AFBA RID: 44986
				private static readonly IntPtr NativeMethodInfoPtr_get_ShowOnlyAfterPlayerUnlock_Public_get_Boolean_0;

				// Token: 0x0400AFBB RID: 44987
				private static readonly IntPtr NativeMethodInfoPtr_get_ShowWeight_Public_get_Single_0;
			}
		}

		// Token: 0x020006D1 RID: 1745
		[Serializable]
		[StructLayout(2)]
		public struct CookerPriceSetup
		{
			// Token: 0x06009A2B RID: 39467 RVA: 0x00290DC0 File Offset: 0x0028EFC0
			// Note: this type is marked as 'beforefieldinit'.
			static CookerPriceSetup()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "CookerPriceSetup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr);
				DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeFieldInfoPtr_m_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr, "m_Price");
				DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeFieldInfoPtr_m_CookerSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr, "m_CookerSeries");
				DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeMethodInfoPtr_get_Price_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr, 100668459);
				DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeMethodInfoPtr_get_CookerSeries_Public_get_CookerSeries_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr, 100668460);
			}

			// Token: 0x17003338 RID: 13112
			// (get) Token: 0x06009A2C RID: 39468 RVA: 0x00290E3C File Offset: 0x0028F03C
			public unsafe int Price
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeMethodInfoPtr_get_Price_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003339 RID: 13113
			// (get) Token: 0x06009A2D RID: 39469 RVA: 0x00290E6C File Offset: 0x0028F06C
			public unsafe Cooker.CookerSeries CookerSeries
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeDataProfile.CookerPriceSetup.NativeMethodInfoPtr_get_CookerSeries_Public_get_CookerSeries_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009A2E RID: 39470 RVA: 0x000536C7 File Offset: 0x000518C7
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CookerPriceSetup>.NativeClassPtr, ref this));
			}

			// Token: 0x040063BB RID: 25531
			private static readonly IntPtr NativeFieldInfoPtr_m_Price;

			// Token: 0x040063BC RID: 25532
			private static readonly IntPtr NativeFieldInfoPtr_m_CookerSeries;

			// Token: 0x040063BD RID: 25533
			private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Int32_0;

			// Token: 0x040063BE RID: 25534
			private static readonly IntPtr NativeMethodInfoPtr_get_CookerSeries_Public_get_CookerSeries_0;

			// Token: 0x040063BF RID: 25535
			[FieldOffset(0)]
			public int m_Price;

			// Token: 0x040063C0 RID: 25536
			[FieldOffset(4)]
			public Cooker.CookerSeries m_CookerSeries;
		}

		// Token: 0x020006D2 RID: 1746
		[Serializable]
		public sealed class RogueLikeAchievement : ValueType
		{
			// Token: 0x06009A2F RID: 39471 RVA: 0x00290E9C File Offset: 0x0028F09C
			// Note: this type is marked as 'beforefieldinit'.
			static RogueLikeAchievement()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "RogueLikeAchievement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr);
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_RogueLikeAchievementType");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_RogueLikeAchievementTriggerType");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_BadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_BadgeId");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_TargetIntValue");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntArrayValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_TargetIntArrayValue");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetFloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_TargetFloatValue");
				DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_CardRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, "m_CardRequired");
			}

			// Token: 0x06009A30 RID: 39472 RVA: 0x000536D9 File Offset: 0x000518D9
			public RogueLikeAchievement(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009A31 RID: 39473 RVA: 0x000536E2 File Offset: 0x000518E2
			public RogueLikeAchievement() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr))
			{
			}

			// Token: 0x1700333A RID: 13114
			// (get) Token: 0x06009A32 RID: 39474 RVA: 0x00290F54 File Offset: 0x0028F154
			// (set) Token: 0x06009A33 RID: 39475 RVA: 0x000536F4 File Offset: 0x000518F4
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementType m_RogueLikeAchievementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementType)) = value;
				}
			}

			// Token: 0x1700333B RID: 13115
			// (get) Token: 0x06009A34 RID: 39476 RVA: 0x00290F7C File Offset: 0x0028F17C
			// (set) Token: 0x06009A35 RID: 39477 RVA: 0x0005370F File Offset: 0x0005190F
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType m_RogueLikeAchievementTriggerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_RogueLikeAchievementTriggerType)) = value;
				}
			}

			// Token: 0x1700333C RID: 13116
			// (get) Token: 0x06009A36 RID: 39478 RVA: 0x00290FA4 File Offset: 0x0028F1A4
			// (set) Token: 0x06009A37 RID: 39479 RVA: 0x0005372A File Offset: 0x0005192A
			public unsafe int m_BadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_BadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_BadgeId)) = value;
				}
			}

			// Token: 0x1700333D RID: 13117
			// (get) Token: 0x06009A38 RID: 39480 RVA: 0x00290FCC File Offset: 0x0028F1CC
			// (set) Token: 0x06009A39 RID: 39481 RVA: 0x00053745 File Offset: 0x00051945
			public unsafe int m_TargetIntValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntValue)) = value;
				}
			}

			// Token: 0x1700333E RID: 13118
			// (get) Token: 0x06009A3A RID: 39482 RVA: 0x00290FF4 File Offset: 0x0028F1F4
			// (set) Token: 0x06009A3B RID: 39483 RVA: 0x00053760 File Offset: 0x00051960
			public unsafe Il2CppStructArray<int> m_TargetIntArrayValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntArrayValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetIntArrayValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700333F RID: 13119
			// (get) Token: 0x06009A3C RID: 39484 RVA: 0x00291024 File Offset: 0x0028F224
			// (set) Token: 0x06009A3D RID: 39485 RVA: 0x0005377F File Offset: 0x0005197F
			public unsafe float m_TargetFloatValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetFloatValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_TargetFloatValue)) = value;
				}
			}

			// Token: 0x17003340 RID: 13120
			// (get) Token: 0x06009A3E RID: 39486 RVA: 0x0029104C File Offset: 0x0028F24C
			// (set) Token: 0x06009A3F RID: 39487 RVA: 0x0005379A File Offset: 0x0005199A
			public unsafe Il2CppStructArray<DLC5_RogueLikeDataProfile.CardRequired> m_CardRequired
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_CardRequired);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_RogueLikeDataProfile.CardRequired>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeDataProfile.RogueLikeAchievement.NativeFieldInfoPtr_m_CardRequired), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040063C1 RID: 25537
			private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeAchievementType;

			// Token: 0x040063C2 RID: 25538
			private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeAchievementTriggerType;

			// Token: 0x040063C3 RID: 25539
			private static readonly IntPtr NativeFieldInfoPtr_m_BadgeId;

			// Token: 0x040063C4 RID: 25540
			private static readonly IntPtr NativeFieldInfoPtr_m_TargetIntValue;

			// Token: 0x040063C5 RID: 25541
			private static readonly IntPtr NativeFieldInfoPtr_m_TargetIntArrayValue;

			// Token: 0x040063C6 RID: 25542
			private static readonly IntPtr NativeFieldInfoPtr_m_TargetFloatValue;

			// Token: 0x040063C7 RID: 25543
			private static readonly IntPtr NativeFieldInfoPtr_m_CardRequired;
		}

		// Token: 0x020006D3 RID: 1747
		[Serializable]
		[StructLayout(2)]
		public struct CardRequired
		{
			// Token: 0x06009A40 RID: 39488 RVA: 0x0029107C File Offset: 0x0028F27C
			// Note: this type is marked as 'beforefieldinit'.
			static CardRequired()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CardRequired>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile>.NativeClassPtr, "CardRequired");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CardRequired>.NativeClassPtr);
				DLC5_RogueLikeDataProfile.CardRequired.NativeFieldInfoPtr_CardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CardRequired>.NativeClassPtr, "CardType");
				DLC5_RogueLikeDataProfile.CardRequired.NativeFieldInfoPtr_needNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CardRequired>.NativeClassPtr, "needNum");
			}

			// Token: 0x06009A41 RID: 39489 RVA: 0x000537B9 File Offset: 0x000519B9
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.CardRequired>.NativeClassPtr, ref this));
			}

			// Token: 0x040063C8 RID: 25544
			private static readonly IntPtr NativeFieldInfoPtr_CardType;

			// Token: 0x040063C9 RID: 25545
			private static readonly IntPtr NativeFieldInfoPtr_needNum;

			// Token: 0x040063CA RID: 25546
			[FieldOffset(0)]
			public RogueLikeCardBase.CardType CardType;

			// Token: 0x040063CB RID: 25547
			[FieldOffset(4)]
			public int needNum;
		}

		// Token: 0x020006D4 RID: 1748
		public enum RogueLikeAchievementType
		{
			// Token: 0x040063CD RID: 25549
			Constant,
			// Token: 0x040063CE RID: 25550
			Constant,
			// Token: 0x040063CF RID: 25551
			Constant,
			// Token: 0x040063D0 RID: 25552
			Constant,
			// Token: 0x040063D1 RID: 25553
			Constant,
			// Token: 0x040063D2 RID: 25554
			Constant,
			// Token: 0x040063D3 RID: 25555
			Constant,
			// Token: 0x040063D4 RID: 25556
			Constant,
			// Token: 0x040063D5 RID: 25557
			Constant,
			// Token: 0x040063D6 RID: 25558
			Constant,
			// Token: 0x040063D7 RID: 25559
			Constant,
			// Token: 0x040063D8 RID: 25560
			Constant,
			// Token: 0x040063D9 RID: 25561
			Constant,
			// Token: 0x040063DA RID: 25562
			Constant,
			// Token: 0x040063DB RID: 25563
			Constant,
			// Token: 0x040063DC RID: 25564
			Constant,
			// Token: 0x040063DD RID: 25565
			Constant,
			// Token: 0x040063DE RID: 25566
			Constant,
			// Token: 0x040063DF RID: 25567
			Constant,
			// Token: 0x040063E0 RID: 25568
			Constant,
			// Token: 0x040063E1 RID: 25569
			Constant,
			// Token: 0x040063E2 RID: 25570
			Constant,
			// Token: 0x040063E3 RID: 25571
			Constant,
			// Token: 0x040063E4 RID: 25572
			Constant,
			// Token: 0x040063E5 RID: 25573
			Constant,
			// Token: 0x040063E6 RID: 25574
			Constant,
			// Token: 0x040063E7 RID: 25575
			Constant,
			// Token: 0x040063E8 RID: 25576
			Constant
		}

		// Token: 0x020006D5 RID: 1749
		public enum RogueLikeAchievementTriggerType
		{
			// Token: 0x040063EA RID: 25578
			FirstOpen,
			// Token: 0x040063EB RID: 25579
			GetCard,
			// Token: 0x040063EC RID: 25580
			GetCardOneNight,
			// Token: 0x040063ED RID: 25581
			GetPersistentCard,
			// Token: 0x040063EE RID: 25582
			GetCard_CollectTarget,
			// Token: 0x040063EF RID: 25583
			GetCard_InstantHit,
			// Token: 0x040063F0 RID: 25584
			GetPersistentCard_HellTrail,
			// Token: 0x040063F1 RID: 25585
			GetPersistentCard_KourindouDiscount,
			// Token: 0x040063F2 RID: 25586
			GetPersistentCard_BuyAllIngredients,
			// Token: 0x040063F3 RID: 25587
			GetPersistentCard_CollectIzakaya,
			// Token: 0x040063F4 RID: 25588
			LimitPass,
			// Token: 0x040063F5 RID: 25589
			GetPersistentCard_CollectTarget,
			// Token: 0x040063F6 RID: 25590
			CollectRecipe,
			// Token: 0x040063F7 RID: 25591
			CollectMoney,
			// Token: 0x040063F8 RID: 25592
			CostInKourindou,
			// Token: 0x040063F9 RID: 25593
			CollectRate,
			// Token: 0x040063FA RID: 25594
			FinishRogueLike,
			// Token: 0x040063FB RID: 25595
			AllAchievement,
			// Token: 0x040063FC RID: 25596
			FinishElite,
			// Token: 0x040063FD RID: 25597
			FinishYuyukoElite_Feed,
			// Token: 0x040063FE RID: 25598
			FinishYuyukoElite_Repell
		}
	}
}
