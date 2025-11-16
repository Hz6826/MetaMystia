using System;
using System.Runtime.InteropServices;
using Common.DialogUtility.History;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.DialogUtility
{
	// Token: 0x0200033E RID: 830
	public class DialogPannel : AsyncUIPanelExtern
	{
		// Token: 0x060062BA RID: 25274 RVA: 0x001E878C File Offset: 0x001E698C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogPannel()
		{
			Il2CppClassPointerStore<DialogPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "DialogPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr);
			DialogPannel.NativeFieldInfoPtr_UNKNOWN_CHARACTER_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "UNKNOWN_CHARACTER_NAME");
			DialogPannel.NativeFieldInfoPtr_COPY_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "COPY_SUCCESS");
			DialogPannel.NativeFieldInfoPtr_s_DialogHistories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "s_DialogHistories");
			DialogPannel.NativeFieldInfoPtr_s_GlobalDialogPackageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "s_GlobalDialogPackageCount");
			DialogPannel.NativeFieldInfoPtr_dialogHistoryPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "dialogHistoryPanel");
			DialogPannel.NativeFieldInfoPtr_leftChatacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "leftChatacter");
			DialogPannel.NativeFieldInfoPtr_leftChatacterShade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "leftChatacterShade");
			DialogPannel.NativeFieldInfoPtr_rightChatacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "rightChatacter");
			DialogPannel.NativeFieldInfoPtr_rightChatacterShade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "rightChatacterShade");
			DialogPannel.NativeFieldInfoPtr_nextProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "nextProgress");
			DialogPannel.NativeFieldInfoPtr_customSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "customSpacingRect");
			DialogPannel.NativeFieldInfoPtr_bg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "bg");
			DialogPannel.NativeFieldInfoPtr_cg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "cg");
			DialogPannel.NativeFieldInfoPtr_blackBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "blackBG");
			DialogPannel.NativeFieldInfoPtr_hidables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "hidables");
			DialogPannel.NativeFieldInfoPtr_bgArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "bgArea");
			DialogPannel.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "context");
			DialogPannel.NativeFieldInfoPtr_leftSpeakerNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "leftSpeakerNameField");
			DialogPannel.NativeFieldInfoPtr_rightSpeakerNameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "rightSpeakerNameField");
			DialogPannel.NativeFieldInfoPtr_leftSpeakerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "leftSpeakerName");
			DialogPannel.NativeFieldInfoPtr_rightSpeakerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "rightSpeakerName");
			DialogPannel.NativeFieldInfoPtr_startSkippingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "startSkippingOffset");
			DialogPannel.NativeFieldInfoPtr_charTypeFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "charTypeFrame");
			DialogPannel.NativeFieldInfoPtr_talkAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "talkAudio");
			DialogPannel.NativeFieldInfoPtr_selectionsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "selectionsParent");
			DialogPannel.NativeFieldInfoPtr_selectionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "selectionPannel");
			DialogPannel.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "highlightColor");
			DialogPannel.NativeFieldInfoPtr_hideOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "hideOnLoad");
			DialogPannel.NativeFieldInfoPtr_leftCharacterAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "leftCharacterAnimator");
			DialogPannel.NativeFieldInfoPtr_rightCharacterAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "rightCharacterAnimator");
			DialogPannel.NativeFieldInfoPtr_allSelectionInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "allSelectionInstances");
			DialogPannel.NativeFieldInfoPtr_m_AllSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_AllSelectionGroup");
			DialogPannel.NativeFieldInfoPtr_m_CurrentDialogDataForCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_CurrentDialogDataForCopy");
			DialogPannel.NativeFieldInfoPtr_nameOnStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "nameOnStage");
			DialogPannel.NativeFieldInfoPtr_portrayalOnStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "portrayalOnStage");
			DialogPannel.NativeFieldInfoPtr_canPlayFirstLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "canPlayFirstLine");
			DialogPannel.NativeFieldInfoPtr_dialogIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "dialogIsOpen");
			DialogPannel.NativeFieldInfoPtr_fastForwardMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "fastForwardMode");
			DialogPannel.NativeFieldInfoPtr_hasInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "hasInteracted");
			DialogPannel.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "initialized");
			DialogPannel.NativeFieldInfoPtr_contentStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "contentStringBuilder");
			DialogPannel.NativeFieldInfoPtr_m_IsHistoryPanelOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_IsHistoryPanelOpened");
			DialogPannel.NativeFieldInfoPtr_m_IsSelectionOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_IsSelectionOpen");
			DialogPannel.NativeFieldInfoPtr_m_ShouldInstantClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_ShouldInstantClose");
			DialogPannel.NativeFieldInfoPtr_m_StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_StringBuilder");
			DialogPannel.NativeFieldInfoPtr_shouldInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "shouldInterrupt");
			DialogPannel.NativeFieldInfoPtr_shouldKeepSkipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "shouldKeepSkipping");
			DialogPannel.NativeFieldInfoPtr_characterDrawAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "characterDrawAmount");
			DialogPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DialogPannel.NativeFieldInfoPtr__ExitCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<ExitCode>k__BackingField");
			DialogPannel.NativeFieldInfoPtr_m_LastPanelOpenStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_LastPanelOpenStack");
			DialogPannel.NativeFieldInfoPtr_m_ProtectionLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "m_ProtectionLock");
			DialogPannel.NativeMethodInfoPtr_set_LeftPortrayal_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684072);
			DialogPannel.NativeMethodInfoPtr_set_RightPortrayal_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684073);
			DialogPannel.NativeMethodInfoPtr_set_LeftPortrayalDark_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684074);
			DialogPannel.NativeMethodInfoPtr_set_RightPortrayalDark_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684075);
			DialogPannel.NativeMethodInfoPtr_set_BG_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684076);
			DialogPannel.NativeMethodInfoPtr_set_CG_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684077);
			DialogPannel.NativeMethodInfoPtr_set_SoundFx_Public_set_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684078);
			DialogPannel.NativeMethodInfoPtr_set_LeftPortrayalHighLight_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684079);
			DialogPannel.NativeMethodInfoPtr_set_RightPortrayalHighLight_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684080);
			DialogPannel.NativeMethodInfoPtr_set_LeftSpeakerName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684081);
			DialogPannel.NativeMethodInfoPtr_set_RightSpeakerName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684082);
			DialogPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684083);
			DialogPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_DialogPannelOpenContextBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684084);
			DialogPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DialogPannelOpenContextBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684085);
			DialogPannel.NativeMethodInfoPtr_get_ContentStringBuilder_Private_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684086);
			DialogPannel.NativeMethodInfoPtr_get_ExitCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684087);
			DialogPannel.NativeMethodInfoPtr_set_ExitCode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684088);
			DialogPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684089);
			DialogPannel.NativeMethodInfoPtr_ClearDialogHistories_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684090);
			DialogPannel.NativeMethodInfoPtr_ClearContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684091);
			DialogPannel.NativeMethodInfoPtr_SetContent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684092);
			DialogPannel.NativeMethodInfoPtr_AddContent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684093);
			DialogPannel.NativeMethodInfoPtr_SetContentMaxVisibleCharacters_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684094);
			DialogPannel.NativeMethodInfoPtr_SetPortrayal_Private_Void_Sprite_Image_Image_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684095);
			DialogPannel.NativeMethodInfoPtr_SetSpeakerName_Private_Void_String_TextMeshProUGUI_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684096);
			DialogPannel.NativeMethodInfoPtr_ToggleDialogUI_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684097);
			DialogPannel.NativeMethodInfoPtr_SetSkippingProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684098);
			DialogPannel.NativeMethodInfoPtr_ToggleOn_Private_DialogPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684099);
			DialogPannel.NativeMethodInfoPtr_ToggleOff_Private_DialogPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684100);
			DialogPannel.NativeMethodInfoPtr_SetCanPlayFirstLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684101);
			DialogPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684102);
			DialogPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684103);
			DialogPannel.NativeMethodInfoPtr_UpdateInputBinding_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684104);
			DialogPannel.NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684105);
			DialogPannel.NativeMethodInfoPtr_StartSkipTiming_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684106);
			DialogPannel.NativeMethodInfoPtr_EndSkipTiming_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684107);
			DialogPannel.NativeMethodInfoPtr_EndSkipTiming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684108);
			DialogPannel.NativeMethodInfoPtr_InterruptDialog_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684109);
			DialogPannel.NativeMethodInfoPtr_OpenHistoryPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684110);
			DialogPannel.NativeMethodInfoPtr_CleanAtPosition_Public_Void_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684111);
			DialogPannel.NativeMethodInfoPtr_ExecuteDialog_Private_IEnumerator_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684112);
			DialogPannel.NativeMethodInfoPtr_TrimNextContentSegment_Private_Int32_String_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684113);
			DialogPannel.NativeMethodInfoPtr_TypeFollowing_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684114);
			DialogPannel.NativeMethodInfoPtr_Copy_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684115);
			DialogPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684116);
			DialogPannel.NativeMethodInfoPtr_OnExecutingDialogLoopInternal_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_Func_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684117);
			DialogPannel.NativeMethodInfoPtr_OnExecutingDialogLoopCore_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684118);
			DialogPannel.NativeMethodInfoPtr_UpdateMetaPresentation_Private_Void_byref_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684119);
			DialogPannel.NativeMethodInfoPtr_GetSpeakerName_Private_Void_byref_String_DialogMeta_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684120);
			DialogPannel.NativeMethodInfoPtr_GetSpeakerVisual_Private_Void_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_byref_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684121);
			DialogPannel.NativeMethodInfoPtr_CheckAndApplyOverrideSprite_Private_Static_Boolean_byref_Sprite_byref_DialogMeta_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684122);
			DialogPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684123);
			DialogPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684124);
			DialogPannel.NativeMethodInfoPtr__UpdateInputBinding_b__97_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684126);
			DialogPannel.NativeMethodInfoPtr__UpdateInputBinding_b__97_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684127);
			DialogPannel.NativeMethodInfoPtr__StartSkipTiming_b__99_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684128);
			DialogPannel.NativeMethodInfoPtr__OpenHistoryPanel_b__103_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684129);
			DialogPannel.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, 100684130);
		}

		// Token: 0x17002229 RID: 8745
		// (set) Token: 0x060062BB RID: 25275 RVA: 0x001E9054 File Offset: 0x001E7254
		public unsafe Sprite LeftPortrayal
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 256345, RefRangeEnd = 256348, XrefRangeStart = 256330, XrefRangeEnd = 256345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_LeftPortrayal_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222A RID: 8746
		// (set) Token: 0x060062BC RID: 25276 RVA: 0x001E9098 File Offset: 0x001E7298
		public unsafe Sprite RightPortrayal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256363, RefRangeEnd = 256364, XrefRangeStart = 256348, XrefRangeEnd = 256363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_RightPortrayal_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222B RID: 8747
		// (set) Token: 0x060062BD RID: 25277 RVA: 0x001E90DC File Offset: 0x001E72DC
		public unsafe bool LeftPortrayalDark
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256365, RefRangeEnd = 256366, XrefRangeStart = 256364, XrefRangeEnd = 256365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_LeftPortrayalDark_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222C RID: 8748
		// (set) Token: 0x060062BE RID: 25278 RVA: 0x001E911C File Offset: 0x001E731C
		public unsafe bool RightPortrayalDark
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256367, RefRangeEnd = 256368, XrefRangeStart = 256366, XrefRangeEnd = 256367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_RightPortrayalDark_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222D RID: 8749
		// (set) Token: 0x060062BF RID: 25279 RVA: 0x001E915C File Offset: 0x001E735C
		public unsafe Sprite BG
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256368, XrefRangeEnd = 256406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_BG_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222E RID: 8750
		// (set) Token: 0x060062C0 RID: 25280 RVA: 0x001E91A0 File Offset: 0x001E73A0
		public unsafe Sprite CG
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256406, XrefRangeEnd = 256444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_CG_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700222F RID: 8751
		// (set) Token: 0x060062C1 RID: 25281 RVA: 0x001E91E4 File Offset: 0x001E73E4
		public unsafe AudioClip SoundFx
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256444, XrefRangeEnd = 256449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_SoundFx_Public_set_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002230 RID: 8752
		// (set) Token: 0x060062C2 RID: 25282 RVA: 0x001E9228 File Offset: 0x001E7428
		public unsafe bool LeftPortrayalHighLight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256453, RefRangeEnd = 256454, XrefRangeStart = 256449, XrefRangeEnd = 256453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_LeftPortrayalHighLight_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002231 RID: 8753
		// (set) Token: 0x060062C3 RID: 25283 RVA: 0x001E9268 File Offset: 0x001E7468
		public unsafe bool RightPortrayalHighLight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256454, XrefRangeEnd = 256458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_RightPortrayalHighLight_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002232 RID: 8754
		// (set) Token: 0x060062C4 RID: 25284 RVA: 0x001E92A8 File Offset: 0x001E74A8
		public unsafe string LeftSpeakerName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 256459, RefRangeEnd = 256462, XrefRangeStart = 256458, XrefRangeEnd = 256459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_LeftSpeakerName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002233 RID: 8755
		// (set) Token: 0x060062C5 RID: 25285 RVA: 0x001E92EC File Offset: 0x001E74EC
		public unsafe string RightSpeakerName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256463, RefRangeEnd = 256464, XrefRangeStart = 256462, XrefRangeEnd = 256463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_RightSpeakerName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x060062C6 RID: 25286 RVA: 0x001E9330 File Offset: 0x001E7530
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x001E9378 File Offset: 0x001E7578
		// (set) Token: 0x060062C8 RID: 25288 RVA: 0x001E93B8 File Offset: 0x001E75B8
		public unsafe DialogPannelOpenContextBase OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_DialogPannelOpenContextBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPannelOpenContextBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DialogPannelOpenContextBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x001E93FC File Offset: 0x001E75FC
		public unsafe StringBuilder ContentStringBuilder
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 256469, RefRangeEnd = 256476, XrefRangeStart = 256464, XrefRangeEnd = 256469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_get_ContentStringBuilder_Private_get_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x060062CA RID: 25290 RVA: 0x001E943C File Offset: 0x001E763C
		// (set) Token: 0x060062CB RID: 25291 RVA: 0x001E9478 File Offset: 0x001E7678
		public unsafe int ExitCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_get_ExitCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_set_ExitCode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x001E94B8 File Offset: 0x001E76B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256476, XrefRangeEnd = 256500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x001E94EC File Offset: 0x001E76EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256507, RefRangeEnd = 256508, XrefRangeStart = 256500, XrefRangeEnd = 256507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDialogHistories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ClearDialogHistories_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x001E9514 File Offset: 0x001E7714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256508, XrefRangeEnd = 256512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ClearContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x001E9548 File Offset: 0x001E7748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256519, RefRangeEnd = 256520, XrefRangeStart = 256512, XrefRangeEnd = 256519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContent(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetContent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x001E958C File Offset: 0x001E778C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256520, XrefRangeEnd = 256524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContent(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_AddContent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x001E95D0 File Offset: 0x001E77D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256526, RefRangeEnd = 256527, XrefRangeStart = 256524, XrefRangeEnd = 256526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContentMaxVisibleCharacters(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetContentMaxVisibleCharacters_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x001E9610 File Offset: 0x001E7810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256527, XrefRangeEnd = 256542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPortrayal(Sprite value, Image character, Image characterShade, Animator animator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterShade);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetPortrayal_Private_Void_Sprite_Image_Image_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x001E968C File Offset: 0x001E788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256542, XrefRangeEnd = 256543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpeakerName(string name, TextMeshProUGUI speaker, GameObject speakerNameField)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(speaker);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(speakerNameField);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetSpeakerName_Private_Void_String_TextMeshProUGUI_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x001E96F4 File Offset: 0x001E78F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256543, XrefRangeEnd = 256544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleDialogUI(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ToggleDialogUI_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x001E973C File Offset: 0x001E793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256546, RefRangeEnd = 256547, XrefRangeStart = 256544, XrefRangeEnd = 256546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkippingProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetSkippingProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x001E977C File Offset: 0x001E797C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256553, RefRangeEnd = 256555, XrefRangeStart = 256547, XrefRangeEnd = 256553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPannel ToggleOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ToggleOn_Private_DialogPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr3) : null;
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x001E97BC File Offset: 0x001E79BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256561, RefRangeEnd = 256562, XrefRangeStart = 256555, XrefRangeEnd = 256561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPannel ToggleOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ToggleOff_Private_DialogPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr3) : null;
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x001E97FC File Offset: 0x001E79FC
		[CallerCount(0)]
		public unsafe void SetCanPlayFirstLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_SetCanPlayFirstLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x001E9830 File Offset: 0x001E7A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256562, XrefRangeEnd = 256563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x001E986C File Offset: 0x001E7A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256563, XrefRangeEnd = 256564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x001E98B4 File Offset: 0x001E7AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256651, RefRangeEnd = 256652, XrefRangeStart = 256564, XrefRangeEnd = 256651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputBinding(bool shouldBind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldBind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_UpdateInputBinding_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x001E98F4 File Offset: 0x001E7AF4
		[CallerCount(0)]
		public unsafe void Interact(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x001E993C File Offset: 0x001E7B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256652, XrefRangeEnd = 256665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSkipTiming(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_StartSkipTiming_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x001E9984 File Offset: 0x001E7B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256667, RefRangeEnd = 256668, XrefRangeStart = 256665, XrefRangeEnd = 256667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSkipTiming(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_EndSkipTiming_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x001E99CC File Offset: 0x001E7BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256667, RefRangeEnd = 256668, XrefRangeStart = 256667, XrefRangeEnd = 256668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSkipTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_EndSkipTiming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x001E9A00 File Offset: 0x001E7C00
		[CallerCount(0)]
		public unsafe void InterruptDialog(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_InterruptDialog_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x001E9A48 File Offset: 0x001E7C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256693, RefRangeEnd = 256695, XrefRangeStart = 256668, XrefRangeEnd = 256693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenHistoryPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_OpenHistoryPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x001E9A7C File Offset: 0x001E7C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256695, XrefRangeEnd = 256697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanAtPosition(Position position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_CleanAtPosition_Public_Void_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x001E9ABC File Offset: 0x001E7CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256697, XrefRangeEnd = 256704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteDialog(string dialogContext, bool needToExitOnLastLine, string speakerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogContext);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needToExitOnLastLine;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(speakerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_ExecuteDialog_Private_IEnumerator_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x001E9B2C File Offset: 0x001E7D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256704, XrefRangeEnd = 256739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TrimNextContentSegment(string line, int currentPlayIndex, out bool isFunctionalTrim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPlayIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isFunctionalTrim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_TrimNextContentSegment_Private_Int32_String_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x001E9B98 File Offset: 0x001E7D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256744, RefRangeEnd = 256745, XrefRangeStart = 256739, XrefRangeEnd = 256744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TypeFollowing(int showNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_TypeFollowing_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x001E9BE4 File Offset: 0x001E7DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256745, XrefRangeEnd = 256777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_Copy_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x001E9C2C File Offset: 0x001E7E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256777, XrefRangeEnd = 256783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTaskVoid OnPanelOpenAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannel.NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x001E9C74 File Offset: 0x001E7E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256794, RefRangeEnd = 256796, XrefRangeStart = 256783, XrefRangeEnd = 256794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnExecutingDialogLoopInternal(IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>> dialogPack, IReadOnlyDictionary<int, string> textFile, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, Func<bool> onCanExecuteFirstLineCalllback, bool blackBG)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPack);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerPortrayalCollection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialNPCPortrayalCollectionDictionary);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideDialogMetaToSprites);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCanExecuteFirstLineCalllback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackBG;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_OnExecutingDialogLoopInternal_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_Func_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x001E9D30 File Offset: 0x001E7F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256796, XrefRangeEnd = 256806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnExecutingDialogLoopCore(IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>> dialogPack, IReadOnlyDictionary<int, string> textFile, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPack);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerPortrayalCollection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialNPCPortrayalCollectionDictionary);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideDialogMetaToSprites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_OnExecutingDialogLoopCore_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x001E9DCC File Offset: 0x001E7FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256806, XrefRangeEnd = 256880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMetaPresentation(ref string line, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>> data, out string speakerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(line);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerPortrayalCollection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialNPCPortrayalCollectionDictionary);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideDialogMetaToSprites);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_UpdateMetaPresentation_Private_Void_byref_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			line = IL2CPP.Il2CppStringToManaged(intPtr);
			speakerName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x001E9E88 File Offset: 0x001E8088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256914, RefRangeEnd = 256916, XrefRangeStart = 256880, XrefRangeEnd = 256914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpeakerName(ref string line, DialogMeta meta, out string speakerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(line);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(meta));
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_GetSpeakerName_Private_Void_byref_String_DialogMeta_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			line = IL2CPP.Il2CppStringToManaged(intPtr);
			speakerName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x001E9F0C File Offset: 0x001E810C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256926, RefRangeEnd = 256927, XrefRangeStart = 256916, XrefRangeEnd = 256926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpeakerVisual(IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, DialogMeta meta, out Sprite visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerPortrayalCollection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialNPCPortrayalCollectionDictionary);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideDialogMetaToSprites);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(meta));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_GetSpeakerVisual_Private_Void_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_byref_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			visual = ((intPtr4 == 0) ? null : new Sprite(intPtr4));
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x001E9FAC File Offset: 0x001E81AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256937, RefRangeEnd = 256938, XrefRangeStart = 256927, XrefRangeEnd = 256937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckAndApplyOverrideSprite(ref Sprite visual, [In] ref DialogMeta dialogMeta, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dialogMeta);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideDialogMetaToSprites);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_CheckAndApplyOverrideSprite_Private_Static_Boolean_byref_Sprite_byref_DialogMeta_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			visual = ((intPtr4 == 0) ? null : new Sprite(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x001EA02C File Offset: 0x001E822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256938, XrefRangeEnd = 256976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x001EA068 File Offset: 0x001E8268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256976, XrefRangeEnd = 257014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x001EA0A4 File Offset: 0x001E82A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257014, XrefRangeEnd = 257019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateInputBinding_b__97_0(InputAction.CallbackContext call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(call));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr__UpdateInputBinding_b__97_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x001EA0EC File Offset: 0x001E82EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257019, XrefRangeEnd = 257023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateInputBinding_b__97_1(InputAction.CallbackContext call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(call));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr__UpdateInputBinding_b__97_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x001EA134 File Offset: 0x001E8334
		[CallerCount(0)]
		public unsafe void _StartSkipTiming_b__99_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr__StartSkipTiming_b__99_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x001EA168 File Offset: 0x001E8368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257023, XrefRangeEnd = 257024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenHistoryPanel_b__103_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr__OpenHistoryPanel_b__103_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x001EA19C File Offset: 0x001E839C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257024, XrefRangeEnd = 257081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_String_String_String_String_PDM_0(string title, string indexer, string value, string referenceName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(indexer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(referenceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_String_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x00035542 File Offset: 0x00033742
		public DialogPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x001EA210 File Offset: 0x001E8410
		// (set) Token: 0x060062F7 RID: 25335 RVA: 0x0003554B File Offset: 0x0003374B
		public unsafe static string UNKNOWN_CHARACTER_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogPannel.NativeFieldInfoPtr_UNKNOWN_CHARACTER_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogPannel.NativeFieldInfoPtr_UNKNOWN_CHARACTER_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x001EA230 File Offset: 0x001E8430
		// (set) Token: 0x060062F9 RID: 25337 RVA: 0x0003555D File Offset: 0x0003375D
		public unsafe static string COPY_SUCCESS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogPannel.NativeFieldInfoPtr_COPY_SUCCESS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogPannel.NativeFieldInfoPtr_COPY_SUCCESS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x001EA250 File Offset: 0x001E8450
		// (set) Token: 0x060062FB RID: 25339 RVA: 0x0003556F File Offset: 0x0003376F
		public unsafe static List<DialogHistory> s_DialogHistories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogPannel.NativeFieldInfoPtr_s_DialogHistories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogHistory>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogPannel.NativeFieldInfoPtr_s_DialogHistories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x001EA278 File Offset: 0x001E8478
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x00035581 File Offset: 0x00033781
		public unsafe static uint s_GlobalDialogPackageCount
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(DialogPannel.NativeFieldInfoPtr_s_GlobalDialogPackageCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogPannel.NativeFieldInfoPtr_s_GlobalDialogPackageCount, (void*)(&value));
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x001EA294 File Offset: 0x001E8494
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x0003558F File Offset: 0x0003378F
		public unsafe DialogHistoryPanel dialogHistoryPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_dialogHistoryPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogHistoryPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_dialogHistoryPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x001EA2C4 File Offset: 0x001E84C4
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x000355AE File Offset: 0x000337AE
		public unsafe Image leftChatacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftChatacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftChatacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x001EA2F4 File Offset: 0x001E84F4
		// (set) Token: 0x06006303 RID: 25347 RVA: 0x000355CD File Offset: 0x000337CD
		public unsafe Image leftChatacterShade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftChatacterShade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftChatacterShade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06006304 RID: 25348 RVA: 0x001EA324 File Offset: 0x001E8524
		// (set) Token: 0x06006305 RID: 25349 RVA: 0x000355EC File Offset: 0x000337EC
		public unsafe Image rightChatacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightChatacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightChatacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06006306 RID: 25350 RVA: 0x001EA354 File Offset: 0x001E8554
		// (set) Token: 0x06006307 RID: 25351 RVA: 0x0003560B File Offset: 0x0003380B
		public unsafe Image rightChatacterShade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightChatacterShade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightChatacterShade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06006308 RID: 25352 RVA: 0x001EA384 File Offset: 0x001E8584
		// (set) Token: 0x06006309 RID: 25353 RVA: 0x0003562A File Offset: 0x0003382A
		public unsafe Image nextProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_nextProgress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_nextProgress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x0600630A RID: 25354 RVA: 0x001EA3B4 File Offset: 0x001E85B4
		// (set) Token: 0x0600630B RID: 25355 RVA: 0x00035649 File Offset: 0x00033849
		public unsafe RectTransform customSpacingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_customSpacingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_customSpacingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x001EA3E4 File Offset: 0x001E85E4
		// (set) Token: 0x0600630D RID: 25357 RVA: 0x00035668 File Offset: 0x00033868
		public unsafe Image bg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_bg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_bg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x001EA414 File Offset: 0x001E8614
		// (set) Token: 0x0600630F RID: 25359 RVA: 0x00035687 File Offset: 0x00033887
		public unsafe Image cg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_cg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_cg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x001EA444 File Offset: 0x001E8644
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x000356A6 File Offset: 0x000338A6
		public unsafe Sprite blackBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_blackBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_blackBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x001EA474 File Offset: 0x001E8674
		// (set) Token: 0x06006313 RID: 25363 RVA: 0x000356C5 File Offset: 0x000338C5
		public unsafe Il2CppReferenceArray<CanvasGroup> hidables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hidables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hidables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x001EA4A4 File Offset: 0x001E86A4
		// (set) Token: 0x06006315 RID: 25365 RVA: 0x000356E4 File Offset: 0x000338E4
		public unsafe Il2CppReferenceArray<CanvasGroup> bgArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_bgArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_bgArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x001EA4D4 File Offset: 0x001E86D4
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x00035703 File Offset: 0x00033903
		public unsafe TextMeshProUGUI context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x001EA504 File Offset: 0x001E8704
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x00035722 File Offset: 0x00033922
		public unsafe GameObject leftSpeakerNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftSpeakerNameField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftSpeakerNameField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x001EA534 File Offset: 0x001E8734
		// (set) Token: 0x0600631B RID: 25371 RVA: 0x00035741 File Offset: 0x00033941
		public unsafe GameObject rightSpeakerNameField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightSpeakerNameField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightSpeakerNameField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x001EA564 File Offset: 0x001E8764
		// (set) Token: 0x0600631D RID: 25373 RVA: 0x00035760 File Offset: 0x00033960
		public unsafe TextMeshProUGUI leftSpeakerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftSpeakerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftSpeakerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600631E RID: 25374 RVA: 0x001EA594 File Offset: 0x001E8794
		// (set) Token: 0x0600631F RID: 25375 RVA: 0x0003577F File Offset: 0x0003397F
		public unsafe TextMeshProUGUI rightSpeakerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightSpeakerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightSpeakerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x001EA5C4 File Offset: 0x001E87C4
		// (set) Token: 0x06006321 RID: 25377 RVA: 0x0003579E File Offset: 0x0003399E
		public unsafe float startSkippingOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_startSkippingOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_startSkippingOffset)) = value;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06006322 RID: 25378 RVA: 0x001EA5EC File Offset: 0x001E87EC
		// (set) Token: 0x06006323 RID: 25379 RVA: 0x000357B9 File Offset: 0x000339B9
		public unsafe int charTypeFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_charTypeFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_charTypeFrame)) = value;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x001EA614 File Offset: 0x001E8814
		// (set) Token: 0x06006325 RID: 25381 RVA: 0x000357D4 File Offset: 0x000339D4
		public unsafe AudioClip talkAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_talkAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_talkAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06006326 RID: 25382 RVA: 0x001EA644 File Offset: 0x001E8844
		// (set) Token: 0x06006327 RID: 25383 RVA: 0x000357F3 File Offset: 0x000339F3
		public unsafe GameObject selectionsParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_selectionsParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_selectionsParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x001EA674 File Offset: 0x001E8874
		// (set) Token: 0x06006329 RID: 25385 RVA: 0x00035812 File Offset: 0x00033A12
		public unsafe CanvasGroup selectionPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_selectionPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_selectionPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x0600632A RID: 25386 RVA: 0x001EA6A4 File Offset: 0x001E88A4
		// (set) Token: 0x0600632B RID: 25387 RVA: 0x00035831 File Offset: 0x00033A31
		public unsafe Color highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600632C RID: 25388 RVA: 0x001EA6CC File Offset: 0x001E88CC
		// (set) Token: 0x0600632D RID: 25389 RVA: 0x0003584C File Offset: 0x00033A4C
		public unsafe GameObject hideOnLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hideOnLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hideOnLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x001EA6FC File Offset: 0x001E88FC
		// (set) Token: 0x0600632F RID: 25391 RVA: 0x0003586B File Offset: 0x00033A6B
		public unsafe Animator leftCharacterAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftCharacterAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_leftCharacterAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x001EA72C File Offset: 0x001E892C
		// (set) Token: 0x06006331 RID: 25393 RVA: 0x0003588A File Offset: 0x00033A8A
		public unsafe Animator rightCharacterAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightCharacterAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_rightCharacterAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06006332 RID: 25394 RVA: 0x001EA75C File Offset: 0x001E895C
		// (set) Token: 0x06006333 RID: 25395 RVA: 0x000358A9 File Offset: 0x00033AA9
		public unsafe List<GameObject> allSelectionInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_allSelectionInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_allSelectionInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06006334 RID: 25396 RVA: 0x001EA78C File Offset: 0x001E898C
		// (set) Token: 0x06006335 RID: 25397 RVA: 0x000358C8 File Offset: 0x00033AC8
		public unsafe UILogicalGroup m_AllSelectionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_AllSelectionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_AllSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x001EA7BC File Offset: 0x001E89BC
		// (set) Token: 0x06006337 RID: 25399 RVA: 0x000358E7 File Offset: 0x00033AE7
		public unsafe List<ValueTuple<DialogMeta, string>> m_CurrentDialogDataForCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_CurrentDialogDataForCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<DialogMeta, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_CurrentDialogDataForCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06006338 RID: 25400 RVA: 0x001EA7EC File Offset: 0x001E89EC
		// (set) Token: 0x06006339 RID: 25401 RVA: 0x00035906 File Offset: 0x00033B06
		public unsafe Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position> nameOnStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_nameOnStage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_nameOnStage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600633A RID: 25402 RVA: 0x001EA81C File Offset: 0x001E8A1C
		// (set) Token: 0x0600633B RID: 25403 RVA: 0x00035925 File Offset: 0x00033B25
		public unsafe Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position> portrayalOnStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_portrayalOnStage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_portrayalOnStage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x001EA84C File Offset: 0x001E8A4C
		// (set) Token: 0x0600633D RID: 25405 RVA: 0x00035944 File Offset: 0x00033B44
		public unsafe bool canPlayFirstLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_canPlayFirstLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_canPlayFirstLine)) = value;
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x001EA874 File Offset: 0x001E8A74
		// (set) Token: 0x0600633F RID: 25407 RVA: 0x0003595F File Offset: 0x00033B5F
		public unsafe bool dialogIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_dialogIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_dialogIsOpen)) = value;
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x001EA89C File Offset: 0x001E8A9C
		// (set) Token: 0x06006341 RID: 25409 RVA: 0x0003597A File Offset: 0x00033B7A
		public unsafe bool fastForwardMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_fastForwardMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_fastForwardMode)) = value;
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x001EA8C4 File Offset: 0x001E8AC4
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x00035995 File Offset: 0x00033B95
		public unsafe bool hasInteracted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hasInteracted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_hasInteracted)) = value;
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x001EA8EC File Offset: 0x001E8AEC
		// (set) Token: 0x06006345 RID: 25413 RVA: 0x000359B0 File Offset: 0x00033BB0
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x001EA914 File Offset: 0x001E8B14
		// (set) Token: 0x06006347 RID: 25415 RVA: 0x000359CB File Offset: 0x00033BCB
		public unsafe StringBuilder contentStringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_contentStringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_contentStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06006348 RID: 25416 RVA: 0x001EA944 File Offset: 0x001E8B44
		// (set) Token: 0x06006349 RID: 25417 RVA: 0x000359EA File Offset: 0x00033BEA
		public unsafe bool m_IsHistoryPanelOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_IsHistoryPanelOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_IsHistoryPanelOpened)) = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600634A RID: 25418 RVA: 0x001EA96C File Offset: 0x001E8B6C
		// (set) Token: 0x0600634B RID: 25419 RVA: 0x00035A05 File Offset: 0x00033C05
		public unsafe bool m_IsSelectionOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_IsSelectionOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_IsSelectionOpen)) = value;
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600634C RID: 25420 RVA: 0x001EA994 File Offset: 0x001E8B94
		// (set) Token: 0x0600634D RID: 25421 RVA: 0x00035A20 File Offset: 0x00033C20
		public unsafe bool m_ShouldInstantClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_ShouldInstantClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_ShouldInstantClose)) = value;
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600634E RID: 25422 RVA: 0x001EA9BC File Offset: 0x001E8BBC
		// (set) Token: 0x0600634F RID: 25423 RVA: 0x00035A3B File Offset: 0x00033C3B
		public unsafe StringBuilder m_StringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_StringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_StringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x001EA9EC File Offset: 0x001E8BEC
		// (set) Token: 0x06006351 RID: 25425 RVA: 0x00035A5A File Offset: 0x00033C5A
		public unsafe bool shouldInterrupt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_shouldInterrupt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_shouldInterrupt)) = value;
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x001EAA14 File Offset: 0x001E8C14
		// (set) Token: 0x06006353 RID: 25427 RVA: 0x00035A75 File Offset: 0x00033C75
		public unsafe bool shouldKeepSkipping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_shouldKeepSkipping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_shouldKeepSkipping)) = value;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06006354 RID: 25428 RVA: 0x001EAA3C File Offset: 0x001E8C3C
		// (set) Token: 0x06006355 RID: 25429 RVA: 0x00035A90 File Offset: 0x00033C90
		public unsafe int characterDrawAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_characterDrawAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_characterDrawAmount)) = value;
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x001EAA64 File Offset: 0x001E8C64
		// (set) Token: 0x06006357 RID: 25431 RVA: 0x00035AAB File Offset: 0x00033CAB
		public unsafe DialogPannelOpenContextBase _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannelOpenContextBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x001EAA94 File Offset: 0x001E8C94
		// (set) Token: 0x06006359 RID: 25433 RVA: 0x00035ACA File Offset: 0x00033CCA
		public unsafe int _ExitCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr__ExitCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr__ExitCode_k__BackingField)) = value;
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x001EAABC File Offset: 0x001E8CBC
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x00035AE5 File Offset: 0x00033CE5
		public unsafe string m_LastPanelOpenStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_LastPanelOpenStack);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_LastPanelOpenStack), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x001EAAE4 File Offset: 0x001E8CE4
		// (set) Token: 0x0600635D RID: 25437 RVA: 0x00035B04 File Offset: 0x00033D04
		public unsafe bool m_ProtectionLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_ProtectionLock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.NativeFieldInfoPtr_m_ProtectionLock)) = value;
			}
		}

		// Token: 0x04004173 RID: 16755
		private static readonly IntPtr NativeFieldInfoPtr_UNKNOWN_CHARACTER_NAME;

		// Token: 0x04004174 RID: 16756
		private static readonly IntPtr NativeFieldInfoPtr_COPY_SUCCESS;

		// Token: 0x04004175 RID: 16757
		private static readonly IntPtr NativeFieldInfoPtr_s_DialogHistories;

		// Token: 0x04004176 RID: 16758
		private static readonly IntPtr NativeFieldInfoPtr_s_GlobalDialogPackageCount;

		// Token: 0x04004177 RID: 16759
		private static readonly IntPtr NativeFieldInfoPtr_dialogHistoryPanel;

		// Token: 0x04004178 RID: 16760
		private static readonly IntPtr NativeFieldInfoPtr_leftChatacter;

		// Token: 0x04004179 RID: 16761
		private static readonly IntPtr NativeFieldInfoPtr_leftChatacterShade;

		// Token: 0x0400417A RID: 16762
		private static readonly IntPtr NativeFieldInfoPtr_rightChatacter;

		// Token: 0x0400417B RID: 16763
		private static readonly IntPtr NativeFieldInfoPtr_rightChatacterShade;

		// Token: 0x0400417C RID: 16764
		private static readonly IntPtr NativeFieldInfoPtr_nextProgress;

		// Token: 0x0400417D RID: 16765
		private static readonly IntPtr NativeFieldInfoPtr_customSpacingRect;

		// Token: 0x0400417E RID: 16766
		private static readonly IntPtr NativeFieldInfoPtr_bg;

		// Token: 0x0400417F RID: 16767
		private static readonly IntPtr NativeFieldInfoPtr_cg;

		// Token: 0x04004180 RID: 16768
		private static readonly IntPtr NativeFieldInfoPtr_blackBG;

		// Token: 0x04004181 RID: 16769
		private static readonly IntPtr NativeFieldInfoPtr_hidables;

		// Token: 0x04004182 RID: 16770
		private static readonly IntPtr NativeFieldInfoPtr_bgArea;

		// Token: 0x04004183 RID: 16771
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04004184 RID: 16772
		private static readonly IntPtr NativeFieldInfoPtr_leftSpeakerNameField;

		// Token: 0x04004185 RID: 16773
		private static readonly IntPtr NativeFieldInfoPtr_rightSpeakerNameField;

		// Token: 0x04004186 RID: 16774
		private static readonly IntPtr NativeFieldInfoPtr_leftSpeakerName;

		// Token: 0x04004187 RID: 16775
		private static readonly IntPtr NativeFieldInfoPtr_rightSpeakerName;

		// Token: 0x04004188 RID: 16776
		private static readonly IntPtr NativeFieldInfoPtr_startSkippingOffset;

		// Token: 0x04004189 RID: 16777
		private static readonly IntPtr NativeFieldInfoPtr_charTypeFrame;

		// Token: 0x0400418A RID: 16778
		private static readonly IntPtr NativeFieldInfoPtr_talkAudio;

		// Token: 0x0400418B RID: 16779
		private static readonly IntPtr NativeFieldInfoPtr_selectionsParent;

		// Token: 0x0400418C RID: 16780
		private static readonly IntPtr NativeFieldInfoPtr_selectionPannel;

		// Token: 0x0400418D RID: 16781
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x0400418E RID: 16782
		private static readonly IntPtr NativeFieldInfoPtr_hideOnLoad;

		// Token: 0x0400418F RID: 16783
		private static readonly IntPtr NativeFieldInfoPtr_leftCharacterAnimator;

		// Token: 0x04004190 RID: 16784
		private static readonly IntPtr NativeFieldInfoPtr_rightCharacterAnimator;

		// Token: 0x04004191 RID: 16785
		private static readonly IntPtr NativeFieldInfoPtr_allSelectionInstances;

		// Token: 0x04004192 RID: 16786
		private static readonly IntPtr NativeFieldInfoPtr_m_AllSelectionGroup;

		// Token: 0x04004193 RID: 16787
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDialogDataForCopy;

		// Token: 0x04004194 RID: 16788
		private static readonly IntPtr NativeFieldInfoPtr_nameOnStage;

		// Token: 0x04004195 RID: 16789
		private static readonly IntPtr NativeFieldInfoPtr_portrayalOnStage;

		// Token: 0x04004196 RID: 16790
		private static readonly IntPtr NativeFieldInfoPtr_canPlayFirstLine;

		// Token: 0x04004197 RID: 16791
		private static readonly IntPtr NativeFieldInfoPtr_dialogIsOpen;

		// Token: 0x04004198 RID: 16792
		private static readonly IntPtr NativeFieldInfoPtr_fastForwardMode;

		// Token: 0x04004199 RID: 16793
		private static readonly IntPtr NativeFieldInfoPtr_hasInteracted;

		// Token: 0x0400419A RID: 16794
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400419B RID: 16795
		private static readonly IntPtr NativeFieldInfoPtr_contentStringBuilder;

		// Token: 0x0400419C RID: 16796
		private static readonly IntPtr NativeFieldInfoPtr_m_IsHistoryPanelOpened;

		// Token: 0x0400419D RID: 16797
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSelectionOpen;

		// Token: 0x0400419E RID: 16798
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldInstantClose;

		// Token: 0x0400419F RID: 16799
		private static readonly IntPtr NativeFieldInfoPtr_m_StringBuilder;

		// Token: 0x040041A0 RID: 16800
		private static readonly IntPtr NativeFieldInfoPtr_shouldInterrupt;

		// Token: 0x040041A1 RID: 16801
		private static readonly IntPtr NativeFieldInfoPtr_shouldKeepSkipping;

		// Token: 0x040041A2 RID: 16802
		private static readonly IntPtr NativeFieldInfoPtr_characterDrawAmount;

		// Token: 0x040041A3 RID: 16803
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x040041A4 RID: 16804
		private static readonly IntPtr NativeFieldInfoPtr__ExitCode_k__BackingField;

		// Token: 0x040041A5 RID: 16805
		private static readonly IntPtr NativeFieldInfoPtr_m_LastPanelOpenStack;

		// Token: 0x040041A6 RID: 16806
		private static readonly IntPtr NativeFieldInfoPtr_m_ProtectionLock;

		// Token: 0x040041A7 RID: 16807
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftPortrayal_Private_set_Void_Sprite_0;

		// Token: 0x040041A8 RID: 16808
		private static readonly IntPtr NativeMethodInfoPtr_set_RightPortrayal_Private_set_Void_Sprite_0;

		// Token: 0x040041A9 RID: 16809
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftPortrayalDark_Private_set_Void_Boolean_0;

		// Token: 0x040041AA RID: 16810
		private static readonly IntPtr NativeMethodInfoPtr_set_RightPortrayalDark_Private_set_Void_Boolean_0;

		// Token: 0x040041AB RID: 16811
		private static readonly IntPtr NativeMethodInfoPtr_set_BG_Public_set_Void_Sprite_0;

		// Token: 0x040041AC RID: 16812
		private static readonly IntPtr NativeMethodInfoPtr_set_CG_Public_set_Void_Sprite_0;

		// Token: 0x040041AD RID: 16813
		private static readonly IntPtr NativeMethodInfoPtr_set_SoundFx_Public_set_Void_AudioClip_0;

		// Token: 0x040041AE RID: 16814
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftPortrayalHighLight_Private_set_Void_Boolean_0;

		// Token: 0x040041AF RID: 16815
		private static readonly IntPtr NativeMethodInfoPtr_set_RightPortrayalHighLight_Private_set_Void_Boolean_0;

		// Token: 0x040041B0 RID: 16816
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftSpeakerName_Private_set_Void_String_0;

		// Token: 0x040041B1 RID: 16817
		private static readonly IntPtr NativeMethodInfoPtr_set_RightSpeakerName_Private_set_Void_String_0;

		// Token: 0x040041B2 RID: 16818
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040041B3 RID: 16819
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_DialogPannelOpenContextBase_0;

		// Token: 0x040041B4 RID: 16820
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DialogPannelOpenContextBase_0;

		// Token: 0x040041B5 RID: 16821
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentStringBuilder_Private_get_StringBuilder_0;

		// Token: 0x040041B6 RID: 16822
		private static readonly IntPtr NativeMethodInfoPtr_get_ExitCode_Public_get_Int32_0;

		// Token: 0x040041B7 RID: 16823
		private static readonly IntPtr NativeMethodInfoPtr_set_ExitCode_Private_set_Void_Int32_0;

		// Token: 0x040041B8 RID: 16824
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040041B9 RID: 16825
		private static readonly IntPtr NativeMethodInfoPtr_ClearDialogHistories_Public_Static_Void_0;

		// Token: 0x040041BA RID: 16826
		private static readonly IntPtr NativeMethodInfoPtr_ClearContent_Private_Void_0;

		// Token: 0x040041BB RID: 16827
		private static readonly IntPtr NativeMethodInfoPtr_SetContent_Private_Void_String_0;

		// Token: 0x040041BC RID: 16828
		private static readonly IntPtr NativeMethodInfoPtr_AddContent_Private_Void_String_0;

		// Token: 0x040041BD RID: 16829
		private static readonly IntPtr NativeMethodInfoPtr_SetContentMaxVisibleCharacters_Private_Void_Int32_0;

		// Token: 0x040041BE RID: 16830
		private static readonly IntPtr NativeMethodInfoPtr_SetPortrayal_Private_Void_Sprite_Image_Image_Animator_0;

		// Token: 0x040041BF RID: 16831
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeakerName_Private_Void_String_TextMeshProUGUI_GameObject_0;

		// Token: 0x040041C0 RID: 16832
		private static readonly IntPtr NativeMethodInfoPtr_ToggleDialogUI_Private_Void_CallbackContext_0;

		// Token: 0x040041C1 RID: 16833
		private static readonly IntPtr NativeMethodInfoPtr_SetSkippingProgress_Private_Void_Single_0;

		// Token: 0x040041C2 RID: 16834
		private static readonly IntPtr NativeMethodInfoPtr_ToggleOn_Private_DialogPannel_0;

		// Token: 0x040041C3 RID: 16835
		private static readonly IntPtr NativeMethodInfoPtr_ToggleOff_Private_DialogPannel_0;

		// Token: 0x040041C4 RID: 16836
		private static readonly IntPtr NativeMethodInfoPtr_SetCanPlayFirstLine_Public_Void_0;

		// Token: 0x040041C5 RID: 16837
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x040041C6 RID: 16838
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x040041C7 RID: 16839
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputBinding_Private_Void_Boolean_0;

		// Token: 0x040041C8 RID: 16840
		private static readonly IntPtr NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0;

		// Token: 0x040041C9 RID: 16841
		private static readonly IntPtr NativeMethodInfoPtr_StartSkipTiming_Private_Void_CallbackContext_0;

		// Token: 0x040041CA RID: 16842
		private static readonly IntPtr NativeMethodInfoPtr_EndSkipTiming_Private_Void_CallbackContext_0;

		// Token: 0x040041CB RID: 16843
		private static readonly IntPtr NativeMethodInfoPtr_EndSkipTiming_Private_Void_0;

		// Token: 0x040041CC RID: 16844
		private static readonly IntPtr NativeMethodInfoPtr_InterruptDialog_Private_Void_CallbackContext_0;

		// Token: 0x040041CD RID: 16845
		private static readonly IntPtr NativeMethodInfoPtr_OpenHistoryPanel_Private_Void_0;

		// Token: 0x040041CE RID: 16846
		private static readonly IntPtr NativeMethodInfoPtr_CleanAtPosition_Public_Void_Position_0;

		// Token: 0x040041CF RID: 16847
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDialog_Private_IEnumerator_String_Boolean_String_0;

		// Token: 0x040041D0 RID: 16848
		private static readonly IntPtr NativeMethodInfoPtr_TrimNextContentSegment_Private_Int32_String_Int32_byref_Boolean_0;

		// Token: 0x040041D1 RID: 16849
		private static readonly IntPtr NativeMethodInfoPtr_TypeFollowing_Private_IEnumerator_Int32_0;

		// Token: 0x040041D2 RID: 16850
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_Void_CallbackContext_0;

		// Token: 0x040041D3 RID: 16851
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpenAsync_Protected_Virtual_UniTaskVoid_0;

		// Token: 0x040041D4 RID: 16852
		private static readonly IntPtr NativeMethodInfoPtr_OnExecutingDialogLoopInternal_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_Func_1_Boolean_Boolean_0;

		// Token: 0x040041D5 RID: 16853
		private static readonly IntPtr NativeMethodInfoPtr_OnExecutingDialogLoopCore_Private_IEnumerator_IReadOnlyList_1_KeyValuePair_2_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_String_IReadOnlyDictionary_2_Int32_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0;

		// Token: 0x040041D6 RID: 16854
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMetaPresentation_Private_Void_byref_String_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_ValueTuple_2_DialogMeta_Il2CppReferenceArray_1_LoadedDialogActionData_byref_String_0;

		// Token: 0x040041D7 RID: 16855
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeakerName_Private_Void_byref_String_DialogMeta_byref_String_0;

		// Token: 0x040041D8 RID: 16856
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeakerVisual_Private_Void_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_Int32_IAssetHandleArray_1_Sprite_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_byref_Sprite_0;

		// Token: 0x040041D9 RID: 16857
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndApplyOverrideSprite_Private_Static_Boolean_byref_Sprite_byref_DialogMeta_IReadOnlyDictionary_2_DialogMeta_IAssetHandle_1_Sprite_0;

		// Token: 0x040041DA RID: 16858
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040041DB RID: 16859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040041DC RID: 16860
		private static readonly IntPtr NativeMethodInfoPtr__UpdateInputBinding_b__97_0_Private_Void_CallbackContext_0;

		// Token: 0x040041DD RID: 16861
		private static readonly IntPtr NativeMethodInfoPtr__UpdateInputBinding_b__97_1_Private_Void_CallbackContext_0;

		// Token: 0x040041DE RID: 16862
		private static readonly IntPtr NativeMethodInfoPtr__StartSkipTiming_b__99_0_Private_Void_0;

		// Token: 0x040041DF RID: 16863
		private static readonly IntPtr NativeMethodInfoPtr__OpenHistoryPanel_b__103_0_Private_Void_0;

		// Token: 0x040041E0 RID: 16864
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_String_String_String_PDM_0;

		// Token: 0x02000DF2 RID: 3570
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010162 RID: 65890 RVA: 0x003C1684 File Offset: 0x003BF884
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr);
				DialogPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9");
				DialogPannel.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__57_0");
				DialogPannel.__c.NativeFieldInfoPtr___9__57_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__57_1");
				DialogPannel.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__59_0");
				DialogPannel.__c.NativeFieldInfoPtr___9__59_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__59_1");
				DialogPannel.__c.NativeFieldInfoPtr___9__106_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__106_0");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_0");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_1");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_2");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_3");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_4");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_5");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_14");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_6");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_15");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_7");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_8");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_9");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_10");
				DialogPannel.__c.NativeFieldInfoPtr___9__111_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__111_11");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_0");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_4");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_5");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_7");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_8");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_1");
				DialogPannel.__c.NativeFieldInfoPtr___9__113_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, "<>9__113_2");
				DialogPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684132);
				DialogPannel.__c.NativeMethodInfoPtr__set_BG_b__57_0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684133);
				DialogPannel.__c.NativeMethodInfoPtr__set_BG_b__57_1_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684134);
				DialogPannel.__c.NativeMethodInfoPtr__set_CG_b__59_0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684135);
				DialogPannel.__c.NativeMethodInfoPtr__set_CG_b__59_1_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684136);
				DialogPannel.__c.NativeMethodInfoPtr__TrimNextContentSegment_b__106_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684137);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684138);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_1_Internal_Boolean_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684139);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_2_Internal_Int32_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684140);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_3_Internal_Int32_IGrouping_2_Int32_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684141);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_4_Internal_Boolean_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684142);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_5_Internal_DialogMeta_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684143);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_6_Internal_Il2CppReferenceArray_1_UniTask_1_LoadedDialogActionData_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684144);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_14_Internal_UniTask_1_LoadedDialogActionData_DialogAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684145);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_15_Internal_UniTask_1_IAssetHandle_1_Sprite_DialogMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684146);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_7_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684147);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_8_Internal_Il2CppStringArray_IGrouping_2_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684148);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_9_Internal_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684149);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_10_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684150);
				DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_11_Internal_ValueTuple_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684151);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_0_Internal_Boolean_LoadedDialogActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684152);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_4_Internal_ValueTuple_2_String_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684153);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_5_Internal_ValueTuple_3_String_Int32_Int32_ValueTuple_2_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684154);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_7_Internal_String_ValueTuple_3_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684155);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_8_Internal_ValueTuple_2_Int32_Int32_ValueTuple_3_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684156);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_1_Internal_Boolean_LoadedDialogActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684157);
				DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_2_Internal_Boolean_LoadedDialogActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr, 100684158);
			}

			// Token: 0x06010163 RID: 65891 RVA: 0x003C1AE8 File Offset: 0x003BFCE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010164 RID: 65892 RVA: 0x003C1B24 File Offset: 0x003BFD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255368, XrefRangeEnd = 255372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _set_BG_b__57_0(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__set_BG_b__57_0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010165 RID: 65893 RVA: 0x003C1B68 File Offset: 0x003BFD68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255372, XrefRangeEnd = 255376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _set_BG_b__57_1(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__set_BG_b__57_1_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010166 RID: 65894 RVA: 0x003C1BAC File Offset: 0x003BFDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255376, XrefRangeEnd = 255380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _set_CG_b__59_0(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__set_CG_b__59_0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010167 RID: 65895 RVA: 0x003C1BF0 File Offset: 0x003BFDF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255380, XrefRangeEnd = 255384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _set_CG_b__59_1(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__set_CG_b__59_1_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010168 RID: 65896 RVA: 0x003C1C34 File Offset: 0x003BFE34
			[CallerCount(0)]
			public unsafe bool _TrimNextContentSegment_b__106_0(char x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__TrimNextContentSegment_b__106_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010169 RID: 65897 RVA: 0x003C1C80 File Offset: 0x003BFE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpenAsync_b__111_0(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601016A RID: 65898 RVA: 0x003C1CC4 File Offset: 0x003BFEC4
			[CallerCount(0)]
			public unsafe bool _OnPanelOpenAsync_b__111_1(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_1_Internal_Boolean_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601016B RID: 65899 RVA: 0x003C1D18 File Offset: 0x003BFF18
			[CallerCount(0)]
			public unsafe int _OnPanelOpenAsync_b__111_2(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_2_Internal_Int32_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601016C RID: 65900 RVA: 0x003C1D6C File Offset: 0x003BFF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255384, XrefRangeEnd = 255388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpenAsync_b__111_3(IGrouping<int, DialogMeta> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_3_Internal_Int32_IGrouping_2_Int32_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601016D RID: 65901 RVA: 0x003C1DBC File Offset: 0x003BFFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255388, XrefRangeEnd = 255400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpenAsync_b__111_4(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_4_Internal_Boolean_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601016E RID: 65902 RVA: 0x003C1E10 File Offset: 0x003C0010
			[CallerCount(0)]
			public unsafe DialogMeta _OnPanelOpenAsync_b__111_5(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_5_Internal_DialogMeta_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DialogMeta(pointer);
			}

			// Token: 0x0601016F RID: 65903 RVA: 0x003C1E60 File Offset: 0x003C0060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255400, XrefRangeEnd = 255422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<UniTask<LoadedDialogActionData>> _OnPanelOpenAsync_b__111_6(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_6_Internal_Il2CppReferenceArray_1_UniTask_1_LoadedDialogActionData_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>(intPtr3) : null;
			}

			// Token: 0x06010170 RID: 65904 RVA: 0x003C1EB8 File Offset: 0x003C00B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255422, XrefRangeEnd = 255431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<LoadedDialogActionData> _OnPanelOpenAsync_b__111_14(DialogAction y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_14_Internal_UniTask_1_LoadedDialogActionData_DialogAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<LoadedDialogActionData>(pointer);
			}

			// Token: 0x06010171 RID: 65905 RVA: 0x003C1F00 File Offset: 0x003C0100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255431, XrefRangeEnd = 255432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandle<Sprite>> _OnPanelOpenAsync_b__111_15(DialogMeta x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_15_Internal_UniTask_1_IAssetHandle_1_Sprite_DialogMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandle<Sprite>>(pointer);
			}

			// Token: 0x06010172 RID: 65906 RVA: 0x003C1F50 File Offset: 0x003C0150
			[CallerCount(0)]
			public unsafe string _OnPanelOpenAsync_b__111_7(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_7_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010173 RID: 65907 RVA: 0x003C1F98 File Offset: 0x003C0198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255432, XrefRangeEnd = 255435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStringArray _OnPanelOpenAsync_b__111_8(IGrouping<string, Il2CppStringArray> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_8_Internal_Il2CppStringArray_IGrouping_2_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}

			// Token: 0x06010174 RID: 65908 RVA: 0x003C1FE8 File Offset: 0x003C01E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255435, XrefRangeEnd = 255461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpenAsync_b__111_9(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_9_Internal_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010175 RID: 65909 RVA: 0x003C2038 File Offset: 0x003C0238
			[CallerCount(0)]
			public unsafe string _OnPanelOpenAsync_b__111_10(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_10_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010176 RID: 65910 RVA: 0x003C2080 File Offset: 0x003C0280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255461, XrefRangeEnd = 255464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<DialogMeta, IAssetHandle<Sprite>> _OnPanelOpenAsync_b__111_11(DialogMeta a, IAssetHandle<Sprite> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnPanelOpenAsync_b__111_11_Internal_ValueTuple_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_IAssetHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<DialogMeta, IAssetHandle<Sprite>>(pointer);
			}

			// Token: 0x06010177 RID: 65911 RVA: 0x003C20E0 File Offset: 0x003C02E0
			[CallerCount(0)]
			public unsafe bool _OnExecutingDialogLoopCore_b__113_0(LoadedDialogActionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_0_Internal_Boolean_LoadedDialogActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010178 RID: 65912 RVA: 0x003C2130 File Offset: 0x003C0330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255464, XrefRangeEnd = 255467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, int> _OnExecutingDialogLoopCore_b__113_4(string a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_4_Internal_ValueTuple_2_String_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, int>(pointer);
			}

			// Token: 0x06010179 RID: 65913 RVA: 0x003C2188 File Offset: 0x003C0388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255467, XrefRangeEnd = 255470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, int, int> _OnExecutingDialogLoopCore_b__113_5(ValueTuple<string, int> a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_5_Internal_ValueTuple_3_String_Int32_Int32_ValueTuple_2_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, int, int>(pointer);
			}

			// Token: 0x0601017A RID: 65914 RVA: 0x003C21E4 File Offset: 0x003C03E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255470, XrefRangeEnd = 255472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnExecutingDialogLoopCore_b__113_7(ValueTuple<string, int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_7_Internal_String_ValueTuple_3_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0601017B RID: 65915 RVA: 0x003C2234 File Offset: 0x003C0434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255472, XrefRangeEnd = 255475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int> _OnExecutingDialogLoopCore_b__113_8(ValueTuple<string, int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_8_Internal_ValueTuple_2_Int32_Int32_ValueTuple_3_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int>(pointer);
			}

			// Token: 0x0601017C RID: 65916 RVA: 0x003C2284 File Offset: 0x003C0484
			[CallerCount(0)]
			public unsafe bool _OnExecutingDialogLoopCore_b__113_1(LoadedDialogActionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_1_Internal_Boolean_LoadedDialogActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601017D RID: 65917 RVA: 0x003C22D4 File Offset: 0x003C04D4
			[CallerCount(0)]
			public unsafe bool _OnExecutingDialogLoopCore_b__113_2(LoadedDialogActionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_2_Internal_Boolean_LoadedDialogActionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601017E RID: 65918 RVA: 0x0008BE01 File Offset: 0x0008A001
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005412 RID: 21522
			// (get) Token: 0x0601017F RID: 65919 RVA: 0x003C2324 File Offset: 0x003C0524
			// (set) Token: 0x06010180 RID: 65920 RVA: 0x0008BE0A File Offset: 0x0008A00A
			public unsafe static DialogPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005413 RID: 21523
			// (get) Token: 0x06010181 RID: 65921 RVA: 0x003C234C File Offset: 0x003C054C
			// (set) Token: 0x06010182 RID: 65922 RVA: 0x0008BE1C File Offset: 0x0008A01C
			public unsafe static Action<CanvasGroup> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005414 RID: 21524
			// (get) Token: 0x06010183 RID: 65923 RVA: 0x003C2374 File Offset: 0x003C0574
			// (set) Token: 0x06010184 RID: 65924 RVA: 0x0008BE2E File Offset: 0x0008A02E
			public unsafe static Action<CanvasGroup> __9__57_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__57_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__57_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005415 RID: 21525
			// (get) Token: 0x06010185 RID: 65925 RVA: 0x003C239C File Offset: 0x003C059C
			// (set) Token: 0x06010186 RID: 65926 RVA: 0x0008BE40 File Offset: 0x0008A040
			public unsafe static Action<CanvasGroup> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005416 RID: 21526
			// (get) Token: 0x06010187 RID: 65927 RVA: 0x003C23C4 File Offset: 0x003C05C4
			// (set) Token: 0x06010188 RID: 65928 RVA: 0x0008BE52 File Offset: 0x0008A052
			public unsafe static Action<CanvasGroup> __9__59_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__59_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__59_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005417 RID: 21527
			// (get) Token: 0x06010189 RID: 65929 RVA: 0x003C23EC File Offset: 0x003C05EC
			// (set) Token: 0x0601018A RID: 65930 RVA: 0x0008BE64 File Offset: 0x0008A064
			public unsafe static Func<char, bool> __9__106_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__106_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__106_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005418 RID: 21528
			// (get) Token: 0x0601018B RID: 65931 RVA: 0x003C2414 File Offset: 0x003C0614
			// (set) Token: 0x0601018C RID: 65932 RVA: 0x0008BE76 File Offset: 0x0008A076
			public unsafe static Action<CanvasGroup> __9__111_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005419 RID: 21529
			// (get) Token: 0x0601018D RID: 65933 RVA: 0x003C243C File Offset: 0x003C063C
			// (set) Token: 0x0601018E RID: 65934 RVA: 0x0008BE88 File Offset: 0x0008A088
			public unsafe static Func<DialogMeta, bool> __9__111_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541A RID: 21530
			// (get) Token: 0x0601018F RID: 65935 RVA: 0x003C2464 File Offset: 0x003C0664
			// (set) Token: 0x06010190 RID: 65936 RVA: 0x0008BE9A File Offset: 0x0008A09A
			public unsafe static Func<DialogMeta, int> __9__111_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541B RID: 21531
			// (get) Token: 0x06010191 RID: 65937 RVA: 0x003C248C File Offset: 0x003C068C
			// (set) Token: 0x06010192 RID: 65938 RVA: 0x0008BEAC File Offset: 0x0008A0AC
			public unsafe static Func<IGrouping<int, DialogMeta>, int> __9__111_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, DialogMeta>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541C RID: 21532
			// (get) Token: 0x06010193 RID: 65939 RVA: 0x003C24B4 File Offset: 0x003C06B4
			// (set) Token: 0x06010194 RID: 65940 RVA: 0x0008BEBE File Offset: 0x0008A0BE
			public unsafe static Func<DialogMeta, bool> __9__111_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541D RID: 21533
			// (get) Token: 0x06010195 RID: 65941 RVA: 0x003C24DC File Offset: 0x003C06DC
			// (set) Token: 0x06010196 RID: 65942 RVA: 0x0008BED0 File Offset: 0x0008A0D0
			public unsafe static Func<DialogMeta, DialogMeta> __9__111_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, DialogMeta>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541E RID: 21534
			// (get) Token: 0x06010197 RID: 65943 RVA: 0x003C2504 File Offset: 0x003C0704
			// (set) Token: 0x06010198 RID: 65944 RVA: 0x0008BEE2 File Offset: 0x0008A0E2
			public unsafe static Func<DialogAction, UniTask<LoadedDialogActionData>> __9__111_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogAction, UniTask<LoadedDialogActionData>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700541F RID: 21535
			// (get) Token: 0x06010199 RID: 65945 RVA: 0x003C252C File Offset: 0x003C072C
			// (set) Token: 0x0601019A RID: 65946 RVA: 0x0008BEF4 File Offset: 0x0008A0F4
			public unsafe static Func<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>> __9__111_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005420 RID: 21536
			// (get) Token: 0x0601019B RID: 65947 RVA: 0x003C2554 File Offset: 0x003C0754
			// (set) Token: 0x0601019C RID: 65948 RVA: 0x0008BF06 File Offset: 0x0008A106
			public unsafe static Func<DialogMeta, UniTask<IAssetHandle<Sprite>>> __9__111_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, UniTask<IAssetHandle<Sprite>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005421 RID: 21537
			// (get) Token: 0x0601019D RID: 65949 RVA: 0x003C257C File Offset: 0x003C077C
			// (set) Token: 0x0601019E RID: 65950 RVA: 0x0008BF18 File Offset: 0x0008A118
			public unsafe static Func<Il2CppStringArray, string> __9__111_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005422 RID: 21538
			// (get) Token: 0x0601019F RID: 65951 RVA: 0x003C25A4 File Offset: 0x003C07A4
			// (set) Token: 0x060101A0 RID: 65952 RVA: 0x0008BF2A File Offset: 0x0008A12A
			public unsafe static Func<IGrouping<string, Il2CppStringArray>, Il2CppStringArray> __9__111_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, Il2CppStringArray>, Il2CppStringArray>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005423 RID: 21539
			// (get) Token: 0x060101A1 RID: 65953 RVA: 0x003C25CC File Offset: 0x003C07CC
			// (set) Token: 0x060101A2 RID: 65954 RVA: 0x0008BF3C File Offset: 0x0008A13C
			public unsafe static Func<Il2CppStringArray, int> __9__111_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005424 RID: 21540
			// (get) Token: 0x060101A3 RID: 65955 RVA: 0x003C25F4 File Offset: 0x003C07F4
			// (set) Token: 0x060101A4 RID: 65956 RVA: 0x0008BF4E File Offset: 0x0008A14E
			public unsafe static Func<Il2CppStringArray, string> __9__111_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005425 RID: 21541
			// (get) Token: 0x060101A5 RID: 65957 RVA: 0x003C261C File Offset: 0x003C081C
			// (set) Token: 0x060101A6 RID: 65958 RVA: 0x0008BF60 File Offset: 0x0008A160
			public unsafe static Func<DialogMeta, IAssetHandle<Sprite>, ValueTuple<DialogMeta, IAssetHandle<Sprite>>> __9__111_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DialogMeta, IAssetHandle<Sprite>, ValueTuple<DialogMeta, IAssetHandle<Sprite>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__111_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005426 RID: 21542
			// (get) Token: 0x060101A7 RID: 65959 RVA: 0x003C2644 File Offset: 0x003C0844
			// (set) Token: 0x060101A8 RID: 65960 RVA: 0x0008BF72 File Offset: 0x0008A172
			public unsafe static Func<LoadedDialogActionData, bool> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LoadedDialogActionData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005427 RID: 21543
			// (get) Token: 0x060101A9 RID: 65961 RVA: 0x003C266C File Offset: 0x003C086C
			// (set) Token: 0x060101AA RID: 65962 RVA: 0x0008BF84 File Offset: 0x0008A184
			public unsafe static Func<string, int, ValueTuple<string, int>> __9__113_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int, ValueTuple<string, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005428 RID: 21544
			// (get) Token: 0x060101AB RID: 65963 RVA: 0x003C2694 File Offset: 0x003C0894
			// (set) Token: 0x060101AC RID: 65964 RVA: 0x0008BF96 File Offset: 0x0008A196
			public unsafe static Func<ValueTuple<string, int>, int, ValueTuple<string, int, int>> __9__113_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int>, int, ValueTuple<string, int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005429 RID: 21545
			// (get) Token: 0x060101AD RID: 65965 RVA: 0x003C26BC File Offset: 0x003C08BC
			// (set) Token: 0x060101AE RID: 65966 RVA: 0x0008BFA8 File Offset: 0x0008A1A8
			public unsafe static Func<ValueTuple<string, int, int>, string> __9__113_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int, int>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700542A RID: 21546
			// (get) Token: 0x060101AF RID: 65967 RVA: 0x003C26E4 File Offset: 0x003C08E4
			// (set) Token: 0x060101B0 RID: 65968 RVA: 0x0008BFBA File Offset: 0x0008A1BA
			public unsafe static Func<ValueTuple<string, int, int>, ValueTuple<int, int>> __9__113_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int, int>, ValueTuple<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700542B RID: 21547
			// (get) Token: 0x060101B1 RID: 65969 RVA: 0x003C270C File Offset: 0x003C090C
			// (set) Token: 0x060101B2 RID: 65970 RVA: 0x0008BFCC File Offset: 0x0008A1CC
			public unsafe static Func<LoadedDialogActionData, bool> __9__113_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LoadedDialogActionData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700542C RID: 21548
			// (get) Token: 0x060101B3 RID: 65971 RVA: 0x003C2734 File Offset: 0x003C0934
			// (set) Token: 0x060101B4 RID: 65972 RVA: 0x0008BFDE File Offset: 0x0008A1DE
			public unsafe static Func<LoadedDialogActionData, bool> __9__113_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LoadedDialogActionData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogPannel.__c.NativeFieldInfoPtr___9__113_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A350 RID: 41808
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A351 RID: 41809
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x0400A352 RID: 41810
			private static readonly IntPtr NativeFieldInfoPtr___9__57_1;

			// Token: 0x0400A353 RID: 41811
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x0400A354 RID: 41812
			private static readonly IntPtr NativeFieldInfoPtr___9__59_1;

			// Token: 0x0400A355 RID: 41813
			private static readonly IntPtr NativeFieldInfoPtr___9__106_0;

			// Token: 0x0400A356 RID: 41814
			private static readonly IntPtr NativeFieldInfoPtr___9__111_0;

			// Token: 0x0400A357 RID: 41815
			private static readonly IntPtr NativeFieldInfoPtr___9__111_1;

			// Token: 0x0400A358 RID: 41816
			private static readonly IntPtr NativeFieldInfoPtr___9__111_2;

			// Token: 0x0400A359 RID: 41817
			private static readonly IntPtr NativeFieldInfoPtr___9__111_3;

			// Token: 0x0400A35A RID: 41818
			private static readonly IntPtr NativeFieldInfoPtr___9__111_4;

			// Token: 0x0400A35B RID: 41819
			private static readonly IntPtr NativeFieldInfoPtr___9__111_5;

			// Token: 0x0400A35C RID: 41820
			private static readonly IntPtr NativeFieldInfoPtr___9__111_14;

			// Token: 0x0400A35D RID: 41821
			private static readonly IntPtr NativeFieldInfoPtr___9__111_6;

			// Token: 0x0400A35E RID: 41822
			private static readonly IntPtr NativeFieldInfoPtr___9__111_15;

			// Token: 0x0400A35F RID: 41823
			private static readonly IntPtr NativeFieldInfoPtr___9__111_7;

			// Token: 0x0400A360 RID: 41824
			private static readonly IntPtr NativeFieldInfoPtr___9__111_8;

			// Token: 0x0400A361 RID: 41825
			private static readonly IntPtr NativeFieldInfoPtr___9__111_9;

			// Token: 0x0400A362 RID: 41826
			private static readonly IntPtr NativeFieldInfoPtr___9__111_10;

			// Token: 0x0400A363 RID: 41827
			private static readonly IntPtr NativeFieldInfoPtr___9__111_11;

			// Token: 0x0400A364 RID: 41828
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x0400A365 RID: 41829
			private static readonly IntPtr NativeFieldInfoPtr___9__113_4;

			// Token: 0x0400A366 RID: 41830
			private static readonly IntPtr NativeFieldInfoPtr___9__113_5;

			// Token: 0x0400A367 RID: 41831
			private static readonly IntPtr NativeFieldInfoPtr___9__113_7;

			// Token: 0x0400A368 RID: 41832
			private static readonly IntPtr NativeFieldInfoPtr___9__113_8;

			// Token: 0x0400A369 RID: 41833
			private static readonly IntPtr NativeFieldInfoPtr___9__113_1;

			// Token: 0x0400A36A RID: 41834
			private static readonly IntPtr NativeFieldInfoPtr___9__113_2;

			// Token: 0x0400A36B RID: 41835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A36C RID: 41836
			private static readonly IntPtr NativeMethodInfoPtr__set_BG_b__57_0_Internal_Void_CanvasGroup_0;

			// Token: 0x0400A36D RID: 41837
			private static readonly IntPtr NativeMethodInfoPtr__set_BG_b__57_1_Internal_Void_CanvasGroup_0;

			// Token: 0x0400A36E RID: 41838
			private static readonly IntPtr NativeMethodInfoPtr__set_CG_b__59_0_Internal_Void_CanvasGroup_0;

			// Token: 0x0400A36F RID: 41839
			private static readonly IntPtr NativeMethodInfoPtr__set_CG_b__59_1_Internal_Void_CanvasGroup_0;

			// Token: 0x0400A370 RID: 41840
			private static readonly IntPtr NativeMethodInfoPtr__TrimNextContentSegment_b__106_0_Internal_Boolean_Char_0;

			// Token: 0x0400A371 RID: 41841
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_0_Internal_Void_CanvasGroup_0;

			// Token: 0x0400A372 RID: 41842
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_1_Internal_Boolean_DialogMeta_0;

			// Token: 0x0400A373 RID: 41843
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_2_Internal_Int32_DialogMeta_0;

			// Token: 0x0400A374 RID: 41844
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_3_Internal_Int32_IGrouping_2_Int32_DialogMeta_0;

			// Token: 0x0400A375 RID: 41845
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_4_Internal_Boolean_DialogMeta_0;

			// Token: 0x0400A376 RID: 41846
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_5_Internal_DialogMeta_DialogMeta_0;

			// Token: 0x0400A377 RID: 41847
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_6_Internal_Il2CppReferenceArray_1_UniTask_1_LoadedDialogActionData_DialogMeta_0;

			// Token: 0x0400A378 RID: 41848
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_14_Internal_UniTask_1_LoadedDialogActionData_DialogAction_0;

			// Token: 0x0400A379 RID: 41849
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_15_Internal_UniTask_1_IAssetHandle_1_Sprite_DialogMeta_0;

			// Token: 0x0400A37A RID: 41850
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_7_Internal_String_Il2CppStringArray_0;

			// Token: 0x0400A37B RID: 41851
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_8_Internal_Il2CppStringArray_IGrouping_2_String_Il2CppStringArray_0;

			// Token: 0x0400A37C RID: 41852
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_9_Internal_Int32_Il2CppStringArray_0;

			// Token: 0x0400A37D RID: 41853
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_10_Internal_String_Il2CppStringArray_0;

			// Token: 0x0400A37E RID: 41854
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__111_11_Internal_ValueTuple_2_DialogMeta_IAssetHandle_1_Sprite_DialogMeta_IAssetHandle_1_Sprite_0;

			// Token: 0x0400A37F RID: 41855
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_0_Internal_Boolean_LoadedDialogActionData_0;

			// Token: 0x0400A380 RID: 41856
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_4_Internal_ValueTuple_2_String_Int32_String_Int32_0;

			// Token: 0x0400A381 RID: 41857
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_5_Internal_ValueTuple_3_String_Int32_Int32_ValueTuple_2_String_Int32_Int32_0;

			// Token: 0x0400A382 RID: 41858
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_7_Internal_String_ValueTuple_3_String_Int32_Int32_0;

			// Token: 0x0400A383 RID: 41859
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_8_Internal_ValueTuple_2_Int32_Int32_ValueTuple_3_String_Int32_Int32_0;

			// Token: 0x0400A384 RID: 41860
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_1_Internal_Boolean_LoadedDialogActionData_0;

			// Token: 0x0400A385 RID: 41861
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__113_2_Internal_Boolean_LoadedDialogActionData_0;
		}

		// Token: 0x02000DF3 RID: 3571
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass105_0")]
		public sealed class __c__DisplayClass105_0 : Il2CppSystem.Object
		{
			// Token: 0x060101B5 RID: 65973 RVA: 0x003C275C File Offset: 0x003C095C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass105_0()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass105_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr);
				DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr_needToExitOnLastLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr, "needToExitOnLastLine");
				DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr, "<>4__this");
				DialogPannel.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr, 100684159);
				DialogPannel.__c__DisplayClass105_0.NativeMethodInfoPtr__ExecuteDialog_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr, 100684160);
			}

			// Token: 0x060101B6 RID: 65974 RVA: 0x003C27D8 File Offset: 0x003C09D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass105_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass105_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101B7 RID: 65975 RVA: 0x003C2814 File Offset: 0x003C0A14
			[CallerCount(0)]
			public unsafe bool _ExecuteDialog_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass105_0.NativeMethodInfoPtr__ExecuteDialog_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060101B8 RID: 65976 RVA: 0x0008BFF0 File Offset: 0x0008A1F0
			public __c__DisplayClass105_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700542D RID: 21549
			// (get) Token: 0x060101B9 RID: 65977 RVA: 0x003C2850 File Offset: 0x003C0A50
			// (set) Token: 0x060101BA RID: 65978 RVA: 0x0008BFF9 File Offset: 0x0008A1F9
			public unsafe bool needToExitOnLastLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr_needToExitOnLastLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr_needToExitOnLastLine)) = value;
				}
			}

			// Token: 0x1700542E RID: 21550
			// (get) Token: 0x060101BB RID: 65979 RVA: 0x003C2878 File Offset: 0x003C0A78
			// (set) Token: 0x060101BC RID: 65980 RVA: 0x0008C014 File Offset: 0x0008A214
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass105_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A386 RID: 41862
			private static readonly IntPtr NativeFieldInfoPtr_needToExitOnLastLine;

			// Token: 0x0400A387 RID: 41863
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A388 RID: 41864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A389 RID: 41865
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteDialog_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000DF4 RID: 3572
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<ExecuteDialog>d__105")]
		public sealed class _ExecuteDialog_d__105 : Il2CppSystem.Object
		{
			// Token: 0x060101BD RID: 65981 RVA: 0x003C28A8 File Offset: 0x003C0AA8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteDialog_d__105()
			{
				Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<ExecuteDialog>d__105");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr);
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<>1__state");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<>2__current");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_needToExitOnLastLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "needToExitOnLastLine");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<>4__this");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_dialogContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "dialogContext");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_speakerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "speakerName");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__waitForNextLine_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<waitForNextLine>5__2");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<>7__wrap2");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<>7__wrap3");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__currentPlayIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<currentPlayIndex>5__5");
				DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__dialogLength_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, "<dialogLength>5__6");
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684161);
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684162);
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684163);
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684164);
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684165);
				DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr, 100684166);
			}

			// Token: 0x060101BE RID: 65982 RVA: 0x003C2A28 File Offset: 0x003C0C28
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteDialog_d__105(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel._ExecuteDialog_d__105>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101BF RID: 65983 RVA: 0x003C2A70 File Offset: 0x003C0C70
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101C0 RID: 65984 RVA: 0x003C2AA4 File Offset: 0x003C0CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255475, XrefRangeEnd = 255518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700543A RID: 21562
			// (get) Token: 0x060101C1 RID: 65985 RVA: 0x003C2AE0 File Offset: 0x003C0CE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060101C2 RID: 65986 RVA: 0x003C2B20 File Offset: 0x003C0D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255518, XrefRangeEnd = 255524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700543B RID: 21563
			// (get) Token: 0x060101C3 RID: 65987 RVA: 0x003C2B54 File Offset: 0x003C0D54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._ExecuteDialog_d__105.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060101C4 RID: 65988 RVA: 0x0008C033 File Offset: 0x0008A233
			public _ExecuteDialog_d__105(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700542F RID: 21551
			// (get) Token: 0x060101C5 RID: 65989 RVA: 0x003C2B94 File Offset: 0x003C0D94
			// (set) Token: 0x060101C6 RID: 65990 RVA: 0x0008C03C File Offset: 0x0008A23C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005430 RID: 21552
			// (get) Token: 0x060101C7 RID: 65991 RVA: 0x003C2BBC File Offset: 0x003C0DBC
			// (set) Token: 0x060101C8 RID: 65992 RVA: 0x0008C057 File Offset: 0x0008A257
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005431 RID: 21553
			// (get) Token: 0x060101C9 RID: 65993 RVA: 0x003C2BEC File Offset: 0x003C0DEC
			// (set) Token: 0x060101CA RID: 65994 RVA: 0x0008C076 File Offset: 0x0008A276
			public unsafe bool needToExitOnLastLine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_needToExitOnLastLine);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_needToExitOnLastLine)) = value;
				}
			}

			// Token: 0x17005432 RID: 21554
			// (get) Token: 0x060101CB RID: 65995 RVA: 0x003C2C14 File Offset: 0x003C0E14
			// (set) Token: 0x060101CC RID: 65996 RVA: 0x0008C091 File Offset: 0x0008A291
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005433 RID: 21555
			// (get) Token: 0x060101CD RID: 65997 RVA: 0x003C2C44 File Offset: 0x003C0E44
			// (set) Token: 0x060101CE RID: 65998 RVA: 0x0008C0B0 File Offset: 0x0008A2B0
			public unsafe string dialogContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_dialogContext);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_dialogContext), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005434 RID: 21556
			// (get) Token: 0x060101CF RID: 65999 RVA: 0x003C2C6C File Offset: 0x003C0E6C
			// (set) Token: 0x060101D0 RID: 66000 RVA: 0x0008C0CF File Offset: 0x0008A2CF
			public unsafe string speakerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_speakerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr_speakerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005435 RID: 21557
			// (get) Token: 0x060101D1 RID: 66001 RVA: 0x003C2C94 File Offset: 0x003C0E94
			// (set) Token: 0x060101D2 RID: 66002 RVA: 0x0008C0EE File Offset: 0x0008A2EE
			public unsafe WaitUntil _waitForNextLine_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__waitForNextLine_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__waitForNextLine_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005436 RID: 21558
			// (get) Token: 0x060101D3 RID: 66003 RVA: 0x003C2CC4 File Offset: 0x003C0EC4
			// (set) Token: 0x060101D4 RID: 66004 RVA: 0x0008C10D File Offset: 0x0008A30D
			public unsafe Il2CppStringArray __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005437 RID: 21559
			// (get) Token: 0x060101D5 RID: 66005 RVA: 0x003C2CF4 File Offset: 0x003C0EF4
			// (set) Token: 0x060101D6 RID: 66006 RVA: 0x0008C12C File Offset: 0x0008A32C
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17005438 RID: 21560
			// (get) Token: 0x060101D7 RID: 66007 RVA: 0x003C2D1C File Offset: 0x003C0F1C
			// (set) Token: 0x060101D8 RID: 66008 RVA: 0x0008C147 File Offset: 0x0008A347
			public unsafe int _currentPlayIndex_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__currentPlayIndex_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__currentPlayIndex_5__5)) = value;
				}
			}

			// Token: 0x17005439 RID: 21561
			// (get) Token: 0x060101D9 RID: 66009 RVA: 0x003C2D44 File Offset: 0x003C0F44
			// (set) Token: 0x060101DA RID: 66010 RVA: 0x0008C162 File Offset: 0x0008A362
			public unsafe int _dialogLength_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__dialogLength_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._ExecuteDialog_d__105.NativeFieldInfoPtr__dialogLength_5__6)) = value;
				}
			}

			// Token: 0x0400A38A RID: 41866
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A38B RID: 41867
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A38C RID: 41868
			private static readonly IntPtr NativeFieldInfoPtr_needToExitOnLastLine;

			// Token: 0x0400A38D RID: 41869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A38E RID: 41870
			private static readonly IntPtr NativeFieldInfoPtr_dialogContext;

			// Token: 0x0400A38F RID: 41871
			private static readonly IntPtr NativeFieldInfoPtr_speakerName;

			// Token: 0x0400A390 RID: 41872
			private static readonly IntPtr NativeFieldInfoPtr__waitForNextLine_5__2;

			// Token: 0x0400A391 RID: 41873
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400A392 RID: 41874
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400A393 RID: 41875
			private static readonly IntPtr NativeFieldInfoPtr__currentPlayIndex_5__5;

			// Token: 0x0400A394 RID: 41876
			private static readonly IntPtr NativeFieldInfoPtr__dialogLength_5__6;

			// Token: 0x0400A395 RID: 41877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A396 RID: 41878
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A397 RID: 41879
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A398 RID: 41880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A399 RID: 41881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A39A RID: 41882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DF5 RID: 3573
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<TypeFollowing>d__107")]
		public sealed class _TypeFollowing_d__107 : Il2CppSystem.Object
		{
			// Token: 0x060101DB RID: 66011 RVA: 0x003C2D6C File Offset: 0x003C0F6C
			// Note: this type is marked as 'beforefieldinit'.
			static _TypeFollowing_d__107()
			{
				Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<TypeFollowing>d__107");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr);
				DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, "<>1__state");
				DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, "<>2__current");
				DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, "<>4__this");
				DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr_showNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, "showNum");
				DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, "<i>5__2");
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684167);
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684168);
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684169);
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684170);
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684171);
				DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr, 100684172);
			}

			// Token: 0x060101DC RID: 66012 RVA: 0x003C2E74 File Offset: 0x003C1074
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TypeFollowing_d__107(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel._TypeFollowing_d__107>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101DD RID: 66013 RVA: 0x003C2EBC File Offset: 0x003C10BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101DE RID: 66014 RVA: 0x003C2EF0 File Offset: 0x003C10F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255524, XrefRangeEnd = 255526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005441 RID: 21569
			// (get) Token: 0x060101DF RID: 66015 RVA: 0x003C2F2C File Offset: 0x003C112C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060101E0 RID: 66016 RVA: 0x003C2F6C File Offset: 0x003C116C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255526, XrefRangeEnd = 255532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005442 RID: 21570
			// (get) Token: 0x060101E1 RID: 66017 RVA: 0x003C2FA0 File Offset: 0x003C11A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._TypeFollowing_d__107.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060101E2 RID: 66018 RVA: 0x0008C17D File Offset: 0x0008A37D
			public _TypeFollowing_d__107(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700543C RID: 21564
			// (get) Token: 0x060101E3 RID: 66019 RVA: 0x003C2FE0 File Offset: 0x003C11E0
			// (set) Token: 0x060101E4 RID: 66020 RVA: 0x0008C186 File Offset: 0x0008A386
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700543D RID: 21565
			// (get) Token: 0x060101E5 RID: 66021 RVA: 0x003C3008 File Offset: 0x003C1208
			// (set) Token: 0x060101E6 RID: 66022 RVA: 0x0008C1A1 File Offset: 0x0008A3A1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700543E RID: 21566
			// (get) Token: 0x060101E7 RID: 66023 RVA: 0x003C3038 File Offset: 0x003C1238
			// (set) Token: 0x060101E8 RID: 66024 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700543F RID: 21567
			// (get) Token: 0x060101E9 RID: 66025 RVA: 0x003C3068 File Offset: 0x003C1268
			// (set) Token: 0x060101EA RID: 66026 RVA: 0x0008C1DF File Offset: 0x0008A3DF
			public unsafe int showNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr_showNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr_showNum)) = value;
				}
			}

			// Token: 0x17005440 RID: 21568
			// (get) Token: 0x060101EB RID: 66027 RVA: 0x003C3090 File Offset: 0x003C1290
			// (set) Token: 0x060101EC RID: 66028 RVA: 0x0008C1FA File Offset: 0x0008A3FA
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._TypeFollowing_d__107.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400A39B RID: 41883
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A39C RID: 41884
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A39D RID: 41885
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A39E RID: 41886
			private static readonly IntPtr NativeFieldInfoPtr_showNum;

			// Token: 0x0400A39F RID: 41887
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400A3A0 RID: 41888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A3A1 RID: 41889
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3A2 RID: 41890
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A3A3 RID: 41891
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A3A4 RID: 41892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3A5 RID: 41893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DF6 RID: 3574
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass111_0")]
		public sealed class __c__DisplayClass111_0 : Il2CppSystem.Object
		{
			// Token: 0x060101ED RID: 66029 RVA: 0x003C30B8 File Offset: 0x003C12B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass111_0()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass111_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr);
				DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, "<>4__this");
				DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_loadedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, "loadedSprites");
				DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_dialogContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, "dialogContext");
				DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_playerPortrayalCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, "playerPortrayalCollection");
				DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, 100684173);
				DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, 100684174);
				DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__16_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, 100684175);
				DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__13_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr, 100684176);
			}

			// Token: 0x060101EE RID: 66030 RVA: 0x003C3184 File Offset: 0x003C1384
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass111_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass111_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101EF RID: 66031 RVA: 0x003C31C0 File Offset: 0x003C13C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255532, XrefRangeEnd = 255560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpenAsync_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101F0 RID: 66032 RVA: 0x003C31F4 File Offset: 0x003C13F4
			[CallerCount(0)]
			public unsafe bool _OnPanelOpenAsync_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__16_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060101F1 RID: 66033 RVA: 0x003C3230 File Offset: 0x003C1430
			[CallerCount(0)]
			public unsafe bool _OnPanelOpenAsync_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass111_0.NativeMethodInfoPtr__OnPanelOpenAsync_b__13_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060101F2 RID: 66034 RVA: 0x0008C215 File Offset: 0x0008A415
			public __c__DisplayClass111_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005443 RID: 21571
			// (get) Token: 0x060101F3 RID: 66035 RVA: 0x003C326C File Offset: 0x003C146C
			// (set) Token: 0x060101F4 RID: 66036 RVA: 0x0008C21E File Offset: 0x0008A41E
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005444 RID: 21572
			// (get) Token: 0x060101F5 RID: 66037 RVA: 0x003C329C File Offset: 0x003C149C
			// (set) Token: 0x060101F6 RID: 66038 RVA: 0x0008C23D File Offset: 0x0008A43D
			public unsafe Il2CppReferenceArray<IAssetHandle<Sprite>> loadedSprites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_loadedSprites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAssetHandle<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_loadedSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005445 RID: 21573
			// (get) Token: 0x060101F7 RID: 66039 RVA: 0x003C32CC File Offset: 0x003C14CC
			// (set) Token: 0x060101F8 RID: 66040 RVA: 0x0008C25C File Offset: 0x0008A45C
			public unsafe IAssetHandle<TextAsset> dialogContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_dialogContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<TextAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_dialogContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005446 RID: 21574
			// (get) Token: 0x060101F9 RID: 66041 RVA: 0x003C32FC File Offset: 0x003C14FC
			// (set) Token: 0x060101FA RID: 66042 RVA: 0x0008C27B File Offset: 0x0008A47B
			public unsafe IAssetHandleArray<Sprite> playerPortrayalCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_playerPortrayalCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandleArray<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass111_0.NativeFieldInfoPtr_playerPortrayalCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3A6 RID: 41894
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3A7 RID: 41895
			private static readonly IntPtr NativeFieldInfoPtr_loadedSprites;

			// Token: 0x0400A3A8 RID: 41896
			private static readonly IntPtr NativeFieldInfoPtr_dialogContext;

			// Token: 0x0400A3A9 RID: 41897
			private static readonly IntPtr NativeFieldInfoPtr_playerPortrayalCollection;

			// Token: 0x0400A3AA RID: 41898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3AB RID: 41899
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__12_Internal_Void_0;

			// Token: 0x0400A3AC RID: 41900
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__16_Internal_Boolean_0;

			// Token: 0x0400A3AD RID: 41901
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpenAsync_b__13_Internal_Boolean_0;
		}

		// Token: 0x02000DF7 RID: 3575
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<OnPanelOpenAsync>d__111")]
		public sealed class _OnPanelOpenAsync_d__111 : ValueType
		{
			// Token: 0x060101FB RID: 66043 RVA: 0x003C332C File Offset: 0x003C152C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPanelOpenAsync_d__111()
			{
				Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<OnPanelOpenAsync>d__111");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr);
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>1__state");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>t__builder");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>4__this");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>8__1");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__handle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<handle>5__2");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__specialNPCIdToLoad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<specialNPCIdToLoad>5__3");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadHandles_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<loadHandles>5__4");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__overrideSpritesMeta_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<overrideSpritesMeta>5__5");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__dialogMetaLoadTask_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<dialogMetaLoadTask>5__6");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedSpecialGuestPortrayalsCollection_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<loadedSpecialGuestPortrayalsCollection>5__7");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedDialogMetaDictionary_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<loadedDialogMetaDictionary>5__8");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__1");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__2");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__3");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__4");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>7__wrap8");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>7__wrap9");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>7__wrap10");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__5");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__manualContext_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<manualContext>5__12");
				DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, "<>u__6");
				DialogPannel._OnPanelOpenAsync_d__111.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, 100684177);
				DialogPannel._OnPanelOpenAsync_d__111.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr, 100684178);
			}

			// Token: 0x060101FC RID: 66044 RVA: 0x003C3524 File Offset: 0x003C1724
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256184, RefRangeEnd = 256186, XrefRangeStart = 255560, XrefRangeEnd = 256184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnPanelOpenAsync_d__111.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101FD RID: 66045 RVA: 0x003C355C File Offset: 0x003C175C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnPanelOpenAsync_d__111.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060101FE RID: 66046 RVA: 0x0008C29A File Offset: 0x0008A49A
			public _OnPanelOpenAsync_d__111(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060101FF RID: 66047 RVA: 0x0008C2A3 File Offset: 0x0008A4A3
			public _OnPanelOpenAsync_d__111() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel._OnPanelOpenAsync_d__111>.NativeClassPtr))
			{
			}

			// Token: 0x17005447 RID: 21575
			// (get) Token: 0x06010200 RID: 66048 RVA: 0x003C35A4 File Offset: 0x003C17A4
			// (set) Token: 0x06010201 RID: 66049 RVA: 0x0008C2B5 File Offset: 0x0008A4B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005448 RID: 21576
			// (get) Token: 0x06010202 RID: 66050 RVA: 0x003C35CC File Offset: 0x003C17CC
			// (set) Token: 0x06010203 RID: 66051 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005449 RID: 21577
			// (get) Token: 0x06010204 RID: 66052 RVA: 0x003C35FC File Offset: 0x003C17FC
			// (set) Token: 0x06010205 RID: 66053 RVA: 0x0008C2FE File Offset: 0x0008A4FE
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544A RID: 21578
			// (get) Token: 0x06010206 RID: 66054 RVA: 0x003C362C File Offset: 0x003C182C
			// (set) Token: 0x06010207 RID: 66055 RVA: 0x0008C31D File Offset: 0x0008A51D
			public unsafe DialogPannel.__c__DisplayClass111_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass111_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544B RID: 21579
			// (get) Token: 0x06010208 RID: 66056 RVA: 0x003C365C File Offset: 0x003C185C
			// (set) Token: 0x06010209 RID: 66057 RVA: 0x0008C33C File Offset: 0x0008A53C
			public unsafe IDisposable _handle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__handle_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__handle_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544C RID: 21580
			// (get) Token: 0x0601020A RID: 66058 RVA: 0x003C368C File Offset: 0x003C188C
			// (set) Token: 0x0601020B RID: 66059 RVA: 0x0008C35B File Offset: 0x0008A55B
			public unsafe Il2CppStructArray<int> _specialNPCIdToLoad_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__specialNPCIdToLoad_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__specialNPCIdToLoad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544D RID: 21581
			// (get) Token: 0x0601020C RID: 66060 RVA: 0x003C36BC File Offset: 0x003C18BC
			// (set) Token: 0x0601020D RID: 66061 RVA: 0x0008C37A File Offset: 0x0008A57A
			public unsafe Il2CppReferenceArray<UniTask<IAssetHandleArray<Sprite>>> _loadHandles_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadHandles_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniTask<IAssetHandleArray<Sprite>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadHandles_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544E RID: 21582
			// (get) Token: 0x0601020E RID: 66062 RVA: 0x003C36EC File Offset: 0x003C18EC
			// (set) Token: 0x0601020F RID: 66063 RVA: 0x0008C399 File Offset: 0x0008A599
			public unsafe Il2CppReferenceArray<DialogMeta> _overrideSpritesMeta_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__overrideSpritesMeta_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogMeta>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__overrideSpritesMeta_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700544F RID: 21583
			// (get) Token: 0x06010210 RID: 66064 RVA: 0x003C371C File Offset: 0x003C191C
			// (set) Token: 0x06010211 RID: 66065 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
			public unsafe Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>> _dialogMetaLoadTask_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__dialogMetaLoadTask_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__dialogMetaLoadTask_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005450 RID: 21584
			// (get) Token: 0x06010212 RID: 66066 RVA: 0x003C374C File Offset: 0x003C194C
			// (set) Token: 0x06010213 RID: 66067 RVA: 0x0008C3D7 File Offset: 0x0008A5D7
			public unsafe Il2CppReferenceArray<IAssetHandleArray<Sprite>> _loadedSpecialGuestPortrayalsCollection_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedSpecialGuestPortrayalsCollection_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAssetHandleArray<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedSpecialGuestPortrayalsCollection_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005451 RID: 21585
			// (get) Token: 0x06010214 RID: 66068 RVA: 0x003C377C File Offset: 0x003C197C
			// (set) Token: 0x06010215 RID: 66069 RVA: 0x0008C3F6 File Offset: 0x0008A5F6
			public unsafe Dictionary<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>> _loadedDialogMetaDictionary_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedDialogMetaDictionary_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__loadedDialogMetaDictionary_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005452 RID: 21586
			// (get) Token: 0x06010216 RID: 66070 RVA: 0x003C37AC File Offset: 0x003C19AC
			// (set) Token: 0x06010217 RID: 66071 RVA: 0x0008C415 File Offset: 0x0008A615
			public UniTask<IAssetHandle<TextAsset>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<TextAsset>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<TextAsset>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<TextAsset>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005453 RID: 21587
			// (get) Token: 0x06010218 RID: 66072 RVA: 0x003C37DC File Offset: 0x003C19DC
			// (set) Token: 0x06010219 RID: 66073 RVA: 0x0008C443 File Offset: 0x0008A643
			public UniTask<IAssetHandleArray<Sprite>>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__2);
					return new UniTask<IAssetHandleArray<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandleArray<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandleArray<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005454 RID: 21588
			// (get) Token: 0x0601021A RID: 66074 RVA: 0x003C380C File Offset: 0x003C1A0C
			// (set) Token: 0x0601021B RID: 66075 RVA: 0x0008C471 File Offset: 0x0008A671
			public UniTask<Il2CppReferenceArray<IAssetHandleArray<Sprite>>>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__3);
					return new UniTask<Il2CppReferenceArray<IAssetHandleArray<Sprite>>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandleArray<Sprite>>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandleArray<Sprite>>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005455 RID: 21589
			// (get) Token: 0x0601021C RID: 66076 RVA: 0x003C383C File Offset: 0x003C1A3C
			// (set) Token: 0x0601021D RID: 66077 RVA: 0x0008C49F File Offset: 0x0008A69F
			public UniTask<Il2CppReferenceArray<IAssetHandle<Sprite>>>.Awaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__4);
					return new UniTask<Il2CppReferenceArray<IAssetHandle<Sprite>>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandle<Sprite>>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<IAssetHandle<Sprite>>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005456 RID: 21590
			// (get) Token: 0x0601021E RID: 66078 RVA: 0x003C386C File Offset: 0x003C1A6C
			// (set) Token: 0x0601021F RID: 66079 RVA: 0x0008C4CD File Offset: 0x0008A6CD
			public Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap8);
					return new Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<DialogMeta, Il2CppReferenceArray<UniTask<LoadedDialogActionData>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005457 RID: 21591
			// (get) Token: 0x06010220 RID: 66080 RVA: 0x003C389C File Offset: 0x003C1A9C
			// (set) Token: 0x06010221 RID: 66081 RVA: 0x0008C4FB File Offset: 0x0008A6FB
			public unsafe Dictionary<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005458 RID: 21592
			// (get) Token: 0x06010222 RID: 66082 RVA: 0x003C38CC File Offset: 0x003C1ACC
			// (set) Token: 0x06010223 RID: 66083 RVA: 0x0008C51A File Offset: 0x0008A71A
			public DialogMeta __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap10);
					return new DialogMeta(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___7__wrap10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005459 RID: 21593
			// (get) Token: 0x06010224 RID: 66084 RVA: 0x003C38FC File Offset: 0x003C1AFC
			// (set) Token: 0x06010225 RID: 66085 RVA: 0x0008C548 File Offset: 0x0008A748
			public UniTask<Il2CppReferenceArray<LoadedDialogActionData>>.Awaiter __u__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__5);
					return new UniTask<Il2CppReferenceArray<LoadedDialogActionData>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<LoadedDialogActionData>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<Il2CppReferenceArray<LoadedDialogActionData>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700545A RID: 21594
			// (get) Token: 0x06010226 RID: 66086 RVA: 0x003C392C File Offset: 0x003C1B2C
			// (set) Token: 0x06010227 RID: 66087 RVA: 0x0008C576 File Offset: 0x0008A776
			public unsafe ManualDialogPannelOpenContext _manualContext_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__manualContext_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualDialogPannelOpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr__manualContext_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700545B RID: 21595
			// (get) Token: 0x06010228 RID: 66088 RVA: 0x003C395C File Offset: 0x003C1B5C
			// (set) Token: 0x06010229 RID: 66089 RVA: 0x0008C595 File Offset: 0x0008A795
			public UniTask.Awaiter __u__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__6);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnPanelOpenAsync_d__111.NativeFieldInfoPtr___u__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A3AE RID: 41902
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A3AF RID: 41903
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A3B0 RID: 41904
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3B1 RID: 41905
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A3B2 RID: 41906
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__2;

			// Token: 0x0400A3B3 RID: 41907
			private static readonly IntPtr NativeFieldInfoPtr__specialNPCIdToLoad_5__3;

			// Token: 0x0400A3B4 RID: 41908
			private static readonly IntPtr NativeFieldInfoPtr__loadHandles_5__4;

			// Token: 0x0400A3B5 RID: 41909
			private static readonly IntPtr NativeFieldInfoPtr__overrideSpritesMeta_5__5;

			// Token: 0x0400A3B6 RID: 41910
			private static readonly IntPtr NativeFieldInfoPtr__dialogMetaLoadTask_5__6;

			// Token: 0x0400A3B7 RID: 41911
			private static readonly IntPtr NativeFieldInfoPtr__loadedSpecialGuestPortrayalsCollection_5__7;

			// Token: 0x0400A3B8 RID: 41912
			private static readonly IntPtr NativeFieldInfoPtr__loadedDialogMetaDictionary_5__8;

			// Token: 0x0400A3B9 RID: 41913
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A3BA RID: 41914
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400A3BB RID: 41915
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400A3BC RID: 41916
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x0400A3BD RID: 41917
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x0400A3BE RID: 41918
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x0400A3BF RID: 41919
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x0400A3C0 RID: 41920
			private static readonly IntPtr NativeFieldInfoPtr___u__5;

			// Token: 0x0400A3C1 RID: 41921
			private static readonly IntPtr NativeFieldInfoPtr__manualContext_5__12;

			// Token: 0x0400A3C2 RID: 41922
			private static readonly IntPtr NativeFieldInfoPtr___u__6;

			// Token: 0x0400A3C3 RID: 41923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3C4 RID: 41924
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000DF8 RID: 3576
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<OnExecutingDialogLoopInternal>d__112")]
		public sealed class _OnExecutingDialogLoopInternal_d__112 : Il2CppSystem.Object
		{
			// Token: 0x0601022A RID: 66090 RVA: 0x003C398C File Offset: 0x003C1B8C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnExecutingDialogLoopInternal_d__112()
			{
				Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<OnExecutingDialogLoopInternal>d__112");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "<>1__state");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "<>2__current");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "<>4__this");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_blackBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "blackBG");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_onCanExecuteFirstLineCalllback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "onCanExecuteFirstLineCalllback");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_dialogPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "dialogPack");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_textFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "textFile");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_playerPortrayalCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "playerPortrayalCollection");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "specialNPCPortrayalCollectionDictionary");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_overrideDialogMetaToSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, "overrideDialogMetaToSprites");
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684179);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684180);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684181);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684182);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684183);
				DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr, 100684184);
			}

			// Token: 0x0601022B RID: 66091 RVA: 0x003C3AF8 File Offset: 0x003C1CF8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnExecutingDialogLoopInternal_d__112(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopInternal_d__112>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601022C RID: 66092 RVA: 0x003C3B40 File Offset: 0x003C1D40
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601022D RID: 66093 RVA: 0x003C3B74 File Offset: 0x003C1D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256186, XrefRangeEnd = 256191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005466 RID: 21606
			// (get) Token: 0x0601022E RID: 66094 RVA: 0x003C3BB0 File Offset: 0x003C1DB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601022F RID: 66095 RVA: 0x003C3BF0 File Offset: 0x003C1DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256191, XrefRangeEnd = 256197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005467 RID: 21607
			// (get) Token: 0x06010230 RID: 66096 RVA: 0x003C3C24 File Offset: 0x003C1E24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010231 RID: 66097 RVA: 0x0008C5C3 File Offset: 0x0008A7C3
			public _OnExecutingDialogLoopInternal_d__112(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700545C RID: 21596
			// (get) Token: 0x06010232 RID: 66098 RVA: 0x003C3C64 File Offset: 0x003C1E64
			// (set) Token: 0x06010233 RID: 66099 RVA: 0x0008C5CC File Offset: 0x0008A7CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700545D RID: 21597
			// (get) Token: 0x06010234 RID: 66100 RVA: 0x003C3C8C File Offset: 0x003C1E8C
			// (set) Token: 0x06010235 RID: 66101 RVA: 0x0008C5E7 File Offset: 0x0008A7E7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700545E RID: 21598
			// (get) Token: 0x06010236 RID: 66102 RVA: 0x003C3CBC File Offset: 0x003C1EBC
			// (set) Token: 0x06010237 RID: 66103 RVA: 0x0008C606 File Offset: 0x0008A806
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700545F RID: 21599
			// (get) Token: 0x06010238 RID: 66104 RVA: 0x003C3CEC File Offset: 0x003C1EEC
			// (set) Token: 0x06010239 RID: 66105 RVA: 0x0008C625 File Offset: 0x0008A825
			public unsafe bool blackBG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_blackBG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_blackBG)) = value;
				}
			}

			// Token: 0x17005460 RID: 21600
			// (get) Token: 0x0601023A RID: 66106 RVA: 0x003C3D14 File Offset: 0x003C1F14
			// (set) Token: 0x0601023B RID: 66107 RVA: 0x0008C640 File Offset: 0x0008A840
			public unsafe Func<bool> onCanExecuteFirstLineCalllback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_onCanExecuteFirstLineCalllback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_onCanExecuteFirstLineCalllback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005461 RID: 21601
			// (get) Token: 0x0601023C RID: 66108 RVA: 0x003C3D44 File Offset: 0x003C1F44
			// (set) Token: 0x0601023D RID: 66109 RVA: 0x0008C65F File Offset: 0x0008A85F
			public unsafe IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>> dialogPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_dialogPack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_dialogPack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005462 RID: 21602
			// (get) Token: 0x0601023E RID: 66110 RVA: 0x003C3D74 File Offset: 0x003C1F74
			// (set) Token: 0x0601023F RID: 66111 RVA: 0x0008C67E File Offset: 0x0008A87E
			public unsafe IReadOnlyDictionary<int, string> textFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_textFile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_textFile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005463 RID: 21603
			// (get) Token: 0x06010240 RID: 66112 RVA: 0x003C3DA4 File Offset: 0x003C1FA4
			// (set) Token: 0x06010241 RID: 66113 RVA: 0x0008C69D File Offset: 0x0008A89D
			public unsafe IAssetHandleArray<Sprite> playerPortrayalCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_playerPortrayalCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandleArray<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_playerPortrayalCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005464 RID: 21604
			// (get) Token: 0x06010242 RID: 66114 RVA: 0x003C3DD4 File Offset: 0x003C1FD4
			// (set) Token: 0x06010243 RID: 66115 RVA: 0x0008C6BC File Offset: 0x0008A8BC
			public unsafe IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, IAssetHandleArray<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005465 RID: 21605
			// (get) Token: 0x06010244 RID: 66116 RVA: 0x003C3E04 File Offset: 0x003C2004
			// (set) Token: 0x06010245 RID: 66117 RVA: 0x0008C6DB File Offset: 0x0008A8DB
			public unsafe IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_overrideDialogMetaToSprites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopInternal_d__112.NativeFieldInfoPtr_overrideDialogMetaToSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3C5 RID: 41925
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A3C6 RID: 41926
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A3C7 RID: 41927
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3C8 RID: 41928
			private static readonly IntPtr NativeFieldInfoPtr_blackBG;

			// Token: 0x0400A3C9 RID: 41929
			private static readonly IntPtr NativeFieldInfoPtr_onCanExecuteFirstLineCalllback;

			// Token: 0x0400A3CA RID: 41930
			private static readonly IntPtr NativeFieldInfoPtr_dialogPack;

			// Token: 0x0400A3CB RID: 41931
			private static readonly IntPtr NativeFieldInfoPtr_textFile;

			// Token: 0x0400A3CC RID: 41932
			private static readonly IntPtr NativeFieldInfoPtr_playerPortrayalCollection;

			// Token: 0x0400A3CD RID: 41933
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary;

			// Token: 0x0400A3CE RID: 41934
			private static readonly IntPtr NativeFieldInfoPtr_overrideDialogMetaToSprites;

			// Token: 0x0400A3CF RID: 41935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A3D0 RID: 41936
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3D1 RID: 41937
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A3D2 RID: 41938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A3D3 RID: 41939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3D4 RID: 41940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DF9 RID: 3577
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass113_0")]
		public sealed class __c__DisplayClass113_0 : Il2CppSystem.Object
		{
			// Token: 0x06010246 RID: 66118 RVA: 0x003C3E34 File Offset: 0x003C2034
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass113_0()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass113_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr);
				DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr_textFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr, "textFile");
				DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr, "<>4__this");
				DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr, "<>9__3");
				DialogPannel.__c__DisplayClass113_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr, 100684185);
				DialogPannel.__c__DisplayClass113_0.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr, 100684186);
			}

			// Token: 0x06010247 RID: 66119 RVA: 0x003C3EC4 File Offset: 0x003C20C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass113_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010248 RID: 66120 RVA: 0x003C3F00 File Offset: 0x003C2100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256197, XrefRangeEnd = 256202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnExecutingDialogLoopCore_b__3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_0.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010249 RID: 66121 RVA: 0x0008C6FA File Offset: 0x0008A8FA
			public __c__DisplayClass113_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005468 RID: 21608
			// (get) Token: 0x0601024A RID: 66122 RVA: 0x003C3F44 File Offset: 0x003C2144
			// (set) Token: 0x0601024B RID: 66123 RVA: 0x0008C703 File Offset: 0x0008A903
			public unsafe IReadOnlyDictionary<int, string> textFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr_textFile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr_textFile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005469 RID: 21609
			// (get) Token: 0x0601024C RID: 66124 RVA: 0x003C3F74 File Offset: 0x003C2174
			// (set) Token: 0x0601024D RID: 66125 RVA: 0x0008C722 File Offset: 0x0008A922
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700546A RID: 21610
			// (get) Token: 0x0601024E RID: 66126 RVA: 0x003C3FA4 File Offset: 0x003C21A4
			// (set) Token: 0x0601024F RID: 66127 RVA: 0x0008C741 File Offset: 0x0008A941
			public unsafe Func<int, string> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3D5 RID: 41941
			private static readonly IntPtr NativeFieldInfoPtr_textFile;

			// Token: 0x0400A3D6 RID: 41942
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3D7 RID: 41943
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400A3D8 RID: 41944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3D9 RID: 41945
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__3_Internal_String_Int32_0;
		}

		// Token: 0x02000DFA RID: 3578
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass113_1")]
		public sealed class __c__DisplayClass113_1 : Il2CppSystem.Object
		{
			// Token: 0x06010250 RID: 66128 RVA: 0x003C3FD4 File Offset: 0x003C21D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass113_1()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass113_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr);
				DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr, "i");
				DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_field_Public___c__DisplayClass113_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr, "CS$<>8__locals1");
				DialogPannel.__c__DisplayClass113_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr, 100684187);
			}

			// Token: 0x06010251 RID: 66129 RVA: 0x003C403C File Offset: 0x003C223C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass113_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010252 RID: 66130 RVA: 0x0008C760 File Offset: 0x0008A960
			public __c__DisplayClass113_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700546B RID: 21611
			// (get) Token: 0x06010253 RID: 66131 RVA: 0x003C4078 File Offset: 0x003C2278
			// (set) Token: 0x06010254 RID: 66132 RVA: 0x0008C769 File Offset: 0x0008A969
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700546C RID: 21612
			// (get) Token: 0x06010255 RID: 66133 RVA: 0x003C40A0 File Offset: 0x003C22A0
			// (set) Token: 0x06010256 RID: 66134 RVA: 0x0008C784 File Offset: 0x0008A984
			public unsafe DialogPannel.__c__DisplayClass113_0 field_Public___c__DisplayClass113_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_field_Public___c__DisplayClass113_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass113_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_1.NativeFieldInfoPtr_field_Public___c__DisplayClass113_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3DA RID: 41946
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400A3DB RID: 41947
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass113_0_0;

			// Token: 0x0400A3DC RID: 41948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000DFB RID: 3579
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass113_2")]
		public sealed class __c__DisplayClass113_2 : Il2CppSystem.Object
		{
			// Token: 0x06010257 RID: 66135 RVA: 0x003C40D0 File Offset: 0x003C22D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass113_2()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass113_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr);
				DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_currentFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, "currentFund");
				DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_hasSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, "hasSelected");
				DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_field_Public___c__DisplayClass113_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, "CS$<>8__locals2");
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684188);
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__6_Internal_Boolean_ValueTuple_3_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684189);
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_KeyValuePair_2_String_ValueTuple_2_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684190);
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__10_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684191);
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684192);
				DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__12_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr, 100684193);
			}

			// Token: 0x06010258 RID: 66136 RVA: 0x003C41B0 File Offset: 0x003C23B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass113_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010259 RID: 66137 RVA: 0x003C41EC File Offset: 0x003C23EC
			[CallerCount(0)]
			public unsafe bool _OnExecutingDialogLoopCore_b__6(ValueTuple<string, int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__6_Internal_Boolean_ValueTuple_3_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601025A RID: 66138 RVA: 0x003C4240 File Offset: 0x003C2440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256202, XrefRangeEnd = 256229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIButtonSimple_KeyValuePair_2_String_ValueTuple_2_Int32_Int32_PDM_0(UIButtonSimple interactableBase, KeyValuePair<string, ValueTuple<int, int>> selection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interactableBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selection));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_KeyValuePair_2_String_ValueTuple_2_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601025B RID: 66139 RVA: 0x003C429C File Offset: 0x003C249C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnExecutingDialogLoopCore_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__10_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601025C RID: 66140 RVA: 0x003C42D8 File Offset: 0x003C24D8
			[CallerCount(0)]
			public unsafe void _OnExecutingDialogLoopCore_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601025D RID: 66141 RVA: 0x003C430C File Offset: 0x003C250C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnExecutingDialogLoopCore_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_2.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__12_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601025E RID: 66142 RVA: 0x0008C7A3 File Offset: 0x0008A9A3
			public __c__DisplayClass113_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700546D RID: 21613
			// (get) Token: 0x0601025F RID: 66143 RVA: 0x003C4348 File Offset: 0x003C2548
			// (set) Token: 0x06010260 RID: 66144 RVA: 0x0008C7AC File Offset: 0x0008A9AC
			public unsafe long currentFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_currentFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_currentFund)) = value;
				}
			}

			// Token: 0x1700546E RID: 21614
			// (get) Token: 0x06010261 RID: 66145 RVA: 0x003C4370 File Offset: 0x003C2570
			// (set) Token: 0x06010262 RID: 66146 RVA: 0x0008C7C7 File Offset: 0x0008A9C7
			public unsafe bool hasSelected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_hasSelected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_hasSelected)) = value;
				}
			}

			// Token: 0x1700546F RID: 21615
			// (get) Token: 0x06010263 RID: 66147 RVA: 0x003C4398 File Offset: 0x003C2598
			// (set) Token: 0x06010264 RID: 66148 RVA: 0x0008C7E2 File Offset: 0x0008A9E2
			public unsafe DialogPannel.__c__DisplayClass113_1 field_Public___c__DisplayClass113_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_field_Public___c__DisplayClass113_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass113_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_2.NativeFieldInfoPtr_field_Public___c__DisplayClass113_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3DD RID: 41949
			private static readonly IntPtr NativeFieldInfoPtr_currentFund;

			// Token: 0x0400A3DE RID: 41950
			private static readonly IntPtr NativeFieldInfoPtr_hasSelected;

			// Token: 0x0400A3DF RID: 41951
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass113_1_0;

			// Token: 0x0400A3E0 RID: 41952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3E1 RID: 41953
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__6_Internal_Boolean_ValueTuple_3_String_Int32_Int32_0;

			// Token: 0x0400A3E2 RID: 41954
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_KeyValuePair_2_String_ValueTuple_2_Int32_Int32_PDM_0;

			// Token: 0x0400A3E3 RID: 41955
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__10_Internal_Boolean_0;

			// Token: 0x0400A3E4 RID: 41956
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__11_Internal_Void_0;

			// Token: 0x0400A3E5 RID: 41957
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__12_Internal_Boolean_0;
		}

		// Token: 0x02000DFC RID: 3580
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass113_3")]
		public sealed class __c__DisplayClass113_3 : Il2CppSystem.Object
		{
			// Token: 0x06010265 RID: 66149 RVA: 0x003C43C8 File Offset: 0x003C25C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass113_3()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass113_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr);
				DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_currentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, "currentSelection");
				DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_interactableBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, "interactableBase");
				DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, "selection");
				DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_field_Public___c__DisplayClass113_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, "CS$<>8__locals3");
				DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, 100684194);
				DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, 100684195);
				DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__14_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr, 100684196);
			}

			// Token: 0x06010266 RID: 66150 RVA: 0x003C4480 File Offset: 0x003C2680
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass113_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass113_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010267 RID: 66151 RVA: 0x003C44BC File Offset: 0x003C26BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256229, XrefRangeEnd = 256236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010268 RID: 66152 RVA: 0x003C44F0 File Offset: 0x003C26F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256236, XrefRangeEnd = 256238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnExecutingDialogLoopCore_b__14(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass113_3.NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__14_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010269 RID: 66153 RVA: 0x0008C801 File Offset: 0x0008AA01
			public __c__DisplayClass113_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005470 RID: 21616
			// (get) Token: 0x0601026A RID: 66154 RVA: 0x003C4534 File Offset: 0x003C2734
			// (set) Token: 0x0601026B RID: 66155 RVA: 0x0008C80A File Offset: 0x0008AA0A
			public KeyValuePair<string, ValueTuple<int, int>> currentSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_currentSelection);
					return new KeyValuePair<string, ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, ValueTuple<int, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_currentSelection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, ValueTuple<int, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005471 RID: 21617
			// (get) Token: 0x0601026C RID: 66156 RVA: 0x003C4564 File Offset: 0x003C2764
			// (set) Token: 0x0601026D RID: 66157 RVA: 0x0008C838 File Offset: 0x0008AA38
			public unsafe UIButtonSimple interactableBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_interactableBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_interactableBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005472 RID: 21618
			// (get) Token: 0x0601026E RID: 66158 RVA: 0x003C4594 File Offset: 0x003C2794
			// (set) Token: 0x0601026F RID: 66159 RVA: 0x0008C857 File Offset: 0x0008AA57
			public KeyValuePair<string, ValueTuple<int, int>> selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_selection);
					return new KeyValuePair<string, ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, ValueTuple<int, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_selection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, ValueTuple<int, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005473 RID: 21619
			// (get) Token: 0x06010270 RID: 66160 RVA: 0x003C45C4 File Offset: 0x003C27C4
			// (set) Token: 0x06010271 RID: 66161 RVA: 0x0008C885 File Offset: 0x0008AA85
			public unsafe DialogPannel.__c__DisplayClass113_2 field_Public___c__DisplayClass113_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_field_Public___c__DisplayClass113_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass113_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass113_3.NativeFieldInfoPtr_field_Public___c__DisplayClass113_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3E6 RID: 41958
			private static readonly IntPtr NativeFieldInfoPtr_currentSelection;

			// Token: 0x0400A3E7 RID: 41959
			private static readonly IntPtr NativeFieldInfoPtr_interactableBase;

			// Token: 0x0400A3E8 RID: 41960
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x0400A3E9 RID: 41961
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass113_2_0;

			// Token: 0x0400A3EA RID: 41962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3EB RID: 41963
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A3EC RID: 41964
			private static readonly IntPtr NativeMethodInfoPtr__OnExecutingDialogLoopCore_b__14_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000DFD RID: 3581
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<OnExecutingDialogLoopCore>d__113")]
		public sealed class _OnExecutingDialogLoopCore_d__113 : Il2CppSystem.Object
		{
			// Token: 0x06010272 RID: 66162 RVA: 0x003C45F4 File Offset: 0x003C27F4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnExecutingDialogLoopCore_d__113()
			{
				Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<OnExecutingDialogLoopCore>d__113");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<>1__state");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<>2__current");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_textFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "textFile");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<>4__this");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_dialogPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "dialogPack");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<>8__1");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_playerPortrayalCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "playerPortrayalCollection");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "specialNPCPortrayalCollectionDictionary");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_overrideDialogMetaToSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "overrideDialogMetaToSprites");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<>8__2");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__loadedDialogActionDataCollection_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<loadedDialogActionDataCollection>5__2");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__selectedAction_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, "<selectedAction>5__3");
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684197);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684198);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684199);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684200);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684201);
				DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr, 100684202);
			}

			// Token: 0x06010273 RID: 66163 RVA: 0x003C4788 File Offset: 0x003C2988
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnExecutingDialogLoopCore_d__113(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel._OnExecutingDialogLoopCore_d__113>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010274 RID: 66164 RVA: 0x003C47D0 File Offset: 0x003C29D0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010275 RID: 66165 RVA: 0x003C4804 File Offset: 0x003C2A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256238, XrefRangeEnd = 256305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005480 RID: 21632
			// (get) Token: 0x06010276 RID: 66166 RVA: 0x003C4840 File Offset: 0x003C2A40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010277 RID: 66167 RVA: 0x003C4880 File Offset: 0x003C2A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256305, XrefRangeEnd = 256311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005481 RID: 21633
			// (get) Token: 0x06010278 RID: 66168 RVA: 0x003C48B4 File Offset: 0x003C2AB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010279 RID: 66169 RVA: 0x0008C8A4 File Offset: 0x0008AAA4
			public _OnExecutingDialogLoopCore_d__113(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005474 RID: 21620
			// (get) Token: 0x0601027A RID: 66170 RVA: 0x003C48F4 File Offset: 0x003C2AF4
			// (set) Token: 0x0601027B RID: 66171 RVA: 0x0008C8AD File Offset: 0x0008AAAD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005475 RID: 21621
			// (get) Token: 0x0601027C RID: 66172 RVA: 0x003C491C File Offset: 0x003C2B1C
			// (set) Token: 0x0601027D RID: 66173 RVA: 0x0008C8C8 File Offset: 0x0008AAC8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005476 RID: 21622
			// (get) Token: 0x0601027E RID: 66174 RVA: 0x003C494C File Offset: 0x003C2B4C
			// (set) Token: 0x0601027F RID: 66175 RVA: 0x0008C8E7 File Offset: 0x0008AAE7
			public unsafe IReadOnlyDictionary<int, string> textFile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_textFile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_textFile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005477 RID: 21623
			// (get) Token: 0x06010280 RID: 66176 RVA: 0x003C497C File Offset: 0x003C2B7C
			// (set) Token: 0x06010281 RID: 66177 RVA: 0x0008C906 File Offset: 0x0008AB06
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005478 RID: 21624
			// (get) Token: 0x06010282 RID: 66178 RVA: 0x003C49AC File Offset: 0x003C2BAC
			// (set) Token: 0x06010283 RID: 66179 RVA: 0x0008C925 File Offset: 0x0008AB25
			public unsafe IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>> dialogPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_dialogPack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, Il2CppReferenceArray<LoadedDialogActionData>>, string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_dialogPack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005479 RID: 21625
			// (get) Token: 0x06010284 RID: 66180 RVA: 0x003C49DC File Offset: 0x003C2BDC
			// (set) Token: 0x06010285 RID: 66181 RVA: 0x0008C944 File Offset: 0x0008AB44
			public unsafe DialogPannel.__c__DisplayClass113_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass113_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547A RID: 21626
			// (get) Token: 0x06010286 RID: 66182 RVA: 0x003C4A0C File Offset: 0x003C2C0C
			// (set) Token: 0x06010287 RID: 66183 RVA: 0x0008C963 File Offset: 0x0008AB63
			public unsafe IAssetHandleArray<Sprite> playerPortrayalCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_playerPortrayalCollection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandleArray<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_playerPortrayalCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547B RID: 21627
			// (get) Token: 0x06010288 RID: 66184 RVA: 0x003C4A3C File Offset: 0x003C2C3C
			// (set) Token: 0x06010289 RID: 66185 RVA: 0x0008C982 File Offset: 0x0008AB82
			public unsafe IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<int, IAssetHandleArray<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547C RID: 21628
			// (get) Token: 0x0601028A RID: 66186 RVA: 0x003C4A6C File Offset: 0x003C2C6C
			// (set) Token: 0x0601028B RID: 66187 RVA: 0x0008C9A1 File Offset: 0x0008ABA1
			public unsafe IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_overrideDialogMetaToSprites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr_overrideDialogMetaToSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547D RID: 21629
			// (get) Token: 0x0601028C RID: 66188 RVA: 0x003C4A9C File Offset: 0x003C2C9C
			// (set) Token: 0x0601028D RID: 66189 RVA: 0x0008C9C0 File Offset: 0x0008ABC0
			public unsafe DialogPannel.__c__DisplayClass113_2 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel.__c__DisplayClass113_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547E RID: 21630
			// (get) Token: 0x0601028E RID: 66190 RVA: 0x003C4ACC File Offset: 0x003C2CCC
			// (set) Token: 0x0601028F RID: 66191 RVA: 0x0008C9DF File Offset: 0x0008ABDF
			public unsafe Il2CppReferenceArray<LoadedDialogActionData> _loadedDialogActionDataCollection_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__loadedDialogActionDataCollection_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoadedDialogActionData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__loadedDialogActionDataCollection_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700547F RID: 21631
			// (get) Token: 0x06010290 RID: 66192 RVA: 0x003C4AFC File Offset: 0x003C2CFC
			// (set) Token: 0x06010291 RID: 66193 RVA: 0x0008C9FE File Offset: 0x0008ABFE
			public unsafe LoadedDialogActionData _selectedAction_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__selectedAction_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadedDialogActionData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel._OnExecutingDialogLoopCore_d__113.NativeFieldInfoPtr__selectedAction_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3ED RID: 41965
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A3EE RID: 41966
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A3EF RID: 41967
			private static readonly IntPtr NativeFieldInfoPtr_textFile;

			// Token: 0x0400A3F0 RID: 41968
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3F1 RID: 41969
			private static readonly IntPtr NativeFieldInfoPtr_dialogPack;

			// Token: 0x0400A3F2 RID: 41970
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A3F3 RID: 41971
			private static readonly IntPtr NativeFieldInfoPtr_playerPortrayalCollection;

			// Token: 0x0400A3F4 RID: 41972
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCPortrayalCollectionDictionary;

			// Token: 0x0400A3F5 RID: 41973
			private static readonly IntPtr NativeFieldInfoPtr_overrideDialogMetaToSprites;

			// Token: 0x0400A3F6 RID: 41974
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x0400A3F7 RID: 41975
			private static readonly IntPtr NativeFieldInfoPtr__loadedDialogActionDataCollection_5__2;

			// Token: 0x0400A3F8 RID: 41976
			private static readonly IntPtr NativeFieldInfoPtr__selectedAction_5__3;

			// Token: 0x0400A3F9 RID: 41977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A3FA RID: 41978
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3FB RID: 41979
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A3FC RID: 41980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A3FD RID: 41981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3FE RID: 41982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DFE RID: 3582
		[ObfuscatedName("Common.DialogUtility.DialogPannel+<>c__DisplayClass114_0")]
		public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
		{
			// Token: 0x06010292 RID: 66194 RVA: 0x003C4B2C File Offset: 0x003C2D2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass114_0()
			{
				Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPannel>.NativeClassPtr, "<>c__DisplayClass114_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr);
				DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, "<>4__this");
				DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr_metatElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, "metatElement");
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684203);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr_Method_Internal_Void_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684204);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr_Method_Internal_Void_Position_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684205);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684206);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__3_Internal_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684207);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__4_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684208);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__5_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684209);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__6_Internal_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684210);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__7_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684211);
				DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__8_Internal_Boolean_KeyValuePair_2_ValueTuple_2_Identity_Int32_Position_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr, 100684212);
			}

			// Token: 0x06010293 RID: 66195 RVA: 0x003C4C48 File Offset: 0x003C2E48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass114_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPannel.__c__DisplayClass114_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010294 RID: 66196 RVA: 0x003C4C84 File Offset: 0x003C2E84
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256313, RefRangeEnd = 256315, XrefRangeStart = 256311, XrefRangeEnd = 256313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Position_0(Position position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr_Method_Internal_Void_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010295 RID: 66197 RVA: 0x003C4CC4 File Offset: 0x003C2EC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 256316, RefRangeEnd = 256317, XrefRangeStart = 256315, XrefRangeEnd = 256316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Position_1(Position position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr_Method_Internal_Void_Position_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010296 RID: 66198 RVA: 0x003C4D04 File Offset: 0x003C2F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256317, XrefRangeEnd = 256319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__2_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010297 RID: 66199 RVA: 0x003C4D48 File Offset: 0x003C2F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256319, XrefRangeEnd = 256321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__3(Sprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__3_Internal_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010298 RID: 66200 RVA: 0x003C4D8C File Offset: 0x003C2F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256321, XrefRangeEnd = 256323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__4(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__4_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010299 RID: 66201 RVA: 0x003C4DCC File Offset: 0x003C2FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256323, XrefRangeEnd = 256325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__5(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__5_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601029A RID: 66202 RVA: 0x003C4E10 File Offset: 0x003C3010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256325, XrefRangeEnd = 256327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__6(Sprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__6_Internal_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601029B RID: 66203 RVA: 0x003C4E54 File Offset: 0x003C3054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256327, XrefRangeEnd = 256329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateMetaPresentation_b__7(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__7_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601029C RID: 66204 RVA: 0x003C4E94 File Offset: 0x003C3094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256329, XrefRangeEnd = 256330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateMetaPresentation_b__8(KeyValuePair<ValueTuple<SpeakerIdentity.Identity, int>, Position> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPannel.__c__DisplayClass114_0.NativeMethodInfoPtr__UpdateMetaPresentation_b__8_Internal_Boolean_KeyValuePair_2_ValueTuple_2_Identity_Int32_Position_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601029D RID: 66205 RVA: 0x0008CA1D File Offset: 0x0008AC1D
			public __c__DisplayClass114_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005482 RID: 21634
			// (get) Token: 0x0601029E RID: 66206 RVA: 0x003C4EE8 File Offset: 0x003C30E8
			// (set) Token: 0x0601029F RID: 66207 RVA: 0x0008CA26 File Offset: 0x0008AC26
			public unsafe DialogPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005483 RID: 21635
			// (get) Token: 0x060102A0 RID: 66208 RVA: 0x003C4F18 File Offset: 0x003C3118
			// (set) Token: 0x060102A1 RID: 66209 RVA: 0x0008CA45 File Offset: 0x0008AC45
			public DialogMeta metatElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr_metatElement);
					return new DialogMeta(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPannel.__c__DisplayClass114_0.NativeFieldInfoPtr_metatElement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A3FF RID: 41983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A400 RID: 41984
			private static readonly IntPtr NativeFieldInfoPtr_metatElement;

			// Token: 0x0400A401 RID: 41985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A402 RID: 41986
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Position_0;

			// Token: 0x0400A403 RID: 41987
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Position_1;

			// Token: 0x0400A404 RID: 41988
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__2_Internal_Void_String_0;

			// Token: 0x0400A405 RID: 41989
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__3_Internal_Void_Sprite_0;

			// Token: 0x0400A406 RID: 41990
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__4_Internal_Void_Boolean_0;

			// Token: 0x0400A407 RID: 41991
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__5_Internal_Void_String_0;

			// Token: 0x0400A408 RID: 41992
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__6_Internal_Void_Sprite_0;

			// Token: 0x0400A409 RID: 41993
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__7_Internal_Void_Boolean_0;

			// Token: 0x0400A40A RID: 41994
			private static readonly IntPtr NativeMethodInfoPtr__UpdateMetaPresentation_b__8_Internal_Boolean_KeyValuePair_2_ValueTuple_2_Identity_Int32_Position_0;
		}
	}
}
