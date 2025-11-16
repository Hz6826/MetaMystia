using System;
using Common.CharacterUtility;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using NightScene.GuestManagementUtility;
using NightScene.UI.GuestManagementUtility;
using UnityEngine;

namespace NightScene
{
	// Token: 0x0200019C RID: 412
	public class NightSceneDirector : MonoSingleton<NightSceneDirector>
	{
		// Token: 0x06002C12 RID: 11282 RVA: 0x00130B30 File Offset: 0x0012ED30
		// Note: this type is marked as 'beforefieldinit'.
		static NightSceneDirector()
		{
			Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene", "NightSceneDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr);
			NightSceneDirector.NativeFieldInfoPtr_cookerSelectionOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "cookerSelectionOverlay");
			NightSceneDirector.NativeFieldInfoPtr_recipeSelectionOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "recipeSelectionOverlay");
			NightSceneDirector.NativeFieldInfoPtr_startCookingOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "startCookingOverlay");
			NightSceneDirector.NativeFieldInfoPtr_cookingOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "cookingOverlay");
			NightSceneDirector.NativeFieldInfoPtr_extractOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "extractOverlay");
			NightSceneDirector.NativeFieldInfoPtr_gotoBeverageOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "gotoBeverageOverlay");
			NightSceneDirector.NativeFieldInfoPtr_extractBeverageOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "extractBeverageOverlay");
			NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "closeBeverageOverlay");
			NightSceneDirector.NativeFieldInfoPtr_gotoDeliverOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "gotoDeliverOverlay");
			NightSceneDirector.NativeFieldInfoPtr_deliverOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "deliverOverlay");
			NightSceneDirector.NativeFieldInfoPtr_closeDeliverOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "closeDeliverOverlay");
			NightSceneDirector.NativeFieldInfoPtr_openWriggleOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "openWriggleOverlay");
			NightSceneDirector.NativeFieldInfoPtr_exitWriggleOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "exitWriggleOverlay");
			NightSceneDirector.NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "dialog");
			NightSceneDirector.NativeFieldInfoPtr_openCookerOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "openCookerOverlay");
			NightSceneDirector.NativeFieldInfoPtr_selectOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "selectOverlay");
			NightSceneDirector.NativeFieldInfoPtr_waitOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "waitOverlay");
			NightSceneDirector.NativeFieldInfoPtr_extractCookedOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "extractCookedOverlay");
			NightSceneDirector.NativeFieldInfoPtr_openBeverageOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "openBeverageOverlay");
			NightSceneDirector.NativeFieldInfoPtr_selectBeverageOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "selectBeverageOverlay");
			NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "closeBeverageOverlay2");
			NightSceneDirector.NativeFieldInfoPtr_deliverSpecialGuestOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "deliverSpecialGuestOverlay");
			NightSceneDirector.NativeFieldInfoPtr_executeDeliverSpecialGuestOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "executeDeliverSpecialGuestOverlay");
			NightSceneDirector.NativeFieldInfoPtr_qteTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "qteTutorial");
			NightSceneDirector.NativeFieldInfoPtr_controlledGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "controlledGuest");
			NightSceneDirector.NativeFieldInfoPtr_m_CurrentDisplayDialogBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "m_CurrentDisplayDialogBox");
			NightSceneDirector.NativeFieldInfoPtr_canGotoNextPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "canGotoNextPhase");
			NightSceneDirector.NativeFieldInfoPtr_isInTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "isInTutorial");
			NightSceneDirector.NativeFieldInfoPtr_onInteractableExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "onInteractableExit");
			NightSceneDirector.NativeFieldInfoPtr_onInteractableOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "onInteractableOpen");
			NightSceneDirector.NativeFieldInfoPtr__IsManualWorkSceneSession_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<IsManualWorkSceneSession>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__DaySceneRemainedActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<DaySceneRemainedActions>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__IsKyoukoTutorialMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<IsKyoukoTutorialMode>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__KyoukoTutorialTimelineCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<KyoukoTutorialTimelineCallback>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__ChallengeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<ChallengeMode>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__DifficultyMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<DifficultyMode>k__BackingField");
			NightSceneDirector.NativeFieldInfoPtr__DoNotFadeOutInChallenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<DoNotFadeOutInChallenge>k__BackingField");
			NightSceneDirector.NativeMethodInfoPtr_get_IsManualWorkSceneSession_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670984);
			NightSceneDirector.NativeMethodInfoPtr_set_IsManualWorkSceneSession_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670985);
			NightSceneDirector.NativeMethodInfoPtr_get_DaySceneRemainedActions_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670986);
			NightSceneDirector.NativeMethodInfoPtr_set_DaySceneRemainedActions_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670987);
			NightSceneDirector.NativeMethodInfoPtr_get_IsKyoukoTutorialMode_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670988);
			NightSceneDirector.NativeMethodInfoPtr_set_IsKyoukoTutorialMode_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670989);
			NightSceneDirector.NativeMethodInfoPtr_get_KyoukoTutorialTimelineCallback_Public_Static_get_ValueTuple_2_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670990);
			NightSceneDirector.NativeMethodInfoPtr_set_KyoukoTutorialTimelineCallback_Public_Static_set_Void_ValueTuple_2_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670991);
			NightSceneDirector.NativeMethodInfoPtr_get_ChallengeMode_Public_Static_get_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670992);
			NightSceneDirector.NativeMethodInfoPtr_set_ChallengeMode_Public_Static_set_Void_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670993);
			NightSceneDirector.NativeMethodInfoPtr_get_DifficultyMode_Public_Static_get_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670994);
			NightSceneDirector.NativeMethodInfoPtr_set_DifficultyMode_Public_Static_set_Void_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670995);
			NightSceneDirector.NativeMethodInfoPtr_get_DoNotFadeOutInChallenge_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670996);
			NightSceneDirector.NativeMethodInfoPtr_set_DoNotFadeOutInChallenge_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670997);
			NightSceneDirector.NativeMethodInfoPtr_get_IsNormalNightOrRogueLike_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670998);
			NightSceneDirector.NativeMethodInfoPtr_get_IsInTutorial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100670999);
			NightSceneDirector.NativeMethodInfoPtr_set_IsInTutorial_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671000);
			NightSceneDirector.NativeMethodInfoPtr_GetControlled_Public_GuestGroupController_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671001);
			NightSceneDirector.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671002);
			NightSceneDirector.NativeMethodInfoPtr_ShouldTimeFlow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671003);
			NightSceneDirector.NativeMethodInfoPtr_ShouldGuestSpawn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671004);
			NightSceneDirector.NativeMethodInfoPtr_SpawnManualControlledSpecialGuestAuto_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671005);
			NightSceneDirector.NativeMethodInfoPtr_SpawnManualControlledSpecialGuest_Public_Void_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671006);
			NightSceneDirector.NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_String_Int32_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671007);
			NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671008);
			NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestSpecialOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671009);
			NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestLeave_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671010);
			NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestPatient_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671011);
			NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestSpell_Public_Void_String_Boolean_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671012);
			NightSceneDirector.NativeMethodInfoPtr_PlayCustomDialog_Public_Void_String_String_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671013);
			NightSceneDirector.NativeMethodInfoPtr_PlaySpecialGuestEvaluationDialog_Public_Void_String_EvaluationResult_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671014);
			NightSceneDirector.NativeMethodInfoPtr_PlayDialogCoroutine_Private_IEnumerator_String_Func_1_ValueTuple_2_TDialogBox_Action_1_TDialogBox_Func_2_TDialogBox_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671015);
			NightSceneDirector.NativeMethodInfoPtr_TryLeaveSession_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671016);
			NightSceneDirector.NativeMethodInfoPtr_OnInteractableOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671017);
			NightSceneDirector.NativeMethodInfoPtr_HasInteractableOpened_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671018);
			NightSceneDirector.NativeMethodInfoPtr_OnCanGotoNextPhase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671019);
			NightSceneDirector.NativeMethodInfoPtr_CanGotoNextPhase_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671020);
			NightSceneDirector.NativeMethodInfoPtr_OnInteractableExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671021);
			NightSceneDirector.NativeMethodInfoPtr_HasInteractableExit_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671022);
			NightSceneDirector.NativeMethodInfoPtr_ResetParams_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671023);
			NightSceneDirector.NativeMethodInfoPtr_TutorialSession_Private_IEnumerator_GameObject_Action_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671024);
			NightSceneDirector.NativeMethodInfoPtr_StartTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671025);
			NightSceneDirector.NativeMethodInfoPtr_StartTutorial2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671026);
			NightSceneDirector.NativeMethodInfoPtr_StartTutorial3_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671027);
			NightSceneDirector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671028);
			NightSceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671029);
			NightSceneDirector.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671030);
			NightSceneDirector.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, 100671031);
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x00131204 File Offset: 0x0012F404
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x00131234 File Offset: 0x0012F434
		public unsafe static bool IsManualWorkSceneSession
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99336, XrefRangeEnd = 99338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_IsManualWorkSceneSession_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99338, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_IsManualWorkSceneSession_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x00131268 File Offset: 0x0012F468
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x00131298 File Offset: 0x0012F498
		public unsafe static int DaySceneRemainedActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99340, XrefRangeEnd = 99342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_DaySceneRemainedActions_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99342, XrefRangeEnd = 99344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_DaySceneRemainedActions_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x001312CC File Offset: 0x0012F4CC
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x001312FC File Offset: 0x0012F4FC
		public unsafe static bool IsKyoukoTutorialMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99344, XrefRangeEnd = 99346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_IsKyoukoTutorialMode_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99346, XrefRangeEnd = 99348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_IsKyoukoTutorialMode_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x00131330 File Offset: 0x0012F530
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x0013135C File Offset: 0x0012F55C
		public unsafe static ValueTuple<Action, Action> KyoukoTutorialTimelineCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99348, XrefRangeEnd = 99350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_KyoukoTutorialTimelineCallback_Public_Static_get_ValueTuple_2_Action_Action_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Action, Action>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99350, XrefRangeEnd = 99354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_KyoukoTutorialTimelineCallback_Public_Static_set_Void_ValueTuple_2_Action_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x00131398 File Offset: 0x0012F598
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x001313C8 File Offset: 0x0012F5C8
		public unsafe static NightSceneDirector.ChallengeType ChallengeMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99354, XrefRangeEnd = 99356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_ChallengeMode_Public_Static_get_ChallengeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99356, XrefRangeEnd = 99358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_ChallengeMode_Public_Static_set_Void_ChallengeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x001313FC File Offset: 0x0012F5FC
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x0013142C File Offset: 0x0012F62C
		public unsafe static NightSceneDirector.Difficulty DifficultyMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99358, XrefRangeEnd = 99360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_DifficultyMode_Public_Static_get_Difficulty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99360, XrefRangeEnd = 99362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_DifficultyMode_Public_Static_set_Void_Difficulty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00131460 File Offset: 0x0012F660
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00131490 File Offset: 0x0012F690
		public unsafe static bool DoNotFadeOutInChallenge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99362, XrefRangeEnd = 99364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_DoNotFadeOutInChallenge_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99364, XrefRangeEnd = 99366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_DoNotFadeOutInChallenge_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x001314C4 File Offset: 0x0012F6C4
		public unsafe static bool IsNormalNightOrRogueLike
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 99368, RefRangeEnd = 99376, XrefRangeStart = 99366, XrefRangeEnd = 99368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_IsNormalNightOrRogueLike_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x001314F4 File Offset: 0x0012F6F4
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x00131530 File Offset: 0x0012F730
		public unsafe bool IsInTutorial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_get_IsInTutorial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_set_IsInTutorial_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00131570 File Offset: 0x0012F770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 99380, RefRangeEnd = 99383, XrefRangeStart = 99376, XrefRangeEnd = 99380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestGroupController GetControlled(string guestLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guestLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_GetControlled_Public_GuestGroupController_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr3) : null;
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x001315C0 File Offset: 0x0012F7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99383, XrefRangeEnd = 99386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NightSceneDirector.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x001315FC File Offset: 0x0012F7FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99389, RefRangeEnd = 99390, XrefRangeStart = 99386, XrefRangeEnd = 99389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShouldTimeFlow(bool doFlow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doFlow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_ShouldTimeFlow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0013163C File Offset: 0x0012F83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99393, RefRangeEnd = 99394, XrefRangeStart = 99390, XrefRangeEnd = 99393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShouldGuestSpawn(bool doSpawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doSpawn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_ShouldGuestSpawn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x0013167C File Offset: 0x0012F87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99409, RefRangeEnd = 99410, XrefRangeStart = 99394, XrefRangeEnd = 99409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnManualControlledSpecialGuestAuto(int specialGuestId, Action onEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onEnd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SpawnManualControlledSpecialGuestAuto_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x001316CC File Offset: 0x0012F8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99428, RefRangeEnd = 99430, XrefRangeStart = 99410, XrefRangeEnd = 99428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnManualControlledSpecialGuest(int specialGuestId, string label, bool spawnInA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnInA;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SpawnManualControlledSpecialGuest_Public_Void_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0013172C File Offset: 0x0012F92C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99434, RefRangeEnd = 99436, XrefRangeStart = 99430, XrefRangeEnd = 99434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManualControlledToSeat(string label, int mood, int deskCode, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mood;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_String_Int32_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x001317A0 File Offset: 0x0012F9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99440, RefRangeEnd = 99441, XrefRangeStart = 99436, XrefRangeEnd = 99440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialGuestOrder(string label, int foodId, int bevId, Action<GuestGroupController.EvaluationResult> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00131814 File Offset: 0x0012FA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99445, RefRangeEnd = 99446, XrefRangeStart = 99441, XrefRangeEnd = 99445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialGuestSpecialOrder(string label, int foodTag, int bevTag, Action<GuestGroupController.EvaluationResult> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodTag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevTag;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestSpecialOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00131888 File Offset: 0x0012FA88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99464, RefRangeEnd = 99465, XrefRangeStart = 99446, XrefRangeEnd = 99464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialGuestLeave(string label, bool shouldLeaveInstantly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldLeaveInstantly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestLeave_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x001318D8 File Offset: 0x0012FAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99472, RefRangeEnd = 99473, XrefRangeStart = 99465, XrefRangeEnd = 99472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialGuestPatient(string label, int targetPatient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetPatient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestPatient_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00131928 File Offset: 0x0012FB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99488, RefRangeEnd = 99489, XrefRangeStart = 99473, XrefRangeEnd = 99488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpecialGuestSpell(string label, bool isPositive, bool visualOnly, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPositive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visualOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_SetSpecialGuestSpell_Public_Void_String_Boolean_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0013199C File Offset: 0x0012FB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99526, RefRangeEnd = 99527, XrefRangeStart = 99489, XrefRangeEnd = 99526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCustomDialog(string characterId, string title, float duration = -1f, Action onFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_PlayCustomDialog_Public_Void_String_String_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00131A14 File Offset: 0x0012FC14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99572, RefRangeEnd = 99573, XrefRangeStart = 99527, XrefRangeEnd = 99572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySpecialGuestEvaluationDialog(string specialGuestId, GuestGroupController.EvaluationResult result, Action onFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(specialGuestId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_PlaySpecialGuestEvaluationDialog_Public_Void_String_EvaluationResult_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00131A78 File Offset: 0x0012FC78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99580, RefRangeEnd = 99582, XrefRangeStart = 99573, XrefRangeEnd = 99580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayDialogCoroutine<TDialogBox>(string characterId, Func<ValueTuple<TDialogBox, Action<TDialogBox>>> getNewDialogBox, Func<TDialogBox, IEnumerator> setMessage, Action onFinish) where TDialogBox : DialogBoxUI
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNewDialogBox);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setMessage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.MethodInfoStoreGeneric_PlayDialogCoroutine_Private_IEnumerator_String_Func_1_ValueTuple_2_TDialogBox_Action_1_TDialogBox_Func_2_TDialogBox_IEnumerator_Action_0<TDialogBox>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x00131B00 File Offset: 0x0012FD00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 99601, RefRangeEnd = 99606, XrefRangeStart = 99582, XrefRangeEnd = 99601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryLeaveSession(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_TryLeaveSession_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00131B44 File Offset: 0x0012FD44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99606, RefRangeEnd = 99608, XrefRangeStart = 99606, XrefRangeEnd = 99606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteractableOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_OnInteractableOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x00131B78 File Offset: 0x0012FD78
		[CallerCount(0)]
		public unsafe bool HasInteractableOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_HasInteractableOpened_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00131BB4 File Offset: 0x0012FDB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99608, RefRangeEnd = 99612, XrefRangeStart = 99608, XrefRangeEnd = 99608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanGotoNextPhase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_OnCanGotoNextPhase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00131BE8 File Offset: 0x0012FDE8
		[CallerCount(0)]
		public unsafe bool CanGotoNextPhase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_CanGotoNextPhase_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00131C24 File Offset: 0x0012FE24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 99612, RefRangeEnd = 99616, XrefRangeStart = 99612, XrefRangeEnd = 99612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteractableExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_OnInteractableExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00131C58 File Offset: 0x0012FE58
		[CallerCount(0)]
		public unsafe bool HasInteractableExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_HasInteractableExit_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00131C94 File Offset: 0x0012FE94
		[CallerCount(0)]
		public unsafe void ResetParams()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_ResetParams_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00131CC8 File Offset: 0x0012FEC8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 99623, RefRangeEnd = 99645, XrefRangeStart = 99616, XrefRangeEnd = 99623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TutorialSession(GameObject displayedObject, Action preInitialize, Func<bool> waitHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayedObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preInitialize);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waitHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_TutorialSession_Private_IEnumerator_GameObject_Action_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00131D3C File Offset: 0x0012FF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99652, RefRangeEnd = 99653, XrefRangeStart = 99645, XrefRangeEnd = 99652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_StartTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00131D70 File Offset: 0x0012FF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99660, RefRangeEnd = 99661, XrefRangeStart = 99653, XrefRangeEnd = 99660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTutorial2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_StartTutorial2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00131DA4 File Offset: 0x0012FFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99674, RefRangeEnd = 99675, XrefRangeStart = 99661, XrefRangeEnd = 99674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTutorial3(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_StartTutorial3_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00131DE8 File Offset: 0x0012FFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99675, XrefRangeEnd = 99705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NightSceneDirector.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00131E24 File Offset: 0x00130024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99705, XrefRangeEnd = 99723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NightSceneDirector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00131E60 File Offset: 0x00130060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99723, XrefRangeEnd = 99728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00131EA0 File Offset: 0x001300A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99728, XrefRangeEnd = 99733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x00019A39 File Offset: 0x00017C39
		public NightSceneDirector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00131EE0 File Offset: 0x001300E0
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x00019A42 File Offset: 0x00017C42
		public unsafe GameObject cookerSelectionOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_cookerSelectionOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_cookerSelectionOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x00131F10 File Offset: 0x00130110
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x00019A61 File Offset: 0x00017C61
		public unsafe GameObject recipeSelectionOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_recipeSelectionOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_recipeSelectionOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00131F40 File Offset: 0x00130140
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x00019A80 File Offset: 0x00017C80
		public unsafe GameObject startCookingOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_startCookingOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_startCookingOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x00131F70 File Offset: 0x00130170
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x00019A9F File Offset: 0x00017C9F
		public unsafe GameObject cookingOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_cookingOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_cookingOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x00131FA0 File Offset: 0x001301A0
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x00019ABE File Offset: 0x00017CBE
		public unsafe GameObject extractOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00131FD0 File Offset: 0x001301D0
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x00019ADD File Offset: 0x00017CDD
		public unsafe GameObject gotoBeverageOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_gotoBeverageOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_gotoBeverageOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x00132000 File Offset: 0x00130200
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x00019AFC File Offset: 0x00017CFC
		public unsafe GameObject extractBeverageOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractBeverageOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractBeverageOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00132030 File Offset: 0x00130230
		// (set) Token: 0x06002C53 RID: 11347 RVA: 0x00019B1B File Offset: 0x00017D1B
		public unsafe GameObject closeBeverageOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x00132060 File Offset: 0x00130260
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x00019B3A File Offset: 0x00017D3A
		public unsafe GameObject gotoDeliverOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_gotoDeliverOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_gotoDeliverOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x00132090 File Offset: 0x00130290
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x00019B59 File Offset: 0x00017D59
		public unsafe GameObject deliverOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_deliverOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_deliverOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x001320C0 File Offset: 0x001302C0
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x00019B78 File Offset: 0x00017D78
		public unsafe GameObject closeDeliverOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeDeliverOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeDeliverOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x001320F0 File Offset: 0x001302F0
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x00019B97 File Offset: 0x00017D97
		public unsafe GameObject openWriggleOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openWriggleOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openWriggleOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x00132120 File Offset: 0x00130320
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x00019BB6 File Offset: 0x00017DB6
		public unsafe GameObject exitWriggleOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_exitWriggleOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_exitWriggleOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x00132150 File Offset: 0x00130350
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x00019BD5 File Offset: 0x00017DD5
		public unsafe DialogPackage dialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_dialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_dialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00132180 File Offset: 0x00130380
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x00019BF4 File Offset: 0x00017DF4
		public unsafe GameObject openCookerOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openCookerOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openCookerOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x001321B0 File Offset: 0x001303B0
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x00019C13 File Offset: 0x00017E13
		public unsafe GameObject selectOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_selectOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_selectOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x001321E0 File Offset: 0x001303E0
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x00019C32 File Offset: 0x00017E32
		public unsafe GameObject waitOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_waitOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_waitOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00132210 File Offset: 0x00130410
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x00019C51 File Offset: 0x00017E51
		public unsafe GameObject extractCookedOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractCookedOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_extractCookedOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00132240 File Offset: 0x00130440
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x00019C70 File Offset: 0x00017E70
		public unsafe GameObject openBeverageOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openBeverageOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_openBeverageOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00132270 File Offset: 0x00130470
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00019C8F File Offset: 0x00017E8F
		public unsafe GameObject selectBeverageOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_selectBeverageOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_selectBeverageOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x001322A0 File Offset: 0x001304A0
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00019CAE File Offset: 0x00017EAE
		public unsafe GameObject closeBeverageOverlay2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_closeBeverageOverlay2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x001322D0 File Offset: 0x001304D0
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x00019CCD File Offset: 0x00017ECD
		public unsafe GameObject deliverSpecialGuestOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_deliverSpecialGuestOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_deliverSpecialGuestOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00132300 File Offset: 0x00130500
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x00019CEC File Offset: 0x00017EEC
		public unsafe GameObject executeDeliverSpecialGuestOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_executeDeliverSpecialGuestOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_executeDeliverSpecialGuestOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00132330 File Offset: 0x00130530
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x00019D0B File Offset: 0x00017F0B
		public unsafe GameObject qteTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_qteTutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_qteTutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x00132360 File Offset: 0x00130560
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x00019D2A File Offset: 0x00017F2A
		public unsafe Dictionary<string, GuestGroupController> controlledGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_controlledGuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GuestGroupController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_controlledGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x00132390 File Offset: 0x00130590
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x00019D49 File Offset: 0x00017F49
		public unsafe Dictionary<string, Action> m_CurrentDisplayDialogBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_m_CurrentDisplayDialogBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_m_CurrentDisplayDialogBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x001323C0 File Offset: 0x001305C0
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x00019D68 File Offset: 0x00017F68
		public unsafe bool canGotoNextPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_canGotoNextPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_canGotoNextPhase)) = value;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x001323E8 File Offset: 0x001305E8
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x00019D83 File Offset: 0x00017F83
		public unsafe bool isInTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_isInTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_isInTutorial)) = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x00132410 File Offset: 0x00130610
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x00019D9E File Offset: 0x00017F9E
		public unsafe bool onInteractableExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_onInteractableExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_onInteractableExit)) = value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00132438 File Offset: 0x00130638
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x00019DB9 File Offset: 0x00017FB9
		public unsafe bool onInteractableOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_onInteractableOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.NativeFieldInfoPtr_onInteractableOpen)) = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00132460 File Offset: 0x00130660
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00019DD4 File Offset: 0x00017FD4
		public unsafe static bool _IsManualWorkSceneSession_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__IsManualWorkSceneSession_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__IsManualWorkSceneSession_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0013247C File Offset: 0x0013067C
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x00019DE2 File Offset: 0x00017FE2
		public unsafe static int _DaySceneRemainedActions_k__BackingField
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__DaySceneRemainedActions_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__DaySceneRemainedActions_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00132498 File Offset: 0x00130698
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x00019DF0 File Offset: 0x00017FF0
		public unsafe static bool _IsKyoukoTutorialMode_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__IsKyoukoTutorialMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__IsKyoukoTutorialMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x001324B4 File Offset: 0x001306B4
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00019DFE File Offset: 0x00017FFE
		public unsafe static ValueTuple<Action, Action> _KyoukoTutorialTimelineCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Action, Action>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__KyoukoTutorialTimelineCallback_k__BackingField, intPtr);
				return new ValueTuple<Action, Action>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Action, Action>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__KyoukoTutorialTimelineCallback_k__BackingField, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x001324F0 File Offset: 0x001306F0
		// (set) Token: 0x06002C89 RID: 11401 RVA: 0x00019E15 File Offset: 0x00018015
		public unsafe static NightSceneDirector.ChallengeType _ChallengeMode_k__BackingField
		{
			get
			{
				NightSceneDirector.ChallengeType result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__ChallengeMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__ChallengeMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x0013250C File Offset: 0x0013070C
		// (set) Token: 0x06002C8B RID: 11403 RVA: 0x00019E23 File Offset: 0x00018023
		public unsafe static NightSceneDirector.Difficulty _DifficultyMode_k__BackingField
		{
			get
			{
				NightSceneDirector.Difficulty result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__DifficultyMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__DifficultyMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002C8C RID: 11404 RVA: 0x00132528 File Offset: 0x00130728
		// (set) Token: 0x06002C8D RID: 11405 RVA: 0x00019E31 File Offset: 0x00018031
		public unsafe static bool _DoNotFadeOutInChallenge_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.NativeFieldInfoPtr__DoNotFadeOutInChallenge_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.NativeFieldInfoPtr__DoNotFadeOutInChallenge_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeFieldInfoPtr_cookerSelectionOverlay;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeFieldInfoPtr_recipeSelectionOverlay;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeFieldInfoPtr_startCookingOverlay;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeFieldInfoPtr_cookingOverlay;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeFieldInfoPtr_extractOverlay;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeFieldInfoPtr_gotoBeverageOverlay;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeFieldInfoPtr_extractBeverageOverlay;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeFieldInfoPtr_closeBeverageOverlay;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeFieldInfoPtr_gotoDeliverOverlay;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeFieldInfoPtr_deliverOverlay;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeFieldInfoPtr_closeDeliverOverlay;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeFieldInfoPtr_openWriggleOverlay;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeFieldInfoPtr_exitWriggleOverlay;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeFieldInfoPtr_dialog;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeFieldInfoPtr_openCookerOverlay;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeFieldInfoPtr_selectOverlay;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeFieldInfoPtr_waitOverlay;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr_extractCookedOverlay;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeFieldInfoPtr_openBeverageOverlay;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeFieldInfoPtr_selectBeverageOverlay;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeFieldInfoPtr_closeBeverageOverlay2;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeFieldInfoPtr_deliverSpecialGuestOverlay;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeFieldInfoPtr_executeDeliverSpecialGuestOverlay;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeFieldInfoPtr_qteTutorial;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeFieldInfoPtr_controlledGuest;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDisplayDialogBox;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeFieldInfoPtr_canGotoNextPhase;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeFieldInfoPtr_isInTutorial;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeFieldInfoPtr_onInteractableExit;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeFieldInfoPtr_onInteractableOpen;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeFieldInfoPtr__IsManualWorkSceneSession_k__BackingField;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr__DaySceneRemainedActions_k__BackingField;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr__IsKyoukoTutorialMode_k__BackingField;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeFieldInfoPtr__KyoukoTutorialTimelineCallback_k__BackingField;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr__ChallengeMode_k__BackingField;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeFieldInfoPtr__DifficultyMode_k__BackingField;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeFieldInfoPtr__DoNotFadeOutInChallenge_k__BackingField;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_get_IsManualWorkSceneSession_Public_Static_get_Boolean_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_set_IsManualWorkSceneSession_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneRemainedActions_Public_Static_get_Int32_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_set_DaySceneRemainedActions_Public_Static_set_Void_Int32_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKyoukoTutorialMode_Public_Static_get_Boolean_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKyoukoTutorialMode_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_get_KyoukoTutorialTimelineCallback_Public_Static_get_ValueTuple_2_Action_Action_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_set_KyoukoTutorialTimelineCallback_Public_Static_set_Void_ValueTuple_2_Action_Action_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr_get_ChallengeMode_Public_Static_get_ChallengeType_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr_set_ChallengeMode_Public_Static_set_Void_ChallengeType_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_get_DifficultyMode_Public_Static_get_Difficulty_0;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeMethodInfoPtr_set_DifficultyMode_Public_Static_set_Void_Difficulty_0;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotFadeOutInChallenge_Public_Static_get_Boolean_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_set_DoNotFadeOutInChallenge_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNormalNightOrRogueLike_Public_Static_get_Boolean_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInTutorial_Public_get_Boolean_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_set_IsInTutorial_Private_set_Void_Boolean_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_GetControlled_Public_GuestGroupController_String_0;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTimeFlow_Public_Void_Boolean_0;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGuestSpawn_Public_Void_Boolean_0;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeMethodInfoPtr_SpawnManualControlledSpecialGuestAuto_Public_Void_Int32_Action_0;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_SpawnManualControlledSpecialGuest_Public_Void_Int32_String_Boolean_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_SetManualControlledToSeat_Public_Void_String_Int32_Int32_Action_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialGuestOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialGuestSpecialOrder_Public_Void_String_Int32_Int32_Action_1_EvaluationResult_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialGuestLeave_Public_Void_String_Boolean_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialGuestPatient_Public_Void_String_Int32_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_SetSpecialGuestSpell_Public_Void_String_Boolean_Boolean_Action_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_PlayCustomDialog_Public_Void_String_String_Single_Action_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_PlaySpecialGuestEvaluationDialog_Public_Void_String_EvaluationResult_Action_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_PlayDialogCoroutine_Private_IEnumerator_String_Func_1_ValueTuple_2_TDialogBox_Action_1_TDialogBox_Func_2_TDialogBox_IEnumerator_Action_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_TryLeaveSession_Public_Void_Action_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_OnInteractableOpen_Public_Void_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_HasInteractableOpened_Private_Boolean_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_OnCanGotoNextPhase_Public_Void_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_CanGotoNextPhase_Private_Boolean_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_OnInteractableExit_Public_Void_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_HasInteractableExit_Private_Boolean_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_ResetParams_Private_Void_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_TutorialSession_Private_IEnumerator_GameObject_Action_Func_1_Boolean_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_StartTutorial_Public_Void_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_StartTutorial2_Public_Void_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_StartTutorial3_Public_Void_Action_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x020007E5 RID: 2021
		public enum ChallengeType
		{
			// Token: 0x04006C0B RID: 27659
			NotChallenge,
			// Token: 0x04006C0C RID: 27660
			Story_Basic,
			// Token: 0x04006C0D RID: 27661
			Story_Advanced,
			// Token: 0x04006C0E RID: 27662
			Story_Yuyuko,
			// Token: 0x04006C0F RID: 27663
			Challenge_Yuyuko,
			// Token: 0x04006C10 RID: 27664
			AnyChallenge,
			// Token: 0x04006C11 RID: 27665
			Story_BloodPondHell,
			// Token: 0x04006C12 RID: 27666
			Story_WackyCookingCompetition,
			// Token: 0x04006C13 RID: 27667
			Story_Seiga_TempleCuisineCompetition,
			// Token: 0x04006C14 RID: 27668
			Story_Futo_TempleCuisineCompetition,
			// Token: 0x04006C15 RID: 27669
			Story_Tochiko_TempleCuisineCompetition,
			// Token: 0x04006C16 RID: 27670
			Story_Ichirin_MusicCompetition,
			// Token: 0x04006C17 RID: 27671
			Story_Minamitu_MusicCompetition,
			// Token: 0x04006C18 RID: 27672
			Story_Toramaru_MusicCompetition,
			// Token: 0x04006C19 RID: 27673
			Story_Flandre,
			// Token: 0x04006C1A RID: 27674
			RogueLike,
			// Token: 0x04006C1B RID: 27675
			Story_Mizuchi,
			// Token: 0x04006C1C RID: 27676
			Story_Mizuchi_1,
			// Token: 0x04006C1D RID: 27677
			Story_Mizuchi_2,
			// Token: 0x04006C1E RID: 27678
			Story_Mizuchi_3
		}

		// Token: 0x020007E6 RID: 2022
		public enum Difficulty
		{
			// Token: 0x04006C20 RID: 27680
			None,
			// Token: 0x04006C21 RID: 27681
			Easy,
			// Token: 0x04006C22 RID: 27682
			Normal,
			// Token: 0x04006C23 RID: 27683
			Hard,
			// Token: 0x04006C24 RID: 27684
			Lunatic
		}

		// Token: 0x020007E7 RID: 2023
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A747 RID: 42823 RVA: 0x002B8844 File Offset: 0x002B6A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass69_0.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr, "onEnd");
				NightSceneDirector.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr, 100671032);
				NightSceneDirector.__c__DisplayClass69_0.NativeMethodInfoPtr__SpawnManualControlledSpecialGuestAuto_b__0_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr, 100671033);
			}

			// Token: 0x0600A748 RID: 42824 RVA: 0x002B88AC File Offset: 0x002B6AAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A749 RID: 42825 RVA: 0x002B88E8 File Offset: 0x002B6AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnManualControlledSpecialGuestAuto_b__0(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass69_0.NativeMethodInfoPtr__SpawnManualControlledSpecialGuestAuto_b__0_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A74A RID: 42826 RVA: 0x0005A65D File Offset: 0x0005885D
			public __c__DisplayClass69_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003704 RID: 14084
			// (get) Token: 0x0600A74B RID: 42827 RVA: 0x002B892C File Offset: 0x002B6B2C
			// (set) Token: 0x0600A74C RID: 42828 RVA: 0x0005A666 File Offset: 0x00058866
			public unsafe Action onEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass69_0.NativeFieldInfoPtr_onEnd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass69_0.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C25 RID: 27685
			private static readonly IntPtr NativeFieldInfoPtr_onEnd;

			// Token: 0x04006C26 RID: 27686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C27 RID: 27687
			private static readonly IntPtr NativeMethodInfoPtr__SpawnManualControlledSpecialGuestAuto_b__0_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x020007E8 RID: 2024
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A74D RID: 42829 RVA: 0x002B895C File Offset: 0x002B6B5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass76_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr, "onFinish");
				NightSceneDirector.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr, 100671034);
				NightSceneDirector.__c__DisplayClass76_0.NativeMethodInfoPtr__SetSpecialGuestSpell_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr, 100671035);
			}

			// Token: 0x0600A74E RID: 42830 RVA: 0x002B89C4 File Offset: 0x002B6BC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A74F RID: 42831 RVA: 0x002B8A00 File Offset: 0x002B6C00
			[CallerCount(0)]
			public unsafe void _SetSpecialGuestSpell_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass76_0.NativeMethodInfoPtr__SetSpecialGuestSpell_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A750 RID: 42832 RVA: 0x0005A685 File Offset: 0x00058885
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003705 RID: 14085
			// (get) Token: 0x0600A751 RID: 42833 RVA: 0x002B8A34 File Offset: 0x002B6C34
			// (set) Token: 0x0600A752 RID: 42834 RVA: 0x0005A68E File Offset: 0x0005888E
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass76_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass76_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C28 RID: 27688
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006C29 RID: 27689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C2A RID: 27690
			private static readonly IntPtr NativeMethodInfoPtr__SetSpecialGuestSpell_b__0_Internal_Void_0;
		}

		// Token: 0x020007E9 RID: 2025
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A753 RID: 42835 RVA: 0x002B8A64 File Offset: 0x002B6C64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr, "character");
				NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr, "duration");
				NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr, "message");
				NightSceneDirector.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr, 100671036);
				NightSceneDirector.__c__DisplayClass77_0.NativeMethodInfoPtr__PlayCustomDialog_b__1_Internal_IEnumerator_DialogBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr, 100671037);
			}

			// Token: 0x0600A754 RID: 42836 RVA: 0x002B8AF4 File Offset: 0x002B6CF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A755 RID: 42837 RVA: 0x002B8B30 File Offset: 0x002B6D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98717, XrefRangeEnd = 98719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PlayCustomDialog_b__1(DialogBoxUI dialogBox)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogBox);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass77_0.NativeMethodInfoPtr__PlayCustomDialog_b__1_Internal_IEnumerator_DialogBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A756 RID: 42838 RVA: 0x0005A6AD File Offset: 0x000588AD
			public __c__DisplayClass77_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003706 RID: 14086
			// (get) Token: 0x0600A757 RID: 42839 RVA: 0x002B8B80 File Offset: 0x002B6D80
			// (set) Token: 0x0600A758 RID: 42840 RVA: 0x0005A6B6 File Offset: 0x000588B6
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003707 RID: 14087
			// (get) Token: 0x0600A759 RID: 42841 RVA: 0x002B8BB0 File Offset: 0x002B6DB0
			// (set) Token: 0x0600A75A RID: 42842 RVA: 0x0005A6D5 File Offset: 0x000588D5
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17003708 RID: 14088
			// (get) Token: 0x0600A75B RID: 42843 RVA: 0x002B8BD8 File Offset: 0x002B6DD8
			// (set) Token: 0x0600A75C RID: 42844 RVA: 0x0005A6F0 File Offset: 0x000588F0
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass77_0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04006C2B RID: 27691
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04006C2C RID: 27692
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04006C2D RID: 27693
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04006C2E RID: 27694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C2F RID: 27695
			private static readonly IntPtr NativeMethodInfoPtr__PlayCustomDialog_b__1_Internal_IEnumerator_DialogBoxUI_0;
		}

		// Token: 0x020007EA RID: 2026
		[ObfuscatedName("NightScene.NightSceneDirector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A75D RID: 42845 RVA: 0x002B8C00 File Offset: 0x002B6E00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr);
				NightSceneDirector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__77_0");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__78_0");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__89_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__89_1");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__89_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__89_2");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__89_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__89_3");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__89_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__89_4");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_1");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_4");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_5");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_6");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_7");
				NightSceneDirector.__c.NativeFieldInfoPtr___9__90_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, "<>9__90_8");
				NightSceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671039);
				NightSceneDirector.__c.NativeMethodInfoPtr__PlayCustomDialog_b__77_0_Internal_ValueTuple_2_DialogBoxUI_Action_1_DialogBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671040);
				NightSceneDirector.__c.NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__78_0_Internal_ValueTuple_2_EvalulationBoxUI_Action_1_EvalulationBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671041);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671042);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671043);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671044);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671045);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671046);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671047);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671048);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671049);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671050);
				NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr, 100671051);
			}

			// Token: 0x0600A75E RID: 42846 RVA: 0x002B8E34 File Offset: 0x002B7034
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A75F RID: 42847 RVA: 0x002B8E70 File Offset: 0x002B7070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98719, XrefRangeEnd = 98726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<DialogBoxUI, Action<DialogBoxUI>> _PlayCustomDialog_b__77_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__PlayCustomDialog_b__77_0_Internal_ValueTuple_2_DialogBoxUI_Action_1_DialogBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<DialogBoxUI, Action<DialogBoxUI>>(pointer);
			}

			// Token: 0x0600A760 RID: 42848 RVA: 0x002B8EA8 File Offset: 0x002B70A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98726, XrefRangeEnd = 98733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<EvalulationBoxUI, Action<EvalulationBoxUI>> _PlaySpecialGuestEvaluationDialog_b__78_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__78_0_Internal_ValueTuple_2_EvalulationBoxUI_Action_1_EvalulationBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<EvalulationBoxUI, Action<EvalulationBoxUI>>(pointer);
			}

			// Token: 0x0600A761 RID: 42849 RVA: 0x002B8EE0 File Offset: 0x002B70E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98733, XrefRangeEnd = 98744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial_b__89_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A762 RID: 42850 RVA: 0x002B8F14 File Offset: 0x002B7114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98744, XrefRangeEnd = 98752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial_b__89_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A763 RID: 42851 RVA: 0x002B8F48 File Offset: 0x002B7148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98752, XrefRangeEnd = 98763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial_b__89_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A764 RID: 42852 RVA: 0x002B8F7C File Offset: 0x002B717C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98763, XrefRangeEnd = 98768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial_b__89_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial_b__89_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A765 RID: 42853 RVA: 0x002B8FB0 File Offset: 0x002B71B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98768, XrefRangeEnd = 98779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A766 RID: 42854 RVA: 0x002B8FE4 File Offset: 0x002B71E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98779, XrefRangeEnd = 98801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A767 RID: 42855 RVA: 0x002B9018 File Offset: 0x002B7218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98801, XrefRangeEnd = 98807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A768 RID: 42856 RVA: 0x002B904C File Offset: 0x002B724C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98807, XrefRangeEnd = 98813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A769 RID: 42857 RVA: 0x002B9080 File Offset: 0x002B7280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98813, XrefRangeEnd = 98830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A76A RID: 42858 RVA: 0x002B90B4 File Offset: 0x002B72B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98830, XrefRangeEnd = 98838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__90_8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c.NativeMethodInfoPtr__StartTutorial2_b__90_8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A76B RID: 42859 RVA: 0x0005A70F File Offset: 0x0005890F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003709 RID: 14089
			// (get) Token: 0x0600A76C RID: 42860 RVA: 0x002B90E8 File Offset: 0x002B72E8
			// (set) Token: 0x0600A76D RID: 42861 RVA: 0x0005A718 File Offset: 0x00058918
			public unsafe static NightSceneDirector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370A RID: 14090
			// (get) Token: 0x0600A76E RID: 42862 RVA: 0x002B9110 File Offset: 0x002B7310
			// (set) Token: 0x0600A76F RID: 42863 RVA: 0x0005A72A File Offset: 0x0005892A
			public unsafe static Func<ValueTuple<DialogBoxUI, Action<DialogBoxUI>>> __9__77_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<DialogBoxUI, Action<DialogBoxUI>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370B RID: 14091
			// (get) Token: 0x0600A770 RID: 42864 RVA: 0x002B9138 File Offset: 0x002B7338
			// (set) Token: 0x0600A771 RID: 42865 RVA: 0x0005A73C File Offset: 0x0005893C
			public unsafe static Func<ValueTuple<EvalulationBoxUI, Action<EvalulationBoxUI>>> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<EvalulationBoxUI, Action<EvalulationBoxUI>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370C RID: 14092
			// (get) Token: 0x0600A772 RID: 42866 RVA: 0x002B9160 File Offset: 0x002B7360
			// (set) Token: 0x0600A773 RID: 42867 RVA: 0x0005A74E File Offset: 0x0005894E
			public unsafe static Action __9__89_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370D RID: 14093
			// (get) Token: 0x0600A774 RID: 42868 RVA: 0x002B9188 File Offset: 0x002B7388
			// (set) Token: 0x0600A775 RID: 42869 RVA: 0x0005A760 File Offset: 0x00058960
			public unsafe static Action __9__89_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370E RID: 14094
			// (get) Token: 0x0600A776 RID: 42870 RVA: 0x002B91B0 File Offset: 0x002B73B0
			// (set) Token: 0x0600A777 RID: 42871 RVA: 0x0005A772 File Offset: 0x00058972
			public unsafe static Action __9__89_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700370F RID: 14095
			// (get) Token: 0x0600A778 RID: 42872 RVA: 0x002B91D8 File Offset: 0x002B73D8
			// (set) Token: 0x0600A779 RID: 42873 RVA: 0x0005A784 File Offset: 0x00058984
			public unsafe static Action __9__89_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__89_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003710 RID: 14096
			// (get) Token: 0x0600A77A RID: 42874 RVA: 0x002B9200 File Offset: 0x002B7400
			// (set) Token: 0x0600A77B RID: 42875 RVA: 0x0005A796 File Offset: 0x00058996
			public unsafe static Action __9__90_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003711 RID: 14097
			// (get) Token: 0x0600A77C RID: 42876 RVA: 0x002B9228 File Offset: 0x002B7428
			// (set) Token: 0x0600A77D RID: 42877 RVA: 0x0005A7A8 File Offset: 0x000589A8
			public unsafe static Action __9__90_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003712 RID: 14098
			// (get) Token: 0x0600A77E RID: 42878 RVA: 0x002B9250 File Offset: 0x002B7450
			// (set) Token: 0x0600A77F RID: 42879 RVA: 0x0005A7BA File Offset: 0x000589BA
			public unsafe static Action __9__90_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003713 RID: 14099
			// (get) Token: 0x0600A780 RID: 42880 RVA: 0x002B9278 File Offset: 0x002B7478
			// (set) Token: 0x0600A781 RID: 42881 RVA: 0x0005A7CC File Offset: 0x000589CC
			public unsafe static Action __9__90_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003714 RID: 14100
			// (get) Token: 0x0600A782 RID: 42882 RVA: 0x002B92A0 File Offset: 0x002B74A0
			// (set) Token: 0x0600A783 RID: 42883 RVA: 0x0005A7DE File Offset: 0x000589DE
			public unsafe static Action __9__90_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003715 RID: 14101
			// (get) Token: 0x0600A784 RID: 42884 RVA: 0x002B92C8 File Offset: 0x002B74C8
			// (set) Token: 0x0600A785 RID: 42885 RVA: 0x0005A7F0 File Offset: 0x000589F0
			public unsafe static Action __9__90_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDirector.__c.NativeFieldInfoPtr___9__90_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C30 RID: 27696
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006C31 RID: 27697
			private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

			// Token: 0x04006C32 RID: 27698
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x04006C33 RID: 27699
			private static readonly IntPtr NativeFieldInfoPtr___9__89_1;

			// Token: 0x04006C34 RID: 27700
			private static readonly IntPtr NativeFieldInfoPtr___9__89_2;

			// Token: 0x04006C35 RID: 27701
			private static readonly IntPtr NativeFieldInfoPtr___9__89_3;

			// Token: 0x04006C36 RID: 27702
			private static readonly IntPtr NativeFieldInfoPtr___9__89_4;

			// Token: 0x04006C37 RID: 27703
			private static readonly IntPtr NativeFieldInfoPtr___9__90_1;

			// Token: 0x04006C38 RID: 27704
			private static readonly IntPtr NativeFieldInfoPtr___9__90_4;

			// Token: 0x04006C39 RID: 27705
			private static readonly IntPtr NativeFieldInfoPtr___9__90_5;

			// Token: 0x04006C3A RID: 27706
			private static readonly IntPtr NativeFieldInfoPtr___9__90_6;

			// Token: 0x04006C3B RID: 27707
			private static readonly IntPtr NativeFieldInfoPtr___9__90_7;

			// Token: 0x04006C3C RID: 27708
			private static readonly IntPtr NativeFieldInfoPtr___9__90_8;

			// Token: 0x04006C3D RID: 27709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C3E RID: 27710
			private static readonly IntPtr NativeMethodInfoPtr__PlayCustomDialog_b__77_0_Internal_ValueTuple_2_DialogBoxUI_Action_1_DialogBoxUI_0;

			// Token: 0x04006C3F RID: 27711
			private static readonly IntPtr NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__78_0_Internal_ValueTuple_2_EvalulationBoxUI_Action_1_EvalulationBoxUI_0;

			// Token: 0x04006C40 RID: 27712
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial_b__89_1_Internal_Void_0;

			// Token: 0x04006C41 RID: 27713
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial_b__89_2_Internal_Void_0;

			// Token: 0x04006C42 RID: 27714
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial_b__89_3_Internal_Void_0;

			// Token: 0x04006C43 RID: 27715
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial_b__89_4_Internal_Void_0;

			// Token: 0x04006C44 RID: 27716
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_1_Internal_Void_0;

			// Token: 0x04006C45 RID: 27717
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_4_Internal_Void_0;

			// Token: 0x04006C46 RID: 27718
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_5_Internal_Void_0;

			// Token: 0x04006C47 RID: 27719
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_6_Internal_Void_0;

			// Token: 0x04006C48 RID: 27720
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_7_Internal_Void_0;

			// Token: 0x04006C49 RID: 27721
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__90_8_Internal_Void_0;
		}

		// Token: 0x020007EB RID: 2027
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A786 RID: 42886 RVA: 0x002B92F0 File Offset: 0x002B74F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr, "result");
				NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr, "character");
				NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_evaluationDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr, "evaluationDialog");
				NightSceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr, 100671052);
				NightSceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__1_Internal_IEnumerator_EvalulationBoxUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr, 100671053);
			}

			// Token: 0x0600A787 RID: 42887 RVA: 0x002B9380 File Offset: 0x002B7580
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A788 RID: 42888 RVA: 0x002B93BC File Offset: 0x002B75BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98838, XrefRangeEnd = 98840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _PlaySpecialGuestEvaluationDialog_b__1(EvalulationBoxUI dialogBox)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogBox);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__1_Internal_IEnumerator_EvalulationBoxUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A789 RID: 42889 RVA: 0x0005A802 File Offset: 0x00058A02
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003716 RID: 14102
			// (get) Token: 0x0600A78A RID: 42890 RVA: 0x002B940C File Offset: 0x002B760C
			// (set) Token: 0x0600A78B RID: 42891 RVA: 0x0005A80B File Offset: 0x00058A0B
			public unsafe GuestGroupController.EvaluationResult result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x17003717 RID: 14103
			// (get) Token: 0x0600A78C RID: 42892 RVA: 0x002B9434 File Offset: 0x002B7634
			// (set) Token: 0x0600A78D RID: 42893 RVA: 0x0005A826 File Offset: 0x00058A26
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003718 RID: 14104
			// (get) Token: 0x0600A78E RID: 42894 RVA: 0x002B9464 File Offset: 0x002B7664
			// (set) Token: 0x0600A78F RID: 42895 RVA: 0x0005A845 File Offset: 0x00058A45
			public unsafe string evaluationDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_evaluationDialog);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_evaluationDialog), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04006C4A RID: 27722
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04006C4B RID: 27723
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04006C4C RID: 27724
			private static readonly IntPtr NativeFieldInfoPtr_evaluationDialog;

			// Token: 0x04006C4D RID: 27725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C4E RID: 27726
			private static readonly IntPtr NativeMethodInfoPtr__PlaySpecialGuestEvaluationDialog_b__1_Internal_IEnumerator_EvalulationBoxUI_0;
		}

		// Token: 0x020007EC RID: 2028
		[ObfuscatedName("NightScene.NightSceneDirector+<PlayDialogCoroutine>d__79`1")]
		public sealed class _PlayDialogCoroutine_d__79<TDialogBox> : Il2CppSystem.Object where TDialogBox : DialogBoxUI
		{
			// Token: 0x0600A790 RID: 42896 RVA: 0x002B948C File Offset: 0x002B768C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayDialogCoroutine_d__79()
			{
				Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<PlayDialogCoroutine>d__79`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDialogBox>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "<>1__state");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "<>2__current");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "<>4__this");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "characterId");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_getNewDialogBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "getNewDialogBox");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_setMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "setMessage");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "onFinish");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr__dialogBoxParent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, "<dialogBoxParent>5__2");
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671054);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671055);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671056);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671057);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671058);
				NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr, 100671059);
			}

			// Token: 0x0600A791 RID: 42897 RVA: 0x002B960C File Offset: 0x002B780C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayDialogCoroutine_d__79(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A792 RID: 42898 RVA: 0x002B9654 File Offset: 0x002B7854
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A793 RID: 42899 RVA: 0x002B9688 File Offset: 0x002B7888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98840, XrefRangeEnd = 98860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003721 RID: 14113
			// (get) Token: 0x0600A794 RID: 42900 RVA: 0x002B96C4 File Offset: 0x002B78C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A795 RID: 42901 RVA: 0x002B9704 File Offset: 0x002B7904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98860, XrefRangeEnd = 98883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003722 RID: 14114
			// (get) Token: 0x0600A796 RID: 42902 RVA: 0x002B9738 File Offset: 0x002B7938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A797 RID: 42903 RVA: 0x0005A864 File Offset: 0x00058A64
			public _PlayDialogCoroutine_d__79(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003719 RID: 14105
			// (get) Token: 0x0600A798 RID: 42904 RVA: 0x002B9778 File Offset: 0x002B7978
			// (set) Token: 0x0600A799 RID: 42905 RVA: 0x0005A86D File Offset: 0x00058A6D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700371A RID: 14106
			// (get) Token: 0x0600A79A RID: 42906 RVA: 0x002B97A0 File Offset: 0x002B79A0
			// (set) Token: 0x0600A79B RID: 42907 RVA: 0x0005A888 File Offset: 0x00058A88
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700371B RID: 14107
			// (get) Token: 0x0600A79C RID: 42908 RVA: 0x002B97D0 File Offset: 0x002B79D0
			// (set) Token: 0x0600A79D RID: 42909 RVA: 0x0005A8A7 File Offset: 0x00058AA7
			public unsafe NightSceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700371C RID: 14108
			// (get) Token: 0x0600A79E RID: 42910 RVA: 0x002B9800 File Offset: 0x002B7A00
			// (set) Token: 0x0600A79F RID: 42911 RVA: 0x0005A8C6 File Offset: 0x00058AC6
			public unsafe string characterId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_characterId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_characterId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700371D RID: 14109
			// (get) Token: 0x0600A7A0 RID: 42912 RVA: 0x002B9828 File Offset: 0x002B7A28
			// (set) Token: 0x0600A7A1 RID: 42913 RVA: 0x0005A8E5 File Offset: 0x00058AE5
			public unsafe Func<ValueTuple<TDialogBox, Action<TDialogBox>>> getNewDialogBox
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_getNewDialogBox);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<TDialogBox, Action<TDialogBox>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_getNewDialogBox), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700371E RID: 14110
			// (get) Token: 0x0600A7A2 RID: 42914 RVA: 0x002B9858 File Offset: 0x002B7A58
			// (set) Token: 0x0600A7A3 RID: 42915 RVA: 0x0005A904 File Offset: 0x00058B04
			public unsafe Func<TDialogBox, IEnumerator> setMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_setMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TDialogBox, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_setMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700371F RID: 14111
			// (get) Token: 0x0600A7A4 RID: 42916 RVA: 0x002B9888 File Offset: 0x002B7A88
			// (set) Token: 0x0600A7A5 RID: 42917 RVA: 0x0005A923 File Offset: 0x00058B23
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003720 RID: 14112
			// (get) Token: 0x0600A7A6 RID: 42918 RVA: 0x002B98B8 File Offset: 0x002B7AB8
			// (set) Token: 0x0600A7A7 RID: 42919 RVA: 0x0005A942 File Offset: 0x00058B42
			public ValueTuple<TDialogBox, Action<TDialogBox>> _dialogBoxParent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr__dialogBoxParent_5__2);
					return new ValueTuple<TDialogBox, Action<TDialogBox>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<TDialogBox, Action<TDialogBox>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._PlayDialogCoroutine_d__79<TDialogBox>.NativeFieldInfoPtr__dialogBoxParent_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<TDialogBox, Action<TDialogBox>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006C4F RID: 27727
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C50 RID: 27728
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C51 RID: 27729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C52 RID: 27730
			private static readonly IntPtr NativeFieldInfoPtr_characterId;

			// Token: 0x04006C53 RID: 27731
			private static readonly IntPtr NativeFieldInfoPtr_getNewDialogBox;

			// Token: 0x04006C54 RID: 27732
			private static readonly IntPtr NativeFieldInfoPtr_setMessage;

			// Token: 0x04006C55 RID: 27733
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006C56 RID: 27734
			private static readonly IntPtr NativeFieldInfoPtr__dialogBoxParent_5__2;

			// Token: 0x04006C57 RID: 27735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C58 RID: 27736
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C59 RID: 27737
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C5A RID: 27738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C5B RID: 27739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C5C RID: 27740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007ED RID: 2029
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A7A8 RID: 42920 RVA: 0x002B98E8 File Offset: 0x002B7AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr, "onFinish");
				NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr, 100671060);
				NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr, 100671061);
				NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr, 100671062);
			}

			// Token: 0x0600A7A9 RID: 42921 RVA: 0x002B9964 File Offset: 0x002B7B64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7AA RID: 42922 RVA: 0x002B99A0 File Offset: 0x002B7BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98883, XrefRangeEnd = 98899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7AB RID: 42923 RVA: 0x002B99D4 File Offset: 0x002B7BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98899, XrefRangeEnd = 98904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7AC RID: 42924 RVA: 0x0005A970 File Offset: 0x00058B70
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003723 RID: 14115
			// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002B9A08 File Offset: 0x002B7C08
			// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x0005A979 File Offset: 0x00058B79
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C5D RID: 27741
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006C5E RID: 27742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C5F RID: 27743
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04006C60 RID: 27744
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}

		// Token: 0x020007EE RID: 2030
		[ObfuscatedName("NightScene.NightSceneDirector+<TutorialSession>d__88")]
		public sealed class _TutorialSession_d__88 : Il2CppSystem.Object
		{
			// Token: 0x0600A7AF RID: 42927 RVA: 0x002B9A38 File Offset: 0x002B7C38
			// Note: this type is marked as 'beforefieldinit'.
			static _TutorialSession_d__88()
			{
				Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<TutorialSession>d__88");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr);
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "<>1__state");
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "<>2__current");
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_preInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "preInitialize");
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_displayedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "displayedObject");
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "waitHandle");
				NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr__displayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, "<displayed>5__2");
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671063);
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671064);
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671065);
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671066);
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671067);
				NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr, 100671068);
			}

			// Token: 0x0600A7B0 RID: 42928 RVA: 0x002B9B54 File Offset: 0x002B7D54
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TutorialSession_d__88(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector._TutorialSession_d__88>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7B1 RID: 42929 RVA: 0x002B9B9C File Offset: 0x002B7D9C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7B2 RID: 42930 RVA: 0x002B9BD0 File Offset: 0x002B7DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98904, XrefRangeEnd = 98924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700372A RID: 14122
			// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x002B9C0C File Offset: 0x002B7E0C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7B4 RID: 42932 RVA: 0x002B9C4C File Offset: 0x002B7E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98924, XrefRangeEnd = 98930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700372B RID: 14123
			// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x002B9C80 File Offset: 0x002B7E80
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector._TutorialSession_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7B6 RID: 42934 RVA: 0x0005A998 File Offset: 0x00058B98
			public _TutorialSession_d__88(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003724 RID: 14116
			// (get) Token: 0x0600A7B7 RID: 42935 RVA: 0x002B9CC0 File Offset: 0x002B7EC0
			// (set) Token: 0x0600A7B8 RID: 42936 RVA: 0x0005A9A1 File Offset: 0x00058BA1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003725 RID: 14117
			// (get) Token: 0x0600A7B9 RID: 42937 RVA: 0x002B9CE8 File Offset: 0x002B7EE8
			// (set) Token: 0x0600A7BA RID: 42938 RVA: 0x0005A9BC File Offset: 0x00058BBC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003726 RID: 14118
			// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x002B9D18 File Offset: 0x002B7F18
			// (set) Token: 0x0600A7BC RID: 42940 RVA: 0x0005A9DB File Offset: 0x00058BDB
			public unsafe Action preInitialize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_preInitialize);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_preInitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003727 RID: 14119
			// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x002B9D48 File Offset: 0x002B7F48
			// (set) Token: 0x0600A7BE RID: 42942 RVA: 0x0005A9FA File Offset: 0x00058BFA
			public unsafe GameObject displayedObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_displayedObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_displayedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003728 RID: 14120
			// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x002B9D78 File Offset: 0x002B7F78
			// (set) Token: 0x0600A7C0 RID: 42944 RVA: 0x0005AA19 File Offset: 0x00058C19
			public unsafe Func<bool> waitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_waitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003729 RID: 14121
			// (get) Token: 0x0600A7C1 RID: 42945 RVA: 0x002B9DA8 File Offset: 0x002B7FA8
			// (set) Token: 0x0600A7C2 RID: 42946 RVA: 0x0005AA38 File Offset: 0x00058C38
			public unsafe GameObject _displayed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr__displayed_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector._TutorialSession_d__88.NativeFieldInfoPtr__displayed_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C61 RID: 27745
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C62 RID: 27746
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C63 RID: 27747
			private static readonly IntPtr NativeFieldInfoPtr_preInitialize;

			// Token: 0x04006C64 RID: 27748
			private static readonly IntPtr NativeFieldInfoPtr_displayedObject;

			// Token: 0x04006C65 RID: 27749
			private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

			// Token: 0x04006C66 RID: 27750
			private static readonly IntPtr NativeFieldInfoPtr__displayed_5__2;

			// Token: 0x04006C67 RID: 27751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C68 RID: 27752
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C69 RID: 27753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C6A RID: 27754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C6B RID: 27755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C6C RID: 27756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007EF RID: 2031
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A7C3 RID: 42947 RVA: 0x002B9DD8 File Offset: 0x002B7FD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass90_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr, "canContinue");
				NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr, 100671069);
				NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__StartTutorial2_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr, 100671070);
				NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__StartTutorial2_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr, 100671071);
			}

			// Token: 0x0600A7C4 RID: 42948 RVA: 0x002B9E54 File Offset: 0x002B8054
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7C5 RID: 42949 RVA: 0x002B9E90 File Offset: 0x002B8090
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial2_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__StartTutorial2_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7C6 RID: 42950 RVA: 0x002B9EC4 File Offset: 0x002B80C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartTutorial2_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass90_0.NativeMethodInfoPtr__StartTutorial2_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A7C7 RID: 42951 RVA: 0x0005AA57 File Offset: 0x00058C57
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700372C RID: 14124
			// (get) Token: 0x0600A7C8 RID: 42952 RVA: 0x002B9F00 File Offset: 0x002B8100
			// (set) Token: 0x0600A7C9 RID: 42953 RVA: 0x0005AA60 File Offset: 0x00058C60
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass90_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass90_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x04006C6D RID: 27757
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04006C6E RID: 27758
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C6F RID: 27759
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__2_Internal_Void_0;

			// Token: 0x04006C70 RID: 27760
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial2_b__3_Internal_Boolean_0;
		}

		// Token: 0x020007F0 RID: 2032
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass91_0")]
		public sealed class __c__DisplayClass91_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A7CA RID: 42954 RVA: 0x002B9F28 File Offset: 0x002B8128
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_0()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass91_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr, "<>4__this");
				NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr, "onFinish");
				NightSceneDirector.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr, 100671072);
				NightSceneDirector.__c__DisplayClass91_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr, 100671073);
			}

			// Token: 0x0600A7CB RID: 42955 RVA: 0x002B9FA4 File Offset: 0x002B81A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7CC RID: 42956 RVA: 0x002B9FE0 File Offset: 0x002B81E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98978, XrefRangeEnd = 98983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A7CD RID: 42957 RVA: 0x0005AA7B File Offset: 0x00058C7B
			public __c__DisplayClass91_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700372D RID: 14125
			// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x002BA020 File Offset: 0x002B8220
			// (set) Token: 0x0600A7CF RID: 42959 RVA: 0x0005AA84 File Offset: 0x00058C84
			public unsafe NightSceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700372E RID: 14126
			// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x002BA050 File Offset: 0x002B8250
			// (set) Token: 0x0600A7D1 RID: 42961 RVA: 0x0005AAA3 File Offset: 0x00058CA3
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C71 RID: 27761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C72 RID: 27762
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006C73 RID: 27763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C74 RID: 27764
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000FE0 RID: 4064
			[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass91_0+<<StartTutorial3>g__Tutorial|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011728 RID: 71464 RVA: 0x00402160 File Offset: 0x00400360
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0>.NativeClassPtr, "<<StartTutorial3>g__Tutorial|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671074);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671075);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671076);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671077);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671078);
					NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671079);
				}

				// Token: 0x06011729 RID: 71465 RVA: 0x00402240 File Offset: 0x00400440
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601172A RID: 71466 RVA: 0x00402288 File Offset: 0x00400488
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601172B RID: 71467 RVA: 0x004022BC File Offset: 0x004004BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98930, XrefRangeEnd = 98972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AB4 RID: 23220
				// (get) Token: 0x0601172C RID: 71468 RVA: 0x004022F8 File Offset: 0x004004F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601172D RID: 71469 RVA: 0x00402338 File Offset: 0x00400538
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98972, XrefRangeEnd = 98978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AB5 RID: 23221
				// (get) Token: 0x0601172E RID: 71470 RVA: 0x0040236C File Offset: 0x0040056C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601172F RID: 71471 RVA: 0x00097D52 File Offset: 0x00095F52
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AB1 RID: 23217
				// (get) Token: 0x06011730 RID: 71472 RVA: 0x004023AC File Offset: 0x004005AC
				// (set) Token: 0x06011731 RID: 71473 RVA: 0x00097D5B File Offset: 0x00095F5B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AB2 RID: 23218
				// (get) Token: 0x06011732 RID: 71474 RVA: 0x004023D4 File Offset: 0x004005D4
				// (set) Token: 0x06011733 RID: 71475 RVA: 0x00097D76 File Offset: 0x00095F76
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AB3 RID: 23219
				// (get) Token: 0x06011734 RID: 71476 RVA: 0x00402404 File Offset: 0x00400604
				// (set) Token: 0x06011735 RID: 71477 RVA: 0x00097D95 File Offset: 0x00095F95
				public unsafe NightSceneDirector.__c__DisplayClass91_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector.__c__DisplayClass91_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B04C RID: 45132
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B04D RID: 45133
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B04E RID: 45134
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B04F RID: 45135
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B050 RID: 45136
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B051 RID: 45137
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B052 RID: 45138
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B053 RID: 45139
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B054 RID: 45140
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020007F1 RID: 2033
		[ObfuscatedName("NightScene.NightSceneDirector+<>c__DisplayClass91_1")]
		public sealed class __c__DisplayClass91_1 : Il2CppSystem.Object
		{
			// Token: 0x0600A7D2 RID: 42962 RVA: 0x002BA080 File Offset: 0x002B8280
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_1()
			{
				Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<>c__DisplayClass91_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr);
				NightSceneDirector.__c__DisplayClass91_1.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr, "canContinue");
				NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr, 100671080);
				NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__StartTutorial3_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr, 100671081);
				NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__StartTutorial3_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr, 100671082);
			}

			// Token: 0x0600A7D3 RID: 42963 RVA: 0x002BA0FC File Offset: 0x002B82FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.__c__DisplayClass91_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7D4 RID: 42964 RVA: 0x002BA138 File Offset: 0x002B8338
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartTutorial3_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__StartTutorial3_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7D5 RID: 42965 RVA: 0x002BA16C File Offset: 0x002B836C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartTutorial3_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.__c__DisplayClass91_1.NativeMethodInfoPtr__StartTutorial3_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A7D6 RID: 42966 RVA: 0x0005AAC2 File Offset: 0x00058CC2
			public __c__DisplayClass91_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700372F RID: 14127
			// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x002BA1A8 File Offset: 0x002B83A8
			// (set) Token: 0x0600A7D8 RID: 42968 RVA: 0x0005AACB File Offset: 0x00058CCB
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_1.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.__c__DisplayClass91_1.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x04006C75 RID: 27765
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04006C76 RID: 27766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C77 RID: 27767
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial3_b__1_Internal_Void_0;

			// Token: 0x04006C78 RID: 27768
			private static readonly IntPtr NativeMethodInfoPtr__StartTutorial3_b__2_Internal_Boolean_0;
		}

		// Token: 0x020007F2 RID: 2034
		[ObfuscatedName("NightScene.NightSceneDirector+<<StartTutorial>g__Tutorial|89_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600A7D9 RID: 42969 RVA: 0x002BA1D0 File Offset: 0x002B83D0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<<StartTutorial>g__Tutorial|89_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671083);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671084);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671085);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671086);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671087);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr, 100671088);
			}

			// Token: 0x0600A7DA RID: 42970 RVA: 0x002BA2B0 File Offset: 0x002B84B0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7DB RID: 42971 RVA: 0x002BA2F8 File Offset: 0x002B84F8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7DC RID: 42972 RVA: 0x002BA32C File Offset: 0x002B852C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98983, XrefRangeEnd = 99127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003733 RID: 14131
			// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x002BA368 File Offset: 0x002B8568
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7DE RID: 42974 RVA: 0x002BA3A8 File Offset: 0x002B85A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99127, XrefRangeEnd = 99133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003734 RID: 14132
			// (get) Token: 0x0600A7DF RID: 42975 RVA: 0x002BA3DC File Offset: 0x002B85DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7E0 RID: 42976 RVA: 0x0005AAE6 File Offset: 0x00058CE6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003730 RID: 14128
			// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x002BA41C File Offset: 0x002B861C
			// (set) Token: 0x0600A7E2 RID: 42978 RVA: 0x0005AAEF File Offset: 0x00058CEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003731 RID: 14129
			// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x002BA444 File Offset: 0x002B8644
			// (set) Token: 0x0600A7E4 RID: 42980 RVA: 0x0005AB0A File Offset: 0x00058D0A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003732 RID: 14130
			// (get) Token: 0x0600A7E5 RID: 42981 RVA: 0x002BA474 File Offset: 0x002B8674
			// (set) Token: 0x0600A7E6 RID: 42982 RVA: 0x0005AB29 File Offset: 0x00058D29
			public unsafe NightSceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C79 RID: 27769
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C7A RID: 27770
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C7B RID: 27771
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C7C RID: 27772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C7D RID: 27773
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C7E RID: 27774
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C7F RID: 27775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C80 RID: 27776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C81 RID: 27777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007F3 RID: 2035
		[ObfuscatedName("NightScene.NightSceneDirector+<<StartTutorial2>g__Tutorial|90_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600A7E7 RID: 42983 RVA: 0x002BA4A4 File Offset: 0x002B86A4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr, "<<StartTutorial2>g__Tutorial|90_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, "<>8__1");
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671089);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671090);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671091);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671092);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671093);
				NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr, 100671094);
			}

			// Token: 0x0600A7E8 RID: 42984 RVA: 0x002BA598 File Offset: 0x002B8798
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7E9 RID: 42985 RVA: 0x002BA5E0 File Offset: 0x002B87E0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A7EA RID: 42986 RVA: 0x002BA614 File Offset: 0x002B8814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99133, XrefRangeEnd = 99330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003739 RID: 14137
			// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x002BA650 File Offset: 0x002B8850
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7EC RID: 42988 RVA: 0x002BA690 File Offset: 0x002B8890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99330, XrefRangeEnd = 99336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700373A RID: 14138
			// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x002BA6C4 File Offset: 0x002B88C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A7EE RID: 42990 RVA: 0x0005AB48 File Offset: 0x00058D48
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003735 RID: 14133
			// (get) Token: 0x0600A7EF RID: 42991 RVA: 0x002BA704 File Offset: 0x002B8904
			// (set) Token: 0x0600A7F0 RID: 42992 RVA: 0x0005AB51 File Offset: 0x00058D51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003736 RID: 14134
			// (get) Token: 0x0600A7F1 RID: 42993 RVA: 0x002BA72C File Offset: 0x002B892C
			// (set) Token: 0x0600A7F2 RID: 42994 RVA: 0x0005AB6C File Offset: 0x00058D6C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003737 RID: 14135
			// (get) Token: 0x0600A7F3 RID: 42995 RVA: 0x002BA75C File Offset: 0x002B895C
			// (set) Token: 0x0600A7F4 RID: 42996 RVA: 0x0005AB8B File Offset: 0x00058D8B
			public unsafe NightSceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003738 RID: 14136
			// (get) Token: 0x0600A7F5 RID: 42997 RVA: 0x002BA78C File Offset: 0x002B898C
			// (set) Token: 0x0600A7F6 RID: 42998 RVA: 0x0005ABAA File Offset: 0x00058DAA
			public unsafe NightSceneDirector.__c__DisplayClass90_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDirector.__c__DisplayClass90_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NightSceneDirector.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNiVoObMoInVoBoOb1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C82 RID: 27778
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006C83 RID: 27779
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006C84 RID: 27780
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C85 RID: 27781
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006C86 RID: 27782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006C87 RID: 27783
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C88 RID: 27784
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006C89 RID: 27785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006C8A RID: 27786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006C8B RID: 27787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007F4 RID: 2036
		private sealed class MethodInfoStoreGeneric_PlayDialogCoroutine_Private_IEnumerator_String_Func_1_ValueTuple_2_TDialogBox_Action_1_TDialogBox_Func_2_TDialogBox_IEnumerator_Action_0<TDialogBox>
		{
			// Token: 0x04006C8C RID: 27788
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NightSceneDirector.NativeMethodInfoPtr_PlayDialogCoroutine_Private_IEnumerator_String_Func_1_ValueTuple_2_TDialogBox_Action_1_TDialogBox_Func_2_TDialogBox_IEnumerator_Action_0, Il2CppClassPointerStore<NightSceneDirector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDialogBox>.NativeClassPtr))
			}))));
		}
	}
}
