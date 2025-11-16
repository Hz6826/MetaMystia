using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000135 RID: 309
	public sealed class RogueLikeSaveData : ValueType
	{
		// Token: 0x06002505 RID: 9477 RVA: 0x0011AB40 File Offset: 0x00118D40
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeSaveData()
		{
			Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr);
			RogueLikeSaveData.NativeFieldInfoPtr_fileVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "fileVersion");
			RogueLikeSaveData.NativeFieldInfoPtr_m_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_Difficulty");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CurrentMapName");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapNameLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CurrentMapNameLang");
			RogueLikeSaveData.NativeFieldInfoPtr_m_GeneratedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_GeneratedProducts");
			RogueLikeSaveData.NativeFieldInfoPtr_m_UnlockedSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_UnlockedSpots");
			RogueLikeSaveData.NativeFieldInfoPtr_m_VisitedSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_VisitedSpots");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentRoundNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CurrentRoundNum");
			RogueLikeSaveData.NativeFieldInfoPtr_m_Funds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_Funds");
			RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_SelectedClothes");
			RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedDecorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_SelectedDecorations");
			RogueLikeSaveData.NativeFieldInfoPtr_m_StorageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_StorageData");
			RogueLikeSaveData.NativeFieldInfoPtr_m_GainedAyaBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_GainedAyaBuff");
			RogueLikeSaveData.NativeFieldInfoPtr_m_RealSaveTimeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_RealSaveTimeCode");
			RogueLikeSaveData.NativeFieldInfoPtr_m_ActiveDLCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_ActiveDLCs");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeTime");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostIngredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCostIngredient");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCostBeverage");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCostFood");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCollectSpellCard");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectMikeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCollectMikeCard");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCollectFund");
			RogueLikeSaveData.NativeFieldInfoPtr_m_MaxEarnedFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_MaxEarnedFund");
			RogueLikeSaveData.NativeFieldInfoPtr_m_ServedGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_ServedGuestNum");
			RogueLikeSaveData.NativeFieldInfoPtr_m_ServedSpecialGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_ServedSpecialGuestNum");
			RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostInKourindou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_WholeCostInKourindou");
			RogueLikeSaveData.NativeFieldInfoPtr_m_ActivatedToastTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_ActivatedToastTip");
			RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeRecipePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_RogueLikeRecipePool");
			RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeBeveragePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_RogueLikeBeveragePool");
			RogueLikeSaveData.NativeFieldInfoPtr_m_GainedCardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_GainedCardPool");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyCoefficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CurrentDifficultyCoefficient");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyPeak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CurrentDifficultyPeak");
			RogueLikeSaveData.NativeFieldInfoPtr_m_CollectRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_CollectRate");
			RogueLikeSaveData.NativeFieldInfoPtr_m_EnabledEliteSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_EnabledEliteSpecialGuests");
			RogueLikeSaveData.NativeFieldInfoPtr_m_HasFinishedEliteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_HasFinishedEliteType");
			RogueLikeSaveData.NativeFieldInfoPtr_m_AllActiveEliteChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, "m_AllActiveEliteChallenge");
			RogueLikeSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_Difficulty_String_String_Il2CppReferenceArray_1_Product_Dictionary_2_String_UnlockedIzakayaInfo_HashSet_1_String_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_RuntimePlayerDataCache_ValueTuple_2_Int32_Boolean_DateTime_Il2CppStringArray_Single_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_RogueLikeProductPool_RogueLikeProductPool_List_1_KeyValuePair_2_RogueLikePer = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669947);
			RogueLikeSaveData.NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669948);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentMapName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669949);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentMapNameLang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669950);
			RogueLikeSaveData.NativeMethodInfoPtr_get_GeneratedProducts_Public_get_IReadOnlyList_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669951);
			RogueLikeSaveData.NativeMethodInfoPtr_get_UnlockedSpots_Public_get_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669952);
			RogueLikeSaveData.NativeMethodInfoPtr_get_VisitedSpots_Public_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669953);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentRoundNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669954);
			RogueLikeSaveData.NativeMethodInfoPtr_get_Funds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669955);
			RogueLikeSaveData.NativeMethodInfoPtr_get_GainedAyaBuff_Public_get_ValueTuple_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669956);
			RogueLikeSaveData.NativeMethodInfoPtr_get_SelectedClothes_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669957);
			RogueLikeSaveData.NativeMethodInfoPtr_get_SelectedDecorations_Public_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669958);
			RogueLikeSaveData.NativeMethodInfoPtr_get_StorageData_Public_get_RuntimePlayerDataCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669959);
			RogueLikeSaveData.NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669960);
			RogueLikeSaveData.NativeMethodInfoPtr_get_ActiveDLCs_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669961);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669962);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostIngredient_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669963);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostBeverage_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669964);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostFood_Public_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669965);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectSpellCard_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669966);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectMikeCard_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669967);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectFund_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669968);
			RogueLikeSaveData.NativeMethodInfoPtr_get_MaxEarnedFund_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669969);
			RogueLikeSaveData.NativeMethodInfoPtr_get_ServedGuestNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669970);
			RogueLikeSaveData.NativeMethodInfoPtr_get_ServedSpecialGuestNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669971);
			RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostInKourindou_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669972);
			RogueLikeSaveData.NativeMethodInfoPtr_get_ActivatedToastTip_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669973);
			RogueLikeSaveData.NativeMethodInfoPtr_get_RogueLikeRecipePool_Public_get_RogueLikeProductPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669974);
			RogueLikeSaveData.NativeMethodInfoPtr_get_RogueLikeBeveragePool_Public_get_RogueLikeProductPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669975);
			RogueLikeSaveData.NativeMethodInfoPtr_get_GainedCardPool_Public_get_List_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669976);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentDifficultyCoefficient_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669977);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentDifficultyPeak_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669978);
			RogueLikeSaveData.NativeMethodInfoPtr_get_CollectRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669979);
			RogueLikeSaveData.NativeMethodInfoPtr_get_EnabledEliteSpecialGuests_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669980);
			RogueLikeSaveData.NativeMethodInfoPtr_get_HasFinishedEliteType_Public_get_List_1_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669981);
			RogueLikeSaveData.NativeMethodInfoPtr_get_AllActiveEliteChallenge_Public_get_List_1_KeyValuePair_2_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669982);
			RogueLikeSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr, 100669983);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x0011B124 File Offset: 0x00119324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88493, RefRangeEnd = 88495, XrefRangeStart = 88383, XrefRangeEnd = 88493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeSaveData(string fileVersion, NightSceneDirector.Difficulty difficulty, string currentMapName, string currentMapNameLang, Il2CppReferenceArray<Product> generatedProducts, Dictionary<string, UnlockedIzakayaInfo> unlockedSpots, HashSet<string> visitedSpots, int currentRoundNum, int funds, Il2CppStructArray<int> selectedClothes, Il2CppStructArray<int> selectedDecorations, RunTimeStorage.RuntimePlayerDataCache storageData, ValueTuple<int, bool> gainedAyaBuff, DateTime realSaveTimeCode, Il2CppStringArray activeDLCs, float wholeTime, Dictionary<int, int> wholeCostIngredient, Dictionary<int, int> wholeCostBeverage, Dictionary<int, int> wholeCostFood, int wholeCollectSpellCard, int wholeCollectMikeCard, int wholeCollectFund, int maxEarnedFund, int servedGuestNum, int servedSpecialGuestNum, int wholeCostInKourindou, List<int> activatedToastTip, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeRecipePool, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeBeveragePool, List<KeyValuePair<RogueLikePersistentCardInstance, int>> gainedCardPool, float currentDifficultyCoefficient, int currentDifficultyPeak, float collectRate, List<int> enabledEliteSpecialGuests, List<RogueLikeRunTimeData.EliteChallengeCache> hasFinishedEliteType, List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> allActiveEliteChallenge) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)36) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileVersion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentMapName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentMapNameLang);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generatedProducts);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedSpots);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visitedSpots);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRoundNum;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref funds;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedClothes);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedDecorations);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storageData);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(gainedAyaBuff));
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realSaveTimeCode;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeDLCs);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeTime;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wholeCostIngredient);
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wholeCostBeverage);
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wholeCostFood);
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeCollectSpellCard;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeCollectMikeCard;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeCollectFund;
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEarnedFund;
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref servedGuestNum;
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref servedSpecialGuestNum;
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeCostInKourindou;
			ptr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activatedToastTip);
			ptr[checked(unchecked((UIntPtr)27) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRecipePool);
			ptr[checked(unchecked((UIntPtr)28) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeBeveragePool);
			ptr[checked(unchecked((UIntPtr)29) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gainedCardPool);
			ptr[checked(unchecked((UIntPtr)30) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentDifficultyCoefficient;
			ptr[checked(unchecked((UIntPtr)31) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentDifficultyPeak;
			ptr[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectRate;
			ptr[checked(unchecked((UIntPtr)33) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enabledEliteSpecialGuests);
			ptr[checked(unchecked((UIntPtr)34) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hasFinishedEliteType);
			ptr[checked(unchecked((UIntPtr)35) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allActiveEliteChallenge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_Difficulty_String_String_Il2CppReferenceArray_1_Product_Dictionary_2_String_UnlockedIzakayaInfo_HashSet_1_String_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_RuntimePlayerDataCache_ValueTuple_2_Int32_Boolean_DateTime_Il2CppStringArray_Single_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_RogueLikeProductPool_RogueLikeProductPool_List_1_KeyValuePair_2_RogueLikePer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0011B3E4 File Offset: 0x001195E4
		public unsafe NightSceneDirector.Difficulty Difficulty
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 88495, RefRangeEnd = 88519, XrefRangeStart = 88495, XrefRangeEnd = 88495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x0011B428 File Offset: 0x00119628
		public unsafe string CurrentMapName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentMapName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x0011B464 File Offset: 0x00119664
		public unsafe string CurrentMapNameLang
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentMapNameLang_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x0011B4A0 File Offset: 0x001196A0
		public unsafe IReadOnlyList<Product> GeneratedProducts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_GeneratedProducts_Public_get_IReadOnlyList_1_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x0011B4E4 File Offset: 0x001196E4
		public unsafe IReadOnlyDictionary<string, UnlockedIzakayaInfo> UnlockedSpots
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_UnlockedSpots_Public_get_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, UnlockedIzakayaInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x0011B528 File Offset: 0x00119728
		public unsafe HashSet<string> VisitedSpots
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_VisitedSpots_Public_get_HashSet_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0011B56C File Offset: 0x0011976C
		public unsafe int CurrentRoundNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentRoundNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x0011B5B0 File Offset: 0x001197B0
		public unsafe int Funds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_Funds_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0011B5F4 File Offset: 0x001197F4
		public unsafe ValueTuple<int, bool> GainedAyaBuff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_GainedAyaBuff_Public_get_ValueTuple_2_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, bool>(pointer);
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x0011B630 File Offset: 0x00119830
		public unsafe IReadOnlyList<int> SelectedClothes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_SelectedClothes_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x0011B674 File Offset: 0x00119874
		public unsafe IReadOnlyList<int> SelectedDecorations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_SelectedDecorations_Public_get_IReadOnlyList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x0011B6B8 File Offset: 0x001198B8
		public unsafe RunTimeStorage.RuntimePlayerDataCache StorageData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_StorageData_Public_get_RuntimePlayerDataCache_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.RuntimePlayerDataCache>(intPtr3) : null;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x0011B6FC File Offset: 0x001198FC
		public unsafe DateTime RealSaveTimeCode
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x0011B740 File Offset: 0x00119940
		public unsafe ICollection<string> ActiveDLCs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_ActiveDLCs_Public_get_ICollection_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0011B784 File Offset: 0x00119984
		public unsafe float WholeTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeTime_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x0011B7C8 File Offset: 0x001199C8
		public unsafe Dictionary<int, int> WholeCostIngredient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostIngredient_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0011B80C File Offset: 0x00119A0C
		public unsafe Dictionary<int, int> WholeCostBeverage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostBeverage_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x0011B850 File Offset: 0x00119A50
		public unsafe Dictionary<int, int> WholeCostFood
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostFood_Public_get_Dictionary_2_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x0011B894 File Offset: 0x00119A94
		public unsafe int WholeCollectSpellCard
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 49194, RefRangeEnd = 49208, XrefRangeStart = 49194, XrefRangeEnd = 49208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectSpellCard_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x0011B8D8 File Offset: 0x00119AD8
		public unsafe int WholeCollectMikeCard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectMikeCard_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x0011B91C File Offset: 0x00119B1C
		public unsafe int WholeCollectFund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCollectFund_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0011B960 File Offset: 0x00119B60
		public unsafe int MaxEarnedFund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_MaxEarnedFund_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x0011B9A4 File Offset: 0x00119BA4
		public unsafe int ServedGuestNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30554, RefRangeEnd = 30555, XrefRangeStart = 30554, XrefRangeEnd = 30555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_ServedGuestNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0011B9E8 File Offset: 0x00119BE8
		public unsafe int ServedSpecialGuestNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49210, RefRangeEnd = 49211, XrefRangeStart = 49210, XrefRangeEnd = 49211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_ServedSpecialGuestNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x0011BA2C File Offset: 0x00119C2C
		public unsafe int WholeCostInKourindou
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_WholeCostInKourindou_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x0011BA70 File Offset: 0x00119C70
		public unsafe List<int> ActivatedToastTip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_ActivatedToastTip_Public_get_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x0011BAB4 File Offset: 0x00119CB4
		public unsafe RogueLikeRunTimeData.RogueLikeProductPool RogueLikeRecipePool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_RogueLikeRecipePool_Public_get_RogueLikeProductPool_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.RogueLikeProductPool>(intPtr3) : null;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x0011BAF8 File Offset: 0x00119CF8
		public unsafe RogueLikeRunTimeData.RogueLikeProductPool RogueLikeBeveragePool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_RogueLikeBeveragePool_Public_get_RogueLikeProductPool_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.RogueLikeProductPool>(intPtr3) : null;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x0011BB3C File Offset: 0x00119D3C
		public unsafe List<KeyValuePair<RogueLikePersistentCardInstance, int>> GainedCardPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_GainedCardPool_Public_get_List_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<RogueLikePersistentCardInstance, int>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x0011BB80 File Offset: 0x00119D80
		public unsafe float CurrentDifficultyCoefficient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentDifficultyCoefficient_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x0011BBC4 File Offset: 0x00119DC4
		public unsafe int CurrentDifficultyPeak
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CurrentDifficultyPeak_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x0011BC08 File Offset: 0x00119E08
		public unsafe float CollectRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_CollectRate_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x0011BC4C File Offset: 0x00119E4C
		public unsafe List<int> EnabledEliteSpecialGuests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_EnabledEliteSpecialGuests_Public_get_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x0011BC90 File Offset: 0x00119E90
		public unsafe List<RogueLikeRunTimeData.EliteChallengeCache> HasFinishedEliteType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_HasFinishedEliteType_Public_get_List_1_EliteChallengeCache_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RogueLikeRunTimeData.EliteChallengeCache>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x0011BCD4 File Offset: 0x00119ED4
		public unsafe List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> AllActiveEliteChallenge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_get_AllActiveEliteChallenge_Public_get_List_1_KeyValuePair_2_String_EliteChallengeCache_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x0011BD18 File Offset: 0x00119F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88519, XrefRangeEnd = 88611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeSaveData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RogueLikeSaveData(pointer);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00015F4C File Offset: 0x0001414C
		public RogueLikeSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00015F55 File Offset: 0x00014155
		public RogueLikeSaveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeSaveData>.NativeClassPtr))
		{
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0011BD54 File Offset: 0x00119F54
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x00015F67 File Offset: 0x00014167
		public unsafe string fileVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_fileVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_fileVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x0011BD7C File Offset: 0x00119F7C
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x00015F86 File Offset: 0x00014186
		public unsafe NightSceneDirector.Difficulty m_Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_Difficulty)) = value;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x0011BDA4 File Offset: 0x00119FA4
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x00015FA1 File Offset: 0x000141A1
		public unsafe string m_CurrentMapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x0011BDCC File Offset: 0x00119FCC
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x00015FC0 File Offset: 0x000141C0
		public unsafe string m_CurrentMapNameLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapNameLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentMapNameLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x0011BDF4 File Offset: 0x00119FF4
		// (set) Token: 0x06002536 RID: 9526 RVA: 0x00015FDF File Offset: 0x000141DF
		public unsafe Il2CppReferenceArray<Product> m_GeneratedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GeneratedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GeneratedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x0011BE24 File Offset: 0x0011A024
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x00015FFE File Offset: 0x000141FE
		public unsafe Dictionary<string, UnlockedIzakayaInfo> m_UnlockedSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_UnlockedSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UnlockedIzakayaInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_UnlockedSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x0011BE54 File Offset: 0x0011A054
		// (set) Token: 0x0600253A RID: 9530 RVA: 0x0001601D File Offset: 0x0001421D
		public unsafe HashSet<string> m_VisitedSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_VisitedSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_VisitedSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x0011BE84 File Offset: 0x0011A084
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x0001603C File Offset: 0x0001423C
		public unsafe int m_CurrentRoundNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentRoundNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentRoundNum)) = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x0011BEAC File Offset: 0x0011A0AC
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x00016057 File Offset: 0x00014257
		public unsafe int m_Funds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_Funds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_Funds)) = value;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x0011BED4 File Offset: 0x0011A0D4
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x00016072 File Offset: 0x00014272
		public unsafe Il2CppStructArray<int> m_SelectedClothes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedClothes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedClothes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0011BF04 File Offset: 0x0011A104
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x00016091 File Offset: 0x00014291
		public unsafe Il2CppStructArray<int> m_SelectedDecorations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedDecorations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_SelectedDecorations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x0011BF34 File Offset: 0x0011A134
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x000160B0 File Offset: 0x000142B0
		public unsafe RunTimeStorage.RuntimePlayerDataCache m_StorageData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_StorageData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeStorage.RuntimePlayerDataCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_StorageData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x0011BF64 File Offset: 0x0011A164
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000160CF File Offset: 0x000142CF
		public ValueTuple<int, bool> m_GainedAyaBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GainedAyaBuff);
				return new ValueTuple<int, bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GainedAyaBuff), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0011BF94 File Offset: 0x0011A194
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000160FD File Offset: 0x000142FD
		public unsafe DateTime m_RealSaveTimeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RealSaveTimeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RealSaveTimeCode)) = value;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x0011BFBC File Offset: 0x0011A1BC
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00016118 File Offset: 0x00014318
		public unsafe Il2CppStringArray m_ActiveDLCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ActiveDLCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ActiveDLCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x0011BFEC File Offset: 0x0011A1EC
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x00016137 File Offset: 0x00014337
		public unsafe float m_WholeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeTime)) = value;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x0011C014 File Offset: 0x0011A214
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x00016152 File Offset: 0x00014352
		public unsafe Dictionary<int, int> m_WholeCostIngredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostIngredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostIngredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x0011C044 File Offset: 0x0011A244
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x00016171 File Offset: 0x00014371
		public unsafe Dictionary<int, int> m_WholeCostBeverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostBeverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0011C074 File Offset: 0x0011A274
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x00016190 File Offset: 0x00014390
		public unsafe Dictionary<int, int> m_WholeCostFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x0011C0A4 File Offset: 0x0011A2A4
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x000161AF File Offset: 0x000143AF
		public unsafe int m_WholeCollectSpellCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectSpellCard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectSpellCard)) = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x0011C0CC File Offset: 0x0011A2CC
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000161CA File Offset: 0x000143CA
		public unsafe int m_WholeCollectMikeCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectMikeCard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectMikeCard)) = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x0011C0F4 File Offset: 0x0011A2F4
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x000161E5 File Offset: 0x000143E5
		public unsafe int m_WholeCollectFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCollectFund)) = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x0011C11C File Offset: 0x0011A31C
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x00016200 File Offset: 0x00014400
		public unsafe int m_MaxEarnedFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_MaxEarnedFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_MaxEarnedFund)) = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x0011C144 File Offset: 0x0011A344
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x0001621B File Offset: 0x0001441B
		public unsafe int m_ServedGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ServedGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ServedGuestNum)) = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x0011C16C File Offset: 0x0011A36C
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x00016236 File Offset: 0x00014436
		public unsafe int m_ServedSpecialGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ServedSpecialGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ServedSpecialGuestNum)) = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x0011C194 File Offset: 0x0011A394
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x00016251 File Offset: 0x00014451
		public unsafe int m_WholeCostInKourindou
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostInKourindou);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_WholeCostInKourindou)) = value;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x0011C1BC File Offset: 0x0011A3BC
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x0001626C File Offset: 0x0001446C
		public unsafe List<int> m_ActivatedToastTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ActivatedToastTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_ActivatedToastTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x0011C1EC File Offset: 0x0011A3EC
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x0001628B File Offset: 0x0001448B
		public unsafe RogueLikeRunTimeData.RogueLikeProductPool m_RogueLikeRecipePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeRecipePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.RogueLikeProductPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeRecipePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x0011C21C File Offset: 0x0011A41C
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x000162AA File Offset: 0x000144AA
		public unsafe RogueLikeRunTimeData.RogueLikeProductPool m_RogueLikeBeveragePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeBeveragePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.RogueLikeProductPool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_RogueLikeBeveragePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x0011C24C File Offset: 0x0011A44C
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x000162C9 File Offset: 0x000144C9
		public unsafe List<KeyValuePair<RogueLikePersistentCardInstance, int>> m_GainedCardPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GainedCardPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<RogueLikePersistentCardInstance, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_GainedCardPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x0011C27C File Offset: 0x0011A47C
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x000162E8 File Offset: 0x000144E8
		public unsafe float m_CurrentDifficultyCoefficient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyCoefficient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyCoefficient)) = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x0011C2A4 File Offset: 0x0011A4A4
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x00016303 File Offset: 0x00014503
		public unsafe int m_CurrentDifficultyPeak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyPeak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CurrentDifficultyPeak)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x0011C2CC File Offset: 0x0011A4CC
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x0001631E File Offset: 0x0001451E
		public unsafe float m_CollectRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CollectRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_CollectRate)) = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x0011C2F4 File Offset: 0x0011A4F4
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x00016339 File Offset: 0x00014539
		public unsafe List<int> m_EnabledEliteSpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_EnabledEliteSpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_EnabledEliteSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0011C324 File Offset: 0x0011A524
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x00016358 File Offset: 0x00014558
		public unsafe List<RogueLikeRunTimeData.EliteChallengeCache> m_HasFinishedEliteType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_HasFinishedEliteType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeRunTimeData.EliteChallengeCache>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_HasFinishedEliteType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x0011C354 File Offset: 0x0011A554
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x00016377 File Offset: 0x00014577
		public unsafe List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> m_AllActiveEliteChallenge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_AllActiveEliteChallenge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeSaveData.NativeFieldInfoPtr_m_AllActiveEliteChallenge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018CA RID: 6346
		private static readonly IntPtr NativeFieldInfoPtr_fileVersion;

		// Token: 0x040018CB RID: 6347
		private static readonly IntPtr NativeFieldInfoPtr_m_Difficulty;

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMapName;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMapNameLang;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr_m_GeneratedProducts;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeFieldInfoPtr_m_UnlockedSpots;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeFieldInfoPtr_m_VisitedSpots;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentRoundNum;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr_m_Funds;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedClothes;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedDecorations;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeFieldInfoPtr_m_StorageData;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeFieldInfoPtr_m_GainedAyaBuff;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeFieldInfoPtr_m_RealSaveTimeCode;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDLCs;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeTime;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCostIngredient;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCostBeverage;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCostFood;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectSpellCard;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectMikeCard;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectFund;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxEarnedFund;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeFieldInfoPtr_m_ServedGuestNum;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeFieldInfoPtr_m_ServedSpecialGuestNum;

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCostInKourindou;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_m_ActivatedToastTip;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeRecipePool;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_m_RogueLikeBeveragePool;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_m_GainedCardPool;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDifficultyCoefficient;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDifficultyPeak;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectRate;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_m_EnabledEliteSpecialGuests;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFinishedEliteType;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeFieldInfoPtr_m_AllActiveEliteChallenge;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Difficulty_String_String_Il2CppReferenceArray_1_Product_Dictionary_2_String_UnlockedIzakayaInfo_HashSet_1_String_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_RuntimePlayerDataCache_ValueTuple_2_Int32_Boolean_DateTime_Il2CppStringArray_Single_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_RogueLikeProductPool_RogueLikeProductPool_List_1_KeyValuePair_2_RogueLikePer;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_get_Difficulty_Public_get_Difficulty_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMapName_Public_get_String_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMapNameLang_Public_get_String_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneratedProducts_Public_get_IReadOnlyList_1_Product_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockedSpots_Public_get_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_get_VisitedSpots_Public_get_HashSet_1_String_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRoundNum_Public_get_Int32_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_get_Funds_Public_get_Int32_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_get_GainedAyaBuff_Public_get_ValueTuple_2_Int32_Boolean_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedClothes_Public_get_IReadOnlyList_1_Int32_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedDecorations_Public_get_IReadOnlyList_1_Int32_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_get_StorageData_Public_get_RuntimePlayerDataCache_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDLCs_Public_get_ICollection_1_String_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeTime_Public_get_Single_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCostIngredient_Public_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCostBeverage_Public_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCostFood_Public_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCollectSpellCard_Public_get_Int32_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCollectMikeCard_Public_get_Int32_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCollectFund_Public_get_Int32_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxEarnedFund_Public_get_Int32_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_get_ServedGuestNum_Public_get_Int32_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr_get_ServedSpecialGuestNum_Public_get_Int32_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeCostInKourindou_Public_get_Int32_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivatedToastTip_Public_get_List_1_Int32_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRecipePool_Public_get_RogueLikeProductPool_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeBeveragePool_Public_get_RogueLikeProductPool_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_get_GainedCardPool_Public_get_List_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDifficultyCoefficient_Public_get_Single_0;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDifficultyPeak_Public_get_Int32_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_get_CollectRate_Public_get_Single_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledEliteSpecialGuests_Public_get_List_1_Int32_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_get_HasFinishedEliteType_Public_get_List_1_EliteChallengeCache_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr_get_AllActiveEliteChallenge_Public_get_List_1_KeyValuePair_2_String_EliteChallengeCache_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeSaveData_0;
	}
}
