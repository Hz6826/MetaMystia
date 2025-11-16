using System;
using GameData;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200012E RID: 302
	public sealed class IRogueLikeData : ValueType
	{
		// Token: 0x0600232C RID: 9004 RVA: 0x00113378 File Offset: 0x00111578
		// Note: this type is marked as 'beforefieldinit'.
		static IRogueLikeData()
		{
			Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "IRogueLikeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr);
			IRogueLikeData.NativeFieldInfoPtr_m_CustomizedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, "m_CustomizedData");
			IRogueLikeData.NativeFieldInfoPtr_m_UnchangeableData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, "m_UnchangeableData");
			IRogueLikeData.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_DLC5_RogueLikeDataProfileUnchangeable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669520);
			IRogueLikeData.NativeMethodInfoPtr_EnsureDataValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669521);
			IRogueLikeData.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669522);
			IRogueLikeData.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669523);
			IRogueLikeData.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669524);
			IRogueLikeData.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669525);
			IRogueLikeData.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669526);
			IRogueLikeData.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669527);
			IRogueLikeData.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669528);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669529);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669530);
			IRogueLikeData.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669531);
			IRogueLikeData.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669532);
			IRogueLikeData.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669533);
			IRogueLikeData.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669534);
			IRogueLikeData.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669535);
			IRogueLikeData.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669536);
			IRogueLikeData.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669537);
			IRogueLikeData.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669538);
			IRogueLikeData.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669539);
			IRogueLikeData.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669540);
			IRogueLikeData.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669541);
			IRogueLikeData.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669542);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669543);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669544);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669545);
			IRogueLikeData.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669546);
			IRogueLikeData.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669547);
			IRogueLikeData.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669548);
			IRogueLikeData.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669549);
			IRogueLikeData.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669550);
			IRogueLikeData.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669551);
			IRogueLikeData.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669552);
			IRogueLikeData.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669553);
			IRogueLikeData.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669554);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669555);
			IRogueLikeData.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669556);
			IRogueLikeData.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669557);
			IRogueLikeData.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669558);
			IRogueLikeData.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669559);
			IRogueLikeData.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669560);
			IRogueLikeData.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669561);
			IRogueLikeData.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669562);
			IRogueLikeData.NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669563);
			IRogueLikeData.NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669564);
			IRogueLikeData.NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669565);
			IRogueLikeData.NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669566);
			IRogueLikeData.NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669567);
			IRogueLikeData.NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669568);
			IRogueLikeData.NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669569);
			IRogueLikeData.NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669570);
			IRogueLikeData.NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669571);
			IRogueLikeData.NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669572);
			IRogueLikeData.NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669573);
			IRogueLikeData.NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669574);
			IRogueLikeData.NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669575);
			IRogueLikeData.NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669576);
			IRogueLikeData.NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669577);
			IRogueLikeData.NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669578);
			IRogueLikeData.NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, 100669579);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00113880 File Offset: 0x00111A80
		[CallerCount(272)]
		[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IRogueLikeData(IRogueLikeCustomizedDataProfile customizedData, DLC5_RogueLikeDataProfileUnchangeable unchangeableData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customizedData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unchangeableData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_DLC5_RogueLikeDataProfileUnchangeable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x001138E4 File Offset: 0x00111AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83718, XrefRangeEnd = 83722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EnsureDataValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_EnsureDataValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00113928 File Offset: 0x00111B28
		public unsafe IReadOnlyList<Product> InitialProducts
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83726, RefRangeEnd = 83727, XrefRangeStart = 83722, XrefRangeEnd = 83726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0011396C File Offset: 0x00111B6C
		public unsafe IReadOnlyList<int> InitialRecipePool
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83736, RefRangeEnd = 83737, XrefRangeStart = 83727, XrefRangeEnd = 83736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x001139B0 File Offset: 0x00111BB0
		public unsafe IReadOnlyList<int> InitialBevPool
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83746, RefRangeEnd = 83747, XrefRangeStart = 83737, XrefRangeEnd = 83746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x001139F4 File Offset: 0x00111BF4
		public unsafe IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83756, RefRangeEnd = 83757, XrefRangeStart = 83747, XrefRangeEnd = 83756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00113A38 File Offset: 0x00111C38
		public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83768, XrefRangeStart = 83757, XrefRangeEnd = 83761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x00113A7C File Offset: 0x00111C7C
		public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83772, RefRangeEnd = 83773, XrefRangeStart = 83768, XrefRangeEnd = 83772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00113AC0 File Offset: 0x00111CC0
		public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83773, XrefRangeEnd = 83777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x00113B04 File Offset: 0x00111D04
		public unsafe IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83777, XrefRangeEnd = 83781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TriggerCardData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00113B48 File Offset: 0x00111D48
		public unsafe IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83781, XrefRangeEnd = 83785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RogueLikeCardRewardPair>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x00113B8C File Offset: 0x00111D8C
		public unsafe int RoundDuration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83789, RefRangeEnd = 83790, XrefRangeStart = 83785, XrefRangeEnd = 83789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00113BD0 File Offset: 0x00111DD0
		public unsafe float GlobalProductMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83790, XrefRangeEnd = 83794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x00113C14 File Offset: 0x00111E14
		public unsafe float Level1RecipePriceMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83794, XrefRangeEnd = 83798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00113C58 File Offset: 0x00111E58
		public unsafe float Level2RecipePriceMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83798, XrefRangeEnd = 83802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x00113C9C File Offset: 0x00111E9C
		public unsafe float Level3RecipePriceMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83802, XrefRangeEnd = 83806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00113CE0 File Offset: 0x00111EE0
		public unsafe float Level4RecipePriceMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83806, XrefRangeEnd = 83810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x00113D24 File Offset: 0x00111F24
		public unsafe float Level5RecipePriceMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83810, XrefRangeEnd = 83814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00113D68 File Offset: 0x00111F68
		public unsafe int PartnerBasePrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83814, XrefRangeEnd = 83818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00113DAC File Offset: 0x00111FAC
		public unsafe int SpecialGuestPrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83818, XrefRangeEnd = 83822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00113DF0 File Offset: 0x00111FF0
		public unsafe int EliteSpecialGuestPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83826, RefRangeEnd = 83827, XrefRangeStart = 83822, XrefRangeEnd = 83826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x00113E34 File Offset: 0x00112034
		public unsafe int ClothesPrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83827, XrefRangeEnd = 83831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00113E78 File Offset: 0x00112078
		public unsafe int DecorationPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83835, RefRangeEnd = 83836, XrefRangeStart = 83831, XrefRangeEnd = 83835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x00113EBC File Offset: 0x001120BC
		public unsafe int GachaNeedComboNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83836, XrefRangeEnd = 83840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00113F00 File Offset: 0x00112100
		public unsafe int GachaNeedSpellNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83840, XrefRangeEnd = 83844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00113F44 File Offset: 0x00112144
		public unsafe int GachaMaxCardNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83848, RefRangeEnd = 83849, XrefRangeStart = 83844, XrefRangeEnd = 83848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00113F88 File Offset: 0x00112188
		public unsafe int BeginToSpawnDangerousCardRoundIndex
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83853, RefRangeEnd = 83857, XrefRangeStart = 83849, XrefRangeEnd = 83853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x00113FCC File Offset: 0x001121CC
		public unsafe int UnlockAllLevel2SpotRoundIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83857, XrefRangeEnd = 83861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00114010 File Offset: 0x00112210
		public unsafe int UnlockAllLevel3SpotRoundIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83861, XrefRangeEnd = 83865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00114054 File Offset: 0x00112254
		public unsafe float LuckyLeafExtraMultiplier
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83869, RefRangeEnd = 83873, XrefRangeStart = 83865, XrefRangeEnd = 83869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00114098 File Offset: 0x00112298
		public unsafe int AyaNewsBeginRoundIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83877, RefRangeEnd = 83878, XrefRangeStart = 83873, XrefRangeEnd = 83877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x001140DC File Offset: 0x001122DC
		public unsafe int PriceToRefreshAyaNews
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 83882, RefRangeEnd = 83887, XrefRangeStart = 83878, XrefRangeEnd = 83882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00114120 File Offset: 0x00112320
		public unsafe int AkyuuWashiPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83891, RefRangeEnd = 83892, XrefRangeStart = 83887, XrefRangeEnd = 83891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x00114164 File Offset: 0x00112364
		public unsafe int EllenCandyPrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83892, XrefRangeEnd = 83896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x001141A8 File Offset: 0x001123A8
		public unsafe float KourindouDiscount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83900, RefRangeEnd = 83903, XrefRangeStart = 83896, XrefRangeEnd = 83900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x001141EC File Offset: 0x001123EC
		public unsafe int GachaRecipeInitialNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83903, XrefRangeEnd = 83907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x00114230 File Offset: 0x00112430
		public unsafe int GachaBevInitialNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83907, XrefRangeEnd = 83911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00114274 File Offset: 0x00112474
		public unsafe int SelectRecipeInitialNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83911, XrefRangeEnd = 83915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x001142B8 File Offset: 0x001124B8
		public unsafe int BaseGachaNumWhenSettle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83919, RefRangeEnd = 83920, XrefRangeStart = 83915, XrefRangeEnd = 83919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x001142FC File Offset: 0x001124FC
		public unsafe int BaseMoveAction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83920, XrefRangeEnd = 83924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00114340 File Offset: 0x00112540
		public unsafe int BaseIngredientNumWhenGetRecipe
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83924, XrefRangeEnd = 83928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x00114384 File Offset: 0x00112584
		public unsafe int StartFund
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83932, RefRangeEnd = 83933, XrefRangeStart = 83928, XrefRangeEnd = 83932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x001143C8 File Offset: 0x001125C8
		public unsafe IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83937, RefRangeEnd = 83938, XrefRangeStart = 83933, XrefRangeEnd = 83937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0011440C File Offset: 0x0011260C
		public unsafe DLC5_RogueLikePoolResultPanel RoguelikePoolEditMessagePanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83938, RefRangeEnd = 83939, XrefRangeStart = 83938, XrefRangeEnd = 83938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr3) : null;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x00114450 File Offset: 0x00112650
		public unsafe DLC5_RogueLikePoolViewerPanel RoguelikePoolViewerPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr3) : null;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x00114494 File Offset: 0x00112694
		public unsafe AssetReference RoguelikeTutorialPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x001144D8 File Offset: 0x001126D8
		public unsafe AssetReference RogueLikeCardScorePanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83939, RefRangeEnd = 83940, XrefRangeStart = 83939, XrefRangeEnd = 83939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0011451C File Offset: 0x0011271C
		public unsafe DLC5_RogueLikeCardSelectorPanel CardSelectorPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83940, RefRangeEnd = 83941, XrefRangeStart = 83940, XrefRangeEnd = 83940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr3) : null;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x00114560 File Offset: 0x00112760
		public unsafe Il2CppReferenceArray<RogueLikeCard> Cards
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCard>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x001145A4 File Offset: 0x001127A4
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset CardDescriptionLang
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x001145E8 File Offset: 0x001127E8
		public unsafe Il2CppReferenceArray<RogueLikeCardPersistent> CardsPersistent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83941, RefRangeEnd = 83942, XrefRangeStart = 83941, XrefRangeEnd = 83941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeCardPersistent>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0011462C File Offset: 0x0011282C
		public unsafe float RecipeCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x00114670 File Offset: 0x00112870
		public unsafe float ItemCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x001146B4 File Offset: 0x001128B4
		public unsafe float PartnerCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x001146F8 File Offset: 0x001128F8
		public unsafe float IzakayaCollectRateWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0011473C File Offset: 0x0011293C
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement> RogueLikeAchievements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x00114780 File Offset: 0x00112980
		public unsafe Il2CppStructArray<Vector2Int> PartnerPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x001147C4 File Offset: 0x001129C4
		public unsafe int FirstRefreshCardPrice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83942, RefRangeEnd = 83943, XrefRangeStart = 83942, XrefRangeEnd = 83942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x00114808 File Offset: 0x00112A08
		public unsafe Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase> EliteChallengeProfiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RogueLikeRunTimeData.EliteChallengeBase>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0011484C File Offset: 0x00112A4C
		public unsafe DLC5_RogueLikeEliteRewardSelectionPanel EliteRewardSelectionPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83943, RefRangeEnd = 83944, XrefRangeStart = 83943, XrefRangeEnd = 83943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IRogueLikeData.NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteRewardSelectionPanel>(intPtr3) : null;
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x0001545C File Offset: 0x0001365C
		public IRogueLikeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00015465 File Offset: 0x00013665
		public IRogueLikeData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr))
		{
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x00114890 File Offset: 0x00112A90
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00015477 File Offset: 0x00013677
		public unsafe IRogueLikeCustomizedDataProfile m_CustomizedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRogueLikeData.NativeFieldInfoPtr_m_CustomizedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRogueLikeCustomizedDataProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRogueLikeData.NativeFieldInfoPtr_m_CustomizedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x001148C0 File Offset: 0x00112AC0
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00015496 File Offset: 0x00013696
		public unsafe DLC5_RogueLikeDataProfileUnchangeable m_UnchangeableData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRogueLikeData.NativeFieldInfoPtr_m_UnchangeableData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeDataProfileUnchangeable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IRogueLikeData.NativeFieldInfoPtr_m_UnchangeableData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomizedData;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_m_UnchangeableData;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikeCustomizedDataProfile_DLC5_RogueLikeDataProfileUnchangeable_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDataValid_Public_Boolean_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialProducts_Public_Virtual_Final_New_get_IReadOnlyList_1_Product_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialRecipePool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialBevPool_Public_Virtual_Final_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Virtual_Final_New_get_IReadOnlyList_1_Vector2Int_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_MapSetup_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerPriceSetups_Public_Virtual_Final_New_get_IReadOnlyList_1_CookerPriceSetup_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaTriggerData_Public_Virtual_Final_New_get_IReadOnlyList_1_TriggerCardData_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRewardPairData_Public_Virtual_Final_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundDuration_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerBasePrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_get_ClothesPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_get_EllenCandyPrice_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_get_KourindouDiscount_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMoveAction_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_get_StartFund_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Virtual_Final_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikePoolEditMessagePanel_Public_get_DLC5_RogueLikePoolResultPanel_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikePoolViewerPanel_Public_get_DLC5_RogueLikePoolViewerPanel_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_get_RoguelikeTutorialPanel_Public_get_AssetReference_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeCardScorePanel_Public_get_AssetReference_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_get_CardSelectorPanel_Public_get_DLC5_RogueLikeCardSelectorPanel_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_get_Cards_Public_get_Il2CppReferenceArray_1_RogueLikeCard_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_get_CardDescriptionLang_Public_get_MultiLanguageTextAsset_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_get_CardsPersistent_Public_get_Il2CppReferenceArray_1_RogueLikeCardPersistent_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaCollectRateWeight_Public_get_Single_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeAchievements_Public_get_Il2CppReferenceArray_1_RogueLikeAchievement_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerPrice_Public_get_Il2CppStructArray_1_Vector2Int_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstRefreshCardPrice_Public_get_Int32_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteChallengeProfiles_Public_get_Il2CppReferenceArray_1_EliteChallengeBase_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteRewardSelectionPanel_Public_get_DLC5_RogueLikeEliteRewardSelectionPanel_0;
	}
}
