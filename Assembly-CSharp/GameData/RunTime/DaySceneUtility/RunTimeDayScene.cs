using System;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility
{
	// Token: 0x02000222 RID: 546
	public static class RunTimeDayScene : Il2CppSystem.Object
	{
		// Token: 0x060040D5 RID: 16597 RVA: 0x0017C170 File Offset: 0x0017A370
		// Note: this type is marked as 'beforefieldinit'.
		static RunTimeDayScene()
		{
			Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.DaySceneUtility", "RunTimeDayScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr);
			RunTimeDayScene.NativeFieldInfoPtr_TOTAL_ACTIVE_HOUR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "TOTAL_ACTIVE_HOUR");
			RunTimeDayScene.NativeFieldInfoPtr_KOURINDOU_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "KOURINDOU_ID");
			RunTimeDayScene.NativeFieldInfoPtr_LAST_MUSIC_GAME_SPEED_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "LAST_MUSIC_GAME_SPEED_KEY");
			RunTimeDayScene.NativeFieldInfoPtr_trackedCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedCollectables");
			RunTimeDayScene.NativeFieldInfoPtr_trackedMerchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedMerchants");
			RunTimeDayScene.NativeFieldInfoPtr_trackedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedNPCs");
			RunTimeDayScene.NativeFieldInfoPtr_trackedInteradctables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedInteradctables");
			RunTimeDayScene.NativeFieldInfoPtr_trackedSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedSwitch");
			RunTimeDayScene.NativeFieldInfoPtr_trackedMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedMaps");
			RunTimeDayScene.NativeFieldInfoPtr_kourindouStaticMerchandiseNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "kourindouStaticMerchandiseNum");
			RunTimeDayScene.NativeFieldInfoPtr_trackedSpecialDayNPCInteractCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "trackedSpecialDayNPCInteractCount");
			RunTimeDayScene.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "musicgameMusicalsNoteSpeed");
			RunTimeDayScene.NativeFieldInfoPtr_flandreHomeFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "flandreHomeFurniture");
			RunTimeDayScene.NativeFieldInfoPtr_onDayOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "onDayOver");
			RunTimeDayScene.NativeFieldInfoPtr_OnTimePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "OnTimePass");
			RunTimeDayScene.NativeFieldInfoPtr_OnTimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "OnTimeSet");
			RunTimeDayScene.NativeFieldInfoPtr__RemainActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<RemainActions>k__BackingField");
			RunTimeDayScene.NativeFieldInfoPtr__OnRequireCurrentMapRefreshCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<OnRequireCurrentMapRefreshCallback>k__BackingField");
			RunTimeDayScene.NativeFieldInfoPtr__OnToggleTrackedSwitch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<OnToggleTrackedSwitch>k__BackingField");
			RunTimeDayScene.NativeMethodInfoPtr_get_RemainActions_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675504);
			RunTimeDayScene.NativeMethodInfoPtr_set_RemainActions_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675505);
			RunTimeDayScene.NativeMethodInfoPtr_get_OnRequireCurrentMapRefreshCallback_Public_Static_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675506);
			RunTimeDayScene.NativeMethodInfoPtr_set_OnRequireCurrentMapRefreshCallback_Public_Static_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675507);
			RunTimeDayScene.NativeMethodInfoPtr_get_OnToggleTrackedSwitch_Public_Static_get_Action_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675508);
			RunTimeDayScene.NativeMethodInfoPtr_set_OnToggleTrackedSwitch_Public_Static_set_Void_Action_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675509);
			RunTimeDayScene.NativeMethodInfoPtr_GetTrackedSwitch_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675510);
			RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedSwitch_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675511);
			RunTimeDayScene.NativeMethodInfoPtr_RefTrackedSwitchAvailability_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675512);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllCollectables_Public_Static_Il2CppReferenceArray_1_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675513);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllTrackedCollectablesData_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675514);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllTrackedNPCsData_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675515);
			RunTimeDayScene.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeDaySceneSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675516);
			RunTimeDayScene.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675517);
			RunTimeDayScene.NativeMethodInfoPtr_InitilizeTrackedNPC_Private_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675518);
			RunTimeDayScene.NativeMethodInfoPtr_SetupDay_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675519);
			RunTimeDayScene.NativeMethodInfoPtr_GetTotalActions_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675520);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllUnlockedMap_Public_Static_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675521);
			RunTimeDayScene.NativeMethodInfoPtr_UnlockMap_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675522);
			RunTimeDayScene.NativeMethodInfoPtr_GetMapOpenStatus_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675523);
			RunTimeDayScene.NativeMethodInfoPtr_TryRefreshMerchantData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675524);
			RunTimeDayScene.NativeMethodInfoPtr_GetTrackedCollectable_Private_Static_TrackedCollectable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675525);
			RunTimeDayScene.NativeMethodInfoPtr_HasCollectableUnlocked_Public_Static_Boolean_Collectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675526);
			RunTimeDayScene.NativeMethodInfoPtr_RefTrackedCollectableAvailability_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675527);
			RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedCollectable_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675528);
			RunTimeDayScene.NativeMethodInfoPtr_CollectTrackedCollectable_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675529);
			RunTimeDayScene.NativeMethodInfoPtr_UpdateTrackedCollectableCoolDown_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675530);
			RunTimeDayScene.NativeMethodInfoPtr_GetKourindoStaticMerchandises_Public_Static_Il2CppReferenceArray_1_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675531);
			RunTimeDayScene.NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675532);
			RunTimeDayScene.NativeMethodInfoPtr_RemoveFromKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675533);
			RunTimeDayScene.NativeMethodInfoPtr_TryDeductProductNum_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675534);
			RunTimeDayScene.NativeMethodInfoPtr_GetTrackedNPC_Private_Static_TrackedNPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675535);
			RunTimeDayScene.NativeMethodInfoPtr_RemoveNPC_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675536);
			RunTimeDayScene.NativeMethodInfoPtr_AddNPC_Private_Static_Void_TrackedNPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675537);
			RunTimeDayScene.NativeMethodInfoPtr_GetMapNPCs_Public_Static_Dictionary_2_String_TrackedNPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675538);
			RunTimeDayScene.NativeMethodInfoPtr_TryGetNpcOverridePositionAndRotation_Public_Static_Boolean_String_byref_Vector2_byref_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675539);
			RunTimeDayScene.NativeMethodInfoPtr_RefTrackedNPCAvailability_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675540);
			RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedNPC_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675541);
			RunTimeDayScene.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_Int32_byref_OverridePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675542);
			RunTimeDayScene.NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675543);
			RunTimeDayScene.NativeMethodInfoPtr_AddNPCDialog_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675544);
			RunTimeDayScene.NativeMethodInfoPtr_RemoveNPCDialog_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675545);
			RunTimeDayScene.NativeMethodInfoPtr_SetNPCDialog_Public_Static_Void_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675546);
			RunTimeDayScene.NativeMethodInfoPtr_IsNPCOverridePosition_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675547);
			RunTimeDayScene.NativeMethodInfoPtr_GetNPCToTargetDistance_Public_Static_Single_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675548);
			RunTimeDayScene.NativeMethodInfoPtr_HasChatData_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675549);
			RunTimeDayScene.NativeMethodInfoPtr_GetCharacterChatData_Public_Static_DialogPackage_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675550);
			RunTimeDayScene.NativeMethodInfoPtr_GetMerchantData_Public_Static_TrackedMerchant_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675551);
			RunTimeDayScene.NativeMethodInfoPtr_DoSell_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675552);
			RunTimeDayScene.NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675553);
			RunTimeDayScene.NativeMethodInfoPtr_EnableTrackedNPC_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675554);
			RunTimeDayScene.NativeMethodInfoPtr_GetTrackedInteractable_Private_Static_TrackedInteractable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675555);
			RunTimeDayScene.NativeMethodInfoPtr_RefTrackedInteractableAvailability_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675556);
			RunTimeDayScene.NativeMethodInfoPtr_SetTrackedInteractableAvailability_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675557);
			RunTimeDayScene.NativeMethodInfoPtr_RefTrackedInteractableTime_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675558);
			RunTimeDayScene.NativeMethodInfoPtr_SetTrackedInteractableTime_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675559);
			RunTimeDayScene.NativeMethodInfoPtr_OnTrackedInteractableActivate_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675560);
			RunTimeDayScene.NativeMethodInfoPtr_TryRefreshNPCs_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675561);
			RunTimeDayScene.NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675562);
			RunTimeDayScene.NativeMethodInfoPtr_WarpToNight_Public_Static_Void_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675563);
			RunTimeDayScene.NativeMethodInfoPtr_OnDayEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675564);
			RunTimeDayScene.NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675565);
			RunTimeDayScene.NativeMethodInfoPtr_WarpActionsAsync_Public_Static_Void_Int32_Func_1_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675566);
			RunTimeDayScene.NativeMethodInfoPtr_SetActions_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675567);
			RunTimeDayScene.NativeMethodInfoPtr_TryInvokeOnDayOverEvent_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675568);
			RunTimeDayScene.NativeMethodInfoPtr_OnTimePassInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675569);
			RunTimeDayScene.NativeMethodInfoPtr_GetTrackedCount_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675570);
			RunTimeDayScene.NativeMethodInfoPtr_SetTrackedCount_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675571);
			RunTimeDayScene.NativeMethodInfoPtr_TryGetMusicalNoteSpeed_Public_Static_Boolean_String_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675572);
			RunTimeDayScene.NativeMethodInfoPtr_GetNoteSpeed_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675573);
			RunTimeDayScene.NativeMethodInfoPtr_GetDefaultMusicGameSpeed_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675574);
			RunTimeDayScene.NativeMethodInfoPtr_SetDefaultMusicGameSpeed_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675575);
			RunTimeDayScene.NativeMethodInfoPtr_SetMusicalNoteSpeed_Public_Static_Void_String_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675576);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllRemainingFurnitures_Public_Static_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675577);
			RunTimeDayScene.NativeMethodInfoPtr_GetAllOccupiedFlandreFurnitureId_Public_Static_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675578);
			RunTimeDayScene.NativeMethodInfoPtr_GetFurniturePositions_Public_Static_List_1_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675579);
			RunTimeDayScene.NativeMethodInfoPtr_GetTargetPositionFurnitureId_Public_Static_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675580);
			RunTimeDayScene.NativeMethodInfoPtr_GetFurnitureCanUseNum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675581);
			RunTimeDayScene.NativeMethodInfoPtr_AddFurnitureNum_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675582);
			RunTimeDayScene.NativeMethodInfoPtr_RemoveFurnitureNum_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675583);
			RunTimeDayScene.NativeMethodInfoPtr_SetFurniturePosition_Public_Static_Void_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, 100675584);
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x0017C970 File Offset: 0x0017AB70
		// (set) Token: 0x060040D7 RID: 16599 RVA: 0x0017C9A0 File Offset: 0x0017ABA0
		public unsafe static int RemainActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159087, XrefRangeEnd = 159089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_get_RemainActions_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159089, XrefRangeEnd = 159091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_set_RemainActions_Private_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0017C9D4 File Offset: 0x0017ABD4
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x0017CA08 File Offset: 0x0017AC08
		public unsafe static Action OnRequireCurrentMapRefreshCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159091, XrefRangeEnd = 159093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_get_OnRequireCurrentMapRefreshCallback_Public_Static_get_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159093, XrefRangeEnd = 159097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_set_OnRequireCurrentMapRefreshCallback_Public_Static_set_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x0017CA40 File Offset: 0x0017AC40
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x0017CA74 File Offset: 0x0017AC74
		public unsafe static Action<string, bool> OnToggleTrackedSwitch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159097, XrefRangeEnd = 159099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_get_OnToggleTrackedSwitch_Public_Static_get_Action_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159099, XrefRangeEnd = 159103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_set_OnToggleTrackedSwitch_Public_Static_set_Void_Action_2_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x0017CAAC File Offset: 0x0017ACAC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 159109, RefRangeEnd = 159131, XrefRangeStart = 159103, XrefRangeEnd = 159109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTrackedSwitch(string key, bool onByDefault)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onByDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTrackedSwitch_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x0017CAFC File Offset: 0x0017ACFC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 159152, RefRangeEnd = 159165, XrefRangeStart = 159131, XrefRangeEnd = 159152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleTrackedSwitch(string key, bool isOpen)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedSwitch_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0017CB40 File Offset: 0x0017AD40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159171, RefRangeEnd = 159173, XrefRangeStart = 159165, XrefRangeEnd = 159171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RefTrackedSwitchAvailability(this string key, bool onByDefault)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onByDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RefTrackedSwitchAvailability_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x0017CB90 File Offset: 0x0017AD90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159182, RefRangeEnd = 159184, XrefRangeStart = 159173, XrefRangeEnd = 159182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TrackedCollectable> GetAllCollectables()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllCollectables_Public_Static_Il2CppReferenceArray_1_TrackedCollectable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedCollectable>>(intPtr3) : null;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x0017CBC4 File Offset: 0x0017ADC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159244, RefRangeEnd = 159246, XrefRangeStart = 159184, XrefRangeEnd = 159244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAllTrackedCollectablesData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllTrackedCollectablesData_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x0017CBF0 File Offset: 0x0017ADF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159270, RefRangeEnd = 159272, XrefRangeStart = 159246, XrefRangeEnd = 159270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAllTrackedNPCsData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllTrackedNPCsData_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x0017CC1C File Offset: 0x0017AE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159300, RefRangeEnd = 159301, XrefRangeStart = 159272, XrefRangeEnd = 159300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerSaveFile.RunTimeDaySceneSaveDataPartial GenerateSaveData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeDaySceneSaveDataPartial_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerSaveFile.RunTimeDaySceneSaveDataPartial(pointer);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x0017CC48 File Offset: 0x0017AE48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159528, RefRangeEnd = 159529, XrefRangeStart = 159301, XrefRangeEnd = 159528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(PlayerSaveFile.RunTimeDaySceneSaveDataPartial dataPartial, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataPartial));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dayScenePartialDLC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x0017CC98 File Offset: 0x0017AE98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159622, RefRangeEnd = 159623, XrefRangeStart = 159529, XrefRangeEnd = 159622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitilizeTrackedNPC(PlayerSaveFile.RunTimeDaySceneSaveDataPartial dataPartial, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataPartial));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dayScenePartialDLC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_InitilizeTrackedNPC_Private_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x0017CCE8 File Offset: 0x0017AEE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159649, RefRangeEnd = 159650, XrefRangeStart = 159623, XrefRangeEnd = 159649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupDay(Action onDayEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDayEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetupDay_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0017CD20 File Offset: 0x0017AF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159651, RefRangeEnd = 159652, XrefRangeStart = 159650, XrefRangeEnd = 159651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTotalActions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTotalActions_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x0017CD50 File Offset: 0x0017AF50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159710, RefRangeEnd = 159712, XrefRangeStart = 159652, XrefRangeEnd = 159710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetAllUnlockedMap()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllUnlockedMap_Public_Static_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x0017CD84 File Offset: 0x0017AF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159776, RefRangeEnd = 159777, XrefRangeStart = 159712, XrefRangeEnd = 159776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockMap(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_UnlockMap_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x0017CDBC File Offset: 0x0017AFBC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 159798, RefRangeEnd = 159815, XrefRangeStart = 159777, XrefRangeEnd = 159798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMapOpenStatus(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetMapOpenStatus_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0017CE00 File Offset: 0x0017B000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159821, RefRangeEnd = 159823, XrefRangeStart = 159815, XrefRangeEnd = 159821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRefreshMerchantData(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryRefreshMerchantData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0017CE38 File Offset: 0x0017B038
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 159838, RefRangeEnd = 159842, XrefRangeStart = 159823, XrefRangeEnd = 159838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrackedCollectable GetTrackedCollectable(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTrackedCollectable_Private_Static_TrackedCollectable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedCollectable>(intPtr3) : null;
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x0017CE7C File Offset: 0x0017B07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159843, RefRangeEnd = 159844, XrefRangeStart = 159842, XrefRangeEnd = 159843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasCollectableUnlocked(Collectable collectable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(collectable));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_HasCollectableUnlocked_Public_Static_Boolean_Collectable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x0017CEC4 File Offset: 0x0017B0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159851, RefRangeEnd = 159852, XrefRangeStart = 159844, XrefRangeEnd = 159851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RefTrackedCollectableAvailability(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RefTrackedCollectableAvailability_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x0017CF08 File Offset: 0x0017B108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159860, RefRangeEnd = 159861, XrefRangeStart = 159852, XrefRangeEnd = 159860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleTrackedCollectable(string key, bool shouldOn)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedCollectable_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x0017CF4C File Offset: 0x0017B14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159869, RefRangeEnd = 159870, XrefRangeStart = 159861, XrefRangeEnd = 159869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CollectTrackedCollectable(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_CollectTrackedCollectable_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x0017CF84 File Offset: 0x0017B184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159889, RefRangeEnd = 159890, XrefRangeStart = 159870, XrefRangeEnd = 159889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateTrackedCollectableCoolDown(int actions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_UpdateTrackedCollectableCoolDown_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x0017CFB8 File Offset: 0x0017B1B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159922, RefRangeEnd = 159924, XrefRangeStart = 159890, XrefRangeEnd = 159922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> GetKourindoStaticMerchandises()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetKourindoStaticMerchandises_Public_Static_Il2CppReferenceArray_1_KourindoStaticMerchandise_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>>(intPtr3) : null;
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x0017CFEC File Offset: 0x0017B1EC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 159981, RefRangeEnd = 159995, XrefRangeStart = 159924, XrefRangeEnd = 159981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddToKourindoStaticMerchandise(IEnumerable<string> data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x0017D024 File Offset: 0x0017B224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160063, RefRangeEnd = 160064, XrefRangeStart = 159995, XrefRangeEnd = 160063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFromKourindoStaticMerchandise(IEnumerable<string> data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RemoveFromKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x0017D05C File Offset: 0x0017B25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160068, RefRangeEnd = 160069, XrefRangeStart = 160064, XrefRangeEnd = 160068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryDeductProductNum(string label, int productNum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryDeductProductNum_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x0017D0A0 File Offset: 0x0017B2A0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 160116, RefRangeEnd = 160131, XrefRangeStart = 160069, XrefRangeEnd = 160116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrackedNPC GetTrackedNPC(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTrackedNPC_Private_Static_TrackedNPC_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedNPC>(intPtr3) : null;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x0017D0E4 File Offset: 0x0017B2E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160151, RefRangeEnd = 160154, XrefRangeStart = 160131, XrefRangeEnd = 160151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveNPC(string npcLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RemoveNPC_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x0017D11C File Offset: 0x0017B31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160154, XrefRangeEnd = 160159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNPC(TrackedNPC npc, string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_AddNPC_Private_Static_Void_TrackedNPC_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x0017D164 File Offset: 0x0017B364
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 160175, RefRangeEnd = 160189, XrefRangeStart = 160159, XrefRangeEnd = 160175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, TrackedNPC> GetMapNPCs(string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetMapNPCs_Public_Static_Dictionary_2_String_TrackedNPC_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedNPC>>(intPtr3) : null;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x0017D1A8 File Offset: 0x0017B3A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160192, RefRangeEnd = 160194, XrefRangeStart = 160189, XrefRangeEnd = 160192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetNpcOverridePositionAndRotation(string characterLabel, out Vector2 position, out DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryGetNpcOverridePositionAndRotation_Public_Static_Boolean_String_byref_Vector2_byref_CharacterRotation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0017D208 File Offset: 0x0017B408
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160199, RefRangeEnd = 160203, XrefRangeStart = 160194, XrefRangeEnd = 160199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RefTrackedNPCAvailability(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RefTrackedNPCAvailability_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0017D24C File Offset: 0x0017B44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160206, RefRangeEnd = 160207, XrefRangeStart = 160203, XrefRangeEnd = 160206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ToggleTrackedNPC(string key, bool shouldOn)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_ToggleTrackedNPC_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x0017D290 File Offset: 0x0017B490
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 160226, RefRangeEnd = 160241, XrefRangeStart = 160207, XrefRangeEnd = 160226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveCharacter(string characterLabel, string mapLabel, Vector2 position, int rotation, out TrackedNPC.OverridePosition oldNPCData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_Int32_byref_OverridePosition_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldNPCData = ((intPtr4 == 0) ? null : new TrackedNPC.OverridePosition(intPtr4));
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x0017D318 File Offset: 0x0017B518
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 160251, RefRangeEnd = 160263, XrefRangeStart = 160241, XrefRangeEnd = 160251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReturnCharacter(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x0017D350 File Offset: 0x0017B550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160283, RefRangeEnd = 160284, XrefRangeStart = 160263, XrefRangeEnd = 160283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNPCDialog(string characterLabel, string destinationLabel, string dialogPackage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_AddNPCDialog_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x0017D3AC File Offset: 0x0017B5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160287, RefRangeEnd = 160288, XrefRangeStart = 160284, XrefRangeEnd = 160287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveNPCDialog(string characterLabel, string destinationLabel, string dialogPackage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RemoveNPCDialog_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x0017D408 File Offset: 0x0017B608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160298, RefRangeEnd = 160300, XrefRangeStart = 160288, XrefRangeEnd = 160298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetNPCDialog(string characterLabel, string destinationLabel, Il2CppStringArray dialogPackageIds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dialogPackageIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetNPCDialog_Public_Static_Void_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x0017D464 File Offset: 0x0017B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160300, XrefRangeEnd = 160301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNPCOverridePosition(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_IsNPCOverridePosition_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0017D4A8 File Offset: 0x0017B6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160307, RefRangeEnd = 160308, XrefRangeStart = 160301, XrefRangeEnd = 160307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNPCToTargetDistance(string characterLabel, Vector2 targetPosition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetNPCToTargetDistance_Public_Static_Single_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0017D4F8 File Offset: 0x0017B6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160319, RefRangeEnd = 160321, XrefRangeStart = 160308, XrefRangeEnd = 160319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasChatData(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_HasChatData_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0017D53C File Offset: 0x0017B73C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160354, RefRangeEnd = 160356, XrefRangeStart = 160321, XrefRangeEnd = 160354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DialogPackage GetCharacterChatData(string characterKey, bool isPostChat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPostChat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetCharacterChatData_Public_Static_DialogPackage_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr3) : null;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x0017D590 File Offset: 0x0017B790
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 160361, RefRangeEnd = 160367, XrefRangeStart = 160356, XrefRangeEnd = 160361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrackedMerchant GetMerchantData(string characterKey)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetMerchantData_Public_Static_TrackedMerchant_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr3) : null;
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x0017D5D4 File Offset: 0x0017B7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160375, RefRangeEnd = 160376, XrefRangeStart = 160367, XrefRangeEnd = 160375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoSell(string characterKey)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_DoSell_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x0017D618 File Offset: 0x0017B818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160376, XrefRangeEnd = 160382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMerchant(string characterKey)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x0017D65C File Offset: 0x0017B85C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160386, RefRangeEnd = 160388, XrefRangeStart = 160382, XrefRangeEnd = 160386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableTrackedNPC(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_EnableTrackedNPC_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x0017D694 File Offset: 0x0017B894
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 160402, RefRangeEnd = 160407, XrefRangeStart = 160388, XrefRangeEnd = 160402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrackedInteractable GetTrackedInteractable(string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTrackedInteractable_Private_Static_TrackedInteractable_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedInteractable>(intPtr3) : null;
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0017D6D8 File Offset: 0x0017B8D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 160408, RefRangeEnd = 160413, XrefRangeStart = 160407, XrefRangeEnd = 160408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RefTrackedInteractableAvailability(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RefTrackedInteractableAvailability_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x0017D71C File Offset: 0x0017B91C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 160421, RefRangeEnd = 160444, XrefRangeStart = 160413, XrefRangeEnd = 160421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTrackedInteractableAvailability(this string key, bool openStatus)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetTrackedInteractableAvailability_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x0017D760 File Offset: 0x0017B960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160445, RefRangeEnd = 160446, XrefRangeStart = 160444, XrefRangeEnd = 160445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RefTrackedInteractableTime(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RefTrackedInteractableTime_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x0017D7A4 File Offset: 0x0017B9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160447, RefRangeEnd = 160448, XrefRangeStart = 160446, XrefRangeEnd = 160447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTrackedInteractableTime(this string key, int trackedTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetTrackedInteractableTime_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x0017D7E8 File Offset: 0x0017B9E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160466, RefRangeEnd = 160467, XrefRangeStart = 160448, XrefRangeEnd = 160466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTrackedInteractableActivate(this string key)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_OnTrackedInteractableActivate_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x0017D820 File Offset: 0x0017BA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160467, XrefRangeEnd = 160469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryRefreshNPCs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryRefreshNPCs_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0017D848 File Offset: 0x0017BA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160471, RefRangeEnd = 160472, XrefRangeStart = 160469, XrefRangeEnd = 160471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpHours(int hours, Action<Action> onCustomEventFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCustomEventFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0017D88C File Offset: 0x0017BA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160475, RefRangeEnd = 160476, XrefRangeStart = 160472, XrefRangeEnd = 160475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpToNight(Action<Action> onCustomEventFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onCustomEventFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_WarpToNight_Public_Static_Void_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0017D8C4 File Offset: 0x0017BAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160503, RefRangeEnd = 160504, XrefRangeStart = 160476, XrefRangeEnd = 160503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDayEnd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_OnDayEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0017D8EC File Offset: 0x0017BAEC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 160558, RefRangeEnd = 160573, XrefRangeStart = 160504, XrefRangeEnd = 160558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpActions(int actions, Action<Action> onCustomEventFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCustomEventFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x0017D930 File Offset: 0x0017BB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160586, RefRangeEnd = 160587, XrefRangeStart = 160573, XrefRangeEnd = 160586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpActionsAsync(int actions, Func<UniTask> beforeDayEndEvent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beforeDayEndEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_WarpActionsAsync_Public_Static_Void_Int32_Func_1_UniTask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x0017D974 File Offset: 0x0017BB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160599, RefRangeEnd = 160601, XrefRangeStart = 160587, XrefRangeEnd = 160599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActions(int actions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetActions_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x0017D9A8 File Offset: 0x0017BBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160601, XrefRangeEnd = 160603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryInvokeOnDayOverEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryInvokeOnDayOverEvent_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160603, XrefRangeEnd = 160613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTimePassInternal(int actions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_OnTimePassInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x0017DA04 File Offset: 0x0017BC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160618, RefRangeEnd = 160620, XrefRangeStart = 160613, XrefRangeEnd = 160618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTrackedCount(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTrackedCount_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x0017DA48 File Offset: 0x0017BC48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160633, RefRangeEnd = 160635, XrefRangeStart = 160620, XrefRangeEnd = 160633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTrackedCount(string id, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetTrackedCount_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x0017DA8C File Offset: 0x0017BC8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160641, RefRangeEnd = 160643, XrefRangeStart = 160635, XrefRangeEnd = 160641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetMusicalNoteSpeed(string musicId, bool isEasy, out float musicalNoteSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEasy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &musicalNoteSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_TryGetMusicalNoteSpeed_Public_Static_Boolean_String_Boolean_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0017DAEC File Offset: 0x0017BCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160643, RefRangeEnd = 160644, XrefRangeStart = 160643, XrefRangeEnd = 160643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNoteSpeed(float progress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetNoteSpeed_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x0017DB2C File Offset: 0x0017BD2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160649, RefRangeEnd = 160650, XrefRangeStart = 160644, XrefRangeEnd = 160649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetDefaultMusicGameSpeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetDefaultMusicGameSpeed_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x0017DB5C File Offset: 0x0017BD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160653, RefRangeEnd = 160654, XrefRangeStart = 160650, XrefRangeEnd = 160653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultMusicGameSpeed(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetDefaultMusicGameSpeed_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x0017DB90 File Offset: 0x0017BD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160672, RefRangeEnd = 160673, XrefRangeStart = 160654, XrefRangeEnd = 160672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMusicalNoteSpeed(string musicId, bool isEasy, float musicalNoteSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(musicId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEasy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicalNoteSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetMusicalNoteSpeed_Public_Static_Void_String_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x0017DBE4 File Offset: 0x0017BDE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160701, RefRangeEnd = 160702, XrefRangeStart = 160673, XrefRangeEnd = 160701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<int> GetAllRemainingFurnitures()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllRemainingFurnitures_Public_Static_HashSet_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x0017DC18 File Offset: 0x0017BE18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160743, RefRangeEnd = 160746, XrefRangeStart = 160702, XrefRangeEnd = 160743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<int> GetAllOccupiedFlandreFurnitureId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetAllOccupiedFlandreFurnitureId_Public_Static_HashSet_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x0017DC4C File Offset: 0x0017BE4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160751, RefRangeEnd = 160754, XrefRangeStart = 160746, XrefRangeEnd = 160751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2Int> GetFurniturePositions(this int furnitureId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref furnitureId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetFurniturePositions_Public_Static_List_1_Vector2Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2Int>>(intPtr3) : null;
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x0017DC8C File Offset: 0x0017BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160754, XrefRangeEnd = 160770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTargetPositionFurnitureId(Vector2Int position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetTargetPositionFurnitureId_Public_Static_Int32_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x0017DCCC File Offset: 0x0017BECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160779, RefRangeEnd = 160781, XrefRangeStart = 160770, XrefRangeEnd = 160779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFurnitureCanUseNum(int furnitureId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref furnitureId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_GetFurnitureCanUseNum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x0017DD0C File Offset: 0x0017BF0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160796, RefRangeEnd = 160800, XrefRangeStart = 160781, XrefRangeEnd = 160796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddFurnitureNum(int furnitureId, int num)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref furnitureId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_AddFurnitureNum_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x0017DD4C File Offset: 0x0017BF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160812, RefRangeEnd = 160814, XrefRangeStart = 160800, XrefRangeEnd = 160812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveFurnitureNum(int furnitureId, int num)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref furnitureId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_RemoveFurnitureNum_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x0017DD8C File Offset: 0x0017BF8C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 160849, RefRangeEnd = 160860, XrefRangeStart = 160814, XrefRangeEnd = 160849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFurniturePosition(int furnitureId, Nullable<Vector2Int> oldPosition, Nullable<Vector2Int> position)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref furnitureId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(oldPosition));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(position));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.NativeMethodInfoPtr_SetFurniturePosition_Public_Static_Void_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x00023501 File Offset: 0x00021701
		public RunTimeDayScene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x0017DDEC File Offset: 0x0017BFEC
		// (set) Token: 0x06004129 RID: 16681 RVA: 0x0002350A File Offset: 0x0002170A
		public unsafe static int TOTAL_ACTIVE_HOUR
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_TOTAL_ACTIVE_HOUR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_TOTAL_ACTIVE_HOUR, (void*)(&value));
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x0017DE08 File Offset: 0x0017C008
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x00023518 File Offset: 0x00021718
		public unsafe static string KOURINDOU_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_KOURINDOU_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_KOURINDOU_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0017DE28 File Offset: 0x0017C028
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x0002352A File Offset: 0x0002172A
		public unsafe static string LAST_MUSIC_GAME_SPEED_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_LAST_MUSIC_GAME_SPEED_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_LAST_MUSIC_GAME_SPEED_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x0017DE48 File Offset: 0x0017C048
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x0002353C File Offset: 0x0002173C
		public unsafe static Dictionary<string, TrackedCollectable> trackedCollectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedCollectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedCollectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedCollectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x0017DE70 File Offset: 0x0017C070
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x0002354E File Offset: 0x0002174E
		public unsafe static Dictionary<string, TrackedMerchant> trackedMerchants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedMerchants, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedMerchant>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedMerchants, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x0017DE98 File Offset: 0x0017C098
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x00023560 File Offset: 0x00021760
		public unsafe static Dictionary<string, Dictionary<string, TrackedNPC>> trackedNPCs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedNPCs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, TrackedNPC>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedNPCs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x0017DEC0 File Offset: 0x0017C0C0
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x00023572 File Offset: 0x00021772
		public unsafe static Dictionary<string, TrackedInteractable> trackedInteradctables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedInteradctables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedInteractable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedInteradctables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x0017DEE8 File Offset: 0x0017C0E8
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00023584 File Offset: 0x00021784
		public unsafe static Dictionary<string, bool> trackedSwitch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedSwitch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedSwitch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x0017DF10 File Offset: 0x0017C110
		// (set) Token: 0x06004139 RID: 16697 RVA: 0x00023596 File Offset: 0x00021796
		public unsafe static Dictionary<string, bool> trackedMaps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedMaps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedMaps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x0017DF38 File Offset: 0x0017C138
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x000235A8 File Offset: 0x000217A8
		public unsafe static List<ValueTuple<string, int>> kourindouStaticMerchandiseNum
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_kourindouStaticMerchandiseNum, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_kourindouStaticMerchandiseNum, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x0017DF60 File Offset: 0x0017C160
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x000235BA File Offset: 0x000217BA
		public unsafe static Dictionary<string, int> trackedSpecialDayNPCInteractCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_trackedSpecialDayNPCInteractCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_trackedSpecialDayNPCInteractCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x0017DF88 File Offset: 0x0017C188
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x000235CC File Offset: 0x000217CC
		public unsafe static Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<float, float>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x0017DFB0 File Offset: 0x0017C1B0
		// (set) Token: 0x06004141 RID: 16705 RVA: 0x000235DE File Offset: 0x000217DE
		public unsafe static Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurniture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_flandreHomeFurniture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<int, List<Vector2Int>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_flandreHomeFurniture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x0017DFD8 File Offset: 0x0017C1D8
		// (set) Token: 0x06004143 RID: 16707 RVA: 0x000235F0 File Offset: 0x000217F0
		public unsafe static Action onDayOver
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_onDayOver, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_onDayOver, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x0017E000 File Offset: 0x0017C200
		// (set) Token: 0x06004145 RID: 16709 RVA: 0x00023602 File Offset: 0x00021802
		public unsafe static Action<int> OnTimePass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_OnTimePass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_OnTimePass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x0017E028 File Offset: 0x0017C228
		// (set) Token: 0x06004147 RID: 16711 RVA: 0x00023614 File Offset: 0x00021814
		public unsafe static Action<int> OnTimeSet
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr_OnTimeSet, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr_OnTimeSet, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x0017E050 File Offset: 0x0017C250
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00023626 File Offset: 0x00021826
		public unsafe static int _RemainActions_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr__RemainActions_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr__RemainActions_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x0017E06C File Offset: 0x0017C26C
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x00023634 File Offset: 0x00021834
		public unsafe static Action _OnRequireCurrentMapRefreshCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr__OnRequireCurrentMapRefreshCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr__OnRequireCurrentMapRefreshCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x0017E094 File Offset: 0x0017C294
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x00023646 File Offset: 0x00021846
		public unsafe static Action<string, bool> _OnToggleTrackedSwitch_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.NativeFieldInfoPtr__OnToggleTrackedSwitch_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.NativeFieldInfoPtr__OnToggleTrackedSwitch_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeFieldInfoPtr_TOTAL_ACTIVE_HOUR;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeFieldInfoPtr_KOURINDOU_ID;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeFieldInfoPtr_LAST_MUSIC_GAME_SPEED_KEY;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeFieldInfoPtr_trackedCollectables;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeFieldInfoPtr_trackedMerchants;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeFieldInfoPtr_trackedNPCs;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeFieldInfoPtr_trackedInteradctables;

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeFieldInfoPtr_trackedSwitch;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeFieldInfoPtr_trackedMaps;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeFieldInfoPtr_kourindouStaticMerchandiseNum;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeFieldInfoPtr_trackedSpecialDayNPCInteractCount;

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeFieldInfoPtr_musicgameMusicalsNoteSpeed;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeFieldInfoPtr_flandreHomeFurniture;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeFieldInfoPtr_onDayOver;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeFieldInfoPtr_OnTimePass;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeFieldInfoPtr_OnTimeSet;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeFieldInfoPtr__RemainActions_k__BackingField;

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeFieldInfoPtr__OnRequireCurrentMapRefreshCallback_k__BackingField;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeFieldInfoPtr__OnToggleTrackedSwitch_k__BackingField;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainActions_Public_Static_get_Int32_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainActions_Private_Static_set_Void_Int32_0;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_get_OnRequireCurrentMapRefreshCallback_Public_Static_get_Action_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_set_OnRequireCurrentMapRefreshCallback_Public_Static_set_Void_Action_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_get_OnToggleTrackedSwitch_Public_Static_get_Action_2_String_Boolean_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_set_OnToggleTrackedSwitch_Public_Static_set_Void_Action_2_String_Boolean_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedSwitch_Public_Static_Boolean_String_Boolean_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr_ToggleTrackedSwitch_Public_Static_Void_String_Boolean_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr_RefTrackedSwitchAvailability_Public_Static_Boolean_String_Boolean_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCollectables_Public_Static_Il2CppReferenceArray_1_TrackedCollectable_0;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTrackedCollectablesData_Public_Static_String_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTrackedNPCsData_Public_Static_String_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_Static_RunTimeDaySceneSaveDataPartial_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeMethodInfoPtr_InitilizeTrackedNPC_Private_Static_Void_RunTimeDaySceneSaveDataPartial_Dictionary_2_String_DLCDaySceneSaveData_0;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeMethodInfoPtr_SetupDay_Public_Static_Void_Action_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalActions_Public_Static_Int32_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUnlockedMap_Public_Static_List_1_String_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_UnlockMap_Public_Static_Void_String_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_GetMapOpenStatus_Public_Static_Boolean_String_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_TryRefreshMerchantData_Public_Static_Void_String_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedCollectable_Private_Static_TrackedCollectable_String_0;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeMethodInfoPtr_HasCollectableUnlocked_Public_Static_Boolean_Collectable_0;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeMethodInfoPtr_RefTrackedCollectableAvailability_Public_Static_Boolean_String_0;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeMethodInfoPtr_ToggleTrackedCollectable_Public_Static_Void_String_Boolean_0;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeMethodInfoPtr_CollectTrackedCollectable_Public_Static_Void_String_0;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrackedCollectableCoolDown_Public_Static_Void_Int32_0;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeMethodInfoPtr_GetKourindoStaticMerchandises_Public_Static_Il2CppReferenceArray_1_KourindoStaticMerchandise_0;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromKourindoStaticMerchandise_Public_Static_Void_IEnumerable_1_String_0;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeMethodInfoPtr_TryDeductProductNum_Public_Static_Void_String_Int32_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedNPC_Private_Static_TrackedNPC_String_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNPC_Private_Static_Void_String_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr_AddNPC_Private_Static_Void_TrackedNPC_String_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr_GetMapNPCs_Public_Static_Dictionary_2_String_TrackedNPC_String_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNpcOverridePositionAndRotation_Public_Static_Boolean_String_byref_Vector2_byref_CharacterRotation_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_RefTrackedNPCAvailability_Public_Static_Boolean_String_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_ToggleTrackedNPC_Public_Static_Void_String_Boolean_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_Int32_byref_OverridePosition_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_AddNPCDialog_Public_Static_Void_String_String_String_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNPCDialog_Public_Static_Void_String_String_String_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCDialog_Public_Static_Void_String_String_Il2CppStringArray_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCOverridePosition_Public_Static_Boolean_String_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCToTargetDistance_Public_Static_Single_String_Vector2_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_HasChatData_Public_Static_Boolean_String_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterChatData_Public_Static_DialogPackage_String_Boolean_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_GetMerchantData_Public_Static_TrackedMerchant_String_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_DoSell_Public_Static_Boolean_String_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_IsMerchant_Public_Static_Boolean_String_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeMethodInfoPtr_EnableTrackedNPC_Public_Static_Void_String_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedInteractable_Private_Static_TrackedInteractable_String_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_RefTrackedInteractableAvailability_Public_Static_Boolean_String_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackedInteractableAvailability_Public_Static_Void_String_Boolean_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_RefTrackedInteractableTime_Public_Static_Int32_String_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackedInteractableTime_Public_Static_Void_String_Int32_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_OnTrackedInteractableActivate_Public_Static_Void_String_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_TryRefreshNPCs_Private_Static_Void_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_Action_1_Action_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNight_Public_Static_Void_Action_1_Action_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_OnDayEnd_Public_Static_Void_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_Action_1_Action_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_WarpActionsAsync_Public_Static_Void_Int32_Func_1_UniTask_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_SetActions_Public_Static_Void_Int32_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeMethodInfoPtr_TryInvokeOnDayOverEvent_Private_Static_Void_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeMethodInfoPtr_OnTimePassInternal_Private_Static_Void_Int32_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedCount_Public_Static_Int32_String_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackedCount_Public_Static_Void_String_Int32_0;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMusicalNoteSpeed_Public_Static_Boolean_String_Boolean_byref_Single_0;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteSpeed_Public_Static_Single_Single_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultMusicGameSpeed_Public_Static_Single_0;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultMusicGameSpeed_Public_Static_Void_Single_0;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicalNoteSpeed_Public_Static_Void_String_Boolean_Single_0;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRemainingFurnitures_Public_Static_HashSet_1_Int32_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_GetAllOccupiedFlandreFurnitureId_Public_Static_HashSet_1_Int32_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_GetFurniturePositions_Public_Static_List_1_Vector2Int_Int32_0;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPositionFurnitureId_Public_Static_Int32_Vector2Int_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_GetFurnitureCanUseNum_Public_Static_Int32_Int32_0;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeMethodInfoPtr_AddFurnitureNum_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFurnitureNum_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeMethodInfoPtr_SetFurniturePosition_Public_Static_Void_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0;

		// Token: 0x020009EA RID: 2538
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C276 RID: 49782 RVA: 0x003075E8 File Offset: 0x003057E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr);
				RunTimeDayScene.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__32_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__32_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__33_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__33_2");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__33_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_8");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_2");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_9");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_3");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_4");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_5");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_6");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__35_7");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__39_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__39_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__39_2");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__40_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__50_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__82_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__82_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__83_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__83_1");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__96_0");
				RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, "<>9__96_1");
				RunTimeDayScene.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675586);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_0_Internal_String_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675587);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_1_Internal_String_TrackedInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675588);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_0_Internal_IEnumerable_1_String_KeyValuePair_2_String_Dictionary_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675589);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_1_Internal_Boolean_KeyValuePair_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675590);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_2_Internal_String_KeyValuePair_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675591);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_0_Internal_String_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675592);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_1_Internal_Dictionary_2_String_TrackedCollectable_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675593);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_8_Internal_String_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675594);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_2_Internal_String_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675595);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_3_Internal_Dictionary_2_String_TrackedMerchant_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675596);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_9_Internal_String_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675597);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_4_Internal_Dictionary_2_String_Boolean_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675598);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_5_Internal_IEnumerable_1_ValueTuple_2_String_Int32_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675599);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_6_Internal_IEnumerable_1_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675600);
				RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_7_Internal_String_TrackedInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675601);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_0_Internal_String_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675602);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675603);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_2_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675604);
				RunTimeDayScene.__c.NativeMethodInfoPtr__UnlockMap_b__40_1_Internal_Int32_levelUnlockRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675605);
				RunTimeDayScene.__c.NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__50_0_Internal_String_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675606);
				RunTimeDayScene.__c.NativeMethodInfoPtr__OnDayEnd_b__82_0_Internal_Void_Dictionary_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675607);
				RunTimeDayScene.__c.NativeMethodInfoPtr__OnDayEnd_b__82_1_Internal_Void_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675608);
				RunTimeDayScene.__c.NativeMethodInfoPtr__WarpActions_b__83_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675609);
				RunTimeDayScene.__c.NativeMethodInfoPtr__WarpActions_b__83_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675610);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675611);
				RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_1_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr, 100675612);
			}

			// Token: 0x0600C277 RID: 49783 RVA: 0x00307A4C File Offset: 0x00305C4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C278 RID: 49784 RVA: 0x00307A88 File Offset: 0x00305C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158770, XrefRangeEnd = 158803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllTrackedCollectablesData_b__32_0(TrackedCollectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_0_Internal_String_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C279 RID: 49785 RVA: 0x00307AD0 File Offset: 0x00305CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158803, XrefRangeEnd = 158809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllTrackedCollectablesData_b__32_1(TrackedInteractable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_1_Internal_String_TrackedInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C27A RID: 49786 RVA: 0x00307B18 File Offset: 0x00305D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158809, XrefRangeEnd = 158846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _GetAllTrackedNPCsData_b__33_0(KeyValuePair<string, Dictionary<string, TrackedNPC>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_0_Internal_IEnumerable_1_String_KeyValuePair_2_String_Dictionary_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x0600C27B RID: 49787 RVA: 0x00307B70 File Offset: 0x00305D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158846, XrefRangeEnd = 158848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTrackedNPCsData_b__33_1(KeyValuePair<string, TrackedNPC> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_1_Internal_Boolean_KeyValuePair_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C27C RID: 49788 RVA: 0x00307BC4 File Offset: 0x00305DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158848, XrefRangeEnd = 158853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllTrackedNPCsData_b__33_2(KeyValuePair<string, TrackedNPC> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_2_Internal_String_KeyValuePair_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C27D RID: 49789 RVA: 0x00307C14 File Offset: 0x00305E14
			[CallerCount(0)]
			public unsafe string _Initialize_b__35_0(TrackedCollectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_0_Internal_String_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C27E RID: 49790 RVA: 0x00307C5C File Offset: 0x00305E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158853, XrefRangeEnd = 158875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, TrackedCollectable> _Initialize_b__35_1(PlayerSaveFile.DLCDaySceneSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_1_Internal_Dictionary_2_String_TrackedCollectable_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedCollectable>>(intPtr3) : null;
			}

			// Token: 0x0600C27F RID: 49791 RVA: 0x00307CB4 File Offset: 0x00305EB4
			[CallerCount(0)]
			public unsafe string _Initialize_b__35_8(TrackedCollectable y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_8_Internal_String_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C280 RID: 49792 RVA: 0x00307CFC File Offset: 0x00305EFC
			[CallerCount(0)]
			public unsafe string _Initialize_b__35_2(TrackedMerchant x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_2_Internal_String_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C281 RID: 49793 RVA: 0x00307D44 File Offset: 0x00305F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158875, XrefRangeEnd = 158897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, TrackedMerchant> _Initialize_b__35_3(PlayerSaveFile.DLCDaySceneSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_3_Internal_Dictionary_2_String_TrackedMerchant_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedMerchant>>(intPtr3) : null;
			}

			// Token: 0x0600C282 RID: 49794 RVA: 0x00307D9C File Offset: 0x00305F9C
			[CallerCount(0)]
			public unsafe string _Initialize_b__35_9(TrackedMerchant y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_9_Internal_String_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C283 RID: 49795 RVA: 0x00307DE4 File Offset: 0x00305FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158897, XrefRangeEnd = 158903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<string, bool> _Initialize_b__35_4(PlayerSaveFile.DLCDaySceneSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_4_Internal_Dictionary_2_String_Boolean_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr3) : null;
			}

			// Token: 0x0600C284 RID: 49796 RVA: 0x00307E3C File Offset: 0x0030603C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158903, XrefRangeEnd = 158909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<string, int>> _Initialize_b__35_5(PlayerSaveFile.DLCDaySceneSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_5_Internal_IEnumerable_1_ValueTuple_2_String_Int32_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, int>>>(intPtr3) : null;
			}

			// Token: 0x0600C285 RID: 49797 RVA: 0x00307E94 File Offset: 0x00306094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158909, XrefRangeEnd = 158915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>> _Initialize_b__35_6(PlayerSaveFile.DLCDaySceneSaveData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_6_Internal_IEnumerable_1_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>>>(intPtr3) : null;
			}

			// Token: 0x0600C286 RID: 49798 RVA: 0x00307EEC File Offset: 0x003060EC
			[CallerCount(0)]
			public unsafe string _Initialize_b__35_7(TrackedInteractable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__Initialize_b__35_7_Internal_String_TrackedInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C287 RID: 49799 RVA: 0x00307F34 File Offset: 0x00306134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158915, XrefRangeEnd = 158916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllUnlockedMap_b__39_0(KeyValuePair<string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_0_Internal_String_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C288 RID: 49800 RVA: 0x00307F84 File Offset: 0x00306184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158916, XrefRangeEnd = 158922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllUnlockedMap_b__39_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C289 RID: 49801 RVA: 0x00307FD4 File Offset: 0x003061D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158922, XrefRangeEnd = 158928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllUnlockedMap_b__39_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllUnlockedMap_b__39_2_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C28A RID: 49802 RVA: 0x00308024 File Offset: 0x00306224
			[CallerCount(0)]
			public unsafe int _UnlockMap_b__40_1(DataBaseCore.LevelProperties.levelUnlockRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__UnlockMap_b__40_1_Internal_Int32_levelUnlockRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C28B RID: 49803 RVA: 0x00308078 File Offset: 0x00306278
			[CallerCount(0)]
			public unsafe string _AddToKourindoStaticMerchandise_b__50_0(ValueTuple<string, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__50_0_Internal_String_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C28C RID: 49804 RVA: 0x003080C8 File Offset: 0x003062C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158928, XrefRangeEnd = 158950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDayEnd_b__82_0(Dictionary<string, TrackedNPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__OnDayEnd_b__82_0_Internal_Void_Dictionary_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28D RID: 49805 RVA: 0x0030810C File Offset: 0x0030630C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158950, XrefRangeEnd = 158958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnDayEnd_b__82_1(TrackedNPC y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__OnDayEnd_b__82_1_Internal_Void_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28E RID: 49806 RVA: 0x00308150 File Offset: 0x00306350
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WarpActions_b__83_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__WarpActions_b__83_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C28F RID: 49807 RVA: 0x00308184 File Offset: 0x00306384
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WarpActions_b__83_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__WarpActions_b__83_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C290 RID: 49808 RVA: 0x003081B8 File Offset: 0x003063B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158958, XrefRangeEnd = 158960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllOccupiedFlandreFurnitureId_b__96_0(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C291 RID: 49809 RVA: 0x0030820C File Offset: 0x0030640C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158960, XrefRangeEnd = 158961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllOccupiedFlandreFurnitureId_b__96_1(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c.NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_1_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C292 RID: 49810 RVA: 0x00068E17 File Offset: 0x00067017
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4F RID: 16207
			// (get) Token: 0x0600C293 RID: 49811 RVA: 0x00308260 File Offset: 0x00306460
			// (set) Token: 0x0600C294 RID: 49812 RVA: 0x00068E20 File Offset: 0x00067020
			public unsafe static RunTimeDayScene.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunTimeDayScene.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F50 RID: 16208
			// (get) Token: 0x0600C295 RID: 49813 RVA: 0x00308288 File Offset: 0x00306488
			// (set) Token: 0x0600C296 RID: 49814 RVA: 0x00068E32 File Offset: 0x00067032
			public unsafe static Func<TrackedCollectable, string> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedCollectable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F51 RID: 16209
			// (get) Token: 0x0600C297 RID: 49815 RVA: 0x003082B0 File Offset: 0x003064B0
			// (set) Token: 0x0600C298 RID: 49816 RVA: 0x00068E44 File Offset: 0x00067044
			public unsafe static Func<TrackedInteractable, string> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedInteractable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F52 RID: 16210
			// (get) Token: 0x0600C299 RID: 49817 RVA: 0x003082D8 File Offset: 0x003064D8
			// (set) Token: 0x0600C29A RID: 49818 RVA: 0x00068E56 File Offset: 0x00067056
			public unsafe static Func<KeyValuePair<string, TrackedNPC>, bool> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, TrackedNPC>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F53 RID: 16211
			// (get) Token: 0x0600C29B RID: 49819 RVA: 0x00308300 File Offset: 0x00306500
			// (set) Token: 0x0600C29C RID: 49820 RVA: 0x00068E68 File Offset: 0x00067068
			public unsafe static Func<KeyValuePair<string, TrackedNPC>, string> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, TrackedNPC>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F54 RID: 16212
			// (get) Token: 0x0600C29D RID: 49821 RVA: 0x00308328 File Offset: 0x00306528
			// (set) Token: 0x0600C29E RID: 49822 RVA: 0x00068E7A File Offset: 0x0006707A
			public unsafe static Func<KeyValuePair<string, Dictionary<string, TrackedNPC>>, IEnumerable<string>> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Dictionary<string, TrackedNPC>>, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F55 RID: 16213
			// (get) Token: 0x0600C29F RID: 49823 RVA: 0x00308350 File Offset: 0x00306550
			// (set) Token: 0x0600C2A0 RID: 49824 RVA: 0x00068E8C File Offset: 0x0006708C
			public unsafe static Func<TrackedCollectable, string> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedCollectable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F56 RID: 16214
			// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x00308378 File Offset: 0x00306578
			// (set) Token: 0x0600C2A2 RID: 49826 RVA: 0x00068E9E File Offset: 0x0006709E
			public unsafe static Func<TrackedCollectable, string> __9__35_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedCollectable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F57 RID: 16215
			// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x003083A0 File Offset: 0x003065A0
			// (set) Token: 0x0600C2A4 RID: 49828 RVA: 0x00068EB0 File Offset: 0x000670B0
			public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, TrackedCollectable>> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, TrackedCollectable>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F58 RID: 16216
			// (get) Token: 0x0600C2A5 RID: 49829 RVA: 0x003083C8 File Offset: 0x003065C8
			// (set) Token: 0x0600C2A6 RID: 49830 RVA: 0x00068EC2 File Offset: 0x000670C2
			public unsafe static Func<TrackedMerchant, string> __9__35_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedMerchant, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F59 RID: 16217
			// (get) Token: 0x0600C2A7 RID: 49831 RVA: 0x003083F0 File Offset: 0x003065F0
			// (set) Token: 0x0600C2A8 RID: 49832 RVA: 0x00068ED4 File Offset: 0x000670D4
			public unsafe static Func<TrackedMerchant, string> __9__35_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedMerchant, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5A RID: 16218
			// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x00308418 File Offset: 0x00306618
			// (set) Token: 0x0600C2AA RID: 49834 RVA: 0x00068EE6 File Offset: 0x000670E6
			public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, TrackedMerchant>> __9__35_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, TrackedMerchant>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5B RID: 16219
			// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x00308440 File Offset: 0x00306640
			// (set) Token: 0x0600C2AC RID: 49836 RVA: 0x00068EF8 File Offset: 0x000670F8
			public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, bool>> __9__35_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData, Dictionary<string, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5C RID: 16220
			// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x00308468 File Offset: 0x00306668
			// (set) Token: 0x0600C2AE RID: 49838 RVA: 0x00068F0A File Offset: 0x0006710A
			public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData, IEnumerable<ValueTuple<string, int>>> __9__35_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData, IEnumerable<ValueTuple<string, int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5D RID: 16221
			// (get) Token: 0x0600C2AF RID: 49839 RVA: 0x00308490 File Offset: 0x00306690
			// (set) Token: 0x0600C2B0 RID: 49840 RVA: 0x00068F1C File Offset: 0x0006711C
			public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData, IEnumerable<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>>> __9__35_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData, IEnumerable<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5E RID: 16222
			// (get) Token: 0x0600C2B1 RID: 49841 RVA: 0x003084B8 File Offset: 0x003066B8
			// (set) Token: 0x0600C2B2 RID: 49842 RVA: 0x00068F2E File Offset: 0x0006712E
			public unsafe static Func<TrackedInteractable, string> __9__35_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedInteractable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__35_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F5F RID: 16223
			// (get) Token: 0x0600C2B3 RID: 49843 RVA: 0x003084E0 File Offset: 0x003066E0
			// (set) Token: 0x0600C2B4 RID: 49844 RVA: 0x00068F40 File Offset: 0x00067140
			public unsafe static Func<KeyValuePair<string, string>, string> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F60 RID: 16224
			// (get) Token: 0x0600C2B5 RID: 49845 RVA: 0x00308508 File Offset: 0x00306708
			// (set) Token: 0x0600C2B6 RID: 49846 RVA: 0x00068F52 File Offset: 0x00067152
			public unsafe static Func<string, bool> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F61 RID: 16225
			// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x00308530 File Offset: 0x00306730
			// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x00068F64 File Offset: 0x00067164
			public unsafe static Func<string, bool> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F62 RID: 16226
			// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x00308558 File Offset: 0x00306758
			// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x00068F76 File Offset: 0x00067176
			public unsafe static Func<DataBaseCore.LevelProperties.levelUnlockRecipe, int> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties.levelUnlockRecipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F63 RID: 16227
			// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x00308580 File Offset: 0x00306780
			// (set) Token: 0x0600C2BC RID: 49852 RVA: 0x00068F88 File Offset: 0x00067188
			public unsafe static Func<ValueTuple<string, int>, string> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F64 RID: 16228
			// (get) Token: 0x0600C2BD RID: 49853 RVA: 0x003085A8 File Offset: 0x003067A8
			// (set) Token: 0x0600C2BE RID: 49854 RVA: 0x00068F9A File Offset: 0x0006719A
			public unsafe static Action<TrackedNPC> __9__82_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrackedNPC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F65 RID: 16229
			// (get) Token: 0x0600C2BF RID: 49855 RVA: 0x003085D0 File Offset: 0x003067D0
			// (set) Token: 0x0600C2C0 RID: 49856 RVA: 0x00068FAC File Offset: 0x000671AC
			public unsafe static Action<Dictionary<string, TrackedNPC>> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<string, TrackedNPC>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F66 RID: 16230
			// (get) Token: 0x0600C2C1 RID: 49857 RVA: 0x003085F8 File Offset: 0x003067F8
			// (set) Token: 0x0600C2C2 RID: 49858 RVA: 0x00068FBE File Offset: 0x000671BE
			public unsafe static Action __9__83_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F67 RID: 16231
			// (get) Token: 0x0600C2C3 RID: 49859 RVA: 0x00308620 File Offset: 0x00306820
			// (set) Token: 0x0600C2C4 RID: 49860 RVA: 0x00068FD0 File Offset: 0x000671D0
			public unsafe static Action __9__83_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__83_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F68 RID: 16232
			// (get) Token: 0x0600C2C5 RID: 49861 RVA: 0x00308648 File Offset: 0x00306848
			// (set) Token: 0x0600C2C6 RID: 49862 RVA: 0x00068FE2 File Offset: 0x000671E2
			public unsafe static Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, bool> __9__96_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F69 RID: 16233
			// (get) Token: 0x0600C2C7 RID: 49863 RVA: 0x00308670 File Offset: 0x00306870
			// (set) Token: 0x0600C2C8 RID: 49864 RVA: 0x00068FF4 File Offset: 0x000671F4
			public unsafe static Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, int> __9__96_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunTimeDayScene.__c.NativeFieldInfoPtr___9__96_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D2C RID: 32044
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D2D RID: 32045
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04007D2E RID: 32046
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x04007D2F RID: 32047
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04007D30 RID: 32048
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x04007D31 RID: 32049
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04007D32 RID: 32050
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04007D33 RID: 32051
			private static readonly IntPtr NativeFieldInfoPtr___9__35_8;

			// Token: 0x04007D34 RID: 32052
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x04007D35 RID: 32053
			private static readonly IntPtr NativeFieldInfoPtr___9__35_2;

			// Token: 0x04007D36 RID: 32054
			private static readonly IntPtr NativeFieldInfoPtr___9__35_9;

			// Token: 0x04007D37 RID: 32055
			private static readonly IntPtr NativeFieldInfoPtr___9__35_3;

			// Token: 0x04007D38 RID: 32056
			private static readonly IntPtr NativeFieldInfoPtr___9__35_4;

			// Token: 0x04007D39 RID: 32057
			private static readonly IntPtr NativeFieldInfoPtr___9__35_5;

			// Token: 0x04007D3A RID: 32058
			private static readonly IntPtr NativeFieldInfoPtr___9__35_6;

			// Token: 0x04007D3B RID: 32059
			private static readonly IntPtr NativeFieldInfoPtr___9__35_7;

			// Token: 0x04007D3C RID: 32060
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04007D3D RID: 32061
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x04007D3E RID: 32062
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x04007D3F RID: 32063
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x04007D40 RID: 32064
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x04007D41 RID: 32065
			private static readonly IntPtr NativeFieldInfoPtr___9__82_1;

			// Token: 0x04007D42 RID: 32066
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x04007D43 RID: 32067
			private static readonly IntPtr NativeFieldInfoPtr___9__83_0;

			// Token: 0x04007D44 RID: 32068
			private static readonly IntPtr NativeFieldInfoPtr___9__83_1;

			// Token: 0x04007D45 RID: 32069
			private static readonly IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x04007D46 RID: 32070
			private static readonly IntPtr NativeFieldInfoPtr___9__96_1;

			// Token: 0x04007D47 RID: 32071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D48 RID: 32072
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_0_Internal_String_TrackedCollectable_0;

			// Token: 0x04007D49 RID: 32073
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrackedCollectablesData_b__32_1_Internal_String_TrackedInteractable_0;

			// Token: 0x04007D4A RID: 32074
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_0_Internal_IEnumerable_1_String_KeyValuePair_2_String_Dictionary_2_String_TrackedNPC_0;

			// Token: 0x04007D4B RID: 32075
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_1_Internal_Boolean_KeyValuePair_2_String_TrackedNPC_0;

			// Token: 0x04007D4C RID: 32076
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTrackedNPCsData_b__33_2_Internal_String_KeyValuePair_2_String_TrackedNPC_0;

			// Token: 0x04007D4D RID: 32077
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_0_Internal_String_TrackedCollectable_0;

			// Token: 0x04007D4E RID: 32078
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_1_Internal_Dictionary_2_String_TrackedCollectable_DLCDaySceneSaveData_0;

			// Token: 0x04007D4F RID: 32079
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_8_Internal_String_TrackedCollectable_0;

			// Token: 0x04007D50 RID: 32080
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_2_Internal_String_TrackedMerchant_0;

			// Token: 0x04007D51 RID: 32081
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_3_Internal_Dictionary_2_String_TrackedMerchant_DLCDaySceneSaveData_0;

			// Token: 0x04007D52 RID: 32082
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_9_Internal_String_TrackedMerchant_0;

			// Token: 0x04007D53 RID: 32083
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_4_Internal_Dictionary_2_String_Boolean_DLCDaySceneSaveData_0;

			// Token: 0x04007D54 RID: 32084
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_5_Internal_IEnumerable_1_ValueTuple_2_String_Int32_DLCDaySceneSaveData_0;

			// Token: 0x04007D55 RID: 32085
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_6_Internal_IEnumerable_1_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_DLCDaySceneSaveData_0;

			// Token: 0x04007D56 RID: 32086
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__35_7_Internal_String_TrackedInteractable_0;

			// Token: 0x04007D57 RID: 32087
			private static readonly IntPtr NativeMethodInfoPtr__GetAllUnlockedMap_b__39_0_Internal_String_KeyValuePair_2_String_String_0;

			// Token: 0x04007D58 RID: 32088
			private static readonly IntPtr NativeMethodInfoPtr__GetAllUnlockedMap_b__39_1_Internal_Boolean_String_0;

			// Token: 0x04007D59 RID: 32089
			private static readonly IntPtr NativeMethodInfoPtr__GetAllUnlockedMap_b__39_2_Internal_Boolean_String_0;

			// Token: 0x04007D5A RID: 32090
			private static readonly IntPtr NativeMethodInfoPtr__UnlockMap_b__40_1_Internal_Int32_levelUnlockRecipe_0;

			// Token: 0x04007D5B RID: 32091
			private static readonly IntPtr NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__50_0_Internal_String_ValueTuple_2_String_Int32_0;

			// Token: 0x04007D5C RID: 32092
			private static readonly IntPtr NativeMethodInfoPtr__OnDayEnd_b__82_0_Internal_Void_Dictionary_2_String_TrackedNPC_0;

			// Token: 0x04007D5D RID: 32093
			private static readonly IntPtr NativeMethodInfoPtr__OnDayEnd_b__82_1_Internal_Void_TrackedNPC_0;

			// Token: 0x04007D5E RID: 32094
			private static readonly IntPtr NativeMethodInfoPtr__WarpActions_b__83_0_Internal_Void_0;

			// Token: 0x04007D5F RID: 32095
			private static readonly IntPtr NativeMethodInfoPtr__WarpActions_b__83_1_Internal_Void_0;

			// Token: 0x04007D60 RID: 32096
			private static readonly IntPtr NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

			// Token: 0x04007D61 RID: 32097
			private static readonly IntPtr NativeMethodInfoPtr__GetAllOccupiedFlandreFurnitureId_b__96_1_Internal_Int32_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;
		}

		// Token: 0x020009EB RID: 2539
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2C9 RID: 49865 RVA: 0x00308698 File Offset: 0x00306898
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr, "key");
				RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr, "<>9__0");
				RunTimeDayScene.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr, 100675613);
				RunTimeDayScene.__c__DisplayClass40_0.NativeMethodInfoPtr__UnlockMap_b__0_Internal_Boolean_levelUnlockRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr, 100675614);
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x00308714 File Offset: 0x00306914
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x00308750 File Offset: 0x00306950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnlockMap_b__0(DataBaseCore.LevelProperties.levelUnlockRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass40_0.NativeMethodInfoPtr__UnlockMap_b__0_Internal_Boolean_levelUnlockRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2CC RID: 49868 RVA: 0x00069006 File Offset: 0x00067206
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6A RID: 16234
			// (get) Token: 0x0600C2CD RID: 49869 RVA: 0x003087A4 File Offset: 0x003069A4
			// (set) Token: 0x0600C2CE RID: 49870 RVA: 0x0006900F File Offset: 0x0006720F
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F6B RID: 16235
			// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x003087CC File Offset: 0x003069CC
			// (set) Token: 0x0600C2D0 RID: 49872 RVA: 0x0006902E File Offset: 0x0006722E
			public unsafe Func<DataBaseCore.LevelProperties.levelUnlockRecipe, bool> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataBaseCore.LevelProperties.levelUnlockRecipe, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass40_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D62 RID: 32098
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04007D63 RID: 32099
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04007D64 RID: 32100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D65 RID: 32101
			private static readonly IntPtr NativeMethodInfoPtr__UnlockMap_b__0_Internal_Boolean_levelUnlockRecipe_0;
		}

		// Token: 0x020009EC RID: 2540
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2D1 RID: 49873 RVA: 0x003087FC File Offset: 0x003069FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass48_0.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr, "actions");
				RunTimeDayScene.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr, 100675615);
				RunTimeDayScene.__c__DisplayClass48_0.NativeMethodInfoPtr__UpdateTrackedCollectableCoolDown_b__0_Internal_Void_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr, 100675616);
			}

			// Token: 0x0600C2D2 RID: 49874 RVA: 0x00308864 File Offset: 0x00306A64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D3 RID: 49875 RVA: 0x003088A0 File Offset: 0x00306AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158961, XrefRangeEnd = 158965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateTrackedCollectableCoolDown_b__0(TrackedCollectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass48_0.NativeMethodInfoPtr__UpdateTrackedCollectableCoolDown_b__0_Internal_Void_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D4 RID: 49876 RVA: 0x0006904D File Offset: 0x0006724D
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6C RID: 16236
			// (get) Token: 0x0600C2D5 RID: 49877 RVA: 0x003088E4 File Offset: 0x00306AE4
			// (set) Token: 0x0600C2D6 RID: 49878 RVA: 0x00069056 File Offset: 0x00067256
			public unsafe int actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass48_0.NativeFieldInfoPtr_actions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass48_0.NativeFieldInfoPtr_actions)) = value;
				}
			}

			// Token: 0x04007D66 RID: 32102
			private static readonly IntPtr NativeFieldInfoPtr_actions;

			// Token: 0x04007D67 RID: 32103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D68 RID: 32104
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTrackedCollectableCoolDown_b__0_Internal_Void_TrackedCollectable_0;
		}

		// Token: 0x020009ED RID: 2541
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2D7 RID: 49879 RVA: 0x0030890C File Offset: 0x00306B0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass51_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr, "item");
				RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr, 100675617);
				RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__0_Internal_Boolean_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr, 100675618);
				RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__1_Internal_Boolean_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr, 100675619);
			}

			// Token: 0x0600C2D8 RID: 49880 RVA: 0x00308988 File Offset: 0x00306B88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2D9 RID: 49881 RVA: 0x003089C4 File Offset: 0x00306BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158965, XrefRangeEnd = 158967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromKourindoStaticMerchandise_b__0(ValueTuple<string, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__0_Internal_Boolean_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2DA RID: 49882 RVA: 0x00308A18 File Offset: 0x00306C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFromKourindoStaticMerchandise_b__1(ValueTuple<string, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass51_0.NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__1_Internal_Boolean_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2DB RID: 49883 RVA: 0x00069071 File Offset: 0x00067271
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6D RID: 16237
			// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x00308A6C File Offset: 0x00306C6C
			// (set) Token: 0x0600C2DD RID: 49885 RVA: 0x0006907A File Offset: 0x0006727A
			public unsafe string item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass51_0.NativeFieldInfoPtr_item);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass51_0.NativeFieldInfoPtr_item), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007D69 RID: 32105
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04007D6A RID: 32106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D6B RID: 32107
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__0_Internal_Boolean_ValueTuple_2_String_Int32_0;

			// Token: 0x04007D6C RID: 32108
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFromKourindoStaticMerchandise_b__1_Internal_Boolean_ValueTuple_2_String_Int32_0;
		}

		// Token: 0x020009EE RID: 2542
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2DE RID: 49886 RVA: 0x00308A94 File Offset: 0x00306C94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr, "key");
				RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr, "tracked");
				RunTimeDayScene.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr, 100675620);
				RunTimeDayScene.__c__DisplayClass53_0.NativeMethodInfoPtr__GetTrackedNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr, 100675621);
			}

			// Token: 0x0600C2DF RID: 49887 RVA: 0x00308B10 File Offset: 0x00306D10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2E0 RID: 49888 RVA: 0x00308B4C File Offset: 0x00306D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158967, XrefRangeEnd = 158971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrackedNPC_b__0(Dictionary<string, TrackedNPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass53_0.NativeMethodInfoPtr__GetTrackedNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2E1 RID: 49889 RVA: 0x00069099 File Offset: 0x00067299
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6E RID: 16238
			// (get) Token: 0x0600C2E2 RID: 49890 RVA: 0x00308B9C File Offset: 0x00306D9C
			// (set) Token: 0x0600C2E3 RID: 49891 RVA: 0x000690A2 File Offset: 0x000672A2
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F6F RID: 16239
			// (get) Token: 0x0600C2E4 RID: 49892 RVA: 0x00308BC4 File Offset: 0x00306DC4
			// (set) Token: 0x0600C2E5 RID: 49893 RVA: 0x000690C1 File Offset: 0x000672C1
			public unsafe TrackedNPC tracked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_tracked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedNPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass53_0.NativeFieldInfoPtr_tracked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D6D RID: 32109
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04007D6E RID: 32110
			private static readonly IntPtr NativeFieldInfoPtr_tracked;

			// Token: 0x04007D6F RID: 32111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D70 RID: 32112
			private static readonly IntPtr NativeMethodInfoPtr__GetTrackedNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0;
		}

		// Token: 0x020009EF RID: 2543
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2E6 RID: 49894 RVA: 0x00308BF4 File Offset: 0x00306DF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass54_0.NativeFieldInfoPtr_npcLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr, "npcLabel");
				RunTimeDayScene.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr, 100675622);
				RunTimeDayScene.__c__DisplayClass54_0.NativeMethodInfoPtr__RemoveNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr, 100675623);
			}

			// Token: 0x0600C2E7 RID: 49895 RVA: 0x00308C5C File Offset: 0x00306E5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2E8 RID: 49896 RVA: 0x00308C98 File Offset: 0x00306E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158971, XrefRangeEnd = 158975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNPC_b__0(Dictionary<string, TrackedNPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass54_0.NativeMethodInfoPtr__RemoveNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2E9 RID: 49897 RVA: 0x000690E0 File Offset: 0x000672E0
			public __c__DisplayClass54_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F70 RID: 16240
			// (get) Token: 0x0600C2EA RID: 49898 RVA: 0x00308CE8 File Offset: 0x00306EE8
			// (set) Token: 0x0600C2EB RID: 49899 RVA: 0x000690E9 File Offset: 0x000672E9
			public unsafe string npcLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass54_0.NativeFieldInfoPtr_npcLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass54_0.NativeFieldInfoPtr_npcLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007D71 RID: 32113
			private static readonly IntPtr NativeFieldInfoPtr_npcLabel;

			// Token: 0x04007D72 RID: 32114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D73 RID: 32115
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNPC_b__0_Internal_Boolean_Dictionary_2_String_TrackedNPC_0;
		}

		// Token: 0x020009F0 RID: 2544
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2EC RID: 49900 RVA: 0x00308D10 File Offset: 0x00306F10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass84_0.NativeFieldInfoPtr_beforeDayEndEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr, "beforeDayEndEvent");
				RunTimeDayScene.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr, 100675624);
				RunTimeDayScene.__c__DisplayClass84_0.NativeMethodInfoPtr__WarpActionsAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr, 100675625);
			}

			// Token: 0x0600C2ED RID: 49901 RVA: 0x00308D78 File Offset: 0x00306F78
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2EE RID: 49902 RVA: 0x00308DB4 File Offset: 0x00306FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158975, XrefRangeEnd = 158983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WarpActionsAsync_b__0(Action onContinue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onContinue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass84_0.NativeMethodInfoPtr__WarpActionsAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2EF RID: 49903 RVA: 0x00069108 File Offset: 0x00067308
			public __c__DisplayClass84_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F71 RID: 16241
			// (get) Token: 0x0600C2F0 RID: 49904 RVA: 0x00308DF8 File Offset: 0x00306FF8
			// (set) Token: 0x0600C2F1 RID: 49905 RVA: 0x00069111 File Offset: 0x00067311
			public unsafe Func<UniTask> beforeDayEndEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass84_0.NativeFieldInfoPtr_beforeDayEndEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass84_0.NativeFieldInfoPtr_beforeDayEndEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D74 RID: 32116
			private static readonly IntPtr NativeFieldInfoPtr_beforeDayEndEvent;

			// Token: 0x04007D75 RID: 32117
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D76 RID: 32118
			private static readonly IntPtr NativeMethodInfoPtr__WarpActionsAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x020009F1 RID: 2545
		[ObfuscatedName("GameData.RunTime.DaySceneUtility.RunTimeDayScene+<>c__DisplayClass98_0")]
		public sealed class __c__DisplayClass98_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C2F2 RID: 49906 RVA: 0x00308E28 File Offset: 0x00307028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass98_0()
			{
				Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunTimeDayScene>.NativeClassPtr, "<>c__DisplayClass98_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr);
				RunTimeDayScene.__c__DisplayClass98_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr, "position");
				RunTimeDayScene.__c__DisplayClass98_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr, 100675626);
				RunTimeDayScene.__c__DisplayClass98_0.NativeMethodInfoPtr__GetTargetPositionFurnitureId_b__0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr, 100675627);
			}

			// Token: 0x0600C2F3 RID: 49907 RVA: 0x00308E90 File Offset: 0x00307090
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass98_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunTimeDayScene.__c__DisplayClass98_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass98_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C2F4 RID: 49908 RVA: 0x00308ECC File Offset: 0x003070CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158983, XrefRangeEnd = 159087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTargetPositionFurnitureId_b__0(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunTimeDayScene.__c__DisplayClass98_0.NativeMethodInfoPtr__GetTargetPositionFurnitureId_b__0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C2F5 RID: 49909 RVA: 0x00069130 File Offset: 0x00067330
			public __c__DisplayClass98_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F72 RID: 16242
			// (get) Token: 0x0600C2F6 RID: 49910 RVA: 0x00308F20 File Offset: 0x00307120
			// (set) Token: 0x0600C2F7 RID: 49911 RVA: 0x00069139 File Offset: 0x00067339
			public unsafe Vector2Int position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass98_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunTimeDayScene.__c__DisplayClass98_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x04007D77 RID: 32119
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04007D78 RID: 32120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D79 RID: 32121
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetPositionFurnitureId_b__0_Internal_Boolean_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;
		}
	}
}
