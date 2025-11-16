using System;
using Common.CharacterUtility;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using NightScene.UI;
using NightScene.UI.GuestManagementUtility;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001A8 RID: 424
	public class GuestsManager : MonoSingleton<GuestsManager>
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x0013D6D0 File Offset: 0x0013B8D0
		// Note: this type is marked as 'beforefieldinit'.
		static GuestsManager()
		{
			Il2CppClassPointerStore<GuestsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "GuestsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr);
			GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "GUEST_INITIAL_MOOD_MIN");
			GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "GUEST_INITIAL_MOOD_MAX");
			GuestsManager.NativeFieldInfoPtr_FIRSTORDER_DELAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "FIRSTORDER_DELAY_TIME");
			GuestsManager.NativeFieldInfoPtr_STATE_ICON_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "STATE_ICON_OFFSET");
			GuestsManager.NativeFieldInfoPtr_ON_GUEST_START_PROVIDE_PASSION_MOOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "ON_GUEST_START_PROVIDE_PASSION_MOOD");
			GuestsManager.NativeFieldInfoPtr_TOTAL_NORMAL_PASSION_GENERATE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "TOTAL_NORMAL_PASSION_GENERATE_AMOUNT");
			GuestsManager.NativeFieldInfoPtr_TOTAL_BAD_PASSION_GENERATE_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "TOTAL_BAD_PASSION_GENERATE_AMOUNT");
			GuestsManager.NativeFieldInfoPtr_ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT");
			GuestsManager.NativeFieldInfoPtr_DELAY_EVALUATE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "DELAY_EVALUATE_TIME");
			GuestsManager.NativeFieldInfoPtr_BAD_MOOD_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "BAD_MOOD_EXP");
			GuestsManager.NativeFieldInfoPtr_NORMAL_MOOD_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "NORMAL_MOOD_EXP");
			GuestsManager.NativeFieldInfoPtr_GOOD_MOOD_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "GOOD_MOOD_EXP");
			GuestsManager.NativeFieldInfoPtr_EXGOOD_MOOD_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "EXGOOD_MOOD_EXP");
			GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "MEDICINE_SPECIAL_FOOD_TAG");
			GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_MILK_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "MEDICINE_SPECIAL_MILK_TAG");
			GuestsManager.NativeFieldInfoPtr_evaulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "evaulate");
			GuestsManager.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "order");
			GuestsManager.NativeFieldInfoPtr_pay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "pay");
			GuestsManager.NativeFieldInfoPtr_timeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "timeEnd");
			GuestsManager.NativeFieldInfoPtr_uiContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "uiContainer");
			GuestsManager.NativeFieldInfoPtr_Await = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "Await");
			GuestsManager.NativeFieldInfoPtr_Eat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "Eat");
			GuestsManager.NativeFieldInfoPtr_serveInWorkMissionIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "serveInWorkMissionIcon");
			GuestsManager.NativeFieldInfoPtr_hateFoodTagIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "hateFoodTagIcon");
			GuestsManager.NativeFieldInfoPtr_hateFoodTagAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "hateFoodTagAudio");
			GuestsManager.NativeFieldInfoPtr_eatSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "eatSFX");
			GuestsManager.NativeFieldInfoPtr_glassSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "glassSFX");
			GuestsManager.NativeFieldInfoPtr_getPostprocessCharacterCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "getPostprocessCharacterCallback");
			GuestsManager.NativeFieldInfoPtr_currentDisplayedDialogBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "currentDisplayedDialogBox");
			GuestsManager.NativeFieldInfoPtr_allDesks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "allDesks");
			GuestsManager.NativeFieldInfoPtr_guestIconManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "guestIconManager");
			GuestsManager.NativeFieldInfoPtr_isIzakayaClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "isIzakayaClosing");
			GuestsManager.NativeFieldInfoPtr_largestDesk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "largestDesk");
			GuestsManager.NativeFieldInfoPtr_occupiedDesks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "occupiedDesks");
			GuestsManager.NativeFieldInfoPtr_onForcePannelClosingWhenGuestRepellCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "onForcePannelClosingWhenGuestRepellCallback");
			GuestsManager.NativeFieldInfoPtr_onOrderAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "onOrderAdd");
			GuestsManager.NativeFieldInfoPtr_onOrderRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "onOrderRemove");
			GuestsManager.NativeFieldInfoPtr_registeredCharacterArrivedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "registeredCharacterArrivedEvents");
			GuestsManager.NativeFieldInfoPtr_timed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "timed");
			GuestsManager.NativeFieldInfoPtr_AllPresentedGuestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "AllPresentedGuestGroupController");
			GuestsManager.NativeFieldInfoPtr_OnGuestSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "OnGuestSpawn");
			GuestsManager.NativeFieldInfoPtr__OnPositiveSpellTriggered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnPositiveSpellTriggered>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__OnPositiveSpellEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnPositiveSpellEnd>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__OnSpellEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnSpellEnd>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__OnIzakayaClosed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnIzakayaClosed>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__OnBussinessTimeEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnBussinessTimeEnd>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__canGuestBeRepelled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<canGuestBeRepelled>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__IsOpenThroughInteract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<IsOpenThroughInteract>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__LevelExtraGuestBaseMood_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<LevelExtraGuestBaseMood>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__LevelExtraGuestPatient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<LevelExtraGuestPatient>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__CanPlayerRepellGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<CanPlayerRepellGuest>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__AllGuestsControllersInDesk_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<AllGuestsControllersInDesk>k__BackingField");
			GuestsManager.NativeFieldInfoPtr__ManualDesksDic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<ManualDesksDic>k__BackingField");
			GuestsManager.NativeFieldInfoPtr_ForceDialogDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "ForceDialogDeskCode");
			GuestsManager.NativeFieldInfoPtr_TEWI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "TEWI_ID");
			GuestsManager.NativeFieldInfoPtr_TEWI_ID_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "TEWI_ID_2");
			GuestsManager.NativeFieldInfoPtr_REISEN2_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "REISEN2_ID");
			GuestsManager.NativeFieldInfoPtr_YOUKAI_RABBIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "YOUKAI_RABBIT");
			GuestsManager.NativeFieldInfoPtr_MOON_RABBIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "MOON_RABBIT");
			GuestsManager.NativeFieldInfoPtr_MOON_RABBIT_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "MOON_RABBIT_2");
			GuestsManager.NativeFieldInfoPtr_GUEST_BASE_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "GUEST_BASE_EXP");
			GuestsManager.NativeFieldInfoPtr_KisumeRepellCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "KisumeRepellCallback");
			GuestsManager.NativeMethodInfoPtr_add_OnGuestSpawn_Public_add_Void_Action_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671660);
			GuestsManager.NativeMethodInfoPtr_remove_OnGuestSpawn_Public_rem_Void_Action_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671661);
			GuestsManager.NativeMethodInfoPtr_get_OnPositiveSpellTriggered_Public_get_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671662);
			GuestsManager.NativeMethodInfoPtr_set_OnPositiveSpellTriggered_Public_set_Void_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671663);
			GuestsManager.NativeMethodInfoPtr_get_OnPositiveSpellEnd_Public_get_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671664);
			GuestsManager.NativeMethodInfoPtr_set_OnPositiveSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671665);
			GuestsManager.NativeMethodInfoPtr_get_OnSpellEnd_Public_get_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671666);
			GuestsManager.NativeMethodInfoPtr_set_OnSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671667);
			GuestsManager.NativeMethodInfoPtr_get_OnIzakayaClosed_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671668);
			GuestsManager.NativeMethodInfoPtr_set_OnIzakayaClosed_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671669);
			GuestsManager.NativeMethodInfoPtr_get_OnBussinessTimeEnd_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671670);
			GuestsManager.NativeMethodInfoPtr_set_OnBussinessTimeEnd_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671671);
			GuestsManager.NativeMethodInfoPtr_get_canGuestBeRepelled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671672);
			GuestsManager.NativeMethodInfoPtr_set_canGuestBeRepelled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671673);
			GuestsManager.NativeMethodInfoPtr_get_IsOpenThroughInteract_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671674);
			GuestsManager.NativeMethodInfoPtr_set_IsOpenThroughInteract_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671675);
			GuestsManager.NativeMethodInfoPtr_get_LevelExtraGuestBaseMood_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671676);
			GuestsManager.NativeMethodInfoPtr_set_LevelExtraGuestBaseMood_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671677);
			GuestsManager.NativeMethodInfoPtr_get_LevelExtraGuestPatient_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671678);
			GuestsManager.NativeMethodInfoPtr_set_LevelExtraGuestPatient_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671679);
			GuestsManager.NativeMethodInfoPtr_get_CanPlayerRepellGuest_Private_get_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671680);
			GuestsManager.NativeMethodInfoPtr_set_CanPlayerRepellGuest_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671681);
			GuestsManager.NativeMethodInfoPtr_get_AllGuestsControllersInDesk_Private_get_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671682);
			GuestsManager.NativeMethodInfoPtr_set_AllGuestsControllersInDesk_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671683);
			GuestsManager.NativeMethodInfoPtr_get_ManualDesksDic_Private_get_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671684);
			GuestsManager.NativeMethodInfoPtr_set_ManualDesksDic_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671685);
			GuestsManager.NativeMethodInfoPtr_get_TrueAvailableDesks_Private_get_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671686);
			GuestsManager.NativeMethodInfoPtr_get_MaxDeskNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671687);
			GuestsManager.NativeMethodInfoPtr_get_CurrentOccupiedDeskNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671688);
			GuestsManager.NativeMethodInfoPtr_get_AllGuestInDeskCode_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671689);
			GuestsManager.NativeMethodInfoPtr_get_AllGuestInDeskController_Public_get_IEnumerable_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671690);
			GuestsManager.NativeMethodInfoPtr_get_InitializedControllerMood_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671691);
			GuestsManager.NativeMethodInfoPtr_GetAllDeskData_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671692);
			GuestsManager.NativeMethodInfoPtr_Initialize_Public_Void_Func_1_Action_1_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671693);
			GuestsManager.NativeMethodInfoPtr_InitializeHUD_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671694);
			GuestsManager.NativeMethodInfoPtr_RemoveGuestIcon_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671695);
			GuestsManager.NativeMethodInfoPtr_CheckCanPlayerRepelGuest_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671696);
			GuestsManager.NativeMethodInfoPtr_SetPlayerCanRepelGuest_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671697);
			GuestsManager.NativeMethodInfoPtr_SetPlayerCanNotRepelGuest_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671698);
			GuestsManager.NativeMethodInfoPtr_CheckGuestIsInDesk_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671699);
			GuestsManager.NativeMethodInfoPtr_SetGuestInDesk_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671700);
			GuestsManager.NativeMethodInfoPtr_SetGuestOutDesk_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671701);
			GuestsManager.NativeMethodInfoPtr_GetInDeskGuest_Public_GuestGroupController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671702);
			GuestsManager.NativeMethodInfoPtr_Register_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671703);
			GuestsManager.NativeMethodInfoPtr_DeRegister_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671704);
			GuestsManager.NativeMethodInfoPtr_ExcuteEventAtCorodinate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671705);
			GuestsManager.NativeMethodInfoPtr_AddToOrder_Public_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671706);
			GuestsManager.NativeMethodInfoPtr_RemoveFromOrder_Public_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671707);
			GuestsManager.NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Int32_Int32_byref_Action_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671708);
			GuestsManager.NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Vector2_Int32_byref_Action_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671709);
			GuestsManager.NativeMethodInfoPtr_ManualSpawnGuestGroupsFromTargetIzakaya_Public_Void_Il2CppReferenceArray_1_NormalGuestGroup_Vector2_Single_IReadOnlyList_1_Int32_Single_byref_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671710);
			GuestsManager.NativeMethodInfoPtr_ManualSpawnSpecialGuestGroupsFromPoolForSara_Public_Void_Int32_byref_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671711);
			GuestsManager.NativeMethodInfoPtr_MoodEdit_Public_Void_IEnumerable_1_GuestGroupController_Single_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671712);
			GuestsManager.NativeMethodInfoPtr_MoodEdit_Public_Void_GuestGroupController_Single_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671713);
			GuestsManager.NativeMethodInfoPtr_TryCloseIzakaya_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671714);
			GuestsManager.NativeMethodInfoPtr_CloseIzakayaDelayed_Public_IEnumerator_IzakayaCloseType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671715);
			GuestsManager.NativeMethodInfoPtr_CloseIzakayaAndLeaveChallengeMode_Public_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671716);
			GuestsManager.NativeMethodInfoPtr_DisposeAllFoods_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671717);
			GuestsManager.NativeMethodInfoPtr_DisposeTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671718);
			GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestToLeave_Public_IEnumerator_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671719);
			GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestDisAppear_Public_IEnumerator_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671720);
			GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestToLeaveForRogueLike_Public_IEnumerator_Func_1_IEnumerator_Int32_Func_1_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671721);
			GuestsManager.NativeMethodInfoPtr_TryRepellAllQueuedGuestControllers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671722);
			GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroupExtern_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671723);
			GuestsManager.NativeMethodInfoPtr_OnIdleDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671724);
			GuestsManager.NativeMethodInfoPtr_ShowTargetDialog_Public_Void_String_GuestGroupController_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671725);
			GuestsManager.NativeMethodInfoPtr_ShowRepellDialog_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671726);
			GuestsManager.NativeMethodInfoPtr_ShowSeenRepellDialog_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671727);
			GuestsManager.NativeMethodInfoPtr_ShowEvaluationDialog_Private_IEnumerator_GuestGroupController_String_EvaluationResult_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671728);
			GuestsManager.NativeMethodInfoPtr_TrySendToSeat_Public_Boolean_GuestGroupController_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671729);
			GuestsManager.NativeMethodInfoPtr_SpawnGuest_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671730);
			GuestsManager.NativeMethodInfoPtr_OnGuestSpawnAndCheckRabbitGuest_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671731);
			GuestsManager.NativeMethodInfoPtr_GetRabbitGuest_Public_List_1_Transform_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671732);
			GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671733);
			GuestsManager.NativeMethodInfoPtr_SpawnPasserbyGuestGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671734);
			GuestsManager.NativeMethodInfoPtr_SpawnInvitedGuestGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671735);
			GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroup_Public_NormalGuestsController_IEnumerable_1_NormalGuest_Nullable_1_Vector3_LeaveType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671736);
			GuestsManager.NativeMethodInfoPtr_SpawnSpecialGuestGroup_Public_SpecialGuestsController_Int32_GuestSpawnType_Nullable_1_Vector3_Action_1_GuestGroupController_LeaveType_Boolean_Int32_Boolean_Action_1_AStarInputGeneratorComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671737);
			GuestsManager.NativeMethodInfoPtr_RegisteredToIconManager_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671738);
			GuestsManager.NativeMethodInfoPtr_PostInitializeGuestGroup_Private_Void_GuestGroupController_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671739);
			GuestsManager.NativeMethodInfoPtr_SpawnManualControlledSpecialGuestGroup_Public_GuestGroupController_Int32_Boolean_Nullable_1_Vector3_LeaveType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671740);
			GuestsManager.NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_GuestGroupController_Int32_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671741);
			GuestsManager.NativeMethodInfoPtr_SetNormalManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671742);
			GuestsManager.NativeMethodInfoPtr_SetSpecialManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671743);
			GuestsManager.NativeMethodInfoPtr_SetManualControllerOrderInternal_Private_Void_GuestGroupController_Action_1_EvaluationResult_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671744);
			GuestsManager.NativeMethodInfoPtr_Dlc4SpecialManualOrder_Public_Void_GuestGroupController_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671745);
			GuestsManager.NativeMethodInfoPtr_EndDlc4SpecialManualOrder_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671746);
			GuestsManager.NativeMethodInfoPtr_ShowManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671747);
			GuestsManager.NativeMethodInfoPtr_CleanOrderInfo_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671748);
			GuestsManager.NativeMethodInfoPtr_SetManualControlledLeave_Public_Void_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671749);
			GuestsManager.NativeMethodInfoPtr_SetManualControlledPatient_Public_Void_GuestGroupController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671750);
			GuestsManager.NativeMethodInfoPtr_GenerateOrderSession_Private_Void_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671751);
			GuestsManager.NativeMethodInfoPtr_FirstOrder_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671752);
			GuestsManager.NativeMethodInfoPtr_MainOrderCycle_Private_Void_GuestGroupController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671753);
			GuestsManager.NativeMethodInfoPtr_ShowOrder_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671754);
			GuestsManager.NativeMethodInfoPtr_PlayEvaluateSFX_Private_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671755);
			GuestsManager.NativeMethodInfoPtr_PlayEvaluateSFXExtern_Public_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671756);
			GuestsManager.NativeMethodInfoPtr_EvaluateOrder_Public_Void_GuestGroupController_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671757);
			GuestsManager.NativeMethodInfoPtr_EvaulateManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671758);
			GuestsManager.NativeMethodInfoPtr_EvaluationTrans_Private_EvaluationResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671759);
			GuestsManager.NativeMethodInfoPtr_StartPassionGenerationSession_Private_Void_Single_Int32_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671760);
			GuestsManager.NativeMethodInfoPtr_Eval_Private_Void_Int32_Int32_Single_Int32_Boolean_Action_1_GuestGroupController_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671761);
			GuestsManager.NativeMethodInfoPtr_PlayGuestEatSFX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671762);
			GuestsManager.NativeMethodInfoPtr_LackMoneyEvaluate_Private_Void_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671763);
			GuestsManager.NativeMethodInfoPtr_AddToPatientCountdown_Private_Void_GuestGroupController_Action_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671764);
			GuestsManager.NativeMethodInfoPtr_RemoveFromPatientCountdown_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671765);
			GuestsManager.NativeMethodInfoPtr_UpdateTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671766);
			GuestsManager.NativeMethodInfoPtr_GetSeatable_Public_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671767);
			GuestsManager.NativeMethodInfoPtr_ExecuteDelayed_Public_Void_Single_Action_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671768);
			GuestsManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671769);
			GuestsManager.NativeMethodInfoPtr_TryCloseCurrentDialogBox_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671770);
			GuestsManager.NativeMethodInfoPtr_LeaveFromDesk_Private_Void_GuestGroupController_LeaveType_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671771);
			GuestsManager.NativeMethodInfoPtr_CheckAndSendFromQueue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671772);
			GuestsManager.NativeMethodInfoPtr_PayAndLeave_Public_Void_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671773);
			GuestsManager.NativeMethodInfoPtr_GuestPay_Public_Void_GuestGroupController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671774);
			GuestsManager.NativeMethodInfoPtr_PlayPayAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671775);
			GuestsManager.NativeMethodInfoPtr_PayByMood_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671776);
			GuestsManager.NativeMethodInfoPtr_PatientDepletedLeave_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671777);
			GuestsManager.NativeMethodInfoPtr_ExBadLeave_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671778);
			GuestsManager.NativeMethodInfoPtr_RepellAndLeavePay_Public_Void_GuestGroupController_LeaveType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671779);
			GuestsManager.NativeMethodInfoPtr_RepellAndLeaveNoPay_Public_Void_GuestGroupController_LeaveType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671780);
			GuestsManager.NativeMethodInfoPtr_PlayerRepell_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671781);
			GuestsManager.NativeMethodInfoPtr_FlyCharaRepell_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671782);
			GuestsManager.NativeMethodInfoPtr_RepellInternal_Private_Void_GuestGroupController_byref_Boolean_LeaveType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671783);
			GuestsManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671784);
			GuestsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671785);
			GuestsManager.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_0_Private_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671786);
			GuestsManager.NativeMethodInfoPtr__Initialize_b__106_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671787);
			GuestsManager.NativeMethodInfoPtr__TryCloseIzakaya_b__127_0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671788);
			GuestsManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671789);
			GuestsManager.NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671790);
			GuestsManager.NativeMethodInfoPtr__OnWaitForAllGuestDisAppear_b__133_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671791);
			GuestsManager.NativeMethodInfoPtr__SpawnGuest_b__144_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671792);
			GuestsManager.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671793);
			GuestsManager.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671794);
			GuestsManager.NativeMethodInfoPtr__UpdateTick_b__186_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, 100671795);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0013E678 File Offset: 0x0013C878
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 107303, RefRangeEnd = 107331, XrefRangeStart = 107298, XrefRangeEnd = 107303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnGuestSpawn(Action<GuestGroupController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_add_OnGuestSpawn_Public_add_Void_Action_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x0013E6BC File Offset: 0x0013C8BC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 107336, RefRangeEnd = 107364, XrefRangeStart = 107331, XrefRangeEnd = 107336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnGuestSpawn(Action<GuestGroupController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_remove_OnGuestSpawn_Public_rem_Void_Action_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x0013E700 File Offset: 0x0013C900
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x0013E740 File Offset: 0x0013C940
		public unsafe Action<SpecialGuestsController> OnPositiveSpellTriggered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_OnPositiveSpellTriggered_Public_get_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_OnPositiveSpellTriggered_Public_set_Void_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0013E784 File Offset: 0x0013C984
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x0013E7C4 File Offset: 0x0013C9C4
		public unsafe Action<SpecialGuestsController> OnPositiveSpellEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_OnPositiveSpellEnd_Public_get_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_OnPositiveSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x0013E808 File Offset: 0x0013CA08
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x0013E848 File Offset: 0x0013CA48
		public unsafe Action<SpecialGuestsController> OnSpellEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_OnSpellEnd_Public_get_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_OnSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x0013E88C File Offset: 0x0013CA8C
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x0013E8CC File Offset: 0x0013CACC
		public unsafe Action OnIzakayaClosed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_OnIzakayaClosed_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_OnIzakayaClosed_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x0013E910 File Offset: 0x0013CB10
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x0013E950 File Offset: 0x0013CB50
		public unsafe Action OnBussinessTimeEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_OnBussinessTimeEnd_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_OnBussinessTimeEnd_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x0013E994 File Offset: 0x0013CB94
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0013E9D0 File Offset: 0x0013CBD0
		public unsafe bool canGuestBeRepelled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_canGuestBeRepelled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_canGuestBeRepelled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0013EA10 File Offset: 0x0013CC10
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0013EA4C File Offset: 0x0013CC4C
		public unsafe bool IsOpenThroughInteract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_IsOpenThroughInteract_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_IsOpenThroughInteract_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x0013EA8C File Offset: 0x0013CC8C
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x0013EAC8 File Offset: 0x0013CCC8
		public unsafe int LevelExtraGuestBaseMood
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_LevelExtraGuestBaseMood_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_LevelExtraGuestBaseMood_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0013EB08 File Offset: 0x0013CD08
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0013EB44 File Offset: 0x0013CD44
		public unsafe float LevelExtraGuestPatient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_LevelExtraGuestPatient_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_LevelExtraGuestPatient_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x0013EB84 File Offset: 0x0013CD84
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0013EBC4 File Offset: 0x0013CDC4
		public unsafe Dictionary<int, GuestGroupController> CanPlayerRepellGuest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_CanPlayerRepellGuest_Private_get_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_CanPlayerRepellGuest_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x0013EC08 File Offset: 0x0013CE08
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x0013EC48 File Offset: 0x0013CE48
		public unsafe Dictionary<int, GuestGroupController> AllGuestsControllersInDesk
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_AllGuestsControllersInDesk_Private_get_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_AllGuestsControllersInDesk_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x0013EC8C File Offset: 0x0013CE8C
		// (set) Token: 0x06002FBA RID: 12218 RVA: 0x0013ECCC File Offset: 0x0013CECC
		public unsafe Dictionary<int, GuestGroupController> ManualDesksDic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_ManualDesksDic_Private_get_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_set_ManualDesksDic_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x0013ED10 File Offset: 0x0013CF10
		public unsafe Dictionary<int, int> TrueAvailableDesks
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107405, RefRangeEnd = 107408, XrefRangeStart = 107364, XrefRangeEnd = 107405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_TrueAvailableDesks_Private_get_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x0013ED50 File Offset: 0x0013CF50
		public unsafe int MaxDeskNum
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 107411, RefRangeEnd = 107413, XrefRangeStart = 107408, XrefRangeEnd = 107411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_MaxDeskNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x0013ED8C File Offset: 0x0013CF8C
		public unsafe int CurrentOccupiedDeskNum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107413, XrefRangeEnd = 107414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_CurrentOccupiedDeskNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x0013EDC8 File Offset: 0x0013CFC8
		public unsafe IEnumerable<int> AllGuestInDeskCode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 107418, RefRangeEnd = 107423, XrefRangeStart = 107414, XrefRangeEnd = 107418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_AllGuestInDeskCode_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x0013EE08 File Offset: 0x0013D008
		public unsafe IEnumerable<GuestGroupController> AllGuestInDeskController
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 107427, RefRangeEnd = 107449, XrefRangeStart = 107423, XrefRangeEnd = 107427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_AllGuestInDeskController_Public_get_IEnumerable_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestGroupController>>(intPtr3) : null;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x0013EE48 File Offset: 0x0013D048
		public unsafe int InitializedControllerMood
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107450, RefRangeEnd = 107451, XrefRangeStart = 107449, XrefRangeEnd = 107450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_get_InitializedControllerMood_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x0013EE84 File Offset: 0x0013D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107451, XrefRangeEnd = 107580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAllDeskData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GetAllDeskData_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x0013EEBC File Offset: 0x0013D0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107718, RefRangeEnd = 107719, XrefRangeStart = 107580, XrefRangeEnd = 107718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Func<Action<AStarInputGeneratorComponent>> getPostprocessCharacterCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getPostprocessCharacterCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Initialize_Public_Void_Func_1_Action_1_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x0013EF00 File Offset: 0x0013D100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107802, RefRangeEnd = 107803, XrefRangeStart = 107719, XrefRangeEnd = 107802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeHUD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_InitializeHUD_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x0013EF34 File Offset: 0x0013D134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107803, XrefRangeEnd = 107805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGuestIcon(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RemoveGuestIcon_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0013EF78 File Offset: 0x0013D178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107809, RefRangeEnd = 107810, XrefRangeStart = 107805, XrefRangeEnd = 107809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanPlayerRepelGuest(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CheckCanPlayerRepelGuest_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x0013EFC4 File Offset: 0x0013D1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107810, XrefRangeEnd = 107811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCanRepelGuest(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetPlayerCanRepelGuest_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x0013F008 File Offset: 0x0013D208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107812, RefRangeEnd = 107813, XrefRangeStart = 107811, XrefRangeEnd = 107812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCanNotRepelGuest(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetPlayerCanNotRepelGuest_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x0013F04C File Offset: 0x0013D24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107813, XrefRangeEnd = 107817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckGuestIsInDesk(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CheckGuestIsInDesk_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x0013F098 File Offset: 0x0013D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107817, XrefRangeEnd = 107818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGuestInDesk(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetGuestInDesk_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0013F0DC File Offset: 0x0013D2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107819, RefRangeEnd = 107820, XrefRangeStart = 107818, XrefRangeEnd = 107819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGuestOutDesk(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetGuestOutDesk_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0013F120 File Offset: 0x0013D320
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 107835, RefRangeEnd = 107856, XrefRangeStart = 107820, XrefRangeEnd = 107835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController GetInDeskGuest(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GetInDeskGuest_Public_GuestGroupController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr3) : null;
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0013F16C File Offset: 0x0013D36C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107866, RefRangeEnd = 107871, XrefRangeStart = 107856, XrefRangeEnd = 107866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Dictionary<int, GuestGroupController> collection, GuestGroupController data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Register_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0013F1C0 File Offset: 0x0013D3C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107885, RefRangeEnd = 107888, XrefRangeStart = 107871, XrefRangeEnd = 107885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeRegister(Dictionary<int, GuestGroupController> collection, GuestGroupController data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_DeRegister_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0013F214 File Offset: 0x0013D414
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 107894, RefRangeEnd = 107898, XrefRangeStart = 107888, XrefRangeEnd = 107894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExcuteEventAtCorodinate(int corodinate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref corodinate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ExcuteEventAtCorodinate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0013F254 File Offset: 0x0013D454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107898, XrefRangeEnd = 107899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToOrder(GuestsManager.OrderBase add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(add);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_AddToOrder_Public_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0013F298 File Offset: 0x0013D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107899, XrefRangeEnd = 107900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromOrder(GuestsManager.OrderBase order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RemoveFromOrder_Public_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x0013F2DC File Offset: 0x0013D4DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107916, RefRangeEnd = 107918, XrefRangeStart = 107900, XrefRangeEnd = 107916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManualSpawnNormalGuestGroups(int amount, int durationSec, out Action onInterruptCallback, int targetNormalGuestId = -1, bool continueToSpawnAfterDayEnd = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSec;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetNormalGuestId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueToSpawnAfterDayEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Int32_Int32_byref_Action_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			onInterruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0013F368 File Offset: 0x0013D568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107918, XrefRangeEnd = 107934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManualSpawnNormalGuestGroups(Vector2 spawnTime, int durationSec, out Action onInterruptCallback, float extraSpawnRate, int targetNormalGuestId = -1, bool continueToSpawnAfterDayEnd = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spawnTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSec;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraSpawnRate;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetNormalGuestId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueToSpawnAfterDayEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Vector2_Int32_byref_Action_Single_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			onInterruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x0013F400 File Offset: 0x0013D600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107955, RefRangeEnd = 107956, XrefRangeStart = 107934, XrefRangeEnd = 107955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManualSpawnGuestGroupsFromTargetIzakaya(Il2CppReferenceArray<Izakaya.NormalGuestGroup> normalGuestGroups, Vector2 normalGuestSpanInterval, float specialGuestGachaInterval, IReadOnlyList<int> specialGuestPool, float extraRefreshRate, out Action onInterruptCallback, bool continueToSpawnAfterDayEnd = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalGuestGroups);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestSpanInterval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestGachaInterval;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestPool);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraRefreshRate;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueToSpawnAfterDayEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ManualSpawnGuestGroupsFromTargetIzakaya_Public_Void_Il2CppReferenceArray_1_NormalGuestGroup_Vector2_Single_IReadOnlyList_1_Int32_Single_byref_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			onInterruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0013F4B0 File Offset: 0x0013D6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107973, RefRangeEnd = 107974, XrefRangeStart = 107956, XrefRangeEnd = 107973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManualSpawnSpecialGuestGroupsFromPoolForSara(int spawnInterval, out Action onInterruptCallback, Action onAllGuestSpawned, bool continueToSpawnAfterDayEnd = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spawnInterval;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onAllGuestSpawned);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueToSpawnAfterDayEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ManualSpawnSpecialGuestGroupsFromPoolForSara_Public_Void_Int32_byref_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			onInterruptCallback = ((intPtr4 == 0) ? null : new Action(intPtr4));
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0013F530 File Offset: 0x0013D730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107988, RefRangeEnd = 107989, XrefRangeStart = 107974, XrefRangeEnd = 107988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoodEdit(IEnumerable<GuestGroupController> toEdit, float value, EventManager.MathOperation math)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEdit);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref math;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_MoodEdit_Public_Void_IEnumerable_1_GuestGroupController_Single_MathOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0013F590 File Offset: 0x0013D790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107994, RefRangeEnd = 107995, XrefRangeStart = 107989, XrefRangeEnd = 107994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoodEdit(GuestGroupController toEdit, float value, EventManager.MathOperation math)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEdit);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref math;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_MoodEdit_Public_Void_GuestGroupController_Single_MathOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0013F5F0 File Offset: 0x0013D7F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108008, RefRangeEnd = 108010, XrefRangeStart = 107995, XrefRangeEnd = 108008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCloseIzakaya()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_TryCloseIzakaya_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0013F624 File Offset: 0x0013D824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108016, RefRangeEnd = 108019, XrefRangeStart = 108010, XrefRangeEnd = 108016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CloseIzakayaDelayed(GuestsManager.IzakayaCloseType izakayaCloseType, Action onSessionLeave = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref izakayaCloseType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSessionLeave);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CloseIzakayaDelayed_Public_IEnumerator_IzakayaCloseType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x0013F684 File Offset: 0x0013D884
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108054, RefRangeEnd = 108057, XrefRangeStart = 108019, XrefRangeEnd = 108054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseIzakayaAndLeaveChallengeMode(Action onSessionLeave, bool needAutoFadeOut = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onSessionLeave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needAutoFadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CloseIzakayaAndLeaveChallengeMode_Public_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0013F6D4 File Offset: 0x0013D8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108185, RefRangeEnd = 108186, XrefRangeStart = 108057, XrefRangeEnd = 108185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeAllFoods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_DisposeAllFoods_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0013F708 File Offset: 0x0013D908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108266, RefRangeEnd = 108267, XrefRangeStart = 108186, XrefRangeEnd = 108266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_DisposeTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0013F73C File Offset: 0x0013D93C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108273, RefRangeEnd = 108276, XrefRangeStart = 108267, XrefRangeEnd = 108273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnWaitForAllGuestToLeave(Func<IEnumerator> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestToLeave_Public_IEnumerator_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0013F78C File Offset: 0x0013D98C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108282, RefRangeEnd = 108283, XrefRangeStart = 108276, XrefRangeEnd = 108282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnWaitForAllGuestDisAppear(Func<IEnumerator> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestDisAppear_Public_IEnumerator_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0013F7DC File Offset: 0x0013D9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108291, RefRangeEnd = 108292, XrefRangeStart = 108283, XrefRangeEnd = 108291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnWaitForAllGuestToLeaveForRogueLike(Func<IEnumerator> onFinish, int extraWaitTime, Func<bool> extraCheck = null, Action onGuestAllLeave = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraWaitTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraCheck);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGuestAllLeave);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_OnWaitForAllGuestToLeaveForRogueLike_Public_IEnumerator_Func_1_IEnumerator_Int32_Func_1_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0013F860 File Offset: 0x0013DA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108303, RefRangeEnd = 108304, XrefRangeStart = 108292, XrefRangeEnd = 108303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRepellAllQueuedGuestControllers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_TryRepellAllQueuedGuestControllers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0013F894 File Offset: 0x0013DA94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108321, RefRangeEnd = 108324, XrefRangeStart = 108304, XrefRangeEnd = 108321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnNormalGuestGroupExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroupExtern_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0013F8C8 File Offset: 0x0013DAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108324, XrefRangeEnd = 108329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnIdleDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_OnIdleDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0013F908 File Offset: 0x0013DB08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108348, RefRangeEnd = 108350, XrefRangeStart = 108329, XrefRangeEnd = 108348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTargetDialog(string message, GuestGroupController guestGroupController, GuestGroupController.EvaluationResult boxType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boxType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowTargetDialog_Public_Void_String_GuestGroupController_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0013F96C File Offset: 0x0013DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108350, XrefRangeEnd = 108355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRepellDialog(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowRepellDialog_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0013F9B0 File Offset: 0x0013DBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108357, RefRangeEnd = 108358, XrefRangeStart = 108355, XrefRangeEnd = 108357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowSeenRepellDialog(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowSeenRepellDialog_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0013F9F4 File Offset: 0x0013DBF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 108366, RefRangeEnd = 108372, XrefRangeStart = 108358, XrefRangeEnd = 108366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowEvaluationDialog(GuestGroupController toTalk, string message, GuestGroupController.EvaluationResult result, Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toTalk);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowEvaluationDialog_Private_IEnumerator_GuestGroupController_String_EvaluationResult_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x0013FA78 File Offset: 0x0013DC78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108450, RefRangeEnd = 108454, XrefRangeStart = 108372, XrefRangeEnd = 108450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySendToSeat(GuestGroupController toTry, bool firstSpawn, int targetDeskCode = -1, bool shouldOrder = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toTry);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstSpawn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetDeskCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_TrySendToSeat_Public_Boolean_GuestGroupController_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0013FAF0 File Offset: 0x0013DCF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108470, RefRangeEnd = 108472, XrefRangeStart = 108454, XrefRangeEnd = 108470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnGuest(GuestGroupController toTry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toTry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnGuest_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x0013FB34 File Offset: 0x0013DD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108492, RefRangeEnd = 108493, XrefRangeStart = 108472, XrefRangeEnd = 108492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGuestSpawnAndCheckRabbitGuest(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_OnGuestSpawnAndCheckRabbitGuest_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x0013FB78 File Offset: 0x0013DD78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108506, RefRangeEnd = 108508, XrefRangeStart = 108493, XrefRangeEnd = 108506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Transform> GetRabbitGuest(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GetRabbitGuest_Public_List_1_Transform_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x0013FBC8 File Offset: 0x0013DDC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108321, RefRangeEnd = 108324, XrefRangeStart = 108321, XrefRangeEnd = 108324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnNormalGuestGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0013FBFC File Offset: 0x0013DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108508, XrefRangeEnd = 108521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnPasserbyGuestGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnPasserbyGuestGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0013FC30 File Offset: 0x0013DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108521, XrefRangeEnd = 108541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnInvitedGuestGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnInvitedGuestGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0013FC64 File Offset: 0x0013DE64
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 108554, RefRangeEnd = 108563, XrefRangeStart = 108541, XrefRangeEnd = 108554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuestsController SpawnNormalGuestGroup(IEnumerable<NormalGuest> normalGuests, Nullable<Vector3> overrideSpawnPosition = null, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, int targetDeskCode = -1, bool shouldFade = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(normalGuests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideSpawnPosition));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetDeskCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFade;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnNormalGuestGroup_Public_NormalGuestsController_IEnumerable_1_NormalGuest_Nullable_1_Vector3_LeaveType_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NormalGuestsController>(intPtr3) : null;
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0013FCF8 File Offset: 0x0013DEF8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 108572, RefRangeEnd = 108589, XrefRangeStart = 108563, XrefRangeEnd = 108572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestsController SpawnSpecialGuestGroup(int id, SpecialGuestsController.GuestSpawnType guestSpawnType, Nullable<Vector3> overrideSpawnPosition = null, Action<GuestGroupController> onGuestLeave = null, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool recordIzakaya = true, int targetDeskCode = -1, bool tryToJumpQueue = false, Action<AStarInputGeneratorComponent> postProcessCharacterCallback = null, bool shouldFade = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestSpawnType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideSpawnPosition));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGuestLeave);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordIzakaya;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetDeskCode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryToJumpQueue;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postProcessCharacterCallback);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFade;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnSpecialGuestGroup_Public_SpecialGuestsController_Int32_GuestSpawnType_Nullable_1_Vector3_Action_1_GuestGroupController_LeaveType_Boolean_Int32_Boolean_Action_1_AStarInputGeneratorComponent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr3) : null;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x0013FDD8 File Offset: 0x0013DFD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108591, RefRangeEnd = 108593, XrefRangeStart = 108589, XrefRangeEnd = 108591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisteredToIconManager(GuestGroupController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RegisteredToIconManager_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0013FE1C File Offset: 0x0013E01C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108626, RefRangeEnd = 108629, XrefRangeStart = 108593, XrefRangeEnd = 108626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostInitializeGuestGroup(GuestGroupController initializedController, int targetDeskCode = -1, bool tryToJumpQueue = false, bool shouldFade = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializedController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetDeskCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tryToJumpQueue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldFade;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PostInitializeGuestGroup_Private_Void_GuestGroupController_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0013FE88 File Offset: 0x0013E088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108655, RefRangeEnd = 108658, XrefRangeStart = 108629, XrefRangeEnd = 108655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController SpawnManualControlledSpecialGuestGroup(int id, bool spawnInA, Nullable<Vector3> overrideSpawnPosition = null, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool recordIzakaya = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnInA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideSpawnPosition));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordIzakaya;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SpawnManualControlledSpecialGuestGroup_Public_GuestGroupController_Int32_Boolean_Nullable_1_Vector3_LeaveType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr3) : null;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0013FF18 File Offset: 0x0013E118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108658, XrefRangeEnd = 108668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManualControlledToSeat(GuestGroupController manualControlled, int guestMood, int deskCode, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestMood;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_GuestGroupController_Int32_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0013FF8C File Offset: 0x0013E18C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108677, RefRangeEnd = 108680, XrefRangeStart = 108668, XrefRangeEnd = 108677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalManualControlledOrder(GuestGroupController manualControlled, int foodId, int bevId, Action<GuestGroupController.EvaluationResult> onEvaluate, Sprite hiddenPic = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEvaluate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hiddenPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetNormalManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00140010 File Offset: 0x0013E210
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108688, RefRangeEnd = 108692, XrefRangeStart = 108680, XrefRangeEnd = 108688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialManualControlledOrder(GuestGroupController manualControlled, int foodTag, int bevTag, Action<GuestGroupController.EvaluationResult> onEvaluate, Sprite hiddenPic = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodTag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevTag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEvaluate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hiddenPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetSpecialManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00140094 File Offset: 0x0013E294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108737, RefRangeEnd = 108739, XrefRangeStart = 108692, XrefRangeEnd = 108737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManualControllerOrderInternal(GuestGroupController manualControlled, Action<GuestGroupController.EvaluationResult> onEvaluate, GuestsManager.OrderBase order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEvaluate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(order);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetManualControllerOrderInternal_Private_Void_GuestGroupController_Action_1_EvaluationResult_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x001400FC File Offset: 0x0013E2FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108743, RefRangeEnd = 108746, XrefRangeStart = 108739, XrefRangeEnd = 108743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dlc4SpecialManualOrder(GuestGroupController guest, Action onServePanelOpenAndEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onServePanelOpenAndEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Dlc4SpecialManualOrder_Public_Void_GuestGroupController_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00140150 File Offset: 0x0013E350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108750, RefRangeEnd = 108751, XrefRangeStart = 108746, XrefRangeEnd = 108750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDlc4SpecialManualOrder(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_EndDlc4SpecialManualOrder_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00140194 File Offset: 0x0013E394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108812, RefRangeEnd = 108813, XrefRangeStart = 108751, XrefRangeEnd = 108812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowManualOrder(GuestGroupController toShow, Action<GuestGroupController.EvaluationResult> onEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toShow);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x001401E8 File Offset: 0x0013E3E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 108820, RefRangeEnd = 108825, XrefRangeStart = 108813, XrefRangeEnd = 108820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanOrderInfo(GuestGroupController guestGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CleanOrderInfo_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0014022C File Offset: 0x0013E42C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108851, RefRangeEnd = 108852, XrefRangeStart = 108825, XrefRangeEnd = 108851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManualControlledLeave(GuestGroupController manualControlled, bool shouldLeaveInstantly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldLeaveInstantly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetManualControlledLeave_Public_Void_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0014027C File Offset: 0x0013E47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108853, RefRangeEnd = 108854, XrefRangeStart = 108852, XrefRangeEnd = 108853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManualControlledPatient(GuestGroupController manualControlled, int targetPatient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manualControlled);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPatient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_SetManualControlledPatient_Public_Void_GuestGroupController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x001402CC File Offset: 0x0013E4CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108885, RefRangeEnd = 108887, XrefRangeStart = 108854, XrefRangeEnd = 108885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateOrderSession(GuestGroupController guestGroup, bool doContinue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doContinue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GenerateOrderSession_Private_Void_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0014031C File Offset: 0x0013E51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108915, RefRangeEnd = 108916, XrefRangeStart = 108887, XrefRangeEnd = 108915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FirstOrder(GuestGroupController first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_FirstOrder_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00140360 File Offset: 0x0013E560
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108990, RefRangeEnd = 108994, XrefRangeStart = 108916, XrefRangeEnd = 108990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MainOrderCycle(GuestGroupController toCycle, float accumlateDoContinueProbability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toCycle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accumlateDoContinueProbability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_MainOrderCycle_Private_Void_GuestGroupController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x001403B0 File Offset: 0x0013E5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109054, RefRangeEnd = 109055, XrefRangeStart = 108994, XrefRangeEnd = 109054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOrder(GuestGroupController toShow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toShow);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ShowOrder_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x001403F4 File Offset: 0x0013E5F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109059, RefRangeEnd = 109062, XrefRangeStart = 109055, XrefRangeEnd = 109059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEvaluateSFX(GuestGroupController.EvaluationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PlayEvaluateSFX_Private_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00140434 File Offset: 0x0013E634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109063, RefRangeEnd = 109064, XrefRangeStart = 109062, XrefRangeEnd = 109063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayEvaluateSFXExtern(GuestGroupController.EvaluationResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PlayEvaluateSFXExtern_Public_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00140474 File Offset: 0x0013E674
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109221, RefRangeEnd = 109226, XrefRangeStart = 109064, XrefRangeEnd = 109221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateOrder(GuestGroupController toEvaluate, bool isTriggerByPartner, Action onFinishEvaluateCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTriggerByPartner;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishEvaluateCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_EvaluateOrder_Public_Void_GuestGroupController_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x001404D8 File Offset: 0x0013E6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109317, RefRangeEnd = 109318, XrefRangeStart = 109226, XrefRangeEnd = 109317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaulateManualOrder(GuestGroupController toEvaluate, Action<GuestGroupController.EvaluationResult> onEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_EvaulateManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0014052C File Offset: 0x0013E72C
		[CallerCount(0)]
		public unsafe GuestGroupController.EvaluationResult EvaluationTrans(int evaluation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_EvaluationTrans_Private_EvaluationResult_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00140578 File Offset: 0x0013E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109318, XrefRangeEnd = 109326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPassionGenerationSession(float duration, int amount, GuestGroupController toEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_StartPassionGenerationSession_Private_Void_Single_Int32_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x001405D8 File Offset: 0x0013E7D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109386, RefRangeEnd = 109391, XrefRangeStart = 109326, XrefRangeEnd = 109386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Eval(int firstMood, int moon, float delay, int amount, bool shouldAddCombo, Action<GuestGroupController> onDeleyEndCallback, GuestGroupController toEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref firstMood;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moon;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldAddCombo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDeleyEndCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Eval_Private_Void_Int32_Int32_Single_Int32_Boolean_Action_1_GuestGroupController_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00140674 File Offset: 0x0013E874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109391, XrefRangeEnd = 109399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayGuestEatSFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PlayGuestEatSFX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x001406A8 File Offset: 0x0013E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109399, XrefRangeEnd = 109404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LackMoneyEvaluate(GuestGroupController toEvaluate, bool exceedEndurance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceedEndurance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_LackMoneyEvaluate_Private_Void_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x001406F8 File Offset: 0x0013E8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109433, RefRangeEnd = 109434, XrefRangeStart = 109404, XrefRangeEnd = 109433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToPatientCountdown(GuestGroupController toCountDown, Action<GuestGroupController> onPatientDepeletedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toCountDown);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPatientDepeletedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_AddToPatientCountdown_Private_Void_GuestGroupController_Action_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0014074C File Offset: 0x0013E94C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109455, RefRangeEnd = 109460, XrefRangeStart = 109434, XrefRangeEnd = 109455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromPatientCountdown(GuestGroupController toCountDown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toCountDown);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RemoveFromPatientCountdown_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00140790 File Offset: 0x0013E990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109460, XrefRangeEnd = 109495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_UpdateTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x001407C4 File Offset: 0x0013E9C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109531, RefRangeEnd = 109535, XrefRangeStart = 109495, XrefRangeEnd = 109531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetSeatable(int guestCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guestCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GetSeatable_Public_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00140810 File Offset: 0x0013EA10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109544, RefRangeEnd = 109547, XrefRangeStart = 109535, XrefRangeEnd = 109544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteDelayed(float offset, Action onDeleyEndCallback, Func<bool> onVertify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDeleyEndCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onVertify);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ExecuteDelayed_Public_Void_Single_Action_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x00140874 File Offset: 0x0013EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109547, XrefRangeEnd = 109550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x001408B0 File Offset: 0x0013EAB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 109556, RefRangeEnd = 109567, XrefRangeStart = 109550, XrefRangeEnd = 109556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCloseCurrentDialogBox(GuestGroupController toEvaluate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEvaluate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_TryCloseCurrentDialogBox_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x001408F4 File Offset: 0x0013EAF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109602, RefRangeEnd = 109606, XrefRangeStart = 109567, XrefRangeEnd = 109602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveFromDesk(GuestGroupController toLeave, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, Action leaveAction = null, bool triggerLeaveBuff = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toLeave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leaveAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerLeaveBuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_LeaveFromDesk_Private_Void_GuestGroupController_LeaveType_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00140964 File Offset: 0x0013EB64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109629, RefRangeEnd = 109634, XrefRangeStart = 109606, XrefRangeEnd = 109629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAndSendFromQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_CheckAndSendFromQueue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x00140998 File Offset: 0x0013EB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109636, RefRangeEnd = 109637, XrefRangeStart = 109634, XrefRangeEnd = 109636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PayAndLeave(GuestGroupController toPayAndLeave, bool includeTip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPayAndLeave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PayAndLeave_Public_Void_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x001409E8 File Offset: 0x0013EBE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109695, RefRangeEnd = 109697, XrefRangeStart = 109637, XrefRangeEnd = 109695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GuestPay(GuestGroupController toPayAndLeave, bool includeTip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPayAndLeave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_GuestPay_Public_Void_GuestGroupController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x00140A38 File Offset: 0x0013EC38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109705, RefRangeEnd = 109708, XrefRangeStart = 109697, XrefRangeEnd = 109705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPayAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PlayPayAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x00140A6C File Offset: 0x0013EC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109715, RefRangeEnd = 109716, XrefRangeStart = 109708, XrefRangeEnd = 109715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PayByMood(GuestGroupController toPayAndLeave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPayAndLeave);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PayByMood_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00140AB0 File Offset: 0x0013ECB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109716, XrefRangeEnd = 109738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PatientDepletedLeave(GuestGroupController toPatientDepletedLeave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toPatientDepletedLeave);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PatientDepletedLeave_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00140AF4 File Offset: 0x0013ECF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109738, XrefRangeEnd = 109740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExBadLeave(GuestGroupController toExBadLeave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toExBadLeave);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_ExBadLeave_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00140B38 File Offset: 0x0013ED38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 109747, RefRangeEnd = 109755, XrefRangeStart = 109740, XrefRangeEnd = 109747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepellAndLeavePay(GuestGroupController toRepell, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerBuff = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRepell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerBuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RepellAndLeavePay_Public_Void_GuestGroupController_LeaveType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00140B98 File Offset: 0x0013ED98
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 109756, RefRangeEnd = 109776, XrefRangeStart = 109755, XrefRangeEnd = 109756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepellAndLeaveNoPay(GuestGroupController toRepell, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerBuff = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRepell);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerBuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RepellAndLeaveNoPay_Public_Void_GuestGroupController_LeaveType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00140BF8 File Offset: 0x0013EDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109841, RefRangeEnd = 109843, XrefRangeStart = 109776, XrefRangeEnd = 109841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRepell(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_PlayerRepell_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00140C38 File Offset: 0x0013EE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109860, RefRangeEnd = 109861, XrefRangeStart = 109843, XrefRangeEnd = 109860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlyCharaRepell(GuestGroupController toRepell)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRepell);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_FlyCharaRepell_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00140C7C File Offset: 0x0013EE7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109878, RefRangeEnd = 109881, XrefRangeStart = 109861, XrefRangeEnd = 109878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepellInternal(GuestGroupController guestGroupController, out bool haveSeated, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerLeaveBuff = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &haveSeated;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triggerLeaveBuff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_RepellInternal_Private_Void_GuestGroupController_byref_Boolean_LeaveType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00140CE8 File Offset: 0x0013EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109881, XrefRangeEnd = 109917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00140D24 File Offset: 0x0013EF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109917, XrefRangeEnd = 109942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00140D60 File Offset: 0x0013EF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109942, XrefRangeEnd = 109948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_TrueAvailableDesks_b__94_0(KeyValuePair<int, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_0_Private_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00140DB4 File Offset: 0x0013EFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109948, XrefRangeEnd = 109949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__106_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__Initialize_b__106_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00140DF4 File Offset: 0x0013EFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109949, XrefRangeEnd = 109955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator _TryCloseIzakaya_b__127_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__TryCloseIzakaya_b__127_0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x00140E34 File Offset: 0x0013F034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109955, XrefRangeEnd = 110014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x00140E5C File Offset: 0x0013F05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110014, XrefRangeEnd = 110016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnWaitForAllGuestToLeave_b__132_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x00140E98 File Offset: 0x0013F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110016, XrefRangeEnd = 110017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnWaitForAllGuestDisAppear_b__133_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__OnWaitForAllGuestDisAppear_b__133_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00140ED4 File Offset: 0x0013F0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110017, XrefRangeEnd = 110021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SpawnGuest_b__144_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__SpawnGuest_b__144_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00140F18 File Offset: 0x0013F118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110021, XrefRangeEnd = 110029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GuestGroupController_PDM_0(GuestGroupController groupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00140F5C File Offset: 0x0013F15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110029, XrefRangeEnd = 110032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GuestGroupController_PDM_1(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00140FA0 File Offset: 0x0013F1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110032, XrefRangeEnd = 110036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateTick_b__186_0(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NativeMethodInfoPtr__UpdateTick_b__186_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x0001B4E8 File Offset: 0x000196E8
		public GuestsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x00140FE4 File Offset: 0x0013F1E4
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x0001B4F1 File Offset: 0x000196F1
		public unsafe static int GUEST_INITIAL_MOOD_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x00141000 File Offset: 0x0013F200
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x0001B4FF File Offset: 0x000196FF
		public unsafe static int GUEST_INITIAL_MOOD_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x0014101C File Offset: 0x0013F21C
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x0001B50D File Offset: 0x0001970D
		public unsafe static float FIRSTORDER_DELAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_FIRSTORDER_DELAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_FIRSTORDER_DELAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x00141038 File Offset: 0x0013F238
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x0001B51B File Offset: 0x0001971B
		public unsafe static float STATE_ICON_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_STATE_ICON_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_STATE_ICON_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x00141054 File Offset: 0x0013F254
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x0001B529 File Offset: 0x00019729
		public unsafe static int ON_GUEST_START_PROVIDE_PASSION_MOOD
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_ON_GUEST_START_PROVIDE_PASSION_MOOD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_ON_GUEST_START_PROVIDE_PASSION_MOOD, (void*)(&value));
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x00141070 File Offset: 0x0013F270
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x0001B537 File Offset: 0x00019737
		public unsafe static int TOTAL_NORMAL_PASSION_GENERATE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_TOTAL_NORMAL_PASSION_GENERATE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_TOTAL_NORMAL_PASSION_GENERATE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x0014108C File Offset: 0x0013F28C
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x0001B545 File Offset: 0x00019745
		public unsafe static int TOTAL_BAD_PASSION_GENERATE_AMOUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_TOTAL_BAD_PASSION_GENERATE_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_TOTAL_BAD_PASSION_GENERATE_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x001410A8 File Offset: 0x0013F2A8
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x0001B553 File Offset: 0x00019753
		public unsafe static int ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT, (void*)(&value));
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x001410C4 File Offset: 0x0013F2C4
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x0001B561 File Offset: 0x00019761
		public unsafe static float DELAY_EVALUATE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_DELAY_EVALUATE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_DELAY_EVALUATE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x001410E0 File Offset: 0x0013F2E0
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x0001B56F File Offset: 0x0001976F
		public unsafe static float BAD_MOOD_EXP
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_BAD_MOOD_EXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_BAD_MOOD_EXP, (void*)(&value));
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x001410FC File Offset: 0x0013F2FC
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x0001B57D File Offset: 0x0001977D
		public unsafe static float NORMAL_MOOD_EXP
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_NORMAL_MOOD_EXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_NORMAL_MOOD_EXP, (void*)(&value));
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x00141118 File Offset: 0x0013F318
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x0001B58B File Offset: 0x0001978B
		public unsafe static float GOOD_MOOD_EXP
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_GOOD_MOOD_EXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_GOOD_MOOD_EXP, (void*)(&value));
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x00141134 File Offset: 0x0013F334
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x0001B599 File Offset: 0x00019799
		public unsafe static float EXGOOD_MOOD_EXP
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_EXGOOD_MOOD_EXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_EXGOOD_MOOD_EXP, (void*)(&value));
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00141150 File Offset: 0x0013F350
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x0001B5A7 File Offset: 0x000197A7
		public unsafe static int MEDICINE_SPECIAL_FOOD_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x0014116C File Offset: 0x0013F36C
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x0001B5B5 File Offset: 0x000197B5
		public unsafe static int MEDICINE_SPECIAL_MILK_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_MILK_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_MEDICINE_SPECIAL_MILK_TAG, (void*)(&value));
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00141188 File Offset: 0x0013F388
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x0001B5C3 File Offset: 0x000197C3
		public unsafe Il2CppReferenceArray<AudioClip> evaulate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_evaulate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_evaulate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x001411B8 File Offset: 0x0013F3B8
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x0001B5E2 File Offset: 0x000197E2
		public unsafe AudioClip order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_order);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_order), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x001411E8 File Offset: 0x0013F3E8
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x0001B601 File Offset: 0x00019801
		public unsafe AudioClip pay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_pay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_pay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x00141218 File Offset: 0x0013F418
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x0001B620 File Offset: 0x00019820
		public unsafe AudioClip timeEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_timeEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_timeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x00141248 File Offset: 0x0013F448
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x0001B63F File Offset: 0x0001983F
		public unsafe Canvas uiContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_uiContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_uiContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x00141278 File Offset: 0x0013F478
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x0001B65E File Offset: 0x0001985E
		public unsafe GameObject Await
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_Await);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_Await), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x001412A8 File Offset: 0x0013F4A8
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x0001B67D File Offset: 0x0001987D
		public unsafe GameObject Eat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_Eat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_Eat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x001412D8 File Offset: 0x0013F4D8
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x0001B69C File Offset: 0x0001989C
		public unsafe GameObject serveInWorkMissionIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_serveInWorkMissionIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_serveInWorkMissionIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x00141308 File Offset: 0x0013F508
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x0001B6BB File Offset: 0x000198BB
		public unsafe GameObject hateFoodTagIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_hateFoodTagIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_hateFoodTagIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x00141338 File Offset: 0x0013F538
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x0001B6DA File Offset: 0x000198DA
		public unsafe AudioClip hateFoodTagAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_hateFoodTagAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_hateFoodTagAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600305C RID: 12380 RVA: 0x00141368 File Offset: 0x0013F568
		// (set) Token: 0x0600305D RID: 12381 RVA: 0x0001B6F9 File Offset: 0x000198F9
		public unsafe Il2CppReferenceArray<AudioClip> eatSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_eatSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_eatSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x00141398 File Offset: 0x0013F598
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x0001B718 File Offset: 0x00019918
		public unsafe Il2CppReferenceArray<AudioClip> glassSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_glassSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_glassSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x001413C8 File Offset: 0x0013F5C8
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x0001B737 File Offset: 0x00019937
		public unsafe Func<Action<AStarInputGeneratorComponent>> getPostprocessCharacterCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_getPostprocessCharacterCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action<AStarInputGeneratorComponent>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_getPostprocessCharacterCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x001413F8 File Offset: 0x0013F5F8
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x0001B756 File Offset: 0x00019956
		public unsafe Dictionary<GuestGroupController, Action> currentDisplayedDialogBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_currentDisplayedDialogBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestGroupController, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_currentDisplayedDialogBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x00141428 File Offset: 0x0013F628
		// (set) Token: 0x06003065 RID: 12389 RVA: 0x0001B775 File Offset: 0x00019975
		public unsafe Dictionary<int, int> allDesks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_allDesks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_allDesks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x00141458 File Offset: 0x0013F658
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x0001B794 File Offset: 0x00019994
		public unsafe GuestIconManager guestIconManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_guestIconManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestIconManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_guestIconManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06003068 RID: 12392 RVA: 0x00141488 File Offset: 0x0013F688
		// (set) Token: 0x06003069 RID: 12393 RVA: 0x0001B7B3 File Offset: 0x000199B3
		public unsafe bool isIzakayaClosing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_isIzakayaClosing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_isIzakayaClosing)) = value;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x001414B0 File Offset: 0x0013F6B0
		// (set) Token: 0x0600306B RID: 12395 RVA: 0x0001B7CE File Offset: 0x000199CE
		public unsafe int largestDesk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_largestDesk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_largestDesk)) = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x001414D8 File Offset: 0x0013F6D8
		// (set) Token: 0x0600306D RID: 12397 RVA: 0x0001B7E9 File Offset: 0x000199E9
		public unsafe List<int> occupiedDesks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_occupiedDesks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_occupiedDesks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600306E RID: 12398 RVA: 0x00141508 File Offset: 0x0013F708
		// (set) Token: 0x0600306F RID: 12399 RVA: 0x0001B808 File Offset: 0x00019A08
		public Nullable<KeyValuePair<GuestGroupController, Action>> onForcePannelClosingWhenGuestRepellCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onForcePannelClosingWhenGuestRepellCallback);
				return new Nullable<KeyValuePair<GuestGroupController, Action>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<KeyValuePair<GuestGroupController, Action>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onForcePannelClosingWhenGuestRepellCallback), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<KeyValuePair<GuestGroupController, Action>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x00141538 File Offset: 0x0013F738
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x0001B836 File Offset: 0x00019A36
		public unsafe Action<GuestsManager.OrderBase> onOrderAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onOrderAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestsManager.OrderBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onOrderAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x00141568 File Offset: 0x0013F768
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x0001B855 File Offset: 0x00019A55
		public unsafe Action<GuestsManager.OrderBase> onOrderRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onOrderRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestsManager.OrderBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_onOrderRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06003074 RID: 12404 RVA: 0x00141598 File Offset: 0x0013F798
		// (set) Token: 0x06003075 RID: 12405 RVA: 0x0001B874 File Offset: 0x00019A74
		public unsafe Dictionary<int, Action> registeredCharacterArrivedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_registeredCharacterArrivedEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_registeredCharacterArrivedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003076 RID: 12406 RVA: 0x001415C8 File Offset: 0x0013F7C8
		// (set) Token: 0x06003077 RID: 12407 RVA: 0x0001B893 File Offset: 0x00019A93
		public unsafe Dictionary<GuestGroupController, GuestsManager.TimedEvent> timed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_timed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestGroupController, GuestsManager.TimedEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_timed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06003078 RID: 12408 RVA: 0x001415F8 File Offset: 0x0013F7F8
		// (set) Token: 0x06003079 RID: 12409 RVA: 0x0001B8B2 File Offset: 0x00019AB2
		public unsafe HashSet<GuestGroupController> AllPresentedGuestGroupController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_AllPresentedGuestGroupController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_AllPresentedGuestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x00141628 File Offset: 0x0013F828
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x0001B8D1 File Offset: 0x00019AD1
		public unsafe Action<GuestGroupController> OnGuestSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_OnGuestSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_OnGuestSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x00141658 File Offset: 0x0013F858
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		public unsafe Action<SpecialGuestsController> _OnPositiveSpellTriggered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnPositiveSpellTriggered_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnPositiveSpellTriggered_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x00141688 File Offset: 0x0013F888
		// (set) Token: 0x0600307F RID: 12415 RVA: 0x0001B90F File Offset: 0x00019B0F
		public unsafe Action<SpecialGuestsController> _OnPositiveSpellEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnPositiveSpellEnd_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnPositiveSpellEnd_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x001416B8 File Offset: 0x0013F8B8
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x0001B92E File Offset: 0x00019B2E
		public unsafe Action<SpecialGuestsController> _OnSpellEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnSpellEnd_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnSpellEnd_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x001416E8 File Offset: 0x0013F8E8
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x0001B94D File Offset: 0x00019B4D
		public unsafe Action _OnIzakayaClosed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnIzakayaClosed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnIzakayaClosed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x00141718 File Offset: 0x0013F918
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x0001B96C File Offset: 0x00019B6C
		public unsafe Action _OnBussinessTimeEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnBussinessTimeEnd_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__OnBussinessTimeEnd_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x00141748 File Offset: 0x0013F948
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x0001B98B File Offset: 0x00019B8B
		public unsafe bool _canGuestBeRepelled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__canGuestBeRepelled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__canGuestBeRepelled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x00141770 File Offset: 0x0013F970
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x0001B9A6 File Offset: 0x00019BA6
		public unsafe bool _IsOpenThroughInteract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__IsOpenThroughInteract_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__IsOpenThroughInteract_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x00141798 File Offset: 0x0013F998
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x0001B9C1 File Offset: 0x00019BC1
		public unsafe int _LevelExtraGuestBaseMood_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__LevelExtraGuestBaseMood_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__LevelExtraGuestBaseMood_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x001417C0 File Offset: 0x0013F9C0
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x0001B9DC File Offset: 0x00019BDC
		public unsafe float _LevelExtraGuestPatient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__LevelExtraGuestPatient_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__LevelExtraGuestPatient_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x001417E8 File Offset: 0x0013F9E8
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x0001B9F7 File Offset: 0x00019BF7
		public unsafe Dictionary<int, GuestGroupController> _CanPlayerRepellGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__CanPlayerRepellGuest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__CanPlayerRepellGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x00141818 File Offset: 0x0013FA18
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x0001BA16 File Offset: 0x00019C16
		public unsafe Dictionary<int, GuestGroupController> _AllGuestsControllersInDesk_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__AllGuestsControllersInDesk_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__AllGuestsControllersInDesk_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x00141848 File Offset: 0x0013FA48
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x0001BA35 File Offset: 0x00019C35
		public unsafe Dictionary<int, GuestGroupController> _ManualDesksDic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__ManualDesksDic_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr__ManualDesksDic_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x00141878 File Offset: 0x0013FA78
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x0001BA54 File Offset: 0x00019C54
		public unsafe int ForceDialogDeskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_ForceDialogDeskCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_ForceDialogDeskCode)) = value;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x001418A0 File Offset: 0x0013FAA0
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x0001BA6F File Offset: 0x00019C6F
		public unsafe static int TEWI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_TEWI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_TEWI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x001418BC File Offset: 0x0013FABC
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x0001BA7D File Offset: 0x00019C7D
		public unsafe static int TEWI_ID_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_TEWI_ID_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_TEWI_ID_2, (void*)(&value));
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x001418D8 File Offset: 0x0013FAD8
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x0001BA8B File Offset: 0x00019C8B
		public unsafe static int REISEN2_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_REISEN2_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_REISEN2_ID, (void*)(&value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x001418F4 File Offset: 0x0013FAF4
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x0001BA99 File Offset: 0x00019C99
		public unsafe static int YOUKAI_RABBIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_YOUKAI_RABBIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_YOUKAI_RABBIT, (void*)(&value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x00141910 File Offset: 0x0013FB10
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x0001BAA7 File Offset: 0x00019CA7
		public unsafe static int MOON_RABBIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_MOON_RABBIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_MOON_RABBIT, (void*)(&value));
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x0014192C File Offset: 0x0013FB2C
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x0001BAB5 File Offset: 0x00019CB5
		public unsafe static int MOON_RABBIT_2
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_MOON_RABBIT_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_MOON_RABBIT_2, (void*)(&value));
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x00141948 File Offset: 0x0013FB48
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x0001BAC3 File Offset: 0x00019CC3
		public unsafe static int GUEST_BASE_EXP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GuestsManager.NativeFieldInfoPtr_GUEST_BASE_EXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestsManager.NativeFieldInfoPtr_GUEST_BASE_EXP, (void*)(&value));
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00141964 File Offset: 0x0013FB64
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x0001BAD1 File Offset: 0x00019CD1
		public unsafe Action<int, Action> KisumeRepellCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_KisumeRepellCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NativeFieldInfoPtr_KisumeRepellCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MIN;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_GUEST_INITIAL_MOOD_MAX;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_FIRSTORDER_DELAY_TIME;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_STATE_ICON_OFFSET;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_ON_GUEST_START_PROVIDE_PASSION_MOOD;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeFieldInfoPtr_TOTAL_NORMAL_PASSION_GENERATE_AMOUNT;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_TOTAL_BAD_PASSION_GENERATE_AMOUNT;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeFieldInfoPtr_DELAY_EVALUATE_TIME;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_BAD_MOOD_EXP;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeFieldInfoPtr_NORMAL_MOOD_EXP;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_GOOD_MOOD_EXP;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_EXGOOD_MOOD_EXP;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_MEDICINE_SPECIAL_MILK_TAG;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr_evaulate;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr_pay;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_timeEnd;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_uiContainer;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_Await;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeFieldInfoPtr_Eat;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeFieldInfoPtr_serveInWorkMissionIcon;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_hateFoodTagIcon;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_hateFoodTagAudio;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr_eatSFX;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_glassSFX;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeFieldInfoPtr_getPostprocessCharacterCallback;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeFieldInfoPtr_currentDisplayedDialogBox;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeFieldInfoPtr_allDesks;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeFieldInfoPtr_guestIconManager;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeFieldInfoPtr_isIzakayaClosing;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr_largestDesk;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeFieldInfoPtr_occupiedDesks;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeFieldInfoPtr_onForcePannelClosingWhenGuestRepellCallback;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeFieldInfoPtr_onOrderAdd;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr_onOrderRemove;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_registeredCharacterArrivedEvents;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_timed;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeFieldInfoPtr_AllPresentedGuestGroupController;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_OnGuestSpawn;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr__OnPositiveSpellTriggered_k__BackingField;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr__OnPositiveSpellEnd_k__BackingField;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr__OnSpellEnd_k__BackingField;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr__OnIzakayaClosed_k__BackingField;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeFieldInfoPtr__OnBussinessTimeEnd_k__BackingField;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeFieldInfoPtr__canGuestBeRepelled_k__BackingField;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeFieldInfoPtr__IsOpenThroughInteract_k__BackingField;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr__LevelExtraGuestBaseMood_k__BackingField;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeFieldInfoPtr__LevelExtraGuestPatient_k__BackingField;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeFieldInfoPtr__CanPlayerRepellGuest_k__BackingField;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeFieldInfoPtr__AllGuestsControllersInDesk_k__BackingField;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr__ManualDesksDic_k__BackingField;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeFieldInfoPtr_ForceDialogDeskCode;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_ID;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_ID_2;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr_REISEN2_ID;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_YOUKAI_RABBIT;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeFieldInfoPtr_MOON_RABBIT;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeFieldInfoPtr_MOON_RABBIT_2;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_GUEST_BASE_EXP;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeFieldInfoPtr_KisumeRepellCallback;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGuestSpawn_Public_add_Void_Action_1_GuestGroupController_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGuestSpawn_Public_rem_Void_Action_1_GuestGroupController_0;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_get_OnPositiveSpellTriggered_Public_get_Action_1_SpecialGuestsController_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_set_OnPositiveSpellTriggered_Public_set_Void_Action_1_SpecialGuestsController_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_get_OnPositiveSpellEnd_Public_get_Action_1_SpecialGuestsController_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_set_OnPositiveSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSpellEnd_Public_get_Action_1_SpecialGuestsController_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSpellEnd_Public_set_Void_Action_1_SpecialGuestsController_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_get_OnIzakayaClosed_Public_get_Action_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_set_OnIzakayaClosed_Public_set_Void_Action_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_get_OnBussinessTimeEnd_Public_get_Action_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr_set_OnBussinessTimeEnd_Public_set_Void_Action_0;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_get_canGuestBeRepelled_Public_get_Boolean_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr_set_canGuestBeRepelled_Public_set_Void_Boolean_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpenThroughInteract_Private_get_Boolean_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpenThroughInteract_Public_set_Void_Boolean_0;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelExtraGuestBaseMood_Private_get_Int32_0;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr_set_LevelExtraGuestBaseMood_Private_set_Void_Int32_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelExtraGuestPatient_Private_get_Single_0;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeMethodInfoPtr_set_LevelExtraGuestPatient_Private_set_Void_Single_0;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeMethodInfoPtr_get_CanPlayerRepellGuest_Private_get_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeMethodInfoPtr_set_CanPlayerRepellGuest_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr_get_AllGuestsControllersInDesk_Private_get_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr_set_AllGuestsControllersInDesk_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_get_ManualDesksDic_Private_get_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_set_ManualDesksDic_Private_set_Void_Dictionary_2_Int32_GuestGroupController_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_get_TrueAvailableDesks_Private_get_Dictionary_2_Int32_Int32_0;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDeskNum_Public_get_Int32_0;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentOccupiedDeskNum_Public_get_Int32_0;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeMethodInfoPtr_get_AllGuestInDeskCode_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeMethodInfoPtr_get_AllGuestInDeskController_Public_get_IEnumerable_1_GuestGroupController_0;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializedControllerMood_Public_get_Int32_0;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDeskData_Public_String_0;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Func_1_Action_1_AStarInputGeneratorComponent_0;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeMethodInfoPtr_InitializeHUD_Public_Void_0;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGuestIcon_Public_Void_GuestGroupController_0;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanPlayerRepelGuest_Public_Boolean_Int32_0;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCanRepelGuest_Private_Void_GuestGroupController_0;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCanNotRepelGuest_Private_Void_GuestGroupController_0;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeMethodInfoPtr_CheckGuestIsInDesk_Private_Boolean_Int32_0;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestInDesk_Private_Void_GuestGroupController_0;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestOutDesk_Private_Void_GuestGroupController_0;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeMethodInfoPtr_GetInDeskGuest_Public_GuestGroupController_Int32_0;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr_Register_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr_DeRegister_Private_Void_Dictionary_2_Int32_GuestGroupController_GuestGroupController_0;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_ExcuteEventAtCorodinate_Public_Void_Int32_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_AddToOrder_Public_Void_OrderBase_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromOrder_Public_Void_OrderBase_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Int32_Int32_byref_Action_Int32_Boolean_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_ManualSpawnNormalGuestGroups_Public_Void_Vector2_Int32_byref_Action_Single_Int32_Boolean_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_ManualSpawnGuestGroupsFromTargetIzakaya_Public_Void_Il2CppReferenceArray_1_NormalGuestGroup_Vector2_Single_IReadOnlyList_1_Int32_Single_byref_Action_Boolean_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_ManualSpawnSpecialGuestGroupsFromPoolForSara_Public_Void_Int32_byref_Action_Action_Boolean_0;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr_MoodEdit_Public_Void_IEnumerable_1_GuestGroupController_Single_MathOperation_0;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr_MoodEdit_Public_Void_GuestGroupController_Single_MathOperation_0;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_TryCloseIzakaya_Public_Void_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_CloseIzakayaDelayed_Public_IEnumerator_IzakayaCloseType_Action_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr_CloseIzakayaAndLeaveChallengeMode_Public_Void_Action_Boolean_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAllFoods_Public_Void_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_DisposeTray_Public_Void_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitForAllGuestToLeave_Public_IEnumerator_Func_1_IEnumerator_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitForAllGuestDisAppear_Public_IEnumerator_Func_1_IEnumerator_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitForAllGuestToLeaveForRogueLike_Public_IEnumerator_Func_1_IEnumerator_Int32_Func_1_Boolean_Action_0;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeMethodInfoPtr_TryRepellAllQueuedGuestControllers_Public_Void_0;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuestGroupExtern_Public_Void_0;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeMethodInfoPtr_OnIdleDialog_Private_IEnumerator_0;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr_ShowTargetDialog_Public_Void_String_GuestGroupController_EvaluationResult_0;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr_ShowRepellDialog_Public_Void_GuestGroupController_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_ShowSeenRepellDialog_Public_Void_GuestGroupController_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_ShowEvaluationDialog_Private_IEnumerator_GuestGroupController_String_EvaluationResult_Transform_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_TrySendToSeat_Public_Boolean_GuestGroupController_Boolean_Int32_Boolean_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGuest_Private_Void_GuestGroupController_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_OnGuestSpawnAndCheckRabbitGuest_Private_Void_GuestGroupController_0;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr_GetRabbitGuest_Public_List_1_Transform_GuestGroupController_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuestGroup_Private_Void_0;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeMethodInfoPtr_SpawnPasserbyGuestGroup_Private_Void_0;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeMethodInfoPtr_SpawnInvitedGuestGroup_Private_Void_0;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuestGroup_Public_NormalGuestsController_IEnumerable_1_NormalGuest_Nullable_1_Vector3_LeaveType_Int32_Boolean_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr_SpawnSpecialGuestGroup_Public_SpecialGuestsController_Int32_GuestSpawnType_Nullable_1_Vector3_Action_1_GuestGroupController_LeaveType_Boolean_Int32_Boolean_Action_1_AStarInputGeneratorComponent_Boolean_0;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeMethodInfoPtr_RegisteredToIconManager_Public_Void_GuestGroupController_0;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr_PostInitializeGuestGroup_Private_Void_GuestGroupController_Int32_Boolean_Boolean_0;

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeMethodInfoPtr_SpawnManualControlledSpecialGuestGroup_Public_GuestGroupController_Int32_Boolean_Nullable_1_Vector3_LeaveType_Boolean_0;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_GuestGroupController_Int32_Int32_Action_0;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialManualControlledOrder_Public_Void_GuestGroupController_Int32_Int32_Action_1_EvaluationResult_Sprite_0;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeMethodInfoPtr_SetManualControllerOrderInternal_Private_Void_GuestGroupController_Action_1_EvaluationResult_OrderBase_0;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeMethodInfoPtr_Dlc4SpecialManualOrder_Public_Void_GuestGroupController_Action_0;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeMethodInfoPtr_EndDlc4SpecialManualOrder_Public_Void_GuestGroupController_0;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_ShowManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr_CleanOrderInfo_Public_Void_GuestGroupController_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_SetManualControlledLeave_Public_Void_GuestGroupController_Boolean_0;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeMethodInfoPtr_SetManualControlledPatient_Public_Void_GuestGroupController_Int32_0;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeMethodInfoPtr_GenerateOrderSession_Private_Void_GuestGroupController_Boolean_0;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrder_Private_Void_GuestGroupController_0;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr_MainOrderCycle_Private_Void_GuestGroupController_Single_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_ShowOrder_Private_Void_GuestGroupController_0;

		// Token: 0x04002058 RID: 8280
		private static readonly IntPtr NativeMethodInfoPtr_PlayEvaluateSFX_Private_Void_EvaluationResult_0;

		// Token: 0x04002059 RID: 8281
		private static readonly IntPtr NativeMethodInfoPtr_PlayEvaluateSFXExtern_Public_Void_EvaluationResult_0;

		// Token: 0x0400205A RID: 8282
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOrder_Public_Void_GuestGroupController_Boolean_Action_0;

		// Token: 0x0400205B RID: 8283
		private static readonly IntPtr NativeMethodInfoPtr_EvaulateManualOrder_Private_Void_GuestGroupController_Action_1_EvaluationResult_0;

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeMethodInfoPtr_EvaluationTrans_Private_EvaluationResult_Int32_0;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeMethodInfoPtr_StartPassionGenerationSession_Private_Void_Single_Int32_GuestGroupController_0;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Private_Void_Int32_Int32_Single_Int32_Boolean_Action_1_GuestGroupController_GuestGroupController_0;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeMethodInfoPtr_PlayGuestEatSFX_Private_Void_0;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeMethodInfoPtr_LackMoneyEvaluate_Private_Void_GuestGroupController_Boolean_0;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeMethodInfoPtr_AddToPatientCountdown_Private_Void_GuestGroupController_Action_1_GuestGroupController_0;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromPatientCountdown_Private_Void_GuestGroupController_0;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTick_Private_Void_0;

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeMethodInfoPtr_GetSeatable_Public_List_1_Int32_Int32_0;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDelayed_Public_Void_Single_Action_Func_1_Boolean_0;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr_TryCloseCurrentDialogBox_Public_Void_GuestGroupController_0;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeMethodInfoPtr_LeaveFromDesk_Private_Void_GuestGroupController_LeaveType_Action_Boolean_0;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndSendFromQueue_Public_Void_0;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeMethodInfoPtr_PayAndLeave_Public_Void_GuestGroupController_Boolean_0;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr_GuestPay_Public_Void_GuestGroupController_Boolean_0;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeMethodInfoPtr_PlayPayAudio_Private_Void_0;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr_PayByMood_Public_Void_GuestGroupController_0;

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeMethodInfoPtr_PatientDepletedLeave_Private_Void_GuestGroupController_0;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeMethodInfoPtr_ExBadLeave_Private_Void_GuestGroupController_0;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr_RepellAndLeavePay_Public_Void_GuestGroupController_LeaveType_Boolean_0;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr_RepellAndLeaveNoPay_Public_Void_GuestGroupController_LeaveType_Boolean_0;

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeMethodInfoPtr_PlayerRepell_Public_Void_Int32_0;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeMethodInfoPtr_FlyCharaRepell_Public_Void_GuestGroupController_0;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr_RepellInternal_Private_Void_GuestGroupController_byref_Boolean_LeaveType_Boolean_0;

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002077 RID: 8311
		private static readonly IntPtr NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_0_Private_Boolean_KeyValuePair_2_Int32_Int32_0;

		// Token: 0x04002078 RID: 8312
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__106_0_Private_Void_Int32_0;

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeMethodInfoPtr__TryCloseIzakaya_b__127_0_Private_IEnumerator_0;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_1_Private_Boolean_0;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr__OnWaitForAllGuestDisAppear_b__133_0_Private_Boolean_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr__SpawnGuest_b__144_0_Private_Void_GuestGroupController_0;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0;

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_1;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTick_b__186_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000826 RID: 2086
		public enum GuestType
		{
			// Token: 0x04006E0E RID: 28174
			Normal,
			// Token: 0x04006E0F RID: 28175
			Special
		}

		// Token: 0x02000827 RID: 2087
		public enum IzakayaCloseType
		{
			// Token: 0x04006E11 RID: 28177
			General,
			// Token: 0x04006E12 RID: 28178
			Challenge,
			// Token: 0x04006E13 RID: 28179
			Tutorial
		}

		// Token: 0x02000828 RID: 2088
		public class TimedEvent : Il2CppSystem.Object
		{
			// Token: 0x0600AA60 RID: 43616 RVA: 0x002C1C58 File Offset: 0x002BFE58
			// Note: this type is marked as 'beforefieldinit'.
			static TimedEvent()
			{
				Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "TimedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr);
				GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr, "onTimingEndCallback");
				GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingUpdatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr, "onTimingUpdatedCallback");
				GuestsManager.TimedEvent.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr, "time");
				GuestsManager.TimedEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr, 100671796);
				GuestsManager.TimedEvent.NativeMethodInfoPtr_UpdateTime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr, 100671797);
			}

			// Token: 0x0600AA61 RID: 43617 RVA: 0x002C1CE8 File Offset: 0x002BFEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105696, XrefRangeEnd = 105699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimedEvent(int time, Action onTimingUpdatedCallback, Action onTimingEndCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.TimedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref time;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTimingUpdatedCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTimingEndCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.TimedEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AA62 RID: 43618 RVA: 0x002C1D54 File Offset: 0x002BFF54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 105699, RefRangeEnd = 105700, XrefRangeStart = 105699, XrefRangeEnd = 105699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool UpdateTime()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.TimedEvent.NativeMethodInfoPtr_UpdateTime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AA63 RID: 43619 RVA: 0x0005BDD7 File Offset: 0x00059FD7
			public TimedEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037EB RID: 14315
			// (get) Token: 0x0600AA64 RID: 43620 RVA: 0x002C1D90 File Offset: 0x002BFF90
			// (set) Token: 0x0600AA65 RID: 43621 RVA: 0x0005BDE0 File Offset: 0x00059FE0
			public unsafe Action onTimingEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037EC RID: 14316
			// (get) Token: 0x0600AA66 RID: 43622 RVA: 0x002C1DC0 File Offset: 0x002BFFC0
			// (set) Token: 0x0600AA67 RID: 43623 RVA: 0x0005BDFF File Offset: 0x00059FFF
			public unsafe Action onTimingUpdatedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingUpdatedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_onTimingUpdatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037ED RID: 14317
			// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x002C1DF0 File Offset: 0x002BFFF0
			// (set) Token: 0x0600AA69 RID: 43625 RVA: 0x0005BE1E File Offset: 0x0005A01E
			public unsafe int time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.TimedEvent.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04006E14 RID: 28180
			private static readonly IntPtr NativeFieldInfoPtr_onTimingEndCallback;

			// Token: 0x04006E15 RID: 28181
			private static readonly IntPtr NativeFieldInfoPtr_onTimingUpdatedCallback;

			// Token: 0x04006E16 RID: 28182
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04006E17 RID: 28183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Action_Action_0;

			// Token: 0x04006E18 RID: 28184
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Public_Boolean_0;
		}

		// Token: 0x02000829 RID: 2089
		public enum OrderGenerationResult
		{
			// Token: 0x04006E1A RID: 28186
			Succeed,
			// Token: 0x04006E1B RID: 28187
			OrderCountDepleted,
			// Token: 0x04006E1C RID: 28188
			NoMoney,
			// Token: 0x04006E1D RID: 28189
			ExceedEndurance,
			// Token: 0x04006E1E RID: 28190
			NotContinue
		}

		// Token: 0x0200082A RID: 2090
		public class OrderBase : Il2CppSystem.Object
		{
			// Token: 0x0600AA6A RID: 43626 RVA: 0x002C1E18 File Offset: 0x002C0018
			// Note: this type is marked as 'beforefieldinit'.
			static OrderBase()
			{
				Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "OrderBase");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr);
				GuestsManager.OrderBase.NativeFieldInfoPtr_beverageRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "beverageRequest");
				GuestsManager.OrderBase.NativeFieldInfoPtr_foodRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "foodRequest");
				GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedBeverageInAir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "m_ServedBeverageInAir");
				GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedFoodInAir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "m_ServedFoodInAir");
				GuestsManager.OrderBase.NativeFieldInfoPtr_servBeverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "servBeverage");
				GuestsManager.OrderBase.NativeFieldInfoPtr_servFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "servFood");
				GuestsManager.OrderBase.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<Type>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__OnUpdateServeDataVisualCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<OnUpdateServeDataVisualCallback>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__DeskCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<DeskCode>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__ManualOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<ManualOrder>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__FreeOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<FreeOrder>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__HiddenPic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<HiddenPic>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__FoodSender_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<FoodSender>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__BevSender_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<BevSender>k__BackingField");
				GuestsManager.OrderBase.NativeFieldInfoPtr__NotShowInUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, "<NotShowInUI>k__BackingField");
				GuestsManager.OrderBase.NativeMethodInfoPtr__ctor_Public_Void_OrderType_Int32_Int32_Int32_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671798);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_Type_Public_get_OrderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671799);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServFood_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671800);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServFood_Public_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671801);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServBeverage_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671802);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServBeverage_Public_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671803);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_OnUpdateServeDataVisualCallback_Private_get_Action_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671804);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_OnUpdateServeDataVisualCallback_Public_set_Void_Action_2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671805);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_Price_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671806);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_DeskCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671807);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_IsFullfilled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671808);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_ManualOrder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671809);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_ManualOrder_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671810);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_FreeOrder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671811);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_FreeOrder_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671812);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServedFoodInAir_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671813);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServedFoodInAir_Public_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671814);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServedBeverageInAir_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671815);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServedBeverageInAir_Public_set_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671816);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_HiddenPic_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671817);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_HiddenPic_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671818);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_FoodSender_Public_get_SenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671819);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_FoodSender_Public_set_Void_SenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671820);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_BevSender_Public_get_SenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671821);
				GuestsManager.OrderBase.NativeMethodInfoPtr_set_BevSender_Public_set_Void_SenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671822);
				GuestsManager.OrderBase.NativeMethodInfoPtr_get_NotShowInUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671823);
				GuestsManager.OrderBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr, 100671824);
			}

			// Token: 0x0600AA6B RID: 43627 RVA: 0x002C218C File Offset: 0x002C038C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105700, XrefRangeEnd = 105702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrderBase(GuestsManager.OrderBase.OrderType orderType, int requestFood, int requestBev, int deskCode, bool notShowInUI, bool freeOrder, Sprite hiddenPic = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.OrderBase>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref orderType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestFood;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestBev;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notShowInUI;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref freeOrder;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hiddenPic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr__ctor_Public_Void_OrderType_Int32_Int32_Int32_Boolean_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037FD RID: 14333
			// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x002C222C File Offset: 0x002C042C
			public unsafe GuestsManager.OrderBase.OrderType Type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_Type_Public_get_OrderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170037FE RID: 14334
			// (get) Token: 0x0600AA6D RID: 43629 RVA: 0x002C2268 File Offset: 0x002C0468
			// (set) Token: 0x0600AA6E RID: 43630 RVA: 0x002C22A8 File Offset: 0x002C04A8
			public unsafe Sellable ServFood
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServFood_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 105704, RefRangeEnd = 105710, XrefRangeStart = 105702, XrefRangeEnd = 105704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServFood_Public_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170037FF RID: 14335
			// (get) Token: 0x0600AA6F RID: 43631 RVA: 0x002C22EC File Offset: 0x002C04EC
			// (set) Token: 0x0600AA70 RID: 43632 RVA: 0x002C232C File Offset: 0x002C052C
			public unsafe Sellable ServBeverage
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServBeverage_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 105712, RefRangeEnd = 105718, XrefRangeStart = 105710, XrefRangeEnd = 105712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServBeverage_Public_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003800 RID: 14336
			// (get) Token: 0x0600AA71 RID: 43633 RVA: 0x002C2370 File Offset: 0x002C0570
			// (set) Token: 0x0600AA72 RID: 43634 RVA: 0x002C23B0 File Offset: 0x002C05B0
			public unsafe Action<bool, bool> OnUpdateServeDataVisualCallback
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_OnUpdateServeDataVisualCallback_Private_get_Action_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105718, XrefRangeEnd = 105719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_OnUpdateServeDataVisualCallback_Public_set_Void_Action_2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003801 RID: 14337
			// (get) Token: 0x0600AA73 RID: 43635 RVA: 0x002C23F4 File Offset: 0x002C05F4
			public unsafe int Price
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 105721, RefRangeEnd = 105723, XrefRangeStart = 105719, XrefRangeEnd = 105721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_Price_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003802 RID: 14338
			// (get) Token: 0x0600AA74 RID: 43636 RVA: 0x002C2430 File Offset: 0x002C0630
			public unsafe int DeskCode
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 105723, RefRangeEnd = 105726, XrefRangeStart = 105723, XrefRangeEnd = 105723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_DeskCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003803 RID: 14339
			// (get) Token: 0x0600AA75 RID: 43637 RVA: 0x002C246C File Offset: 0x002C066C
			public unsafe bool IsFullfilled
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 105726, RefRangeEnd = 105738, XrefRangeStart = 105726, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_IsFullfilled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003804 RID: 14340
			// (get) Token: 0x0600AA76 RID: 43638 RVA: 0x002C24A8 File Offset: 0x002C06A8
			// (set) Token: 0x0600AA77 RID: 43639 RVA: 0x002C24E4 File Offset: 0x002C06E4
			public unsafe bool ManualOrder
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_ManualOrder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_ManualOrder_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003805 RID: 14341
			// (get) Token: 0x0600AA78 RID: 43640 RVA: 0x002C2524 File Offset: 0x002C0724
			// (set) Token: 0x0600AA79 RID: 43641 RVA: 0x002C2560 File Offset: 0x002C0760
			public unsafe bool FreeOrder
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_FreeOrder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_FreeOrder_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003806 RID: 14342
			// (get) Token: 0x0600AA7A RID: 43642 RVA: 0x002C25A0 File Offset: 0x002C07A0
			// (set) Token: 0x0600AA7B RID: 43643 RVA: 0x002C25E0 File Offset: 0x002C07E0
			public unsafe Sellable ServedFoodInAir
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServedFoodInAir_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 105740, RefRangeEnd = 105745, XrefRangeStart = 105738, XrefRangeEnd = 105740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServedFoodInAir_Public_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003807 RID: 14343
			// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x002C2624 File Offset: 0x002C0824
			// (set) Token: 0x0600AA7D RID: 43645 RVA: 0x002C2664 File Offset: 0x002C0864
			public unsafe Sellable ServedBeverageInAir
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_ServedBeverageInAir_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 105747, RefRangeEnd = 105752, XrefRangeStart = 105745, XrefRangeEnd = 105747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_ServedBeverageInAir_Public_set_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003808 RID: 14344
			// (get) Token: 0x0600AA7E RID: 43646 RVA: 0x002C26A8 File Offset: 0x002C08A8
			// (set) Token: 0x0600AA7F RID: 43647 RVA: 0x002C26E8 File Offset: 0x002C08E8
			public unsafe Sprite HiddenPic
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_HiddenPic_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105752, XrefRangeEnd = 105753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_HiddenPic_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003809 RID: 14345
			// (get) Token: 0x0600AA80 RID: 43648 RVA: 0x002C272C File Offset: 0x002C092C
			// (set) Token: 0x0600AA81 RID: 43649 RVA: 0x002C2768 File Offset: 0x002C0968
			public unsafe GuestsManager.OrderBase.SenderType FoodSender
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 86389, RefRangeEnd = 86391, XrefRangeStart = 86389, XrefRangeEnd = 86391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_FoodSender_Public_get_SenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 105753, RefRangeEnd = 105754, XrefRangeStart = 105753, XrefRangeEnd = 105753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_FoodSender_Public_set_Void_SenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700380A RID: 14346
			// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x002C27A8 File Offset: 0x002C09A8
			// (set) Token: 0x0600AA83 RID: 43651 RVA: 0x002C27E4 File Offset: 0x002C09E4
			public unsafe GuestsManager.OrderBase.SenderType BevSender
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_BevSender_Public_get_SenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 86385, RefRangeEnd = 86389, XrefRangeStart = 86385, XrefRangeEnd = 86389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_set_BevSender_Public_set_Void_SenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700380B RID: 14347
			// (get) Token: 0x0600AA84 RID: 43652 RVA: 0x002C2824 File Offset: 0x002C0A24
			public unsafe bool NotShowInUI
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderBase.NativeMethodInfoPtr_get_NotShowInUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AA85 RID: 43653 RVA: 0x002C2860 File Offset: 0x002C0A60
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 105818, RefRangeEnd = 105820, XrefRangeStart = 105754, XrefRangeEnd = 105818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.OrderBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AA86 RID: 43654 RVA: 0x0005BE39 File Offset: 0x0005A039
			public OrderBase(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037EE RID: 14318
			// (get) Token: 0x0600AA87 RID: 43655 RVA: 0x002C28A4 File Offset: 0x002C0AA4
			// (set) Token: 0x0600AA88 RID: 43656 RVA: 0x0005BE42 File Offset: 0x0005A042
			public unsafe int beverageRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_beverageRequest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_beverageRequest)) = value;
				}
			}

			// Token: 0x170037EF RID: 14319
			// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x002C28CC File Offset: 0x002C0ACC
			// (set) Token: 0x0600AA8A RID: 43658 RVA: 0x0005BE5D File Offset: 0x0005A05D
			public unsafe int foodRequest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_foodRequest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_foodRequest)) = value;
				}
			}

			// Token: 0x170037F0 RID: 14320
			// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x002C28F4 File Offset: 0x002C0AF4
			// (set) Token: 0x0600AA8C RID: 43660 RVA: 0x0005BE78 File Offset: 0x0005A078
			public unsafe Sellable m_ServedBeverageInAir
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedBeverageInAir);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedBeverageInAir), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F1 RID: 14321
			// (get) Token: 0x0600AA8D RID: 43661 RVA: 0x002C2924 File Offset: 0x002C0B24
			// (set) Token: 0x0600AA8E RID: 43662 RVA: 0x0005BE97 File Offset: 0x0005A097
			public unsafe Sellable m_ServedFoodInAir
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedFoodInAir);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_m_ServedFoodInAir), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F2 RID: 14322
			// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x002C2954 File Offset: 0x002C0B54
			// (set) Token: 0x0600AA90 RID: 43664 RVA: 0x0005BEB6 File Offset: 0x0005A0B6
			public unsafe Sellable servBeverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_servBeverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_servBeverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F3 RID: 14323
			// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x002C2984 File Offset: 0x002C0B84
			// (set) Token: 0x0600AA92 RID: 43666 RVA: 0x0005BED5 File Offset: 0x0005A0D5
			public unsafe Sellable servFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_servFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr_servFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F4 RID: 14324
			// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x002C29B4 File Offset: 0x002C0BB4
			// (set) Token: 0x0600AA94 RID: 43668 RVA: 0x0005BEF4 File Offset: 0x0005A0F4
			public unsafe GuestsManager.OrderBase.OrderType _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__Type_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__Type_k__BackingField)) = value;
				}
			}

			// Token: 0x170037F5 RID: 14325
			// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x002C29DC File Offset: 0x002C0BDC
			// (set) Token: 0x0600AA96 RID: 43670 RVA: 0x0005BF0F File Offset: 0x0005A10F
			public unsafe Action<bool, bool> _OnUpdateServeDataVisualCallback_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__OnUpdateServeDataVisualCallback_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__OnUpdateServeDataVisualCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037F6 RID: 14326
			// (get) Token: 0x0600AA97 RID: 43671 RVA: 0x002C2A0C File Offset: 0x002C0C0C
			// (set) Token: 0x0600AA98 RID: 43672 RVA: 0x0005BF2E File Offset: 0x0005A12E
			public unsafe int _DeskCode_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__DeskCode_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__DeskCode_k__BackingField)) = value;
				}
			}

			// Token: 0x170037F7 RID: 14327
			// (get) Token: 0x0600AA99 RID: 43673 RVA: 0x002C2A34 File Offset: 0x002C0C34
			// (set) Token: 0x0600AA9A RID: 43674 RVA: 0x0005BF49 File Offset: 0x0005A149
			public unsafe bool _ManualOrder_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__ManualOrder_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__ManualOrder_k__BackingField)) = value;
				}
			}

			// Token: 0x170037F8 RID: 14328
			// (get) Token: 0x0600AA9B RID: 43675 RVA: 0x002C2A5C File Offset: 0x002C0C5C
			// (set) Token: 0x0600AA9C RID: 43676 RVA: 0x0005BF64 File Offset: 0x0005A164
			public unsafe bool _FreeOrder_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__FreeOrder_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__FreeOrder_k__BackingField)) = value;
				}
			}

			// Token: 0x170037F9 RID: 14329
			// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x002C2A84 File Offset: 0x002C0C84
			// (set) Token: 0x0600AA9E RID: 43678 RVA: 0x0005BF7F File Offset: 0x0005A17F
			public unsafe Sprite _HiddenPic_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__HiddenPic_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__HiddenPic_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037FA RID: 14330
			// (get) Token: 0x0600AA9F RID: 43679 RVA: 0x002C2AB4 File Offset: 0x002C0CB4
			// (set) Token: 0x0600AAA0 RID: 43680 RVA: 0x0005BF9E File Offset: 0x0005A19E
			public unsafe GuestsManager.OrderBase.SenderType _FoodSender_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__FoodSender_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__FoodSender_k__BackingField)) = value;
				}
			}

			// Token: 0x170037FB RID: 14331
			// (get) Token: 0x0600AAA1 RID: 43681 RVA: 0x002C2ADC File Offset: 0x002C0CDC
			// (set) Token: 0x0600AAA2 RID: 43682 RVA: 0x0005BFB9 File Offset: 0x0005A1B9
			public unsafe GuestsManager.OrderBase.SenderType _BevSender_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__BevSender_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__BevSender_k__BackingField)) = value;
				}
			}

			// Token: 0x170037FC RID: 14332
			// (get) Token: 0x0600AAA3 RID: 43683 RVA: 0x002C2B04 File Offset: 0x002C0D04
			// (set) Token: 0x0600AAA4 RID: 43684 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
			public unsafe bool _NotShowInUI_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__NotShowInUI_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderBase.NativeFieldInfoPtr__NotShowInUI_k__BackingField)) = value;
				}
			}

			// Token: 0x04006E1F RID: 28191
			private static readonly IntPtr NativeFieldInfoPtr_beverageRequest;

			// Token: 0x04006E20 RID: 28192
			private static readonly IntPtr NativeFieldInfoPtr_foodRequest;

			// Token: 0x04006E21 RID: 28193
			private static readonly IntPtr NativeFieldInfoPtr_m_ServedBeverageInAir;

			// Token: 0x04006E22 RID: 28194
			private static readonly IntPtr NativeFieldInfoPtr_m_ServedFoodInAir;

			// Token: 0x04006E23 RID: 28195
			private static readonly IntPtr NativeFieldInfoPtr_servBeverage;

			// Token: 0x04006E24 RID: 28196
			private static readonly IntPtr NativeFieldInfoPtr_servFood;

			// Token: 0x04006E25 RID: 28197
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x04006E26 RID: 28198
			private static readonly IntPtr NativeFieldInfoPtr__OnUpdateServeDataVisualCallback_k__BackingField;

			// Token: 0x04006E27 RID: 28199
			private static readonly IntPtr NativeFieldInfoPtr__DeskCode_k__BackingField;

			// Token: 0x04006E28 RID: 28200
			private static readonly IntPtr NativeFieldInfoPtr__ManualOrder_k__BackingField;

			// Token: 0x04006E29 RID: 28201
			private static readonly IntPtr NativeFieldInfoPtr__FreeOrder_k__BackingField;

			// Token: 0x04006E2A RID: 28202
			private static readonly IntPtr NativeFieldInfoPtr__HiddenPic_k__BackingField;

			// Token: 0x04006E2B RID: 28203
			private static readonly IntPtr NativeFieldInfoPtr__FoodSender_k__BackingField;

			// Token: 0x04006E2C RID: 28204
			private static readonly IntPtr NativeFieldInfoPtr__BevSender_k__BackingField;

			// Token: 0x04006E2D RID: 28205
			private static readonly IntPtr NativeFieldInfoPtr__NotShowInUI_k__BackingField;

			// Token: 0x04006E2E RID: 28206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OrderType_Int32_Int32_Int32_Boolean_Boolean_Sprite_0;

			// Token: 0x04006E2F RID: 28207
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_OrderType_0;

			// Token: 0x04006E30 RID: 28208
			private static readonly IntPtr NativeMethodInfoPtr_get_ServFood_Public_get_Sellable_0;

			// Token: 0x04006E31 RID: 28209
			private static readonly IntPtr NativeMethodInfoPtr_set_ServFood_Public_set_Void_Sellable_0;

			// Token: 0x04006E32 RID: 28210
			private static readonly IntPtr NativeMethodInfoPtr_get_ServBeverage_Public_get_Sellable_0;

			// Token: 0x04006E33 RID: 28211
			private static readonly IntPtr NativeMethodInfoPtr_set_ServBeverage_Public_set_Void_Sellable_0;

			// Token: 0x04006E34 RID: 28212
			private static readonly IntPtr NativeMethodInfoPtr_get_OnUpdateServeDataVisualCallback_Private_get_Action_2_Boolean_Boolean_0;

			// Token: 0x04006E35 RID: 28213
			private static readonly IntPtr NativeMethodInfoPtr_set_OnUpdateServeDataVisualCallback_Public_set_Void_Action_2_Boolean_Boolean_0;

			// Token: 0x04006E36 RID: 28214
			private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Int32_0;

			// Token: 0x04006E37 RID: 28215
			private static readonly IntPtr NativeMethodInfoPtr_get_DeskCode_Public_get_Int32_0;

			// Token: 0x04006E38 RID: 28216
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFullfilled_Public_get_Boolean_0;

			// Token: 0x04006E39 RID: 28217
			private static readonly IntPtr NativeMethodInfoPtr_get_ManualOrder_Public_get_Boolean_0;

			// Token: 0x04006E3A RID: 28218
			private static readonly IntPtr NativeMethodInfoPtr_set_ManualOrder_Public_set_Void_Boolean_0;

			// Token: 0x04006E3B RID: 28219
			private static readonly IntPtr NativeMethodInfoPtr_get_FreeOrder_Public_get_Boolean_0;

			// Token: 0x04006E3C RID: 28220
			private static readonly IntPtr NativeMethodInfoPtr_set_FreeOrder_Public_set_Void_Boolean_0;

			// Token: 0x04006E3D RID: 28221
			private static readonly IntPtr NativeMethodInfoPtr_get_ServedFoodInAir_Public_get_Sellable_0;

			// Token: 0x04006E3E RID: 28222
			private static readonly IntPtr NativeMethodInfoPtr_set_ServedFoodInAir_Public_set_Void_Sellable_0;

			// Token: 0x04006E3F RID: 28223
			private static readonly IntPtr NativeMethodInfoPtr_get_ServedBeverageInAir_Public_get_Sellable_0;

			// Token: 0x04006E40 RID: 28224
			private static readonly IntPtr NativeMethodInfoPtr_set_ServedBeverageInAir_Public_set_Void_Sellable_0;

			// Token: 0x04006E41 RID: 28225
			private static readonly IntPtr NativeMethodInfoPtr_get_HiddenPic_Public_get_Sprite_0;

			// Token: 0x04006E42 RID: 28226
			private static readonly IntPtr NativeMethodInfoPtr_set_HiddenPic_Public_set_Void_Sprite_0;

			// Token: 0x04006E43 RID: 28227
			private static readonly IntPtr NativeMethodInfoPtr_get_FoodSender_Public_get_SenderType_0;

			// Token: 0x04006E44 RID: 28228
			private static readonly IntPtr NativeMethodInfoPtr_set_FoodSender_Public_set_Void_SenderType_0;

			// Token: 0x04006E45 RID: 28229
			private static readonly IntPtr NativeMethodInfoPtr_get_BevSender_Public_get_SenderType_0;

			// Token: 0x04006E46 RID: 28230
			private static readonly IntPtr NativeMethodInfoPtr_set_BevSender_Public_set_Void_SenderType_0;

			// Token: 0x04006E47 RID: 28231
			private static readonly IntPtr NativeMethodInfoPtr_get_NotShowInUI_Public_get_Boolean_0;

			// Token: 0x04006E48 RID: 28232
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000FE1 RID: 4065
			public enum OrderType
			{
				// Token: 0x0400B056 RID: 45142
				Normal,
				// Token: 0x0400B057 RID: 45143
				Special
			}

			// Token: 0x02000FE2 RID: 4066
			public enum SenderType
			{
				// Token: 0x0400B059 RID: 45145
				Self,
				// Token: 0x0400B05A RID: 45146
				Partner,
				// Token: 0x0400B05B RID: 45147
				Boss
			}
		}

		// Token: 0x0200082B RID: 2091
		public class NormalOrder : GuestsManager.OrderBase
		{
			// Token: 0x0600AAA5 RID: 43685 RVA: 0x002C2B2C File Offset: 0x002C0D2C
			// Note: this type is marked as 'beforefieldinit'.
			static NormalOrder()
			{
				Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "NormalOrder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr);
				GuestsManager.NormalOrder.NativeFieldInfoPtr__Guest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, "<Guest>k__BackingField");
				GuestsManager.NormalOrder.NativeMethodInfoPtr__ctor_Public_Void_GuestBase_Int32_Int32_Int32_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671825);
				GuestsManager.NormalOrder.NativeMethodInfoPtr_get_Guest_Public_get_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671826);
				GuestsManager.NormalOrder.NativeMethodInfoPtr_set_Guest_Public_set_Void_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671827);
				GuestsManager.NormalOrder.NativeMethodInfoPtr_get_RequestFood_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671828);
				GuestsManager.NormalOrder.NativeMethodInfoPtr_get_RequestBeverage_Public_get_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671829);
				GuestsManager.NormalOrder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr, 100671830);
			}

			// Token: 0x0600AAA6 RID: 43686 RVA: 0x002C2BE4 File Offset: 0x002C0DE4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 105823, RefRangeEnd = 105830, XrefRangeStart = 105820, XrefRangeEnd = 105823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NormalOrder(GuestBase guest, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, Sprite hiddenPic = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.NormalOrder>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestFoodId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestBevId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notShowInUI;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hiddenPic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NormalOrder.NativeMethodInfoPtr__ctor_Public_Void_GuestBase_Int32_Int32_Int32_Boolean_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700380D RID: 14349
			// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x002C2C88 File Offset: 0x002C0E88
			// (set) Token: 0x0600AAA8 RID: 43688 RVA: 0x002C2CC8 File Offset: 0x002C0EC8
			public unsafe GuestBase Guest
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NormalOrder.NativeMethodInfoPtr_get_Guest_Public_get_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestBase>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NormalOrder.NativeMethodInfoPtr_set_Guest_Public_set_Void_GuestBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700380E RID: 14350
			// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x002C2D0C File Offset: 0x002C0F0C
			public unsafe Sellable RequestFood
			{
				[CallerCount(30)]
				[CachedScanResults(RefRangeStart = 105831, RefRangeEnd = 105861, XrefRangeStart = 105830, XrefRangeEnd = 105831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NormalOrder.NativeMethodInfoPtr_get_RequestFood_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
			}

			// Token: 0x1700380F RID: 14351
			// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x002C2D4C File Offset: 0x002C0F4C
			public unsafe Sellable RequestBeverage
			{
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 105862, RefRangeEnd = 105880, XrefRangeStart = 105861, XrefRangeEnd = 105862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.NormalOrder.NativeMethodInfoPtr_get_RequestBeverage_Public_get_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
				}
			}

			// Token: 0x0600AAAB RID: 43691 RVA: 0x002C2D8C File Offset: 0x002C0F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105880, XrefRangeEnd = 105934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.NormalOrder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AAAC RID: 43692 RVA: 0x0005BFEF File Offset: 0x0005A1EF
			public NormalOrder(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700380C RID: 14348
			// (get) Token: 0x0600AAAD RID: 43693 RVA: 0x002C2DD0 File Offset: 0x002C0FD0
			// (set) Token: 0x0600AAAE RID: 43694 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
			public unsafe GuestBase _Guest_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NormalOrder.NativeFieldInfoPtr__Guest_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.NormalOrder.NativeFieldInfoPtr__Guest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E49 RID: 28233
			private static readonly IntPtr NativeFieldInfoPtr__Guest_k__BackingField;

			// Token: 0x04006E4A RID: 28234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuestBase_Int32_Int32_Int32_Boolean_Boolean_Sprite_0;

			// Token: 0x04006E4B RID: 28235
			private static readonly IntPtr NativeMethodInfoPtr_get_Guest_Public_get_GuestBase_0;

			// Token: 0x04006E4C RID: 28236
			private static readonly IntPtr NativeMethodInfoPtr_set_Guest_Public_set_Void_GuestBase_0;

			// Token: 0x04006E4D RID: 28237
			private static readonly IntPtr NativeMethodInfoPtr_get_RequestFood_Public_get_Sellable_0;

			// Token: 0x04006E4E RID: 28238
			private static readonly IntPtr NativeMethodInfoPtr_get_RequestBeverage_Public_get_Sellable_0;

			// Token: 0x04006E4F RID: 28239
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x0200082C RID: 2092
		public class SpecialOrder : GuestsManager.OrderBase
		{
			// Token: 0x0600AAAF RID: 43695 RVA: 0x002C2E00 File Offset: 0x002C1000
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialOrder()
			{
				Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "SpecialOrder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr);
				GuestsManager.SpecialOrder.NativeFieldInfoPtr__SpecialGuests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, "<SpecialGuests>k__BackingField");
				GuestsManager.SpecialOrder.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Int32_Int32_Int32_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, 100671831);
				GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_RequestFoodTag_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, 100671832);
				GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_RequestBeverageTag_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, 100671833);
				GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_SpecialGuests_Public_get_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, 100671834);
				GuestsManager.SpecialOrder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr, 100671835);
			}

			// Token: 0x0600AAB0 RID: 43696 RVA: 0x002C2EA4 File Offset: 0x002C10A4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105937, RefRangeEnd = 105940, XrefRangeStart = 105934, XrefRangeEnd = 105937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialOrder(SpecialGuest specialGuests, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, Sprite hiddenPic = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.SpecialOrder>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuests);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestFoodTag;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestBevTag;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notShowInUI;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hiddenPic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.SpecialOrder.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Int32_Int32_Int32_Boolean_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003811 RID: 14353
			// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x002C2F48 File Offset: 0x002C1148
			public unsafe int RequestFoodTag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_RequestFoodTag_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003812 RID: 14354
			// (get) Token: 0x0600AAB2 RID: 43698 RVA: 0x002C2F84 File Offset: 0x002C1184
			public unsafe int RequestBeverageTag
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_RequestBeverageTag_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003813 RID: 14355
			// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x002C2FC0 File Offset: 0x002C11C0
			public unsafe SpecialGuest SpecialGuests
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.SpecialOrder.NativeMethodInfoPtr_get_SpecialGuests_Public_get_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
				}
			}

			// Token: 0x0600AAB4 RID: 43700 RVA: 0x002C3000 File Offset: 0x002C1200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105940, XrefRangeEnd = 105987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.SpecialOrder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AAB5 RID: 43701 RVA: 0x0005C017 File Offset: 0x0005A217
			public SpecialOrder(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003810 RID: 14352
			// (get) Token: 0x0600AAB6 RID: 43702 RVA: 0x002C3044 File Offset: 0x002C1244
			// (set) Token: 0x0600AAB7 RID: 43703 RVA: 0x0005C020 File Offset: 0x0005A220
			public unsafe SpecialGuest _SpecialGuests_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.SpecialOrder.NativeFieldInfoPtr__SpecialGuests_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.SpecialOrder.NativeFieldInfoPtr__SpecialGuests_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E50 RID: 28240
			private static readonly IntPtr NativeFieldInfoPtr__SpecialGuests_k__BackingField;

			// Token: 0x04006E51 RID: 28241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Int32_Int32_Int32_Boolean_Boolean_Sprite_0;

			// Token: 0x04006E52 RID: 28242
			private static readonly IntPtr NativeMethodInfoPtr_get_RequestFoodTag_Public_get_Int32_0;

			// Token: 0x04006E53 RID: 28243
			private static readonly IntPtr NativeMethodInfoPtr_get_RequestBeverageTag_Public_get_Int32_0;

			// Token: 0x04006E54 RID: 28244
			private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuests_Public_get_SpecialGuest_0;

			// Token: 0x04006E55 RID: 28245
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x0200082D RID: 2093
		public class OrderProperty : Il2CppSystem.Object
		{
			// Token: 0x0600AAB8 RID: 43704 RVA: 0x002C3074 File Offset: 0x002C1274
			// Note: this type is marked as 'beforefieldinit'.
			static OrderProperty()
			{
				Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "OrderProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr);
				GuestsManager.OrderProperty.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, "Source");
				GuestsManager.OrderProperty.NativeFieldInfoPtr_SourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, "SourceLabel");
				GuestsManager.OrderProperty.NativeFieldInfoPtr__IsFree_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, "<IsFree>k__BackingField");
				GuestsManager.OrderProperty.NativeMethodInfoPtr__ctor_Public_Void_OrderSource_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, 100671836);
				GuestsManager.OrderProperty.NativeMethodInfoPtr_get_IsFree_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, 100671837);
				GuestsManager.OrderProperty.NativeMethodInfoPtr_set_IsFree_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, 100671838);
				GuestsManager.OrderProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr, 100671839);
			}

			// Token: 0x0600AAB9 RID: 43705 RVA: 0x002C312C File Offset: 0x002C132C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 105989, RefRangeEnd = 105991, XrefRangeStart = 105987, XrefRangeEnd = 105989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrderProperty(GuestsManager.OrderProperty.OrderSource source, string sourceLabel, bool isFree) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.OrderProperty>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref source;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceLabel);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderProperty.NativeMethodInfoPtr__ctor_Public_Void_OrderSource_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003817 RID: 14359
			// (get) Token: 0x0600AABA RID: 43706 RVA: 0x002C3194 File Offset: 0x002C1394
			// (set) Token: 0x0600AABB RID: 43707 RVA: 0x002C31D0 File Offset: 0x002C13D0
			public unsafe bool IsFree
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderProperty.NativeMethodInfoPtr_get_IsFree_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 105991, RefRangeEnd = 105993, XrefRangeStart = 105991, XrefRangeEnd = 105991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.OrderProperty.NativeMethodInfoPtr_set_IsFree_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AABC RID: 43708 RVA: 0x002C3210 File Offset: 0x002C1410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105993, XrefRangeEnd = 106023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestsManager.OrderProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AABD RID: 43709 RVA: 0x0005C03F File Offset: 0x0005A23F
			public OrderProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003814 RID: 14356
			// (get) Token: 0x0600AABE RID: 43710 RVA: 0x002C3254 File Offset: 0x002C1454
			// (set) Token: 0x0600AABF RID: 43711 RVA: 0x0005C048 File Offset: 0x0005A248
			public unsafe GuestsManager.OrderProperty.OrderSource Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr_Source);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr_Source)) = value;
				}
			}

			// Token: 0x17003815 RID: 14357
			// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x002C327C File Offset: 0x002C147C
			// (set) Token: 0x0600AAC1 RID: 43713 RVA: 0x0005C063 File Offset: 0x0005A263
			public unsafe string SourceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr_SourceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr_SourceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003816 RID: 14358
			// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x002C32A4 File Offset: 0x002C14A4
			// (set) Token: 0x0600AAC3 RID: 43715 RVA: 0x0005C082 File Offset: 0x0005A282
			public unsafe bool _IsFree_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr__IsFree_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.OrderProperty.NativeFieldInfoPtr__IsFree_k__BackingField)) = value;
				}
			}

			// Token: 0x04006E56 RID: 28246
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04006E57 RID: 28247
			private static readonly IntPtr NativeFieldInfoPtr_SourceLabel;

			// Token: 0x04006E58 RID: 28248
			private static readonly IntPtr NativeFieldInfoPtr__IsFree_k__BackingField;

			// Token: 0x04006E59 RID: 28249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OrderSource_String_Boolean_0;

			// Token: 0x04006E5A RID: 28250
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFree_Public_get_Boolean_0;

			// Token: 0x04006E5B RID: 28251
			private static readonly IntPtr NativeMethodInfoPtr_set_IsFree_Public_set_Void_Boolean_0;

			// Token: 0x04006E5C RID: 28252
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000FE3 RID: 4067
			public enum OrderSource
			{
				// Token: 0x0400B05D RID: 45149
				Base,
				// Token: 0x0400B05E RID: 45150
				Extra
			}
		}

		// Token: 0x0200082E RID: 2094
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600AAC4 RID: 43716 RVA: 0x002C32CC File Offset: 0x002C14CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr);
				GuestsManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9");
				GuestsManager.__c.NativeFieldInfoPtr___9__94_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__94_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__94_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__94_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__105_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__105_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__105_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__105_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__105_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__105_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__105_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__105_3");
				GuestsManager.__c.NativeFieldInfoPtr___9__107_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__107_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__107_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__107_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__107_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__107_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__123_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__123_3");
				GuestsManager.__c.NativeFieldInfoPtr___9__123_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__123_4");
				GuestsManager.__c.NativeFieldInfoPtr___9__123_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__123_5");
				GuestsManager.__c.NativeFieldInfoPtr___9__124_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__124_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__124_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__124_3");
				GuestsManager.__c.NativeFieldInfoPtr___9__124_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__124_7");
				GuestsManager.__c.NativeFieldInfoPtr___9__124_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__124_9");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_4");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_5");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_6");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_7");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_8");
				GuestsManager.__c.NativeFieldInfoPtr___9__128_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__128_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_3");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_4");
				GuestsManager.__c.NativeFieldInfoPtr___9__130_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__130_5");
				GuestsManager.__c.NativeFieldInfoPtr___9__131_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__131_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__131_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__131_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__131_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__131_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__131_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__131_3");
				GuestsManager.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__132_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__134_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__134_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__138_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__138_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__159_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__159_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__169_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__169_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__171_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__171_4");
				GuestsManager.__c.NativeFieldInfoPtr___9__171_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__171_5");
				GuestsManager.__c.NativeFieldInfoPtr___9__171_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__171_6");
				GuestsManager.__c.NativeFieldInfoPtr___9__187_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__187_1");
				GuestsManager.__c.NativeFieldInfoPtr___9__197_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__197_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__209_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__209_0");
				GuestsManager.__c.NativeFieldInfoPtr___9__209_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__209_2");
				GuestsManager.__c.NativeFieldInfoPtr___9__209_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, "<>9__209_3");
				GuestsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671841);
				GuestsManager.__c.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671842);
				GuestsManager.__c.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671843);
				GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_0_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671844);
				GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671845);
				GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_2_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671846);
				GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_3_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671847);
				GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_0_Internal_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671848);
				GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_1_Internal_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671849);
				GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_2_Internal_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671850);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_3_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671851);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_4_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671852);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671853);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_2_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671854);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_3_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671855);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_7_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671856);
				GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671857);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_4_Internal_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671858);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671859);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671860);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671861);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671862);
				GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671863);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671864);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_1_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671865);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_2_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671866);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_3_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671867);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671868);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_5_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671869);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671870);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_1_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671871);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_2_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671872);
				GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_3_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671873);
				GuestsManager.__c.NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671874);
				GuestsManager.__c.NativeMethodInfoPtr__OnWaitForAllGuestToLeaveForRogueLike_b__134_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671875);
				GuestsManager.__c.NativeMethodInfoPtr__OnIdleDialog_b__138_0_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671876);
				GuestsManager.__c.NativeMethodInfoPtr__PostInitializeGuestGroup_b__159_0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671877);
				GuestsManager.__c.NativeMethodInfoPtr__SetManualControlledLeave_b__169_0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671878);
				GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_4_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671879);
				GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_5_Internal_Int32_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671880);
				GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_6_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671881);
				GuestsManager.__c.NativeMethodInfoPtr__GetSeatable_b__187_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671882);
				GuestsManager.__c.NativeMethodInfoPtr__LeaveFromDesk_b__197_0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671883);
				GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671884);
				GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_2_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671885);
				GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_3_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr, 100671886);
			}

			// Token: 0x0600AAC5 RID: 43717 RVA: 0x002C3A28 File Offset: 0x002C1C28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAC6 RID: 43718 RVA: 0x002C3A64 File Offset: 0x002C1C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106023, XrefRangeEnd = 106024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_TrueAvailableDesks_b__94_1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAC7 RID: 43719 RVA: 0x002C3AB8 File Offset: 0x002C1CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106024, XrefRangeEnd = 106025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_TrueAvailableDesks_b__94_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAC8 RID: 43720 RVA: 0x002C3B0C File Offset: 0x002C1D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106025, XrefRangeEnd = 106035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllDeskData_b__105_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_0_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AAC9 RID: 43721 RVA: 0x002C3B5C File Offset: 0x002C1D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106035, XrefRangeEnd = 106041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllDeskData_b__105_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AACA RID: 43722 RVA: 0x002C3BA0 File Offset: 0x002C1DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106041, XrefRangeEnd = 106047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllDeskData_b__105_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_2_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AACB RID: 43723 RVA: 0x002C3BE4 File Offset: 0x002C1DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106047, XrefRangeEnd = 106053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllDeskData_b__105_3(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GetAllDeskData_b__105_3_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AACC RID: 43724 RVA: 0x002C3C34 File Offset: 0x002C1E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106053, XrefRangeEnd = 106058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeHUD_b__107_0(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_0_Internal_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AACD RID: 43725 RVA: 0x002C3C78 File Offset: 0x002C1E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106058, XrefRangeEnd = 106073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeHUD_b__107_1(GuestsManager.OrderBase orderToRemove)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderToRemove);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_1_Internal_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AACE RID: 43726 RVA: 0x002C3CBC File Offset: 0x002C1EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106073, XrefRangeEnd = 106077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeHUD_b__107_2(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__InitializeHUD_b__107_2_Internal_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AACF RID: 43727 RVA: 0x002C3D00 File Offset: 0x002C1F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106077, XrefRangeEnd = 106079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IEnumerable<NormalGuest>> _ManualSpawnGuestGroupsFromTargetIzakaya_b__123_3(Izakaya.NormalGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_3_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
			}

			// Token: 0x0600AAD0 RID: 43728 RVA: 0x002C3D50 File Offset: 0x002C1F50
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 30674, RefRangeEnd = 30684, XrefRangeStart = 30674, XrefRangeEnd = 30684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ManualSpawnGuestGroupsFromTargetIzakaya_b__123_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_4_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600AAD1 RID: 43729 RVA: 0x002C3D94 File Offset: 0x002C1F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106079, XrefRangeEnd = 106082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ManualSpawnGuestGroupsFromTargetIzakaya_b__123_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD2 RID: 43730 RVA: 0x002C3DE0 File Offset: 0x002C1FE0
			[CallerCount(0)]
			public unsafe bool _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_2(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_2_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD3 RID: 43731 RVA: 0x002C3E34 File Offset: 0x002C2034
			[CallerCount(0)]
			public unsafe int _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_3_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD4 RID: 43732 RVA: 0x002C3E88 File Offset: 0x002C2088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106082, XrefRangeEnd = 106088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_7(ValueTuple<int, PartnerBase> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_7_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600AAD5 RID: 43733 RVA: 0x002C3EE0 File Offset: 0x002C20E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106088, XrefRangeEnd = 106091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD6 RID: 43734 RVA: 0x002C3F2C File Offset: 0x002C212C
			[CallerCount(0)]
			public unsafe float _CloseIzakayaDelayed_b__128_4(float a, float b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_4_Internal_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD7 RID: 43735 RVA: 0x002C3F84 File Offset: 0x002C2184
			[CallerCount(0)]
			public unsafe bool _CloseIzakayaDelayed_b__128_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD8 RID: 43736 RVA: 0x002C3FD0 File Offset: 0x002C21D0
			[CallerCount(0)]
			public unsafe bool _CloseIzakayaDelayed_b__128_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAD9 RID: 43737 RVA: 0x002C401C File Offset: 0x002C221C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106091, XrefRangeEnd = 106134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaDelayed_b__128_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AADA RID: 43738 RVA: 0x002C4050 File Offset: 0x002C2250
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaDelayed_b__128_7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AADB RID: 43739 RVA: 0x002C4084 File Offset: 0x002C2284
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaDelayed_b__128_8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AADC RID: 43740 RVA: 0x002C40B8 File Offset: 0x002C22B8
			[CallerCount(0)]
			public unsafe bool _DisposeAllFoods_b__130_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AADD RID: 43741 RVA: 0x002C4108 File Offset: 0x002C2308
			[CallerCount(0)]
			public unsafe int _DisposeAllFoods_b__130_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_1_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AADE RID: 43742 RVA: 0x002C4158 File Offset: 0x002C2358
			[CallerCount(0)]
			public unsafe bool _DisposeAllFoods_b__130_2(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_2_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AADF RID: 43743 RVA: 0x002C41A8 File Offset: 0x002C23A8
			[CallerCount(0)]
			public unsafe int _DisposeAllFoods_b__130_3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_3_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE0 RID: 43744 RVA: 0x002C41F8 File Offset: 0x002C23F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106134, XrefRangeEnd = 106140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _DisposeAllFoods_b__130_4(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600AAE1 RID: 43745 RVA: 0x002C4250 File Offset: 0x002C2450
			[CallerCount(0)]
			public unsafe int _DisposeAllFoods_b__130_5(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeAllFoods_b__130_5_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE2 RID: 43746 RVA: 0x002C42A0 File Offset: 0x002C24A0
			[CallerCount(0)]
			public unsafe bool _DisposeTray_b__131_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE3 RID: 43747 RVA: 0x002C42F0 File Offset: 0x002C24F0
			[CallerCount(0)]
			public unsafe int _DisposeTray_b__131_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_1_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE4 RID: 43748 RVA: 0x002C4340 File Offset: 0x002C2540
			[CallerCount(0)]
			public unsafe bool _DisposeTray_b__131_2(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_2_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE5 RID: 43749 RVA: 0x002C4390 File Offset: 0x002C2590
			[CallerCount(0)]
			public unsafe int _DisposeTray_b__131_3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__DisposeTray_b__131_3_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE6 RID: 43750 RVA: 0x002C43E0 File Offset: 0x002C25E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106140, XrefRangeEnd = 106147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnWaitForAllGuestToLeave_b__132_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE7 RID: 43751 RVA: 0x002C441C File Offset: 0x002C261C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106147, XrefRangeEnd = 106152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnWaitForAllGuestToLeaveForRogueLike_b__134_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__OnWaitForAllGuestToLeaveForRogueLike_b__134_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE8 RID: 43752 RVA: 0x002C4458 File Offset: 0x002C2658
			[CallerCount(0)]
			public unsafe bool _OnIdleDialog_b__138_0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__OnIdleDialog_b__138_0_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAE9 RID: 43753 RVA: 0x002C44A8 File Offset: 0x002C26A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106152, XrefRangeEnd = 106157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PostInitializeGuestGroup_b__159_0(AStarInputGeneratorComponent guestInstance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__PostInitializeGuestGroup_b__159_0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAEA RID: 43754 RVA: 0x002C44EC File Offset: 0x002C26EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106157, XrefRangeEnd = 106163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetManualControlledLeave_b__169_0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__SetManualControlledLeave_b__169_0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAEB RID: 43755 RVA: 0x002C4530 File Offset: 0x002C2730
			[CallerCount(0)]
			public unsafe bool _GenerateOrderSession_b__171_4(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_4_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAEC RID: 43756 RVA: 0x002C4580 File Offset: 0x002C2780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106163, XrefRangeEnd = 106165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GenerateOrderSession_b__171_5(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_5_Internal_Int32_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAED RID: 43757 RVA: 0x002C45D0 File Offset: 0x002C27D0
			[CallerCount(0)]
			public unsafe int _GenerateOrderSession_b__171_6(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GenerateOrderSession_b__171_6_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAEE RID: 43758 RVA: 0x002C4628 File Offset: 0x002C2828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106165, XrefRangeEnd = 106166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSeatable_b__187_1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__GetSeatable_b__187_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAEF RID: 43759 RVA: 0x002C467C File Offset: 0x002C287C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LeaveFromDesk_b__197_0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__LeaveFromDesk_b__197_0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAF0 RID: 43760 RVA: 0x002C46C0 File Offset: 0x002C28C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106166, XrefRangeEnd = 106173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayerRepell_b__209_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAF1 RID: 43761 RVA: 0x002C4704 File Offset: 0x002C2904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayerRepell_b__209_2(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_2_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AAF2 RID: 43762 RVA: 0x002C4748 File Offset: 0x002C2948
			[CallerCount(0)]
			public unsafe bool _PlayerRepell_b__209_3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c.NativeMethodInfoPtr__PlayerRepell_b__209_3_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AAF3 RID: 43763 RVA: 0x0005C09D File Offset: 0x0005A29D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003818 RID: 14360
			// (get) Token: 0x0600AAF4 RID: 43764 RVA: 0x002C4798 File Offset: 0x002C2998
			// (set) Token: 0x0600AAF5 RID: 43765 RVA: 0x0005C0A6 File Offset: 0x0005A2A6
			public unsafe static GuestsManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003819 RID: 14361
			// (get) Token: 0x0600AAF6 RID: 43766 RVA: 0x002C47C0 File Offset: 0x002C29C0
			// (set) Token: 0x0600AAF7 RID: 43767 RVA: 0x0005C0B8 File Offset: 0x0005A2B8
			public unsafe static Func<KeyValuePair<int, int>, int> __9__94_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__94_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__94_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381A RID: 14362
			// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x002C47E8 File Offset: 0x002C29E8
			// (set) Token: 0x0600AAF9 RID: 43769 RVA: 0x0005C0CA File Offset: 0x0005A2CA
			public unsafe static Func<KeyValuePair<int, int>, int> __9__94_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__94_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__94_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381B RID: 14363
			// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x002C4810 File Offset: 0x002C2A10
			// (set) Token: 0x0600AAFB RID: 43771 RVA: 0x0005C0DC File Offset: 0x0005A2DC
			public unsafe static Func<KeyValuePair<int, int>, string> __9__105_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381C RID: 14364
			// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x002C4838 File Offset: 0x002C2A38
			// (set) Token: 0x0600AAFD RID: 43773 RVA: 0x0005C0EE File Offset: 0x0005A2EE
			public unsafe static Func<int, string> __9__105_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381D RID: 14365
			// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x002C4860 File Offset: 0x002C2A60
			// (set) Token: 0x0600AAFF RID: 43775 RVA: 0x0005C100 File Offset: 0x0005A300
			public unsafe static Func<int, string> __9__105_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381E RID: 14366
			// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x002C4888 File Offset: 0x002C2A88
			// (set) Token: 0x0600AB01 RID: 43777 RVA: 0x0005C112 File Offset: 0x0005A312
			public unsafe static Func<KeyValuePair<int, int>, string> __9__105_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__105_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700381F RID: 14367
			// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002C48B0 File Offset: 0x002C2AB0
			// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x0005C124 File Offset: 0x0005A324
			public unsafe static Action<GuestsManager.OrderBase> __9__107_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestsManager.OrderBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003820 RID: 14368
			// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002C48D8 File Offset: 0x002C2AD8
			// (set) Token: 0x0600AB05 RID: 43781 RVA: 0x0005C136 File Offset: 0x0005A336
			public unsafe static Action<GuestsManager.OrderBase> __9__107_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestsManager.OrderBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003821 RID: 14369
			// (get) Token: 0x0600AB06 RID: 43782 RVA: 0x002C4900 File Offset: 0x002C2B00
			// (set) Token: 0x0600AB07 RID: 43783 RVA: 0x0005C148 File Offset: 0x0005A348
			public unsafe static Action<GuestsManager.OrderBase> __9__107_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestsManager.OrderBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__107_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003822 RID: 14370
			// (get) Token: 0x0600AB08 RID: 43784 RVA: 0x002C4928 File Offset: 0x002C2B28
			// (set) Token: 0x0600AB09 RID: 43785 RVA: 0x0005C15A File Offset: 0x0005A35A
			public unsafe static Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>> __9__123_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, IEnumerable<IEnumerable<NormalGuest>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003823 RID: 14371
			// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x002C4950 File Offset: 0x002C2B50
			// (set) Token: 0x0600AB0B RID: 43787 RVA: 0x0005C16C File Offset: 0x0005A36C
			public unsafe static Func<int, string> __9__123_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003824 RID: 14372
			// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x002C4978 File Offset: 0x002C2B78
			// (set) Token: 0x0600AB0D RID: 43789 RVA: 0x0005C17E File Offset: 0x0005A37E
			public unsafe static Func<int, bool> __9__123_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__123_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003825 RID: 14373
			// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x002C49A0 File Offset: 0x002C2BA0
			// (set) Token: 0x0600AB0F RID: 43791 RVA: 0x0005C190 File Offset: 0x0005A390
			public unsafe static Func<Product, bool> __9__124_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003826 RID: 14374
			// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x002C49C8 File Offset: 0x002C2BC8
			// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x0005C1A2 File Offset: 0x0005A3A2
			public unsafe static Func<Product, int> __9__124_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003827 RID: 14375
			// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x002C49F0 File Offset: 0x002C2BF0
			// (set) Token: 0x0600AB13 RID: 43795 RVA: 0x0005C1B4 File Offset: 0x0005A3B4
			public unsafe static Func<ValueTuple<int, PartnerBase>, IEnumerable<int>> __9__124_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003828 RID: 14376
			// (get) Token: 0x0600AB14 RID: 43796 RVA: 0x002C4A18 File Offset: 0x002C2C18
			// (set) Token: 0x0600AB15 RID: 43797 RVA: 0x0005C1C6 File Offset: 0x0005A3C6
			public unsafe static Func<int, bool> __9__124_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__124_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003829 RID: 14377
			// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x002C4A40 File Offset: 0x002C2C40
			// (set) Token: 0x0600AB17 RID: 43799 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
			public unsafe static Func<float, float, float> __9__128_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382A RID: 14378
			// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x002C4A68 File Offset: 0x002C2C68
			// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x0005C1EA File Offset: 0x0005A3EA
			public unsafe static Func<int, bool> __9__128_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382B RID: 14379
			// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x002C4A90 File Offset: 0x002C2C90
			// (set) Token: 0x0600AB1B RID: 43803 RVA: 0x0005C1FC File Offset: 0x0005A3FC
			public unsafe static Func<int, bool> __9__128_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382C RID: 14380
			// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x002C4AB8 File Offset: 0x002C2CB8
			// (set) Token: 0x0600AB1D RID: 43805 RVA: 0x0005C20E File Offset: 0x0005A40E
			public unsafe static Action __9__128_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382D RID: 14381
			// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x002C4AE0 File Offset: 0x002C2CE0
			// (set) Token: 0x0600AB1F RID: 43807 RVA: 0x0005C220 File Offset: 0x0005A420
			public unsafe static Action __9__128_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382E RID: 14382
			// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x002C4B08 File Offset: 0x002C2D08
			// (set) Token: 0x0600AB21 RID: 43809 RVA: 0x0005C232 File Offset: 0x0005A432
			public unsafe static Action __9__128_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__128_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700382F RID: 14383
			// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x002C4B30 File Offset: 0x002C2D30
			// (set) Token: 0x0600AB23 RID: 43811 RVA: 0x0005C244 File Offset: 0x0005A444
			public unsafe static Func<Sellable, bool> __9__130_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003830 RID: 14384
			// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x002C4B58 File Offset: 0x002C2D58
			// (set) Token: 0x0600AB25 RID: 43813 RVA: 0x0005C256 File Offset: 0x0005A456
			public unsafe static Func<Sellable, int> __9__130_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003831 RID: 14385
			// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x002C4B80 File Offset: 0x002C2D80
			// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x0005C268 File Offset: 0x0005A468
			public unsafe static Func<Sellable, bool> __9__130_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003832 RID: 14386
			// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x002C4BA8 File Offset: 0x002C2DA8
			// (set) Token: 0x0600AB29 RID: 43817 RVA: 0x0005C27A File Offset: 0x0005A47A
			public unsafe static Func<Sellable, int> __9__130_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003833 RID: 14387
			// (get) Token: 0x0600AB2A RID: 43818 RVA: 0x002C4BD0 File Offset: 0x002C2DD0
			// (set) Token: 0x0600AB2B RID: 43819 RVA: 0x0005C28C File Offset: 0x0005A48C
			public unsafe static Func<KeyValuePair<Sellable, int>, IEnumerable<int>> __9__130_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003834 RID: 14388
			// (get) Token: 0x0600AB2C RID: 43820 RVA: 0x002C4BF8 File Offset: 0x002C2DF8
			// (set) Token: 0x0600AB2D RID: 43821 RVA: 0x0005C29E File Offset: 0x0005A49E
			public unsafe static Func<Sellable, int> __9__130_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__130_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003835 RID: 14389
			// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x002C4C20 File Offset: 0x002C2E20
			// (set) Token: 0x0600AB2F RID: 43823 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
			public unsafe static Func<Sellable, bool> __9__131_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003836 RID: 14390
			// (get) Token: 0x0600AB30 RID: 43824 RVA: 0x002C4C48 File Offset: 0x002C2E48
			// (set) Token: 0x0600AB31 RID: 43825 RVA: 0x0005C2C2 File Offset: 0x0005A4C2
			public unsafe static Func<Sellable, int> __9__131_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003837 RID: 14391
			// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x002C4C70 File Offset: 0x002C2E70
			// (set) Token: 0x0600AB33 RID: 43827 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
			public unsafe static Func<Sellable, bool> __9__131_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003838 RID: 14392
			// (get) Token: 0x0600AB34 RID: 43828 RVA: 0x002C4C98 File Offset: 0x002C2E98
			// (set) Token: 0x0600AB35 RID: 43829 RVA: 0x0005C2E6 File Offset: 0x0005A4E6
			public unsafe static Func<Sellable, int> __9__131_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__131_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003839 RID: 14393
			// (get) Token: 0x0600AB36 RID: 43830 RVA: 0x002C4CC0 File Offset: 0x002C2EC0
			// (set) Token: 0x0600AB37 RID: 43831 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
			public unsafe static Func<bool> __9__132_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383A RID: 14394
			// (get) Token: 0x0600AB38 RID: 43832 RVA: 0x002C4CE8 File Offset: 0x002C2EE8
			// (set) Token: 0x0600AB39 RID: 43833 RVA: 0x0005C30A File Offset: 0x0005A50A
			public unsafe static Func<bool> __9__134_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__134_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__134_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383B RID: 14395
			// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x002C4D10 File Offset: 0x002C2F10
			// (set) Token: 0x0600AB3B RID: 43835 RVA: 0x0005C31C File Offset: 0x0005A51C
			public unsafe static Func<GuestGroupController, bool> __9__138_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__138_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__138_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383C RID: 14396
			// (get) Token: 0x0600AB3C RID: 43836 RVA: 0x002C4D38 File Offset: 0x002C2F38
			// (set) Token: 0x0600AB3D RID: 43837 RVA: 0x0005C32E File Offset: 0x0005A52E
			public unsafe static Action<AStarInputGeneratorComponent> __9__159_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__159_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__159_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383D RID: 14397
			// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x002C4D60 File Offset: 0x002C2F60
			// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x0005C340 File Offset: 0x0005A540
			public unsafe static Action<AStarInputGeneratorComponent> __9__169_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__169_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__169_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383E RID: 14398
			// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x002C4D88 File Offset: 0x002C2F88
			// (set) Token: 0x0600AB41 RID: 43841 RVA: 0x0005C352 File Offset: 0x0005A552
			public unsafe static Func<GuestsManager.OrderBase, bool> __9__171_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700383F RID: 14399
			// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x002C4DB0 File Offset: 0x002C2FB0
			// (set) Token: 0x0600AB43 RID: 43843 RVA: 0x0005C364 File Offset: 0x0005A564
			public unsafe static Func<GuestsManager.OrderBase, int> __9__171_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003840 RID: 14400
			// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002C4DD8 File Offset: 0x002C2FD8
			// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x0005C376 File Offset: 0x0005A576
			public unsafe static Func<int, int, int> __9__171_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__171_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003841 RID: 14401
			// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x002C4E00 File Offset: 0x002C3000
			// (set) Token: 0x0600AB47 RID: 43847 RVA: 0x0005C388 File Offset: 0x0005A588
			public unsafe static Func<KeyValuePair<int, int>, int> __9__187_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__187_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__187_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003842 RID: 14402
			// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x002C4E28 File Offset: 0x002C3028
			// (set) Token: 0x0600AB49 RID: 43849 RVA: 0x0005C39A File Offset: 0x0005A59A
			public unsafe static Action<AStarInputGeneratorComponent> __9__197_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__197_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__197_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003843 RID: 14403
			// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x002C4E50 File Offset: 0x002C3050
			// (set) Token: 0x0600AB4B RID: 43851 RVA: 0x0005C3AC File Offset: 0x0005A5AC
			public unsafe static Action<AchievementNotifyResult> __9__209_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003844 RID: 14404
			// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x002C4E78 File Offset: 0x002C3078
			// (set) Token: 0x0600AB4D RID: 43853 RVA: 0x0005C3BE File Offset: 0x0005A5BE
			public unsafe static Action<AStarInputGeneratorComponent> __9__209_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003845 RID: 14405
			// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x002C4EA0 File Offset: 0x002C30A0
			// (set) Token: 0x0600AB4F RID: 43855 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
			public unsafe static Func<GuestGroupController, bool> __9__209_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestsManager.__c.NativeFieldInfoPtr___9__209_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E5D RID: 28253
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006E5E RID: 28254
			private static readonly IntPtr NativeFieldInfoPtr___9__94_1;

			// Token: 0x04006E5F RID: 28255
			private static readonly IntPtr NativeFieldInfoPtr___9__94_2;

			// Token: 0x04006E60 RID: 28256
			private static readonly IntPtr NativeFieldInfoPtr___9__105_0;

			// Token: 0x04006E61 RID: 28257
			private static readonly IntPtr NativeFieldInfoPtr___9__105_1;

			// Token: 0x04006E62 RID: 28258
			private static readonly IntPtr NativeFieldInfoPtr___9__105_2;

			// Token: 0x04006E63 RID: 28259
			private static readonly IntPtr NativeFieldInfoPtr___9__105_3;

			// Token: 0x04006E64 RID: 28260
			private static readonly IntPtr NativeFieldInfoPtr___9__107_0;

			// Token: 0x04006E65 RID: 28261
			private static readonly IntPtr NativeFieldInfoPtr___9__107_1;

			// Token: 0x04006E66 RID: 28262
			private static readonly IntPtr NativeFieldInfoPtr___9__107_2;

			// Token: 0x04006E67 RID: 28263
			private static readonly IntPtr NativeFieldInfoPtr___9__123_3;

			// Token: 0x04006E68 RID: 28264
			private static readonly IntPtr NativeFieldInfoPtr___9__123_4;

			// Token: 0x04006E69 RID: 28265
			private static readonly IntPtr NativeFieldInfoPtr___9__123_5;

			// Token: 0x04006E6A RID: 28266
			private static readonly IntPtr NativeFieldInfoPtr___9__124_2;

			// Token: 0x04006E6B RID: 28267
			private static readonly IntPtr NativeFieldInfoPtr___9__124_3;

			// Token: 0x04006E6C RID: 28268
			private static readonly IntPtr NativeFieldInfoPtr___9__124_7;

			// Token: 0x04006E6D RID: 28269
			private static readonly IntPtr NativeFieldInfoPtr___9__124_9;

			// Token: 0x04006E6E RID: 28270
			private static readonly IntPtr NativeFieldInfoPtr___9__128_4;

			// Token: 0x04006E6F RID: 28271
			private static readonly IntPtr NativeFieldInfoPtr___9__128_5;

			// Token: 0x04006E70 RID: 28272
			private static readonly IntPtr NativeFieldInfoPtr___9__128_6;

			// Token: 0x04006E71 RID: 28273
			private static readonly IntPtr NativeFieldInfoPtr___9__128_7;

			// Token: 0x04006E72 RID: 28274
			private static readonly IntPtr NativeFieldInfoPtr___9__128_8;

			// Token: 0x04006E73 RID: 28275
			private static readonly IntPtr NativeFieldInfoPtr___9__128_0;

			// Token: 0x04006E74 RID: 28276
			private static readonly IntPtr NativeFieldInfoPtr___9__130_0;

			// Token: 0x04006E75 RID: 28277
			private static readonly IntPtr NativeFieldInfoPtr___9__130_1;

			// Token: 0x04006E76 RID: 28278
			private static readonly IntPtr NativeFieldInfoPtr___9__130_2;

			// Token: 0x04006E77 RID: 28279
			private static readonly IntPtr NativeFieldInfoPtr___9__130_3;

			// Token: 0x04006E78 RID: 28280
			private static readonly IntPtr NativeFieldInfoPtr___9__130_4;

			// Token: 0x04006E79 RID: 28281
			private static readonly IntPtr NativeFieldInfoPtr___9__130_5;

			// Token: 0x04006E7A RID: 28282
			private static readonly IntPtr NativeFieldInfoPtr___9__131_0;

			// Token: 0x04006E7B RID: 28283
			private static readonly IntPtr NativeFieldInfoPtr___9__131_1;

			// Token: 0x04006E7C RID: 28284
			private static readonly IntPtr NativeFieldInfoPtr___9__131_2;

			// Token: 0x04006E7D RID: 28285
			private static readonly IntPtr NativeFieldInfoPtr___9__131_3;

			// Token: 0x04006E7E RID: 28286
			private static readonly IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x04006E7F RID: 28287
			private static readonly IntPtr NativeFieldInfoPtr___9__134_0;

			// Token: 0x04006E80 RID: 28288
			private static readonly IntPtr NativeFieldInfoPtr___9__138_0;

			// Token: 0x04006E81 RID: 28289
			private static readonly IntPtr NativeFieldInfoPtr___9__159_0;

			// Token: 0x04006E82 RID: 28290
			private static readonly IntPtr NativeFieldInfoPtr___9__169_0;

			// Token: 0x04006E83 RID: 28291
			private static readonly IntPtr NativeFieldInfoPtr___9__171_4;

			// Token: 0x04006E84 RID: 28292
			private static readonly IntPtr NativeFieldInfoPtr___9__171_5;

			// Token: 0x04006E85 RID: 28293
			private static readonly IntPtr NativeFieldInfoPtr___9__171_6;

			// Token: 0x04006E86 RID: 28294
			private static readonly IntPtr NativeFieldInfoPtr___9__187_1;

			// Token: 0x04006E87 RID: 28295
			private static readonly IntPtr NativeFieldInfoPtr___9__197_0;

			// Token: 0x04006E88 RID: 28296
			private static readonly IntPtr NativeFieldInfoPtr___9__209_0;

			// Token: 0x04006E89 RID: 28297
			private static readonly IntPtr NativeFieldInfoPtr___9__209_2;

			// Token: 0x04006E8A RID: 28298
			private static readonly IntPtr NativeFieldInfoPtr___9__209_3;

			// Token: 0x04006E8B RID: 28299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E8C RID: 28300
			private static readonly IntPtr NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006E8D RID: 28301
			private static readonly IntPtr NativeMethodInfoPtr__get_TrueAvailableDesks_b__94_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006E8E RID: 28302
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeskData_b__105_0_Internal_String_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006E8F RID: 28303
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeskData_b__105_1_Internal_String_Int32_0;

			// Token: 0x04006E90 RID: 28304
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeskData_b__105_2_Internal_String_Int32_0;

			// Token: 0x04006E91 RID: 28305
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeskData_b__105_3_Internal_String_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006E92 RID: 28306
			private static readonly IntPtr NativeMethodInfoPtr__InitializeHUD_b__107_0_Internal_Void_OrderBase_0;

			// Token: 0x04006E93 RID: 28307
			private static readonly IntPtr NativeMethodInfoPtr__InitializeHUD_b__107_1_Internal_Void_OrderBase_0;

			// Token: 0x04006E94 RID: 28308
			private static readonly IntPtr NativeMethodInfoPtr__InitializeHUD_b__107_2_Internal_Void_OrderBase_0;

			// Token: 0x04006E95 RID: 28309
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_3_Internal_IEnumerable_1_IEnumerable_1_NormalGuest_NormalGuestGroup_0;

			// Token: 0x04006E96 RID: 28310
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_4_Internal_String_Int32_0;

			// Token: 0x04006E97 RID: 28311
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnGuestGroupsFromTargetIzakaya_b__123_5_Internal_Boolean_Int32_0;

			// Token: 0x04006E98 RID: 28312
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_2_Internal_Boolean_Product_0;

			// Token: 0x04006E99 RID: 28313
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_3_Internal_Int32_Product_0;

			// Token: 0x04006E9A RID: 28314
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_7_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0;

			// Token: 0x04006E9B RID: 28315
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__124_9_Internal_Boolean_Int32_0;

			// Token: 0x04006E9C RID: 28316
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_4_Internal_Single_Single_Single_0;

			// Token: 0x04006E9D RID: 28317
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_5_Internal_Boolean_Int32_0;

			// Token: 0x04006E9E RID: 28318
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_6_Internal_Boolean_Int32_0;

			// Token: 0x04006E9F RID: 28319
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_0_Internal_Void_0;

			// Token: 0x04006EA0 RID: 28320
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_7_Internal_Void_0;

			// Token: 0x04006EA1 RID: 28321
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__128_8_Internal_Void_0;

			// Token: 0x04006EA2 RID: 28322
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_0_Internal_Boolean_Sellable_0;

			// Token: 0x04006EA3 RID: 28323
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_1_Internal_Int32_Sellable_0;

			// Token: 0x04006EA4 RID: 28324
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_2_Internal_Boolean_Sellable_0;

			// Token: 0x04006EA5 RID: 28325
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_3_Internal_Int32_Sellable_0;

			// Token: 0x04006EA6 RID: 28326
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04006EA7 RID: 28327
			private static readonly IntPtr NativeMethodInfoPtr__DisposeAllFoods_b__130_5_Internal_Int32_Sellable_0;

			// Token: 0x04006EA8 RID: 28328
			private static readonly IntPtr NativeMethodInfoPtr__DisposeTray_b__131_0_Internal_Boolean_Sellable_0;

			// Token: 0x04006EA9 RID: 28329
			private static readonly IntPtr NativeMethodInfoPtr__DisposeTray_b__131_1_Internal_Int32_Sellable_0;

			// Token: 0x04006EAA RID: 28330
			private static readonly IntPtr NativeMethodInfoPtr__DisposeTray_b__131_2_Internal_Boolean_Sellable_0;

			// Token: 0x04006EAB RID: 28331
			private static readonly IntPtr NativeMethodInfoPtr__DisposeTray_b__131_3_Internal_Int32_Sellable_0;

			// Token: 0x04006EAC RID: 28332
			private static readonly IntPtr NativeMethodInfoPtr__OnWaitForAllGuestToLeave_b__132_0_Internal_Boolean_0;

			// Token: 0x04006EAD RID: 28333
			private static readonly IntPtr NativeMethodInfoPtr__OnWaitForAllGuestToLeaveForRogueLike_b__134_0_Internal_Boolean_0;

			// Token: 0x04006EAE RID: 28334
			private static readonly IntPtr NativeMethodInfoPtr__OnIdleDialog_b__138_0_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04006EAF RID: 28335
			private static readonly IntPtr NativeMethodInfoPtr__PostInitializeGuestGroup_b__159_0_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04006EB0 RID: 28336
			private static readonly IntPtr NativeMethodInfoPtr__SetManualControlledLeave_b__169_0_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04006EB1 RID: 28337
			private static readonly IntPtr NativeMethodInfoPtr__GenerateOrderSession_b__171_4_Internal_Boolean_OrderBase_0;

			// Token: 0x04006EB2 RID: 28338
			private static readonly IntPtr NativeMethodInfoPtr__GenerateOrderSession_b__171_5_Internal_Int32_OrderBase_0;

			// Token: 0x04006EB3 RID: 28339
			private static readonly IntPtr NativeMethodInfoPtr__GenerateOrderSession_b__171_6_Internal_Int32_Int32_Int32_0;

			// Token: 0x04006EB4 RID: 28340
			private static readonly IntPtr NativeMethodInfoPtr__GetSeatable_b__187_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006EB5 RID: 28341
			private static readonly IntPtr NativeMethodInfoPtr__LeaveFromDesk_b__197_0_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04006EB6 RID: 28342
			private static readonly IntPtr NativeMethodInfoPtr__PlayerRepell_b__209_0_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x04006EB7 RID: 28343
			private static readonly IntPtr NativeMethodInfoPtr__PlayerRepell_b__209_2_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x04006EB8 RID: 28344
			private static readonly IntPtr NativeMethodInfoPtr__PlayerRepell_b__209_3_Internal_Boolean_GuestGroupController_0;
		}

		// Token: 0x0200082F RID: 2095
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass107_0")]
		public sealed class __c__DisplayClass107_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AB50 RID: 43856 RVA: 0x002C4EC8 File Offset: 0x002C30C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass107_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass107_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass107_0.NativeFieldInfoPtr_orderToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr, "orderToRemove");
				GuestsManager.__c__DisplayClass107_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr, 100671887);
				GuestsManager.__c__DisplayClass107_0.NativeMethodInfoPtr__InitializeHUD_b__3_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr, 100671888);
			}

			// Token: 0x0600AB51 RID: 43857 RVA: 0x002C4F30 File Offset: 0x002C3130
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass107_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass107_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass107_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB52 RID: 43858 RVA: 0x002C4F6C File Offset: 0x002C316C
			[CallerCount(0)]
			public unsafe bool _InitializeHUD_b__3(GuestsManager.OrderBase order)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass107_0.NativeMethodInfoPtr__InitializeHUD_b__3_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AB53 RID: 43859 RVA: 0x0005C3E2 File Offset: 0x0005A5E2
			public __c__DisplayClass107_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003846 RID: 14406
			// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x002C4FBC File Offset: 0x002C31BC
			// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x0005C3EB File Offset: 0x0005A5EB
			public unsafe GuestsManager.OrderBase orderToRemove
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass107_0.NativeFieldInfoPtr_orderToRemove);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass107_0.NativeFieldInfoPtr_orderToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EB9 RID: 28345
			private static readonly IntPtr NativeFieldInfoPtr_orderToRemove;

			// Token: 0x04006EBA RID: 28346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EBB RID: 28347
			private static readonly IntPtr NativeMethodInfoPtr__InitializeHUD_b__3_Internal_Boolean_OrderBase_0;
		}

		// Token: 0x02000830 RID: 2096
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass121_0")]
		public sealed class __c__DisplayClass121_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AB56 RID: 43862 RVA: 0x002C4FEC File Offset: 0x002C31EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass121_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass121_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "amount");
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_durationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "durationSec");
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "continueToSpawnAfterDayEnd");
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_targetNormalGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "targetNormalGuestId");
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "coroutine");
				GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, 100671889);
				GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, 100671890);
				GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, 100671891);
			}

			// Token: 0x0600AB57 RID: 43863 RVA: 0x002C50CC File Offset: 0x002C32CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass121_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB58 RID: 43864 RVA: 0x002C5108 File Offset: 0x002C3308
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106214, RefRangeEnd = 106215, XrefRangeStart = 106209, XrefRangeEnd = 106214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB59 RID: 43865 RVA: 0x002C5148 File Offset: 0x002C3348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106215, XrefRangeEnd = 106216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB5A RID: 43866 RVA: 0x0005C40A File Offset: 0x0005A60A
			public __c__DisplayClass121_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003847 RID: 14407
			// (get) Token: 0x0600AB5B RID: 43867 RVA: 0x002C517C File Offset: 0x002C337C
			// (set) Token: 0x0600AB5C RID: 43868 RVA: 0x0005C413 File Offset: 0x0005A613
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17003848 RID: 14408
			// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x002C51A4 File Offset: 0x002C33A4
			// (set) Token: 0x0600AB5E RID: 43870 RVA: 0x0005C42E File Offset: 0x0005A62E
			public unsafe int durationSec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_durationSec);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_durationSec)) = value;
				}
			}

			// Token: 0x17003849 RID: 14409
			// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x002C51CC File Offset: 0x002C33CC
			// (set) Token: 0x0600AB60 RID: 43872 RVA: 0x0005C449 File Offset: 0x0005A649
			public unsafe bool continueToSpawnAfterDayEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd)) = value;
				}
			}

			// Token: 0x1700384A RID: 14410
			// (get) Token: 0x0600AB61 RID: 43873 RVA: 0x002C51F4 File Offset: 0x002C33F4
			// (set) Token: 0x0600AB62 RID: 43874 RVA: 0x0005C464 File Offset: 0x0005A664
			public unsafe int targetNormalGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_targetNormalGuestId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_targetNormalGuestId)) = value;
				}
			}

			// Token: 0x1700384B RID: 14411
			// (get) Token: 0x0600AB63 RID: 43875 RVA: 0x002C521C File Offset: 0x002C341C
			// (set) Token: 0x0600AB64 RID: 43876 RVA: 0x0005C47F File Offset: 0x0005A67F
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700384C RID: 14412
			// (get) Token: 0x0600AB65 RID: 43877 RVA: 0x002C524C File Offset: 0x002C344C
			// (set) Token: 0x0600AB66 RID: 43878 RVA: 0x0005C49E File Offset: 0x0005A69E
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EBC RID: 28348
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04006EBD RID: 28349
			private static readonly IntPtr NativeFieldInfoPtr_durationSec;

			// Token: 0x04006EBE RID: 28350
			private static readonly IntPtr NativeFieldInfoPtr_continueToSpawnAfterDayEnd;

			// Token: 0x04006EBF RID: 28351
			private static readonly IntPtr NativeFieldInfoPtr_targetNormalGuestId;

			// Token: 0x04006EC0 RID: 28352
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006EC1 RID: 28353
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04006EC2 RID: 28354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EC3 RID: 28355
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04006EC4 RID: 28356
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02000FE4 RID: 4068
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass121_0+<<ManualSpawnNormalGuestGroups>g__OnNormalGuestSpawning|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011736 RID: 71478 RVA: 0x00402434 File Offset: 0x00400634
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0>.NativeClassPtr, "<<ManualSpawnNormalGuestGroups>g__OnNormalGuestSpawning|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__thisAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, "<thisAmount>5__2");
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, "<wait>5__3");
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671892);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671893);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671894);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671895);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671896);
					GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr, 100671897);
				}

				// Token: 0x06011737 RID: 71479 RVA: 0x0040253C File Offset: 0x0040073C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011738 RID: 71480 RVA: 0x00402584 File Offset: 0x00400784
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011739 RID: 71481 RVA: 0x004025B8 File Offset: 0x004007B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106173, XrefRangeEnd = 106203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005ABB RID: 23227
				// (get) Token: 0x0601173A RID: 71482 RVA: 0x004025F4 File Offset: 0x004007F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601173B RID: 71483 RVA: 0x00402634 File Offset: 0x00400834
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106203, XrefRangeEnd = 106209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005ABC RID: 23228
				// (get) Token: 0x0601173C RID: 71484 RVA: 0x00402668 File Offset: 0x00400868
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601173D RID: 71485 RVA: 0x00097DB4 File Offset: 0x00095FB4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AB6 RID: 23222
				// (get) Token: 0x0601173E RID: 71486 RVA: 0x004026A8 File Offset: 0x004008A8
				// (set) Token: 0x0601173F RID: 71487 RVA: 0x00097DBD File Offset: 0x00095FBD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AB7 RID: 23223
				// (get) Token: 0x06011740 RID: 71488 RVA: 0x004026D0 File Offset: 0x004008D0
				// (set) Token: 0x06011741 RID: 71489 RVA: 0x00097DD8 File Offset: 0x00095FD8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AB8 RID: 23224
				// (get) Token: 0x06011742 RID: 71490 RVA: 0x00402700 File Offset: 0x00400900
				// (set) Token: 0x06011743 RID: 71491 RVA: 0x00097DF7 File Offset: 0x00095FF7
				public unsafe GuestsManager.__c__DisplayClass121_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass121_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AB9 RID: 23225
				// (get) Token: 0x06011744 RID: 71492 RVA: 0x00402730 File Offset: 0x00400930
				// (set) Token: 0x06011745 RID: 71493 RVA: 0x00097E16 File Offset: 0x00096016
				public unsafe int _thisAmount_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__thisAmount_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__thisAmount_5__2)) = value;
					}
				}

				// Token: 0x17005ABA RID: 23226
				// (get) Token: 0x06011746 RID: 71494 RVA: 0x00402758 File Offset: 0x00400958
				// (set) Token: 0x06011747 RID: 71495 RVA: 0x00097E31 File Offset: 0x00096031
				public unsafe WaitForSeconds _wait_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__wait_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass121_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaInObObUnique.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B05F RID: 45151
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B060 RID: 45152
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B061 RID: 45153
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B062 RID: 45154
				private static readonly IntPtr NativeFieldInfoPtr__thisAmount_5__2;

				// Token: 0x0400B063 RID: 45155
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

				// Token: 0x0400B064 RID: 45156
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B065 RID: 45157
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B066 RID: 45158
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B067 RID: 45159
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B068 RID: 45160
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B069 RID: 45161
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000831 RID: 2097
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass122_0")]
		public sealed class __c__DisplayClass122_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AB67 RID: 43879 RVA: 0x002C527C File Offset: 0x002C347C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass122_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass122_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_durationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "durationSec");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "continueToSpawnAfterDayEnd");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_targetNormalGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "targetNormalGuestId");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_spawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "spawnTime");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_extraSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "extraSpawnRate");
				GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "coroutine");
				GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, 100671898);
				GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, 100671899);
				GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, 100671900);
			}

			// Token: 0x0600AB68 RID: 43880 RVA: 0x002C5370 File Offset: 0x002C3570
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass122_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB69 RID: 43881 RVA: 0x002C53AC File Offset: 0x002C35AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106261, RefRangeEnd = 106262, XrefRangeStart = 106256, XrefRangeEnd = 106261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB6A RID: 43882 RVA: 0x002C53EC File Offset: 0x002C35EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106262, XrefRangeEnd = 106263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB6B RID: 43883 RVA: 0x0005C4BD File Offset: 0x0005A6BD
			public __c__DisplayClass122_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700384D RID: 14413
			// (get) Token: 0x0600AB6C RID: 43884 RVA: 0x002C5420 File Offset: 0x002C3620
			// (set) Token: 0x0600AB6D RID: 43885 RVA: 0x0005C4C6 File Offset: 0x0005A6C6
			public unsafe int durationSec
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_durationSec);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_durationSec)) = value;
				}
			}

			// Token: 0x1700384E RID: 14414
			// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x002C5448 File Offset: 0x002C3648
			// (set) Token: 0x0600AB6F RID: 43887 RVA: 0x0005C4E1 File Offset: 0x0005A6E1
			public unsafe bool continueToSpawnAfterDayEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd)) = value;
				}
			}

			// Token: 0x1700384F RID: 14415
			// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x002C5470 File Offset: 0x002C3670
			// (set) Token: 0x0600AB71 RID: 43889 RVA: 0x0005C4FC File Offset: 0x0005A6FC
			public unsafe int targetNormalGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_targetNormalGuestId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_targetNormalGuestId)) = value;
				}
			}

			// Token: 0x17003850 RID: 14416
			// (get) Token: 0x0600AB72 RID: 43890 RVA: 0x002C5498 File Offset: 0x002C3698
			// (set) Token: 0x0600AB73 RID: 43891 RVA: 0x0005C517 File Offset: 0x0005A717
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003851 RID: 14417
			// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x002C54C8 File Offset: 0x002C36C8
			// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x0005C536 File Offset: 0x0005A736
			public unsafe Vector2 spawnTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_spawnTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_spawnTime)) = value;
				}
			}

			// Token: 0x17003852 RID: 14418
			// (get) Token: 0x0600AB76 RID: 43894 RVA: 0x002C54F0 File Offset: 0x002C36F0
			// (set) Token: 0x0600AB77 RID: 43895 RVA: 0x0005C551 File Offset: 0x0005A751
			public unsafe float extraSpawnRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_extraSpawnRate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_extraSpawnRate)) = value;
				}
			}

			// Token: 0x17003853 RID: 14419
			// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x002C5518 File Offset: 0x002C3718
			// (set) Token: 0x0600AB79 RID: 43897 RVA: 0x0005C56C File Offset: 0x0005A76C
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EC5 RID: 28357
			private static readonly IntPtr NativeFieldInfoPtr_durationSec;

			// Token: 0x04006EC6 RID: 28358
			private static readonly IntPtr NativeFieldInfoPtr_continueToSpawnAfterDayEnd;

			// Token: 0x04006EC7 RID: 28359
			private static readonly IntPtr NativeFieldInfoPtr_targetNormalGuestId;

			// Token: 0x04006EC8 RID: 28360
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006EC9 RID: 28361
			private static readonly IntPtr NativeFieldInfoPtr_spawnTime;

			// Token: 0x04006ECA RID: 28362
			private static readonly IntPtr NativeFieldInfoPtr_extraSpawnRate;

			// Token: 0x04006ECB RID: 28363
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04006ECC RID: 28364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006ECD RID: 28365
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04006ECE RID: 28366
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02000FE5 RID: 4069
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass122_0+<<ManualSpawnNormalGuestGroups>g__OnNormalGuestSpawning|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011748 RID: 71496 RVA: 0x00402788 File Offset: 0x00400988
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0>.NativeClassPtr, "<<ManualSpawnNormalGuestGroups>g__OnNormalGuestSpawning|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__thisDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<thisDuration>5__2");
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__spawnInterval_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<spawnInterval>5__3");
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671901);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671902);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671903);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671904);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671905);
					GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100671906);
				}

				// Token: 0x06011749 RID: 71497 RVA: 0x00402890 File Offset: 0x00400A90
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601174A RID: 71498 RVA: 0x004028D8 File Offset: 0x00400AD8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601174B RID: 71499 RVA: 0x0040290C File Offset: 0x00400B0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106216, XrefRangeEnd = 106250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AC2 RID: 23234
				// (get) Token: 0x0601174C RID: 71500 RVA: 0x00402948 File Offset: 0x00400B48
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601174D RID: 71501 RVA: 0x00402988 File Offset: 0x00400B88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106250, XrefRangeEnd = 106256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AC3 RID: 23235
				// (get) Token: 0x0601174E RID: 71502 RVA: 0x004029BC File Offset: 0x00400BBC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601174F RID: 71503 RVA: 0x00097E50 File Offset: 0x00096050
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005ABD RID: 23229
				// (get) Token: 0x06011750 RID: 71504 RVA: 0x004029FC File Offset: 0x00400BFC
				// (set) Token: 0x06011751 RID: 71505 RVA: 0x00097E59 File Offset: 0x00096059
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005ABE RID: 23230
				// (get) Token: 0x06011752 RID: 71506 RVA: 0x00402A24 File Offset: 0x00400C24
				// (set) Token: 0x06011753 RID: 71507 RVA: 0x00097E74 File Offset: 0x00096074
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005ABF RID: 23231
				// (get) Token: 0x06011754 RID: 71508 RVA: 0x00402A54 File Offset: 0x00400C54
				// (set) Token: 0x06011755 RID: 71509 RVA: 0x00097E93 File Offset: 0x00096093
				public unsafe GuestsManager.__c__DisplayClass122_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass122_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AC0 RID: 23232
				// (get) Token: 0x06011756 RID: 71510 RVA: 0x00402A84 File Offset: 0x00400C84
				// (set) Token: 0x06011757 RID: 71511 RVA: 0x00097EB2 File Offset: 0x000960B2
				public unsafe float _thisDuration_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__thisDuration_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__thisDuration_5__2)) = value;
					}
				}

				// Token: 0x17005AC1 RID: 23233
				// (get) Token: 0x06011758 RID: 71512 RVA: 0x00402AAC File Offset: 0x00400CAC
				// (set) Token: 0x06011759 RID: 71513 RVA: 0x00097ECD File Offset: 0x000960CD
				public unsafe float _spawnInterval_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__spawnInterval_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass122_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__spawnInterval_5__3)) = value;
					}
				}

				// Token: 0x0400B06A RID: 45162
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B06B RID: 45163
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B06C RID: 45164
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B06D RID: 45165
				private static readonly IntPtr NativeFieldInfoPtr__thisDuration_5__2;

				// Token: 0x0400B06E RID: 45166
				private static readonly IntPtr NativeFieldInfoPtr__spawnInterval_5__3;

				// Token: 0x0400B06F RID: 45167
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B070 RID: 45168
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B071 RID: 45169
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B072 RID: 45170
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B073 RID: 45171
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B074 RID: 45172
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000832 RID: 2098
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass123_0")]
		public sealed class __c__DisplayClass123_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AB7A RID: 43898 RVA: 0x002C5548 File Offset: 0x002C3748
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass123_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass123_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "normalGuestGroups");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "continueToSpawnAfterDayEnd");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestSpanInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "normalGuestSpanInterval");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_extraRefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "extraRefreshRate");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "specialGuestPool");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestGachaInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "specialGuestGachaInterval");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "coroutine");
				GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "coroutine2");
				GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, 100671907);
				GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, 100671908);
				GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, 100671909);
				GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, 100671910);
			}

			// Token: 0x0600AB7B RID: 43899 RVA: 0x002C5678 File Offset: 0x002C3878
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass123_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB7C RID: 43900 RVA: 0x002C56B4 File Offset: 0x002C38B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106414, RefRangeEnd = 106415, XrefRangeStart = 106409, XrefRangeEnd = 106414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB7D RID: 43901 RVA: 0x002C56F4 File Offset: 0x002C38F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106420, RefRangeEnd = 106421, XrefRangeStart = 106415, XrefRangeEnd = 106420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB7E RID: 43902 RVA: 0x002C5734 File Offset: 0x002C3934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106421, XrefRangeEnd = 106423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB7F RID: 43903 RVA: 0x0005C58B File Offset: 0x0005A78B
			public __c__DisplayClass123_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003854 RID: 14420
			// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x002C5768 File Offset: 0x002C3968
			// (set) Token: 0x0600AB81 RID: 43905 RVA: 0x0005C594 File Offset: 0x0005A794
			public unsafe Il2CppReferenceArray<Izakaya.NormalGuestGroup> normalGuestGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.NormalGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003855 RID: 14421
			// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x002C5798 File Offset: 0x002C3998
			// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x0005C5B3 File Offset: 0x0005A7B3
			public unsafe bool continueToSpawnAfterDayEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd)) = value;
				}
			}

			// Token: 0x17003856 RID: 14422
			// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x002C57C0 File Offset: 0x002C39C0
			// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x0005C5CE File Offset: 0x0005A7CE
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003857 RID: 14423
			// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x002C57F0 File Offset: 0x002C39F0
			// (set) Token: 0x0600AB87 RID: 43911 RVA: 0x0005C5ED File Offset: 0x0005A7ED
			public unsafe Vector2 normalGuestSpanInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestSpanInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_normalGuestSpanInterval)) = value;
				}
			}

			// Token: 0x17003858 RID: 14424
			// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x002C5818 File Offset: 0x002C3A18
			// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x0005C608 File Offset: 0x0005A808
			public unsafe float extraRefreshRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_extraRefreshRate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_extraRefreshRate)) = value;
				}
			}

			// Token: 0x17003859 RID: 14425
			// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x002C5840 File Offset: 0x002C3A40
			// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x0005C623 File Offset: 0x0005A823
			public unsafe IReadOnlyList<int> specialGuestPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700385A RID: 14426
			// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x002C5870 File Offset: 0x002C3A70
			// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x0005C642 File Offset: 0x0005A842
			public unsafe float specialGuestGachaInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestGachaInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_specialGuestGachaInterval)) = value;
				}
			}

			// Token: 0x1700385B RID: 14427
			// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x002C5898 File Offset: 0x002C3A98
			// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x0005C65D File Offset: 0x0005A85D
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700385C RID: 14428
			// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x002C58C8 File Offset: 0x002C3AC8
			// (set) Token: 0x0600AB91 RID: 43921 RVA: 0x0005C67C File Offset: 0x0005A87C
			public unsafe Coroutine coroutine2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.NativeFieldInfoPtr_coroutine2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006ECF RID: 28367
			private static readonly IntPtr NativeFieldInfoPtr_normalGuestGroups;

			// Token: 0x04006ED0 RID: 28368
			private static readonly IntPtr NativeFieldInfoPtr_continueToSpawnAfterDayEnd;

			// Token: 0x04006ED1 RID: 28369
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006ED2 RID: 28370
			private static readonly IntPtr NativeFieldInfoPtr_normalGuestSpanInterval;

			// Token: 0x04006ED3 RID: 28371
			private static readonly IntPtr NativeFieldInfoPtr_extraRefreshRate;

			// Token: 0x04006ED4 RID: 28372
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestPool;

			// Token: 0x04006ED5 RID: 28373
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestGachaInterval;

			// Token: 0x04006ED6 RID: 28374
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04006ED7 RID: 28375
			private static readonly IntPtr NativeFieldInfoPtr_coroutine2;

			// Token: 0x04006ED8 RID: 28376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006ED9 RID: 28377
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04006EDA RID: 28378
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_1;

			// Token: 0x04006EDB RID: 28379
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02000FE6 RID: 4070
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass123_0+<<ManualSpawnGuestGroupsFromTargetIzakaya>g__OnNormalGuestSpawning|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601175A RID: 71514 RVA: 0x00402AD4 File Offset: 0x00400CD4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "<<ManualSpawnGuestGroupsFromTargetIzakaya>g__OnNormalGuestSpawning|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr__normalGuestPool_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, "<normalGuestPool>5__2");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671911);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671912);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671913);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671914);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671915);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr, 100671916);
				}

				// Token: 0x0601175B RID: 71515 RVA: 0x00402BC8 File Offset: 0x00400DC8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601175C RID: 71516 RVA: 0x00402C10 File Offset: 0x00400E10
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601175D RID: 71517 RVA: 0x00402C44 File Offset: 0x00400E44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106263, XrefRangeEnd = 106308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AC8 RID: 23240
				// (get) Token: 0x0601175E RID: 71518 RVA: 0x00402C80 File Offset: 0x00400E80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601175F RID: 71519 RVA: 0x00402CC0 File Offset: 0x00400EC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106308, XrefRangeEnd = 106314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AC9 RID: 23241
				// (get) Token: 0x06011760 RID: 71520 RVA: 0x00402CF4 File Offset: 0x00400EF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011761 RID: 71521 RVA: 0x00097EE8 File Offset: 0x000960E8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AC4 RID: 23236
				// (get) Token: 0x06011762 RID: 71522 RVA: 0x00402D34 File Offset: 0x00400F34
				// (set) Token: 0x06011763 RID: 71523 RVA: 0x00097EF1 File Offset: 0x000960F1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AC5 RID: 23237
				// (get) Token: 0x06011764 RID: 71524 RVA: 0x00402D5C File Offset: 0x00400F5C
				// (set) Token: 0x06011765 RID: 71525 RVA: 0x00097F0C File Offset: 0x0009610C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AC6 RID: 23238
				// (get) Token: 0x06011766 RID: 71526 RVA: 0x00402D8C File Offset: 0x00400F8C
				// (set) Token: 0x06011767 RID: 71527 RVA: 0x00097F2B File Offset: 0x0009612B
				public unsafe GuestsManager.__c__DisplayClass123_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass123_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AC7 RID: 23239
				// (get) Token: 0x06011768 RID: 71528 RVA: 0x00402DBC File Offset: 0x00400FBC
				// (set) Token: 0x06011769 RID: 71529 RVA: 0x00097F4A File Offset: 0x0009614A
				public unsafe Il2CppReferenceArray<IEnumerable<NormalGuest>> _normalGuestPool_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr__normalGuestPool_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEnumerable<NormalGuest>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIE1NoObObUnique.NativeFieldInfoPtr__normalGuestPool_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B075 RID: 45173
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B076 RID: 45174
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B077 RID: 45175
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B078 RID: 45176
				private static readonly IntPtr NativeFieldInfoPtr__normalGuestPool_5__2;

				// Token: 0x0400B079 RID: 45177
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B07A RID: 45178
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B07B RID: 45179
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B07C RID: 45180
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B07D RID: 45181
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B07E RID: 45182
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000FE7 RID: 4071
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass123_0+<<ManualSpawnGuestGroupsFromTargetIzakaya>g__OnSpecialGuestSpawning|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601176A RID: 71530 RVA: 0x00402DEC File Offset: 0x00400FEC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0>.NativeClassPtr, "<<ManualSpawnGuestGroupsFromTargetIzakaya>g__OnSpecialGuestSpawning|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<wait>5__2");
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671917);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671918);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671919);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671920);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671921);
					GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100671922);
				}

				// Token: 0x0601176B RID: 71531 RVA: 0x00402EE0 File Offset: 0x004010E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601176C RID: 71532 RVA: 0x00402F28 File Offset: 0x00401128
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601176D RID: 71533 RVA: 0x00402F5C File Offset: 0x0040115C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106314, XrefRangeEnd = 106403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005ACE RID: 23246
				// (get) Token: 0x0601176E RID: 71534 RVA: 0x00402F98 File Offset: 0x00401198
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601176F RID: 71535 RVA: 0x00402FD8 File Offset: 0x004011D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106403, XrefRangeEnd = 106409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005ACF RID: 23247
				// (get) Token: 0x06011770 RID: 71536 RVA: 0x0040300C File Offset: 0x0040120C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011771 RID: 71537 RVA: 0x00097F69 File Offset: 0x00096169
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005ACA RID: 23242
				// (get) Token: 0x06011772 RID: 71538 RVA: 0x0040304C File Offset: 0x0040124C
				// (set) Token: 0x06011773 RID: 71539 RVA: 0x00097F72 File Offset: 0x00096172
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005ACB RID: 23243
				// (get) Token: 0x06011774 RID: 71540 RVA: 0x00403074 File Offset: 0x00401274
				// (set) Token: 0x06011775 RID: 71541 RVA: 0x00097F8D File Offset: 0x0009618D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005ACC RID: 23244
				// (get) Token: 0x06011776 RID: 71542 RVA: 0x004030A4 File Offset: 0x004012A4
				// (set) Token: 0x06011777 RID: 71543 RVA: 0x00097FAC File Offset: 0x000961AC
				public unsafe GuestsManager.__c__DisplayClass123_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass123_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005ACD RID: 23245
				// (get) Token: 0x06011778 RID: 71544 RVA: 0x004030D4 File Offset: 0x004012D4
				// (set) Token: 0x06011779 RID: 71545 RVA: 0x00097FCB File Offset: 0x000961CB
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass123_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B07F RID: 45183
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B080 RID: 45184
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B081 RID: 45185
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B082 RID: 45186
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400B083 RID: 45187
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B084 RID: 45188
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B085 RID: 45189
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B086 RID: 45190
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B087 RID: 45191
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B088 RID: 45192
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000833 RID: 2099
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass124_0")]
		public sealed class __c__DisplayClass124_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AB92 RID: 43922 RVA: 0x002C58F8 File Offset: 0x002C3AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass124_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass124_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "continueToSpawnAfterDayEnd");
				GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_onAllGuestSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "onAllGuestSpawned");
				GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_spawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "spawnInterval");
				GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "coroutine");
				GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, 100671923);
				GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, 100671924);
				GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, 100671925);
			}

			// Token: 0x0600AB93 RID: 43923 RVA: 0x002C59C4 File Offset: 0x002C3BC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass124_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB94 RID: 43924 RVA: 0x002C5A00 File Offset: 0x002C3C00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 106569, RefRangeEnd = 106570, XrefRangeStart = 106564, XrefRangeEnd = 106569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AB95 RID: 43925 RVA: 0x002C5A40 File Offset: 0x002C3C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106570, XrefRangeEnd = 106571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AB96 RID: 43926 RVA: 0x0005C69B File Offset: 0x0005A89B
			public __c__DisplayClass124_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700385D RID: 14429
			// (get) Token: 0x0600AB97 RID: 43927 RVA: 0x002C5A74 File Offset: 0x002C3C74
			// (set) Token: 0x0600AB98 RID: 43928 RVA: 0x0005C6A4 File Offset: 0x0005A8A4
			public unsafe bool continueToSpawnAfterDayEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_continueToSpawnAfterDayEnd)) = value;
				}
			}

			// Token: 0x1700385E RID: 14430
			// (get) Token: 0x0600AB99 RID: 43929 RVA: 0x002C5A9C File Offset: 0x002C3C9C
			// (set) Token: 0x0600AB9A RID: 43930 RVA: 0x0005C6BF File Offset: 0x0005A8BF
			public unsafe Action onAllGuestSpawned
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_onAllGuestSpawned);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_onAllGuestSpawned), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700385F RID: 14431
			// (get) Token: 0x0600AB9B RID: 43931 RVA: 0x002C5ACC File Offset: 0x002C3CCC
			// (set) Token: 0x0600AB9C RID: 43932 RVA: 0x0005C6DE File Offset: 0x0005A8DE
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003860 RID: 14432
			// (get) Token: 0x0600AB9D RID: 43933 RVA: 0x002C5AFC File Offset: 0x002C3CFC
			// (set) Token: 0x0600AB9E RID: 43934 RVA: 0x0005C6FD File Offset: 0x0005A8FD
			public unsafe int spawnInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_spawnInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_spawnInterval)) = value;
				}
			}

			// Token: 0x17003861 RID: 14433
			// (get) Token: 0x0600AB9F RID: 43935 RVA: 0x002C5B24 File Offset: 0x002C3D24
			// (set) Token: 0x0600ABA0 RID: 43936 RVA: 0x0005C718 File Offset: 0x0005A918
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EDC RID: 28380
			private static readonly IntPtr NativeFieldInfoPtr_continueToSpawnAfterDayEnd;

			// Token: 0x04006EDD RID: 28381
			private static readonly IntPtr NativeFieldInfoPtr_onAllGuestSpawned;

			// Token: 0x04006EDE RID: 28382
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006EDF RID: 28383
			private static readonly IntPtr NativeFieldInfoPtr_spawnInterval;

			// Token: 0x04006EE0 RID: 28384
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04006EE1 RID: 28385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EE2 RID: 28386
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04006EE3 RID: 28387
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02000FE8 RID: 4072
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass124_0+<<ManualSpawnSpecialGuestGroupsFromPoolForSara>g__OnSpecialGuestSpawning|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601177A RID: 71546 RVA: 0x00403104 File Offset: 0x00401304
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0>.NativeClassPtr, "<<ManualSpawnSpecialGuestGroupsFromPoolForSara>g__OnSpecialGuestSpawning|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>8__1");
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671926);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671927);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671928);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671929);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671930);
					GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671931);
				}

				// Token: 0x0601177B RID: 71547 RVA: 0x004031F8 File Offset: 0x004013F8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601177C RID: 71548 RVA: 0x00403240 File Offset: 0x00401440
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601177D RID: 71549 RVA: 0x00403274 File Offset: 0x00401474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106423, XrefRangeEnd = 106558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AD4 RID: 23252
				// (get) Token: 0x0601177E RID: 71550 RVA: 0x004032B0 File Offset: 0x004014B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601177F RID: 71551 RVA: 0x004032F0 File Offset: 0x004014F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106558, XrefRangeEnd = 106564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AD5 RID: 23253
				// (get) Token: 0x06011780 RID: 71552 RVA: 0x00403324 File Offset: 0x00401524
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011781 RID: 71553 RVA: 0x00097FEA File Offset: 0x000961EA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AD0 RID: 23248
				// (get) Token: 0x06011782 RID: 71554 RVA: 0x00403364 File Offset: 0x00401564
				// (set) Token: 0x06011783 RID: 71555 RVA: 0x00097FF3 File Offset: 0x000961F3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AD1 RID: 23249
				// (get) Token: 0x06011784 RID: 71556 RVA: 0x0040338C File Offset: 0x0040158C
				// (set) Token: 0x06011785 RID: 71557 RVA: 0x0009800E File Offset: 0x0009620E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AD2 RID: 23250
				// (get) Token: 0x06011786 RID: 71558 RVA: 0x004033BC File Offset: 0x004015BC
				// (set) Token: 0x06011787 RID: 71559 RVA: 0x0009802D File Offset: 0x0009622D
				public unsafe GuestsManager.__c__DisplayClass124_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass124_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AD3 RID: 23251
				// (get) Token: 0x06011788 RID: 71560 RVA: 0x004033EC File Offset: 0x004015EC
				// (set) Token: 0x06011789 RID: 71561 RVA: 0x0009804C File Offset: 0x0009624C
				public unsafe GuestsManager.__c__DisplayClass124_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass124_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B089 RID: 45193
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B08A RID: 45194
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B08B RID: 45195
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B08C RID: 45196
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B08D RID: 45197
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B08E RID: 45198
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B08F RID: 45199
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B090 RID: 45200
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B091 RID: 45201
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B092 RID: 45202
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000834 RID: 2100
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass124_1")]
		public sealed class __c__DisplayClass124_1 : Il2CppSystem.Object
		{
			// Token: 0x0600ABA1 RID: 43937 RVA: 0x002C5B54 File Offset: 0x002C3D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass124_1()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass124_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr);
				GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_invitedGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, "invitedGuests");
				GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allGuestCouldSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, "allGuestCouldSpawn");
				GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allAvailableGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, "allAvailableGuest");
				GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, 100671932);
				GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, 100671933);
				GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, 100671934);
				GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr, 100671935);
			}

			// Token: 0x0600ABA2 RID: 43938 RVA: 0x002C5C0C File Offset: 0x002C3E0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass124_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABA3 RID: 43939 RVA: 0x002C5C48 File Offset: 0x002C3E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106571, XrefRangeEnd = 106574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ABA4 RID: 43940 RVA: 0x002C5C94 File Offset: 0x002C3E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106574, XrefRangeEnd = 106620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ABA5 RID: 43941 RVA: 0x002C5CE0 File Offset: 0x002C3EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106620, XrefRangeEnd = 106643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABA6 RID: 43942 RVA: 0x0005C737 File Offset: 0x0005A937
			public __c__DisplayClass124_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003862 RID: 14434
			// (get) Token: 0x0600ABA7 RID: 43943 RVA: 0x002C5D14 File Offset: 0x002C3F14
			// (set) Token: 0x0600ABA8 RID: 43944 RVA: 0x0005C740 File Offset: 0x0005A940
			public unsafe IList<int> invitedGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_invitedGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_invitedGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003863 RID: 14435
			// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x002C5D44 File Offset: 0x002C3F44
			// (set) Token: 0x0600ABAA RID: 43946 RVA: 0x0005C75F File Offset: 0x0005A95F
			public unsafe List<int> allGuestCouldSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allGuestCouldSpawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allGuestCouldSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003864 RID: 14436
			// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x002C5D74 File Offset: 0x002C3F74
			// (set) Token: 0x0600ABAC RID: 43948 RVA: 0x0005C77E File Offset: 0x0005A97E
			public unsafe List<int> allAvailableGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allAvailableGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_1.NativeFieldInfoPtr_allAvailableGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EE4 RID: 28388
			private static readonly IntPtr NativeFieldInfoPtr_invitedGuests;

			// Token: 0x04006EE5 RID: 28389
			private static readonly IntPtr NativeFieldInfoPtr_allGuestCouldSpawn;

			// Token: 0x04006EE6 RID: 28390
			private static readonly IntPtr NativeFieldInfoPtr_allAvailableGuest;

			// Token: 0x04006EE7 RID: 28391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EE8 RID: 28392
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__4_Internal_Boolean_Int32_0;

			// Token: 0x04006EE9 RID: 28393
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__5_Internal_Boolean_Int32_0;

			// Token: 0x04006EEA RID: 28394
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000835 RID: 2101
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass124_2")]
		public sealed class __c__DisplayClass124_2 : Il2CppSystem.Object
		{
			// Token: 0x0600ABAD RID: 43949 RVA: 0x002C5DA4 File Offset: 0x002C3FA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass124_2()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass124_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr);
				GuestsManager.__c__DisplayClass124_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr, "x");
				GuestsManager.__c__DisplayClass124_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr, 100671936);
				GuestsManager.__c__DisplayClass124_2.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__8_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr, 100671937);
			}

			// Token: 0x0600ABAE RID: 43950 RVA: 0x002C5E0C File Offset: 0x002C400C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass124_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass124_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABAF RID: 43951 RVA: 0x002C5E48 File Offset: 0x002C4048
			[CallerCount(0)]
			public unsafe bool _ManualSpawnSpecialGuestGroupsFromPoolForSara_b__8(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass124_2.NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__8_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ABB0 RID: 43952 RVA: 0x0005C79D File Offset: 0x0005A99D
			public __c__DisplayClass124_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003865 RID: 14437
			// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x002C5E94 File Offset: 0x002C4094
			// (set) Token: 0x0600ABB2 RID: 43954 RVA: 0x0005C7A6 File Offset: 0x0005A9A6
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_2.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass124_2.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04006EEB RID: 28395
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006EEC RID: 28396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EED RID: 28397
			private static readonly IntPtr NativeMethodInfoPtr__ManualSpawnSpecialGuestGroupsFromPoolForSara_b__8_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000836 RID: 2102
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass125_0")]
		public sealed class __c__DisplayClass125_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ABB3 RID: 43955 RVA: 0x002C5EBC File Offset: 0x002C40BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass125_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass125_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr, "value");
				GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_math = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr, "math");
				GuestsManager.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr, 100671938);
				GuestsManager.__c__DisplayClass125_0.NativeMethodInfoPtr__MoodEdit_b__0_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr, 100671939);
			}

			// Token: 0x0600ABB4 RID: 43956 RVA: 0x002C5F38 File Offset: 0x002C4138
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass125_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass125_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABB5 RID: 43957 RVA: 0x002C5F74 File Offset: 0x002C4174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106643, XrefRangeEnd = 106649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoodEdit_b__0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass125_0.NativeMethodInfoPtr__MoodEdit_b__0_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABB6 RID: 43958 RVA: 0x0005C7C1 File Offset: 0x0005A9C1
			public __c__DisplayClass125_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003866 RID: 14438
			// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x002C5FB8 File Offset: 0x002C41B8
			// (set) Token: 0x0600ABB8 RID: 43960 RVA: 0x0005C7CA File Offset: 0x0005A9CA
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x17003867 RID: 14439
			// (get) Token: 0x0600ABB9 RID: 43961 RVA: 0x002C5FE0 File Offset: 0x002C41E0
			// (set) Token: 0x0600ABBA RID: 43962 RVA: 0x0005C7E5 File Offset: 0x0005A9E5
			public unsafe EventManager.MathOperation math
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_math);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass125_0.NativeFieldInfoPtr_math)) = value;
				}
			}

			// Token: 0x04006EEE RID: 28398
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04006EEF RID: 28399
			private static readonly IntPtr NativeFieldInfoPtr_math;

			// Token: 0x04006EF0 RID: 28400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EF1 RID: 28401
			private static readonly IntPtr NativeMethodInfoPtr__MoodEdit_b__0_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000837 RID: 2103
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass128_0")]
		public sealed class __c__DisplayClass128_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ABBB RID: 43963 RVA: 0x002C6008 File Offset: 0x002C4208
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass128_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass128_0.NativeFieldInfoPtr_sustainedPannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr, "sustainedPannelInstance");
				GuestsManager.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr, 100671940);
				GuestsManager.__c__DisplayClass128_0.NativeMethodInfoPtr__CloseIzakayaDelayed_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr, 100671941);
			}

			// Token: 0x0600ABBC RID: 43964 RVA: 0x002C6070 File Offset: 0x002C4270
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABBD RID: 43965 RVA: 0x002C60AC File Offset: 0x002C42AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106649, XrefRangeEnd = 106663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaDelayed_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass128_0.NativeMethodInfoPtr__CloseIzakayaDelayed_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABBE RID: 43966 RVA: 0x0005C800 File Offset: 0x0005AA00
			public __c__DisplayClass128_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003868 RID: 14440
			// (get) Token: 0x0600ABBF RID: 43967 RVA: 0x002C60E0 File Offset: 0x002C42E0
			// (set) Token: 0x0600ABC0 RID: 43968 RVA: 0x0005C809 File Offset: 0x0005AA09
			public unsafe WorkSceneSustainedPannel sustainedPannelInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_0.NativeFieldInfoPtr_sustainedPannelInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_0.NativeFieldInfoPtr_sustainedPannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EF2 RID: 28402
			private static readonly IntPtr NativeFieldInfoPtr_sustainedPannelInstance;

			// Token: 0x04006EF3 RID: 28403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EF4 RID: 28404
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__2_Internal_Void_0;
		}

		// Token: 0x02000838 RID: 2104
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass128_1")]
		public sealed class __c__DisplayClass128_1 : Il2CppSystem.Object
		{
			// Token: 0x0600ABC1 RID: 43969 RVA: 0x002C6110 File Offset: 0x002C4310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_1()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass128_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr);
				GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_extraPartnerWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr, "extraPartnerWage");
				GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_haveExtraPartnerWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr, "haveExtraPartnerWage");
				GuestsManager.__c__DisplayClass128_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr, 100671942);
				GuestsManager.__c__DisplayClass128_1.NativeMethodInfoPtr__CloseIzakayaDelayed_b__3_Internal_Single_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr, 100671943);
			}

			// Token: 0x0600ABC2 RID: 43970 RVA: 0x002C618C File Offset: 0x002C438C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass128_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass128_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABC3 RID: 43971 RVA: 0x002C61C8 File Offset: 0x002C43C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106663, XrefRangeEnd = 106665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CloseIzakayaDelayed_b__3(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass128_1.NativeMethodInfoPtr__CloseIzakayaDelayed_b__3_Internal_Single_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ABC4 RID: 43972 RVA: 0x0005C828 File Offset: 0x0005AA28
			public __c__DisplayClass128_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003869 RID: 14441
			// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x002C6218 File Offset: 0x002C4418
			// (set) Token: 0x0600ABC6 RID: 43974 RVA: 0x0005C831 File Offset: 0x0005AA31
			public unsafe float extraPartnerWage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_extraPartnerWage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_extraPartnerWage)) = value;
				}
			}

			// Token: 0x1700386A RID: 14442
			// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x002C6240 File Offset: 0x002C4440
			// (set) Token: 0x0600ABC8 RID: 43976 RVA: 0x0005C84C File Offset: 0x0005AA4C
			public unsafe bool haveExtraPartnerWage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_haveExtraPartnerWage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass128_1.NativeFieldInfoPtr_haveExtraPartnerWage)) = value;
				}
			}

			// Token: 0x04006EF5 RID: 28405
			private static readonly IntPtr NativeFieldInfoPtr_extraPartnerWage;

			// Token: 0x04006EF6 RID: 28406
			private static readonly IntPtr NativeFieldInfoPtr_haveExtraPartnerWage;

			// Token: 0x04006EF7 RID: 28407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006EF8 RID: 28408
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaDelayed_b__3_Internal_Single_PartnerBase_0;
		}

		// Token: 0x02000839 RID: 2105
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<CloseIzakayaDelayed>d__128")]
		public sealed class _CloseIzakayaDelayed_d__128 : Il2CppSystem.Object
		{
			// Token: 0x0600ABC9 RID: 43977 RVA: 0x002C6268 File Offset: 0x002C4468
			// Note: this type is marked as 'beforefieldinit'.
			static _CloseIzakayaDelayed_d__128()
			{
				Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<CloseIzakayaDelayed>d__128");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "<>1__state");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "<>2__current");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "<>4__this");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_izakayaCloseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "izakayaCloseType");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "<>8__1");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_onSessionLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, "onSessionLeave");
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671944);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671945);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671946);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671947);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671948);
				GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr, 100671949);
			}

			// Token: 0x0600ABCA RID: 43978 RVA: 0x002C6384 File Offset: 0x002C4584
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CloseIzakayaDelayed_d__128(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._CloseIzakayaDelayed_d__128>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABCB RID: 43979 RVA: 0x002C63CC File Offset: 0x002C45CC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABCC RID: 43980 RVA: 0x002C6400 File Offset: 0x002C4600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106665, XrefRangeEnd = 106722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003871 RID: 14449
			// (get) Token: 0x0600ABCD RID: 43981 RVA: 0x002C643C File Offset: 0x002C463C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ABCE RID: 43982 RVA: 0x002C647C File Offset: 0x002C467C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106722, XrefRangeEnd = 106728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003872 RID: 14450
			// (get) Token: 0x0600ABCF RID: 43983 RVA: 0x002C64B0 File Offset: 0x002C46B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._CloseIzakayaDelayed_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ABD0 RID: 43984 RVA: 0x0005C867 File Offset: 0x0005AA67
			public _CloseIzakayaDelayed_d__128(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700386B RID: 14443
			// (get) Token: 0x0600ABD1 RID: 43985 RVA: 0x002C64F0 File Offset: 0x002C46F0
			// (set) Token: 0x0600ABD2 RID: 43986 RVA: 0x0005C870 File Offset: 0x0005AA70
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700386C RID: 14444
			// (get) Token: 0x0600ABD3 RID: 43987 RVA: 0x002C6518 File Offset: 0x002C4718
			// (set) Token: 0x0600ABD4 RID: 43988 RVA: 0x0005C88B File Offset: 0x0005AA8B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700386D RID: 14445
			// (get) Token: 0x0600ABD5 RID: 43989 RVA: 0x002C6548 File Offset: 0x002C4748
			// (set) Token: 0x0600ABD6 RID: 43990 RVA: 0x0005C8AA File Offset: 0x0005AAAA
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700386E RID: 14446
			// (get) Token: 0x0600ABD7 RID: 43991 RVA: 0x002C6578 File Offset: 0x002C4778
			// (set) Token: 0x0600ABD8 RID: 43992 RVA: 0x0005C8C9 File Offset: 0x0005AAC9
			public unsafe GuestsManager.IzakayaCloseType izakayaCloseType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_izakayaCloseType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_izakayaCloseType)) = value;
				}
			}

			// Token: 0x1700386F RID: 14447
			// (get) Token: 0x0600ABD9 RID: 43993 RVA: 0x002C65A0 File Offset: 0x002C47A0
			// (set) Token: 0x0600ABDA RID: 43994 RVA: 0x0005C8E4 File Offset: 0x0005AAE4
			public unsafe GuestsManager.__c__DisplayClass128_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass128_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003870 RID: 14448
			// (get) Token: 0x0600ABDB RID: 43995 RVA: 0x002C65D0 File Offset: 0x002C47D0
			// (set) Token: 0x0600ABDC RID: 43996 RVA: 0x0005C903 File Offset: 0x0005AB03
			public unsafe Action onSessionLeave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_onSessionLeave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._CloseIzakayaDelayed_d__128.NativeFieldInfoPtr_onSessionLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EF9 RID: 28409
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006EFA RID: 28410
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006EFB RID: 28411
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006EFC RID: 28412
			private static readonly IntPtr NativeFieldInfoPtr_izakayaCloseType;

			// Token: 0x04006EFD RID: 28413
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006EFE RID: 28414
			private static readonly IntPtr NativeFieldInfoPtr_onSessionLeave;

			// Token: 0x04006EFF RID: 28415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F00 RID: 28416
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F01 RID: 28417
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F02 RID: 28418
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F03 RID: 28419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F04 RID: 28420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200083A RID: 2106
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass129_0")]
		public sealed class __c__DisplayClass129_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ABDD RID: 43997 RVA: 0x002C6600 File Offset: 0x002C4800
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass129_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass129_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_sustainedPannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, "sustainedPannelInstance");
				GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_onSessionLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, "onSessionLeave");
				GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_needAutoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, "needAutoFadeOut");
				GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, "<>9__2");
				GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, "<>9__1");
				GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, 100671950);
				GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, 100671951);
				GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, 100671952);
				GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr, 100671953);
			}

			// Token: 0x0600ABDE RID: 43998 RVA: 0x002C66E0 File Offset: 0x002C48E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass129_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass129_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABDF RID: 43999 RVA: 0x002C671C File Offset: 0x002C491C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106728, XrefRangeEnd = 106744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaAndLeaveChallengeMode_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABE0 RID: 44000 RVA: 0x002C6750 File Offset: 0x002C4950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106744, XrefRangeEnd = 106758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaAndLeaveChallengeMode_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABE1 RID: 44001 RVA: 0x002C6784 File Offset: 0x002C4984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106758, XrefRangeEnd = 106766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseIzakayaAndLeaveChallengeMode_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass129_0.NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABE2 RID: 44002 RVA: 0x0005C922 File Offset: 0x0005AB22
			public __c__DisplayClass129_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003873 RID: 14451
			// (get) Token: 0x0600ABE3 RID: 44003 RVA: 0x002C67B8 File Offset: 0x002C49B8
			// (set) Token: 0x0600ABE4 RID: 44004 RVA: 0x0005C92B File Offset: 0x0005AB2B
			public unsafe WorkSceneSustainedPannel sustainedPannelInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_sustainedPannelInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_sustainedPannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003874 RID: 14452
			// (get) Token: 0x0600ABE5 RID: 44005 RVA: 0x002C67E8 File Offset: 0x002C49E8
			// (set) Token: 0x0600ABE6 RID: 44006 RVA: 0x0005C94A File Offset: 0x0005AB4A
			public unsafe Action onSessionLeave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_onSessionLeave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_onSessionLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003875 RID: 14453
			// (get) Token: 0x0600ABE7 RID: 44007 RVA: 0x002C6818 File Offset: 0x002C4A18
			// (set) Token: 0x0600ABE8 RID: 44008 RVA: 0x0005C969 File Offset: 0x0005AB69
			public unsafe bool needAutoFadeOut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_needAutoFadeOut);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr_needAutoFadeOut)) = value;
				}
			}

			// Token: 0x17003876 RID: 14454
			// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x002C6840 File Offset: 0x002C4A40
			// (set) Token: 0x0600ABEA RID: 44010 RVA: 0x0005C984 File Offset: 0x0005AB84
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003877 RID: 14455
			// (get) Token: 0x0600ABEB RID: 44011 RVA: 0x002C6870 File Offset: 0x002C4A70
			// (set) Token: 0x0600ABEC RID: 44012 RVA: 0x0005C9A3 File Offset: 0x0005ABA3
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass129_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F05 RID: 28421
			private static readonly IntPtr NativeFieldInfoPtr_sustainedPannelInstance;

			// Token: 0x04006F06 RID: 28422
			private static readonly IntPtr NativeFieldInfoPtr_onSessionLeave;

			// Token: 0x04006F07 RID: 28423
			private static readonly IntPtr NativeFieldInfoPtr_needAutoFadeOut;

			// Token: 0x04006F08 RID: 28424
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006F09 RID: 28425
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006F0A RID: 28426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F0B RID: 28427
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__0_Internal_Void_0;

			// Token: 0x04006F0C RID: 28428
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__1_Internal_Void_0;

			// Token: 0x04006F0D RID: 28429
			private static readonly IntPtr NativeMethodInfoPtr__CloseIzakayaAndLeaveChallengeMode_b__2_Internal_Void_0;
		}

		// Token: 0x0200083B RID: 2107
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<OnWaitForAllGuestToLeave>d__132")]
		public sealed class _OnWaitForAllGuestToLeave_d__132 : Il2CppSystem.Object
		{
			// Token: 0x0600ABED RID: 44013 RVA: 0x002C68A0 File Offset: 0x002C4AA0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnWaitForAllGuestToLeave_d__132()
			{
				Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnWaitForAllGuestToLeave>d__132");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, "<>1__state");
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, "<>2__current");
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, "<>4__this");
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, "onFinish");
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671954);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671955);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671956);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671957);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671958);
				GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr, 100671959);
			}

			// Token: 0x0600ABEE RID: 44014 RVA: 0x002C6994 File Offset: 0x002C4B94
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnWaitForAllGuestToLeave_d__132(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeave_d__132>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABEF RID: 44015 RVA: 0x002C69DC File Offset: 0x002C4BDC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABF0 RID: 44016 RVA: 0x002C6A10 File Offset: 0x002C4C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106766, XrefRangeEnd = 106779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700387C RID: 14460
			// (get) Token: 0x0600ABF1 RID: 44017 RVA: 0x002C6A4C File Offset: 0x002C4C4C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ABF2 RID: 44018 RVA: 0x002C6A8C File Offset: 0x002C4C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106779, XrefRangeEnd = 106785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700387D RID: 14461
			// (get) Token: 0x0600ABF3 RID: 44019 RVA: 0x002C6AC0 File Offset: 0x002C4CC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ABF4 RID: 44020 RVA: 0x0005C9C2 File Offset: 0x0005ABC2
			public _OnWaitForAllGuestToLeave_d__132(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003878 RID: 14456
			// (get) Token: 0x0600ABF5 RID: 44021 RVA: 0x002C6B00 File Offset: 0x002C4D00
			// (set) Token: 0x0600ABF6 RID: 44022 RVA: 0x0005C9CB File Offset: 0x0005ABCB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003879 RID: 14457
			// (get) Token: 0x0600ABF7 RID: 44023 RVA: 0x002C6B28 File Offset: 0x002C4D28
			// (set) Token: 0x0600ABF8 RID: 44024 RVA: 0x0005C9E6 File Offset: 0x0005ABE6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700387A RID: 14458
			// (get) Token: 0x0600ABF9 RID: 44025 RVA: 0x002C6B58 File Offset: 0x002C4D58
			// (set) Token: 0x0600ABFA RID: 44026 RVA: 0x0005CA05 File Offset: 0x0005AC05
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700387B RID: 14459
			// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x002C6B88 File Offset: 0x002C4D88
			// (set) Token: 0x0600ABFC RID: 44028 RVA: 0x0005CA24 File Offset: 0x0005AC24
			public unsafe Func<IEnumerator> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeave_d__132.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F0E RID: 28430
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F0F RID: 28431
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F10 RID: 28432
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F11 RID: 28433
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006F12 RID: 28434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F13 RID: 28435
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F14 RID: 28436
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F15 RID: 28437
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F16 RID: 28438
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F17 RID: 28439
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200083C RID: 2108
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<OnWaitForAllGuestDisAppear>d__133")]
		public sealed class _OnWaitForAllGuestDisAppear_d__133 : Il2CppSystem.Object
		{
			// Token: 0x0600ABFD RID: 44029 RVA: 0x002C6BB8 File Offset: 0x002C4DB8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnWaitForAllGuestDisAppear_d__133()
			{
				Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnWaitForAllGuestDisAppear>d__133");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, "<>1__state");
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, "<>2__current");
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, "<>4__this");
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, "onFinish");
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671960);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671961);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671962);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671963);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671964);
				GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr, 100671965);
			}

			// Token: 0x0600ABFE RID: 44030 RVA: 0x002C6CAC File Offset: 0x002C4EAC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnWaitForAllGuestDisAppear_d__133(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestDisAppear_d__133>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ABFF RID: 44031 RVA: 0x002C6CF4 File Offset: 0x002C4EF4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC00 RID: 44032 RVA: 0x002C6D28 File Offset: 0x002C4F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106785, XrefRangeEnd = 106788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003882 RID: 14466
			// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x002C6D64 File Offset: 0x002C4F64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC02 RID: 44034 RVA: 0x002C6DA4 File Offset: 0x002C4FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106788, XrefRangeEnd = 106794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003883 RID: 14467
			// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x002C6DD8 File Offset: 0x002C4FD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC04 RID: 44036 RVA: 0x0005CA43 File Offset: 0x0005AC43
			public _OnWaitForAllGuestDisAppear_d__133(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700387E RID: 14462
			// (get) Token: 0x0600AC05 RID: 44037 RVA: 0x002C6E18 File Offset: 0x002C5018
			// (set) Token: 0x0600AC06 RID: 44038 RVA: 0x0005CA4C File Offset: 0x0005AC4C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700387F RID: 14463
			// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x002C6E40 File Offset: 0x002C5040
			// (set) Token: 0x0600AC08 RID: 44040 RVA: 0x0005CA67 File Offset: 0x0005AC67
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003880 RID: 14464
			// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x002C6E70 File Offset: 0x002C5070
			// (set) Token: 0x0600AC0A RID: 44042 RVA: 0x0005CA86 File Offset: 0x0005AC86
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003881 RID: 14465
			// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x002C6EA0 File Offset: 0x002C50A0
			// (set) Token: 0x0600AC0C RID: 44044 RVA: 0x0005CAA5 File Offset: 0x0005ACA5
			public unsafe Func<IEnumerator> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestDisAppear_d__133.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F18 RID: 28440
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F19 RID: 28441
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F1A RID: 28442
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F1B RID: 28443
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006F1C RID: 28444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F1D RID: 28445
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F1E RID: 28446
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F1F RID: 28447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F20 RID: 28448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F21 RID: 28449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200083D RID: 2109
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<OnWaitForAllGuestToLeaveForRogueLike>d__134")]
		public sealed class _OnWaitForAllGuestToLeaveForRogueLike_d__134 : Il2CppSystem.Object
		{
			// Token: 0x0600AC0D RID: 44045 RVA: 0x002C6ED0 File Offset: 0x002C50D0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnWaitForAllGuestToLeaveForRogueLike_d__134()
			{
				Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnWaitForAllGuestToLeaveForRogueLike>d__134");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "<>1__state");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "<>2__current");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "<>4__this");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "extraWaitTime");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "extraCheck");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onGuestAllLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "onGuestAllLeave");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "onFinish");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__extra_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "<extra>5__2");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, "<wait>5__3");
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671966);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671967);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671968);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671969);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671970);
				GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr, 100671971);
			}

			// Token: 0x0600AC0E RID: 44046 RVA: 0x002C7028 File Offset: 0x002C5228
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnWaitForAllGuestToLeaveForRogueLike_d__134(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC0F RID: 44047 RVA: 0x002C7070 File Offset: 0x002C5270
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC10 RID: 44048 RVA: 0x002C70A4 File Offset: 0x002C52A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106794, XrefRangeEnd = 106807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700388D RID: 14477
			// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x002C70E0 File Offset: 0x002C52E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC12 RID: 44050 RVA: 0x002C7120 File Offset: 0x002C5320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106807, XrefRangeEnd = 106813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700388E RID: 14478
			// (get) Token: 0x0600AC13 RID: 44051 RVA: 0x002C7154 File Offset: 0x002C5354
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC14 RID: 44052 RVA: 0x0005CAC4 File Offset: 0x0005ACC4
			public _OnWaitForAllGuestToLeaveForRogueLike_d__134(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003884 RID: 14468
			// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x002C7194 File Offset: 0x002C5394
			// (set) Token: 0x0600AC16 RID: 44054 RVA: 0x0005CACD File Offset: 0x0005ACCD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003885 RID: 14469
			// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x002C71BC File Offset: 0x002C53BC
			// (set) Token: 0x0600AC18 RID: 44056 RVA: 0x0005CAE8 File Offset: 0x0005ACE8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003886 RID: 14470
			// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x002C71EC File Offset: 0x002C53EC
			// (set) Token: 0x0600AC1A RID: 44058 RVA: 0x0005CB07 File Offset: 0x0005AD07
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003887 RID: 14471
			// (get) Token: 0x0600AC1B RID: 44059 RVA: 0x002C721C File Offset: 0x002C541C
			// (set) Token: 0x0600AC1C RID: 44060 RVA: 0x0005CB26 File Offset: 0x0005AD26
			public unsafe int extraWaitTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraWaitTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraWaitTime)) = value;
				}
			}

			// Token: 0x17003888 RID: 14472
			// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x002C7244 File Offset: 0x002C5444
			// (set) Token: 0x0600AC1E RID: 44062 RVA: 0x0005CB41 File Offset: 0x0005AD41
			public unsafe Func<bool> extraCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_extraCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003889 RID: 14473
			// (get) Token: 0x0600AC1F RID: 44063 RVA: 0x002C7274 File Offset: 0x002C5474
			// (set) Token: 0x0600AC20 RID: 44064 RVA: 0x0005CB60 File Offset: 0x0005AD60
			public unsafe Action onGuestAllLeave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onGuestAllLeave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onGuestAllLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700388A RID: 14474
			// (get) Token: 0x0600AC21 RID: 44065 RVA: 0x002C72A4 File Offset: 0x002C54A4
			// (set) Token: 0x0600AC22 RID: 44066 RVA: 0x0005CB7F File Offset: 0x0005AD7F
			public unsafe Func<IEnumerator> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700388B RID: 14475
			// (get) Token: 0x0600AC23 RID: 44067 RVA: 0x002C72D4 File Offset: 0x002C54D4
			// (set) Token: 0x0600AC24 RID: 44068 RVA: 0x0005CB9E File Offset: 0x0005AD9E
			public unsafe bool _extra_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__extra_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__extra_5__2)) = value;
				}
			}

			// Token: 0x1700388C RID: 14476
			// (get) Token: 0x0600AC25 RID: 44069 RVA: 0x002C72FC File Offset: 0x002C54FC
			// (set) Token: 0x0600AC26 RID: 44070 RVA: 0x0005CBB9 File Offset: 0x0005ADB9
			public unsafe WaitForSeconds _wait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__wait_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnWaitForAllGuestToLeaveForRogueLike_d__134.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F22 RID: 28450
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F23 RID: 28451
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F24 RID: 28452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F25 RID: 28453
			private static readonly IntPtr NativeFieldInfoPtr_extraWaitTime;

			// Token: 0x04006F26 RID: 28454
			private static readonly IntPtr NativeFieldInfoPtr_extraCheck;

			// Token: 0x04006F27 RID: 28455
			private static readonly IntPtr NativeFieldInfoPtr_onGuestAllLeave;

			// Token: 0x04006F28 RID: 28456
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006F29 RID: 28457
			private static readonly IntPtr NativeFieldInfoPtr__extra_5__2;

			// Token: 0x04006F2A RID: 28458
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

			// Token: 0x04006F2B RID: 28459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F2C RID: 28460
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F2D RID: 28461
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F2E RID: 28462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F2F RID: 28463
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F30 RID: 28464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200083E RID: 2110
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass138_0")]
		public sealed class __c__DisplayClass138_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC27 RID: 44071 RVA: 0x002C732C File Offset: 0x002C552C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass138_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass138_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, "target");
				GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, "message");
				GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_speakerTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, "speakerTarget");
				GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, 100671972);
				GuestsManager.__c__DisplayClass138_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, 100671973);
			}

			// Token: 0x0600AC28 RID: 44072 RVA: 0x002C73D0 File Offset: 0x002C55D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass138_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC29 RID: 44073 RVA: 0x002C740C File Offset: 0x002C560C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106841, XrefRangeEnd = 106846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AC2A RID: 44074 RVA: 0x0005CBD8 File Offset: 0x0005ADD8
			public __c__DisplayClass138_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700388F RID: 14479
			// (get) Token: 0x0600AC2B RID: 44075 RVA: 0x002C744C File Offset: 0x002C564C
			// (set) Token: 0x0600AC2C RID: 44076 RVA: 0x0005CBE1 File Offset: 0x0005ADE1
			public unsafe GuestGroupController target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003890 RID: 14480
			// (get) Token: 0x0600AC2D RID: 44077 RVA: 0x002C747C File Offset: 0x002C567C
			// (set) Token: 0x0600AC2E RID: 44078 RVA: 0x0005CC00 File Offset: 0x0005AE00
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003891 RID: 14481
			// (get) Token: 0x0600AC2F RID: 44079 RVA: 0x002C74A4 File Offset: 0x002C56A4
			// (set) Token: 0x0600AC30 RID: 44080 RVA: 0x0005CC1F File Offset: 0x0005AE1F
			public unsafe Transform speakerTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_speakerTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr_speakerTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003892 RID: 14482
			// (get) Token: 0x0600AC31 RID: 44081 RVA: 0x002C74D4 File Offset: 0x002C56D4
			// (set) Token: 0x0600AC32 RID: 44082 RVA: 0x0005CC3E File Offset: 0x0005AE3E
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F31 RID: 28465
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04006F32 RID: 28466
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04006F33 RID: 28467
			private static readonly IntPtr NativeFieldInfoPtr_speakerTarget;

			// Token: 0x04006F34 RID: 28468
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F35 RID: 28469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F36 RID: 28470
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000FE9 RID: 4073
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass138_0+<<OnIdleDialog>g__ShowIdleDialog|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601178A RID: 71562 RVA: 0x0040341C File Offset: 0x0040161C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0>.NativeClassPtr, "<<OnIdleDialog>g__ShowIdleDialog|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__thisTarget_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<thisTarget>5__2");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__idleDialogElement_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<idleDialogElement>5__3");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__pushCallback_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, "<pushCallback>5__4");
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671974);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671975);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671976);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671977);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671978);
					GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr, 100671979);
				}

				// Token: 0x0601178B RID: 71563 RVA: 0x00403538 File Offset: 0x00401738
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601178C RID: 71564 RVA: 0x00403580 File Offset: 0x00401780
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601178D RID: 71565 RVA: 0x004035B4 File Offset: 0x004017B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106813, XrefRangeEnd = 106835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005ADC RID: 23260
				// (get) Token: 0x0601178E RID: 71566 RVA: 0x004035F0 File Offset: 0x004017F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601178F RID: 71567 RVA: 0x00403630 File Offset: 0x00401830
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106835, XrefRangeEnd = 106841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005ADD RID: 23261
				// (get) Token: 0x06011790 RID: 71568 RVA: 0x00403664 File Offset: 0x00401864
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011791 RID: 71569 RVA: 0x0009806B File Offset: 0x0009626B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AD6 RID: 23254
				// (get) Token: 0x06011792 RID: 71570 RVA: 0x004036A4 File Offset: 0x004018A4
				// (set) Token: 0x06011793 RID: 71571 RVA: 0x00098074 File Offset: 0x00096274
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AD7 RID: 23255
				// (get) Token: 0x06011794 RID: 71572 RVA: 0x004036CC File Offset: 0x004018CC
				// (set) Token: 0x06011795 RID: 71573 RVA: 0x0009808F File Offset: 0x0009628F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AD8 RID: 23256
				// (get) Token: 0x06011796 RID: 71574 RVA: 0x004036FC File Offset: 0x004018FC
				// (set) Token: 0x06011797 RID: 71575 RVA: 0x000980AE File Offset: 0x000962AE
				public unsafe GuestsManager.__c__DisplayClass138_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass138_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AD9 RID: 23257
				// (get) Token: 0x06011798 RID: 71576 RVA: 0x0040372C File Offset: 0x0040192C
				// (set) Token: 0x06011799 RID: 71577 RVA: 0x000980CD File Offset: 0x000962CD
				public unsafe GuestGroupController _thisTarget_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__thisTarget_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__thisTarget_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005ADA RID: 23258
				// (get) Token: 0x0601179A RID: 71578 RVA: 0x0040375C File Offset: 0x0040195C
				// (set) Token: 0x0601179B RID: 71579 RVA: 0x000980EC File Offset: 0x000962EC
				public unsafe DialogBoxUI _idleDialogElement_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__idleDialogElement_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogBoxUI>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__idleDialogElement_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005ADB RID: 23259
				// (get) Token: 0x0601179C RID: 71580 RVA: 0x0040378C File Offset: 0x0040198C
				// (set) Token: 0x0601179D RID: 71581 RVA: 0x0009810B File Offset: 0x0009630B
				public unsafe Action<DialogBoxUI> _pushCallback_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__pushCallback_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DialogBoxUI>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass138_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGuDiAc1DiObObUnique.NativeFieldInfoPtr__pushCallback_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B093 RID: 45203
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B094 RID: 45204
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B095 RID: 45205
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B096 RID: 45206
				private static readonly IntPtr NativeFieldInfoPtr__thisTarget_5__2;

				// Token: 0x0400B097 RID: 45207
				private static readonly IntPtr NativeFieldInfoPtr__idleDialogElement_5__3;

				// Token: 0x0400B098 RID: 45208
				private static readonly IntPtr NativeFieldInfoPtr__pushCallback_5__4;

				// Token: 0x0400B099 RID: 45209
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B09A RID: 45210
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B09B RID: 45211
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B09C RID: 45212
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B09D RID: 45213
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B09E RID: 45214
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200083F RID: 2111
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<OnIdleDialog>d__138")]
		public sealed class _OnIdleDialog_d__138 : Il2CppSystem.Object
		{
			// Token: 0x0600AC33 RID: 44083 RVA: 0x002C7504 File Offset: 0x002C5704
			// Note: this type is marked as 'beforefieldinit'.
			static _OnIdleDialog_d__138()
			{
				Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<OnIdleDialog>d__138");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr);
				GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, "<>1__state");
				GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, "<>2__current");
				GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, "<>4__this");
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671980);
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671981);
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671982);
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671983);
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671984);
				GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr, 100671985);
			}

			// Token: 0x0600AC34 RID: 44084 RVA: 0x002C75E4 File Offset: 0x002C57E4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnIdleDialog_d__138(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._OnIdleDialog_d__138>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC35 RID: 44085 RVA: 0x002C762C File Offset: 0x002C582C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC36 RID: 44086 RVA: 0x002C7660 File Offset: 0x002C5860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106846, XrefRangeEnd = 106932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003896 RID: 14486
			// (get) Token: 0x0600AC37 RID: 44087 RVA: 0x002C769C File Offset: 0x002C589C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC38 RID: 44088 RVA: 0x002C76DC File Offset: 0x002C58DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106932, XrefRangeEnd = 106938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003897 RID: 14487
			// (get) Token: 0x0600AC39 RID: 44089 RVA: 0x002C7710 File Offset: 0x002C5910
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._OnIdleDialog_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC3A RID: 44090 RVA: 0x0005CC5D File Offset: 0x0005AE5D
			public _OnIdleDialog_d__138(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003893 RID: 14483
			// (get) Token: 0x0600AC3B RID: 44091 RVA: 0x002C7750 File Offset: 0x002C5950
			// (set) Token: 0x0600AC3C RID: 44092 RVA: 0x0005CC66 File Offset: 0x0005AE66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003894 RID: 14484
			// (get) Token: 0x0600AC3D RID: 44093 RVA: 0x002C7778 File Offset: 0x002C5978
			// (set) Token: 0x0600AC3E RID: 44094 RVA: 0x0005CC81 File Offset: 0x0005AE81
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003895 RID: 14485
			// (get) Token: 0x0600AC3F RID: 44095 RVA: 0x002C77A8 File Offset: 0x002C59A8
			// (set) Token: 0x0600AC40 RID: 44096 RVA: 0x0005CCA0 File Offset: 0x0005AEA0
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._OnIdleDialog_d__138.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F37 RID: 28471
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F38 RID: 28472
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F39 RID: 28473
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F3A RID: 28474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F3B RID: 28475
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F3C RID: 28476
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F3D RID: 28477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F3E RID: 28478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F3F RID: 28479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000840 RID: 2112
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC41 RID: 44097 RVA: 0x002C77D8 File Offset: 0x002C59D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_guestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, "guestGroupController");
				GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, "message");
				GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_boxType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, "boxType");
				GuestsManager.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, 100671986);
				GuestsManager.__c__DisplayClass139_0.NativeMethodInfoPtr__ShowTargetDialog_b__0_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr, 100671987);
			}

			// Token: 0x0600AC42 RID: 44098 RVA: 0x002C787C File Offset: 0x002C5A7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass139_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC43 RID: 44099 RVA: 0x002C78B8 File Offset: 0x002C5AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106938, XrefRangeEnd = 106942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowTargetDialog_b__0(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass139_0.NativeMethodInfoPtr__ShowTargetDialog_b__0_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC44 RID: 44100 RVA: 0x0005CCBF File Offset: 0x0005AEBF
			public __c__DisplayClass139_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003898 RID: 14488
			// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x002C78FC File Offset: 0x002C5AFC
			// (set) Token: 0x0600AC46 RID: 44102 RVA: 0x0005CCC8 File Offset: 0x0005AEC8
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003899 RID: 14489
			// (get) Token: 0x0600AC47 RID: 44103 RVA: 0x002C792C File Offset: 0x002C5B2C
			// (set) Token: 0x0600AC48 RID: 44104 RVA: 0x0005CCE7 File Offset: 0x0005AEE7
			public unsafe GuestGroupController guestGroupController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_guestGroupController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_guestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700389A RID: 14490
			// (get) Token: 0x0600AC49 RID: 44105 RVA: 0x002C795C File Offset: 0x002C5B5C
			// (set) Token: 0x0600AC4A RID: 44106 RVA: 0x0005CD06 File Offset: 0x0005AF06
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700389B RID: 14491
			// (get) Token: 0x0600AC4B RID: 44107 RVA: 0x002C7984 File Offset: 0x002C5B84
			// (set) Token: 0x0600AC4C RID: 44108 RVA: 0x0005CD25 File Offset: 0x0005AF25
			public unsafe GuestGroupController.EvaluationResult boxType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_boxType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass139_0.NativeFieldInfoPtr_boxType)) = value;
				}
			}

			// Token: 0x04006F40 RID: 28480
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F41 RID: 28481
			private static readonly IntPtr NativeFieldInfoPtr_guestGroupController;

			// Token: 0x04006F42 RID: 28482
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04006F43 RID: 28483
			private static readonly IntPtr NativeFieldInfoPtr_boxType;

			// Token: 0x04006F44 RID: 28484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F45 RID: 28485
			private static readonly IntPtr NativeMethodInfoPtr__ShowTargetDialog_b__0_Internal_Void_AStarInputGeneratorComponent_0;
		}

		// Token: 0x02000841 RID: 2113
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<ShowEvaluationDialog>d__142")]
		public sealed class _ShowEvaluationDialog_d__142 : Il2CppSystem.Object
		{
			// Token: 0x0600AC4D RID: 44109 RVA: 0x002C79AC File Offset: 0x002C5BAC
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowEvaluationDialog_d__142()
			{
				Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<ShowEvaluationDialog>d__142");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr);
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "<>1__state");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "<>2__current");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "<>4__this");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_toTalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "toTalk");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "message");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "result");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "target");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__evaluationDialogParent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "<evaluationDialogParent>5__2");
				GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__pushCallback_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, "<pushCallback>5__3");
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671988);
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671989);
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671990);
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671991);
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671992);
				GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr, 100671993);
			}

			// Token: 0x0600AC4E RID: 44110 RVA: 0x002C7B04 File Offset: 0x002C5D04
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowEvaluationDialog_d__142(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager._ShowEvaluationDialog_d__142>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC4F RID: 44111 RVA: 0x002C7B4C File Offset: 0x002C5D4C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC50 RID: 44112 RVA: 0x002C7B80 File Offset: 0x002C5D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106942, XrefRangeEnd = 106963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170038A5 RID: 14501
			// (get) Token: 0x0600AC51 RID: 44113 RVA: 0x002C7BBC File Offset: 0x002C5DBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC52 RID: 44114 RVA: 0x002C7BFC File Offset: 0x002C5DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106963, XrefRangeEnd = 106969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170038A6 RID: 14502
			// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x002C7C30 File Offset: 0x002C5E30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager._ShowEvaluationDialog_d__142.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AC54 RID: 44116 RVA: 0x0005CD40 File Offset: 0x0005AF40
			public _ShowEvaluationDialog_d__142(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700389C RID: 14492
			// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x002C7C70 File Offset: 0x002C5E70
			// (set) Token: 0x0600AC56 RID: 44118 RVA: 0x0005CD49 File Offset: 0x0005AF49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700389D RID: 14493
			// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x002C7C98 File Offset: 0x002C5E98
			// (set) Token: 0x0600AC58 RID: 44120 RVA: 0x0005CD64 File Offset: 0x0005AF64
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700389E RID: 14494
			// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x002C7CC8 File Offset: 0x002C5EC8
			// (set) Token: 0x0600AC5A RID: 44122 RVA: 0x0005CD83 File Offset: 0x0005AF83
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700389F RID: 14495
			// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x002C7CF8 File Offset: 0x002C5EF8
			// (set) Token: 0x0600AC5C RID: 44124 RVA: 0x0005CDA2 File Offset: 0x0005AFA2
			public unsafe GuestGroupController toTalk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_toTalk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_toTalk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038A0 RID: 14496
			// (get) Token: 0x0600AC5D RID: 44125 RVA: 0x002C7D28 File Offset: 0x002C5F28
			// (set) Token: 0x0600AC5E RID: 44126 RVA: 0x0005CDC1 File Offset: 0x0005AFC1
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038A1 RID: 14497
			// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x002C7D50 File Offset: 0x002C5F50
			// (set) Token: 0x0600AC60 RID: 44128 RVA: 0x0005CDE0 File Offset: 0x0005AFE0
			public unsafe GuestGroupController.EvaluationResult result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x170038A2 RID: 14498
			// (get) Token: 0x0600AC61 RID: 44129 RVA: 0x002C7D78 File Offset: 0x002C5F78
			// (set) Token: 0x0600AC62 RID: 44130 RVA: 0x0005CDFB File Offset: 0x0005AFFB
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038A3 RID: 14499
			// (get) Token: 0x0600AC63 RID: 44131 RVA: 0x002C7DA8 File Offset: 0x002C5FA8
			// (set) Token: 0x0600AC64 RID: 44132 RVA: 0x0005CE1A File Offset: 0x0005B01A
			public unsafe EvalulationBoxUI _evaluationDialogParent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__evaluationDialogParent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EvalulationBoxUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__evaluationDialogParent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038A4 RID: 14500
			// (get) Token: 0x0600AC65 RID: 44133 RVA: 0x002C7DD8 File Offset: 0x002C5FD8
			// (set) Token: 0x0600AC66 RID: 44134 RVA: 0x0005CE39 File Offset: 0x0005B039
			public unsafe Action<EvalulationBoxUI> _pushCallback_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__pushCallback_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EvalulationBoxUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager._ShowEvaluationDialog_d__142.NativeFieldInfoPtr__pushCallback_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F46 RID: 28486
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006F47 RID: 28487
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006F48 RID: 28488
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F49 RID: 28489
			private static readonly IntPtr NativeFieldInfoPtr_toTalk;

			// Token: 0x04006F4A RID: 28490
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04006F4B RID: 28491
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04006F4C RID: 28492
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04006F4D RID: 28493
			private static readonly IntPtr NativeFieldInfoPtr__evaluationDialogParent_5__2;

			// Token: 0x04006F4E RID: 28494
			private static readonly IntPtr NativeFieldInfoPtr__pushCallback_5__3;

			// Token: 0x04006F4F RID: 28495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006F50 RID: 28496
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F51 RID: 28497
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006F52 RID: 28498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006F53 RID: 28499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006F54 RID: 28500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000842 RID: 2114
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC67 RID: 44135 RVA: 0x002C7E08 File Offset: 0x002C6008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_toTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, "toTry");
				GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_shouldOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, "shouldOrder");
				GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, "<>9__1");
				GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, 100671994);
				GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__TrySendToSeat_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, 100671995);
				GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__TrySendToSeat_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr, 100671996);
			}

			// Token: 0x0600AC68 RID: 44136 RVA: 0x002C7EC0 File Offset: 0x002C60C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass143_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC69 RID: 44137 RVA: 0x002C7EFC File Offset: 0x002C60FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106969, XrefRangeEnd = 106993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TrySendToSeat_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__TrySendToSeat_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC6A RID: 44138 RVA: 0x002C7F30 File Offset: 0x002C6130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106993, XrefRangeEnd = 106996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TrySendToSeat_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass143_0.NativeMethodInfoPtr__TrySendToSeat_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC6B RID: 44139 RVA: 0x0005CE58 File Offset: 0x0005B058
			public __c__DisplayClass143_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038A7 RID: 14503
			// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x002C7F64 File Offset: 0x002C6164
			// (set) Token: 0x0600AC6D RID: 44141 RVA: 0x0005CE61 File Offset: 0x0005B061
			public unsafe GuestGroupController toTry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_toTry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_toTry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038A8 RID: 14504
			// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002C7F94 File Offset: 0x002C6194
			// (set) Token: 0x0600AC6F RID: 44143 RVA: 0x0005CE80 File Offset: 0x0005B080
			public unsafe bool shouldOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_shouldOrder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr_shouldOrder)) = value;
				}
			}

			// Token: 0x170038A9 RID: 14505
			// (get) Token: 0x0600AC70 RID: 44144 RVA: 0x002C7FBC File Offset: 0x002C61BC
			// (set) Token: 0x0600AC71 RID: 44145 RVA: 0x0005CE9B File Offset: 0x0005B09B
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AA RID: 14506
			// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x002C7FEC File Offset: 0x002C61EC
			// (set) Token: 0x0600AC73 RID: 44147 RVA: 0x0005CEBA File Offset: 0x0005B0BA
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass143_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F55 RID: 28501
			private static readonly IntPtr NativeFieldInfoPtr_toTry;

			// Token: 0x04006F56 RID: 28502
			private static readonly IntPtr NativeFieldInfoPtr_shouldOrder;

			// Token: 0x04006F57 RID: 28503
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F58 RID: 28504
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006F59 RID: 28505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F5A RID: 28506
			private static readonly IntPtr NativeMethodInfoPtr__TrySendToSeat_b__0_Internal_Void_0;

			// Token: 0x04006F5B RID: 28507
			private static readonly IntPtr NativeMethodInfoPtr__TrySendToSeat_b__1_Internal_Void_0;
		}

		// Token: 0x02000843 RID: 2115
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass164_0")]
		public sealed class __c__DisplayClass164_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC74 RID: 44148 RVA: 0x002C801C File Offset: 0x002C621C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass164_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass164_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_manualControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr, "manualControlled");
				GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_onEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr, "onEvaluate");
				GuestsManager.__c__DisplayClass164_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr, 100671997);
				GuestsManager.__c__DisplayClass164_0.NativeMethodInfoPtr__SetManualControllerOrderInternal_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr, 100671998);
			}

			// Token: 0x0600AC75 RID: 44149 RVA: 0x002C80AC File Offset: 0x002C62AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass164_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass164_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass164_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC76 RID: 44150 RVA: 0x002C80E8 File Offset: 0x002C62E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106996, XrefRangeEnd = 106998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetManualControllerOrderInternal_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass164_0.NativeMethodInfoPtr__SetManualControllerOrderInternal_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC77 RID: 44151 RVA: 0x0005CED9 File Offset: 0x0005B0D9
			public __c__DisplayClass164_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038AB RID: 14507
			// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x002C811C File Offset: 0x002C631C
			// (set) Token: 0x0600AC79 RID: 44153 RVA: 0x0005CEE2 File Offset: 0x0005B0E2
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AC RID: 14508
			// (get) Token: 0x0600AC7A RID: 44154 RVA: 0x002C814C File Offset: 0x002C634C
			// (set) Token: 0x0600AC7B RID: 44155 RVA: 0x0005CF01 File Offset: 0x0005B101
			public unsafe GuestGroupController manualControlled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_manualControlled);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_manualControlled), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AD RID: 14509
			// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x002C817C File Offset: 0x002C637C
			// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x0005CF20 File Offset: 0x0005B120
			public unsafe Action<GuestGroupController.EvaluationResult> onEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_onEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass164_0.NativeFieldInfoPtr_onEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F5C RID: 28508
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F5D RID: 28509
			private static readonly IntPtr NativeFieldInfoPtr_manualControlled;

			// Token: 0x04006F5E RID: 28510
			private static readonly IntPtr NativeFieldInfoPtr_onEvaluate;

			// Token: 0x04006F5F RID: 28511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F60 RID: 28512
			private static readonly IntPtr NativeMethodInfoPtr__SetManualControllerOrderInternal_b__0_Internal_Void_0;
		}

		// Token: 0x02000844 RID: 2116
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass167_0")]
		public sealed class __c__DisplayClass167_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC7E RID: 44158 RVA: 0x002C81AC File Offset: 0x002C63AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass167_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass167_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_toShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, "toShow");
				GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_onEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, "onEvaluate");
				GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, 100671999);
				GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, 100672000);
				GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr__ShowManualOrder_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr, 100672001);
			}

			// Token: 0x0600AC7F RID: 44159 RVA: 0x002C8250 File Offset: 0x002C6450
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass167_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass167_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC80 RID: 44160 RVA: 0x002C828C File Offset: 0x002C648C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106998, XrefRangeEnd = 107000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int submitCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref submitCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC81 RID: 44161 RVA: 0x002C82CC File Offset: 0x002C64CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107000, XrefRangeEnd = 107002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowManualOrder_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass167_0.NativeMethodInfoPtr__ShowManualOrder_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC82 RID: 44162 RVA: 0x0005CF3F File Offset: 0x0005B13F
			public __c__DisplayClass167_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038AE RID: 14510
			// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x002C8300 File Offset: 0x002C6500
			// (set) Token: 0x0600AC84 RID: 44164 RVA: 0x0005CF48 File Offset: 0x0005B148
			public unsafe GuestGroupController toShow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_toShow);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_toShow), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AF RID: 14511
			// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x002C8330 File Offset: 0x002C6530
			// (set) Token: 0x0600AC86 RID: 44166 RVA: 0x0005CF67 File Offset: 0x0005B167
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B0 RID: 14512
			// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x002C8360 File Offset: 0x002C6560
			// (set) Token: 0x0600AC88 RID: 44168 RVA: 0x0005CF86 File Offset: 0x0005B186
			public unsafe Action<GuestGroupController.EvaluationResult> onEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_onEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass167_0.NativeFieldInfoPtr_onEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F61 RID: 28513
			private static readonly IntPtr NativeFieldInfoPtr_toShow;

			// Token: 0x04006F62 RID: 28514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F63 RID: 28515
			private static readonly IntPtr NativeFieldInfoPtr_onEvaluate;

			// Token: 0x04006F64 RID: 28516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F65 RID: 28517
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x04006F66 RID: 28518
			private static readonly IntPtr NativeMethodInfoPtr__ShowManualOrder_b__1_Internal_Void_0;
		}

		// Token: 0x02000845 RID: 2117
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass171_0")]
		public sealed class __c__DisplayClass171_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC89 RID: 44169 RVA: 0x002C8390 File Offset: 0x002C6590
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass171_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass171_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_orderMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, "orderMessage");
				GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_guestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, "guestGroup");
				GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_doContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, "doContinue");
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672002);
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_OrderGenerationResult_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672003);
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672004);
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__GenerateOrderSession_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672005);
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672006);
				GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__GenerateOrderSession_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, 100672007);
			}

			// Token: 0x0600AC8A RID: 44170 RVA: 0x002C8484 File Offset: 0x002C6684
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass171_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC8B RID: 44171 RVA: 0x002C84C0 File Offset: 0x002C66C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107077, RefRangeEnd = 107078, XrefRangeStart = 107016, XrefRangeEnd = 107077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderGenerationResult Method_Internal_OrderGenerationResult_OrderGenerationResult_SpecialGuestsController_0(GuestsManager.OrderGenerationResult oldResult, SpecialGuestsController toGenerate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref oldResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toGenerate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_OrderGenerationResult_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AC8C RID: 44172 RVA: 0x002C851C File Offset: 0x002C671C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107105, RefRangeEnd = 107106, XrefRangeStart = 107078, XrefRangeEnd = 107105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderGenerationResult Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0(GuestGroupController toGenerate, out GuestsManager.OrderBase orderData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toGenerate);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				orderData = ((intPtr4 == 0) ? null : new GuestsManager.OrderBase(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600AC8D RID: 44173 RVA: 0x002C858C File Offset: 0x002C678C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107106, XrefRangeEnd = 107108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateOrderSession_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__GenerateOrderSession_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC8E RID: 44174 RVA: 0x002C85C0 File Offset: 0x002C67C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107108, XrefRangeEnd = 107113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AC8F RID: 44175 RVA: 0x002C8600 File Offset: 0x002C6800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107113, XrefRangeEnd = 107115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateOrderSession_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.NativeMethodInfoPtr__GenerateOrderSession_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC90 RID: 44176 RVA: 0x0005CFA5 File Offset: 0x0005B1A5
			public __c__DisplayClass171_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038B1 RID: 14513
			// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002C8634 File Offset: 0x002C6834
			// (set) Token: 0x0600AC92 RID: 44178 RVA: 0x0005CFAE File Offset: 0x0005B1AE
			public unsafe string orderMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_orderMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_orderMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038B2 RID: 14514
			// (get) Token: 0x0600AC93 RID: 44179 RVA: 0x002C865C File Offset: 0x002C685C
			// (set) Token: 0x0600AC94 RID: 44180 RVA: 0x0005CFCD File Offset: 0x0005B1CD
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B3 RID: 14515
			// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x002C868C File Offset: 0x002C688C
			// (set) Token: 0x0600AC96 RID: 44182 RVA: 0x0005CFEC File Offset: 0x0005B1EC
			public unsafe GuestGroupController guestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_guestGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_guestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B4 RID: 14516
			// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002C86BC File Offset: 0x002C68BC
			// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x0005D00B File Offset: 0x0005B20B
			public unsafe bool doContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_doContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.NativeFieldInfoPtr_doContinue)) = value;
				}
			}

			// Token: 0x04006F67 RID: 28519
			private static readonly IntPtr NativeFieldInfoPtr_orderMessage;

			// Token: 0x04006F68 RID: 28520
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F69 RID: 28521
			private static readonly IntPtr NativeFieldInfoPtr_guestGroup;

			// Token: 0x04006F6A RID: 28522
			private static readonly IntPtr NativeFieldInfoPtr_doContinue;

			// Token: 0x04006F6B RID: 28523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F6C RID: 28524
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_OrderGenerationResult_SpecialGuestsController_0;

			// Token: 0x04006F6D RID: 28525
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderGenerationResult_GuestGroupController_byref_OrderBase_0;

			// Token: 0x04006F6E RID: 28526
			private static readonly IntPtr NativeMethodInfoPtr__GenerateOrderSession_b__2_Internal_Void_0;

			// Token: 0x04006F6F RID: 28527
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04006F70 RID: 28528
			private static readonly IntPtr NativeMethodInfoPtr__GenerateOrderSession_b__7_Internal_Void_0;

			// Token: 0x02000FEA RID: 4074
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass171_0+<<GenerateOrderSession>g__OnDelay|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601179E RID: 71582 RVA: 0x004037BC File Offset: 0x004019BC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0>.NativeClassPtr, "<<GenerateOrderSession>g__OnDelay|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672008);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672009);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672010);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672011);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672012);
					GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672013);
				}

				// Token: 0x0601179F RID: 71583 RVA: 0x0040389C File Offset: 0x00401A9C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117A0 RID: 71584 RVA: 0x004038E4 File Offset: 0x00401AE4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117A1 RID: 71585 RVA: 0x00403918 File Offset: 0x00401B18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107002, XrefRangeEnd = 107010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AE1 RID: 23265
				// (get) Token: 0x060117A2 RID: 71586 RVA: 0x00403954 File Offset: 0x00401B54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117A3 RID: 71587 RVA: 0x00403994 File Offset: 0x00401B94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107010, XrefRangeEnd = 107016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AE2 RID: 23266
				// (get) Token: 0x060117A4 RID: 71588 RVA: 0x004039C8 File Offset: 0x00401BC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117A5 RID: 71589 RVA: 0x0009812A File Offset: 0x0009632A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005ADE RID: 23262
				// (get) Token: 0x060117A6 RID: 71590 RVA: 0x00403A08 File Offset: 0x00401C08
				// (set) Token: 0x060117A7 RID: 71591 RVA: 0x00098133 File Offset: 0x00096333
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005ADF RID: 23263
				// (get) Token: 0x060117A8 RID: 71592 RVA: 0x00403A30 File Offset: 0x00401C30
				// (set) Token: 0x060117A9 RID: 71593 RVA: 0x0009814E File Offset: 0x0009634E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AE0 RID: 23264
				// (get) Token: 0x060117AA RID: 71594 RVA: 0x00403A60 File Offset: 0x00401C60
				// (set) Token: 0x060117AB RID: 71595 RVA: 0x0009816D File Offset: 0x0009636D
				public unsafe GuestsManager.__c__DisplayClass171_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass171_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass171_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B09F RID: 45215
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B0A0 RID: 45216
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B0A1 RID: 45217
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B0A2 RID: 45218
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B0A3 RID: 45219
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0A4 RID: 45220
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B0A5 RID: 45221
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B0A6 RID: 45222
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0A7 RID: 45223
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000846 RID: 2118
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass174_0")]
		public sealed class __c__DisplayClass174_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AC99 RID: 44185 RVA: 0x002C86E4 File Offset: 0x002C68E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass174_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass174_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr_toShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr, "toShow");
				GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr, 100672014);
				GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr, 100672015);
				GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr__ShowOrder_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr, 100672016);
			}

			// Token: 0x0600AC9A RID: 44186 RVA: 0x002C8774 File Offset: 0x002C6974
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass174_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass174_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC9B RID: 44187 RVA: 0x002C87B0 File Offset: 0x002C69B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int submitCount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref submitCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC9C RID: 44188 RVA: 0x002C87F0 File Offset: 0x002C69F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107115, XrefRangeEnd = 107116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowOrder_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass174_0.NativeMethodInfoPtr__ShowOrder_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC9D RID: 44189 RVA: 0x0005D026 File Offset: 0x0005B226
			public __c__DisplayClass174_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038B5 RID: 14517
			// (get) Token: 0x0600AC9E RID: 44190 RVA: 0x002C8824 File Offset: 0x002C6A24
			// (set) Token: 0x0600AC9F RID: 44191 RVA: 0x0005D02F File Offset: 0x0005B22F
			public unsafe GuestGroupController toShow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr_toShow);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr_toShow), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B6 RID: 14518
			// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x002C8854 File Offset: 0x002C6A54
			// (set) Token: 0x0600ACA1 RID: 44193 RVA: 0x0005D04E File Offset: 0x0005B24E
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass174_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F71 RID: 28529
			private static readonly IntPtr NativeFieldInfoPtr_toShow;

			// Token: 0x04006F72 RID: 28530
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F73 RID: 28531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F74 RID: 28532
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x04006F75 RID: 28533
			private static readonly IntPtr NativeMethodInfoPtr__ShowOrder_b__1_Internal_Void_0;
		}

		// Token: 0x02000847 RID: 2119
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass177_0")]
		public sealed class __c__DisplayClass177_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACA2 RID: 44194 RVA: 0x002C8884 File Offset: 0x002C6A84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass177_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass177_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_cookerAdditiveContinueProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "cookerAdditiveContinueProbability");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_servedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "servedFood");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_toEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "toEvaluate");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisNormalEvaluationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "thisNormalEvaluationDelay");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_protectCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "protectCombo");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "thisEvaluate");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "result");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_postEvaluation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "postEvaluation");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_isTriggerByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "isTriggerByPartner");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_obtainedExGoodRatingWithModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "obtainedExGoodRatingWithModifiers");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "<>9__7");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "<>9__8");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "<>9__9");
				GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, "<>9__10");
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672017);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr_Method_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672018);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672019);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672020);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672021);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672022);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__8_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672023);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672024);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__9_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672025);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672026);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__10_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672027);
				GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr, 100672028);
			}

			// Token: 0x0600ACA3 RID: 44195 RVA: 0x002C8ACC File Offset: 0x002C6CCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass177_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass177_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACA4 RID: 44196 RVA: 0x002C8B08 File Offset: 0x002C6D08
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107123, RefRangeEnd = 107127, XrefRangeStart = 107116, XrefRangeEnd = 107123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Method_Internal_Single_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr_Method_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ACA5 RID: 44197 RVA: 0x002C8B44 File Offset: 0x002C6D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107127, XrefRangeEnd = 107134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACA6 RID: 44198 RVA: 0x002C8B78 File Offset: 0x002C6D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107134, XrefRangeEnd = 107142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACA7 RID: 44199 RVA: 0x002C8BAC File Offset: 0x002C6DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107142, XrefRangeEnd = 107145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__7(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACA8 RID: 44200 RVA: 0x002C8BF0 File Offset: 0x002C6DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107145, XrefRangeEnd = 107153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACA9 RID: 44201 RVA: 0x002C8C24 File Offset: 0x002C6E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__8(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__8_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAA RID: 44202 RVA: 0x002C8C68 File Offset: 0x002C6E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107153, XrefRangeEnd = 107161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAB RID: 44203 RVA: 0x002C8C9C File Offset: 0x002C6E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__9(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__9_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAC RID: 44204 RVA: 0x002C8CE0 File Offset: 0x002C6EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107161, XrefRangeEnd = 107169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAD RID: 44205 RVA: 0x002C8D14 File Offset: 0x002C6F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaluateOrder_b__10(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__10_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAE RID: 44206 RVA: 0x002C8D58 File Offset: 0x002C6F58
			[CallerCount(0)]
			public unsafe void _EvaluateOrder_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass177_0.NativeMethodInfoPtr__EvaluateOrder_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACAF RID: 44207 RVA: 0x0005D06D File Offset: 0x0005B26D
			public __c__DisplayClass177_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038B7 RID: 14519
			// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x002C8D8C File Offset: 0x002C6F8C
			// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x0005D076 File Offset: 0x0005B276
			public unsafe float cookerAdditiveContinueProbability
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_cookerAdditiveContinueProbability);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_cookerAdditiveContinueProbability)) = value;
				}
			}

			// Token: 0x170038B8 RID: 14520
			// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x002C8DB4 File Offset: 0x002C6FB4
			// (set) Token: 0x0600ACB3 RID: 44211 RVA: 0x0005D091 File Offset: 0x0005B291
			public unsafe Sellable servedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_servedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_servedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B9 RID: 14521
			// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x002C8DE4 File Offset: 0x002C6FE4
			// (set) Token: 0x0600ACB5 RID: 44213 RVA: 0x0005D0B0 File Offset: 0x0005B2B0
			public unsafe GuestGroupController toEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_toEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_toEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BA RID: 14522
			// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x002C8E14 File Offset: 0x002C7014
			// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x0005D0CF File Offset: 0x0005B2CF
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BB RID: 14523
			// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x002C8E44 File Offset: 0x002C7044
			// (set) Token: 0x0600ACB9 RID: 44217 RVA: 0x0005D0EE File Offset: 0x0005B2EE
			public unsafe float thisNormalEvaluationDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisNormalEvaluationDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisNormalEvaluationDelay)) = value;
				}
			}

			// Token: 0x170038BC RID: 14524
			// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x002C8E6C File Offset: 0x002C706C
			// (set) Token: 0x0600ACBB RID: 44219 RVA: 0x0005D109 File Offset: 0x0005B309
			public unsafe bool protectCombo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_protectCombo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_protectCombo)) = value;
				}
			}

			// Token: 0x170038BD RID: 14525
			// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x002C8E94 File Offset: 0x002C7094
			// (set) Token: 0x0600ACBD RID: 44221 RVA: 0x0005D124 File Offset: 0x0005B324
			public unsafe GuestGroupController thisEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_thisEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BE RID: 14526
			// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x002C8EC4 File Offset: 0x002C70C4
			// (set) Token: 0x0600ACBF RID: 44223 RVA: 0x0005D143 File Offset: 0x0005B343
			public unsafe GuestGroupController.EvaluationResult result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x170038BF RID: 14527
			// (get) Token: 0x0600ACC0 RID: 44224 RVA: 0x002C8EEC File Offset: 0x002C70EC
			// (set) Token: 0x0600ACC1 RID: 44225 RVA: 0x0005D15E File Offset: 0x0005B35E
			public unsafe Action postEvaluation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_postEvaluation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_postEvaluation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C0 RID: 14528
			// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x002C8F1C File Offset: 0x002C711C
			// (set) Token: 0x0600ACC3 RID: 44227 RVA: 0x0005D17D File Offset: 0x0005B37D
			public unsafe bool isTriggerByPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_isTriggerByPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_isTriggerByPartner)) = value;
				}
			}

			// Token: 0x170038C1 RID: 14529
			// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x002C8F44 File Offset: 0x002C7144
			// (set) Token: 0x0600ACC5 RID: 44229 RVA: 0x0005D198 File Offset: 0x0005B398
			public unsafe bool obtainedExGoodRatingWithModifiers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_obtainedExGoodRatingWithModifiers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr_obtainedExGoodRatingWithModifiers)) = value;
				}
			}

			// Token: 0x170038C2 RID: 14530
			// (get) Token: 0x0600ACC6 RID: 44230 RVA: 0x002C8F6C File Offset: 0x002C716C
			// (set) Token: 0x0600ACC7 RID: 44231 RVA: 0x0005D1B3 File Offset: 0x0005B3B3
			public unsafe Action<GuestGroupController> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C3 RID: 14531
			// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x002C8F9C File Offset: 0x002C719C
			// (set) Token: 0x0600ACC9 RID: 44233 RVA: 0x0005D1D2 File Offset: 0x0005B3D2
			public unsafe Action<GuestGroupController> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C4 RID: 14532
			// (get) Token: 0x0600ACCA RID: 44234 RVA: 0x002C8FCC File Offset: 0x002C71CC
			// (set) Token: 0x0600ACCB RID: 44235 RVA: 0x0005D1F1 File Offset: 0x0005B3F1
			public unsafe Action<GuestGroupController> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C5 RID: 14533
			// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x002C8FFC File Offset: 0x002C71FC
			// (set) Token: 0x0600ACCD RID: 44237 RVA: 0x0005D210 File Offset: 0x0005B410
			public unsafe Action<GuestGroupController> __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass177_0.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F76 RID: 28534
			private static readonly IntPtr NativeFieldInfoPtr_cookerAdditiveContinueProbability;

			// Token: 0x04006F77 RID: 28535
			private static readonly IntPtr NativeFieldInfoPtr_servedFood;

			// Token: 0x04006F78 RID: 28536
			private static readonly IntPtr NativeFieldInfoPtr_toEvaluate;

			// Token: 0x04006F79 RID: 28537
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F7A RID: 28538
			private static readonly IntPtr NativeFieldInfoPtr_thisNormalEvaluationDelay;

			// Token: 0x04006F7B RID: 28539
			private static readonly IntPtr NativeFieldInfoPtr_protectCombo;

			// Token: 0x04006F7C RID: 28540
			private static readonly IntPtr NativeFieldInfoPtr_thisEvaluate;

			// Token: 0x04006F7D RID: 28541
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04006F7E RID: 28542
			private static readonly IntPtr NativeFieldInfoPtr_postEvaluation;

			// Token: 0x04006F7F RID: 28543
			private static readonly IntPtr NativeFieldInfoPtr_isTriggerByPartner;

			// Token: 0x04006F80 RID: 28544
			private static readonly IntPtr NativeFieldInfoPtr_obtainedExGoodRatingWithModifiers;

			// Token: 0x04006F81 RID: 28545
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04006F82 RID: 28546
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x04006F83 RID: 28547
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x04006F84 RID: 28548
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x04006F85 RID: 28549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F86 RID: 28550
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Single_0;

			// Token: 0x04006F87 RID: 28551
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__1_Internal_Void_0;

			// Token: 0x04006F88 RID: 28552
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__2_Internal_Void_0;

			// Token: 0x04006F89 RID: 28553
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__7_Internal_Void_GuestGroupController_0;

			// Token: 0x04006F8A RID: 28554
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__3_Internal_Void_0;

			// Token: 0x04006F8B RID: 28555
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__8_Internal_Void_GuestGroupController_0;

			// Token: 0x04006F8C RID: 28556
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__4_Internal_Void_0;

			// Token: 0x04006F8D RID: 28557
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__9_Internal_Void_GuestGroupController_0;

			// Token: 0x04006F8E RID: 28558
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__5_Internal_Void_0;

			// Token: 0x04006F8F RID: 28559
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__10_Internal_Void_GuestGroupController_0;

			// Token: 0x04006F90 RID: 28560
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateOrder_b__6_Internal_Void_0;
		}

		// Token: 0x02000848 RID: 2120
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACCE RID: 44238 RVA: 0x002C902C File Offset: 0x002C722C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_toEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr, "toEvaluate");
				GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_onEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr, "onEvaluate");
				GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr, "result");
				GuestsManager.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr, 100672029);
				GuestsManager.__c__DisplayClass178_0.NativeMethodInfoPtr__EvaulateManualOrder_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr, 100672030);
			}

			// Token: 0x0600ACCF RID: 44239 RVA: 0x002C90BC File Offset: 0x002C72BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass178_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACD0 RID: 44240 RVA: 0x002C90F8 File Offset: 0x002C72F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107169, XrefRangeEnd = 107170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EvaulateManualOrder_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass178_0.NativeMethodInfoPtr__EvaulateManualOrder_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACD1 RID: 44241 RVA: 0x0005D22F File Offset: 0x0005B42F
			public __c__DisplayClass178_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038C6 RID: 14534
			// (get) Token: 0x0600ACD2 RID: 44242 RVA: 0x002C912C File Offset: 0x002C732C
			// (set) Token: 0x0600ACD3 RID: 44243 RVA: 0x0005D238 File Offset: 0x0005B438
			public unsafe GuestGroupController toEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_toEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_toEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C7 RID: 14535
			// (get) Token: 0x0600ACD4 RID: 44244 RVA: 0x002C915C File Offset: 0x002C735C
			// (set) Token: 0x0600ACD5 RID: 44245 RVA: 0x0005D257 File Offset: 0x0005B457
			public unsafe Action<GuestGroupController.EvaluationResult> onEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_onEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_onEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C8 RID: 14536
			// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x002C918C File Offset: 0x002C738C
			// (set) Token: 0x0600ACD7 RID: 44247 RVA: 0x0005D276 File Offset: 0x0005B476
			public unsafe GuestGroupController.EvaluationResult result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass178_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x04006F91 RID: 28561
			private static readonly IntPtr NativeFieldInfoPtr_toEvaluate;

			// Token: 0x04006F92 RID: 28562
			private static readonly IntPtr NativeFieldInfoPtr_onEvaluate;

			// Token: 0x04006F93 RID: 28563
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04006F94 RID: 28564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F95 RID: 28565
			private static readonly IntPtr NativeMethodInfoPtr__EvaulateManualOrder_b__0_Internal_Void_0;
		}

		// Token: 0x02000849 RID: 2121
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass180_0")]
		public sealed class __c__DisplayClass180_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACD8 RID: 44248 RVA: 0x002C91B4 File Offset: 0x002C73B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass180_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass180_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_given = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, "given");
				GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, "delta");
				GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, "amount");
				GuestsManager.__c__DisplayClass180_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, 100672031);
				GuestsManager.__c__DisplayClass180_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, 100672032);
			}

			// Token: 0x0600ACD9 RID: 44249 RVA: 0x002C9244 File Offset: 0x002C7444
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass180_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACDA RID: 44250 RVA: 0x002C9280 File Offset: 0x002C7480
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107190, RefRangeEnd = 107191, XrefRangeStart = 107185, XrefRangeEnd = 107190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ACDB RID: 44251 RVA: 0x0005D291 File Offset: 0x0005B491
			public __c__DisplayClass180_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038C9 RID: 14537
			// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x002C92C0 File Offset: 0x002C74C0
			// (set) Token: 0x0600ACDD RID: 44253 RVA: 0x0005D29A File Offset: 0x0005B49A
			public unsafe int given
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_given);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_given)) = value;
				}
			}

			// Token: 0x170038CA RID: 14538
			// (get) Token: 0x0600ACDE RID: 44254 RVA: 0x002C92E8 File Offset: 0x002C74E8
			// (set) Token: 0x0600ACDF RID: 44255 RVA: 0x0005D2B5 File Offset: 0x0005B4B5
			public unsafe float delta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_delta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_delta)) = value;
				}
			}

			// Token: 0x170038CB RID: 14539
			// (get) Token: 0x0600ACE0 RID: 44256 RVA: 0x002C9310 File Offset: 0x002C7510
			// (set) Token: 0x0600ACE1 RID: 44257 RVA: 0x0005D2D0 File Offset: 0x0005B4D0
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x04006F96 RID: 28566
			private static readonly IntPtr NativeFieldInfoPtr_given;

			// Token: 0x04006F97 RID: 28567
			private static readonly IntPtr NativeFieldInfoPtr_delta;

			// Token: 0x04006F98 RID: 28568
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04006F99 RID: 28569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F9A RID: 28570
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000FEB RID: 4075
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass180_0+<<StartPassionGenerationSession>g__OnPassionGenerate|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060117AC RID: 71596 RVA: 0x00403A90 File Offset: 0x00401C90
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0>.NativeClassPtr, "<<StartPassionGenerationSession>g__OnPassionGenerate|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672033);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672034);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672035);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672036);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672037);
					GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672038);
				}

				// Token: 0x060117AD RID: 71597 RVA: 0x00403B70 File Offset: 0x00401D70
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117AE RID: 71598 RVA: 0x00403BB8 File Offset: 0x00401DB8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117AF RID: 71599 RVA: 0x00403BEC File Offset: 0x00401DEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107170, XrefRangeEnd = 107179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AE6 RID: 23270
				// (get) Token: 0x060117B0 RID: 71600 RVA: 0x00403C28 File Offset: 0x00401E28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117B1 RID: 71601 RVA: 0x00403C68 File Offset: 0x00401E68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107179, XrefRangeEnd = 107185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AE7 RID: 23271
				// (get) Token: 0x060117B2 RID: 71602 RVA: 0x00403C9C File Offset: 0x00401E9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117B3 RID: 71603 RVA: 0x0009818C File Offset: 0x0009638C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AE3 RID: 23267
				// (get) Token: 0x060117B4 RID: 71604 RVA: 0x00403CDC File Offset: 0x00401EDC
				// (set) Token: 0x060117B5 RID: 71605 RVA: 0x00098195 File Offset: 0x00096395
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AE4 RID: 23268
				// (get) Token: 0x060117B6 RID: 71606 RVA: 0x00403D04 File Offset: 0x00401F04
				// (set) Token: 0x060117B7 RID: 71607 RVA: 0x000981B0 File Offset: 0x000963B0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AE5 RID: 23269
				// (get) Token: 0x060117B8 RID: 71608 RVA: 0x00403D34 File Offset: 0x00401F34
				// (set) Token: 0x060117B9 RID: 71609 RVA: 0x000981CF File Offset: 0x000963CF
				public unsafe GuestsManager.__c__DisplayClass180_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass180_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass180_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B0A8 RID: 45224
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B0A9 RID: 45225
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B0AA RID: 45226
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B0AB RID: 45227
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B0AC RID: 45228
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0AD RID: 45229
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B0AE RID: 45230
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B0AF RID: 45231
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0B0 RID: 45232
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200084A RID: 2122
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass181_0")]
		public sealed class __c__DisplayClass181_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACE2 RID: 44258 RVA: 0x002C9338 File Offset: 0x002C7538
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass181_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass181_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_toEvaluate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr, "toEvaluate");
				GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_onDeleyEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr, "onDeleyEndCallback");
				GuestsManager.__c__DisplayClass181_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr, 100672039);
				GuestsManager.__c__DisplayClass181_0.NativeMethodInfoPtr__Eval_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr, 100672040);
			}

			// Token: 0x0600ACE3 RID: 44259 RVA: 0x002C93C8 File Offset: 0x002C75C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass181_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass181_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass181_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACE4 RID: 44260 RVA: 0x002C9404 File Offset: 0x002C7604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107191, XrefRangeEnd = 107193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Eval_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass181_0.NativeMethodInfoPtr__Eval_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACE5 RID: 44261 RVA: 0x0005D2EB File Offset: 0x0005B4EB
			public __c__DisplayClass181_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038CC RID: 14540
			// (get) Token: 0x0600ACE6 RID: 44262 RVA: 0x002C9438 File Offset: 0x002C7638
			// (set) Token: 0x0600ACE7 RID: 44263 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038CD RID: 14541
			// (get) Token: 0x0600ACE8 RID: 44264 RVA: 0x002C9468 File Offset: 0x002C7668
			// (set) Token: 0x0600ACE9 RID: 44265 RVA: 0x0005D313 File Offset: 0x0005B513
			public unsafe GuestGroupController toEvaluate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_toEvaluate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_toEvaluate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038CE RID: 14542
			// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x002C9498 File Offset: 0x002C7698
			// (set) Token: 0x0600ACEB RID: 44267 RVA: 0x0005D332 File Offset: 0x0005B532
			public unsafe Action<GuestGroupController> onDeleyEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_onDeleyEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass181_0.NativeFieldInfoPtr_onDeleyEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006F9B RID: 28571
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006F9C RID: 28572
			private static readonly IntPtr NativeFieldInfoPtr_toEvaluate;

			// Token: 0x04006F9D RID: 28573
			private static readonly IntPtr NativeFieldInfoPtr_onDeleyEndCallback;

			// Token: 0x04006F9E RID: 28574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006F9F RID: 28575
			private static readonly IntPtr NativeMethodInfoPtr__Eval_b__0_Internal_Void_0;
		}

		// Token: 0x0200084B RID: 2123
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass187_0")]
		public sealed class __c__DisplayClass187_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACEC RID: 44268 RVA: 0x002C94C8 File Offset: 0x002C76C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass187_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass187_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass187_0.NativeFieldInfoPtr_guestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr, "guestCount");
				GuestsManager.__c__DisplayClass187_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr, 100672041);
				GuestsManager.__c__DisplayClass187_0.NativeMethodInfoPtr__GetSeatable_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr, 100672042);
			}

			// Token: 0x0600ACED RID: 44269 RVA: 0x002C9530 File Offset: 0x002C7730
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass187_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass187_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass187_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACEE RID: 44270 RVA: 0x002C956C File Offset: 0x002C776C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107193, XrefRangeEnd = 107194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSeatable_b__0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass187_0.NativeMethodInfoPtr__GetSeatable_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ACEF RID: 44271 RVA: 0x0005D351 File Offset: 0x0005B551
			public __c__DisplayClass187_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038CF RID: 14543
			// (get) Token: 0x0600ACF0 RID: 44272 RVA: 0x002C95C0 File Offset: 0x002C77C0
			// (set) Token: 0x0600ACF1 RID: 44273 RVA: 0x0005D35A File Offset: 0x0005B55A
			public unsafe int guestCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass187_0.NativeFieldInfoPtr_guestCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass187_0.NativeFieldInfoPtr_guestCount)) = value;
				}
			}

			// Token: 0x04006FA0 RID: 28576
			private static readonly IntPtr NativeFieldInfoPtr_guestCount;

			// Token: 0x04006FA1 RID: 28577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FA2 RID: 28578
			private static readonly IntPtr NativeMethodInfoPtr__GetSeatable_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x0200084C RID: 2124
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass188_0")]
		public sealed class __c__DisplayClass188_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACF2 RID: 44274 RVA: 0x002C95E8 File Offset: 0x002C77E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass188_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass188_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, "offset");
				GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onVertify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, "onVertify");
				GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onDeleyEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, "onDeleyEndCallback");
				GuestsManager.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, 100672043);
				GuestsManager.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, 100672044);
			}

			// Token: 0x0600ACF3 RID: 44275 RVA: 0x002C9678 File Offset: 0x002C7878
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass188_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACF4 RID: 44276 RVA: 0x002C96B4 File Offset: 0x002C78B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107210, RefRangeEnd = 107211, XrefRangeStart = 107205, XrefRangeEnd = 107210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ACF5 RID: 44277 RVA: 0x0005D375 File Offset: 0x0005B575
			public __c__DisplayClass188_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038D0 RID: 14544
			// (get) Token: 0x0600ACF6 RID: 44278 RVA: 0x002C96F4 File Offset: 0x002C78F4
			// (set) Token: 0x0600ACF7 RID: 44279 RVA: 0x0005D37E File Offset: 0x0005B57E
			public unsafe float offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170038D1 RID: 14545
			// (get) Token: 0x0600ACF8 RID: 44280 RVA: 0x002C971C File Offset: 0x002C791C
			// (set) Token: 0x0600ACF9 RID: 44281 RVA: 0x0005D399 File Offset: 0x0005B599
			public unsafe Func<bool> onVertify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onVertify);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onVertify), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D2 RID: 14546
			// (get) Token: 0x0600ACFA RID: 44282 RVA: 0x002C974C File Offset: 0x002C794C
			// (set) Token: 0x0600ACFB RID: 44283 RVA: 0x0005D3B8 File Offset: 0x0005B5B8
			public unsafe Action onDeleyEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onDeleyEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.NativeFieldInfoPtr_onDeleyEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FA3 RID: 28579
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04006FA4 RID: 28580
			private static readonly IntPtr NativeFieldInfoPtr_onVertify;

			// Token: 0x04006FA5 RID: 28581
			private static readonly IntPtr NativeFieldInfoPtr_onDeleyEndCallback;

			// Token: 0x04006FA6 RID: 28582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FA7 RID: 28583
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000FEC RID: 4076
			[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass188_0+<<ExecuteDelayed>g__OnDelay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060117BA RID: 71610 RVA: 0x00403D64 File Offset: 0x00401F64
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0>.NativeClassPtr, "<<ExecuteDelayed>g__OnDelay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672045);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672046);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672047);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672048);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672049);
					GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672050);
				}

				// Token: 0x060117BB RID: 71611 RVA: 0x00403E44 File Offset: 0x00402044
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117BC RID: 71612 RVA: 0x00403E8C File Offset: 0x0040208C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060117BD RID: 71613 RVA: 0x00403EC0 File Offset: 0x004020C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107194, XrefRangeEnd = 107199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AEB RID: 23275
				// (get) Token: 0x060117BE RID: 71614 RVA: 0x00403EFC File Offset: 0x004020FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117BF RID: 71615 RVA: 0x00403F3C File Offset: 0x0040213C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107199, XrefRangeEnd = 107205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AEC RID: 23276
				// (get) Token: 0x060117C0 RID: 71616 RVA: 0x00403F70 File Offset: 0x00402170
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060117C1 RID: 71617 RVA: 0x000981EE File Offset: 0x000963EE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AE8 RID: 23272
				// (get) Token: 0x060117C2 RID: 71618 RVA: 0x00403FB0 File Offset: 0x004021B0
				// (set) Token: 0x060117C3 RID: 71619 RVA: 0x000981F7 File Offset: 0x000963F7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AE9 RID: 23273
				// (get) Token: 0x060117C4 RID: 71620 RVA: 0x00403FD8 File Offset: 0x004021D8
				// (set) Token: 0x060117C5 RID: 71621 RVA: 0x00098212 File Offset: 0x00096412
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AEA RID: 23274
				// (get) Token: 0x060117C6 RID: 71622 RVA: 0x00404008 File Offset: 0x00402208
				// (set) Token: 0x060117C7 RID: 71623 RVA: 0x00098231 File Offset: 0x00096431
				public unsafe GuestsManager.__c__DisplayClass188_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass188_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B0B1 RID: 45233
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B0B2 RID: 45234
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B0B3 RID: 45235
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B0B4 RID: 45236
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B0B5 RID: 45237
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0B6 RID: 45238
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B0B7 RID: 45239
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B0B8 RID: 45240
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B0B9 RID: 45241
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200084D RID: 2125
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass197_0")]
		public sealed class __c__DisplayClass197_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ACFC RID: 44284 RVA: 0x002C977C File Offset: 0x002C797C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass197_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass197_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_thisToLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, "thisToLeave");
				GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_leaveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, "leaveAction");
				GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_finalLeaveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, "finalLeaveType");
				GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, 100672051);
				GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, 100672052);
				GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr__LeaveFromDesk_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr, 100672053);
			}

			// Token: 0x0600ACFD RID: 44285 RVA: 0x002C9834 File Offset: 0x002C7A34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass197_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass197_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACFE RID: 44286 RVA: 0x002C9870 File Offset: 0x002C7A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107211, XrefRangeEnd = 107271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ACFF RID: 44287 RVA: 0x002C98A4 File Offset: 0x002C7AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107271, XrefRangeEnd = 107272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LeaveFromDesk_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass197_0.NativeMethodInfoPtr__LeaveFromDesk_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD00 RID: 44288 RVA: 0x0005D3D7 File Offset: 0x0005B5D7
			public __c__DisplayClass197_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038D3 RID: 14547
			// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x002C98D8 File Offset: 0x002C7AD8
			// (set) Token: 0x0600AD02 RID: 44290 RVA: 0x0005D3E0 File Offset: 0x0005B5E0
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D4 RID: 14548
			// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x002C9908 File Offset: 0x002C7B08
			// (set) Token: 0x0600AD04 RID: 44292 RVA: 0x0005D3FF File Offset: 0x0005B5FF
			public unsafe GuestGroupController thisToLeave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_thisToLeave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_thisToLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D5 RID: 14549
			// (get) Token: 0x0600AD05 RID: 44293 RVA: 0x002C9938 File Offset: 0x002C7B38
			// (set) Token: 0x0600AD06 RID: 44294 RVA: 0x0005D41E File Offset: 0x0005B61E
			public unsafe Action leaveAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_leaveAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_leaveAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D6 RID: 14550
			// (get) Token: 0x0600AD07 RID: 44295 RVA: 0x002C9968 File Offset: 0x002C7B68
			// (set) Token: 0x0600AD08 RID: 44296 RVA: 0x0005D43D File Offset: 0x0005B63D
			public unsafe GuestGroupController.LeaveType finalLeaveType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_finalLeaveType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass197_0.NativeFieldInfoPtr_finalLeaveType)) = value;
				}
			}

			// Token: 0x04006FA8 RID: 28584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006FA9 RID: 28585
			private static readonly IntPtr NativeFieldInfoPtr_thisToLeave;

			// Token: 0x04006FAA RID: 28586
			private static readonly IntPtr NativeFieldInfoPtr_leaveAction;

			// Token: 0x04006FAB RID: 28587
			private static readonly IntPtr NativeFieldInfoPtr_finalLeaveType;

			// Token: 0x04006FAC RID: 28588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FAD RID: 28589
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04006FAE RID: 28590
			private static readonly IntPtr NativeMethodInfoPtr__LeaveFromDesk_b__2_Internal_Void_0;
		}

		// Token: 0x0200084E RID: 2126
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass209_0")]
		public sealed class __c__DisplayClass209_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AD09 RID: 44297 RVA: 0x002C9990 File Offset: 0x002C7B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass209_0()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass209_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr);
				GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr_toRepell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr, "toRepell");
				GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr, "<>4__this");
				GuestsManager.__c__DisplayClass209_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr, 100672054);
				GuestsManager.__c__DisplayClass209_0.NativeMethodInfoPtr__PlayerRepell_b__4_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr, 100672055);
			}

			// Token: 0x0600AD0A RID: 44298 RVA: 0x002C9A0C File Offset: 0x002C7C0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass209_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass209_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD0B RID: 44299 RVA: 0x002C9A48 File Offset: 0x002C7C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107272, XrefRangeEnd = 107277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayerRepell_b__4(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass209_0.NativeMethodInfoPtr__PlayerRepell_b__4_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD0C RID: 44300 RVA: 0x0005D458 File Offset: 0x0005B658
			public __c__DisplayClass209_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038D7 RID: 14551
			// (get) Token: 0x0600AD0D RID: 44301 RVA: 0x002C9A8C File Offset: 0x002C7C8C
			// (set) Token: 0x0600AD0E RID: 44302 RVA: 0x0005D461 File Offset: 0x0005B661
			public unsafe GuestGroupController toRepell
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr_toRepell);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr_toRepell), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D8 RID: 14552
			// (get) Token: 0x0600AD0F RID: 44303 RVA: 0x002C9ABC File Offset: 0x002C7CBC
			// (set) Token: 0x0600AD10 RID: 44304 RVA: 0x0005D480 File Offset: 0x0005B680
			public unsafe GuestsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FAF RID: 28591
			private static readonly IntPtr NativeFieldInfoPtr_toRepell;

			// Token: 0x04006FB0 RID: 28592
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006FB1 RID: 28593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FB2 RID: 28594
			private static readonly IntPtr NativeMethodInfoPtr__PlayerRepell_b__4_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x0200084F RID: 2127
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestsManager+<>c__DisplayClass209_1")]
		public sealed class __c__DisplayClass209_1 : Il2CppSystem.Object
		{
			// Token: 0x0600AD11 RID: 44305 RVA: 0x002C9AEC File Offset: 0x002C7CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass209_1()
			{
				Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestsManager>.NativeClassPtr, "<>c__DisplayClass209_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr);
				GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_oldSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr, "oldSet");
				GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_field_Public___c__DisplayClass209_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr, "CS$<>8__locals1");
				GuestsManager.__c__DisplayClass209_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr, 100672056);
				GuestsManager.__c__DisplayClass209_1.NativeMethodInfoPtr__PlayerRepell_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr, 100672057);
			}

			// Token: 0x0600AD12 RID: 44306 RVA: 0x002C9B68 File Offset: 0x002C7D68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass209_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestsManager.__c__DisplayClass209_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass209_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD13 RID: 44307 RVA: 0x002C9BA4 File Offset: 0x002C7DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107277, XrefRangeEnd = 107298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayerRepell_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestsManager.__c__DisplayClass209_1.NativeMethodInfoPtr__PlayerRepell_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD14 RID: 44308 RVA: 0x0005D49F File Offset: 0x0005B69F
			public __c__DisplayClass209_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038D9 RID: 14553
			// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x002C9BD8 File Offset: 0x002C7DD8
			// (set) Token: 0x0600AD16 RID: 44310 RVA: 0x0005D4A8 File Offset: 0x0005B6A8
			public unsafe bool oldSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_oldSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_oldSet)) = value;
				}
			}

			// Token: 0x170038DA RID: 14554
			// (get) Token: 0x0600AD17 RID: 44311 RVA: 0x002C9C00 File Offset: 0x002C7E00
			// (set) Token: 0x0600AD18 RID: 44312 RVA: 0x0005D4C3 File Offset: 0x0005B6C3
			public unsafe GuestsManager.__c__DisplayClass209_0 field_Public___c__DisplayClass209_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_field_Public___c__DisplayClass209_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.__c__DisplayClass209_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestsManager.__c__DisplayClass209_1.NativeFieldInfoPtr_field_Public___c__DisplayClass209_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FB3 RID: 28595
			private static readonly IntPtr NativeFieldInfoPtr_oldSet;

			// Token: 0x04006FB4 RID: 28596
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass209_0_0;

			// Token: 0x04006FB5 RID: 28597
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FB6 RID: 28598
			private static readonly IntPtr NativeMethodInfoPtr__PlayerRepell_b__1_Internal_Void_0;
		}
	}
}
