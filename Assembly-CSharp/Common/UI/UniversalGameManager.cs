using System;
using System.Runtime.InteropServices;
using Common.DialogUtility;
using Common.UI.EscapeUtility;
using Common.UI.Filter;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AssetHandleUtility;
using DEYU.SceneComposer;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using GameData.Profile;
using GamePlatform.Core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using PrepNightScene.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x0200035A RID: 858
	public class UniversalGameManager : MonoSingletonPersistant<UniversalGameManager>
	{
		// Token: 0x060064CC RID: 25804 RVA: 0x001EEE98 File Offset: 0x001ED098
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGameManager()
		{
			Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "UniversalGameManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr);
			UniversalGameManager.NativeFieldInfoPtr_TRANSITION_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "TRANSITION_DURATION");
			UniversalGameManager.NativeFieldInfoPtr_s_LoadingIndicatorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_LoadingIndicatorPanel");
			UniversalGameManager.NativeFieldInfoPtr_s_EscMainPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_EscMainPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_NoteBookMainPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_NoteBookMainPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_StorageMainPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_StorageMainPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_DialogPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_DialogPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_EscBindingSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_EscBindingSubPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_FlattenedFilterPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_FlattenedFilterPanel");
			UniversalGameManager.NativeFieldInfoPtr_s_MultipleChoicePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_MultipleChoicePannel");
			UniversalGameManager.NativeFieldInfoPtr_s_IzakayaConfigPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_IzakayaConfigPannel");
			UniversalGameManager.NativeFieldInfoPtr_s_MultipleGetProductsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_MultipleGetProductsPanel");
			UniversalGameManager.NativeFieldInfoPtr_s_GeneralErrorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_GeneralErrorPanel");
			UniversalGameManager.NativeFieldInfoPtr_s_LevelUpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_LevelUpEffect");
			UniversalGameManager.NativeFieldInfoPtr_m_IsCommonPannelLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_IsCommonPannelLoaded");
			UniversalGameManager.NativeFieldInfoPtr_m_HasFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_HasFadeIn");
			UniversalGameManager.NativeFieldInfoPtr_s_Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_Amplitude");
			UniversalGameManager.NativeFieldInfoPtr_s_IsDialogPanelOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_IsDialogPanelOpened");
			UniversalGameManager.NativeFieldInfoPtr_s_IsLoadingIndicatorPanelShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "s_IsLoadingIndicatorPanelShown");
			UniversalGameManager.NativeFieldInfoPtr_m_TutorialSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_TutorialSFX");
			UniversalGameManager.NativeFieldInfoPtr_m_EscapePannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_EscapePannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_NotebookPannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_NotebookPannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_StoragePannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_StoragePannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_DialogPannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DialogPannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_MultipleChoicePannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_MultipleChoicePannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_IzakayaConfigPannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_IzakayaConfigPannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_BindingPannelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_BindingPannelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_FilterPanelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_FilterPanelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_RewindDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_RewindDialogPackage");
			UniversalGameManager.NativeFieldInfoPtr_m_LevelUpEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_LevelUpEffect");
			UniversalGameManager.NativeFieldInfoPtr_m_LoadingIndicatorPanelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_LoadingIndicatorPanelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_MultipleGetProductsPanelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_MultipleGetProductsPanelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_GeneralErrorPanelAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_GeneralErrorPanelAsset");
			UniversalGameManager.NativeFieldInfoPtr_m_DayScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DayScene");
			UniversalGameManager.NativeFieldInfoPtr_m_MainScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_MainScene");
			UniversalGameManager.NativeFieldInfoPtr_m_LoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_LoadScene");
			UniversalGameManager.NativeFieldInfoPtr_m_IzakayaPrepScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_IzakayaPrepScene");
			UniversalGameManager.NativeFieldInfoPtr_m_WorkScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_WorkScene");
			UniversalGameManager.NativeFieldInfoPtr_m_ResultScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_ResultScene");
			UniversalGameManager.NativeFieldInfoPtr_m_StaffScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_StaffScene");
			UniversalGameManager.NativeFieldInfoPtr_m_EmptyScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_EmptyScene");
			UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSelectAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DefaultOnSelectAudio");
			UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSubmitAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DefaultOnSubmitAudio");
			UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnCancelAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DefaultOnCancelAudio");
			UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelOpenAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DefaultOnPanelOpenAudio");
			UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelCloseAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_DefaultOnPanelCloseAudio");
			UniversalGameManager.NativeFieldInfoPtr_m_TransitionModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_TransitionModule");
			UniversalGameManager.NativeFieldInfoPtr_m_ShakeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_ShakeMaterial");
			UniversalGameManager.NativeFieldInfoPtr_m_IsolatedPanelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_IsolatedPanelTransform");
			UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_BufferedPanelPrefabs");
			UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_BufferedPanelPrefabGroups");
			UniversalGameManager.NativeFieldInfoPtr_m_AllScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_AllScenes");
			UniversalGameManager.NativeFieldInfoPtr_m_ShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "m_ShakeCoroutine");
			UniversalGameManager.NativeFieldInfoPtr__PlayerInputMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<PlayerInputMode>k__BackingField");
			UniversalGameManager.NativeFieldInfoPtr__RewindDialogPackage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<RewindDialogPackage>k__BackingField");
			UniversalGameManager.NativeFieldInfoPtr__IsInputEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<IsInputEnabled>k__BackingField");
			UniversalGameManager.NativeFieldInfoPtr__IsSwitchScene_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<IsSwitchScene>k__BackingField");
			UniversalGameManager.NativeFieldInfoPtr_OnWillLoadSceneCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "OnWillLoadSceneCallback");
			UniversalGameManager.NativeFieldInfoPtr_OnPointerPositionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "OnPointerPositionUpdate");
			UniversalGameManager.NativeFieldInfoPtr_OnPlayerInputAvailabilityUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "OnPlayerInputAvailabilityUpdate");
			UniversalGameManager.NativeMethodInfoPtr_get_PlayerInputMode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684404);
			UniversalGameManager.NativeMethodInfoPtr_set_PlayerInputMode_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684405);
			UniversalGameManager.NativeMethodInfoPtr_get_RewindDialogPackage_Public_Static_get_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684406);
			UniversalGameManager.NativeMethodInfoPtr_set_RewindDialogPackage_Private_Static_set_Void_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684407);
			UniversalGameManager.NativeMethodInfoPtr_get_IsInputEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684408);
			UniversalGameManager.NativeMethodInfoPtr_set_IsInputEnabled_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684409);
			UniversalGameManager.NativeMethodInfoPtr_get_PlatformMemoryMode_Public_Static_get_MemoryMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684410);
			UniversalGameManager.NativeMethodInfoPtr_get_PlatformAssetLifetime_Public_Static_get_AssetLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684411);
			UniversalGameManager.NativeMethodInfoPtr_get_PlatformPanelLifetime_Public_Static_get_AdpPanelLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684412);
			UniversalGameManager.NativeMethodInfoPtr_get_LevelUpEffect_Public_Static_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684413);
			UniversalGameManager.NativeMethodInfoPtr_get_IsSwitchScene_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684414);
			UniversalGameManager.NativeMethodInfoPtr_set_IsSwitchScene_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684415);
			UniversalGameManager.NativeMethodInfoPtr_add_OnWillLoadSceneCallback_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684416);
			UniversalGameManager.NativeMethodInfoPtr_remove_OnWillLoadSceneCallback_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684417);
			UniversalGameManager.NativeMethodInfoPtr_add_OnPointerPositionUpdate_Public_Static_add_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684418);
			UniversalGameManager.NativeMethodInfoPtr_remove_OnPointerPositionUpdate_Public_Static_rem_Void_Action_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684419);
			UniversalGameManager.NativeMethodInfoPtr_add_OnPlayerInputAvailabilityUpdate_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684420);
			UniversalGameManager.NativeMethodInfoPtr_remove_OnPlayerInputAvailabilityUpdate_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684421);
			UniversalGameManager.NativeMethodInfoPtr_SetAndPushCurrentScenePanelRoot_Public_Static_Void_MonoBehaviour_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684422);
			UniversalGameManager.NativeMethodInfoPtr_GetEscapePanelParent_Public_Static_EscMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684423);
			UniversalGameManager.NativeMethodInfoPtr_GetNotebookPanelParent_Public_Static_NoteBookMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684424);
			UniversalGameManager.NativeMethodInfoPtr_GetStoragePanelParent_Public_Static_StorageMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684425);
			UniversalGameManager.NativeMethodInfoPtr_GetIzakayaConfigPanelParent_Private_IzakayaConfigPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684426);
			UniversalGameManager.NativeMethodInfoPtr_GetMultipleChoicePanelParent_Private_MultipleChoicePannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684427);
			UniversalGameManager.NativeMethodInfoPtr_GetMultipleGetProductsPanelParent_Private_MultipleGetProductsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684428);
			UniversalGameManager.NativeMethodInfoPtr_OpenNotebookPanelStandalone_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684429);
			UniversalGameManager.NativeMethodInfoPtr_OpenNotebookPanelStandaloneAsync_Private_Static_UniTask_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684430);
			UniversalGameManager.NativeMethodInfoPtr_OpenStoragePanelStandalone_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684431);
			UniversalGameManager.NativeMethodInfoPtr_OpenStoragePanelStandaloneAsync_Private_Static_UniTask_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684432);
			UniversalGameManager.NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_T_T_Action_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684433);
			UniversalGameManager.NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684434);
			UniversalGameManager.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684435);
			UniversalGameManager.NativeMethodInfoPtr_StopCameraShake_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684436);
			UniversalGameManager.NativeMethodInfoPtr_UpdatePlayerInputAvailability_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684437);
			UniversalGameManager.NativeMethodInfoPtr_ReMigrateCommonPanels_Public_Static_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684438);
			UniversalGameManager.NativeMethodInfoPtr_PreLoadCommonPanelParent_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684439);
			UniversalGameManager.NativeMethodInfoPtr_PlayLevelUpEffect_Public_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684440);
			UniversalGameManager.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684441);
			UniversalGameManager.NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684442);
			UniversalGameManager.NativeMethodInfoPtr_CallOnPointerPositionUpdate_Private_Static_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684443);
			UniversalGameManager.NativeMethodInfoPtr_GetScene_Private_Static_AssetReference_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684444);
			UniversalGameManager.NativeMethodInfoPtr_IsMainScene_Public_Static_Boolean_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684445);
			UniversalGameManager.NativeMethodInfoPtr_GetMainScene_Public_Static_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684446);
			UniversalGameManager.NativeMethodInfoPtr_PlayTutorialOpenAudio_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684447);
			UniversalGameManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Scene_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684448);
			UniversalGameManager.NativeMethodInfoPtr_WaitUntilAllPannelClosed_Private_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684449);
			UniversalGameManager.NativeMethodInfoPtr_FadeInAsync_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684450);
			UniversalGameManager.NativeMethodInfoPtr_FadeOutAsync_Public_Static_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684451);
			UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenuAsync_Public_Static_UniTask_IPostExtraChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684452);
			UniversalGameManager.NativeMethodInfoPtr_FadeIn_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684453);
			UniversalGameManager.NativeMethodInfoPtr_FadeOut_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684454);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684455);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684456);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCode_Public_Static_Void_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684457);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCodeAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684458);
			UniversalGameManager.NativeMethodInfoPtr_OpenManualDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Action_Action_1_Action_Action_Boolean_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684459);
			UniversalGameManager.NativeMethodInfoPtr_OpenGeneralErrorPanelAsync_Public_Static_UniTask_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684460);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684461);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684462);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684463);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684464);
			UniversalGameManager.NativeMethodInfoPtr_OpenBindingSubPannel_Public_Static_Void_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684465);
			UniversalGameManager.NativeMethodInfoPtr_OpenBindingSubPannelAsyncInternal_Private_Static_UniTaskVoid_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684466);
			UniversalGameManager.NativeMethodInfoPtr_OpenFilterPanel_Public_Static_UniTask_IReadOnlyList_1_FilterConfigFactory_1_T_List_1_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684467);
			UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenu_Public_Static_Void_Action_IPostExtraChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684468);
			UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenuAsyncInternal_Private_Static_UniTask_Action_IPostExtraChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684469);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleGetProductsPanel_Public_Static_Void_MultipleGetProductsOpenContext_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684470);
			UniversalGameManager.NativeMethodInfoPtr_OpenMultipleGetProductsPanelAsync_Public_Static_UniTask_MultipleGetProductsOpenContext_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684471);
			UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_Func_1_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684472);
			UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_Func_1_UniTask_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684473);
			UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684474);
			UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_UniTask_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684475);
			UniversalGameManager.NativeMethodInfoPtr_ShowLoadingIndicator_Public_Static_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684476);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684477);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCodeCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684478);
			UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuAsync_Public_Static_UniTask_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684479);
			UniversalGameManager.NativeMethodInfoPtr_OpenInputBlockerMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684480);
			UniversalGameManager.NativeMethodInfoPtr_CloseInputBlockerMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684481);
			UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684482);
			UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684483);
			UniversalGameManager.NativeMethodInfoPtr_SetCameraShakeC_Public_Static_IEnumerator_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684484);
			UniversalGameManager.NativeMethodInfoPtr_SetCameraShakeCorotine_Public_Static_IEnumerator_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684485);
			UniversalGameManager.NativeMethodInfoPtr_LoadAndPreparePanelScoped_Public_Static_UniTask_1_T_AssetReference_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684486);
			UniversalGameManager.NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684487);
			UniversalGameManager.NativeMethodInfoPtr_PrepareOrGetTempPanelInstanceImpl_Private_T_T_AdpPanelLifetime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684488);
			UniversalGameManager.NativeMethodInfoPtr_LoadPanelScoped_Public_Static_UniTask_1_IGameObjectAssetHandle_1_T_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684489);
			UniversalGameManager.NativeMethodInfoPtr_TryCleanThenAddBufferedPanelPrefab_Private_Void_UIPanelBaseImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684490);
			UniversalGameManager.NativeMethodInfoPtr_ClearAllBufferedPanelOfGroup_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684491);
			UniversalGameManager.NativeMethodInfoPtr_WaitDelayFrame_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684492);
			UniversalGameManager.NativeMethodInfoPtr_WaitDelay_Public_Static_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684493);
			UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684494);
			UniversalGameManager.NativeMethodInfoPtr_RunUnderIsolatedParent_Public_Static_IsolatedPanelTransformHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684495);
			UniversalGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684496);
			UniversalGameManager.NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684498);
			UniversalGameManager.NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, 100684499);
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x001EFAD0 File Offset: 0x001EDCD0
		// (set) Token: 0x060064CE RID: 25806 RVA: 0x001EFAFC File Offset: 0x001EDCFC
		public unsafe static string PlayerInputMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260652, XrefRangeEnd = 260656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_PlayerInputMode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260656, XrefRangeEnd = 260662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_set_PlayerInputMode_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x001EFB34 File Offset: 0x001EDD34
		// (set) Token: 0x060064D0 RID: 25808 RVA: 0x001EFB68 File Offset: 0x001EDD68
		public unsafe static DialogPackage RewindDialogPackage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260662, XrefRangeEnd = 260666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_RewindDialogPackage_Public_Static_get_DialogPackage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260666, XrefRangeEnd = 260682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_set_RewindDialogPackage_Private_Static_set_Void_DialogPackage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x001EFBA0 File Offset: 0x001EDDA0
		// (set) Token: 0x060064D2 RID: 25810 RVA: 0x001EFBD0 File Offset: 0x001EDDD0
		public unsafe static bool IsInputEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260682, XrefRangeEnd = 260686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_IsInputEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260686, XrefRangeEnd = 260690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_set_IsInputEnabled_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x001EFC04 File Offset: 0x001EDE04
		public unsafe static MemoryMode PlatformMemoryMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260693, RefRangeEnd = 260696, XrefRangeStart = 260690, XrefRangeEnd = 260693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_PlatformMemoryMode_Public_Static_get_MemoryMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x060064D4 RID: 25812 RVA: 0x001EFC34 File Offset: 0x001EDE34
		public unsafe static AssetLifetime PlatformAssetLifetime
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 260701, RefRangeEnd = 260716, XrefRangeStart = 260696, XrefRangeEnd = 260701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_PlatformAssetLifetime_Public_Static_get_AssetLifetime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x001EFC64 File Offset: 0x001EDE64
		public unsafe static AdpPanelLifetime PlatformPanelLifetime
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260721, RefRangeEnd = 260726, XrefRangeStart = 260716, XrefRangeEnd = 260721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_PlatformPanelLifetime_Public_Static_get_AdpPanelLifetime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x001EFC94 File Offset: 0x001EDE94
		public unsafe static GameObject LevelUpEffect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260726, XrefRangeEnd = 260737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_LevelUpEffect_Public_Static_get_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x001EFCC8 File Offset: 0x001EDEC8
		// (set) Token: 0x060064D8 RID: 25816 RVA: 0x001EFCF8 File Offset: 0x001EDEF8
		public unsafe static bool IsSwitchScene
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260737, XrefRangeEnd = 260741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_get_IsSwitchScene_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260741, XrefRangeEnd = 260745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_set_IsSwitchScene_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x001EFD2C File Offset: 0x001EDF2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 260756, RefRangeEnd = 260762, XrefRangeStart = 260745, XrefRangeEnd = 260756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnWillLoadSceneCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_add_OnWillLoadSceneCallback_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x001EFD64 File Offset: 0x001EDF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260762, XrefRangeEnd = 260773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnWillLoadSceneCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_remove_OnWillLoadSceneCallback_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x001EFD9C File Offset: 0x001EDF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260773, XrefRangeEnd = 260786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnPointerPositionUpdate(Action<Vector2> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_add_OnPointerPositionUpdate_Public_Static_add_Void_Action_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x001EFDD4 File Offset: 0x001EDFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260786, XrefRangeEnd = 260799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnPointerPositionUpdate(Action<Vector2> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_remove_OnPointerPositionUpdate_Public_Static_rem_Void_Action_1_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x001EFE0C File Offset: 0x001EE00C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 260812, RefRangeEnd = 260818, XrefRangeStart = 260799, XrefRangeEnd = 260812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnPlayerInputAvailabilityUpdate(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_add_OnPlayerInputAvailabilityUpdate_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x001EFE44 File Offset: 0x001EE044
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 260831, RefRangeEnd = 260837, XrefRangeStart = 260818, XrefRangeEnd = 260831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnPlayerInputAvailabilityUpdate(Action<bool> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_remove_OnPlayerInputAvailabilityUpdate_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x001EFE7C File Offset: 0x001EE07C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 260841, RefRangeEnd = 260845, XrefRangeStart = 260837, XrefRangeEnd = 260841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAndPushCurrentScenePanelRoot(MonoBehaviour owner, RectTransform panelRoot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panelRoot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetAndPushCurrentScenePanelRoot_Public_Static_Void_MonoBehaviour_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x001EFEC4 File Offset: 0x001EE0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260845, XrefRangeEnd = 260849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EscMainPannel GetEscapePanelParent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetEscapePanelParent_Public_Static_EscMainPannel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EscMainPannel>(intPtr3) : null;
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x001EFEF8 File Offset: 0x001EE0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260849, XrefRangeEnd = 260853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NoteBookMainPannel GetNotebookPanelParent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetNotebookPanelParent_Public_Static_NoteBookMainPannel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteBookMainPannel>(intPtr3) : null;
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x001EFF2C File Offset: 0x001EE12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260853, XrefRangeEnd = 260857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorageMainPannel GetStoragePanelParent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetStoragePanelParent_Public_Static_StorageMainPannel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageMainPannel>(intPtr3) : null;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x001EFF60 File Offset: 0x001EE160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260857, XrefRangeEnd = 260861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaConfigPannel GetIzakayaConfigPanelParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetIzakayaConfigPanelParent_Private_IzakayaConfigPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr3) : null;
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x001EFFA0 File Offset: 0x001EE1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260861, XrefRangeEnd = 260865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleChoicePannel GetMultipleChoicePanelParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetMultipleChoicePanelParent_Private_MultipleChoicePannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel>(intPtr3) : null;
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x001EFFE0 File Offset: 0x001EE1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260865, XrefRangeEnd = 260869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleGetProductsPanel GetMultipleGetProductsPanelParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetMultipleGetProductsPanelParent_Private_MultipleGetProductsPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleGetProductsPanel>(intPtr3) : null;
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x001F0020 File Offset: 0x001EE220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260885, RefRangeEnd = 260887, XrefRangeStart = 260869, XrefRangeEnd = 260885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenNotebookPanelStandalone(Action onPanelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenNotebookPanelStandalone_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x001F0058 File Offset: 0x001EE258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260887, XrefRangeEnd = 260893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenNotebookPanelStandaloneAsync(Action onPanelCloseCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenNotebookPanelStandaloneAsync_Private_Static_UniTask_Action_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x001F0094 File Offset: 0x001EE294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260909, RefRangeEnd = 260911, XrefRangeStart = 260893, XrefRangeEnd = 260909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenStoragePanelStandalone(Action onPanelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenStoragePanelStandalone_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x001F00CC File Offset: 0x001EE2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260911, XrefRangeEnd = 260917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenStoragePanelStandaloneAsync(Action onPanelCloseCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPanelCloseCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenStoragePanelStandaloneAsync_Private_Static_UniTask_Action_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x001F0108 File Offset: 0x001EE308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260917, XrefRangeEnd = 260937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T PrepareBufferedPanelWithRecord<T>(T panelParent, Action<T> preInitializeCallback = null, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(preInitializeCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_PrepareBufferedPanelWithRecord_Public_T_T_Action_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x001F01AC File Offset: 0x001EE3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260937, XrefRangeEnd = 260957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T PreBufferPanelWithRecord<T>(T panelParent, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelParent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelParent;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_PreBufferPanelWithRecord_Public_T_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x001F0240 File Offset: 0x001EE440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260969, RefRangeEnd = 260970, XrefRangeStart = 260957, XrefRangeEnd = 260969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x001F0268 File Offset: 0x001EE468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260982, RefRangeEnd = 260984, XrefRangeStart = 260970, XrefRangeEnd = 260982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopCameraShake()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_StopCameraShake_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x001F0290 File Offset: 0x001EE490
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 261008, RefRangeEnd = 261038, XrefRangeStart = 260984, XrefRangeEnd = 261008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdatePlayerInputAvailability(bool targetInputAvailability)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetInputAvailability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_UpdatePlayerInputAvailability_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x001F02C4 File Offset: 0x001EE4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261072, RefRangeEnd = 261075, XrefRangeStart = 261038, XrefRangeEnd = 261072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReMigrateCommonPanels(Transform panelRoot, bool escapePanelOnly = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panelRoot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escapePanelOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_ReMigrateCommonPanels_Public_Static_Void_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x001F0308 File Offset: 0x001EE508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261081, RefRangeEnd = 261082, XrefRangeStart = 261075, XrefRangeEnd = 261081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask PreLoadCommonPanelParent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_PreLoadCommonPanelParent_Public_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x001F0334 File Offset: 0x001EE534
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261109, RefRangeEnd = 261112, XrefRangeStart = 261082, XrefRangeEnd = 261109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject PlayLevelUpEffect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_PlayLevelUpEffect_Public_Static_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x001F0368 File Offset: 0x001EE568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261112, XrefRangeEnd = 261309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGameManager.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x001F03A4 File Offset: 0x001EE5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261309, XrefRangeEnd = 261375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdpUIPanelManager_OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x001F03E4 File Offset: 0x001EE5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261375, XrefRangeEnd = 261382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallOnPointerPositionUpdate(InputAction.CallbackContext callbackContext)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_CallOnPointerPositionUpdate_Private_Static_Void_CallbackContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x001F0420 File Offset: 0x001EE620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261382, XrefRangeEnd = 261385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetReference GetScene(Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetScene_Private_Static_AssetReference_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x001F0460 File Offset: 0x001EE660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261385, XrefRangeEnd = 261388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMainScene(AssetReference sceneReference)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_IsMainScene_Public_Static_Boolean_AssetReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x001F04A4 File Offset: 0x001EE6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261391, RefRangeEnd = 261392, XrefRangeStart = 261388, XrefRangeEnd = 261391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AssetReference GetMainScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_GetMainScene_Public_Static_AssetReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x001F04D8 File Offset: 0x001EE6D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261400, RefRangeEnd = 261402, XrefRangeStart = 261392, XrefRangeEnd = 261400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayTutorialOpenAudio()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_PlayTutorialOpenAudio_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x001F0500 File Offset: 0x001EE700
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 261467, RefRangeEnd = 261497, XrefRangeStart = 261402, XrefRangeEnd = 261467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(Scene scene, Action onFadeFinishCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFadeFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Scene_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x001F0544 File Offset: 0x001EE744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261497, XrefRangeEnd = 261522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitUntilAllPannelClosed(Action onFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_WaitUntilAllPannelClosed_Private_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x001F057C File Offset: 0x001EE77C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 261529, RefRangeEnd = 261538, XrefRangeStart = 261522, XrefRangeEnd = 261529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask FadeInAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_FadeInAsync_Public_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x001F05A8 File Offset: 0x001EE7A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261545, RefRangeEnd = 261547, XrefRangeStart = 261538, XrefRangeEnd = 261545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask FadeOutAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_FadeOutAsync_Public_Static_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x001F05D4 File Offset: 0x001EE7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261559, RefRangeEnd = 261560, XrefRangeStart = 261547, XrefRangeEnd = 261559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenIzakayaConfigMenuAsync(IPostExtraChecker iPostExtraChecker = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(iPostExtraChecker);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenuAsync_Public_Static_UniTask_IPostExtraChecker_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x001F0610 File Offset: 0x001EE810
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 261597, RefRangeEnd = 261623, XrefRangeStart = 261560, XrefRangeEnd = 261597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeIn(Action onFinishCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_FadeIn_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x001F0648 File Offset: 0x001EE848
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 261660, RefRangeEnd = 261699, XrefRangeStart = 261623, XrefRangeEnd = 261660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FadeOut(Action onFinishCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_FadeOut_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x001F0680 File Offset: 0x001EE880
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 261710, RefRangeEnd = 261783, XrefRangeStart = 261699, XrefRangeEnd = 261710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenDialogMenu(DialogPackage dialogPackage, Action onFinishCallback, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x001F06E8 File Offset: 0x001EE8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261783, XrefRangeEnd = 261790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid OpenDialogMenuAsyncInternal(DialogPackage dialogPackage, Action onFinishCallback, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x001F075C File Offset: 0x001EE95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261790, XrefRangeEnd = 261801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenDialogMenuWithExitCode(DialogPackage dialogPackage, Action<int> onFinishCallback, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCode_Public_Static_Void_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x001F07C4 File Offset: 0x001EE9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261801, XrefRangeEnd = 261808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid OpenDialogMenuWithExitCodeAsyncInternal(DialogPackage dialogPackage, Action<int> onFinishCallback, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCodeAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x001F0838 File Offset: 0x001EEA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261860, RefRangeEnd = 261861, XrefRangeStart = 261808, XrefRangeEnd = 261860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenManualDialogMenu(DialogPackage dialogPackage, Action onCanContinueCallback, Action<Action> canPlayFirstLineCallback, Action<Action> canExitCallback, Action loadFinishCallback, bool shouldHaveBlackBackground, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCanContinueCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canPlayFirstLineCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canExitCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadFinishCallback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldHaveBlackBackground;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenManualDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Action_Action_1_Action_Action_Boolean_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x001F08D4 File Offset: 0x001EEAD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261880, RefRangeEnd = 261881, XrefRangeStart = 261861, XrefRangeEnd = 261880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenGeneralErrorPanelAsync(string title, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenGeneralErrorPanelAsync_Public_Static_UniTask_String_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x001F0924 File Offset: 0x001EEB24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 261885, RefRangeEnd = 261892, XrefRangeStart = 261881, XrefRangeEnd = 261885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMultipleChoiceMenu<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<Il2CppArrayBase<T>> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x001F0980 File Offset: 0x001EEB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261892, XrefRangeEnd = 261896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid OpenMultipleChoiceMenuAsyncInternal<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<Il2CppArrayBase<T>> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x001F09E8 File Offset: 0x001EEBE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261900, RefRangeEnd = 261901, XrefRangeStart = 261896, XrefRangeEnd = 261900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMultipleChoiceMenu<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<bool, Il2CppArrayBase<T>> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x001F0A44 File Offset: 0x001EEC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261901, XrefRangeEnd = 261905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid OpenMultipleChoiceMenuAsyncInternal<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<bool, Il2CppArrayBase<T>> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x001F0AAC File Offset: 0x001EECAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261918, RefRangeEnd = 261919, XrefRangeStart = 261905, XrefRangeEnd = 261918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenBindingSubPannel(EscBindingPannel.InputBindingData actionGroupToRebind, Il2CppReferenceArray<EscBindingPannel.StringArray> groups, Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas, Action onPannelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(actionGroupToRebind));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBindingDatas);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenBindingSubPannel_Public_Static_Void_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x001F0B30 File Offset: 0x001EED30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261919, XrefRangeEnd = 261928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid OpenBindingSubPannelAsyncInternal(EscBindingPannel.InputBindingData actionGroupToRebind, Il2CppReferenceArray<EscBindingPannel.StringArray> groups, Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas, Action onPannelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(actionGroupToRebind));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBindingDatas);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenBindingSubPannelAsyncInternal_Private_Static_UniTaskVoid_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x001F0BC0 File Offset: 0x001EEDC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 261933, RefRangeEnd = 261944, XrefRangeStart = 261928, XrefRangeEnd = 261933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenFilterPanel<T>(IReadOnlyList<FilterConfigFactory<T>> filterConfigFactories, List<IFilterConfig> historyFilterConfigList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterConfigFactories);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(historyFilterConfigList);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_OpenFilterPanel_Public_Static_UniTask_IReadOnlyList_1_FilterConfigFactory_1_T_List_1_IFilterConfig_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x001F0C10 File Offset: 0x001EEE10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261981, RefRangeEnd = 261984, XrefRangeStart = 261944, XrefRangeEnd = 261981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenIzakayaConfigMenu(Action onPannelCloseCallback = null, IPostExtraChecker iPostExtraChecker = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iPostExtraChecker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenu_Public_Static_Void_Action_IPostExtraChecker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x001F0C58 File Offset: 0x001EEE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261984, XrefRangeEnd = 262011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenIzakayaConfigMenuAsyncInternal(Action onPannelCloseCallback = null, IPostExtraChecker iPostExtraChecker = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iPostExtraChecker);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenIzakayaConfigMenuAsyncInternal_Private_Static_UniTask_Action_IPostExtraChecker_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x001F0CA8 File Offset: 0x001EEEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262022, RefRangeEnd = 262024, XrefRangeStart = 262011, XrefRangeEnd = 262022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMultipleGetProductsPanel(MultipleGetProductsPanel.MultipleGetProductsOpenContext multipleGetProductsOpenContext, Action onPannelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(multipleGetProductsOpenContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleGetProductsPanel_Public_Static_Void_MultipleGetProductsOpenContext_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x001F0CF8 File Offset: 0x001EEEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262042, RefRangeEnd = 262044, XrefRangeStart = 262024, XrefRangeEnd = 262042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenMultipleGetProductsPanelAsync(MultipleGetProductsPanel.MultipleGetProductsOpenContext multipleGetProductsOpenContext, Action onPannelCloseCallback = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(multipleGetProductsOpenContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPannelCloseCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleGetProductsPanelAsync_Public_Static_UniTask_MultipleGetProductsOpenContext_Action_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x001F0D4C File Offset: 0x001EEF4C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 262050, RefRangeEnd = 262058, XrefRangeStart = 262044, XrefRangeEnd = 262050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask RunWithLoadingIndicatorPanel(Func<UniTask> taskToRun)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskToRun);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_Func_1_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x001F0D88 File Offset: 0x001EEF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262062, RefRangeEnd = 262063, XrefRangeStart = 262058, XrefRangeEnd = 262062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<T> RunWithLoadingIndicatorPanel<T>(Func<UniTask<T>> taskToRun)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskToRun);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_Func_1_UniTask_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<T>(pointer);
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x001F0DC4 File Offset: 0x001EEFC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262083, RefRangeEnd = 262085, XrefRangeStart = 262063, XrefRangeEnd = 262083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask RunWithLoadingIndicatorPanel(UniTask taskToRun)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskToRun));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_UniTask_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x001F0E08 File Offset: 0x001EF008
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262093, RefRangeEnd = 262098, XrefRangeStart = 262085, XrefRangeEnd = 262093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<T> RunWithLoadingIndicatorPanel<T>(UniTask<T> taskToRun)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskToRun));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_UniTask_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<T>(pointer);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x001F0E4C File Offset: 0x001EF04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262120, RefRangeEnd = 262121, XrefRangeStart = 262098, XrefRangeEnd = 262120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable ShowLoadingIndicator()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_ShowLoadingIndicator_Public_Static_IDisposable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x001F0E80 File Offset: 0x001EF080
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 262127, RefRangeEnd = 262133, XrefRangeStart = 262121, XrefRangeEnd = 262127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator OpenDialogMenuCoroutine(DialogPackage dialogPackage, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x001F0EE4 File Offset: 0x001EF0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262133, XrefRangeEnd = 262140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator OpenDialogMenuWithExitCodeCoroutine(DialogPackage dialogPackage, Action<int> getExitCodeCallback, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getExitCodeCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuWithExitCodeCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x001F0F5C File Offset: 0x001EF15C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 262153, RefRangeEnd = 262164, XrefRangeStart = 262140, XrefRangeEnd = 262153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenDialogMenuAsync(DialogPackage dialogPackage, Action<Dictionary<int, string>> overrideReplaceTextCallback = null, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideReplaceTextCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousPanelVisualMode;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenDialogMenuAsync_Public_Static_UniTask_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x001F0FB8 File Offset: 0x001EF1B8
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 262168, RefRangeEnd = 262206, XrefRangeStart = 262164, XrefRangeEnd = 262168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenInputBlockerMenu()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_OpenInputBlockerMenu_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651A RID: 25882 RVA: 0x001F0FE0 File Offset: 0x001EF1E0
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 262210, RefRangeEnd = 262255, XrefRangeStart = 262206, XrefRangeEnd = 262210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseInputBlockerMenu()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_CloseInputBlockerMenu_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651B RID: 25883 RVA: 0x001F1008 File Offset: 0x001EF208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 262277, RefRangeEnd = 262281, XrefRangeStart = 262255, XrefRangeEnd = 262277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraShake(float amplitude, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x001F1048 File Offset: 0x001EF248
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262303, RefRangeEnd = 262305, XrefRangeStart = 262281, XrefRangeEnd = 262303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraShake(float amplitude, float duration, float fadeTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651D RID: 25885 RVA: 0x001F1098 File Offset: 0x001EF298
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262309, RefRangeEnd = 262312, XrefRangeStart = 262305, XrefRangeEnd = 262309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator SetCameraShakeC(float amplitude, float duration, float fadeTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetCameraShakeC_Public_Static_IEnumerator_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x001F10F4 File Offset: 0x001EF2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262312, XrefRangeEnd = 262316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator SetCameraShakeCorotine(float amplitude, float duration, float fadeTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetCameraShakeCorotine_Public_Static_IEnumerator_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x001F1150 File Offset: 0x001EF350
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 262320, RefRangeEnd = 262339, XrefRangeStart = 262316, XrefRangeEnd = 262320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<T> LoadAndPreparePanelScoped<T>(AssetReference assetReference, bool forceTempPanel = false) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetReference);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceTempPanel;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_LoadAndPreparePanelScoped_Public_Static_UniTask_1_T_AssetReference_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<T>(pointer);
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x001F119C File Offset: 0x001EF39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262339, XrefRangeEnd = 262343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T PrepareOrGetTempPanelInstance<T>(T panelPrefab, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelPrefab;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelPrefab;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_PrepareOrGetTempPanelInstance_Public_T_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x001F1230 File Offset: 0x001EF430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262343, XrefRangeEnd = 262363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T PrepareOrGetTempPanelInstanceImpl<T>(T panelPrefab, AdpPanelLifetime lifetime, string bufferPanelLabel = null) where T : UIPanelBaseImpl
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = panelPrefab;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref panelPrefab;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_PrepareOrGetTempPanelInstanceImpl_Private_T_T_AdpPanelLifetime_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x001F12D0 File Offset: 0x001EF4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262367, RefRangeEnd = 262369, XrefRangeStart = 262363, XrefRangeEnd = 262367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<IGameObjectAssetHandle<T>> LoadPanelScoped<T>(AssetReference assetReference) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetReference);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_LoadPanelScoped_Public_Static_UniTask_1_IGameObjectAssetHandle_1_T_AssetReference_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IGameObjectAssetHandle<T>>(pointer);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x001F130C File Offset: 0x001EF50C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262391, RefRangeEnd = 262394, XrefRangeStart = 262369, XrefRangeEnd = 262391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCleanThenAddBufferedPanelPrefab(UIPanelBaseImpl panelPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panelPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_TryCleanThenAddBufferedPanelPrefab_Private_Void_UIPanelBaseImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x001F1350 File Offset: 0x001EF550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262451, RefRangeEnd = 262453, XrefRangeStart = 262394, XrefRangeEnd = 262451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllBufferedPanelOfGroup(string bufferPanelLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bufferPanelLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_ClearAllBufferedPanelOfGroup_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x001F1394 File Offset: 0x001EF594
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262471, RefRangeEnd = 262472, XrefRangeStart = 262453, XrefRangeEnd = 262471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitDelayFrame(Action onFinishCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_WaitDelayFrame_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x001F13CC File Offset: 0x001EF5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262472, XrefRangeEnd = 262490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitDelay(float delaySecond, Action onFinishCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delaySecond;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_WaitDelay_Public_Static_Void_Single_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x001F1410 File Offset: 0x001EF610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262499, RefRangeEnd = 262500, XrefRangeStart = 262490, XrefRangeEnd = 262499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraShake(float amplitude)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x001F1444 File Offset: 0x001EF644
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 262509, RefRangeEnd = 262515, XrefRangeStart = 262500, XrefRangeEnd = 262509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniversalGameManager.IsolatedPanelTransformHandle RunUnderIsolatedParent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr_RunUnderIsolatedParent_Public_Static_IsolatedPanelTransformHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x001F1474 File Offset: 0x001EF674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262515, XrefRangeEnd = 262533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGameManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x001F14B0 File Offset: 0x001EF6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262536, RefRangeEnd = 262538, XrefRangeStart = 262533, XrefRangeEnd = 262536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<IAssetHandle<T>> Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>(Func<UniversalGameManager, AssetReference> getAssetReferenceCallback) where T : UnityEngine.Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetReferenceCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<T>>(pointer);
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x001F14EC File Offset: 0x001EF6EC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 262541, RefRangeEnd = 262552, XrefRangeStart = 262538, XrefRangeEnd = 262541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<IGameObjectAssetHandle<T>> Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>(Func<UniversalGameManager, AssetReference> getAssetReferenceCallback) where T : UIPanelBaseImpl
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetReferenceCallback);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.MethodInfoStoreGeneric_Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>.Pointer, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IGameObjectAssetHandle<T>>(pointer);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0003688B File Offset: 0x00034A8B
		public UniversalGameManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x001F1528 File Offset: 0x001EF728
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x00036894 File Offset: 0x00034A94
		public unsafe static float TRANSITION_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_TRANSITION_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_TRANSITION_DURATION, (void*)(&value));
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600652F RID: 25903 RVA: 0x001F1544 File Offset: 0x001EF744
		// (set) Token: 0x06006530 RID: 25904 RVA: 0x000368A2 File Offset: 0x00034AA2
		public unsafe static AdpBuiltinInputBlockerPanel s_LoadingIndicatorPanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_LoadingIndicatorPanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpBuiltinInputBlockerPanel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_LoadingIndicatorPanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x001F156C File Offset: 0x001EF76C
		// (set) Token: 0x06006532 RID: 25906 RVA: 0x000368B4 File Offset: 0x00034AB4
		public unsafe static EscMainPannel s_EscMainPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_EscMainPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscMainPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_EscMainPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x001F1594 File Offset: 0x001EF794
		// (set) Token: 0x06006534 RID: 25908 RVA: 0x000368C6 File Offset: 0x00034AC6
		public unsafe static NoteBookMainPannel s_NoteBookMainPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_NoteBookMainPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMainPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_NoteBookMainPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06006535 RID: 25909 RVA: 0x001F15BC File Offset: 0x001EF7BC
		// (set) Token: 0x06006536 RID: 25910 RVA: 0x000368D8 File Offset: 0x00034AD8
		public unsafe static StorageMainPannel s_StorageMainPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_StorageMainPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageMainPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_StorageMainPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x001F15E4 File Offset: 0x001EF7E4
		// (set) Token: 0x06006538 RID: 25912 RVA: 0x000368EA File Offset: 0x00034AEA
		public unsafe static DialogPannel s_DialogPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_DialogPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_DialogPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x001F160C File Offset: 0x001EF80C
		// (set) Token: 0x0600653A RID: 25914 RVA: 0x000368FC File Offset: 0x00034AFC
		public unsafe static EscBindingSubPannel s_EscBindingSubPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_EscBindingSubPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingSubPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_EscBindingSubPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600653B RID: 25915 RVA: 0x001F1634 File Offset: 0x001EF834
		// (set) Token: 0x0600653C RID: 25916 RVA: 0x0003690E File Offset: 0x00034B0E
		public unsafe static FlattenedFilterPanel s_FlattenedFilterPanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_FlattenedFilterPanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_FlattenedFilterPanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x001F165C File Offset: 0x001EF85C
		// (set) Token: 0x0600653E RID: 25918 RVA: 0x00036920 File Offset: 0x00034B20
		public unsafe static MultipleChoicePannel s_MultipleChoicePannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_MultipleChoicePannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_MultipleChoicePannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x001F1684 File Offset: 0x001EF884
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x00036932 File Offset: 0x00034B32
		public unsafe static IzakayaConfigPannel s_IzakayaConfigPannel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_IzakayaConfigPannel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_IzakayaConfigPannel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x001F16AC File Offset: 0x001EF8AC
		// (set) Token: 0x06006542 RID: 25922 RVA: 0x00036944 File Offset: 0x00034B44
		public unsafe static MultipleGetProductsPanel s_MultipleGetProductsPanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_MultipleGetProductsPanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleGetProductsPanel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_MultipleGetProductsPanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x001F16D4 File Offset: 0x001EF8D4
		// (set) Token: 0x06006544 RID: 25924 RVA: 0x00036956 File Offset: 0x00034B56
		public unsafe static GenericErrorPanel s_GeneralErrorPanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_GeneralErrorPanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericErrorPanel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_GeneralErrorPanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x001F16FC File Offset: 0x001EF8FC
		// (set) Token: 0x06006546 RID: 25926 RVA: 0x00036968 File Offset: 0x00034B68
		public unsafe static GameObject s_LevelUpEffect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_LevelUpEffect, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_LevelUpEffect, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x001F1724 File Offset: 0x001EF924
		// (set) Token: 0x06006548 RID: 25928 RVA: 0x0003697A File Offset: 0x00034B7A
		public unsafe static bool m_IsCommonPannelLoaded
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_m_IsCommonPannelLoaded, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_m_IsCommonPannelLoaded, (void*)(&value));
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x001F1740 File Offset: 0x001EF940
		// (set) Token: 0x0600654A RID: 25930 RVA: 0x00036988 File Offset: 0x00034B88
		public unsafe static Nullable<bool> m_HasFadeIn
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_m_HasFadeIn, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_m_HasFadeIn, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x001F177C File Offset: 0x001EF97C
		// (set) Token: 0x0600654C RID: 25932 RVA: 0x0003699F File Offset: 0x00034B9F
		public unsafe static int s_Amplitude
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_Amplitude, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_Amplitude, (void*)(&value));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x001F1798 File Offset: 0x001EF998
		// (set) Token: 0x0600654E RID: 25934 RVA: 0x000369AD File Offset: 0x00034BAD
		public unsafe static bool s_IsDialogPanelOpened
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_IsDialogPanelOpened, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_IsDialogPanelOpened, (void*)(&value));
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x001F17B4 File Offset: 0x001EF9B4
		// (set) Token: 0x06006550 RID: 25936 RVA: 0x000369BB File Offset: 0x00034BBB
		public unsafe static bool s_IsLoadingIndicatorPanelShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_s_IsLoadingIndicatorPanelShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_s_IsLoadingIndicatorPanelShown, (void*)(&value));
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x001F17D0 File Offset: 0x001EF9D0
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x000369C9 File Offset: 0x00034BC9
		public unsafe AudioClip m_TutorialSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_TutorialSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_TutorialSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x06006553 RID: 25939 RVA: 0x001F1800 File Offset: 0x001EFA00
		// (set) Token: 0x06006554 RID: 25940 RVA: 0x000369E8 File Offset: 0x00034BE8
		public unsafe AssetReference m_EscapePannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_EscapePannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_EscapePannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x06006555 RID: 25941 RVA: 0x001F1830 File Offset: 0x001EFA30
		// (set) Token: 0x06006556 RID: 25942 RVA: 0x00036A07 File Offset: 0x00034C07
		public unsafe AssetReference m_NotebookPannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_NotebookPannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_NotebookPannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x06006557 RID: 25943 RVA: 0x001F1860 File Offset: 0x001EFA60
		// (set) Token: 0x06006558 RID: 25944 RVA: 0x00036A26 File Offset: 0x00034C26
		public unsafe AssetReference m_StoragePannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_StoragePannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_StoragePannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x001F1890 File Offset: 0x001EFA90
		// (set) Token: 0x0600655A RID: 25946 RVA: 0x00036A45 File Offset: 0x00034C45
		public unsafe AssetReference m_DialogPannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DialogPannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DialogPannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x001F18C0 File Offset: 0x001EFAC0
		// (set) Token: 0x0600655C RID: 25948 RVA: 0x00036A64 File Offset: 0x00034C64
		public unsafe AssetReference m_MultipleChoicePannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MultipleChoicePannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MultipleChoicePannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x001F18F0 File Offset: 0x001EFAF0
		// (set) Token: 0x0600655E RID: 25950 RVA: 0x00036A83 File Offset: 0x00034C83
		public unsafe AssetReference m_IzakayaConfigPannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IzakayaConfigPannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IzakayaConfigPannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600655F RID: 25951 RVA: 0x001F1920 File Offset: 0x001EFB20
		// (set) Token: 0x06006560 RID: 25952 RVA: 0x00036AA2 File Offset: 0x00034CA2
		public unsafe AssetReference m_BindingPannelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BindingPannelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BindingPannelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x001F1950 File Offset: 0x001EFB50
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x00036AC1 File Offset: 0x00034CC1
		public unsafe AssetReference m_FilterPanelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_FilterPanelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_FilterPanelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x001F1980 File Offset: 0x001EFB80
		// (set) Token: 0x06006564 RID: 25956 RVA: 0x00036AE0 File Offset: 0x00034CE0
		public unsafe AssetReference m_RewindDialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_RewindDialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_RewindDialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x001F19B0 File Offset: 0x001EFBB0
		// (set) Token: 0x06006566 RID: 25958 RVA: 0x00036AFF File Offset: 0x00034CFF
		public unsafe AssetReference m_LevelUpEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LevelUpEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LevelUpEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x001F19E0 File Offset: 0x001EFBE0
		// (set) Token: 0x06006568 RID: 25960 RVA: 0x00036B1E File Offset: 0x00034D1E
		public unsafe AssetReference m_LoadingIndicatorPanelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LoadingIndicatorPanelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LoadingIndicatorPanelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x001F1A10 File Offset: 0x001EFC10
		// (set) Token: 0x0600656A RID: 25962 RVA: 0x00036B3D File Offset: 0x00034D3D
		public unsafe AssetReference m_MultipleGetProductsPanelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MultipleGetProductsPanelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MultipleGetProductsPanelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x001F1A40 File Offset: 0x001EFC40
		// (set) Token: 0x0600656C RID: 25964 RVA: 0x00036B5C File Offset: 0x00034D5C
		public unsafe AssetReference m_GeneralErrorPanelAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_GeneralErrorPanelAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_GeneralErrorPanelAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x001F1A70 File Offset: 0x001EFC70
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x00036B7B File Offset: 0x00034D7B
		public unsafe AssetReference m_DayScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DayScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DayScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x001F1AA0 File Offset: 0x001EFCA0
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x00036B9A File Offset: 0x00034D9A
		public unsafe AssetReference m_MainScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MainScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_MainScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x001F1AD0 File Offset: 0x001EFCD0
		// (set) Token: 0x06006572 RID: 25970 RVA: 0x00036BB9 File Offset: 0x00034DB9
		public unsafe AssetReference m_LoadScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LoadScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_LoadScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x001F1B00 File Offset: 0x001EFD00
		// (set) Token: 0x06006574 RID: 25972 RVA: 0x00036BD8 File Offset: 0x00034DD8
		public unsafe AssetReference m_IzakayaPrepScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IzakayaPrepScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IzakayaPrepScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06006575 RID: 25973 RVA: 0x001F1B30 File Offset: 0x001EFD30
		// (set) Token: 0x06006576 RID: 25974 RVA: 0x00036BF7 File Offset: 0x00034DF7
		public unsafe AssetReference m_WorkScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_WorkScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_WorkScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x001F1B60 File Offset: 0x001EFD60
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x00036C16 File Offset: 0x00034E16
		public unsafe AssetReference m_ResultScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ResultScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ResultScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x001F1B90 File Offset: 0x001EFD90
		// (set) Token: 0x0600657A RID: 25978 RVA: 0x00036C35 File Offset: 0x00034E35
		public unsafe AssetReference m_StaffScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_StaffScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_StaffScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x001F1BC0 File Offset: 0x001EFDC0
		// (set) Token: 0x0600657C RID: 25980 RVA: 0x00036C54 File Offset: 0x00034E54
		public unsafe AssetReference m_EmptyScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_EmptyScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_EmptyScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x001F1BF0 File Offset: 0x001EFDF0
		// (set) Token: 0x0600657E RID: 25982 RVA: 0x00036C73 File Offset: 0x00034E73
		public unsafe AudioClip m_DefaultOnSelectAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSelectAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSelectAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x001F1C20 File Offset: 0x001EFE20
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x00036C92 File Offset: 0x00034E92
		public unsafe AudioClip m_DefaultOnSubmitAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSubmitAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnSubmitAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x001F1C50 File Offset: 0x001EFE50
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x00036CB1 File Offset: 0x00034EB1
		public unsafe AudioClip m_DefaultOnCancelAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnCancelAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnCancelAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06006583 RID: 25987 RVA: 0x001F1C80 File Offset: 0x001EFE80
		// (set) Token: 0x06006584 RID: 25988 RVA: 0x00036CD0 File Offset: 0x00034ED0
		public unsafe AudioClip m_DefaultOnPanelOpenAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelOpenAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelOpenAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x001F1CB0 File Offset: 0x001EFEB0
		// (set) Token: 0x06006586 RID: 25990 RVA: 0x00036CEF File Offset: 0x00034EEF
		public unsafe AudioClip m_DefaultOnPanelCloseAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelCloseAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_DefaultOnPanelCloseAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x001F1CE0 File Offset: 0x001EFEE0
		// (set) Token: 0x06006588 RID: 25992 RVA: 0x00036D0E File Offset: 0x00034F0E
		public unsafe TransitingModuleBase m_TransitionModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_TransitionModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitingModuleBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_TransitionModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x001F1D10 File Offset: 0x001EFF10
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x00036D2D File Offset: 0x00034F2D
		public unsafe Material m_ShakeMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ShakeMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ShakeMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x001F1D40 File Offset: 0x001EFF40
		// (set) Token: 0x0600658C RID: 25996 RVA: 0x00036D4C File Offset: 0x00034F4C
		public unsafe RectTransform m_IsolatedPanelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IsolatedPanelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_IsolatedPanelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600658D RID: 25997 RVA: 0x001F1D70 File Offset: 0x001EFF70
		// (set) Token: 0x0600658E RID: 25998 RVA: 0x00036D6B File Offset: 0x00034F6B
		public unsafe HashSet<UIPanelBaseImpl> m_BufferedPanelPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UIPanelBaseImpl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x001F1DA0 File Offset: 0x001EFFA0
		// (set) Token: 0x06006590 RID: 26000 RVA: 0x00036D8A File Offset: 0x00034F8A
		public unsafe Dictionary<string, HashSet<UIPanelBaseImpl>> m_BufferedPanelPrefabGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<UIPanelBaseImpl>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_BufferedPanelPrefabGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x001F1DD0 File Offset: 0x001EFFD0
		// (set) Token: 0x06006592 RID: 26002 RVA: 0x00036DA9 File Offset: 0x00034FA9
		public unsafe Il2CppReferenceArray<AssetReference> m_AllScenes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_AllScenes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_AllScenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06006593 RID: 26003 RVA: 0x001F1E00 File Offset: 0x001F0000
		// (set) Token: 0x06006594 RID: 26004 RVA: 0x00036DC8 File Offset: 0x00034FC8
		public unsafe Coroutine m_ShakeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ShakeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.NativeFieldInfoPtr_m_ShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06006595 RID: 26005 RVA: 0x001F1E30 File Offset: 0x001F0030
		// (set) Token: 0x06006596 RID: 26006 RVA: 0x00036DE7 File Offset: 0x00034FE7
		public unsafe static string _PlayerInputMode_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr__PlayerInputMode_k__BackingField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr__PlayerInputMode_k__BackingField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x001F1E50 File Offset: 0x001F0050
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x00036DF9 File Offset: 0x00034FF9
		public unsafe static DialogPackage _RewindDialogPackage_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr__RewindDialogPackage_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr__RewindDialogPackage_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x001F1E78 File Offset: 0x001F0078
		// (set) Token: 0x0600659A RID: 26010 RVA: 0x00036E0B File Offset: 0x0003500B
		public unsafe static bool _IsInputEnabled_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr__IsInputEnabled_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr__IsInputEnabled_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x001F1E94 File Offset: 0x001F0094
		// (set) Token: 0x0600659C RID: 26012 RVA: 0x00036E19 File Offset: 0x00035019
		public unsafe static bool _IsSwitchScene_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr__IsSwitchScene_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr__IsSwitchScene_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x001F1EB0 File Offset: 0x001F00B0
		// (set) Token: 0x0600659E RID: 26014 RVA: 0x00036E27 File Offset: 0x00035027
		public unsafe static Action OnWillLoadSceneCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_OnWillLoadSceneCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_OnWillLoadSceneCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600659F RID: 26015 RVA: 0x001F1ED8 File Offset: 0x001F00D8
		// (set) Token: 0x060065A0 RID: 26016 RVA: 0x00036E39 File Offset: 0x00035039
		public unsafe static Action<Vector2> OnPointerPositionUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_OnPointerPositionUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_OnPointerPositionUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060065A1 RID: 26017 RVA: 0x001F1F00 File Offset: 0x001F0100
		// (set) Token: 0x060065A2 RID: 26018 RVA: 0x00036E4B File Offset: 0x0003504B
		public unsafe static Action<bool> OnPlayerInputAvailabilityUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.NativeFieldInfoPtr_OnPlayerInputAvailabilityUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.NativeFieldInfoPtr_OnPlayerInputAvailabilityUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeFieldInfoPtr_TRANSITION_DURATION;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeFieldInfoPtr_s_LoadingIndicatorPanel;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeFieldInfoPtr_s_EscMainPannel;

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeFieldInfoPtr_s_NoteBookMainPannel;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeFieldInfoPtr_s_StorageMainPannel;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeFieldInfoPtr_s_DialogPannel;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeFieldInfoPtr_s_EscBindingSubPannel;

		// Token: 0x040042DC RID: 17116
		private static readonly IntPtr NativeFieldInfoPtr_s_FlattenedFilterPanel;

		// Token: 0x040042DD RID: 17117
		private static readonly IntPtr NativeFieldInfoPtr_s_MultipleChoicePannel;

		// Token: 0x040042DE RID: 17118
		private static readonly IntPtr NativeFieldInfoPtr_s_IzakayaConfigPannel;

		// Token: 0x040042DF RID: 17119
		private static readonly IntPtr NativeFieldInfoPtr_s_MultipleGetProductsPanel;

		// Token: 0x040042E0 RID: 17120
		private static readonly IntPtr NativeFieldInfoPtr_s_GeneralErrorPanel;

		// Token: 0x040042E1 RID: 17121
		private static readonly IntPtr NativeFieldInfoPtr_s_LevelUpEffect;

		// Token: 0x040042E2 RID: 17122
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCommonPannelLoaded;

		// Token: 0x040042E3 RID: 17123
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFadeIn;

		// Token: 0x040042E4 RID: 17124
		private static readonly IntPtr NativeFieldInfoPtr_s_Amplitude;

		// Token: 0x040042E5 RID: 17125
		private static readonly IntPtr NativeFieldInfoPtr_s_IsDialogPanelOpened;

		// Token: 0x040042E6 RID: 17126
		private static readonly IntPtr NativeFieldInfoPtr_s_IsLoadingIndicatorPanelShown;

		// Token: 0x040042E7 RID: 17127
		private static readonly IntPtr NativeFieldInfoPtr_m_TutorialSFX;

		// Token: 0x040042E8 RID: 17128
		private static readonly IntPtr NativeFieldInfoPtr_m_EscapePannelAsset;

		// Token: 0x040042E9 RID: 17129
		private static readonly IntPtr NativeFieldInfoPtr_m_NotebookPannelAsset;

		// Token: 0x040042EA RID: 17130
		private static readonly IntPtr NativeFieldInfoPtr_m_StoragePannelAsset;

		// Token: 0x040042EB RID: 17131
		private static readonly IntPtr NativeFieldInfoPtr_m_DialogPannelAsset;

		// Token: 0x040042EC RID: 17132
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleChoicePannelAsset;

		// Token: 0x040042ED RID: 17133
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaConfigPannelAsset;

		// Token: 0x040042EE RID: 17134
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingPannelAsset;

		// Token: 0x040042EF RID: 17135
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterPanelAsset;

		// Token: 0x040042F0 RID: 17136
		private static readonly IntPtr NativeFieldInfoPtr_m_RewindDialogPackage;

		// Token: 0x040042F1 RID: 17137
		private static readonly IntPtr NativeFieldInfoPtr_m_LevelUpEffect;

		// Token: 0x040042F2 RID: 17138
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadingIndicatorPanelAsset;

		// Token: 0x040042F3 RID: 17139
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleGetProductsPanelAsset;

		// Token: 0x040042F4 RID: 17140
		private static readonly IntPtr NativeFieldInfoPtr_m_GeneralErrorPanelAsset;

		// Token: 0x040042F5 RID: 17141
		private static readonly IntPtr NativeFieldInfoPtr_m_DayScene;

		// Token: 0x040042F6 RID: 17142
		private static readonly IntPtr NativeFieldInfoPtr_m_MainScene;

		// Token: 0x040042F7 RID: 17143
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadScene;

		// Token: 0x040042F8 RID: 17144
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaPrepScene;

		// Token: 0x040042F9 RID: 17145
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkScene;

		// Token: 0x040042FA RID: 17146
		private static readonly IntPtr NativeFieldInfoPtr_m_ResultScene;

		// Token: 0x040042FB RID: 17147
		private static readonly IntPtr NativeFieldInfoPtr_m_StaffScene;

		// Token: 0x040042FC RID: 17148
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyScene;

		// Token: 0x040042FD RID: 17149
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultOnSelectAudio;

		// Token: 0x040042FE RID: 17150
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultOnSubmitAudio;

		// Token: 0x040042FF RID: 17151
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultOnCancelAudio;

		// Token: 0x04004300 RID: 17152
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultOnPanelOpenAudio;

		// Token: 0x04004301 RID: 17153
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultOnPanelCloseAudio;

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeFieldInfoPtr_m_TransitionModule;

		// Token: 0x04004303 RID: 17155
		private static readonly IntPtr NativeFieldInfoPtr_m_ShakeMaterial;

		// Token: 0x04004304 RID: 17156
		private static readonly IntPtr NativeFieldInfoPtr_m_IsolatedPanelTransform;

		// Token: 0x04004305 RID: 17157
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferedPanelPrefabs;

		// Token: 0x04004306 RID: 17158
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferedPanelPrefabGroups;

		// Token: 0x04004307 RID: 17159
		private static readonly IntPtr NativeFieldInfoPtr_m_AllScenes;

		// Token: 0x04004308 RID: 17160
		private static readonly IntPtr NativeFieldInfoPtr_m_ShakeCoroutine;

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeFieldInfoPtr__PlayerInputMode_k__BackingField;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeFieldInfoPtr__RewindDialogPackage_k__BackingField;

		// Token: 0x0400430B RID: 17163
		private static readonly IntPtr NativeFieldInfoPtr__IsInputEnabled_k__BackingField;

		// Token: 0x0400430C RID: 17164
		private static readonly IntPtr NativeFieldInfoPtr__IsSwitchScene_k__BackingField;

		// Token: 0x0400430D RID: 17165
		private static readonly IntPtr NativeFieldInfoPtr_OnWillLoadSceneCallback;

		// Token: 0x0400430E RID: 17166
		private static readonly IntPtr NativeFieldInfoPtr_OnPointerPositionUpdate;

		// Token: 0x0400430F RID: 17167
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerInputAvailabilityUpdate;

		// Token: 0x04004310 RID: 17168
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerInputMode_Public_Static_get_String_0;

		// Token: 0x04004311 RID: 17169
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerInputMode_Public_Static_set_Void_String_0;

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeMethodInfoPtr_get_RewindDialogPackage_Public_Static_get_DialogPackage_0;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeMethodInfoPtr_set_RewindDialogPackage_Private_Static_set_Void_DialogPackage_0;

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeMethodInfoPtr_set_IsInputEnabled_Private_Static_set_Void_Boolean_0;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformMemoryMode_Public_Static_get_MemoryMode_0;

		// Token: 0x04004317 RID: 17175
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformAssetLifetime_Public_Static_get_AssetLifetime_0;

		// Token: 0x04004318 RID: 17176
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformPanelLifetime_Public_Static_get_AdpPanelLifetime_0;

		// Token: 0x04004319 RID: 17177
		private static readonly IntPtr NativeMethodInfoPtr_get_LevelUpEffect_Public_Static_get_GameObject_0;

		// Token: 0x0400431A RID: 17178
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSwitchScene_Public_Static_get_Boolean_0;

		// Token: 0x0400431B RID: 17179
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSwitchScene_Private_Static_set_Void_Boolean_0;

		// Token: 0x0400431C RID: 17180
		private static readonly IntPtr NativeMethodInfoPtr_add_OnWillLoadSceneCallback_Public_Static_add_Void_Action_0;

		// Token: 0x0400431D RID: 17181
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnWillLoadSceneCallback_Public_Static_rem_Void_Action_0;

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPointerPositionUpdate_Public_Static_add_Void_Action_1_Vector2_0;

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPointerPositionUpdate_Public_Static_rem_Void_Action_1_Vector2_0;

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPlayerInputAvailabilityUpdate_Public_Static_add_Void_Action_1_Boolean_0;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlayerInputAvailabilityUpdate_Public_Static_rem_Void_Action_1_Boolean_0;

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeMethodInfoPtr_SetAndPushCurrentScenePanelRoot_Public_Static_Void_MonoBehaviour_RectTransform_0;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeMethodInfoPtr_GetEscapePanelParent_Public_Static_EscMainPannel_0;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeMethodInfoPtr_GetNotebookPanelParent_Public_Static_NoteBookMainPannel_0;

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeMethodInfoPtr_GetStoragePanelParent_Public_Static_StorageMainPannel_0;

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaConfigPanelParent_Private_IzakayaConfigPannel_0;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeMethodInfoPtr_GetMultipleChoicePanelParent_Private_MultipleChoicePannel_0;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeMethodInfoPtr_GetMultipleGetProductsPanelParent_Private_MultipleGetProductsPanel_0;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeMethodInfoPtr_OpenNotebookPanelStandalone_Public_Static_Void_Action_0;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeMethodInfoPtr_OpenNotebookPanelStandaloneAsync_Private_Static_UniTask_Action_0;

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePanelStandalone_Public_Static_Void_Action_0;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeMethodInfoPtr_OpenStoragePanelStandaloneAsync_Private_Static_UniTask_Action_0;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_T_T_Action_1_T_String_0;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_T_T_String_0;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeMethodInfoPtr_StopCameraShake_Public_Static_Void_0;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerInputAvailability_Public_Static_Void_Boolean_0;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeMethodInfoPtr_ReMigrateCommonPanels_Public_Static_Void_Transform_Boolean_0;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeMethodInfoPtr_PreLoadCommonPanelParent_Public_Static_UniTask_0;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeMethodInfoPtr_PlayLevelUpEffect_Public_Static_GameObject_0;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeMethodInfoPtr_AdpUIPanelManager_OnInputModeChangedCallback_Private_Void_RequestedInputMode_0;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeMethodInfoPtr_CallOnPointerPositionUpdate_Private_Static_Void_CallbackContext_0;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeMethodInfoPtr_GetScene_Private_Static_AssetReference_Scene_0;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeMethodInfoPtr_IsMainScene_Public_Static_Boolean_AssetReference_0;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeMethodInfoPtr_GetMainScene_Public_Static_AssetReference_0;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeMethodInfoPtr_PlayTutorialOpenAudio_Public_Static_Void_0;

		// Token: 0x0400433C RID: 17212
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_Scene_Action_0;

		// Token: 0x0400433D RID: 17213
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilAllPannelClosed_Private_Static_Void_Action_0;

		// Token: 0x0400433E RID: 17214
		private static readonly IntPtr NativeMethodInfoPtr_FadeInAsync_Public_Static_UniTask_0;

		// Token: 0x0400433F RID: 17215
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutAsync_Public_Static_UniTask_0;

		// Token: 0x04004340 RID: 17216
		private static readonly IntPtr NativeMethodInfoPtr_OpenIzakayaConfigMenuAsync_Public_Static_UniTask_IPostExtraChecker_0;

		// Token: 0x04004341 RID: 17217
		private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Static_Void_Action_0;

		// Token: 0x04004342 RID: 17218
		private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Static_Void_Action_0;

		// Token: 0x04004343 RID: 17219
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x04004344 RID: 17220
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x04004345 RID: 17221
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuWithExitCode_Public_Static_Void_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x04004346 RID: 17222
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuWithExitCodeAsyncInternal_Private_Static_UniTaskVoid_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x04004347 RID: 17223
		private static readonly IntPtr NativeMethodInfoPtr_OpenManualDialogMenu_Public_Static_Void_DialogPackage_Action_Action_1_Action_Action_1_Action_Action_Boolean_PanelVisualMode_0;

		// Token: 0x04004348 RID: 17224
		private static readonly IntPtr NativeMethodInfoPtr_OpenGeneralErrorPanelAsync_Public_Static_UniTask_String_String_0;

		// Token: 0x04004349 RID: 17225
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0;

		// Token: 0x0400434A RID: 17226
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0;

		// Token: 0x0400434B RID: 17227
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0;

		// Token: 0x0400434C RID: 17228
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0;

		// Token: 0x0400434D RID: 17229
		private static readonly IntPtr NativeMethodInfoPtr_OpenBindingSubPannel_Public_Static_Void_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0;

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeMethodInfoPtr_OpenBindingSubPannelAsyncInternal_Private_Static_UniTaskVoid_InputBindingData_Il2CppReferenceArray_1_StringArray_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_InputBindingData_Action_0;

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilterPanel_Public_Static_UniTask_IReadOnlyList_1_FilterConfigFactory_1_T_List_1_IFilterConfig_0;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeMethodInfoPtr_OpenIzakayaConfigMenu_Public_Static_Void_Action_IPostExtraChecker_0;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeMethodInfoPtr_OpenIzakayaConfigMenuAsyncInternal_Private_Static_UniTask_Action_IPostExtraChecker_0;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleGetProductsPanel_Public_Static_Void_MultipleGetProductsOpenContext_Action_0;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeMethodInfoPtr_OpenMultipleGetProductsPanelAsync_Public_Static_UniTask_MultipleGetProductsOpenContext_Action_0;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_Func_1_UniTask_0;

		// Token: 0x04004355 RID: 17237
		private static readonly IntPtr NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_Func_1_UniTask_1_T_0;

		// Token: 0x04004356 RID: 17238
		private static readonly IntPtr NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_UniTask_0;

		// Token: 0x04004357 RID: 17239
		private static readonly IntPtr NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_UniTask_1_T_0;

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeMethodInfoPtr_ShowLoadingIndicator_Public_Static_IDisposable_0;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuWithExitCodeCoroutine_Public_Static_IEnumerator_DialogPackage_Action_1_Int32_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeMethodInfoPtr_OpenDialogMenuAsync_Public_Static_UniTask_DialogPackage_Action_1_Dictionary_2_Int32_String_PanelVisualMode_0;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeMethodInfoPtr_OpenInputBlockerMenu_Public_Static_Void_0;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeMethodInfoPtr_CloseInputBlockerMenu_Public_Static_Void_0;

		// Token: 0x0400435E RID: 17246
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_0;

		// Token: 0x0400435F RID: 17247
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x04004360 RID: 17248
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShakeC_Public_Static_IEnumerator_Single_Single_Single_0;

		// Token: 0x04004361 RID: 17249
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShakeCorotine_Public_Static_IEnumerator_Single_Single_Single_0;

		// Token: 0x04004362 RID: 17250
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndPreparePanelScoped_Public_Static_UniTask_1_T_AssetReference_Boolean_0;

		// Token: 0x04004363 RID: 17251
		private static readonly IntPtr NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_T_T_String_0;

		// Token: 0x04004364 RID: 17252
		private static readonly IntPtr NativeMethodInfoPtr_PrepareOrGetTempPanelInstanceImpl_Private_T_T_AdpPanelLifetime_String_0;

		// Token: 0x04004365 RID: 17253
		private static readonly IntPtr NativeMethodInfoPtr_LoadPanelScoped_Public_Static_UniTask_1_IGameObjectAssetHandle_1_T_AssetReference_0;

		// Token: 0x04004366 RID: 17254
		private static readonly IntPtr NativeMethodInfoPtr_TryCleanThenAddBufferedPanelPrefab_Private_Void_UIPanelBaseImpl_0;

		// Token: 0x04004367 RID: 17255
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllBufferedPanelOfGroup_Public_Void_String_0;

		// Token: 0x04004368 RID: 17256
		private static readonly IntPtr NativeMethodInfoPtr_WaitDelayFrame_Public_Static_Void_Action_0;

		// Token: 0x04004369 RID: 17257
		private static readonly IntPtr NativeMethodInfoPtr_WaitDelay_Public_Static_Void_Single_Action_0;

		// Token: 0x0400436A RID: 17258
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShake_Public_Static_Void_Single_0;

		// Token: 0x0400436B RID: 17259
		private static readonly IntPtr NativeMethodInfoPtr_RunUnderIsolatedParent_Public_Static_IsolatedPanelTransformHandle_0;

		// Token: 0x0400436C RID: 17260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400436D RID: 17261
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0;

		// Token: 0x0400436E RID: 17262
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0;

		// Token: 0x02000E0D RID: 3597
		public class LoadingIndicatorDisposableHandle : Il2CppSystem.Object
		{
			// Token: 0x06010314 RID: 66324 RVA: 0x003C6314 File Offset: 0x003C4514
			// Note: this type is marked as 'beforefieldinit'.
			static LoadingIndicatorDisposableHandle()
			{
				Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "LoadingIndicatorDisposableHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr);
				UniversalGameManager.LoadingIndicatorDisposableHandle.NativeFieldInfoPtr_m_OpenedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr, "m_OpenedPanel");
				UniversalGameManager.LoadingIndicatorDisposableHandle.NativeMethodInfoPtr__ctor_Public_Void_AdpBuiltinInputBlockerPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr, 100684500);
				UniversalGameManager.LoadingIndicatorDisposableHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr, 100684501);
			}

			// Token: 0x06010315 RID: 66325 RVA: 0x003C637C File Offset: 0x003C457C
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadingIndicatorDisposableHandle(AdpBuiltinInputBlockerPanel openedPanel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.LoadingIndicatorDisposableHandle>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(openedPanel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.LoadingIndicatorDisposableHandle.NativeMethodInfoPtr__ctor_Public_Void_AdpBuiltinInputBlockerPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010316 RID: 66326 RVA: 0x003C63C8 File Offset: 0x003C45C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258973, XrefRangeEnd = 258978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.LoadingIndicatorDisposableHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010317 RID: 66327 RVA: 0x0008CE7E File Offset: 0x0008B07E
			public LoadingIndicatorDisposableHandle(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054A9 RID: 21673
			// (get) Token: 0x06010318 RID: 66328 RVA: 0x003C63FC File Offset: 0x003C45FC
			// (set) Token: 0x06010319 RID: 66329 RVA: 0x0008CE87 File Offset: 0x0008B087
			public unsafe AdpBuiltinInputBlockerPanel m_OpenedPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.LoadingIndicatorDisposableHandle.NativeFieldInfoPtr_m_OpenedPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpBuiltinInputBlockerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.LoadingIndicatorDisposableHandle.NativeFieldInfoPtr_m_OpenedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A450 RID: 42064
			private static readonly IntPtr NativeFieldInfoPtr_m_OpenedPanel;

			// Token: 0x0400A451 RID: 42065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AdpBuiltinInputBlockerPanel_0;

			// Token: 0x0400A452 RID: 42066
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000E0E RID: 3598
		public class InvalidIDisposable : Il2CppSystem.Object
		{
			// Token: 0x0601031A RID: 66330 RVA: 0x003C642C File Offset: 0x003C462C
			// Note: this type is marked as 'beforefieldinit'.
			static InvalidIDisposable()
			{
				Il2CppClassPointerStore<UniversalGameManager.InvalidIDisposable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "InvalidIDisposable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.InvalidIDisposable>.NativeClassPtr);
				UniversalGameManager.InvalidIDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.InvalidIDisposable>.NativeClassPtr, 100684502);
				UniversalGameManager.InvalidIDisposable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.InvalidIDisposable>.NativeClassPtr, 100684503);
			}

			// Token: 0x0601031B RID: 66331 RVA: 0x003C6480 File Offset: 0x003C4680
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.InvalidIDisposable.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601031C RID: 66332 RVA: 0x003C64B4 File Offset: 0x003C46B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvalidIDisposable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.InvalidIDisposable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.InvalidIDisposable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601031D RID: 66333 RVA: 0x0008CEA6 File Offset: 0x0008B0A6
			public InvalidIDisposable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400A453 RID: 42067
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400A454 RID: 42068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000E0F RID: 3599
		[StructLayout(2)]
		public struct IsolatedPanelTransformHandle
		{
			// Token: 0x0601031E RID: 66334 RVA: 0x0008CEAF File Offset: 0x0008B0AF
			// Note: this type is marked as 'beforefieldinit'.
			static IsolatedPanelTransformHandle()
			{
				Il2CppClassPointerStore<UniversalGameManager.IsolatedPanelTransformHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "IsolatedPanelTransformHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.IsolatedPanelTransformHandle>.NativeClassPtr);
				UniversalGameManager.IsolatedPanelTransformHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.IsolatedPanelTransformHandle>.NativeClassPtr, 100684504);
			}

			// Token: 0x0601031F RID: 66335 RVA: 0x003C64F0 File Offset: 0x003C46F0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 258985, RefRangeEnd = 258989, XrefRangeStart = 258978, XrefRangeEnd = 258985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.IsolatedPanelTransformHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010320 RID: 66336 RVA: 0x0008CEE3 File Offset: 0x0008B0E3
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniversalGameManager.IsolatedPanelTransformHandle>.NativeClassPtr, ref this));
			}

			// Token: 0x0400A455 RID: 42069
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000E10 RID: 3600
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenNotebookPanelStandaloneAsync>d__93")]
		public sealed class _OpenNotebookPanelStandaloneAsync_d__93 : ValueType
		{
			// Token: 0x06010321 RID: 66337 RVA: 0x003C6518 File Offset: 0x003C4718
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenNotebookPanelStandaloneAsync_d__93()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenNotebookPanelStandaloneAsync>d__93");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr);
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr_onPanelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, "onPanelCloseCallback");
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, "<>7__wrap1");
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, 100684505);
				UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr, 100684506);
			}

			// Token: 0x06010322 RID: 66338 RVA: 0x003C65D0 File Offset: 0x003C47D0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 259006, RefRangeEnd = 259009, XrefRangeStart = 258989, XrefRangeEnd = 259006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010323 RID: 66339 RVA: 0x003C6608 File Offset: 0x003C4808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010324 RID: 66340 RVA: 0x0008CEF5 File Offset: 0x0008B0F5
			public _OpenNotebookPanelStandaloneAsync_d__93(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010325 RID: 66341 RVA: 0x0008CEFE File Offset: 0x0008B0FE
			public _OpenNotebookPanelStandaloneAsync_d__93() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93>.NativeClassPtr))
			{
			}

			// Token: 0x170054AA RID: 21674
			// (get) Token: 0x06010326 RID: 66342 RVA: 0x003C6650 File Offset: 0x003C4850
			// (set) Token: 0x06010327 RID: 66343 RVA: 0x0008CF10 File Offset: 0x0008B110
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170054AB RID: 21675
			// (get) Token: 0x06010328 RID: 66344 RVA: 0x003C6678 File Offset: 0x003C4878
			// (set) Token: 0x06010329 RID: 66345 RVA: 0x0008CF2B File Offset: 0x0008B12B
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054AC RID: 21676
			// (get) Token: 0x0601032A RID: 66346 RVA: 0x003C66A8 File Offset: 0x003C48A8
			// (set) Token: 0x0601032B RID: 66347 RVA: 0x0008CF59 File Offset: 0x0008B159
			public unsafe Action onPanelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr_onPanelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr_onPanelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054AD RID: 21677
			// (get) Token: 0x0601032C RID: 66348 RVA: 0x003C66D8 File Offset: 0x003C48D8
			// (set) Token: 0x0601032D RID: 66349 RVA: 0x0008CF78 File Offset: 0x0008B178
			public unsafe UniversalGameManager.IsolatedPanelTransformHandle __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x170054AE RID: 21678
			// (get) Token: 0x0601032E RID: 66350 RVA: 0x003C6700 File Offset: 0x003C4900
			// (set) Token: 0x0601032F RID: 66351 RVA: 0x0008CF93 File Offset: 0x0008B193
			public UniTask<NoteBookMainPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___u__1);
					return new UniTask<NoteBookMainPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<NoteBookMainPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenNotebookPanelStandaloneAsync_d__93.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<NoteBookMainPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A456 RID: 42070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A457 RID: 42071
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A458 RID: 42072
			private static readonly IntPtr NativeFieldInfoPtr_onPanelCloseCallback;

			// Token: 0x0400A459 RID: 42073
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400A45A RID: 42074
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A45B RID: 42075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A45C RID: 42076
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E11 RID: 3601
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenStoragePanelStandaloneAsync>d__95")]
		public sealed class _OpenStoragePanelStandaloneAsync_d__95 : ValueType
		{
			// Token: 0x06010330 RID: 66352 RVA: 0x003C6730 File Offset: 0x003C4930
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenStoragePanelStandaloneAsync_d__95()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenStoragePanelStandaloneAsync>d__95");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr);
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr_onPanelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, "onPanelCloseCallback");
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, "<>7__wrap1");
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, 100684507);
				UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr, 100684508);
			}

			// Token: 0x06010331 RID: 66353 RVA: 0x003C67E8 File Offset: 0x003C49E8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 259026, RefRangeEnd = 259029, XrefRangeStart = 259009, XrefRangeEnd = 259026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010332 RID: 66354 RVA: 0x003C6820 File Offset: 0x003C4A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010333 RID: 66355 RVA: 0x0008CFC1 File Offset: 0x0008B1C1
			public _OpenStoragePanelStandaloneAsync_d__95(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010334 RID: 66356 RVA: 0x0008CFCA File Offset: 0x0008B1CA
			public _OpenStoragePanelStandaloneAsync_d__95() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95>.NativeClassPtr))
			{
			}

			// Token: 0x170054AF RID: 21679
			// (get) Token: 0x06010335 RID: 66357 RVA: 0x003C6868 File Offset: 0x003C4A68
			// (set) Token: 0x06010336 RID: 66358 RVA: 0x0008CFDC File Offset: 0x0008B1DC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170054B0 RID: 21680
			// (get) Token: 0x06010337 RID: 66359 RVA: 0x003C6890 File Offset: 0x003C4A90
			// (set) Token: 0x06010338 RID: 66360 RVA: 0x0008CFF7 File Offset: 0x0008B1F7
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054B1 RID: 21681
			// (get) Token: 0x06010339 RID: 66361 RVA: 0x003C68C0 File Offset: 0x003C4AC0
			// (set) Token: 0x0601033A RID: 66362 RVA: 0x0008D025 File Offset: 0x0008B225
			public unsafe Action onPanelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr_onPanelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr_onPanelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B2 RID: 21682
			// (get) Token: 0x0601033B RID: 66363 RVA: 0x003C68F0 File Offset: 0x003C4AF0
			// (set) Token: 0x0601033C RID: 66364 RVA: 0x0008D044 File Offset: 0x0008B244
			public unsafe UniversalGameManager.IsolatedPanelTransformHandle __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___7__wrap1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___7__wrap1)) = value;
				}
			}

			// Token: 0x170054B3 RID: 21683
			// (get) Token: 0x0601033D RID: 66365 RVA: 0x003C6918 File Offset: 0x003C4B18
			// (set) Token: 0x0601033E RID: 66366 RVA: 0x0008D05F File Offset: 0x0008B25F
			public UniTask<StorageMainPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___u__1);
					return new UniTask<StorageMainPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<StorageMainPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenStoragePanelStandaloneAsync_d__95.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<StorageMainPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A45D RID: 42077
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A45E RID: 42078
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A45F RID: 42079
			private static readonly IntPtr NativeFieldInfoPtr_onPanelCloseCallback;

			// Token: 0x0400A460 RID: 42080
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400A461 RID: 42081
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A462 RID: 42082
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A463 RID: 42083
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E12 RID: 3602
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601033F RID: 66367 RVA: 0x003C6948 File Offset: 0x003C4B48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr);
				UniversalGameManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_2");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_3");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_4");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_5");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_6");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_7");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_8");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_9");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_10");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_11");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_12");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_13");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__102_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__102_14");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__104_0");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__104_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__104_1");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__111_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__111_2");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__119_0");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__153_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__153_0");
				UniversalGameManager.__c.NativeFieldInfoPtr___9__154_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, "<>9__154_0");
				UniversalGameManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684510);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_2_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684511);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_3_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684512);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_4_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684513);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_5_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684514);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_6_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684515);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_7_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684516);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_8_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684517);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_9_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684518);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_10_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684519);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_11_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684520);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_12_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684521);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_13_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684522);
				UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_14_Internal_AssetReference_UniversalGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684523);
				UniversalGameManager.__c.NativeMethodInfoPtr__OnAwake_b__104_0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684524);
				UniversalGameManager.__c.NativeMethodInfoPtr__OnAwake_b__104_1_Internal_InputAction_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684525);
				UniversalGameManager.__c.NativeMethodInfoPtr__LoadScene_b__111_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684526);
				UniversalGameManager.__c.NativeMethodInfoPtr__OpenDialogMenuAsyncInternal_b__119_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684527);
				UniversalGameManager.__c.NativeMethodInfoPtr__TryCleanThenAddBufferedPanelPrefab_b__153_0_Internal_Boolean_UIPanelBaseImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684528);
				UniversalGameManager.__c.NativeMethodInfoPtr__ClearAllBufferedPanelOfGroup_b__154_0_Internal_Boolean_UIPanelBaseImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr, 100684529);
			}

			// Token: 0x06010340 RID: 66368 RVA: 0x003C6C94 File Offset: 0x003C4E94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010341 RID: 66369 RVA: 0x003C6CD0 File Offset: 0x003C4ED0
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_2(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_2_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010342 RID: 66370 RVA: 0x003C6D20 File Offset: 0x003C4F20
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_3(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_3_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010343 RID: 66371 RVA: 0x003C6D70 File Offset: 0x003C4F70
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_4(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_4_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010344 RID: 66372 RVA: 0x003C6DC0 File Offset: 0x003C4FC0
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_5(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_5_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010345 RID: 66373 RVA: 0x003C6E10 File Offset: 0x003C5010
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_6(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_6_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010346 RID: 66374 RVA: 0x003C6E60 File Offset: 0x003C5060
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_7(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_7_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010347 RID: 66375 RVA: 0x003C6EB0 File Offset: 0x003C50B0
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_8(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_8_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010348 RID: 66376 RVA: 0x003C6F00 File Offset: 0x003C5100
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_9(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_9_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x06010349 RID: 66377 RVA: 0x003C6F50 File Offset: 0x003C5150
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_10(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_10_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0601034A RID: 66378 RVA: 0x003C6FA0 File Offset: 0x003C51A0
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_11(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_11_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0601034B RID: 66379 RVA: 0x003C6FF0 File Offset: 0x003C51F0
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_12(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_12_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0601034C RID: 66380 RVA: 0x003C7040 File Offset: 0x003C5240
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_13(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_13_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0601034D RID: 66381 RVA: 0x003C7090 File Offset: 0x003C5290
			[CallerCount(0)]
			public unsafe AssetReference _PreLoadCommonPanelParent_b__102_14(UniversalGameManager x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_14_Internal_AssetReference_UniversalGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0601034E RID: 66382 RVA: 0x003C70E0 File Offset: 0x003C52E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259029, XrefRangeEnd = 259059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAwake_b__104_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__OnAwake_b__104_0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601034F RID: 66383 RVA: 0x003C7120 File Offset: 0x003C5320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259059, XrefRangeEnd = 259072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputAction _OnAwake_b__104_1(InputActionReference reference)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__OnAwake_b__104_1_Internal_InputAction_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr3) : null;
			}

			// Token: 0x06010350 RID: 66384 RVA: 0x003C7170 File Offset: 0x003C5370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259072, XrefRangeEnd = 259080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadScene_b__111_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__LoadScene_b__111_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010351 RID: 66385 RVA: 0x003C71A4 File Offset: 0x003C53A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259080, XrefRangeEnd = 259084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenDialogMenuAsyncInternal_b__119_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__OpenDialogMenuAsyncInternal_b__119_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010352 RID: 66386 RVA: 0x003C71E0 File Offset: 0x003C53E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259084, XrefRangeEnd = 259088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryCleanThenAddBufferedPanelPrefab_b__153_0(UIPanelBaseImpl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__TryCleanThenAddBufferedPanelPrefab_b__153_0_Internal_Boolean_UIPanelBaseImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010353 RID: 66387 RVA: 0x003C7230 File Offset: 0x003C5430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259088, XrefRangeEnd = 259092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearAllBufferedPanelOfGroup_b__154_0(UIPanelBaseImpl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c.NativeMethodInfoPtr__ClearAllBufferedPanelOfGroup_b__154_0_Internal_Boolean_UIPanelBaseImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010354 RID: 66388 RVA: 0x0008D08D File Offset: 0x0008B28D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054B4 RID: 21684
			// (get) Token: 0x06010355 RID: 66389 RVA: 0x003C7280 File Offset: 0x003C5480
			// (set) Token: 0x06010356 RID: 66390 RVA: 0x0008D096 File Offset: 0x0008B296
			public unsafe static UniversalGameManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGameManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B5 RID: 21685
			// (get) Token: 0x06010357 RID: 66391 RVA: 0x003C72A8 File Offset: 0x003C54A8
			// (set) Token: 0x06010358 RID: 66392 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B6 RID: 21686
			// (get) Token: 0x06010359 RID: 66393 RVA: 0x003C72D0 File Offset: 0x003C54D0
			// (set) Token: 0x0601035A RID: 66394 RVA: 0x0008D0BA File Offset: 0x0008B2BA
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B7 RID: 21687
			// (get) Token: 0x0601035B RID: 66395 RVA: 0x003C72F8 File Offset: 0x003C54F8
			// (set) Token: 0x0601035C RID: 66396 RVA: 0x0008D0CC File Offset: 0x0008B2CC
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B8 RID: 21688
			// (get) Token: 0x0601035D RID: 66397 RVA: 0x003C7320 File Offset: 0x003C5520
			// (set) Token: 0x0601035E RID: 66398 RVA: 0x0008D0DE File Offset: 0x0008B2DE
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054B9 RID: 21689
			// (get) Token: 0x0601035F RID: 66399 RVA: 0x003C7348 File Offset: 0x003C5548
			// (set) Token: 0x06010360 RID: 66400 RVA: 0x0008D0F0 File Offset: 0x0008B2F0
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BA RID: 21690
			// (get) Token: 0x06010361 RID: 66401 RVA: 0x003C7370 File Offset: 0x003C5570
			// (set) Token: 0x06010362 RID: 66402 RVA: 0x0008D102 File Offset: 0x0008B302
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BB RID: 21691
			// (get) Token: 0x06010363 RID: 66403 RVA: 0x003C7398 File Offset: 0x003C5598
			// (set) Token: 0x06010364 RID: 66404 RVA: 0x0008D114 File Offset: 0x0008B314
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BC RID: 21692
			// (get) Token: 0x06010365 RID: 66405 RVA: 0x003C73C0 File Offset: 0x003C55C0
			// (set) Token: 0x06010366 RID: 66406 RVA: 0x0008D126 File Offset: 0x0008B326
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BD RID: 21693
			// (get) Token: 0x06010367 RID: 66407 RVA: 0x003C73E8 File Offset: 0x003C55E8
			// (set) Token: 0x06010368 RID: 66408 RVA: 0x0008D138 File Offset: 0x0008B338
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BE RID: 21694
			// (get) Token: 0x06010369 RID: 66409 RVA: 0x003C7410 File Offset: 0x003C5610
			// (set) Token: 0x0601036A RID: 66410 RVA: 0x0008D14A File Offset: 0x0008B34A
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054BF RID: 21695
			// (get) Token: 0x0601036B RID: 66411 RVA: 0x003C7438 File Offset: 0x003C5638
			// (set) Token: 0x0601036C RID: 66412 RVA: 0x0008D15C File Offset: 0x0008B35C
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C0 RID: 21696
			// (get) Token: 0x0601036D RID: 66413 RVA: 0x003C7460 File Offset: 0x003C5660
			// (set) Token: 0x0601036E RID: 66414 RVA: 0x0008D16E File Offset: 0x0008B36E
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C1 RID: 21697
			// (get) Token: 0x0601036F RID: 66415 RVA: 0x003C7488 File Offset: 0x003C5688
			// (set) Token: 0x06010370 RID: 66416 RVA: 0x0008D180 File Offset: 0x0008B380
			public unsafe static Func<UniversalGameManager, AssetReference> __9__102_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniversalGameManager, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__102_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C2 RID: 21698
			// (get) Token: 0x06010371 RID: 66417 RVA: 0x003C74B0 File Offset: 0x003C56B0
			// (set) Token: 0x06010372 RID: 66418 RVA: 0x0008D192 File Offset: 0x0008B392
			public unsafe static Action<int> __9__104_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__104_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C3 RID: 21699
			// (get) Token: 0x06010373 RID: 66419 RVA: 0x003C74D8 File Offset: 0x003C56D8
			// (set) Token: 0x06010374 RID: 66420 RVA: 0x0008D1A4 File Offset: 0x0008B3A4
			public unsafe static Func<InputActionReference, InputAction> __9__104_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__104_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InputActionReference, InputAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__104_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C4 RID: 21700
			// (get) Token: 0x06010375 RID: 66421 RVA: 0x003C7500 File Offset: 0x003C5700
			// (set) Token: 0x06010376 RID: 66422 RVA: 0x0008D1B6 File Offset: 0x0008B3B6
			public unsafe static Action __9__111_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__111_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__111_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C5 RID: 21701
			// (get) Token: 0x06010377 RID: 66423 RVA: 0x003C7528 File Offset: 0x003C5728
			// (set) Token: 0x06010378 RID: 66424 RVA: 0x0008D1C8 File Offset: 0x0008B3C8
			public unsafe static Func<bool> __9__119_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__119_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__119_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C6 RID: 21702
			// (get) Token: 0x06010379 RID: 66425 RVA: 0x003C7550 File Offset: 0x003C5750
			// (set) Token: 0x0601037A RID: 66426 RVA: 0x0008D1DA File Offset: 0x0008B3DA
			public unsafe static Predicate<UIPanelBaseImpl> __9__153_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__153_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<UIPanelBaseImpl>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__153_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054C7 RID: 21703
			// (get) Token: 0x0601037B RID: 66427 RVA: 0x003C7578 File Offset: 0x003C5778
			// (set) Token: 0x0601037C RID: 66428 RVA: 0x0008D1EC File Offset: 0x0008B3EC
			public unsafe static Predicate<UIPanelBaseImpl> __9__154_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__154_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<UIPanelBaseImpl>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalGameManager.__c.NativeFieldInfoPtr___9__154_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A464 RID: 42084
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A465 RID: 42085
			private static readonly IntPtr NativeFieldInfoPtr___9__102_2;

			// Token: 0x0400A466 RID: 42086
			private static readonly IntPtr NativeFieldInfoPtr___9__102_3;

			// Token: 0x0400A467 RID: 42087
			private static readonly IntPtr NativeFieldInfoPtr___9__102_4;

			// Token: 0x0400A468 RID: 42088
			private static readonly IntPtr NativeFieldInfoPtr___9__102_5;

			// Token: 0x0400A469 RID: 42089
			private static readonly IntPtr NativeFieldInfoPtr___9__102_6;

			// Token: 0x0400A46A RID: 42090
			private static readonly IntPtr NativeFieldInfoPtr___9__102_7;

			// Token: 0x0400A46B RID: 42091
			private static readonly IntPtr NativeFieldInfoPtr___9__102_8;

			// Token: 0x0400A46C RID: 42092
			private static readonly IntPtr NativeFieldInfoPtr___9__102_9;

			// Token: 0x0400A46D RID: 42093
			private static readonly IntPtr NativeFieldInfoPtr___9__102_10;

			// Token: 0x0400A46E RID: 42094
			private static readonly IntPtr NativeFieldInfoPtr___9__102_11;

			// Token: 0x0400A46F RID: 42095
			private static readonly IntPtr NativeFieldInfoPtr___9__102_12;

			// Token: 0x0400A470 RID: 42096
			private static readonly IntPtr NativeFieldInfoPtr___9__102_13;

			// Token: 0x0400A471 RID: 42097
			private static readonly IntPtr NativeFieldInfoPtr___9__102_14;

			// Token: 0x0400A472 RID: 42098
			private static readonly IntPtr NativeFieldInfoPtr___9__104_0;

			// Token: 0x0400A473 RID: 42099
			private static readonly IntPtr NativeFieldInfoPtr___9__104_1;

			// Token: 0x0400A474 RID: 42100
			private static readonly IntPtr NativeFieldInfoPtr___9__111_2;

			// Token: 0x0400A475 RID: 42101
			private static readonly IntPtr NativeFieldInfoPtr___9__119_0;

			// Token: 0x0400A476 RID: 42102
			private static readonly IntPtr NativeFieldInfoPtr___9__153_0;

			// Token: 0x0400A477 RID: 42103
			private static readonly IntPtr NativeFieldInfoPtr___9__154_0;

			// Token: 0x0400A478 RID: 42104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A479 RID: 42105
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_2_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47A RID: 42106
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_3_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47B RID: 42107
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_4_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47C RID: 42108
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_5_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47D RID: 42109
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_6_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47E RID: 42110
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_7_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A47F RID: 42111
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_8_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A480 RID: 42112
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_9_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A481 RID: 42113
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_10_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A482 RID: 42114
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_11_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A483 RID: 42115
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_12_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A484 RID: 42116
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_13_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A485 RID: 42117
			private static readonly IntPtr NativeMethodInfoPtr__PreLoadCommonPanelParent_b__102_14_Internal_AssetReference_UniversalGameManager_0;

			// Token: 0x0400A486 RID: 42118
			private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__104_0_Internal_Void_Int32_0;

			// Token: 0x0400A487 RID: 42119
			private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__104_1_Internal_InputAction_InputActionReference_0;

			// Token: 0x0400A488 RID: 42120
			private static readonly IntPtr NativeMethodInfoPtr__LoadScene_b__111_2_Internal_Void_0;

			// Token: 0x0400A489 RID: 42121
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuAsyncInternal_b__119_0_Internal_Boolean_0;

			// Token: 0x0400A48A RID: 42122
			private static readonly IntPtr NativeMethodInfoPtr__TryCleanThenAddBufferedPanelPrefab_b__153_0_Internal_Boolean_UIPanelBaseImpl_0;

			// Token: 0x0400A48B RID: 42123
			private static readonly IntPtr NativeMethodInfoPtr__ClearAllBufferedPanelOfGroup_b__154_0_Internal_Boolean_UIPanelBaseImpl_0;
		}

		// Token: 0x02000E13 RID: 3603
		[ObfuscatedName("Common.UI.UniversalGameManager+<PreLoadCommonPanelParent>d__102")]
		public sealed class _PreLoadCommonPanelParent_d__102 : ValueType
		{
			// Token: 0x0601037D RID: 66429 RVA: 0x003C75A0 File Offset: 0x003C57A0
			// Note: this type is marked as 'beforefieldinit'.
			static _PreLoadCommonPanelParent_d__102()
			{
				Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<PreLoadCommonPanelParent>d__102");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr);
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>1__state");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__gameObjectTask_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<gameObjectTask>5__2");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelTask_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<loadingIndicatorPanelTask>5__3");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelTask_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<noteBookMainPanelTask>5__4");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelTask_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<storageMainPanelTask>5__5");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelTask_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<escMainPanelTask>5__6");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelTask_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<escBindingSubPanelTask>5__7");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelTask_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<filterPanelTask>5__8");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelTask_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<dialogPanelTask>5__9");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelTask_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<multipleChoicePanelTask>5__10");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelTask_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<izakayaConfigPanelTask>5__11");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelTask_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<multipleGetProductsPanelTask>5__12");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__generalErrorPanelTask_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<generalErrorPanelTask>5__13");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__rewindDialogPackageHandle_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<rewindDialogPackageHandle>5__14");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__levelUpEffectHandle_5__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<levelUpEffectHandle>5__15");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelHandle_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<loadingIndicatorPanelHandle>5__16");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelHandle_5__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<noteBookMainPanelHandle>5__17");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelHandle_5__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<storageMainPanelHandle>5__18");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelHandle_5__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<escMainPanelHandle>5__19");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelHandle_5__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<escBindingSubPanelHandle>5__20");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelHandle_5__21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<filterPanelHandle>5__21");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelHandle_5__22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<dialogPanelHandle>5__22");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelHandle_5__23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<multipleChoicePanelHandle>5__23");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelHandle_5__24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<izakayaConfigPanelHandle>5__24");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelHandle_5__25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<multipleGetProductsPanelHandle>5__25");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__1");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__2");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__3");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__4");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__5");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__6");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__7");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__8");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__9");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__10");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__11");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__12");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, "<>u__13");
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, 100684530);
				UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr, 100684531);
			}

			// Token: 0x0601037E RID: 66430 RVA: 0x003C7900 File Offset: 0x003C5B00
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 259877, RefRangeEnd = 259879, XrefRangeStart = 259092, XrefRangeEnd = 259877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601037F RID: 66431 RVA: 0x003C7938 File Offset: 0x003C5B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010380 RID: 66432 RVA: 0x0008D1FE File Offset: 0x0008B3FE
			public _PreLoadCommonPanelParent_d__102(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010381 RID: 66433 RVA: 0x0008D207 File Offset: 0x0008B407
			public _PreLoadCommonPanelParent_d__102() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._PreLoadCommonPanelParent_d__102>.NativeClassPtr))
			{
			}

			// Token: 0x170054C8 RID: 21704
			// (get) Token: 0x06010382 RID: 66434 RVA: 0x003C7980 File Offset: 0x003C5B80
			// (set) Token: 0x06010383 RID: 66435 RVA: 0x0008D219 File Offset: 0x0008B419
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170054C9 RID: 21705
			// (get) Token: 0x06010384 RID: 66436 RVA: 0x003C79A8 File Offset: 0x003C5BA8
			// (set) Token: 0x06010385 RID: 66437 RVA: 0x0008D234 File Offset: 0x0008B434
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CA RID: 21706
			// (get) Token: 0x06010386 RID: 66438 RVA: 0x003C79D8 File Offset: 0x003C5BD8
			// (set) Token: 0x06010387 RID: 66439 RVA: 0x0008D262 File Offset: 0x0008B462
			public UniTask<IAssetHandle<GameObject>> _gameObjectTask_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__gameObjectTask_5__2);
					return new UniTask<IAssetHandle<GameObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__gameObjectTask_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CB RID: 21707
			// (get) Token: 0x06010388 RID: 66440 RVA: 0x003C7A08 File Offset: 0x003C5C08
			// (set) Token: 0x06010389 RID: 66441 RVA: 0x0008D290 File Offset: 0x0008B490
			public UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>> _loadingIndicatorPanelTask_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelTask_5__3);
					return new UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelTask_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CC RID: 21708
			// (get) Token: 0x0601038A RID: 66442 RVA: 0x003C7A38 File Offset: 0x003C5C38
			// (set) Token: 0x0601038B RID: 66443 RVA: 0x0008D2BE File Offset: 0x0008B4BE
			public UniTask<IGameObjectAssetHandle<NoteBookMainPannel>> _noteBookMainPanelTask_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelTask_5__4);
					return new UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelTask_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CD RID: 21709
			// (get) Token: 0x0601038C RID: 66444 RVA: 0x003C7A68 File Offset: 0x003C5C68
			// (set) Token: 0x0601038D RID: 66445 RVA: 0x0008D2EC File Offset: 0x0008B4EC
			public UniTask<IGameObjectAssetHandle<StorageMainPannel>> _storageMainPanelTask_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelTask_5__5);
					return new UniTask<IGameObjectAssetHandle<StorageMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<StorageMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelTask_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<StorageMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CE RID: 21710
			// (get) Token: 0x0601038E RID: 66446 RVA: 0x003C7A98 File Offset: 0x003C5C98
			// (set) Token: 0x0601038F RID: 66447 RVA: 0x0008D31A File Offset: 0x0008B51A
			public UniTask<IGameObjectAssetHandle<EscMainPannel>> _escMainPanelTask_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelTask_5__6);
					return new UniTask<IGameObjectAssetHandle<EscMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelTask_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054CF RID: 21711
			// (get) Token: 0x06010390 RID: 66448 RVA: 0x003C7AC8 File Offset: 0x003C5CC8
			// (set) Token: 0x06010391 RID: 66449 RVA: 0x0008D348 File Offset: 0x0008B548
			public UniTask<IGameObjectAssetHandle<EscBindingSubPannel>> _escBindingSubPanelTask_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelTask_5__7);
					return new UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelTask_5__7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D0 RID: 21712
			// (get) Token: 0x06010392 RID: 66450 RVA: 0x003C7AF8 File Offset: 0x003C5CF8
			// (set) Token: 0x06010393 RID: 66451 RVA: 0x0008D376 File Offset: 0x0008B576
			public UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>> _filterPanelTask_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelTask_5__8);
					return new UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelTask_5__8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D1 RID: 21713
			// (get) Token: 0x06010394 RID: 66452 RVA: 0x003C7B28 File Offset: 0x003C5D28
			// (set) Token: 0x06010395 RID: 66453 RVA: 0x0008D3A4 File Offset: 0x0008B5A4
			public UniTask<IGameObjectAssetHandle<DialogPannel>> _dialogPanelTask_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelTask_5__9);
					return new UniTask<IGameObjectAssetHandle<DialogPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DialogPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelTask_5__9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DialogPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D2 RID: 21714
			// (get) Token: 0x06010396 RID: 66454 RVA: 0x003C7B58 File Offset: 0x003C5D58
			// (set) Token: 0x06010397 RID: 66455 RVA: 0x0008D3D2 File Offset: 0x0008B5D2
			public UniTask<IGameObjectAssetHandle<MultipleChoicePannel>> _multipleChoicePanelTask_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelTask_5__10);
					return new UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelTask_5__10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D3 RID: 21715
			// (get) Token: 0x06010398 RID: 66456 RVA: 0x003C7B88 File Offset: 0x003C5D88
			// (set) Token: 0x06010399 RID: 66457 RVA: 0x0008D400 File Offset: 0x0008B600
			public UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>> _izakayaConfigPanelTask_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelTask_5__11);
					return new UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelTask_5__11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D4 RID: 21716
			// (get) Token: 0x0601039A RID: 66458 RVA: 0x003C7BB8 File Offset: 0x003C5DB8
			// (set) Token: 0x0601039B RID: 66459 RVA: 0x0008D42E File Offset: 0x0008B62E
			public UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>> _multipleGetProductsPanelTask_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelTask_5__12);
					return new UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelTask_5__12), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D5 RID: 21717
			// (get) Token: 0x0601039C RID: 66460 RVA: 0x003C7BE8 File Offset: 0x003C5DE8
			// (set) Token: 0x0601039D RID: 66461 RVA: 0x0008D45C File Offset: 0x0008B65C
			public UniTask<IGameObjectAssetHandle<GenericErrorPanel>> _generalErrorPanelTask_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__generalErrorPanelTask_5__13);
					return new UniTask<IGameObjectAssetHandle<GenericErrorPanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<GenericErrorPanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__generalErrorPanelTask_5__13), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<GenericErrorPanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054D6 RID: 21718
			// (get) Token: 0x0601039E RID: 66462 RVA: 0x003C7C18 File Offset: 0x003C5E18
			// (set) Token: 0x0601039F RID: 66463 RVA: 0x0008D48A File Offset: 0x0008B68A
			public unsafe IAssetHandle<DialogPackage> _rewindDialogPackageHandle_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__rewindDialogPackageHandle_5__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__rewindDialogPackageHandle_5__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054D7 RID: 21719
			// (get) Token: 0x060103A0 RID: 66464 RVA: 0x003C7C48 File Offset: 0x003C5E48
			// (set) Token: 0x060103A1 RID: 66465 RVA: 0x0008D4A9 File Offset: 0x0008B6A9
			public unsafe IAssetHandle<GameObject> _levelUpEffectHandle_5__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__levelUpEffectHandle_5__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__levelUpEffectHandle_5__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054D8 RID: 21720
			// (get) Token: 0x060103A2 RID: 66466 RVA: 0x003C7C78 File Offset: 0x003C5E78
			// (set) Token: 0x060103A3 RID: 66467 RVA: 0x0008D4C8 File Offset: 0x0008B6C8
			public unsafe IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel> _loadingIndicatorPanelHandle_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelHandle_5__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__loadingIndicatorPanelHandle_5__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054D9 RID: 21721
			// (get) Token: 0x060103A4 RID: 66468 RVA: 0x003C7CA8 File Offset: 0x003C5EA8
			// (set) Token: 0x060103A5 RID: 66469 RVA: 0x0008D4E7 File Offset: 0x0008B6E7
			public unsafe IGameObjectAssetHandle<NoteBookMainPannel> _noteBookMainPanelHandle_5__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelHandle_5__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<NoteBookMainPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__noteBookMainPanelHandle_5__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DA RID: 21722
			// (get) Token: 0x060103A6 RID: 66470 RVA: 0x003C7CD8 File Offset: 0x003C5ED8
			// (set) Token: 0x060103A7 RID: 66471 RVA: 0x0008D506 File Offset: 0x0008B706
			public unsafe IGameObjectAssetHandle<StorageMainPannel> _storageMainPanelHandle_5__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelHandle_5__18);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<StorageMainPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__storageMainPanelHandle_5__18), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DB RID: 21723
			// (get) Token: 0x060103A8 RID: 66472 RVA: 0x003C7D08 File Offset: 0x003C5F08
			// (set) Token: 0x060103A9 RID: 66473 RVA: 0x0008D525 File Offset: 0x0008B725
			public unsafe IGameObjectAssetHandle<EscMainPannel> _escMainPanelHandle_5__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelHandle_5__19);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<EscMainPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escMainPanelHandle_5__19), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DC RID: 21724
			// (get) Token: 0x060103AA RID: 66474 RVA: 0x003C7D38 File Offset: 0x003C5F38
			// (set) Token: 0x060103AB RID: 66475 RVA: 0x0008D544 File Offset: 0x0008B744
			public unsafe IGameObjectAssetHandle<EscBindingSubPannel> _escBindingSubPanelHandle_5__20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelHandle_5__20);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<EscBindingSubPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__escBindingSubPanelHandle_5__20), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DD RID: 21725
			// (get) Token: 0x060103AC RID: 66476 RVA: 0x003C7D68 File Offset: 0x003C5F68
			// (set) Token: 0x060103AD RID: 66477 RVA: 0x0008D563 File Offset: 0x0008B763
			public unsafe IGameObjectAssetHandle<FlattenedFilterPanel> _filterPanelHandle_5__21
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelHandle_5__21);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<FlattenedFilterPanel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__filterPanelHandle_5__21), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DE RID: 21726
			// (get) Token: 0x060103AE RID: 66478 RVA: 0x003C7D98 File Offset: 0x003C5F98
			// (set) Token: 0x060103AF RID: 66479 RVA: 0x0008D582 File Offset: 0x0008B782
			public unsafe IGameObjectAssetHandle<DialogPannel> _dialogPanelHandle_5__22
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelHandle_5__22);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<DialogPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__dialogPanelHandle_5__22), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054DF RID: 21727
			// (get) Token: 0x060103B0 RID: 66480 RVA: 0x003C7DC8 File Offset: 0x003C5FC8
			// (set) Token: 0x060103B1 RID: 66481 RVA: 0x0008D5A1 File Offset: 0x0008B7A1
			public unsafe IGameObjectAssetHandle<MultipleChoicePannel> _multipleChoicePanelHandle_5__23
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelHandle_5__23);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<MultipleChoicePannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleChoicePanelHandle_5__23), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054E0 RID: 21728
			// (get) Token: 0x060103B2 RID: 66482 RVA: 0x003C7DF8 File Offset: 0x003C5FF8
			// (set) Token: 0x060103B3 RID: 66483 RVA: 0x0008D5C0 File Offset: 0x0008B7C0
			public unsafe IGameObjectAssetHandle<IzakayaConfigPannel> _izakayaConfigPanelHandle_5__24
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelHandle_5__24);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<IzakayaConfigPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__izakayaConfigPanelHandle_5__24), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054E1 RID: 21729
			// (get) Token: 0x060103B4 RID: 66484 RVA: 0x003C7E28 File Offset: 0x003C6028
			// (set) Token: 0x060103B5 RID: 66485 RVA: 0x0008D5DF File Offset: 0x0008B7DF
			public unsafe IGameObjectAssetHandle<MultipleGetProductsPanel> _multipleGetProductsPanelHandle_5__25
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelHandle_5__25);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<MultipleGetProductsPanel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr__multipleGetProductsPanelHandle_5__25), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054E2 RID: 21730
			// (get) Token: 0x060103B6 RID: 66486 RVA: 0x003C7E58 File Offset: 0x003C6058
			// (set) Token: 0x060103B7 RID: 66487 RVA: 0x0008D5FE File Offset: 0x0008B7FE
			public UniTask<IAssetHandle<DialogPackage>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<DialogPackage>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E3 RID: 21731
			// (get) Token: 0x060103B8 RID: 66488 RVA: 0x003C7E88 File Offset: 0x003C6088
			// (set) Token: 0x060103B9 RID: 66489 RVA: 0x0008D62C File Offset: 0x0008B82C
			public UniTask<IAssetHandle<GameObject>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__2);
					return new UniTask<IAssetHandle<GameObject>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E4 RID: 21732
			// (get) Token: 0x060103BA RID: 66490 RVA: 0x003C7EB8 File Offset: 0x003C60B8
			// (set) Token: 0x060103BB RID: 66491 RVA: 0x0008D65A File Offset: 0x0008B85A
			public UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__3);
					return new UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<AdpBuiltinInputBlockerPanel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E5 RID: 21733
			// (get) Token: 0x060103BC RID: 66492 RVA: 0x003C7EE8 File Offset: 0x003C60E8
			// (set) Token: 0x060103BD RID: 66493 RVA: 0x0008D688 File Offset: 0x0008B888
			public UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>.Awaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__4);
					return new UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<NoteBookMainPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E6 RID: 21734
			// (get) Token: 0x060103BE RID: 66494 RVA: 0x003C7F18 File Offset: 0x003C6118
			// (set) Token: 0x060103BF RID: 66495 RVA: 0x0008D6B6 File Offset: 0x0008B8B6
			public UniTask<IGameObjectAssetHandle<StorageMainPannel>>.Awaiter __u__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__5);
					return new UniTask<IGameObjectAssetHandle<StorageMainPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<StorageMainPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<StorageMainPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E7 RID: 21735
			// (get) Token: 0x060103C0 RID: 66496 RVA: 0x003C7F48 File Offset: 0x003C6148
			// (set) Token: 0x060103C1 RID: 66497 RVA: 0x0008D6E4 File Offset: 0x0008B8E4
			public UniTask<IGameObjectAssetHandle<EscMainPannel>>.Awaiter __u__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__6);
					return new UniTask<IGameObjectAssetHandle<EscMainPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscMainPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscMainPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E8 RID: 21736
			// (get) Token: 0x060103C2 RID: 66498 RVA: 0x003C7F78 File Offset: 0x003C6178
			// (set) Token: 0x060103C3 RID: 66499 RVA: 0x0008D712 File Offset: 0x0008B912
			public UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>.Awaiter __u__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__7);
					return new UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<EscBindingSubPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054E9 RID: 21737
			// (get) Token: 0x060103C4 RID: 66500 RVA: 0x003C7FA8 File Offset: 0x003C61A8
			// (set) Token: 0x060103C5 RID: 66501 RVA: 0x0008D740 File Offset: 0x0008B940
			public UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>.Awaiter __u__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__8);
					return new UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<FlattenedFilterPanel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054EA RID: 21738
			// (get) Token: 0x060103C6 RID: 66502 RVA: 0x003C7FD8 File Offset: 0x003C61D8
			// (set) Token: 0x060103C7 RID: 66503 RVA: 0x0008D76E File Offset: 0x0008B96E
			public UniTask<IGameObjectAssetHandle<DialogPannel>>.Awaiter __u__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__9);
					return new UniTask<IGameObjectAssetHandle<DialogPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DialogPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<DialogPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054EB RID: 21739
			// (get) Token: 0x060103C8 RID: 66504 RVA: 0x003C8008 File Offset: 0x003C6208
			// (set) Token: 0x060103C9 RID: 66505 RVA: 0x0008D79C File Offset: 0x0008B99C
			public UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>.Awaiter __u__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__10);
					return new UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleChoicePannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054EC RID: 21740
			// (get) Token: 0x060103CA RID: 66506 RVA: 0x003C8038 File Offset: 0x003C6238
			// (set) Token: 0x060103CB RID: 66507 RVA: 0x0008D7CA File Offset: 0x0008B9CA
			public UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>.Awaiter __u__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__11);
					return new UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<IzakayaConfigPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054ED RID: 21741
			// (get) Token: 0x060103CC RID: 66508 RVA: 0x003C8068 File Offset: 0x003C6268
			// (set) Token: 0x060103CD RID: 66509 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
			public UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>.Awaiter __u__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__12);
					return new UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__12), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<MultipleGetProductsPanel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054EE RID: 21742
			// (get) Token: 0x060103CE RID: 66510 RVA: 0x003C8098 File Offset: 0x003C6298
			// (set) Token: 0x060103CF RID: 66511 RVA: 0x0008D826 File Offset: 0x0008BA26
			public UniTask<IGameObjectAssetHandle<GenericErrorPanel>>.Awaiter __u__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__13);
					return new UniTask<IGameObjectAssetHandle<GenericErrorPanel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<GenericErrorPanel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._PreLoadCommonPanelParent_d__102.NativeFieldInfoPtr___u__13), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<GenericErrorPanel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A48C RID: 42124
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A48D RID: 42125
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A48E RID: 42126
			private static readonly IntPtr NativeFieldInfoPtr__gameObjectTask_5__2;

			// Token: 0x0400A48F RID: 42127
			private static readonly IntPtr NativeFieldInfoPtr__loadingIndicatorPanelTask_5__3;

			// Token: 0x0400A490 RID: 42128
			private static readonly IntPtr NativeFieldInfoPtr__noteBookMainPanelTask_5__4;

			// Token: 0x0400A491 RID: 42129
			private static readonly IntPtr NativeFieldInfoPtr__storageMainPanelTask_5__5;

			// Token: 0x0400A492 RID: 42130
			private static readonly IntPtr NativeFieldInfoPtr__escMainPanelTask_5__6;

			// Token: 0x0400A493 RID: 42131
			private static readonly IntPtr NativeFieldInfoPtr__escBindingSubPanelTask_5__7;

			// Token: 0x0400A494 RID: 42132
			private static readonly IntPtr NativeFieldInfoPtr__filterPanelTask_5__8;

			// Token: 0x0400A495 RID: 42133
			private static readonly IntPtr NativeFieldInfoPtr__dialogPanelTask_5__9;

			// Token: 0x0400A496 RID: 42134
			private static readonly IntPtr NativeFieldInfoPtr__multipleChoicePanelTask_5__10;

			// Token: 0x0400A497 RID: 42135
			private static readonly IntPtr NativeFieldInfoPtr__izakayaConfigPanelTask_5__11;

			// Token: 0x0400A498 RID: 42136
			private static readonly IntPtr NativeFieldInfoPtr__multipleGetProductsPanelTask_5__12;

			// Token: 0x0400A499 RID: 42137
			private static readonly IntPtr NativeFieldInfoPtr__generalErrorPanelTask_5__13;

			// Token: 0x0400A49A RID: 42138
			private static readonly IntPtr NativeFieldInfoPtr__rewindDialogPackageHandle_5__14;

			// Token: 0x0400A49B RID: 42139
			private static readonly IntPtr NativeFieldInfoPtr__levelUpEffectHandle_5__15;

			// Token: 0x0400A49C RID: 42140
			private static readonly IntPtr NativeFieldInfoPtr__loadingIndicatorPanelHandle_5__16;

			// Token: 0x0400A49D RID: 42141
			private static readonly IntPtr NativeFieldInfoPtr__noteBookMainPanelHandle_5__17;

			// Token: 0x0400A49E RID: 42142
			private static readonly IntPtr NativeFieldInfoPtr__storageMainPanelHandle_5__18;

			// Token: 0x0400A49F RID: 42143
			private static readonly IntPtr NativeFieldInfoPtr__escMainPanelHandle_5__19;

			// Token: 0x0400A4A0 RID: 42144
			private static readonly IntPtr NativeFieldInfoPtr__escBindingSubPanelHandle_5__20;

			// Token: 0x0400A4A1 RID: 42145
			private static readonly IntPtr NativeFieldInfoPtr__filterPanelHandle_5__21;

			// Token: 0x0400A4A2 RID: 42146
			private static readonly IntPtr NativeFieldInfoPtr__dialogPanelHandle_5__22;

			// Token: 0x0400A4A3 RID: 42147
			private static readonly IntPtr NativeFieldInfoPtr__multipleChoicePanelHandle_5__23;

			// Token: 0x0400A4A4 RID: 42148
			private static readonly IntPtr NativeFieldInfoPtr__izakayaConfigPanelHandle_5__24;

			// Token: 0x0400A4A5 RID: 42149
			private static readonly IntPtr NativeFieldInfoPtr__multipleGetProductsPanelHandle_5__25;

			// Token: 0x0400A4A6 RID: 42150
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4A7 RID: 42151
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400A4A8 RID: 42152
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400A4A9 RID: 42153
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x0400A4AA RID: 42154
			private static readonly IntPtr NativeFieldInfoPtr___u__5;

			// Token: 0x0400A4AB RID: 42155
			private static readonly IntPtr NativeFieldInfoPtr___u__6;

			// Token: 0x0400A4AC RID: 42156
			private static readonly IntPtr NativeFieldInfoPtr___u__7;

			// Token: 0x0400A4AD RID: 42157
			private static readonly IntPtr NativeFieldInfoPtr___u__8;

			// Token: 0x0400A4AE RID: 42158
			private static readonly IntPtr NativeFieldInfoPtr___u__9;

			// Token: 0x0400A4AF RID: 42159
			private static readonly IntPtr NativeFieldInfoPtr___u__10;

			// Token: 0x0400A4B0 RID: 42160
			private static readonly IntPtr NativeFieldInfoPtr___u__11;

			// Token: 0x0400A4B1 RID: 42161
			private static readonly IntPtr NativeFieldInfoPtr___u__12;

			// Token: 0x0400A4B2 RID: 42162
			private static readonly IntPtr NativeFieldInfoPtr___u__13;

			// Token: 0x0400A4B3 RID: 42163
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4B4 RID: 42164
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E14 RID: 3604
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass111_0")]
		public sealed class __c__DisplayClass111_0 : Il2CppSystem.Object
		{
			// Token: 0x060103D0 RID: 66512 RVA: 0x003C80C8 File Offset: 0x003C62C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass111_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass111_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass111_0.NativeFieldInfoPtr_onFadeFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr, "onFadeFinishCallback");
				UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr, 100684532);
				UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr, 100684533);
				UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr__LoadScene_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr, 100684534);
			}

			// Token: 0x060103D1 RID: 66513 RVA: 0x003C8144 File Offset: 0x003C6344
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass111_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass111_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103D2 RID: 66514 RVA: 0x003C8180 File Offset: 0x003C6380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259879, XrefRangeEnd = 259903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103D3 RID: 66515 RVA: 0x003C81B4 File Offset: 0x003C63B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259903, XrefRangeEnd = 259990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadScene_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass111_0.NativeMethodInfoPtr__LoadScene_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103D4 RID: 66516 RVA: 0x0008D854 File Offset: 0x0008BA54
			public __c__DisplayClass111_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054EF RID: 21743
			// (get) Token: 0x060103D5 RID: 66517 RVA: 0x003C81E8 File Offset: 0x003C63E8
			// (set) Token: 0x060103D6 RID: 66518 RVA: 0x0008D85D File Offset: 0x0008BA5D
			public unsafe Action onFadeFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass111_0.NativeFieldInfoPtr_onFadeFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass111_0.NativeFieldInfoPtr_onFadeFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4B5 RID: 42165
			private static readonly IntPtr NativeFieldInfoPtr_onFadeFinishCallback;

			// Token: 0x0400A4B6 RID: 42166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4B7 RID: 42167
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A4B8 RID: 42168
			private static readonly IntPtr NativeMethodInfoPtr__LoadScene_b__1_Internal_Void_0;
		}

		// Token: 0x02000E15 RID: 3605
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x060103D7 RID: 66519 RVA: 0x003C8218 File Offset: 0x003C6418
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass112_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr, "onFinish");
				UniversalGameManager.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr, 100684535);
				UniversalGameManager.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr, 100684536);
			}

			// Token: 0x060103D8 RID: 66520 RVA: 0x003C8280 File Offset: 0x003C6480
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103D9 RID: 66521 RVA: 0x003C82BC File Offset: 0x003C64BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260008, XrefRangeEnd = 260013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060103DA RID: 66522 RVA: 0x0008D87C File Offset: 0x0008BA7C
			public __c__DisplayClass112_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054F0 RID: 21744
			// (get) Token: 0x060103DB RID: 66523 RVA: 0x003C82FC File Offset: 0x003C64FC
			// (set) Token: 0x060103DC RID: 66524 RVA: 0x0008D885 File Offset: 0x0008BA85
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4B9 RID: 42169
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400A4BA RID: 42170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4BB RID: 42171
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x020010AE RID: 4270
			[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass112_0+<<WaitUntilAllPannelClosed>g__Process|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601229D RID: 74397 RVA: 0x00424A08 File Offset: 0x00422C08
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0>.NativeClassPtr, "<<WaitUntilAllPannelClosed>g__Process|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684537);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684538);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684539);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684540);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684541);
					UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684542);
				}

				// Token: 0x0601229E RID: 74398 RVA: 0x00424AE8 File Offset: 0x00422CE8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601229F RID: 74399 RVA: 0x00424B30 File Offset: 0x00422D30
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122A0 RID: 74400 RVA: 0x00424B64 File Offset: 0x00422D64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259990, XrefRangeEnd = 260002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F00 RID: 24320
				// (get) Token: 0x060122A1 RID: 74401 RVA: 0x00424BA0 File Offset: 0x00422DA0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122A2 RID: 74402 RVA: 0x00424BE0 File Offset: 0x00422DE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260002, XrefRangeEnd = 260008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F01 RID: 24321
				// (get) Token: 0x060122A3 RID: 74403 RVA: 0x00424C14 File Offset: 0x00422E14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060122A4 RID: 74404 RVA: 0x0009DADA File Offset: 0x0009BCDA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EFD RID: 24317
				// (get) Token: 0x060122A5 RID: 74405 RVA: 0x00424C54 File Offset: 0x00422E54
				// (set) Token: 0x060122A6 RID: 74406 RVA: 0x0009DAE3 File Offset: 0x0009BCE3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005EFE RID: 24318
				// (get) Token: 0x060122A7 RID: 74407 RVA: 0x00424C7C File Offset: 0x00422E7C
				// (set) Token: 0x060122A8 RID: 74408 RVA: 0x0009DAFE File Offset: 0x0009BCFE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EFF RID: 24319
				// (get) Token: 0x060122A9 RID: 74409 RVA: 0x00424CAC File Offset: 0x00422EAC
				// (set) Token: 0x060122AA RID: 74410 RVA: 0x0009DB1D File Offset: 0x0009BD1D
				public unsafe UniversalGameManager.__c__DisplayClass112_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGameManager.__c__DisplayClass112_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B822 RID: 47138
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B823 RID: 47139
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B824 RID: 47140
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B825 RID: 47141
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B826 RID: 47142
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B827 RID: 47143
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B828 RID: 47144
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B829 RID: 47145
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B82A RID: 47146
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000E16 RID: 3606
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass115_0")]
		public sealed class __c__DisplayClass115_0 : Il2CppSystem.Object
		{
			// Token: 0x060103DD RID: 66525 RVA: 0x003C832C File Offset: 0x003C652C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass115_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass115_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass115_0.NativeFieldInfoPtr_iPostExtraChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr, "iPostExtraChecker");
				UniversalGameManager.__c__DisplayClass115_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr, 100684543);
				UniversalGameManager.__c__DisplayClass115_0.NativeMethodInfoPtr__OpenIzakayaConfigMenuAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr, 100684544);
			}

			// Token: 0x060103DE RID: 66526 RVA: 0x003C8394 File Offset: 0x003C6594
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass115_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass115_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass115_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103DF RID: 66527 RVA: 0x003C83D0 File Offset: 0x003C65D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260013, XrefRangeEnd = 260017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenIzakayaConfigMenuAsync_b__0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass115_0.NativeMethodInfoPtr__OpenIzakayaConfigMenuAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103E0 RID: 66528 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
			public __c__DisplayClass115_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054F1 RID: 21745
			// (get) Token: 0x060103E1 RID: 66529 RVA: 0x003C8414 File Offset: 0x003C6614
			// (set) Token: 0x060103E2 RID: 66530 RVA: 0x0008D8AD File Offset: 0x0008BAAD
			public unsafe IPostExtraChecker iPostExtraChecker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass115_0.NativeFieldInfoPtr_iPostExtraChecker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPostExtraChecker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass115_0.NativeFieldInfoPtr_iPostExtraChecker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4BC RID: 42172
			private static readonly IntPtr NativeFieldInfoPtr_iPostExtraChecker;

			// Token: 0x0400A4BD RID: 42173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4BE RID: 42174
			private static readonly IntPtr NativeMethodInfoPtr__OpenIzakayaConfigMenuAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x02000E17 RID: 3607
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass116_0")]
		public sealed class __c__DisplayClass116_0 : Il2CppSystem.Object
		{
			// Token: 0x060103E3 RID: 66531 RVA: 0x003C8444 File Offset: 0x003C6644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass116_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass116_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass116_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr, 100684545);
				UniversalGameManager.__c__DisplayClass116_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr, 100684546);
			}

			// Token: 0x060103E4 RID: 66532 RVA: 0x003C84AC File Offset: 0x003C66AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass116_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass116_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103E5 RID: 66533 RVA: 0x003C84E8 File Offset: 0x003C66E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260017, XrefRangeEnd = 260026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass116_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103E6 RID: 66534 RVA: 0x0008D8CC File Offset: 0x0008BACC
			public __c__DisplayClass116_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054F2 RID: 21746
			// (get) Token: 0x060103E7 RID: 66535 RVA: 0x003C851C File Offset: 0x003C671C
			// (set) Token: 0x060103E8 RID: 66536 RVA: 0x0008D8D5 File Offset: 0x0008BAD5
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass116_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass116_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4BF RID: 42175
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4C0 RID: 42176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4C1 RID: 42177
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000E18 RID: 3608
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass117_0")]
		public sealed class __c__DisplayClass117_0 : Il2CppSystem.Object
		{
			// Token: 0x060103E9 RID: 66537 RVA: 0x003C854C File Offset: 0x003C674C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass117_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass117_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass117_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr, 100684547);
				UniversalGameManager.__c__DisplayClass117_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr, 100684548);
			}

			// Token: 0x060103EA RID: 66538 RVA: 0x003C85B4 File Offset: 0x003C67B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass117_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass117_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass117_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103EB RID: 66539 RVA: 0x003C85F0 File Offset: 0x003C67F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260026, XrefRangeEnd = 260035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass117_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103EC RID: 66540 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
			public __c__DisplayClass117_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170054F3 RID: 21747
			// (get) Token: 0x060103ED RID: 66541 RVA: 0x003C8624 File Offset: 0x003C6824
			// (set) Token: 0x060103EE RID: 66542 RVA: 0x0008D8FD File Offset: 0x0008BAFD
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass117_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass117_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4C2 RID: 42178
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4C3 RID: 42179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4C4 RID: 42180
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000E19 RID: 3609
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenDialogMenuAsyncInternal>d__119")]
		public sealed class _OpenDialogMenuAsyncInternal_d__119 : ValueType
		{
			// Token: 0x060103EF RID: 66543 RVA: 0x003C8654 File Offset: 0x003C6854
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDialogMenuAsyncInternal_d__119()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenDialogMenuAsyncInternal>d__119");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr);
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "dialogPackage");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_overrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "overrideReplaceTextCallback");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr__handle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "<handle>5__2");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, "<>u__2");
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, 100684549);
				UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr, 100684550);
			}

			// Token: 0x060103F0 RID: 66544 RVA: 0x003C875C File Offset: 0x003C695C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260141, RefRangeEnd = 260143, XrefRangeStart = 260035, XrefRangeEnd = 260141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103F1 RID: 66545 RVA: 0x003C8794 File Offset: 0x003C6994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060103F2 RID: 66546 RVA: 0x0008D91C File Offset: 0x0008BB1C
			public _OpenDialogMenuAsyncInternal_d__119(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060103F3 RID: 66547 RVA: 0x0008D925 File Offset: 0x0008BB25
			public _OpenDialogMenuAsyncInternal_d__119() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuAsyncInternal_d__119>.NativeClassPtr))
			{
			}

			// Token: 0x170054F4 RID: 21748
			// (get) Token: 0x060103F4 RID: 66548 RVA: 0x003C87DC File Offset: 0x003C69DC
			// (set) Token: 0x060103F5 RID: 66549 RVA: 0x0008D937 File Offset: 0x0008BB37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170054F5 RID: 21749
			// (get) Token: 0x060103F6 RID: 66550 RVA: 0x003C8804 File Offset: 0x003C6A04
			// (set) Token: 0x060103F7 RID: 66551 RVA: 0x0008D952 File Offset: 0x0008BB52
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054F6 RID: 21750
			// (get) Token: 0x060103F8 RID: 66552 RVA: 0x003C8834 File Offset: 0x003C6A34
			// (set) Token: 0x060103F9 RID: 66553 RVA: 0x0008D980 File Offset: 0x0008BB80
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054F7 RID: 21751
			// (get) Token: 0x060103FA RID: 66554 RVA: 0x003C8864 File Offset: 0x003C6A64
			// (set) Token: 0x060103FB RID: 66555 RVA: 0x0008D99F File Offset: 0x0008BB9F
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054F8 RID: 21752
			// (get) Token: 0x060103FC RID: 66556 RVA: 0x003C8894 File Offset: 0x003C6A94
			// (set) Token: 0x060103FD RID: 66557 RVA: 0x0008D9BE File Offset: 0x0008BBBE
			public unsafe Action<Dictionary<int, string>> overrideReplaceTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_overrideReplaceTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_overrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170054F9 RID: 21753
			// (get) Token: 0x060103FE RID: 66558 RVA: 0x003C88C4 File Offset: 0x003C6AC4
			// (set) Token: 0x060103FF RID: 66559 RVA: 0x0008D9DD File Offset: 0x0008BBDD
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x170054FA RID: 21754
			// (get) Token: 0x06010400 RID: 66560 RVA: 0x003C88EC File Offset: 0x003C6AEC
			// (set) Token: 0x06010401 RID: 66561 RVA: 0x0008D9F8 File Offset: 0x0008BBF8
			public unsafe UniversalGameManager.IsolatedPanelTransformHandle _handle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr__handle_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr__handle_5__2)) = value;
				}
			}

			// Token: 0x170054FB RID: 21755
			// (get) Token: 0x06010402 RID: 66562 RVA: 0x003C8914 File Offset: 0x003C6B14
			// (set) Token: 0x06010403 RID: 66563 RVA: 0x0008DA13 File Offset: 0x0008BC13
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054FC RID: 21756
			// (get) Token: 0x06010404 RID: 66564 RVA: 0x003C8944 File Offset: 0x003C6B44
			// (set) Token: 0x06010405 RID: 66565 RVA: 0x0008DA41 File Offset: 0x0008BC41
			public UniTask<DialogPannel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__2);
					return new UniTask<DialogPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DialogPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuAsyncInternal_d__119.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DialogPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4C5 RID: 42181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4C6 RID: 42182
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4C7 RID: 42183
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x0400A4C8 RID: 42184
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4C9 RID: 42185
			private static readonly IntPtr NativeFieldInfoPtr_overrideReplaceTextCallback;

			// Token: 0x0400A4CA RID: 42186
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A4CB RID: 42187
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__2;

			// Token: 0x0400A4CC RID: 42188
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4CD RID: 42189
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400A4CE RID: 42190
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4CF RID: 42191
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1A RID: 3610
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenDialogMenuWithExitCodeAsyncInternal>d__121")]
		public sealed class _OpenDialogMenuWithExitCodeAsyncInternal_d__121 : ValueType
		{
			// Token: 0x06010406 RID: 66566 RVA: 0x003C8974 File Offset: 0x003C6B74
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDialogMenuWithExitCodeAsyncInternal_d__121()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenDialogMenuWithExitCodeAsyncInternal>d__121");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr);
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "dialogPackage");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_overrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "overrideReplaceTextCallback");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr__panelInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "<panelInstance>5__2");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, 100684551);
				UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr, 100684552);
			}

			// Token: 0x06010407 RID: 66567 RVA: 0x003C8A68 File Offset: 0x003C6C68
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260202, RefRangeEnd = 260204, XrefRangeStart = 260143, XrefRangeEnd = 260202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010408 RID: 66568 RVA: 0x003C8AA0 File Offset: 0x003C6CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010409 RID: 66569 RVA: 0x0008DA6F File Offset: 0x0008BC6F
			public _OpenDialogMenuWithExitCodeAsyncInternal_d__121(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601040A RID: 66570 RVA: 0x0008DA78 File Offset: 0x0008BC78
			public _OpenDialogMenuWithExitCodeAsyncInternal_d__121() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121>.NativeClassPtr))
			{
			}

			// Token: 0x170054FD RID: 21757
			// (get) Token: 0x0601040B RID: 66571 RVA: 0x003C8AE8 File Offset: 0x003C6CE8
			// (set) Token: 0x0601040C RID: 66572 RVA: 0x0008DA8A File Offset: 0x0008BC8A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170054FE RID: 21758
			// (get) Token: 0x0601040D RID: 66573 RVA: 0x003C8B10 File Offset: 0x003C6D10
			// (set) Token: 0x0601040E RID: 66574 RVA: 0x0008DAA5 File Offset: 0x0008BCA5
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170054FF RID: 21759
			// (get) Token: 0x0601040F RID: 66575 RVA: 0x003C8B40 File Offset: 0x003C6D40
			// (set) Token: 0x06010410 RID: 66576 RVA: 0x0008DAD3 File Offset: 0x0008BCD3
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005500 RID: 21760
			// (get) Token: 0x06010411 RID: 66577 RVA: 0x003C8B70 File Offset: 0x003C6D70
			// (set) Token: 0x06010412 RID: 66578 RVA: 0x0008DAF2 File Offset: 0x0008BCF2
			public unsafe Action<int> onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005501 RID: 21761
			// (get) Token: 0x06010413 RID: 66579 RVA: 0x003C8BA0 File Offset: 0x003C6DA0
			// (set) Token: 0x06010414 RID: 66580 RVA: 0x0008DB11 File Offset: 0x0008BD11
			public unsafe Action<Dictionary<int, string>> overrideReplaceTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_overrideReplaceTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_overrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005502 RID: 21762
			// (get) Token: 0x06010415 RID: 66581 RVA: 0x003C8BD0 File Offset: 0x003C6DD0
			// (set) Token: 0x06010416 RID: 66582 RVA: 0x0008DB30 File Offset: 0x0008BD30
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17005503 RID: 21763
			// (get) Token: 0x06010417 RID: 66583 RVA: 0x003C8BF8 File Offset: 0x003C6DF8
			// (set) Token: 0x06010418 RID: 66584 RVA: 0x0008DB4B File Offset: 0x0008BD4B
			public unsafe DialogPannel _panelInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr__panelInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr__panelInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005504 RID: 21764
			// (get) Token: 0x06010419 RID: 66585 RVA: 0x003C8C28 File Offset: 0x003C6E28
			// (set) Token: 0x0601041A RID: 66586 RVA: 0x0008DB6A File Offset: 0x0008BD6A
			public UniTask<DialogPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___u__1);
					return new UniTask<DialogPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DialogPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeAsyncInternal_d__121.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DialogPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4D0 RID: 42192
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4D1 RID: 42193
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4D2 RID: 42194
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x0400A4D3 RID: 42195
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4D4 RID: 42196
			private static readonly IntPtr NativeFieldInfoPtr_overrideReplaceTextCallback;

			// Token: 0x0400A4D5 RID: 42197
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A4D6 RID: 42198
			private static readonly IntPtr NativeFieldInfoPtr__panelInstance_5__2;

			// Token: 0x0400A4D7 RID: 42199
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4D8 RID: 42200
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4D9 RID: 42201
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1B RID: 3611
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenMultipleChoiceMenuAsyncInternal>d__125`1")]
		public sealed class _OpenMultipleChoiceMenuAsyncInternal_d__125<T> : ValueType
		{
			// Token: 0x0601041B RID: 66587 RVA: 0x003C8C58 File Offset: 0x003C6E58
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenMultipleChoiceMenuAsyncInternal_d__125()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenMultipleChoiceMenuAsyncInternal>d__125`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr);
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_openContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "openContext");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr__panelInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "<panelInstance>5__2");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, 100684553);
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr, 100684554);
			}

			// Token: 0x0601041C RID: 66588 RVA: 0x003C8D74 File Offset: 0x003C6F74
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260221, RefRangeEnd = 260223, XrefRangeStart = 260204, XrefRangeEnd = 260221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601041D RID: 66589 RVA: 0x003C8DAC File Offset: 0x003C6FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601041E RID: 66590 RVA: 0x0008DB98 File Offset: 0x0008BD98
			public _OpenMultipleChoiceMenuAsyncInternal_d__125(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601041F RID: 66591 RVA: 0x0008DBA1 File Offset: 0x0008BDA1
			public _OpenMultipleChoiceMenuAsyncInternal_d__125() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17005505 RID: 21765
			// (get) Token: 0x06010420 RID: 66592 RVA: 0x003C8DF4 File Offset: 0x003C6FF4
			// (set) Token: 0x06010421 RID: 66593 RVA: 0x0008DBB3 File Offset: 0x0008BDB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005506 RID: 21766
			// (get) Token: 0x06010422 RID: 66594 RVA: 0x003C8E1C File Offset: 0x003C701C
			// (set) Token: 0x06010423 RID: 66595 RVA: 0x0008DBCE File Offset: 0x0008BDCE
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005507 RID: 21767
			// (get) Token: 0x06010424 RID: 66596 RVA: 0x003C8E4C File Offset: 0x003C704C
			// (set) Token: 0x06010425 RID: 66597 RVA: 0x0008DBFC File Offset: 0x0008BDFC
			public MultipleChoicePannel.MultipleChoicePannelOpenContext openContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_openContext);
					return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_openContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005508 RID: 21768
			// (get) Token: 0x06010426 RID: 66598 RVA: 0x003C8E7C File Offset: 0x003C707C
			// (set) Token: 0x06010427 RID: 66599 RVA: 0x0008DC2A File Offset: 0x0008BE2A
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17005509 RID: 21769
			// (get) Token: 0x06010428 RID: 66600 RVA: 0x003C8EA4 File Offset: 0x003C70A4
			// (set) Token: 0x06010429 RID: 66601 RVA: 0x0008DC45 File Offset: 0x0008BE45
			public unsafe Action<Il2CppArrayBase<T>> onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700550A RID: 21770
			// (get) Token: 0x0601042A RID: 66602 RVA: 0x003C8ED4 File Offset: 0x003C70D4
			// (set) Token: 0x0601042B RID: 66603 RVA: 0x0008DC64 File Offset: 0x0008BE64
			public unsafe MultipleChoicePannel _panelInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr__panelInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr__panelInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700550B RID: 21771
			// (get) Token: 0x0601042C RID: 66604 RVA: 0x003C8F04 File Offset: 0x003C7104
			// (set) Token: 0x0601042D RID: 66605 RVA: 0x0008DC83 File Offset: 0x0008BE83
			public UniTask<MultipleChoicePannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___u__1);
					return new UniTask<MultipleChoicePannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<MultipleChoicePannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__125<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<MultipleChoicePannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4DA RID: 42202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4DB RID: 42203
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4DC RID: 42204
			private static readonly IntPtr NativeFieldInfoPtr_openContext;

			// Token: 0x0400A4DD RID: 42205
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A4DE RID: 42206
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4DF RID: 42207
			private static readonly IntPtr NativeFieldInfoPtr__panelInstance_5__2;

			// Token: 0x0400A4E0 RID: 42208
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4E1 RID: 42209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4E2 RID: 42210
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1C RID: 3612
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenMultipleChoiceMenuAsyncInternal>d__127`1")]
		public sealed class _OpenMultipleChoiceMenuAsyncInternal_d__127<T> : ValueType
		{
			// Token: 0x0601042E RID: 66606 RVA: 0x003C8F34 File Offset: 0x003C7134
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenMultipleChoiceMenuAsyncInternal_d__127()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenMultipleChoiceMenuAsyncInternal>d__127`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr);
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_openContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "openContext");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr__panelInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "<panelInstance>5__2");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, 100684555);
				UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr, 100684556);
			}

			// Token: 0x0601042F RID: 66607 RVA: 0x003C9050 File Offset: 0x003C7250
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260240, RefRangeEnd = 260242, XrefRangeStart = 260223, XrefRangeEnd = 260240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010430 RID: 66608 RVA: 0x003C9088 File Offset: 0x003C7288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010431 RID: 66609 RVA: 0x0008DCB1 File Offset: 0x0008BEB1
			public _OpenMultipleChoiceMenuAsyncInternal_d__127(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010432 RID: 66610 RVA: 0x0008DCBA File Offset: 0x0008BEBA
			public _OpenMultipleChoiceMenuAsyncInternal_d__127() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700550C RID: 21772
			// (get) Token: 0x06010433 RID: 66611 RVA: 0x003C90D0 File Offset: 0x003C72D0
			// (set) Token: 0x06010434 RID: 66612 RVA: 0x0008DCCC File Offset: 0x0008BECC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700550D RID: 21773
			// (get) Token: 0x06010435 RID: 66613 RVA: 0x003C90F8 File Offset: 0x003C72F8
			// (set) Token: 0x06010436 RID: 66614 RVA: 0x0008DCE7 File Offset: 0x0008BEE7
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700550E RID: 21774
			// (get) Token: 0x06010437 RID: 66615 RVA: 0x003C9128 File Offset: 0x003C7328
			// (set) Token: 0x06010438 RID: 66616 RVA: 0x0008DD15 File Offset: 0x0008BF15
			public MultipleChoicePannel.MultipleChoicePannelOpenContext openContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_openContext);
					return new MultipleChoicePannel.MultipleChoicePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_openContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultipleChoicePannel.MultipleChoicePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700550F RID: 21775
			// (get) Token: 0x06010439 RID: 66617 RVA: 0x003C9158 File Offset: 0x003C7358
			// (set) Token: 0x0601043A RID: 66618 RVA: 0x0008DD43 File Offset: 0x0008BF43
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x17005510 RID: 21776
			// (get) Token: 0x0601043B RID: 66619 RVA: 0x003C9180 File Offset: 0x003C7380
			// (set) Token: 0x0601043C RID: 66620 RVA: 0x0008DD5E File Offset: 0x0008BF5E
			public unsafe Action<bool, Il2CppArrayBase<T>> onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005511 RID: 21777
			// (get) Token: 0x0601043D RID: 66621 RVA: 0x003C91B0 File Offset: 0x003C73B0
			// (set) Token: 0x0601043E RID: 66622 RVA: 0x0008DD7D File Offset: 0x0008BF7D
			public unsafe MultipleChoicePannel _panelInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr__panelInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleChoicePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr__panelInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005512 RID: 21778
			// (get) Token: 0x0601043F RID: 66623 RVA: 0x003C91E0 File Offset: 0x003C73E0
			// (set) Token: 0x06010440 RID: 66624 RVA: 0x0008DD9C File Offset: 0x0008BF9C
			public UniTask<MultipleChoicePannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___u__1);
					return new UniTask<MultipleChoicePannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<MultipleChoicePannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenMultipleChoiceMenuAsyncInternal_d__127<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<MultipleChoicePannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4E3 RID: 42211
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4E4 RID: 42212
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4E5 RID: 42213
			private static readonly IntPtr NativeFieldInfoPtr_openContext;

			// Token: 0x0400A4E6 RID: 42214
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A4E7 RID: 42215
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A4E8 RID: 42216
			private static readonly IntPtr NativeFieldInfoPtr__panelInstance_5__2;

			// Token: 0x0400A4E9 RID: 42217
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4EA RID: 42218
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4EB RID: 42219
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1D RID: 3613
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenBindingSubPannelAsyncInternal>d__129")]
		public sealed class _OpenBindingSubPannelAsyncInternal_d__129 : ValueType
		{
			// Token: 0x06010441 RID: 66625 RVA: 0x003C9210 File Offset: 0x003C7410
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenBindingSubPannelAsyncInternal_d__129()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenBindingSubPannelAsyncInternal>d__129");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr);
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_actionGroupToRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "actionGroupToRebind");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "groups");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "instances");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_inputBindingDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "inputBindingDatas");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "onPannelCloseCallback");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, 100684557);
				UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr, 100684558);
			}

			// Token: 0x06010442 RID: 66626 RVA: 0x003C9304 File Offset: 0x003C7504
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260253, RefRangeEnd = 260255, XrefRangeStart = 260242, XrefRangeEnd = 260253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010443 RID: 66627 RVA: 0x003C933C File Offset: 0x003C753C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010444 RID: 66628 RVA: 0x0008DDCA File Offset: 0x0008BFCA
			public _OpenBindingSubPannelAsyncInternal_d__129(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010445 RID: 66629 RVA: 0x0008DDD3 File Offset: 0x0008BFD3
			public _OpenBindingSubPannelAsyncInternal_d__129() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129>.NativeClassPtr))
			{
			}

			// Token: 0x17005513 RID: 21779
			// (get) Token: 0x06010446 RID: 66630 RVA: 0x003C9384 File Offset: 0x003C7584
			// (set) Token: 0x06010447 RID: 66631 RVA: 0x0008DDE5 File Offset: 0x0008BFE5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005514 RID: 21780
			// (get) Token: 0x06010448 RID: 66632 RVA: 0x003C93AC File Offset: 0x003C75AC
			// (set) Token: 0x06010449 RID: 66633 RVA: 0x0008DE00 File Offset: 0x0008C000
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005515 RID: 21781
			// (get) Token: 0x0601044A RID: 66634 RVA: 0x003C93DC File Offset: 0x003C75DC
			// (set) Token: 0x0601044B RID: 66635 RVA: 0x0008DE2E File Offset: 0x0008C02E
			public EscBindingPannel.InputBindingData actionGroupToRebind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_actionGroupToRebind);
					return new EscBindingPannel.InputBindingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_actionGroupToRebind), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005516 RID: 21782
			// (get) Token: 0x0601044C RID: 66636 RVA: 0x003C940C File Offset: 0x003C760C
			// (set) Token: 0x0601044D RID: 66637 RVA: 0x0008DE5C File Offset: 0x0008C05C
			public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> groups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_groups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005517 RID: 21783
			// (get) Token: 0x0601044E RID: 66638 RVA: 0x003C943C File Offset: 0x003C763C
			// (set) Token: 0x0601044F RID: 66639 RVA: 0x0008DE7B File Offset: 0x0008C07B
			public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_instances);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005518 RID: 21784
			// (get) Token: 0x06010450 RID: 66640 RVA: 0x003C946C File Offset: 0x003C766C
			// (set) Token: 0x06010451 RID: 66641 RVA: 0x0008DE9A File Offset: 0x0008C09A
			public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_inputBindingDatas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_inputBindingDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005519 RID: 21785
			// (get) Token: 0x06010452 RID: 66642 RVA: 0x003C949C File Offset: 0x003C769C
			// (set) Token: 0x06010453 RID: 66643 RVA: 0x0008DEB9 File Offset: 0x0008C0B9
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700551A RID: 21786
			// (get) Token: 0x06010454 RID: 66644 RVA: 0x003C94CC File Offset: 0x003C76CC
			// (set) Token: 0x06010455 RID: 66645 RVA: 0x0008DED8 File Offset: 0x0008C0D8
			public UniTask<EscBindingSubPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___u__1);
					return new UniTask<EscBindingSubPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<EscBindingSubPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenBindingSubPannelAsyncInternal_d__129.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<EscBindingSubPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4EC RID: 42220
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4ED RID: 42221
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4EE RID: 42222
			private static readonly IntPtr NativeFieldInfoPtr_actionGroupToRebind;

			// Token: 0x0400A4EF RID: 42223
			private static readonly IntPtr NativeFieldInfoPtr_groups;

			// Token: 0x0400A4F0 RID: 42224
			private static readonly IntPtr NativeFieldInfoPtr_instances;

			// Token: 0x0400A4F1 RID: 42225
			private static readonly IntPtr NativeFieldInfoPtr_inputBindingDatas;

			// Token: 0x0400A4F2 RID: 42226
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x0400A4F3 RID: 42227
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4F4 RID: 42228
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4F5 RID: 42229
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1E RID: 3614
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenFilterPanel>d__130`1")]
		public sealed class _OpenFilterPanel_d__130<T> : ValueType
		{
			// Token: 0x06010456 RID: 66646 RVA: 0x003C94FC File Offset: 0x003C76FC
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenFilterPanel_d__130()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenFilterPanel>d__130`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr);
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_historyFilterConfigList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "historyFilterConfigList");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_filterConfigFactories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "filterConfigFactories");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr__configList_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "<configList>5__2");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "<>7__wrap2");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, "<>u__1");
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, 100684559);
				UniversalGameManager._OpenFilterPanel_d__130<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr, 100684560);
			}

			// Token: 0x06010457 RID: 66647 RVA: 0x003C9618 File Offset: 0x003C7818
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260330, RefRangeEnd = 260333, XrefRangeStart = 260255, XrefRangeEnd = 260330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010458 RID: 66648 RVA: 0x003C9650 File Offset: 0x003C7850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010459 RID: 66649 RVA: 0x0008DF06 File Offset: 0x0008C106
			public _OpenFilterPanel_d__130(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601045A RID: 66650 RVA: 0x0008DF0F File Offset: 0x0008C10F
			public _OpenFilterPanel_d__130() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenFilterPanel_d__130<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700551B RID: 21787
			// (get) Token: 0x0601045B RID: 66651 RVA: 0x003C9698 File Offset: 0x003C7898
			// (set) Token: 0x0601045C RID: 66652 RVA: 0x0008DF21 File Offset: 0x0008C121
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700551C RID: 21788
			// (get) Token: 0x0601045D RID: 66653 RVA: 0x003C96C0 File Offset: 0x003C78C0
			// (set) Token: 0x0601045E RID: 66654 RVA: 0x0008DF3C File Offset: 0x0008C13C
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700551D RID: 21789
			// (get) Token: 0x0601045F RID: 66655 RVA: 0x003C96F0 File Offset: 0x003C78F0
			// (set) Token: 0x06010460 RID: 66656 RVA: 0x0008DF6A File Offset: 0x0008C16A
			public unsafe List<IFilterConfig> historyFilterConfigList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_historyFilterConfigList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_historyFilterConfigList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700551E RID: 21790
			// (get) Token: 0x06010461 RID: 66657 RVA: 0x003C9720 File Offset: 0x003C7920
			// (set) Token: 0x06010462 RID: 66658 RVA: 0x0008DF89 File Offset: 0x0008C189
			public unsafe IReadOnlyList<FilterConfigFactory<T>> filterConfigFactories
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_filterConfigFactories);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<FilterConfigFactory<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr_filterConfigFactories), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700551F RID: 21791
			// (get) Token: 0x06010463 RID: 66659 RVA: 0x003C9750 File Offset: 0x003C7950
			// (set) Token: 0x06010464 RID: 66660 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
			public unsafe List<IFilterConfig> _configList_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr__configList_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr__configList_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005520 RID: 21792
			// (get) Token: 0x06010465 RID: 66661 RVA: 0x003C9780 File Offset: 0x003C7980
			// (set) Token: 0x06010466 RID: 66662 RVA: 0x0008DFC7 File Offset: 0x0008C1C7
			public unsafe UniversalGameManager.IsolatedPanelTransformHandle __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17005521 RID: 21793
			// (get) Token: 0x06010467 RID: 66663 RVA: 0x003C97A8 File Offset: 0x003C79A8
			// (set) Token: 0x06010468 RID: 66664 RVA: 0x0008DFE2 File Offset: 0x0008C1E2
			public UniTask<FlattenedFilterPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___u__1);
					return new UniTask<FlattenedFilterPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<FlattenedFilterPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenFilterPanel_d__130<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<FlattenedFilterPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A4F6 RID: 42230
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4F7 RID: 42231
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A4F8 RID: 42232
			private static readonly IntPtr NativeFieldInfoPtr_historyFilterConfigList;

			// Token: 0x0400A4F9 RID: 42233
			private static readonly IntPtr NativeFieldInfoPtr_filterConfigFactories;

			// Token: 0x0400A4FA RID: 42234
			private static readonly IntPtr NativeFieldInfoPtr__configList_5__2;

			// Token: 0x0400A4FB RID: 42235
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400A4FC RID: 42236
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A4FD RID: 42237
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4FE RID: 42238
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E1F RID: 3615
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass132_0")]
		public sealed class __c__DisplayClass132_0 : Il2CppSystem.Object
		{
			// Token: 0x06010469 RID: 66665 RVA: 0x003C97D8 File Offset: 0x003C79D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass132_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass132_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass132_0.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr, "onPannelCloseCallback");
				UniversalGameManager.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr, 100684561);
				UniversalGameManager.__c__DisplayClass132_0.NativeMethodInfoPtr__OpenIzakayaConfigMenuAsyncInternal_b__0_Internal_Void_IzakayaConfigPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr, 100684562);
			}

			// Token: 0x0601046A RID: 66666 RVA: 0x003C9840 File Offset: 0x003C7A40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass132_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass132_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601046B RID: 66667 RVA: 0x003C987C File Offset: 0x003C7A7C
			[CallerCount(0)]
			public unsafe void _OpenIzakayaConfigMenuAsyncInternal_b__0(IzakayaConfigPannel _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass132_0.NativeMethodInfoPtr__OpenIzakayaConfigMenuAsyncInternal_b__0_Internal_Void_IzakayaConfigPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601046C RID: 66668 RVA: 0x0008E010 File Offset: 0x0008C210
			public __c__DisplayClass132_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005522 RID: 21794
			// (get) Token: 0x0601046D RID: 66669 RVA: 0x003C98C0 File Offset: 0x003C7AC0
			// (set) Token: 0x0601046E RID: 66670 RVA: 0x0008E019 File Offset: 0x0008C219
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass132_0.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass132_0.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4FF RID: 42239
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x0400A500 RID: 42240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A501 RID: 42241
			private static readonly IntPtr NativeMethodInfoPtr__OpenIzakayaConfigMenuAsyncInternal_b__0_Internal_Void_IzakayaConfigPannel_0;
		}

		// Token: 0x02000E20 RID: 3616
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass134_0")]
		public sealed class __c__DisplayClass134_0 : Il2CppSystem.Object
		{
			// Token: 0x0601046F RID: 66671 RVA: 0x003C98F0 File Offset: 0x003C7AF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass134_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass134_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass134_0.NativeFieldInfoPtr_onPannelCloseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr, "onPannelCloseCallback");
				UniversalGameManager.__c__DisplayClass134_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr, 100684563);
				UniversalGameManager.__c__DisplayClass134_0.NativeMethodInfoPtr__OpenMultipleGetProductsPanelAsync_b__0_Internal_Void_MultipleGetProductsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr, 100684564);
			}

			// Token: 0x06010470 RID: 66672 RVA: 0x003C9958 File Offset: 0x003C7B58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass134_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass134_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass134_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010471 RID: 66673 RVA: 0x003C9994 File Offset: 0x003C7B94
			[CallerCount(0)]
			public unsafe void _OpenMultipleGetProductsPanelAsync_b__0(MultipleGetProductsPanel _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass134_0.NativeMethodInfoPtr__OpenMultipleGetProductsPanelAsync_b__0_Internal_Void_MultipleGetProductsPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010472 RID: 66674 RVA: 0x0008E038 File Offset: 0x0008C238
			public __c__DisplayClass134_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005523 RID: 21795
			// (get) Token: 0x06010473 RID: 66675 RVA: 0x003C99D8 File Offset: 0x003C7BD8
			// (set) Token: 0x06010474 RID: 66676 RVA: 0x0008E041 File Offset: 0x0008C241
			public unsafe Action onPannelCloseCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass134_0.NativeFieldInfoPtr_onPannelCloseCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass134_0.NativeFieldInfoPtr_onPannelCloseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A502 RID: 42242
			private static readonly IntPtr NativeFieldInfoPtr_onPannelCloseCallback;

			// Token: 0x0400A503 RID: 42243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A504 RID: 42244
			private static readonly IntPtr NativeMethodInfoPtr__OpenMultipleGetProductsPanelAsync_b__0_Internal_Void_MultipleGetProductsPanel_0;
		}

		// Token: 0x02000E21 RID: 3617
		[ObfuscatedName("Common.UI.UniversalGameManager+<RunWithLoadingIndicatorPanel>d__135")]
		public sealed class _RunWithLoadingIndicatorPanel_d__135 : ValueType
		{
			// Token: 0x06010475 RID: 66677 RVA: 0x003C9A08 File Offset: 0x003C7C08
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithLoadingIndicatorPanel_d__135()
			{
				Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<RunWithLoadingIndicatorPanel>d__135");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr);
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, "<>1__state");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr_taskToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, "taskToRun");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr__panel_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, "<panel>5__2");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, "<>u__1");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, 100684565);
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr, 100684566);
			}

			// Token: 0x06010476 RID: 66678 RVA: 0x003C9AC0 File Offset: 0x003C7CC0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260378, RefRangeEnd = 260381, XrefRangeStart = 260333, XrefRangeEnd = 260378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010477 RID: 66679 RVA: 0x003C9AF8 File Offset: 0x003C7CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010478 RID: 66680 RVA: 0x0008E060 File Offset: 0x0008C260
			public _RunWithLoadingIndicatorPanel_d__135(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010479 RID: 66681 RVA: 0x0008E069 File Offset: 0x0008C269
			public _RunWithLoadingIndicatorPanel_d__135() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__135>.NativeClassPtr))
			{
			}

			// Token: 0x17005524 RID: 21796
			// (get) Token: 0x0601047A RID: 66682 RVA: 0x003C9B40 File Offset: 0x003C7D40
			// (set) Token: 0x0601047B RID: 66683 RVA: 0x0008E07B File Offset: 0x0008C27B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005525 RID: 21797
			// (get) Token: 0x0601047C RID: 66684 RVA: 0x003C9B68 File Offset: 0x003C7D68
			// (set) Token: 0x0601047D RID: 66685 RVA: 0x0008E096 File Offset: 0x0008C296
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005526 RID: 21798
			// (get) Token: 0x0601047E RID: 66686 RVA: 0x003C9B98 File Offset: 0x003C7D98
			// (set) Token: 0x0601047F RID: 66687 RVA: 0x0008E0C4 File Offset: 0x0008C2C4
			public unsafe Func<UniTask> taskToRun
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr_taskToRun);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr_taskToRun), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005527 RID: 21799
			// (get) Token: 0x06010480 RID: 66688 RVA: 0x003C9BC8 File Offset: 0x003C7DC8
			// (set) Token: 0x06010481 RID: 66689 RVA: 0x0008E0E3 File Offset: 0x0008C2E3
			public unsafe AdpBuiltinInputBlockerPanel _panel_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr__panel_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpBuiltinInputBlockerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr__panel_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005528 RID: 21800
			// (get) Token: 0x06010482 RID: 66690 RVA: 0x003C9BF8 File Offset: 0x003C7DF8
			// (set) Token: 0x06010483 RID: 66691 RVA: 0x0008E102 File Offset: 0x0008C302
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__135.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A505 RID: 42245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A506 RID: 42246
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A507 RID: 42247
			private static readonly IntPtr NativeFieldInfoPtr_taskToRun;

			// Token: 0x0400A508 RID: 42248
			private static readonly IntPtr NativeFieldInfoPtr__panel_5__2;

			// Token: 0x0400A509 RID: 42249
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A50A RID: 42250
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A50B RID: 42251
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E22 RID: 3618
		[ObfuscatedName("Common.UI.UniversalGameManager+<RunWithLoadingIndicatorPanel>d__136`1")]
		public sealed class _RunWithLoadingIndicatorPanel_d__136<T> : ValueType
		{
			// Token: 0x06010484 RID: 66692 RVA: 0x003C9C28 File Offset: 0x003C7E28
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithLoadingIndicatorPanel_d__136()
			{
				Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<RunWithLoadingIndicatorPanel>d__136`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr);
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, "<>1__state");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr_taskToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, "taskToRun");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr__panel_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, "<panel>5__2");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, "<>u__1");
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, 100684567);
				UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr, 100684568);
			}

			// Token: 0x06010485 RID: 66693 RVA: 0x003C9D1C File Offset: 0x003C7F1C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260440, RefRangeEnd = 260442, XrefRangeStart = 260381, XrefRangeEnd = 260440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010486 RID: 66694 RVA: 0x003C9D54 File Offset: 0x003C7F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010487 RID: 66695 RVA: 0x0008E130 File Offset: 0x0008C330
			public _RunWithLoadingIndicatorPanel_d__136(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010488 RID: 66696 RVA: 0x0008E139 File Offset: 0x0008C339
			public _RunWithLoadingIndicatorPanel_d__136() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17005529 RID: 21801
			// (get) Token: 0x06010489 RID: 66697 RVA: 0x003C9D9C File Offset: 0x003C7F9C
			// (set) Token: 0x0601048A RID: 66698 RVA: 0x0008E14B File Offset: 0x0008C34B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700552A RID: 21802
			// (get) Token: 0x0601048B RID: 66699 RVA: 0x003C9DC4 File Offset: 0x003C7FC4
			// (set) Token: 0x0601048C RID: 66700 RVA: 0x0008E166 File Offset: 0x0008C366
			public AsyncUniTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700552B RID: 21803
			// (get) Token: 0x0601048D RID: 66701 RVA: 0x003C9DF4 File Offset: 0x003C7FF4
			// (set) Token: 0x0601048E RID: 66702 RVA: 0x0008E194 File Offset: 0x0008C394
			public unsafe Func<UniTask<T>> taskToRun
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr_taskToRun);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr_taskToRun), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700552C RID: 21804
			// (get) Token: 0x0601048F RID: 66703 RVA: 0x003C9E24 File Offset: 0x003C8024
			// (set) Token: 0x06010490 RID: 66704 RVA: 0x0008E1B3 File Offset: 0x0008C3B3
			public unsafe AdpBuiltinInputBlockerPanel _panel_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr__panel_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpBuiltinInputBlockerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr__panel_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700552D RID: 21805
			// (get) Token: 0x06010491 RID: 66705 RVA: 0x003C9E54 File Offset: 0x003C8054
			// (set) Token: 0x06010492 RID: 66706 RVA: 0x0008E1D2 File Offset: 0x0008C3D2
			public UniTask<T>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___u__1);
					return new UniTask<T>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<T>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._RunWithLoadingIndicatorPanel_d__136<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<T>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A50C RID: 42252
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A50D RID: 42253
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A50E RID: 42254
			private static readonly IntPtr NativeFieldInfoPtr_taskToRun;

			// Token: 0x0400A50F RID: 42255
			private static readonly IntPtr NativeFieldInfoPtr__panel_5__2;

			// Token: 0x0400A510 RID: 42256
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A511 RID: 42257
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A512 RID: 42258
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E23 RID: 3619
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass137_0")]
		public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
		{
			// Token: 0x06010493 RID: 66707 RVA: 0x003C9E84 File Offset: 0x003C8084
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass137_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass137_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass137_0.NativeFieldInfoPtr_taskToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr, "taskToRun");
				UniversalGameManager.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr, 100684569);
				UniversalGameManager.__c__DisplayClass137_0.NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr, 100684570);
			}

			// Token: 0x06010494 RID: 66708 RVA: 0x003C9EEC File Offset: 0x003C80EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass137_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass137_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010495 RID: 66709 RVA: 0x003C9F28 File Offset: 0x003C8128
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260442, RefRangeEnd = 260443, XrefRangeStart = 260442, XrefRangeEnd = 260442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _RunWithLoadingIndicatorPanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass137_0.NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06010496 RID: 66710 RVA: 0x0008E200 File Offset: 0x0008C400
			public __c__DisplayClass137_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700552E RID: 21806
			// (get) Token: 0x06010497 RID: 66711 RVA: 0x003C9F60 File Offset: 0x003C8160
			// (set) Token: 0x06010498 RID: 66712 RVA: 0x0008E209 File Offset: 0x0008C409
			public UniTask taskToRun
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass137_0.NativeFieldInfoPtr_taskToRun);
					return new UniTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass137_0.NativeFieldInfoPtr_taskToRun), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A513 RID: 42259
			private static readonly IntPtr NativeFieldInfoPtr_taskToRun;

			// Token: 0x0400A514 RID: 42260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A515 RID: 42261
			private static readonly IntPtr NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_0;
		}

		// Token: 0x02000E24 RID: 3620
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass138_0`1")]
		public sealed class __c__DisplayClass138_0<T> : Il2CppSystem.Object
		{
			// Token: 0x06010499 RID: 66713 RVA: 0x003C9F90 File Offset: 0x003C8190
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass138_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass138_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass138_0<T>.NativeFieldInfoPtr_taskToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr, "taskToRun");
				UniversalGameManager.__c__DisplayClass138_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr, 100684571);
				UniversalGameManager.__c__DisplayClass138_0<T>.NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr, 100684572);
			}

			// Token: 0x0601049A RID: 66714 RVA: 0x003CA034 File Offset: 0x003C8234
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass138_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass138_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass138_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601049B RID: 66715 RVA: 0x003CA070 File Offset: 0x003C8270
			[CallerCount(0)]
			public unsafe UniTask<T> _RunWithLoadingIndicatorPanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass138_0<T>.NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<T>(pointer);
			}

			// Token: 0x0601049C RID: 66716 RVA: 0x0008E237 File Offset: 0x0008C437
			public __c__DisplayClass138_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700552F RID: 21807
			// (get) Token: 0x0601049D RID: 66717 RVA: 0x003CA0A8 File Offset: 0x003C82A8
			// (set) Token: 0x0601049E RID: 66718 RVA: 0x0008E240 File Offset: 0x0008C440
			public UniTask<T> taskToRun
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass138_0<T>.NativeFieldInfoPtr_taskToRun);
					return new UniTask<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass138_0<T>.NativeFieldInfoPtr_taskToRun), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A516 RID: 42262
			private static readonly IntPtr NativeFieldInfoPtr_taskToRun;

			// Token: 0x0400A517 RID: 42263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A518 RID: 42264
			private static readonly IntPtr NativeMethodInfoPtr__RunWithLoadingIndicatorPanel_b__0_Internal_UniTask_1_T_0;
		}

		// Token: 0x02000E25 RID: 3621
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass140_0")]
		public sealed class __c__DisplayClass140_0 : Il2CppSystem.Object
		{
			// Token: 0x0601049F RID: 66719 RVA: 0x003CA0D8 File Offset: 0x003C82D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass140_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass140_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass140_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr, "canContinue");
				UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr, 100684573);
				UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr, 100684574);
				UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr, 100684575);
			}

			// Token: 0x060104A0 RID: 66720 RVA: 0x003CA154 File Offset: 0x003C8354
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass140_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass140_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104A1 RID: 66721 RVA: 0x003CA190 File Offset: 0x003C8390
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenDialogMenuCoroutine_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104A2 RID: 66722 RVA: 0x003CA1C4 File Offset: 0x003C83C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenDialogMenuCoroutine_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass140_0.NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060104A3 RID: 66723 RVA: 0x0008E26E File Offset: 0x0008C46E
			public __c__DisplayClass140_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005530 RID: 21808
			// (get) Token: 0x060104A4 RID: 66724 RVA: 0x003CA200 File Offset: 0x003C8400
			// (set) Token: 0x060104A5 RID: 66725 RVA: 0x0008E277 File Offset: 0x0008C477
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass140_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass140_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x0400A519 RID: 42265
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x0400A51A RID: 42266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A51B RID: 42267
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__0_Internal_Void_0;

			// Token: 0x0400A51C RID: 42268
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuCoroutine_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000E26 RID: 3622
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenDialogMenuCoroutine>d__140")]
		public sealed class _OpenDialogMenuCoroutine_d__140 : Il2CppSystem.Object
		{
			// Token: 0x060104A6 RID: 66726 RVA: 0x003CA228 File Offset: 0x003C8428
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDialogMenuCoroutine_d__140()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenDialogMenuCoroutine>d__140");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, "<>2__current");
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, "dialogPackage");
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_overrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, "overrideReplaceTextCallback");
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684576);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684577);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684578);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684579);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684580);
				UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr, 100684581);
			}

			// Token: 0x060104A7 RID: 66727 RVA: 0x003CA330 File Offset: 0x003C8530
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OpenDialogMenuCoroutine_d__140(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuCoroutine_d__140>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104A8 RID: 66728 RVA: 0x003CA378 File Offset: 0x003C8578
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104A9 RID: 66729 RVA: 0x003CA3AC File Offset: 0x003C85AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260443, XrefRangeEnd = 260468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005536 RID: 21814
			// (get) Token: 0x060104AA RID: 66730 RVA: 0x003CA3E8 File Offset: 0x003C85E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104AB RID: 66731 RVA: 0x003CA428 File Offset: 0x003C8628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260468, XrefRangeEnd = 260474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005537 RID: 21815
			// (get) Token: 0x060104AC RID: 66732 RVA: 0x003CA45C File Offset: 0x003C865C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104AD RID: 66733 RVA: 0x0008E292 File Offset: 0x0008C492
			public _OpenDialogMenuCoroutine_d__140(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005531 RID: 21809
			// (get) Token: 0x060104AE RID: 66734 RVA: 0x003CA49C File Offset: 0x003C869C
			// (set) Token: 0x060104AF RID: 66735 RVA: 0x0008E29B File Offset: 0x0008C49B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005532 RID: 21810
			// (get) Token: 0x060104B0 RID: 66736 RVA: 0x003CA4C4 File Offset: 0x003C86C4
			// (set) Token: 0x060104B1 RID: 66737 RVA: 0x0008E2B6 File Offset: 0x0008C4B6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005533 RID: 21811
			// (get) Token: 0x060104B2 RID: 66738 RVA: 0x003CA4F4 File Offset: 0x003C86F4
			// (set) Token: 0x060104B3 RID: 66739 RVA: 0x0008E2D5 File Offset: 0x0008C4D5
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005534 RID: 21812
			// (get) Token: 0x060104B4 RID: 66740 RVA: 0x003CA524 File Offset: 0x003C8724
			// (set) Token: 0x060104B5 RID: 66741 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
			public unsafe Action<Dictionary<int, string>> overrideReplaceTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_overrideReplaceTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_overrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005535 RID: 21813
			// (get) Token: 0x060104B6 RID: 66742 RVA: 0x003CA554 File Offset: 0x003C8754
			// (set) Token: 0x060104B7 RID: 66743 RVA: 0x0008E313 File Offset: 0x0008C513
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuCoroutine_d__140.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x0400A51D RID: 42269
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A51E RID: 42270
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A51F RID: 42271
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x0400A520 RID: 42272
			private static readonly IntPtr NativeFieldInfoPtr_overrideReplaceTextCallback;

			// Token: 0x0400A521 RID: 42273
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A522 RID: 42274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A523 RID: 42275
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A524 RID: 42276
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A525 RID: 42277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A526 RID: 42278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A527 RID: 42279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E27 RID: 3623
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass141_0")]
		public sealed class __c__DisplayClass141_0 : Il2CppSystem.Object
		{
			// Token: 0x060104B8 RID: 66744 RVA: 0x003CA57C File Offset: 0x003C877C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass141_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass141_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass141_0.NativeFieldInfoPtr_exitCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr, "exitCode");
				UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr, 100684582);
				UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr, 100684583);
				UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr, 100684584);
			}

			// Token: 0x060104B9 RID: 66745 RVA: 0x003CA5F8 File Offset: 0x003C87F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass141_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass141_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104BA RID: 66746 RVA: 0x003CA634 File Offset: 0x003C8834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260474, XrefRangeEnd = 260477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenDialogMenuWithExitCodeCoroutine_b__0(int code)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104BB RID: 66747 RVA: 0x003CA674 File Offset: 0x003C8874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260477, XrefRangeEnd = 260478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenDialogMenuWithExitCodeCoroutine_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass141_0.NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060104BC RID: 66748 RVA: 0x0008E32E File Offset: 0x0008C52E
			public __c__DisplayClass141_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005538 RID: 21816
			// (get) Token: 0x060104BD RID: 66749 RVA: 0x003CA6B0 File Offset: 0x003C88B0
			// (set) Token: 0x060104BE RID: 66750 RVA: 0x0008E337 File Offset: 0x0008C537
			public Nullable<int> exitCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass141_0.NativeFieldInfoPtr_exitCode);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass141_0.NativeFieldInfoPtr_exitCode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A528 RID: 42280
			private static readonly IntPtr NativeFieldInfoPtr_exitCode;

			// Token: 0x0400A529 RID: 42281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A52A RID: 42282
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__0_Internal_Void_Int32_0;

			// Token: 0x0400A52B RID: 42283
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuWithExitCodeCoroutine_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000E28 RID: 3624
		[ObfuscatedName("Common.UI.UniversalGameManager+<OpenDialogMenuWithExitCodeCoroutine>d__141")]
		public sealed class _OpenDialogMenuWithExitCodeCoroutine_d__141 : Il2CppSystem.Object
		{
			// Token: 0x060104BF RID: 66751 RVA: 0x003CA6E0 File Offset: 0x003C88E0
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDialogMenuWithExitCodeCoroutine_d__141()
			{
				Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<OpenDialogMenuWithExitCodeCoroutine>d__141");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "<>1__state");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "<>2__current");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "dialogPackage");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_overrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "overrideReplaceTextCallback");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_getExitCodeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "getExitCodeCallback");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, "<>8__1");
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684585);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684586);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684587);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684588);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684589);
				UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr, 100684590);
			}

			// Token: 0x060104C0 RID: 66752 RVA: 0x003CA810 File Offset: 0x003C8A10
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OpenDialogMenuWithExitCodeCoroutine_d__141(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104C1 RID: 66753 RVA: 0x003CA858 File Offset: 0x003C8A58
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104C2 RID: 66754 RVA: 0x003CA88C File Offset: 0x003C8A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260478, XrefRangeEnd = 260518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005540 RID: 21824
			// (get) Token: 0x060104C3 RID: 66755 RVA: 0x003CA8C8 File Offset: 0x003C8AC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104C4 RID: 66756 RVA: 0x003CA908 File Offset: 0x003C8B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260518, XrefRangeEnd = 260524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005541 RID: 21825
			// (get) Token: 0x060104C5 RID: 66757 RVA: 0x003CA93C File Offset: 0x003C8B3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104C6 RID: 66758 RVA: 0x0008E365 File Offset: 0x0008C565
			public _OpenDialogMenuWithExitCodeCoroutine_d__141(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005539 RID: 21817
			// (get) Token: 0x060104C7 RID: 66759 RVA: 0x003CA97C File Offset: 0x003C8B7C
			// (set) Token: 0x060104C8 RID: 66760 RVA: 0x0008E36E File Offset: 0x0008C56E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700553A RID: 21818
			// (get) Token: 0x060104C9 RID: 66761 RVA: 0x003CA9A4 File Offset: 0x003C8BA4
			// (set) Token: 0x060104CA RID: 66762 RVA: 0x0008E389 File Offset: 0x0008C589
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700553B RID: 21819
			// (get) Token: 0x060104CB RID: 66763 RVA: 0x003CA9D4 File Offset: 0x003C8BD4
			// (set) Token: 0x060104CC RID: 66764 RVA: 0x0008E3A8 File Offset: 0x0008C5A8
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700553C RID: 21820
			// (get) Token: 0x060104CD RID: 66765 RVA: 0x003CAA04 File Offset: 0x003C8C04
			// (set) Token: 0x060104CE RID: 66766 RVA: 0x0008E3C7 File Offset: 0x0008C5C7
			public unsafe Action<Dictionary<int, string>> overrideReplaceTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_overrideReplaceTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_overrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700553D RID: 21821
			// (get) Token: 0x060104CF RID: 66767 RVA: 0x003CAA34 File Offset: 0x003C8C34
			// (set) Token: 0x060104D0 RID: 66768 RVA: 0x0008E3E6 File Offset: 0x0008C5E6
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x1700553E RID: 21822
			// (get) Token: 0x060104D1 RID: 66769 RVA: 0x003CAA5C File Offset: 0x003C8C5C
			// (set) Token: 0x060104D2 RID: 66770 RVA: 0x0008E401 File Offset: 0x0008C601
			public unsafe Action<int> getExitCodeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_getExitCodeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr_getExitCodeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700553F RID: 21823
			// (get) Token: 0x060104D3 RID: 66771 RVA: 0x003CAA8C File Offset: 0x003C8C8C
			// (set) Token: 0x060104D4 RID: 66772 RVA: 0x0008E420 File Offset: 0x0008C620
			public unsafe UniversalGameManager.__c__DisplayClass141_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGameManager.__c__DisplayClass141_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._OpenDialogMenuWithExitCodeCoroutine_d__141.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A52C RID: 42284
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A52D RID: 42285
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A52E RID: 42286
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x0400A52F RID: 42287
			private static readonly IntPtr NativeFieldInfoPtr_overrideReplaceTextCallback;

			// Token: 0x0400A530 RID: 42288
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A531 RID: 42289
			private static readonly IntPtr NativeFieldInfoPtr_getExitCodeCallback;

			// Token: 0x0400A532 RID: 42290
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A533 RID: 42291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A534 RID: 42292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A535 RID: 42293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A536 RID: 42294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A537 RID: 42295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A538 RID: 42296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E29 RID: 3625
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass142_0")]
		public sealed class __c__DisplayClass142_0 : Il2CppSystem.Object
		{
			// Token: 0x060104D5 RID: 66773 RVA: 0x003CAABC File Offset: 0x003C8CBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass142_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass142_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr, "dialogPackage");
				UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_overrideReplaceTextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr, "overrideReplaceTextCallback");
				UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_previousPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr, "previousPanelVisualMode");
				UniversalGameManager.__c__DisplayClass142_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr, 100684591);
				UniversalGameManager.__c__DisplayClass142_0.NativeMethodInfoPtr__OpenDialogMenuAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr, 100684592);
			}

			// Token: 0x060104D6 RID: 66774 RVA: 0x003CAB4C File Offset: 0x003C8D4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass142_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass142_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass142_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104D7 RID: 66775 RVA: 0x003CAB88 File Offset: 0x003C8D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260524, XrefRangeEnd = 260528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenDialogMenuAsync_b__0(Action call)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass142_0.NativeMethodInfoPtr__OpenDialogMenuAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104D8 RID: 66776 RVA: 0x0008E43F File Offset: 0x0008C63F
			public __c__DisplayClass142_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005542 RID: 21826
			// (get) Token: 0x060104D9 RID: 66777 RVA: 0x003CABCC File Offset: 0x003C8DCC
			// (set) Token: 0x060104DA RID: 66778 RVA: 0x0008E448 File Offset: 0x0008C648
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005543 RID: 21827
			// (get) Token: 0x060104DB RID: 66779 RVA: 0x003CABFC File Offset: 0x003C8DFC
			// (set) Token: 0x060104DC RID: 66780 RVA: 0x0008E467 File Offset: 0x0008C667
			public unsafe Action<Dictionary<int, string>> overrideReplaceTextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_overrideReplaceTextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dictionary<int, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_overrideReplaceTextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005544 RID: 21828
			// (get) Token: 0x060104DD RID: 66781 RVA: 0x003CAC2C File Offset: 0x003C8E2C
			// (set) Token: 0x060104DE RID: 66782 RVA: 0x0008E486 File Offset: 0x0008C686
			public unsafe AdpUIPanelManager.PanelVisualMode previousPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_previousPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass142_0.NativeFieldInfoPtr_previousPanelVisualMode)) = value;
				}
			}

			// Token: 0x0400A539 RID: 42297
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

			// Token: 0x0400A53A RID: 42298
			private static readonly IntPtr NativeFieldInfoPtr_overrideReplaceTextCallback;

			// Token: 0x0400A53B RID: 42299
			private static readonly IntPtr NativeFieldInfoPtr_previousPanelVisualMode;

			// Token: 0x0400A53C RID: 42300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A53D RID: 42301
			private static readonly IntPtr NativeMethodInfoPtr__OpenDialogMenuAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x02000E2A RID: 3626
		[ObfuscatedName("Common.UI.UniversalGameManager+<SetCameraShakeC>d__147")]
		public sealed class _SetCameraShakeC_d__147 : Il2CppSystem.Object
		{
			// Token: 0x060104DF RID: 66783 RVA: 0x003CAC54 File Offset: 0x003C8E54
			// Note: this type is marked as 'beforefieldinit'.
			static _SetCameraShakeC_d__147()
			{
				Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<SetCameraShakeC>d__147");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr);
				UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, "<>1__state");
				UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, "<>2__current");
				UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, "amplitude");
				UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, "duration");
				UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, "fadeTime");
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684593);
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684594);
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684595);
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684596);
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684597);
				UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr, 100684598);
			}

			// Token: 0x060104E0 RID: 66784 RVA: 0x003CAD5C File Offset: 0x003C8F5C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetCameraShakeC_d__147(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeC_d__147>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104E1 RID: 66785 RVA: 0x003CADA4 File Offset: 0x003C8FA4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104E2 RID: 66786 RVA: 0x003CADD8 File Offset: 0x003C8FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260528, XrefRangeEnd = 260557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700554A RID: 21834
			// (get) Token: 0x060104E3 RID: 66787 RVA: 0x003CAE14 File Offset: 0x003C9014
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104E4 RID: 66788 RVA: 0x003CAE54 File Offset: 0x003C9054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260557, XrefRangeEnd = 260563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700554B RID: 21835
			// (get) Token: 0x060104E5 RID: 66789 RVA: 0x003CAE88 File Offset: 0x003C9088
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeC_d__147.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104E6 RID: 66790 RVA: 0x0008E4A1 File Offset: 0x0008C6A1
			public _SetCameraShakeC_d__147(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005545 RID: 21829
			// (get) Token: 0x060104E7 RID: 66791 RVA: 0x003CAEC8 File Offset: 0x003C90C8
			// (set) Token: 0x060104E8 RID: 66792 RVA: 0x0008E4AA File Offset: 0x0008C6AA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005546 RID: 21830
			// (get) Token: 0x060104E9 RID: 66793 RVA: 0x003CAEF0 File Offset: 0x003C90F0
			// (set) Token: 0x060104EA RID: 66794 RVA: 0x0008E4C5 File Offset: 0x0008C6C5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005547 RID: 21831
			// (get) Token: 0x060104EB RID: 66795 RVA: 0x003CAF20 File Offset: 0x003C9120
			// (set) Token: 0x060104EC RID: 66796 RVA: 0x0008E4E4 File Offset: 0x0008C6E4
			public unsafe float amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_amplitude)) = value;
				}
			}

			// Token: 0x17005548 RID: 21832
			// (get) Token: 0x060104ED RID: 66797 RVA: 0x003CAF48 File Offset: 0x003C9148
			// (set) Token: 0x060104EE RID: 66798 RVA: 0x0008E4FF File Offset: 0x0008C6FF
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17005549 RID: 21833
			// (get) Token: 0x060104EF RID: 66799 RVA: 0x003CAF70 File Offset: 0x003C9170
			// (set) Token: 0x060104F0 RID: 66800 RVA: 0x0008E51A File Offset: 0x0008C71A
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeC_d__147.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x0400A53E RID: 42302
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A53F RID: 42303
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A540 RID: 42304
			private static readonly IntPtr NativeFieldInfoPtr_amplitude;

			// Token: 0x0400A541 RID: 42305
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A542 RID: 42306
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x0400A543 RID: 42307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A544 RID: 42308
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A545 RID: 42309
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A546 RID: 42310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A547 RID: 42311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A548 RID: 42312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E2B RID: 3627
		[ObfuscatedName("Common.UI.UniversalGameManager+<SetCameraShakeCorotine>d__148")]
		public sealed class _SetCameraShakeCorotine_d__148 : Il2CppSystem.Object
		{
			// Token: 0x060104F1 RID: 66801 RVA: 0x003CAF98 File Offset: 0x003C9198
			// Note: this type is marked as 'beforefieldinit'.
			static _SetCameraShakeCorotine_d__148()
			{
				Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<SetCameraShakeCorotine>d__148");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "<>1__state");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "<>2__current");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "amplitude");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "duration");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "fadeTime");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__shakeMaterial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "<shakeMaterial>5__2");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, "<progress>5__3");
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684599);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684600);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684601);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684602);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684603);
				UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr, 100684604);
			}

			// Token: 0x060104F2 RID: 66802 RVA: 0x003CB0C8 File Offset: 0x003C92C8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetCameraShakeCorotine_d__148(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._SetCameraShakeCorotine_d__148>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104F3 RID: 66803 RVA: 0x003CB110 File Offset: 0x003C9310
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060104F4 RID: 66804 RVA: 0x003CB144 File Offset: 0x003C9344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260563, XrefRangeEnd = 260566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005553 RID: 21843
			// (get) Token: 0x060104F5 RID: 66805 RVA: 0x003CB180 File Offset: 0x003C9380
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104F6 RID: 66806 RVA: 0x003CB1C0 File Offset: 0x003C93C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260566, XrefRangeEnd = 260572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005554 RID: 21844
			// (get) Token: 0x060104F7 RID: 66807 RVA: 0x003CB1F4 File Offset: 0x003C93F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060104F8 RID: 66808 RVA: 0x0008E535 File Offset: 0x0008C735
			public _SetCameraShakeCorotine_d__148(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700554C RID: 21836
			// (get) Token: 0x060104F9 RID: 66809 RVA: 0x003CB234 File Offset: 0x003C9434
			// (set) Token: 0x060104FA RID: 66810 RVA: 0x0008E53E File Offset: 0x0008C73E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700554D RID: 21837
			// (get) Token: 0x060104FB RID: 66811 RVA: 0x003CB25C File Offset: 0x003C945C
			// (set) Token: 0x060104FC RID: 66812 RVA: 0x0008E559 File Offset: 0x0008C759
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700554E RID: 21838
			// (get) Token: 0x060104FD RID: 66813 RVA: 0x003CB28C File Offset: 0x003C948C
			// (set) Token: 0x060104FE RID: 66814 RVA: 0x0008E578 File Offset: 0x0008C778
			public unsafe float amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_amplitude)) = value;
				}
			}

			// Token: 0x1700554F RID: 21839
			// (get) Token: 0x060104FF RID: 66815 RVA: 0x003CB2B4 File Offset: 0x003C94B4
			// (set) Token: 0x06010500 RID: 66816 RVA: 0x0008E593 File Offset: 0x0008C793
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17005550 RID: 21840
			// (get) Token: 0x06010501 RID: 66817 RVA: 0x003CB2DC File Offset: 0x003C94DC
			// (set) Token: 0x06010502 RID: 66818 RVA: 0x0008E5AE File Offset: 0x0008C7AE
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17005551 RID: 21841
			// (get) Token: 0x06010503 RID: 66819 RVA: 0x003CB304 File Offset: 0x003C9504
			// (set) Token: 0x06010504 RID: 66820 RVA: 0x0008E5C9 File Offset: 0x0008C7C9
			public unsafe Material _shakeMaterial_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__shakeMaterial_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__shakeMaterial_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005552 RID: 21842
			// (get) Token: 0x06010505 RID: 66821 RVA: 0x003CB334 File Offset: 0x003C9534
			// (set) Token: 0x06010506 RID: 66822 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
			public unsafe float _progress_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__progress_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._SetCameraShakeCorotine_d__148.NativeFieldInfoPtr__progress_5__3)) = value;
				}
			}

			// Token: 0x0400A549 RID: 42313
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A54A RID: 42314
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A54B RID: 42315
			private static readonly IntPtr NativeFieldInfoPtr_amplitude;

			// Token: 0x0400A54C RID: 42316
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A54D RID: 42317
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x0400A54E RID: 42318
			private static readonly IntPtr NativeFieldInfoPtr__shakeMaterial_5__2;

			// Token: 0x0400A54F RID: 42319
			private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

			// Token: 0x0400A550 RID: 42320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A551 RID: 42321
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A552 RID: 42322
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A553 RID: 42323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A554 RID: 42324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A555 RID: 42325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000E2C RID: 3628
		[ObfuscatedName("Common.UI.UniversalGameManager+<LoadAndPreparePanelScoped>d__149`1")]
		public sealed class _LoadAndPreparePanelScoped_d__149<T> : ValueType where T : UIPanelBaseImpl
		{
			// Token: 0x06010507 RID: 66823 RVA: 0x003CB35C File Offset: 0x003C955C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndPreparePanelScoped_d__149()
			{
				Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<LoadAndPreparePanelScoped>d__149`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr);
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, "<>1__state");
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, "<>t__builder");
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_assetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, "assetReference");
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_forceTempPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, "forceTempPanel");
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, "<>u__1");
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, 100684605);
				UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr, 100684606);
			}

			// Token: 0x06010508 RID: 66824 RVA: 0x003CB450 File Offset: 0x003C9650
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260619, RefRangeEnd = 260622, XrefRangeStart = 260572, XrefRangeEnd = 260619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010509 RID: 66825 RVA: 0x003CB488 File Offset: 0x003C9688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601050A RID: 66826 RVA: 0x0008E603 File Offset: 0x0008C803
			public _LoadAndPreparePanelScoped_d__149(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601050B RID: 66827 RVA: 0x0008E60C File Offset: 0x0008C80C
			public _LoadAndPreparePanelScoped_d__149() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>>.NativeClassPtr))
			{
			}

			// Token: 0x17005555 RID: 21845
			// (get) Token: 0x0601050C RID: 66828 RVA: 0x003CB4D0 File Offset: 0x003C96D0
			// (set) Token: 0x0601050D RID: 66829 RVA: 0x0008E61E File Offset: 0x0008C81E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005556 RID: 21846
			// (get) Token: 0x0601050E RID: 66830 RVA: 0x003CB4F8 File Offset: 0x003C96F8
			// (set) Token: 0x0601050F RID: 66831 RVA: 0x0008E639 File Offset: 0x0008C839
			public AsyncUniTaskMethodBuilder<T> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005557 RID: 21847
			// (get) Token: 0x06010510 RID: 66832 RVA: 0x003CB528 File Offset: 0x003C9728
			// (set) Token: 0x06010511 RID: 66833 RVA: 0x0008E667 File Offset: 0x0008C867
			public unsafe AssetReference assetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_assetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_assetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005558 RID: 21848
			// (get) Token: 0x06010512 RID: 66834 RVA: 0x003CB558 File Offset: 0x003C9758
			// (set) Token: 0x06010513 RID: 66835 RVA: 0x0008E686 File Offset: 0x0008C886
			public unsafe bool forceTempPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_forceTempPanel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr_forceTempPanel)) = value;
				}
			}

			// Token: 0x17005559 RID: 21849
			// (get) Token: 0x06010514 RID: 66836 RVA: 0x003CB580 File Offset: 0x003C9780
			// (set) Token: 0x06010515 RID: 66837 RVA: 0x0008E6A1 File Offset: 0x0008C8A1
			public UniTask<IGameObjectAssetHandle<T>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___u__1);
					return new UniTask<IGameObjectAssetHandle<T>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<T>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager._LoadAndPreparePanelScoped_d__149<T>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<T>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A556 RID: 42326
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A557 RID: 42327
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A558 RID: 42328
			private static readonly IntPtr NativeFieldInfoPtr_assetReference;

			// Token: 0x0400A559 RID: 42329
			private static readonly IntPtr NativeFieldInfoPtr_forceTempPanel;

			// Token: 0x0400A55A RID: 42330
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A55B RID: 42331
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A55C RID: 42332
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000E2D RID: 3629
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass155_0")]
		public sealed class __c__DisplayClass155_0 : Il2CppSystem.Object
		{
			// Token: 0x06010516 RID: 66838 RVA: 0x003CB5B0 File Offset: 0x003C97B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass155_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass155_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass155_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr, 100684607);
				UniversalGameManager.__c__DisplayClass155_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr, 100684608);
			}

			// Token: 0x06010517 RID: 66839 RVA: 0x003CB618 File Offset: 0x003C9818
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass155_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010518 RID: 66840 RVA: 0x003CB654 File Offset: 0x003C9854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260631, XrefRangeEnd = 260637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass155_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06010519 RID: 66841 RVA: 0x0008E6CF File Offset: 0x0008C8CF
			public __c__DisplayClass155_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700555A RID: 21850
			// (get) Token: 0x0601051A RID: 66842 RVA: 0x003CB68C File Offset: 0x003C988C
			// (set) Token: 0x0601051B RID: 66843 RVA: 0x0008E6D8 File Offset: 0x0008C8D8
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A55D RID: 42333
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A55E RID: 42334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A55F RID: 42335
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0;

			// Token: 0x020010AF RID: 4271
			[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass155_0+<<WaitDelayFrame>g__WaitFrameToCloseTask|0>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique : ValueType
			{
				// Token: 0x060122AB RID: 74411 RVA: 0x00424CDC File Offset: 0x00422EDC
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
				{
					Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0>.NativeClassPtr, "<<WaitDelayFrame>g__WaitFrameToCloseTask|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr);
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>1__state");
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>t__builder");
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>4__this");
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>u__1");
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100684609);
					UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100684610);
				}

				// Token: 0x060122AC RID: 74412 RVA: 0x00424D80 File Offset: 0x00422F80
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 260628, RefRangeEnd = 260631, XrefRangeStart = 260622, XrefRangeEnd = 260628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122AD RID: 74413 RVA: 0x00424DB8 File Offset: 0x00422FB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122AE RID: 74414 RVA: 0x0009DB3C File Offset: 0x0009BD3C
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060122AF RID: 74415 RVA: 0x0009DB45 File Offset: 0x0009BD45
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005F02 RID: 24322
				// (get) Token: 0x060122B0 RID: 74416 RVA: 0x00424E00 File Offset: 0x00423000
				// (set) Token: 0x060122B1 RID: 74417 RVA: 0x0009DB57 File Offset: 0x0009BD57
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F03 RID: 24323
				// (get) Token: 0x060122B2 RID: 74418 RVA: 0x00424E28 File Offset: 0x00423028
				// (set) Token: 0x060122B3 RID: 74419 RVA: 0x0009DB72 File Offset: 0x0009BD72
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005F04 RID: 24324
				// (get) Token: 0x060122B4 RID: 74420 RVA: 0x00424E58 File Offset: 0x00423058
				// (set) Token: 0x060122B5 RID: 74421 RVA: 0x0009DBA0 File Offset: 0x0009BDA0
				public unsafe UniversalGameManager.__c__DisplayClass155_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGameManager.__c__DisplayClass155_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F05 RID: 24325
				// (get) Token: 0x060122B6 RID: 74422 RVA: 0x00424E88 File Offset: 0x00423088
				// (set) Token: 0x060122B7 RID: 74423 RVA: 0x0009DBBF File Offset: 0x0009BDBF
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass155_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B82B RID: 47147
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B82C RID: 47148
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B82D RID: 47149
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B82E RID: 47150
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B82F RID: 47151
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B830 RID: 47152
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000E2E RID: 3630
		[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass156_0")]
		public sealed class __c__DisplayClass156_0 : Il2CppSystem.Object
		{
			// Token: 0x0601051C RID: 66844 RVA: 0x003CB6BC File Offset: 0x003C98BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass156_0()
			{
				Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr, "<>c__DisplayClass156_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr);
				UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_delaySecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr, "delaySecond");
				UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr, "onFinishCallback");
				UniversalGameManager.__c__DisplayClass156_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr, 100684611);
				UniversalGameManager.__c__DisplayClass156_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr, 100684612);
			}

			// Token: 0x0601051D RID: 66845 RVA: 0x003CB738 File Offset: 0x003C9938
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass156_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass156_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601051E RID: 66846 RVA: 0x003CB774 File Offset: 0x003C9974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260646, XrefRangeEnd = 260652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask Method_Internal_UniTask_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass156_0.NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x0601051F RID: 66847 RVA: 0x0008E6F7 File Offset: 0x0008C8F7
			public __c__DisplayClass156_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700555B RID: 21851
			// (get) Token: 0x06010520 RID: 66848 RVA: 0x003CB7AC File Offset: 0x003C99AC
			// (set) Token: 0x06010521 RID: 66849 RVA: 0x0008E700 File Offset: 0x0008C900
			public unsafe float delaySecond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_delaySecond);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_delaySecond)) = value;
				}
			}

			// Token: 0x1700555C RID: 21852
			// (get) Token: 0x06010522 RID: 66850 RVA: 0x003CB7D4 File Offset: 0x003C99D4
			// (set) Token: 0x06010523 RID: 66851 RVA: 0x0008E71B File Offset: 0x0008C91B
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A560 RID: 42336
			private static readonly IntPtr NativeFieldInfoPtr_delaySecond;

			// Token: 0x0400A561 RID: 42337
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A562 RID: 42338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A563 RID: 42339
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTask_PDM_0;

			// Token: 0x020010B0 RID: 4272
			[ObfuscatedName("Common.UI.UniversalGameManager+<>c__DisplayClass156_0+<<WaitDelay>g__WaitFrameToCloseTask|0>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique : ValueType
			{
				// Token: 0x060122B8 RID: 74424 RVA: 0x00424EB8 File Offset: 0x004230B8
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique()
				{
					Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0>.NativeClassPtr, "<<WaitDelay>g__WaitFrameToCloseTask|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr);
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>1__state");
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>t__builder");
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>4__this");
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, "<>u__1");
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100684613);
					UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr, 100684614);
				}

				// Token: 0x060122B9 RID: 74425 RVA: 0x00424F5C File Offset: 0x0042315C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 260643, RefRangeEnd = 260646, XrefRangeStart = 260637, XrefRangeEnd = 260643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122BA RID: 74426 RVA: 0x00424F94 File Offset: 0x00423194
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060122BB RID: 74427 RVA: 0x0009DBED File Offset: 0x0009BDED
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060122BC RID: 74428 RVA: 0x0009DBF6 File Offset: 0x0009BDF6
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005F06 RID: 24326
				// (get) Token: 0x060122BD RID: 74429 RVA: 0x00424FDC File Offset: 0x004231DC
				// (set) Token: 0x060122BE RID: 74430 RVA: 0x0009DC08 File Offset: 0x0009BE08
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F07 RID: 24327
				// (get) Token: 0x060122BF RID: 74431 RVA: 0x00425004 File Offset: 0x00423204
				// (set) Token: 0x060122C0 RID: 74432 RVA: 0x0009DC23 File Offset: 0x0009BE23
				public AsyncUniTaskMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005F08 RID: 24328
				// (get) Token: 0x060122C1 RID: 74433 RVA: 0x00425034 File Offset: 0x00423234
				// (set) Token: 0x060122C2 RID: 74434 RVA: 0x0009DC51 File Offset: 0x0009BE51
				public unsafe UniversalGameManager.__c__DisplayClass156_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGameManager.__c__DisplayClass156_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F09 RID: 24329
				// (get) Token: 0x060122C3 RID: 74435 RVA: 0x00425064 File Offset: 0x00423264
				// (set) Token: 0x060122C4 RID: 74436 RVA: 0x0009DC70 File Offset: 0x0009BE70
				public UniTask.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1);
						return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGameManager.__c__DisplayClass156_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsAwUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B831 RID: 47153
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B832 RID: 47154
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B833 RID: 47155
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B834 RID: 47156
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B835 RID: 47157
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B836 RID: 47158
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000E2F RID: 3631
		private sealed class MethodInfoStoreGeneric_PrepareBufferedPanelWithRecord_Public_T_T_Action_1_T_String_0<T>
		{
			// Token: 0x0400A564 RID: 42340
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_PrepareBufferedPanelWithRecord_Public_T_T_Action_1_T_String_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E30 RID: 3632
		private sealed class MethodInfoStoreGeneric_PreBufferPanelWithRecord_Public_T_T_String_0<T>
		{
			// Token: 0x0400A565 RID: 42341
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_PreBufferPanelWithRecord_Public_T_T_String_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E31 RID: 3633
		private sealed class MethodInfoStoreGeneric_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0<T>
		{
			// Token: 0x0400A566 RID: 42342
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E32 RID: 3634
		private sealed class MethodInfoStoreGeneric_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0<T>
		{
			// Token: 0x0400A567 RID: 42343
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_1_Il2CppArrayBase_1_T_PanelVisualMode_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E33 RID: 3635
		private sealed class MethodInfoStoreGeneric_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0<T>
		{
			// Token: 0x0400A568 RID: 42344
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenu_Public_Static_Void_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E34 RID: 3636
		private sealed class MethodInfoStoreGeneric_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0<T>
		{
			// Token: 0x0400A569 RID: 42345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_OpenMultipleChoiceMenuAsyncInternal_Private_Static_UniTaskVoid_MultipleChoicePannelOpenContext_Action_2_Boolean_Il2CppArrayBase_1_T_PanelVisualMode_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E35 RID: 3637
		private sealed class MethodInfoStoreGeneric_OpenFilterPanel_Public_Static_UniTask_IReadOnlyList_1_FilterConfigFactory_1_T_List_1_IFilterConfig_0<T>
		{
			// Token: 0x0400A56A RID: 42346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_OpenFilterPanel_Public_Static_UniTask_IReadOnlyList_1_FilterConfigFactory_1_T_List_1_IFilterConfig_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E36 RID: 3638
		private sealed class MethodInfoStoreGeneric_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_Func_1_UniTask_1_T_0<T>
		{
			// Token: 0x0400A56B RID: 42347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_Func_1_UniTask_1_T_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E37 RID: 3639
		private sealed class MethodInfoStoreGeneric_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_UniTask_1_T_0<T>
		{
			// Token: 0x0400A56C RID: 42348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_RunWithLoadingIndicatorPanel_Public_Static_UniTask_1_T_UniTask_1_T_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E38 RID: 3640
		private sealed class MethodInfoStoreGeneric_LoadAndPreparePanelScoped_Public_Static_UniTask_1_T_AssetReference_Boolean_0<T>
		{
			// Token: 0x0400A56D RID: 42349
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_LoadAndPreparePanelScoped_Public_Static_UniTask_1_T_AssetReference_Boolean_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E39 RID: 3641
		private sealed class MethodInfoStoreGeneric_PrepareOrGetTempPanelInstance_Public_T_T_String_0<T>
		{
			// Token: 0x0400A56E RID: 42350
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_PrepareOrGetTempPanelInstance_Public_T_T_String_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E3A RID: 3642
		private sealed class MethodInfoStoreGeneric_PrepareOrGetTempPanelInstanceImpl_Private_T_T_AdpPanelLifetime_String_0<T>
		{
			// Token: 0x0400A56F RID: 42351
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_PrepareOrGetTempPanelInstanceImpl_Private_T_T_AdpPanelLifetime_String_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E3B RID: 3643
		private sealed class MethodInfoStoreGeneric_LoadPanelScoped_Public_Static_UniTask_1_IGameObjectAssetHandle_1_T_AssetReference_0<T>
		{
			// Token: 0x0400A570 RID: 42352
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_LoadPanelScoped_Public_Static_UniTask_1_IGameObjectAssetHandle_1_T_AssetReference_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E3C RID: 3644
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>
		{
			// Token: 0x0400A571 RID: 42353
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000E3D RID: 3645
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0<T>
		{
			// Token: 0x0400A572 RID: 42354
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UniversalGameManager.NativeMethodInfoPtr_Method_Internal_Static_UniTask_1_IGameObjectAssetHandle_1_T_Func_2_UniversalGameManager_AssetReference_0, Il2CppClassPointerStore<UniversalGameManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
