using System;
using Common;
using DayScene.Input;
using DayScene.UI;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x02000046 RID: 70
	public static class DaySceneDebugImpl : Il2CppSystem.Object
	{
		// Token: 0x06000875 RID: 2165 RVA: 0x000B865C File Offset: 0x000B685C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneDebugImpl()
		{
			Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "DaySceneDebugImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr);
			DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "GIVE_AMOUNT_MAX");
			DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "GIVE_AMOUNT_MIN");
			DaySceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664606);
			DaySceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664607);
			DaySceneDebugImpl.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664608);
			DaySceneDebugImpl.NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664609);
			DaySceneDebugImpl.NativeMethodInfoPtr_AddKizunaLevelExp_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664610);
			DaySceneDebugImpl.NativeMethodInfoPtr_UpgradeKizunaLevel_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664611);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetEntityActive_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664612);
			DaySceneDebugImpl.NativeMethodInfoPtr_ScheduleEvent_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664613);
			DaySceneDebugImpl.NativeMethodInfoPtr_ScheduleNews_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664614);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartMission_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664615);
			DaySceneDebugImpl.NativeMethodInfoPtr_FinishNode_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664616);
			DaySceneDebugImpl.NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664617);
			DaySceneDebugImpl.NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664618);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllClothes_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664619);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllRecords_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664620);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneCore_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664621);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneTrue_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664622);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC1_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664623);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664624);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC3_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664625);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC4_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664626);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC5_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664627);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneImpl_Private_Static_Void_StaffScenePlayBackIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664628);
			DaySceneDebugImpl.NativeMethodInfoPtr_HakureiMoneyBoxDonate_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664629);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllFishingTrophy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664630);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetPlayerColliderActive_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664631);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetTestResources_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664632);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetMaxResources_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664633);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetRandomResources_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664634);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetMoney_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664635);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllBadges_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664636);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAndUseAllDecorations_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664637);
			DaySceneDebugImpl.NativeMethodInfoPtr_AddReimuPossitiveSpellToWorkScene_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664638);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetSilverFrogCoin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664639);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetPlayerInputActive_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664640);
			DaySceneDebugImpl.NativeMethodInfoPtr_UnlockSpecialGuestsAndMaps_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664641);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartAllMissions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664642);
			DaySceneDebugImpl.NativeMethodInfoPtr_ResetCollectableCoolDown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664643);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllPartners_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664644);
			DaySceneDebugImpl.NativeMethodInfoPtr_FinishAllEventsAndMissions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664645);
			DaySceneDebugImpl.NativeMethodInfoPtr_RefreshCollectable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664646);
			DaySceneDebugImpl.NativeMethodInfoPtr_RefreshNPC_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664647);
			DaySceneDebugImpl.NativeMethodInfoPtr_GotoKourindou_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664648);
			DaySceneDebugImpl.NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664649);
			DaySceneDebugImpl.NativeMethodInfoPtr_FullUpgradeAllKizunaLevel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664650);
			DaySceneDebugImpl.NativeMethodInfoPtr_InviteProfiteerTewi_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664651);
			DaySceneDebugImpl.NativeMethodInfoPtr_UnlockAllMusicChapters_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664652);
			DaySceneDebugImpl.NativeMethodInfoPtr_NextDay_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664653);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetDays_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664654);
			DaySceneDebugImpl.NativeMethodInfoPtr_AddDays_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664655);
			DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664656);
			DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllBeverages_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664657);
			DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664658);
			DaySceneDebugImpl.NativeMethodInfoPtr_AddExp_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664659);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetMultiPartnerModeActive_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664660);
			DaySceneDebugImpl.NativeMethodInfoPtr_SetMaxPartnerCount_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664661);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeLv1_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664662);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeLv2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664663);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeFinal_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664664);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartWeirdCookingChallenge_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664665);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartHakureiFestivalMusicChallenge_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664666);
			DaySceneDebugImpl.NativeMethodInfoPtr_StartHakureiFestivalCookingChallenge_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664667);
			DaySceneDebugImpl.NativeMethodInfoPtr_Transmit_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664668);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllCharacterMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664669);
			DaySceneDebugImpl.NativeMethodInfoPtr_MoveToRogueLike_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664670);
			DaySceneDebugImpl.NativeMethodInfoPtr_OpenCreatorsBoxPanel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664671);
			DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel1_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664672);
			DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664673);
			DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel3_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664674);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllSpecialCharacterMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664675);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllMapMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664676);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllEventMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664677);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllMissionMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664678);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllEventAndMissionMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664679);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetAllNewsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664680);
			DaySceneDebugImpl.NativeMethodInfoPtr_GetResources_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664681);
			DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664682);
			DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664683);
			DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664684);
			DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664685);
			DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, 100664686);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000B8D08 File Offset: 0x000B6F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34994, RefRangeEnd = 34995, XrefRangeStart = 34984, XrefRangeEnd = 34994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000B8D30 File Offset: 0x000B6F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35005, RefRangeEnd = 35006, XrefRangeStart = 34995, XrefRangeEnd = 35005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000B8D58 File Offset: 0x000B6F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35007, RefRangeEnd = 35008, XrefRangeStart = 35006, XrefRangeEnd = 35007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveCharacter(string characterLabel, string mapLabel, Vector2 position, DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_CharacterRotation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000B8DBC File Offset: 0x000B6FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35009, RefRangeEnd = 35010, XrefRangeStart = 35008, XrefRangeEnd = 35009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReturnCharacter(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35014, RefRangeEnd = 35015, XrefRangeStart = 35010, XrefRangeEnd = 35014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddKizunaLevelExp(string characterLabel, int levelExp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref levelExp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_AddKizunaLevelExp_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000B8E38 File Offset: 0x000B7038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35019, RefRangeEnd = 35020, XrefRangeStart = 35015, XrefRangeEnd = 35019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpgradeKizunaLevel(string characterLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_UpgradeKizunaLevel_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000B8E70 File Offset: 0x000B7070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35021, RefRangeEnd = 35022, XrefRangeStart = 35020, XrefRangeEnd = 35021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEntityActive(string entityName, bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(entityName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetEntityActive_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000B8EB4 File Offset: 0x000B70B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35026, RefRangeEnd = 35027, XrefRangeStart = 35022, XrefRangeEnd = 35026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleEvent(string eventLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(eventLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ScheduleEvent_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000B8EEC File Offset: 0x000B70EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35031, RefRangeEnd = 35032, XrefRangeStart = 35027, XrefRangeEnd = 35031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleNews(string newsLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newsLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ScheduleNews_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000B8F24 File Offset: 0x000B7124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35036, RefRangeEnd = 35037, XrefRangeStart = 35032, XrefRangeEnd = 35036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartMission(string missionLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(missionLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartMission_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000B8F5C File Offset: 0x000B715C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35041, RefRangeEnd = 35043, XrefRangeStart = 35037, XrefRangeEnd = 35041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishNode(string nodeLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_FinishNode_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000B8F94 File Offset: 0x000B7194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35044, RefRangeEnd = 35045, XrefRangeStart = 35043, XrefRangeEnd = 35044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpHours(int hour)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000B8FC8 File Offset: 0x000B71C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35046, RefRangeEnd = 35047, XrefRangeStart = 35045, XrefRangeEnd = 35046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WarpActions(int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000B8FFC File Offset: 0x000B71FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35049, RefRangeEnd = 35050, XrefRangeStart = 35047, XrefRangeEnd = 35049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllClothes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllClothes_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000B9024 File Offset: 0x000B7224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35052, RefRangeEnd = 35053, XrefRangeStart = 35050, XrefRangeEnd = 35052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllRecords()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllRecords_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000B904C File Offset: 0x000B724C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35054, RefRangeEnd = 35055, XrefRangeStart = 35053, XrefRangeEnd = 35054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneCore()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneCore_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000B9074 File Offset: 0x000B7274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35056, RefRangeEnd = 35057, XrefRangeStart = 35055, XrefRangeEnd = 35056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneTrue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneTrue_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000B909C File Offset: 0x000B729C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35058, RefRangeEnd = 35059, XrefRangeStart = 35057, XrefRangeEnd = 35058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneDLC1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC1_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000B90C4 File Offset: 0x000B72C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35060, RefRangeEnd = 35061, XrefRangeStart = 35059, XrefRangeEnd = 35060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneDLC2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC2_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000B90EC File Offset: 0x000B72EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35062, RefRangeEnd = 35063, XrefRangeStart = 35061, XrefRangeEnd = 35062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneDLC3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC3_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000B9114 File Offset: 0x000B7314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35064, RefRangeEnd = 35065, XrefRangeStart = 35063, XrefRangeEnd = 35064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneDLC4()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC4_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000B913C File Offset: 0x000B733C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35066, RefRangeEnd = 35067, XrefRangeStart = 35065, XrefRangeEnd = 35066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneDLC5()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneDLC5_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000B9164 File Offset: 0x000B7364
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 35156, RefRangeEnd = 35163, XrefRangeStart = 35067, XrefRangeEnd = 35156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffSceneImpl(SceneDirector.StaffScenePlayBackIndicator scenePlayBackIndicator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scenePlayBackIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoStaffSceneImpl_Private_Static_Void_StaffScenePlayBackIndicator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000B9198 File Offset: 0x000B7398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35167, RefRangeEnd = 35168, XrefRangeStart = 35163, XrefRangeEnd = 35167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HakureiMoneyBoxDonate(int money)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref money;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_HakureiMoneyBoxDonate_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000B91CC File Offset: 0x000B73CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35188, RefRangeEnd = 35189, XrefRangeStart = 35168, XrefRangeEnd = 35188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllFishingTrophy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllFishingTrophy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000B91F4 File Offset: 0x000B73F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35194, RefRangeEnd = 35195, XrefRangeStart = 35189, XrefRangeEnd = 35194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerColliderActive(bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetPlayerColliderActive_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000B9228 File Offset: 0x000B7428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 35206, RefRangeEnd = 35210, XrefRangeStart = 35195, XrefRangeEnd = 35206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetTestResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetTestResources_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000B9250 File Offset: 0x000B7450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35211, RefRangeEnd = 35212, XrefRangeStart = 35210, XrefRangeEnd = 35211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMaxResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetMaxResources_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000B9278 File Offset: 0x000B7478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35220, RefRangeEnd = 35221, XrefRangeStart = 35212, XrefRangeEnd = 35220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRandomResources()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetRandomResources_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000B92A0 File Offset: 0x000B74A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35225, RefRangeEnd = 35227, XrefRangeStart = 35221, XrefRangeEnd = 35225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetMoney(int money)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref money;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetMoney_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000B92D4 File Offset: 0x000B74D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35229, RefRangeEnd = 35230, XrefRangeStart = 35227, XrefRangeEnd = 35229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllBadges()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllBadges_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000B92FC File Offset: 0x000B74FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35248, RefRangeEnd = 35249, XrefRangeStart = 35230, XrefRangeEnd = 35248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAndUseAllDecorations()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAndUseAllDecorations_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000B9324 File Offset: 0x000B7524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35253, RefRangeEnd = 35254, XrefRangeStart = 35249, XrefRangeEnd = 35253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddReimuPossitiveSpellToWorkScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_AddReimuPossitiveSpellToWorkScene_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000B934C File Offset: 0x000B754C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35258, RefRangeEnd = 35259, XrefRangeStart = 35254, XrefRangeEnd = 35258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSilverFrogCoin(int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetSilverFrogCoin_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000B9380 File Offset: 0x000B7580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35265, RefRangeEnd = 35267, XrefRangeStart = 35259, XrefRangeEnd = 35265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayerInputActive(bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetPlayerInputActive_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000B93B4 File Offset: 0x000B75B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35285, RefRangeEnd = 35286, XrefRangeStart = 35267, XrefRangeEnd = 35285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockSpecialGuestsAndMaps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_UnlockSpecialGuestsAndMaps_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000B93DC File Offset: 0x000B75DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35343, RefRangeEnd = 35344, XrefRangeStart = 35286, XrefRangeEnd = 35343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartAllMissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartAllMissions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000B9404 File Offset: 0x000B7604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35370, RefRangeEnd = 35371, XrefRangeStart = 35344, XrefRangeEnd = 35370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetCollectableCoolDown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ResetCollectableCoolDown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000B942C File Offset: 0x000B762C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35394, RefRangeEnd = 35395, XrefRangeStart = 35371, XrefRangeEnd = 35394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllPartners()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllPartners_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x000B9454 File Offset: 0x000B7654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35420, RefRangeEnd = 35421, XrefRangeStart = 35395, XrefRangeEnd = 35420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishAllEventsAndMissions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_FinishAllEventsAndMissions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000B947C File Offset: 0x000B767C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35427, RefRangeEnd = 35428, XrefRangeStart = 35421, XrefRangeEnd = 35427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshCollectable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_RefreshCollectable_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000B94A4 File Offset: 0x000B76A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35434, RefRangeEnd = 35435, XrefRangeStart = 35428, XrefRangeEnd = 35434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshNPC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_RefreshNPC_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000B94CC File Offset: 0x000B76CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35470, RefRangeEnd = 35471, XrefRangeStart = 35435, XrefRangeEnd = 35470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoKourindou()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GotoKourindou_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000B94F4 File Offset: 0x000B76F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35499, RefRangeEnd = 35500, XrefRangeStart = 35471, XrefRangeEnd = 35499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddToKourindoStaticMerchandise()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000B951C File Offset: 0x000B771C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35513, RefRangeEnd = 35514, XrefRangeStart = 35500, XrefRangeEnd = 35513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FullUpgradeAllKizunaLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_FullUpgradeAllKizunaLevel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000B9544 File Offset: 0x000B7744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35526, RefRangeEnd = 35527, XrefRangeStart = 35514, XrefRangeEnd = 35526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InviteProfiteerTewi()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_InviteProfiteerTewi_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000B956C File Offset: 0x000B776C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35554, RefRangeEnd = 35555, XrefRangeStart = 35527, XrefRangeEnd = 35554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockAllMusicChapters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_UnlockAllMusicChapters_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000B9594 File Offset: 0x000B7794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35559, RefRangeEnd = 35560, XrefRangeStart = 35555, XrefRangeEnd = 35559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NextDay()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_NextDay_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000B95BC File Offset: 0x000B77BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35569, RefRangeEnd = 35570, XrefRangeStart = 35560, XrefRangeEnd = 35569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDays(int day)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetDays_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000B95F0 File Offset: 0x000B77F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35579, RefRangeEnd = 35580, XrefRangeStart = 35570, XrefRangeEnd = 35579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddDays(int day)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_AddDays_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000B9624 File Offset: 0x000B7824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35581, RefRangeEnd = 35582, XrefRangeStart = 35580, XrefRangeEnd = 35581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000B964C File Offset: 0x000B784C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35583, RefRangeEnd = 35584, XrefRangeStart = 35582, XrefRangeEnd = 35583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllBeverages_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000B9674 File Offset: 0x000B7874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35585, RefRangeEnd = 35586, XrefRangeStart = 35584, XrefRangeEnd = 35585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000B969C File Offset: 0x000B789C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35590, RefRangeEnd = 35591, XrefRangeStart = 35586, XrefRangeEnd = 35590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddExp(int exp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref exp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_AddExp_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000B96D0 File Offset: 0x000B78D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35599, RefRangeEnd = 35600, XrefRangeStart = 35591, XrefRangeEnd = 35599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMultiPartnerModeActive(bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetMultiPartnerModeActive_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000B9704 File Offset: 0x000B7904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35608, RefRangeEnd = 35609, XrefRangeStart = 35600, XrefRangeEnd = 35608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaxPartnerCount(int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_SetMaxPartnerCount_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000B9738 File Offset: 0x000B7938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35613, RefRangeEnd = 35614, XrefRangeStart = 35609, XrefRangeEnd = 35613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartHakugyokurouChallengeLv1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeLv1_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000B9760 File Offset: 0x000B7960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35618, RefRangeEnd = 35619, XrefRangeStart = 35614, XrefRangeEnd = 35618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartHakugyokurouChallengeLv2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeLv2_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000B9788 File Offset: 0x000B7988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35625, RefRangeEnd = 35626, XrefRangeStart = 35619, XrefRangeEnd = 35625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartHakugyokurouChallengeFinal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartHakugyokurouChallengeFinal_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000B97B0 File Offset: 0x000B79B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35632, RefRangeEnd = 35633, XrefRangeStart = 35626, XrefRangeEnd = 35632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartWeirdCookingChallenge()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartWeirdCookingChallenge_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000B97D8 File Offset: 0x000B79D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35721, RefRangeEnd = 35722, XrefRangeStart = 35633, XrefRangeEnd = 35721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartHakureiFestivalMusicChallenge()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartHakureiFestivalMusicChallenge_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000B9800 File Offset: 0x000B7A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35722, XrefRangeEnd = 35823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartHakureiFestivalCookingChallenge()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_StartHakureiFestivalCookingChallenge_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000B9828 File Offset: 0x000B7A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35827, RefRangeEnd = 35829, XrefRangeStart = 35823, XrefRangeEnd = 35827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Transmit(string mapLabel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Transmit_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000B9860 File Offset: 0x000B7A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35829, XrefRangeEnd = 35863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllCharacterMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllCharacterMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000B9894 File Offset: 0x000B7A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35864, RefRangeEnd = 35865, XrefRangeStart = 35863, XrefRangeEnd = 35864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveToRogueLike()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_MoveToRogueLike_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000B98BC File Offset: 0x000B7ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35895, RefRangeEnd = 35896, XrefRangeStart = 35865, XrefRangeEnd = 35895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenCreatorsBoxPanel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_OpenCreatorsBoxPanel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000B98E4 File Offset: 0x000B7AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35898, RefRangeEnd = 35899, XrefRangeStart = 35896, XrefRangeEnd = 35898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenInfiniteSelectorPanel1()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel1_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000B990C File Offset: 0x000B7B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35901, RefRangeEnd = 35902, XrefRangeStart = 35899, XrefRangeEnd = 35901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenInfiniteSelectorPanel2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel2_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000B9934 File Offset: 0x000B7B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35904, RefRangeEnd = 35905, XrefRangeStart = 35902, XrefRangeEnd = 35904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenInfiniteSelectorPanel3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_OpenInfiniteSelectorPanel3_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000B995C File Offset: 0x000B7B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35905, XrefRangeEnd = 35956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllSpecialCharacterMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllSpecialCharacterMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000B9990 File Offset: 0x000B7B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35956, XrefRangeEnd = 35990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllMapMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllMapMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000B99C4 File Offset: 0x000B7BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35990, XrefRangeEnd = 36041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllEventMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllEventMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000B99F8 File Offset: 0x000B7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36041, XrefRangeEnd = 36092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllMissionMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllMissionMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000B9A2C File Offset: 0x000B7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36092, XrefRangeEnd = 36143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllEventAndMissionMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllEventAndMissionMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x000B9A60 File Offset: 0x000B7C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36143, XrefRangeEnd = 36177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Il2CppSystem.Object> GetAllNewsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetAllNewsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr3) : null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000B9A94 File Offset: 0x000B7C94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36264, RefRangeEnd = 36267, XrefRangeStart = 36177, XrefRangeEnd = 36264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetResources(bool max = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_GetResources_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000B9AC8 File Offset: 0x000B7CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36267, XrefRangeEnd = 36277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0(Il2CppStructArray<int> selectedId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000B9B00 File Offset: 0x000B7D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36277, XrefRangeEnd = 36287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1(Il2CppStructArray<int> selectedId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000B9B38 File Offset: 0x000B7D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36287, XrefRangeEnd = 36319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000B9BB8 File Offset: 0x000B7DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36319, XrefRangeEnd = 36336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000B9C38 File Offset: 0x000B7E38
		[CallerCount(0)]
		public unsafe static void Method_Internal_Static_Void_Action_0(Action action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.NativeMethodInfoPtr_Method_Internal_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00007163 File Offset: 0x00005363
		public DaySceneDebugImpl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000B9C70 File Offset: 0x000B7E70
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0000716C File Offset: 0x0000536C
		public unsafe static int GIVE_AMOUNT_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX, (void*)(&value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000B9C8C File Offset: 0x000B7E8C
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000717A File Offset: 0x0000537A
		public unsafe static int GIVE_AMOUNT_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN, (void*)(&value));
			}
		}

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_GIVE_AMOUNT_MAX;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_GIVE_AMOUNT_MIN;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_String_String_Vector2_CharacterRotation_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_ReturnCharacter_Public_Static_Void_String_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_AddKizunaLevelExp_Public_Static_Void_String_Int32_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeKizunaLevel_Public_Static_Void_String_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr_SetEntityActive_Public_Static_Void_String_Boolean_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleEvent_Public_Static_Void_String_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNews_Public_Static_Void_String_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_StartMission_Public_Static_Void_String_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_FinishNode_Public_Static_Void_String_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_WarpHours_Public_Static_Void_Int32_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_WarpActions_Public_Static_Void_Int32_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_GetAllClothes_Public_Static_Void_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_GetAllRecords_Public_Static_Void_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneCore_Public_Static_Void_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneTrue_Public_Static_Void_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneDLC1_Public_Static_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneDLC2_Public_Static_Void_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneDLC3_Public_Static_Void_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneDLC4_Public_Static_Void_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneDLC5_Public_Static_Void_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneImpl_Private_Static_Void_StaffScenePlayBackIndicator_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_HakureiMoneyBoxDonate_Public_Static_Void_Int32_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFishingTrophy_Public_Static_Void_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerColliderActive_Public_Static_Void_Boolean_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_GetTestResources_Public_Static_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxResources_Public_Static_Void_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomResources_Public_Static_Void_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_GetMoney_Public_Static_Void_Int32_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBadges_Public_Static_Void_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_GetAndUseAllDecorations_Public_Static_Void_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_AddReimuPossitiveSpellToWorkScene_Public_Static_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_GetSilverFrogCoin_Public_Static_Void_Int32_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerInputActive_Public_Static_Void_Boolean_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_UnlockSpecialGuestsAndMaps_Public_Static_Void_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_StartAllMissions_Public_Static_Void_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_ResetCollectableCoolDown_Public_Static_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPartners_Public_Static_Void_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_FinishAllEventsAndMissions_Public_Static_Void_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCollectable_Public_Static_Void_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNPC_Public_Static_Void_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_GotoKourindou_Public_Static_Void_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_AddToKourindoStaticMerchandise_Public_Static_Void_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_FullUpgradeAllKizunaLevel_Public_Static_Void_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_InviteProfiteerTewi_Public_Static_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAllMusicChapters_Public_Static_Void_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_NextDay_Public_Static_Void_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_SetDays_Public_Static_Void_Int32_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_AddDays_Public_Static_Void_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllIngredients_Public_Static_Void_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBeverages_Public_Static_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllItems_Public_Static_Void_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_AddExp_Public_Static_Void_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiPartnerModeActive_Public_Static_Void_Boolean_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxPartnerCount_Public_Static_Void_Int32_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_StartHakugyokurouChallengeLv1_Public_Static_Void_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_StartHakugyokurouChallengeLv2_Public_Static_Void_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_StartHakugyokurouChallengeFinal_Public_Static_Void_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_StartWeirdCookingChallenge_Public_Static_Void_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_StartHakureiFestivalMusicChallenge_Public_Static_Void_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_StartHakureiFestivalCookingChallenge_Public_Static_Void_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_Transmit_Public_Static_Void_String_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCharacterMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRogueLike_Public_Static_Void_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_OpenCreatorsBoxPanel_Public_Static_Void_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_OpenInfiniteSelectorPanel1_Public_Static_Void_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_OpenInfiniteSelectorPanel2_Public_Static_Void_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_OpenInfiniteSelectorPanel3_Public_Static_Void_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSpecialCharacterMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMapMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_GetAllEventMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_GetAllMissionMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_GetAllEventAndMissionMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNewsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_GetResources_Private_Static_Void_Boolean_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Il2CppStructArray_1_Int32_PDM_1;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_1;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Action_0;

		// Token: 0x02000502 RID: 1282
		[ObfuscatedName("PrototypingManagers.DaySceneDebugImpl+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600836D RID: 33645 RVA: 0x0024F230 File Offset: 0x0024D430
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr);
				DaySceneDebugImpl.__c__DisplayClass24_0.NativeFieldInfoPtr_allLevel5Guests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr, "allLevel5Guests");
				DaySceneDebugImpl.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr, 100664687);
				DaySceneDebugImpl.__c__DisplayClass24_0.NativeMethodInfoPtr__GotoStaffSceneImpl_b__1_Internal_Boolean_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr, 100664688);
			}

			// Token: 0x0600836E RID: 33646 RVA: 0x0024F298 File Offset: 0x0024D498
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600836F RID: 33647 RVA: 0x0024F2D4 File Offset: 0x0024D4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34890, XrefRangeEnd = 34905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GotoStaffSceneImpl_b__1(MappedSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass24_0.NativeMethodInfoPtr__GotoStaffSceneImpl_b__1_Internal_Boolean_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008370 RID: 33648 RVA: 0x00046E80 File Offset: 0x00045080
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C30 RID: 11312
			// (get) Token: 0x06008371 RID: 33649 RVA: 0x0024F324 File Offset: 0x0024D524
			// (set) Token: 0x06008372 RID: 33650 RVA: 0x00046E89 File Offset: 0x00045089
			public unsafe IEnumerable<SpecialGuest> allLevel5Guests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass24_0.NativeFieldInfoPtr_allLevel5Guests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass24_0.NativeFieldInfoPtr_allLevel5Guests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400561A RID: 22042
			private static readonly IntPtr NativeFieldInfoPtr_allLevel5Guests;

			// Token: 0x0400561B RID: 22043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400561C RID: 22044
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffSceneImpl_b__1_Internal_Boolean_MappedSpecialGuest_0;
		}

		// Token: 0x02000503 RID: 1283
		[ObfuscatedName("PrototypingManagers.DaySceneDebugImpl+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Il2CppSystem.Object
		{
			// Token: 0x06008373 RID: 33651 RVA: 0x0024F354 File Offset: 0x0024D554
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr);
				DaySceneDebugImpl.__c__DisplayClass24_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr, "x");
				DaySceneDebugImpl.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr, 100664689);
				DaySceneDebugImpl.__c__DisplayClass24_1.NativeMethodInfoPtr__GotoStaffSceneImpl_b__4_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr, 100664690);
			}

			// Token: 0x06008374 RID: 33652 RVA: 0x0024F3BC File Offset: 0x0024D5BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008375 RID: 33653 RVA: 0x0024F3F8 File Offset: 0x0024D5F8
			[CallerCount(0)]
			public unsafe bool _GotoStaffSceneImpl_b__4(SpecialGuest y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass24_1.NativeMethodInfoPtr__GotoStaffSceneImpl_b__4_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008376 RID: 33654 RVA: 0x00046EA8 File Offset: 0x000450A8
			public __c__DisplayClass24_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C31 RID: 11313
			// (get) Token: 0x06008377 RID: 33655 RVA: 0x0024F448 File Offset: 0x0024D648
			// (set) Token: 0x06008378 RID: 33656 RVA: 0x00046EB1 File Offset: 0x000450B1
			public unsafe MappedSpecialGuest x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass24_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MappedSpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass24_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400561D RID: 22045
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400561E RID: 22046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400561F RID: 22047
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffSceneImpl_b__4_Internal_Boolean_SpecialGuest_0;
		}

		// Token: 0x02000504 RID: 1284
		[ObfuscatedName("PrototypingManagers.DaySceneDebugImpl+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008379 RID: 33657 RVA: 0x0024F478 File Offset: 0x0024D678
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr);
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__24_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__24_2");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__24_3");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__26_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__38_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__38_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__39_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__40_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__44_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__45_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__48_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__62_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__62_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__63_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__63_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__65_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__65_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__71_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__71_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__71_2");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__72_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__72_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__73_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__73_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__73_2");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__74_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__74_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__74_2");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__75_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__75_1");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__75_2");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__76_0");
				DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, "<>9__76_1");
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664692);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_0_Internal_SpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664693);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_2_Internal_String_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664694);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_3_Internal_String_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664695);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFishingTrophy_b__26_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664696);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartAllMissions_b__38_0_Internal_Boolean_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664697);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartAllMissions_b__38_1_Internal_String_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664698);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__ResetCollectableCoolDown_b__39_0_Internal_Void_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664699);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllPartners_b__40_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664700);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoKourindou_b__44_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664701);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__45_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664702);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__UnlockAllMusicChapters_b__48_0_Internal_String_MusicMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664703);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664704);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664705);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_0_Internal_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664706);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664707);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllCharacterMapping_b__65_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664708);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllCharacterMapping_b__65_1_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664709);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664710);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664711);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_2_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664712);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMapMapping_b__72_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664713);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMapMapping_b__72_1_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664714);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664715);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664716);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664717);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664718);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664719);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664720);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664721);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664722);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664723);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNewsMapping_b__76_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664724);
				DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNewsMapping_b__76_1_Internal_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr, 100664725);
			}

			// Token: 0x0600837A RID: 33658 RVA: 0x0024F9F4 File Offset: 0x0024DBF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600837B RID: 33659 RVA: 0x0024FA30 File Offset: 0x0024DC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34905, XrefRangeEnd = 34909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _GotoStaffSceneImpl_b__24_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_0_Internal_SpecialGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x0600837C RID: 33660 RVA: 0x0024FA7C File Offset: 0x0024DC7C
			[CallerCount(0)]
			public unsafe string _GotoStaffSceneImpl_b__24_2(MappedSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_2_Internal_String_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600837D RID: 33661 RVA: 0x0024FAC4 File Offset: 0x0024DCC4
			[CallerCount(0)]
			public unsafe string _GotoStaffSceneImpl_b__24_3(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_3_Internal_String_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600837E RID: 33662 RVA: 0x0024FB0C File Offset: 0x0024DD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34909, XrefRangeEnd = 34910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAllFishingTrophy_b__26_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFishingTrophy_b__26_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600837F RID: 33663 RVA: 0x0024FB4C File Offset: 0x0024DD4C
			[CallerCount(0)]
			public unsafe bool _StartAllMissions_b__38_0(SchedulerNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartAllMissions_b__38_0_Internal_Boolean_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008380 RID: 33664 RVA: 0x0024FB9C File Offset: 0x0024DD9C
			[CallerCount(0)]
			public unsafe string _StartAllMissions_b__38_1(SchedulerNode x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartAllMissions_b__38_1_Internal_String_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008381 RID: 33665 RVA: 0x0024FBE4 File Offset: 0x0024DDE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34910, XrefRangeEnd = 34912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ResetCollectableCoolDown_b__39_0(TrackedCollectable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__ResetCollectableCoolDown_b__39_0_Internal_Void_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008382 RID: 33666 RVA: 0x0024FC28 File Offset: 0x0024DE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34912, XrefRangeEnd = 34913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAllPartners_b__40_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllPartners_b__40_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008383 RID: 33667 RVA: 0x0024FC68 File Offset: 0x0024DE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34913, XrefRangeEnd = 34918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GotoKourindou_b__44_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GotoKourindou_b__44_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008384 RID: 33668 RVA: 0x0024FC9C File Offset: 0x0024DE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34918, XrefRangeEnd = 34923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddToKourindoStaticMerchandise_b__45_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__45_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008385 RID: 33669 RVA: 0x0024FCD0 File Offset: 0x0024DED0
			[CallerCount(0)]
			public unsafe string _UnlockAllMusicChapters_b__48_0(MusicGameMappingProfile.MusicMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__UnlockAllMusicChapters_b__48_0_Internal_String_MusicMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008386 RID: 33670 RVA: 0x0024FD20 File Offset: 0x0024DF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34923, XrefRangeEnd = 34933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _StartHakureiFestivalMusicChallenge_b__62_0(Il2CppSystem.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008387 RID: 33671 RVA: 0x0024FD68 File Offset: 0x0024DF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34933, XrefRangeEnd = 34939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartHakureiFestivalMusicChallenge_b__62_1(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008388 RID: 33672 RVA: 0x0024FDBC File Offset: 0x0024DFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34939, XrefRangeEnd = 34949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _StartHakureiFestivalCookingChallenge_b__63_0(Il2CppSystem.Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_0_Internal_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008389 RID: 33673 RVA: 0x0024FE04 File Offset: 0x0024E004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34949, XrefRangeEnd = 34955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartHakureiFestivalCookingChallenge_b__63_1(ValueTuple<IEnumerable<Il2CppSystem.Object>, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600838A RID: 33674 RVA: 0x0024FE58 File Offset: 0x0024E058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34955, XrefRangeEnd = 34961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllCharacterMapping_b__65_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllCharacterMapping_b__65_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600838B RID: 33675 RVA: 0x0024FEA0 File Offset: 0x0024E0A0
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllCharacterMapping_b__65_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllCharacterMapping_b__65_1_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x0600838C RID: 33676 RVA: 0x0024FEF0 File Offset: 0x0024E0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllSpecialCharacterMapping_b__71_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600838D RID: 33677 RVA: 0x0024FF40 File Offset: 0x0024E140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34961, XrefRangeEnd = 34967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllSpecialCharacterMapping_b__71_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600838E RID: 33678 RVA: 0x0024FF88 File Offset: 0x0024E188
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllSpecialCharacterMapping_b__71_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_2_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x0600838F RID: 33679 RVA: 0x0024FFD8 File Offset: 0x0024E1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34967, XrefRangeEnd = 34974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllMapMapping_b__72_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMapMapping_b__72_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008390 RID: 33680 RVA: 0x00250020 File Offset: 0x0024E220
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllMapMapping_b__72_1(string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMapMapping_b__72_1_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x06008391 RID: 33681 RVA: 0x00250070 File Offset: 0x0024E270
			[CallerCount(0)]
			public unsafe bool _GetAllEventMapping_b__73_0(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008392 RID: 33682 RVA: 0x002500C4 File Offset: 0x0024E2C4
			[CallerCount(0)]
			public unsafe string _GetAllEventMapping_b__73_1(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008393 RID: 33683 RVA: 0x00250114 File Offset: 0x0024E314
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllEventMapping_b__73_2(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventMapping_b__73_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x06008394 RID: 33684 RVA: 0x0025016C File Offset: 0x0024E36C
			[CallerCount(0)]
			public unsafe bool _GetAllMissionMapping_b__74_0(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008395 RID: 33685 RVA: 0x002501C0 File Offset: 0x0024E3C0
			[CallerCount(0)]
			public unsafe string _GetAllMissionMapping_b__74_1(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008396 RID: 33686 RVA: 0x00250210 File Offset: 0x0024E410
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllMissionMapping_b__74_2(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllMissionMapping_b__74_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x06008397 RID: 33687 RVA: 0x00250268 File Offset: 0x0024E468
			[CallerCount(0)]
			public unsafe bool _GetAllEventAndMissionMapping_b__75_0(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008398 RID: 33688 RVA: 0x002502BC File Offset: 0x0024E4BC
			[CallerCount(0)]
			public unsafe string _GetAllEventAndMissionMapping_b__75_1(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008399 RID: 33689 RVA: 0x0025030C File Offset: 0x0024E50C
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllEventAndMissionMapping_b__75_2(ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x0600839A RID: 33690 RVA: 0x00250364 File Offset: 0x0024E564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34974, XrefRangeEnd = 34975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllNewsMapping_b__76_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNewsMapping_b__76_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600839B RID: 33691 RVA: 0x002503AC File Offset: 0x0024E5AC
			[CallerCount(0)]
			public unsafe Il2CppSystem.Object _GetAllNewsMapping_b__76_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNewsMapping_b__76_1_Internal_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}

			// Token: 0x0600839C RID: 33692 RVA: 0x00046ED0 File Offset: 0x000450D0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C32 RID: 11314
			// (get) Token: 0x0600839D RID: 33693 RVA: 0x002503FC File Offset: 0x0024E5FC
			// (set) Token: 0x0600839E RID: 33694 RVA: 0x00046ED9 File Offset: 0x000450D9
			public unsafe static DaySceneDebugImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneDebugImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C33 RID: 11315
			// (get) Token: 0x0600839F RID: 33695 RVA: 0x00250424 File Offset: 0x0024E624
			// (set) Token: 0x060083A0 RID: 33696 RVA: 0x00046EEB File Offset: 0x000450EB
			public unsafe static Func<int, SpecialGuest> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C34 RID: 11316
			// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0025044C File Offset: 0x0024E64C
			// (set) Token: 0x060083A2 RID: 33698 RVA: 0x00046EFD File Offset: 0x000450FD
			public unsafe static Func<MappedSpecialGuest, string> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MappedSpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C35 RID: 11317
			// (get) Token: 0x060083A3 RID: 33699 RVA: 0x00250474 File Offset: 0x0024E674
			// (set) Token: 0x060083A4 RID: 33700 RVA: 0x00046F0F File Offset: 0x0004510F
			public unsafe static Func<SpecialGuest, string> __9__24_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__24_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C36 RID: 11318
			// (get) Token: 0x060083A5 RID: 33701 RVA: 0x0025049C File Offset: 0x0024E69C
			// (set) Token: 0x060083A6 RID: 33702 RVA: 0x00046F21 File Offset: 0x00045121
			public unsafe static Action<int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C37 RID: 11319
			// (get) Token: 0x060083A7 RID: 33703 RVA: 0x002504C4 File Offset: 0x0024E6C4
			// (set) Token: 0x060083A8 RID: 33704 RVA: 0x00046F33 File Offset: 0x00045133
			public unsafe static Func<SchedulerNode, bool> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C38 RID: 11320
			// (get) Token: 0x060083A9 RID: 33705 RVA: 0x002504EC File Offset: 0x0024E6EC
			// (set) Token: 0x060083AA RID: 33706 RVA: 0x00046F45 File Offset: 0x00045145
			public unsafe static Func<SchedulerNode, string> __9__38_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__38_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C39 RID: 11321
			// (get) Token: 0x060083AB RID: 33707 RVA: 0x00250514 File Offset: 0x0024E714
			// (set) Token: 0x060083AC RID: 33708 RVA: 0x00046F57 File Offset: 0x00045157
			public unsafe static Action<TrackedCollectable> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TrackedCollectable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3A RID: 11322
			// (get) Token: 0x060083AD RID: 33709 RVA: 0x0025053C File Offset: 0x0024E73C
			// (set) Token: 0x060083AE RID: 33710 RVA: 0x00046F69 File Offset: 0x00045169
			public unsafe static Action<int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3B RID: 11323
			// (get) Token: 0x060083AF RID: 33711 RVA: 0x00250564 File Offset: 0x0024E764
			// (set) Token: 0x060083B0 RID: 33712 RVA: 0x00046F7B File Offset: 0x0004517B
			public unsafe static Action __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3C RID: 11324
			// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0025058C File Offset: 0x0024E78C
			// (set) Token: 0x060083B2 RID: 33714 RVA: 0x00046F8D File Offset: 0x0004518D
			public unsafe static Action __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3D RID: 11325
			// (get) Token: 0x060083B3 RID: 33715 RVA: 0x002505B4 File Offset: 0x0024E7B4
			// (set) Token: 0x060083B4 RID: 33716 RVA: 0x00046F9F File Offset: 0x0004519F
			public unsafe static Func<MusicGameMappingProfile.MusicMapping, string> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameMappingProfile.MusicMapping, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3E RID: 11326
			// (get) Token: 0x060083B5 RID: 33717 RVA: 0x002505DC File Offset: 0x0024E7DC
			// (set) Token: 0x060083B6 RID: 33718 RVA: 0x00046FB1 File Offset: 0x000451B1
			public unsafe static Func<Il2CppSystem.Object, string> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C3F RID: 11327
			// (get) Token: 0x060083B7 RID: 33719 RVA: 0x00250604 File Offset: 0x0024E804
			// (set) Token: 0x060083B8 RID: 33720 RVA: 0x00046FC3 File Offset: 0x000451C3
			public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__62_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__62_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C40 RID: 11328
			// (get) Token: 0x060083B9 RID: 33721 RVA: 0x0025062C File Offset: 0x0024E82C
			// (set) Token: 0x060083BA RID: 33722 RVA: 0x00046FD5 File Offset: 0x000451D5
			public unsafe static Func<Il2CppSystem.Object, string> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppSystem.Object, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C41 RID: 11329
			// (get) Token: 0x060083BB RID: 33723 RVA: 0x00250654 File Offset: 0x0024E854
			// (set) Token: 0x060083BC RID: 33724 RVA: 0x00046FE7 File Offset: 0x000451E7
			public unsafe static Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool> __9__63_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<IEnumerable<Il2CppSystem.Object>, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__63_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C42 RID: 11330
			// (get) Token: 0x060083BD RID: 33725 RVA: 0x0025067C File Offset: 0x0024E87C
			// (set) Token: 0x060083BE RID: 33726 RVA: 0x00046FF9 File Offset: 0x000451F9
			public unsafe static Func<string, string> __9__65_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C43 RID: 11331
			// (get) Token: 0x060083BF RID: 33727 RVA: 0x002506A4 File Offset: 0x0024E8A4
			// (set) Token: 0x060083C0 RID: 33728 RVA: 0x0004700B File Offset: 0x0004520B
			public unsafe static Func<string, Il2CppSystem.Object> __9__65_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__65_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C44 RID: 11332
			// (get) Token: 0x060083C1 RID: 33729 RVA: 0x002506CC File Offset: 0x0024E8CC
			// (set) Token: 0x060083C2 RID: 33730 RVA: 0x0004701D File Offset: 0x0004521D
			public unsafe static Func<string, bool> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C45 RID: 11333
			// (get) Token: 0x060083C3 RID: 33731 RVA: 0x002506F4 File Offset: 0x0024E8F4
			// (set) Token: 0x060083C4 RID: 33732 RVA: 0x0004702F File Offset: 0x0004522F
			public unsafe static Func<string, string> __9__71_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C46 RID: 11334
			// (get) Token: 0x060083C5 RID: 33733 RVA: 0x0025071C File Offset: 0x0024E91C
			// (set) Token: 0x060083C6 RID: 33734 RVA: 0x00047041 File Offset: 0x00045241
			public unsafe static Func<string, Il2CppSystem.Object> __9__71_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__71_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C47 RID: 11335
			// (get) Token: 0x060083C7 RID: 33735 RVA: 0x00250744 File Offset: 0x0024E944
			// (set) Token: 0x060083C8 RID: 33736 RVA: 0x00047053 File Offset: 0x00045253
			public unsafe static Func<string, string> __9__72_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C48 RID: 11336
			// (get) Token: 0x060083C9 RID: 33737 RVA: 0x0025076C File Offset: 0x0024E96C
			// (set) Token: 0x060083CA RID: 33738 RVA: 0x00047065 File Offset: 0x00045265
			public unsafe static Func<string, Il2CppSystem.Object> __9__72_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__72_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C49 RID: 11337
			// (get) Token: 0x060083CB RID: 33739 RVA: 0x00250794 File Offset: 0x0024E994
			// (set) Token: 0x060083CC RID: 33740 RVA: 0x00047077 File Offset: 0x00045277
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool> __9__73_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4A RID: 11338
			// (get) Token: 0x060083CD RID: 33741 RVA: 0x002507BC File Offset: 0x0024E9BC
			// (set) Token: 0x060083CE RID: 33742 RVA: 0x00047089 File Offset: 0x00045289
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string> __9__73_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4B RID: 11339
			// (get) Token: 0x060083CF RID: 33743 RVA: 0x002507E4 File Offset: 0x0024E9E4
			// (set) Token: 0x060083D0 RID: 33744 RVA: 0x0004709B File Offset: 0x0004529B
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object> __9__73_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__73_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4C RID: 11340
			// (get) Token: 0x060083D1 RID: 33745 RVA: 0x0025080C File Offset: 0x0024EA0C
			// (set) Token: 0x060083D2 RID: 33746 RVA: 0x000470AD File Offset: 0x000452AD
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool> __9__74_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4D RID: 11341
			// (get) Token: 0x060083D3 RID: 33747 RVA: 0x00250834 File Offset: 0x0024EA34
			// (set) Token: 0x060083D4 RID: 33748 RVA: 0x000470BF File Offset: 0x000452BF
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string> __9__74_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4E RID: 11342
			// (get) Token: 0x060083D5 RID: 33749 RVA: 0x0025085C File Offset: 0x0024EA5C
			// (set) Token: 0x060083D6 RID: 33750 RVA: 0x000470D1 File Offset: 0x000452D1
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object> __9__74_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__74_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C4F RID: 11343
			// (get) Token: 0x060083D7 RID: 33751 RVA: 0x00250884 File Offset: 0x0024EA84
			// (set) Token: 0x060083D8 RID: 33752 RVA: 0x000470E3 File Offset: 0x000452E3
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool> __9__75_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C50 RID: 11344
			// (get) Token: 0x060083D9 RID: 33753 RVA: 0x002508AC File Offset: 0x0024EAAC
			// (set) Token: 0x060083DA RID: 33754 RVA: 0x000470F5 File Offset: 0x000452F5
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string> __9__75_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C51 RID: 11345
			// (get) Token: 0x060083DB RID: 33755 RVA: 0x002508D4 File Offset: 0x0024EAD4
			// (set) Token: 0x060083DC RID: 33756 RVA: 0x00047107 File Offset: 0x00045307
			public unsafe static Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object> __9__75_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__75_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C52 RID: 11346
			// (get) Token: 0x060083DD RID: 33757 RVA: 0x002508FC File Offset: 0x0024EAFC
			// (set) Token: 0x060083DE RID: 33758 RVA: 0x00047119 File Offset: 0x00045319
			public unsafe static Func<string, string> __9__76_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C53 RID: 11347
			// (get) Token: 0x060083DF RID: 33759 RVA: 0x00250924 File Offset: 0x0024EB24
			// (set) Token: 0x060083E0 RID: 33760 RVA: 0x0004712B File Offset: 0x0004532B
			public unsafe static Func<string, Il2CppSystem.Object> __9__76_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneDebugImpl.__c.NativeFieldInfoPtr___9__76_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005620 RID: 22048
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005621 RID: 22049
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04005622 RID: 22050
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x04005623 RID: 22051
			private static readonly IntPtr NativeFieldInfoPtr___9__24_3;

			// Token: 0x04005624 RID: 22052
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04005625 RID: 22053
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x04005626 RID: 22054
			private static readonly IntPtr NativeFieldInfoPtr___9__38_1;

			// Token: 0x04005627 RID: 22055
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04005628 RID: 22056
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04005629 RID: 22057
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x0400562A RID: 22058
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400562B RID: 22059
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x0400562C RID: 22060
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x0400562D RID: 22061
			private static readonly IntPtr NativeFieldInfoPtr___9__62_1;

			// Token: 0x0400562E RID: 22062
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x0400562F RID: 22063
			private static readonly IntPtr NativeFieldInfoPtr___9__63_1;

			// Token: 0x04005630 RID: 22064
			private static readonly IntPtr NativeFieldInfoPtr___9__65_0;

			// Token: 0x04005631 RID: 22065
			private static readonly IntPtr NativeFieldInfoPtr___9__65_1;

			// Token: 0x04005632 RID: 22066
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x04005633 RID: 22067
			private static readonly IntPtr NativeFieldInfoPtr___9__71_1;

			// Token: 0x04005634 RID: 22068
			private static readonly IntPtr NativeFieldInfoPtr___9__71_2;

			// Token: 0x04005635 RID: 22069
			private static readonly IntPtr NativeFieldInfoPtr___9__72_0;

			// Token: 0x04005636 RID: 22070
			private static readonly IntPtr NativeFieldInfoPtr___9__72_1;

			// Token: 0x04005637 RID: 22071
			private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x04005638 RID: 22072
			private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x04005639 RID: 22073
			private static readonly IntPtr NativeFieldInfoPtr___9__73_2;

			// Token: 0x0400563A RID: 22074
			private static readonly IntPtr NativeFieldInfoPtr___9__74_0;

			// Token: 0x0400563B RID: 22075
			private static readonly IntPtr NativeFieldInfoPtr___9__74_1;

			// Token: 0x0400563C RID: 22076
			private static readonly IntPtr NativeFieldInfoPtr___9__74_2;

			// Token: 0x0400563D RID: 22077
			private static readonly IntPtr NativeFieldInfoPtr___9__75_0;

			// Token: 0x0400563E RID: 22078
			private static readonly IntPtr NativeFieldInfoPtr___9__75_1;

			// Token: 0x0400563F RID: 22079
			private static readonly IntPtr NativeFieldInfoPtr___9__75_2;

			// Token: 0x04005640 RID: 22080
			private static readonly IntPtr NativeFieldInfoPtr___9__76_0;

			// Token: 0x04005641 RID: 22081
			private static readonly IntPtr NativeFieldInfoPtr___9__76_1;

			// Token: 0x04005642 RID: 22082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005643 RID: 22083
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_0_Internal_SpecialGuest_Int32_0;

			// Token: 0x04005644 RID: 22084
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_2_Internal_String_MappedSpecialGuest_0;

			// Token: 0x04005645 RID: 22085
			private static readonly IntPtr NativeMethodInfoPtr__GotoStaffSceneImpl_b__24_3_Internal_String_SpecialGuest_0;

			// Token: 0x04005646 RID: 22086
			private static readonly IntPtr NativeMethodInfoPtr__GetAllFishingTrophy_b__26_0_Internal_Void_Int32_0;

			// Token: 0x04005647 RID: 22087
			private static readonly IntPtr NativeMethodInfoPtr__StartAllMissions_b__38_0_Internal_Boolean_SchedulerNode_0;

			// Token: 0x04005648 RID: 22088
			private static readonly IntPtr NativeMethodInfoPtr__StartAllMissions_b__38_1_Internal_String_SchedulerNode_0;

			// Token: 0x04005649 RID: 22089
			private static readonly IntPtr NativeMethodInfoPtr__ResetCollectableCoolDown_b__39_0_Internal_Void_TrackedCollectable_0;

			// Token: 0x0400564A RID: 22090
			private static readonly IntPtr NativeMethodInfoPtr__GetAllPartners_b__40_0_Internal_Void_Int32_0;

			// Token: 0x0400564B RID: 22091
			private static readonly IntPtr NativeMethodInfoPtr__GotoKourindou_b__44_0_Internal_Void_0;

			// Token: 0x0400564C RID: 22092
			private static readonly IntPtr NativeMethodInfoPtr__AddToKourindoStaticMerchandise_b__45_0_Internal_Void_0;

			// Token: 0x0400564D RID: 22093
			private static readonly IntPtr NativeMethodInfoPtr__UnlockAllMusicChapters_b__48_0_Internal_String_MusicMapping_0;

			// Token: 0x0400564E RID: 22094
			private static readonly IntPtr NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_0_Internal_String_Object_0;

			// Token: 0x0400564F RID: 22095
			private static readonly IntPtr NativeMethodInfoPtr__StartHakureiFestivalMusicChallenge_b__62_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;

			// Token: 0x04005650 RID: 22096
			private static readonly IntPtr NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_0_Internal_String_Object_0;

			// Token: 0x04005651 RID: 22097
			private static readonly IntPtr NativeMethodInfoPtr__StartHakureiFestivalCookingChallenge_b__63_1_Internal_Boolean_ValueTuple_2_IEnumerable_1_Object_Boolean_0;

			// Token: 0x04005652 RID: 22098
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCharacterMapping_b__65_0_Internal_String_String_0;

			// Token: 0x04005653 RID: 22099
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCharacterMapping_b__65_1_Internal_Object_String_0;

			// Token: 0x04005654 RID: 22100
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_0_Internal_Boolean_String_0;

			// Token: 0x04005655 RID: 22101
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_1_Internal_String_String_0;

			// Token: 0x04005656 RID: 22102
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialCharacterMapping_b__71_2_Internal_Object_String_0;

			// Token: 0x04005657 RID: 22103
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMapMapping_b__72_0_Internal_String_String_0;

			// Token: 0x04005658 RID: 22104
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMapMapping_b__72_1_Internal_Object_String_0;

			// Token: 0x04005659 RID: 22105
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventMapping_b__73_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565A RID: 22106
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventMapping_b__73_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565B RID: 22107
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventMapping_b__73_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565C RID: 22108
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMissionMapping_b__74_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565D RID: 22109
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMissionMapping_b__74_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565E RID: 22110
			private static readonly IntPtr NativeMethodInfoPtr__GetAllMissionMapping_b__74_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x0400565F RID: 22111
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_0_Internal_Boolean_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x04005660 RID: 22112
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_1_Internal_String_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x04005661 RID: 22113
			private static readonly IntPtr NativeMethodInfoPtr__GetAllEventAndMissionMapping_b__75_2_Internal_Object_ValueTuple_4_NodeType_SchedulerType_String_String_0;

			// Token: 0x04005662 RID: 22114
			private static readonly IntPtr NativeMethodInfoPtr__GetAllNewsMapping_b__76_0_Internal_String_String_0;

			// Token: 0x04005663 RID: 22115
			private static readonly IntPtr NativeMethodInfoPtr__GetAllNewsMapping_b__76_1_Internal_Object_String_0;
		}

		// Token: 0x02000505 RID: 1285
		[ObfuscatedName("PrototypingManagers.DaySceneDebugImpl+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x060083E1 RID: 33761 RVA: 0x0025094C File Offset: 0x0024EB4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr);
				DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr, "baseInteractData");
				DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr, "opened");
				DaySceneDebugImpl.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr, 100664726);
				DaySceneDebugImpl.__c__DisplayClass67_0.NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr, 100664727);
			}

			// Token: 0x060083E2 RID: 33762 RVA: 0x002509C8 File Offset: 0x0024EBC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083E3 RID: 33763 RVA: 0x00250A04 File Offset: 0x0024EC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34975, XrefRangeEnd = 34982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenCreatorsBoxPanel_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass67_0.NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083E4 RID: 33764 RVA: 0x0004713D File Offset: 0x0004533D
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C54 RID: 11348
			// (get) Token: 0x060083E5 RID: 33765 RVA: 0x00250A38 File Offset: 0x0024EC38
			// (set) Token: 0x060083E6 RID: 33766 RVA: 0x00047146 File Offset: 0x00045346
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C55 RID: 11349
			// (get) Token: 0x060083E7 RID: 33767 RVA: 0x00250A68 File Offset: 0x0024EC68
			// (set) Token: 0x060083E8 RID: 33768 RVA: 0x00047165 File Offset: 0x00045365
			public unsafe bool opened
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_opened);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_0.NativeFieldInfoPtr_opened)) = value;
				}
			}

			// Token: 0x04005664 RID: 22116
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04005665 RID: 22117
			private static readonly IntPtr NativeFieldInfoPtr_opened;

			// Token: 0x04005666 RID: 22118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005667 RID: 22119
			private static readonly IntPtr NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__3_Internal_Void_0;
		}

		// Token: 0x02000506 RID: 1286
		[ObfuscatedName("PrototypingManagers.DaySceneDebugImpl+<>c__DisplayClass67_1")]
		public sealed class __c__DisplayClass67_1 : Il2CppSystem.Object
		{
			// Token: 0x060083E9 RID: 33769 RVA: 0x00250A90 File Offset: 0x0024EC90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_1()
			{
				Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneDebugImpl>.NativeClassPtr, "<>c__DisplayClass67_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr);
				DaySceneDebugImpl.__c__DisplayClass67_1.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr, "baseInteractData");
				DaySceneDebugImpl.__c__DisplayClass67_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr, 100664728);
				DaySceneDebugImpl.__c__DisplayClass67_1.NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr, 100664729);
			}

			// Token: 0x060083EA RID: 33770 RVA: 0x00250AF8 File Offset: 0x0024ECF8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneDebugImpl.__c__DisplayClass67_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass67_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083EB RID: 33771 RVA: 0x00250B34 File Offset: 0x0024ED34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34982, XrefRangeEnd = 34984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenCreatorsBoxPanel_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneDebugImpl.__c__DisplayClass67_1.NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060083EC RID: 33772 RVA: 0x00047180 File Offset: 0x00045380
			public __c__DisplayClass67_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C56 RID: 11350
			// (get) Token: 0x060083ED RID: 33773 RVA: 0x00250B68 File Offset: 0x0024ED68
			// (set) Token: 0x060083EE RID: 33774 RVA: 0x00047189 File Offset: 0x00045389
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_1.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneDebugImpl.__c__DisplayClass67_1.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005668 RID: 22120
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04005669 RID: 22121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400566A RID: 22122
			private static readonly IntPtr NativeMethodInfoPtr__OpenCreatorsBoxPanel_b__4_Internal_Void_0;
		}
	}
}
