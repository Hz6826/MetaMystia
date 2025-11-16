using System;
using Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility
{
	// Token: 0x02000298 RID: 664
	public static class DataBaseDay : Il2CppSystem.Object
	{
		// Token: 0x06005461 RID: 21601 RVA: 0x001BB1C4 File Offset: 0x001B93C4
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseDay()
		{
			Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility", "DataBaseDay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr);
			DataBaseDay.NativeFieldInfoPtr_HOUR_DIVISIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "HOUR_DIVISIONS");
			DataBaseDay.NativeFieldInfoPtr_fanArtCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "fanArtCG");
			DataBaseDay.NativeFieldInfoPtr_allCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allCollectables");
			DataBaseDay.NativeFieldInfoPtr_allNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allNPCs");
			DataBaseDay.NativeFieldInfoPtr_allDialogPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allDialogPackages");
			DataBaseDay.NativeFieldInfoPtr_allMerchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allMerchants");
			DataBaseDay.NativeFieldInfoPtr_mapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "mapData");
			DataBaseDay.NativeFieldInfoPtr_mapReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "mapReference");
			DataBaseDay.NativeFieldInfoPtr_izakayaIdToMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "izakayaIdToMap");
			DataBaseDay.NativeFieldInfoPtr_kourindoStaticMerchandiseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "kourindoStaticMerchandiseData");
			DataBaseDay.NativeFieldInfoPtr_flandreHomeFurnitureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "flandreHomeFurnitureData");
			DataBaseDay.NativeFieldInfoPtr_globalIgnoreIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "globalIgnoreIngredients");
			DataBaseDay.NativeFieldInfoPtr_missionIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "missionIngredients");
			DataBaseDay.NativeFieldInfoPtr_globalOnlyOneDayValidItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "globalOnlyOneDayValidItems");
			DataBaseDay.NativeFieldInfoPtr_globalPublicExtraDiaglogSelectionsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "globalPublicExtraDiaglogSelectionsData");
			DataBaseDay.NativeFieldInfoPtr_allCollectablesLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allCollectablesLabels");
			DataBaseDay.NativeFieldInfoPtr_allSpawnMarkerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "allSpawnMarkerLabels");
			DataBaseDay.NativeFieldInfoPtr_additiveMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "additiveMapData");
			DataBaseDay.NativeFieldInfoPtr_globalMusicMapMappingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "globalMusicMapMappingData");
			DataBaseDay.NativeFieldInfoPtr_globalMusicChapterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "globalMusicChapterData");
			DataBaseDay.NativeFieldInfoPtr_m_LoadedSpecialGuestDialogData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "m_LoadedSpecialGuestDialogData");
			DataBaseDay.NativeFieldInfoPtr__AllCollectablesMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<AllCollectablesMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__AllNPCsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<AllNPCsMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__AllMappedNPCsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<AllMappedNPCsMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__AllMerchantsMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<AllMerchantsMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__MapDataMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<MapDataMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__KourindoStaticMerchandiseMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<KourindoStaticMerchandiseMapping>k__BackingField");
			DataBaseDay.NativeFieldInfoPtr__FlandreHomeFurnitureMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<FlandreHomeFurnitureMapping>k__BackingField");
			DataBaseDay.NativeMethodInfoPtr_get_AllCollectablesMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680543);
			DataBaseDay.NativeMethodInfoPtr_set_AllCollectablesMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680544);
			DataBaseDay.NativeMethodInfoPtr_get_AllNPCsMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680545);
			DataBaseDay.NativeMethodInfoPtr_set_AllNPCsMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680546);
			DataBaseDay.NativeMethodInfoPtr_get_AllMappedNPCsMapping_Public_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680547);
			DataBaseDay.NativeMethodInfoPtr_set_AllMappedNPCsMapping_Public_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680548);
			DataBaseDay.NativeMethodInfoPtr_get_AllMerchantsMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680549);
			DataBaseDay.NativeMethodInfoPtr_set_AllMerchantsMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680550);
			DataBaseDay.NativeMethodInfoPtr_get_MapDataMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680551);
			DataBaseDay.NativeMethodInfoPtr_set_MapDataMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680552);
			DataBaseDay.NativeMethodInfoPtr_get_KourindoStaticMerchandiseMapping_Private_Static_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680553);
			DataBaseDay.NativeMethodInfoPtr_set_KourindoStaticMerchandiseMapping_Private_Static_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680554);
			DataBaseDay.NativeMethodInfoPtr_get_FlandreHomeFurnitureMapping_Private_Static_get_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680555);
			DataBaseDay.NativeMethodInfoPtr_set_FlandreHomeFurnitureMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680556);
			DataBaseDay.NativeMethodInfoPtr_GetFanArtCG_Public_Static_List_1_CGPicture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680557);
			DataBaseDay.NativeMethodInfoPtr_GetCollectablesDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680558);
			DataBaseDay.NativeMethodInfoPtr_GetNPCDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680559);
			DataBaseDay.NativeMethodInfoPtr_GetMerchantsDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680560);
			DataBaseDay.NativeMethodInfoPtr_GetMapDataDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680561);
			DataBaseDay.NativeMethodInfoPtr_GetKourindoStaticMerchandiseDLCMapping_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680562);
			DataBaseDay.NativeMethodInfoPtr_GetFlandreHomeFurnitureDataDLCMapping_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680563);
			DataBaseDay.NativeMethodInfoPtr_GetAllDaySceneNormalGuestIndex_Public_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680564);
			DataBaseDay.NativeMethodInfoPtr_GetAllMapAssetReferences_Public_Static_IEnumerable_1_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680565);
			DataBaseDay.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseDayData_Dictionary_2_String_DialogPackage_List_1_Int32_List_1_Int32_Dictionary_2_String_MapNode_Dictionary_2_String_List_1_MapAdditiveData_List_1_Int32_List_1_SpecialGuestPublicExtraDialogData_Dictionary_2_String_List_1_CGPicture_Dictionary_2_String_MusicMapping_List_1_MusicChapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680566);
			DataBaseDay.NativeMethodInfoPtr_LoadSpecialGuestExtraDialogData_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680567);
			DataBaseDay.NativeMethodInfoPtr_UnloadSpecialGuestExtraDialogData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680568);
			DataBaseDay.NativeMethodInfoPtr_DaySceneGetSpecialGuestExtraDialogData_Public_Static_SpecialGuestExtraDialogData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680569);
			DataBaseDay.NativeMethodInfoPtr_DaySceneCheckSpecialGuestNotSkipGreeting_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680570);
			DataBaseDay.NativeMethodInfoPtr_GetIzakayaDataFromDaySceneMapId_Public_Static_ValueTuple_3_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680571);
			DataBaseDay.NativeMethodInfoPtr_GetDaySceneMapDataFromIzakayaId_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680572);
			DataBaseDay.NativeMethodInfoPtr_GetIzakayaLevel_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680573);
			DataBaseDay.NativeMethodInfoPtr_RefKourindoStaticMerchandise_Public_Static_KourindoStaticMerchandise_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680574);
			DataBaseDay.NativeMethodInfoPtr_GetAllKourindouLabels_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680575);
			DataBaseDay.NativeMethodInfoPtr_GetCollectablesFromMap_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680576);
			DataBaseDay.NativeMethodInfoPtr_SpawnMapReferenceAsync_Public_Static_UniTask_1_ValueTuple_2_IGameObjectAssetHandle_1_DaySceneMap_DaySceneMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680577);
			DataBaseDay.NativeMethodInfoPtr_GetMapLabelFromSpawnMarker_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680578);
			DataBaseDay.NativeMethodInfoPtr_GetAllMaps_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680579);
			DataBaseDay.NativeMethodInfoPtr_CheckIngredientNotIgnore_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680580);
			DataBaseDay.NativeMethodInfoPtr_IsMissionIngredient_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680581);
			DataBaseDay.NativeMethodInfoPtr_IsMissionOrIgnoreIngredient_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680582);
			DataBaseDay.NativeMethodInfoPtr_IsOneDayValidItem_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680583);
			DataBaseDay.NativeMethodInfoPtr_GetAllExtraDialogData_Public_Static_List_1_SpecialGuestPublicExtraDialogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680584);
			DataBaseDay.NativeMethodInfoPtr_RefMapNode_Public_Static_MapNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680585);
			DataBaseDay.NativeMethodInfoPtr_IsMapNodePresent_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680586);
			DataBaseDay.NativeMethodInfoPtr_RefCollectable_Public_Static_Collectable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680587);
			DataBaseDay.NativeMethodInfoPtr_RefNPC_Public_Static_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680588);
			DataBaseDay.NativeMethodInfoPtr_GetAllNPCKeys_Public_Static_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680589);
			DataBaseDay.NativeMethodInfoPtr_RefMerchant_Public_Static_Merchant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680590);
			DataBaseDay.NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680591);
			DataBaseDay.NativeMethodInfoPtr_RefDialogPackage_Public_Static_DialogPackage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680592);
			DataBaseDay.NativeMethodInfoPtr_IsDialogPackage_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680593);
			DataBaseDay.NativeMethodInfoPtr_GetAllCollectableLabels_Public_Static_Dictionary_2_String_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680594);
			DataBaseDay.NativeMethodInfoPtr_GetRegionMappingData_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680595);
			DataBaseDay.NativeMethodInfoPtr_HoursToActions_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680596);
			DataBaseDay.NativeMethodInfoPtr_MapNPCIdentity_Public_Static_String_Identity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680597);
			DataBaseDay.NativeMethodInfoPtr_GetAllMusicChapterCollection_Public_Static_IEnumerable_1_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680598);
			DataBaseDay.NativeMethodInfoPtr_GetMapMusicLabels_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680599);
			DataBaseDay.NativeMethodInfoPtr_GetMusicChapterMap_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680600);
			DataBaseDay.NativeMethodInfoPtr_GetMapMusicUnlockedLabels_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680601);
			DataBaseDay.NativeMethodInfoPtr_RefMusicChapter_Public_Static_MusicChapter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680602);
			DataBaseDay.NativeMethodInfoPtr_GetAllFurnitures_Public_Static_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680603);
			DataBaseDay.NativeMethodInfoPtr_RefFurniture_Public_Static_FlandreHomeFurniture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680604);
			DataBaseDay.NativeMethodInfoPtr_CollectableExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680605);
			DataBaseDay.NativeMethodInfoPtr_NPCExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680606);
			DataBaseDay.NativeMethodInfoPtr_MapExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680607);
			DataBaseDay.NativeMethodInfoPtr_KourindouStaticMerchandiseExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680608);
			DataBaseDay.NativeMethodInfoPtr_FlandreHomeFurnitureExists_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, 100680609);
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x001BB960 File Offset: 0x001B9B60
		// (set) Token: 0x06005463 RID: 21603 RVA: 0x001BB994 File Offset: 0x001B9B94
		public unsafe static Dictionary<string, string> AllCollectablesMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211418, XrefRangeEnd = 211420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_AllCollectablesMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211420, XrefRangeEnd = 211424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_AllCollectablesMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06005464 RID: 21604 RVA: 0x001BB9CC File Offset: 0x001B9BCC
		// (set) Token: 0x06005465 RID: 21605 RVA: 0x001BBA00 File Offset: 0x001B9C00
		public unsafe static Dictionary<string, string> AllNPCsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211424, XrefRangeEnd = 211426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_AllNPCsMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211426, XrefRangeEnd = 211430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_AllNPCsMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x001BBA38 File Offset: 0x001B9C38
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x001BBA6C File Offset: 0x001B9C6C
		public unsafe static Dictionary<string, string> AllMappedNPCsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211430, XrefRangeEnd = 211432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_AllMappedNPCsMapping_Public_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211432, XrefRangeEnd = 211436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_AllMappedNPCsMapping_Public_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x001BBAA4 File Offset: 0x001B9CA4
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x001BBAD8 File Offset: 0x001B9CD8
		public unsafe static Dictionary<string, string> AllMerchantsMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211436, XrefRangeEnd = 211438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_AllMerchantsMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211438, XrefRangeEnd = 211442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_AllMerchantsMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x0600546A RID: 21610 RVA: 0x001BBB10 File Offset: 0x001B9D10
		// (set) Token: 0x0600546B RID: 21611 RVA: 0x001BBB44 File Offset: 0x001B9D44
		public unsafe static Dictionary<string, string> MapDataMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211442, XrefRangeEnd = 211444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_MapDataMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211444, XrefRangeEnd = 211448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_MapDataMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x0600546C RID: 21612 RVA: 0x001BBB7C File Offset: 0x001B9D7C
		// (set) Token: 0x0600546D RID: 21613 RVA: 0x001BBBB0 File Offset: 0x001B9DB0
		public unsafe static Dictionary<string, string> KourindoStaticMerchandiseMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211448, XrefRangeEnd = 211450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_KourindoStaticMerchandiseMapping_Private_Static_get_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211450, XrefRangeEnd = 211454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_KourindoStaticMerchandiseMapping_Private_Static_set_Void_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x0600546E RID: 21614 RVA: 0x001BBBE8 File Offset: 0x001B9DE8
		// (set) Token: 0x0600546F RID: 21615 RVA: 0x001BBC1C File Offset: 0x001B9E1C
		public unsafe static Dictionary<int, string> FlandreHomeFurnitureMapping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211454, XrefRangeEnd = 211456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_get_FlandreHomeFurnitureMapping_Private_Static_get_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211456, XrefRangeEnd = 211460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_set_FlandreHomeFurnitureMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x001BBC54 File Offset: 0x001B9E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211466, RefRangeEnd = 211467, XrefRangeStart = 211460, XrefRangeEnd = 211466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<RunTimeScheduler.CGPicture> GetFanArtCG(string artLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(artLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetFanArtCG_Public_Static_List_1_CGPicture_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RunTimeScheduler.CGPicture>>(intPtr3) : null;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x001BBC98 File Offset: 0x001B9E98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211473, RefRangeEnd = 211474, XrefRangeStart = 211467, XrefRangeEnd = 211473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCollectablesDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetCollectablesDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x001BBCD4 File Offset: 0x001B9ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211485, RefRangeEnd = 211486, XrefRangeStart = 211474, XrefRangeEnd = 211485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNPCDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetNPCDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x001BBD10 File Offset: 0x001B9F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211493, RefRangeEnd = 211494, XrefRangeStart = 211486, XrefRangeEnd = 211493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMerchantsDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMerchantsDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x001BBD4C File Offset: 0x001B9F4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211501, RefRangeEnd = 211506, XrefRangeStart = 211494, XrefRangeEnd = 211501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMapDataDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMapDataDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x001BBD88 File Offset: 0x001B9F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211513, RefRangeEnd = 211514, XrefRangeStart = 211506, XrefRangeEnd = 211513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetKourindoStaticMerchandiseDLCMapping(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetKourindoStaticMerchandiseDLCMapping_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x001BBDC4 File Offset: 0x001B9FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211521, RefRangeEnd = 211522, XrefRangeStart = 211514, XrefRangeEnd = 211521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFlandreHomeFurnitureDataDLCMapping(this int key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetFlandreHomeFurnitureDataDLCMapping_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x001BBDFC File Offset: 0x001B9FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211569, RefRangeEnd = 211570, XrefRangeStart = 211522, XrefRangeEnd = 211569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetAllDaySceneNormalGuestIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllDaySceneNormalGuestIndex_Public_Static_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x001BBE30 File Offset: 0x001BA030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211576, RefRangeEnd = 211577, XrefRangeStart = 211570, XrefRangeEnd = 211576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<AssetReference> GetAllMapAssetReferences()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllMapAssetReferences_Public_Static_IEnumerable_1_AssetReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssetReference>>(intPtr3) : null;
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x001BBE64 File Offset: 0x001BA064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212013, RefRangeEnd = 212014, XrefRangeStart = 211577, XrefRangeEnd = 212013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Dictionary<string, DataBaseDay.DataBaseDayData> dayData, Dictionary<string, DialogPackage> dialogPackages, List<int> ignoreIngredients, List<int> missionIngredientsData, Dictionary<string, DaySceneMapProfile.MapNode> loadedMapRef, Dictionary<string, List<ExpandableGameDataPack.MapAdditiveData>> mapAdditiveData, List<int> onlyOneDayValidItems, List<SpecialGuestPublicExtraDialogData> publicExtraDiaglogSelectionsData, Dictionary<string, List<RunTimeScheduler.CGPicture>> fanArtCGData, Dictionary<string, MusicGameMappingProfile.MusicMapping> musicMapMapping, List<MusicGameChapterProfile.MusicChapter> musicChapterData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dayData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dialogPackages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreIngredients);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(missionIngredientsData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedMapRef);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapAdditiveData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onlyOneDayValidItems);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(publicExtraDiaglogSelectionsData);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fanArtCGData);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicMapMapping);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicChapterData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseDayData_Dictionary_2_String_DialogPackage_List_1_Int32_List_1_Int32_Dictionary_2_String_MapNode_Dictionary_2_String_List_1_MapAdditiveData_List_1_Int32_List_1_SpecialGuestPublicExtraDialogData_Dictionary_2_String_List_1_CGPicture_Dictionary_2_String_MusicMapping_List_1_MusicChapter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x001BBF58 File Offset: 0x001BA158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212014, XrefRangeEnd = 212019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask LoadSpecialGuestExtraDialogData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_LoadSpecialGuestExtraDialogData_Public_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x001BBF84 File Offset: 0x001BA184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212043, RefRangeEnd = 212045, XrefRangeStart = 212019, XrefRangeEnd = 212043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadSpecialGuestExtraDialogData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_UnloadSpecialGuestExtraDialogData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x001BBFAC File Offset: 0x001BA1AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212053, RefRangeEnd = 212056, XrefRangeStart = 212045, XrefRangeEnd = 212053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpecialGuestExtraDialogData DaySceneGetSpecialGuestExtraDialogData(this int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_DaySceneGetSpecialGuestExtraDialogData_Public_Static_SpecialGuestExtraDialogData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuestExtraDialogData>(intPtr3) : null;
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x001BBFEC File Offset: 0x001BA1EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212068, RefRangeEnd = 212070, XrefRangeStart = 212056, XrefRangeEnd = 212068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DaySceneCheckSpecialGuestNotSkipGreeting(this int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_DaySceneCheckSpecialGuestNotSkipGreeting_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x001BC02C File Offset: 0x001BA22C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 212076, RefRangeEnd = 212088, XrefRangeStart = 212070, XrefRangeEnd = 212076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>> GetIzakayaDataFromDaySceneMapId(string daySceneMapData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(daySceneMapData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetIzakayaDataFromDaySceneMapId_Public_Static_ValueTuple_3_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>>(pointer);
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x001BC068 File Offset: 0x001BA268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212093, RefRangeEnd = 212096, XrefRangeStart = 212088, XrefRangeEnd = 212093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDaySceneMapDataFromIzakayaId(int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetDaySceneMapDataFromIzakayaId_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x001BC0A0 File Offset: 0x001BA2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212128, RefRangeEnd = 212129, XrefRangeStart = 212096, XrefRangeEnd = 212128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIzakayaLevel(int izakayaId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetIzakayaLevel_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x001BC0E0 File Offset: 0x001BA2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212134, RefRangeEnd = 212137, XrefRangeStart = 212129, XrefRangeEnd = 212134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KourindoStaticMerchandiseProfile.KourindoStaticMerchandise RefKourindoStaticMerchandise(this string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefKourindoStaticMerchandise_Public_Static_KourindoStaticMerchandise_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new KourindoStaticMerchandiseProfile.KourindoStaticMerchandise(pointer);
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x001BC11C File Offset: 0x001BA31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212161, RefRangeEnd = 212162, XrefRangeStart = 212137, XrefRangeEnd = 212161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetAllKourindouLabels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllKourindouLabels_Public_Static_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x001BC150 File Offset: 0x001BA350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212170, RefRangeEnd = 212172, XrefRangeStart = 212162, XrefRangeEnd = 212170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetCollectablesFromMap(this string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetCollectablesFromMap_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x001BC194 File Offset: 0x001BA394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212181, RefRangeEnd = 212182, XrefRangeStart = 212172, XrefRangeEnd = 212181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>> SpawnMapReferenceAsync(string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_SpawnMapReferenceAsync_Public_Static_UniTask_1_ValueTuple_2_IGameObjectAssetHandle_1_DaySceneMap_DaySceneMap_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>(pointer);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x001BC1D0 File Offset: 0x001BA3D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212205, RefRangeEnd = 212208, XrefRangeStart = 212182, XrefRangeEnd = 212205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMapLabelFromSpawnMarker(this string spawnMarker)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(spawnMarker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMapLabelFromSpawnMarker_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x001BC20C File Offset: 0x001BA40C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212214, RefRangeEnd = 212219, XrefRangeStart = 212208, XrefRangeEnd = 212214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetAllMaps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllMaps_Public_Static_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x001BC240 File Offset: 0x001BA440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212224, RefRangeEnd = 212226, XrefRangeStart = 212219, XrefRangeEnd = 212224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIngredientNotIgnore(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_CheckIngredientNotIgnore_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x001BC280 File Offset: 0x001BA480
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 212232, RefRangeEnd = 212242, XrefRangeStart = 212226, XrefRangeEnd = 212232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMissionIngredient(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsMissionIngredient_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x001BC2C0 File Offset: 0x001BA4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212247, RefRangeEnd = 212248, XrefRangeStart = 212242, XrefRangeEnd = 212247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMissionOrIgnoreIngredient(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsMissionOrIgnoreIngredient_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x001BC300 File Offset: 0x001BA500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212254, RefRangeEnd = 212255, XrefRangeStart = 212248, XrefRangeEnd = 212254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOneDayValidItem(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsOneDayValidItem_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x001BC340 File Offset: 0x001BA540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212255, XrefRangeEnd = 212257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<SpecialGuestPublicExtraDialogData> GetAllExtraDialogData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllExtraDialogData_Public_Static_List_1_SpecialGuestPublicExtraDialogData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SpecialGuestPublicExtraDialogData>>(intPtr3) : null;
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x001BC374 File Offset: 0x001BA574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212262, RefRangeEnd = 212265, XrefRangeStart = 212257, XrefRangeEnd = 212262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DaySceneMapProfile.MapNode RefMapNode(this string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefMapNode_Public_Static_MapNode_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DaySceneMapProfile.MapNode(pointer);
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x001BC3B0 File Offset: 0x001BA5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212271, RefRangeEnd = 212272, XrefRangeStart = 212265, XrefRangeEnd = 212271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMapNodePresent(this string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsMapNodePresent_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x001BC3F4 File Offset: 0x001BA5F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212277, RefRangeEnd = 212284, XrefRangeStart = 212272, XrefRangeEnd = 212277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Collectable RefCollectable(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefCollectable_Public_Static_Collectable_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Collectable(pointer);
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x001BC430 File Offset: 0x001BA630
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 212289, RefRangeEnd = 212319, XrefRangeStart = 212284, XrefRangeEnd = 212289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NPC RefNPC(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefNPC_Public_Static_NPC_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NPC(pointer);
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x001BC46C File Offset: 0x001BA66C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212325, RefRangeEnd = 212332, XrefRangeStart = 212319, XrefRangeEnd = 212325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetAllNPCKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllNPCKeys_Public_Static_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x001BC4A0 File Offset: 0x001BA6A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 212337, RefRangeEnd = 212345, XrefRangeStart = 212332, XrefRangeEnd = 212337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Merchant RefMerchant(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefMerchant_Public_Static_Merchant_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Merchant(pointer);
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x001BC4DC File Offset: 0x001BA6DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212351, RefRangeEnd = 212355, XrefRangeStart = 212345, XrefRangeEnd = 212351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMerchant(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x001BC520 File Offset: 0x001BA720
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212361, RefRangeEnd = 212366, XrefRangeStart = 212355, XrefRangeEnd = 212361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DialogPackage RefDialogPackage(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefDialogPackage_Public_Static_DialogPackage_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr3) : null;
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x001BC564 File Offset: 0x001BA764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212372, RefRangeEnd = 212376, XrefRangeStart = 212366, XrefRangeEnd = 212372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDialogPackage(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_IsDialogPackage_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x001BC5A8 File Offset: 0x001BA7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212376, XrefRangeEnd = 212378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, HashSet<string>> GetAllCollectableLabels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllCollectableLabels_Public_Static_Dictionary_2_String_HashSet_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(intPtr3) : null;
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x001BC5DC File Offset: 0x001BA7DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212402, RefRangeEnd = 212404, XrefRangeStart = 212378, XrefRangeEnd = 212402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KeyValuePair<string, string>> GetRegionMappingData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetRegionMappingData_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<string, string>>>(intPtr3) : null;
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x001BC610 File Offset: 0x001BA810
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212404, RefRangeEnd = 212408, XrefRangeStart = 212404, XrefRangeEnd = 212404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int HoursToActions(this int hour)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_HoursToActions_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x001BC650 File Offset: 0x001BA850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212413, RefRangeEnd = 212415, XrefRangeStart = 212408, XrefRangeEnd = 212413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNPCIdentity(SceneDirector.Identity identity, int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref identity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_MapNPCIdentity_Public_Static_String_Identity_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x001BC698 File Offset: 0x001BA898
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212453, RefRangeEnd = 212457, XrefRangeStart = 212415, XrefRangeEnd = 212453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<MusicGameMappingProfile.MusicMapping> GetAllMusicChapterCollection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllMusicChapterCollection_Public_Static_IEnumerable_1_MusicMapping_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MusicGameMappingProfile.MusicMapping>>(intPtr3) : null;
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x001BC6CC File Offset: 0x001BA8CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 212462, RefRangeEnd = 212466, XrefRangeStart = 212457, XrefRangeEnd = 212462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetMapMusicLabels(string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMapMusicLabels_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x001BC710 File Offset: 0x001BA910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212483, RefRangeEnd = 212484, XrefRangeStart = 212466, XrefRangeEnd = 212483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMusicChapterMap(string musicLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMusicChapterMap_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x001BC74C File Offset: 0x001BA94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212489, RefRangeEnd = 212490, XrefRangeStart = 212484, XrefRangeEnd = 212489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetMapMusicUnlockedLabels(string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetMapMusicUnlockedLabels_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x001BC790 File Offset: 0x001BA990
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 212495, RefRangeEnd = 212503, XrefRangeStart = 212490, XrefRangeEnd = 212495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MusicGameChapterProfile.MusicChapter RefMusicChapter(this string musicLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicLabel);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefMusicChapter_Public_Static_MusicChapter_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new MusicGameChapterProfile.MusicChapter(pointer);
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x001BC7CC File Offset: 0x001BA9CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212509, RefRangeEnd = 212510, XrefRangeStart = 212503, XrefRangeEnd = 212509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<int> GetAllFurnitures()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_GetAllFurnitures_Public_Static_IEnumerable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x001BC800 File Offset: 0x001BAA00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212519, RefRangeEnd = 212526, XrefRangeStart = 212510, XrefRangeEnd = 212519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FlandreHomeFurnitureProfile.FlandreHomeFurniture RefFurniture(this int label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref label;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_RefFurniture_Public_Static_FlandreHomeFurniture_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FlandreHomeFurnitureProfile.FlandreHomeFurniture(pointer);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x001BC838 File Offset: 0x001BAA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212532, RefRangeEnd = 212533, XrefRangeStart = 212526, XrefRangeEnd = 212532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CollectableExists(string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_CollectableExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x001BC87C File Offset: 0x001BAA7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212539, RefRangeEnd = 212546, XrefRangeStart = 212533, XrefRangeEnd = 212539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NPCExists(this string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_NPCExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x001BC8C0 File Offset: 0x001BAAC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 212552, RefRangeEnd = 212559, XrefRangeStart = 212546, XrefRangeEnd = 212552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MapExists(string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_MapExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x001BC904 File Offset: 0x001BAB04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212565, RefRangeEnd = 212566, XrefRangeStart = 212559, XrefRangeEnd = 212565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool KourindouStaticMerchandiseExists(string label)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_KourindouStaticMerchandiseExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x001BC948 File Offset: 0x001BAB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212572, RefRangeEnd = 212573, XrefRangeStart = 212566, XrefRangeEnd = 212572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FlandreHomeFurnitureExists(int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.NativeMethodInfoPtr_FlandreHomeFurnitureExists_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x0002D836 File Offset: 0x0002BA36
		public DataBaseDay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x001BC988 File Offset: 0x001BAB88
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x0002D83F File Offset: 0x0002BA3F
		public unsafe static int HOUR_DIVISIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_HOUR_DIVISIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_HOUR_DIVISIONS, (void*)(&value));
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x001BC9A4 File Offset: 0x001BABA4
		// (set) Token: 0x060054A9 RID: 21673 RVA: 0x0002D84D File Offset: 0x0002BA4D
		public unsafe static Dictionary<string, List<RunTimeScheduler.CGPicture>> fanArtCG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_fanArtCG, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<RunTimeScheduler.CGPicture>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_fanArtCG, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x001BC9CC File Offset: 0x001BABCC
		// (set) Token: 0x060054AB RID: 21675 RVA: 0x0002D85F File Offset: 0x0002BA5F
		public unsafe static Dictionary<string, Collectable> allCollectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allCollectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Collectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allCollectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x001BC9F4 File Offset: 0x001BABF4
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x0002D871 File Offset: 0x0002BA71
		public unsafe static Dictionary<string, NPC> allNPCs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allNPCs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NPC>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allNPCs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x001BCA1C File Offset: 0x001BAC1C
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x0002D883 File Offset: 0x0002BA83
		public unsafe static Dictionary<string, DialogPackage> allDialogPackages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allDialogPackages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allDialogPackages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x001BCA44 File Offset: 0x001BAC44
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x0002D895 File Offset: 0x0002BA95
		public unsafe static Dictionary<string, Merchant> allMerchants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allMerchants, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Merchant>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allMerchants, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x001BCA6C File Offset: 0x001BAC6C
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x0002D8A7 File Offset: 0x0002BAA7
		public unsafe static Dictionary<string, DaySceneMapProfile.MapNode> mapData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_mapData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneMapProfile.MapNode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_mapData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x001BCA94 File Offset: 0x001BAC94
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x0002D8B9 File Offset: 0x0002BAB9
		public unsafe static Dictionary<string, AssetReference> mapReference
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_mapReference, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AssetReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_mapReference, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x001BCABC File Offset: 0x001BACBC
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x0002D8CB File Offset: 0x0002BACB
		public unsafe static Dictionary<int, string> izakayaIdToMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_izakayaIdToMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_izakayaIdToMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x001BCAE4 File Offset: 0x001BACE4
		// (set) Token: 0x060054B9 RID: 21689 RVA: 0x0002D8DD File Offset: 0x0002BADD
		public unsafe static Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> kourindoStaticMerchandiseData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_kourindoStaticMerchandiseData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_kourindoStaticMerchandiseData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x001BCB0C File Offset: 0x001BAD0C
		// (set) Token: 0x060054BB RID: 21691 RVA: 0x0002D8EF File Offset: 0x0002BAEF
		public unsafe static Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> flandreHomeFurnitureData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_flandreHomeFurnitureData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_flandreHomeFurnitureData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x001BCB34 File Offset: 0x001BAD34
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x0002D901 File Offset: 0x0002BB01
		public unsafe static List<int> globalIgnoreIngredients
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_globalIgnoreIngredients, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_globalIgnoreIngredients, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x001BCB5C File Offset: 0x001BAD5C
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x0002D913 File Offset: 0x0002BB13
		public unsafe static List<int> missionIngredients
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_missionIngredients, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_missionIngredients, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x001BCB84 File Offset: 0x001BAD84
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x0002D925 File Offset: 0x0002BB25
		public unsafe static List<int> globalOnlyOneDayValidItems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_globalOnlyOneDayValidItems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_globalOnlyOneDayValidItems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x001BCBAC File Offset: 0x001BADAC
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x0002D937 File Offset: 0x0002BB37
		public unsafe static List<SpecialGuestPublicExtraDialogData> globalPublicExtraDiaglogSelectionsData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_globalPublicExtraDiaglogSelectionsData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpecialGuestPublicExtraDialogData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_globalPublicExtraDiaglogSelectionsData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x001BCBD4 File Offset: 0x001BADD4
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x0002D949 File Offset: 0x0002BB49
		public unsafe static Dictionary<string, HashSet<string>> allCollectablesLabels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allCollectablesLabels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allCollectablesLabels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x001BCBFC File Offset: 0x001BADFC
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x0002D95B File Offset: 0x0002BB5B
		public unsafe static Dictionary<string, HashSet<string>> allSpawnMarkerLabels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_allSpawnMarkerLabels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_allSpawnMarkerLabels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x001BCC24 File Offset: 0x001BAE24
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x0002D96D File Offset: 0x0002BB6D
		public unsafe static Dictionary<string, List<ExpandableGameDataPack.MapAdditiveData>> additiveMapData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_additiveMapData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<ExpandableGameDataPack.MapAdditiveData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_additiveMapData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x001BCC4C File Offset: 0x001BAE4C
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x0002D97F File Offset: 0x0002BB7F
		public unsafe static Dictionary<string, MusicGameMappingProfile.MusicMapping> globalMusicMapMappingData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_globalMusicMapMappingData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, MusicGameMappingProfile.MusicMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_globalMusicMapMappingData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x001BCC74 File Offset: 0x001BAE74
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x0002D991 File Offset: 0x0002BB91
		public unsafe static Dictionary<string, MusicGameChapterProfile.MusicChapter> globalMusicChapterData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_globalMusicChapterData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, MusicGameChapterProfile.MusicChapter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_globalMusicChapterData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x001BCC9C File Offset: 0x001BAE9C
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x0002D9A3 File Offset: 0x0002BBA3
		public unsafe static Dictionary<int, IAssetHandle<SpecialGuestExtraDialogData>> m_LoadedSpecialGuestDialogData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr_m_LoadedSpecialGuestDialogData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IAssetHandle<SpecialGuestExtraDialogData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr_m_LoadedSpecialGuestDialogData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x001BCCC4 File Offset: 0x001BAEC4
		// (set) Token: 0x060054D1 RID: 21713 RVA: 0x0002D9B5 File Offset: 0x0002BBB5
		public unsafe static Dictionary<string, string> _AllCollectablesMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__AllCollectablesMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__AllCollectablesMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x001BCCEC File Offset: 0x001BAEEC
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x0002D9C7 File Offset: 0x0002BBC7
		public unsafe static Dictionary<string, string> _AllNPCsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__AllNPCsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__AllNPCsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0E RID: 7438
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x001BCD14 File Offset: 0x001BAF14
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x0002D9D9 File Offset: 0x0002BBD9
		public unsafe static Dictionary<string, string> _AllMappedNPCsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__AllMappedNPCsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__AllMappedNPCsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0F RID: 7439
		// (get) Token: 0x060054D6 RID: 21718 RVA: 0x001BCD3C File Offset: 0x001BAF3C
		// (set) Token: 0x060054D7 RID: 21719 RVA: 0x0002D9EB File Offset: 0x0002BBEB
		public unsafe static Dictionary<string, string> _AllMerchantsMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__AllMerchantsMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__AllMerchantsMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D10 RID: 7440
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x001BCD64 File Offset: 0x001BAF64
		// (set) Token: 0x060054D9 RID: 21721 RVA: 0x0002D9FD File Offset: 0x0002BBFD
		public unsafe static Dictionary<string, string> _MapDataMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__MapDataMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__MapDataMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x001BCD8C File Offset: 0x001BAF8C
		// (set) Token: 0x060054DB RID: 21723 RVA: 0x0002DA0F File Offset: 0x0002BC0F
		public unsafe static Dictionary<string, string> _KourindoStaticMerchandiseMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__KourindoStaticMerchandiseMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__KourindoStaticMerchandiseMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x060054DC RID: 21724 RVA: 0x001BCDB4 File Offset: 0x001BAFB4
		// (set) Token: 0x060054DD RID: 21725 RVA: 0x0002DA21 File Offset: 0x0002BC21
		public unsafe static Dictionary<int, string> _FlandreHomeFurnitureMapping_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseDay.NativeFieldInfoPtr__FlandreHomeFurnitureMapping_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseDay.NativeFieldInfoPtr__FlandreHomeFurnitureMapping_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeFieldInfoPtr_HOUR_DIVISIONS;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeFieldInfoPtr_fanArtCG;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeFieldInfoPtr_allCollectables;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeFieldInfoPtr_allNPCs;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeFieldInfoPtr_allDialogPackages;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeFieldInfoPtr_allMerchants;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeFieldInfoPtr_mapData;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeFieldInfoPtr_mapReference;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeFieldInfoPtr_izakayaIdToMap;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeFieldInfoPtr_kourindoStaticMerchandiseData;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeFieldInfoPtr_flandreHomeFurnitureData;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeFieldInfoPtr_globalIgnoreIngredients;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeFieldInfoPtr_missionIngredients;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeFieldInfoPtr_globalOnlyOneDayValidItems;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeFieldInfoPtr_globalPublicExtraDiaglogSelectionsData;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeFieldInfoPtr_allCollectablesLabels;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeFieldInfoPtr_allSpawnMarkerLabels;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeFieldInfoPtr_additiveMapData;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeFieldInfoPtr_globalMusicMapMappingData;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeFieldInfoPtr_globalMusicChapterData;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedSpecialGuestDialogData;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeFieldInfoPtr__AllCollectablesMapping_k__BackingField;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeFieldInfoPtr__AllNPCsMapping_k__BackingField;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeFieldInfoPtr__AllMappedNPCsMapping_k__BackingField;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeFieldInfoPtr__AllMerchantsMapping_k__BackingField;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeFieldInfoPtr__MapDataMapping_k__BackingField;

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeFieldInfoPtr__KourindoStaticMerchandiseMapping_k__BackingField;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeFieldInfoPtr__FlandreHomeFurnitureMapping_k__BackingField;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCollectablesMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeMethodInfoPtr_set_AllCollectablesMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeMethodInfoPtr_get_AllNPCsMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeMethodInfoPtr_set_AllNPCsMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeMethodInfoPtr_get_AllMappedNPCsMapping_Public_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeMethodInfoPtr_set_AllMappedNPCsMapping_Public_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeMethodInfoPtr_get_AllMerchantsMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeMethodInfoPtr_set_AllMerchantsMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeMethodInfoPtr_get_MapDataMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_set_MapDataMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_get_KourindoStaticMerchandiseMapping_Private_Static_get_Dictionary_2_String_String_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_set_KourindoStaticMerchandiseMapping_Private_Static_set_Void_Dictionary_2_String_String_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_get_FlandreHomeFurnitureMapping_Private_Static_get_Dictionary_2_Int32_String_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_set_FlandreHomeFurnitureMapping_Private_Static_set_Void_Dictionary_2_Int32_String_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr_GetFanArtCG_Public_Static_List_1_CGPicture_String_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly IntPtr NativeMethodInfoPtr_GetCollectablesDLCMapping_Public_Static_String_String_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCDLCMapping_Public_Static_String_String_0;

		// Token: 0x040038D6 RID: 14550
		private static readonly IntPtr NativeMethodInfoPtr_GetMerchantsDLCMapping_Public_Static_String_String_0;

		// Token: 0x040038D7 RID: 14551
		private static readonly IntPtr NativeMethodInfoPtr_GetMapDataDLCMapping_Public_Static_String_String_0;

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeMethodInfoPtr_GetKourindoStaticMerchandiseDLCMapping_Public_Static_String_String_0;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeMethodInfoPtr_GetFlandreHomeFurnitureDataDLCMapping_Public_Static_String_Int32_0;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDaySceneNormalGuestIndex_Public_Static_Il2CppStructArray_1_Int32_0;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMapAssetReferences_Public_Static_IEnumerable_1_AssetReference_0;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Dictionary_2_String_DataBaseDayData_Dictionary_2_String_DialogPackage_List_1_Int32_List_1_Int32_Dictionary_2_String_MapNode_Dictionary_2_String_List_1_MapAdditiveData_List_1_Int32_List_1_SpecialGuestPublicExtraDialogData_Dictionary_2_String_List_1_CGPicture_Dictionary_2_String_MusicMapping_List_1_MusicChapter_0;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpecialGuestExtraDialogData_Public_Static_UniTask_0;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSpecialGuestExtraDialogData_Public_Static_Void_0;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeMethodInfoPtr_DaySceneGetSpecialGuestExtraDialogData_Public_Static_SpecialGuestExtraDialogData_Int32_0;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeMethodInfoPtr_DaySceneCheckSpecialGuestNotSkipGreeting_Public_Static_Boolean_Int32_0;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaDataFromDaySceneMapId_Public_Static_ValueTuple_3_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_IReadOnlyList_1_Int32_String_0;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_GetDaySceneMapDataFromIzakayaId_Public_Static_String_Int32_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaLevel_Public_Static_Int32_Int32_0;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeMethodInfoPtr_RefKourindoStaticMerchandise_Public_Static_KourindoStaticMerchandise_String_0;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeMethodInfoPtr_GetAllKourindouLabels_Public_Static_IEnumerable_1_String_0;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr_GetCollectablesFromMap_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr_SpawnMapReferenceAsync_Public_Static_UniTask_1_ValueTuple_2_IGameObjectAssetHandle_1_DaySceneMap_DaySceneMap_String_0;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeMethodInfoPtr_GetMapLabelFromSpawnMarker_Public_Static_String_String_0;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMaps_Public_Static_IEnumerable_1_String_0;

		// Token: 0x040038EA RID: 14570
		private static readonly IntPtr NativeMethodInfoPtr_CheckIngredientNotIgnore_Public_Static_Boolean_Int32_0;

		// Token: 0x040038EB RID: 14571
		private static readonly IntPtr NativeMethodInfoPtr_IsMissionIngredient_Public_Static_Boolean_Int32_0;

		// Token: 0x040038EC RID: 14572
		private static readonly IntPtr NativeMethodInfoPtr_IsMissionOrIgnoreIngredient_Public_Static_Boolean_Int32_0;

		// Token: 0x040038ED RID: 14573
		private static readonly IntPtr NativeMethodInfoPtr_IsOneDayValidItem_Public_Static_Boolean_Int32_0;

		// Token: 0x040038EE RID: 14574
		private static readonly IntPtr NativeMethodInfoPtr_GetAllExtraDialogData_Public_Static_List_1_SpecialGuestPublicExtraDialogData_0;

		// Token: 0x040038EF RID: 14575
		private static readonly IntPtr NativeMethodInfoPtr_RefMapNode_Public_Static_MapNode_String_0;

		// Token: 0x040038F0 RID: 14576
		private static readonly IntPtr NativeMethodInfoPtr_IsMapNodePresent_Public_Static_Boolean_String_0;

		// Token: 0x040038F1 RID: 14577
		private static readonly IntPtr NativeMethodInfoPtr_RefCollectable_Public_Static_Collectable_String_0;

		// Token: 0x040038F2 RID: 14578
		private static readonly IntPtr NativeMethodInfoPtr_RefNPC_Public_Static_NPC_String_0;

		// Token: 0x040038F3 RID: 14579
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNPCKeys_Public_Static_IEnumerable_1_String_0;

		// Token: 0x040038F4 RID: 14580
		private static readonly IntPtr NativeMethodInfoPtr_RefMerchant_Public_Static_Merchant_String_0;

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeMethodInfoPtr_RefDialogPackage_Public_Static_DialogPackage_String_0;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeMethodInfoPtr_IsDialogPackage_Public_Static_Boolean_String_0;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCollectableLabels_Public_Static_Dictionary_2_String_HashSet_1_String_0;

		// Token: 0x040038F9 RID: 14585
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionMappingData_Public_Static_Il2CppReferenceArray_1_KeyValuePair_2_String_String_0;

		// Token: 0x040038FA RID: 14586
		private static readonly IntPtr NativeMethodInfoPtr_HoursToActions_Public_Static_Int32_Int32_0;

		// Token: 0x040038FB RID: 14587
		private static readonly IntPtr NativeMethodInfoPtr_MapNPCIdentity_Public_Static_String_Identity_Int32_0;

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMusicChapterCollection_Public_Static_IEnumerable_1_MusicMapping_0;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeMethodInfoPtr_GetMapMusicLabels_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeMethodInfoPtr_GetMusicChapterMap_Public_Static_String_String_0;

		// Token: 0x040038FF RID: 14591
		private static readonly IntPtr NativeMethodInfoPtr_GetMapMusicUnlockedLabels_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04003900 RID: 14592
		private static readonly IntPtr NativeMethodInfoPtr_RefMusicChapter_Public_Static_MusicChapter_String_0;

		// Token: 0x04003901 RID: 14593
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFurnitures_Public_Static_IEnumerable_1_Int32_0;

		// Token: 0x04003902 RID: 14594
		private static readonly IntPtr NativeMethodInfoPtr_RefFurniture_Public_Static_FlandreHomeFurniture_Int32_0;

		// Token: 0x04003903 RID: 14595
		private static readonly IntPtr NativeMethodInfoPtr_CollectableExists_Public_Static_Boolean_String_0;

		// Token: 0x04003904 RID: 14596
		private static readonly IntPtr NativeMethodInfoPtr_NPCExists_Public_Static_Boolean_String_0;

		// Token: 0x04003905 RID: 14597
		private static readonly IntPtr NativeMethodInfoPtr_MapExists_Public_Static_Boolean_String_0;

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeMethodInfoPtr_KourindouStaticMerchandiseExists_Public_Static_Boolean_String_0;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeMethodInfoPtr_FlandreHomeFurnitureExists_Public_Static_Boolean_Int32_0;

		// Token: 0x02000C3E RID: 3134
		public class DataBaseDayData : Il2CppSystem.Object
		{
			// Token: 0x0600E2BB RID: 58043 RVA: 0x00369EBC File Offset: 0x003680BC
			// Note: this type is marked as 'beforefieldinit'.
			static DataBaseDayData()
			{
				Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "DataBaseDayData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr);
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllCollectables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<AllCollectables>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<AllNPCs>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllMerchants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<AllMerchants>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__MapData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<MapData>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__KourindoStaticMerchandise_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<KourindoStaticMerchandise>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__FlandreHomeFurniture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, "<FlandreHomeFurniture>k__BackingField");
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Collectable_Dictionary_2_String_NPC_Dictionary_2_String_Merchant_Dictionary_2_String_MapNode_Dictionary_2_String_KourindoStaticMerchandise_Dictionary_2_Int32_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680610);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllCollectables_Internal_get_Dictionary_2_String_Collectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680611);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllCollectables_Internal_set_Void_Dictionary_2_String_Collectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680612);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllNPCs_Internal_get_Dictionary_2_String_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680613);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllNPCs_Internal_set_Void_Dictionary_2_String_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680614);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllMerchants_Internal_get_Dictionary_2_String_Merchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680615);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllMerchants_Internal_set_Void_Dictionary_2_String_Merchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680616);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_MapData_Internal_get_Dictionary_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680617);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_MapData_Internal_set_Void_Dictionary_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680618);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_KourindoStaticMerchandise_Internal_get_Dictionary_2_String_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680619);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_KourindoStaticMerchandise_Internal_set_Void_Dictionary_2_String_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680620);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_FlandreHomeFurniture_Internal_get_Dictionary_2_Int32_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680621);
				DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_FlandreHomeFurniture_Internal_set_Void_Dictionary_2_Int32_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr, 100680622);
			}

			// Token: 0x0600E2BC RID: 58044 RVA: 0x0036A064 File Offset: 0x00368264
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211185, RefRangeEnd = 211186, XrefRangeStart = 211178, XrefRangeEnd = 211185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataBaseDayData(Dictionary<string, Collectable> allCollectables, Dictionary<string, NPC> allNPCs, Dictionary<string, Merchant> allMerchants, Dictionary<string, DaySceneMapProfile.MapNode> mapData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> kourindoStaticMerchandise, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> flandreHomeFurniture) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay.DataBaseDayData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allCollectables);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allNPCs);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allMerchants);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapData);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(kourindoStaticMerchandise);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flandreHomeFurniture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Collectable_Dictionary_2_String_NPC_Dictionary_2_String_Merchant_Dictionary_2_String_MapNode_Dictionary_2_String_KourindoStaticMerchandise_Dictionary_2_Int32_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049A3 RID: 18851
			// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x0036A10C File Offset: 0x0036830C
			// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x0036A14C File Offset: 0x0036834C
			public unsafe Dictionary<string, Collectable> AllCollectables
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllCollectables_Internal_get_Dictionary_2_String_Collectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Collectable>>(intPtr3) : null;
				}
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllCollectables_Internal_set_Void_Dictionary_2_String_Collectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170049A4 RID: 18852
			// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x0036A190 File Offset: 0x00368390
			// (set) Token: 0x0600E2C0 RID: 58048 RVA: 0x0036A1D0 File Offset: 0x003683D0
			public unsafe Dictionary<string, NPC> AllNPCs
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllNPCs_Internal_get_Dictionary_2_String_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NPC>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllNPCs_Internal_set_Void_Dictionary_2_String_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170049A5 RID: 18853
			// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x0036A214 File Offset: 0x00368414
			// (set) Token: 0x0600E2C2 RID: 58050 RVA: 0x0036A254 File Offset: 0x00368454
			public unsafe Dictionary<string, Merchant> AllMerchants
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_AllMerchants_Internal_get_Dictionary_2_String_Merchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Merchant>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_AllMerchants_Internal_set_Void_Dictionary_2_String_Merchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170049A6 RID: 18854
			// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x0036A298 File Offset: 0x00368498
			// (set) Token: 0x0600E2C4 RID: 58052 RVA: 0x0036A2D8 File Offset: 0x003684D8
			public unsafe Dictionary<string, DaySceneMapProfile.MapNode> MapData
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_MapData_Internal_get_Dictionary_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneMapProfile.MapNode>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_MapData_Internal_set_Void_Dictionary_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170049A7 RID: 18855
			// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x0036A31C File Offset: 0x0036851C
			// (set) Token: 0x0600E2C6 RID: 58054 RVA: 0x0036A35C File Offset: 0x0036855C
			public unsafe Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> KourindoStaticMerchandise
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_KourindoStaticMerchandise_Internal_get_Dictionary_2_String_KourindoStaticMerchandise_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_KourindoStaticMerchandise_Internal_set_Void_Dictionary_2_String_KourindoStaticMerchandise_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170049A8 RID: 18856
			// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x0036A3A0 File Offset: 0x003685A0
			// (set) Token: 0x0600E2C8 RID: 58056 RVA: 0x0036A3E0 File Offset: 0x003685E0
			public unsafe Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> FlandreHomeFurniture
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_get_FlandreHomeFurniture_Internal_get_Dictionary_2_Int32_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.DataBaseDayData.NativeMethodInfoPtr_set_FlandreHomeFurniture_Internal_set_Void_Dictionary_2_Int32_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600E2C9 RID: 58057 RVA: 0x00078F18 File Offset: 0x00077118
			public DataBaseDayData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700499D RID: 18845
			// (get) Token: 0x0600E2CA RID: 58058 RVA: 0x0036A424 File Offset: 0x00368624
			// (set) Token: 0x0600E2CB RID: 58059 RVA: 0x00078F21 File Offset: 0x00077121
			public unsafe Dictionary<string, Collectable> _AllCollectables_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllCollectables_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Collectable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllCollectables_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499E RID: 18846
			// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x0036A454 File Offset: 0x00368654
			// (set) Token: 0x0600E2CD RID: 58061 RVA: 0x00078F40 File Offset: 0x00077140
			public unsafe Dictionary<string, NPC> _AllNPCs_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllNPCs_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NPC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllNPCs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700499F RID: 18847
			// (get) Token: 0x0600E2CE RID: 58062 RVA: 0x0036A484 File Offset: 0x00368684
			// (set) Token: 0x0600E2CF RID: 58063 RVA: 0x00078F5F File Offset: 0x0007715F
			public unsafe Dictionary<string, Merchant> _AllMerchants_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllMerchants_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Merchant>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__AllMerchants_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A0 RID: 18848
			// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x0036A4B4 File Offset: 0x003686B4
			// (set) Token: 0x0600E2D1 RID: 58065 RVA: 0x00078F7E File Offset: 0x0007717E
			public unsafe Dictionary<string, DaySceneMapProfile.MapNode> _MapData_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__MapData_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneMapProfile.MapNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__MapData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A1 RID: 18849
			// (get) Token: 0x0600E2D2 RID: 58066 RVA: 0x0036A4E4 File Offset: 0x003686E4
			// (set) Token: 0x0600E2D3 RID: 58067 RVA: 0x00078F9D File Offset: 0x0007719D
			public unsafe Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> _KourindoStaticMerchandise_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__KourindoStaticMerchandise_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__KourindoStaticMerchandise_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049A2 RID: 18850
			// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x0036A514 File Offset: 0x00368714
			// (set) Token: 0x0600E2D5 RID: 58069 RVA: 0x00078FBC File Offset: 0x000771BC
			public unsafe Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> _FlandreHomeFurniture_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__FlandreHomeFurniture_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.DataBaseDayData.NativeFieldInfoPtr__FlandreHomeFurniture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090F3 RID: 37107
			private static readonly IntPtr NativeFieldInfoPtr__AllCollectables_k__BackingField;

			// Token: 0x040090F4 RID: 37108
			private static readonly IntPtr NativeFieldInfoPtr__AllNPCs_k__BackingField;

			// Token: 0x040090F5 RID: 37109
			private static readonly IntPtr NativeFieldInfoPtr__AllMerchants_k__BackingField;

			// Token: 0x040090F6 RID: 37110
			private static readonly IntPtr NativeFieldInfoPtr__MapData_k__BackingField;

			// Token: 0x040090F7 RID: 37111
			private static readonly IntPtr NativeFieldInfoPtr__KourindoStaticMerchandise_k__BackingField;

			// Token: 0x040090F8 RID: 37112
			private static readonly IntPtr NativeFieldInfoPtr__FlandreHomeFurniture_k__BackingField;

			// Token: 0x040090F9 RID: 37113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Collectable_Dictionary_2_String_NPC_Dictionary_2_String_Merchant_Dictionary_2_String_MapNode_Dictionary_2_String_KourindoStaticMerchandise_Dictionary_2_Int32_FlandreHomeFurniture_0;

			// Token: 0x040090FA RID: 37114
			private static readonly IntPtr NativeMethodInfoPtr_get_AllCollectables_Internal_get_Dictionary_2_String_Collectable_0;

			// Token: 0x040090FB RID: 37115
			private static readonly IntPtr NativeMethodInfoPtr_set_AllCollectables_Internal_set_Void_Dictionary_2_String_Collectable_0;

			// Token: 0x040090FC RID: 37116
			private static readonly IntPtr NativeMethodInfoPtr_get_AllNPCs_Internal_get_Dictionary_2_String_NPC_0;

			// Token: 0x040090FD RID: 37117
			private static readonly IntPtr NativeMethodInfoPtr_set_AllNPCs_Internal_set_Void_Dictionary_2_String_NPC_0;

			// Token: 0x040090FE RID: 37118
			private static readonly IntPtr NativeMethodInfoPtr_get_AllMerchants_Internal_get_Dictionary_2_String_Merchant_0;

			// Token: 0x040090FF RID: 37119
			private static readonly IntPtr NativeMethodInfoPtr_set_AllMerchants_Internal_set_Void_Dictionary_2_String_Merchant_0;

			// Token: 0x04009100 RID: 37120
			private static readonly IntPtr NativeMethodInfoPtr_get_MapData_Internal_get_Dictionary_2_String_MapNode_0;

			// Token: 0x04009101 RID: 37121
			private static readonly IntPtr NativeMethodInfoPtr_set_MapData_Internal_set_Void_Dictionary_2_String_MapNode_0;

			// Token: 0x04009102 RID: 37122
			private static readonly IntPtr NativeMethodInfoPtr_get_KourindoStaticMerchandise_Internal_get_Dictionary_2_String_KourindoStaticMerchandise_0;

			// Token: 0x04009103 RID: 37123
			private static readonly IntPtr NativeMethodInfoPtr_set_KourindoStaticMerchandise_Internal_set_Void_Dictionary_2_String_KourindoStaticMerchandise_0;

			// Token: 0x04009104 RID: 37124
			private static readonly IntPtr NativeMethodInfoPtr_get_FlandreHomeFurniture_Internal_get_Dictionary_2_Int32_FlandreHomeFurniture_0;

			// Token: 0x04009105 RID: 37125
			private static readonly IntPtr NativeMethodInfoPtr_set_FlandreHomeFurniture_Internal_set_Void_Dictionary_2_Int32_FlandreHomeFurniture_0;
		}

		// Token: 0x02000C3F RID: 3135
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.DataBaseDay+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E2D6 RID: 58070 RVA: 0x0036A544 File Offset: 0x00368744
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr);
				DataBaseDay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9");
				DataBaseDay.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__56_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__56_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__56_1");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_1");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_2");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_3");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_4");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_5");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_6");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_7");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_8");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_9");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_10");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_11");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_12");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_13");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_14");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_15");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_16");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_17");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_18");
				DataBaseDay.__c.NativeFieldInfoPtr___9__58_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__58_19");
				DataBaseDay.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__59_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__59_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__59_1");
				DataBaseDay.__c.NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__67_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__87_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__87_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__90_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__90_0");
				DataBaseDay.__c.NativeFieldInfoPtr___9__90_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, "<>9__90_1");
				DataBaseDay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680624);
				DataBaseDay.__c.NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680625);
				DataBaseDay.__c.NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_1_Internal_Int32_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680626);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_0_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680627);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_1_Internal_Dictionary_2_String_NPC_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680628);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_2_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680629);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_3_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680630);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_4_Internal_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680631);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_5_Internal_AssetReference_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680632);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_6_Internal_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680633);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_7_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680634);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_8_Internal_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680635);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_9_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680636);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_10_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680637);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_11_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680638);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_12_Internal_String_MusicChapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680639);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_13_Internal_MusicChapter_MusicChapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680640);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_14_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680641);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_15_Internal_Dictionary_2_String_NPC_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680642);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_16_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680643);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_17_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680644);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_18_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680645);
				DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_19_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680646);
				DataBaseDay.__c.NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_0_Internal_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680647);
				DataBaseDay.__c.NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_1_Internal_ValueTuple_2_Int32_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_IAssetHandle_1_SpecialGuestExtraDialogData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680648);
				DataBaseDay.__c.NativeMethodInfoPtr__GetAllKourindouLabels_b__67_0_Internal_String_KeyValuePair_2_String_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680649);
				DataBaseDay.__c.NativeMethodInfoPtr__GetRegionMappingData_b__87_0_Internal_KeyValuePair_2_String_String_KeyValuePair_2_String_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680650);
				DataBaseDay.__c.NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_0_Internal_Boolean_KeyValuePair_2_String_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680651);
				DataBaseDay.__c.NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_1_Internal_MusicMapping_KeyValuePair_2_String_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr, 100680652);
			}

			// Token: 0x0600E2D7 RID: 58071 RVA: 0x0036A9F8 File Offset: 0x00368BF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2D8 RID: 58072 RVA: 0x0036AA34 File Offset: 0x00368C34
			[CallerCount(0)]
			public unsafe bool _GetAllDaySceneNormalGuestIndex_b__56_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2D9 RID: 58073 RVA: 0x0036AA88 File Offset: 0x00368C88
			[CallerCount(0)]
			public unsafe int _GetAllDaySceneNormalGuestIndex_b__56_1(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_1_Internal_Int32_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2DA RID: 58074 RVA: 0x0036AADC File Offset: 0x00368CDC
			[CallerCount(0)]
			public unsafe Dictionary<string, Collectable> _Initialize_b__58_0(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_0_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Collectable>>(intPtr3) : null;
			}

			// Token: 0x0600E2DB RID: 58075 RVA: 0x0036AB2C File Offset: 0x00368D2C
			[CallerCount(0)]
			public unsafe Dictionary<string, NPC> _Initialize_b__58_1(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_1_Internal_Dictionary_2_String_NPC_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NPC>>(intPtr3) : null;
			}

			// Token: 0x0600E2DC RID: 58076 RVA: 0x0036AB7C File Offset: 0x00368D7C
			[CallerCount(0)]
			public unsafe Dictionary<string, Merchant> _Initialize_b__58_2(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_2_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Merchant>>(intPtr3) : null;
			}

			// Token: 0x0600E2DD RID: 58077 RVA: 0x0036ABCC File Offset: 0x00368DCC
			[CallerCount(0)]
			public unsafe Dictionary<string, DaySceneMapProfile.MapNode> _Initialize_b__58_3(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_3_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneMapProfile.MapNode>>(intPtr3) : null;
			}

			// Token: 0x0600E2DE RID: 58078 RVA: 0x0036AC1C File Offset: 0x00368E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211186, XrefRangeEnd = 211187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__58_4(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_4_Internal_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E2DF RID: 58079 RVA: 0x0036AC6C File Offset: 0x00368E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211187, XrefRangeEnd = 211188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AssetReference _Initialize_b__58_5(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_5_Internal_AssetReference_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0600E2E0 RID: 58080 RVA: 0x0036ACC4 File Offset: 0x00368EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211188, XrefRangeEnd = 211189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__58_6(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_6_Internal_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E2E1 RID: 58081 RVA: 0x0036AD14 File Offset: 0x00368F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211189, XrefRangeEnd = 211196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashSet<string> _Initialize_b__58_7(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_7_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}

			// Token: 0x0600E2E2 RID: 58082 RVA: 0x0036AD6C File Offset: 0x00368F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211196, XrefRangeEnd = 211197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Initialize_b__58_8(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_8_Internal_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E2E3 RID: 58083 RVA: 0x0036ADBC File Offset: 0x00368FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211197, XrefRangeEnd = 211204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashSet<string> _Initialize_b__58_9(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_9_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}

			// Token: 0x0600E2E4 RID: 58084 RVA: 0x0036AE14 File Offset: 0x00369014
			[CallerCount(0)]
			public unsafe Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> _Initialize_b__58_10(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_10_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr3) : null;
			}

			// Token: 0x0600E2E5 RID: 58085 RVA: 0x0036AE64 File Offset: 0x00369064
			[CallerCount(0)]
			public unsafe Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> _Initialize_b__58_11(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_11_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr3) : null;
			}

			// Token: 0x0600E2E6 RID: 58086 RVA: 0x0036AEB4 File Offset: 0x003690B4
			[CallerCount(0)]
			public unsafe string _Initialize_b__58_12(MusicGameChapterProfile.MusicChapter x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_12_Internal_String_MusicChapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E2E7 RID: 58087 RVA: 0x0036AF04 File Offset: 0x00369104
			[CallerCount(0)]
			public unsafe MusicGameChapterProfile.MusicChapter _Initialize_b__58_13(MusicGameChapterProfile.MusicChapter y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_13_Internal_MusicChapter_MusicChapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicGameChapterProfile.MusicChapter(pointer);
			}

			// Token: 0x0600E2E8 RID: 58088 RVA: 0x0036AF54 File Offset: 0x00369154
			[CallerCount(0)]
			public unsafe Dictionary<string, Collectable> _Initialize_b__58_14(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_14_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Collectable>>(intPtr3) : null;
			}

			// Token: 0x0600E2E9 RID: 58089 RVA: 0x0036AFA4 File Offset: 0x003691A4
			[CallerCount(0)]
			public unsafe Dictionary<string, NPC> _Initialize_b__58_15(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_15_Internal_Dictionary_2_String_NPC_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, NPC>>(intPtr3) : null;
			}

			// Token: 0x0600E2EA RID: 58090 RVA: 0x0036AFF4 File Offset: 0x003691F4
			[CallerCount(0)]
			public unsafe Dictionary<string, Merchant> _Initialize_b__58_16(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_16_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Merchant>>(intPtr3) : null;
			}

			// Token: 0x0600E2EB RID: 58091 RVA: 0x0036B044 File Offset: 0x00369244
			[CallerCount(0)]
			public unsafe Dictionary<string, DaySceneMapProfile.MapNode> _Initialize_b__58_17(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_17_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DaySceneMapProfile.MapNode>>(intPtr3) : null;
			}

			// Token: 0x0600E2EC RID: 58092 RVA: 0x0036B094 File Offset: 0x00369294
			[CallerCount(0)]
			public unsafe Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> _Initialize_b__58_18(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_18_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr3) : null;
			}

			// Token: 0x0600E2ED RID: 58093 RVA: 0x0036B0E4 File Offset: 0x003692E4
			[CallerCount(0)]
			public unsafe Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> _Initialize_b__58_19(DataBaseDay.DataBaseDayData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__Initialize_b__58_19_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr3) : null;
			}

			// Token: 0x0600E2EE RID: 58094 RVA: 0x0036B134 File Offset: 0x00369334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211204, XrefRangeEnd = 211205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandle<SpecialGuestExtraDialogData>> _LoadSpecialGuestExtraDialogData_b__59_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_0_Internal_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandle<SpecialGuestExtraDialogData>>(pointer);
			}

			// Token: 0x0600E2EF RID: 58095 RVA: 0x0036B17C File Offset: 0x0036937C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211205, XrefRangeEnd = 211208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, IAssetHandle<SpecialGuestExtraDialogData>> _LoadSpecialGuestExtraDialogData_b__59_1(SpecialGuest a, IAssetHandle<SpecialGuestExtraDialogData> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_1_Internal_ValueTuple_2_Int32_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_IAssetHandle_1_SpecialGuestExtraDialogData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, IAssetHandle<SpecialGuestExtraDialogData>>(pointer);
			}

			// Token: 0x0600E2F0 RID: 58096 RVA: 0x0036B1D8 File Offset: 0x003693D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211208, XrefRangeEnd = 211209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllKourindouLabels_b__67_0(KeyValuePair<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetAllKourindouLabels_b__67_0_Internal_String_KeyValuePair_2_String_KourindoStaticMerchandise_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E2F1 RID: 58097 RVA: 0x0036B228 File Offset: 0x00369428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211209, XrefRangeEnd = 211218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<string, string> _GetRegionMappingData_b__87_0(KeyValuePair<string, DaySceneMapProfile.MapNode> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetRegionMappingData_b__87_0_Internal_KeyValuePair_2_String_String_KeyValuePair_2_String_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<string, string>(pointer);
			}

			// Token: 0x0600E2F2 RID: 58098 RVA: 0x0036B278 File Offset: 0x00369478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211218, XrefRangeEnd = 211224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllMusicChapterCollection_b__90_0(KeyValuePair<string, MusicGameMappingProfile.MusicMapping> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_0_Internal_Boolean_KeyValuePair_2_String_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2F3 RID: 58099 RVA: 0x0036B2CC File Offset: 0x003694CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211224, XrefRangeEnd = 211225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MusicGameMappingProfile.MusicMapping _GetAllMusicChapterCollection_b__90_1(KeyValuePair<string, MusicGameMappingProfile.MusicMapping> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c.NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_1_Internal_MusicMapping_KeyValuePair_2_String_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicGameMappingProfile.MusicMapping(pointer);
			}

			// Token: 0x0600E2F4 RID: 58100 RVA: 0x00078FDB File Offset: 0x000771DB
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049A9 RID: 18857
			// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x0036B31C File Offset: 0x0036951C
			// (set) Token: 0x0600E2F6 RID: 58102 RVA: 0x00078FE4 File Offset: 0x000771E4
			public unsafe static DataBaseDay.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseDay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AA RID: 18858
			// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x0036B344 File Offset: 0x00369544
			// (set) Token: 0x0600E2F8 RID: 58104 RVA: 0x00078FF6 File Offset: 0x000771F6
			public unsafe static Func<NPC, bool> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AB RID: 18859
			// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x0036B36C File Offset: 0x0036956C
			// (set) Token: 0x0600E2FA RID: 58106 RVA: 0x00079008 File Offset: 0x00077208
			public unsafe static Func<NPC, int> __9__56_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__56_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__56_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AC RID: 18860
			// (get) Token: 0x0600E2FB RID: 58107 RVA: 0x0036B394 File Offset: 0x00369594
			// (set) Token: 0x0600E2FC RID: 58108 RVA: 0x0007901A File Offset: 0x0007721A
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, Collectable>> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, Collectable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AD RID: 18861
			// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x0036B3BC File Offset: 0x003695BC
			// (set) Token: 0x0600E2FE RID: 58110 RVA: 0x0007902C File Offset: 0x0007722C
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, NPC>> __9__58_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, NPC>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AE RID: 18862
			// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x0036B3E4 File Offset: 0x003695E4
			// (set) Token: 0x0600E300 RID: 58112 RVA: 0x0007903E File Offset: 0x0007723E
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, Merchant>> __9__58_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, Merchant>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049AF RID: 18863
			// (get) Token: 0x0600E301 RID: 58113 RVA: 0x0036B40C File Offset: 0x0036960C
			// (set) Token: 0x0600E302 RID: 58114 RVA: 0x00079050 File Offset: 0x00077250
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, DaySceneMapProfile.MapNode>> __9__58_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, DaySceneMapProfile.MapNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B0 RID: 18864
			// (get) Token: 0x0600E303 RID: 58115 RVA: 0x0036B434 File Offset: 0x00369634
			// (set) Token: 0x0600E304 RID: 58116 RVA: 0x00079062 File Offset: 0x00077262
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string> __9__58_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B1 RID: 18865
			// (get) Token: 0x0600E305 RID: 58117 RVA: 0x0036B45C File Offset: 0x0036965C
			// (set) Token: 0x0600E306 RID: 58118 RVA: 0x00079074 File Offset: 0x00077274
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, AssetReference> __9__58_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B2 RID: 18866
			// (get) Token: 0x0600E307 RID: 58119 RVA: 0x0036B484 File Offset: 0x00369684
			// (set) Token: 0x0600E308 RID: 58120 RVA: 0x00079086 File Offset: 0x00077286
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string> __9__58_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B3 RID: 18867
			// (get) Token: 0x0600E309 RID: 58121 RVA: 0x0036B4AC File Offset: 0x003696AC
			// (set) Token: 0x0600E30A RID: 58122 RVA: 0x00079098 File Offset: 0x00077298
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, HashSet<string>> __9__58_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, HashSet<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B4 RID: 18868
			// (get) Token: 0x0600E30B RID: 58123 RVA: 0x0036B4D4 File Offset: 0x003696D4
			// (set) Token: 0x0600E30C RID: 58124 RVA: 0x000790AA File Offset: 0x000772AA
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string> __9__58_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B5 RID: 18869
			// (get) Token: 0x0600E30D RID: 58125 RVA: 0x0036B4FC File Offset: 0x003696FC
			// (set) Token: 0x0600E30E RID: 58126 RVA: 0x000790BC File Offset: 0x000772BC
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, HashSet<string>> __9__58_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, HashSet<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B6 RID: 18870
			// (get) Token: 0x0600E30F RID: 58127 RVA: 0x0036B524 File Offset: 0x00369724
			// (set) Token: 0x0600E310 RID: 58128 RVA: 0x000790CE File Offset: 0x000772CE
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>> __9__58_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B7 RID: 18871
			// (get) Token: 0x0600E311 RID: 58129 RVA: 0x0036B54C File Offset: 0x0036974C
			// (set) Token: 0x0600E312 RID: 58130 RVA: 0x000790E0 File Offset: 0x000772E0
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>> __9__58_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B8 RID: 18872
			// (get) Token: 0x0600E313 RID: 58131 RVA: 0x0036B574 File Offset: 0x00369774
			// (set) Token: 0x0600E314 RID: 58132 RVA: 0x000790F2 File Offset: 0x000772F2
			public unsafe static Func<MusicGameChapterProfile.MusicChapter, string> __9__58_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameChapterProfile.MusicChapter, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049B9 RID: 18873
			// (get) Token: 0x0600E315 RID: 58133 RVA: 0x0036B59C File Offset: 0x0036979C
			// (set) Token: 0x0600E316 RID: 58134 RVA: 0x00079104 File Offset: 0x00077304
			public unsafe static Func<MusicGameChapterProfile.MusicChapter, MusicGameChapterProfile.MusicChapter> __9__58_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameChapterProfile.MusicChapter, MusicGameChapterProfile.MusicChapter>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BA RID: 18874
			// (get) Token: 0x0600E317 RID: 58135 RVA: 0x0036B5C4 File Offset: 0x003697C4
			// (set) Token: 0x0600E318 RID: 58136 RVA: 0x00079116 File Offset: 0x00077316
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, Collectable>> __9__58_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, Collectable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BB RID: 18875
			// (get) Token: 0x0600E319 RID: 58137 RVA: 0x0036B5EC File Offset: 0x003697EC
			// (set) Token: 0x0600E31A RID: 58138 RVA: 0x00079128 File Offset: 0x00077328
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, NPC>> __9__58_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, NPC>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BC RID: 18876
			// (get) Token: 0x0600E31B RID: 58139 RVA: 0x0036B614 File Offset: 0x00369814
			// (set) Token: 0x0600E31C RID: 58140 RVA: 0x0007913A File Offset: 0x0007733A
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, Merchant>> __9__58_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, Merchant>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BD RID: 18877
			// (get) Token: 0x0600E31D RID: 58141 RVA: 0x0036B63C File Offset: 0x0036983C
			// (set) Token: 0x0600E31E RID: 58142 RVA: 0x0007914C File Offset: 0x0007734C
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, DaySceneMapProfile.MapNode>> __9__58_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, DaySceneMapProfile.MapNode>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BE RID: 18878
			// (get) Token: 0x0600E31F RID: 58143 RVA: 0x0036B664 File Offset: 0x00369864
			// (set) Token: 0x0600E320 RID: 58144 RVA: 0x0007915E File Offset: 0x0007735E
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>> __9__58_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049BF RID: 18879
			// (get) Token: 0x0600E321 RID: 58145 RVA: 0x0036B68C File Offset: 0x0036988C
			// (set) Token: 0x0600E322 RID: 58146 RVA: 0x00079170 File Offset: 0x00077370
			public unsafe static Func<DataBaseDay.DataBaseDayData, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>> __9__58_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseDay.DataBaseDayData, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__58_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C0 RID: 18880
			// (get) Token: 0x0600E323 RID: 58147 RVA: 0x0036B6B4 File Offset: 0x003698B4
			// (set) Token: 0x0600E324 RID: 58148 RVA: 0x00079182 File Offset: 0x00077382
			public unsafe static Func<SpecialGuest, UniTask<IAssetHandle<SpecialGuestExtraDialogData>>> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, UniTask<IAssetHandle<SpecialGuestExtraDialogData>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C1 RID: 18881
			// (get) Token: 0x0600E325 RID: 58149 RVA: 0x0036B6DC File Offset: 0x003698DC
			// (set) Token: 0x0600E326 RID: 58150 RVA: 0x00079194 File Offset: 0x00077394
			public unsafe static Func<SpecialGuest, IAssetHandle<SpecialGuestExtraDialogData>, ValueTuple<int, IAssetHandle<SpecialGuestExtraDialogData>>> __9__59_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__59_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, IAssetHandle<SpecialGuestExtraDialogData>, ValueTuple<int, IAssetHandle<SpecialGuestExtraDialogData>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__59_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C2 RID: 18882
			// (get) Token: 0x0600E327 RID: 58151 RVA: 0x0036B704 File Offset: 0x00369904
			// (set) Token: 0x0600E328 RID: 58152 RVA: 0x000791A6 File Offset: 0x000773A6
			public unsafe static Func<KeyValuePair<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>, string> __9__67_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__67_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C3 RID: 18883
			// (get) Token: 0x0600E329 RID: 58153 RVA: 0x0036B72C File Offset: 0x0036992C
			// (set) Token: 0x0600E32A RID: 58154 RVA: 0x000791B8 File Offset: 0x000773B8
			public unsafe static Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, KeyValuePair<string, string>> __9__87_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__87_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, DaySceneMapProfile.MapNode>, KeyValuePair<string, string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__87_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C4 RID: 18884
			// (get) Token: 0x0600E32B RID: 58155 RVA: 0x0036B754 File Offset: 0x00369954
			// (set) Token: 0x0600E32C RID: 58156 RVA: 0x000791CA File Offset: 0x000773CA
			public unsafe static Func<KeyValuePair<string, MusicGameMappingProfile.MusicMapping>, bool> __9__90_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__90_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, MusicGameMappingProfile.MusicMapping>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__90_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C5 RID: 18885
			// (get) Token: 0x0600E32D RID: 58157 RVA: 0x0036B77C File Offset: 0x0036997C
			// (set) Token: 0x0600E32E RID: 58158 RVA: 0x000791DC File Offset: 0x000773DC
			public unsafe static Func<KeyValuePair<string, MusicGameMappingProfile.MusicMapping>, MusicGameMappingProfile.MusicMapping> __9__90_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseDay.__c.NativeFieldInfoPtr___9__90_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, MusicGameMappingProfile.MusicMapping>, MusicGameMappingProfile.MusicMapping>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseDay.__c.NativeFieldInfoPtr___9__90_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009106 RID: 37126
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009107 RID: 37127
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x04009108 RID: 37128
			private static readonly IntPtr NativeFieldInfoPtr___9__56_1;

			// Token: 0x04009109 RID: 37129
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x0400910A RID: 37130
			private static readonly IntPtr NativeFieldInfoPtr___9__58_1;

			// Token: 0x0400910B RID: 37131
			private static readonly IntPtr NativeFieldInfoPtr___9__58_2;

			// Token: 0x0400910C RID: 37132
			private static readonly IntPtr NativeFieldInfoPtr___9__58_3;

			// Token: 0x0400910D RID: 37133
			private static readonly IntPtr NativeFieldInfoPtr___9__58_4;

			// Token: 0x0400910E RID: 37134
			private static readonly IntPtr NativeFieldInfoPtr___9__58_5;

			// Token: 0x0400910F RID: 37135
			private static readonly IntPtr NativeFieldInfoPtr___9__58_6;

			// Token: 0x04009110 RID: 37136
			private static readonly IntPtr NativeFieldInfoPtr___9__58_7;

			// Token: 0x04009111 RID: 37137
			private static readonly IntPtr NativeFieldInfoPtr___9__58_8;

			// Token: 0x04009112 RID: 37138
			private static readonly IntPtr NativeFieldInfoPtr___9__58_9;

			// Token: 0x04009113 RID: 37139
			private static readonly IntPtr NativeFieldInfoPtr___9__58_10;

			// Token: 0x04009114 RID: 37140
			private static readonly IntPtr NativeFieldInfoPtr___9__58_11;

			// Token: 0x04009115 RID: 37141
			private static readonly IntPtr NativeFieldInfoPtr___9__58_12;

			// Token: 0x04009116 RID: 37142
			private static readonly IntPtr NativeFieldInfoPtr___9__58_13;

			// Token: 0x04009117 RID: 37143
			private static readonly IntPtr NativeFieldInfoPtr___9__58_14;

			// Token: 0x04009118 RID: 37144
			private static readonly IntPtr NativeFieldInfoPtr___9__58_15;

			// Token: 0x04009119 RID: 37145
			private static readonly IntPtr NativeFieldInfoPtr___9__58_16;

			// Token: 0x0400911A RID: 37146
			private static readonly IntPtr NativeFieldInfoPtr___9__58_17;

			// Token: 0x0400911B RID: 37147
			private static readonly IntPtr NativeFieldInfoPtr___9__58_18;

			// Token: 0x0400911C RID: 37148
			private static readonly IntPtr NativeFieldInfoPtr___9__58_19;

			// Token: 0x0400911D RID: 37149
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x0400911E RID: 37150
			private static readonly IntPtr NativeFieldInfoPtr___9__59_1;

			// Token: 0x0400911F RID: 37151
			private static readonly IntPtr NativeFieldInfoPtr___9__67_0;

			// Token: 0x04009120 RID: 37152
			private static readonly IntPtr NativeFieldInfoPtr___9__87_0;

			// Token: 0x04009121 RID: 37153
			private static readonly IntPtr NativeFieldInfoPtr___9__90_0;

			// Token: 0x04009122 RID: 37154
			private static readonly IntPtr NativeFieldInfoPtr___9__90_1;

			// Token: 0x04009123 RID: 37155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009124 RID: 37156
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_0_Internal_Boolean_NPC_0;

			// Token: 0x04009125 RID: 37157
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDaySceneNormalGuestIndex_b__56_1_Internal_Int32_NPC_0;

			// Token: 0x04009126 RID: 37158
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_0_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0;

			// Token: 0x04009127 RID: 37159
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_1_Internal_Dictionary_2_String_NPC_DataBaseDayData_0;

			// Token: 0x04009128 RID: 37160
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_2_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0;

			// Token: 0x04009129 RID: 37161
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_3_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0;

			// Token: 0x0400912A RID: 37162
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_4_Internal_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400912B RID: 37163
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_5_Internal_AssetReference_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400912C RID: 37164
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_6_Internal_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400912D RID: 37165
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_7_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400912E RID: 37166
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_8_Internal_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400912F RID: 37167
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_9_Internal_HashSet_1_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x04009130 RID: 37168
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_10_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0;

			// Token: 0x04009131 RID: 37169
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_11_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0;

			// Token: 0x04009132 RID: 37170
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_12_Internal_String_MusicChapter_0;

			// Token: 0x04009133 RID: 37171
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_13_Internal_MusicChapter_MusicChapter_0;

			// Token: 0x04009134 RID: 37172
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_14_Internal_Dictionary_2_String_Collectable_DataBaseDayData_0;

			// Token: 0x04009135 RID: 37173
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_15_Internal_Dictionary_2_String_NPC_DataBaseDayData_0;

			// Token: 0x04009136 RID: 37174
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_16_Internal_Dictionary_2_String_Merchant_DataBaseDayData_0;

			// Token: 0x04009137 RID: 37175
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_17_Internal_Dictionary_2_String_MapNode_DataBaseDayData_0;

			// Token: 0x04009138 RID: 37176
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_18_Internal_Dictionary_2_String_KourindoStaticMerchandise_DataBaseDayData_0;

			// Token: 0x04009139 RID: 37177
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__58_19_Internal_Dictionary_2_Int32_FlandreHomeFurniture_DataBaseDayData_0;

			// Token: 0x0400913A RID: 37178
			private static readonly IntPtr NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_0_Internal_UniTask_1_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_0;

			// Token: 0x0400913B RID: 37179
			private static readonly IntPtr NativeMethodInfoPtr__LoadSpecialGuestExtraDialogData_b__59_1_Internal_ValueTuple_2_Int32_IAssetHandle_1_SpecialGuestExtraDialogData_SpecialGuest_IAssetHandle_1_SpecialGuestExtraDialogData_0;

			// Token: 0x0400913C RID: 37180
			private static readonly IntPtr NativeMethodInfoPtr__GetAllKourindouLabels_b__67_0_Internal_String_KeyValuePair_2_String_KourindoStaticMerchandise_0;

			// Token: 0x0400913D RID: 37181
			private static readonly IntPtr NativeMethodInfoPtr__GetRegionMappingData_b__87_0_Internal_KeyValuePair_2_String_String_KeyValuePair_2_String_MapNode_0;

			// Token: 0x0400913E RID: 37182
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_0_Internal_Boolean_KeyValuePair_2_String_MusicMapping_0;

			// Token: 0x0400913F RID: 37183
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMusicChapterCollection_b__90_1_Internal_MusicMapping_KeyValuePair_2_String_MusicMapping_0;
		}

		// Token: 0x02000C40 RID: 3136
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.DataBaseDay+<LoadSpecialGuestExtraDialogData>d__59")]
		public sealed class _LoadSpecialGuestExtraDialogData_d__59 : ValueType
		{
			// Token: 0x0600E32F RID: 58159 RVA: 0x0036B7A4 File Offset: 0x003699A4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadSpecialGuestExtraDialogData_d__59()
			{
				Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<LoadSpecialGuestExtraDialogData>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr);
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, "<>1__state");
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, "<>t__builder");
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr__allSpecialGuests_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, "<allSpecialGuests>5__2");
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, "<>u__1");
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, 100680653);
				DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr, 100680654);
			}

			// Token: 0x0600E330 RID: 58160 RVA: 0x0036B848 File Offset: 0x00369A48
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 211267, RefRangeEnd = 211270, XrefRangeStart = 211225, XrefRangeEnd = 211267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E331 RID: 58161 RVA: 0x0036B880 File Offset: 0x00369A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E332 RID: 58162 RVA: 0x000791EE File Offset: 0x000773EE
			public _LoadSpecialGuestExtraDialogData_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E333 RID: 58163 RVA: 0x000791F7 File Offset: 0x000773F7
			public _LoadSpecialGuestExtraDialogData_d__59() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay._LoadSpecialGuestExtraDialogData_d__59>.NativeClassPtr))
			{
			}

			// Token: 0x170049C6 RID: 18886
			// (get) Token: 0x0600E334 RID: 58164 RVA: 0x0036B8C8 File Offset: 0x00369AC8
			// (set) Token: 0x0600E335 RID: 58165 RVA: 0x00079209 File Offset: 0x00077409
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049C7 RID: 18887
			// (get) Token: 0x0600E336 RID: 58166 RVA: 0x0036B8F0 File Offset: 0x00369AF0
			// (set) Token: 0x0600E337 RID: 58167 RVA: 0x00079224 File Offset: 0x00077424
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049C8 RID: 18888
			// (get) Token: 0x0600E338 RID: 58168 RVA: 0x0036B920 File Offset: 0x00369B20
			// (set) Token: 0x0600E339 RID: 58169 RVA: 0x00079252 File Offset: 0x00077452
			public unsafe Il2CppReferenceArray<SpecialGuest> _allSpecialGuests_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr__allSpecialGuests_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr__allSpecialGuests_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049C9 RID: 18889
			// (get) Token: 0x0600E33A RID: 58170 RVA: 0x0036B950 File Offset: 0x00369B50
			// (set) Token: 0x0600E33B RID: 58171 RVA: 0x00079271 File Offset: 0x00077471
			public UniTask<Il2CppReferenceArray<IAssetHandle<SpecialGuestExtraDialogData>>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___u__1);
					return new UniTask<Il2CppReferenceArray<IAssetHandle<SpecialGuestExtraDialogData>>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandle<SpecialGuestExtraDialogData>>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._LoadSpecialGuestExtraDialogData_d__59.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandle<SpecialGuestExtraDialogData>>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009140 RID: 37184
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009141 RID: 37185
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04009142 RID: 37186
			private static readonly IntPtr NativeFieldInfoPtr__allSpecialGuests_5__2;

			// Token: 0x04009143 RID: 37187
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04009144 RID: 37188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009145 RID: 37189
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000C41 RID: 3137
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.DataBaseDay+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E33C RID: 58172 RVA: 0x0036B980 File Offset: 0x00369B80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr);
				DataBaseDay.__c__DisplayClass65_0.NativeFieldInfoPtr_izakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr, "izakayaId");
				DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr, 100680655);
				DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__0_Internal_Boolean_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr, 100680656);
				DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__1_Internal_Boolean_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr, 100680657);
				DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__2_Internal_Boolean_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr, 100680658);
			}

			// Token: 0x0600E33D RID: 58173 RVA: 0x0036BA10 File Offset: 0x00369C10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E33E RID: 58174 RVA: 0x0036BA4C File Offset: 0x00369C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211270, XrefRangeEnd = 211273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIzakayaLevel_b__0(DaySceneMapProfile.MapNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__0_Internal_Boolean_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E33F RID: 58175 RVA: 0x0036BAA0 File Offset: 0x00369CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211273, XrefRangeEnd = 211276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIzakayaLevel_b__1(DaySceneMapProfile.MapNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__1_Internal_Boolean_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E340 RID: 58176 RVA: 0x0036BAF4 File Offset: 0x00369CF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211276, XrefRangeEnd = 211279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIzakayaLevel_b__2(DaySceneMapProfile.MapNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass65_0.NativeMethodInfoPtr__GetIzakayaLevel_b__2_Internal_Boolean_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E341 RID: 58177 RVA: 0x0007929F File Offset: 0x0007749F
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049CA RID: 18890
			// (get) Token: 0x0600E342 RID: 58178 RVA: 0x0036BB48 File Offset: 0x00369D48
			// (set) Token: 0x0600E343 RID: 58179 RVA: 0x000792A8 File Offset: 0x000774A8
			public unsafe int izakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.__c__DisplayClass65_0.NativeFieldInfoPtr_izakayaId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.__c__DisplayClass65_0.NativeFieldInfoPtr_izakayaId)) = value;
				}
			}

			// Token: 0x04009146 RID: 37190
			private static readonly IntPtr NativeFieldInfoPtr_izakayaId;

			// Token: 0x04009147 RID: 37191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009148 RID: 37192
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayaLevel_b__0_Internal_Boolean_MapNode_0;

			// Token: 0x04009149 RID: 37193
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayaLevel_b__1_Internal_Boolean_MapNode_0;

			// Token: 0x0400914A RID: 37194
			private static readonly IntPtr NativeMethodInfoPtr__GetIzakayaLevel_b__2_Internal_Boolean_MapNode_0;
		}

		// Token: 0x02000C42 RID: 3138
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.DataBaseDay+<SpawnMapReferenceAsync>d__69")]
		public sealed class _SpawnMapReferenceAsync_d__69 : ValueType
		{
			// Token: 0x0600E344 RID: 58180 RVA: 0x0036BB70 File Offset: 0x00369D70
			// Note: this type is marked as 'beforefieldinit'.
			static _SpawnMapReferenceAsync_d__69()
			{
				Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<SpawnMapReferenceAsync>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr);
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<>1__state");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<>t__builder");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "mapLabel");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__allAdditiveObjects_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<allAdditiveObjects>5__2");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loadedAdditiveGameObjectTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<loadedAdditiveGameObjectTask>5__3");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loaded_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<loaded>5__4");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__spawnedMap_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<spawnedMap>5__5");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<>u__1");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, "<>u__2");
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, 100680659);
				DataBaseDay._SpawnMapReferenceAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr, 100680660);
			}

			// Token: 0x0600E345 RID: 58181 RVA: 0x0036BC78 File Offset: 0x00369E78
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 211408, RefRangeEnd = 211410, XrefRangeStart = 211279, XrefRangeEnd = 211408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E346 RID: 58182 RVA: 0x0036BCB0 File Offset: 0x00369EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211410, XrefRangeEnd = 211413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E347 RID: 58183 RVA: 0x000792C3 File Offset: 0x000774C3
			public _SpawnMapReferenceAsync_d__69(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E348 RID: 58184 RVA: 0x000792CC File Offset: 0x000774CC
			public _SpawnMapReferenceAsync_d__69() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay._SpawnMapReferenceAsync_d__69>.NativeClassPtr))
			{
			}

			// Token: 0x170049CB RID: 18891
			// (get) Token: 0x0600E349 RID: 58185 RVA: 0x0036BCF8 File Offset: 0x00369EF8
			// (set) Token: 0x0600E34A RID: 58186 RVA: 0x000792DE File Offset: 0x000774DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049CC RID: 18892
			// (get) Token: 0x0600E34B RID: 58187 RVA: 0x0036BD20 File Offset: 0x00369F20
			// (set) Token: 0x0600E34C RID: 58188 RVA: 0x000792F9 File Offset: 0x000774F9
			public AsyncUniTaskMethodBuilder<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049CD RID: 18893
			// (get) Token: 0x0600E34D RID: 58189 RVA: 0x0036BD50 File Offset: 0x00369F50
			// (set) Token: 0x0600E34E RID: 58190 RVA: 0x00079327 File Offset: 0x00077527
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170049CE RID: 18894
			// (get) Token: 0x0600E34F RID: 58191 RVA: 0x0036BD78 File Offset: 0x00369F78
			// (set) Token: 0x0600E350 RID: 58192 RVA: 0x00079346 File Offset: 0x00077546
			public unsafe Il2CppReferenceArray<ExpandableGameDataPack.MapAdditiveData> _allAdditiveObjects_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__allAdditiveObjects_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.MapAdditiveData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__allAdditiveObjects_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049CF RID: 18895
			// (get) Token: 0x0600E351 RID: 58193 RVA: 0x0036BDA8 File Offset: 0x00369FA8
			// (set) Token: 0x0600E352 RID: 58194 RVA: 0x00079365 File Offset: 0x00077565
			public unsafe List<UniTask<IGameObjectAssetHandle<Transform>>> _loadedAdditiveGameObjectTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loadedAdditiveGameObjectTask_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UniTask<IGameObjectAssetHandle<Transform>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loadedAdditiveGameObjectTask_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D0 RID: 18896
			// (get) Token: 0x0600E353 RID: 58195 RVA: 0x0036BDD8 File Offset: 0x00369FD8
			// (set) Token: 0x0600E354 RID: 58196 RVA: 0x00079384 File Offset: 0x00077584
			public unsafe IGameObjectAssetHandle<DaySceneMap> _loaded_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loaded_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<DaySceneMap>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__loaded_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D1 RID: 18897
			// (get) Token: 0x0600E355 RID: 58197 RVA: 0x0036BE08 File Offset: 0x0036A008
			// (set) Token: 0x0600E356 RID: 58198 RVA: 0x000793A3 File Offset: 0x000775A3
			public unsafe DaySceneMap _spawnedMap_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__spawnedMap_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr__spawnedMap_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D2 RID: 18898
			// (get) Token: 0x0600E357 RID: 58199 RVA: 0x0036BE38 File Offset: 0x0036A038
			// (set) Token: 0x0600E358 RID: 58200 RVA: 0x000793C2 File Offset: 0x000775C2
			public UniTask<IGameObjectAssetHandle<DaySceneMap>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__1);
					return new UniTask<IGameObjectAssetHandle<DaySceneMap>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DaySceneMap>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DaySceneMap>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049D3 RID: 18899
			// (get) Token: 0x0600E359 RID: 58201 RVA: 0x0036BE68 File Offset: 0x0036A068
			// (set) Token: 0x0600E35A RID: 58202 RVA: 0x000793F0 File Offset: 0x000775F0
			public UniTask<Il2CppReferenceArray<IGameObjectAssetHandle<Transform>>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__2);
					return new UniTask<Il2CppReferenceArray<IGameObjectAssetHandle<Transform>>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IGameObjectAssetHandle<Transform>>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay._SpawnMapReferenceAsync_d__69.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IGameObjectAssetHandle<Transform>>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400914B RID: 37195
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400914C RID: 37196
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400914D RID: 37197
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x0400914E RID: 37198
			private static readonly IntPtr NativeFieldInfoPtr__allAdditiveObjects_5__2;

			// Token: 0x0400914F RID: 37199
			private static readonly IntPtr NativeFieldInfoPtr__loadedAdditiveGameObjectTask_5__3;

			// Token: 0x04009150 RID: 37200
			private static readonly IntPtr NativeFieldInfoPtr__loaded_5__4;

			// Token: 0x04009151 RID: 37201
			private static readonly IntPtr NativeFieldInfoPtr__spawnedMap_5__5;

			// Token: 0x04009152 RID: 37202
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04009153 RID: 37203
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04009154 RID: 37204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009155 RID: 37205
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000C43 RID: 3139
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.DataBaseDay+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E35B RID: 58203 RVA: 0x0036BE98 File Offset: 0x0036A098
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseDay>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr);
				DataBaseDay.__c__DisplayClass70_0.NativeFieldInfoPtr_spawnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr, "spawnMarker");
				DataBaseDay.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr, 100680661);
				DataBaseDay.__c__DisplayClass70_0.NativeMethodInfoPtr__GetMapLabelFromSpawnMarker_b__0_Internal_Boolean_KeyValuePair_2_String_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr, 100680662);
			}

			// Token: 0x0600E35C RID: 58204 RVA: 0x0036BF00 File Offset: 0x0036A100
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseDay.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E35D RID: 58205 RVA: 0x0036BF3C File Offset: 0x0036A13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211413, XrefRangeEnd = 211418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetMapLabelFromSpawnMarker_b__0(KeyValuePair<string, HashSet<string>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseDay.__c__DisplayClass70_0.NativeMethodInfoPtr__GetMapLabelFromSpawnMarker_b__0_Internal_Boolean_KeyValuePair_2_String_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E35E RID: 58206 RVA: 0x0007941E File Offset: 0x0007761E
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049D4 RID: 18900
			// (get) Token: 0x0600E35F RID: 58207 RVA: 0x0036BF90 File Offset: 0x0036A190
			// (set) Token: 0x0600E360 RID: 58208 RVA: 0x00079427 File Offset: 0x00077627
			public unsafe string spawnMarker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.__c__DisplayClass70_0.NativeFieldInfoPtr_spawnMarker);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseDay.__c__DisplayClass70_0.NativeFieldInfoPtr_spawnMarker), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009156 RID: 37206
			private static readonly IntPtr NativeFieldInfoPtr_spawnMarker;

			// Token: 0x04009157 RID: 37207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009158 RID: 37208
			private static readonly IntPtr NativeMethodInfoPtr__GetMapLabelFromSpawnMarker_b__0_Internal_Boolean_KeyValuePair_2_String_HashSet_1_String_0;
		}
	}
}
