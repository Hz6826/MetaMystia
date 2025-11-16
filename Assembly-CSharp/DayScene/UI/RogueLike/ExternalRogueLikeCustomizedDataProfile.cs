using System;
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
	// Token: 0x0200012C RID: 300
	public class ExternalRogueLikeCustomizedDataProfile : Il2CppSystem.Object
	{
		// Token: 0x06002281 RID: 8833 RVA: 0x00110A08 File Offset: 0x0010EC08
		// Note: this type is marked as 'beforefieldinit'.
		static ExternalRogueLikeCustomizedDataProfile()
		{
			Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "ExternalRogueLikeCustomizedDataProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr);
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_InitialProducts");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialRecipePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_InitialRecipePool");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialBevPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_InitialBevPool");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_BevLevelLinkToNum");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_RoundSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_RoundSetups");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_MapSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_MapSetups");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_CookerPriceSetups");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaTriggerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_GachaTriggerData");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_GachaRewardPairData");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "m_SpecialGuestVisitEverywhere");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__RoundDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<RoundDuration>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GlobalProductMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GlobalProductMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level1RecipePriceMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<Level1RecipePriceMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level2RecipePriceMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<Level2RecipePriceMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level3RecipePriceMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<Level3RecipePriceMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level4RecipePriceMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<Level4RecipePriceMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level5RecipePriceMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<Level5RecipePriceMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PartnerBasePrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<PartnerBasePrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SpecialGuestPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<SpecialGuestPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EliteSpecialGuestPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<EliteSpecialGuestPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__ClothesPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<ClothesPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__DecorationPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<DecorationPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedComboNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GachaNeedComboNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedSpellNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GachaNeedSpellNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaMaxCardNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GachaMaxCardNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BeginToSpawnDangerousCardRoundIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<BeginToSpawnDangerousCardRoundIndex>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel2SpotRoundIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<UnlockAllLevel2SpotRoundIndex>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel3SpotRoundIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<UnlockAllLevel3SpotRoundIndex>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__LuckyLeafExtraMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<LuckyLeafExtraMultiplier>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AyaNewsBeginRoundIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<AyaNewsBeginRoundIndex>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PriceToRefreshAyaNews_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<PriceToRefreshAyaNews>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AkyuuWashiPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<AkyuuWashiPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EllenCandyPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<EllenCandyPrice>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__KourindouDiscount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<KourindouDiscount>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaRecipeInitialNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GachaRecipeInitialNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaBevInitialNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<GachaBevInitialNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SelectRecipeInitialNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<SelectRecipeInitialNum>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseGachaNumWhenSettle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<BaseGachaNumWhenSettle>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseMoveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<BaseMoveAction>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseIngredientNumWhenGetRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<BaseIngredientNumWhenGetRecipe>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__StartFund_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, "<StartFund>k__BackingField");
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669435);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669436);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669437);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669438);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669439);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669440);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669441);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669442);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669443);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669444);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669445);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669446);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669447);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669448);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669449);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669450);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669451);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669452);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669453);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669454);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669455);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669456);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669457);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669458);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669459);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669460);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669461);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669462);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669463);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669464);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669465);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669466);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669467);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669468);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669469);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669470);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669471);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669472);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669473);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669474);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669475);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669476);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_RogueLikeRoundSetup_Il2CppReferenceArray_1_MapSetup_Il2CppStructArray_1_CookerPriceSetup_Il2CppStructArray_1_TriggerCardData_Il2CppReferenceArray_1_RogueLikeCardRewardPair_Int32_Single_Single_Single_Single_Single_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ConditionalSpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669477);
			ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669478);
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x001110DC File Offset: 0x0010F2DC
		public unsafe virtual IReadOnlyList<Product> InitialProducts
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0011111C File Offset: 0x0010F31C
		public unsafe virtual IReadOnlyList<int> InitialRecipePool
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0011115C File Offset: 0x0010F35C
		public unsafe virtual IReadOnlyList<int> InitialBevPool
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0011119C File Offset: 0x0010F39C
		public unsafe virtual IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x001111DC File Offset: 0x0010F3DC
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0011121C File Offset: 0x0010F41C
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x0011125C File Offset: 0x0010F45C
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0011129C File Offset: 0x0010F49C
		public unsafe virtual IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TriggerCardData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x001112DC File Offset: 0x0010F4DC
		public unsafe virtual IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RogueLikeCardRewardPair>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0011131C File Offset: 0x0010F51C
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0011135C File Offset: 0x0010F55C
		public unsafe virtual int RoundDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00111398 File Offset: 0x0010F598
		public unsafe virtual float GlobalProductMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x001113D4 File Offset: 0x0010F5D4
		public unsafe virtual float Level1RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x00111410 File Offset: 0x0010F610
		public unsafe virtual float Level2RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x0011144C File Offset: 0x0010F64C
		public unsafe virtual float Level3RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x00111488 File Offset: 0x0010F688
		public unsafe virtual float Level4RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x001114C4 File Offset: 0x0010F6C4
		public unsafe virtual float Level5RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00111500 File Offset: 0x0010F700
		public unsafe virtual int PartnerBasePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0011153C File Offset: 0x0010F73C
		public unsafe virtual int SpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x00111578 File Offset: 0x0010F778
		public unsafe virtual int EliteSpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x001115B4 File Offset: 0x0010F7B4
		public unsafe virtual int ClothesPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x001115F0 File Offset: 0x0010F7F0
		public unsafe virtual int DecorationPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0011162C File Offset: 0x0010F82C
		public unsafe virtual int GachaNeedComboNum
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 49194, RefRangeEnd = 49208, XrefRangeStart = 49194, XrefRangeEnd = 49208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x00111668 File Offset: 0x0010F868
		public unsafe virtual int GachaNeedSpellNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x001116A4 File Offset: 0x0010F8A4
		public unsafe virtual int GachaMaxCardNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x001116E0 File Offset: 0x0010F8E0
		public unsafe virtual int BeginToSpawnDangerousCardRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0011171C File Offset: 0x0010F91C
		public unsafe virtual int UnlockAllLevel2SpotRoundIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30554, RefRangeEnd = 30555, XrefRangeStart = 30554, XrefRangeEnd = 30555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x00111758 File Offset: 0x0010F958
		public unsafe virtual int UnlockAllLevel3SpotRoundIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49210, RefRangeEnd = 49211, XrefRangeStart = 49210, XrefRangeEnd = 49211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x00111794 File Offset: 0x0010F994
		public unsafe virtual float LuckyLeafExtraMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x001117D0 File Offset: 0x0010F9D0
		public unsafe virtual int AyaNewsBeginRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x0011180C File Offset: 0x0010FA0C
		public unsafe virtual int PriceToRefreshAyaNews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00111848 File Offset: 0x0010FA48
		public unsafe virtual int AkyuuWashiPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00111884 File Offset: 0x0010FA84
		public unsafe virtual int EllenCandyPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x001118C0 File Offset: 0x0010FAC0
		public unsafe virtual float KourindouDiscount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x001118FC File Offset: 0x0010FAFC
		public unsafe virtual int GachaRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00111938 File Offset: 0x0010FB38
		public unsafe virtual int GachaBevInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00111974 File Offset: 0x0010FB74
		public unsafe virtual int SelectRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x001119B0 File Offset: 0x0010FBB0
		public unsafe virtual int BaseGachaNumWhenSettle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x001119EC File Offset: 0x0010FBEC
		public unsafe virtual int BaseMoveAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00111A28 File Offset: 0x0010FC28
		public unsafe virtual int BaseIngredientNumWhenGetRecipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x00111A64 File Offset: 0x0010FC64
		public unsafe virtual int StartFund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00111AA0 File Offset: 0x0010FCA0
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalRogueLikeCustomizedDataProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00111ADC File Offset: 0x0010FCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83588, XrefRangeEnd = 83596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalRogueLikeCustomizedDataProfile(Il2CppReferenceArray<Product> initialProducts, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> roundSetups, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup> mapSetups, Il2CppStructArray<DLC5_RogueLikeDataProfile.CookerPriceSetup> cookerPriceSetups, Il2CppStructArray<TriggerCardData> gachaTriggerData, Il2CppReferenceArray<RogueLikeCardRewardPair> gachaRewardPairData, int roundDuration, float globalProductMultiplier, float level1RecipePriceMultiplier, float level2RecipePriceMultiplier, float level3RecipePriceMultiplier, float level4RecipePriceMultiplier, float level5RecipePriceMultiplier, int partnerBasePrice, int specialGuestPrice, int eliteSpecialGuestPrice, int clothesPrice, int decorationPrice, int gachaNeedComboNum, int gachaNeedSpellNum, int gachaMaxCardNum, int beginToSpawnDangerousCardRoundIndex, int unlockAllLevel2SpotRoundIndex, int unlockAllLevel3SpotRoundIndex, float luckyLeafExtraMultiplier, int ayaNewsBeginRoundIndex, int priceToRefreshAyaNews, int akyuuWashiPrice, int ellenCandyPrice, float kourindouDiscount, int gachaRecipeInitialNum, int gachaBevInitialNum, int selectRecipeInitialNum, int baseGachaNumWhenSettle, int baseMoveAction, int baseIngredientNumWhenGetRecipe, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> specialGuestVisitEverywhere, int startFund) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)38) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialProducts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roundSetups);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapSetups);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerPriceSetups);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gachaTriggerData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gachaRewardPairData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundDuration;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref globalProductMultiplier;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level1RecipePriceMultiplier;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level2RecipePriceMultiplier;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level3RecipePriceMultiplier;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level4RecipePriceMultiplier;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level5RecipePriceMultiplier;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerBasePrice;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestPrice;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eliteSpecialGuestPrice;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clothesPrice;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decorationPrice;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gachaNeedComboNum;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gachaNeedSpellNum;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gachaMaxCardNum;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginToSpawnDangerousCardRoundIndex;
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockAllLevel2SpotRoundIndex;
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockAllLevel3SpotRoundIndex;
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref luckyLeafExtraMultiplier;
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ayaNewsBeginRoundIndex;
			ptr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priceToRefreshAyaNews;
			ptr[checked(unchecked((UIntPtr)27) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref akyuuWashiPrice;
			ptr[checked(unchecked((UIntPtr)28) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ellenCandyPrice;
			ptr[checked(unchecked((UIntPtr)29) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kourindouDiscount;
			ptr[checked(unchecked((UIntPtr)30) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gachaRecipeInitialNum;
			ptr[checked(unchecked((UIntPtr)31) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gachaBevInitialNum;
			ptr[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectRecipeInitialNum;
			ptr[checked(unchecked((UIntPtr)33) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseGachaNumWhenSettle;
			ptr[checked(unchecked((UIntPtr)34) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseMoveAction;
			ptr[checked(unchecked((UIntPtr)35) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseIngredientNumWhenGetRecipe;
			ptr[checked(unchecked((UIntPtr)36) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestVisitEverywhere);
			ptr[checked(unchecked((UIntPtr)37) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startFund;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_RogueLikeRoundSetup_Il2CppReferenceArray_1_MapSetup_Il2CppStructArray_1_CookerPriceSetup_Il2CppStructArray_1_TriggerCardData_Il2CppReferenceArray_1_RogueLikeCardRewardPair_Int32_Single_Single_Single_Single_Single_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ConditionalSpecialGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00111D68 File Offset: 0x0010FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83596, XrefRangeEnd = 83718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExternalRogueLikeCustomizedDataProfile(IRogueLikeCustomizedDataProfile rogueLikeCustomizedDataProfile) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalRogueLikeCustomizedDataProfile>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCustomizedDataProfile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExternalRogueLikeCustomizedDataProfile.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00014FCF File Offset: 0x000131CF
		public ExternalRogueLikeCustomizedDataProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x00111DB4 File Offset: 0x0010FFB4
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x00014FD8 File Offset: 0x000131D8
		public unsafe Il2CppReferenceArray<Product> m_InitialProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00111DE4 File Offset: 0x0010FFE4
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x00014FF7 File Offset: 0x000131F7
		public unsafe Il2CppStructArray<int> m_InitialRecipePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialRecipePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialRecipePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00111E14 File Offset: 0x00110014
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00015016 File Offset: 0x00013216
		public unsafe Il2CppStructArray<int> m_InitialBevPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialBevPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_InitialBevPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00111E44 File Offset: 0x00110044
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00015035 File Offset: 0x00013235
		public unsafe Il2CppStructArray<Vector2Int> m_BevLevelLinkToNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_BevLevelLinkToNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x00111E74 File Offset: 0x00110074
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00015054 File Offset: 0x00013254
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> m_RoundSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_RoundSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_RoundSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x00111EA4 File Offset: 0x001100A4
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x00015073 File Offset: 0x00013273
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup> m_MapSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_MapSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_MapSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x00111ED4 File Offset: 0x001100D4
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00015092 File Offset: 0x00013292
		public unsafe Il2CppStructArray<DLC5_RogueLikeDataProfile.CookerPriceSetup> m_CookerPriceSetups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_CookerPriceSetups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x00111F04 File Offset: 0x00110104
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x000150B1 File Offset: 0x000132B1
		public unsafe Il2CppStructArray<TriggerCardData> m_GachaTriggerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaTriggerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TriggerCardData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaTriggerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00111F34 File Offset: 0x00110134
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000150D0 File Offset: 0x000132D0
		public unsafe Il2CppReferenceArray<RogueLikeCardRewardPair> m_GachaRewardPairData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCardRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_GachaRewardPairData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00111F64 File Offset: 0x00110164
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x000150EF File Offset: 0x000132EF
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> m_SpecialGuestVisitEverywhere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00111F94 File Offset: 0x00110194
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0001510E File Offset: 0x0001330E
		public unsafe int _RoundDuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__RoundDuration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__RoundDuration_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00111FBC File Offset: 0x001101BC
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00015129 File Offset: 0x00013329
		public unsafe float _GlobalProductMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GlobalProductMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GlobalProductMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00111FE4 File Offset: 0x001101E4
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00015144 File Offset: 0x00013344
		public unsafe float _Level1RecipePriceMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level1RecipePriceMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level1RecipePriceMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0011200C File Offset: 0x0011020C
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x0001515F File Offset: 0x0001335F
		public unsafe float _Level2RecipePriceMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level2RecipePriceMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level2RecipePriceMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00112034 File Offset: 0x00110234
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0001517A File Offset: 0x0001337A
		public unsafe float _Level3RecipePriceMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level3RecipePriceMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level3RecipePriceMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0011205C File Offset: 0x0011025C
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00015195 File Offset: 0x00013395
		public unsafe float _Level4RecipePriceMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level4RecipePriceMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level4RecipePriceMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00112084 File Offset: 0x00110284
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000151B0 File Offset: 0x000133B0
		public unsafe float _Level5RecipePriceMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level5RecipePriceMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__Level5RecipePriceMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x001120AC File Offset: 0x001102AC
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000151CB File Offset: 0x000133CB
		public unsafe int _PartnerBasePrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PartnerBasePrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PartnerBasePrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x001120D4 File Offset: 0x001102D4
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x000151E6 File Offset: 0x000133E6
		public unsafe int _SpecialGuestPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SpecialGuestPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SpecialGuestPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x001120FC File Offset: 0x001102FC
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00015201 File Offset: 0x00013401
		public unsafe int _EliteSpecialGuestPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EliteSpecialGuestPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EliteSpecialGuestPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00112124 File Offset: 0x00110324
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0001521C File Offset: 0x0001341C
		public unsafe int _ClothesPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__ClothesPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__ClothesPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0011214C File Offset: 0x0011034C
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00015237 File Offset: 0x00013437
		public unsafe int _DecorationPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__DecorationPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__DecorationPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00112174 File Offset: 0x00110374
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x00015252 File Offset: 0x00013452
		public unsafe int _GachaNeedComboNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedComboNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedComboNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x0011219C File Offset: 0x0011039C
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0001526D File Offset: 0x0001346D
		public unsafe int _GachaNeedSpellNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedSpellNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaNeedSpellNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x001121C4 File Offset: 0x001103C4
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00015288 File Offset: 0x00013488
		public unsafe int _GachaMaxCardNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaMaxCardNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaMaxCardNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x001121EC File Offset: 0x001103EC
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x000152A3 File Offset: 0x000134A3
		public unsafe int _BeginToSpawnDangerousCardRoundIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BeginToSpawnDangerousCardRoundIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BeginToSpawnDangerousCardRoundIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00112214 File Offset: 0x00110414
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x000152BE File Offset: 0x000134BE
		public unsafe int _UnlockAllLevel2SpotRoundIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel2SpotRoundIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel2SpotRoundIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x0011223C File Offset: 0x0011043C
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x000152D9 File Offset: 0x000134D9
		public unsafe int _UnlockAllLevel3SpotRoundIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel3SpotRoundIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__UnlockAllLevel3SpotRoundIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00112264 File Offset: 0x00110464
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x000152F4 File Offset: 0x000134F4
		public unsafe float _LuckyLeafExtraMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__LuckyLeafExtraMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__LuckyLeafExtraMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0011228C File Offset: 0x0011048C
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x0001530F File Offset: 0x0001350F
		public unsafe int _AyaNewsBeginRoundIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AyaNewsBeginRoundIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AyaNewsBeginRoundIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x001122B4 File Offset: 0x001104B4
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x0001532A File Offset: 0x0001352A
		public unsafe int _PriceToRefreshAyaNews_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PriceToRefreshAyaNews_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__PriceToRefreshAyaNews_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x001122DC File Offset: 0x001104DC
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00015345 File Offset: 0x00013545
		public unsafe int _AkyuuWashiPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AkyuuWashiPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__AkyuuWashiPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00112304 File Offset: 0x00110504
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00015360 File Offset: 0x00013560
		public unsafe int _EllenCandyPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EllenCandyPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__EllenCandyPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0011232C File Offset: 0x0011052C
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x0001537B File Offset: 0x0001357B
		public unsafe float _KourindouDiscount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__KourindouDiscount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__KourindouDiscount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00112354 File Offset: 0x00110554
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00015396 File Offset: 0x00013596
		public unsafe int _GachaRecipeInitialNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaRecipeInitialNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaRecipeInitialNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0011237C File Offset: 0x0011057C
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x000153B1 File Offset: 0x000135B1
		public unsafe int _GachaBevInitialNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaBevInitialNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__GachaBevInitialNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x001123A4 File Offset: 0x001105A4
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x000153CC File Offset: 0x000135CC
		public unsafe int _SelectRecipeInitialNum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SelectRecipeInitialNum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__SelectRecipeInitialNum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x001123CC File Offset: 0x001105CC
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x000153E7 File Offset: 0x000135E7
		public unsafe int _BaseGachaNumWhenSettle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseGachaNumWhenSettle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseGachaNumWhenSettle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x001123F4 File Offset: 0x001105F4
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x00015402 File Offset: 0x00013602
		public unsafe int _BaseMoveAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseMoveAction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseMoveAction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0011241C File Offset: 0x0011061C
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x0001541D File Offset: 0x0001361D
		public unsafe int _BaseIngredientNumWhenGetRecipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseIngredientNumWhenGetRecipe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__BaseIngredientNumWhenGetRecipe_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00112444 File Offset: 0x00110644
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00015438 File Offset: 0x00013638
		public unsafe int _StartFund_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__StartFund_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExternalRogueLikeCustomizedDataProfile.NativeFieldInfoPtr__StartFund_k__BackingField)) = value;
			}
		}

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialProducts;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialRecipePool;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_m_InitialBevPool;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_m_BevLevelLinkToNum;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_m_RoundSetups;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_m_MapSetups;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerPriceSetups;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaTriggerData;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaRewardPairData;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestVisitEverywhere;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr__RoundDuration_k__BackingField;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeFieldInfoPtr__GlobalProductMultiplier_k__BackingField;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeFieldInfoPtr__Level1RecipePriceMultiplier_k__BackingField;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeFieldInfoPtr__Level2RecipePriceMultiplier_k__BackingField;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr__Level3RecipePriceMultiplier_k__BackingField;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr__Level4RecipePriceMultiplier_k__BackingField;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr__Level5RecipePriceMultiplier_k__BackingField;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr__PartnerBasePrice_k__BackingField;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuestPrice_k__BackingField;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr__EliteSpecialGuestPrice_k__BackingField;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr__ClothesPrice_k__BackingField;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr__DecorationPrice_k__BackingField;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr__GachaNeedComboNum_k__BackingField;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr__GachaNeedSpellNum_k__BackingField;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr__GachaMaxCardNum_k__BackingField;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr__BeginToSpawnDangerousCardRoundIndex_k__BackingField;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr__UnlockAllLevel2SpotRoundIndex_k__BackingField;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr__UnlockAllLevel3SpotRoundIndex_k__BackingField;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr__LuckyLeafExtraMultiplier_k__BackingField;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr__AyaNewsBeginRoundIndex_k__BackingField;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr__PriceToRefreshAyaNews_k__BackingField;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr__AkyuuWashiPrice_k__BackingField;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr__EllenCandyPrice_k__BackingField;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr__KourindouDiscount_k__BackingField;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr__GachaRecipeInitialNum_k__BackingField;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr__GachaBevInitialNum_k__BackingField;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr__SelectRecipeInitialNum_k__BackingField;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr__BaseGachaNumWhenSettle_k__BackingField;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr__BaseMoveAction_k__BackingField;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr__BaseIngredientNumWhenGetRecipe_k__BackingField;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr__StartFund_k__BackingField;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Il2CppReferenceArray_1_RogueLikeRoundSetup_Il2CppReferenceArray_1_MapSetup_Il2CppStructArray_1_CookerPriceSetup_Il2CppStructArray_1_TriggerCardData_Il2CppReferenceArray_1_RogueLikeCardRewardPair_Int32_Single_Single_Single_Single_Single_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Single_Int32_Int32_Int32_Int32_Int32_Int32_Il2CppReferenceArray_1_ConditionalSpecialGuest_Int32_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_0;
	}
}
